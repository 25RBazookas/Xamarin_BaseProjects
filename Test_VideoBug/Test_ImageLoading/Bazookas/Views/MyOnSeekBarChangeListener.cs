using System;
using Android.Widget;

namespace Test_ImageLoading
{
	public class MyOnSeekBarChangeListener: Java.Lang.Object, SeekBar.IOnSeekBarChangeListener
	{
		#region variables
		View_VideoController videoController;
		#endregion

		#region properties

		#endregion

		#region constructors
		public MyOnSeekBarChangeListener(View_VideoController controller)
		{
			this.videoController = controller;
		}
		#endregion

		#region public methods

		public void OnStartTrackingTouch(SeekBar bar)
		{
			videoController.Show(View_VideoController.sDefaultTimeout);

			videoController.mDragging = true;

			// By removing these pending progress messages we make sure
			// that a) we won't update the progress while the user adjusts
			// the seekbar and b) once the user is done dragging the thumb
			// we will post one of these messages to the queue again and
			// this ensures that there will be exactly one message queued up.
			videoController.mHandler.RemoveMessages(View_VideoController.SHOW_PROGRESS);
		}

		public void onProgressChanged(SeekBar bar, int progress, bool fromuser)
		{
			if (videoController.mPlayer == null)
			{
				return;
			}

			if (!fromuser)
			{
				// We're not interested in programmatically generated changes to
				// the progress bar's position.
				return;
			}

			long duration = videoController.mPlayer.getDuration();
			long newposition = (duration * progress) / 1000L;
			videoController.mPlayer.seekTo((int)newposition);
			if (videoController.mCurrentTime != null)
				videoController.mCurrentTime.Text = (videoController.StringForTime((int)newposition));
		}

		public void onStopTrackingTouch(SeekBar bar)
		{
			videoController.mDragging = false;
			videoController.SetProgress();
			videoController.updatePausePlay();
			videoController.Show(View_VideoController.sDefaultTimeout);

			// Ensure that progress is properly updated in the future,
			// the call to Show() does not guarantee this because it is a
			// no-op if we are already Showing.
			videoController.mHandler.SendEmptyMessage(View_VideoController.SHOW_PROGRESS);
		}

		public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
		{
			if (videoController.mPlayer == null)
			{
				return;
			}

			if (!fromUser)
			{
				// We're not interested in programmatically generated changes to
				// the progress bar's position.
				return;
			}

			long duration = videoController.mPlayer.getDuration();
			long newposition = (duration * progress) / 1000L;
			videoController.mPlayer.seekTo((int)newposition);
			if (videoController.mCurrentTime != null)
			{
				videoController.mCurrentTime.Text = (videoController.StringForTime((int)newposition));
			}
		}

		public void OnStopTrackingTouch(SeekBar seekBar)
		{
			videoController.mDragging = false;
			videoController.SetProgress();
			videoController.updatePausePlay();
			videoController.Show(View_VideoController.sDefaultTimeout);

			// Ensure that progress is properly updated in the future,
			// the call to show() does not guarantee this because it is a
			// no-op if we are already showing.
			videoController.mHandler.SendEmptyMessage(View_VideoController.SHOW_PROGRESS);
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

