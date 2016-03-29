// //
// //Fragment_Maps.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Test_ImageLoading;
using System.ComponentModel;
using Com.Lilarcor.Cheeseknife;
using Android.Graphics;

namespace Bazookas.Fragments
{
	public class Fragment_Maps : Android.Support.V4.App.Fragment, IOnMapReadyCallback
	{
		#region delegates

		#endregion

		#region variables
		GoogleMap map;
		SupportMapFragment mapFragment;
		Marker _marker = null;
		#endregion

		#region properties

		[InjectView (Resource.Id.view_theaterDetail_location)] 
		public LinearLayout TheaterDetailLocationContainer {
			get;
			set;
		}

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
			setMapCamera (51.079772, 2.600393);
		}

		#region overided methods

		#region viewlifecycle


		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			return base.OnCreateView (inflater, container, savedInstanceState);
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
			TheaterDetailLocationContainer.SetBackgroundColor (Color.Gray);
			TheaterDetailLocationContainer.Visibility = ViewStates.Visible;
			TheaterDetailLocationContainer.Alpha = 1;

			BackgroundWorker bw = new BackgroundWorker();

			// what to do in the background thread
			bw.DoWork += delegate {
				mapFragment = new SupportMapFragment ();
				Android.Support.V4.App.FragmentTransaction tx = ChildFragmentManager.BeginTransaction ();
				tx.Add (Resource.Id.view_theaterDetail_location, mapFragment);
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
			CameraUpdate zoom = CameraUpdateFactory.ZoomTo (13);
			map.MoveCamera (center);
			map.AnimateCamera (zoom);
		}

		void addAnnotation (double latitude, double longitude)
		{
			MarkerOptions markerOpt1 = new MarkerOptions ();
			markerOpt1.SetPosition (new LatLng (latitude,longitude));
			_marker = map.AddMarker (markerOpt1);
		}

		#endregion


	}
}

