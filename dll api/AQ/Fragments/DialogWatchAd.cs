using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace AQ.Fragments
{
	// Token: 0x020000A1 RID: 161
	public class DialogWatchAd : DialogFragment
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001560C File Offset: 0x0001380C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558523, container, false);
			this.mWatchBtn = this.view.FindViewById<Button>(2131362298);
			this.mCancelBtn = this.view.FindViewById<Button>(2131362297);
			return this.view;
		}

		// Token: 0x040003A7 RID: 935
		private View view;

		// Token: 0x040003A8 RID: 936
		private Button mWatchBtn;

		// Token: 0x040003A9 RID: 937
		private Button mCancelBtn;
	}
}
