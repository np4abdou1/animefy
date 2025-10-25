using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Activities;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Google.Android.Material.Tabs;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A2 RID: 162
	public class ExploreFragment : AndroidX.Fragment.App.Fragment
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x00015673 File Offset: 0x00013873
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			base.HasOptionsMenu = true;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00015684 File Offset: 0x00013884
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558528, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mMainContent = this.view.FindViewById<LinearLayout>(2131362360);
			this.seasonsProgressBar = this.view.FindViewById<ProgressBar>(2131362365);
			this.scheduleProgressBar = this.view.FindViewById<ProgressBar>(2131362362);
			this.mostWatchedEpisodesProgressBar = this.view.FindViewById<ProgressBar>(2131362370);
			this.seasonalAnimeRecyclerView = this.view.FindViewById<RecyclerView>(2131362364);
			this.scheduleRecyclerView = this.view.FindViewById<RecyclerView>(2131362361);
			this.mostWatchedEpisodesRecyclerView = this.view.FindViewById<RecyclerView>(2131362369);
			this.mSeasonsTabLayout = this.view.FindViewById<TabLayout>(2131362366);
			this.mYearsTabLayout = this.view.FindViewById<TabLayout>(2131362367);
			this.mWeekDaysTabLayout = this.view.FindViewById<TabLayout>(2131362371);
			this.seasonsNoResult = this.view.FindViewById<TextView>(2131362363);
			this.scheduleNoResult = this.view.FindViewById<TextView>(2131362368);
			this.mOfflineView = this.view.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = this.view.FindViewById<Button>(2131362815);
			this.seasonsLinearLayoutManager = new LinearLayoutManager(this.view.Context, 0, false);
			this.scheduleLinearLayoutManager = new LinearLayoutManager(this.view.Context, 0, false);
			this.mostWatchedEpisodesLinearLayoutManager = new LinearLayoutManager(this.view.Context, 0, false);
			if (base.Resources.GetString(2131951706) == "EN")
			{
				this.recyclerDirection = 1;
			}
			else
			{
				this.recyclerDirection = -1;
			}
			this.isLoading = true;
			this.InitializeLists();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadExploreMain();
			});
			this.mSeasonsTabLayout.TabSelected += this.MSeasonsTabLayout_TabSelected;
			this.mYearsTabLayout.TabSelected += this.MYearsTabLayout_TabSelected;
			this.mWeekDaysTabLayout.TabSelected += this.MWeekDaysTabLayout_TabSelected;
			this.seasonalAnimeRecyclerView.ScrollChange += this.SeasonalAnimeRecyclerView_ScrollChange;
			this.scheduleRecyclerView.ScrollChange += this.ScheduleRecyclerView_ScrollChange;
			this.mostWatchedEpisodesRecyclerView.ScrollChange += this.MostWatchedEpisodesRecyclerView_ScrollChange;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			return this.view;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00015939 File Offset: 0x00013B39
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.RefreshReload();
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00015944 File Offset: 0x00013B44
		private void MWeekDaysTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			this.selectedWeekDay = LanguageConvertor.WeekDayToDB(this.view.Context, e.Tab.Text);
			this.scheduleReachedEnd = false;
			this.scheduleProgressBar.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadSchedule(true, 0);
			});
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000159A0 File Offset: 0x00013BA0
		private void MYearsTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			this.selectedYear = e.Tab.Text;
			this.seasonsReachedEnd = false;
			this.seasonsProgressBar.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadSeasons(true, 0);
			});
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000159EC File Offset: 0x00013BEC
		private void MSeasonsTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			this.selectedSeason = LanguageConvertor.PremieredToDB(this.view.Context, e.Tab.Text);
			this.seasonsReachedEnd = false;
			this.seasonsProgressBar.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadSeasons(true, 0);
			});
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00015A48 File Offset: 0x00013C48
		private void MostWatchedEpisodesRecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.mostWatchedEpisodesRecyclerView.CanScrollHorizontally(this.recyclerDirection))
			{
				if (!this.isLoading && !this.mostWatchedEpisodesReachedEnd)
				{
					this.isLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mostWatchedEpisodesProgressBar.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadMostWatchedEpisodes(false, this.exploreMain.MostWatchedEpisodes.Count);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00015ABC File Offset: 0x00013CBC
		private void ScheduleRecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.scheduleRecyclerView.CanScrollHorizontally(this.recyclerDirection))
			{
				if (!this.isLoading && !this.scheduleReachedEnd)
				{
					this.isLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.scheduleProgressBar.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadSchedule(false, this.exploreMain.Schedule.Count);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00015B30 File Offset: 0x00013D30
		private void SeasonalAnimeRecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.seasonalAnimeRecyclerView.CanScrollHorizontally(this.recyclerDirection))
			{
				if (!this.isLoading && !this.seasonsReachedEnd)
				{
					this.isLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.seasonsProgressBar.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadSeasons(false, this.exploreMain.Seasons.Count);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00015BA4 File Offset: 0x00013DA4
		private void RefreshReload()
		{
			this.isLoading = true;
			this.mMainContent.Visibility = ViewStates.Visible;
			this.seasonsProgressBar.Visibility = ViewStates.Visible;
			this.scheduleProgressBar.Visibility = ViewStates.Visible;
			this.mostWatchedEpisodesProgressBar.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadExploreMain();
			});
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00015C08 File Offset: 0x00013E08
		private void InitializeLists()
		{
			this.yearsList = FixedCollections.YearsList();
			this.seasonsList = FixedCollections.Seasons(this.view.Context);
			this.weekDaysList = FixedCollections.WeekDays(this.view.Context);
			try
			{
				if (this.yearsList.Count > 0)
				{
					int index = this.yearsList.FindIndex((SelectableListModel p) => SharedPreferencesSaves.StringSharedPreferencesGet("CurrentSeason").Contains(p.Title));
					foreach (SelectableListModel selectableListModel in this.yearsList)
					{
						this.mYearsTabLayout.AddTab(this.mYearsTabLayout.NewTab().SetText(selectableListModel.Title));
					}
					this.mYearsTabLayout.SelectTab(this.mYearsTabLayout.GetTabAt(index));
					this.selectedYear = this.yearsList[index].Title;
					this.selectedYearPosition = index;
				}
				if (this.seasonsList.Count > 0)
				{
					int index2 = this.seasonsList.FindIndex((SelectableListModel p) => LanguageConvertor.Premiered(this.view.Context, SharedPreferencesSaves.StringSharedPreferencesGet("CurrentSeason")).Contains(p.Title));
					foreach (SelectableListModel selectableListModel2 in this.seasonsList)
					{
						this.mSeasonsTabLayout.AddTab(this.mSeasonsTabLayout.NewTab().SetText(selectableListModel2.Title));
					}
					this.mSeasonsTabLayout.SelectTab(this.mSeasonsTabLayout.GetTabAt(index2));
					this.selectedSeason = LanguageConvertor.PremieredToDB(this.view.Context, this.seasonsList[index2].Title);
					this.selectedSeasonPosition = index2;
				}
				if (this.weekDaysList.Count > 0)
				{
					int index3 = this.weekDaysList.FindIndex((SelectableListModel p) => LanguageConvertor.DayOfWeek(this.view.Context, DateTime.Now.DayOfWeek.ToString().ToUpper()).Contains(p.Title));
					foreach (SelectableListModel selectableListModel3 in this.weekDaysList)
					{
						this.mWeekDaysTabLayout.AddTab(this.mWeekDaysTabLayout.NewTab().SetText(selectableListModel3.Title));
					}
					this.mWeekDaysTabLayout.SelectTab(this.mWeekDaysTabLayout.GetTabAt(index3));
					this.selectedWeekDay = LanguageConvertor.WeekDayToDB(this.view.Context, this.weekDaysList[index3].Title);
					this.selectedWeekDayPosition = index3;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00015EFC File Offset: 0x000140FC
		private void LoadSeasons(bool reload = false, int from = 0)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("explore/load_seasons.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId.ToString());
			nameValueCollection.Add("Language", base.Resources.GetString(2131951706));
			nameValueCollection.Add("Premiere", this.selectedSeason + " " + this.selectedYear);
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> animeTmpList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.Activity.RunOnUiThread(delegate()
					{
						if (animeTmpList != null)
						{
							if (reload)
							{
								this.exploreMain.Seasons.Clear();
								this.exploreMain.Seasons.AddRange(animeTmpList);
								this.seasonsGridAdapter.NotifyDataSetChanged();
								if (this.exploreMain.Seasons.Count == 0)
								{
									this.seasonsNoResult.Text = string.Concat(new string[]
									{
										this.Resources.GetString(2131952229),
										LanguageConvertor.Premiered(this.view.Context, this.selectedSeason),
										" ",
										this.selectedYear,
										" ",
										this.Resources.GetString(2131952590)
									});
									this.seasonsNoResult.Visibility = ViewStates.Visible;
								}
								else
								{
									this.seasonsNoResult.Visibility = ViewStates.Gone;
								}
							}
							else
							{
								this.exploreMain.Seasons.AddRange(animeTmpList);
								this.seasonsGridAdapter.NotifyDataSetChanged();
								if (animeTmpList.Count == 0)
								{
									this.seasonsReachedEnd = true;
								}
							}
						}
						this.isLoading = false;
						this.seasonsProgressBar.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					Activity activity = this.Activity;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							this.isLoading = false;
							this.seasonsProgressBar.Visibility = ViewStates.Gone;
						});
					}
					activity.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00015FE0 File Offset: 0x000141E0
		private void LoadSchedule(bool reload = false, int from = 0)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("explore/load_shcedule.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId.ToString());
			nameValueCollection.Add("Language", base.Resources.GetString(2131951706));
			nameValueCollection.Add("Broadcast", this.selectedWeekDay);
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> animeTmpList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.Activity.RunOnUiThread(delegate()
					{
						if (animeTmpList != null)
						{
							if (reload)
							{
								this.exploreMain.Schedule.Clear();
								this.exploreMain.Schedule.AddRange(animeTmpList);
								this.scheduleGridAdapter.NotifyDataSetChanged();
								if (this.exploreMain.Schedule.Count == 0)
								{
									this.scheduleNoResult.Visibility = ViewStates.Visible;
								}
								else
								{
									this.scheduleNoResult.Visibility = ViewStates.Gone;
								}
							}
							else
							{
								this.exploreMain.Schedule.AddRange(animeTmpList);
								this.scheduleGridAdapter.NotifyDataSetChanged();
								if (animeTmpList.Count == 0)
								{
									this.scheduleReachedEnd = true;
								}
							}
						}
						this.isLoading = false;
						this.scheduleProgressBar.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					Activity activity = this.Activity;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							this.isLoading = false;
							this.scheduleProgressBar.Visibility = ViewStates.Gone;
						});
					}
					activity.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000160B4 File Offset: 0x000142B4
		private void LoadMostWatchedEpisodes(bool reload = false, int from = 0)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("explore/load_mw_episodes.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId.ToString());
			nameValueCollection.Add("Language", base.Resources.GetString(2131951706));
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModelWithOtherData> episodesTmpList = JsonConvert.DeserializeObject<List<AnimeModelWithOtherData>>(@string);
					this.Activity.RunOnUiThread(delegate()
					{
						if (episodesTmpList != null)
						{
							if (reload)
							{
								this.exploreMain.MostWatchedEpisodes.Clear();
								this.exploreMain.MostWatchedEpisodes.AddRange(episodesTmpList);
								this.mostWatchedEpisodesGridAdapter.NotifyDataSetChanged();
							}
							else
							{
								this.exploreMain.MostWatchedEpisodes.AddRange(episodesTmpList);
								this.mostWatchedEpisodesGridAdapter.NotifyDataSetChanged();
								if (episodesTmpList.Count == 0)
								{
									this.mostWatchedEpisodesReachedEnd = true;
								}
							}
						}
						this.isLoading = false;
						this.mostWatchedEpisodesProgressBar.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					Activity activity = this.Activity;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							this.isLoading = false;
							this.mostWatchedEpisodesProgressBar.Visibility = ViewStates.Gone;
						});
					}
					activity.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00016178 File Offset: 0x00014378
		private void LoadExploreMain()
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("explore/loade_explore.php"));
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
					this.selectedWeekDay
				},
				{
					"Premiere",
					this.selectedSeason + " " + this.selectedYear
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
					this.exploreMain = JsonConvert.DeserializeObject<ExploreModel>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (this.exploreMain != null)
						{
							this.seasonsGridAdapter = new AnimeCatalogGridAdapter(this.view.Context, this.exploreMain.Seasons, base.Resources.GetDimensionPixelSize(2131165282));
							this.seasonsGridAdapter.ItemClick += this.SeasonsGridAdapter_ItemClick;
							this.seasonsGridAdapter.ItemLongClick += this.SeasonsGridAdapter_ItemLongClick;
							this.seasonalAnimeRecyclerView.SetLayoutManager(this.seasonsLinearLayoutManager);
							this.seasonalAnimeRecyclerView.SetAdapter(this.seasonsGridAdapter);
							this.scheduleGridAdapter = new AnimeCatalogGridAdapter(this.view.Context, this.exploreMain.Schedule, base.Resources.GetDimensionPixelSize(2131165282));
							this.scheduleGridAdapter.ItemClick += this.ScheduleGridAdapter_ItemClick;
							this.scheduleGridAdapter.ItemLongClick += this.ScheduleGridAdapter_ItemLongClick;
							this.scheduleRecyclerView.SetLayoutManager(this.scheduleLinearLayoutManager);
							this.scheduleRecyclerView.SetAdapter(this.scheduleGridAdapter);
							this.mostWatchedEpisodesGridAdapter = new LatestEpisodesStaticGridAdapter(this.view.Context, this.exploreMain.MostWatchedEpisodes, base.Resources.GetDimensionPixelSize(2131165282));
							this.mostWatchedEpisodesGridAdapter.ItemClick += this.MostWatchedEpisodesGridAdapter_ItemClick;
							this.mostWatchedEpisodesGridAdapter.ItemLongClick += this.MostWatchedEpisodesGridAdapter_ItemLongClick;
							this.mostWatchedEpisodesRecyclerView.SetLayoutManager(this.mostWatchedEpisodesLinearLayoutManager);
							this.mostWatchedEpisodesRecyclerView.SetAdapter(this.mostWatchedEpisodesGridAdapter);
						}
						this.isLoading = false;
						this.seasonsProgressBar.Visibility = ViewStates.Gone;
						this.scheduleProgressBar.Visibility = ViewStates.Gone;
						this.mostWatchedEpisodesProgressBar.Visibility = ViewStates.Gone;
						this.mMainContent.Visibility = ViewStates.Visible;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.isLoading = false;
						this.seasonsProgressBar.Visibility = ViewStates.Gone;
						this.scheduleProgressBar.Visibility = ViewStates.Gone;
						this.mostWatchedEpisodesProgressBar.Visibility = ViewStates.Gone;
						this.mMainContent.Visibility = ViewStates.Gone;
						this.mOfflineView.Visibility = ViewStates.Visible;
					});
				}
			};
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001622E File Offset: 0x0001442E
		private void MostWatchedEpisodesGridAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.exploreMain.MostWatchedEpisodes[e].Anime);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001624C File Offset: 0x0001444C
		private void MostWatchedEpisodesGridAdapter_ItemClick(object sender, int e)
		{
			this.GoEpisodeServers(this.exploreMain.MostWatchedEpisodes[e].Episode, this.exploreMain.MostWatchedEpisodes[e].Anime);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00016280 File Offset: 0x00014480
		private void ScheduleGridAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.exploreMain.Schedule[e]);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00016299 File Offset: 0x00014499
		private void ScheduleGridAdapter_ItemClick(object sender, int e)
		{
			this.GoAnimeDetails(this.exploreMain.Schedule[e], this.scheduleRecyclerView, e, 1);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000162BA File Offset: 0x000144BA
		private void SeasonsGridAdapter_ItemLongClick(object sender, int e)
		{
			this.GoAnimeGlance(this.exploreMain.Seasons[e]);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000162D3 File Offset: 0x000144D3
		private void SeasonsGridAdapter_ItemClick(object sender, int e)
		{
			this.GoAnimeDetails(this.exploreMain.Seasons[e], this.seasonalAnimeRecyclerView, e, 2);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000162F4 File Offset: 0x000144F4
		private void GoAnimeDetails(AnimeModel anime, RecyclerView recyclerView, int itemPosition, int resultCode)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < ExploreFragment.CLICK_TIME_INTERVAL)
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

		// Token: 0x060006EF RID: 1775 RVA: 0x00016568 File Offset: 0x00014768
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

		// Token: 0x060006F0 RID: 1776 RVA: 0x000165E8 File Offset: 0x000147E8
		private void GoEpisodeServers(EpisodeModel episode, AnimeModel anime)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.lastClickTime < ExploreFragment.CLICK_TIME_INTERVAL)
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

		// Token: 0x060006F1 RID: 1777 RVA: 0x000166D9 File Offset: 0x000148D9
		public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
		{
			base.OnCreateOptionsMenu(menu, inflater);
			inflater.Inflate(2131689510, menu);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000166F0 File Offset: 0x000148F0
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

		// Token: 0x040003AA RID: 938
		private View view;

		// Token: 0x040003AB RID: 939
		private UsersModel user;

		// Token: 0x040003AC RID: 940
		private int userId;

		// Token: 0x040003AD RID: 941
		private LinearLayout mMainContent;

		// Token: 0x040003AE RID: 942
		private ProgressBar seasonsProgressBar;

		// Token: 0x040003AF RID: 943
		private ProgressBar scheduleProgressBar;

		// Token: 0x040003B0 RID: 944
		private ProgressBar mostWatchedEpisodesProgressBar;

		// Token: 0x040003B1 RID: 945
		private RecyclerView seasonalAnimeRecyclerView;

		// Token: 0x040003B2 RID: 946
		private RecyclerView scheduleRecyclerView;

		// Token: 0x040003B3 RID: 947
		private RecyclerView mostWatchedEpisodesRecyclerView;

		// Token: 0x040003B4 RID: 948
		private LinearLayoutManager seasonsLinearLayoutManager;

		// Token: 0x040003B5 RID: 949
		private LinearLayoutManager scheduleLinearLayoutManager;

		// Token: 0x040003B6 RID: 950
		private LinearLayoutManager mostWatchedEpisodesLinearLayoutManager;

		// Token: 0x040003B7 RID: 951
		private TextView seasonsNoResult;

		// Token: 0x040003B8 RID: 952
		private TextView scheduleNoResult;

		// Token: 0x040003B9 RID: 953
		private ExploreModel exploreMain;

		// Token: 0x040003BA RID: 954
		private List<SelectableListModel> yearsList;

		// Token: 0x040003BB RID: 955
		private List<SelectableListModel> seasonsList;

		// Token: 0x040003BC RID: 956
		private List<SelectableListModel> weekDaysList;

		// Token: 0x040003BD RID: 957
		private AnimeCatalogGridAdapter seasonsGridAdapter;

		// Token: 0x040003BE RID: 958
		private AnimeCatalogGridAdapter scheduleGridAdapter;

		// Token: 0x040003BF RID: 959
		private LatestEpisodesStaticGridAdapter mostWatchedEpisodesGridAdapter;

		// Token: 0x040003C0 RID: 960
		private Button mOfflineRetry;

		// Token: 0x040003C1 RID: 961
		private RelativeLayout mOfflineView;

		// Token: 0x040003C2 RID: 962
		private WebClient client;

		// Token: 0x040003C3 RID: 963
		private Uri uri;

		// Token: 0x040003C4 RID: 964
		private NameValueCollection parameters;

		// Token: 0x040003C5 RID: 965
		private TabLayout mSeasonsTabLayout;

		// Token: 0x040003C6 RID: 966
		private TabLayout mYearsTabLayout;

		// Token: 0x040003C7 RID: 967
		private TabLayout mWeekDaysTabLayout;

		// Token: 0x040003C8 RID: 968
		private string selectedYear;

		// Token: 0x040003C9 RID: 969
		private string selectedSeason;

		// Token: 0x040003CA RID: 970
		private string selectedWeekDay;

		// Token: 0x040003CB RID: 971
		private int recyclerDirection;

		// Token: 0x040003CC RID: 972
		private int selectedYearPosition;

		// Token: 0x040003CD RID: 973
		private int selectedSeasonPosition;

		// Token: 0x040003CE RID: 974
		private int selectedWeekDayPosition;

		// Token: 0x040003CF RID: 975
		private bool isLoading;

		// Token: 0x040003D0 RID: 976
		private bool seasonsReachedEnd;

		// Token: 0x040003D1 RID: 977
		private bool scheduleReachedEnd;

		// Token: 0x040003D2 RID: 978
		private bool mostWatchedEpisodesReachedEnd;

		// Token: 0x040003D3 RID: 979
		private const int SCHEDULE_REQUEST_CODE = 1;

		// Token: 0x040003D4 RID: 980
		private const int SEASONS_REQUEST_CODE = 2;

		// Token: 0x040003D5 RID: 981
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x040003D6 RID: 982
		private long lastClickTime = JavaSystem.CurrentTimeMillis();
	}
}
