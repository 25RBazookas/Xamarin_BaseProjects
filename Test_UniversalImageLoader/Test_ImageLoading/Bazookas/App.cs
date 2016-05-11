// //
// //App.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.App;
using Android.Runtime;
using UniversalImageLoader.Core;

namespace Bazookas
{
	[Application]
	public class App: Application
	{
		protected App(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
		public override void OnCreate()
		{
			base.OnCreate();
			// Use default options
			var config = ImageLoaderConfiguration.CreateDefault(ApplicationContext);
			// Initialize ImageLoader with configuration.
			ImageLoader.Instance.Init(config);
		}
	}
}

