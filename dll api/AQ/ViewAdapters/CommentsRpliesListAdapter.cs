using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using Android.Content;
using Android.Views;
using AndroidX.Core.Content;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000028 RID: 40
	public class CommentsRpliesListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000177 RID: 375 RVA: 0x0000813C File Offset: 0x0000633C
		// (remove) Token: 0x06000178 RID: 376 RVA: 0x00008174 File Offset: 0x00006374
		public event EventHandler<int> ItemClick;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000179 RID: 377 RVA: 0x000081AC File Offset: 0x000063AC
		// (remove) Token: 0x0600017A RID: 378 RVA: 0x000081E4 File Offset: 0x000063E4
		public event EventHandler<int> LikeClick;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600017B RID: 379 RVA: 0x0000821C File Offset: 0x0000641C
		// (remove) Token: 0x0600017C RID: 380 RVA: 0x00008254 File Offset: 0x00006454
		public event EventHandler<int> DislikeClick;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600017D RID: 381 RVA: 0x0000828C File Offset: 0x0000648C
		// (remove) Token: 0x0600017E RID: 382 RVA: 0x000082C4 File Offset: 0x000064C4
		public event EventHandler<int> ItemProfilePhotoClick;

		// Token: 0x0600017F RID: 383 RVA: 0x000082F9 File Offset: 0x000064F9
		public CommentsRpliesListAdapter(Context context, List<CommentRepliesModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008310 File Offset: 0x00006510
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558476;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CommentsRepliesListHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnLikeClick), new Action<int>(this.OnDislikeClick), new Action<int>(this.OnProfilePhotoClick));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008370 File Offset: 0x00006570
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CommentRepliesModel commentRepliesModel = this.items[position];
			CommentsRepliesListHolder commentsRepliesListHolder = viewHolder as CommentsRepliesListHolder;
			commentsRepliesListHolder.ReplyTimeView.Text = commentRepliesModel.ReplyTime;
			commentsRepliesListHolder.FullNameView.Text = commentRepliesModel.User.FullName;
			commentsRepliesListHolder.LikesCountView.Text = commentRepliesModel.LikesCount.ToString();
			commentsRepliesListHolder.DislikesCountView.Text = commentRepliesModel.DislikesCount.ToString();
			commentsRepliesListHolder.ReplyBodyView.Text = commentRepliesModel.ReplyBody;
			if (commentRepliesModel.User.ProfileImage != "")
			{
				Glide.With(this.context).Load(Constants.ProfilePhoto(commentRepliesModel.User.ProfileImage, commentRepliesModel.UserID.ToString())).Into(commentsRepliesListHolder.ProfileImageView);
			}
			else if (commentRepliesModel.User.GoogleProfilePhotoUrl != "")
			{
				Glide.With(this.context).Load(commentRepliesModel.User.GoogleProfilePhotoUrl).Into(commentsRepliesListHolder.ProfileImageView);
			}
			else
			{
				commentsRepliesListHolder.ProfileImageView.SetImageResource(2131231168);
			}
			if (commentRepliesModel.User.Membership == "ADMIN")
			{
				commentsRepliesListHolder.ProfileImageView.BorderWidth = 6;
				commentsRepliesListHolder.ProfileImageView.BorderColor = ContextCompat.GetColor(this.context, 2131100510);
			}
			else
			{
				commentsRepliesListHolder.ProfileImageView.BorderWidth = 2;
				commentsRepliesListHolder.ProfileImageView.BorderColor = ContextCompat.GetColor(this.context, 2131100465);
			}
			if (commentRepliesModel.LikeOrDislike == "1")
			{
				commentsRepliesListHolder.LikeView.SetImageResource(2131231100);
			}
			else
			{
				commentsRepliesListHolder.LikeView.SetImageResource(2131231099);
			}
			if (commentRepliesModel.LikeOrDislike == "0")
			{
				commentsRepliesListHolder.DislikeView.SetImageResource(2131231011);
				return;
			}
			commentsRepliesListHolder.DislikeView.SetImageResource(2131231010);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000856C File Offset: 0x0000676C
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00008583 File Offset: 0x00006783
		private void OnLikeClick(int obj)
		{
			if (this.LikeClick != null)
			{
				this.LikeClick(this, obj);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000859A File Offset: 0x0000679A
		private void OnDislikeClick(int obj)
		{
			if (this.DislikeClick != null)
			{
				this.DislikeClick(this, obj);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000085B1 File Offset: 0x000067B1
		private void OnProfilePhotoClick(int obj)
		{
			if (this.ItemProfilePhotoClick != null)
			{
				this.ItemProfilePhotoClick(this, obj);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000085C8 File Offset: 0x000067C8
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000107 RID: 263
		private List<CommentRepliesModel> items;

		// Token: 0x04000108 RID: 264
		private Context context;

		// Token: 0x04000109 RID: 265
		public static WebClient client;

		// Token: 0x0400010A RID: 266
		public static Uri uri;

		// Token: 0x0400010B RID: 267
		public static NameValueCollection parameters;
	}
}
