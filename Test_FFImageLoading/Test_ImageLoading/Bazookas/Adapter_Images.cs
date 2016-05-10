// //
// //Adapter.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Support.V7.Widget;
using Bazookas.VO;
using Android.Views;
using Test_ImageLoading;
using Bazookas.RecyclerViewHolder;
using Bazookas.RecyclerViewCells;
using Android.Content;
using System.Collections.Generic;
using Android.Support.V4.App;

namespace Bazookas
{
	public interface IMyAdapterListener
	{
		void OnClick(int position);
	}
	public class Adapter_Images: RecyclerView.Adapter
	{
		#region delegates

		#endregion

		#region variables

		#endregion

		#region properties
		public IMyAdapterListener Listener {
			get;
			set;
		}

		public PhotoAlbumVO Album {
			get;
			set;
		}

		public Context Context {
			get;
			set;
		}

		#endregion

		#region constructor

		public Adapter_Images (Context context, PhotoAlbumVO album, IMyAdapterListener listener)
		{
			this.Album = album;
			this.Context = context;
			this.Listener = listener;
		}
		

		#endregion

		#region public methods

		#region overided methods

		public override RecyclerView.ViewHolder OnCreateViewHolder (ViewGroup parent, int viewType)
		{
			View itemView = LayoutInflater.From (parent.Context).Inflate (Resource.Layout.Cell_RecyclerView_ImageLoading, parent, false);
			RecyclerView.ViewHolder viewHolder = new RecyclerViewHolder_Image (itemView, OnClick);
			return viewHolder;
		}

		public override void OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
		{
			//CELL CREATION
			RecyclerViewHolder_Image viewHolder = holder as RecyclerViewHolder_Image;
			string item = Album.ImageUrls [position];
			RecyclerViewCell_Image listViewItem = new RecyclerViewCell_Image_FFImageLoading (this.Context, item);
			listViewItem.SetData (viewHolder);
			listViewItem.LoadImage ();
		}

		public override int ItemCount {
			get {
				return Album.ImageUrls.Count;
			}
		}

		public void OnClick(int position){
			Listener.OnClick (position);
		}

		#endregion

		#endregion

		#region private methods

		#endregion


	}
}

