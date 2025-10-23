using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace AQ.Dialogs
{
	// Token: 0x020000AD RID: 173
	public class AppStatus : DialogFragment
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0001E388 File Offset: 0x0001C588
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558506, container, false);
			this.mOkBtn = this.view.FindViewById<Button>(2131361967);
			this.mCloseBtn = this.view.FindViewById<ImageView>(2131361968);
			this.mOkBtn.Click += this.MOkBtn_Click;
			this.mCloseBtn.Click += this.MCloseBtn_Click;
			return this.view;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001E41D File Offset: 0x0001C61D
		private void MCloseBtn_Click(object sender, EventArgs e)
		{
			base.Activity.Finish();
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001E41D File Offset: 0x0001C61D
		private void MOkBtn_Click(object sender, EventArgs e)
		{
			base.Activity.Finish();
		}

		// Token: 0x040004C3 RID: 1219
		private View view;

		// Token: 0x040004C4 RID: 1220
		private Button mOkBtn;

		// Token: 0x040004C5 RID: 1221
		private ImageView mCloseBtn;
	}
}
