// //
// //Cell_Choice.cs$
// //
// // Author:
// //       Bruneel Robin <robin@bazookas.be>
// //
// // Copyright (c) 2015 Robin Bruneel
using System;
using Android.Widget;
using Test_ImageLoading;
using Android.Support.V7.Widget;

namespace Bazookas.RecyclerViewCells
{
	public class Cell_Choice: LinearLayout
	{
		#region delegates

		#endregion

		#region variables

		#endregion

		#region properties

		public View_Button_Overlay_Oval Done_Button {
			get;
			set;
		}

		public TextView TxtChoice {
			get;
			set;
		}

		public string Choice {
			get;
			set;
		}

		#endregion

		#region constructor

		public Cell_Choice (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer)
		{
			initialize ();
		}

		public Cell_Choice (Android.Content.Context context) : base (context)
		{
			initialize ();
		}

		public Cell_Choice (Android.Content.Context context, Android.Util.IAttributeSet attrs) : base (context, attrs)
		{
			initialize ();
		}

		public Cell_Choice (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyle) : base (context, attrs, defStyle)
		{
			initialize ();
		}

		#endregion

		#region public methods

		public void SetData(string choice){
			TxtChoice.Text = choice;
		}

		#region overided methods

		protected override void OnFinishInflate ()
		{
			base.OnFinishInflate ();

			TxtChoice = this.FindViewById<TextView> (Resource.Id.choice_text);

			TxtChoice.Text = "Choice";
		}

		#endregion

		#endregion

		#region private methods

		void initialize ()
		{
			Inflate (this.Context, Resource.Layout.Cell_Dialog_Fragment, this);
			OnFinishInflate ();
		}

		#endregion


	}
}

