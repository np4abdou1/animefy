using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Android.Content;
using Android.Widget;
using AQ.Helpers;
using AQ.Models;
using Newtonsoft.Json;

namespace AQ.ViewModels
{
	// Token: 0x02000009 RID: 9
	public class CommentsViewModel
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000040A4 File Offset: 0x000022A4
		public static void CommentLikeDelete(Context context, CommentsModel item, ImageView likeBtn, ImageView dislikeBtn, TextView likesCountTxt, TextView dislikesCountTxt, string action, int commentUserId, int commentId, int userId)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/comment_delete_like.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("CommID", commentId.ToString());
			CommentsViewModel.parameters.Add("UserID", userId.ToString());
			CommentsViewModel.parameters.Add("CommentUserId", commentUserId.ToString());
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						if (action == "LIKE")
						{
							likeBtn.SetImageResource(2131231100);
							likesCountTxt.Text = (item.LikesCount + 1).ToString();
							item.LikesCount++;
							item.LikeOrDislike = "1";
						}
						else
						{
							dislikeBtn.SetImageResource(2131231011);
							dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
							item.DislikesCount++;
							item.LikeOrDislike = "0";
						}
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					if (action == "LIKE")
					{
						likeBtn.SetImageResource(2131231100);
						likesCountTxt.Text = (item.LikesCount + 1).ToString();
						item.LikesCount++;
						item.LikeOrDislike = "1";
					}
					else
					{
						dislikeBtn.SetImageResource(2131231011);
						dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
						item.DislikesCount++;
						item.LikeOrDislike = "0";
					}
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004194 File Offset: 0x00002394
		public static void CommentLikeUpdate(Context context, CommentsModel item, ImageView likeBtn, ImageView dislikeBtn, TextView likesCountTxt, TextView dislikesCountTxt, string action, int commentUserId, int commentId, int userId, string like, string dislike)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/comment_update_like.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("CommID", commentId.ToString());
			CommentsViewModel.parameters.Add("UserID", userId.ToString());
			CommentsViewModel.parameters.Add("Like", like);
			CommentsViewModel.parameters.Add("DisLike", dislike);
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						if (action == "LIKE")
						{
							likeBtn.SetImageResource(2131231099);
							dislikeBtn.SetImageResource(2131231011);
							likesCountTxt.Text = (item.LikesCount - 1).ToString();
							dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
							item.LikesCount--;
							item.DislikesCount++;
							item.LikeOrDislike = "0";
						}
						else
						{
							dislikeBtn.SetImageResource(2131231010);
							likeBtn.SetImageResource(2131231100);
							likesCountTxt.Text = (item.LikesCount + 1).ToString();
							dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
							item.LikesCount++;
							item.DislikesCount--;
							item.LikeOrDislike = "1";
						}
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					if (action == "LIKE")
					{
						likeBtn.SetImageResource(2131231099);
						dislikeBtn.SetImageResource(2131231011);
						likesCountTxt.Text = (item.LikesCount - 1).ToString();
						dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
						item.LikesCount--;
						item.DislikesCount++;
						item.LikeOrDislike = "0";
					}
					else
					{
						dislikeBtn.SetImageResource(2131231010);
						likeBtn.SetImageResource(2131231100);
						likesCountTxt.Text = (item.LikesCount + 1).ToString();
						dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
						item.LikesCount++;
						item.DislikesCount--;
						item.LikeOrDislike = "1";
					}
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004290 File Offset: 0x00002490
		public static void CommentLikeAdd(Context context, CommentsModel item, ImageView likeBtn, ImageView dislikeBtn, TextView likesCountTxt, TextView dislikesCountTxt, string action, int commentUserId, int commentId, int userId, string like, string dislike)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/comment_add_like.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("CommID", commentId.ToString());
			CommentsViewModel.parameters.Add("UserID", userId.ToString());
			CommentsViewModel.parameters.Add("Like", like);
			CommentsViewModel.parameters.Add("DisLike", dislike);
			CommentsViewModel.parameters.Add("CommentUserId", commentUserId.ToString());
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						if (action == "LIKE")
						{
							likeBtn.SetImageResource(2131231099);
							likesCountTxt.Text = (item.LikesCount - 1).ToString();
							item.LikesCount--;
							item.LikeOrDislike = "N/A";
						}
						else
						{
							dislikeBtn.SetImageResource(2131231010);
							dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
							item.DislikesCount--;
							item.LikeOrDislike = "N/A";
						}
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					if (action == "LIKE")
					{
						likeBtn.SetImageResource(2131231099);
						likesCountTxt.Text = (item.LikesCount - 1).ToString();
						item.LikesCount--;
						item.LikeOrDislike = "N/A";
					}
					else
					{
						dislikeBtn.SetImageResource(2131231010);
						dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
						item.DislikesCount--;
						item.LikeOrDislike = "N/A";
					}
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000043A4 File Offset: 0x000025A4
		public static void CommentReplyLikeDelete(Context context, CommentRepliesModel item, ImageView likeBtn, ImageView dislikeBtn, TextView likesCountTxt, TextView dislikesCountTxt, string action, int replyUserId, int replyId, int userId)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/replies/reply_delete_like.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("ReplyID", replyId.ToString());
			CommentsViewModel.parameters.Add("UserID", userId.ToString());
			CommentsViewModel.parameters.Add("ReplyUserId", replyUserId.ToString());
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						if (action == "LIKE")
						{
							likeBtn.SetImageResource(2131231100);
							likesCountTxt.Text = (item.LikesCount + 1).ToString();
							item.LikesCount++;
							item.LikeOrDislike = "1";
						}
						else
						{
							dislikeBtn.SetImageResource(2131231011);
							dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
							item.DislikesCount++;
							item.LikeOrDislike = "0";
						}
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					if (action == "LIKE")
					{
						likeBtn.SetImageResource(2131231100);
						likesCountTxt.Text = (item.LikesCount + 1).ToString();
						item.LikesCount++;
						item.LikeOrDislike = "1";
					}
					else
					{
						dislikeBtn.SetImageResource(2131231011);
						dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
						item.DislikesCount++;
						item.LikeOrDislike = "0";
					}
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004494 File Offset: 0x00002694
		public static void CommentReplyLikeUpdate(Context context, CommentRepliesModel item, ImageView likeBtn, ImageView dislikeBtn, TextView likesCountTxt, TextView dislikesCountTxt, string action, int commentReplyUserId, int replyId, int userId, string like, string dislike)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/replies/reply_update_like.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("ReplyID", replyId.ToString());
			CommentsViewModel.parameters.Add("UserID", userId.ToString());
			CommentsViewModel.parameters.Add("Like", like);
			CommentsViewModel.parameters.Add("DisLike", dislike);
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						if (action == "LIKE")
						{
							likeBtn.SetImageResource(2131231099);
							dislikeBtn.SetImageResource(2131231011);
							likesCountTxt.Text = (item.LikesCount - 1).ToString();
							dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
							item.LikesCount--;
							item.DislikesCount++;
							item.LikeOrDislike = "0";
						}
						else
						{
							dislikeBtn.SetImageResource(2131231010);
							likeBtn.SetImageResource(2131231100);
							likesCountTxt.Text = (item.LikesCount + 1).ToString();
							dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
							item.LikesCount++;
							item.DislikesCount--;
							item.LikeOrDislike = "1";
						}
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					if (action == "LIKE")
					{
						likeBtn.SetImageResource(2131231099);
						dislikeBtn.SetImageResource(2131231011);
						likesCountTxt.Text = (item.LikesCount - 1).ToString();
						dislikesCountTxt.Text = (item.DislikesCount + 1).ToString();
						item.LikesCount--;
						item.DislikesCount++;
						item.LikeOrDislike = "0";
					}
					else
					{
						dislikeBtn.SetImageResource(2131231010);
						likeBtn.SetImageResource(2131231100);
						likesCountTxt.Text = (item.LikesCount + 1).ToString();
						dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
						item.LikesCount++;
						item.DislikesCount--;
						item.LikeOrDislike = "1";
					}
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004590 File Offset: 0x00002790
		public static void CommentReplyLikeAdd(Context context, CommentRepliesModel item, ImageView likeBtn, ImageView dislikeBtn, TextView likesCountTxt, TextView dislikesCountTxt, string action, int commentReplyUserId, int replyId, int userId, string like, string dislike)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/replies/reply_add_like.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("ReplyID", replyId.ToString());
			CommentsViewModel.parameters.Add("UserID", userId.ToString());
			CommentsViewModel.parameters.Add("Like", like);
			CommentsViewModel.parameters.Add("DisLike", dislike);
			CommentsViewModel.parameters.Add("ReplyUserId", commentReplyUserId.ToString());
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						if (action == "LIKE")
						{
							likeBtn.SetImageResource(2131231099);
							likesCountTxt.Text = (item.LikesCount - 1).ToString();
							item.LikesCount--;
							item.LikeOrDislike = "N/A";
						}
						else
						{
							dislikeBtn.SetImageResource(2131231010);
							dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
							item.DislikesCount--;
							item.LikeOrDislike = "N/A";
						}
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					if (action == "LIKE")
					{
						likeBtn.SetImageResource(2131231099);
						likesCountTxt.Text = (item.LikesCount - 1).ToString();
						item.LikesCount--;
						item.LikeOrDislike = "N/A";
					}
					else
					{
						dislikeBtn.SetImageResource(2131231010);
						dislikesCountTxt.Text = (item.DislikesCount - 1).ToString();
						item.DislikesCount--;
						item.LikeOrDislike = "N/A";
					}
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000046A4 File Offset: 0x000028A4
		public static void CommentPin(Context context, int commentId, int pinStatus)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/comment_pin.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("CommId", commentId.ToString());
			CommentsViewModel.parameters.Add("PinStatus", pinStatus.ToString());
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004750 File Offset: 0x00002950
		public static void CommentBlockUser(Context context, int userId, string status)
		{
			CommentsViewModel.client = new WebClient();
			CommentsViewModel.uri = new Uri(Constants.ApiPhp("comments/block_user.php"));
			CommentsViewModel.parameters = new NameValueCollection();
			CommentsViewModel.parameters.Add("UsrId", userId.ToString());
			CommentsViewModel.parameters.Add("Status", status);
			CommentsViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			CommentsViewModel.client.UploadValuesAsync(CommentsViewModel.uri, CommentsViewModel.parameters);
			CommentsViewModel.client.UploadValuesCompleted += delegate(object s1, UploadValuesCompletedEventArgs e1)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e1.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a != "DONE")
					{
						CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
					}
				}
				catch
				{
					CustomizedToast.ShowToast(context, context.Resources.GetString(2131951821), 0);
				}
			};
		}

		// Token: 0x0400006D RID: 109
		public static WebClient client;

		// Token: 0x0400006E RID: 110
		public static Uri uri;

		// Token: 0x0400006F RID: 111
		public static NameValueCollection parameters;
	}
}
