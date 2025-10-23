using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
using AQ.Helpers;
using AQ.Sdks.Ok;

namespace AQ.Activities
{
	// Token: 0x020000D5 RID: 213
	[Activity(Label = "@string/app_name", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class WatchOKActivity : Activity
	{
		// Token: 0x06000AB1 RID: 2737 RVA: 0x000396F0 File Offset: 0x000378F0
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558466);
			this.mWatchLink = this.Intent.GetStringExtra("WatchLink");
			this.metrics = this.Resources.DisplayMetrics;
			this.widthInDp = Calculators.ConvertPixelsToDp((float)this.metrics.WidthPixels, this);
			this.heightInDp = Calculators.ConvertPixelsToDp((float)this.metrics.HeightPixels, this);
			if (this.heightInDp > this.widthInDp)
			{
				this.RequestedOrientation = ScreenOrientation.SensorLandscape;
			}
			this.mVideoView = base.FindViewById<OkWebVideoView>(2131362817);
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

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000397D0 File Offset: 0x000379D0
		public override void OnBackPressed()
		{
			this.mVideoView.handleBackPress(this);
			this.RequestedOrientation = ScreenOrientation.FullUser;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x000397E6 File Offset: 0x000379E6
		protected override void OnPause()
		{
			base.OnPause();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
			{
				this.mVideoView.OnPause();
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00039802 File Offset: 0x00037A02
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

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003982C File Offset: 0x00037A2C
		public void ImmerseMode()
		{
			int num = (int)this.Window.DecorView.SystemUiVisibility;
			num |= 4;
			num |= 1024;
			num |= 2;
			num |= 4096;
			this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)num;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x0400085C RID: 2140
		private OkWebVideoView mVideoView;

		// Token: 0x0400085D RID: 2141
		private DisplayMetrics metrics;

		// Token: 0x0400085E RID: 2142
		private int widthInDp;

		// Token: 0x0400085F RID: 2143
		private int heightInDp;

		// Token: 0x04000860 RID: 2144
		private string mWatchLink;
	}
}
