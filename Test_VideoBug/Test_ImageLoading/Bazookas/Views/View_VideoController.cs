using System;
using Android.Content;
using Android.OS;
using Android.Text.Format;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.Util;
using Test_ImageLoading;

namespace Test_ImageLoading
{
	public class View_VideoController : LinearLayout, View.IOnClickListener
	{
		#region variables
		static string TAG = "VideoControllerView";
		const int FORWARD_BACKWARD_PLAYTIME = 5000;

		public IMediaPlayerControl mPlayer;
		Context mContext;
		ViewGroup mAnchor;
		View mRoot;
		ProgressBar mProgress;
		public TextView mEndTime, mCurrentTime;
		public bool mShowing;
		public bool mDragging;
		public const int sDefaultTimeout = 300000;
		public const int FADE_OUT = 1;
		public const int SHOW_PROGRESS = 2;
		bool mUseFastForward;
		bool mFromXml;
		bool mListenersSet;
		View.IOnClickListener mNextListener, mPrevListener;
		StringBuilder mFormatBuilder;
		Java.Util.Formatter mFormatter;
		ImageButton mPauseButton;
		ImageButton mFfwdButton;
		ImageButton mRewButton;
		ImageButton mNextButton;
		ImageButton mPrevButton;
		ImageButton mFullscreenButton;
		public Handler mHandler;
		#endregion

		#region properties
		#endregion

		#region constructors
		public View_VideoController(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			mRoot = null;
			mContext = context;
			mUseFastForward = true;
			mFromXml = true;
			mHandler = new MessageHandler(this);
		}

		public View_VideoController(Context context, bool useFastForward) : base(context)
		{
			mContext = context;
			mUseFastForward = useFastForward;
			mHandler = new MessageHandler(this);
		}
		#endregion

		#region public methods
		#region View.IOnClickListener
		public void OnClick(View v)
		{
			if (v.Id == mRewButton.Id)
			{
				if (mPlayer == null)
				{
					return;
				}
				int pos = mPlayer.getCurrentPosition();
				pos -= 5000; // milliseconds
				mPlayer.seekTo(pos);
				SetProgress();

				Show(sDefaultTimeout);
			}
			else if (v.Id == mFfwdButton.Id)
			{
				if (mPlayer == null)
				{
					return;
				}
				int pos = mPlayer.getCurrentPosition();
				pos += 5000; // milliseconds
				mPlayer.seekTo(pos);
				SetProgress();
				Show(sDefaultTimeout);
			}
			else if (v.Id == mPauseButton.Id )
			{
				doPauseResume();
				Show(sDefaultTimeout);
			}
			else if (v.Id == mFullscreenButton.Id)
			{
				doToggleFullscreen();
				Show(sDefaultTimeout);
			}
		}
		#endregion

		#region MyRegion	

		public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
		{
		}

		public void OnStartTrackingTouch(SeekBar seekBar)
		{
		}

		public void OnStopTrackingTouch(SeekBar seekBar)
		{

		}

		#endregion


		public void setMediaPlayer(IMediaPlayerControl player)
		{
			mPlayer = player;
			updatePausePlay();
			updateFullScreen();
		}

		/**
		 * Set the view that acts as the anchor for the control view.
		 * This can for example be a VideoView, or your Activity's main view.
		 * @param view The view to which to anchor the controller when it is visible.
		 */
		public void setAnchorView(ViewGroup view)
		{
			mAnchor = view;

			FrameLayout.LayoutParams frameParams = new FrameLayout.LayoutParams(
				ViewGroup.LayoutParams.MatchParent,
					ViewGroup.LayoutParams.MatchParent
			);

			RemoveAllViews();
			View v = makeControllerView();
			AddView(v, frameParams);
		}

		/**
		 * Create the view that holds the widgets that control playback.
		 * Derived classes can override this to create their own.
		 * @return The controller view.
		 * @hide This doesn't work as advertised
		 */
		protected View makeControllerView()
		{
			LayoutInflater inflate = (LayoutInflater)mContext.GetSystemService(Context.LayoutInflaterService);
			mRoot = inflate.Inflate(Resource.Layout.View_MediaController, null);

			initControllerView(mRoot);

			return mRoot;
		}
		/**
		 * Show the controller on screen. It will go away
		 * automatically after 3 seconds of inactivity.
		 */
		public void Show()
		{
			Show(sDefaultTimeout);
		}

		public void setPrevNextListeners(View.IOnClickListener next, View.IOnClickListener prev)
		{
			mNextListener = next;
			mPrevListener = prev;
			mListenersSet = true;

			if (mRoot != null)
			{
				installPrevNextListeners();

				if (mNextButton != null && !mFromXml)
				{
					mNextButton.Visibility = (ViewStates.Visible);
				}
				if (mPrevButton != null && !mFromXml)
				{
					mPrevButton.Visibility = (ViewStates.Visible);
				}
			}
		}
		public bool isShowing()
		{
			return mShowing;
		}

		/**
		 * Remove the controller from the screen.
		 */
		public void hide()
		{
			if (mAnchor == null)
			{
				return;
			}

			try
			{
				mAnchor.RemoveView(this);
				mHandler.RemoveMessages(SHOW_PROGRESS);
			}
			catch (IllegalArgumentException ex)
			{
				Console.WriteLine("MediaController", "already removed");
			}
			mShowing = false;
		}

		public void updatePausePlay()
		{
			if (mRoot == null || mPauseButton == null || mPlayer == null)
			{
				return;
			}

			if (mPlayer.isPlaying())
			{
				mPauseButton.SetImageResource(Resource.Drawable.ic_media_pause);
			}
			else {
				mPauseButton.SetImageResource(Resource.Drawable.ic_media_play);
			}
		}

		public void updateFullScreen()
		{
			if (mRoot == null || mFullscreenButton == null || mPlayer == null)
			{
				return;
			}

			if (mPlayer.isFullScreen())
			{
				mFullscreenButton.SetImageResource(Resource.Drawable.ic_media_fullscreen_shrink);
			}
			else {
				mFullscreenButton.SetImageResource(Resource.Drawable.ic_media_fullscreen_stretch);
			}
		}

		/**
		 * Show the controller on screen. It will go away
		 * automatically after 'timeout' milliseconds of inactivity.
		 * @param timeout The timeout in milliseconds. Use 0 to show
		 * the controller until hide() is called.
		 */
		public void Show(int timeout)
		{
			if (!mShowing && mAnchor != null)
			{
				SetProgress();
				if (mPauseButton != null)
				{
					mPauseButton.RequestFocus();
				}
				disableUnsupportedButtons();

				FrameLayout.LayoutParams tlp = new FrameLayout.LayoutParams(
					ViewGroup.LayoutParams.MatchParent,
					ViewGroup.LayoutParams.WrapContent,
					GravityFlags.Bottom
				);

				mAnchor.AddView(this, tlp);
				mShowing = true;
			}
			updatePausePlay();
			updateFullScreen();

			// cause the progress bar to be updated even if mShowing
			// was already true.  This happens, for example, if we're
			// paused with the progress bar showing the user hits play.
			mHandler.SendEmptyMessage(SHOW_PROGRESS);

			Message msg = mHandler.ObtainMessage(FADE_OUT);
			if (timeout != 0)
			{
				mHandler.RemoveMessages(FADE_OUT);
				mHandler.SendMessageDelayed(msg, timeout);
			}
		}

		public int SetProgress()
		{
			if (mPlayer == null || mDragging)
			{
				return 0;
			}

			int position = mPlayer.getCurrentPosition();
			int duration = mPlayer.getDuration();
			if (mProgress != null)
			{
				if (duration > 0)
				{
					// use long to avoid overflow
					long pos = 1000L * position / duration;
					mProgress.Progress = ((int)pos);
				}
				int percent = mPlayer.getBufferPercentage();
				mProgress.SecondaryProgress = (percent * 10);
			}

			if (mEndTime != null)
				mEndTime.Text = (StringForTime(duration));
			if (mCurrentTime != null)
				mCurrentTime.Text = (StringForTime(position));

			return position;
		}

		public string StringForTime(int timeMs)
		{
			int totalSeconds = timeMs / 1000;

			int seconds = totalSeconds % 60;
			int minutes = (totalSeconds / 60) % 60;
			int hours = totalSeconds / 3600;

			mFormatBuilder.SetLength(0);
			if (hours > 0)
			{
				return mFormatter.Format("%d:%02d:%02d", hours, minutes, seconds).ToString();
			}
			else {
				return mFormatter.Format("%02d:%02d", minutes, seconds).ToString();
			}
		}
		#region overrided methods

		public override bool Enabled
		{
			get
			{
				return base.Enabled;
			}
			set
			{
				if (mPauseButton != null)
				{
					mPauseButton.Enabled = (value);
				}
				if (mFfwdButton != null)
				{
					mFfwdButton.Enabled = (value);
				}
				if (mRewButton != null)
				{
					mRewButton.Enabled = (value);
				}
				if (mNextButton != null)
				{
					mNextButton.Enabled = (value && mNextListener != null);
				}
				if (mPrevButton != null)
				{
					mPrevButton.Enabled = (value && mPrevListener != null);
				}
				if (mProgress != null)
				{
					mProgress.Enabled = (value);
				}
				disableUnsupportedButtons();
				base.Enabled = value;
			}
		}

		protected override void OnFinishInflate()
		{
			if (mRoot != null)
			{
				initControllerView(mRoot);
			}
		}

		public override bool OnTouchEvent(MotionEvent myEvent)
		{
			Show(sDefaultTimeout);
			return true;
		}

		public override bool OnTrackballEvent(MotionEvent ev)
		{
			Show(sDefaultTimeout);
			return false;
		}

		public override bool DispatchKeyEvent(KeyEvent myEvent)
		{
			if (mPlayer == null)
			{
				return true;
			}

			int keyCode = myEvent.KeyCode.GetHashCode();
			bool uniqueDown = myEvent.RepeatCount == 0 && myEvent.Action == KeyEventActions.Down;

			if (keyCode == Keycode.Headsethook.GetHashCode()
				|| keyCode == Keycode.MediaPlayPause.GetHashCode()
				|| keyCode == Keycode.Space.GetHashCode())
			{
				if (uniqueDown)
				{
					doPauseResume();
					Show(sDefaultTimeout);
					if (mPauseButton != null)
					{
						mPauseButton.RequestFocus();
					}
				}
				return true;
			}
			else if (keyCode == Keycode.MediaPlay.GetHashCode())
			{
				if (uniqueDown && !mPlayer.isPlaying())
				{
					mPlayer.start();
					updatePausePlay();
					Show(sDefaultTimeout);
				}
				return true;
			}
			else if (keyCode == Keycode.MediaStop.GetHashCode()
					 || keyCode == Keycode.MediaPause.GetHashCode())
			{
				if (uniqueDown && mPlayer.isPlaying())
				{
					mPlayer.pause();
					updatePausePlay();
					Show(sDefaultTimeout);
				}
				return true;
			}
			else if (keyCode == Keycode.VolumeDown.GetHashCode()
					 || keyCode == Keycode.VolumeUp.GetHashCode()
					 || keyCode == Keycode.VolumeMute.GetHashCode())
			{
				// don't show the controls for volume adjustment
				return base.DispatchKeyEvent(myEvent);
			}
			else if (keyCode == Keycode.Back.GetHashCode() || keyCode == Keycode.Menu.GetHashCode())
			{
				if (uniqueDown)
				{
					hide();
				}
				return true;
			}


			Show(sDefaultTimeout);
			return base.DispatchKeyEvent(myEvent);
		}


		#region viewlifecycle
		#endregion
		#endregion
		#endregion

		#region private methods
		void initControllerView(View v)
		{
			mPauseButton = (ImageButton)v.FindViewById(Resource.Id.pause);
			if (mPauseButton != null)
			{
				mPauseButton.RequestFocus();
				mPauseButton.SetOnClickListener(this);
			}

			mFullscreenButton = (ImageButton)v.FindViewById(Resource.Id.fullscreen);
			if (mFullscreenButton != null)
			{
				mFullscreenButton.RequestFocus();
				mFullscreenButton.SetOnClickListener(this);
			}

			mFfwdButton = (ImageButton)v.FindViewById(Resource.Id.ffwd);
			if (mFfwdButton != null)
			{
				mFfwdButton.SetOnClickListener(this);
				if (!mFromXml)
				{
					mFfwdButton.Visibility = mUseFastForward ? ViewStates.Visible : ViewStates.Gone;
				}
			}

			mRewButton = (ImageButton)v.FindViewById(Resource.Id.rew);
			if (mRewButton != null)
			{
				mRewButton.SetOnClickListener(this);
				if (!mFromXml)
				{
					mRewButton.Visibility = (mUseFastForward ? ViewStates.Visible : ViewStates.Gone);
				}
			}

			// By default these are hidden. They will be enabled when setPrevNextListeners() is called 
			mNextButton = (ImageButton)v.FindViewById(Resource.Id.next);
			if (mNextButton != null && !mFromXml && !mListenersSet)
			{
				mNextButton.Visibility = (ViewStates.Gone);
			}
			mPrevButton = (ImageButton)v.FindViewById(Resource.Id.prev);
			if (mPrevButton != null && !mFromXml && !mListenersSet)
			{
				mPrevButton.Visibility = (ViewStates.Gone);
			}

			mProgress = (ProgressBar)v.FindViewById(Resource.Id.mediacontroller_progress);
			if (mProgress != null)
			{
				if (mProgress.GetType() == typeof(SeekBar))
				{
					SeekBar seeker = (SeekBar)mProgress;
					seeker.SetOnSeekBarChangeListener(new MyOnSeekBarChangeListener(this));
				}
				mProgress.Max = 1000;
			}

			mEndTime = (TextView)v.FindViewById(Resource.Id.time);
			mCurrentTime = (TextView)v.FindViewById(Resource.Id.time_current);
			mFormatBuilder = new StringBuilder();
			mFormatter = new Java.Util.Formatter(mFormatBuilder, Locale.Default);

			#region OnClickListeners
			mPauseButton.SetOnClickListener(this);
			mFfwdButton.SetOnClickListener(this);
			mRewButton.SetOnClickListener(this);
			#endregion

			installPrevNextListeners();
		}

		void doPauseResume()
		{
			if (mPlayer == null)
			{
				return;
			}

			if (mPlayer.isPlaying())
			{
				mPlayer.pause();
			}
			else {
				mPlayer.start();
			}
			updatePausePlay();
		}

		void doToggleFullscreen()
		{
			if (mPlayer == null)
			{
				return;
			}

			mPlayer.toggleFullScreen();
		}

		void installPrevNextListeners()
		{
			if (mNextButton != null)
			{
				mNextButton.SetOnClickListener(mNextListener);
				mNextButton.Enabled = (mNextListener != null);
			}

			if (mPrevButton != null)
			{
				mPrevButton.SetOnClickListener(mPrevListener);
				mPrevButton.Enabled = (mPrevListener != null);
			}
		}

		/**
		 * Disable pause or seek buttons if the stream cannot be paused or seeked.
		 * This requires the control interface to be a MediaPlayerControlExt
		 */
		void disableUnsupportedButtons()
		{
			if (mPlayer == null)
			{
				return;
			}

			try
			{
				if (mPauseButton != null && !mPlayer.canPause())
				{
					mPauseButton.Enabled = false;
				}
				if (mRewButton != null && !mPlayer.canSeekBackward())
				{
					mRewButton.Enabled = false;
				}
				if (mFfwdButton != null && !mPlayer.canSeekForward())
				{
					mFfwdButton.Enabled = false;
				}
			}
			catch (IncompatibleClassChangeError ex)
			{
				// We were given an old version of the interface, that doesn't have
				// the canPause/canSeekXYZ methods. This is OK, it just means we
				// assume the media can be paused and seeked, and so we don't disable
				// the buttons.
			}
		}



		#endregion

	}
}

