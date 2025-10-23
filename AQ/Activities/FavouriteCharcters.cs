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
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Util;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Google.Android.Material.Button;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000C4 RID: 196
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class FavouriteCharcters : AppCompatActivity
	{
		// Token: 0x0600094F RID: 2383 RVA: 0x0002E678 File Offset: 0x0002C878
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
			this.SupportActionBar.SetTitle(2131952216);
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558443);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362385);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = base.FindViewById<CardView>(2131362134);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
			this.mEmptyViewIcon = base.FindViewById<ImageView>(2131362333);
			this.mEmptyViewIcon.SetImageResource(2131231083);
			this.mEmptyViewMessage = base.FindViewById<TextView>(2131362334);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.fullRotation = AnimationUtils.LoadAnimation(this, 2130772022);
			this.mReactionsToggle = base.FindViewById<MaterialButtonToggleGroup>(2131362137);
			this.mCharList = new List<CharacterModel>();
			if (this.userId == 0)
			{
				Bundle bundle = new Bundle();
				bundle.PutString("Message", base.Resources.GetString(2131951866));
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
					this.LoadFavCharacters(0, false);
				});
			}
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.mReactionsToggle.ButtonChecked += this.MReactionsToggle_ButtonChecked;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0002E908 File Offset: 0x0002CB08
		private void MReactionsToggle_ButtonChecked(object sender, MaterialButtonToggleGroup.ButtonCheckedEventArgs e)
		{
			if (e.P2)
			{
				int p = e.P1;
				if (p != 2131362136)
				{
					if (p != 2131362138)
					{
						this.reaction = 1;
						this.mEmptyViewIcon.SetImageResource(2131231083);
					}
					else
					{
						this.reaction = 0;
						this.mEmptyViewIcon.SetImageResource(2131230974);
					}
				}
				else
				{
					this.reaction = 1;
					this.mEmptyViewIcon.SetImageResource(2131231083);
				}
			}
			this.IsLoading = true;
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mEmptyView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadFavCharacters(0, false);
			});
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.IsLoading = true;
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mEmptyView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadFavCharacters(0, false);
			});
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002EA20 File Offset: 0x0002CC20
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1))
			{
				if (!this.IsLoadingMore)
				{
					this.IsLoadingMore = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadFavCharacters(this.mCharList.Count, true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.IsLoadingMore)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002EA98 File Offset: 0x0002CC98
		public static int CalculateNumberOfColumns(Context context, float columnWidthDp)
		{
			DisplayMetrics displayMetrics = context.Resources.DisplayMetrics;
			float num = (float)displayMetrics.WidthPixels / displayMetrics.Density;
			return (int)((double)(num / columnWidthDp) + 0.5);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002EAD4 File Offset: 0x0002CCD4
		private void LoadFavCharacters(int from = 0, bool loadMore = false)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("library/favourites/fav_chars_loader.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId.ToString());
			nameValueCollection.Add("LovedOrUnloved", this.reaction.ToString());
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__3;
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<CharacterModel> charTmpList = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					if (charTmpList != null)
					{
						this.RunOnUiThread(delegate()
						{
							if (loadMore)
							{
								this.mCharList.AddRange(charTmpList);
								this.adapter.NotifyDataSetChanged();
								return;
							}
							if (charTmpList.Count<CharacterModel>() <= 0)
							{
								this.mEmptyView.Visibility = ViewStates.Visible;
							}
							else
							{
								this.mCharList.Clear();
								this.mCharList.AddRange(charTmpList);
								this.adapter = new FavouriteCharsListAdapter(this, this.mCharList, this.reaction == 1);
								this.adapter.ItemClick += this.Adapter_ItemClick;
								this.adapter.ItemLoveClick += this.Adapter_ItemLoveClick;
								this.adapter.ItemUnloveClick += this.Adapter_ItemUnloveClick;
								this.adapter.ItemCommentsClick += this.Adapter_ItemCommentsClick;
								this.layoutManager = new GridLayoutManager(this, FavouriteCharcters.CalculateNumberOfColumns(this, 380f));
								this.recyclerView.SetLayoutManager(this.layoutManager);
								this.recyclerView.SetAdapter(this.adapter);
								this.recyclerView.Visibility = ViewStates.Visible;
								this.mOfflineView.Visibility = ViewStates.Gone;
							}
							this.IsLoading = false;
							this.mLoader.Visibility = ViewStates.Gone;
						});
					}
					Activity <>4__this = this;
					Action action;
					if ((action = <>9__3) == null)
					{
						action = (<>9__3 = delegate()
						{
							this.IsLoadingMore = false;
							this.mMoreLoader.StartAnimation(this.hideLoader);
							this.mMoreLoader.Visibility = ViewStates.Gone;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
				catch
				{
					Activity <>4__this2 = this;
					Action action2;
					if ((action2 = <>9__1) == null)
					{
						action2 = (<>9__1 = delegate()
						{
							if (loadMore)
							{
								this.mMoreLoader.StartAnimation(this.hideLoader);
								this.mMoreLoader.Visibility = ViewStates.Gone;
								this.IsLoadingMore = false;
								return;
							}
							this.mOfflineView.Visibility = ViewStates.Visible;
							this.mLoader.Visibility = ViewStates.Gone;
						});
					}
					<>4__this2.RunOnUiThread(action2);
				}
			};
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0002EB94 File Offset: 0x0002CD94
		private void Adapter_ItemUnloveClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouriteCharcters.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel item = this.mCharList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362114);
			imageView.StartAnimation(AnimationUtils.LoadAnimation(this, 2130771992));
			imageView.SetImageResource(2131230974);
			if (item.Love == 0)
			{
				item.Love = 2;
				item.DislikersCount--;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SetLove(item.CharId, "DELETE", 0, item, e);
				});
				return;
			}
			if (item.Love == 1)
			{
				item.LikersCount--;
			}
			item.Love = 0;
			item.DislikersCount++;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.SetLove(item.CharId, "ADD_UPDATE", 0, item, e);
			});
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0002ECC8 File Offset: 0x0002CEC8
		private void Adapter_ItemLoveClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouriteCharcters.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel item = this.mCharList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362109);
			imageView.StartAnimation(AnimationUtils.LoadAnimation(this, 2130771992));
			imageView.SetImageResource(2131231083);
			if (item.Love == 1)
			{
				item.Love = 2;
				item.LikersCount--;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SetLove(item.CharId, "DELETE", 1, item, e);
				});
				return;
			}
			if (item.Love == 0)
			{
				item.DislikersCount--;
			}
			item.Love = 1;
			item.LikersCount++;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.SetLove(item.CharId, "ADD_UPDATE", 1, item, e);
			});
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0002EDFC File Offset: 0x0002CFFC
		private void SetLove(string charId, string command, int love, CharacterModel item, int pos)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("characters/characters_set_love.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"CharId",
					charId
				},
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Command",
					command
				},
				{
					"Love",
					love.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			Action <>9__1;
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				Activity <>4__this = this;
				Action action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate()
					{
						if (love == 1)
						{
							this.mLoveHeart.StartAnimation(this.fullRotation);
						}
						else
						{
							this.mUnloveHeart.StartAnimation(this.fullRotation);
						}
						this.RemoveItem(item, pos);
					});
				}
				<>4__this.RunOnUiThread(action);
			};
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002EEB8 File Offset: 0x0002D0B8
		private void Adapter_ItemCommentsClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouriteCharcters.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel characterModel = this.mCharList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", characterModel.CharId);
			bundle.PutString("CommType", "CHARACTER");
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0002EF40 File Offset: 0x0002D140
		private void Adapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouriteCharcters.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel characterModel = this.mCharList[e];
			if (characterModel.Enabled == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952247), 0);
				return;
			}
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView a = itemView.FindViewById<ImageView>(2131362127);
			TextView textView = itemView.FindViewById<TextView>(2131362125);
			Intent intent = new Intent(Application.Context, typeof(CharacterDetailsActivity));
			intent.PutExtra("CharId", characterModel.CharId);
			intent.PutExtra("CharEnName", characterModel.NameEN);
			intent.PutExtra("CharArName", characterModel.NameAR);
			intent.PutExtra("CharJpName", characterModel.NameJP);
			intent.PutExtra("CharAka", characterModel.Aka);
			intent.PutExtra("RelationId", characterModel.RelationId);
			intent.PutExtra("Gender", characterModel.Gender);
			intent.PutExtra("ExtraPhotosCount", characterModel.ExtraPhotosCount);
			intent.PutExtra("Age", characterModel.Age);
			intent.PutExtra("Height", characterModel.Height);
			intent.PutExtra("Weight", characterModel.Weight);
			intent.PutExtra("BloodType", characterModel.BloodType);
			intent.PutExtra("IsLoved", characterModel.Love);
			intent.PutExtra("CharPhoto", Constants.CharPhoto(characterModel.Photo));
			intent.PutExtra("LikersCount", characterModel.LikersCount);
			intent.PutExtra("DislikersCount", characterModel.DislikersCount);
			intent.PutExtra("ItemPosition", e);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Pair pair = Pair.Create(a, "charthumbnail");
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, new Pair[]
				{
					pair
				});
				this.StartActivityForResult(intent, 4, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 4);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0002F163 File Offset: 0x0002D363
		private void RemoveItem(CharacterModel item, int postion)
		{
			this.mCharList.Remove(item);
			this.adapter.NotifyItemRemoved(postion);
			if (this.mCharList.Count<CharacterModel>() <= 0)
			{
				this.mEmptyView.Visibility = ViewStates.Visible;
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0002F198 File Offset: 0x0002D398
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			if (resultCode == Result.Ok && requestCode == 4)
			{
				int intExtra = data.GetIntExtra("LoveFeedback", 0);
				int intExtra2 = data.GetIntExtra("LoversCount", 0);
				int intExtra3 = data.GetIntExtra("DisloversCount", 0);
				int intExtra4 = data.GetIntExtra("ItemPosistion", 0);
				CharacterModel characterModel = this.mCharList[intExtra4];
				if (intExtra != characterModel.Love)
				{
					if (intExtra == 1 && this.reaction == 0)
					{
						this.mUnloveHeart.StartAnimation(this.fullRotation);
						this.RemoveItem(characterModel, intExtra4);
					}
					else if (intExtra == 0 && this.reaction == 1)
					{
						this.mLoveHeart.StartAnimation(this.fullRotation);
						this.RemoveItem(characterModel, intExtra4);
					}
					else
					{
						this.RemoveItem(characterModel, intExtra4);
					}
				}
				characterModel.Love = intExtra;
				characterModel.LikersCount = intExtra2;
				characterModel.DislikersCount = intExtra3;
			}
			base.OnActivityResult(requestCode, resultCode, data);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0002F279 File Offset: 0x0002D479
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			if (UsersModel.OnResumeLogin && this.mLoginFrag != null)
			{
				this.mLoginFrag.Dismiss();
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadFavCharacters(this.reaction, false);
				});
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0002F2DF File Offset: 0x0002D4DF
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			this.layoutManager = new GridLayoutManager(this, FavouriteCharcters.CalculateNumberOfColumns(this, 380f));
			this.recyclerView.SetLayoutManager(this.layoutManager);
			base.OnConfigurationChanged(newConfig);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x040006D0 RID: 1744
		private UsersModel user;

		// Token: 0x040006D1 RID: 1745
		private int userId;

		// Token: 0x040006D2 RID: 1746
		private DialogSigninPrompt mLoginFrag;

		// Token: 0x040006D3 RID: 1747
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x040006D4 RID: 1748
		private List<CharacterModel> mCharList;

		// Token: 0x040006D5 RID: 1749
		private FavouriteCharsListAdapter adapter;

		// Token: 0x040006D6 RID: 1750
		private WebClient client;

		// Token: 0x040006D7 RID: 1751
		private Uri uri;

		// Token: 0x040006D8 RID: 1752
		private ProgressBar mLoader;

		// Token: 0x040006D9 RID: 1753
		private RelativeLayout mOfflineView;

		// Token: 0x040006DA RID: 1754
		private Button mOfflineRetry;

		// Token: 0x040006DB RID: 1755
		private RelativeLayout mEmptyView;

		// Token: 0x040006DC RID: 1756
		private ImageView mEmptyViewIcon;

		// Token: 0x040006DD RID: 1757
		private ImageView mLoveHeart;

		// Token: 0x040006DE RID: 1758
		private ImageView mUnloveHeart;

		// Token: 0x040006DF RID: 1759
		private TextView mEmptyViewMessage;

		// Token: 0x040006E0 RID: 1760
		private Animation hideLoader;

		// Token: 0x040006E1 RID: 1761
		private Animation showLoader;

		// Token: 0x040006E2 RID: 1762
		private Animation fullRotation;

		// Token: 0x040006E3 RID: 1763
		private RecyclerView recyclerView;

		// Token: 0x040006E4 RID: 1764
		private CardView mMoreLoader;

		// Token: 0x040006E5 RID: 1765
		private MaterialButtonToggleGroup mReactionsToggle;

		// Token: 0x040006E6 RID: 1766
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x040006E7 RID: 1767
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x040006E8 RID: 1768
		private bool IsLoading = true;

		// Token: 0x040006E9 RID: 1769
		private bool IsLoadingMore;

		// Token: 0x040006EA RID: 1770
		private int reaction = 1;
	}
}
