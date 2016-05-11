//
// DispatchAdapter.cs
//
// Author:
//       Philippe Creytens <philippe@bazookas.be>
//
// Copyright (c) 2015 Philippe Creytens
using System;
using Android.App;
using System.Collections.Generic;
using Android.OS;
using Bazookas.BL.Interfaces;
using Bazookas.Kinepolis.BL.Interfaces;
using Android.Content;
using Android.Telephony;
using Bazookas.Kinepolis.Manager;
using Android.Webkit;

namespace Bazookas.Kinepolis.Adapters
{
	public class DispatchAdapter : IDispatchOnUIThread
	{
		public DispatchAdapter ()
		{
		}

		public void Invoke(Action action)
		{
			using(var h = new Handler(Looper.MainLooper))
				h.Post (action);
		}
	}

	public class DeviceInformation : IDeviceInformation
	{
		AccountManager _manager;
		public DeviceInformation()
		{
			_manager = new AccountManager ();
		}

		public string AccountStoreName {
			get {
				throw new NotImplementedException ();
			}
		}

		public string Version() {
			Context context = Application.Context;
			var name = context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
			var code = context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionCode;
			return code.ToString ();
		}

		public string PhoneId ()
		{
			// TODO Update to adds ids

			// Current solution: locally stored GUID
			if (!_manager.ContainsCredential ("UniqueGUID"))
				_manager.StoreCredential ("UniqueGUID", Guid.NewGuid ().ToString ());
			return _manager.GetCredential ("UniqueGUID");
			// Needs additional permission that user do not like & will not work on android devices that do not call (like tablets)
		//	return ((TelephonyManager)Application.Context.GetSystemService(Context.TelephonyService)).DeviceId;
		}

		public void GoToAppInAppstore(string appId)
		{
			Android.Net.Uri uri = Android.Net.Uri.Parse("market://details?id=" + Application.Context.PackageName);
			Intent goToMarket = new Intent(Intent.ActionView, uri);
			try 
			{
				Application.Context.StartActivity(goToMarket);
			} 
			catch (ActivityNotFoundException ex)
			{
				BzLogging.SendException (ex);
				Application.Context.StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://play.google.com/store/apps/details?id=" + Application.Context.PackageName)));
			}
		}

		public void RemoveLocalStoredCookie (string key, string value)
		{
			CookieManager manager = CookieManager.Instance;
			if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop) {
				CookieSyncManager.CreateInstance (Application.Context);
			}
			manager.RemoveSessionCookie ();
			manager.RemoveAllCookie ();
		}
	}
}

