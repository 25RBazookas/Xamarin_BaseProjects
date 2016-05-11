// //
// //RecyclerViewCell_Image_UniversalImageLoader.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using UniversalImageLoader.Core;
using UniversalImageLoader.Core.Listener;

namespace Bazookas.RecyclerViewCells
{
	public class RecyclerViewCell_Image_UniversalImageLoader: RecyclerViewCell_Image
	{
		public RecyclerViewCell_Image_UniversalImageLoader (Android.Content.Context context, string imageUrl) : base (context, imageUrl)
		{
		}

		public override void LoadImage ()
		{
			ImageLoader imageLoader = ImageLoader.Instance; 
			ViewHolder.Image.SetImageBitmap (null);
			imageLoader.LoadImage(
				ImageUrl, 
				new ImageLoadingListener(
					loadingComplete: (imageUri, view, loadedImage) => ViewHolder.Image.SetImageBitmap (loadedImage)));
			
		}

	}
}

