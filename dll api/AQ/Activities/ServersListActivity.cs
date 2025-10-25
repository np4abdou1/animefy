using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Com.Adcolony.Sdk;
using Com.Applovin.Adview;
using Com.Applovin.Sdk;
using Com.Unity3d.Ads;
using Com.Wang.Avi;
using Java.Interop;
using Java.Lang;
using Newtonsoft.Json;
using Warkiz.Widgets;

namespace AQ.Activities
{
	// Token: 0x020000CD RID: 205
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
	public class ServersListActivity : AppCompatActivity
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x000344D8 File Offset: 0x000326D8
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
			this.goNext = this.Intent.GetBooleanExtra("Next", false);
			this.goPrevious = this.Intent.GetBooleanExtra("Previous", false);
			if (this.goNext)
			{
				this.OverridePendingTransition(2130772024, 2130772027);
			}
			else if (this.goPrevious)
			{
				this.OverridePendingTransition(2130772025, 2130772026);
			}
			base.OnCreate(savedInstanceState);
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558467);
			this.mAnimeId = this.Intent.GetStringExtra("AnimeId");
			this.mAnimeTitle = this.Intent.GetStringExtra("AnimeTitle");
			this.mAnimeType = this.Intent.GetStringExtra("AnimeType");
			this.mEpisode = this.Intent.GetFloatExtra("Episode", 0f);
			this.mExtraEpisodes = this.Intent.GetStringExtra("ExtraEpisodes");
			this.mEpisodeType = this.Intent.GetStringExtra("EpisodeType");
			this.mMarkedAs = this.Intent.GetStringExtra("MarkedAs");
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.membership = ((this.user == null) ? "" : this.user.Membership);
			this.mServersContent = base.FindViewById<LinearLayout>(2131362986);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mRateRefreshLoader = base.FindViewById<AVLoadingIndicatorView>(2131362874);
			this.mRateSeekerBar = base.FindViewById<IndicatorSeekBar>(2131362968);
			this.mUsersRate = base.FindViewById<TextView>(2131362343);
			this.mRatedUsersCount = base.FindViewById<TextView>(2131362347);
			this.mRatedUsersCount.Text = this.Resources.GetString(2131951726) + " (... " + this.Resources.GetString(2131952293) + ") ";
			this.mSVStatus = base.FindViewById<ImageView>(2131363034);
			this.mOkStatus = base.FindViewById<ImageView>(2131363032);
			this.mMaStatus = base.FindViewById<ImageView>(2131363031);
			this.mFrLowQStatus = base.FindViewById<ImageView>(2131363027);
			this.mSVLowQStatus = base.FindViewById<ImageView>(2131363035);
			this.mFrContent = base.FindViewById<RelativeLayout>(2131362988);
			this.mSfContent = base.FindViewById<RelativeLayout>(2131363021);
			this.mGdContent = base.FindViewById<RelativeLayout>(2131363000);
			this.mLowQualitiesSeperator = base.FindViewById<LinearLayout>(2131363007);
			this.mFHDQualitiesSeperator = base.FindViewById<LinearLayout>(2131362987);
			this.mLbFhdContent = base.FindViewById<RelativeLayout>(2131363005);
			this.mGdFhdContent = base.FindViewById<RelativeLayout>(2131363001);
			this.mFrFhdContent = base.FindViewById<RelativeLayout>(2131362990);
			this.mLBWatch = base.FindViewById<Button>(2131362978);
			this.mSVWatch = base.FindViewById<Button>(2131362983);
			this.mMaWatch = base.FindViewById<Button>(2131362981);
			this.mOkWatch = base.FindViewById<Button>(2131362982);
			this.mFdWatch = base.FindViewById<Button>(2131362976);
			this.mFrWatch = base.FindViewById<Button>(2131362999);
			this.mSfWatch = base.FindViewById<Button>(2131363024);
			this.mGdWatch = base.FindViewById<Button>(2131363004);
			this.mLBLowQWatch = base.FindViewById<Button>(2131362980);
			this.mSVLowQWatch = base.FindViewById<Button>(2131362984);
			this.mFrLowQWatch = base.FindViewById<Button>(2131362998);
			this.mLbFhdWatch = base.FindViewById<Button>(2131362979);
			this.mGdFhdWatch = base.FindViewById<Button>(2131362977);
			this.mFrFhdQWatch = base.FindViewById<Button>(2131362993);
			this.mFrFhdQDownload = base.FindViewById<Button>(2131362991);
			this.mFrDownload = base.FindViewById<Button>(2131362989);
			this.mSfDownload = base.FindViewById<Button>(2131363022);
			this.mFrLowQDownload = base.FindViewById<Button>(2131362996);
			this.mFrLoader = base.FindViewById<ProgressBar>(2131362994);
			this.mSfLoader = base.FindViewById<ProgressBar>(2131363023);
			this.mGdLoader = base.FindViewById<ProgressBar>(2131363003);
			this.mFrLowQLoader = base.FindViewById<ProgressBar>(2131362997);
			this.mGdFhdLoader = base.FindViewById<ProgressBar>(2131363002);
			this.mFrFhdQLoader = base.FindViewById<ProgressBar>(2131362992);
			this.mFrServerName = base.FindViewById<TextView>(2131363009);
			this.mSfServerName = base.FindViewById<TextView>(2131363017);
			this.mGdFhdServerName = base.FindViewById<TextView>(2131363013);
			this.mFrFhdServerName = base.FindViewById<TextView>(2131363010);
			this.mRateDeleteIcon = base.FindViewById<ImageView>(2131362345);
			this.mRateDeleteProgressBar = base.FindViewById<ProgressBar>(2131362346);
			this.mComments = base.FindViewById<Button>(2131362985);
			this.InitAppBarTitle();
			this.LoadAd();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadServers();
			});
			this.mLBWatch.Click += this.MLBWatch_Click;
			this.mSVWatch.Click += this.MSVWatch_Click;
			this.mMaWatch.Click += this.MMaWatch_Click;
			this.mOkWatch.Click += this.MOkWatch_Click;
			this.mGdWatch.Click += this.MGdWatch_Click;
			this.mFrWatch.Click += this.MFrWatch_Click;
			this.mSfWatch.Click += this.MSfWatch_Click;
			this.mFdWatch.Click += this.MFdWatch_Click;
			this.mLBLowQWatch.Click += this.MLBLowQWatch_Click;
			this.mSVLowQWatch.Click += this.MSVLowQWatch_Click;
			this.mFrLowQWatch.Click += this.MFrLowQWatch_Click;
			this.mFrDownload.Click += this.MFrDownload_Click;
			this.mSfDownload.Click += this.MSfDownload_Click;
			this.mFrLowQDownload.Click += this.MFrLowQDownload_Click;
			this.mLbFhdWatch.Click += this.MLbFhdWatch_Click;
			this.mGdFhdWatch.Click += this.MGdFhdWatch_Click;
			this.mFrFhdQWatch.Click += this.MFrFhdQWatch_Click;
			this.mFrFhdQDownload.Click += this.MFrFhdQDownload_Click;
			this.mComments.Click += this.MComments_Click;
			this.mRateDeleteIcon.Click += this.MRateDeleteIcon_Click;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.mRateSeekerBar.OnSeekChangeListener = new ServersListActivity.SeekChangeListener(this, this.mRateRefreshLoader);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00034C78 File Offset: 0x00032E78
		private void MComments_Click(object sender, EventArgs e)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.mAnimeId);
			bundle.PutString("CommType", this.mAnimeType);
			bundle.PutFloat("Episode", this.mEpisode);
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00034CE4 File Offset: 0x00032EE4
		private void MRewardAdCancel_Click(object sender, EventArgs e)
		{
			this.Finish();
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00034CEC File Offset: 0x00032EEC
		private void LoadAd()
		{
			if (this.membership == "PREMIUM" || this.membership == "ADMIN")
			{
				if (SharedPreferencesSaves.StringSharedPreferencesGet("IsAdsRemoved") == "False")
				{
					this.ShowAd();
					return;
				}
			}
			else
			{
				this.ShowAd();
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00034D40 File Offset: 0x00032F40
		private void ShowAd()
		{
			if (new Random().Next(0, SharedPreferencesSaves.IntSharedPreferencesGet("AppLovinAds")) == 0)
			{
				AppLovinSdk.GetInstance(this).AdService.LoadNextAd(AppLovinAdSize.Interstitial, new ServersListActivity.AppLovinAdLoadListener(this));
				return;
			}
			if (new Random().Next(0, SharedPreferencesSaves.IntSharedPreferencesGet("GoogleAds")) == 0)
			{
				UnityAds.Load("Interstitial_Android", new ServersListActivity.UnityAdsLoadListener(this));
				return;
			}
			if (new Random().Next(0, SharedPreferencesSaves.IntSharedPreferencesGet("AdColonyAds")) == 0)
			{
				AdColony.RequestInterstitial(base.GetString(2131951658), new ServersListActivity.AdColonyListener(this));
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00034DD8 File Offset: 0x00032FD8
		private float CalculateRateing(int[] rating)
		{
			return (float)(rating[0] + 2 * rating[1] + 3 * rating[2] + 4 * rating[3] + 5 * rating[4] + 6 * rating[5] + 7 * rating[6] + 8 * rating[7] + 9 * rating[8] + 10 * rating[9]) / (float)(rating[0] + rating[1] + rating[2] + rating[3] + rating[4] + rating[5] + rating[6] + rating[7] + rating[8] + rating[9]);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00034E4C File Offset: 0x0003304C
		private void MRateDeleteIcon_Click(object sender, EventArgs e)
		{
			this.mRateDeleteIcon.Visibility = ViewStates.Gone;
			this.mRateDeleteProgressBar.Visibility = ViewStates.Visible;
			this.DeleteRate();
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00034E6C File Offset: 0x0003306C
		private void SetRate(int rate)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("anime/rating/rate_set.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"AnimeId",
					this.mAnimeId
				},
				{
					"Episode",
					this.mEpisode.ToString()
				},
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Rate",
					rate.ToString()
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
					EpisodesStatistics statistics = JsonConvert.DeserializeObject<EpisodesStatistics>(@string);
					base.RunOnUiThread(delegate()
					{
						this.CalculateAnimeRating(statistics);
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
						this.mRateRefreshLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mRateSeekerBar.SetProgress(1f);
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
						this.mRateRefreshLoader.Visibility = ViewStates.Gone;
					});
				}
			};
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00034F10 File Offset: 0x00033110
		private void DeleteRate()
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("anime/rating/rate_delete.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"AnimeId",
					this.mAnimeId
				},
				{
					"Episode",
					this.mEpisode.ToString()
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
					EpisodesStatistics episodesStatistics = JsonConvert.DeserializeObject<EpisodesStatistics>(@string);
					if (episodesStatistics != null)
					{
						this.mRateDeleteIcon.Visibility = ViewStates.Gone;
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
						this.mRateSeekerBar.SetProgress(1f);
						this.CalculateAnimeRating(episodesStatistics);
					}
					else
					{
						this.mRateDeleteIcon.Visibility = ViewStates.Visible;
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
					}
				}
				catch
				{
					this.mRateDeleteIcon.Visibility = ViewStates.Visible;
					this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
				}
			};
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00034FA0 File Offset: 0x000331A0
		private void CalculateAnimeRating(EpisodesStatistics statistics)
		{
			if (statistics.UserRate > 0)
			{
				this.mRateDeleteIcon.Visibility = ViewStates.Visible;
			}
			else
			{
				this.mRateDeleteIcon.Visibility = ViewStates.Gone;
			}
			int[] ratings = new int[]
			{
				statistics.rates_1,
				statistics.rates_2,
				statistics.rates_3,
				statistics.rates_4,
				statistics.rates_5,
				statistics.rates_6,
				statistics.rates_7,
				statistics.rates_8,
				statistics.rates_9,
				statistics.rates_10
			};
			base.RunOnUiThread(delegate()
			{
				float num = this.CalculateRateing(ratings);
				if (!float.IsNaN(num))
				{
					if ((double)num > 9.9)
					{
						this.mUsersRate.Text = string.Format("{0:0}", num);
					}
					else
					{
						this.mUsersRate.Text = string.Format("{0:0.0}", num);
					}
				}
				else
				{
					this.mUsersRate.Text = "0";
				}
				this.mRateSeekerBar.SetProgress((float)statistics.UserRate);
				int num2 = statistics.rates_1 + statistics.rates_2 + statistics.rates_3 + statistics.rates_4 + statistics.rates_5 + statistics.rates_6 + statistics.rates_7 + statistics.rates_8 + statistics.rates_9 + statistics.rates_10;
				this.mRatedUsersCount.Text = string.Concat(new string[]
				{
					"(",
					string.Format("{0:N0}", num2),
					" ",
					this.Resources.GetString(2131952293),
					")"
				});
			});
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00035098 File Offset: 0x00033298
		private void MLbFhdWatch_Click(object sender, EventArgs e)
		{
			if (this.LbFhdQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchLBActivity));
			intent.PutExtra("WatchLink", this.LbFhdQLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000350FC File Offset: 0x000332FC
		private void MLBLowQWatch_Click(object sender, EventArgs e)
		{
			if (this.LbLowQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchLBActivity));
			intent.PutExtra("WatchLink", this.LbLowQLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00035160 File Offset: 0x00033360
		private void MLBWatch_Click(object sender, EventArgs e)
		{
			if (this.LbLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchLBActivity));
			intent.PutExtra("WatchLink", this.LbLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000351C4 File Offset: 0x000333C4
		private void MFdWatch_Click(object sender, EventArgs e)
		{
			if (this.FDLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchFDActivity));
			intent.PutExtra("WatchLink", this.FDLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00035228 File Offset: 0x00033428
		private void MSfDownload_Click(object sender, EventArgs e)
		{
			if (this.SfLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			this.mSfLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromSf(this.SfLink, "Download");
			});
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00035280 File Offset: 0x00033480
		private void MSfWatch_Click(object sender, EventArgs e)
		{
			if (this.SfLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			this.mSfLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromSf(this.SfLink, "Watch");
			});
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000352D8 File Offset: 0x000334D8
		private void MFrFhdQDownload_Click(object sender, EventArgs e)
		{
			if (this.FrFhdQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			this.mFrFhdQLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromMediaFire(this.FrFhdQLink, "Download", "fhd");
			});
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00035330 File Offset: 0x00033530
		private void MFrFhdQWatch_Click(object sender, EventArgs e)
		{
			if (this.FrFhdQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			this.mFrFhdQLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromMediaFire(this.FrFhdQLink, "Watch", "fhd");
			});
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00035385 File Offset: 0x00033585
		private void MGdFhdWatch_Click(object sender, EventArgs e)
		{
			this.mGdFhdLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromGD(this.GdFhdQLink);
			});
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000353A8 File Offset: 0x000335A8
		private void MFrLowQDownload_Click(object sender, EventArgs e)
		{
			if (this.FrLowQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			this.mFrLowQLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromMediaFire(this.FrLowQLink, "Download", "sd");
			});
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00035400 File Offset: 0x00033600
		private void MFrLowQWatch_Click(object sender, EventArgs e)
		{
			if (this.FrLowQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			this.mFrLowQLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromMediaFire(this.FrLowQLink, "Watch", "sd");
			});
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00035455 File Offset: 0x00033655
		private void MGdWatch_Click(object sender, EventArgs e)
		{
			this.mGdLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromGD(this.GdLink);
			});
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00035475 File Offset: 0x00033675
		private void MFrDownload_Click(object sender, EventArgs e)
		{
			this.mFrLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromMediaFire(this.FrLink, "Download", "hd");
			});
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00035495 File Offset: 0x00033695
		private void MFrWatch_Click(object sender, EventArgs e)
		{
			this.mFrLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.PlayFromMediaFire(this.FrLink, "Watch", "hd");
			});
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x000354B5 File Offset: 0x000336B5
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689511, menu);
			this.localMenu = menu;
			return true;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000354D0 File Offset: 0x000336D0
		private void ReloadServers()
		{
			this.InitAppBarTitle();
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mServersContent.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadServers();
			});
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0003550E File Offset: 0x0003370E
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.ReloadServers();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00035518 File Offset: 0x00033718
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId == 2131362641)
			{
				if (this.mAnimeType == "SERIES" && this.isLoadingFinished && this.mEpisodeResponse.NextEpisode != null)
				{
					Intent intent = new Intent(this, typeof(ServersListActivity));
					intent.PutExtra("AnimeId", this.mAnimeId);
					intent.PutExtra("AnimeTitle", this.mAnimeTitle);
					intent.PutExtra("AnimeType", this.mAnimeType);
					intent.PutExtra("Episode", this.mEpisodeResponse.NextEpisode.Episode);
					intent.PutExtra("ExtraEpisodes", this.mEpisodeResponse.NextEpisode.ExtraEpisodes);
					intent.PutExtra("EpisodeType", this.mEpisodeResponse.NextEpisode.Type);
					intent.PutExtra("MarkedAs", this.mEpisodeResponse.NextEpisode.MarkedAs);
					intent.PutExtra("Next", true);
					this.StartActivity(intent);
					if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") != "OFF")
					{
						WatchHistoryViewModel.AddLocaleHistory(this.mEpisodeResponse.NextEpisode.AnimeID, this.mEpisodeResponse.NextEpisode.Episode);
					}
					this.Finish();
				}
				return true;
			}
			if (itemId != 2131362647)
			{
				return base.OnOptionsItemSelected(item);
			}
			if (this.mAnimeType == "SERIES" && this.isLoadingFinished && this.mEpisodeResponse.PreviousEpisode != null)
			{
				Intent intent2 = new Intent(this, typeof(ServersListActivity));
				intent2.PutExtra("AnimeId", this.mAnimeId);
				intent2.PutExtra("AnimeTitle", this.mAnimeTitle);
				intent2.PutExtra("AnimeType", this.mAnimeType);
				intent2.PutExtra("Episode", this.mEpisodeResponse.PreviousEpisode.Episode);
				intent2.PutExtra("ExtraEpisodes", this.mEpisodeResponse.PreviousEpisode.ExtraEpisodes);
				intent2.PutExtra("EpisodeType", this.mEpisodeResponse.PreviousEpisode.Type);
				intent2.PutExtra("MarkedAs", this.mEpisodeResponse.PreviousEpisode.MarkedAs);
				intent2.PutExtra("Previous", true);
				this.StartActivity(intent2);
				if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") != "OFF")
				{
					WatchHistoryViewModel.AddLocaleHistory(this.mEpisodeResponse.PreviousEpisode.AnimeID, this.mEpisodeResponse.PreviousEpisode.Episode);
				}
				this.Finish();
			}
			return true;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000357D8 File Offset: 0x000339D8
		private string GetFileName()
		{
			string result;
			if (this.mAnimeType == "MOVIE")
			{
				result = this.mAnimeTitle;
			}
			else if (this.mEpisodeType == "OVA")
			{
				result = this.mAnimeTitle + " - " + this.Resources.GetString(2131952541);
			}
			else if (this.mEpisodeType == "SPECIAL")
			{
				result = this.mAnimeTitle + " - " + this.Resources.GetString(2131952542);
			}
			else if (this.mExtraEpisodes != "")
			{
				if (this.mMarkedAs == "LAST")
				{
					result = string.Concat(new string[]
					{
						this.mAnimeTitle,
						" - E",
						this.mEpisode.ToString(),
						"-",
						this.mExtraEpisodes,
						"  ",
						this.Resources.GetString(2131952025)
					});
				}
				else
				{
					result = string.Concat(new string[]
					{
						this.mAnimeTitle,
						" - E",
						this.mEpisode.ToString(),
						"-",
						this.mExtraEpisodes
					});
				}
			}
			else if (this.mMarkedAs == "LAST")
			{
				result = string.Concat(new string[]
				{
					this.mAnimeTitle,
					" - E",
					this.mEpisode.ToString(),
					"  ",
					this.Resources.GetString(2131952025)
				});
			}
			else
			{
				result = this.mAnimeTitle + " - E" + this.mEpisode.ToString();
			}
			return result;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000359AC File Offset: 0x00033BAC
		private void InitAppBarTitle()
		{
			if (this.mAnimeType == "MOVIE")
			{
				this.SupportActionBar.Title = this.mAnimeTitle;
				return;
			}
			if (this.mEpisodeType == "OVA")
			{
				this.SupportActionBar.Title = string.Concat(new string[]
				{
					this.Resources.GetString(2131951895),
					" ",
					this.mEpisode.ToString(),
					"  ",
					this.Resources.GetString(2131952541),
					" - ",
					this.mAnimeTitle
				});
				return;
			}
			if (this.mEpisodeType == "SPECIAL")
			{
				this.SupportActionBar.Title = string.Concat(new string[]
				{
					this.Resources.GetString(2131951895),
					" ",
					this.mEpisode.ToString(),
					"  ",
					this.Resources.GetString(2131952542),
					" - ",
					this.mAnimeTitle
				});
				return;
			}
			if (this.mExtraEpisodes != "")
			{
				if (this.mMarkedAs == "LAST")
				{
					this.SupportActionBar.Title = string.Concat(new string[]
					{
						this.Resources.GetString(2131951895),
						" ",
						this.mEpisode.ToString(),
						"-",
						this.mExtraEpisodes,
						"  ",
						this.Resources.GetString(2131952025),
						" - ",
						this.mAnimeTitle
					});
					return;
				}
				this.SupportActionBar.Title = string.Concat(new string[]
				{
					this.Resources.GetString(2131951895),
					" ",
					this.mEpisode.ToString(),
					"-",
					this.mExtraEpisodes,
					" - ",
					this.mAnimeTitle
				});
				return;
			}
			else
			{
				if (this.mMarkedAs == "LAST")
				{
					this.SupportActionBar.Title = string.Concat(new string[]
					{
						this.Resources.GetString(2131951895),
						" ",
						this.mEpisode.ToString(),
						"  ",
						this.Resources.GetString(2131952025),
						" - ",
						this.mAnimeTitle
					});
					return;
				}
				this.SupportActionBar.Title = string.Concat(new string[]
				{
					this.Resources.GetString(2131951895),
					" ",
					this.mEpisode.ToString(),
					" - ",
					this.mAnimeTitle
				});
				return;
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00035CB0 File Offset: 0x00033EB0
		private void MMaWatch_Click(object sender, EventArgs e)
		{
			if (this.MaLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchMAActivity));
			intent.PutExtra("WatchLink", this.MaLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00035D14 File Offset: 0x00033F14
		private void MSVWatch_Click(object sender, EventArgs e)
		{
			if (this.SvLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchSVActivity));
			intent.PutExtra("WatchLink", this.SvLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00035D78 File Offset: 0x00033F78
		private void MSVLowQWatch_Click(object sender, EventArgs e)
		{
			if (this.SvLowQLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchSVActivity));
			intent.PutExtra("WatchLink", this.SvLowQLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00035DDC File Offset: 0x00033FDC
		private void MOkWatch_Click(object sender, EventArgs e)
		{
			if (this.OkLink == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952388), 0);
				return;
			}
			Intent intent = new Intent(this, typeof(WatchOKActivity));
			intent.PutExtra("WatchLink", this.OkLink);
			this.StartActivity(intent);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00035E40 File Offset: 0x00034040
		private void InitStatus()
		{
			if (this.SvLink == "" && this.LbLink == "")
			{
				this.mSVStatus.SetImageResource(2131231215);
				this.mSVWatch.SetBackgroundResource(2131230904);
				this.mLBWatch.SetBackgroundResource(2131230904);
				this.mSVWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
				this.mLBWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
			}
			else
			{
				if (this.SvLink == "")
				{
					this.mSVWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
					this.mSVWatch.SetBackgroundResource(2131230904);
				}
				if (this.LbLink == "")
				{
					this.mLBWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
					this.mLBWatch.SetBackgroundResource(2131230904);
				}
			}
			if (this.MaLink == "")
			{
				this.mMaStatus.SetImageResource(2131231215);
				this.mMaWatch.SetBackgroundResource(2131230904);
				this.mMaWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
			}
			if (this.OkLink == "" && this.FDLink == "")
			{
				this.mOkStatus.SetImageResource(2131231215);
				this.mOkWatch.SetBackgroundResource(2131230904);
				this.mFdWatch.SetBackgroundResource(2131230904);
				this.mOkWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
				this.mFdWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
			}
			else
			{
				if (this.OkLink == "")
				{
					this.mOkWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
					this.mOkWatch.SetBackgroundResource(2131230904);
				}
				if (this.FDLink == "")
				{
					this.mFdWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
					this.mFdWatch.SetBackgroundResource(2131230904);
				}
			}
			if (this.SfLink == "")
			{
				this.mSfContent.Visibility = ViewStates.Gone;
			}
			if (this.GdLink == "")
			{
				this.mGdContent.Visibility = ViewStates.Gone;
				this.mFrServerName.Text = this.Resources.GetString(2131952382);
			}
			if (this.FrLink == "")
			{
				this.mFrContent.Visibility = ViewStates.Gone;
				this.mSfServerName.Text = this.Resources.GetString(2131952382);
			}
			if (this.FrLowQLink == "" && this.SvLowQLink == "" && this.LbLowQLink == "")
			{
				this.mLowQualitiesSeperator.Visibility = ViewStates.Gone;
			}
			else
			{
				if (this.SvLowQLink == "" && this.LbLowQLink == "")
				{
					this.mSVLowQStatus.SetImageResource(2131231215);
					this.mSVLowQWatch.SetBackgroundResource(2131230904);
					this.mLBLowQWatch.SetBackgroundResource(2131230904);
					this.mSVLowQWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
					this.mLBLowQWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
				}
				else
				{
					if (this.SvLowQLink == "")
					{
						this.mSVLowQWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
						this.mSVLowQWatch.SetBackgroundResource(2131230904);
					}
					if (this.LbLowQLink == "")
					{
						this.mLBLowQWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
						this.mLBLowQWatch.SetBackgroundResource(2131230904);
					}
				}
				if (this.FrLowQLink == "")
				{
					this.mFrLowQStatus.SetImageResource(2131231215);
					this.mFrLowQWatch.SetBackgroundResource(2131230904);
					this.mFrLowQWatch.SetTextColor(Color.ParseColor("#99FFFFFF"));
					this.mFrLowQDownload.SetBackgroundResource(2131230904);
					this.mFrLowQDownload.SetTextColor(Color.ParseColor("#99FFFFFF"));
				}
			}
			if (this.LbFhdQLink == "" && this.GdFhdQLink == "" && this.FrFhdQLink == "")
			{
				this.mFHDQualitiesSeperator.Visibility = ViewStates.Gone;
				return;
			}
			if (this.LbFhdQLink == "")
			{
				this.mLbFhdContent.Visibility = ViewStates.Gone;
				this.mGdFhdServerName.Text = this.Resources.GetString(2131952379);
				this.mFrFhdServerName.Text = this.Resources.GetString(2131952380);
			}
			if (this.GdFhdQLink == "")
			{
				this.mGdFhdContent.Visibility = ViewStates.Gone;
				if (this.LbFhdQLink == "")
				{
					this.mFrFhdServerName.Text = this.Resources.GetString(2131952379);
				}
				else
				{
					this.mFrFhdServerName.Text = this.Resources.GetString(2131952380);
				}
			}
			if (this.FrFhdQLink == "")
			{
				this.mFrFhdContent.Visibility = ViewStates.Gone;
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000363C0 File Offset: 0x000345C0
		private void LoadServers()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("anime/load_servers.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("AnimeId", this.mAnimeId);
			this.parameters.Add("Episode", this.mEpisode.ToString());
			this.parameters.Add("AnimeType", this.mAnimeType);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				base.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						this.mEpisodeResponse = JsonConvert.DeserializeObject<EpisodeResponse>(@string);
						if (this.mEpisodeResponse != null)
						{
							this.LbLink = this.mEpisodeResponse.CurrentEpisode.LBLink;
							this.SvLink = this.mEpisodeResponse.CurrentEpisode.SVLink;
							this.OkLink = this.mEpisodeResponse.CurrentEpisode.OKLink;
							this.MaLink = this.mEpisodeResponse.CurrentEpisode.MALink;
							this.GdLink = this.mEpisodeResponse.CurrentEpisode.GDLink;
							this.FrLink = this.mEpisodeResponse.CurrentEpisode.FRLink;
							this.SfLink = this.mEpisodeResponse.CurrentEpisode.SFLink;
							this.FDLink = this.mEpisodeResponse.CurrentEpisode.FDLink;
							this.LbLowQLink = this.mEpisodeResponse.CurrentEpisode.LBLowQ;
							this.SvLowQLink = this.mEpisodeResponse.CurrentEpisode.SVLowQ;
							this.FrLowQLink = this.mEpisodeResponse.CurrentEpisode.FRLowQ;
							this.LbFhdQLink = this.mEpisodeResponse.CurrentEpisode.LBFhdQ;
							this.GdFhdQLink = this.mEpisodeResponse.CurrentEpisode.GDFhdQ;
							this.FrFhdQLink = this.mEpisodeResponse.CurrentEpisode.FRFhdQ;
							if (this.localMenu != null)
							{
								if (this.mEpisodeResponse.NextEpisode != null)
								{
									this.localMenu.FindItem(2131362641).SetIcon(2131230961);
								}
								if (this.mEpisodeResponse.PreviousEpisode != null)
								{
									this.localMenu.FindItem(2131362647).SetIcon(2131230959);
								}
							}
							this.InitStatus();
							if (this.mEpisodeResponse.CurrentEpisode.EpisodeStatistics != null)
							{
								this.CalculateAnimeRating(this.mEpisodeResponse.CurrentEpisode.EpisodeStatistics);
							}
							this.isLoadingFinished = true;
						}
						this.mLoader.Visibility = ViewStates.Gone;
						if (SharedPreferencesSaves.IntSharedPreferencesGet("WatchConfig") != 0)
						{
							this.mServersContent.Visibility = ViewStates.Visible;
						}
					}
					catch
					{
						this.mOfflineView.Visibility = ViewStates.Visible;
						this.mLoader.Visibility = ViewStates.Gone;
						this.mServersContent.Visibility = ViewStates.Gone;
					}
				});
			};
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000364A0 File Offset: 0x000346A0
		private void PlayFromMediaFire(string id, string action, string q)
		{
			try
			{
				string value = CustomizedDownloader.FrDownload("https://www.mediafire.com/file/" + id);
				if (action == "Watch")
				{
					Bundle bundle = new Bundle();
					bundle.PutString("StreamLink", value);
					WatchBy watchBy = new WatchBy();
					FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
					watchBy.Arguments = bundle;
					watchBy.Show(transaction, "DialogWatchBy");
				}
				else
				{
					Bundle bundle2 = new Bundle();
					bundle2.PutString("DownloadLink", value);
					bundle2.PutString("Title", this.mAnimeTitle);
					bundle2.PutString("FileName", this.GetFileName());
					bundle2.PutString("Type", this.mAnimeType);
					bundle2.PutString("FileSize", "");
					DownloadBy downloadBy = new DownloadBy();
					FragmentTransaction transaction2 = this.SupportFragmentManager.BeginTransaction();
					downloadBy.Arguments = bundle2;
					downloadBy.Show(transaction2, "DialogDownloadBy");
				}
			}
			catch
			{
				if (this.SfLink != "")
				{
					this.PlayFromSf(this.SfLink, action);
				}
				else
				{
					base.RunOnUiThread(delegate()
					{
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952259), 0);
					});
				}
			}
			base.RunOnUiThread(delegate()
			{
				this.mFrLoader.Visibility = ViewStates.Gone;
				this.mFrLowQLoader.Visibility = ViewStates.Gone;
				this.mFrFhdQLoader.Visibility = ViewStates.Gone;
			});
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000365EC File Offset: 0x000347EC
		private void PlayFromSf(string id, string action)
		{
			try
			{
				string str = CustomizedDownloader.SFDownload("http://www.solidfiles.com/v/" + id);
				if (action == "Watch")
				{
					Bundle bundle = new Bundle();
					bundle.PutString("StreamLink", str + "/[Animeify]" + this.GetFileName() + ".mp4");
					WatchBy watchBy = new WatchBy();
					FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
					watchBy.Arguments = bundle;
					watchBy.Show(transaction, "DialogWatchBy");
				}
				else
				{
					Bundle bundle2 = new Bundle();
					bundle2.PutString("DownloadLink", str + "/[Animeify]" + this.GetFileName() + ".mp4");
					bundle2.PutString("Title", this.mAnimeTitle);
					bundle2.PutString("FileName", this.GetFileName());
					bundle2.PutString("Type", this.mAnimeType);
					bundle2.PutString("FileSize", "");
					DownloadBy downloadBy = new DownloadBy();
					FragmentTransaction transaction2 = this.SupportFragmentManager.BeginTransaction();
					downloadBy.Arguments = bundle2;
					downloadBy.Show(transaction2, "DialogDownloadBy");
				}
			}
			catch
			{
				base.RunOnUiThread(delegate()
				{
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131952259), 0);
				});
			}
			base.RunOnUiThread(delegate()
			{
				this.mSfLoader.Visibility = ViewStates.Gone;
			});
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0003674C File Offset: 0x0003494C
		private void PlayFromGD(string id)
		{
			try
			{
				Bundle bundle = new Bundle();
				bundle.PutString("StreamLink", string.Format("https://www.googleapis.com/drive/v3/files/{0}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media", id));
				WatchBy watchBy = new WatchBy();
				FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
				watchBy.Arguments = bundle;
				watchBy.Show(transaction, "DialogWatchBy");
			}
			catch
			{
				base.RunOnUiThread(delegate()
				{
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131952259), 0);
				});
			}
			base.RunOnUiThread(delegate()
			{
				this.mGdLoader.Visibility = ViewStates.Gone;
				this.mGdFhdLoader.Visibility = ViewStates.Gone;
			});
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000798 RID: 1944
		private UsersModel user;

		// Token: 0x04000799 RID: 1945
		private int userId;

		// Token: 0x0400079A RID: 1946
		private string membership = "";

		// Token: 0x0400079B RID: 1947
		private ImageView mSVStatus;

		// Token: 0x0400079C RID: 1948
		private ImageView mOkStatus;

		// Token: 0x0400079D RID: 1949
		private ImageView mMaStatus;

		// Token: 0x0400079E RID: 1950
		private ImageView mFrLowQStatus;

		// Token: 0x0400079F RID: 1951
		private ImageView mSVLowQStatus;

		// Token: 0x040007A0 RID: 1952
		private ImageView mRateDeleteIcon;

		// Token: 0x040007A1 RID: 1953
		private LinearLayout mServersContent;

		// Token: 0x040007A2 RID: 1954
		private LinearLayout mLowQualitiesSeperator;

		// Token: 0x040007A3 RID: 1955
		private LinearLayout mFHDQualitiesSeperator;

		// Token: 0x040007A4 RID: 1956
		private RelativeLayout mFrContent;

		// Token: 0x040007A5 RID: 1957
		private RelativeLayout mSfContent;

		// Token: 0x040007A6 RID: 1958
		private RelativeLayout mGdContent;

		// Token: 0x040007A7 RID: 1959
		private RelativeLayout mLbFhdContent;

		// Token: 0x040007A8 RID: 1960
		private RelativeLayout mFrFhdContent;

		// Token: 0x040007A9 RID: 1961
		private RelativeLayout mGdFhdContent;

		// Token: 0x040007AA RID: 1962
		private Button mLBWatch;

		// Token: 0x040007AB RID: 1963
		private Button mSVWatch;

		// Token: 0x040007AC RID: 1964
		private Button mOkWatch;

		// Token: 0x040007AD RID: 1965
		private Button mMaWatch;

		// Token: 0x040007AE RID: 1966
		private Button mFdWatch;

		// Token: 0x040007AF RID: 1967
		private Button mGdWatch;

		// Token: 0x040007B0 RID: 1968
		private Button mFrWatch;

		// Token: 0x040007B1 RID: 1969
		private Button mSfWatch;

		// Token: 0x040007B2 RID: 1970
		private Button mLBLowQWatch;

		// Token: 0x040007B3 RID: 1971
		private Button mSVLowQWatch;

		// Token: 0x040007B4 RID: 1972
		private Button mFrDownload;

		// Token: 0x040007B5 RID: 1973
		private Button mSfDownload;

		// Token: 0x040007B6 RID: 1974
		private Button mFrLowQWatch;

		// Token: 0x040007B7 RID: 1975
		private Button mFrLowQDownload;

		// Token: 0x040007B8 RID: 1976
		private Button mLbFhdWatch;

		// Token: 0x040007B9 RID: 1977
		private Button mGdFhdWatch;

		// Token: 0x040007BA RID: 1978
		private Button mFrFhdQWatch;

		// Token: 0x040007BB RID: 1979
		private Button mFrFhdQDownload;

		// Token: 0x040007BC RID: 1980
		private TextView mFrServerName;

		// Token: 0x040007BD RID: 1981
		private TextView mSfServerName;

		// Token: 0x040007BE RID: 1982
		private TextView mGdFhdServerName;

		// Token: 0x040007BF RID: 1983
		private TextView mFrFhdServerName;

		// Token: 0x040007C0 RID: 1984
		private ProgressBar mLoader;

		// Token: 0x040007C1 RID: 1985
		private ProgressBar mFrLoader;

		// Token: 0x040007C2 RID: 1986
		private ProgressBar mSfLoader;

		// Token: 0x040007C3 RID: 1987
		private ProgressBar mGdLoader;

		// Token: 0x040007C4 RID: 1988
		private ProgressBar mFrLowQLoader;

		// Token: 0x040007C5 RID: 1989
		private ProgressBar mGdFhdLoader;

		// Token: 0x040007C6 RID: 1990
		private ProgressBar mFrFhdQLoader;

		// Token: 0x040007C7 RID: 1991
		private ProgressBar mRateDeleteProgressBar;

		// Token: 0x040007C8 RID: 1992
		private RelativeLayout mOfflineView;

		// Token: 0x040007C9 RID: 1993
		private Button mOfflineRetry;

		// Token: 0x040007CA RID: 1994
		private EpisodeResponse mEpisodeResponse;

		// Token: 0x040007CB RID: 1995
		private WebClient mClient;

		// Token: 0x040007CC RID: 1996
		private Uri mUri;

		// Token: 0x040007CD RID: 1997
		private NameValueCollection parameters;

		// Token: 0x040007CE RID: 1998
		private Button mComments;

		// Token: 0x040007CF RID: 1999
		private bool isLoadingFinished;

		// Token: 0x040007D0 RID: 2000
		private IndicatorSeekBar mRateSeekerBar;

		// Token: 0x040007D1 RID: 2001
		private TextView mUsersRate;

		// Token: 0x040007D2 RID: 2002
		private TextView mRatedUsersCount;

		// Token: 0x040007D3 RID: 2003
		private AVLoadingIndicatorView mRateRefreshLoader;

		// Token: 0x040007D4 RID: 2004
		private IMenu localMenu;

		// Token: 0x040007D5 RID: 2005
		private float mEpisode;

		// Token: 0x040007D6 RID: 2006
		private string mAnimeId;

		// Token: 0x040007D7 RID: 2007
		private string mAnimeTitle;

		// Token: 0x040007D8 RID: 2008
		private string mAnimeType;

		// Token: 0x040007D9 RID: 2009
		private string mExtraEpisodes;

		// Token: 0x040007DA RID: 2010
		private string mEpisodeType;

		// Token: 0x040007DB RID: 2011
		private string mMarkedAs;

		// Token: 0x040007DC RID: 2012
		private string LbLink;

		// Token: 0x040007DD RID: 2013
		private string SvLink;

		// Token: 0x040007DE RID: 2014
		private string OkLink;

		// Token: 0x040007DF RID: 2015
		private string MaLink;

		// Token: 0x040007E0 RID: 2016
		private string GdLink;

		// Token: 0x040007E1 RID: 2017
		private string FrLink;

		// Token: 0x040007E2 RID: 2018
		private string SfLink;

		// Token: 0x040007E3 RID: 2019
		private string FDLink;

		// Token: 0x040007E4 RID: 2020
		private string LbLowQLink;

		// Token: 0x040007E5 RID: 2021
		private string SvLowQLink;

		// Token: 0x040007E6 RID: 2022
		private string FrLowQLink;

		// Token: 0x040007E7 RID: 2023
		private string LbFhdQLink;

		// Token: 0x040007E8 RID: 2024
		private string GdFhdQLink;

		// Token: 0x040007E9 RID: 2025
		private string FrFhdQLink;

		// Token: 0x040007EA RID: 2026
		private bool goNext;

		// Token: 0x040007EB RID: 2027
		private bool goPrevious;

		// Token: 0x0200017E RID: 382
		private class UnityAdsLoadListener : Java.Lang.Object, IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000C69 RID: 3177 RVA: 0x000447D5 File Offset: 0x000429D5
			public UnityAdsLoadListener(ServersListActivity context)
			{
				this.context = context;
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x000447E4 File Offset: 0x000429E4
			public void OnUnityAdsAdLoaded(string p0)
			{
				UnityAds.Show(this.context, "Interstitial_Android", new UnityAdsShowOptions(), new ServersListActivity.UnityAdsShowListener(this.context));
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2)
			{
			}

			// Token: 0x04003166 RID: 12646
			private ServersListActivity context;
		}

		// Token: 0x0200017F RID: 383
		private class UnityAdsShowListener : Java.Lang.Object, IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000C6C RID: 3180 RVA: 0x00044806 File Offset: 0x00042A06
			public UnityAdsShowListener(ServersListActivity context)
			{
				this.context = context;
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowClick(string p0)
			{
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1)
			{
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2)
			{
			}

			// Token: 0x06000C70 RID: 3184 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowStart(string p0)
			{
			}

			// Token: 0x04003167 RID: 12647
			private ServersListActivity context;
		}

		// Token: 0x02000180 RID: 384
		private class AdColonyListener : AdColonyInterstitialListener
		{
			// Token: 0x06000C71 RID: 3185 RVA: 0x00044815 File Offset: 0x00042A15
			public AdColonyListener(ServersListActivity context)
			{
				this.context = context;
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x00044824 File Offset: 0x00042A24
			public override void OnRequestNotFilled(AdColonyZone p0)
			{
				base.OnRequestNotFilled(p0);
			}

			// Token: 0x06000C73 RID: 3187 RVA: 0x0004482D File Offset: 0x00042A2D
			public override void OnClosed(AdColonyInterstitial p0)
			{
				base.OnClosed(p0);
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x00044836 File Offset: 0x00042A36
			public override void OnOpened(AdColonyInterstitial p0)
			{
				base.OnOpened(p0);
			}

			// Token: 0x06000C75 RID: 3189 RVA: 0x0004483F File Offset: 0x00042A3F
			public override void OnRequestFilled(AdColonyInterstitial p0)
			{
				p0.Show();
			}

			// Token: 0x04003168 RID: 12648
			private ServersListActivity context;
		}

		// Token: 0x02000181 RID: 385
		private class AppLovinAdLoadListener : Java.Lang.Object, IAppLovinAdLoadListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000C76 RID: 3190 RVA: 0x00044848 File Offset: 0x00042A48
			public AppLovinAdLoadListener(ServersListActivity context)
			{
				this.context = context;
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x00044858 File Offset: 0x00042A58
			public void AdReceived(IAppLovinAd p0)
			{
				IAppLovinInterstitialAdDialog appLovinInterstitialAdDialog = AppLovinInterstitialAd.Create(AppLovinSdk.GetInstance(this.context), this.context);
				appLovinInterstitialAdDialog.ShowAndRender(p0);
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x00004097 File Offset: 0x00002297
			public void FailedToReceiveAd(int p0)
			{
			}

			// Token: 0x04003169 RID: 12649
			private ServersListActivity context;
		}

		// Token: 0x02000182 RID: 386
		private class SeekChangeListener : Java.Lang.Object, IOnSeekChangeListener, IJavaObject, IDisposable
		{
			// Token: 0x06000C79 RID: 3193 RVA: 0x00044883 File Offset: 0x00042A83
			public SeekChangeListener(ServersListActivity context, AVLoadingIndicatorView refreshLoader)
			{
				this.context = context;
				this.refreshLoader = refreshLoader;
			}

			// Token: 0x06000C7A RID: 3194 RVA: 0x00044899 File Offset: 0x00042A99
			public void OnSeeking(SeekParams seekParams)
			{
				this.currentRate = seekParams.ThumbPosition + 1;
			}

			// Token: 0x06000C7B RID: 3195 RVA: 0x00004097 File Offset: 0x00002297
			public void OnStartTrackingTouch(IndicatorSeekBar seekBar)
			{
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x000448AC File Offset: 0x00042AAC
			public void OnStopTrackingTouch(IndicatorSeekBar seekBar)
			{
				if (this.context.userId == 0)
				{
					Bundle bundle = new Bundle();
					bundle.PutString("Message", this.context.Resources.GetString(2131951866));
					DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
					FragmentTransaction transaction = this.context.SupportFragmentManager.BeginTransaction();
					dialogSigninPrompt.Arguments = bundle;
					dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
					seekBar.SetProgress(0f);
					return;
				}
				this.refreshLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.context.SetRate(this.currentRate);
				});
			}

			// Token: 0x0400316A RID: 12650
			private ServersListActivity context;

			// Token: 0x0400316B RID: 12651
			private AVLoadingIndicatorView refreshLoader;

			// Token: 0x0400316C RID: 12652
			private int currentRate;
		}
	}
}
