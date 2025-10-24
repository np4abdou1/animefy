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
using AndroidX.Core.Content;
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
	// Token: 0x020000B0 RID: 176
	public class CommentsReplies : DialogFragment
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x000207C8 File Offset: 0x0001E9C8
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

		// Token: 0x060007FE RID: 2046 RVA: 0x00020844 File Offset: 0x0001EA44
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558438, container, false);
			this.Dialog.Window.SetSoftInputMode(SoftInput.AdjustResize);
			this.isCommentLoadNeeded = base.Arguments.GetBoolean("IsCommentLoadNeeded", false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.membership = ((this.user == null) ? "" : this.user.Membership);
			if (this.userId != 0)
			{
				this.user = UsersViewModel.GetUserProfile();
				this.mCommentRpliesFieldAvatar = this.view.FindViewById<CircleImageView>(2131362220);
				if (this.user.ProfileImage != "")
				{
					Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).CenterCrop().Into(this.mCommentRpliesFieldAvatar);
				}
				else if (this.user.GoogleProfilePhotoUrl != "")
				{
					Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).CenterCrop().Into(this.mCommentRpliesFieldAvatar);
				}
			}
			this.mMoreLoader = this.view.FindViewById<CardView>(2131362202);
			this.mReloadBtn = this.view.FindViewById<ImageView>(2131362192);
			this.mCommentsRpliesLoader = this.view.FindViewById<ProgressBar>(2131362835);
			this.mCommentRpliesSendLoader = this.view.FindViewById<ProgressBar>(2131362195);
			this.mBackBtn = this.view.FindViewById<ImageView>(2131362189);
			this.recyclerView = this.view.FindViewById<RecyclerView>(2131362917);
			this.mScroller = this.view.FindViewById<ScrollView>(2131362908);
			this.mNoReplies = this.view.FindViewById<LinearLayout>(2131362793);
			this.mSendConetnet = this.view.FindViewById<FrameLayout>(2131362194);
			this.mTypingField = this.view.FindViewById<EditText>(2131362197);
			this.mSendButton = this.view.FindViewById<ImageView>(2131362193);
			this.mCommentWasDeleted = this.view.FindViewById<TextView>(2131362185);
			this.sendReady = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			this.sendNotReady = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.hideLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this.view.Context, 2130771998);
			if (base.Resources.GetString(2131952024) == "AR")
			{
				this.mBackBtn.SetImageResource(2131231096);
			}
			else
			{
				this.mBackBtn.SetImageResource(2131231184);
			}
			this.LoadCommentWithRplies();
			this.mScroller.ScrollChange += this.MScroller_ScrollChange;
			this.mBackBtn.Click += this.MBackBtn_Click;
			this.mReloadBtn.Click += this.MReloadBtn_Click;
			this.mTypingField.TextChanged += this.MTypingField_TextChanged;
			this.mSendButton.Click += this.MSendButton_Click;
			return this.view;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		private void LoadCommentWithRplies()
		{
			if (this.isCommentLoadNeeded)
			{
				this.mCommentParent = this.view.FindViewById<RelativeLayout>(2131362212);
				this.commentId = base.Arguments.GetInt("CommId", 0);
				this.mCommentParent.Visibility = ViewStates.Gone;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadComment();
				});
				return;
			}
			this.commUserId = base.Arguments.GetInt("CommUserId", 0);
			this.fullname = base.Arguments.GetString("Fullname", "N/A");
			this.bio = base.Arguments.GetString("Bio", "N/A");
			this.gender = base.Arguments.GetString("Gender", "N/A");
			this.profilePhoto = base.Arguments.GetString("ProfilePhoto", "N/A");
			this.googlePhotoUrl = base.Arguments.GetString("GooglePhotoUrl", "N/A");
			this.profileCover = base.Arguments.GetString("ProfileCover", "N/A");
			this.membershipLevel = base.Arguments.GetString("MembershipLevel", "N/A");
			this.mAllowLibraryView = base.Arguments.GetInt("AllowLibraryView", 0);
			this.commentsItem = new CommentsModel();
			this.commentsItem.CommID = base.Arguments.GetInt("CommId", 0);
			this.commentsItem.CommBody = base.Arguments.GetString("CommBody", "N/A");
			this.commentsItem.CommTime = base.Arguments.GetString("CommTime", "N/A");
			this.commentsItem.LikesCount = base.Arguments.GetInt("CommLikes", 0);
			this.commentsItem.DislikesCount = base.Arguments.GetInt("CommDislikes", 0);
			this.commentsItem.LikeOrDislike = base.Arguments.GetString("LikeOrDislike", "N/A");
			this.commentsItem.Spoiler = base.Arguments.GetInt("Spoiler", 0);
			this.commentsItem.Pinned = base.Arguments.GetInt("Pinned", 0);
			this.PrepareComment();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadReplies();
			});
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00020E24 File Offset: 0x0001F024
		private void PrepareComment()
		{
			this.view.FindViewById<RelativeLayout>(2131362218).Visibility = ViewStates.Gone;
			this.view.FindViewById<ImageView>(2131362222).Visibility = ViewStates.Gone;
			this.mPinnedComment = this.view.FindViewById<LinearLayout>(2131362847);
			if (this.commentsItem.Pinned > 0)
			{
				this.mPinnedComment.Visibility = ViewStates.Visible;
			}
			else
			{
				this.mPinnedComment.Visibility = ViewStates.Gone;
			}
			this.mLikesCount = this.view.FindViewById<TextView>(2131362216);
			this.mDislikesCount = this.view.FindViewById<TextView>(2131362214);
			this.mLikesCount.Text = this.commentsItem.LikesCount.ToString();
			this.mDislikesCount.Text = this.commentsItem.DislikesCount.ToString();
			this.mLikeBtn = this.view.FindViewById<ImageView>(2131362215);
			this.mDislikeBtn = this.view.FindViewById<ImageView>(2131362213);
			if (this.commentsItem.LikeOrDislike == "1")
			{
				this.mLikeBtn.SetImageResource(2131231100);
			}
			else if (this.commentsItem.LikeOrDislike == "0")
			{
				this.mDislikeBtn.SetImageResource(2131231011);
			}
			CircleImageView circleImageView = this.view.FindViewById<CircleImageView>(2131362209);
			if (this.profilePhoto != "" && this.profilePhoto != "N/A")
			{
				Glide.With(this).Load(Constants.ProfilePhoto(this.profilePhoto, this.commUserId.ToString())).CenterCrop().Into(circleImageView);
			}
			else if (this.googlePhotoUrl != "" && this.googlePhotoUrl != "N/A")
			{
				Glide.With(this).Load(this.googlePhotoUrl).CenterCrop().Into(circleImageView);
			}
			if (this.membershipLevel == "ADMIN")
			{
				circleImageView.BorderWidth = 4;
				circleImageView.BorderColor = ContextCompat.GetColor(this.view.Context, 2131100510);
			}
			this.view.FindViewById<TextView>(2131362223).Text = this.commentsItem.CommTime;
			this.view.FindViewById<TextView>(2131362224).Text = this.fullname;
			this.mCommentBody = this.view.FindViewById<TextView>(2131362210);
			this.mSpoiler = this.view.FindViewById<LinearLayout>(2131363089);
			if (this.commentsItem.CommBody.StartsWith("/"))
			{
				this.mCommentBody.Text = base.Resources.GetString(2131952464);
				this.mCommentBody.SetTextColor(Color.ParseColor("#b3b3b3"));
				this.mCommentBody.SetTypeface(this.mCommentBody.Typeface, TypefaceStyle.Italic);
			}
			else
			{
				this.mCommentBody.Text = this.commentsItem.CommBody;
			}
			if (this.commentsItem.Spoiler == 1)
			{
				this.mCommentBody.Visibility = ViewStates.Gone;
				this.mSpoiler.Visibility = ViewStates.Visible;
			}
			else
			{
				this.mCommentBody.Visibility = ViewStates.Visible;
				this.mSpoiler.Visibility = ViewStates.Gone;
			}
			this.mLikeBtn.Click += this.MLikeBtn_Click;
			this.mDislikeBtn.Click += this.MDislikeBtn_Click;
			circleImageView.Click += this.TempProfilePhoto_Click;
			this.mSpoiler.Click += this.MSpoiler_Click;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000211CC File Offset: 0x0001F3CC
		private void LoadComment()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/get_comment.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("CommentId", this.commentId.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
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
					this.commentsItem = JsonConvert.DeserializeObject<CommentsModel>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (this.commentsItem != null)
						{
							this.commUserId = this.commentsItem.User.UserID;
							this.fullname = this.commentsItem.User.FullName;
							this.bio = this.commentsItem.User.Bio;
							this.gender = this.commentsItem.User.Gender;
							this.profilePhoto = this.commentsItem.User.ProfileImage;
							this.googlePhotoUrl = this.commentsItem.User.GoogleProfilePhotoUrl;
							this.membershipLevel = this.commentsItem.User.Membership;
							this.mAllowLibraryView = this.commentsItem.User.AllowLibraryView;
							this.PrepareComment();
							this.mCommentParent.Visibility = ViewStates.Visible;
							ThreadPool.QueueUserWorkItem(delegate(object o)
							{
								this.LoadReplies();
							});
							return;
						}
						this.mCommentWasDeleted.Visibility = ViewStates.Visible;
						this.mCommentsRpliesLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951826), 0);
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.mReloadBtn.Visibility = ViewStates.Visible;
						this.mCommentsRpliesLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951826), 0);
					});
				}
			};
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00021284 File Offset: 0x0001F484
		private void MScroller_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.IsLoadingMore && e.ScrollY == this.mScroller.GetChildAt(0).MeasuredHeight - this.mScroller.MeasuredHeight)
			{
				int listCount = this.mCommentRepliesList.Count<CommentRepliesModel>();
				if (listCount >= 25)
				{
					this.IsLoadingMore = true;
					this.mMoreLoader.StartAnimation(this.showLoader);
					this.mMoreLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadMoreReplies(listCount);
					});
				}
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002131C File Offset: 0x0001F51C
		private void MSpoiler_Click(object sender, EventArgs e)
		{
			this.mCommentBody.Visibility = ViewStates.Visible;
			this.mSpoiler.Visibility = ViewStates.Gone;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00021338 File Offset: 0x0001F538
		private void TempProfilePhoto_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CommentsReplies.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("UserId", this.commUserId.ToString());
			bundle.PutString("DisplayName", this.fullname);
			bundle.PutString("Bio", this.bio);
			bundle.PutString("Gender", this.gender);
			bundle.PutString("ProfilePhoto", this.profilePhoto);
			bundle.PutString("GglPforilePhoto", this.googlePhotoUrl);
			bundle.PutString("ProfileCover", this.profileCover);
			bundle.PutInt("LibraryViewAllowed", this.mAllowLibraryView);
			DialogUserProfile dialogUserProfile = new DialogUserProfile();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogUserProfile.Arguments = bundle;
			dialogUserProfile.Show(transaction, "DialogUserProfile");
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0002141C File Offset: 0x0001F61C
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
					this.mCommentRpliesFieldAvatar = this.view.FindViewById<CircleImageView>(2131362220);
					if (this.user.ProfileImage != "")
					{
						Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).CenterCrop().Placeholder(2131231224).Into(this.mCommentRpliesFieldAvatar);
						return;
					}
					if (this.user.GoogleProfilePhotoUrl != "")
					{
						Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).CenterCrop().Placeholder(2131231224).Into(this.mCommentRpliesFieldAvatar);
					}
				}
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0002154C File Offset: 0x0001F74C
		private void MDislikeBtn_Click(object sender, EventArgs e)
		{
			this.mDislikeBtn.StartAnimation(AnimationUtils.LoadAnimation(this.view.Context, 2130771992));
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (this.commentsItem.CommBody.StartsWith("/"))
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952596), 0);
				return;
			}
			if (this.commUserId == this.userId)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952597), 0);
				return;
			}
			if (this.commentsItem.LikeOrDislike == "0")
			{
				this.mDislikeBtn.SetImageResource(2131231010);
				this.mDislikesCount.Text = (this.commentsItem.DislikesCount - 1).ToString();
				this.commentsItem.DislikesCount--;
				this.commentsItem.LikeOrDislike = "N/A";
				CommentsViewModel.CommentLikeDelete(this.view.Context, this.commentsItem, this.mLikeBtn, this.mDislikeBtn, this.mLikesCount, this.mDislikesCount, "DISLIKE", this.commUserId, this.commentsItem.CommID, this.userId);
				return;
			}
			if (this.commentsItem.LikeOrDislike == "1")
			{
				this.mDislikeBtn.SetImageResource(2131231011);
				this.mLikeBtn.SetImageResource(2131231099);
				this.mLikesCount.Text = (this.commentsItem.LikesCount - 1).ToString();
				this.mDislikesCount.Text = (this.commentsItem.DislikesCount + 1).ToString();
				this.commentsItem.LikesCount--;
				this.commentsItem.DislikesCount++;
				this.commentsItem.LikeOrDislike = "0";
				CommentsViewModel.CommentLikeUpdate(this.view.Context, this.commentsItem, this.mLikeBtn, this.mDislikeBtn, this.mLikesCount, this.mDislikesCount, "DISLIKE", this.commUserId, this.commentsItem.CommID, this.userId, "0", "1");
				return;
			}
			this.mDislikeBtn.SetImageResource(2131231011);
			this.mDislikesCount.Text = (this.commentsItem.DislikesCount + 1).ToString();
			this.commentsItem.DislikesCount++;
			this.commentsItem.LikeOrDislike = "0";
			CommentsViewModel.CommentLikeAdd(this.view.Context, this.commentsItem, this.mLikeBtn, this.mDislikeBtn, this.mLikesCount, this.mDislikesCount, "DISLIKE", this.commUserId, this.commentsItem.CommID, this.userId, "0", "1");
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00021868 File Offset: 0x0001FA68
		private void MLikeBtn_Click(object sender, EventArgs e)
		{
			this.mLikeBtn.StartAnimation(AnimationUtils.LoadAnimation(this.view.Context, 2130771992));
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (this.commentsItem.CommBody.StartsWith("/"))
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952596), 0);
				return;
			}
			if (this.commUserId == this.userId)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952597), 0);
				return;
			}
			if (this.commentsItem.LikeOrDislike == "1")
			{
				this.mLikeBtn.SetImageResource(2131231099);
				this.mLikesCount.Text = (this.commentsItem.LikesCount - 1).ToString();
				this.commentsItem.LikesCount--;
				this.commentsItem.LikeOrDislike = "N/A";
				CommentsViewModel.CommentLikeDelete(this.view.Context, this.commentsItem, this.mLikeBtn, this.mDislikeBtn, this.mLikesCount, this.mDislikesCount, "LIKE", this.commUserId, this.commentsItem.CommID, this.userId);
				return;
			}
			if (this.commentsItem.LikeOrDislike == "0")
			{
				this.mLikeBtn.SetImageResource(2131231100);
				this.mDislikeBtn.SetImageResource(2131231010);
				this.mLikesCount.Text = (this.commentsItem.LikesCount + 1).ToString();
				this.mDislikesCount.Text = (this.commentsItem.DislikesCount - 1).ToString();
				this.commentsItem.LikesCount++;
				this.commentsItem.DislikesCount--;
				this.commentsItem.LikeOrDislike = "1";
				CommentsViewModel.CommentLikeUpdate(this.view.Context, this.commentsItem, this.mLikeBtn, this.mDislikeBtn, this.mLikesCount, this.mDislikesCount, "LIKE", this.commUserId, this.commentsItem.CommID, this.userId, "1", "0");
				return;
			}
			this.mLikeBtn.SetImageResource(2131231100);
			this.mLikesCount.Text = (this.commentsItem.LikesCount + 1).ToString();
			this.commentsItem.LikesCount++;
			this.commentsItem.LikeOrDislike = "1";
			CommentsViewModel.CommentLikeAdd(this.view.Context, this.commentsItem, this.mLikeBtn, this.mDislikeBtn, this.mLikesCount, this.mDislikesCount, "LIKE", this.commUserId, this.commentsItem.CommID, this.userId, "1", "0");
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00021B84 File Offset: 0x0001FD84
		private void MTypingField_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.mTypingField.Text.Trim() == "")
			{
				if (this.IsSendAnimated)
				{
					this.mSendButton.StartAnimation(this.sendNotReady);
					this.mSendConetnet.Visibility = ViewStates.Gone;
					this.mSendButton.Clickable = false;
					this.IsSendAnimated = false;
					this.IsEditModeOn = false;
					return;
				}
			}
			else if (!this.IsSendAnimated)
			{
				this.mSendButton.StartAnimation(this.sendReady);
				this.mSendConetnet.Visibility = ViewStates.Visible;
				this.mSendButton.Clickable = true;
				this.IsSendAnimated = true;
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00021C28 File Offset: 0x0001FE28
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
			if (this.IsEditModeOn)
			{
				this.mSendButton.StartAnimation(this.sendNotReady);
				this.mSendButton.Clickable = false;
				this.IsSendAnimated = false;
				this.mCommentRpliesSendLoader.Visibility = ViewStates.Visible;
				this.EditReply();
				return;
			}
			DateTime latestReplyTime = this.LatestReplyTime;
			if (DateTime.Now.Subtract(this.LatestReplyTime).TotalSeconds <= 30.0 && this.membership != "ADMIN")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952594) + " 30 " + base.Resources.GetString(2131952370), 0);
				return;
			}
			this.mSendButton.StartAnimation(this.sendNotReady);
			this.mSendButton.Clickable = false;
			this.IsSendAnimated = false;
			this.mCommentRpliesSendLoader.Visibility = ViewStates.Visible;
			this.AddReply(this.view.Context, this.commentsItem.CommID, this.mTypingField.Text, this.userId);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MBackBtn_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00021DED File Offset: 0x0001FFED
		private void MReloadBtn_Click(object sender, EventArgs e)
		{
			this.mReloadBtn.Visibility = ViewStates.Gone;
			this.mCommentsRpliesLoader.Visibility = ViewStates.Visible;
			this.LoadCommentWithRplies();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00021E10 File Offset: 0x00020010
		public void AddReply(Context context, int commId, string body, int userId)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/replies/reply_add.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("CommID", commId.ToString());
			this.parameters.Add("ReplyBody", body.Trim());
			this.parameters.Add("UserID", userId.ToString());
			this.parameters.Add("CommentUserId", this.commUserId.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mCommentRepliesLastReply = JsonConvert.DeserializeObject<CommentRepliesModel>(@string);
					if (this.mCommentRepliesLastReply != null)
					{
						this.excludedReplies = this.excludedReplies + this.mCommentRepliesLastReply.ReplyID.ToString() + ",";
						int num = this.mCommentRepliesList.Count<CommentRepliesModel>();
						this.mCommentRepliesList.Insert(num, this.mCommentRepliesLastReply);
						this.mTypingField.Text = "";
						this.adapter.NotifyItemInserted(num);
						this.mNoReplies.Visibility = ViewStates.Gone;
						this.mSendButton.Clickable = false;
						this.mScroller.SmoothScrollTo(0, this.mScroller.GetChildAt(0).MeasuredHeight);
					}
					else
					{
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951829), 0);
						this.mSendButton.StartAnimation(this.sendReady);
						this.mSendButton.Clickable = true;
						this.IsSendAnimated = true;
					}
					this.LatestReplyTime = DateTime.Now;
					this.mTypingField.Enabled = true;
					this.mCommentRpliesSendLoader.Visibility = ViewStates.Gone;
					this.mSendConetnet.Visibility = ViewStates.Gone;
				}
				catch
				{
					this.mTypingField.Enabled = true;
					this.mCommentRpliesSendLoader.Visibility = ViewStates.Gone;
					this.mSendButton.StartAnimation(this.sendReady);
					this.mSendButton.Clickable = true;
					this.IsSendAnimated = true;
					CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951829), 0);
				}
			};
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00021F0C File Offset: 0x0002010C
		private void LoadReplies()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/replies/replys_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("CommID", this.commentsItem.CommID.ToString());
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("From", 0.ToString());
			this.parameters.Add("ExcludedReplies", (this.excludedReplies == "") ? "" : this.excludedReplies.Remove(this.excludedReplies.Length - 1));
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				if (this.IsDismissed)
				{
					return;
				}
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mCommentRepliesList = JsonConvert.DeserializeObject<List<CommentRepliesModel>>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						this.adapter = new CommentsRpliesListAdapter(this.view.Context, this.mCommentRepliesList);
						this.adapter.ItemClick += this.Adapter_ItemClick;
						this.adapter.LikeClick += this.Adapter_LikeClick;
						this.adapter.DislikeClick += this.Adapter_DislikeClick;
						this.adapter.ItemProfilePhotoClick += this.Adapter_ItemProfilePhotoClick;
						this.layoutManager = new GridLayoutManager(this.view.Context, 1);
						this.recyclerView.SetLayoutManager(this.layoutManager);
						this.recyclerView.SetAdapter(this.adapter);
						int count = this.mCommentRepliesList.Count;
						if (count <= 0)
						{
							this.mNoReplies.Visibility = ViewStates.Visible;
						}
						this.mCommentsRpliesLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.mReloadBtn.Visibility = ViewStates.Visible;
						this.mCommentsRpliesLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951826), 0);
					});
				}
				this.IsLoadingMore = false;
			};
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00022040 File Offset: 0x00020240
		private void LoadMoreReplies(int from)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/replies/replys_loader.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("CommID", this.commentsItem.CommID.ToString());
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("Language", base.Resources.GetString(2131951706));
			this.parameters.Add("From", from.ToString());
			this.parameters.Add("ExcludedReplies", (this.excludedReplies == "") ? "" : this.excludedReplies.Remove(this.excludedReplies.Length - 1));
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				if (this.IsDismissed)
				{
					return;
				}
				string @string = Encoding.UTF8.GetString(e.Result);
				List<CommentRepliesModel> mCommentRepliesTmpList = JsonConvert.DeserializeObject<List<CommentRepliesModel>>(@string);
				base.Activity.RunOnUiThread(delegate()
				{
					try
					{
						if (mCommentRepliesTmpList.Count != 0)
						{
							this.mCommentRepliesList.AddRange(mCommentRepliesTmpList);
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
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951826), 0);
					}
				});
			};
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00022174 File Offset: 0x00020374
		private void Adapter_ItemProfilePhotoClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CommentsReplies.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CommentRepliesModel commentRepliesModel = this.mCommentRepliesList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("UserId", commentRepliesModel.User.UserID.ToString());
			bundle.PutString("DisplayName", commentRepliesModel.User.FullName);
			bundle.PutString("Bio", commentRepliesModel.User.Bio);
			bundle.PutString("Gender", commentRepliesModel.User.Gender);
			bundle.PutString("Membership", commentRepliesModel.User.Membership);
			bundle.PutString("ProfilePhoto", commentRepliesModel.User.ProfileImage);
			bundle.PutString("GglPforilePhoto", commentRepliesModel.User.GoogleProfilePhotoUrl);
			bundle.PutInt("LibraryViewAllowed", commentRepliesModel.User.AllowLibraryView);
			DialogUserProfile dialogUserProfile = new DialogUserProfile();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogUserProfile.Arguments = bundle;
			dialogUserProfile.Show(transaction, "DialogUserProfile");
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00022294 File Offset: 0x00020494
		private void Adapter_DislikeClick(object sender, int e)
		{
			CommentRepliesModel commentRepliesModel = this.mCommentRepliesList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362177);
			ImageView imageView2 = itemView.FindViewById<ImageView>(2131362175);
			TextView textView = itemView.FindViewById<TextView>(2131362178);
			TextView textView2 = itemView.FindViewById<TextView>(2131362176);
			imageView2.StartAnimation(AnimationUtils.LoadAnimation(this.view.Context, 2130771992));
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (commentRepliesModel.ReplyBody.StartsWith("/"))
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952595), 0);
				return;
			}
			if (commentRepliesModel.UserID == this.userId)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952597), 0);
				return;
			}
			if (commentRepliesModel.LikeOrDislike == "0")
			{
				imageView2.SetImageResource(2131231010);
				textView2.Text = (commentRepliesModel.DislikesCount - 1).ToString();
				commentRepliesModel.DislikesCount--;
				commentRepliesModel.LikeOrDislike = "N/A";
				CommentsViewModel.CommentReplyLikeDelete(this.view.Context, commentRepliesModel, imageView, imageView2, textView, textView2, "DISLIKE", commentRepliesModel.UserID, commentRepliesModel.ReplyID, this.userId);
				return;
			}
			if (commentRepliesModel.LikeOrDislike == "1")
			{
				imageView2.SetImageResource(2131231011);
				imageView.SetImageResource(2131231099);
				textView.Text = (commentRepliesModel.LikesCount - 1).ToString();
				textView2.Text = (commentRepliesModel.DislikesCount + 1).ToString();
				commentRepliesModel.LikesCount--;
				commentRepliesModel.DislikesCount++;
				commentRepliesModel.LikeOrDislike = "0";
				CommentsViewModel.CommentReplyLikeUpdate(this.view.Context, commentRepliesModel, imageView, imageView2, textView, textView2, "DISLIKE", commentRepliesModel.UserID, commentRepliesModel.ReplyID, this.userId, "0", "1");
				return;
			}
			imageView2.SetImageResource(2131231011);
			textView2.Text = (commentRepliesModel.DislikesCount + 1).ToString();
			commentRepliesModel.DislikesCount++;
			commentRepliesModel.LikeOrDislike = "0";
			CommentsViewModel.CommentReplyLikeAdd(this.view.Context, commentRepliesModel, imageView, imageView2, textView, textView2, "DISLIKE", commentRepliesModel.UserID, commentRepliesModel.ReplyID, this.userId, "0", "1");
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0002253C File Offset: 0x0002073C
		private void Adapter_LikeClick(object sender, int e)
		{
			CommentRepliesModel commentRepliesModel = this.mCommentRepliesList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362177);
			ImageView imageView2 = itemView.FindViewById<ImageView>(2131362175);
			TextView textView = itemView.FindViewById<TextView>(2131362178);
			TextView textView2 = itemView.FindViewById<TextView>(2131362176);
			imageView.StartAnimation(AnimationUtils.LoadAnimation(this.view.Context, 2130771992));
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (commentRepliesModel.ReplyBody.StartsWith("/"))
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952595), 0);
				return;
			}
			if (commentRepliesModel.UserID == this.userId)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952597), 0);
				return;
			}
			if (commentRepliesModel.LikeOrDislike == "1")
			{
				imageView.SetImageResource(2131231099);
				textView.Text = (commentRepliesModel.LikesCount - 1).ToString();
				commentRepliesModel.LikesCount--;
				commentRepliesModel.LikeOrDislike = "N/A";
				CommentsViewModel.CommentReplyLikeDelete(this.view.Context, commentRepliesModel, imageView, imageView2, textView, textView2, "LIKE", commentRepliesModel.UserID, commentRepliesModel.ReplyID, this.userId);
				return;
			}
			if (commentRepliesModel.LikeOrDislike == "0")
			{
				imageView.SetImageResource(2131231100);
				imageView2.SetImageResource(2131231010);
				textView.Text = (commentRepliesModel.LikesCount + 1).ToString();
				textView2.Text = (commentRepliesModel.DislikesCount - 1).ToString();
				commentRepliesModel.LikesCount++;
				commentRepliesModel.DislikesCount--;
				commentRepliesModel.LikeOrDislike = "1";
				CommentsViewModel.CommentReplyLikeUpdate(this.view.Context, commentRepliesModel, imageView, imageView2, textView, textView2, "LIKE", commentRepliesModel.UserID, commentRepliesModel.ReplyID, this.userId, "1", "0");
				return;
			}
			imageView.SetImageResource(2131231100);
			textView.Text = (commentRepliesModel.LikesCount + 1).ToString();
			commentRepliesModel.LikesCount++;
			commentRepliesModel.LikeOrDislike = "1";
			CommentsViewModel.CommentReplyLikeAdd(this.view.Context, commentRepliesModel, imageView, imageView2, textView, textView2, "LIKE", commentRepliesModel.UserID, commentRepliesModel.ReplyID, this.userId, "1", "0");
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000227E4 File Offset: 0x000209E4
		private void Adapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CommentsReplies.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CommentRepliesModel item = this.mCommentRepliesList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			this.mOptionMenu = itemView.FindViewById<ImageView>(2131362179);
			this.mOptionMenuLoader = itemView.FindViewById<ProgressBar>(2131362181);
			this.mReplyBodyView = itemView.FindViewById<TextView>(2131362173);
			PopupMenu menu = new PopupMenu(itemView.Context, this.mOptionMenu);
			if (item.User.UserID == this.userId || this.membership == "ADMIN")
			{
				menu.MenuInflater.Inflate(2131689485, menu.Menu);
				if (this.membership == "ADMIN")
				{
					if (item.User.CommunicationStatus == "OK")
					{
						menu.Menu.FindItem(2131362619).SetTitle(base.Resources.GetString(2131951731));
					}
					else
					{
						menu.Menu.FindItem(2131362619).SetTitle(base.Resources.GetString(2131952545));
					}
					menu.Menu.FindItem(2131362619).SetVisible(true);
				}
			}
			else
			{
				menu.MenuInflater.Inflate(2131689484, menu.Menu);
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
				if (itemId == 2131362653)
				{
					this.mClient = new WebClient();
					this.mUri = new Uri(Constants.ApiPhp("comments/replies/report.php"));
					this.parameters = new NameValueCollection();
					this.parameters.Add("ReplyID", item.CommID.ToString());
					this.parameters.Add("ReporterId", this.userId.ToString());
					this.parameters.Add("ReplyBody", item.ReplyBody);
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
				if (itemId == 2131362630)
				{
					if (item.ReplyBody.StartsWith("/") && this.membership != "ADMIN")
					{
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951750), 0);
					}
					else if (item.User.CommunicationStatus == "BLOCK" && this.membership != "ADMIN")
					{
						CommunicationBlock communicationBlock = new CommunicationBlock();
						FragmentTransaction transaction = this.ParentFragmentManager.BeginTransaction();
						communicationBlock.Show(transaction, "BlockedDialog");
					}
					else if (item.ReplyBody.StartsWith("/") && this.membership != "ADMIN")
					{
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952599), 0);
					}
					else
					{
						this.latestEditPosition = e;
						this.IsEditModeOn = true;
						this.mTypingField.Text = item.ReplyBody;
						this.mTypingField.RequestFocus();
						this.mTypingField.SetSelection(this.mTypingField.Text.Length);
					}
					menu.Dismiss();
					return;
				}
				if (itemId != 2131362627)
				{
					if (itemId == 2131362619)
					{
						if (item.User.CommunicationStatus == "OK")
						{
							CommentsViewModel.CommentBlockUser(this.view.Context, item.UserID, "BLOCK");
							item.User.CommunicationStatus = "BLOCK";
							return;
						}
						CommentsViewModel.CommentBlockUser(this.view.Context, item.UserID, "OK");
						item.User.CommunicationStatus = "OK";
					}
					return;
				}
				if (item.ReplyBody.StartsWith("/") && this.membership != "ADMIN")
				{
					CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951751), 0);
					return;
				}
				this.mOptionMenu.Visibility = ViewStates.Gone;
				this.mOptionMenuLoader.Visibility = ViewStates.Visible;
				LayoutInflater layoutInflater = LayoutInflater.From(itemView.Context);
				View view = layoutInflater.Inflate(2131558618, null);
				view.FindViewById<TextView>(2131362279).Text = view.Resources.GetString(2131951868);
				Button button = view.FindViewById<Button>(2131362300);
				Button button2 = view.FindViewById<Button>(2131362263);
				AlertDialog.Builder builder = new AlertDialog.Builder(itemView.Context);
				builder.SetView(view);
				builder.SetCancelable(false);
				AlertDialog dialog = builder.Create();
				dialog.Show();
				button.Click += delegate(object <p0>, EventArgs <p1>)
				{
					this.mTypingField.Text = "";
					this.mClient = new WebClient();
					this.mUri = new Uri(Constants.ApiPhp("comments/replies/reply_delete.php"));
					this.parameters = new NameValueCollection();
					this.parameters.Add("ReplyID", item.ReplyID.ToString());
					this.parameters.Add("UserID", (this.membership == "ADMIN") ? item.User.UserID.ToString() : this.userId.ToString());
					this.parameters.Add("CommentUserId", this.commUserId.ToString());
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
									this.mCommentRepliesList.Remove(item);
									this.adapter.NotifyItemRemoved(e);
									int count = this.mCommentRepliesList.Count;
									if (count <= 0)
									{
										this.mNoReplies.Visibility = ViewStates.Visible;
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
			};
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00022A00 File Offset: 0x00020C00
		private void EditReply()
		{
			CommentRepliesModel item = this.mCommentRepliesList[this.latestEditPosition];
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("comments/replies/reply_update.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("ReplyID", item.ReplyID.ToString());
			this.parameters.Add("ReplyBody", this.mTypingField.Text.Trim());
			this.parameters.Add("UserId", this.userId.ToString());
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
							this.mReplyBodyView.Text = this.Resources.GetString(2131952466);
							this.mReplyBodyView.SetTextColor(Color.ParseColor("#b3b3b3"));
							this.mReplyBodyView.SetTypeface(this.mReplyBodyView.Typeface, TypefaceStyle.Italic);
						}
						else
						{
							this.mReplyBodyView.Text = this.mTypingField.Text;
						}
						item.ReplyBody = this.mTypingField.Text;
						this.mTypingField.Text = "";
						this.mCommentRpliesSendLoader.Visibility = ViewStates.Gone;
						this.mSendConetnet.Visibility = ViewStates.Gone;
						this.IsEditModeOn = false;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951792), 0);
					}
					else
					{
						this.mCommentRpliesSendLoader.Visibility = ViewStates.Gone;
						this.mSendButton.StartAnimation(this.sendReady);
						this.mSendButton.Clickable = true;
						this.IsSendAnimated = true;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951918), 0);
					}
				}
				catch
				{
					this.mCommentRpliesSendLoader.Visibility = ViewStates.Gone;
					this.mSendButton.StartAnimation(this.sendReady);
					this.mSendButton.Clickable = true;
					this.IsSendAnimated = true;
					CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951821), 0);
				}
				this.mOptionMenu.Visibility = ViewStates.Visible;
				this.mOptionMenuLoader.Visibility = ViewStates.Gone;
			};
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00022AFD File Offset: 0x00020CFD
		public override void OnDismiss(IDialogInterface dialog)
		{
			this.IsDismissed = true;
			base.OnDismiss(dialog);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00022B10 File Offset: 0x00020D10
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x040004FD RID: 1277
		private View view;

		// Token: 0x040004FE RID: 1278
		private UsersModel user;

		// Token: 0x040004FF RID: 1279
		private int userId;

		// Token: 0x04000500 RID: 1280
		private string membership = "";

		// Token: 0x04000501 RID: 1281
		private WebClient mClient;

		// Token: 0x04000502 RID: 1282
		private Uri mUri;

		// Token: 0x04000503 RID: 1283
		private NameValueCollection parameters;

		// Token: 0x04000504 RID: 1284
		private RecyclerView recyclerView;

		// Token: 0x04000505 RID: 1285
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x04000506 RID: 1286
		private CommentsRpliesListAdapter adapter;

		// Token: 0x04000507 RID: 1287
		private List<CommentRepliesModel> mCommentRepliesList;

		// Token: 0x04000508 RID: 1288
		private CommentRepliesModel mCommentRepliesLastReply;

		// Token: 0x04000509 RID: 1289
		private FrameLayout mSendConetnet;

		// Token: 0x0400050A RID: 1290
		private LinearLayout mNoReplies;

		// Token: 0x0400050B RID: 1291
		private LinearLayout mSpoiler;

		// Token: 0x0400050C RID: 1292
		private TextView mCommentBody;

		// Token: 0x0400050D RID: 1293
		private TextView mCommentWasDeleted;

		// Token: 0x0400050E RID: 1294
		private RelativeLayout mCommentParent;

		// Token: 0x0400050F RID: 1295
		private EditText mTypingField;

		// Token: 0x04000510 RID: 1296
		private ImageView mSendButton;

		// Token: 0x04000511 RID: 1297
		private ImageView mReloadBtn;

		// Token: 0x04000512 RID: 1298
		private ImageView mBackBtn;

		// Token: 0x04000513 RID: 1299
		private ProgressBar mCommentsRpliesLoader;

		// Token: 0x04000514 RID: 1300
		private ProgressBar mCommentRpliesSendLoader;

		// Token: 0x04000515 RID: 1301
		private ImageView mLikeBtn;

		// Token: 0x04000516 RID: 1302
		private ImageView mDislikeBtn;

		// Token: 0x04000517 RID: 1303
		private ImageView mOptionMenu;

		// Token: 0x04000518 RID: 1304
		private ProgressBar mOptionMenuLoader;

		// Token: 0x04000519 RID: 1305
		private TextView mReplyBodyView;

		// Token: 0x0400051A RID: 1306
		private TextView mLikesCount;

		// Token: 0x0400051B RID: 1307
		private TextView mDislikesCount;

		// Token: 0x0400051C RID: 1308
		private ScrollView mScroller;

		// Token: 0x0400051D RID: 1309
		private CircleImageView mCommentRpliesFieldAvatar;

		// Token: 0x0400051E RID: 1310
		private LinearLayout mPinnedComment;

		// Token: 0x0400051F RID: 1311
		private CardView mMoreLoader;

		// Token: 0x04000520 RID: 1312
		private Animation sendReady;

		// Token: 0x04000521 RID: 1313
		private Animation sendNotReady;

		// Token: 0x04000522 RID: 1314
		private Animation hideLoader;

		// Token: 0x04000523 RID: 1315
		private Animation showLoader;

		// Token: 0x04000524 RID: 1316
		private DateTime LatestReplyTime;

		// Token: 0x04000525 RID: 1317
		private string excludedReplies = "";

		// Token: 0x04000526 RID: 1318
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000527 RID: 1319
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x04000528 RID: 1320
		private string fullname;

		// Token: 0x04000529 RID: 1321
		private string bio;

		// Token: 0x0400052A RID: 1322
		private string gender;

		// Token: 0x0400052B RID: 1323
		private string profilePhoto;

		// Token: 0x0400052C RID: 1324
		private string googlePhotoUrl;

		// Token: 0x0400052D RID: 1325
		private string membershipLevel;

		// Token: 0x0400052E RID: 1326
		private string profileCover;

		// Token: 0x0400052F RID: 1327
		private int mAllowLibraryView;

		// Token: 0x04000530 RID: 1328
		private int commUserId;

		// Token: 0x04000531 RID: 1329
		private int commentId;

		// Token: 0x04000532 RID: 1330
		private bool IsSendAnimated;

		// Token: 0x04000533 RID: 1331
		private bool IsDismissed;

		// Token: 0x04000534 RID: 1332
		private bool IsEditModeOn;

		// Token: 0x04000535 RID: 1333
		private bool isCommentLoadNeeded;

		// Token: 0x04000536 RID: 1334
		private bool IsLoadingMore = true;

		// Token: 0x04000537 RID: 1335
		private int latestEditPosition;

		// Token: 0x04000538 RID: 1336
		private CommentsModel commentsItem;
	}
}
