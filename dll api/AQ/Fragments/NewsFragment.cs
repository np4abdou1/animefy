using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Gms.Ads;
using Android.Gms.Ads.Rewarded;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
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
using Java.Interop;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A7 RID: 167
	public class NewsFragment : AndroidX.Fragment.App.Fragment
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x0001C280 File Offset: 0x0001A480
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558455, container, false);
			this.recyclerView = this.view.FindViewById<RecyclerView>(2131362785);
			this.mLoader = this.view.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = this.view.FindViewById<CardView>(2131362773);
			this.mNoNews = this.view.FindViewById<TextView>(2131362792);
			this.mOfflineView = this.view.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = this.view.FindViewById<Button>(2131362815);
			this.swipeRefresh = this.view.FindViewById<SwipeRefreshLayout>(2131362786);
			this.hideLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadNews();
			});
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.swipeRefresh.Refresh += this.SwipeRefresh_Refresh;
			return this.view;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001C3CD File Offset: 0x0001A5CD
		private void SwipeRefresh_Refresh(object sender, EventArgs e)
		{
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadNews();
			});
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001C3F0 File Offset: 0x0001A5F0
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1) && !this.IsLoadingMore)
			{
				this.IsLoadingMore = true;
				this.mMoreLoader.StartAnimation(this.showLoader);
				this.mMoreLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadMoreNews(this.mNewsList.Count);
				});
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001C449 File Offset: 0x0001A649
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadNews();
			});
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001C478 File Offset: 0x0001A678
		private void LoadNews()
		{
			this.mClient = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("news/load_news.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("Language", base.Resources.GetString(2131951706));
			nameValueCollection.Add("From", 0.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.uri, nameValueCollection);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mNewsList = JsonConvert.DeserializeObject<List<NewsModel>>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						this.adapter = new NewsListAdapter(this.view.Context, this.mNewsList);
						this.adapter.ItemClick += this.Adapter_ItemClick;
						this.adapter.ItemEditorPhotoClick += this.Adapter_ItemEditorPhotoClick;
						this.adapter.ItemShareClick += this.Adapter_ItemShareClick;
						this.adapter.ItemRelatedClick += this.Adapter_ItemRelatedClick;
						this.adapter.ItemCommentsClick += this.Adapter_ItemCommentsClick;
						NewsModel.CurrentNewsScreenWidthRows = Calculators.CalculateNumberOfColumns(this.view.Context, 400f);
						this.layoutManager = new GridLayoutManager(this.view.Context, NewsModel.CurrentNewsScreenWidthRows);
						this.recyclerView.SetLayoutManager(this.layoutManager);
						this.recyclerView.SetAdapter(this.adapter);
						if (this.mNewsList.Count == 0)
						{
							this.mNoNews.Visibility = ViewStates.Visible;
						}
						this.swipeRefresh.Refreshing = false;
						this.mLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.swipeRefresh.Refreshing = false;
						this.mLoader.Visibility = ViewStates.Gone;
						this.mOfflineView.Visibility = ViewStates.Visible;
					});
				}
			};
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001C514 File Offset: 0x0001A714
		private void Adapter_ItemCommentsClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < NewsFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.mNewsList[e].ID.ToString());
			bundle.PutString("CommType", NewsModel.News);
			Comments comments = new Comments();
			FragmentTransaction transaction = base.FragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		private void Adapter_ItemRelatedClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < NewsFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			if (this.mNewsList[e].RelationId == "")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952224), 0);
				return;
			}
			Bundle bundle = new Bundle();
			bundle.PutString("RelatedId", this.mNewsList[e].RelationId);
			RelatedAnimeSheet relatedAnimeSheet = new RelatedAnimeSheet();
			FragmentTransaction transaction = base.FragmentManager.BeginTransaction();
			relatedAnimeSheet.Arguments = bundle;
			relatedAnimeSheet.Show(transaction, "RelatedAnimeSheet");
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0001C654 File Offset: 0x0001A854
		private void Adapter_ItemShareClick(object sender, int e)
		{
			Intent intent = new Intent("android.intent.action.SEND");
			intent.PutExtra("android.intent.extra.TITLE", base.Resources.GetString(2131952114));
			intent.PutExtra("android.intent.extra.SUBJECT", base.Resources.GetString(2131952114) + " " + base.Resources.GetString(2131951707));
			intent.PutExtra("android.intent.extra.TEXT", string.Concat(new string[]
			{
				base.Resources.GetString(2131952114),
				": ",
				this.mNewsList[e].Title,
				" ",
				SharedPreferencesSaves.StringSharedPreferencesGet("WebsiteUrl")
			}));
			intent.SetType("text/plain");
			this.StartActivity(Intent.CreateChooser(intent, base.Resources.GetString(2131952394)));
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0001C744 File Offset: 0x0001A944
		private void Adapter_ItemEditorPhotoClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < NewsFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			NewsModel newsModel = this.mNewsList[e];
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

		// Token: 0x06000795 RID: 1941 RVA: 0x0001C878 File Offset: 0x0001AA78
		private void LoadMoreNews(int from = 0)
		{
			this.mClient = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("news/load_news.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("Language", base.Resources.GetString(2131951706));
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.uri, nameValueCollection);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				base.Activity.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						List<NewsModel> list = JsonConvert.DeserializeObject<List<NewsModel>>(@string);
						if (list.Count != 0)
						{
							this.mNewsList.AddRange(list);
							this.adapter.NotifyDataSetChanged();
						}
						this.IsLoadingMore = false;
						this.mMoreLoader.StartAnimation(this.hideLoader);
						this.mMoreLoader.Visibility = ViewStates.Gone;
					}
					catch
					{
						this.IsLoadingMore = false;
						this.mMoreLoader.StartAnimation(this.hideLoader);
						this.mMoreLoader.Visibility = ViewStates.Gone;
					}
				});
			};
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001C914 File Offset: 0x0001AB14
		private void Adapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < NewsFragment.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			this.GoToNewContent(this.mNewsList[e], e);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001C954 File Offset: 0x0001AB54
		private void GoToNewContent(NewsModel item, int itemPosition)
		{
			this.newsViewingCounter++;
			if (this.newsViewingCounter - this.lastAdShowenOn == SharedPreferencesSaves.IntSharedPreferencesGet("GoogleAds"))
			{
				this.adRewardRecieved = false;
				this.lastAdShowenOn = this.newsViewingCounter;
			}
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(itemPosition).ItemView;
			ImageView sharedElement = itemView.FindViewById<ImageView>(2131362780);
			Intent intent = new Intent(Application.Context, typeof(NewContentActivity));
			intent.PutExtra("NewId", item.ID);
			intent.PutExtra("NewTitle", item.Title);
			intent.PutExtra("RelatedAnimeId", item.RelationId);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, sharedElement, "newthumbnail");
				this.StartActivity(intent, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivity(intent);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001CA34 File Offset: 0x0001AC34
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			this.layoutManager = new GridLayoutManager(this.view.Context, Calculators.CalculateNumberOfColumns(this.view.Context, 400f));
			this.recyclerView.SetLayoutManager(this.layoutManager);
			base.OnConfigurationChanged(newConfig);
		}

		// Token: 0x04000472 RID: 1138
		private View view;

		// Token: 0x04000473 RID: 1139
		private WebClient mClient;

		// Token: 0x04000474 RID: 1140
		private Uri uri;

		// Token: 0x04000475 RID: 1141
		private RecyclerView recyclerView;

		// Token: 0x04000476 RID: 1142
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x04000477 RID: 1143
		private NewsListAdapter adapter;

		// Token: 0x04000478 RID: 1144
		private List<NewsModel> mNewsList;

		// Token: 0x04000479 RID: 1145
		private SwipeRefreshLayout swipeRefresh;

		// Token: 0x0400047A RID: 1146
		private RelativeLayout mOfflineView;

		// Token: 0x0400047B RID: 1147
		private ProgressBar mLoader;

		// Token: 0x0400047C RID: 1148
		private Button mOfflineRetry;

		// Token: 0x0400047D RID: 1149
		private CardView mMoreLoader;

		// Token: 0x0400047E RID: 1150
		private TextView mNoNews;

		// Token: 0x0400047F RID: 1151
		private Animation hideLoader;

		// Token: 0x04000480 RID: 1152
		private Animation showLoader;

		// Token: 0x04000481 RID: 1153
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000482 RID: 1154
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x04000483 RID: 1155
		private bool IsLoadingMore;

		// Token: 0x04000484 RID: 1156
		private bool adRewardRecieved;

		// Token: 0x04000485 RID: 1157
		private int newsViewingCounter;

		// Token: 0x04000486 RID: 1158
		private int lastAdShowenOn;

		// Token: 0x02000134 RID: 308
		private class UserEarnedRewardListener : Java.Lang.Object, IOnUserEarnedRewardListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BA7 RID: 2983 RVA: 0x0003E9EA File Offset: 0x0003CBEA
			public UserEarnedRewardListener(NewsFragment context, NewsModel item, int itemPosition)
			{
				this.context = context;
				this.item = item;
				this.itemPosition = itemPosition;
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x0003EA07 File Offset: 0x0003CC07
			public void OnUserEarnedReward(IRewardItem p0)
			{
				this.context.adRewardRecieved = true;
				this.context.GoToNewContent(this.item, this.itemPosition);
			}

			// Token: 0x0400308C RID: 12428
			private NewsFragment context;

			// Token: 0x0400308D RID: 12429
			private NewsModel item;

			// Token: 0x0400308E RID: 12430
			private int itemPosition;
		}
	}
}
