// //
// //BaseImageView.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Widget;
using Bazookas.BL.Interfaces;
using Square.Picasso;
using Java.IO;
using Android.Graphics.Drawables;
using Bazookas.Utils;
using Android.Graphics;
using System.Threading.Tasks;
using Bazookas.Kinepolis.BL.Interfaces;
using Android.Views;
using Bazookas.Kinepolis.PicassoExtension;

namespace Bazookas.Kinepolis.Views.ImageViews
{
	/**
	 * xml
	 * Bazookas.Kinepolis.Views.ImageViews.ImageView_Base
	 * */
	public class ImageView_Base : ImageView, IBazookasImageInterface
	{
		#region delegates
		#endregion

		#region variables
		public PicassoCallBack listener;
		public string _currentUrl = string.Empty;
		public string _hashedUrl = string.Empty;
		public string _hashedGeneralUrl = string.Empty;

		int qualityOfImage = 100;
		bool _isDisposed = false;
		protected bool _drawAfterMeasure = false;
		int _targetWidth = 0;
		int _targetHeight = 0;

		protected string _predrawOriginalUrl = string.Empty;
		protected string _predrawLocalUrl = string.Empty;
		protected bool _canDispose = false;
		#endregion

		#region properties

		public virtual int QualityOfImage {
			get{ 
				return qualityOfImage;
			}
			set{ 
				qualityOfImage = value;
			}
		}

		public Func<Picasso, Android.Net.Uri, RequestCreator> PicassoRequest {
			get;
			protected set;
		}

		public bool IsLoading {
			get;
			protected set;
		}
			
		#endregion

		#region constructor

		public ImageView_Base (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer)
		{
			initialize ();
		}

		public ImageView_Base (Android.Content.Context context) : base (context)
		{
			initialize ();
		}

		public ImageView_Base (Android.Content.Context context, Android.Util.IAttributeSet attrs) : base (context, attrs)
		{
			initialize ();
		}

		public ImageView_Base (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr) : base (context, attrs, defStyleAttr)
		{
			initialize ();
		}

		public ImageView_Base (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base (context, attrs, defStyleAttr, defStyleRes)
		{
			initialize ();
		}

		#endregion

		#region public methods

		public void LoadImage(string url, Func<Picasso, Android.Net.Uri, RequestCreator> requestCreator, PicassoCallBack listener = null, bool deleteExistingImage = true, int targetWidth = 0, int targetHeight = 0){
			_canDispose = true;
			_targetWidth = targetWidth != 0 ? targetWidth : this.Width;
			_targetHeight = targetHeight != 0 ? targetHeight : this.Height;
			if (_currentUrl != url) {
				_drawAfterMeasure = false;
				(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).CancelBitmap (_currentUrl);
				IsLoading = true;
				this.PicassoRequest = requestCreator;
				this.listener = listener;
				if (deleteExistingImage) {
					this.SetImageDrawable (null);
					this.SetBackgroundColor (Color.Transparent);
				}
				_currentUrl = url;
				Bitmap bmp = (AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GetBitmapFromMemCache (url);
				if (bmp == null) {
					AppController.Instance.ImageController.GetImage (_currentUrl, this);
				} else {
					IsLoading = false;
					this.SetImageBitmap (bmp);
					listener?.OnSuccess ();
				}
			} else {
				listener?.OnSuccess ();
			}
		}
			
		public void OnBitmapFailed (Drawable p0)
		{
			listener?.OnError ();
			BzLogging.Log ("load bitmap failedin ImageView_Base");
		}

		public void OnPrepareLoad (Drawable p0)
		{
			
		}

		public virtual void ImageLoaded (string originalImageLocation, string localImageLocation, string imageName, string error)
		{
			this.SetBackgroundColor (Color.Transparent);
			IsLoading = false;
			if (string.IsNullOrEmpty (error)) {
				if (originalImageLocation == _currentUrl) {
					const bool newMethod = true;
					if (newMethod) {
						if (_targetWidth == 0 && this.Width == 0) {
							this._predrawLocalUrl = localImageLocation; 
							this._predrawOriginalUrl = originalImageLocation;
							_drawAfterMeasure = true;
						} else {
							(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GenerateBitmap (localImageLocation, originalImageLocation, _targetWidth, _targetHeight, this);
							listener?.OnSuccess ();
						}
					}else{
					//	Android.Net.Uri contentUri = Android.Net.Uri.FromFile (new File (localImageLocation));
					//	PicassoRequest(Picasso.With(Context),contentUri).Into (this as ImageView, listener);
					}
				}
			} else {
				listener?.OnError ();
				BzLogging.Log ("Failed to load Image in ImageView_Base: " + error);
			}
		}

		public bool IsDisposed ()
		{
			return _isDisposed;
		}

		#region overided methods

		public override void SetImageBitmap (Bitmap bm)
		{
			if (bm == null)
				_currentUrl = string.Empty;
			base.SetImageBitmap (bm);
		}

		protected override void Dispose (bool disposing)
		{
			if(_canDispose)
				(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).RemoveBitmapFromMemCache (_currentUrl);
			base.Dispose (disposing);
			_isDisposed = true;
		}

		#endregion

		#endregion

		#region private methods

		void initialize(){
		}

		protected override void OnMeasure (int widthMeasureSpec, int heightMeasureSpec)
		{
			base.OnMeasure (widthMeasureSpec, heightMeasureSpec);
			if (_drawAfterMeasure) {
				if (_predrawOriginalUrl == _currentUrl) {
					_targetWidth = _targetWidth == 0 ? this.MeasuredWidth : _targetWidth;
					_targetHeight = _targetHeight == 0 ? this.MeasuredHeight : _targetHeight;
					(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).GenerateBitmap (_predrawLocalUrl, _predrawOriginalUrl, _targetWidth, _targetHeight, this);
						listener?.OnSuccess ();
				}
				_drawAfterMeasure = false;
			}
		}

		#endregion

	}
}

