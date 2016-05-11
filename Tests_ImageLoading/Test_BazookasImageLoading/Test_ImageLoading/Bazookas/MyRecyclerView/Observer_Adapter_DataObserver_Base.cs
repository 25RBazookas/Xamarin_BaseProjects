// //
// //Observer_Adapter_DataObserver_Base.cs$
// //
// // Author:
// //       Philippe Creytens <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;

namespace Bazookas.Kinepolis.Observers
{
	public interface IBaseAdapterDataObserverListener
	{
		void CheckIfEmpty();
	}

	public class Observer_Adapter_DataObserver_Base: Android.Support.V7.Widget.RecyclerView.AdapterDataObserver
	{

		#region delegates

		#endregion

		#region variables

		#endregion

		#region properties
		public IBaseAdapterDataObserverListener DataObserverListener {
			get;
			set;
		}
		#endregion

		#region constructor
		public Observer_Adapter_DataObserver_Base (IBaseAdapterDataObserverListener listener)
		{
			this.DataObserverListener = listener;
		}

		#endregion

		#region public methods

		#region overided methods

		public override void OnChanged ()
		{
			base.OnChanged ();
			DataObserverListener.CheckIfEmpty();
		}

		public override void OnItemRangeChanged (int positionStart, int itemCount)
		{
			base.OnItemRangeChanged (positionStart, itemCount);
			DataObserverListener.CheckIfEmpty();
		}

		public override void OnItemRangeInserted (int positionStart, int itemCount)
		{
			base.OnItemRangeInserted (positionStart, itemCount);
			DataObserverListener.CheckIfEmpty();
		}

		public override void OnItemRangeMoved (int fromPosition, int toPosition, int itemCount)
		{
			base.OnItemRangeMoved (fromPosition, toPosition, itemCount);
			DataObserverListener.CheckIfEmpty();
		}

		public override void OnItemRangeRemoved (int positionStart, int itemCount)
		{
			base.OnItemRangeRemoved (positionStart, itemCount);
			DataObserverListener.CheckIfEmpty();
		}
		#endregion

		#endregion

		#region private methods

		#endregion



	}


}

