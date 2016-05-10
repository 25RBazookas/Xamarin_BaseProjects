// //
// //BaseActivity.cs$
// //
// // Author:
// //       Philippe Creytens <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Support.V7.App;

namespace Bazookas.Activities
{
	[Activity (Label = "Activity_FavoriteCinema")]
	public class Activity_Base: AppCompatActivity
	{
		#region delegates

		#endregion

		#region variables
		#endregion

		#region properties
		#endregion

		#region constructor
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

		}
		#endregion

		#region public methods
		public void ShowFragment (int id_WhereToAdd, Android.Support.V4.App.Fragment fragment, string tag, bool replace = false, bool addToBackStack = false, bool overideSameFragmentCheck = false)
		{
			try {
				Android.Support.V4.App.FragmentTransaction transaction = SupportFragmentManager.BeginTransaction ();

				//Add or replace
				if (replace) {
					transaction.Replace(id_WhereToAdd, fragment, tag);
				} else {
					transaction.Add (id_WhereToAdd, fragment, tag);
				}
				//Add to backstack
				if (addToBackStack) {
					transaction.AddToBackStack(tag);
				}

				transaction.Commit ();	
				SupportFragmentManager.ExecutePendingTransactions();
			} catch (Exception ex) {
				Console.WriteLine (ex);
			}
		}

		#region overided methods

		#region viewlifecycle
		protected override void OnResume ()
		{
			base.OnResume ();

			#region events
			#endregion
		}

		protected override void OnPause ()
		{
			base.OnPause ();

			#region events
			#endregion
		}

		protected override void OnDestroy ()
		{
			base.OnDestroy ();

		}
		#endregion

		#endregion

		#endregion

		#region private methods
		#endregion
	}
}

