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
	// Token: 0x020000B3 RID: 179
	public class DownloadBy : DialogFragment
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000232B4 File Offset: 0x000214B4
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.downloadLink = base.Arguments.GetString("DownloadLink");
			this.title = base.Arguments.GetString("Title");
			this.fileName = base.Arguments.GetString("FileName");
			this.type = base.Arguments.GetString("Type");
			this.fileSize = base.Arguments.GetString("FileSize");
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558510, container, false);
			this.mBasicDownload = this.view.FindViewById<LinearLayout>(2131362310);
			this.mADMDownload = this.view.FindViewById<LinearLayout>(2131362309);
			this.mOthersDownload = this.view.FindViewById<LinearLayout>(2131362312);
			this.mFileName = this.view.FindViewById<TextView>(2131362311);
			if (this.fileSize == "")
			{
				this.mFileName.Visibility = ViewStates.Gone;
			}
			else
			{
				try
				{
					this.mFileName.Text = "(" + Calculators.GetSizeOfNum(int.Parse(this.fileSize)) + ")";
				}
				catch
				{
				}
			}
			this.mBasicDownload.Click += this.MBasicDownload_Click;
			this.mADMDownload.Click += this.MADMDownload_Click;
			this.mOthersDownload.Click += this.MOthersDownload_Click;
			return this.view;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0002345C File Offset: 0x0002165C
		private void MOthersDownload_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.VIEW");
			intent.SetData(Android.Net.Uri.Parse(this.downloadLink));
			this.StartActivity(intent);
			this.Dismiss();
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00023494 File Offset: 0x00021694
		private void MADMDownload_Click(object sender, EventArgs e)
		{
			string text = "com.dv.adm";
			string text2 = "com.dv.adm.pay";
			Intent launchIntentForPackage = this.view.Context.PackageManager.GetLaunchIntentForPackage(text);
			Intent launchIntentForPackage2 = this.view.Context.PackageManager.GetLaunchIntentForPackage(text2);
			if (launchIntentForPackage2 != null)
			{
				Intent intent = new Intent("android.intent.action.VIEW");
				intent.SetPackage(text2);
				intent.SetData(Android.Net.Uri.Parse(this.downloadLink));
				this.StartActivity(intent);
			}
			else if (launchIntentForPackage != null)
			{
				Intent intent2 = new Intent("android.intent.action.VIEW");
				intent2.SetPackage(text);
				intent2.SetData(Android.Net.Uri.Parse(this.downloadLink));
				this.StartActivity(intent2);
			}
			else
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951667), 0);
				this.StartActivity(new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse("market://details?id=" + text)));
			}
			this.Dismiss();
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0002358C File Offset: 0x0002178C
		private void MBasicDownload_Click(object sender, EventArgs e)
		{
			if (this.type == "MOVIE")
			{
				CustomizedDownloader.Download(base.Activity, this.downloadLink, "[Animeify]" + this.fileName + ".mp4", "[Animeify]" + this.fileName, "", base.Resources.GetString(2131951883));
			}
			else
			{
				CustomizedDownloader.Download(base.Activity, this.downloadLink, "[Animeify]" + this.fileName + ".mp4", "[Animeify]" + this.fileName, this.title, base.Resources.GetString(2131951883));
			}
			this.Dismiss();
		}

		// Token: 0x04000540 RID: 1344
		private View view;

		// Token: 0x04000541 RID: 1345
		private LinearLayout mBasicDownload;

		// Token: 0x04000542 RID: 1346
		private LinearLayout mADMDownload;

		// Token: 0x04000543 RID: 1347
		private LinearLayout mOthersDownload;

		// Token: 0x04000544 RID: 1348
		private TextView mFileName;

		// Token: 0x04000545 RID: 1349
		private string downloadLink;

		// Token: 0x04000546 RID: 1350
		private string title;

		// Token: 0x04000547 RID: 1351
		private string fileName;

		// Token: 0x04000548 RID: 1352
		private string type;

		// Token: 0x04000549 RID: 1353
		private string fileSize;
	}
}
