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
	// Token: 0x020000BC RID: 188
	public class WatchBy : DialogFragment
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000250B8 File Offset: 0x000232B8
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.streamLink = base.Arguments.GetString("StreamLink");
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558524, container, false);
			this.mMXPlayerWatch = this.view.FindViewById<LinearLayout>(2131363288);
			this.mOtherAppsWatch = this.view.FindViewById<LinearLayout>(2131363289);
			this.mMXPlayerWatch.Click += this.MMXPlayerWatch_Click;
			this.mOtherAppsWatch.Click += this.MOtherAppsWatch_Click;
			return this.view;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00025164 File Offset: 0x00023364
		private void MOtherAppsWatch_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(this.streamLink));
			intent.SetDataAndType(Android.Net.Uri.Parse(this.streamLink), "video/mp4");
			this.StartActivity(intent);
			this.Dismiss();
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000251AC File Offset: 0x000233AC
		private void MMXPlayerWatch_Click(object sender, EventArgs e)
		{
			string text = "com.mxtech.videoplayer.ad";
			string text2 = "com.mxtech.videoplayer.pro";
			Intent launchIntentForPackage = this.view.Context.PackageManager.GetLaunchIntentForPackage(text);
			Intent launchIntentForPackage2 = this.view.Context.PackageManager.GetLaunchIntentForPackage(text2);
			if (launchIntentForPackage2 != null)
			{
				Intent intent = new Intent("android.intent.action.VIEW");
				intent.SetPackage(text2);
				intent.SetDataAndType(Android.Net.Uri.Parse(this.streamLink), "video/mp4");
				this.StartActivity(intent);
			}
			else if (launchIntentForPackage != null)
			{
				Intent intent2 = new Intent("android.intent.action.VIEW");
				intent2.SetPackage(text);
				intent2.SetDataAndType(Android.Net.Uri.Parse(this.streamLink), "video/mp4");
				this.StartActivity(intent2);
			}
			else
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952215), 0);
				this.StartActivity(new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse("market://details?id=" + text)));
			}
			this.Dismiss();
		}

		// Token: 0x04000587 RID: 1415
		private View view;

		// Token: 0x04000588 RID: 1416
		private LinearLayout mMXPlayerWatch;

		// Token: 0x04000589 RID: 1417
		private LinearLayout mOtherAppsWatch;

		// Token: 0x0400058A RID: 1418
		private string streamLink;
	}
}
