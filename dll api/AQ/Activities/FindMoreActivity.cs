using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000C8 RID: 200
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class FindMoreActivity : AppCompatActivity
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x00030D48 File Offset: 0x0002EF48
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
			this.findMoreType = this.Intent.GetStringExtra("FindMoreType");
			this.findMoreData = this.Intent.GetStringExtra("FindMoreData");
			this.dataTitle = this.Intent.GetStringExtra("DataTitle");
			this.OverridePendingTransition(2130772025, 2130772026);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SupportActionBar.SetDisplayShowTitleEnabled(false);
			this.SupportActionBar.SetDisplayShowCustomEnabled(true);
			this.SupportActionBar.SetCustomView(2131558642);
			this.SetContentView(2131558447);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.animeList = new List<AnimeModel>();
			this.mContent = base.FindViewById<RelativeLayout>(2131363076);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362420);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = base.FindViewById<CardView>(2131362421);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
			this.mEmptyViewIcon = base.FindViewById<ImageView>(2131362333);
			this.mEmptyViewMessage = base.FindViewById<TextView>(2131362334);
			this.mFindMoreOf = base.FindViewById<TextView>(2131362422);
			this.mFindMoreOfTitle = base.FindViewById<TextView>(2131362423);
			this.mEmptyViewIcon.SetImageResource(2131231193);
			this.mEmptyViewMessage.Text = this.Resources.GetString(2131952242);
			this.mFindMoreOf.Text = this.dataTitle;
			this.LoadFindMoreLists();
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00030FE4 File Offset: 0x0002F1E4
		private void LoadFindMoreLists()
		{
			if (this.findMoreType == "GENRE")
			{
				this.mFindMoreOfTitle.Text = this.Resources.GetString(2131951946);
			}
			else if (this.findMoreType == "STUDIOS")
			{
				this.mFindMoreOfTitle.Text = this.Resources.GetString(2131951947);
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadAnimeList(0, false);
			});
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0003105F File Offset: 0x0002F25F
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.LoadFindMoreLists();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0003108C File Offset: 0x0002F28C
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1))
			{
				if (!this.isLoading && !this.isReachedToEnd)
				{
					this.isLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadAnimeList(this.animeList.Count<AnimeModel>(), true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0003110C File Offset: 0x0002F30C
		private void LoadAnimeList(int from = 0, bool loadMore = false)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("anime/load_anime_list.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("FilterType", this.findMoreType);
			this.parameters.Add("FilterData", this.findMoreData);
			this.parameters.Add("Type", "FINDMORE");
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> tempList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (tempList != null)
						{
							if (loadMore)
							{
								if (tempList.Count == 0)
								{
									this.isReachedToEnd = true;
								}
								else
								{
									this.animeList.AddRange(tempList);
									if (this.loadAsGrid)
									{
										this.adapterGrid.NotifyDataSetChanged();
									}
									else
									{
										this.adapterList.NotifyDataSetChanged();
									}
								}
								this.mMoreLoader.StartAnimation(this.hideLoader);
								this.mMoreLoader.Visibility = ViewStates.Gone;
							}
							else if (tempList.Count == 0)
							{
								this.mLoader.Visibility = ViewStates.Gone;
								this.mEmptyView.Visibility = ViewStates.Visible;
							}
							else
							{
								this.animeList.Clear();
								this.animeList.AddRange(tempList);
								this.LoadAs(this.animeList);
								this.mLoader.Visibility = ViewStates.Gone;
								this.recyclerView.Visibility = ViewStates.Visible;
							}
						}
						else if (loadMore)
						{
							this.mMoreLoader.StartAnimation(this.hideLoader);
							this.mMoreLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mLoader.Visibility = ViewStates.Gone;
							this.recyclerView.Visibility = ViewStates.Gone;
							this.mOfflineView.Visibility = ViewStates.Visible;
						}
						this.isLoading = false;
					});
				}
				catch
				{
					Activity <>4__this = this;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							if (loadMore)
							{
								this.mMoreLoader.StartAnimation(this.hideLoader);
								this.mMoreLoader.Visibility = ViewStates.Gone;
							}
							else
							{
								this.mLoader.Visibility = ViewStates.Gone;
								this.recyclerView.Visibility = ViewStates.Gone;
								this.mOfflineView.Visibility = ViewStates.Visible;
							}
							this.isLoading = false;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00031230 File Offset: 0x0002F430
		private void LoadAs(List<AnimeModel> list)
		{
			if (this.loadAsGrid)
			{
				this.adapterGrid = new AnimeCatalogGridAdapter(this, list, 0);
				this.adapterGrid.ItemClick += this.AdapterGrid_ItemClick;
				this.adapterGrid.ItemLongClick += this.AdapterGrid_ItemLongClick;
				this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 140f));
				this.recyclerView.SetLayoutManager(this.layoutManager);
				this.recyclerView.SetAdapter(this.adapterGrid);
				return;
			}
			this.adapterList = new AnimeCatalogListAdapter(this, this.animeList, false);
			this.adapterList.ItemClick += this.AdapterList_ItemClick;
			this.adapterList.ItemPlotClick += this.AdapterList_ItemPlotClick;
			this.layoutManager = new GridLayoutManager(this, 1);
			this.recyclerView.SetLayoutManager(this.layoutManager);
			this.recyclerView.SetAdapter(this.adapterList);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0003132B File Offset: 0x0002F52B
		private void AdapterGrid_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00031334 File Offset: 0x0002F534
		private void AdapterGrid_ItemLongClick(object sender, int e)
		{
			this.OpenPlot(e);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00031334 File Offset: 0x0002F534
		private void AdapterList_ItemPlotClick(object sender, int e)
		{
			this.OpenPlot(e);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0003132B File Offset: 0x0002F52B
		private void AdapterList_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00031340 File Offset: 0x0002F540
		private void OpenPlot(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FindMoreActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.animeList[itemPosition];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "AnimeDetailsGlance");
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000313EC File Offset: 0x0002F5EC
		private void GoToDetails(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FindMoreActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.animeList[itemPosition];
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
			intent.PutExtra("Transition", this.isLoading);
			intent.PutExtra("CommingFromFindMore", true);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00031698 File Offset: 0x0002F898
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000316DD File Offset: 0x0002F8DD
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.localMenu = menu;
			this.MenuInflater.Inflate(2131689493, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00031700 File Offset: 0x0002F900
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
			}
			else if (itemId == 2131362634 && this.animeList.Count<AnimeModel>() > 0)
			{
				if (this.loadAsGrid)
				{
					this.loadAsGrid = false;
					this.localMenu.FindItem(2131362634).SetIcon(2131231079);
				}
				else
				{
					this.loadAsGrid = true;
					this.localMenu.FindItem(2131362634).SetIcon(2131231104);
				}
				this.LoadAs(this.animeList);
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0003179C File Offset: 0x0002F99C
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok && requestCode == 1)
			{
				string stringExtra = data.GetStringExtra("FindMoreData");
				string stringExtra2 = data.GetStringExtra("FindMoreType");
				string stringExtra3 = data.GetStringExtra("DataTitle");
				if (stringExtra != null && stringExtra != "" && stringExtra != this.findMoreData)
				{
					this.findMoreData = stringExtra;
					this.findMoreType = stringExtra2;
					this.mFindMoreOf.Text = stringExtra3;
					this.mLoader.Visibility = ViewStates.Visible;
					this.recyclerView.Visibility = ViewStates.Gone;
					this.mOfflineView.Visibility = ViewStates.Gone;
					this.LoadFindMoreLists();
				}
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00031846 File Offset: 0x0002FA46
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			if (this.loadAsGrid)
			{
				this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 140f));
				this.recyclerView.SetLayoutManager(this.layoutManager);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000724 RID: 1828
		private UsersModel user;

		// Token: 0x04000725 RID: 1829
		private int userId;

		// Token: 0x04000726 RID: 1830
		private RelativeLayout mContent;

		// Token: 0x04000727 RID: 1831
		private WebClient client;

		// Token: 0x04000728 RID: 1832
		private Uri uri;

		// Token: 0x04000729 RID: 1833
		private NameValueCollection parameters;

		// Token: 0x0400072A RID: 1834
		private RecyclerView recyclerView;

		// Token: 0x0400072B RID: 1835
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x0400072C RID: 1836
		private AnimeCatalogGridAdapter adapterGrid;

		// Token: 0x0400072D RID: 1837
		private AnimeCatalogListAdapter adapterList;

		// Token: 0x0400072E RID: 1838
		private Animation hideLoader;

		// Token: 0x0400072F RID: 1839
		private Animation showLoader;

		// Token: 0x04000730 RID: 1840
		private List<AnimeModel> animeList;

		// Token: 0x04000731 RID: 1841
		private ProgressBar mLoader;

		// Token: 0x04000732 RID: 1842
		private RelativeLayout mOfflineView;

		// Token: 0x04000733 RID: 1843
		private Button mOfflineRetry;

		// Token: 0x04000734 RID: 1844
		private CardView mMoreLoader;

		// Token: 0x04000735 RID: 1845
		private RelativeLayout mEmptyView;

		// Token: 0x04000736 RID: 1846
		private ImageView mEmptyViewIcon;

		// Token: 0x04000737 RID: 1847
		private TextView mEmptyViewMessage;

		// Token: 0x04000738 RID: 1848
		private TextView mFindMoreOf;

		// Token: 0x04000739 RID: 1849
		private TextView mFindMoreOfTitle;

		// Token: 0x0400073A RID: 1850
		private string findMoreType;

		// Token: 0x0400073B RID: 1851
		private string findMoreData;

		// Token: 0x0400073C RID: 1852
		private string dataTitle;

		// Token: 0x0400073D RID: 1853
		private bool loadAsGrid = true;

		// Token: 0x0400073E RID: 1854
		private bool isReachedToEnd;

		// Token: 0x0400073F RID: 1855
		private bool isLoading;

		// Token: 0x04000740 RID: 1856
		private IMenu localMenu;

		// Token: 0x04000741 RID: 1857
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000742 RID: 1858
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
