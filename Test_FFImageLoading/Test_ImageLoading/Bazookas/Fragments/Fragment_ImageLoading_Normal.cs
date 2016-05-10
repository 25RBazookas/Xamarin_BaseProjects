// //
// //Fragment_ImageLoading_Normal.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.App;
using Android.Views;
using Test_ImageLoading;
using Android.Support.V7.Widget;
using Bazookas.VO;
using System.Collections.Generic;
using Android.Support.V7.App;

namespace Bazookas.Fragments
{
	public class Fragment_ImageLoading_Normal: Android.Support.V4.App.Fragment, IMyAdapterListener
	{
		#region delegates

		#endregion

		#region variables

		RecyclerView mRecyclerView;
		RecyclerView.LayoutManager mLayoutManager = null;
		RecyclerView.Adapter mAdapter;

		#endregion

		#region properties
		public Android.Support.V4.App.FragmentManager SupportFragmentManager {
			get;
			set;
		}
		#endregion

		#region constructor
		public Fragment_ImageLoading_Normal (Android.Support.V4.App.FragmentManager supportFragmentManager)
		{
			this.SupportFragmentManager = supportFragmentManager;
		}
		
		#endregion

		#region public methods

		#region IMyAdapterListener implementation

		public void OnClick (int position)
		{
			IList<string> list = new List<string> ();
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			list.Add ("Keuze");
			AppCompatDialogFragment fragment = new Fragment_Dialog (list);
			fragment.Show (SupportFragmentManager, "dialog");
		}

		#endregion

		#region overided methods

		#region viewlifecycle

		public override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override Android.Views.View OnCreateView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.Fragment_ImageLoading_Normal, container, false);

			// Prepare the data source:
			PhotoAlbumVO album = new PhotoAlbumVO();
			album = mockData (album);

			// Instantiate the adapter and pass in its data source:
			mAdapter = new Adapter_Images (this.Activity, album, this);

			// Get our RecyclerView layout:
			mRecyclerView = view.FindViewById<RecyclerView> (Resource.Id.fragment_list);

			// Plug the adapter into the RecyclerView:
			mRecyclerView.SetAdapter (mAdapter);

			mLayoutManager = new LinearLayoutManager (this.Activity);
			mRecyclerView.SetLayoutManager (mLayoutManager);

			return view;
		}

		#endregion

		#endregion

		#endregion

		#region private methods


		PhotoAlbumVO mockData(PhotoAlbumVO album){
			for (int i = 0; i < 2000; i++) {
				album.ImageUrls.Add("https://placeholdit.imgix.net/~text?txtsize=33&txt=" + i +"&w=1000&h=450");
			}
			return album;
		}
		#endregion


	}
}

