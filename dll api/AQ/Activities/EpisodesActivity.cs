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
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000C3 RID: 195
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class EpisodesActivity : AppCompatActivity
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x0002DFDC File Offset: 0x0002C1DC
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
			this.SetContentView(2131558442);
			this.mAnimeId = this.Intent.GetStringExtra("AnimeId");
			this.mAnimeTitle = this.Intent.GetStringExtra("Title");
			this.mAnimeType = this.Intent.GetStringExtra("Type");
			this.IsNotification = this.Intent.GetBooleanExtra("IsNotification", false);
			this.IsScrollNeeded = this.Intent.GetBooleanExtra("ScrollToEnd", false);
			if (this.mAnimeType == "MOVIE")
			{
				this.SupportActionBar.Title = this.mAnimeTitle + " " + this.Resources.GetString(2131952282);
			}
			else
			{
				this.SupportActionBar.Title = this.mAnimeTitle + " " + this.Resources.GetString(2131951899);
			}
			this.recyclerView = base.FindViewById<RecyclerView>(2131362353);
			this.gotoEpisodeEditText = base.FindViewById<EditText>(2131362351);
			this.gotoEpisodeParent = base.FindViewById<LinearLayout>(2131362352);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mNoEpisodes = base.FindViewById<TextView>(2131362791);
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.ListEpisodes();
			});
			this.gotoEpisodeEditText.TextChanged += this.GotoEpisodeEditText_TextChanged;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0002E210 File Offset: 0x0002C410
		private void GotoEpisodeEditText_TextChanged(object sender, TextChangedEventArgs e)
		{
			string episode = this.gotoEpisodeEditText.Text;
			int num;
			if (int.TryParse(episode, out num))
			{
				this.recyclerView.ScrollToPosition(this.mEpisodesList.FindIndex((EpisodeModel p) => p.Episode == (float)int.Parse(episode) || p.ExtraEpisodes.Contains(episode)));
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0002E265 File Offset: 0x0002C465
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.ListEpisodes();
			});
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002E291 File Offset: 0x0002C491
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689505, menu);
			return true;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId != 2131362645)
			{
				return true;
			}
			if (this.mEpisodesList != null)
			{
				int num = this.mEpisodesList.Count<EpisodeModel>() - 1;
				if (!this.IsDescendingOrder)
				{
					item.SetIcon(2131230963);
					if (num <= 50)
					{
						this.recyclerView.SmoothScrollToPosition(num);
					}
					else
					{
						this.recyclerView.ScrollToPosition(num);
					}
					this.IsDescendingOrder = true;
				}
				else
				{
					item.SetIcon(2131230958);
					if (num <= 50)
					{
						this.recyclerView.SmoothScrollToPosition(0);
					}
					else
					{
						this.recyclerView.ScrollToPosition(0);
					}
					this.IsDescendingOrder = false;
				}
			}
			return true;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002E360 File Offset: 0x0002C560
		private void SwipeContainer_Refresh(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.ListEpisodes();
			});
			(sender as SwipeRefreshLayout).Refreshing = false;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002E398 File Offset: 0x0002C598
		private void ListEpisodes()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("episodes/load_episodes.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("AnimeID", this.mAnimeId);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += this.client_UploadValuesCompleted;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002E42C File Offset: 0x0002C62C
		private void client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
		{
			base.RunOnUiThread(delegate()
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mEpisodesList = JsonConvert.DeserializeObject<List<EpisodeModel>>(@string);
					this.adapter = new EpisodesListAdapter(this, this.mEpisodesList, this.mAnimeType);
					this.adapter.ItemClick += this.Adapter_ItemClick;
					this.adapter.ViewClick += this.Adapter_ViewClick;
					this.adapter.CommentsClick += this.Adapter_CommentsClick;
					this.layoutManager = new GridLayoutManager(this, 1);
					this.recyclerView.SetLayoutManager(this.layoutManager);
					this.recyclerView.SetAdapter(this.adapter);
					this.mLoader.Visibility = ViewStates.Gone;
					if (this.mEpisodesList.Count == 0)
					{
						this.mNoEpisodes.Text = this.Resources.GetString(2131952231);
						this.mNoEpisodes.Visibility = ViewStates.Visible;
					}
					int num = this.mEpisodesList.Count<EpisodeModel>() - 1;
					if (num > 40)
					{
						this.gotoEpisodeParent.Visibility = ViewStates.Visible;
					}
					if ((this.IsNotification || this.IsScrollNeeded) && !this.IsDescendingOrder)
					{
						if (num <= 50)
						{
							this.recyclerView.SmoothScrollToPosition(num);
						}
						else
						{
							this.recyclerView.ScrollToPosition(num);
						}
						this.IsDescendingOrder = true;
					}
				}
				catch
				{
					this.mOfflineView.Visibility = ViewStates.Visible;
					this.mLoader.Visibility = ViewStates.Gone;
				}
			});
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0002E460 File Offset: 0x0002C660
		private void Adapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < EpisodesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			EpisodeModel episodeModel = this.mEpisodesList[e];
			Intent intent = new Intent(this, typeof(ServersListActivity));
			intent.PutExtra("AnimeId", this.mAnimeId);
			intent.PutExtra("AnimeTitle", this.mAnimeTitle);
			intent.PutExtra("AnimeType", this.mAnimeType);
			intent.PutExtra("Episode", episodeModel.Episode);
			intent.PutExtra("ExtraEpisodes", episodeModel.ExtraEpisodes);
			intent.PutExtra("EpisodeType", episodeModel.Type);
			intent.PutExtra("MarkedAs", episodeModel.MarkedAs);
			this.StartActivity(intent);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AutoMarkAsWatched") != "OFF")
			{
				WatchHistoryViewModel.AddLocaleHistory(episodeModel.AnimeID, episodeModel.Episode);
				this.adapter.NotifyItemChanged(e);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002E560 File Offset: 0x0002C760
		private void Adapter_CommentsClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < EpisodesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			EpisodeModel episodeModel = this.mEpisodesList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.mAnimeId);
			bundle.PutString("CommType", "Episode");
			bundle.PutFloat("Episode", episodeModel.Episode);
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		private void Adapter_ViewClick(object sender, int e)
		{
			EpisodeModel episodeModel = this.mEpisodesList[e];
			WatchHistoryViewModel.AddLocaleHistory(episodeModel.AnimeID, episodeModel.Episode);
			this.adapter.NotifyItemChanged(e);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0002E62F File Offset: 0x0002C82F
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			if (this.adapter != null)
			{
				this.adapter.NotifyDataSetChanged();
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x040006BB RID: 1723
		private RecyclerView recyclerView;

		// Token: 0x040006BC RID: 1724
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x040006BD RID: 1725
		private EpisodesListAdapter adapter;

		// Token: 0x040006BE RID: 1726
		private EditText gotoEpisodeEditText;

		// Token: 0x040006BF RID: 1727
		private LinearLayout gotoEpisodeParent;

		// Token: 0x040006C0 RID: 1728
		private List<EpisodeModel> mEpisodesList;

		// Token: 0x040006C1 RID: 1729
		private WebClient mClient;

		// Token: 0x040006C2 RID: 1730
		private Uri mUri;

		// Token: 0x040006C3 RID: 1731
		private NameValueCollection parameters;

		// Token: 0x040006C4 RID: 1732
		private TextView mNoEpisodes;

		// Token: 0x040006C5 RID: 1733
		private ProgressBar mLoader;

		// Token: 0x040006C6 RID: 1734
		private RelativeLayout mOfflineView;

		// Token: 0x040006C7 RID: 1735
		private Button mOfflineRetry;

		// Token: 0x040006C8 RID: 1736
		private string mAnimeId;

		// Token: 0x040006C9 RID: 1737
		private string mAnimeTitle;

		// Token: 0x040006CA RID: 1738
		private string mAnimeType;

		// Token: 0x040006CB RID: 1739
		private bool IsNotification;

		// Token: 0x040006CC RID: 1740
		private bool IsScrollNeeded;

		// Token: 0x040006CD RID: 1741
		private bool IsDescendingOrder;

		// Token: 0x040006CE RID: 1742
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x040006CF RID: 1743
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
