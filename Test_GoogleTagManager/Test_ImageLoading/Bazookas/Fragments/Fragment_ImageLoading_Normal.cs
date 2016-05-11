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
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/dedeminfisi_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/The_Boy.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/The_Boy.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/revenant.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/TheFinestHours_BENLFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/goosebumps_temp_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Kardesim_A4_300dpi.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/broer_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Legend_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/danishgirl_BENL_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-CREED-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/daddyshome_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-JOY-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/ToutSchuss_FRFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/carol_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Hateful-Eight_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Hateful-Eight_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/thebigshort_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-SNOOPY-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/starwars7_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/SafetyFirst_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/mmvsRox_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/belleetseb2_BEFOteaser.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-BOS-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/babysitting2_FRFOv2.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/gooddino_BENL_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Mockingjay2_BE_FOdef.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/black_BE_FO2.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/spectre_BE_FOdef.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/kampioenen2_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/lesaventuresdaladin_FRFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/hoteltrans2_BENL_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/The_Choice_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/JosephineSArrondit_FRFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/TwoPigeons_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/heldenvandezee_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Turandot_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/The_Choice_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/JosephineSArrondit_FRFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Goya_540.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Uffizi_540.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Renoir_540.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Modern_540.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Manon_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Manon_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Madama-Butterlfy_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Madama-Butterlfy_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Giselle_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Giselle_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Roberto-Deveraux_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Roberto-Deveraux_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Elektra_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Elektra_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/belleetseb2_BEFOteaser.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/gooddino_BENL_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/starwars7_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/SafetyFirst_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-SNOOPY-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/mmvsRox_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/zootopia_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Turandot_540x810.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/achterdewolken_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/chocolat_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/kanye_688x1032.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/TED-miniposter_EURO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/A3EXPLO_20152016_FF5.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/the-forest-poster.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/sven_688x1032.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/A3EXPLO_20152016_FF6.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/ID_ROW_LR_686x1020.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/IntheheartoftheseaP.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/watmannenwillen_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/45years_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/ID_ROW_LR_686x1020.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/IntheheartoftheseaP.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/stevejobs_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/heldenvandezee_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Spotlight_540.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/chocolat_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/45years_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-ALVIN4-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/PointBreak_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/zootopia_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/deadpool_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/achterdewolken_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/LATOUR_carton_v2.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/howtobesingle_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Ride_Along_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/The_Choice_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/zoolander_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/londonhasfallen_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/belgica_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/MissYouAlready_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/allegiant_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/triplenine_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Batman_Vs_Superman_Dawn_Of_Justice_poster_resize.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/13hours_BENL_FOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/secretintheireyes_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/junglebook_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/5thwave_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/huntsman_BENLFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/captainamericacivil_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/angrybirds_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/xmenap.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/warcraft_BENL_FO1.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/ttlg_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/findingdory_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/idr_teaser.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/iceage5_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/suicidesquadtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/secretlifeofpets_BE_FOteaser.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/fifty-shades-darker-poster_resize.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FF8_Poster.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/50shadesdarkerB.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/fifty-shades-darker-poster_resize.jpg");
			album.ImageUrls.Add("http://a.dilcdn.com/bl/wp-content/uploads/sites/6/2015/10/star-wars-force-awakens-official-poster.jpg");
			album.ImageUrls.Add("http://a.dilcdn.com/bl/wp-content/uploads/sites/6/2015/10/star-wars-force-awakens-official-poster.jpg");
			album.ImageUrls.Add("http://a.dilcdn.com/bl/wp-content/uploads/sites/6/2015/10/star-wars-force-awakens-official-poster.jpg");
			album.ImageUrls.Add("http://a.dilcdn.com/bl/wp-content/uploads/sites/6/2015/10/star-wars-force-awakens-official-poster.jpg");
			album.ImageUrls.Add("http://a.dilcdn.com/bl/wp-content/uploads/sites/6/2015/10/star-wars-force-awakens-official-poster.jpg");
			album.ImageUrls.Add("http://a.dilcdn.com/bl/wp-content/uploads/sites/6/2015/10/star-wars-force-awakens-official-poster.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/stevejobs_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/heldenvandezee_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Spotlight_540.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/chocolat_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/45years_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/FOX-ALVIN4-688x1032-nl.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/PointBreak_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/zootopia_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/deadpool_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/achterdewolken_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/LATOUR_carton_v2.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/howtobesingle_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Ride_Along_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/The_Choice_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/zoolander_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/londonhasfallen_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/belgica_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/MissYouAlready_BEFO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/allegiant_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/triplenine_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/Batman_Vs_Superman_Dawn_Of_Justice_poster_resize.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/13hours_BENL_FOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/secretintheireyes_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/junglebook_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/5thwave_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/huntsman_BENLFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/captainamericacivil_BEFOtemp.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/angrybirds_BE_FO.jpg");
			album.ImageUrls.Add("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/styles/movie_poster_list/public/posters/xmenap.jpg");
			return album;
		}
		#endregion


	}
}

