// //
// //Fragment_Dialog.cs$
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
using Android.Util;
using Android.Views;
using Android.Widget;
using Test_ImageLoading;
using Android.Support.V7.App;
using Bazookas.RecyclerViewCells;

namespace Bazookas.Fragments
{
	public class Fragment_Dialog : AppCompatDialogFragment
	{
		#region delegates

		#endregion

		#region variables

		#endregion

		#region properties

		public IList<string> Choices {
			get;
			set;
		}

		public LinearLayout ChoiceContainer {
			get;
			set;
		}

		#endregion

		#region constructor
		public Fragment_Dialog (IList<string> choices)
		{
			this.Choices = choices;
		}
		
		#endregion

		#region public methods

		#region overided methods

		#region viewlifecycle


		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.Fragment_Dialog_Card_ListPicker ,container, false);

			ChoiceContainer = view.FindViewById<LinearLayout> (Resource.Id.choiceContainer);

			setChoices ();

			return view;
		}

		public override Dialog OnCreateDialog (Bundle savedInstanceState)
		{
			Dialog dialog = base.OnCreateDialog(savedInstanceState);
			// request a window without the title
//			dialog.Window.RequestFeature(WindowFeatures.NoTitle);
			return dialog;

		}

		#endregion

		#endregion

		#endregion

		#region private methods

		void setChoices(){
			ChoiceContainer.RemoveAllViews ();
			Cell_Choice cell = null;

			foreach (var item in Choices) {
				cell = new Cell_Choice (this.Context);
				cell.SetData (item);
				ChoiceContainer.AddView (cell);
			}
		}
		#endregion

	}
}

