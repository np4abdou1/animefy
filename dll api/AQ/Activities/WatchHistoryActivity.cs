using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Google.Android.Material.Snackbar;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000D2 RID: 210
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
	public class WatchHistoryActivity : AppCompatActivity
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x00038ACC File Offset: 0x00036CCC
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
			this.SupportActionBar.SetCustomView(2131558650);
			this.SetContentView(2131558448);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362462);
			this.mContent = base.FindViewById<RelativeLayout>(2131363076);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = base.FindViewById<CardView>(2131362463);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
			this.mEmptyViewIcon = base.FindViewById<ImageView>(2131362333);
			this.mEmptyViewIcon.SetImageResource(2131231085);
			this.mEmptyViewMessage = base.FindViewById<TextView>(2131362334);
			this.mEmptyViewMessage.Text = this.Resources.GetString(2131951982);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			if (this.userId == 0)
			{
				Bundle bundle = new Bundle();
				bundle.PutString("Message", this.Resources.GetString(2131951866));
				bundle.PutBoolean("IsOnCancelFinish", true);
				this.mLoginFrag = new DialogSigninPrompt();
				FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
				this.mLoginFrag.Arguments = bundle;
				this.mLoginFrag.Cancelable = false;
				this.mLoginFrag.Show(transaction, "DialogSigninPrompt");
			}
			else
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadHistory();
				});
			}
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00038D5C File Offset: 0x00036F5C
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1) && !this.IsLoadingMore && !this.IsClearTriggered && !this.IsItemRemoveTriggered)
			{
				this.IsLoadingMore = true;
				this.mMoreLoader.StartAnimation(this.showLoader);
				this.mMoreLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.HistoryLoadMore(this.mHistoryList.Count);
				});
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00038DC5 File Offset: 0x00036FC5
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadHistory();
			});
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00038DF4 File Offset: 0x00036FF4
		private void ClearAll()
		{
			WatchHistoryActivity.<ClearAll>d__27 <ClearAll>d__;
			<ClearAll>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ClearAll>d__.<>4__this = this;
			<ClearAll>d__.<>1__state = -1;
			<ClearAll>d__.<>t__builder.Start<WatchHistoryActivity.<ClearAll>d__27>(ref <ClearAll>d__);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00038E2C File Offset: 0x0003702C
		private void LoadHistory()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("library/history/history_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("From", 0.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				base.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						this.mHistoryList = JsonConvert.DeserializeObject<List<AnimeModelWithOtherData>>(@string);
						if (this.mHistoryList != null)
						{
							this.adapter = new WatchHistoryListAdapter(this, this.mHistoryList);
							this.adapter.ItemClick += this.Adapter_ItemClick;
							this.adapter.ItemDelete += this.Adapter_ItemDelete;
							this.layoutManager = new GridLayoutManager(this, 1);
							this.recyclerView.SetLayoutManager(this.layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
							if (this.mHistoryList.Count<AnimeModelWithOtherData>() <= 0)
							{
								this.mEmptyView.Visibility = ViewStates.Visible;
							}
							this.mLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mLoader.Visibility = ViewStates.Gone;
							this.mOfflineView.Visibility = ViewStates.Visible;
						}
					}
					catch
					{
						this.mLoader.Visibility = ViewStates.Gone;
						this.mOfflineView.Visibility = ViewStates.Visible;
					}
				});
			};
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00038EFC File Offset: 0x000370FC
		private void HistoryLoadMore(int from)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("library/history/history_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				base.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						List<AnimeModelWithOtherData> list = JsonConvert.DeserializeObject<List<AnimeModelWithOtherData>>(@string);
						if (list.Count != 0)
						{
							this.mHistoryList.AddRange(list);
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

		// Token: 0x06000A94 RID: 2708 RVA: 0x00038FCC File Offset: 0x000371CC
		private void Adapter_ItemDelete(object sender, int e)
		{
			AnimeModelWithOtherData item = this.mHistoryList[e];
			int itemPos = e;
			this.mHistoryList.Remove(item);
			this.adapter.NotifyItemRemoved(itemPos);
			if (this.mHistoryList.Count<AnimeModelWithOtherData>() <= 0)
			{
				this.mEmptyView.Visibility = ViewStates.Visible;
			}
			this.IsItemRemoveTriggered = true;
			Snackbar snackbar = CustomizedSnackbar.SnackBar(this.mContent, 2131952012, "");
			snackbar.SetAction(this.Resources.GetString(2131952546), delegate(View v)
			{
				this.mHistoryList.Insert(itemPos, item);
				this.adapter.NotifyItemInserted(itemPos);
				if (this.mHistoryList.Count<AnimeModelWithOtherData>() <= 0)
				{
					this.mEmptyView.Visibility = ViewStates.Visible;
				}
				else
				{
					this.mEmptyView.Visibility = ViewStates.Gone;
				}
				this.IsItemRemoveTriggered = false;
			}).Show();
			Task task = new Task(delegate()
			{
				this.ItemRemove(item.Anime.AnimeId, item.Episode.Episode);
			});
			task.Start();
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00039098 File Offset: 0x00037298
		private void ItemRemove(string animeId, float episode)
		{
			WatchHistoryActivity.<ItemRemove>d__31 <ItemRemove>d__;
			<ItemRemove>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemRemove>d__.<>4__this = this;
			<ItemRemove>d__.animeId = animeId;
			<ItemRemove>d__.episode = episode;
			<ItemRemove>d__.<>1__state = -1;
			<ItemRemove>d__.<>t__builder.Start<WatchHistoryActivity.<ItemRemove>d__31>(ref <ItemRemove>d__);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000390E0 File Offset: 0x000372E0
		private void Adapter_ItemClick(object sender, int e)
		{
			AnimeModelWithOtherData animeModelWithOtherData = this.mHistoryList[e];
			Intent intent = new Intent(Application.Context, typeof(ServersListActivity));
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

		// Token: 0x06000A97 RID: 2711 RVA: 0x000391E8 File Offset: 0x000373E8
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689506, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00039204 File Offset: 0x00037404
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 2131362625)
			{
				if (this.mHistoryList == null)
				{
					return true;
				}
				if (this.mHistoryList.Count<AnimeModelWithOtherData>() > 0)
				{
					LayoutInflater layoutInflater = LayoutInflater.From(this);
					View view = layoutInflater.Inflate(2131558618, null);
					view.FindViewById<TextView>(2131362279).Text = view.Resources.GetString(2131951862);
					Button button = view.FindViewById<Button>(2131362300);
					Button button2 = view.FindViewById<Button>(2131362263);
					AlertDialog.Builder builder = new AlertDialog.Builder(this);
					builder.SetView(view);
					builder.SetCancelable(true);
					AlertDialog dialog = builder.Create();
					dialog.Show();
					button.Click += delegate(object <p0>, EventArgs <p1>)
					{
						this.mHistoryListHelper = new List<AnimeModelWithOtherData>();
						foreach (AnimeModelWithOtherData item2 in this.mHistoryList)
						{
							this.mHistoryListHelper.Add(item2);
						}
						int count = this.mHistoryList.Count<AnimeModelWithOtherData>();
						this.IsClearTriggered = true;
						this.mHistoryList.RemoveRange(0, count);
						this.adapter.NotifyItemRangeRemoved(0, count);
						this.mEmptyView.Visibility = ViewStates.Visible;
						Snackbar snackbar = CustomizedSnackbar.SnackBar(this.mContent, 2131951683, "");
						snackbar.SetAction(this.Resources.GetString(2131952546), delegate(View v)
						{
							this.IsClearTriggered = false;
							this.mHistoryList.InsertRange(0, this.mHistoryListHelper);
							this.adapter.NotifyItemRangeInserted(0, count);
							this.mEmptyView.Visibility = ViewStates.Gone;
						}).Show();
						Task task = new Task(delegate()
						{
							this.ClearAll();
						});
						task.Start();
						dialog.Dismiss();
					};
					button2.Click += delegate(object <p0>, EventArgs <p1>)
					{
						dialog.Dismiss();
					};
				}
				else
				{
					CustomizedSnackbar.SnackBar(this.mContent, 2131952234, "").Show();
				}
				return true;
			}
			else
			{
				if (itemId == 16908332)
				{
					this.Finish();
					return true;
				}
				return base.OnOptionsItemSelected(item);
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00039326 File Offset: 0x00037526
		protected override void OnResume()
		{
			base.OnResume();
			if (UsersModel.OnResumeLogin && this.mLoginFrag != null)
			{
				this.mLoginFrag.Dismiss();
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadHistory();
				});
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x0400083A RID: 2106
		private UsersModel user;

		// Token: 0x0400083B RID: 2107
		private int userId;

		// Token: 0x0400083C RID: 2108
		private RecyclerView recyclerView;

		// Token: 0x0400083D RID: 2109
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x0400083E RID: 2110
		private WatchHistoryListAdapter adapter;

		// Token: 0x0400083F RID: 2111
		private List<AnimeModelWithOtherData> mHistoryList;

		// Token: 0x04000840 RID: 2112
		private List<AnimeModelWithOtherData> mHistoryListHelper;

		// Token: 0x04000841 RID: 2113
		private RelativeLayout mContent;

		// Token: 0x04000842 RID: 2114
		private ProgressBar mLoader;

		// Token: 0x04000843 RID: 2115
		private RelativeLayout mOfflineView;

		// Token: 0x04000844 RID: 2116
		private Button mOfflineRetry;

		// Token: 0x04000845 RID: 2117
		private CardView mMoreLoader;

		// Token: 0x04000846 RID: 2118
		private RelativeLayout mEmptyView;

		// Token: 0x04000847 RID: 2119
		private ImageView mEmptyViewIcon;

		// Token: 0x04000848 RID: 2120
		private TextView mEmptyViewMessage;

		// Token: 0x04000849 RID: 2121
		private WebClient mClient;

		// Token: 0x0400084A RID: 2122
		private Uri mUri;

		// Token: 0x0400084B RID: 2123
		private NameValueCollection parameters;

		// Token: 0x0400084C RID: 2124
		private Animation hideLoader;

		// Token: 0x0400084D RID: 2125
		private Animation showLoader;

		// Token: 0x0400084E RID: 2126
		private DialogSigninPrompt mLoginFrag;

		// Token: 0x0400084F RID: 2127
		private bool IsClearTriggered;

		// Token: 0x04000850 RID: 2128
		private bool IsItemRemoveTriggered;

		// Token: 0x04000851 RID: 2129
		private bool IsLoadingMore;
	}
}
