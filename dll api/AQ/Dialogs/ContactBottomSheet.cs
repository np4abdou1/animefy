using System;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Views;
using Android.Widget;
using AQ.Helpers;
using Java.Lang;

namespace AQ.Dialogs
{
	// Token: 0x020000B2 RID: 178
	public class ContactBottomSheet : RoundedBottomSheet
	{
		// Token: 0x06000827 RID: 2087 RVA: 0x0002316C File Offset: 0x0002136C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558637, container, false);
			this.mMessengerBtn = this.view.FindViewById<Button>(2131362230);
			this.mIntegramBtn = this.view.FindViewById<Button>(2131362229);
			this.mMessengerBtn.Click += this.MMessengerBtn_Click;
			this.mIntegramBtn.Click += this.MIntegramBtn_Click;
			return this.view;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000231EC File Offset: 0x000213EC
		private void MIntegramBtn_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < ContactBottomSheet.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Intent intent = new Intent("android.intent.action.VIEW");
			intent.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("InstagramUrl")));
			this.StartActivity(intent);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00023240 File Offset: 0x00021440
		private void MMessengerBtn_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < ContactBottomSheet.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Intent intent = new Intent("android.intent.action.VIEW");
			intent.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("FacebookUrl")));
			this.StartActivity(intent);
		}

		// Token: 0x0400053B RID: 1339
		private View view;

		// Token: 0x0400053C RID: 1340
		private Button mMessengerBtn;

		// Token: 0x0400053D RID: 1341
		private Button mIntegramBtn;

		// Token: 0x0400053E RID: 1342
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x0400053F RID: 1343
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
