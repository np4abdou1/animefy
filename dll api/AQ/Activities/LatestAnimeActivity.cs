using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
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
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Firebase.Messaging;
using Google.Android.Material.Snackbar;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000C9 RID: 201
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class LatestAnimeActivity : AppCompatActivity
	{
		// Token: 0x060009B2 RID: 2482 RVA: 0x000318C4 File Offset: 0x0002FAC4
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
			this.SupportActionBar.SetCustomView(2131558643);
			this.SetContentView(2131558450);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mLatestUploadsList = new List<AnimeModel>();
			this.newCount = this.Intent.GetIntExtra("NewCount", 0);
			if (this.newCount < 0)
			{
				this.newCount = 0;
			}
			this.recyclerView = base.FindViewById<RecyclerView>(2131362536);
			this.swipeContainer = base.FindViewById<SwipeRefreshLayout>(2131362537);
			this.mMoreLoader = base.FindViewById<CardView>(2131362535);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatests(0, false);
			});
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.swipeContainer.Refresh += this.SwipeContainer_Refresh;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00031A8C File Offset: 0x0002FC8C
		private void SwipeContainer_Refresh(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatests(0, false);
			});
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00031AA0 File Offset: 0x0002FCA0
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
						this.LoadLatests(this.mLatestUploadsList.Count, true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00031B18 File Offset: 0x0002FD18
		private void LoadLatests(int from = 0, bool loadMore = false)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("anime/load_latest_anime.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"From",
					from.ToString()
				},
				{
					"Language",
					this.Resources.GetString(2131951706)
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			WaitCallback <>9__3;
			Action<View> <>9__2;
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				this.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						List<AnimeModel> collection = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
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
							this.adapter = new AnimeCatalogListAdapter(this, this.mLatestUploadsList, false);
							this.adapter.ItemClick += this.AdapterAnime_ItemClick;
							this.adapter.ItemPlotClick += this.Adapter_ItemPlotClick;
							this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 350f));
							this.recyclerView.SetLayoutManager(this.layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
							this.mLoader.Visibility = ViewStates.Gone;
							this.recyclerView.Visibility = ViewStates.Visible;
						}
						this.isLoading = false;
						this.swipeContainer.Refreshing = false;
					}
					catch
					{
						if (loadMore)
						{
							this.isLoading = false;
							this.mMoreLoader.StartAnimation(this.hideLoader);
							this.mMoreLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mLoader.Visibility = ViewStates.Gone;
							this.isLoading = false;
							this.swipeContainer.Refreshing = false;
							Snackbar snackbar = Snackbar.Make(this.mLoader, 2131951821, -2);
							Snackbar snackbar2 = snackbar;
							int resId = 2131952343;
							Action<View> clickHandler;
							if ((clickHandler = <>9__2) == null)
							{
								clickHandler = (<>9__2 = delegate(View v)
								{
									this.mLoader.Visibility = ViewStates.Visible;
									WaitCallback callBack;
									if ((callBack = <>9__3) == null)
									{
										callBack = (<>9__3 = delegate(object o)
										{
											this.LoadLatests(0, false);
										});
									}
									ThreadPool.QueueUserWorkItem(callBack);
								});
							}
							snackbar2.SetAction(resId, clickHandler).Show();
						}
					}
				});
			};
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00031BC4 File Offset: 0x0002FDC4
		private void Adapter_ItemPlotClick(object sender, int e)
		{
			AnimeModel animeModel = this.mLatestUploadsList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "DialogDescription");
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00031C50 File Offset: 0x0002FE50
		private void AdapterAnime_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LatestAnimeActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.mLatestUploadsList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
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

		// Token: 0x060009B8 RID: 2488 RVA: 0x00031EF4 File Offset: 0x000300F4
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00031F3C File Offset: 0x0003013C
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId == 2131362635)
			{
				if (SharedPreferencesSaves.StringSharedPreferencesGet("LatestAnimeNotifications") == "ON")
				{
					item.SetIcon(2131231141);
					FirebaseMessaging.Instance.UnsubscribeFromTopic("LatestAnime");
					SharedPreferencesSaves.StringSharedPreferencesSave("LatestAnimeNotifications", "OFF");
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951927) + " " + this.Resources.GetString(2131952029), 2131231141);
				}
				else
				{
					item.SetIcon(2131231143);
					FirebaseMessaging.Instance.SubscribeToTopic("LatestAnime");
					SharedPreferencesSaves.StringSharedPreferencesSave("LatestAnimeNotifications", "ON");
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951928) + " " + this.Resources.GetString(2131952029), 2131231141);
				}
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0003204C File Offset: 0x0003024C
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689495, menu);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("LatestAnimeNotifications") == "ON")
			{
				menu.FindItem(2131362635).SetIcon(2131231143);
			}
			else
			{
				menu.FindItem(2131362635).SetIcon(2131231141);
			}
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000320B5 File Offset: 0x000302B5
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 350f));
			this.recyclerView.SetLayoutManager(this.layoutManager);
			base.OnConfigurationChanged(newConfig);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000743 RID: 1859
		private UsersModel user;

		// Token: 0x04000744 RID: 1860
		private int userId;

		// Token: 0x04000745 RID: 1861
		private RecyclerView recyclerView;

		// Token: 0x04000746 RID: 1862
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x04000747 RID: 1863
		private AnimeCatalogListAdapter adapter;

		// Token: 0x04000748 RID: 1864
		private List<AnimeModel> mLatestUploadsList;

		// Token: 0x04000749 RID: 1865
		private ProgressBar mLoader;

		// Token: 0x0400074A RID: 1866
		private CardView mMoreLoader;

		// Token: 0x0400074B RID: 1867
		private SwipeRefreshLayout swipeContainer;

		// Token: 0x0400074C RID: 1868
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x0400074D RID: 1869
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x0400074E RID: 1870
		private Animation hideLoader;

		// Token: 0x0400074F RID: 1871
		private Animation showLoader;

		// Token: 0x04000750 RID: 1872
		private bool isLoading = true;

		// Token: 0x04000751 RID: 1873
		private int newCount;
	}
}
