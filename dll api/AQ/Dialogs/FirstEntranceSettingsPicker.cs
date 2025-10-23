using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;

namespace AQ.Dialogs
{
	// Token: 0x020000B4 RID: 180
	public class FirstEntranceSettingsPicker : DialogFragment
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x0002364C File Offset: 0x0002184C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558511, container, false);
			SharedPreferencesSaves.StringSharedPreferencesSave("IsFirstVisit", "NO");
			this.mBlueMode = this.view.FindViewById<View>(2131362290);
			this.mPinkMode = this.view.FindViewById<View>(2131362294);
			this.mDarkGrayMode = this.view.FindViewById<View>(2131362292);
			this.mDarkLightGrayMode = this.view.FindViewById<View>(2131362293);
			this.mBlueRadio = this.view.FindViewById<RadioButton>(2131361997);
			this.mPinkRadio = this.view.FindViewById<RadioButton>(2131362003);
			this.mDarkGrayRadio = this.view.FindViewById<RadioButton>(2131361999);
			this.mDarkLightGrayRadio = this.view.FindViewById<RadioButton>(2131362001);
			this.mCancelBtn = this.view.FindViewById<Button>(2131362291);
			this.mCancelBtn.Click += this.MCancelBtn_Click;
			this.mBlueMode.Click += this.MBlueMode_Click;
			this.mPinkMode.Click += this.MPinkMode_Click;
			this.mDarkGrayMode.Click += this.MDarkMode_Click;
			this.mDarkLightGrayMode.Click += this.MDarkLightGrayMode_Click;
			this.mBlueRadio.CheckedChange += this.MBlueRadio_CheckedChange;
			this.mPinkRadio.CheckedChange += this.MPinkRadio_CheckedChange;
			this.mDarkGrayRadio.CheckedChange += this.MDarkRadio_CheckedChange;
			this.mDarkLightGrayRadio.CheckedChange += this.MDarkLightGrayRadio_CheckedChange;
			return this.view;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0002382C File Offset: 0x00021A2C
		private void MDarkLightGrayRadio_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mPinkRadio.Checked = false;
				this.mBlueRadio.Checked = false;
				this.mDarkGrayRadio.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "DARK_GRAY");
				this.Dismiss();
				base.Activity.Recreate();
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00023888 File Offset: 0x00021A88
		private void MDarkRadio_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mPinkRadio.Checked = false;
				this.mBlueRadio.Checked = false;
				this.mDarkLightGrayRadio.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "DARK_GRAY");
				this.Dismiss();
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000238D8 File Offset: 0x00021AD8
		private void MPinkRadio_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mBlueRadio.Checked = false;
				this.mDarkGrayRadio.Checked = false;
				this.mDarkLightGrayRadio.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "PINK");
				this.Dismiss();
				base.Activity.Recreate();
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00023934 File Offset: 0x00021B34
		private void MBlueRadio_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mPinkRadio.Checked = false;
				this.mDarkGrayRadio.Checked = false;
				this.mDarkLightGrayRadio.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "BLUE");
				this.Dismiss();
				base.Activity.Recreate();
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0002398D File Offset: 0x00021B8D
		private void MDarkLightGrayMode_Click(object sender, EventArgs e)
		{
			this.mDarkLightGrayRadio.Checked = true;
			SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "LIGHT_GRAY");
			this.Dismiss();
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000239B0 File Offset: 0x00021BB0
		private void MDarkMode_Click(object sender, EventArgs e)
		{
			this.mDarkGrayRadio.Checked = true;
			SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "DARK_GRAY");
			this.Dismiss();
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000239D3 File Offset: 0x00021BD3
		private void MPinkMode_Click(object sender, EventArgs e)
		{
			this.mPinkRadio.Checked = true;
			SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "PINK");
			this.Dismiss();
			base.Activity.Recreate();
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00023A01 File Offset: 0x00021C01
		private void MBlueMode_Click(object sender, EventArgs e)
		{
			this.mBlueRadio.Checked = true;
			SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "BLUE");
			this.Dismiss();
			base.Activity.Recreate();
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00023A2F File Offset: 0x00021C2F
		private void MCancelBtn_Click(object sender, EventArgs e)
		{
			SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "DARK_GRAY");
			this.Dismiss();
		}

		// Token: 0x0400054A RID: 1354
		private View view;

		// Token: 0x0400054B RID: 1355
		private View mBlueMode;

		// Token: 0x0400054C RID: 1356
		private View mPinkMode;

		// Token: 0x0400054D RID: 1357
		private View mDarkGrayMode;

		// Token: 0x0400054E RID: 1358
		private View mDarkLightGrayMode;

		// Token: 0x0400054F RID: 1359
		private Button mCancelBtn;

		// Token: 0x04000550 RID: 1360
		private RadioButton mBlueRadio;

		// Token: 0x04000551 RID: 1361
		private RadioButton mPinkRadio;

		// Token: 0x04000552 RID: 1362
		private RadioButton mDarkGrayRadio;

		// Token: 0x04000553 RID: 1363
		private RadioButton mDarkLightGrayRadio;
	}
}
