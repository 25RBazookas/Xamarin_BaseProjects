// //
// //Fragment_GoogleTagManager.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Gms.Tagmanager;
using Android.Gms.Common.Apis;
using Bazookas.MyGoogleTagManager;
using Test_ImageLoading;

namespace Bazookas.Fragments
{
	public class Fragment_GoogleTagManager : Android.Support.V4.App.Fragment
	{
		#region delegates

		#endregion

		#region variables

		static TagManagerClass _tagmanager;
		const string googleTagManager_ID = "GTM-N9FFXD";

		#endregion

		#region properties

		#endregion

		#region constructor

		#endregion

		#region public methods

		#region overided methods

		#region viewlifecycle

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.Fragment_GoogleTagManager, container, false);

			_tagmanager = TagManagerClass.GetInstance (this.Activity);

			PendingResult pending = _tagmanager.LoadContainerPreferNonDefault (googleTagManager_ID, Resource.Raw.gtm_analytics);
			pending.SetResultCallback (new MyResultCallback<Container> (this.Activity), 2, Java.Util.Concurrent.TimeUnit.Seconds);

			return view;
		}

		#endregion

		#endregion

		#endregion

		#region private methods

		#endregion

		class MyResultCallback<IContainerHolder>: Java.Lang.Object, IResultCallback
		{
			public Activity MyActivity {
				get;
				private set;
			}

			public MyResultCallback (Activity myActivity)
			{
				MyActivity = myActivity;
			}

			public void OnResult (Java.Lang.Object result)
			{
				Android.Gms.Tagmanager.IContainerHolder containerHolder = result.JavaCast<Android.Gms.Tagmanager.IContainerHolder> ();

				//TODO - if you need to keep a reference to the containerHolder to retreive configuration, unmark next line
				ContainerHolderSingleton.SetContainerHolder (containerHolder);

				if (!containerHolder.Status.IsSuccess) {
					AlertDialog.Builder builder = new AlertDialog.Builder (MyActivity);
					builder.SetTitle ("Error");
					builder.SetMessage ("Can't load Google tag manager");
					builder.SetCancelable (false);
					builder.SetPositiveButton ("OK", delegate {
						MyActivity.Finish ();
					});
					builder.Show ();
				} else {
					_tagmanager.DataLayer.PushEvent ("screenView", DataLayer.MapOf ("screenName", "testScreen"));
				}
			}
		}
	}
}

