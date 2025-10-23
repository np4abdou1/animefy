using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Util;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AndroidX.ViewPager2.Widget;
using AQ.Activities;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Firebase.Messaging;
using Google.Android.Material.Tabs;
using Java.Interop;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A4 RID: 164
	public class HomeFragment : AndroidX.Fragment.App.Fragment
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x00015673 File Offset: 0x00013873
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			base.HasOptionsMenu = true;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00017370 File Offset: 0x00015570
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558449, container, false);
			this.trendingViewPager2 = this.view.FindViewById<ViewPager2>(2131362489);
			this.latestsTabLayout = this.view.FindViewById<TabLayout>(2131362477);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.view.FindViewById<TextView>(2131362483).Text = LanguageConvertor.Premiered(this.view.Context, SharedPreferencesSaves.StringSharedPreferencesGet("CurrentSeason"));
			this.view.FindViewById<TextView>(2131362471).Text = base.Resources.GetString(2131951791) + " (" + LanguageConvertor.DayOfWeek(this.view.Context, DateTime.Now.DayOfWeek.ToString().ToUpper()) + ")";
			this.swipeRefresh = this.view.FindViewById<SwipeRefreshLayout>(2131362484);
			this.genresRecyclerView = this.view.FindViewById<RecyclerView>(2131362473);
			this.latestsRecyclerView = this.view.FindViewById<RecyclerView>(2131362475);
			this.broadcastRecyclerView = this.view.FindViewById<RecyclerView>(2131362469);
			this.premiereRecyclerView = this.view.FindViewById<RecyclerView>(2131362481);
			this.newsRecyclerView = this.view.FindViewById<RecyclerView>(2131362478);
			this.homeLoader = this.view.FindViewById<ProgressBar>(2131362835);
			this.homeContentParent = this.view.FindViewById<LinearLayout>(2131362472);
			this.latestsGridIcon = this.view.FindViewById<ImageView>(2131362474);
			this.broadcastGridIcon = this.view.FindViewById<ImageView>(2131362468);
			this.premiereGridIcon = this.view.FindViewById<ImageView>(2131362480);
			this.latestsSeeAll = this.view.FindViewById<TextView>(2131362476);
			this.broadcastSeeAll = this.view.FindViewById<TextView>(2131362470);
			this.premiereSeeAll = this.view.FindViewById<TextView>(2131362482);
			this.newsSeeAll = this.view.FindViewById<TextView>(2131362479);
			this.mOfflineView = this.view.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = this.view.FindViewById<Button>(2131362815);
			this.latestLinearLayoutManager = new LinearLayoutManager(this.view.Context, 0, false);
			this.broadcastLinearLayoutManager = new LinearLayoutManager(this.view.Context, 0, false);
			this.premiereLinearLayoutManager = new LinearLayoutManager(this.view.Context, 0, false);
			this.latestGridLayoutManager130 = new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 130f));
			this.latestGridLayoutManager400 = new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 400f));
			this.broadcastGridLayoutManager = new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 400f));
			this.premiereGridLayoutManager = new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 400f));
			this.newsGridLayoutManager = new GridLayoutManager(this.view.Context, 1);
			this.trendingRunnable = new HomeFragment.SliderRunnable(this);
			this.trendingHandler = new Handler(Looper.MainLooper);
			this.isLoading = true;
			this.SetupGenres();
			if (SharedPreferencesSaves.IntSharedPreferencesGet("HomeTrendingStatus") != 0)
			{
				this.trendingViewPager2.Visibility = ViewStates.Gone;
			}
			else
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadHomeTrending(false);
				});
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadHomeMain();
			});
			this.latestsGridIcon.Click += this.LatestsGridIcon_Click;
			this.broadcastGridIcon.Click += this.BroadcastGridIcon_Click;
			this.premiereGridIcon.Click += this.PremiereGridIcon_Click;
			this.latestsSeeAll.Click += this.LatestsSeeAll_Click;
			this.broadcastSeeAll.Click += this.BroadcastSeeAll_Click;
			this.premiereSeeAll.Click += this.PremiereSeeAll_Click;
			this.newsSeeAll.Click += this.NewsSeeAll_Click;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.swipeRefresh.Refresh += this.SwipeRefresh_Refresh;
			this.latestsTabLayout.TabSelected += this.LatestsTabLayout_TabSelected;
			return this.view;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001784A File Offset: 0x00015A4A
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.RefreshReload();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001784A File Offset: 0x00015A4A
		private void SwipeRefresh_Refresh(object sender, EventArgs e)
		{
			this.RefreshReload();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00017854 File Offset: 0x00015A54
		private void RefreshReload()
		{
			this.swipeRefresh.Refreshing = false;
			this.homeLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			if (this.isLoading)
			{
				return;
			}
			this.latestsTabLayout.GetTabAt(0).Select();
			this.homeLoader.Visibility = ViewStates.Visible;
			this.homeContentParent.Visibility = ViewStates.Gone;
			if (SharedPreferencesSaves.IntSharedPreferencesGet("HomeTrendingStatus") != 0)
			{
				this.trendingViewPager2.Visibility = ViewStates.Gone;
			}
			else
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadHomeTrending(true);
				});
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadHomeMain();
			});
			this.latestsGridIcon.Animate().Rotation(0f).SetDuration(800L).Start();
			this.broadcastGridIcon.Animate().Rotation(0f).SetDuration(800L).Start();
			this.premiereGridIcon.Animate().Rotation(0f).SetDuration(800L).Start();
			this.latestsLoadedVertically = false;
			this.broadcastLoadedVertically = false;
			this.premiereLoadedVertically = false;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001797C File Offset: 0x00015B7C
		private void SetupGenres()
		{
			string[] array = FixedCollections.Genres2(this.view.Context);
			this.ganresList = new List<SelectableListModel>();
			foreach (string title in array)
			{
				SelectableListModel selectableListModel = new SelectableListModel();
				selectableListModel.Selected = false;
				selectableListModel.Title = title;
				this.ganresList.Add(selectableListModel);
			}
			this.mainGenresAdapter = new HomeGenresAdapter(this.view.Context, this.ganresList);
			this.mainGenresAdapter.ItemClick += this.MainGenresAdapter_ItemClick;
			this.genresRecyclerView.SetLayoutManager(new LinearLayoutManager(this.view.Context, 0, false));
			this.genresRecyclerView.SetAdapter(this.mainGenresAdapter);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00017A40 File Offset: 0x00015C40
		private void MainGenresAdapter_ItemClick(object sender, int e)
		{
			View itemView = this.genresRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			TextView sharedElement = itemView.FindViewById<TextView>(2131363147);
			Intent intent = new Intent(Application.Context, typeof(FindMoreActivity));
			intent.PutExtra("FindMoreType", "GENRE");
			intent.PutExtra("FindMoreData", LanguageConvertor.GenresToENSingle(this.view.Context, this.ganresList[e].Title));
			intent.PutExtra("DataTitle", this.ganresList[e].Title);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, sharedElement, "textviewdatabutton");
				this.StartActivity(intent, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivity(intent);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00017B0C File Offset: 0x00015D0C
		private void LatestsTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			switch (e.Tab.Position)
			{
			case 0:
				this.latestsTabLayout.GetTabAt(0).RemoveBadge();
				if (this.mainActivity.mainModel != null)
				{
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewEpisodesCountHome", this.mainActivity.mainModel.UpdatesChart.new_episodes_count);
				}
				if (this.latestsLoadedVertically)
				{
					this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager400);
					if (this.latestEpisodesListAdapter == null)
					{
						this.latestEpisodesListAdapter = new LatestEpisodesListAdapter(this.view.Context, this.homeMain.LatestEpisodes);
						this.latestEpisodesListAdapter.ItemClick += this.LatestEpisodesStaticAdapter_ItemClick;
						this.latestEpisodesListAdapter.HomeClick += this.LatestEpisodesListAdapter_HomeClick;
						this.latestEpisodesListAdapter.CommentsClick += this.LatestEpisodesListAdapter_CommentsClick;
						this.latestEpisodesListAdapter.NotificationClick += this.LatestEpisodesListAdapter_NotificationClick;
					}
					this.latestsRecyclerView.SetAdapter(this.latestEpisodesListAdapter);
					return;
				}
				this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
				this.latestsRecyclerView.SetAdapter(this.latestEpisodesStaticGridAdapter);
				return;
			case 1:
				this.latestsTabLayout.GetTabAt(1).RemoveBadge();
				if (this.mainActivity.mainModel != null)
				{
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewAnimeCountHome", this.mainActivity.mainModel.UpdatesChart.new_anime_count);
				}
				if (this.homeMain.LatestAnime == null || this.homeMain.LatestAnime.Count == 0)
				{
					this.isLoading = true;
					this.LoadLatests("ANIME");
					return;
				}
				if (this.latestsLoadedVertically)
				{
					this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager400);
					if (this.latestAnimeListAdapter == null)
					{
						this.latestAnimeListAdapter = new AnimeCatalogListAdapter(this.view.Context, this.homeMain.LatestAnime, false);
						this.latestAnimeListAdapter.ItemClick += this.LatestAnimeStaticAdapter_ItemClick;
						this.latestAnimeListAdapter.ItemPlotClick += this.LatestAnimeStaticAdapter_ItemLongClick;
					}
					this.latestsRecyclerView.SetAdapter(this.latestAnimeListAdapter);
					return;
				}
				this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
				this.latestsRecyclerView.SetAdapter(this.latestAnimeStaticAdapter);
				return;
			case 2:
				this.latestsTabLayout.GetTabAt(2).RemoveBadge();
				if (this.mainActivity.mainModel != null)
				{
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewCharsCountHome", this.mainActivity.mainModel.UpdatesChart.new_characters_count);
				}
				if (this.homeMain.LatestCharacters == null || this.homeMain.LatestCharacters.Count == 0)
				{
					this.isLoading = true;
					this.LoadLatests("CHARACTER");
					return;
				}
				if (this.latestsLoadedVertically)
				{
					this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager130);
					if (this.latestCharactersDynamicAdapter == null)
					{
						this.latestCharactersDynamicAdapter = new CharactersListAdapter(this.view.Context, this.homeMain.LatestCharacters);
						this.latestCharactersDynamicAdapter.ItemClick += this.LatestCharactersStaticAdapter_ItemClick;
					}
					this.latestsRecyclerView.SetAdapter(this.latestCharactersDynamicAdapter);
					return;
				}
				this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
				this.latestsRecyclerView.SetAdapter(this.latestCharactersStaticAdapter);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00017E65 File Offset: 0x00016065
		private void NewsSeeAll_Click(object sender, EventArgs e)
		{
			base.Activity.FindViewById<TabLayout>(2131363116).GetTabAt(2).Select();
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00017E82 File Offset: 0x00016082
		private void PremiereSeeAll_Click(object sender, EventArgs e)
		{
			base.Activity.FindViewById<TabLayout>(2131363116).GetTabAt(3).Select();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00017E82 File Offset: 0x00016082
		private void BroadcastSeeAll_Click(object sender, EventArgs e)
		{
			base.Activity.FindViewById<TabLayout>(2131363116).GetTabAt(3).Select();
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00017EA0 File Offset: 0x000160A0
		private void LatestsSeeAll_Click(object sender, EventArgs e)
		{
			if (this.latestsTabLayout.GetTabAt(0).IsSelected)
			{
				base.Activity.StartActivity(typeof(LatestEpisodesActivity));
				return;
			}
			if (this.latestsTabLayout.GetTabAt(1).IsSelected)
			{
				base.Activity.StartActivity(typeof(LatestAnimeActivity));
				return;
			}
			if (this.latestsTabLayout.GetTabAt(2).IsSelected)
			{
				base.Activity.StartActivity(typeof(CharactersActivity));
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00017F28 File Offset: 0x00016128
		private void PremiereGridIcon_Click(object sender, EventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			if (this.premiereLoadedVertically)
			{
				this.premiereRecyclerView.SetLayoutManager(this.premiereLinearLayoutManager);
				this.premiereRecyclerView.SetAdapter(this.premiereStaticAdapter);
				this.premiereGridIcon.Animate().Rotation(0f).SetDuration(800L).Start();
				this.premiereLoadedVertically = false;
				return;
			}
			this.premiereRecyclerView.SetLayoutManager(this.premiereGridLayoutManager);
			if (this.premiereListAdapter == null)
			{
				this.premiereListAdapter = new AnimeCatalogListAdapter(this.view.Context, this.homeMain.Premiere, false);
				this.premiereListAdapter.ItemClick += this.PremiereStaticAdapter_ItemClick;
				this.premiereListAdapter.ItemPlotClick += this.PremiereStaticAdapter_ItemLongClick;
			}
			this.premiereRecyclerView.SetAdapter(this.premiereListAdapter);
			this.premiereGridIcon.Animate().Rotation((float)HomeFragment.GRID_ICON_ROTATION_ANGLE).SetDuration(800L).Start();
			this.premiereLoadedVertically = true;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001803C File Offset: 0x0001623C
		private void BroadcastGridIcon_Click(object sender, EventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			if (this.broadcastLoadedVertically)
			{
				this.broadcastRecyclerView.SetLayoutManager(this.broadcastLinearLayoutManager);
				this.broadcastRecyclerView.SetAdapter(this.broadcastStaticAdapter);
				this.broadcastGridIcon.Animate().Rotation(0f).SetDuration(800L).Start();
				this.broadcastLoadedVertically = false;
				return;
			}
			this.broadcastRecyclerView.SetLayoutManager(this.broadcastGridLayoutManager);
			if (this.broadcastListAdapter == null)
			{
				this.broadcastListAdapter = new AnimeCatalogListAdapter(this.view.Context, this.homeMain.Broadcast, false);
				this.broadcastListAdapter.ItemClick += this.BroadcastStaticAdapter_ItemClick;
				this.broadcastListAdapter.ItemPlotClick += this.BroadcastStaticAdapter_ItemLongClick;
			}
			this.broadcastRecyclerView.SetAdapter(this.broadcastListAdapter);
			this.broadcastGridIcon.Animate().Rotation((float)HomeFragment.GRID_ICON_ROTATION_ANGLE).SetDuration(800L).Start();
			this.broadcastLoadedVertically = true;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00018150 File Offset: 0x00016350
		private void LatestsGridIcon_Click(object sender, EventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			if (this.latestsLoadedVertically)
			{
				this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
				if (this.latestsTabLayout.GetTabAt(0).IsSelected)
				{
					this.latestsRecyclerView.SetAdapter(this.latestEpisodesStaticGridAdapter);
				}
				else if (this.latestsTabLayout.GetTabAt(1).IsSelected)
				{
					this.latestsRecyclerView.SetAdapter(this.latestAnimeStaticAdapter);
				}
				else if (this.latestsTabLayout.GetTabAt(2).IsSelected)
				{
					this.latestsRecyclerView.SetAdapter(this.latestCharactersStaticAdapter);
				}
				this.latestsGridIcon.Animate().Rotation(0f).SetDuration(800L).Start();
				this.latestsLoadedVertically = false;
				return;
			}
			if (this.latestsTabLayout.GetTabAt(0).IsSelected)
			{
				this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager400);
				if (this.latestEpisodesListAdapter == null)
				{
					this.latestEpisodesListAdapter = new LatestEpisodesListAdapter(this.view.Context, this.homeMain.LatestEpisodes);
					this.latestEpisodesListAdapter.ItemClick += this.LatestEpisodesStaticAdapter_ItemClick;
					this.latestEpisodesListAdapter.HomeClick += this.LatestEpisodesListAdapter_HomeClick;
					this.latestEpisodesListAdapter.CommentsClick += this.LatestEpisodesListAdapter_CommentsClick;
					this.latestEpisodesListAdapter.NotificationClick += this.LatestEpisodesListAdapter_NotificationClick;
				}
				this.latestsRecyclerView.SetAdapter(this.latestEpisodesListAdapter);
			}
			else if (this.latestsTabLayout.GetTabAt(1).IsSelected)
			{
				this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager400);
				if (this.latestAnimeListAdapter == null)
				{
					this.latestAnimeListAdapter = new AnimeCatalogListAdapter(this.view.Context, this.homeMain.LatestAnime, false);
					this.latestAnimeListAdapter.ItemClick += this.LatestAnimeStaticAdapter_ItemClick;
					this.latestAnimeListAdapter.ItemPlotClick += this.LatestAnimeStaticAdapter_ItemLongClick;
				}
				this.latestsRecyclerView.SetAdapter(this.latestAnimeListAdapter);
			}
			else if (this.latestsTabLayout.GetTabAt(2).IsSelected)
			{
				this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager130);
				if (this.latestCharactersDynamicAdapter == null)
				{
					this.latestCharactersDynamicAdapter = new CharactersListAdapter(this.view.Context, this.homeMain.LatestCharacters);
					this.latestCharactersDynamicAdapter.ItemClick += this.LatestCharactersStaticAdapter_ItemClick;
				}
				this.latestsRecyclerView.SetAdapter(this.latestCharactersDynamicAdapter);
			}
			this.latestsGridIcon.Animate().Rotation((float)HomeFragment.GRID_ICON_ROTATION_ANGLE).SetDuration(800L).Start();
			this.latestsLoadedVertically = true;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00018414 File Offset: 0x00016614
		private void LoadHomeTrending(bool refresh = false)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("home/load_trending.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Language",
					base.Resources.GetString(2131951706)
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			Action <>9__1;
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.trending = JsonConvert.DeserializeObject<List<HomeTrendingModel>>(@string);
					Activity activity = this.Activity;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							if (this.trending != null)
							{
								this.isTrendingLoaded = true;
								HomeTrendingAdapter homeTrendingAdapter = new HomeTrendingAdapter(this.view.Context, this.trendingViewPager2, this.trending);
								this.trendingViewPager2.Adapter = homeTrendingAdapter;
								homeTrendingAdapter.ItemClick += this.ViewPagerAdapter_ItemClick;
								if (!refresh)
								{
									this.trendingViewPager2.SetClipToPadding(false);
									this.trendingViewPager2.SetClipChildren(false);
									this.trendingViewPager2.OffscreenPageLimit = 3;
									this.trendingViewPager2.GetChildAt(0).OverScrollMode = OverScrollMode.Never;
									this.trendingViewPager2.SetPageTransformer(new HomeFragment.VPPageTransfer(this.view.Context));
									this.trendingViewPager2.AddItemDecoration(new HomeFragment.HorizontalMarginItemDecoration(this.view.Context));
									this.trendingViewPager2.RegisterOnPageChangeCallback(new HomeFragment.OnPageChangeCallback(this));
								}
							}
						});
					}
					activity.RunOnUiThread(action);
				}
				catch
				{
					this.isTrendingLoaded = false;
				}
			};
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000184AC File Offset: 0x000166AC
		private void ViewPagerAdapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			HomeTrendingModel homeTrendingModel = this.trending[e];
			string type = homeTrendingModel.Type;
			if (type == "ANIME")
			{
				this.HandleTrendingAnimeNavigation(homeTrendingModel.Anime, e);
				return;
			}
			if (type == "EPISODE")
			{
				this.HandleTrendingEpisodeNavigation(homeTrendingModel.Episode, homeTrendingModel.Anime);
				return;
			}
			if (type == "CHARACTER")
			{
				this.HandleTrendingCharactersNavigation(homeTrendingModel.Character, e);
				return;
			}
			if (type == "NEWS")
			{
				this.HandleTrendingNewsNavigation(homeTrendingModel.News);
				return;
			}
			if (!(type == "OTHERS"))
			{
				return;
			}
			if (homeTrendingModel.Data != "")
			{
				this.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse(homeTrendingModel.Data)));
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001859C File Offset: 0x0001679C
		private void HandleTrendingNewsNavigation(NewsModel news)
		{
			Intent intent = new Intent(Application.Context, typeof(NewContentActivity));
			intent.PutExtra("NewId", news.ID);
			intent.PutExtra("NewTitle", news.Title);
			intent.PutExtra("RelatedAnimeId", news.RelationId);
			this.StartActivity(intent);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000185FC File Offset: 0x000167FC
		private void HandleTrendingEpisodeNavigation(EpisodeModel episode, AnimeModel anime)
		{
			Intent intent = new Intent(this.view.Context, typeof(ServersListActivity));
			intent.PutExtra("AnimeId", anime.AnimeId);
			intent.PutExtra("AnimeTitle", anime.EN_Title);
			intent.PutExtra("AnimeType", anime.Type);
			intent.PutExtra("Episode", episode.Episode);
			intent.PutExtra("ExtraEpisodes", episode.ExtraEpisodes);
			intent.PutExtra("EpisodeType", episode.Type);
			intent.PutExtra("MarkedAs", episode.MarkedAs);
			this.StartActivity(intent);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") != "OFF")
			{
				WatchHistoryViewModel.AddLocaleHistory(episode.AnimeID, episode.Episode);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000186D0 File Offset: 0x000168D0
		private void HandleTrendingAnimeNavigation(AnimeModel anime, int itemPosition)
		{
			Intent intent = new Intent(Application.Context, typeof(AnimeDetails));
			intent.PutExtra("AnimeId", anime.AnimeId);
			intent.PutExtra("ENTitle", anime.EN_Title);
			intent.PutExtra("JPTitle", anime.JP_Title);
			intent.PutExtra("ARTitle", anime.AR_Title);
			intent.PutExtra("Synonyms", anime.Synonyms);
			intent.PutExtra("Tags", anime.Tags);
			intent.PutExtra("Genres", anime.Genres);
			intent.PutExtra("Season", anime.Season);
			intent.PutExtra("Duration", anime.Duration);
			intent.PutExtra("Premiered", anime.Premiered);
			intent.PutExtra("Aired", anime.Aired);
			intent.PutExtra("Broadcast", anime.Broadcast);
			intent.PutExtra("Thumbnail", Constants.Thumbnails(anime.Thumbnail));
			intent.PutExtra("Trailer", anime.Trailer);
			intent.PutExtra("YTTrailer", anime.YTTrailer);
			intent.PutExtra("Creators", anime.Creators);
			intent.PutExtra("Status", anime.Status);
			intent.PutExtra("Episodes", anime.Episodes);
			intent.PutExtra("Score", anime.Score);
			intent.PutExtra("Rank", anime.Rank);
			intent.PutExtra("Popularity", anime.Popularity);
			intent.PutExtra("Rating", anime.Rating);
			intent.PutExtra("RelationId", anime.RelationId);
			intent.PutExtra("MalId", anime.MalId);
			intent.PutExtra("Type", anime.Type);
			intent.PutExtra("ItemPosition", itemPosition);
			intent.PutExtra("Transition", this.isLoading);
			this.StartActivityForResult(intent, 0);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000188E0 File Offset: 0x00016AE0
		private void HandleTrendingCharactersNavigation(CharacterModel character, int itemPosition)
		{
			Intent intent = new Intent(Application.Context, typeof(CharacterDetailsActivity));
			intent.PutExtra("CharId", character.CharId);
			intent.PutExtra("CharEnName", character.NameEN);
			intent.PutExtra("CharArName", character.NameAR);
			intent.PutExtra("CharJpName", character.NameJP);
			intent.PutExtra("CharAka", character.Aka);
			intent.PutExtra("RelationId", character.RelationId);
			intent.PutExtra("Gender", character.Gender);
			intent.PutExtra("ExtraPhotosCount", character.ExtraPhotosCount);
			intent.PutExtra("Age", character.Age);
			intent.PutExtra("Height", character.Height);
			intent.PutExtra("Weight", character.Weight);
			intent.PutExtra("BloodType", character.BloodType);
			intent.PutExtra("IsLoved", character.Love);
			intent.PutExtra("CharPhoto", Constants.CharPhoto(character.Photo));
			intent.PutExtra("LikersCount", character.LikersCount);
			intent.PutExtra("DislikersCount", character.DislikersCount);
			intent.PutExtra("ItemPosition", itemPosition);
			this.StartActivityForResult(intent, 0);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00018A3C File Offset: 0x00016C3C
		private void LoadHomeMain()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("home/load_home.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Language",
					base.Resources.GetString(2131951706)
				},
				{
					"Broadcast",
					DateTime.Now.DayOfWeek.ToString().ToUpper()
				},
				{
					"Premiered",
					SharedPreferencesSaves.StringSharedPreferencesGet("CurrentSeason")
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
					this.homeMain = JsonConvert.DeserializeObject<HomeModel>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (this.homeMain != null)
						{
							this.latestEpisodesStaticGridAdapter = new LatestEpisodesStaticGridAdapter(this.view.Context, this.homeMain.LatestEpisodes, base.Resources.GetDimensionPixelSize(2131165282));
							this.latestEpisodesStaticGridAdapter.ItemClick += this.LatestEpisodesStaticAdapter_ItemClick;
							this.latestEpisodesStaticGridAdapter.ItemLongClick += this.LatestEpisodesStaticAdapter_ItemLongClick;
							this.latestEpisodesStaticGridAdapter.ItemTitleClick += this.LatestEpisodesStaticGridAdapter_ItemTitleClick;
							this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
							this.latestsRecyclerView.SetAdapter(this.latestEpisodesStaticGridAdapter);
							this.broadcastStaticAdapter = new AnimeCatalogGridAdapter(this.view.Context, this.homeMain.Broadcast, base.Resources.GetDimensionPixelSize(2131165282));
							this.broadcastStaticAdapter.ItemClick += this.BroadcastStaticAdapter_ItemClick;
							this.broadcastStaticAdapter.ItemLongClick += this.BroadcastStaticAdapter_ItemLongClick;
							this.broadcastRecyclerView.SetLayoutManager(this.broadcastLinearLayoutManager);
							this.broadcastRecyclerView.SetAdapter(this.broadcastStaticAdapter);
							this.premiereStaticAdapter = new AnimeCatalogGridAdapter(this.view.Context, this.homeMain.Premiere, base.Resources.GetDimensionPixelSize(2131165282));
							this.premiereStaticAdapter.ItemClick += this.PremiereStaticAdapter_ItemClick;
							this.premiereStaticAdapter.ItemLongClick += this.PremiereStaticAdapter_ItemLongClick;
							this.premiereRecyclerView.SetLayoutManager(this.premiereLinearLayoutManager);
							this.premiereRecyclerView.SetAdapter(this.premiereStaticAdapter);
							this.newAdapter = new HomeNewsListAdapter(this.view.Context, this.homeMain.LatestNews);
							this.newAdapter.ItemClick += this.NewAdapter_ItemClick;
							this.newAdapter.ItemEditorPhotoClick += this.NewAdapter_ItemEditorPhotoClick;
							this.newAdapter.ItemCommentsClick += this.NewAdapter_ItemCommentsClick;
							this.newAdapter.ItemRelatedClick += this.NewAdapter_ItemRelatedClick;
							this.newAdapter.ItemShareClick += this.NewAdapter_ItemShareClick;
							this.newsRecyclerView.SetLayoutManager(this.newsGridLayoutManager);
							this.newsRecyclerView.SetAdapter(this.newAdapter);
							this.homeLoader.Visibility = ViewStates.Gone;
							this.homeContentParent.Visibility = ViewStates.Visible;
						}
						this.isLoading = false;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.isLoading = false;
						this.homeLoader.Visibility = ViewStates.Gone;
						this.mOfflineView.Visibility = ViewStates.Visible;
					});
				}
			};
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00018B04 File Offset: 0x00016D04
		private void NewAdapter_ItemShareClick(object sender, int e)
		{
			Intent intent = new Intent("android.intent.action.SEND");
			intent.PutExtra("android.intent.extra.TITLE", base.Resources.GetString(2131952114));
			intent.PutExtra("android.intent.extra.SUBJECT", base.Resources.GetString(2131952114) + " " + base.Resources.GetString(2131951707));
			intent.PutExtra("android.intent.extra.TEXT", string.Concat(new string[]
			{
				base.Resources.GetString(2131952114),
				": ",
				this.homeMain.LatestNews[e].Title,
				" ",
				SharedPreferencesSaves.StringSharedPreferencesGet("WebsiteUrl")
			}));
			intent.SetType("text/plain");
			this.StartActivity(Intent.CreateChooser(intent, base.Resources.GetString(2131952394)));
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00018BF8 File Offset: 0x00016DF8
		private void NewAdapter_ItemRelatedClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			if (this.homeMain.LatestNews[e].RelationId == "")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952224), 0);
				return;
			}
			Bundle bundle = new Bundle();
			bundle.PutString("RelatedId", this.homeMain.LatestNews[e].RelationId);
			RelatedAnimeSheet relatedAnimeSheet = new RelatedAnimeSheet();
			FragmentTransaction transaction = base.FragmentManager.BeginTransaction();
			relatedAnimeSheet.Arguments = bundle;
			relatedAnimeSheet.Show(transaction, "RelatedAnimeSheet");
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00018CB4 File Offset: 0x00016EB4
		private void NewAdapter_ItemCommentsClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.homeMain.LatestNews[e].ID.ToString());
			bundle.PutString("CommType", NewsModel.News);
			Comments comments = new Comments();
			FragmentTransaction transaction = base.FragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00018D44 File Offset: 0x00016F44
		private void NewAdapter_ItemEditorPhotoClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			NewsModel newsModel = this.homeMain.LatestNews[e];
			Bundle bundle = new Bundle();
			bundle.PutString("UserId", newsModel.Editor.UserID.ToString());
			bundle.PutString("DisplayName", newsModel.Editor.FullName);
			bundle.PutString("Bio", newsModel.Editor.Bio);
			bundle.PutString("Gender", newsModel.Editor.Gender);
			bundle.PutString("Membership", newsModel.Editor.Membership);
			bundle.PutString("ProfilePhoto", newsModel.Editor.ProfileImage);
			bundle.PutString("GglPforilePhoto", newsModel.Editor.GoogleProfilePhotoUrl);
			bundle.PutString("ProfileCover", newsModel.Editor.ProfileCover);
			bundle.PutInt("LibraryViewAllowed", newsModel.Editor.AllowLibraryView);
			DialogUserProfile dialogUserProfile = new DialogUserProfile();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogUserProfile.Arguments = bundle;
			dialogUserProfile.Show(transaction, "DialogUserProfile");
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00018E7D File Offset: 0x0001707D
		private void PremiereStaticAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.homeMain.Premiere[e]);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00018E96 File Offset: 0x00017096
		private void PremiereStaticAdapter_ItemClick(object sender, int e)
		{
			this.GoAnimeDetails(this.homeMain.Premiere[e], this.premiereRecyclerView, e, 5);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00018EB7 File Offset: 0x000170B7
		private void BroadcastStaticAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.homeMain.Broadcast[e]);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00018ED0 File Offset: 0x000170D0
		private void BroadcastStaticAdapter_ItemClick(object sender, int e)
		{
			this.GoAnimeDetails(this.homeMain.Broadcast[e], this.broadcastRecyclerView, e, 4);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00018EF1 File Offset: 0x000170F1
		private void LatestEpisodesStaticAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.homeMain.LatestEpisodes[e].Anime);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00018F0F File Offset: 0x0001710F
		private void LatestEpisodesStaticGridAdapter_ItemTitleClick(object sender, int e)
		{
			this.GoAnimeDetails(this.homeMain.LatestEpisodes[e].Anime, this.latestsRecyclerView, e, 1);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00018F38 File Offset: 0x00017138
		private void LatestEpisodesListAdapter_NotificationClick(object sender, int e)
		{
			AnimeModelWithOtherData animeModelWithOtherData = this.homeMain.LatestEpisodes[e];
			View itemView = this.latestsRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362532);
			if (animeModelWithOtherData.Anime.Status == "AIRED")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951693), 0);
				return;
			}
			if (NotificationsViewModel.IsNotifExist(animeModelWithOtherData.Anime.AnimeId))
			{
				imageView.SetImageResource(2131231140);
				FirebaseMessaging.Instance.UnsubscribeFromTopic(animeModelWithOtherData.Anime.AnimeId);
				NotificationsViewModel.DelNotif(animeModelWithOtherData.Anime.AnimeId);
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951927) + " " + animeModelWithOtherData.Anime.EN_Title, 2131231141);
				return;
			}
			imageView.SetImageResource(2131231142);
			FirebaseMessaging.Instance.SubscribeToTopic(animeModelWithOtherData.Anime.AnimeId);
			NotificationsViewModel.InitializeNewNotif(animeModelWithOtherData.Anime.AnimeId, animeModelWithOtherData.Anime.EN_Title, animeModelWithOtherData.Anime.Episodes);
			CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951928) + " " + animeModelWithOtherData.Anime.EN_Title, 2131231141);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000190B0 File Offset: 0x000172B0
		private void LatestEpisodesListAdapter_CommentsClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			AnimeModelWithOtherData animeModelWithOtherData = this.homeMain.LatestEpisodes[e];
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", animeModelWithOtherData.Anime.AnimeId);
			bundle.PutString("CommType", "Episode");
			bundle.PutFloat("Episode", animeModelWithOtherData.Episode.Episode);
			Comments comments = new Comments();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00018F0F File Offset: 0x0001710F
		private void LatestEpisodesListAdapter_HomeClick(object sender, int e)
		{
			this.GoAnimeDetails(this.homeMain.LatestEpisodes[e].Anime, this.latestsRecyclerView, e, 1);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00019156 File Offset: 0x00017356
		private void LatestEpisodesStaticAdapter_ItemClick(object sender, int e)
		{
			this.GoEpisodeServers(this.homeMain.LatestEpisodes[e].Episode, this.homeMain.LatestEpisodes[e].Anime);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001918C File Offset: 0x0001738C
		private void NewAdapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			NewsModel newsModel = this.homeMain.LatestNews[e];
			View itemView = this.newsRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView sharedElement = itemView.FindViewById<ImageView>(2131362780);
			Intent intent = new Intent(Application.Context, typeof(NewContentActivity));
			intent.PutExtra("NewId", newsModel.ID);
			intent.PutExtra("NewTitle", newsModel.Title);
			intent.PutExtra("RelatedAnimeId", newsModel.RelationId);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, sharedElement, "newthumbnail");
				this.StartActivity(intent, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivity(intent);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001926C File Offset: 0x0001746C
		private void LoadLatests(string latest)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("home/load_home_latest.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Language",
					base.Resources.GetString(2131951706)
				},
				{
					"Latest",
					latest
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			Action <>9__1;
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					if (latest == "ANIME")
					{
						this.homeMain.LatestAnime = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					}
					else if (latest == "CHARACTER")
					{
						this.homeMain.LatestCharacters = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					}
					Activity activity = this.Activity;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							if (latest == "ANIME")
							{
								this.latestAnimeStaticAdapter = new AnimeCatalogGridAdapter(this.view.Context, this.homeMain.LatestAnime, this.Resources.GetDimensionPixelSize(2131165282));
								this.latestAnimeStaticAdapter.ItemClick += this.LatestAnimeStaticAdapter_ItemClick;
								this.latestAnimeStaticAdapter.ItemLongClick += this.LatestAnimeStaticAdapter_ItemLongClick;
								if (this.latestsLoadedVertically)
								{
									this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager400);
									if (this.latestAnimeListAdapter == null)
									{
										this.latestAnimeListAdapter = new AnimeCatalogListAdapter(this.view.Context, this.homeMain.LatestAnime, false);
										this.latestAnimeListAdapter.ItemClick += this.LatestAnimeStaticAdapter_ItemClick;
										this.latestAnimeListAdapter.ItemPlotClick += this.LatestAnimeStaticAdapter_ItemLongClick;
									}
									this.latestsRecyclerView.SetAdapter(this.latestAnimeListAdapter);
								}
								else
								{
									this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
									this.latestsRecyclerView.SetAdapter(this.latestAnimeStaticAdapter);
								}
							}
							else if (latest == "CHARACTER")
							{
								this.latestCharactersStaticAdapter = new LatestCharactersListAdapter(this.view.Context, this.homeMain.LatestCharacters);
								this.latestCharactersStaticAdapter.ItemClick += this.LatestCharactersStaticAdapter_ItemClick;
								if (this.latestsLoadedVertically)
								{
									this.latestsRecyclerView.SetLayoutManager(this.latestGridLayoutManager130);
									if (this.latestCharactersDynamicAdapter == null)
									{
										this.latestCharactersDynamicAdapter = new CharactersListAdapter(this.view.Context, this.homeMain.LatestCharacters);
										this.latestCharactersDynamicAdapter.ItemClick += this.LatestCharactersStaticAdapter_ItemClick;
									}
									this.latestsRecyclerView.SetAdapter(this.latestCharactersDynamicAdapter);
								}
								else
								{
									this.latestsRecyclerView.SetLayoutManager(this.latestLinearLayoutManager);
									this.latestsRecyclerView.SetAdapter(this.latestCharactersStaticAdapter);
								}
							}
							this.isLoading = false;
						});
					}
					activity.RunOnUiThread(action);
				}
				catch
				{
				}
			};
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00019315 File Offset: 0x00017515
		private void LatestCharactersStaticAdapter_ItemClick(object sender, int e)
		{
			this.GoCharacterDetails(this.homeMain.LatestCharacters[e], this.latestsRecyclerView, e);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00019335 File Offset: 0x00017535
		private void LatestAnimeStaticAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.homeMain.LatestAnime[e]);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001934E File Offset: 0x0001754E
		private void LatestAnimeStaticAdapter_ItemClick(object sender, int e)
		{
			this.GoAnimeDetails(this.homeMain.LatestAnime[e], this.latestsRecyclerView, e, 2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00019370 File Offset: 0x00017570
		private void GoAnimeDetails(AnimeModel anime, RecyclerView recyclerView, int itemPosition, int resultCode)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			View itemView = recyclerView.FindViewHolderForAdapterPosition(itemPosition).ItemView;
			ImageView sharedElement = itemView.FindViewById<ImageView>(2131361956);
			Intent intent = new Intent(Application.Context, typeof(AnimeDetails));
			intent.PutExtra("AnimeId", anime.AnimeId);
			intent.PutExtra("ENTitle", anime.EN_Title);
			intent.PutExtra("JPTitle", anime.JP_Title);
			intent.PutExtra("ARTitle", anime.AR_Title);
			intent.PutExtra("Synonyms", anime.Synonyms);
			intent.PutExtra("Tags", anime.Tags);
			intent.PutExtra("Genres", anime.Genres);
			intent.PutExtra("Season", anime.Season);
			intent.PutExtra("Duration", anime.Duration);
			intent.PutExtra("Premiered", anime.Premiered);
			intent.PutExtra("Aired", anime.Aired);
			intent.PutExtra("Broadcast", anime.Broadcast);
			intent.PutExtra("Thumbnail", Constants.Thumbnails(anime.Thumbnail));
			intent.PutExtra("Trailer", anime.Trailer);
			intent.PutExtra("YTTrailer", anime.YTTrailer);
			intent.PutExtra("Creators", anime.Creators);
			intent.PutExtra("Status", anime.Status);
			intent.PutExtra("Episodes", anime.Episodes);
			intent.PutExtra("Score", anime.Score);
			intent.PutExtra("Rank", anime.Rank);
			intent.PutExtra("Popularity", anime.Popularity);
			intent.PutExtra("Rating", anime.Rating);
			intent.PutExtra("RelationId", anime.RelationId);
			intent.PutExtra("MalId", anime.MalId);
			intent.PutExtra("Type", anime.Type);
			intent.PutExtra("ItemPosition", itemPosition);
			intent.PutExtra("Transition", this.isLoading);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, resultCode, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, resultCode);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000195E4 File Offset: 0x000177E4
		private void GoAnimeGlance(AnimeModel anime)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Title", anime.EN_Title);
			bundle.PutString("AnimeId", anime.AnimeId);
			bundle.PutString("AnimeType", anime.Type);
			bundle.PutString("Genres", anime.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "DialogDescription");
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00019664 File Offset: 0x00017864
		private void GoCharacterDetails(CharacterModel character, RecyclerView recyclerView, int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			if (character.Enabled == 0)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952247), 0);
				return;
			}
			View itemView = recyclerView.FindViewHolderForAdapterPosition(itemPosition).ItemView;
			ImageView a = itemView.FindViewById<ImageView>(2131362127);
			TextView a2 = itemView.FindViewById<TextView>(2131362125);
			Intent intent = new Intent(Application.Context, typeof(CharacterDetailsActivity));
			intent.PutExtra("CharId", character.CharId);
			intent.PutExtra("CharEnName", character.NameEN);
			intent.PutExtra("CharArName", character.NameAR);
			intent.PutExtra("CharJpName", character.NameJP);
			intent.PutExtra("CharAka", character.Aka);
			intent.PutExtra("RelationId", character.RelationId);
			intent.PutExtra("Gender", character.Gender);
			intent.PutExtra("ExtraPhotosCount", character.ExtraPhotosCount);
			intent.PutExtra("Age", character.Age);
			intent.PutExtra("Height", character.Height);
			intent.PutExtra("Weight", character.Weight);
			intent.PutExtra("BloodType", character.BloodType);
			intent.PutExtra("IsLoved", character.Love);
			intent.PutExtra("CharPhoto", Constants.CharPhoto(character.Photo));
			intent.PutExtra("LikersCount", character.LikersCount);
			intent.PutExtra("DislikersCount", character.DislikersCount);
			intent.PutExtra("ItemPosition", itemPosition);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Pair pair = Pair.Create(a, "charthumbnail");
				Pair pair2 = Pair.Create(a2, "name");
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, new Pair[]
				{
					pair,
					pair2
				});
				this.StartActivityForResult(intent, 3, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 3);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001989C File Offset: 0x00017A9C
		private void GoEpisodeServers(EpisodeModel episode, AnimeModel anime)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < HomeFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.lastClickTime = num;
			Intent intent = new Intent(this.view.Context, typeof(ServersListActivity));
			intent.PutExtra("AnimeId", anime.AnimeId);
			intent.PutExtra("AnimeTitle", anime.EN_Title);
			intent.PutExtra("AnimeType", anime.Type);
			intent.PutExtra("Episode", episode.Episode);
			intent.PutExtra("ExtraEpisodes", episode.ExtraEpisodes);
			intent.PutExtra("EpisodeType", episode.Type);
			intent.PutExtra("MarkedAs", episode.MarkedAs);
			this.StartActivity(intent);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") != "OFF")
			{
				WatchHistoryViewModel.AddLocaleHistory(episode.AnimeID, episode.Episode);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001998D File Offset: 0x00017B8D
		private void SliderIntervalerRepeat()
		{
			if (this.isTrendingLoaded)
			{
				this.trendingHandler.PostDelayed(this.trendingRunnable, HomeFragment.SLIDE_INTERVAL);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000199AE File Offset: 0x00017BAE
		private void SliderIntervalerStop()
		{
			this.trendingHandler.RemoveCallbacks(this.trendingRunnable);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000166D9 File Offset: 0x000148D9
		public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
		{
			base.OnCreateOptionsMenu(menu, inflater);
			inflater.Inflate(2131689510, menu);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000199C4 File Offset: 0x00017BC4
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 2131362655)
			{
				HomeModel.OpenSearch = true;
				base.Activity.FindViewById<TabLayout>(2131363116).GetTabAt(1).Select();
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00019A08 File Offset: 0x00017C08
		public override void OnResume()
		{
			base.OnResume();
			this.SliderIntervalerRepeat();
			this.mainActivity = (MainActivity)base.Activity;
			if (this.mainActivity.mainModel != null)
			{
				if (this.mainActivity.mainModel.UpdatesChart.new_episodes_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewEpisodesCountHome") > 0)
				{
					this.latestsTabLayout.GetTabAt(0).OrCreateBadge.BackgroundColor = base.Resources.GetColor(2131100510, base.Activity.Theme);
					SharedPreferencesSaves.IntSharedPreferencesSave("LatestSavedNewEpisodesCountHome", this.mainActivity.mainModel.UpdatesChart.new_episodes_count);
				}
				if (this.mainActivity.mainModel.UpdatesChart.new_anime_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewAnimeCountHome") > 0)
				{
					this.latestsTabLayout.GetTabAt(1).OrCreateBadge.BackgroundColor = base.Resources.GetColor(2131100510, base.Activity.Theme);
				}
				if (this.mainActivity.mainModel.UpdatesChart.new_characters_count - SharedPreferencesSaves.IntSharedPreferencesGet("LatestSavedNewCharsCountHome") > 0)
				{
					this.latestsTabLayout.GetTabAt(2).OrCreateBadge.BackgroundColor = base.Resources.GetColor(2131100510, base.Activity.Theme);
				}
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00019B6C File Offset: 0x00017D6C
		public override void OnPause()
		{
			base.OnPause();
			this.SliderIntervalerStop();
		}

		// Token: 0x040003EC RID: 1004
		private View view;

		// Token: 0x040003ED RID: 1005
		private UsersModel user;

		// Token: 0x040003EE RID: 1006
		private int userId;

		// Token: 0x040003EF RID: 1007
		private ViewPager2 trendingViewPager2;

		// Token: 0x040003F0 RID: 1008
		private TabLayout latestsTabLayout;

		// Token: 0x040003F1 RID: 1009
		private HomeModel homeMain;

		// Token: 0x040003F2 RID: 1010
		private List<HomeTrendingModel> trending;

		// Token: 0x040003F3 RID: 1011
		private Handler trendingHandler;

		// Token: 0x040003F4 RID: 1012
		private HomeFragment.SliderRunnable trendingRunnable;

		// Token: 0x040003F5 RID: 1013
		private SwipeRefreshLayout swipeRefresh;

		// Token: 0x040003F6 RID: 1014
		private ImageView latestsGridIcon;

		// Token: 0x040003F7 RID: 1015
		private ImageView broadcastGridIcon;

		// Token: 0x040003F8 RID: 1016
		private ImageView premiereGridIcon;

		// Token: 0x040003F9 RID: 1017
		private TextView latestsSeeAll;

		// Token: 0x040003FA RID: 1018
		private TextView broadcastSeeAll;

		// Token: 0x040003FB RID: 1019
		private TextView premiereSeeAll;

		// Token: 0x040003FC RID: 1020
		private TextView newsSeeAll;

		// Token: 0x040003FD RID: 1021
		private RecyclerView genresRecyclerView;

		// Token: 0x040003FE RID: 1022
		private RecyclerView latestsRecyclerView;

		// Token: 0x040003FF RID: 1023
		private RecyclerView broadcastRecyclerView;

		// Token: 0x04000400 RID: 1024
		private RecyclerView premiereRecyclerView;

		// Token: 0x04000401 RID: 1025
		private RecyclerView newsRecyclerView;

		// Token: 0x04000402 RID: 1026
		private ProgressBar homeLoader;

		// Token: 0x04000403 RID: 1027
		private LinearLayout homeContentParent;

		// Token: 0x04000404 RID: 1028
		private Button mOfflineRetry;

		// Token: 0x04000405 RID: 1029
		private RelativeLayout mOfflineView;

		// Token: 0x04000406 RID: 1030
		private HomeGenresAdapter mainGenresAdapter;

		// Token: 0x04000407 RID: 1031
		private AnimeCatalogGridAdapter latestAnimeStaticAdapter;

		// Token: 0x04000408 RID: 1032
		private AnimeCatalogGridAdapter broadcastStaticAdapter;

		// Token: 0x04000409 RID: 1033
		private AnimeCatalogGridAdapter premiereStaticAdapter;

		// Token: 0x0400040A RID: 1034
		private AnimeCatalogListAdapter latestAnimeListAdapter;

		// Token: 0x0400040B RID: 1035
		private AnimeCatalogListAdapter broadcastListAdapter;

		// Token: 0x0400040C RID: 1036
		private AnimeCatalogListAdapter premiereListAdapter;

		// Token: 0x0400040D RID: 1037
		private HomeNewsListAdapter newAdapter;

		// Token: 0x0400040E RID: 1038
		private LatestEpisodesStaticGridAdapter latestEpisodesStaticGridAdapter;

		// Token: 0x0400040F RID: 1039
		private LatestEpisodesListAdapter latestEpisodesListAdapter;

		// Token: 0x04000410 RID: 1040
		private CharactersListAdapter latestCharactersDynamicAdapter;

		// Token: 0x04000411 RID: 1041
		private LatestCharactersListAdapter latestCharactersStaticAdapter;

		// Token: 0x04000412 RID: 1042
		private LinearLayoutManager latestLinearLayoutManager;

		// Token: 0x04000413 RID: 1043
		private LinearLayoutManager broadcastLinearLayoutManager;

		// Token: 0x04000414 RID: 1044
		private LinearLayoutManager premiereLinearLayoutManager;

		// Token: 0x04000415 RID: 1045
		private GridLayoutManager latestGridLayoutManager130;

		// Token: 0x04000416 RID: 1046
		private GridLayoutManager latestGridLayoutManager400;

		// Token: 0x04000417 RID: 1047
		private GridLayoutManager broadcastGridLayoutManager;

		// Token: 0x04000418 RID: 1048
		private GridLayoutManager premiereGridLayoutManager;

		// Token: 0x04000419 RID: 1049
		private GridLayoutManager newsGridLayoutManager;

		// Token: 0x0400041A RID: 1050
		private MainActivity mainActivity;

		// Token: 0x0400041B RID: 1051
		private List<SelectableListModel> ganresList;

		// Token: 0x0400041C RID: 1052
		private static readonly long SLIDE_INTERVAL = 6000L;

		// Token: 0x0400041D RID: 1053
		private static readonly int GRID_ICON_ROTATION_ANGLE = 90;

		// Token: 0x0400041E RID: 1054
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x0400041F RID: 1055
		private const int TRENDING_REQUEST_CODE = 0;

		// Token: 0x04000420 RID: 1056
		private const int LATEST_EPISODES_REQUEST_CODE = 1;

		// Token: 0x04000421 RID: 1057
		private const int LATEST_ANIME_REQUEST_CODE = 2;

		// Token: 0x04000422 RID: 1058
		private const int LATEST_CHARACTERS_REQUEST_CODE = 3;

		// Token: 0x04000423 RID: 1059
		private const int BROADCAST_REQUEST_CODE = 4;

		// Token: 0x04000424 RID: 1060
		private const int PREMIERE_REQUEST_CODE = 5;

		// Token: 0x04000425 RID: 1061
		private long lastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000426 RID: 1062
		private bool isLoading;

		// Token: 0x04000427 RID: 1063
		private bool isTrendingLoaded;

		// Token: 0x04000428 RID: 1064
		private bool latestsLoadedVertically;

		// Token: 0x04000429 RID: 1065
		private bool broadcastLoadedVertically;

		// Token: 0x0400042A RID: 1066
		private bool premiereLoadedVertically;

		// Token: 0x02000126 RID: 294
		private class VPPageTransfer : Java.Lang.Object, ViewPager2.IPageTransformer, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000B89 RID: 2953 RVA: 0x0003D7D8 File Offset: 0x0003B9D8
			public VPPageTransfer(Context context)
			{
				this.context = context;
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x0003D7E8 File Offset: 0x0003B9E8
			public void TransformPage(View p0, float p1)
			{
				int num = (int)this.context.Resources.GetDimension(2131165988);
				int num2 = (int)this.context.Resources.GetDimension(2131165987);
				int num3 = num + num2;
				p0.TranslationX = (float)(-(float)num3) * p1;
				p0.ScaleY = 1f - 0.25f * Java.Lang.Math.Abs(p1);
			}

			// Token: 0x0400305E RID: 12382
			private Context context;
		}

		// Token: 0x02000127 RID: 295
		private class HorizontalMarginItemDecoration : RecyclerView.ItemDecoration
		{
			// Token: 0x06000B8B RID: 2955 RVA: 0x0003D84A File Offset: 0x0003BA4A
			public HorizontalMarginItemDecoration(Context context)
			{
				this.context = context;
			}

			// Token: 0x06000B8C RID: 2956 RVA: 0x0003D85C File Offset: 0x0003BA5C
			public override void GetItemOffsets(Rect outRect, View view, RecyclerView parent, RecyclerView.State state)
			{
				base.GetItemOffsets(outRect, view, parent, state);
				int num = (int)this.context.Resources.GetDimension(2131165987);
				outRect.Right = num;
				outRect.Left = num;
			}

			// Token: 0x0400305F RID: 12383
			private Context context;
		}

		// Token: 0x02000128 RID: 296
		private class OnPageChangeCallback : ViewPager2.OnPageChangeCallback
		{
			// Token: 0x06000B8D RID: 2957 RVA: 0x0003D899 File Offset: 0x0003BA99
			public OnPageChangeCallback(HomeFragment c)
			{
				this.context = c;
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
			public override void OnPageSelected(int position)
			{
				base.OnPageSelected(position);
				this.context.SliderIntervalerStop();
				this.context.SliderIntervalerRepeat();
			}

			// Token: 0x04003060 RID: 12384
			private HomeFragment context;
		}

		// Token: 0x02000129 RID: 297
		public class SliderRunnable : Java.Lang.Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000B8F RID: 2959 RVA: 0x0003D8C7 File Offset: 0x0003BAC7
			public SliderRunnable(HomeFragment c)
			{
				this.context = c;
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x0003D8D8 File Offset: 0x0003BAD8
			public void Run()
			{
				if (this.context.trending.Count - 1 == this.context.trendingViewPager2.CurrentItem)
				{
					this.context.trendingViewPager2.SetCurrentItem(-1, true);
					return;
				}
				this.context.trendingViewPager2.SetCurrentItem(this.context.trendingViewPager2.CurrentItem + 1, true);
			}

			// Token: 0x04003061 RID: 12385
			private HomeFragment context;
		}
	}
}
