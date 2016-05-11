//
// CustomLRUCache.cs
//
// Author:
//       Philippe Creytens <philippe@bazookas.be>
//
// Copyright (c) 2016 Philippe Creytens
using System;
using Android.Support.V4.Util;
using Android.Graphics;
using Java.Lang;
using Android.Widget;
using Android.Content.Res;
using System.Threading;
using Android.App;
using Java.IO;
using System.Collections.Generic;
using Bazookas.Kinepolis.BL.Interfaces;
using Bazookas.BL.Interfaces;
using Bazookas.Kinepolis.Adapters;

namespace Bazookas.Kinepolis.CustomControls
{
	public class CustomLRUCache : LruCache, IBitmapCache<Bitmap>
	{
		static int cacheSize = (int)((Runtime.GetRuntime ().MaxMemory () / 1024) / 8);
		IDispatchOnUIThread UIThreadDispatcher = null;

		IDictionary<string, DecodeTask> _isBlurrRunning = new Dictionary<string, DecodeTask> ();
		IDictionary<string, DecodeTask> _isRunning = new Dictionary<string, DecodeTask> ();

		bool _canLoad = true;

		public CustomLRUCache (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}


		public CustomLRUCache () : base (cacheSize)
		{
			UIThreadDispatcher = new DispatchAdapter();
		}


		protected override int SizeOf (Java.Lang.Object key, Java.Lang.Object value)
		{
			return (value as Bitmap).ByteCount / 1024;
		}

		public void AddBitmapToMemoryCache (string key, Bitmap bitmap)
		{
			if (GetBitmapFromMemCache (key) == null) {
				Put (key, bitmap);
			}
		}

		public void RemoveBitmapFromMemCache (string key)
		{
			try {
				var bmp = GetBitmapFromMemCache (key);
				if (bmp != null) {
					Remove (key);

					try {
						lock (bmp) {
							if (bmp != null && !bmp.IsRecycled) {
								bmp.Recycle ();
								bmp.Dispose ();
							}
						}
						bmp = null;
						JavaSystem.Gc ();
					} catch (System.Exception ex) {
						BzLogging.SendException (ex, "REMOVE IMAGE FROM CACHE");
					}
				}
			} catch (System.Exception ex) {
				BzLogging.SendException (ex);
			}
		}

		public Bitmap GetBitmapFromMemCache (string key)
		{
			try {
				return Get (key) as Bitmap;
			} catch (System.Exception ex) {
				BzLogging.SendException (ex);
				return null;
			}
		}

		public void GenerateBitmap (string localLocation, string key, int width, int height, object imageView)
		{
			ImageView imgView = imageView as ImageView;
			if (imgView != null) {
				Bitmap bmp = GetBitmapFromMemCache (key);
				if (bmp == null) {
					DecodeTask task = new DecodeTask (localLocation, key, width, height, imageView as ImageView, (newKey, bmp2) => {
						AddBitmapToMemoryCache (newKey, bmp2);
						_isRunning.Remove (newKey);
					});
					if (!_isRunning.ContainsKey (key))
						_isRunning.Add (key, task);
					if (_canLoad) {
						task.IsRunning = true;
						task.Execute ();
					}
				} else {
					AppController.Instance.UIThreadDispatcher.Invoke (() => imgView.SetImageBitmap (bmp));
				}
			}
		}

		public void GenerateScaledAndBlurredBitmap (string localLocation, string key, int width, int height, IBitmapScaled imageView, int blurRadius)
		{
			if (imageView != null) {
				Bitmap bmp = GetBitmapFromMemCache (key);
				if (bmp == null) {
					DecodeTask task = new DecodeTask (localLocation, key, width, height, imageView, blurRadius, (newKey, bmp2) => {
						AddBitmapToMemoryCache (newKey, bmp2);
						_isBlurrRunning.Remove (key);
					});
					if (!_isBlurrRunning.ContainsKey (key))
						_isBlurrRunning.Add (key, task);
					if (_canLoad) {
						task.IsRunning = true;
						task.Execute ();
					}
				} else {
					AppController.Instance.UIThreadDispatcher.Invoke (() => (imageView as ImageView).SetImageBitmap (bmp));
				}
			}
		}

		public void CancelBitmap (string key)
		{
			if (!string.IsNullOrEmpty (key) && !key.StartsWith ("Blur")) {
				DecodeTask thread = null;
				_isBlurrRunning.TryGetValue (key, out thread);
				if (thread != null) {
					_isBlurrRunning.Remove (key);
					thread.Cancel (true);
					thread.Dispose ();
				}
				DecodeTask thread2 = null;
				_isRunning.TryGetValue (key, out thread2);
				if (thread2 != null) {
					_isRunning.Remove (key);
					thread2.Cancel (true);
					thread2.Dispose ();
				}
			}
		}

		public void ContinueLoading ()
		{
//			if (!_canLoad) {
//				_canLoad = true;
//				foreach (KeyValuePair<string, DecodeTask> pair in _isBlurrRunning) {
//					if (!pair.Value.IsRunning) {
//						pair.Value.IsRunning = true;
//						pair.Value.Execute ();
//					}
//				}
//				foreach (KeyValuePair<string, DecodeTask> pair in _isRunning) {
//					if (!pair.Value.IsRunning) {
//						pair.Value.IsRunning = true;
//						pair.Value.Execute ();
//					}
//				}
//			}
		}

		public void PauseLoading ()
		{
//			if (_canLoad) {
//				_canLoad = false;
//			}
		}
	}

	internal class DecodeTask : Android.OS.AsyncTask
	{
		#region variables

		string _localLocation = string.Empty;
		int _width = 0;
		int _height = 0;
		string _key;
		IBitmapScaled _blurrImageView;
		ImageView _imageView;
		Action<string, Bitmap> _finishedRunning;
		Bitmap _bmp;
		int _blurRadius = 25;
		bool _isBlurr;
		bool _successfullFinish = false;

		#endregion

		#region properties

		public bool IsRunning { get; set; }

		#endregion

		#region constructor

		public DecodeTask (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public DecodeTask (string localLocation, string key, int width, int height, IBitmapScaled imageView, Action<string, Bitmap> finishedRunning)
		{
			_successfullFinish = false;
			_isBlurr = true;
			_localLocation = localLocation;
			_key = key;
			_width = width;
			_height = height;
			_blurrImageView = imageView;
			_finishedRunning = finishedRunning;
		}

		public DecodeTask (string localLocation, string key, int width, int height, ImageView imageView, Action<string, Bitmap> finishedRunning)
		{
			_successfullFinish = false;
			_isBlurr = false;
			_localLocation = localLocation;
			_key = key;
			_width = width;
			_height = height;
			_imageView = imageView;
			_finishedRunning = finishedRunning;
		}

		public DecodeTask (string localLocation, string key, int width, int height, IBitmapScaled imageView, int blurRadius, Action<string, Bitmap> finishedRunning)
		{
			_successfullFinish = false;
			_isBlurr = true;
			_localLocation = localLocation;
			_key = key;
			_width = width;
			_height = height;
			_blurrImageView = imageView;
			_finishedRunning = finishedRunning;
			_blurRadius = blurRadius;
		}

		public DecodeTask (string localLocation, string key, int width, int height, ImageView imageView, int blurRadius, Action<string, Bitmap> finishedRunning)
		{
			_successfullFinish = false;
			_isBlurr = false;
			_localLocation = localLocation;
			_key = key;
			_width = width;
			_height = height;
			_imageView = imageView;
			_finishedRunning = finishedRunning;
			_blurRadius = blurRadius;
		}

		#endregion

		#region overriden methods

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (!_successfullFinish) {

				if (_bmp!=null) {
					lock (_bmp) {
						if (_bmp != null && !_bmp.IsRecycled) {
							_bmp.Recycle ();
							_bmp.Dispose ();
						}
					}
				}
				_bmp = null;
			}
		}

		protected override void OnPreExecute ()
		{
			base.OnPreExecute ();
		}

		protected override Java.Lang.Object DoInBackground (params Java.Lang.Object[] @params)
		{
			if (_isBlurr) {
				Bitmap sampledBitmap = null;
				Bitmap scaledBitmap = null;
				if (!checkIsCancelled ()) {
					sampledBitmap = decodeSampledBitmapFromFile (_localLocation, _width, _height);
				}
				try {
					if (!checkIsCancelled ()) {
						scaledBitmap = Bitmap.CreateScaledBitmap (sampledBitmap, _width, _height, true);
						if (sampledBitmap!=null) {
							lock (sampledBitmap) {
								if (sampledBitmap != null && !sampledBitmap.IsRecycled) {
									sampledBitmap.Recycle ();
									sampledBitmap.Dispose ();
								}
							}
							sampledBitmap = null;
						}
					}
					if (!checkIsCancelled ()) {
						_bmp = MyBitmapFactory.CreateBlurredImage (_blurRadius, scaledBitmap, Application.Context);
						if (scaledBitmap!=null) {
							lock (scaledBitmap) {
								if (scaledBitmap != null && !scaledBitmap.IsRecycled) {
									scaledBitmap.Recycle ();
									scaledBitmap.Dispose ();
								}
							}
							scaledBitmap = null;
						}
					}
					if (!checkIsCancelled ()) {
						_blurrImageView.BitmapScaledAndBlurred (_bmp);
					}
				} catch (System.Exception ex) {
					BzLogging.Log ("EXCEPTION");
					BzLogging.SendException (ex);
					GC.Collect ();
				}
			} else {
				if (!checkIsCancelled ()) {
					_bmp = decodeSampledBitmapFromFile (_localLocation, _width, _height);
				}
			}

			return true;
		}

		protected override void OnPostExecute (Java.Lang.Object result)
		{
			base.OnPostExecute (result);
			if (!checkIsCancelled ()) {
				if (_bmp != null && _isBlurr) {
					_finishedRunning (_key, _bmp);
					(_blurrImageView as ImageView).SetImageBitmap (_bmp);
				} else if (_bmp != null && !_isBlurr) {
					_finishedRunning (_key, _bmp);
					_imageView.SetImageBitmap (_bmp);
				}
				_successfullFinish = true;
			} else {
				if(_bmp != null && !_bmp.IsRecycled){
					lock(_bmp){
						_bmp.Recycle ();
						_bmp.Dispose ();
					}
				}
				_bmp = null;
			}
		}

		#endregion

		#region private methods

		bool checkIsCancelled ()
		{
			try {
				return IsCancelled;
			} catch (System.Exception ex) {
				BzLogging.SendException (ex);
			}
			return true;
		}

		Bitmap decodeSampledBitmapFromFile (string res, int reqWidth, int reqHeight, bool retryAfterGC = true)
		{
			try {
				// First decode with inJustDecodeBounds=true to check dimensions
				BitmapFactory.Options options = new BitmapFactory.Options ();
				options.InJustDecodeBounds = true;
				BitmapFactory.DecodeFile (res, options);

				// Calculate inSampleSize
				options.InSampleSize = calculateInSampleSize (options, reqWidth, reqHeight);

				// Decode bitmap with inSampleSize set
				options.InJustDecodeBounds = false;
				var returnVal = BitmapFactory.DecodeFile (new File (res).AbsolutePath, options);
				options.Dispose ();
				return returnVal;
			} catch (System.Exception ex) {
				if (retryAfterGC) {
					GC.Collect ();
					return decodeSampledBitmapFromFile (res, reqWidth, reqHeight, false);
				} else {
					BzLogging.SendException (ex);
					return null;
				}
			}
		}

		int calculateInSampleSize (BitmapFactory.Options options, int reqWidth, int reqHeight)
		{
			// Raw height and width of image
			int height = options.OutHeight;
			int width = options.OutWidth;
			int inSampleSize = 1;

			if (height > reqHeight || width > reqWidth) {

				int halfHeight = (int)(height * 0.5);
				int halfWidth = (int)(width * 0.5);

				// Calculate the largest inSampleSize value that is a power of 2 and keeps both
				// height and width larger than the requested height and width.
				while ((halfHeight / inSampleSize) > reqHeight
				       && (halfWidth / inSampleSize) > reqWidth) {
					inSampleSize *= 2;
				}
			}

			return inSampleSize;
		}

		#endregion
	}
}

