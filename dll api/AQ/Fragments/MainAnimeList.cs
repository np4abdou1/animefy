using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AndroidX.CardView.Widget;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Activities;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Google.Android.Material.Button;
using Google.Android.Material.FloatingActionButton;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A6 RID: 166
	public class MainAnimeList : AndroidX.Fragment.App.Fragment
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x0001A680 File Offset: 0x00018880
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			base.HasOptionsMenu = true;
			this.mCatalogSeriesTmpList = new List<AnimeModel>();
			this.mCatalogSeriesSortingList = new List<AnimeModel>();
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001A6A8 File Offset: 0x000188A8
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558432, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.recyclerView = this.view.FindViewById<RecyclerView>(2131362041);
			this.mLoader = this.view.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = this.view.FindViewById<CardView>(2131362042);
			this.mOfflineView = this.view.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = this.view.FindViewById<Button>(2131362815);
			this.mSearshNoResault = this.view.FindViewById<RelativeLayout>(2131362967);
			this.swipeContainer = this.view.FindViewById<SwipeRefreshLayout>(2131362044);
			this.swipeContainer.Refresh += this.SwipeContainer_Refresh;
			this.mResortBtn = this.view.FindViewById<ImageView>(2131362043);
			this.fab1 = this.view.FindViewById<FloatingActionButton>(2131362374);
			this.fab2 = this.view.FindViewById<FloatingActionButton>(2131362376);
			this.fab3 = this.view.FindViewById<FloatingActionButton>(2131362378);
			this.fab4 = this.view.FindViewById<FloatingActionButton>(2131362380);
			this.fab1_container = this.view.FindViewById<LinearLayout>(2131362375);
			this.fab2_container = this.view.FindViewById<LinearLayout>(2131362377);
			this.fab3_container = this.view.FindViewById<LinearLayout>(2131362379);
			this.fab4_container = this.view.FindViewById<LinearLayout>(2131362381);
			this.fabs_bg = this.view.FindViewById<FrameLayout>(2131362382);
			this.fab_open = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			this.fab_close = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.rotate_forward = AnimationUtils.LoadAnimation(this.view.Context, 2130772021);
			this.rotate_backward = AnimationUtils.LoadAnimation(this.view.Context, 2130772020);
			this.fabsScroller = this.view.FindViewById<HorizontalScrollView>(2131362383);
			this.hideLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			this.mTypesToggle = this.view.FindViewById<MaterialButtonToggleGroup>(2131362577);
			this.LoadMainList();
			this.PrepareHeaderFilter();
			this.mResortBtn.Click += this.MResortBtn_Click;
			this.fab1.Click += this.Fab1_Click;
			this.fab2.Click += this.Fab2_Click;
			this.fab3.Click += this.Fab3_Click;
			this.fab4.Click += this.Fab4_Click;
			this.fabs_bg.Click += this.Fabs_bg_Click;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.mTypesToggle.ButtonChecked += this.MTypesToggle_ButtonChecked;
			return this.view;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001AA2C File Offset: 0x00018C2C
		private void MTypesToggle_ButtonChecked(object sender, MaterialButtonToggleGroup.ButtonCheckedEventArgs e)
		{
			if (e.P2)
			{
				int p = e.P1;
				if (p != 2131362578)
				{
					if (p == 2131362579)
					{
						this.type = "SERIES";
					}
					else
					{
						this.type = "SERIES";
					}
				}
				else
				{
					this.type = "MOVIE";
				}
				this.isloading = true;
				this.swipeContainer.Refreshing = true;
				this.mOfflineView.Visibility = ViewStates.Gone;
				this.mSearshNoResault.Visibility = ViewStates.Gone;
				this.LoadMainList();
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		private void PrepareHeaderFilter()
		{
			this.recyclerViewFilterSerach = this.view.FindViewById<RecyclerView>(2131362576);
			this.recyclerViewFilterSerach.SetLayoutManager(new LinearLayoutManager(this.view.Context, 0, false));
			this.headerGenreList = new List<SelectableListModel>();
			this.headerGenresAdapter = new MainGenresAdapterV2(this.view.Context, this.headerGenreList);
			this.headerGenresAdapter.ItemClick += this.MainGenresAdapter_ItemClick;
			this.headerStudiosList = new List<SelectableListModel>();
			this.headerStudiosAdapter = new ClickableTextsAdapter(this.view.Context, this.headerStudiosList);
			this.headerStudiosAdapter.ItemClick += this.HeaderStudiosAdapter_ItemClick;
			this.headerPremieredList = new List<SelectableListModel>();
			this.headerPremieredAdapter = new ClickableTextsAdapter(this.view.Context, this.headerPremieredList);
			this.headerPremieredAdapter.ItemClick += this.HeaderPremieredAdapter_ItemClick;
			this.headerSortList = new List<SelectableListModel>();
			this.headerSortAdapter = new ClickableTextsAdapter(this.view.Context, this.headerSortList);
			this.headerSortAdapter.ItemClick += this.HeaderSortAdapter_ItemClick;
			this.InitHeaderGenres();
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001ABF0 File Offset: 0x00018DF0
		private void InitHeaderGenres()
		{
			MainAnimeList.<InitHeaderGenres>d__58 <InitHeaderGenres>d__;
			<InitHeaderGenres>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitHeaderGenres>d__.<>4__this = this;
			<InitHeaderGenres>d__.<>1__state = -1;
			<InitHeaderGenres>d__.<>t__builder.Start<MainAnimeList.<InitHeaderGenres>d__58>(ref <InitHeaderGenres>d__);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001AC28 File Offset: 0x00018E28
		private void InitHeaderStudios()
		{
			MainAnimeList.<InitHeaderStudios>d__59 <InitHeaderStudios>d__;
			<InitHeaderStudios>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitHeaderStudios>d__.<>4__this = this;
			<InitHeaderStudios>d__.<>1__state = -1;
			<InitHeaderStudios>d__.<>t__builder.Start<MainAnimeList.<InitHeaderStudios>d__59>(ref <InitHeaderStudios>d__);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001AC60 File Offset: 0x00018E60
		private void InitHeaderPremiered()
		{
			MainAnimeList.<InitHeaderPremiered>d__60 <InitHeaderPremiered>d__;
			<InitHeaderPremiered>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitHeaderPremiered>d__.<>4__this = this;
			<InitHeaderPremiered>d__.<>1__state = -1;
			<InitHeaderPremiered>d__.<>t__builder.Start<MainAnimeList.<InitHeaderPremiered>d__60>(ref <InitHeaderPremiered>d__);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001AC98 File Offset: 0x00018E98
		private void InitHeaderSort()
		{
			MainAnimeList.<InitHeaderSort>d__61 <InitHeaderSort>d__;
			<InitHeaderSort>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitHeaderSort>d__.<>4__this = this;
			<InitHeaderSort>d__.<>1__state = -1;
			<InitHeaderSort>d__.<>t__builder.Start<MainAnimeList.<InitHeaderSort>d__61>(ref <InitHeaderSort>d__);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		private void MainGenresAdapter_ItemClick(object sender, int e)
		{
			if (!this.isloading)
			{
				if (this.headerGenreList[e].Selected)
				{
					this.headerGenreList[e].Selected = false;
					this.headerGenresAdapter.NotifyDataSetChanged();
					bool flag = false;
					foreach (SelectableListModel selectableListModel in this.headerGenreList)
					{
						if (selectableListModel.Selected)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.filterType = "GENRE";
						this.filterData = this.filterData.Replace(LanguageConvertor.GenresToENSingle(this.view.Context, this.headerGenreList[e].Title) + ",", "");
					}
					else
					{
						this.filterType = "";
						this.filterData = "";
					}
				}
				else
				{
					this.headerGenreList[e].Selected = true;
					this.headerGenresAdapter.NotifyDataSetChanged();
					this.filterType = "GENRE";
					this.filterData = this.filterData + LanguageConvertor.GenresToENSingle(this.view.Context, this.headerGenreList[e].Title) + ",";
				}
				this.LoadMainList();
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001AE34 File Offset: 0x00019034
		private int GetSelectedItemPostision(List<SelectableListModel> list)
		{
			int num = 0;
			foreach (SelectableListModel selectableListModel in list)
			{
				if (selectableListModel.Selected)
				{
					break;
				}
				num++;
			}
			if (num != list.Count)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001AE98 File Offset: 0x00019098
		private void HeaderStudiosAdapter_ItemClick(object sender, int e)
		{
			if (!this.isloading)
			{
				if (this.headerStudiosList[e].Selected)
				{
					this.headerStudiosList[e].Selected = false;
					this.headerStudiosAdapter.NotifyDataSetChanged();
					bool flag = false;
					foreach (SelectableListModel selectableListModel in this.headerStudiosList)
					{
						if (selectableListModel.Selected)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.filterType = "STUDIOS";
						this.filterData = this.filterData.Replace(this.headerStudiosList[e].Title + ",", "");
					}
					else
					{
						this.filterType = "";
						this.filterData = "";
					}
				}
				else
				{
					this.headerStudiosList[e].Selected = true;
					this.headerStudiosAdapter.NotifyDataSetChanged();
					this.filterType = "STUDIOS";
					this.filterData = this.filterData + this.headerStudiosList[e].Title + ",";
				}
				this.LoadMainList();
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001AFDC File Offset: 0x000191DC
		private void HeaderPremieredAdapter_ItemClick(object sender, int e)
		{
			if (!this.isloading)
			{
				if (this.headerPremieredList[e].Selected)
				{
					this.headerPremieredList[e].Selected = false;
					this.headerPremieredAdapter.NotifyDataSetChanged();
					bool flag = false;
					foreach (SelectableListModel selectableListModel in this.headerPremieredList)
					{
						if (selectableListModel.Selected)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.filterType = "PREMIERED";
						this.filterData = this.filterData.Replace(this.headerPremieredList[e].Title + ",", "");
					}
					else
					{
						this.filterType = "";
						this.filterData = "";
					}
				}
				else
				{
					this.headerPremieredList[e].Selected = true;
					this.headerPremieredAdapter.NotifyDataSetChanged();
					this.filterType = "PREMIERED";
					this.filterData = this.filterData + this.headerPremieredList[e].Title + ",";
				}
				this.LoadMainList();
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0001B120 File Offset: 0x00019320
		private void HeaderSortAdapter_ItemClick(object sender, int e)
		{
			if (!this.isloading)
			{
				int selectedItemPostision = this.GetSelectedItemPostision(this.headerSortList);
				if (selectedItemPostision == e)
				{
					this.headerSortList[e].Selected = false;
					this.headerSortAdapter.NotifyItemChanged(e);
					this.isloading = true;
					this.swipeContainer.Refreshing = true;
					this.filterType = "";
					this.filterData = "";
				}
				else
				{
					if (selectedItemPostision != -1)
					{
						this.headerSortList[selectedItemPostision].Selected = false;
					}
					this.headerSortList[e].Selected = true;
					this.headerSortAdapter.NotifyDataSetChanged();
					this.mCatalogSeriesSortingList.Clear();
					this.isloading = true;
					this.swipeContainer.Refreshing = true;
					this.filterType = "SORT";
					switch (e)
					{
					case 0:
						this.filterData = "NAME";
						break;
					case 1:
						this.filterData = "PREMIERED_DEC";
						break;
					case 2:
						this.filterData = "PREMIERED_ACS";
						break;
					case 3:
						this.filterData = "EPISODES_DEC";
						break;
					case 4:
						this.filterData = "EPISODES_ASC";
						break;
					case 5:
						this.filterData = "HIGHEST_RATE";
						break;
					case 6:
						this.filterData = "HIGHEST_RANK";
						break;
					default:
						this.filterData = "NAME";
						break;
					}
				}
				this.LoadMainList();
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001B281 File Offset: 0x00019481
		private void MResortBtn_Click(object sender, EventArgs e)
		{
			this.AnimateFAB();
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001B28C File Offset: 0x0001948C
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1))
			{
				if (!this.isloading)
				{
					this.isloading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadMoreAnime(this.mCatalogSeriesList.Count);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isloading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001B304 File Offset: 0x00019504
		public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
		{
			inflater.Inflate(2131689509, menu);
			IMenuItem menuItem = menu.FindItem(2131361867);
			SearchView instance = menuItem.ActionView.JavaCast<SearchView>();
			this.searchView = instance.JavaCast<SearchView>();
			if (HomeModel.OpenSearch)
			{
				HomeModel.OpenSearch = false;
				menuItem.ExpandActionView();
			}
			this.searchView.QueryTextChange += delegate(object s, [Nullable(1)] SearchView.QueryTextChangeEventArgs e)
			{
				if (e.NewText.Length > 2)
				{
					if (!this.isloading)
					{
						this.isloading = true;
						this.swipeContainer.Refreshing = true;
						this.filterType = "SEARCH";
						this.filterData = e.NewText;
						this.LoadMainList();
					}
				}
				else if (e.NewText.Length == 0)
				{
					this.ReloadMainList();
				}
				e.Handled = true;
			};
			this.searchView.QueryTextSubmit += delegate(object s, [Nullable(1)] SearchView.QueryTextSubmitEventArgs e)
			{
				if (e.NewText.Length > 0)
				{
					if (!this.isloading)
					{
						this.isloading = true;
						this.swipeContainer.Refreshing = true;
						this.filterType = "SEARCH";
						this.filterData = e.NewText;
						this.LoadMainList();
					}
				}
				else
				{
					this.ReloadMainList();
				}
				e.Handled = true;
			};
			base.OnCreateOptionsMenu(menu, inflater);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001B38B File Offset: 0x0001958B
		public override void OnPause()
		{
			base.OnPause();
			if (this.recyclerView != null)
			{
				this.recyclerView.SuppressLayout(true);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001B3A7 File Offset: 0x000195A7
		public override void OnResume()
		{
			base.OnResume();
			if (this.recyclerView != null)
			{
				this.recyclerView.SuppressLayout(false);
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001B3C3 File Offset: 0x000195C3
		private void SwipeContainer_Refresh(object sender, EventArgs e)
		{
			this.ReloadMainList();
			(sender as SwipeRefreshLayout).Refreshing = false;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001B3D7 File Offset: 0x000195D7
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.ReloadMainList();
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001B3DF File Offset: 0x000195DF
		private void LoadMainList()
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadAnime();
			});
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001B3F4 File Offset: 0x000195F4
		private void ReloadMainList()
		{
			this.filterType = "";
			this.filterData = "";
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mSearshNoResault.Visibility = ViewStates.Gone;
			foreach (SelectableListModel selectableListModel in this.headerGenreList)
			{
				selectableListModel.Selected = false;
			}
			foreach (SelectableListModel selectableListModel2 in this.headerStudiosList)
			{
				selectableListModel2.Selected = false;
			}
			foreach (SelectableListModel selectableListModel3 in this.headerPremieredList)
			{
				selectableListModel3.Selected = false;
			}
			foreach (SelectableListModel selectableListModel4 in this.headerSortList)
			{
				selectableListModel4.Selected = false;
			}
			this.headerGenresAdapter.NotifyDataSetChanged();
			this.headerStudiosAdapter.NotifyDataSetChanged();
			this.headerPremieredAdapter.NotifyDataSetChanged();
			this.headerSortAdapter.NotifyDataSetChanged();
			this.recyclerViewFilterSerach.SmoothScrollToPosition(0);
			this.isloading = true;
			this.LoadMainList();
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0001B5A0 File Offset: 0x000197A0
		private void LoadAnime()
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("anime/load_anime_list_v2.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("FilterType", this.filterType);
			this.parameters.Add("FilterData", this.filterData.TrimEnd(','));
			this.parameters.Add("Type", this.type);
			this.parameters.Add("From", 0.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mCatalogSeriesList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (this.mCatalogSeriesList == null)
						{
							this.mLoader.Visibility = ViewStates.Gone;
							this.mOfflineView.Visibility = ViewStates.Visible;
							this.recyclerView.Visibility = ViewStates.Gone;
							return;
						}
						this.mCatalogSeriesTmpList.Clear();
						this.mCatalogSeriesTmpList.AddRange(this.mCatalogSeriesList);
						if (SharedPreferencesSaves.StringSharedPreferencesGet("AnimeListMode") == "List")
						{
							this.seriesAdapterList = new AnimeCatalogListAdapter(this.view.Context, this.mCatalogSeriesTmpList, false);
							this.seriesAdapterList.ItemClick += this.SeriesAdapterList_ItemClick;
							this.seriesAdapterList.ItemPlotClick += this.SeriesAdapterList_ItemPlotClick;
							this.recyclerView.SetLayoutManager(new GridLayoutManager(this.view.Context, 1));
							this.recyclerView.SetAdapter(this.seriesAdapterList);
						}
						else
						{
							this.seriesAdapterGrid = new AnimeCatalogGridAdapter(this.view.Context, this.mCatalogSeriesTmpList, 0);
							this.seriesAdapterGrid.ItemClick += this.SeriesAdapterGrid_ItemClick;
							this.seriesAdapterGrid.ItemLongClick += this.SeriesAdapterGrid_ItemLongClick;
							this.recyclerView.SetLayoutManager(new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 140f)));
							this.recyclerView.SetAdapter(this.seriesAdapterGrid);
						}
						this.isloading = false;
						this.swipeContainer.Refreshing = false;
						this.mLoader.Visibility = ViewStates.Gone;
						this.recyclerView.Visibility = ViewStates.Visible;
						this.mMoreLoader.StartAnimation(this.hideLoader);
						this.mMoreLoader.Visibility = ViewStates.Gone;
						if (this.mCatalogSeriesList.Count == 0)
						{
							this.mSearshNoResault.Visibility = ViewStates.Visible;
							return;
						}
						this.mSearshNoResault.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.mLoader.Visibility = ViewStates.Gone;
						this.mOfflineView.Visibility = ViewStates.Visible;
						this.recyclerView.Visibility = ViewStates.Gone;
					});
				}
			};
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001B6B8 File Offset: 0x000198B8
		private void LoadMoreAnime(int from)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("anime/load_anime_list_v2.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("FilterType", this.filterType);
			this.parameters.Add("FilterData", this.filterData.TrimEnd(','));
			this.parameters.Add("Type", this.type);
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> seriesList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (seriesList.Count != 0)
						{
							this.mCatalogSeriesList.AddRange(seriesList);
							this.mCatalogSeriesTmpList.Clear();
							this.mCatalogSeriesTmpList.AddRange(this.mCatalogSeriesList);
							if (SharedPreferencesSaves.StringSharedPreferencesGet("AnimeListMode") == "List")
							{
								this.seriesAdapterList.NotifyDataSetChanged();
							}
							else
							{
								this.seriesAdapterGrid.NotifyDataSetChanged();
							}
						}
						this.isloading = false;
						this.mMoreLoader.StartAnimation(this.hideLoader);
						this.mMoreLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.isloading = false;
						this.mMoreLoader.StartAnimation(this.hideLoader);
						this.mMoreLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951821), 0);
					});
				}
			};
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001B7CE File Offset: 0x000199CE
		private void SeriesAdapterGrid_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001B7D8 File Offset: 0x000199D8
		private void SeriesAdapterGrid_ItemLongClick(object sender, int e)
		{
			AnimeModel animeModel = this.mCatalogSeriesTmpList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "DialogDescription");
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001B864 File Offset: 0x00019A64
		private void SeriesAdapterList_ItemPlotClick(object sender, int e)
		{
			AnimeModel animeModel = this.mCatalogSeriesTmpList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "DialogDescription");
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001B7CE File Offset: 0x000199CE
		private void SeriesAdapterList_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001B938 File Offset: 0x00019B38
		private void GoToDetails(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < MainAnimeList.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.mCatalogSeriesTmpList[itemPosition];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(itemPosition).ItemView;
			ImageView sharedElement = itemView.FindViewById<ImageView>(2131361956);
			Intent intent = new Intent(Application.Context, typeof(AnimeDetails));
			intent.PutExtra("AnimeId", animeModel.AnimeId);
			intent.PutExtra("ENTitle", animeModel.EN_Title);
			intent.PutExtra("JPTitle", animeModel.JP_Title);
			intent.PutExtra("ARTitle", animeModel.AR_Title);
			intent.PutExtra("Synonyms", animeModel.Synonyms);
			intent.PutExtra("Tags", animeModel.Tags);
			intent.PutExtra("Genres", animeModel.Genres);
			intent.PutExtra("Season", animeModel.Season);
			intent.PutExtra("Duration", animeModel.Duration);
			intent.PutExtra("Premiered", animeModel.Premiered);
			intent.PutExtra("Aired", animeModel.Aired);
			intent.PutExtra("Broadcast", animeModel.Broadcast);
			intent.PutExtra("Thumbnail", Constants.Thumbnails(animeModel.Thumbnail));
			intent.PutExtra("Trailer", animeModel.Trailer);
			intent.PutExtra("YTTrailer", animeModel.YTTrailer);
			intent.PutExtra("Creators", animeModel.Creators);
			intent.PutExtra("Status", animeModel.Status);
			intent.PutExtra("Episodes", animeModel.Episodes);
			intent.PutExtra("Score", animeModel.Score);
			intent.PutExtra("Rank", animeModel.Rank);
			intent.PutExtra("Popularity", animeModel.Popularity);
			intent.PutExtra("Rating", animeModel.Rating);
			intent.PutExtra("RelationId", animeModel.RelationId);
			intent.PutExtra("MalId", animeModel.MalId);
			intent.PutExtra("Type", animeModel.Type);
			intent.PutExtra("ItemPosition", itemPosition);
			intent.PutExtra("Transition", this.isloading);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001B281 File Offset: 0x00019481
		private void Fabs_bg_Click(object sender, EventArgs e)
		{
			this.AnimateFAB();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		public void AnimateFAB()
		{
			if (this.isFabOpen)
			{
				this.fabs_bg.Visibility = ViewStates.Gone;
				this.fabsScroller.Visibility = ViewStates.Invisible;
				this.fab1_container.StartAnimation(this.fab_close);
				this.fab2_container.StartAnimation(this.fab_close);
				this.fab3_container.StartAnimation(this.fab_close);
				this.fab4_container.StartAnimation(this.fab_close);
				this.fab1.Clickable = false;
				this.fab2.Clickable = false;
				this.fab3.Clickable = false;
				this.fab4.Clickable = false;
				this.isFabOpen = false;
				return;
			}
			this.fabs_bg.Visibility = ViewStates.Visible;
			this.fabsScroller.Visibility = ViewStates.Visible;
			this.fab1_container.StartAnimation(this.fab_open);
			this.fab2_container.StartAnimation(this.fab_open);
			this.fab3_container.StartAnimation(this.fab_open);
			this.fab4_container.StartAnimation(this.fab_open);
			this.fab1.Clickable = true;
			this.fab2.Clickable = true;
			this.fab3.Clickable = true;
			this.fab4.Clickable = true;
			this.isFabOpen = true;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001BD1F File Offset: 0x00019F1F
		private void Fab1_Click(object sender, EventArgs e)
		{
			if (this.filterBy != "GENRE")
			{
				this.InitHeaderGenres();
			}
			this.AnimateFAB();
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001BD3F File Offset: 0x00019F3F
		private void Fab2_Click(object sender, EventArgs e)
		{
			if (this.filterBy != "STUDIOS")
			{
				this.InitHeaderStudios();
			}
			this.AnimateFAB();
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001BD5F File Offset: 0x00019F5F
		private void Fab3_Click(object sender, EventArgs e)
		{
			if (this.filterBy != "PREMIERED")
			{
				this.InitHeaderPremiered();
			}
			this.AnimateFAB();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001BD7F File Offset: 0x00019F7F
		private void Fab4_Click(object sender, EventArgs e)
		{
			if (this.filterBy != "SORT")
			{
				this.InitHeaderSort();
			}
			this.AnimateFAB();
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AnimeListMode") != "List")
			{
				this.recyclerView.SetLayoutManager(new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 140f)));
			}
		}

		// Token: 0x0400043C RID: 1084
		private View view;

		// Token: 0x0400043D RID: 1085
		private UsersModel user;

		// Token: 0x0400043E RID: 1086
		private int userId;

		// Token: 0x0400043F RID: 1087
		private RecyclerView recyclerView;

		// Token: 0x04000440 RID: 1088
		private AnimeCatalogGridAdapter seriesAdapterGrid;

		// Token: 0x04000441 RID: 1089
		private AnimeCatalogListAdapter seriesAdapterList;

		// Token: 0x04000442 RID: 1090
		private ProgressBar mLoader;

		// Token: 0x04000443 RID: 1091
		private RelativeLayout mOfflineView;

		// Token: 0x04000444 RID: 1092
		private RelativeLayout mSearshNoResault;

		// Token: 0x04000445 RID: 1093
		private Button mOfflineRetry;

		// Token: 0x04000446 RID: 1094
		private List<AnimeModel> mCatalogSeriesList;

		// Token: 0x04000447 RID: 1095
		private List<AnimeModel> mCatalogSeriesTmpList;

		// Token: 0x04000448 RID: 1096
		private List<AnimeModel> mCatalogSeriesSortingList;

		// Token: 0x04000449 RID: 1097
		private LinearLayout fab1_container;

		// Token: 0x0400044A RID: 1098
		private LinearLayout fab2_container;

		// Token: 0x0400044B RID: 1099
		private LinearLayout fab3_container;

		// Token: 0x0400044C RID: 1100
		private LinearLayout fab4_container;

		// Token: 0x0400044D RID: 1101
		private FrameLayout fabs_bg;

		// Token: 0x0400044E RID: 1102
		private ImageView mResortBtn;

		// Token: 0x0400044F RID: 1103
		private FloatingActionButton fab1;

		// Token: 0x04000450 RID: 1104
		private FloatingActionButton fab2;

		// Token: 0x04000451 RID: 1105
		private FloatingActionButton fab3;

		// Token: 0x04000452 RID: 1106
		private FloatingActionButton fab4;

		// Token: 0x04000453 RID: 1107
		private Animation fab_open;

		// Token: 0x04000454 RID: 1108
		private Animation fab_close;

		// Token: 0x04000455 RID: 1109
		private Animation rotate_forward;

		// Token: 0x04000456 RID: 1110
		private Animation rotate_backward;

		// Token: 0x04000457 RID: 1111
		private Animation hideLoader;

		// Token: 0x04000458 RID: 1112
		private Animation showLoader;

		// Token: 0x04000459 RID: 1113
		private HorizontalScrollView fabsScroller;

		// Token: 0x0400045A RID: 1114
		private bool isFabOpen;

		// Token: 0x0400045B RID: 1115
		private bool isloading = true;

		// Token: 0x0400045C RID: 1116
		private string filterType;

		// Token: 0x0400045D RID: 1117
		private string filterData = "";

		// Token: 0x0400045E RID: 1118
		private string type = "SERIES";

		// Token: 0x0400045F RID: 1119
		private CardView mMoreLoader;

		// Token: 0x04000460 RID: 1120
		private SwipeRefreshLayout swipeContainer;

		// Token: 0x04000461 RID: 1121
		private SearchView searchView;

		// Token: 0x04000462 RID: 1122
		private WebClient client;

		// Token: 0x04000463 RID: 1123
		private Uri uri;

		// Token: 0x04000464 RID: 1124
		private NameValueCollection parameters;

		// Token: 0x04000465 RID: 1125
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000466 RID: 1126
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x04000467 RID: 1127
		private RecyclerView recyclerViewFilterSerach;

		// Token: 0x04000468 RID: 1128
		private MainGenresAdapterV2 headerGenresAdapter;

		// Token: 0x04000469 RID: 1129
		private ClickableTextsAdapter headerStudiosAdapter;

		// Token: 0x0400046A RID: 1130
		private ClickableTextsAdapter headerPremieredAdapter;

		// Token: 0x0400046B RID: 1131
		private ClickableTextsAdapter headerSortAdapter;

		// Token: 0x0400046C RID: 1132
		private List<SelectableListModel> headerGenreList;

		// Token: 0x0400046D RID: 1133
		private List<SelectableListModel> headerStudiosList;

		// Token: 0x0400046E RID: 1134
		private List<SelectableListModel> headerPremieredList;

		// Token: 0x0400046F RID: 1135
		private List<SelectableListModel> headerSortList;

		// Token: 0x04000470 RID: 1136
		private string filterBy = "GENRE";

		// Token: 0x04000471 RID: 1137
		private MaterialButtonToggleGroup mTypesToggle;
	}
}
