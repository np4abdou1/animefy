using System;
using System.Runtime.CompilerServices;
using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Firebase.Messaging;

namespace AQ.Activities
{
	// Token: 0x020000C0 RID: 192
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
	public class AppSettingsActivity : AppCompatActivity
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00029DD4 File Offset: 0x00027FD4
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
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SupportActionBar.SetDisplayShowTitleEnabled(false);
			this.SupportActionBar.SetDisplayShowCustomEnabled(true);
			this.SupportActionBar.SetCustomView(2131558648);
			this.SetContentView(2131558433);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mContent = base.FindViewById<LinearLayout>(2131361977);
			this.mAboutApp = base.FindViewById<LinearLayout>(2131361972);
			this.mShare = base.FindViewById<LinearLayout>(2131361989);
			this.mChangeLang = base.FindViewById<LinearLayout>(2131361980);
			this.mCurrentLanguage = base.FindViewById<TextView>(2131361978);
			this.mGoPremiumBtn = base.FindViewById<Button>(2131361979);
			this.mAutoMarkSwitch = base.FindViewById<SwitchCompat>(2131361976);
			this.mRemoveAdsSwitch = base.FindViewById<SwitchCompat>(2131361994);
			this.mNotificationsSwtich = base.FindViewById<SwitchCompat>(2131361987);
			this.mMXPlayerDefaultSwitch = base.FindViewById<SwitchCompat>(2131361985);
			this.mADMDefaultSwitch = base.FindViewById<SwitchCompat>(2131361974);
			this.mModeList = base.FindViewById<RadioButton>(2131361983);
			this.mModeGrid = base.FindViewById<RadioButton>(2131361982);
			this.mThemeBlue = base.FindViewById<RadioButton>(2131361996);
			this.mThemePink = base.FindViewById<RadioButton>(2131362002);
			this.mThemeLightGray = base.FindViewById<RadioButton>(2131362000);
			this.mThemeDarkGray = base.FindViewById<RadioButton>(2131361998);
			this.mOnAppStartHome = base.FindViewById<RadioButton>(2131361992);
			this.mOnAppStartAnime = base.FindViewById<RadioButton>(2131361991);
			this.mPrivacyPolicy = base.FindViewById<LinearLayout>(2131361988);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AppLanguage") == "en")
			{
				this.mCurrentLanguage.Text = this.Resources.GetString(2131952023);
			}
			else
			{
				this.mCurrentLanguage.Text = this.Resources.GetString(2131952021);
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") == "ON" || SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") == "N/A")
			{
				this.mAutoMarkSwitch.Checked = true;
			}
			if ((SharedPreferencesSaves.StringSharedPreferencesGet("IsAdsRemoved") == "True" || SharedPreferencesSaves.StringSharedPreferencesGet("IsAdsRemoved") == null) && this.user != null && (this.user.Membership == "PREMIUM" || this.user.Membership == "ADMIN"))
			{
				this.mRemoveAdsSwitch.Checked = true;
			}
			if (this.user != null && (this.user.Membership == "PREMIUM" || this.user.Membership == "ADMIN"))
			{
				this.mGoPremiumBtn.Visibility = ViewStates.Gone;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("MXPlayerDefault") == "YES")
			{
				this.mMXPlayerDefaultSwitch.Checked = true;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("ADMDefault") == "YES")
			{
				this.mADMDefaultSwitch.Checked = true;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") == "BLUE")
			{
				this.mThemeBlue.Checked = true;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") == "PINK")
			{
				this.mThemePink.Checked = true;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") == "LIGHT_GRAY")
			{
				this.mThemeLightGray.Checked = true;
			}
			else
			{
				this.mThemeDarkGray.Checked = true;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("Notification") != "OFF")
			{
				this.mNotificationsSwtich.Checked = true;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("OnAppStart") != "ANIME")
			{
				this.mOnAppStartHome.Checked = true;
			}
			else
			{
				this.mOnAppStartAnime.Checked = true;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AnimeListMode") == "List")
			{
				this.mModeList.Checked = true;
			}
			else
			{
				this.mModeGrid.Checked = true;
			}
			this.mAboutApp.Click += this.MAboutApp_Click;
			this.mShare.Click += this.MShare_Click;
			this.mGoPremiumBtn.Click += this.MGoPremiumBtn_Click;
			this.mAutoMarkSwitch.CheckedChange += this.MAutoMarkSwitch_CheckedChange;
			this.mRemoveAdsSwitch.CheckedChange += this.MRemoveAdsSwitch_CheckedChange;
			this.mNotificationsSwtich.CheckedChange += this.MNotificationsSwtich_CheckedChange;
			this.mMXPlayerDefaultSwitch.CheckedChange += this.MMXPlayerDefaultSwitch_CheckedChange;
			this.mADMDefaultSwitch.CheckedChange += this.MADMDefaultSwitch_CheckedChange;
			this.mPrivacyPolicy.Click += this.MPrivacyPolicy_Click;
			this.mModeList.CheckedChange += this.MModeList_CheckedChange;
			this.mModeGrid.CheckedChange += this.MModeGrid_CheckedChange;
			this.mThemeBlue.CheckedChange += this.MThemeBlue_CheckedChange;
			this.mThemePink.CheckedChange += this.MThemePink_CheckedChange;
			this.mThemeLightGray.CheckedChange += this.MThemeLightGray_CheckedChange;
			this.mThemeDarkGray.CheckedChange += this.MThemeDark_CheckedChange;
			this.mOnAppStartHome.CheckedChange += this.MOnAppStartHome_CheckedChange;
			this.mOnAppStartAnime.CheckedChange += this.MOnAppStartAnime_CheckedChange;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002A409 File Offset: 0x00028609
		private void MPrivacyPolicy_Click(object sender, EventArgs e)
		{
			this.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse("https://animeify.net/privacy")));
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0002A42A File Offset: 0x0002862A
		private void MOnAppStartAnime_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("OnAppStart", "ANIME");
				this.mOnAppStartHome.Checked = false;
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0002A44F File Offset: 0x0002864F
		private void MOnAppStartHome_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("OnAppStart", "HOME");
				this.mOnAppStartAnime.Checked = false;
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000268C4 File Offset: 0x00024AC4
		private void MGoPremiumBtn_Click(object sender, EventArgs e)
		{
			new ContactBottomSheet().Show(this.SupportFragmentManager.BeginTransaction(), "ContactSheet");
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0002A474 File Offset: 0x00028674
		private void MADMDefaultSwitch_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (!e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("ADMDefault", "NO");
				return;
			}
			string text = "com.dv.adm";
			string packageName = "com.dv.adm.pay";
			Intent launchIntentForPackage = this.PackageManager.GetLaunchIntentForPackage(text);
			Intent launchIntentForPackage2 = this.PackageManager.GetLaunchIntentForPackage(packageName);
			if (launchIntentForPackage != null || launchIntentForPackage2 != null)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("ADMDefault", "YES");
				return;
			}
			CustomizedToast.ShowToast(this, this.Resources.GetString(2131951667), 0);
			this.StartActivity(new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse("market://details?id=" + text)));
			this.mADMDefaultSwitch.Checked = false;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002A51C File Offset: 0x0002871C
		private void MMXPlayerDefaultSwitch_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (!e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("MXPlayerDefault", "NO");
				return;
			}
			string text = "com.mxtech.videoplayer.ad";
			string packageName = "com.mxtech.videoplayer.pro";
			Intent launchIntentForPackage = this.PackageManager.GetLaunchIntentForPackage(text);
			Intent launchIntentForPackage2 = this.PackageManager.GetLaunchIntentForPackage(packageName);
			if (launchIntentForPackage != null || launchIntentForPackage2 != null)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("MXPlayerDefault", "YES");
				return;
			}
			CustomizedToast.ShowToast(this, this.Resources.GetString(2131952215), 0);
			this.StartActivity(new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse("market://details?id=" + text)));
			this.mMXPlayerDefaultSwitch.Checked = false;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002A5C3 File Offset: 0x000287C3
		private void MModeGrid_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("AnimeListMode", "Grid");
				this.mModeList.Checked = false;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0002A5E8 File Offset: 0x000287E8
		private void MModeList_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("AnimeListMode", "List");
				this.mModeGrid.Checked = false;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002A60D File Offset: 0x0002880D
		private void MAboutApp_Click(object sender, EventArgs e)
		{
			base.StartActivity(typeof(AboutApp));
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0002A620 File Offset: 0x00028820
		private void MNotificationsSwtich_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("Notification", "ON");
				FirebaseMessaging.Instance.SubscribeToTopic("News");
				return;
			}
			SharedPreferencesSaves.StringSharedPreferencesSave("Notification", "OFF");
			FirebaseMessaging.Instance.UnsubscribeFromTopic("News");
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0002A674 File Offset: 0x00028874
		private void MShare_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.SEND");
			intent.PutExtra("android.intent.extra.TITLE", this.Resources.GetString(2131952392));
			intent.PutExtra("android.intent.extra.TEXT", this.Resources.GetString(2131952391) + " " + SharedPreferencesSaves.StringSharedPreferencesGet("WebsiteUrl"));
			intent.SetType("text/plain");
			this.StartActivity(Intent.CreateChooser(intent, this.Resources.GetString(2131952394)));
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0002A700 File Offset: 0x00028900
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689512, menu);
			return true;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002A714 File Offset: 0x00028914
		private void MThemeLightGray_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked && SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") != "LIGHT_GRAY")
			{
				this.mThemeBlue.Checked = false;
				this.mThemePink.Checked = false;
				this.mThemeDarkGray.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "LIGHT_GRAY");
				this.SetTheme(2132017174);
				this.Recreate();
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0002A784 File Offset: 0x00028984
		private void MThemeDark_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked && SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") != "DARK_GRAY")
			{
				this.mThemeBlue.Checked = false;
				this.mThemePink.Checked = false;
				this.mThemeLightGray.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "DARK_GRAY");
				this.SetTheme(2132017171);
				this.Recreate();
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0002A7F4 File Offset: 0x000289F4
		private void MThemePink_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked && SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") != "PINK")
			{
				this.mThemeBlue.Checked = false;
				this.mThemeDarkGray.Checked = false;
				this.mThemeLightGray.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "PINK");
				this.SetTheme(2132017177);
				this.Recreate();
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0002A864 File Offset: 0x00028A64
		private void MThemeBlue_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked && SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") != "BLUE")
			{
				this.mThemePink.Checked = false;
				this.mThemeDarkGray.Checked = false;
				this.mThemeLightGray.Checked = false;
				SharedPreferencesSaves.StringSharedPreferencesSave("UserAppTheme", "BLUE");
				this.SetTheme(2132017168);
				this.Recreate();
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002A8D4 File Offset: 0x00028AD4
		private void MRemoveAdsSwitch_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (this.user == null)
			{
				CustomizedSnackbar.SnackBar(this.mContent, 2131952273, "").Show();
				this.mRemoveAdsSwitch.Checked = false;
				return;
			}
			if (this.user.Membership != "PREMIUM" && this.user.Membership != "ADMIN")
			{
				CustomizedSnackbar.SnackBar(this.mContent, 2131952273, "").Show();
				this.mRemoveAdsSwitch.Checked = false;
				return;
			}
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("IsAdsRemoved", "True");
				return;
			}
			SharedPreferencesSaves.StringSharedPreferencesSave("IsAdsRemoved", "False");
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0002A98C File Offset: 0x00028B8C
		private void MAutoMarkSwitch_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("AutoMarkAsWatched", "ON");
				return;
			}
			SharedPreferencesSaves.StringSharedPreferencesSave("AutoMarkAsWatched", "OFF");
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0002A9B8 File Offset: 0x00028BB8
		private void MChangeLang_Click(object sender, EventArgs e)
		{
			string[] items = new string[]
			{
				this.Resources.GetString(2131952021),
				this.Resources.GetString(2131952023)
			};
			using (AlertDialog.Builder builder = new AlertDialog.Builder(this))
			{
				builder.SetItems(items, delegate(object d, [Nullable(1)] DialogClickEventArgs args)
				{
					if (args.Which == 0)
					{
						if (SharedPreferencesSaves.StringSharedPreferencesGet("AppLanguage") == "ar")
						{
							return;
						}
						SharedPreferencesSaves.StringSharedPreferencesSave("AppLanguage", "ar");
						this.mCurrentLanguage.Text = this.Resources.GetString(2131952021);
					}
					else
					{
						if (SharedPreferencesSaves.StringSharedPreferencesGet("AppLanguage") == "en")
						{
							return;
						}
						SharedPreferencesSaves.StringSharedPreferencesSave("AppLanguage", "en");
						this.mCurrentLanguage.Text = this.Resources.GetString(2131952023);
					}
					base.StartActivity(typeof(AppSettingsActivity));
				});
				builder.Show();
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0002AA30 File Offset: 0x00028C30
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				base.StartActivity(typeof(MainActivity));
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0002AA63 File Offset: 0x00028C63
		public override void OnBackPressed()
		{
			base.OnBackPressed();
			base.StartActivity(typeof(MainActivity));
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000613 RID: 1555
		private UsersModel user;

		// Token: 0x04000614 RID: 1556
		private int userId;

		// Token: 0x04000615 RID: 1557
		private LinearLayout mChangeLang;

		// Token: 0x04000616 RID: 1558
		private LinearLayout mContent;

		// Token: 0x04000617 RID: 1559
		private LinearLayout mAboutApp;

		// Token: 0x04000618 RID: 1560
		private LinearLayout mShare;

		// Token: 0x04000619 RID: 1561
		private LinearLayout mPrivacyPolicy;

		// Token: 0x0400061A RID: 1562
		private Button mGoPremiumBtn;

		// Token: 0x0400061B RID: 1563
		private TextView mCurrentLanguage;

		// Token: 0x0400061C RID: 1564
		private RadioButton mModeList;

		// Token: 0x0400061D RID: 1565
		private RadioButton mModeGrid;

		// Token: 0x0400061E RID: 1566
		private RadioButton mThemeBlue;

		// Token: 0x0400061F RID: 1567
		private RadioButton mThemePink;

		// Token: 0x04000620 RID: 1568
		private RadioButton mThemeLightGray;

		// Token: 0x04000621 RID: 1569
		private RadioButton mThemeDarkGray;

		// Token: 0x04000622 RID: 1570
		private RadioButton mOnAppStartHome;

		// Token: 0x04000623 RID: 1571
		private RadioButton mOnAppStartAnime;

		// Token: 0x04000624 RID: 1572
		private SwitchCompat mAutoMarkSwitch;

		// Token: 0x04000625 RID: 1573
		private SwitchCompat mRemoveAdsSwitch;

		// Token: 0x04000626 RID: 1574
		private SwitchCompat mNotificationsSwtich;

		// Token: 0x04000627 RID: 1575
		private SwitchCompat mMXPlayerDefaultSwitch;

		// Token: 0x04000628 RID: 1576
		private SwitchCompat mADMDefaultSwitch;
	}
}
