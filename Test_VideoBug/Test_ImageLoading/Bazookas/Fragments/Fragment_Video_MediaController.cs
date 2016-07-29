// //
// //Fragment_Video_MediaController.cs$
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
using Test_ImageLoading;
using Android.Media;
using Com.Lilarcor.Cheeseknife;

namespace Bazookas.Fragments
{
	public class Fragment_Video_MediaController : Android.Support.V4.App.Fragment,  MediaPlayer.IOnBufferingUpdateListener, 
	MediaPlayer.IOnCompletionListener, MediaPlayer.IOnPreparedListener,
	MediaPlayer.IOnVideoSizeChangedListener, ISurfaceHolderCallback, View.IOnTouchListener
	{
		#region delegates

		#endregion

		#region variables
		private MediaPlayer mMediaPlayer;
		private MediaController mcontroller;
		private Handler handler = new Handler();
		#endregion

		#region properties


		[InjectView (Resource.Id.videoView)] 
		public VideoView MyVideoView {
			get;
			set;
		}


		#endregion

		#region constructor

		#endregion

		#region public methods

		public bool OnTouch (View v, MotionEvent e)
		{
//			mcontroller.Show ();
			return OnTouch (v, e);
		}

		public void OnBufferingUpdate (MediaPlayer mp, int percent)
		{
			
		}

		public void OnCompletion (MediaPlayer mp)
		{
			
		}

		public void OnVideoSizeChanged (MediaPlayer mp, int width, int height)
		{
			
		}


		public void OnPrepared (MediaPlayer mp)
		{
			Console.WriteLine (String.Format ("LOG: {0}", "on prepared"));
		}

		public void SurfaceChanged (ISurfaceHolder holder, Android.Graphics.Format format, int width, int height)
		{
			Console.WriteLine (String.Format ("LOG: {0}", "Surface changed"));
		}

		public void SurfaceCreated (ISurfaceHolder holder)
		{
			mMediaPlayer.SetDisplay(holder);
		}

		public void SurfaceDestroyed (ISurfaceHolder holder)
		{
			Console.WriteLine (String.Format ("LOG: {0}", "Surface destroyed"));
		}

		public void start() {
			mMediaPlayer.Start();
		}

		public void pause() {
			mMediaPlayer.Pause();
		}

		public int getDuration() {
			return mMediaPlayer.Duration;
		}

		public int getCurrentPosition() {
			return mMediaPlayer.CurrentPosition;
		}

		public void seekTo(int i) {
			mMediaPlayer.SeekTo(i);
		}

		public bool isPlaying() {
			return mMediaPlayer.IsPlaying; 
		}

		public int getBufferPercentage() {
			return 0;
		}

		public bool canPause() {
			return true;
		}

		public bool canSeekBackward() {
			return true;
		}

		public bool canSeekForward() {
			return true;
		}

		#region overided methods




		#region viewlifecycle

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.Fragment_Video, container, false);

			#region INJECTION
			Cheeseknife.Inject (this, view);
			#endregion

//			MyVideoView.SetOnTouchListener (this);

			ISurfaceHolder holder = MyVideoView.Holder;
			holder.SetType (SurfaceType.PushBuffers);
			holder.AddCallback( this );

			mMediaPlayer = new MediaPlayer();
			mMediaPlayer.SetDataSource("https://kinepolis.be/nl/sites/kinepolis.be.nl/files/trailers/Huntsman-The_TLR-A_S_EN-vls_BE_51_2K_UP_20151119_MPS_IOP_OV_480p.mp4");
			mMediaPlayer.Prepare();
			mMediaPlayer.Prepared += mediaPlayerPrepared;
			mcontroller = new MediaController(this.Activity);
			mcontroller.SetAnchorView (MyVideoView);
			MyVideoView.SetMediaController (mcontroller);

			return view;
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();

			mMediaPlayer.Stop ();
			mMediaPlayer.Release ();
			mMediaPlayer = null;


			Cheeseknife.Reset (this);
		}

		void mediaPlayerPrepared (object sender, EventArgs e)
		{
			mMediaPlayer.SetOnBufferingUpdateListener(this);
			mMediaPlayer.SetOnCompletionListener(this);
			mMediaPlayer.SetOnPreparedListener(this);
			mMediaPlayer.SetScreenOnWhilePlaying(true);
			mMediaPlayer.SetOnVideoSizeChangedListener(this);
			mMediaPlayer.SetAudioStreamType(Stream.Music);
			mMediaPlayer.Start ();
		}
		#endregion

		#endregion

		#endregion

		#region private methods

		#endregion


	}
}

