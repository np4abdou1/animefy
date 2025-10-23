using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
using AQ.Helpers;
using AQ.Sdks.UV;

namespace AQ.Activities
{
	// Token: 0x020000D7 RID: 215
	[Activity(Label = "@string/app_name", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class WatchUVActivity : Activity
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x000399F8 File Offset: 0x00037BF8
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558469);
			this.mWatchLink = this.Intent.GetStringExtra("WatchLink");
			this.metrics = this.Resources.DisplayMetrics;
			this.widthInDp = Calculators.ConvertPixelsToDp((float)this.metrics.WidthPixels, this);
			this.heightInDp = Calculators.ConvertPixelsToDp((float)this.metrics.HeightPixels, this);
			if (this.heightInDp > this.widthInDp)
			{
				this.RequestedOrientation = ScreenOrientation.SensorLandscape;
			}
			this.mVideoView = base.FindViewById<UVWebVideoView>(2131363266);
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

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00039AD8 File Offset: 0x00037CD8
		public override void OnBackPressed()
		{
			this.mVideoView.handleBackPress(this);
			this.RequestedOrientation = ScreenOrientation.FullUser;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00039AEE File Offset: 0x00037CEE
		protected override void OnPause()
		{
			base.OnPause();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
			{
				this.mVideoView.OnPause();
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00039B0A File Offset: 0x00037D0A
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

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00039B34 File Offset: 0x00037D34
		public void ImmerseMode()
		{
			int num = (int)this.Window.DecorView.SystemUiVisibility;
			num |= 4;
			num |= 1024;
			num |= 2;
			num |= 4096;
			this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)num;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000866 RID: 2150
		private UVWebVideoView mVideoView;

		// Token: 0x04000867 RID: 2151
		private DisplayMetrics metrics;

		// Token: 0x04000868 RID: 2152
		private int widthInDp;

		// Token: 0x04000869 RID: 2153
		private int heightInDp;

		// Token: 0x0400086A RID: 2154
		private string mWatchLink;
	}
}
