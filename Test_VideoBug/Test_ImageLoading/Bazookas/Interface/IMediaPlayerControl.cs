using System;
namespace Test_ImageLoading
{
	public interface IMediaPlayerControl
	{
		void start();
		void pause();
		int getDuration();
		int getCurrentPosition();
		void seekTo(int pos);
		bool isPlaying();
		int getBufferPercentage();
		bool canPause();
		bool canSeekBackward();
		bool canSeekForward();
		bool isFullScreen();
		void toggleFullScreen();
	}
}

