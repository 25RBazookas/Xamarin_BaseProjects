// //
// //ContainerHolderSingleton.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Gms.Tagmanager;

namespace Bazookas.MyGoogleTagManager
{
	public class ContainerHolderSingleton
	{
		private static IContainerHolder _containerHolder;

		/**
         * Utility class; don't instantiate.
         */
		private ContainerHolderSingleton()
		{
		}

		public static IContainerHolder GetContainerHolder()
		{
			return _containerHolder;
		}

		public static void SetContainerHolder(IContainerHolder c)
		{
			_containerHolder = c;
		}

	}
}

