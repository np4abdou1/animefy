using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;

namespace AQ.Dialogs
{
	// Token: 0x020000AB RID: 171
	public class AccountActivation : DialogFragment
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0001DE7C File Offset: 0x0001C07C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.email = base.Arguments.GetString("Email");
			this.fullname = base.Arguments.GetString("FullName");
			this.username = base.Arguments.GetString("UserName");
			this.password = base.Arguments.GetString("Password");
			this.view = inflater.Inflate(2131558617, container, false);
			this.mOkBtn = this.view.FindViewById<Button>(2131362260);
			this.mResendBtn = this.view.FindViewById<Button>(2131362261);
			this.mLoader = this.view.FindViewById<ProgressBar>(2131362259);
			this.mOkBtn.Click += this.MOkBtn_Click;
			this.mResendBtn.Click += this.MResendBtn_Click;
			return this.view;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0001DF80 File Offset: 0x0001C180
		private void MResendBtn_Click(object sender, EventArgs e)
		{
			try
			{
				this.mResendBtn.Visibility = ViewStates.Gone;
				this.mLoader.Visibility = ViewStates.Visible;
				ActivationMail.SendActivationMailApis(this.view.Context, base.Resources.GetString(2131951706), this.email);
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951656), 0);
				this.Dismiss();
			}
			catch
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951905), 0);
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MOkBtn_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x040004AD RID: 1197
		private View view;

		// Token: 0x040004AE RID: 1198
		private Button mOkBtn;

		// Token: 0x040004AF RID: 1199
		private Button mResendBtn;

		// Token: 0x040004B0 RID: 1200
		private ProgressBar mLoader;

		// Token: 0x040004B1 RID: 1201
		private string email;

		// Token: 0x040004B2 RID: 1202
		private string fullname;

		// Token: 0x040004B3 RID: 1203
		private string username;

		// Token: 0x040004B4 RID: 1204
		private string password;
	}
}
