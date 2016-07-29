using System;
using Android.OS;

namespace Test_ImageLoading
{
	public class MessageHandler : Handler
	{

		WeakReference<View_VideoController> mView;


		public MessageHandler(View_VideoController view)
		{
			mView = new WeakReference<View_VideoController>(view);
		}

		public override void HandleMessage(Message msg)
		{
			View_VideoController view;
			mView.TryGetTarget(out view);
			if (view == null || view.mPlayer == null)
			{
				return;
			}

			int pos;
			switch (msg.What)
			{
				case View_VideoController.FADE_OUT:
					view.hide();
					break;
				case View_VideoController.SHOW_PROGRESS:
					pos = view.SetProgress();
					if (!view.mDragging && view.mShowing && view.mPlayer.isPlaying())
					{
						msg = ObtainMessage(View_VideoController.SHOW_PROGRESS);
						SendMessageDelayed(msg, 1000 - (pos % 1000));
					}
					break;
			}
		}
	}
}