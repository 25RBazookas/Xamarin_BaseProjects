// //
// //RecyclerViewHolder_Image.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Support.V7.Widget;
using Android.Widget;
using Com.Lilarcor.Cheeseknife;
using Test_ImageLoading;
using Android.Views;
using FFImageLoading.Views;

namespace Bazookas.RecyclerViewHolder
{
	public class RecyclerViewHolder_Image: RecyclerView.ViewHolder
	{

		[InjectView (Resource.Id.image)] 
		public ImageViewAsync Image {
			get;
			set;
		}
		
		public RecyclerViewHolder_Image (View itemView, Action<int> listener): base(itemView)
		{
			Cheeseknife.Inject (this, itemView);
			itemView.Click += (object sender, EventArgs e) => listener (base.AdapterPosition);


		}
	}
}

