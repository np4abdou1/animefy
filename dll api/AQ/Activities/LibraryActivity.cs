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
using Firebase.Messaging;
using Google.Android.Material.Snackbar;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000CB RID: 203
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class LibraryActivity : AppCompatActivity
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x00032C94 File Offset: 0x00030E94
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
			this.library = this.Intent.GetStringExtra("Library");
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558452);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.libraryList = new List<AnimeModel>();
			this.libraryListHelper = new List<AnimeModel>();
			this.mContent = base.FindViewById<RelativeLayout>(2131363076);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362545);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mMoreLoader = base.FindViewById<CardView>(2131362546);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
			this.mEmptyViewIcon = base.FindViewById<ImageView>(2131362333);
			this.mEmptyViewMessage = base.FindViewById<TextView>(2131362334);
			if (this.library == "WATCH_CURRENTLY")
			{
				this.mEmptyViewIcon.SetImageResource(2131231004);
				this.SupportActionBar.SetTitle(2131952129);
				this.mEmptyViewMessage.Text = this.Resources.GetString(2131951983);
			}
			else if (this.library == "WATCH_LATER")
			{
				this.mEmptyViewIcon.SetImageResource(2131231186);
				this.SupportActionBar.SetTitle(2131952131);
				this.mEmptyViewMessage.Text = this.Resources.GetString(2131951985);
			}
			else
			{
				this.mEmptyViewIcon.SetImageResource(2131231225);
				this.SupportActionBar.SetTitle(2131952130);
				this.mEmptyViewMessage.Text = this.Resources.GetString(2131951984);
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
					this.LoadLibrary(0, false);
				});
			}
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00032FD8 File Offset: 0x000311D8
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1))
			{
				if (!this.isLibraryLoading && !this.isClearTriggered && !this.isItemRemoveTriggered && !this.isReachedToEnd)
				{
					this.isLibraryLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadLibrary(this.libraryList.Count<AnimeModel>(), true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLibraryLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00033065 File Offset: 0x00031265
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mOfflineView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLibrary(0, false);
			});
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00033094 File Offset: 0x00031294
		private void LoadLibrary(int from = 0, bool loadMore = false)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("library/library/library_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("Library", this.library);
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> libraryTempList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (libraryTempList != null)
						{
							if (loadMore)
							{
								if (libraryTempList.Count == 0)
								{
									this.isReachedToEnd = true;
								}
								else
								{
									this.libraryList.AddRange(libraryTempList);
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
							else if (libraryTempList.Count == 0)
							{
								this.mLoader.Visibility = ViewStates.Gone;
								this.mEmptyView.Visibility = ViewStates.Visible;
							}
							else
							{
								this.libraryList.Clear();
								this.libraryList.AddRange(libraryTempList);
								this.LoadAs(this.libraryList);
								this.mLoader.Visibility = ViewStates.Gone;
								this.recyclerView.Visibility = ViewStates.Visible;
							}
						}
						else if (loadMore)
						{
							this.mMoreLoader.StartAnimation(this.hideLoader);
							this.mMoreLoader.Visibility = ViewStates.Gone;
						}
						this.isLibraryLoading = false;
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
				}
			};
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0003318C File Offset: 0x0003138C
		private void ClearAll()
		{
			LibraryActivity.<ClearAll>d__35 <ClearAll>d__;
			<ClearAll>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ClearAll>d__.<>4__this = this;
			<ClearAll>d__.<>1__state = -1;
			<ClearAll>d__.<>t__builder.Start<LibraryActivity.<ClearAll>d__35>(ref <ClearAll>d__);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000331C3 File Offset: 0x000313C3
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.localMenu = menu;
			this.MenuInflater.Inflate(2131689497, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000331E4 File Offset: 0x000313E4
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 2131362625)
			{
				if (this.libraryList.Count<AnimeModel>() > 0)
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
						foreach (AnimeModel item2 in this.libraryList)
						{
							this.libraryListHelper.Add(item2);
						}
						int count = this.libraryList.Count<AnimeModel>();
						this.isClearTriggered = true;
						this.libraryList.RemoveRange(0, count);
						if (this.loadAsGrid)
						{
							this.adapterGrid.NotifyItemRangeRemoved(0, count);
						}
						else
						{
							this.adapterList.NotifyItemRangeRemoved(0, count);
						}
						this.mEmptyView.Visibility = ViewStates.Visible;
						Snackbar snackbar = CustomizedSnackbar.SnackBar(this.mContent, 2131952012, "");
						snackbar.SetAction(this.Resources.GetString(2131952546), delegate(View v)
						{
							this.isClearTriggered = false;
							this.libraryList.InsertRange(0, this.libraryListHelper);
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
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId == 2131362634 && this.libraryList.Count<AnimeModel>() > 0)
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
				this.LoadAs(this.libraryList);
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0003336C File Offset: 0x0003156C
		private void DeleteLibraryItem(int itemPos, AnimeModel item, bool move = false)
		{
			this.libraryList.Remove(item);
			if (this.loadAsGrid)
			{
				this.adapterGrid.NotifyItemRemoved(itemPos);
			}
			else
			{
				this.adapterList.NotifyItemRemoved(itemPos);
			}
			if (this.libraryList.Count<AnimeModel>() <= 0)
			{
				this.mEmptyView.Visibility = ViewStates.Visible;
			}
			this.isItemRemoveTriggered = true;
			if (!move)
			{
				Snackbar snackbar = Snackbar.Make(this.mContent, item.EN_Title + " " + this.Resources.GetString(2131952012), -1);
				snackbar.SetAction(this.Resources.GetString(2131952546), delegate(View v)
				{
					this.libraryList.Insert(itemPos, item);
					if (this.loadAsGrid)
					{
						this.adapterGrid.NotifyItemInserted(itemPos);
					}
					else
					{
						this.adapterList.NotifyItemInserted(itemPos);
					}
					if (this.libraryList.Count<AnimeModel>() <= 0)
					{
						this.mEmptyView.Visibility = ViewStates.Visible;
					}
					else
					{
						this.mEmptyView.Visibility = ViewStates.Gone;
					}
					this.isItemRemoveTriggered = false;
				}).Show();
			}
			Task task = new Task(delegate()
			{
				this.ItemDelete(item, move);
			});
			task.Start();
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00033474 File Offset: 0x00031674
		private void ItemDelete(AnimeModel item, bool move)
		{
			LibraryActivity.<ItemDelete>d__39 <ItemDelete>d__;
			<ItemDelete>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemDelete>d__.<>4__this = this;
			<ItemDelete>d__.item = item;
			<ItemDelete>d__.move = move;
			<ItemDelete>d__.<>1__state = -1;
			<ItemDelete>d__.<>t__builder.Start<LibraryActivity.<ItemDelete>d__39>(ref <ItemDelete>d__);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000334BC File Offset: 0x000316BC
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
			this.adapterList = new AnimeCatalogListAdapter(this, this.libraryList, true);
			this.adapterList.ItemClick += this.AdapterList_ItemClick;
			this.adapterList.ItemPlotClick += this.AdapterList_ItemPlotClick;
			this.adapterList.ItemOptionMenuClick += this.AdapterList_ItemOptionMenuClick;
			this.layoutManager = new GridLayoutManager(this, 1);
			this.recyclerView.SetLayoutManager(this.layoutManager);
			this.recyclerView.SetAdapter(this.adapterList);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000335CE File Offset: 0x000317CE
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			if (this.loadAsGrid)
			{
				this.layoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 140f));
				this.recyclerView.SetLayoutManager(this.layoutManager);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00033607 File Offset: 0x00031807
		private void AdapterList_ItemOptionMenuClick(object sender, int e)
		{
			this.OpenOptionMenu(e);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00033610 File Offset: 0x00031810
		private void AdapterList_ItemPlotClick(object sender, int e)
		{
			this.OpenPlot(e);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00033619 File Offset: 0x00031819
		private void AdapterList_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00033607 File Offset: 0x00031807
		private void AdapterGrid_ItemLongClick(object sender, int e)
		{
			this.OpenOptionMenu(e);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00033619 File Offset: 0x00031819
		private void AdapterGrid_ItemClick(object sender, int e)
		{
			this.GoToDetails(e);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00033624 File Offset: 0x00031824
		private void OpenOptionMenu(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LibraryActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel item = this.libraryList[itemPosition];
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
			menu.MenuInflater.Inflate(2131689498, menu.Menu);
			IMenuItem notificationItem = menu.Menu.FindItem(2131362549);
			if (item.Type == "MOVIE")
			{
				notificationItem.SetVisible(false);
			}
			else if (item.Status == "AIRED")
			{
				notificationItem.SetEnabled(false);
			}
			else if (NotificationsViewModel.IsNotifExist(item.AnimeId))
			{
				notificationItem.SetTitle(this.Resources.GetString(2131951925));
			}
			else
			{
				notificationItem.SetTitle(this.Resources.GetString(2131951926));
			}
			if (this.library == "WATCH_CURRENTLY")
			{
				menu.Menu.FindItem(2131362547).SetVisible(false);
				if (item.Status != "AIRED")
				{
					menu.Menu.FindItem(2131362548).SetEnabled(false);
				}
			}
			else if (this.library == "WATCH_DONE")
			{
				menu.Menu.FindItem(2131362548).SetVisible(false);
				menu.Menu.FindItem(2131362547).SetVisible(false);
			}
			else if (this.library == "WATCH_LATER" && item.Status != "AIRED")
			{
				menu.Menu.FindItem(2131362548).SetEnabled(false);
			}
			menu.Show();
			menu.DismissEvent += delegate(object se, [Nullable(1)] PopupMenu.DismissEventArgs ee)
			{
				menu.Dispose();
			};
			menu.MenuItemClick += delegate(object s1, [Nullable(1)] PopupMenu.MenuItemClickEventArgs arg1)
			{
				int itemId = arg1.Item.ItemId;
				if (itemId == 2131362544)
				{
					this.DeleteLibraryItem(itemPosition, this.libraryList[itemPosition], false);
				}
				else if (itemId == 2131362549)
				{
					if (item.Status == "AIRED")
					{
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951693), 2131230956);
					}
					else if (NotificationsViewModel.IsNotifExist(item.AnimeId))
					{
						notificationItem.SetTitle(this.Resources.GetString(2131951925));
						FirebaseMessaging.Instance.UnsubscribeFromTopic(item.AnimeId);
						NotificationsViewModel.DelNotif(item.AnimeId);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951927) + " " + item.EN_Title, 2131231141);
					}
					else
					{
						notificationItem.SetTitle(this.Resources.GetString(2131951926));
						FirebaseMessaging.Instance.SubscribeToTopic(item.AnimeId);
						NotificationsViewModel.InitializeNewNotif(item.AnimeId, item.EN_Title, item.Episodes);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951928) + " " + item.EN_Title, 2131231141);
					}
				}
				else if (itemId == 2131362547)
				{
					this.MoveToAnotherList(itemPosition, "WATCH_CURRENTLY", item);
				}
				else if (itemId == 2131362548)
				{
					this.MoveToAnotherList(itemPosition, "WATCH_DONE", item);
				}
				menu.Dismiss();
			};
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000338E0 File Offset: 0x00031AE0
		private void OpenPlot(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LibraryActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.libraryList[itemPosition];
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

		// Token: 0x060009EB RID: 2539 RVA: 0x0003398C File Offset: 0x00031B8C
		private void GoToDetails(int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < LibraryActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.libraryList[itemPosition];
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
			intent.PutExtra("Transition", this.isLibraryLoading);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00033C2C File Offset: 0x00031E2C
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok && requestCode == 1)
			{
				bool booleanExtra = data.GetBooleanExtra("DeleteOnReturn", false);
				int intExtra = data.GetIntExtra("ItemPosistion", 0);
				if (booleanExtra)
				{
					this.DeleteLibraryItem(intExtra, this.libraryList[intExtra], true);
				}
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00033C7C File Offset: 0x00031E7C
		private void MoveToAnotherList(int itemPosition, string library, AnimeModel item)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("library/library/library_crud.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("AnimeId", item.AnimeId);
			this.parameters.Add("Library", library);
			this.parameters.Add("Type", item.Type);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object sender2, UploadValuesCompletedEventArgs e2)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e2.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a == "DELETE" || a == "UPDATE")
					{
						this.DeleteLibraryItem(itemPosition, item, true);
						if (library == "WATCH_CURRENTLY")
						{
							CustomizedToast.ShowToast(this, this.Resources.GetString(2131952013) + " " + item.EN_Title, 2131231004);
						}
						else if (library == "WATCH_DONE")
						{
							CustomizedToast.ShowToast(this, this.Resources.GetString(2131952013) + " " + item.EN_Title, 2131231225);
						}
					}
				}
				catch
				{
				}
			};
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00033D80 File Offset: 0x00031F80
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			if (UsersModel.OnResumeLogin && this.mLoginFrag != null)
			{
				this.mLoginFrag.Dismiss();
				this.user = UsersViewModel.GetUserProfile();
				this.userId = ((this.user == null) ? 0 : this.user.UserID);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadLibrary(0, false);
				});
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000768 RID: 1896
		private UsersModel user;

		// Token: 0x04000769 RID: 1897
		private int userId;

		// Token: 0x0400076A RID: 1898
		private RecyclerView recyclerView;

		// Token: 0x0400076B RID: 1899
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x0400076C RID: 1900
		private AnimeCatalogGridAdapter adapterGrid;

		// Token: 0x0400076D RID: 1901
		private AnimeCatalogListAdapter adapterList;

		// Token: 0x0400076E RID: 1902
		private List<AnimeModel> libraryList;

		// Token: 0x0400076F RID: 1903
		private List<AnimeModel> libraryListHelper;

		// Token: 0x04000770 RID: 1904
		private RelativeLayout mContent;

		// Token: 0x04000771 RID: 1905
		private ProgressBar mLoader;

		// Token: 0x04000772 RID: 1906
		private RelativeLayout mOfflineView;

		// Token: 0x04000773 RID: 1907
		private Button mOfflineRetry;

		// Token: 0x04000774 RID: 1908
		private CardView mMoreLoader;

		// Token: 0x04000775 RID: 1909
		private RelativeLayout mEmptyView;

		// Token: 0x04000776 RID: 1910
		private ImageView mEmptyViewIcon;

		// Token: 0x04000777 RID: 1911
		private TextView mEmptyViewMessage;

		// Token: 0x04000778 RID: 1912
		private WebClient client;

		// Token: 0x04000779 RID: 1913
		private Uri uri;

		// Token: 0x0400077A RID: 1914
		private NameValueCollection parameters;

		// Token: 0x0400077B RID: 1915
		private Animation hideLoader;

		// Token: 0x0400077C RID: 1916
		private Animation showLoader;

		// Token: 0x0400077D RID: 1917
		private bool isClearTriggered;

		// Token: 0x0400077E RID: 1918
		private bool isItemRemoveTriggered;

		// Token: 0x0400077F RID: 1919
		private bool isLibraryLoading;

		// Token: 0x04000780 RID: 1920
		private bool isReachedToEnd;

		// Token: 0x04000781 RID: 1921
		private bool loadAsGrid;

		// Token: 0x04000782 RID: 1922
		private string library;

		// Token: 0x04000783 RID: 1923
		private DialogSigninPrompt mLoginFrag;

		// Token: 0x04000784 RID: 1924
		private IMenu localMenu;

		// Token: 0x04000785 RID: 1925
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000786 RID: 1926
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
