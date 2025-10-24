using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
using AQ.Helpers;
using AQ.Sdks.MA;

namespace AQ.Activities
{
	// Token: 0x020000D4 RID: 212
	[Activity(Label = "@string/app_name", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class WatchMAActivity : Activity
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x0003956C File Offset: 0x0003776C
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558465);
			this.mWatchLink = this.Intent.GetStringExtra("WatchLink");
			this.metrics = this.Resources.DisplayMetrics;
			this.widthInDp = Calculators.ConvertPixelsToDp((float)this.metrics.WidthPixels, this);
			this.heightInDp = Calculators.ConvertPixelsToDp((float)this.metrics.HeightPixels, this);
			if (this.heightInDp > this.widthInDp)
			{
				this.RequestedOrientation = ScreenOrientation.SensorLandscape;
			}
			this.mVideoView = base.FindViewById<MaWebVideoView>(2131362570);
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

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003964C File Offset: 0x0003784C
		public override void OnBackPressed()
		{
			this.mVideoView.handleBackPress(this);
			this.RequestedOrientation = ScreenOrientation.FullUser;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00039662 File Offset: 0x00037862
		protected override void OnPause()
		{
			base.OnPause();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
			{
				this.mVideoView.OnPause();
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0003967E File Offset: 0x0003787E
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

		// Token: 0x06000AAE RID: 2734 RVA: 0x000396A8 File Offset: 0x000378A8
		public void ImmerseMode()
		{
			int num = (int)this.Window.DecorView.SystemUiVisibility;
			num |= 4;
			num |= 1024;
			num |= 2;
			num |= 4096;
			this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)num;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000857 RID: 2135
		private MaWebVideoView mVideoView;

		// Token: 0x04000858 RID: 2136
		private DisplayMetrics metrics;

		// Token: 0x04000859 RID: 2137
		private int widthInDp;

		// Token: 0x0400085A RID: 2138
		private int heightInDp;

		// Token: 0x0400085B RID: 2139
		private string mWatchLink;
	}
}
