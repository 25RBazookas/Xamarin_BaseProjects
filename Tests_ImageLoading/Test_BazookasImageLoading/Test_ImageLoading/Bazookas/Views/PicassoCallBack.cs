// //
// //PicassoCallBack.cs$
// //
// // Author:
// //       Philippe Creytens <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;

using Android.Util;
using Square.Picasso;

namespace Bazookas.Kinepolis.PicassoExtension
{

	public interface IPicassoCallBackListener
	{
		void SuccesfullLoadedImage(bool loaded);
	}

	public class PicassoCallBack: CallbackEmptyCallback
	{

		public IPicassoCallBackListener Listener {
			get;
			private set;
		}

		public PicassoCallBack (IPicassoCallBackListener listener)
		{
			this.Listener = listener;
		}

		public override void OnError ()
		{
			base.OnError ();
			Listener.SuccesfullLoadedImage (false);
		}

		public override void OnSuccess ()
		{
			base.OnSuccess ();
			Listener.SuccesfullLoadedImage (true);
		}
	}
}

