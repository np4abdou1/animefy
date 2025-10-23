using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Text;
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
using Bumptech.Glide;
using Java.Lang;
using Newtonsoft.Json;
using Refractored.Controls;

namespace AQ.Dialogs
{
	// Token: 0x020000AF RID: 175
	public class Comments : DialogFragment
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x0001E6F8 File Offset: 0x0001C8F8
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			string a = SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme");
			if (a == "BLUE")
			{
				this.SetStyle(1, 2132017169);
				return;
			}
			if (a == "PINK")
			{
				this.SetStyle(1, 2132017178);
				return;
			}
			if (!(a == "LIGHT_GRAY"))
			{
				this.SetStyle(1, 2132017172);
				return;
			}
			this.SetStyle(1, 2132017175);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0001E774 File Offset: 0x0001C974
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558439, container, false);
			this.Dialog.Window.SetSoftInputMode(SoftInput.AdjustResize);
			this.animeId = base.Arguments.GetString("AnimeID", "N/A");
			this.commType = base.Arguments.GetString("CommType", "N/A");
			this.episode = base.Arguments.GetFloat("Episode", 0f);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.membership = ((this.user == null) ? "" : this.user.Membership);
			if (this.user != null)
			{
				this.mCommentFieldAvatar = this.view.FindViewById<CircleImageView>(2131362209);
				if (this.user.ProfileImage != "")
				{
					Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).Into(this.mCommentFieldAvatar);
				}
				else if (this.user.GoogleProfilePhotoUrl != "")
				{
					Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).Into(this.mCommentFieldAvatar);
				}
			}
			this.mReloadBtn = this.view.FindViewById<ImageView>(2131362187);
			this.mReloadBtn.Click += this.MReloadBtn_Click;
			this.mCommentsLoader = this.view.FindViewById<ProgressBar>(2131362835);
			this.mCommentSendLoader = this.view.FindViewById<ProgressBar>(2131362204);
			this.mSpoiler = this.view.FindViewById<CheckBox>(2131362160);
			this.mMoreLoader = this.view.FindViewById<CardView>(2131362201);
			this.mNoComments = this.view.FindViewById<LinearLayout>(2131362790);
			this.mSendConetnet = this.view.FindViewById<FrameLayout>(2131362199);
			this.mSortbySpinner = this.view.FindViewById<Spinner>(2131362205);
			this.recyclerView = this.view.FindViewById<RecyclerView>(2131362918);
			this.mTypingField = this.view.FindViewById<EditText>(2131362207);
			this.mSendButton = this.view.FindViewById<ImageView>(2131362203);
			this.sendReady = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			this.sendNotReady = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.hideLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			this.mSortbySpinner.ItemSelected += this.spinner_ItemSelected;
			ArrayAdapter arrayAdapter = ArrayAdapter.CreateFromResource(this.view.Context, 2130903042, 17367048);
			arrayAdapter.SetDropDownViewResource(17367049);
			this.mSortbySpinner.Adapter = arrayAdapter;
			if (SharedPreferencesSaves.IntSharedPreferencesGet("CommentsStatus") != 0)
			{
				Bundle bundle = new Bundle();
				bundle.PutString("DialogTitle", base.Resources.GetString(2131952502));
				bundle.PutString("DialogMessage", base.Resources.GetString(2131951794));
				PageClose pageClose = new PageClose();
				FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
				pageClose.Arguments = bundle;
				pageClose.Show(transaction, "DialogPopupMessage");
				this.Dismiss();
			}
			else
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadComments();
				});
			}
			this.mSendButton.Click += this.MSendButton_Click;
			this.mTypingField.TextChanged += this.MTypingField_TextChanged;
			this.recyclerView.ScrollChange += this.RecyclerView_ScrollChange;
			this.mSpoiler.CheckedChange += this.MSpoiler_CheckedChange;
			return this.view;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001EB95 File Offset: 0x0001CD95
		private void MSpoiler_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.spoiler = 1;
				return;
			}
			this.spoiler = 0;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		private void RecyclerView_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.recyclerView.CanScrollVertically(1) && !this.IsLoadingMore)
			{
				int num = this.mCommentsList.Count<CommentsModel>();
				if (num >= 25)
				{
					this.IsLoadingMore = true;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					this.LoadMoreComments(num);
				}
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001EC0F File Offset: 0x0001CE0F
		private void MReloadBtn_Click(object sender, EventArgs e)
		{
			this.mReloadBtn.Visibility = ViewStates.Gone;
			this.mCommentsLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadComments();
			});
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0001EC3C File Offset: 0x0001CE3C
		private void MTypingField_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.mTypingField.Text.Trim() == "")
			{
				if (this.IsSendAnimated)
				{
					this.mSendButton.StartAnimation(this.sendNotReady);
					this.mSendConetnet.Visibility = ViewStates.Gone;
					this.mSpoiler.Visibility = ViewStates.Gone;
					this.mSendButton.Clickable = false;
					this.IsSendAnimated = false;
					this.IsEditModeOn = false;
					this.mSpoiler.Checked = false;
					return;
				}
			}
			else if (!this.IsSendAnimated)
			{
				this.mSendButton.StartAnimation(this.sendReady);
				this.mSendConetnet.Visibility = ViewStates.Visible;
				this.mSpoiler.Visibility = ViewStates.Visible;
				this.mSendButton.Clickable = true;
				this.IsSendAnimated = true;
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0001ED04 File Offset: 0x0001CF04
		private void MSendButton_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (this.mTypingField.Text.StartsWith("/") && this.membership != "ADMIN")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952599), 0);
				return;
			}
			if (this.user.CommunicationStatus == "BLOCK")
			{
				CommunicationBlock communicationBlock = new CommunicationBlock();
				FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
				communicationBlock.Show(transaction, "BlockedDialog");
				return;
			}
			this.mSendButton.StartAnimation(this.sendNotReady);
			this.mSendButton.Clickable = false;
			this.IsSendAnimated = false;
			this.mCommentSendLoader.Visibility = ViewStates.Visible;
			if (this.IsEditModeOn)
			{
				this.EditComment();
				return;
			}
			this.AddComment(this.mTypingField.Text, this.userId, this.animeId, this.commType, this.episode);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0001EE1C File Offset: 0x0001D01C
		private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			if (this.mCommentsList == null)
			{
				return;
			}
			int selectedItemPosition = this.mSortbySpinner.SelectedItemPosition;
			if (selectedItemPosition == 0)
			{
				this.orderBy = "Most_Popular";
				this.mCommentsList = (from p in this.mCommentsList
				orderby p.Pinned descending, p.LikesCount + p.DislikesCount descending
				select p).ToList<CommentsModel>();
				this.adapter = new CommentsListAdapter(this.view.Context, this.mCommentsList);
				this.recyclerView.SetAdapter(this.adapter);
			}
			else if (selectedItemPosition == 1)
			{
				this.orderBy = "Newest";
				this.excludedComments = "";
				this.mReloadBtn.Visibility = ViewStates.Gone;
				this.mCommentsLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadComments();
				});
			}
			else
			{
				this.orderBy = "Oldest";
				this.excludedComments = "";
				this.mReloadBtn.Visibility = ViewStates.Gone;
				this.mCommentsLoader.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadComments();
				});
			}
			this.adapter.ItemClick += this.Adapter_ItemClick;
			this.adapter.ItemOptionMenuClick += this.Adapter_ItemOptionMenuClick;
			this.adapter.ItemShowHideReplies += this.Adapter_ItemShowHideReplies;
			this.adapter.ItemShowReplies += this.Adapter_ItemShowReplies;
			this.adapter.ItemLikeClick += this.Adapter_ItemLikeClick;
			this.adapter.ItemDislikeClick += this.Adapter_ItemDislikeClick;
			this.adapter.ItemProfilePhotoClick += this.Adapter_ItemProfilePhotoClick;
			this.adapter.ItemShowSpoilerClick += this.Adapter_ItemShowSpoilerClick;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0001F018 File Offset: 0x0001D218
		public void AddComment(string body, int userId, string animeId, string type, float episode = 0f)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/comments_add.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("CommBody", body.Trim());
			this.parameters.Add("UserID", userId.ToString());
			this.parameters.Add("AnimeID", animeId);
			this.parameters.Add("Episode", episode.ToString());
			this.parameters.Add("Spoiler", this.spoiler.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("CommType", type);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mLastComment = JsonConvert.DeserializeObject<CommentsModel>(@string);
					if (this.mLastComment != null)
					{
						this.excludedComments = this.excludedComments + this.mLastComment.CommID.ToString() + ",";
						this.mCommentsList.Insert(0, this.mLastComment);
						this.mTypingField.Text = "";
						this.adapter.NotifyItemInserted(0);
						this.mNoComments.Visibility = ViewStates.Gone;
						this.mSendButton.Clickable = false;
						this.recyclerView.ScrollToPosition(0);
						this.mSpoiler.Checked = false;
					}
					else
					{
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951828), 0);
						this.mSendButton.StartAnimation(this.sendReady);
						this.mSendButton.Clickable = true;
						this.IsSendAnimated = true;
					}
					this.mCommentSendLoader.Visibility = ViewStates.Gone;
					this.mSpoiler.Visibility = ViewStates.Gone;
					this.mSendConetnet.Visibility = ViewStates.Gone;
				}
				catch
				{
					CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951828), 0);
					this.mCommentSendLoader.Visibility = ViewStates.Gone;
					this.mSendButton.StartAnimation(this.sendReady);
					this.mSendButton.Clickable = true;
					this.IsSendAnimated = true;
				}
			};
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001F138 File Offset: 0x0001D338
		public void EditComment()
		{
			CommentsModel item = this.mCommentsList[this.latestEditPosition];
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/comments_update.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("CommID", item.CommID.ToString());
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("CommBody", this.mTypingField.Text.Trim());
			this.parameters.Add("Spoiler", this.spoiler.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sss, UploadValuesCompletedEventArgs eee)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(eee.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a == "DONE")
					{
						if (this.mTypingField.Text.StartsWith("/"))
						{
							this.mCommBodyView.Text = this.Resources.GetString(2131952464);
							this.mCommBodyView.SetTextColor(Color.ParseColor("#b3b3b3"));
							this.mCommBodyView.SetTypeface(this.mCommBodyView.Typeface, TypefaceStyle.Italic);
						}
						else
						{
							this.mCommBodyView.Text = this.mTypingField.Text;
							this.mCommBodyView.Post(new ReedMoreHelper(this.view.Context, this.mCommBodyView));
						}
						if (this.spoiler == 1)
						{
							this.mCommBodyView.Visibility = ViewStates.Gone;
							this.mSpoilerMessage.Visibility = ViewStates.Visible;
						}
						else
						{
							this.mCommBodyView.Visibility = ViewStates.Visible;
							this.mSpoilerMessage.Visibility = ViewStates.Gone;
						}
						item.Spoiler = this.spoiler;
						item.CommBody = this.mTypingField.Text;
						this.mSpoiler.Checked = false;
						this.mTypingField.Text = "";
						this.mCommentSendLoader.Visibility = ViewStates.Gone;
						this.mSendConetnet.Visibility = ViewStates.Gone;
						this.mSpoiler.Visibility = ViewStates.Gone;
						this.IsEditModeOn = false;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951792), 0);
					}
					else
					{
						this.mCommentSendLoader.Visibility = ViewStates.Gone;
						this.mSendButton.StartAnimation(this.sendReady);
						this.mSendButton.Clickable = true;
						this.IsSendAnimated = true;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951917), 0);
					}
				}
				catch
				{
					this.mCommentSendLoader.Visibility = ViewStates.Gone;
					this.mSendButton.StartAnimation(this.sendReady);
					this.mSendButton.Clickable = true;
					this.IsSendAnimated = true;
					CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951821), 0);
				}
				this.mOptionMenu.Visibility = ViewStates.Visible;
				this.mOptionMenuLoader.Visibility = ViewStates.Gone;
			};
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0001F250 File Offset: 0x0001D450
		private void LoadComments()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/comments_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("AnimeID", this.animeId);
			this.parameters.Add("CommType", this.commType);
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("Episode", this.episode.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("From", 0.ToString());
			this.parameters.Add("OrderBy", this.orderBy);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.parameters.Add("ExcludedComments", (this.excludedComments == "") ? "" : this.excludedComments.Remove(this.excludedComments.Length - 1));
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				if (this.IsDismissed)
				{
					return;
				}
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mCommentsList = JsonConvert.DeserializeObject<List<CommentsModel>>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (this.mCommentsList != null)
						{
							if (this.mCommentsList.Count <= 0)
							{
								this.mNoComments.Visibility = ViewStates.Visible;
							}
							if (this.orderBy == "Most_Popular")
							{
								this.mCommentsList = (from p in this.mCommentsList
								orderby p.Pinned descending, p.LikesCount + p.DislikesCount descending
								select p).ToList<CommentsModel>();
							}
							this.adapter = new CommentsListAdapter(this.view.Context, this.mCommentsList);
							this.adapter.ItemClick += this.Adapter_ItemClick;
							this.adapter.ItemOptionMenuClick += this.Adapter_ItemOptionMenuClick;
							this.adapter.ItemShowHideReplies += this.Adapter_ItemShowHideReplies;
							this.adapter.ItemShowReplies += this.Adapter_ItemShowReplies;
							this.adapter.ItemLikeClick += this.Adapter_ItemLikeClick;
							this.adapter.ItemDislikeClick += this.Adapter_ItemDislikeClick;
							this.adapter.ItemProfilePhotoClick += this.Adapter_ItemProfilePhotoClick;
							this.adapter.ItemShowSpoilerClick += this.Adapter_ItemShowSpoilerClick;
							this.layoutManager = new GridLayoutManager(this.view.Context, 1);
							this.recyclerView.SetLayoutManager(this.layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
							this.mCommentsLoader.Visibility = ViewStates.Gone;
							return;
						}
						this.mReloadBtn.Visibility = ViewStates.Visible;
						this.mCommentsLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.mReloadBtn.Visibility = ViewStates.Visible;
						this.mCommentsLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951826), 0);
					});
				}
			};
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0001F3C0 File Offset: 0x0001D5C0
		private void Adapter_ItemOptionMenuClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < Comments.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CommentsModel item = this.mCommentsList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			this.mOptionMenu = itemView.FindViewById<ImageView>(2131362217);
			this.mOptionMenuLoader = itemView.FindViewById<ProgressBar>(2131362219);
			this.mCommBodyView = itemView.FindViewById<TextView>(2131362210);
			this.mSpoilerMessage = itemView.FindViewById<LinearLayout>(2131363089);
			PopupMenu menu = new PopupMenu(itemView.Context, this.mOptionMenu);
			if (item.User.UserID == this.userId || this.membership == "ADMIN")
			{
				menu.MenuInflater.Inflate(2131689487, menu.Menu);
				if (this.membership == "ADMIN")
				{
					if (item.User.CommunicationStatus == "OK")
					{
						menu.Menu.FindItem(2131362618).SetTitle(base.Resources.GetString(2131951731));
					}
					else
					{
						menu.Menu.FindItem(2131362618).SetTitle(base.Resources.GetString(2131952545));
					}
					if (item.Pinned == 0)
					{
						menu.Menu.FindItem(2131362646).SetTitle(base.Resources.GetString(2131952295));
					}
					else
					{
						menu.Menu.FindItem(2131362646).SetTitle(base.Resources.GetString(2131952549));
					}
					menu.Menu.FindItem(2131362646).SetVisible(true);
					menu.Menu.FindItem(2131362618).SetVisible(true);
				}
			}
			else
			{
				menu.MenuInflater.Inflate(2131689486, menu.Menu);
			}
			menu.Show();
			menu.DismissEvent += delegate(object se, [Nullable(1)] PopupMenu.DismissEventArgs ee)
			{
				menu.Dispose();
			};
			UploadValuesCompletedEventHandler <>9__2;
			UploadValuesCompletedEventHandler <>9__5;
			menu.MenuItemClick += delegate(object s1, [Nullable(1)] PopupMenu.MenuItemClickEventArgs arg1)
			{
				int itemId = arg1.Item.ItemId;
				if (itemId == 2131362652)
				{
					this.mClient = new WebClient();
					this.mUri = new Uri(Constants.ApiPhp("comments/report.php"));
					this.parameters = new NameValueCollection();
					this.parameters.Add("CommentId", item.CommID.ToString());
					this.parameters.Add("ReporterId", this.userId.ToString());
					this.parameters.Add("CommentBody", item.CommBody);
					this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
					this.mClient.UploadValuesAsync(this.mUri, this.parameters);
					WebClient webClient = this.mClient;
					UploadValuesCompletedEventHandler value;
					if ((value = <>9__2) == null)
					{
						value = (<>9__2 = delegate(object ss, UploadValuesCompletedEventArgs ee)
						{
							try
							{
								string @string = Encoding.UTF8.GetString(ee.Result);
								string a = JsonConvert.DeserializeObject<string>(@string);
								if (a == "INSERT")
								{
									CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952339), 0);
								}
							}
							catch
							{
								CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951833), 0);
							}
						});
					}
					webClient.UploadValuesCompleted += value;
					menu.Dismiss();
					return;
				}
				if (itemId == 2131362629)
				{
					if (item.CommBody.StartsWith("/") && this.membership != "ADMIN")
					{
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951750), 0);
					}
					else if (item.User.CommunicationStatus == "BLOCK" && this.membership != "ADMIN")
					{
						CommunicationBlock communicationBlock = new CommunicationBlock();
						FragmentTransaction transaction = this.ParentFragmentManager.BeginTransaction();
						communicationBlock.Show(transaction, "BlockedDialog");
					}
					else if (item.CommBody.StartsWith("/") && this.membership != "ADMIN")
					{
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952599), 0);
					}
					else
					{
						this.latestEditPosition = e;
						this.IsEditModeOn = true;
						if (item.Spoiler == 1)
						{
							this.mSpoiler.Checked = true;
						}
						else
						{
							this.mSpoiler.Checked = false;
						}
						this.mTypingField.Text = item.CommBody;
						this.mTypingField.RequestFocus();
						this.mTypingField.SetSelection(this.mTypingField.Text.Length);
					}
					menu.Dismiss();
					return;
				}
				if (itemId == 2131362626)
				{
					if (item.CommBody.StartsWith("/") && this.membership != "ADMIN")
					{
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951751), 0);
						return;
					}
					this.mOptionMenu.Visibility = ViewStates.Gone;
					this.mOptionMenuLoader.Visibility = ViewStates.Visible;
					View view = LayoutInflater.From(this.view.Context).Inflate(2131558618, null);
					view.FindViewById<TextView>(2131362279).Text = view.Resources.GetString(2131951863);
					Button button = view.FindViewById<Button>(2131362300);
					Button button2 = view.FindViewById<Button>(2131362263);
					AlertDialog.Builder builder = new AlertDialog.Builder(this.view.Context);
					builder.SetView(view);
					builder.SetCancelable(false);
					AlertDialog dialog = builder.Create();
					dialog.Show();
					button.Click += delegate(object <p0>, EventArgs <p1>)
					{
						this.mTypingField.Text = "";
						this.mClient = new WebClient();
						this.mUri = new Uri(Constants.ApiPhp("comments/comments_delete.php"));
						this.parameters = new NameValueCollection();
						this.parameters.Add("CommID", item.CommID.ToString());
						if (this.membership == "ADMIN")
						{
							this.parameters.Add("UserID", item.User.UserID.ToString());
						}
						else
						{
							this.parameters.Add("UserID", this.userId.ToString());
						}
						this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
						this.mClient.UploadValuesAsync(this.mUri, this.parameters);
						WebClient webClient2 = this.mClient;
						UploadValuesCompletedEventHandler value2;
						if ((value2 = <>9__5) == null)
						{
							value2 = (<>9__5 = delegate(object sss, UploadValuesCompletedEventArgs eee)
							{
								try
								{
									string @string = Encoding.UTF8.GetString(eee.Result);
									string a = JsonConvert.DeserializeObject<string>(@string);
									if (a == "DONE")
									{
										this.mCommentsList.Remove(item);
										this.adapter.NotifyItemRemoved(e);
										if (this.mCommentsList.Count <= 0)
										{
											this.mNoComments.Visibility = ViewStates.Visible;
										}
									}
									this.mOptionMenu.Visibility = ViewStates.Visible;
									this.mOptionMenuLoader.Visibility = ViewStates.Gone;
								}
								catch
								{
									this.mOptionMenu.Visibility = ViewStates.Visible;
									this.mOptionMenuLoader.Visibility = ViewStates.Gone;
									CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951913), 0);
								}
							});
						}
						webClient2.UploadValuesCompleted += value2;
						dialog.Dismiss();
					};
					button2.Click += delegate(object <p0>, EventArgs <p1>)
					{
						dialog.Dismiss();
						this.mOptionMenu.Visibility = ViewStates.Visible;
						this.mOptionMenuLoader.Visibility = ViewStates.Gone;
					};
					return;
				}
				else
				{
					if (itemId == 2131362651)
					{
						this.OpenReplies(item);
						return;
					}
					if (itemId != 2131362618)
					{
						if (itemId == 2131362646)
						{
							if (item.Pinned == 0)
							{
								CommentsViewModel.CommentPin(this.view.Context, item.CommID, 1);
								item.Pinned = 1;
								itemView.FindViewById<LinearLayout>(2131362847).Visibility = ViewStates.Visible;
								return;
							}
							CommentsViewModel.CommentPin(this.view.Context, item.CommID, 0);
							item.Pinned = 0;
							itemView.FindViewById<LinearLayout>(2131362847).Visibility = ViewStates.Gone;
						}
						return;
					}
					if (item.User.CommunicationStatus == "OK")
					{
						CommentsViewModel.CommentBlockUser(this.view.Context, item.UserID, "BLOCK");
						item.User.CommunicationStatus = "BLOCK";
						return;
					}
					CommentsViewModel.CommentBlockUser(this.view.Context, item.UserID, "OK");
					item.User.CommunicationStatus = "OK";
					return;
				}
			};
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001F673 File Offset: 0x0001D873
		private void Adapter_ItemClick(object sender, int e)
		{
			this.OpenReplies(this.mCommentsList[e]);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0001F673 File Offset: 0x0001D873
		private void Adapter_ItemShowReplies(object sender, int e)
		{
			this.OpenReplies(this.mCommentsList[e]);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0001F673 File Offset: 0x0001D873
		private void Adapter_ItemShowHideReplies(object sender, int e)
		{
			this.OpenReplies(this.mCommentsList[e]);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0001F688 File Offset: 0x0001D888
		private void OpenReplies(CommentsModel item)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < Comments.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutInt("CommId", item.CommID);
			bundle.PutString("CommBody", item.CommBody);
			bundle.PutString("CommTime", item.CommTime);
			bundle.PutInt("CommLikes", item.LikesCount);
			bundle.PutInt("CommDislikes", item.DislikesCount);
			bundle.PutString("LikeOrDislike", item.LikeOrDislike);
			bundle.PutInt("Spoiler", item.Spoiler);
			bundle.PutInt("Pinned", item.Pinned);
			bundle.PutInt("CommUserId", item.User.UserID);
			bundle.PutString("Fullname", item.User.FullName);
			bundle.PutString("Bio", item.User.Bio);
			bundle.PutString("Gender", item.User.Gender);
			bundle.PutString("ProfilePhoto", item.User.ProfileImage);
			bundle.PutString("GooglePhotoUrl", item.User.GoogleProfilePhotoUrl);
			bundle.PutString("ProfileCover", item.User.ProfileCover);
			bundle.PutString("UserStatus", item.User.CommunicationStatus);
			bundle.PutString("MembershipLevel", item.User.Membership);
			bundle.PutInt("AllowLibraryView", item.User.AllowLibraryView);
			CommentsReplies commentsReplies = new CommentsReplies();
			FragmentTransaction fragmentTransaction = base.ParentFragmentManager.BeginTransaction();
			fragmentTransaction.SetCustomAnimations(2130772024, 2130772027);
			commentsReplies.Arguments = bundle;
			commentsReplies.Show(fragmentTransaction, "CommentRepliesFragment");
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001F854 File Offset: 0x0001DA54
		private void Adapter_ItemShowSpoilerClick(object sender, int e)
		{
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			itemView.FindViewById<LinearLayout>(2131363089).Visibility = ViewStates.Gone;
			itemView.FindViewById<TextView>(2131362210).Visibility = ViewStates.Visible;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001F898 File Offset: 0x0001DA98
		private void LoadMoreComments(int from)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/comments_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("AnimeID", this.animeId);
			this.parameters.Add("CommType", this.commType);
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("Episode", this.episode.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("OrderBy", this.orderBy);
			this.parameters.Add("ExcludedComments", (this.excludedComments == "") ? "" : this.excludedComments.Remove(this.excludedComments.Length - 1));
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				if (this.IsDismissed)
				{
					return;
				}
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<CommentsModel> list = JsonConvert.DeserializeObject<List<CommentsModel>>(@string);
					if (list.Count != 0)
					{
						if (this.orderBy == "Most_Popular")
						{
							this.mCommentsList.AddRange((from p in list
							orderby p.Pinned descending, p.LikesCount + p.DislikesCount descending
							select p).ToList<CommentsModel>());
						}
						else
						{
							this.mCommentsList.AddRange(list);
						}
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
					CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0001FA04 File Offset: 0x0001DC04
		private void Adapter_ItemProfilePhotoClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < Comments.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CommentsModel commentsModel = this.mCommentsList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("UserId", commentsModel.User.UserID.ToString());
			bundle.PutString("DisplayName", commentsModel.User.FullName);
			bundle.PutString("Bio", commentsModel.User.Bio);
			bundle.PutString("Gender", commentsModel.User.Gender);
			bundle.PutString("Membership", commentsModel.User.Membership);
			bundle.PutString("ProfilePhoto", commentsModel.User.ProfileImage);
			bundle.PutString("GglPforilePhoto", commentsModel.User.GoogleProfilePhotoUrl);
			bundle.PutString("ProfileCover", commentsModel.User.ProfileCover);
			bundle.PutInt("LibraryViewAllowed", commentsModel.User.AllowLibraryView);
			DialogUserProfile dialogUserProfile = new DialogUserProfile();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogUserProfile.Arguments = bundle;
			dialogUserProfile.Show(transaction, "DialogUserProfile");
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0001FB38 File Offset: 0x0001DD38
		private void Adapter_ItemDislikeClick(object sender, int e)
		{
			CommentsModel commentsModel = this.mCommentsList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362215);
			ImageView imageView2 = itemView.FindViewById<ImageView>(2131362213);
			TextView textView = itemView.FindViewById<TextView>(2131362216);
			TextView textView2 = itemView.FindViewById<TextView>(2131362214);
			imageView2.StartAnimation(AnimationUtils.LoadAnimation(this.view.Context, 2130771992));
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (commentsModel.CommBody.StartsWith("/"))
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952595), 0);
				return;
			}
			if (commentsModel.UserID == this.userId)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952597), 0);
				return;
			}
			if (commentsModel.LikeOrDislike == "0")
			{
				imageView2.SetImageResource(2131231010);
				textView2.Text = (commentsModel.DislikesCount - 1).ToString();
				commentsModel.DislikesCount--;
				commentsModel.LikeOrDislike = "N/A";
				CommentsViewModel.CommentLikeDelete(this.view.Context, commentsModel, imageView, imageView2, textView, textView2, "DISLIKE", commentsModel.UserID, commentsModel.CommID, this.userId);
				return;
			}
			if (commentsModel.LikeOrDislike == "1")
			{
				imageView2.SetImageResource(2131231011);
				imageView.SetImageResource(2131231099);
				textView.Text = (commentsModel.LikesCount - 1).ToString();
				textView2.Text = (commentsModel.DislikesCount + 1).ToString();
				commentsModel.LikesCount--;
				commentsModel.DislikesCount++;
				commentsModel.LikeOrDislike = "0";
				CommentsViewModel.CommentLikeUpdate(this.view.Context, commentsModel, imageView, imageView2, textView, textView2, "DISLIKE", commentsModel.UserID, commentsModel.CommID, this.userId, "0", "1");
				return;
			}
			imageView2.SetImageResource(2131231011);
			textView2.Text = (commentsModel.DislikesCount + 1).ToString();
			commentsModel.DislikesCount++;
			commentsModel.LikeOrDislike = "0";
			CommentsViewModel.CommentLikeAdd(this.view.Context, commentsModel, imageView, imageView2, textView, textView2, "DISLIKE", commentsModel.UserID, commentsModel.CommID, this.userId, "0", "1");
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001FDEC File Offset: 0x0001DFEC
		private void Adapter_ItemLikeClick(object sender, int e)
		{
			CommentsModel commentsModel = this.mCommentsList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362215);
			ImageView imageView2 = itemView.FindViewById<ImageView>(2131362213);
			TextView textView = itemView.FindViewById<TextView>(2131362216);
			TextView textView2 = itemView.FindViewById<TextView>(2131362214);
			imageView.StartAnimation(AnimationUtils.LoadAnimation(this.view.Context, 2130771992));
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (commentsModel.CommBody.StartsWith("/"))
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952595), 0);
				return;
			}
			if (commentsModel.UserID == this.userId)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952597), 0);
				return;
			}
			if (commentsModel.LikeOrDislike == "1")
			{
				imageView.SetImageResource(2131231099);
				textView.Text = (commentsModel.LikesCount - 1).ToString();
				commentsModel.LikesCount--;
				commentsModel.LikeOrDislike = "N/A";
				CommentsViewModel.CommentLikeDelete(this.view.Context, commentsModel, imageView, imageView2, textView, textView2, "LIKE", commentsModel.UserID, commentsModel.CommID, this.userId);
				return;
			}
			if (commentsModel.LikeOrDislike == "0")
			{
				imageView.SetImageResource(2131231100);
				imageView2.SetImageResource(2131231010);
				textView.Text = (commentsModel.LikesCount + 1).ToString();
				textView2.Text = (commentsModel.DislikesCount - 1).ToString();
				commentsModel.LikesCount++;
				commentsModel.DislikesCount--;
				commentsModel.LikeOrDislike = "1";
				CommentsViewModel.CommentLikeUpdate(this.view.Context, commentsModel, imageView, imageView2, textView, textView2, "LIKE", commentsModel.UserID, commentsModel.CommID, this.userId, "1", "0");
				return;
			}
			imageView.SetImageResource(2131231100);
			textView.Text = (commentsModel.LikesCount + 1).ToString();
			commentsModel.LikesCount++;
			commentsModel.LikeOrDislike = "1";
			CommentsViewModel.CommentLikeAdd(this.view.Context, commentsModel, imageView, imageView2, textView, textView2, "LIKE", commentsModel.UserID, commentsModel.CommID, this.userId, "1", "0");
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0002009C File Offset: 0x0001E29C
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000200E4 File Offset: 0x0001E2E4
		public override void OnResume()
		{
			base.OnResume();
			if (UsersModel.OnResumeLogin)
			{
				this.user = UsersViewModel.GetUserProfile();
				this.userId = ((this.user == null) ? 0 : this.user.UserID);
				this.membership = ((this.user == null) ? "" : this.user.Membership);
				if (this.user != null)
				{
					this.mCommentFieldAvatar = this.view.FindViewById<CircleImageView>(2131362209);
					if (this.user.ProfileImage != "")
					{
						Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).CenterCrop().Placeholder(2131231224).Into(this.mCommentFieldAvatar);
						return;
					}
					if (this.user.GoogleProfilePhotoUrl != "")
					{
						Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).CenterCrop().Placeholder(2131231224).Into(this.mCommentFieldAvatar);
					}
				}
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00020212 File Offset: 0x0001E412
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			this.IsDismissed = true;
		}

		// Token: 0x040004D1 RID: 1233
		private View view;

		// Token: 0x040004D2 RID: 1234
		private UsersModel user;

		// Token: 0x040004D3 RID: 1235
		private int userId;

		// Token: 0x040004D4 RID: 1236
		private string membership = "";

		// Token: 0x040004D5 RID: 1237
		private Spinner mSortbySpinner;

		// Token: 0x040004D6 RID: 1238
		private WebClient mClient;

		// Token: 0x040004D7 RID: 1239
		private Uri mUri;

		// Token: 0x040004D8 RID: 1240
		private NameValueCollection parameters;

		// Token: 0x040004D9 RID: 1241
		private CheckBox mSpoiler;

		// Token: 0x040004DA RID: 1242
		private RecyclerView recyclerView;

		// Token: 0x040004DB RID: 1243
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x040004DC RID: 1244
		private CommentsListAdapter adapter;

		// Token: 0x040004DD RID: 1245
		private List<CommentsModel> mCommentsList;

		// Token: 0x040004DE RID: 1246
		private CommentsModel mLastComment;

		// Token: 0x040004DF RID: 1247
		private FrameLayout mSendConetnet;

		// Token: 0x040004E0 RID: 1248
		private CardView mMoreLoader;

		// Token: 0x040004E1 RID: 1249
		private TextView mCommBodyView;

		// Token: 0x040004E2 RID: 1250
		private LinearLayout mSpoilerMessage;

		// Token: 0x040004E3 RID: 1251
		private EditText mTypingField;

		// Token: 0x040004E4 RID: 1252
		private ImageView mSendButton;

		// Token: 0x040004E5 RID: 1253
		private ImageView mReloadBtn;

		// Token: 0x040004E6 RID: 1254
		private ImageView mOptionMenu;

		// Token: 0x040004E7 RID: 1255
		private ProgressBar mCommentsLoader;

		// Token: 0x040004E8 RID: 1256
		private ProgressBar mCommentSendLoader;

		// Token: 0x040004E9 RID: 1257
		private ProgressBar mOptionMenuLoader;

		// Token: 0x040004EA RID: 1258
		private CircleImageView mCommentFieldAvatar;

		// Token: 0x040004EB RID: 1259
		private LinearLayout mNoComments;

		// Token: 0x040004EC RID: 1260
		private Animation sendReady;

		// Token: 0x040004ED RID: 1261
		private Animation sendNotReady;

		// Token: 0x040004EE RID: 1262
		private Animation hideLoader;

		// Token: 0x040004EF RID: 1263
		private Animation showLoader;

		// Token: 0x040004F0 RID: 1264
		private bool IsSendAnimated;

		// Token: 0x040004F1 RID: 1265
		private bool IsLoadingMore;

		// Token: 0x040004F2 RID: 1266
		private bool IsEditModeOn;

		// Token: 0x040004F3 RID: 1267
		private bool IsDismissed;

		// Token: 0x040004F4 RID: 1268
		private string animeId;

		// Token: 0x040004F5 RID: 1269
		private string commType;

		// Token: 0x040004F6 RID: 1270
		private float episode;

		// Token: 0x040004F7 RID: 1271
		private int spoiler;

		// Token: 0x040004F8 RID: 1272
		private int latestEditPosition;

		// Token: 0x040004F9 RID: 1273
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x040004FA RID: 1274
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x040004FB RID: 1275
		private string excludedComments = "";

		// Token: 0x040004FC RID: 1276
		private string orderBy = "Most_Popular";
	}
}
