using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Com.Wang.Avi;
using Newtonsoft.Json;

namespace AQ.Activities
{
	// Token: 0x020000CF RID: 207
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class UserNotificationsActivity : AppCompatActivity
	{
		// Token: 0x06000A4D RID: 2637 RVA: 0x00036BF4 File Offset: 0x00034DF4
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
			this.OverridePendingTransition(2130772025, 2130772026);
			this.SetContentView(2131558461);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetTitle(2131952560);
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.notificationList = new List<UserNotificationsModel>();
			this.notificationListActualSize = new List<UserNotificationsModel>();
			this.recyclerView = base.FindViewById<RecyclerView>(2131363202);
			this.mLoader = base.FindViewById<AVLoadingIndicatorView>(2131363203);
			this.mSwiperRefresher = base.FindViewById<SwipeRefreshLayout>(2131362811);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.mEmptyView = base.FindViewById<RelativeLayout>(2131362332);
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
					this.LoadNotifications(0, false);
				});
			}
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
			this.mSwiperRefresher.Refresh += this.MSwiperRefresher_Refresh;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00036E27 File Offset: 0x00035027
		private void MSwiperRefresher_Refresh(object sender, EventArgs e)
		{
			this.Reload();
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00036E27 File Offset: 0x00035027
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.Reload();
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00036E2F File Offset: 0x0003502F
		private void Reload()
		{
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mEmptyView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadNotifications(0, false);
			});
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00036E67 File Offset: 0x00035067
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1) && !this.isLoading)
			{
				this.isLoading = true;
				this.mLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadNotifications(this.notificationListActualSize.Count<UserNotificationsModel>(), true);
				});
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00036EA4 File Offset: 0x000350A4
		private void LoadNotifications(int from = 0, bool loadMore = false)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("users/notifications/notification_load.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			Action <>9__1;
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<UserNotificationsModel> tmpList = JsonConvert.DeserializeObject<List<UserNotificationsModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (tmpList != null)
						{
							if (loadMore)
							{
								this.notificationList.AddRange(from p in tmpList
								where p != null
								select p);
								this.notificationListActualSize.AddRange(tmpList);
								this.adapter.NotifyDataSetChanged();
								this.mLoader.Visibility = ViewStates.Gone;
							}
							else
							{
								this.notificationList.Clear();
								this.notificationList.AddRange(from p in tmpList
								where p != null
								select p);
								this.notificationListActualSize.AddRange(tmpList);
								if (this.notificationList.Count<UserNotificationsModel>() == 0)
								{
									this.mEmptyView.Visibility = ViewStates.Visible;
									this.recyclerView.Visibility = ViewStates.Gone;
								}
								else
								{
									this.adapter = new UserNotificationsAdapter(this, this.notificationList, SharedPreferencesSaves.IntSharedPreferencesGet("LatestNotificationId"));
									this.adapter.ItemClick += this.Adapter_ItemClick;
									this.adapter.ItemAvatarClick += this.Adapter_ItemAvatarClick;
									this.adapter.ItemLongClick += this.Adapter_ItemLongClick;
									this.layoutManager = new GridLayoutManager(this, 1);
									this.recyclerView.SetLayoutManager(this.layoutManager);
									this.layoutManager.AutoMeasureEnabled = true;
									this.recyclerView.SetAdapter(this.adapter);
									this.recyclerView.Visibility = ViewStates.Visible;
									SharedPreferencesSaves.IntSharedPreferencesSave("LatestNotificationId", this.notificationList[0].Id);
								}
								this.mLoader.Visibility = ViewStates.Gone;
							}
							this.mSwiperRefresher.Refreshing = false;
							this.isLoading = false;
							return;
						}
						if (loadMore)
						{
							this.mLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mLoader.Visibility = ViewStates.Gone;
							this.recyclerView.Visibility = ViewStates.Gone;
							this.mOfflineView.Visibility = ViewStates.Visible;
						}
						this.isLoading = false;
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
								this.mLoader.Visibility = ViewStates.Gone;
							}
							else
							{
								this.mLoader.Visibility = ViewStates.Gone;
								this.recyclerView.Visibility = ViewStates.Gone;
								this.mOfflineView.Visibility = ViewStates.Visible;
							}
							this.isLoading = false;
							this.mSwiperRefresher.Refreshing = false;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00036F88 File Offset: 0x00035188
		private void Adapter_ItemAvatarClick(object sender, int e)
		{
			UserNotificationsModel userNotificationsModel = this.notificationList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("UserId", userNotificationsModel.User.UserID.ToString());
			bundle.PutString("DisplayName", userNotificationsModel.User.FullName);
			bundle.PutString("Bio", userNotificationsModel.User.Bio);
			bundle.PutString("Gender", userNotificationsModel.User.Gender);
			bundle.PutString("Membership", userNotificationsModel.User.Membership);
			bundle.PutString("ProfilePhoto", userNotificationsModel.User.ProfileImage);
			bundle.PutString("GglPforilePhoto", userNotificationsModel.User.GoogleProfilePhotoUrl);
			bundle.PutString("ProfileCover", userNotificationsModel.User.ProfileCover);
			bundle.PutInt("LibraryViewAllowed", userNotificationsModel.User.AllowLibraryView);
			DialogUserProfile dialogUserProfile = new DialogUserProfile();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogUserProfile.Arguments = bundle;
			dialogUserProfile.Show(transaction, "DialogUserProfile");
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000370A0 File Offset: 0x000352A0
		private void Adapter_ItemLongClick(object sender, int e)
		{
			UserNotificationsModel item = this.notificationList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			LinearLayout anchor = itemView.FindViewById<LinearLayout>(2131362801);
			PopupMenu menu = new PopupMenu(itemView.Context, anchor);
			menu.MenuInflater.Inflate(2131689504, menu.Menu);
			menu.Show();
			menu.DismissEvent += delegate(object se, [Nullable(1)] PopupMenu.DismissEventArgs ee)
			{
				menu.Dispose();
			};
			UploadValuesCompletedEventHandler <>9__2;
			menu.MenuItemClick += delegate(object s1, [Nullable(1)] PopupMenu.MenuItemClickEventArgs arg1)
			{
				int itemId = arg1.Item.ItemId;
				if (itemId == 2131362643)
				{
					WebClient webClient = new WebClient();
					Uri address = new Uri(Constants.ApiPhp("users/notifications/notification_delete.php"));
					webClient.UploadValuesAsync(address, new NameValueCollection
					{
						{
							"UserId",
							this.userId.ToString()
						},
						{
							"NotificationId",
							item.Id.ToString()
						},
						{
							"Token",
							"8cnY80AZSbUCmR26Vku1VUUY4"
						}
					});
					WebClient webClient2 = webClient;
					UploadValuesCompletedEventHandler value;
					if ((value = <>9__2) == null)
					{
						value = (<>9__2 = delegate(object s, UploadValuesCompletedEventArgs ne)
						{
							this.RunOnUiThread(delegate()
							{
								try
								{
									string @string = Encoding.UTF8.GetString(ne.Result);
									string a = JsonConvert.DeserializeObject<string>(@string);
									if (a == "DONE")
									{
										this.notificationList.Remove(item);
										this.adapter.NotifyItemRemoved(e);
										if (this.notificationList.Count<UserNotificationsModel>() == 0)
										{
											this.mEmptyView.Visibility = ViewStates.Visible;
											this.recyclerView.Visibility = ViewStates.Gone;
										}
									}
								}
								catch
								{
									CustomizedToast.ShowToast(this, this.Resources.GetString(2131951821), 0);
								}
							});
						});
					}
					webClient2.UploadValuesCompleted += value;
				}
				menu.Dismiss();
			};
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00037168 File Offset: 0x00035368
		private void Adapter_ItemClick(object sender, int e)
		{
			UserNotificationsModel userNotificationsModel = this.notificationList[e];
			Bundle bundle = new Bundle();
			if (userNotificationsModel.Subject == "REPLY")
			{
				bundle.PutInt("CommId", userNotificationsModel.Reply.CommID);
			}
			else if (userNotificationsModel.Subject == "COMMENT")
			{
				bundle.PutInt("CommId", userNotificationsModel.Comment.CommID);
			}
			else
			{
				bundle.PutInt("CommId", userNotificationsModel.SubjectId);
			}
			bundle.PutBoolean("IsCommentLoadNeeded", true);
			CommentsReplies commentsReplies = new CommentsReplies();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			commentsReplies.Arguments = bundle;
			commentsReplies.Show(transaction, "CommentRepliesFragment");
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0003721F File Offset: 0x0003541F
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689503, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0003723C File Offset: 0x0003543C
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId != 2131362803)
			{
				return base.OnOptionsItemSelected(item);
			}
			if (this.notificationList.Count<UserNotificationsModel>() != 0)
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
					WebClient webClient = new WebClient();
					Uri address = new Uri(Constants.ApiPhp("users/notifications/notification_delete_all.php"));
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
					webClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs ne)
					{
						base.RunOnUiThread(delegate()
						{
							try
							{
								string @string = Encoding.UTF8.GetString(ne.Result);
								string a = JsonConvert.DeserializeObject<string>(@string);
								if (a == "DONE")
								{
									this.mSwiperRefresher.Refreshing = true;
									ThreadPool.QueueUserWorkItem(delegate(object o)
									{
										this.LoadNotifications(0, false);
									});
								}
							}
							catch
							{
								CustomizedToast.ShowToast(this, this.Resources.GetString(2131951821), 0);
							}
						});
					};
					dialog.Dismiss();
				};
				button2.Click += delegate(object <p0>, EventArgs <p1>)
				{
					dialog.Dismiss();
				};
			}
			return true;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0003733C File Offset: 0x0003553C
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
					this.LoadNotifications(0, false);
				});
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x040007EC RID: 2028
		private UsersModel user;

		// Token: 0x040007ED RID: 2029
		private int userId;

		// Token: 0x040007EE RID: 2030
		private RecyclerView recyclerView;

		// Token: 0x040007EF RID: 2031
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x040007F0 RID: 2032
		private UserNotificationsAdapter adapter;

		// Token: 0x040007F1 RID: 2033
		private WebClient mClient;

		// Token: 0x040007F2 RID: 2034
		private Uri mUri;

		// Token: 0x040007F3 RID: 2035
		private NameValueCollection parameters;

		// Token: 0x040007F4 RID: 2036
		private List<UserNotificationsModel> notificationList;

		// Token: 0x040007F5 RID: 2037
		private List<UserNotificationsModel> notificationListActualSize;

		// Token: 0x040007F6 RID: 2038
		private AVLoadingIndicatorView mLoader;

		// Token: 0x040007F7 RID: 2039
		private SwipeRefreshLayout mSwiperRefresher;

		// Token: 0x040007F8 RID: 2040
		private RelativeLayout mOfflineView;

		// Token: 0x040007F9 RID: 2041
		private Button mOfflineRetry;

		// Token: 0x040007FA RID: 2042
		private RelativeLayout mEmptyView;

		// Token: 0x040007FB RID: 2043
		private DialogSigninPrompt mLoginFrag;

		// Token: 0x040007FC RID: 2044
		private bool isLoading;
	}
}
