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
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Firebase.Messaging;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000CA RID: 202
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class LatestEpisodesActivity : AppCompatActivity
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x0003212C File Offset: 0x0003032C
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
			this.SupportActionBar.SetCustomView(2131558644);
			this.SetContentView(2131558451);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362536);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = base.FindViewById<CardView>(2131362531);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.swipeContainer = base.FindViewById<SwipeRefreshLayout>(2131362533);
			this.swipeContainer.Refresh += this.SwipeContainer_Refresh;
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
			this.mEmptyViewIcon = base.FindViewById<ImageView>(2131362333);
			this.mEmptyViewIcon.SetImageResource(2131231021);
			this.mEmptyViewMessage = base.FindViewById<TextView>(2131362334);
			this.mEmptyViewMessage.Text = this.Resources.GetString(2131952028);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mLatestUploadsList = new List<AnimeModelWithOtherData>();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatestUploads(false, 0);
			});
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00032364 File Offset: 0x00030564
		public static int CalculateNumberOfColumns(Context context, float columnWidthDp)
		{
			DisplayMetrics displayMetrics = context.Resources.DisplayMetrics;
			float num = (float)displayMetrics.WidthPixels / displayMetrics.Density;
			return (int)((double)(num / columnWidthDp) + 0.5);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000323A0 File Offset: 0x000305A0
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1))
			{
				if (!this.isLoading)
				{
					this.isLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadLatestUploads(true, this.mLatestUploadsList.Count);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00032415 File Offset: 0x00030615
		private void SwipeContainer_Refresh(object sender, EventArgs e)
		{
			AnimeModel.IsAnimationAllowed = false;
			this.isLoading = true;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatestUploads(false, 0);
			});
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0003244E File Offset: 0x0003064E
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689507, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00032468 File Offset: 0x00030668
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatestUploads(false, 0);
			});
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00032494 File Offset: 0x00030694
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId == 2131362650)
			{
				this.swipeContainer.Refreshing = true;
				AnimeModel.IsAnimationAllowed = false;
				this.mOfflineView.Visibility = ViewStates.Gone;
				this.mLoader.Visibility = ViewStates.Gone;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadLatestUploads(false, 0);
				});
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00032504 File Offset: 0x00030704
		private void LoadLatestUploads(bool loadMore = false, int from = 0)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("episodes/load_latest_episodes.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				this.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						List<AnimeModelWithOtherData> collection = JsonConvert.DeserializeObject<List<AnimeModelWithOtherData>>(@string);
						if (loadMore)
						{
							this.mLatestUploadsList.AddRange(collection);
							this.adapter.NotifyDataSetChanged();
							this.mMoreLoader.StartAnimation(this.hideLoader);
							this.mMoreLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mLatestUploadsList.Clear();
							this.mLatestUploadsList.AddRange(collection);
							this.adapter = new LatestEpisodesListAdapter(this, this.mLatestUploadsList);
							this.adapter.ItemClick += this.Adapter_ItemClick;
							this.adapter.HomeClick += this.Adapter_HomeClick;
							this.adapter.CommentsClick += this.Adapter_CommentsClick;
							this.adapter.NotificationClick += this.Adapter_NotificationClick;
							this.layoutManager = new GridLayoutManager(this, LatestEpisodesActivity.CalculateNumberOfColumns(this, 400f));
							this.recyclerView.SetLayoutManager(this.layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
							if (this.mLatestUploadsList.Count<AnimeModelWithOtherData>() == 0)
							{
								this.mEmptyView.Visibility = ViewStates.Visible;
							}
							this.mLoader.Visibility = ViewStates.Gone;
							this.recyclerView.Visibility = ViewStates.Visible;
							this.swipeContainer.Refreshing = false;
						}
						this.isLoading = false;
					}
					catch
					{
						this.isLoading = false;
						this.swipeContainer.Refreshing = false;
						this.mLoader.Visibility = ViewStates.Gone;
						this.mOfflineView.Visibility = ViewStates.Visible;
						this.recyclerView.Visibility = ViewStates.Gone;
					}
				});
			};
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000325E8 File Offset: 0x000307E8
		private void Adapter_NotificationClick(object sender, int e)
		{
			AnimeModelWithOtherData animeModelWithOtherData = this.mLatestUploadsList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362532);
			if (animeModelWithOtherData.Anime.Status == "AIRED")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131951693), 0);
				return;
			}
			if (NotificationsViewModel.IsNotifExist(animeModelWithOtherData.Anime.AnimeId))
			{
				imageView.SetImageResource(2131231140);
				FirebaseMessaging.Instance.UnsubscribeFromTopic(animeModelWithOtherData.Anime.AnimeId);
				NotificationsViewModel.DelNotif(animeModelWithOtherData.Anime.AnimeId);
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131951927) + " " + animeModelWithOtherData.Anime.EN_Title, 2131231141);
				return;
			}
			imageView.SetImageResource(2131231142);
			FirebaseMessaging.Instance.SubscribeToTopic(animeModelWithOtherData.Anime.AnimeId);
			NotificationsViewModel.InitializeNewNotif(animeModelWithOtherData.Anime.AnimeId, animeModelWithOtherData.Anime.EN_Title, animeModelWithOtherData.Anime.Episodes);
			CustomizedToast.ShowToast(this, this.Resources.GetString(2131951928) + " " + animeModelWithOtherData.Anime.EN_Title, 2131231141);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0003273C File Offset: 0x0003093C
		private void Adapter_CommentsClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LatestEpisodesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModelWithOtherData animeModelWithOtherData = this.mLatestUploadsList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", animeModelWithOtherData.Anime.AnimeId);
			bundle.PutString("CommType", "Episode");
			bundle.PutFloat("Episode", animeModelWithOtherData.Episode.Episode);
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000327E0 File Offset: 0x000309E0
		private void Adapter_HomeClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LatestEpisodesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModelWithOtherData animeModelWithOtherData = this.mLatestUploadsList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView sharedElement = itemView.FindViewById<ImageView>(2131361956);
			Intent intent = new Intent(Application.Context, typeof(AnimeDetails));
			intent.PutExtra("AnimeId", animeModelWithOtherData.Anime.AnimeId);
			intent.PutExtra("ENTitle", animeModelWithOtherData.Anime.EN_Title);
			intent.PutExtra("JPTitle", animeModelWithOtherData.Anime.JP_Title);
			intent.PutExtra("ARTitle", animeModelWithOtherData.Anime.AR_Title);
			intent.PutExtra("Synonyms", animeModelWithOtherData.Anime.Synonyms);
			intent.PutExtra("Tags", animeModelWithOtherData.Anime.Tags);
			intent.PutExtra("Genres", animeModelWithOtherData.Anime.Genres);
			intent.PutExtra("Season", animeModelWithOtherData.Anime.Season);
			intent.PutExtra("Duration", animeModelWithOtherData.Anime.Duration);
			intent.PutExtra("Premiered", animeModelWithOtherData.Anime.Premiered);
			intent.PutExtra("Aired", animeModelWithOtherData.Anime.Aired);
			intent.PutExtra("Broadcast", animeModelWithOtherData.Anime.Broadcast);
			intent.PutExtra("Thumbnail", Constants.Thumbnails(animeModelWithOtherData.Anime.Thumbnail));
			intent.PutExtra("Trailer", animeModelWithOtherData.Anime.Trailer);
			intent.PutExtra("YTTrailer", animeModelWithOtherData.Anime.YTTrailer);
			intent.PutExtra("Creators", animeModelWithOtherData.Anime.Creators);
			intent.PutExtra("Status", animeModelWithOtherData.Anime.Status);
			intent.PutExtra("Episodes", animeModelWithOtherData.Anime.Episodes);
			intent.PutExtra("Score", animeModelWithOtherData.Anime.Score);
			intent.PutExtra("Rank", animeModelWithOtherData.Anime.Rank);
			intent.PutExtra("Popularity", animeModelWithOtherData.Anime.Popularity);
			intent.PutExtra("Rating", animeModelWithOtherData.Anime.Rating);
			intent.PutExtra("RelationId", animeModelWithOtherData.Anime.RelationId);
			intent.PutExtra("MalId", animeModelWithOtherData.Anime.MalId);
			intent.PutExtra("Type", animeModelWithOtherData.Anime.Type);
			intent.PutExtra("ItemPosition", e);
			intent.PutExtra("Transition", this.isLoading);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00032AFC File Offset: 0x00030CFC
		private void Adapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LatestEpisodesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModelWithOtherData animeModelWithOtherData = this.mLatestUploadsList[e];
			Intent intent = new Intent(this, typeof(ServersListActivity));
			intent.PutExtra("AnimeId", animeModelWithOtherData.Anime.AnimeId);
			intent.PutExtra("AnimeTitle", animeModelWithOtherData.Anime.EN_Title);
			intent.PutExtra("AnimeType", animeModelWithOtherData.Anime.Type);
			intent.PutExtra("Episode", animeModelWithOtherData.Episode.Episode);
			intent.PutExtra("ExtraEpisodes", animeModelWithOtherData.Episode.ExtraEpisodes);
			intent.PutExtra("EpisodeType", animeModelWithOtherData.Episode.Type);
			intent.PutExtra("MarkedAs", animeModelWithOtherData.Episode.MarkedAs);
			this.StartActivity(intent);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") != "OFF")
			{
				WatchHistoryViewModel.AddLocaleHistory(animeModelWithOtherData.Episode.AnimeID, animeModelWithOtherData.Episode.Episode);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00032C1D File Offset: 0x00030E1D
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			this.layoutManager = new GridLayoutManager(this, LatestEpisodesActivity.CalculateNumberOfColumns(this, 350f));
			this.recyclerView.SetLayoutManager(this.layoutManager);
			base.OnConfigurationChanged(newConfig);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000752 RID: 1874
		private UsersModel user;

		// Token: 0x04000753 RID: 1875
		private int userId;

		// Token: 0x04000754 RID: 1876
		private RecyclerView recyclerView;

		// Token: 0x04000755 RID: 1877
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x04000756 RID: 1878
		private LatestEpisodesListAdapter adapter;

		// Token: 0x04000757 RID: 1879
		private List<AnimeModelWithOtherData> mLatestUploadsList;

		// Token: 0x04000758 RID: 1880
		private bool isLoading = true;

		// Token: 0x04000759 RID: 1881
		private RelativeLayout mEmptyView;

		// Token: 0x0400075A RID: 1882
		private ImageView mEmptyViewIcon;

		// Token: 0x0400075B RID: 1883
		private TextView mEmptyViewMessage;

		// Token: 0x0400075C RID: 1884
		private ProgressBar mLoader;

		// Token: 0x0400075D RID: 1885
		private RelativeLayout mOfflineView;

		// Token: 0x0400075E RID: 1886
		private Button mOfflineRetry;

		// Token: 0x0400075F RID: 1887
		private CardView mMoreLoader;

		// Token: 0x04000760 RID: 1888
		private SwipeRefreshLayout swipeContainer;

		// Token: 0x04000761 RID: 1889
		private WebClient mClient;

		// Token: 0x04000762 RID: 1890
		private Uri mUri;

		// Token: 0x04000763 RID: 1891
		private NameValueCollection parameters;

		// Token: 0x04000764 RID: 1892
		private Animation hideLoader;

		// Token: 0x04000765 RID: 1893
		private Animation showLoader;

		// Token: 0x04000766 RID: 1894
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000767 RID: 1895
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
