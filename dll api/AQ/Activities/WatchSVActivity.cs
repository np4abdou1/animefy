using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
using AQ.Helpers;
using AQ.Sdks.SV;

namespace AQ.Activities
{
	// Token: 0x020000D6 RID: 214
	[Activity(Label = "@string/app_name", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class WatchSVActivity : Activity
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x00039874 File Offset: 0x00037A74
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558468);
			this.mWatchLink = this.Intent.GetStringExtra("WatchLink");
			this.metrics = this.Resources.DisplayMetrics;
			this.widthInDp = Calculators.ConvertPixelsToDp((float)this.metrics.WidthPixels, this);
			this.heightInDp = Calculators.ConvertPixelsToDp((float)this.metrics.HeightPixels, this);
			if (this.heightInDp > this.widthInDp)
			{
				this.RequestedOrientation = ScreenOrientation.SensorLandscape;
			}
			this.mVideoView = base.FindViewById<SVWebVideoView>(2131363115);
			this.ImmerseMode();
			try
			{
				this.mVideoView.setVideoId(this.mWatchLink, false);
			}
			catch
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131951827), 0);
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00039954 File Offset: 0x00037B54
		public override void OnBackPressed()
		{
			this.mVideoView.handleBackPress(this);
			this.RequestedOrientation = ScreenOrientation.FullUser;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0003996A File Offset: 0x00037B6A
		protected override void OnPause()
		{
			base.OnPause();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
			{
				this.mVideoView.OnPause();
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00039986 File Offset: 0x00037B86
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			this.ImmerseMode();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
			{
				this.mVideoView.OnResume();
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000399B0 File Offset: 0x00037BB0
		public void ImmerseMode()
		{
			int num = (int)this.Window.DecorView.SystemUiVisibility;
			num |= 4;
			num |= 1024;
			num |= 2;
			num |= 4096;
			this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)num;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000861 RID: 2145
		private SVWebVideoView mVideoView;

		// Token: 0x04000862 RID: 2146
		private DisplayMetrics metrics;

		// Token: 0x04000863 RID: 2147
		private int widthInDp;

		// Token: 0x04000864 RID: 2148
		private int heightInDp;

		// Token: 0x04000865 RID: 2149
		private string mWatchLink;
	}
}
