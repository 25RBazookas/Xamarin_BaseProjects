using Android.App;
using Test_ImageLoading;
using Android.OS;
using Bazookas.Fragments;
using Android.Views;
using System.Drawing;
using Android.Content;
using Android.Runtime;

namespace Bazookas.Activities
{
	[Activity (Label = "Test_ImageLoading",  Theme="@style/Theme.AppCompat.Dark.NoActionBar", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity_Base
	{
		#region delegates

		#endregion

		#region variables

		public static int SCREEN_WIDTH 						= 0;
		public static int SCREEN_HEIGHT 					= 0;


		#endregion

		#region properties

		#endregion

		#region constructor

		#endregion

		#region public methods

		#region overided methods

		#region viewlifecycle

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.Activity_Container);

			//SIZES
			IWindowManager windowManager = this.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
			Display display = windowManager.DefaultDisplay;
			Android.Graphics.Point size = new Android.Graphics.Point();
			display.GetSize(size);
			SCREEN_HEIGHT = size.Y;
			SCREEN_WIDTH = size.X;

//			Android.Support.V4.App.Fragment fragment = new Fragment_ImageLoading_Normal (SupportFragmentManager);
//			Android.Support.V4.App.Fragment fragment = new Fragment_Map ();
			Android.Support.V4.App.Fragment fragment = new Fragment_GoogleTagManager();

			ShowFragment (Resource.Id.activity_container, fragment, "TAG");

		}
		protected override void OnResume ()
		{
			base.OnResume ();
		}

		protected override void OnPause ()
		{
			base.OnPause ();
		}


		#endregion

		#endregion

		#endregion

		#region private methods



		#endregion

	}
}
