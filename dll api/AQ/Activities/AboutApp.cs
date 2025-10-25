using System;
using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AQ.Helpers;

namespace AQ.Activities
{
	// Token: 0x020000BD RID: 189
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
	public class AboutApp : AppCompatActivity
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x000252B0 File Offset: 0x000234B0
		protected override void OnCreate(Bundle savedInstanceState)
		{
			string a = SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme");
			if (!(a == "BLUE"))
			{
				if (!(a == "PINK"))
				{
					if (!(a == "LIGHT_GRAY"))
					{
						this.SetTheme(2132017171);
					}
					else
					{
						this.SetTheme(2132017174);
					}
				}
				else
				{
					this.SetTheme(2132017177);
				}
			}
			else
			{
				this.SetTheme(2132017168);
			}
			base.OnCreate(savedInstanceState);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetTitle(2131951646);
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558428);
			this.mAboutBottomHint = base.FindViewById<TextView>(2131361806);
			this.mAboutBottomHint.Text = "Made with LOVE for Otakus";
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00025384 File Offset: 0x00023584
		private void MFacebook_Click(object sender, EventArgs e)
		{
			string package = "com.facebook.katana";
			try
			{
				Intent intent = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse("fb://page/106857530788866"));
				intent.SetPackage(package);
				this.StartActivity(intent);
			}
			catch
			{
				Intent intent2 = new Intent("android.intent.action.VIEW");
				intent2.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("FacebookUrl")));
				this.StartActivity(intent2);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000253F8 File Offset: 0x000235F8
		private void MYouTubeBtn_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.VIEW");
			intent.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("YoutubeUrl")));
			this.StartActivity(intent);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00025430 File Offset: 0x00023630
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x0400058B RID: 1419
		private TextView mAboutBottomHint;
	}
}
