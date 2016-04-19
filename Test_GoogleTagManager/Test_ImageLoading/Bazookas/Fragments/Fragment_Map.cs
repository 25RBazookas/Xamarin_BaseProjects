// //
// //Fragment_Map.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Test_ImageLoading;
using Android.Views;
using Android.Gms.Maps;
using System.ComponentModel;
using Android.Support.V4.App;
using Android.Gms.Maps.Model;

namespace Bazookas.Fragments
{
	public class Fragment_Map: Android.Support.V4.App.Fragment, IOnMapReadyCallback
	{
		#region delegates

		#endregion

		#region variables
		string address = "";
		GoogleMap map;
		SupportMapFragment mapFragment;
		#endregion

		#region properties

		#endregion

		#region constructor

		#endregion

		#region public methods

		public void OnMapReady (GoogleMap googleMap)
		{
			map = googleMap;

			if (map != null) {
				map.MapType = GoogleMap.MapTypeNormal;
				map.UiSettings.MyLocationButtonEnabled = false;
				map.MyLocationEnabled = true;
			}
		
			setMapCamera (0,0);
			addAnnotation (0,0);
		}

		#region overided methods

		#region viewlifecycle
		public override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override Android.Views.View OnCreateView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.Fragment_Maps, container, false);

			return view;
		}
		#endregion

		#endregion

		#endregion

		#region private methods

		bool setUpGoogleMap()
		{
			if(null != map ){ 
				return false;
			}
			BackgroundWorker bw = new BackgroundWorker();

			GoogleMapOptions options = new GoogleMapOptions ();
			options.InvokeScrollGesturesEnabled (false);
			options.InvokeZoomGesturesEnabled (false);

			// what to do in the background thread
			bw.DoWork += delegate {
				mapFragment = SupportMapFragment.NewInstance(options);
				FragmentTransaction tx = ChildFragmentManager.BeginTransaction ();
				tx.Add (Resource.Id.map, mapFragment);
				tx.Commit ();
			};

			// what to do when worker completes its task (notify the user)
			bw.RunWorkerCompleted += delegate {
				mapFragment.GetMapAsync (this);
			};

			bw.RunWorkerAsync();
			return true;
		}

		void setMapCamera (double latitude, double longitude)
		{
			CameraUpdate center = CameraUpdateFactory.NewLatLng (new LatLng (latitude, longitude));
			CameraUpdate zoom = CameraUpdateFactory.ZoomTo (12f);
			map.MoveCamera (center);
			map.AnimateCamera (zoom);
		}

		void addAnnotation (double latitude, double longitude)
		{
			MarkerOptions markerOpt1 = new MarkerOptions ();
			markerOpt1.SetPosition (new LatLng (latitude,longitude));
			Marker _marker = map.AddMarker (markerOpt1);
		}
		#endregion


	}
}

