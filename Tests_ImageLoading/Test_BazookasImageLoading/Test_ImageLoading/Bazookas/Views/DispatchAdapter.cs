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

}

