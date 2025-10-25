using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Auth.Api.SignIn;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Content;
using AndroidX.DrawerLayout.Widget;
using AndroidX.Fragment.App;
using AQ.Activities;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Bumptech.Glide;
using Firebase.Messaging;
using Google.Android.Material.Navigation;
using Google.Android.Material.Tabs;
using Java.Interop;
using Java.Lang;
using Newtonsoft.Json;
using Refractored.Controls;

namespace AQ
{
	// Token: 0x02000006 RID: 6
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002104 File Offset: 0x00000304
		protected override void OnCreate(Bundle savedInstanceState)
		{
			string a = SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme");
			if (!(a == "BLUE"))
			{
				if (!(a == "PINK"))
				{
					if (!(a == "LIGHT_GRAY"))
					{
						this.SetTheme(2132017173);
					}
					else
					{
						this.SetTheme(2132017176);
					}
				}
				else
				{
					this.SetTheme(2132017179);
				}
			}
			else
			{
				this.SetTheme(2132017170);
			}
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558470);
			this.navigationView = base.FindViewById<NavigationView>(2131362749);
			Toolbar toolbar = base.FindViewById<Toolbar>(2131363160);
			this.SetSupportActionBar(toolbar);
			this.SupportActionBar.SetDisplayShowHomeEnabled(true);
			this.SupportActionBar.SetLogo(2131230949);
			this.SupportActionBar.SetDisplayUseLogoEnabled(true);
			this.SupportActionBar.SetDisplayShowTitleEnabled(false);
			this.mTabLayout = base.FindViewById<TabLayout>(2131363116);
			this.mTabLayout.TabSelected += this.MTabLayout_TabSelected;
			DrawerLayout drawerLayout = base.FindViewById<DrawerLayout>(2131362321);
			ActionBarDrawerToggle actionBarDrawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, 2131952223, 2131952222);
			drawerLayout.SetScrimColor(17170445);
			drawerLayout.AddDrawerListener(actionBarDrawerToggle);
			actionBarDrawerToggle.SyncState();
			View headerView = this.navigationView.GetHeaderView(0);
			this.navUserFullname = headerView.FindViewById<TextView>(2131362748);
			this.navProfilePhoto = headerView.FindViewById<CircleImageView>(2131362744);
			this.navPofileCover = headerView.FindViewById<ImageView>(2131362743);
			this.navUserPicPremiumMark = headerView.FindViewById<ImageView>(2131362745);
			this.favSeriesCount = (TextView)this.navigationView.Menu.FindItem(2131362726).ActionView;
			this.watchCurrentlyCount = (TextView)this.navigationView.Menu.FindItem(2131362750).ActionView;
			this.watchLaterCount = (TextView)this.navigationView.Menu.FindItem(2131362752).ActionView;
			this.watchDoneCount = (TextView)this.navigationView.Menu.FindItem(2131362751).ActionView;
			this.newNotify = (LinearLayout)this.navigationView.Menu.FindItem(2131362740).ActionView;
			this.newsNotifyText = this.navigationView.Menu.FindItem(2131362740).ActionView.FindViewById<TextView>(2131362812);
			this.newAnimeNotify = (LinearLayout)this.navigationView.Menu.FindItem(2131362732).ActionView;
			this.newEpisodeNotify = (LinearLayout)this.navigationView.Menu.FindItem(2131362733).ActionView;
			this.newEpisodeNotifyText = this.navigationView.Menu.FindItem(2131362733).ActionView.FindViewById<TextView>(2131362812);
			this.mNewYoutubeVideoNotify = (LinearLayout)this.navigationView.Menu.FindItem(2131362754).ActionView;
			this.mNewYoutubeVideoNotifyText = this.navigationView.Menu.FindItem(2131362754).ActionView.FindViewById<TextView>(2131362812);
			this.newCharacterNotify = (LinearLayout)this.navigationView.Menu.FindItem(2131362723).ActionView;
			this.newCharacterNotifyText = this.navigationView.Menu.FindItem(2131362723).ActionView.FindViewById<TextView>(2131362812);
			this.InitMain();
			this.AskNotificationsPermission();
			if (SharedPreferencesSaves.StringSharedPreferencesGet("OnAppStart") != "ANIME")
			{
				FragmentTransaction fragmentTransaction = this.SupportFragmentManager.BeginTransaction();
				fragmentTransaction.Replace(2131362436, new HomeFragment(), "Home");
				fragmentTransaction.AddToBackStack(null);
				fragmentTransaction.Commit();
			}
			else
			{
				this.mTabLayout.GetTabAt(1).Select();
			}
			this.navigationView.SetNavigationItemSelectedListener(this);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002500 File Offset: 0x00000700
		private void AskNotificationsPermission()
		{
			string[] permissions = new string[]
			{
				"android.permission.POST_NOTIFICATIONS"
			};
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Tiramisu && ContextCompat.CheckSelfPermission(this, "android.permission.POST_NOTIFICATIONS") != Permission.Granted)
			{
				base.RequestPermissions(permissions, 1);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000253C File Offset: 0x0000073C
		private void MTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			FragmentTransaction fragmentTransaction = this.SupportFragmentManager.BeginTransaction();
			switch (e.Tab.Position)
			{
			case 0:
				fragmentTransaction.Replace(2131362436, new HomeFragment(), "Home");
				this.navigationView.Menu.GetItem(3).SetChecked(true);
				break;
			case 1:
				fragmentTransaction.Replace(2131362436, new MainAnimeList(), "AnimeList");
				this.navigationView.Menu.GetItem(4).SetChecked(true);
				break;
			case 2:
				fragmentTransaction.Replace(2131362436, new NewsFragment(), "NewList");
				this.navigationView.Menu.GetItem(5).SetChecked(true);
				break;
			case 3:
				fragmentTransaction.Replace(2131362436, new ExploreFragment(), "Explore");
				break;
			}
			fragmentTransaction.AddToBackStack(null);
			fragmentTransaction.Commit();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002634 File Offset: 0x00000834
		private void InitMain()
		{
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			if (this.userId > 0)
			{
				this.PrepareDrawerUserProfileUI();
				this.PrepareHeaderUserProfileUI(this.mMenu);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.CheckDataChanges();
				});
				this.navUserFullname.Click -= this.NavUserFullname_Click;
			}
			else
			{
				IMenu menu = this.navigationView.Menu;
				IMenuItem self = menu.FindItem(2131362736);
				self.SetTitle(this.Resources.GetString(2131952106));
				this.navUserFullname.Text = this.Resources.GetString(2131952048);
				this.navUserFullname.Click += this.NavUserFullname_Click;
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.InitDrawer();
			});
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002724 File Offset: 0x00000924
		private void PrepareDrawerUserProfileUI()
		{
			this.navUserFullname.Text = this.user.FullName;
			if (this.user.ProfileImage != "")
			{
				Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).Into(this.navProfilePhoto);
			}
			else if (this.user.GoogleProfilePhotoUrl != "")
			{
				Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).Into(this.navProfilePhoto);
			}
			else
			{
				this.navProfilePhoto.SetImageResource(2131230965);
			}
			if (this.user.ProfileCover != "")
			{
				Glide.With(this).Load(Constants.ProfileCover(this.user.ProfileCover, this.user.UserID.ToString())).Into(this.navPofileCover);
			}
			else
			{
				this.navPofileCover.SetImageResource(0);
			}
			if (this.user.Membership == "ADMIN")
			{
				this.navProfilePhoto.BorderColor = ContextCompat.GetColor(this, 2131100510);
				this.navUserPicPremiumMark.Visibility = ViewStates.Gone;
				return;
			}
			if (this.user.Membership == "PREMIUM")
			{
				this.navProfilePhoto.BorderColor = Color.Gold;
				this.navUserPicPremiumMark.Visibility = ViewStates.Visible;
				return;
			}
			this.navProfilePhoto.BorderColor = ContextCompat.GetColor(this, 2131100059);
			this.navUserPicPremiumMark.Visibility = ViewStates.Gone;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000028DC File Offset: 0x00000ADC
		private void DoubleClickToExit()
		{
			if (MainActivity.back_pressed + 2000L > JavaSystem.CurrentTimeMillis())
			{
				Intent intent = new Intent("android.intent.action.MAIN");
				intent.AddCategory("android.intent.category.HOME");
				intent.SetFlags(ActivityFlags.ClearTop);
				this.StartActivity(intent);
			}
			else
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131951788), 0);
			}
			MainActivity.back_pressed = JavaSystem.CurrentTimeMillis();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002949 File Offset: 0x00000B49
		private void NavUserFullname_Click(object sender, EventArgs e)
		{
			base.StartActivity(typeof(SignInUpDashboard));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000295C File Offset: 0x00000B5C
		public override void OnBackPressed()
		{
			DrawerLayout drawerLayout = base.FindViewById<DrawerLayout>(2131362321);
			if (drawerLayout.IsDrawerOpen(8388611))
			{
				drawerLayout.CloseDrawer(8388611);
				return;
			}
			this.DoubleClickToExit();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002994 File Offset: 0x00000B94
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.mMenu = menu;
			this.MenuInflater.Inflate(2131689515, menu);
			this.headerProfilePhoto = (CircleImageView)((FrameLayout)menu.FindItem(2131362648).ActionView).FindViewById(2131362649);
			this.headerProfilePhoto.Click += this.HeaderProfilePhoto_Click;
			this.PrepareUserNotificationUI(menu);
			this.PrepareHeaderUserProfileUI(menu);
			return true;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002A0C File Offset: 0x00000C0C
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (item.ItemId == 2131362607)
			{
				LayoutInflater layoutInflater = LayoutInflater.From(this);
				View view = layoutInflater.Inflate(2131558619, null);
				view.FindViewById<TextView>(2131362295).Text = this.mainModel.Configurations.admin_notifications_title;
				view.FindViewById<TextView>(2131362281).Text = this.mainModel.Configurations.admin_notifications_message;
				Button button = view.FindViewById<Button>(2131362289);
				button.Text = this.Resources.GetString(2131952267);
				view.FindViewById<TextView>(2131362295).SetTextColor(Color.Red);
				view.FindViewById<Button>(2131362288).Visibility = ViewStates.Gone;
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				builder.SetView(view);
				builder.SetCancelable(true);
				AlertDialog dialog = builder.Create();
				dialog.Show();
				button.Click += delegate(object <p0>, EventArgs <p1>)
				{
					dialog.Dismiss();
				};
				item.SetVisible(false);
				SharedPreferencesSaves.IntSharedPreferencesSave("admin_notifications_id", this.mainModel.Configurations.admin_notifications_id);
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B38 File Offset: 0x00000D38
		public bool OnNavigationItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 2131362730)
			{
				this.mTabLayout.GetTabAt(0).Select();
			}
			else if (itemId == 2131362724)
			{
				this.mTabLayout.GetTabAt(1).Select();
			}
			else if (itemId == 2131362738)
			{
				if (this.userId == 0)
				{
					this.SignInPormpt(this.Resources.GetString(2131951866));
				}
				else
				{
					base.StartActivity(typeof(AccountCPActivity));
				}
			}
			else if (itemId == 2131362726)
			{
				Intent intent = new Intent(Application.Context, typeof(FavouritesActivity));
				intent.PutExtra("AnimeType", "SERIES");
				this.StartActivity(intent);
			}
			else if (itemId == 2131362727)
			{
				base.StartActivity(typeof(FavouriteCharcters));
			}
			else if (itemId == 2131362733)
			{
				if (this.mainModel != null)
				{
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewEpisodesCount", this.mainModel.UpdatesChart.new_episodes_count);
				}
				base.StartActivity(typeof(LatestEpisodesActivity));
			}
			else if (itemId == 2131362732)
			{
				Intent intent2 = new Intent(Application.Context, typeof(LatestAnimeActivity));
				if (this.mainModel != null)
				{
					intent2.PutExtra("NewCount", this.mainModel.UpdatesChart.new_anime_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewAnimeCount"));
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewAnimeCount", this.mainModel.UpdatesChart.new_anime_count);
				}
				this.StartActivity(intent2);
			}
			else if (itemId == 2131362740)
			{
				if (this.mainModel != null)
				{
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewsCount", this.mainModel.UpdatesChart.news_count);
				}
				this.mTabLayout.GetTabAt(2).Select();
				this.newNotify.Visibility = ViewStates.Gone;
			}
			else if (itemId == 2131362729)
			{
				base.StartActivity(typeof(WatchHistoryActivity));
			}
			else if (itemId == 2131362752)
			{
				Intent intent3 = new Intent(Application.Context, typeof(LibraryActivity));
				intent3.PutExtra("Library", "WATCH_LATER");
				this.StartActivity(intent3);
			}
			else if (itemId == 2131362751)
			{
				Intent intent4 = new Intent(Application.Context, typeof(LibraryActivity));
				intent4.PutExtra("Library", "WATCH_DONE");
				this.StartActivity(intent4);
			}
			else if (itemId == 2131362750)
			{
				Intent intent5 = new Intent(Application.Context, typeof(LibraryActivity));
				intent5.PutExtra("Library", "WATCH_CURRENTLY");
				this.StartActivity(intent5);
			}
			else if (itemId == 2131362723)
			{
				if (this.mainModel != null)
				{
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewCharsCount", this.mainModel.UpdatesChart.new_characters_count);
				}
				base.StartActivity(typeof(CharactersActivity));
			}
			else if (itemId == 2131362746)
			{
				base.StartActivity(typeof(AppSettingsActivity));
			}
			else if (itemId == 2131362728)
			{
				base.StartActivity(typeof(FeedbackActivity));
			}
			else if (itemId == 2131362753)
			{
				Intent intent6 = new Intent("android.intent.action.VIEW");
				intent6.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("WebsiteUrl")));
				this.StartActivity(intent6);
			}
			else
			{
				if (itemId == 2131362725)
				{
					string package = "com.facebook.katana";
					try
					{
						Intent intent7 = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse("fb://page/106857530788866"));
						intent7.SetPackage(package);
						this.StartActivity(intent7);
						goto IL_5B4;
					}
					catch
					{
						Intent intent8 = new Intent("android.intent.action.VIEW");
						intent8.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("FacebookUrl")));
						this.StartActivity(intent8);
						goto IL_5B4;
					}
				}
				if (itemId == 2131362731)
				{
					string package2 = "com.instagram.android";
					try
					{
						Intent intent9 = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("InstagramUrl")));
						intent9.SetPackage(package2);
						this.StartActivity(intent9);
						goto IL_5B4;
					}
					catch
					{
						Intent intent10 = new Intent("android.intent.action.VIEW");
						intent10.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("InstagramUrl")));
						this.StartActivity(intent10);
						goto IL_5B4;
					}
				}
				if (itemId == 2131362754)
				{
					if (this.mainModel != null)
					{
						SharedPreferencesSaves.IntSharedPreferencesSave("LatestYoutubeVideosCount", this.mainModel.Configurations.social_youtube_new_videos);
					}
					string package3 = "com.google.android.youtube";
					try
					{
						Intent intent11 = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("YoutubeUrl")));
						intent11.SetPackage(package3);
						this.StartActivity(intent11);
						goto IL_5B4;
					}
					catch
					{
						Intent intent12 = new Intent("android.intent.action.VIEW");
						intent12.SetData(Android.Net.Uri.Parse(SharedPreferencesSaves.StringSharedPreferencesGet("YoutubeUrl")));
						this.StartActivity(intent12);
						goto IL_5B4;
					}
				}
				if (itemId == 2131362741)
				{
					this.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse("https://animeify.net/privacy")));
				}
				else if (itemId == 2131362736)
				{
					if (this.userId > 0)
					{
						UsersViewModel.ClearUsers();
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952600), 0);
						if (this.user.GoogleUserID != "" || this.user.GoogleUserID != "0")
						{
							SharedPreferencesSaves.IntSharedPreferencesSave("CurrentUserNotifications", 0);
							GoogleSignInOptions options = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn).RequestEmail().Build();
							GoogleSignInClient client = GoogleSignIn.GetClient(this, options);
							client.SignOut();
						}
						base.StartActivity(typeof(MainActivity));
					}
					else
					{
						base.StartActivity(typeof(SignInUpDashboard));
					}
				}
			}
			IL_5B4:
			DrawerLayout drawerLayout = base.FindViewById<DrawerLayout>(2131362321);
			drawerLayout.CloseDrawer(8388611);
			return true;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000313C File Offset: 0x0000133C
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			if (UsersModel.OnResumeLogin)
			{
				this.InitMain();
				UsersModel.OnResumeLogin = false;
				return;
			}
			if (this.onResumeCount >= 1)
			{
				if (this.userId > 0)
				{
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.CheckDataChanges();
					});
				}
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.InitDrawer();
				});
				return;
			}
			this.onResumeCount++;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000031B0 File Offset: 0x000013B0
		private void PrepareHeaderUserProfileUI(IMenu menu)
		{
			if (menu != null && this.user != null)
			{
				if (this.user.ProfileImage != "")
				{
					Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).CenterCrop().Into(this.headerProfilePhoto);
				}
				else if (this.user.GoogleProfilePhotoUrl != "")
				{
					Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).CenterCrop().Into(this.headerProfilePhoto);
				}
				else
				{
					this.headerProfilePhoto.SetImageResource(2131230965);
				}
				if (this.user.Membership == "ADMIN")
				{
					this.headerProfilePhoto.BorderColor = ContextCompat.GetColor(this, 2131100510);
					return;
				}
				if (this.user.Membership == "PREMIUM")
				{
					this.headerProfilePhoto.BorderColor = Color.Gold;
					return;
				}
				this.headerProfilePhoto.BorderColor = ContextCompat.GetColor(this, 2131100465);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000032E7 File Offset: 0x000014E7
		private void HeaderProfilePhoto_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				this.SignInPormpt(this.Resources.GetString(2131951866));
				return;
			}
			base.StartActivity(typeof(AccountCPActivity));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003318 File Offset: 0x00001518
		private void PrepareUserNotificationUI(IMenu menu)
		{
			IMenuItem menuItem = menu.FindItem(2131362644);
			FrameLayout frameLayout = (FrameLayout)menuItem.ActionView;
			ImageView imageView = (ImageView)frameLayout.FindViewById(2131362617);
			imageView.Click += this.NotificationBell_Click;
			this.notificationCircle = (FrameLayout)frameLayout.FindViewById(2131362615);
			this.notificationCircleText = (TextView)frameLayout.FindViewById(2131362616);
			if (SharedPreferencesSaves.IntSharedPreferencesGet("CurrentUserNotifications") > 0)
			{
				this.notificationCircle.Visibility = ViewStates.Visible;
				int num = SharedPreferencesSaves.IntSharedPreferencesGet("CurrentUserNotifications");
				if (num > 9)
				{
					this.notificationCircleText.Text = "9+";
					return;
				}
				this.notificationCircleText.Text = num.ToString();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000033D8 File Offset: 0x000015D8
		private void NotificationBell_Click(object sender, EventArgs e)
		{
			if (this.mainModel != null)
			{
				Intent intent = new Intent(Application.Context, typeof(UserNotificationsActivity));
				if (this.user != null)
				{
					intent.PutExtra("UserNotificationsCount", this.mainModel.UserStatistics.notifications - SharedPreferencesSaves.IntSharedPreferencesGet("UserNotifications"));
					SharedPreferencesSaves.IntSharedPreferencesSave("UserNotifications", this.mainModel.UserStatistics.notifications);
					SharedPreferencesSaves.IntSharedPreferencesSave("CurrentUserNotifications", 0);
				}
				this.StartActivity(intent);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003460 File Offset: 0x00001660
		private void CheckDataChanges()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/get_user.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(@string);
					base.RunOnUiThread(delegate()
					{
						if (userResponse.code == 1)
						{
							if (userResponse.data.Password != "")
							{
								if (this.user.UserName != userResponse.data.UserName || this.user.Password != userResponse.data.Password)
								{
									UsersViewModel.ClearUsers();
									CustomizedToast.ShowToast(this, this.Resources.GetString(2131952600), 0);
									if (this.user.GoogleUserID != "" || this.user.GoogleUserID != "0")
									{
										SharedPreferencesSaves.IntSharedPreferencesSave("CurrentUserNotifications", 0);
										GoogleSignInOptions options = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn).RequestEmail().Build();
										GoogleSignInClient client = GoogleSignIn.GetClient(this, options);
										client.SignOut();
									}
									LayoutInflater layoutInflater = LayoutInflater.From(this);
									View view = layoutInflater.Inflate(2131558619, null);
									view.FindViewById<TextView>(2131362281).Text = view.Resources.GetString(2131951867);
									Button button = view.FindViewById<Button>(2131362289);
									Button button2 = view.FindViewById<Button>(2131362288);
									AlertDialog.Builder builder = new AlertDialog.Builder(this);
									builder.SetView(view);
									builder.SetCancelable(true);
									AlertDialog dialog = builder.Create();
									dialog.Show();
									button.Click += delegate(object <p0>, EventArgs <p1>)
									{
										this.StartActivity(typeof(SignInUpDashboard));
										dialog.Dismiss();
									};
									button2.Click += delegate(object <p0>, EventArgs <p1>)
									{
										this.Recreate();
										dialog.Dismiss();
									};
									return;
								}
								if (this.user.FullName != userResponse.data.FullName || this.user.ProfileImage != userResponse.data.ProfileImage || this.user.GoogleProfilePhotoUrl != userResponse.data.GoogleProfilePhotoUrl || this.user.ProfileCover != userResponse.data.ProfileCover || this.user.Membership != userResponse.data.Membership)
								{
									this.user = userResponse.data;
									this.PrepareDrawerUserProfileUI();
									this.PrepareHeaderUserProfileUI(this.mMenu);
								}
								UsersViewModel.SaveUser(userResponse.data);
								return;
							}
							else
							{
								if (this.user.FullName != userResponse.data.FullName || this.user.ProfileImage != userResponse.data.ProfileImage || this.user.GoogleProfilePhotoUrl != userResponse.data.GoogleProfilePhotoUrl || this.user.ProfileCover != userResponse.data.ProfileCover || this.user.Membership != userResponse.data.Membership)
								{
									this.user = userResponse.data;
									this.PrepareDrawerUserProfileUI();
									this.PrepareHeaderUserProfileUI(this.mMenu);
								}
								UsersViewModel.SaveUser(userResponse.data);
							}
						}
					});
				}
				catch
				{
				}
			};
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000034CC File Offset: 0x000016CC
		private void InitDrawer()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("configuration.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"user_id",
					this.userId.ToString()
				},
				{
					"notification_id",
					SharedPreferencesSaves.IntSharedPreferencesGet("notification_id").ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object senderc, UploadValuesCompletedEventArgs ec)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(ec.Result);
					this.mainModel = JsonConvert.DeserializeObject<MainModel>(@string);
					base.RunOnUiThread(delegate()
					{
						if (this.user != null)
						{
							this.favSeriesCount.Text = this.mainModel.UserStatistics.library_favourites.ToString();
							this.watchCurrentlyCount.Text = this.mainModel.UserStatistics.library_watch_currently.ToString();
							this.watchLaterCount.Text = this.mainModel.UserStatistics.library_watch_later.ToString();
							this.watchDoneCount.Text = this.mainModel.UserStatistics.library_watch_done.ToString();
							this.PrepareUserNotifications();
						}
						this.InitConfigurations();
						this.InitDrawerNotifications();
					});
				}
				catch
				{
				}
			};
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003554 File Offset: 0x00001754
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000359C File Offset: 0x0000179C
		private void InitConfigurations()
		{
			try
			{
				if (this.mainModel.Configurations.status_app != 0)
				{
					AppStatus appStatus = new AppStatus();
					appStatus.Cancelable = false;
					FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
					appStatus.Show(transaction, "AppOffDialog");
				}
				else if (this.mainModel.Configurations.app_unskipable_version > 309)
				{
					Bundle bundle = new Bundle();
					bundle.PutInt("RequiredVersion", this.mainModel.Configurations.app_unskipable_version);
					bundle.PutBoolean("Skipability", false);
					bundle.PutString("AppNamespace", this.mainModel.Configurations.app_store_download_url);
					bundle.PutString("AppDownloadLink", this.mainModel.Configurations.app_download_url);
					AppUpdate appUpdate = new AppUpdate();
					appUpdate.Cancelable = false;
					FragmentTransaction transaction2 = this.SupportFragmentManager.BeginTransaction();
					appUpdate.Arguments = bundle;
					appUpdate.Show(transaction2, "UpdateDialog");
				}
				else
				{
					if (this.mainModel.Configurations.app_skipable_version > 309)
					{
						if (this.mainModel.Configurations.app_update_notifications > SharedPreferencesSaves.IntSharedPreferencesGet("UpdateNotificationNo"))
						{
							Bundle bundle2 = new Bundle();
							bundle2.PutInt("RequiredVersion", this.mainModel.Configurations.app_skipable_version);
							bundle2.PutBoolean("Skipability", true);
							bundle2.PutString("AppNamespace", this.mainModel.Configurations.app_store_download_url);
							bundle2.PutString("AppDownloadLink", this.mainModel.Configurations.app_download_url);
							bundle2.PutInt("Notification", this.mainModel.Configurations.app_update_notifications);
							AppUpdate appUpdate2 = new AppUpdate();
							appUpdate2.Cancelable = false;
							FragmentTransaction transaction3 = this.SupportFragmentManager.BeginTransaction();
							appUpdate2.Arguments = bundle2;
							appUpdate2.Show(transaction3, "UpdateDialog");
						}
					}
					else if (SharedPreferencesSaves.StringSharedPreferencesGet("IsFirstVisit") != "NO")
					{
						FirstEntranceSettingsPicker firstEntranceSettingsPicker = new FirstEntranceSettingsPicker();
						FragmentTransaction transaction4 = this.SupportFragmentManager.BeginTransaction();
						firstEntranceSettingsPicker.Cancelable = false;
						firstEntranceSettingsPicker.Show(transaction4, "DialogInitStylePick");
						FirebaseMessaging.Instance.SubscribeToTopic("News");
					}
					if (this.mainModel.Configurations.admin_notifications_id > SharedPreferencesSaves.IntSharedPreferencesGet("admin_notifications_id") && this.mMenu != null)
					{
						this.mMenu.FindItem(2131362607).SetVisible(true);
					}
					SharedPreferencesSaves.StringSharedPreferencesSave("WebsiteUrl", this.mainModel.Configurations.social_website);
					SharedPreferencesSaves.StringSharedPreferencesSave("FacebookUrl", this.mainModel.Configurations.social_facebook);
					SharedPreferencesSaves.StringSharedPreferencesSave("YoutubeUrl", this.mainModel.Configurations.social_youtube);
					SharedPreferencesSaves.StringSharedPreferencesSave("InstagramUrl", this.mainModel.Configurations.social_instagram);
					SharedPreferencesSaves.StringSharedPreferencesSave("StudiosList", this.mainModel.Configurations.collection_studios);
					SharedPreferencesSaves.StringSharedPreferencesSave("CurrentSeason", this.mainModel.Configurations.current_season);
					SharedPreferencesSaves.StringSharedPreferencesSave("YearsList", this.mainModel.Configurations.collection_years);
					SharedPreferencesSaves.IntSharedPreferencesSave("CommentsStatus", this.mainModel.Configurations.status_comments);
					SharedPreferencesSaves.IntSharedPreferencesSave("CommentsTimeSpan", this.mainModel.Configurations.comments_capping);
					SharedPreferencesSaves.IntSharedPreferencesSave("NewsAd", this.mainModel.Configurations.ad_news_ad_random_value);
					SharedPreferencesSaves.IntSharedPreferencesSave("GoogleAds", this.mainModel.Configurations.ad_googlead_random_value);
					SharedPreferencesSaves.IntSharedPreferencesSave("AppLovinAds", this.mainModel.Configurations.ad_applovin_random_value);
					SharedPreferencesSaves.IntSharedPreferencesSave("AdColonyAds", this.mainModel.Configurations.ad_adcolony_random_value);
					SharedPreferencesSaves.IntSharedPreferencesSave("StartappAds", this.mainModel.Configurations.ad_startapp_random_value);
					SharedPreferencesSaves.StringSharedPreferencesSave("GoogleWSAdUnit", this.mainModel.Configurations.ad_google_ws_ad_unit);
					SharedPreferencesSaves.StringSharedPreferencesSave("GoogleNSAdUnit", this.mainModel.Configurations.ad_google_ns_ad_unit);
					SharedPreferencesSaves.IntSharedPreferencesSave("RegistrationStatus", this.mainModel.Configurations.status_registration);
					SharedPreferencesSaves.IntSharedPreferencesSave("HomeTrendingStatus", this.mainModel.Configurations.status_home_trending);
					SharedPreferencesSaves.IntSharedPreferencesSave("WatchConfig", this.mainModel.Configurations.watch_config_v2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003A28 File Offset: 0x00001C28
		private void InitDrawerNotifications()
		{
			if (this.mainModel.UpdatesChart.news_count != SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewsCount"))
			{
				this.newNotify.Visibility = ViewStates.Visible;
				if (this.mainModel.UpdatesChart.news_count > SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewsCount"))
				{
					int num = this.mainModel.UpdatesChart.news_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewsCount");
					if (num >= 99)
					{
						this.newsNotifyText.Text = "+99 " + this.Resources.GetString(2131952225);
					}
					else
					{
						this.newsNotifyText.Text = num.ToString() + " " + this.Resources.GetString(2131952225);
					}
				}
			}
			else
			{
				this.newNotify.Visibility = ViewStates.Gone;
			}
			if (this.mainModel.UpdatesChart.new_episodes_count != SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewEpisodesCount"))
			{
				this.newEpisodeNotify.Visibility = ViewStates.Visible;
				if (this.mainModel.UpdatesChart.new_episodes_count > SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewEpisodesCount"))
				{
					int num2 = this.mainModel.UpdatesChart.new_episodes_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewEpisodesCount");
					if (num2 >= 99)
					{
						this.newEpisodeNotifyText.Text = "+99 " + this.Resources.GetString(2131952225);
					}
					else
					{
						this.newEpisodeNotifyText.Text = num2.ToString() + " " + this.Resources.GetString(2131952225);
					}
				}
			}
			else
			{
				this.newEpisodeNotify.Visibility = ViewStates.Gone;
			}
			if (this.mainModel.UpdatesChart.new_anime_count != SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewAnimeCount"))
			{
				this.newAnimeNotify.Visibility = ViewStates.Visible;
			}
			else
			{
				this.newAnimeNotify.Visibility = ViewStates.Gone;
			}
			if (this.mainModel.UpdatesChart.new_characters_count != SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewCharsCount"))
			{
				this.newCharacterNotify.Visibility = ViewStates.Visible;
				if (this.mainModel.UpdatesChart.new_characters_count > SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewCharsCount"))
				{
					int num3 = this.mainModel.UpdatesChart.new_characters_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewCharsCount");
					if (num3 >= 99)
					{
						this.newCharacterNotifyText.Text = "+99 " + this.Resources.GetString(2131952225);
					}
					else
					{
						this.newCharacterNotifyText.Text = num3.ToString() + " " + this.Resources.GetString(2131952225);
					}
				}
			}
			else
			{
				this.newCharacterNotify.Visibility = ViewStates.Gone;
			}
			if (this.mainModel.Configurations.social_youtube_new_videos == SharedPreferencesSaves.IntSharedPreferencesGet("LatestYoutubeVideosCount"))
			{
				this.mNewYoutubeVideoNotify.Visibility = ViewStates.Gone;
				return;
			}
			if (this.mainModel.Configurations.social_youtube_new_videos <= SharedPreferencesSaves.IntSharedPreferencesGet("LatestYoutubeVideosCount"))
			{
				SharedPreferencesSaves.IntSharedPreferencesSave("LatestYoutubeVideosCount", this.mainModel.Configurations.social_youtube_new_videos);
				return;
			}
			this.mNewYoutubeVideoNotify.Visibility = ViewStates.Visible;
			int num4 = this.mainModel.Configurations.social_youtube_new_videos - SharedPreferencesSaves.IntSharedPreferencesGet("LatestYoutubeVideosCount");
			if (num4 > 9)
			{
				this.mNewYoutubeVideoNotifyText.Text = "9+";
				return;
			}
			this.mNewYoutubeVideoNotifyText.Text = num4.ToString();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003D84 File Offset: 0x00001F84
		private void PrepareUserNotifications()
		{
			if (this.mainModel.UserStatistics.notifications <= SharedPreferencesSaves.IntSharedPreferencesGet("UserNotifications"))
			{
				this.notificationCircle.Visibility = ViewStates.Gone;
				SharedPreferencesSaves.IntSharedPreferencesSave("UserNotifications", this.mainModel.UserStatistics.notifications);
				return;
			}
			this.notificationCircle.Visibility = ViewStates.Visible;
			int num = this.mainModel.UserStatistics.notifications - SharedPreferencesSaves.IntSharedPreferencesGet("UserNotifications");
			SharedPreferencesSaves.IntSharedPreferencesSave("CurrentUserNotifications", num);
			if (num > 9)
			{
				this.notificationCircleText.Text = "9+";
				return;
			}
			this.notificationCircleText.Text = num.ToString();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003E2F File Offset: 0x0000202F
		protected override void AttachBaseContext(Context @base)
		{
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AppLanguage") == null)
			{
				base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
				return;
			}
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, SharedPreferencesSaves.StringSharedPreferencesGet("AppLanguage")));
		}

		// Token: 0x04000050 RID: 80
		public MainModel mainModel;

		// Token: 0x04000051 RID: 81
		private TextView favSeriesCount;

		// Token: 0x04000052 RID: 82
		private TextView watchCurrentlyCount;

		// Token: 0x04000053 RID: 83
		private TextView watchLaterCount;

		// Token: 0x04000054 RID: 84
		private TextView watchDoneCount;

		// Token: 0x04000055 RID: 85
		private LinearLayout newNotify;

		// Token: 0x04000056 RID: 86
		private LinearLayout newEpisodeNotify;

		// Token: 0x04000057 RID: 87
		private LinearLayout newAnimeNotify;

		// Token: 0x04000058 RID: 88
		private LinearLayout newCharacterNotify;

		// Token: 0x04000059 RID: 89
		private LinearLayout mNewYoutubeVideoNotify;

		// Token: 0x0400005A RID: 90
		private TextView newEpisodeNotifyText;

		// Token: 0x0400005B RID: 91
		private TextView newsNotifyText;

		// Token: 0x0400005C RID: 92
		private TextView newCharacterNotifyText;

		// Token: 0x0400005D RID: 93
		private TextView mNewYoutubeVideoNotifyText;

		// Token: 0x0400005E RID: 94
		private TextView navUserFullname;

		// Token: 0x0400005F RID: 95
		private CircleImageView navProfilePhoto;

		// Token: 0x04000060 RID: 96
		private CircleImageView headerProfilePhoto;

		// Token: 0x04000061 RID: 97
		private ImageView navUserPicPremiumMark;

		// Token: 0x04000062 RID: 98
		private ImageView navPofileCover;

		// Token: 0x04000063 RID: 99
		private NavigationView navigationView;

		// Token: 0x04000064 RID: 100
		private TabLayout mTabLayout;

		// Token: 0x04000065 RID: 101
		private FrameLayout notificationCircle;

		// Token: 0x04000066 RID: 102
		private TextView notificationCircleText;

		// Token: 0x04000067 RID: 103
		private UsersModel user;

		// Token: 0x04000068 RID: 104
		private int userId;

		// Token: 0x04000069 RID: 105
		private int onResumeCount;

		// Token: 0x0400006A RID: 106
		private IMenu mMenu;

		// Token: 0x0400006B RID: 107
		private static long back_pressed;
	}
}
