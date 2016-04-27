// //
// //MyGTMResultCallback.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Gms.Common.Apis;
using Java.Interop;
using Android.Gms.Tagmanager;
using Android.App;
using Android.Content;

namespace Bazookas.MyGoogleTagManager
{
	public class MyGTMResultCallback<IContainerHolder>: Java.Lang.Object, IResultCallback
	{
		Dialog  dialog =null;

		public Context Context {
			get;
			private set;
		}

		public MyGTMResultCallback (Context context)
		{
			Context = context;
		}

		public void OnResult (Java.Lang.Object result)
		{
			Android.Gms.Tagmanager.IContainerHolder containerHolder = result.JavaCast<Android.Gms.Tagmanager.IContainerHolder> ();

			//TODO - if you need to keep a reference to the containerHolder to retreive configuration, unmark next line
			ContainerHolderSingleton.SetContainerHolder (containerHolder);
			Container container = containerHolder.Container;

			if (!containerHolder.Status.IsSuccess) {
				Console.WriteLine (String.Format ("LOG: {0}", "FAILED TO SET GTM"));
			} else {

				TagManagerClass.GetInstance (Application.Context).DataLayer.PushEvent ("screenView", DataLayer.MapOf ("screenName", "testScreenActivity"));
				Console.WriteLine (String.Format ("LOG: {0}", "SUCCEED TO SET GTM"));

			}
		}
	}
}

