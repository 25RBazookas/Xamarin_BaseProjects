// //
// //RecyclerViewCell_Image_Picasso.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Square.Picasso;
using Bazookas.Activities;

namespace Bazookas.RecyclerViewCells
{
	public class RecyclerViewCell_Image_Picasso: RecyclerViewCell_Image
	{
		public RecyclerViewCell_Image_Picasso (Android.Content.Context context, string imageUrl) : base (context, imageUrl)
		{
		}

		public override void LoadImage ()
		{
			Picasso.With (Context)
				.Load (ImageUrl)
				.Resize (MainActivity.SCREEN_WIDTH, MainActivity.SCREEN_HEIGHT) 
				.OnlyScaleDown ()
				.CenterCrop()
				.Into (ViewHolder.Image);
		
			StatsSnapshot picassoStats = Picasso.With(Context).Snapshot;
			Console.WriteLine ("Picasso Stats: \n", picassoStats); 
		}
		
	}
}

