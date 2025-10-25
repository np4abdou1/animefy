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
using Google.Android.Material.Button;
using Google.Android.Material.Snackbar;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000C5 RID: 197
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class FavouritesActivity : AppCompatActivity
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x0002F36C File Offset: 0x0002D56C
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
			this.SupportActionBar.SetTitle(2131951932);
			this.SetContentView(2131558444);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.favouritesList = new List<AnimeModel>();
			this.favouritesListHelper = new List<AnimeModel>();
			this.mContent = base.FindViewById<RelativeLayout>(2131363076);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362386);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = base.FindViewById<CardView>(2131362387);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mTypesToggle = base.FindViewById<MaterialButtonToggleGroup>(2131362391);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
			this.mEmptyViewIcon = base.FindViewById<ImageView>(2131362333);
			this.mEmptyViewIcon.SetImageResource(2131231209);
			this.mEmptyViewMessage = base.FindViewById<TextView>(2131362334);
			if (this.animeType == "SERIES")
			{
				this.mEmptyViewMessage.Text = this.Resources.GetString(2131951981);
			}
			else
			{
				this.mEmptyViewMessage.Text = this.Resources.GetString(2131951980);
			}
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
					this.LoadFavourites(0, false);
				});
			}
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.mTypesToggle.ButtonChecked += this.MTypesToggle_ButtonChecked;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002F650 File Offset: 0x0002D850
		private void MTypesToggle_ButtonChecked(object sender, MaterialButtonToggleGroup.ButtonCheckedEventArgs e)
		{
			if (e.P2)
			{
				int p = e.P1;
				if (p != 2131362389)
				{
					if (p == 2131362390)
					{
						this.animeType = "SERIES";
					}
					else
					{
						this.animeType = "SERIES";
					}
				}
				else
				{
					this.animeType = "MOVIE";
				}
				this.isLoadingFavourites = true;
				this.mOfflineView.Visibility = ViewStates.Gone;
				this.mEmptyView.Visibility = ViewStates.Gone;
				this.recyclerView.Visibility = ViewStates.Gone;
				this.mLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadFavourites(0, false);
				});
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0002F6F0 File Offset: 0x0002D8F0
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1))
			{
				if (!this.isLoadingFavourites && !this.IsClearTriggered && !this.IsItemDeleteTriggered && !this.isReachedToEnd)
				{
					this.isLoadingFavourites = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadFavourites(this.favouritesList.Count<AnimeModel>(), true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLoadingFavourites)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0002F77D File Offset: 0x0002D97D
		protected override void OnPause()
		{
			base.OnPause();
			if (this.recyclerView != null)
			{
				this.recyclerView.SuppressLayout(true);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0002F79C File Offset: 0x0002D99C
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			if (this.recyclerView != null)
			{
				this.recyclerView.SuppressLayout(false);
			}
			if (UsersModel.OnResumeLogin && this.mLoginFrag != null)
			{
				this.mLoginFrag.Dismiss();
				this.user = UsersViewModel.GetUserProfile();
				this.userId = ((this.user == null) ? 0 : this.user.UserID);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadFavourites(0, false);
				});
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002F81C File Offset: 0x0002DA1C
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.isLoadingFavourites = true;
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mEmptyView.Visibility = ViewStates.Gone;
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadFavourites(0, false);
			});
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002F872 File Offset: 0x0002DA72
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.localMenu = menu;
			this.MenuInflater.Inflate(2131689497, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0002F894 File Offset: 0x0002DA94
		private void ClearAll()
		{
			FavouritesActivity.<ClearAll>d__39 <ClearAll>d__;
			<ClearAll>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ClearAll>d__.<>4__this = this;
			<ClearAll>d__.<>1__state = -1;
			<ClearAll>d__.<>t__builder.Start<FavouritesActivity.<ClearAll>d__39>(ref <ClearAll>d__);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0002F8CC File Offset: 0x0002DACC
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok && requestCode == 1)
			{
				bool booleanExtra = data.GetBooleanExtra("DeleteOnReturn", false);
				int intExtra = data.GetIntExtra("ItemPosistion", 0);
				if (booleanExtra)
				{
					this.favouritesList.Remove(this.favouritesList[intExtra]);
					if (this.loadAsGrid)
					{
						this.adapterGrid.NotifyItemRemoved(intExtra);
					}
					else
					{
						this.adapterList.NotifyItemRemoved(intExtra);
					}
					if (this.favouritesList.Count<AnimeModel>() == 0)
					{
						this.mEmptyView.Visibility = ViewStates.Visible;
					}
				}
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002F95C File Offset: 0x0002DB5C
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 2131362625)
			{
				if (this.favouritesList == null)
				{
					return true;
				}
				if (this.favouritesList.Count<AnimeModel>() > 0)
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
						this.favouritesListHelper = new List<AnimeModel>();
						foreach (AnimeModel item2 in this.favouritesList)
						{
							this.favouritesListHelper.Add(item2);
						}
						int count = this.favouritesList.Count<AnimeModel>();
						this.favouritesList.RemoveRange(0, count);
						if (this.loadAsGrid)
						{
							this.adapterGrid.NotifyItemRangeRemoved(0, count);
						}
						else
						{
							this.adapterList.NotifyItemRangeRemoved(0, count);
						}
						this.IsClearTriggered = true;
						this.mEmptyView.Visibility = ViewStates.Visible;
						Snackbar snackbar = CustomizedSnackbar.SnackBar(this.mContent, 2131951680, "");
						snackbar.SetAction(this.Resources.GetString(2131952546), delegate(View v)
						{
							this.IsClearTriggered = false;
							this.favouritesList.InsertRange(0, this.favouritesListHelper);
							if (this.loadAsGrid)
							{
								this.adapterGrid.NotifyItemRangeInserted(0, count);
							}
							else
							{
								this.adapterList.NotifyItemRangeInserted(0, count);
							}
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
				if (itemId == 2131362634)
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
					this.LoadAs(this.favouritesList);
				}
				return base.OnOptionsItemSelected(item);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002FAE0 File Offset: 0x0002DCE0
		private void LoadFavourites(int from = 0, bool loadMore = false)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("library/favourites/favourites_a_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("Type", this.animeType);
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			Action <>9__1;
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> tmpFavouritesList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (tmpFavouritesList != null)
						{
							if (loadMore)
							{
								if (tmpFavouritesList.Count == 0)
								{
									this.isReachedToEnd = true;
								}
								else
								{
									this.favouritesList.AddRange(tmpFavouritesList);
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
							else if (tmpFavouritesList.Count == 0)
							{
								this.mLoader.Visibility = ViewStates.Gone;
								this.mEmptyView.Visibility = ViewStates.Visible;
							}
							else
							{
								this.favouritesList.Clear();
								this.favouritesList.AddRange(tmpFavouritesList);
								this.LoadAs(this.favouritesList);
							}
						}
						else if (loadMore)
						{
							this.mMoreLoader.StartAnimation(this.hideLoader);
							this.mMoreLoader.Visibility = ViewStates.Gone;
						}
						this.isLoadingFavourites = false;
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
								return;
							}
							this.mLoader.Visibility = ViewStates.Gone;
							this.recyclerView.Visibility = ViewStates.Gone;
							this.mOfflineView.Visibility = ViewStates.Visible;
						});
					}
					<>4__this.RunOnUiThread(action);
					this.isLoadingFavourites = false;
				}
			};
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		private void DeleteFavouriteItem(int itemPos, AnimeModel item)
		{
			this.favouritesList.Remove(item);
			if (this.loadAsGrid)
			{
				this.adapterGrid.NotifyItemRemoved(itemPos);
			}
			else
			{
				this.adapterList.NotifyItemRemoved(itemPos);
			}
			if (this.favouritesList.Count<AnimeModel>() <= 0)
			{
				this.mEmptyView.Visibility = ViewStates.Visible;
			}
			this.IsItemDeleteTriggered = true;
			Snackbar snackbar = Snackbar.Make(this.mContent, item.EN_Title + " " + this.Resources.GetString(2131951930), -1);
			snackbar.SetAction(this.Resources.GetString(2131952546), delegate(View v)
			{
				this.favouritesList.Insert(itemPos, item);
				if (this.loadAsGrid)
				{
					this.adapterGrid.NotifyItemInserted(itemPos);
				}
				else
				{
					this.adapterList.NotifyItemInserted(itemPos);
				}
				if (this.favouritesList.Count<AnimeModel>() <= 0)
				{
					this.mEmptyView.Visibility = ViewStates.Visible;
				}
				else
				{
					this.mEmptyView.Visibility = ViewStates.Gone;
				}
				this.IsItemDeleteTriggered = false;
			}).Show();
			Task task = new Task(delegate()
			{
				this.ItemDelete(item.AnimeId);
			});
			task.Start();
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0002FCD0 File Offset: 0x0002DED0
		private void ItemDelete(string animeId)
		{
			FavouritesActivity.<ItemDelete>d__44 <ItemDelete>d__;
			<ItemDelete>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemDelete>d__.<>4__this = this;
			<ItemDelete>d__.animeId = animeId;
			<ItemDelete>d__.<>1__state = -1;
			<ItemDelete>d__.<>t__builder.Start<FavouritesActivity.<ItemDelete>d__44>(ref <ItemDelete>d__);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0002FD10 File Offset: 0x0002DF10
		private void LoadAs(List<AnimeModel> list)
		{
			if (this.loadAsGrid)
			{
				this.adapterGrid = new AnimeCatalogGridAdapter(this, list, 0);
				this.adapterGrid.ItemClick += this.AdapterGrid_ItemClick;
				this.adapterGrid.ItemLongClick += this.AdapterGrid_ItemLongClick;
				this.adapterGrid.ItemFavouriteClick += this.AdapterGrid_ItemFavouriteClick;
				this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 140f));
				this.recyclerView.SetLayoutManager(this.layoutManager);
				this.recyclerView.SetAdapter(this.adapterGrid);
			}
			else
			{
				this.adapterList = new AnimeCatalogListAdapter(this, this.favouritesList, true);
				this.adapterList.ItemClick += this.AdapterList_ItemClick;
				this.adapterList.ItemPlotClick += this.AdapterList_ItemPlotClick;
				this.adapterList.ItemOptionMenuClick += this.AdapterList_ItemOptionMenuClick;
				this.layoutManager = new GridLayoutManager(this, 1);
				this.recyclerView.SetLayoutManager(this.layoutManager);
				this.recyclerView.SetAdapter(this.adapterList);
			}
			this.mLoader.Visibility = ViewStates.Gone;
			this.recyclerView.Visibility = ViewStates.Visible;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0002FE58 File Offset: 0x0002E058
		private void AdapterGrid_ItemFavouriteClick(object sender, int e)
		{
			this.OpenOptionMenu(e);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002FE61 File Offset: 0x0002E061
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			if (this.loadAsGrid)
			{
				this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 140f));
				this.recyclerView.SetLayoutManager(this.layoutManager);
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002FE58 File Offset: 0x0002E058
		private void AdapterList_ItemOptionMenuClick(object sender, int e)
		{
			this.OpenOptionMenu(e);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002FE9A File Offset: 0x0002E09A
		private void AdapterList_ItemPlotClick(object sender, int e)
		{
			this.OpenPlot(e);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0002FEA3 File Offset: 0x0002E0A3
		private void AdapterList_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002FE58 File Offset: 0x0002E058
		private void AdapterGrid_ItemLongClick(object sender, int e)
		{
			this.OpenOptionMenu(e);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002FEA3 File Offset: 0x0002E0A3
		private void AdapterGrid_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002FEAC File Offset: 0x0002E0AC
		private void OpenOptionMenu(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouritesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.favouritesList[itemPosition];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(itemPosition).ItemView;
			PopupMenu menu;
			if (this.loadAsGrid)
			{
				CardView anchor = itemView.FindViewById<CardView>(2131361946);
				menu = new PopupMenu(itemView.Context, anchor);
			}
			else
			{
				ImageView anchor2 = itemView.FindViewById<ImageView>(2131361950);
				menu = new PopupMenu(itemView.Context, anchor2);
			}
			menu.MenuInflater.Inflate(2131689491, menu.Menu);
			menu.Show();
			menu.DismissEvent += delegate(object se, [Nullable(1)] PopupMenu.DismissEventArgs ee)
			{
				menu.Dispose();
			};
			menu.MenuItemClick += delegate(object s1, [Nullable(1)] PopupMenu.MenuItemClickEventArgs arg1)
			{
				int itemId = arg1.Item.ItemId;
				if (itemId == 2131362388)
				{
					this.DeleteFavouriteItem(itemPosition, this.favouritesList[itemPosition]);
				}
				menu.Dismiss();
			};
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		private void OpenPlot(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouritesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.favouritesList[itemPosition];
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

		// Token: 0x0600097E RID: 2430 RVA: 0x00030064 File Offset: 0x0002E264
		private void GoToDetails(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < FavouritesActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.favouritesList[itemPosition];
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
			intent.PutExtra("Transition", this.isLoadingFavourites);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x040006EB RID: 1771
		private UsersModel user;

		// Token: 0x040006EC RID: 1772
		private int userId;

		// Token: 0x040006ED RID: 1773
		private RecyclerView recyclerView;

		// Token: 0x040006EE RID: 1774
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x040006EF RID: 1775
		private AnimeCatalogGridAdapter adapterGrid;

		// Token: 0x040006F0 RID: 1776
		private AnimeCatalogListAdapter adapterList;

		// Token: 0x040006F1 RID: 1777
		private List<AnimeModel> favouritesList;

		// Token: 0x040006F2 RID: 1778
		private List<AnimeModel> favouritesListHelper;

		// Token: 0x040006F3 RID: 1779
		private RelativeLayout mContent;

		// Token: 0x040006F4 RID: 1780
		private ProgressBar mLoader;

		// Token: 0x040006F5 RID: 1781
		private RelativeLayout mOfflineView;

		// Token: 0x040006F6 RID: 1782
		private Button mOfflineRetry;

		// Token: 0x040006F7 RID: 1783
		private CardView mMoreLoader;

		// Token: 0x040006F8 RID: 1784
		private RelativeLayout mEmptyView;

		// Token: 0x040006F9 RID: 1785
		private ImageView mEmptyViewIcon;

		// Token: 0x040006FA RID: 1786
		private TextView mEmptyViewMessage;

		// Token: 0x040006FB RID: 1787
		private WebClient mClient;

		// Token: 0x040006FC RID: 1788
		private Uri mUri;

		// Token: 0x040006FD RID: 1789
		private NameValueCollection parameters;

		// Token: 0x040006FE RID: 1790
		private MaterialButtonToggleGroup mTypesToggle;

		// Token: 0x040006FF RID: 1791
		private Animation hideLoader;

		// Token: 0x04000700 RID: 1792
		private Animation showLoader;

		// Token: 0x04000701 RID: 1793
		private IMenu localMenu;

		// Token: 0x04000702 RID: 1794
		private string animeType = "SERIES";

		// Token: 0x04000703 RID: 1795
		private bool isLoadingFavourites = true;

		// Token: 0x04000704 RID: 1796
		private bool IsClearTriggered;

		// Token: 0x04000705 RID: 1797
		private bool IsItemDeleteTriggered;

		// Token: 0x04000706 RID: 1798
		private bool loadAsGrid;

		// Token: 0x04000707 RID: 1799
		private bool isReachedToEnd;

		// Token: 0x04000708 RID: 1800
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000709 RID: 1801
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x0400070A RID: 1802
		private DialogSigninPrompt mLoginFrag;
	}
}
