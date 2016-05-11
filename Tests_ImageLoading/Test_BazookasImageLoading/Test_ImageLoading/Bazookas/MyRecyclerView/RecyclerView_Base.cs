// //
// //RecyclerView_Base.cs$
// //
// // Author:
// //       Philippe Creytens <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Support.V7.Widget;
using Android.Content;
using Bazookas.Kinepolis.Observers;
using Android.Views;
using Android.Util;
using Android.Widget;
using Bazookas.Kinepolis.BL.Interfaces;
using Android.Graphics;
using Android.App;
using System.Collections.Generic;

namespace Bazookas.Kinepolis.CustomRecyclerViews
{
	public class RecyclerView_Base: RecyclerView, IBaseAdapterDataObserverListener
	{
		#region delegates

		#endregion

		#region variables

		#endregion

		#region properties
//		public TextView EmptyView {
//			get;
//			set;
//		}
		public ProgressBar EmptyView {
			get;
			set;
		}
		public RecyclerView.AdapterDataObserver DataObserver {
			get;
			set;
		}

		#endregion

		#region constructor
		public RecyclerView_Base(Context context): base(context) {
			initialize ();
		}

		public RecyclerView_Base(Context context, IAttributeSet attrs): base(context, attrs) {
			initialize ();
		}

		public RecyclerView_Base(Context context, IAttributeSet attrs, int defStyle): base(context, attrs, defStyle) {
			initialize ();
		}
		#endregion

		#region public methods

		public override void OnScrolled (int dx, int dy)
		{
			base.OnScrolled (dx, dy);
		}

		public override void OnScrollStateChanged (int state)
		{
			if (state == ScrollStateIdle) {
				GC.Collect ();
				(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).ContinueLoading ();
			} else if (state == ScrollStateSettling) {
				(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).PauseLoading ();
			} else {
				(AppController.Instance.BitmapCache as IBitmapCache<Bitmap>).ContinueLoading();
			}
		}

		public void CheckIfEmpty(){
			checkIfEmpty ();
		}
			
		public void SetEmptyView(ProgressBar emptyView) {
			this.EmptyView = emptyView;
			checkIfEmpty();
		}

		#region overided methods

		public override void SetAdapter (Adapter adapter)
		{
			Adapter oldAdapter = this.GetAdapter ();
			if (oldAdapter != null) {
				oldAdapter.UnregisterAdapterDataObserver(DataObserver);
			}
			base.SetAdapter(adapter);
			if (adapter != null) {
				adapter.RegisterAdapterDataObserver(DataObserver);
			}
			this.Visibility = ViewStates.Gone;
			checkIfEmpty();
		}

		#region viewlifecycle

		#endregion

		#endregion

		#endregion

		#region private methods

		void initialize(){
			try {
				this.DataObserver = new Observer_Adapter_DataObserver_Base(this);
			} catch (Exception ex) {
				BzLogging.SendException (ex);
			}
		}

		void checkIfEmpty() {
			if (EmptyView != null && this.GetAdapter() != null) {
				bool emptyViewVisible = this.GetAdapter().ItemCount == 0;
				EmptyView.Visibility = emptyViewVisible ? ViewStates.Visible : ViewStates.Gone;
				this.Visibility = emptyViewVisible ?  ViewStates.Gone : ViewStates.Visible;
			}
		}


		#endregion


	}
}

