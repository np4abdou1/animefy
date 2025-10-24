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
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.CardView.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Util;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Com.Wang.Avi;
using Firebase.Messaging;
using Google.Android.Material.AppBar;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000C2 RID: 194
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class CharactersActivity : AppCompatActivity
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		protected override void OnCreate(Bundle savedInstanceState)
		{
			string a = SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme");
			if (!(a == "BLUE"))
			{
				if (!(a == "PINK"))
				{
					if (!(a == "LIGHT_GRAY"))
					{
						this.SetTheme(2132017173);
					}
					else
					{
						this.SetTheme(2132017176);
					}
				}
				else
				{
					this.SetTheme(2132017179);
				}
			}
			else
			{
				this.SetTheme(2132017170);
			}
			base.OnCreate(savedInstanceState);
			this.SetContentView(2131558437);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			Toolbar supportActionBar = base.FindViewById<Toolbar>(2131363160);
			this.SetSupportActionBar(supportActionBar);
			this.SupportActionBar.SetTitle(2131952099);
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			CollapsingToolbarLayout collapsingToolbarLayout = base.FindViewById<CollapsingToolbarLayout>(2131363161);
			collapsingToolbarLayout.ContentScrim = null;
			collapsingToolbarLayout.StatusBarScrim = null;
			this.newCharsCount = this.Intent.GetIntExtra("NewCharsCount", 0);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362121);
			this.recyclerView.HasFixedSize = true;
			this.latestCharsRecyclerView = base.FindViewById<RecyclerView>(2131362524);
			this.mLoader = base.FindViewById<AVLoadingIndicatorView>(2131362116);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mSearshNoResault = base.FindViewById<RelativeLayout>(2131362967);
			this.mSwiperRefresher = base.FindViewById<SwipeRefreshLayout>(2131362149);
			this.mSortedByContent = base.FindViewById<LinearLayout>(2131363083);
			this.mSearchBar = base.FindViewById<EditText>(2131362117);
			this.mCharsMoreLoader = base.FindViewById<CardView>(2131362134);
			this.mSettings = base.FindViewById<ImageView>(2131362120);
			this.mClearSearch = base.FindViewById<ImageView>(2131362119);
			this.mSortedByClose = base.FindViewById<ImageView>(2131363082);
			this.mSoretedByText = base.FindViewById<TextView>(2131363081);
			this.mCharsReload = base.FindViewById<ImageView>(2131362251);
			this.mLatestCharactersArea = base.FindViewById<LinearLayout>(2131362523);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.isCharactersLoading = true;
			this.charachersList = new List<CharacterModel>();
			if (SharedPreferencesSaves.StringSharedPreferencesGet("LastSort") != "N/A")
			{
				string a2 = SharedPreferencesSaves.StringSharedPreferencesGet("LastSort");
				if (!(a2 == "Most_Populer"))
				{
					if (!(a2 == "Most_Loved"))
					{
						if (!(a2 == "Less_Loved"))
						{
							this.sortBy = "";
							this.mSoretedByText.Text = "---";
						}
						else
						{
							this.sortBy = "Less_Loved";
							this.mSoretedByText.Text = base.Resources.GetString(2131952420);
						}
					}
					else
					{
						this.sortBy = "Most_Loved";
						this.mSoretedByText.Text = base.Resources.GetString(2131952421);
					}
				}
				else
				{
					this.sortBy = "Most_Populer";
					this.mSoretedByText.Text = base.Resources.GetString(2131952108);
				}
				this.mSortedByContent.Visibility = ViewStates.Visible;
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadCharacters(0, false);
			});
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatestCharacters();
			});
			this.mSwiperRefresher.Refresh += this.MSwiperRefresher_Refresh;
			this.mSettings.Click += this.MSettings_Click;
			this.mClearSearch.Click += this.MClearSearch_Click;
			this.mSearchBar.TextChanged += this.MSearchBar_TextChanged;
			this.mSortedByClose.Click += this.MSortedByClose_Click;
			this.mCharsReload.Click += this.MCharsReload_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1) && !this.isCharactersLoading)
			{
				this.isCharactersLoading = true;
				this.mCharsMoreLoader.StartAnimation(this.showLoader);
				this.mCharsMoreLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadCharacters(this.charachersList.Count<CharacterModel>(), true);
				});
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0002D230 File Offset: 0x0002B430
		private void MSuggestBtn_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent(Application.Context, typeof(FeedbackActivity));
			intent.PutExtra("CharSuggest", true);
			this.StartActivity(intent);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002D268 File Offset: 0x0002B468
		private void MSortedByClose_Click(object sender, EventArgs e)
		{
			this.mSortedByContent.Visibility = ViewStates.Gone;
			this.sortBy = "";
			SharedPreferencesSaves.StringSharedPreferencesSave("LastSort", "N/A");
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mCharsReload.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadCharacters(0, false);
			});
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		private void MSearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.mSearchBar.Text.Length > 0)
			{
				if (!this.isSearchCloseAnimeated)
				{
					this.mClearSearch.Visibility = ViewStates.Visible;
					this.mClearSearch.StartAnimation(this.showLoader);
					this.mClearSearch.Clickable = true;
					this.isSearchCloseAnimeated = true;
				}
				this.mSwiperRefresher.Refreshing = true;
				this.mLatestCharactersArea.Visibility = ViewStates.Gone;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SearchCharacters();
				});
				return;
			}
			if (this.isSearchCloseAnimeated)
			{
				this.mClearSearch.StartAnimation(this.hideLoader);
				this.mClearSearch.Visibility = ViewStates.Gone;
				this.mClearSearch.Clickable = false;
				this.isSearchCloseAnimeated = false;
			}
			if (this.adapter != null)
			{
				this.mSwiperRefresher.Refreshing = true;
				this.mLatestCharactersArea.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadCharacters(0, false);
				});
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002D3C4 File Offset: 0x0002B5C4
		private void MSettings_Click(object sender, EventArgs e)
		{
			DialogCharctersSettings dialogCharctersSettings = new DialogCharctersSettings();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogCharctersSettings.Show(transaction, "CharactersSettingDialog");
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		private void MClearSearch_Click(object sender, EventArgs e)
		{
			this.mSearchBar.Text = "";
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002D404 File Offset: 0x0002B604
		public static int CalculateNumberOfColumns(Context context, float columnWidthDp)
		{
			DisplayMetrics displayMetrics = context.Resources.DisplayMetrics;
			float num = (float)displayMetrics.WidthPixels / displayMetrics.Density;
			return (int)((double)(num / columnWidthDp) + 0.5);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002D440 File Offset: 0x0002B640
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689483, menu);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("AnimeCharsNotifications") == "ON")
			{
				menu.FindItem(2131362624).SetIcon(2131231143);
			}
			else
			{
				menu.FindItem(2131362624).SetIcon(2131231141);
			}
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			switch (itemId)
			{
			case 2131362146:
				this.sortBy = "Less_Loved";
				SharedPreferencesSaves.StringSharedPreferencesSave("LastSort", this.sortBy);
				this.mSoretedByText.Text = base.Resources.GetString(2131952420);
				this.mSortedByContent.Visibility = ViewStates.Visible;
				this.mSwiperRefresher.Refreshing = true;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadCharacters(0, false);
				});
				return true;
			case 2131362147:
				this.sortBy = "Most_Loved";
				SharedPreferencesSaves.StringSharedPreferencesSave("LastSort", this.sortBy);
				this.mSoretedByText.Text = base.Resources.GetString(2131952421);
				this.mSortedByContent.Visibility = ViewStates.Visible;
				this.mSwiperRefresher.Refreshing = true;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadCharacters(0, false);
				});
				return true;
			case 2131362148:
				this.sortBy = "Most_Populer";
				SharedPreferencesSaves.StringSharedPreferencesSave("LastSort", this.sortBy);
				this.mSoretedByText.Text = base.Resources.GetString(2131952108);
				this.mSortedByContent.Visibility = ViewStates.Visible;
				this.mSwiperRefresher.Refreshing = true;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadCharacters(0, false);
				});
				return true;
			default:
				if (itemId != 2131362624)
				{
					return base.OnOptionsItemSelected(item);
				}
				if (SharedPreferencesSaves.StringSharedPreferencesGet("AnimeCharsNotifications") == "ON")
				{
					item.SetIcon(2131231141);
					FirebaseMessaging.Instance.UnsubscribeFromTopic("AnimeChars");
					SharedPreferencesSaves.StringSharedPreferencesSave("AnimeCharsNotifications", "OFF");
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951927) + " " + this.Resources.GetString(2131951691), 0);
				}
				else
				{
					item.SetIcon(2131231143);
					FirebaseMessaging.Instance.SubscribeToTopic("AnimeChars");
					SharedPreferencesSaves.StringSharedPreferencesSave("AnimeCharsNotifications", "ON");
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951928) + " " + this.Resources.GetString(2131951691), 0);
				}
				return true;
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		private void MCharsReload_Click(object sender, EventArgs e)
		{
			this.latestCharsRecyclerView.Visibility = ViewStates.Gone;
			this.mCharsReload.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			this.mLatestCharactersArea.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatestCharacters();
			});
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadCharacters(0, false);
			});
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0002D760 File Offset: 0x0002B960
		private void MSwiperRefresher_Refresh(object sender, EventArgs e)
		{
			this.latestCharsRecyclerView.Visibility = ViewStates.Gone;
			this.mCharsReload.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			this.mLatestCharactersArea.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLatestCharacters();
			});
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadCharacters(0, false);
			});
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
		private void LoadCharacters(int from = 0, bool loadMore = false)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("characters/characters_list.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Sortby", this.sortBy);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			Action <>9__1;
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<CharacterModel> charTmpList = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (charTmpList != null)
						{
							if (loadMore)
							{
								this.charachersList.AddRange(charTmpList);
								this.adapter.NotifyDataSetChanged();
								this.mCharsMoreLoader.StartAnimation(this.hideLoader);
								this.mCharsMoreLoader.Visibility = ViewStates.Gone;
							}
							else
							{
								this.charachersList.Clear();
								this.charachersList.AddRange(charTmpList);
								this.adapter = new CharactersListAdapter(this, this.charachersList);
								this.adapter.ItemClick += this.Adapter_ItemClick;
								this.layoutManager = new GridLayoutManager(this, CharactersActivity.CalculateNumberOfColumns(this, 124f));
								this.recyclerView.SetLayoutManager(this.layoutManager);
								this.layoutManager.AutoMeasureEnabled = true;
								this.recyclerView.SetAdapter(this.adapter);
								this.mLoader.Visibility = ViewStates.Gone;
								this.recyclerView.Visibility = ViewStates.Visible;
							}
							this.mSwiperRefresher.Refreshing = false;
							this.isCharactersLoading = false;
							return;
						}
						if (loadMore)
						{
							this.mCharsMoreLoader.StartAnimation(this.hideLoader);
							this.mCharsMoreLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mLoader.Visibility = ViewStates.Gone;
							this.recyclerView.Visibility = ViewStates.Gone;
						}
						this.isCharactersLoading = false;
						this.mSwiperRefresher.Refreshing = false;
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
								this.mCharsMoreLoader.StartAnimation(this.hideLoader);
								this.mCharsMoreLoader.Visibility = ViewStates.Gone;
							}
							else
							{
								this.mLoader.Visibility = ViewStates.Gone;
								this.recyclerView.Visibility = ViewStates.Gone;
							}
							this.isCharactersLoading = false;
							this.mSwiperRefresher.Refreshing = false;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002D8BB File Offset: 0x0002BABB
		private void Adapter_ItemClick(object sender, int e)
		{
			this.GoCharDetails(this.charachersList[e], this.recyclerView, e, 1);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
		private void LoadLatestCharacters()
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("characters/demo_characters.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
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
					this.latestCharsList = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					base.RunOnUiThread(delegate()
					{
						if (this.latestCharsList != null)
						{
							if (this.latestCharsList.Count<CharacterModel>() > 0)
							{
								this.latestCharsAdapter = new LatestCharactersListAdapter(this, this.latestCharsList);
								this.latestCharsAdapter.ItemClick += this.LatestCharsAdapter_ItemClick;
								LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, 0, false);
								this.latestCharsRecyclerView.SetLayoutManager(linearLayoutManager);
								this.latestCharsRecyclerView.SetAdapter(this.latestCharsAdapter);
							}
						}
						else
						{
							this.latestCharsRecyclerView.Visibility = ViewStates.Gone;
							this.mCharsReload.Visibility = ViewStates.Visible;
						}
						this.mLoader.Visibility = ViewStates.Gone;
						this.latestCharsRecyclerView.Visibility = ViewStates.Visible;
						this.mSwiperRefresher.Refreshing = false;
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mCharsReload.Visibility = ViewStates.Visible;
						this.mLoader.Visibility = ViewStates.Gone;
						this.latestCharsRecyclerView.Visibility = ViewStates.Gone;
						this.mSwiperRefresher.Refreshing = false;
					});
				}
			};
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002D941 File Offset: 0x0002BB41
		private void LatestCharsAdapter_ItemClick(object sender, int e)
		{
			this.GoCharDetails(this.latestCharsList[e], this.latestCharsRecyclerView, e, 3);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0002D960 File Offset: 0x0002BB60
		private void GoCharDetails(CharacterModel item, RecyclerView recycler, int itemPosition, int resultCode)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CharactersActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			this.newsViewingCounter++;
			if (this.newsViewingCounter - this.lastAdShowenOn == SharedPreferencesSaves.IntSharedPreferencesGet("GoogleAdsPerSession"))
			{
				this.adRewardRecieved = false;
				this.lastAdShowenOn = this.newsViewingCounter;
			}
			if (item.Enabled == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952247), 0);
				return;
			}
			View itemView = recycler.FindViewHolderForAdapterPosition(itemPosition).ItemView;
			ImageView a = itemView.FindViewById<ImageView>(2131362127);
			TextView a2 = itemView.FindViewById<TextView>(2131362125);
			Intent intent = new Intent(Application.Context, typeof(CharacterDetailsActivity));
			intent.PutExtra("CharId", item.CharId);
			intent.PutExtra("CharEnName", item.NameEN);
			intent.PutExtra("CharArName", item.NameAR);
			intent.PutExtra("CharJpName", item.NameJP);
			intent.PutExtra("CharAka", item.Aka);
			intent.PutExtra("RelationId", item.RelationId);
			intent.PutExtra("Gender", item.Gender);
			intent.PutExtra("ExtraPhotosCount", item.ExtraPhotosCount);
			intent.PutExtra("Age", item.Age);
			intent.PutExtra("Height", item.Height);
			intent.PutExtra("Weight", item.Weight);
			intent.PutExtra("BloodType", item.BloodType);
			intent.PutExtra("IsLoved", item.Love);
			intent.PutExtra("CharPhoto", Constants.CharPhoto(item.Photo));
			intent.PutExtra("LikersCount", item.LikersCount);
			intent.PutExtra("DislikersCount", item.DislikersCount);
			intent.PutExtra("ItemPosition", itemPosition);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Pair pair = Pair.Create(a, "charthumbnail");
				Pair pair2 = Pair.Create(a2, "name");
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, new Pair[]
				{
					pair,
					pair2
				});
				this.StartActivityForResult(intent, resultCode, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, resultCode);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
		private void SearchCharacters()
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("characters/characters_search.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"SearchText",
					this.mSearchBar.Text
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
					this.charachersList = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					base.RunOnUiThread(delegate()
					{
						if (this.charachersList != null)
						{
							if (this.charachersList.Count == 0)
							{
								this.mSearshNoResault.Visibility = ViewStates.Visible;
							}
							else
							{
								this.mSearshNoResault.Visibility = ViewStates.Gone;
							}
							if (this.adapter != null)
							{
								this.adapter.SetData(this.charachersList);
								this.recyclerView.SetAdapter(this.adapter);
							}
						}
						this.mSwiperRefresher.Refreshing = false;
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mSwiperRefresher.Refreshing = false;
					});
				}
			};
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0002DC43 File Offset: 0x0002BE43
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			this.layoutManager = new GridLayoutManager(this, CharactersActivity.CalculateNumberOfColumns(this, 124f));
			this.recyclerView.SetLayoutManager(this.layoutManager);
			base.OnConfigurationChanged(newConfig);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0002DC74 File Offset: 0x0002BE74
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			if (resultCode == Result.Ok)
			{
				if (requestCode == 1)
				{
					int intExtra = data.GetIntExtra("LoveFeedback", 0);
					int intExtra2 = data.GetIntExtra("LoversCount", 0);
					int intExtra3 = data.GetIntExtra("DisloversCount", 0);
					int intExtra4 = data.GetIntExtra("ItemPosistion", 0);
					CharacterModel characterModel = this.charachersList[intExtra4];
					characterModel.Love = intExtra;
					characterModel.LikersCount = intExtra2;
					characterModel.DislikersCount = intExtra3;
				}
				else if (requestCode == 3)
				{
					int intExtra5 = data.GetIntExtra("LoveFeedback", 0);
					int intExtra6 = data.GetIntExtra("LoversCount", 0);
					int intExtra7 = data.GetIntExtra("DisloversCount", 0);
					int intExtra8 = data.GetIntExtra("ItemPosistion", 0);
					CharacterModel characterModel2 = this.latestCharsList[intExtra8];
					characterModel2.Love = intExtra5;
					characterModel2.LikersCount = intExtra6;
					characterModel2.DislikersCount = intExtra7;
				}
			}
			base.OnActivityResult(requestCode, resultCode, data);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000696 RID: 1686
		private UsersModel user;

		// Token: 0x04000697 RID: 1687
		private int userId;

		// Token: 0x04000698 RID: 1688
		private RecyclerView recyclerView;

		// Token: 0x04000699 RID: 1689
		private RecyclerView latestCharsRecyclerView;

		// Token: 0x0400069A RID: 1690
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x0400069B RID: 1691
		private LatestCharactersListAdapter latestCharsAdapter;

		// Token: 0x0400069C RID: 1692
		private CharactersListAdapter adapter;

		// Token: 0x0400069D RID: 1693
		private List<CharacterModel> charachersList;

		// Token: 0x0400069E RID: 1694
		private List<CharacterModel> latestCharsList;

		// Token: 0x0400069F RID: 1695
		private SwipeRefreshLayout mSwiperRefresher;

		// Token: 0x040006A0 RID: 1696
		private WebClient mClient;

		// Token: 0x040006A1 RID: 1697
		private Uri mUri;

		// Token: 0x040006A2 RID: 1698
		private NameValueCollection parameters;

		// Token: 0x040006A3 RID: 1699
		private AVLoadingIndicatorView mLoader;

		// Token: 0x040006A4 RID: 1700
		private RelativeLayout mOfflineView;

		// Token: 0x040006A5 RID: 1701
		private RelativeLayout mSearshNoResault;

		// Token: 0x040006A6 RID: 1702
		private Button mOfflineRetry;

		// Token: 0x040006A7 RID: 1703
		private CardView mCharsMoreLoader;

		// Token: 0x040006A8 RID: 1704
		private EditText mSearchBar;

		// Token: 0x040006A9 RID: 1705
		private TextView mSoretedByText;

		// Token: 0x040006AA RID: 1706
		private ImageView mSettings;

		// Token: 0x040006AB RID: 1707
		private ImageView mClearSearch;

		// Token: 0x040006AC RID: 1708
		private ImageView mSortedByClose;

		// Token: 0x040006AD RID: 1709
		private ImageView mCharsReload;

		// Token: 0x040006AE RID: 1710
		private LinearLayout mLatestCharactersArea;

		// Token: 0x040006AF RID: 1711
		private LinearLayout mSortedByContent;

		// Token: 0x040006B0 RID: 1712
		private Animation hideLoader;

		// Token: 0x040006B1 RID: 1713
		private Animation showLoader;

		// Token: 0x040006B2 RID: 1714
		private bool isSearchCloseAnimeated;

		// Token: 0x040006B3 RID: 1715
		private bool isCharactersLoading;

		// Token: 0x040006B4 RID: 1716
		private bool adRewardRecieved;

		// Token: 0x040006B5 RID: 1717
		private string sortBy = "";

		// Token: 0x040006B6 RID: 1718
		private int newCharsCount;

		// Token: 0x040006B7 RID: 1719
		private int newsViewingCounter;

		// Token: 0x040006B8 RID: 1720
		private int lastAdShowenOn;

		// Token: 0x040006B9 RID: 1721
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x040006BA RID: 1722
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
