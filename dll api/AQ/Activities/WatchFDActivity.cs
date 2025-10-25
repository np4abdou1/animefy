using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
using AQ.Helpers;
using AQ.Sdks.FD;

namespace AQ.Activities
{
	// Token: 0x020000D1 RID: 209
	[Activity(Label = "@string/app_name", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class WatchFDActivity : Activity
	{
		// Token: 0x06000A87 RID: 2695 RVA: 0x00038940 File Offset: 0x00036B40
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558463);
			this.mWatchLink = this.Intent.GetStringExtra("WatchLink");
			this.metrics = this.Resources.DisplayMetrics;
			this.widthInDp = Calculators.ConvertPixelsToDp((float)this.metrics.WidthPixels, this);
			this.heightInDp = Calculators.ConvertPixelsToDp((float)this.metrics.HeightPixels, this);
			if (this.heightInDp > this.widthInDp)
			{
				this.RequestedOrientation = ScreenOrientation.SensorLandscape;
			}
			this.mVideoView = base.FindViewById<FDWebVideoView>(2131362392);
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

		// Token: 0x06000A88 RID: 2696 RVA: 0x00038A20 File Offset: 0x00036C20
		public override void OnBackPressed()
		{
			this.mVideoView.handleBackPress(this);
			this.RequestedOrientation = ScreenOrientation.FullUser;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00038A36 File Offset: 0x00036C36
		protected override void OnPause()
		{
			base.OnPause();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
			{
				this.mVideoView.OnPause();
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00038A52 File Offset: 0x00036C52
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

		// Token: 0x06000A8B RID: 2699 RVA: 0x00038A7C File Offset: 0x00036C7C
		public void ImmerseMode()
		{
			int num = (int)this.Window.DecorView.SystemUiVisibility;
			num |= 4;
			num |= 1024;
			num |= 2;
			num |= 4096;
			this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)num;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000835 RID: 2101
		private FDWebVideoView mVideoView;

		// Token: 0x04000836 RID: 2102
		private DisplayMetrics metrics;

		// Token: 0x04000837 RID: 2103
		private int widthInDp;

		// Token: 0x04000838 RID: 2104
		private int heightInDp;

		// Token: 0x04000839 RID: 2105
		private string mWatchLink;
	}
}
