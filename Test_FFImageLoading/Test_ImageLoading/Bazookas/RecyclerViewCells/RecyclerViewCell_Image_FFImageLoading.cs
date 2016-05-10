// //
// //RecyclerViewCell_Image_FFImageLoading.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using FFImageLoading;

namespace Bazookas.RecyclerViewCells
{
	public class RecyclerViewCell_Image_FFImageLoading: RecyclerViewCell_Image
	{
		public RecyclerViewCell_Image_FFImageLoading (Android.Content.Context context, string imageUrl) : base (context, imageUrl)
		{
		}

		public override void LoadImage ()
		{
			ImageService.LoadUrl (ImageUrl)
				.DownSampleInDip (ViewHolder.Image.Width, ViewHolder.Image.Height)
				.Into(ViewHolder.Image);
		}
	}
}