using System;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;

namespace AQ.Dialogs
{
	// Token: 0x020000AE RID: 174
	public class AppUpdate : DialogFragment
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001E42C File Offset: 0x0001C62C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.newRequiredVersion = base.Arguments.GetInt("RequiredVersion");
			this.appNamespace = base.Arguments.GetString("AppNamespace");
			this.appDownloadLink = base.Arguments.GetString("AppDownloadLink");
			this.skipability = base.Arguments.GetBoolean("Skipability", true);
			this.notification = base.Arguments.GetInt("Notification");
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558521, container, false);
			this.mVersion = this.view.FindViewById<TextView>(2131363199);
			this.mMessage = this.view.FindViewById<TextView>(2131363198);
			this.mUpdateBtn = this.view.FindViewById<Button>(2131363196);
			this.mSkipBtn = this.view.FindViewById<Button>(2131363072);
			this.mCloseBtn = this.view.FindViewById<ImageView>(2131363197);
			if (this.newRequiredVersion != 0)
			{
				this.Init();
			}
			if (this.skipability)
			{
				this.mMessage.Text = this.view.Resources.GetString(2131952411);
				this.mSkipBtn.Visibility = ViewStates.Visible;
			}
			this.mUpdateBtn.Click += this.MUpdateBtn_Click;
			this.mSkipBtn.Click += this.MSkipBtn_Click;
			this.mCloseBtn.Click += this.MCloseBtn_Click;
			return this.view;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001E5CB File Offset: 0x0001C7CB
		private void MSkipBtn_Click(object sender, EventArgs e)
		{
			SharedPreferencesSaves.IntSharedPreferencesSave("UpdateNotificationNo", this.notification);
			this.Dismiss();
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0001E5E3 File Offset: 0x0001C7E3
		private void MCloseBtn_Click(object sender, EventArgs e)
		{
			if (this.skipability)
			{
				SharedPreferencesSaves.IntSharedPreferencesSave("UpdateNotificationNo", this.notification);
				this.Dismiss();
				return;
			}
			base.Activity.Finish();
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0001E610 File Offset: 0x0001C810
		private void MUpdateBtn_Click(object sender, EventArgs e)
		{
			if (this.skipability)
			{
				SharedPreferencesSaves.IntSharedPreferencesSave("UpdateNotificationNo", this.notification);
				this.Dismiss();
			}
			try
			{
				this.StartActivity(new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(this.appNamespace)));
			}
			catch
			{
				this.StartActivity(new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(this.appDownloadLink)));
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0001E688 File Offset: 0x0001C888
		private void Init()
		{
			string text = "";
			string text2 = this.newRequiredVersion.ToString();
			for (int i = 0; i < text2.Length; i++)
			{
				text = text + text2[i].ToString() + ".";
			}
			this.mVersion.Text = "v" + text.Substring(0, text.Length - 1);
		}

		// Token: 0x040004C6 RID: 1222
		private View view;

		// Token: 0x040004C7 RID: 1223
		private TextView mVersion;

		// Token: 0x040004C8 RID: 1224
		private TextView mMessage;

		// Token: 0x040004C9 RID: 1225
		private Button mUpdateBtn;

		// Token: 0x040004CA RID: 1226
		private Button mSkipBtn;

		// Token: 0x040004CB RID: 1227
		private ImageView mCloseBtn;

		// Token: 0x040004CC RID: 1228
		private int newRequiredVersion;

		// Token: 0x040004CD RID: 1229
		private int notification;

		// Token: 0x040004CE RID: 1230
		private string appNamespace;

		// Token: 0x040004CF RID: 1231
		private string appDownloadLink;

		// Token: 0x040004D0 RID: 1232
		private bool skipability;
	}
}
