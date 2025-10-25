using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Activities;

namespace AQ.Fragments
{
	// Token: 0x0200009C RID: 156
	public class DialogSigninPrompt : DialogFragment
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x000142C4 File Offset: 0x000124C4
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.onCancelFinish = base.Arguments.GetBoolean("IsOnCancelFinish", false);
			this.view = inflater.Inflate(2131558619, container, false);
			this.view.FindViewById<TextView>(2131362281).Text = base.Arguments.GetString("Message", "N/A");
			this.mSigninBtn = this.view.FindViewById<Button>(2131362289);
			this.mCancelBtn = this.view.FindViewById<Button>(2131362288);
			this.mSigninBtn.Click += this.MSigninBtn_Click;
			this.mCancelBtn.Click += this.MCancelBtn_Click;
			return this.view;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001439A File Offset: 0x0001259A
		private void MCancelBtn_Click(object sender, EventArgs e)
		{
			if (this.onCancelFinish)
			{
				base.Activity.Finish();
				return;
			}
			this.Dismiss();
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000143B6 File Offset: 0x000125B6
		private void MSigninBtn_Click(object sender, EventArgs e)
		{
			this.view.Context.StartActivity(typeof(SignInUpDashboard));
			if (!this.onCancelFinish)
			{
				this.Dismiss();
			}
		}

		// Token: 0x0400036C RID: 876
		private View view;

		// Token: 0x0400036D RID: 877
		private Button mSigninBtn;

		// Token: 0x0400036E RID: 878
		private Button mCancelBtn;

		// Token: 0x0400036F RID: 879
		private bool onCancelFinish;
	}
}
