// //
// //PhotoAlbumVO.cs$
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
using Android.Views;
using Android.Widget;

namespace Bazookas.VO
{
	public class PhotoAlbumVO
	{
		public IList<string> ImageUrls {
			get;
			set;
		}

		public PhotoAlbumVO ()
		{
			ImageUrls = new List<string> ();
		}
		
	}
}

