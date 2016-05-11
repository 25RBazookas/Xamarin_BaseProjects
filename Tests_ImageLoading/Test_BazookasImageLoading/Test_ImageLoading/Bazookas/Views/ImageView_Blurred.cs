// //
// //ImageView_Blurred.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
 //
 // Copyright (c) 2015 Robin Bruneel
using System;
using System.Text;
using Square.Picasso;
using Android.Widget;
using Bazookas.Utils;
using Android.Graphics;
using System.Threading.Tasks;
using Java.IO;
using Bazookas.Kinepolis.PicassoExtension;
using Bazookas.Kinepolis.BL.Interfaces;
using Android.Views;

namespace Bazookas.Kinepolis.Views.ImageViews
{
	/*
	 * XML
	 * Bazookas.Kinepolis.Views.ImageViews.ImageView_Blurred
	 */
	public class ImageView_Blurred: ImageView_Base, ITarget, IBitmapScaled
	{
		#region delegates

		#endregion

		#region variables
		bool _needsToBlurr = false;
		int width = 0;
		int height = 0;
		bool _drawAfterMeasureBlur = false;
		int _blurRadius = 25;
		#endregion

		#region properties

		public virtual int BlurRadius {
			get{ 
				return _blurRadius;
			} 
			set{ 
				_blurRadius = value;
			}
		}

		public override int QualityOfImage {
			get {
				return 50;
			}
			set {
				base.QualityOfImage = value;
			}
		}

		#endregion

		#region constructor
	
		public ImageView_Blurred (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}
		

		public ImageView_Blurred (Android.Content.Context context) : base (context)
		{
		}
		

		public ImageView_Blurred (Android.Content.Context context, Android.Util.IAttributeSet attrs) : base (context, attrs)
		{
		}
		

		public ImageView_Blurred (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr) : base (context, attrs, defStyleAttr)
		{
		}
		

		public ImageView_Blurred (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base (context, attrs, defStyleAttr, defStyleRes)
		{
		}
		
		#endregion

		protected override void Dispose (bool disposing)
		{
			if(_canDispose)
				(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).RemoveBitmapFromMemCache (_currentUrl + "Blur");
			_canDispose = false;
			base.Dispose (disposing);

		}
		#region public methods


		//USE THIS ONE IF YOU WANT TO BLUR RECYCLERVIEWCELLS
		public void LoadBlurredImage (string url, int width, int height,int blurFactor, PicassoCallBack listener = null)
		{
			this.listener = listener;
			this.width = width;
			this.height = height;
			this.SetImageBitmap (null);

			if (_currentUrl != url) {
				_drawAfterMeasureBlur = false;

				Bitmap bmp = (AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GetBitmapFromMemCache (url+"Blur");
				_currentUrl = url;
				if (bmp == null) {
					if (!string.IsNullOrEmpty (_currentUrl))
						(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).CancelBitmap (_currentUrl + "Blur");
					handleImageSave ();
				} else {
					IsLoading = false;
					SetImageBitmap (bmp);
					listener?.OnSuccess ();
				}
			}
		}

		public void LoadBlurredImage(string url, Func<Picasso, Android.Net.Uri, RequestCreator> request, PicassoCallBack listener = null){
			this.listener = listener;
			this.PicassoRequest = request;
			this.SetImageBitmap (null);
			_canDispose = true;
			if (_currentUrl != url) {
				_drawAfterMeasureBlur = false;
				//(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).CancelBitmap (_currentUrl + "Blur");
				_currentUrl = url;
				handleImageSave ();
			} else {
				IsLoading = false;
				listener?.OnSuccess ();
			}
		}

		public void CancelBitmap()
		{
			(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).CancelBitmap (_currentUrl+"Blur");
			_currentUrl = "";
		}

		public void OnBitmapLoaded (Android.Graphics.Bitmap p0, Picasso.LoadedFrom p1)
		{
			/*await Task.Run (() => {
				System.IO.FileStream str = null;
				try {
					string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
					System.IO.Directory.CreateDirectory (System.IO.Path.Combine (documentsPath, Constants_Android.FOLDER_BLUR));
					str = new System.IO.FileStream (_hashedUrl, System.IO.FileMode.OpenOrCreate);
					p0.Compress (Bitmap.CompressFormat.Jpeg, QualityOfImage, str);
					str.Flush ();
				} catch (Exception ex) {
					BzLogging.SendException (ex);
				} finally {
					if (str != null) {
						str.Close ();
						Java.IO.File file = new File (_hashedGeneralUrl);
						file.Delete ();
					}
				}
			});

			Android.Net.Uri hashedContentUri = Android.Net.Uri.FromFile (new File (_hashedUrl));
			BzLogging.Log (String.Format ("LOG: {0}", hashedContentUri));
			if (listener!=null) {
				Picasso.With (Context).Load (hashedContentUri).Into (this as ImageView, listener);
			} else {
				Picasso.With (Context).Load (hashedContentUri).Into (this as ImageView);
			}*/
		}

		public void BitmapScaledAndBlurred (object bitmap)
		{
			Bitmap bmp = bitmap as Bitmap;
			System.IO.FileStream str = null;
			try {
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
				System.IO.Directory.CreateDirectory (System.IO.Path.Combine (documentsPath, Constants_Android.FOLDER_BLUR));
				str = new System.IO.FileStream (_hashedUrl, System.IO.FileMode.OpenOrCreate);
				bmp.Compress (Bitmap.CompressFormat.Jpeg, QualityOfImage, str);
				str.Flush ();
			} catch (Exception ex) {
				BzLogging.SendException (ex);
			} finally {
				if (str != null) {
					str.Close ();
				}
			}
		}

		#region overided methods

		public override void ImageLoaded (string originalImageLocation, string localImageLocation, string imageName, string error)
		{
			IsLoading = false;
			if (string.IsNullOrEmpty (error)) {
				if (originalImageLocation == _currentUrl) {
						if (this.Width == 0) {
							this._predrawLocalUrl = localImageLocation; 
							this._predrawOriginalUrl = originalImageLocation;
							_drawAfterMeasure = true;
						} else {
							(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GenerateScaledAndBlurredBitmap (localImageLocation, originalImageLocation + "Blur", width,height, this, BlurRadius);
							listener?.OnSuccess ();
						}
				}
			} else {
				listener?.OnError ();
				BzLogging.Log ("Failed to load Image in ImageView_Blurred: " + error);
			}
		}

		#endregion

		#endregion

		#region private methods

		protected override void OnMeasure (int widthMeasureSpec, int heightMeasureSpec)
		{
			base.OnMeasure (widthMeasureSpec, heightMeasureSpec);
			if (_drawAfterMeasureBlur) {
				if (_needsToBlurr) {
					if (width == 0 || height == 0) {
						if (_predrawOriginalUrl == _currentUrl+"Blur") {
							(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GenerateScaledAndBlurredBitmap (_predrawLocalUrl, _predrawOriginalUrl, this.MeasuredWidth, this.MeasuredHeight, this, BlurRadius);
							listener?.OnSuccess ();
						}
					}
				} else {
					if (_predrawOriginalUrl == _currentUrl+"Blur") {
						(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GenerateBitmap (_predrawLocalUrl, _predrawOriginalUrl, this.MeasuredWidth, this.MeasuredHeight, this);
						listener?.OnSuccess ();
					}
				}
				_drawAfterMeasureBlur = false;
			}
		}

		void handleImageSave(){
			_hashedUrl = string.Empty;
			_needsToBlurr = false;
			var keyBytes = Encoding.UTF8.GetBytes (_currentUrl);
			var hashAlgorithm = new System.Security.Cryptography.HMACSHA256 (keyBytes);            
			byte[] dataBuffer = Encoding.UTF8.GetBytes (_currentUrl);
			byte[] hashBytes = hashAlgorithm.ComputeHash (dataBuffer);
			_hashedUrl = Convert.ToBase64String (hashBytes).Replace ("/", "") + System.IO.Path.GetExtension (_currentUrl);
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			_hashedGeneralUrl = System.IO.Path.Combine (documentsPath, Constants_Android.FOLDER_GENERAL + _hashedUrl);
			_hashedUrl = System.IO.Path.Combine (documentsPath, Constants_Android.FOLDER_BLUR + _hashedUrl);
			_needsToBlurr = !System.IO.File.Exists (_hashedUrl);
			if (_needsToBlurr) {
				AppController.Instance.ImageController.GetImage (_currentUrl, this);
			} else {
				AppController.Instance.ImageController.GetImage (_currentUrl, this, Constants_Android.FOLDERNAME_BLUR);
			}
		}

		#endregion


	}
}