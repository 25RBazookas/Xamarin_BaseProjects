// //
// //Fragment_Video.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel

using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Lilarcor.Cheeseknife;
using Test_ImageLoading;
using Android.Media;
using Android.Net;
using Android.Graphics;
using Android.Runtime;
using System;

namespace Bazookas.Fragments
{
	public interface IStopCurrentHandling
	{
		void StopCurrentHandling();
	}

	public class Fragment_Video_MediaCenter : Android.Support.V4.App.Fragment,
	                                                 ISurfaceHolderCallback, 
	                                                 MediaPlayer.IOnPreparedListener,
	                                                 IMediaPlayerControl
	{

		#region delegates

		#endregion

		#region variables
		MediaPlayer mediaPlayer;
		ISurfaceHolder vidHolder;
		[InjectView(Resource.Id.videoSurface)]
		SurfaceView vidSurface;
		string vidAddress = "http://www.w3schools.com/html/mov_bbb.mp4";

		View_VideoController controller;


		#endregion

		#region properties

		#endregion

		#region constructor

		#endregion

		#region public methods

		#region IMediaPlayerControl

		public void start()
		{
			mediaPlayer.Start();
		}

		public void pause()
		{
			mediaPlayer.Pause();
		}

		public int getDuration()
		{
			return mediaPlayer.Duration;
		}

		public int getCurrentPosition()
		{
			return mediaPlayer.CurrentPosition;
		}

		public void seekTo(int pos)
		{
			mediaPlayer.SeekTo(pos);
		}

		public bool isPlaying()
		{
			return mediaPlayer.IsPlaying;
		}

		public int getBufferPercentage()
		{
			return 0;
		}

		public bool canPause()
		{
			return true;
		}

		public bool canSeekBackward()
		{
			return true;
		}

		public bool canSeekForward()
		{
			return true;
		}

		public bool isFullScreen()
		{
			return false;
		}

		public void toggleFullScreen()
		{
			//DO NOTHING
		}
		#endregion

		#region overided methods

		#region viewlifecycle

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.Fragment_SurfaceView, container, false);

			#region INJECTION
			Cheeseknife.Inject (this, view);
			#endregion

			vidHolder = vidSurface.Holder;
			vidHolder.AddCallback(this);

			controller = new View_VideoController(this.Context, useFastForward:true);
			view.Touch += viewTouchedHandler;

			return view;
		}

		public override void OnDestroyView()
		{
			this.View.Touch -= viewTouchedHandler;
			base.OnDestroyView();
		}

		public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
		{
			
		}

		public void SurfaceCreated(ISurfaceHolder holder)
		{
			try
			{
				mediaPlayer = new MediaPlayer();
				mediaPlayer.SetDisplay(vidHolder);
				mediaPlayer.SetDataSource(vidAddress);
				mediaPlayer.Prepare();
				mediaPlayer.SetOnPreparedListener(this);
				mediaPlayer.SetAudioStreamType(Stream.Music);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		public void SurfaceDestroyed(ISurfaceHolder holder)
		{
			if (mediaPlayer!=null)
			{
				mediaPlayer.Stop();
				mediaPlayer.Release();
				mediaPlayer = null;
			}
		}

		public void OnPrepared(MediaPlayer mp)
		{
			controller.setMediaPlayer(this);
			controller.setAnchorView((FrameLayout) this.View.FindViewById<FrameLayout>(Resource.Id.videoSurfaceContainer));
			mediaPlayer.Start();
		}

		#endregion

		#endregion

		#endregion

		#region private methods

		void viewTouchedHandler(object sender, View.TouchEventArgs e)
		{
			controller.Show();
		}

		#endregion
	}
}

