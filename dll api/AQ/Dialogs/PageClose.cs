using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace AQ.Dialogs
{
	// Token: 0x020000B6 RID: 182
	public class PageClose : DialogFragment
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000244B4 File Offset: 0x000226B4
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.title = base.Arguments.GetString("DialogTitle");
			this.messgae = base.Arguments.GetString("DialogMessage");
			this.view = inflater.Inflate(2131558509, container, false);
			this.mLock = this.view.FindViewById<LinearLayout>(2131362278);
			this.mTitle = this.view.FindViewById<TextView>(2131362295);
			this.mTitle.Text = this.title;
			this.mMessage = this.view.FindViewById<TextView>(2131362279);
			this.mMessage.Text = this.messgae;
			this.mLock.Click += this.MLock_Click;
			return this.view;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MLock_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x0400056A RID: 1386
		private View view;

		// Token: 0x0400056B RID: 1387
		private TextView mTitle;

		// Token: 0x0400056C RID: 1388
		private TextView mMessage;

		// Token: 0x0400056D RID: 1389
		private LinearLayout mLock;

		// Token: 0x0400056E RID: 1390
		private string title;

		// Token: 0x0400056F RID: 1391
		private string messgae;
	}
}
