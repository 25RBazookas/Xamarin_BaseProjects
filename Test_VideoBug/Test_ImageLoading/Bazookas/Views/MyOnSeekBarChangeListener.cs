using System;
using Android.Widget;

namespace Test_ImageLoading
{
	public class MyOnSeekBarChangeListener: Java.Lang.Object, SeekBar.IOnSeekBarChangeListener
	{
		#region variables
		#endregion

		#region properties
		public View_VideoController MyVideoController
		{
			get;
			set;
		}

		#endregion

		#region constructors
		public MyOnSeekBarChangeListener()
		{

		}
		#endregion

		#region public methods

		public void OnStartTrackingTouch(SeekBar bar)
		{
			MyVideoController.Show(3600000);

			MyVideoController.mDragging = true;

			// By removing these pending progress messages we make sure
			// that a) we won't update the progress while the user adjusts
			// the seekbar and b) once the user is done dragging the thumb
			// we will post one of these messages to the queue again and
			// this ensures that there will be exactly one message queued up.
			MyVideoController.mHandler.RemoveMessages(View_VideoController.SHOW_PROGRESS);
		}

		public void onProgressChanged(SeekBar bar, int progress, bool fromuser)
		{
			if (MyVideoController.mPlayer == null)
			{
				return;
			}

			if (!fromuser)
			{
				// We're not interested in programmatically generated changes to
				// the progress bar's position.
				return;
			}

			long duration = MyVideoController.mPlayer.getDuration();
			long newposition = (duration * progress) / 1000L;
			MyVideoController.mPlayer.seekTo((int)newposition);
			if (MyVideoController.mCurrentTime != null)
				MyVideoController.mCurrentTime.Text = (MyVideoController.StringForTime((int)newposition));
		}

		public void onStopTrackingTouch(SeekBar bar)
		{
			MyVideoController.mDragging = false;
			MyVideoController.SetProgress();
			MyVideoController.updatePausePlay();
			MyVideoController.Show(View_VideoController.sDefaultTimeout);

			// Ensure that progress is properly updated in the future,
			// the call to Show() does not guarantee this because it is a
			// no-op if we are already Showing.
			MyVideoController.mHandler.SendEmptyMessage(View_VideoController.SHOW_PROGRESS);
		}

		public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
		{
			if (MyVideoController.mPlayer == null)
			{
				return;
			}

			if (!fromUser)
			{
				// We're not interested in programmatically generated changes to
				// the progress bar's position.
				return;
			}

			long duration = MyVideoController.mPlayer.getDuration();
			long newposition = (duration * progress) / 1000L;
			MyVideoController.mPlayer.seekTo((int)newposition);
			if (MyVideoController.mCurrentTime != null)
			{
				MyVideoController.mCurrentTime.Text = (MyVideoController.StringForTime((int)newposition));
			}
		}

		public void OnStopTrackingTouch(SeekBar seekBar)
		{
			MyVideoController.mDragging = false;
			MyVideoController.SetProgress();
			MyVideoController.updatePausePlay();
			MyVideoController.Show(View_VideoController.sDefaultTimeout);

			// Ensure that progress is properly updated in the future,
			// the call to show() does not guarantee this because it is a
			// no-op if we are already showing.
			MyVideoController.mHandler.SendEmptyMessage(View_VideoController.SHOW_PROGRESS);
		}

		public void Dispose()
		{
			//Dispose
		}
		#endregion

		#region private methods
		#endregion

	}
}

