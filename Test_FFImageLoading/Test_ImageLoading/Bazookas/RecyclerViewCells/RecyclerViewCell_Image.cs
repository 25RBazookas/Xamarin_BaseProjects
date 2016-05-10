// //
// //RecyclerViewCell_Image.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Widget;
using Android.Content;
using Bazookas.RecyclerViewHolder;

namespace Bazookas.RecyclerViewCells
{
	public class RecyclerViewCell_Image{

		public string ImageUrl {
			get;
			set;
		}

		public Context Context {
			get;
			set;
		}

		public RecyclerViewHolder_Image ViewHolder {
			get;
			set;
		}

		public RecyclerViewCell_Image (Context context, string imageUrl)
		{
			this.ImageUrl = imageUrl;
			this.Context = context;
		}

		public virtual void LoadImage(){
			
		}
		
		public void SetData (RecyclerViewHolder_Image viewHolder)
		{
			this.ViewHolder = viewHolder;
		}
	}
}

