// //
// //MYBitmapFactory.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Graphics;
using System.Threading.Tasks;
using Android.Renderscripts;
using Android.Content;

namespace Bazookas.Kinepolis.CustomControls
{
	public static class MyBitmapFactory
	{

		public static Bitmap CreateBlurredImage (int radius, Bitmap bitmap, Context context)
		{
			if (radius>25) {
				return CreateBlurredImage (radius-25,bitmap, context);
			} else {
				return blurImage (radius, bitmap, context);
			}
		}

		static Bitmap blurImage(int radius, Bitmap bitmap, Context context){
			// Load a clean bitmap and work from that.
			Bitmap originalBitmap = bitmap;

			// Create another bitmap that will hold the results of the filter.
			Bitmap blurredBitmap;
			blurredBitmap = Bitmap.CreateBitmap (originalBitmap);

			// Create the Renderscript instance that will do the work.
			RenderScript rs = RenderScript.Create (context);

			// Allocate memory for Renderscript to work with
			Allocation input = Allocation.CreateFromBitmap (rs, originalBitmap, Allocation.MipmapControl.MipmapFull, AllocationUsage.Script);
			Allocation output = Allocation.CreateTyped (rs, input.Type);

			// Load up an instance of the specific script that we want to use.
			ScriptIntrinsicBlur script = ScriptIntrinsicBlur.Create (rs, Element.U8_4 (rs));
			script.SetInput (input);

			// Set the blur radius
			script.SetRadius (radius);

			// Start the ScriptIntrinisicBlur
			script.ForEach (output);

			// Copy the output to the blurred bitmap
			output.CopyTo (blurredBitmap);

			//RELEASE MEMORY
			if (originalBitmap != null && !originalBitmap.IsRecycled) {
				originalBitmap.Recycle ();
				originalBitmap.Dispose ();
			}

			rs.Destroy ();
			rs.Dispose ();

			input.Destroy ();
			output.Destroy ();
			script.Destroy ();

			return blurredBitmap;
		}
	}
}

