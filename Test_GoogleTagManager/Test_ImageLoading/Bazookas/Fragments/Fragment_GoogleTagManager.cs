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
//
//			TagManagerClass _tagmanager = TagManagerClass.GetInstance (this.Activity);
//
//			PendingResult pending = _tagmanager.LoadContainerPreferNonDefault (googleTagManager_ID, Resource.Raw.gtm_analytics);
//			pending.SetResultCallback (new MyGTMResultCallback<Container> (this.Activity), 2, Java.Util.Concurrent.TimeUnit.Seconds);
//
//
//			#if DEBUG
//			_tagmanager.SetVerboseLoggingEnabled(true);
//			#endif

			TagManagerClass.GetInstance (this.Activity)
				.DataLayer.PushEvent ("screenView", DataLayer.MapOf ("screenName", "fragment_googleTagmanagerScreen"));

			return view;
		}

		#endregion

		#endregion

		#endregion

		#region private methods

		#endregion

	}
}

