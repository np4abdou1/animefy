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
	// Token: 0x02000027 RID: 39
	public class CommentsListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600015B RID: 347 RVA: 0x00007940 File Offset: 0x00005B40
		// (remove) Token: 0x0600015C RID: 348 RVA: 0x00007978 File Offset: 0x00005B78
		public event EventHandler<int> ItemClick;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600015D RID: 349 RVA: 0x000079B0 File Offset: 0x00005BB0
		// (remove) Token: 0x0600015E RID: 350 RVA: 0x000079E8 File Offset: 0x00005BE8
		public event EventHandler<int> ItemOptionMenuClick;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600015F RID: 351 RVA: 0x00007A20 File Offset: 0x00005C20
		// (remove) Token: 0x06000160 RID: 352 RVA: 0x00007A58 File Offset: 0x00005C58
		public event EventHandler<int> ItemShowHideReplies;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000161 RID: 353 RVA: 0x00007A90 File Offset: 0x00005C90
		// (remove) Token: 0x06000162 RID: 354 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public event EventHandler<int> ItemShowReplies;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000163 RID: 355 RVA: 0x00007B00 File Offset: 0x00005D00
		// (remove) Token: 0x06000164 RID: 356 RVA: 0x00007B38 File Offset: 0x00005D38
		public event EventHandler<int> ItemLikeClick;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000165 RID: 357 RVA: 0x00007B70 File Offset: 0x00005D70
		// (remove) Token: 0x06000166 RID: 358 RVA: 0x00007BA8 File Offset: 0x00005DA8
		public event EventHandler<int> ItemDislikeClick;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000167 RID: 359 RVA: 0x00007BE0 File Offset: 0x00005DE0
		// (remove) Token: 0x06000168 RID: 360 RVA: 0x00007C18 File Offset: 0x00005E18
		public event EventHandler<int> ItemProfilePhotoClick;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000169 RID: 361 RVA: 0x00007C50 File Offset: 0x00005E50
		// (remove) Token: 0x0600016A RID: 362 RVA: 0x00007C88 File Offset: 0x00005E88
		public event EventHandler<int> ItemShowSpoilerClick;

		// Token: 0x0600016B RID: 363 RVA: 0x00007CBD File Offset: 0x00005EBD
		public CommentsListAdapter(Context context, List<CommentsModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007CD4 File Offset: 0x00005ED4
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558477;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CommentsListHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnOptionMenuClick), new Action<int>(this.OnShowHideReplies), new Action<int>(this.OnShowRelies), new Action<int>(this.OnLikeClick), new Action<int>(this.OnDisLikeClick), new Action<int>(this.OnProfilePhotoClick), new Action<int>(this.OnShowSpoilerClick));
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00007D64 File Offset: 0x00005F64
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CommentsModel commentsModel = this.items[position];
			CommentsListHolder commentsListHolder = viewHolder as CommentsListHolder;
			commentsListHolder.CommBodyView.Text = commentsModel.CommBody;
			commentsListHolder.CommBodyView.Post(new ReedMoreHelper(this.context, commentsListHolder.CommBodyView));
			commentsListHolder.CommTimeView.Text = commentsModel.CommTime;
			commentsListHolder.FullNameView.Text = commentsModel.User.FullName;
			commentsListHolder.LikesCountView.Text = commentsModel.LikesCount.ToString();
			commentsListHolder.DislikesCountView.Text = commentsModel.DislikesCount.ToString();
			if (commentsModel.Pinned > 0)
			{
				commentsListHolder.PinnedView.Visibility = ViewStates.Visible;
			}
			else
			{
				commentsListHolder.PinnedView.Visibility = ViewStates.Gone;
			}
			if (commentsModel.User.ProfileImage != "")
			{
				Glide.With(this.context).Load(Constants.ProfilePhoto(commentsModel.User.ProfileImage, commentsModel.UserID.ToString())).Into(commentsListHolder.ProfileImageView);
			}
			else if (commentsModel.User.GoogleProfilePhotoUrl != "")
			{
				Glide.With(this.context).Load(commentsModel.User.GoogleProfilePhotoUrl).Into(commentsListHolder.ProfileImageView);
			}
			else
			{
				commentsListHolder.ProfileImageView.SetImageResource(2131231168);
			}
			if (commentsModel.User.Membership == "ADMIN")
			{
				commentsListHolder.ProfileImageView.BorderWidth = 6;
				commentsListHolder.ProfileImageView.BorderColor = ContextCompat.GetColor(this.context, 2131100510);
			}
			else
			{
				commentsListHolder.ProfileImageView.BorderWidth = 2;
				commentsListHolder.ProfileImageView.BorderColor = ContextCompat.GetColor(this.context, 2131100465);
			}
			if (commentsModel.LikeOrDislike == "1")
			{
				commentsListHolder.LikeView.SetImageResource(2131231100);
			}
			else
			{
				commentsListHolder.LikeView.SetImageResource(2131231099);
			}
			if (commentsModel.LikeOrDislike == "0")
			{
				commentsListHolder.DislikeView.SetImageResource(2131231011);
			}
			else
			{
				commentsListHolder.DislikeView.SetImageResource(2131231010);
			}
			if (commentsModel.RepliesCount > 0)
			{
				commentsListHolder.RepliesShowHideView.Text = string.Concat(new string[]
				{
					this.context.Resources.GetString(2131952564),
					" ",
					commentsModel.RepliesCount.ToString(),
					" ",
					this.context.Resources.GetString(2131952333)
				});
				commentsListHolder.RepliesShowHideView.Visibility = ViewStates.Visible;
			}
			else
			{
				commentsListHolder.RepliesShowHideView.Text = "";
				commentsListHolder.RepliesShowHideView.Visibility = ViewStates.Gone;
			}
			if (commentsModel.Spoiler == 1)
			{
				commentsListHolder.CommBodyView.Visibility = ViewStates.Gone;
				commentsListHolder.SpoilerContent.Visibility = ViewStates.Visible;
				return;
			}
			commentsListHolder.CommBodyView.Visibility = ViewStates.Visible;
			commentsListHolder.SpoilerContent.Visibility = ViewStates.Gone;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008075 File Offset: 0x00006275
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000808C File Offset: 0x0000628C
		private void OnOptionMenuClick(int obj)
		{
			if (this.ItemOptionMenuClick != null)
			{
				this.ItemOptionMenuClick(this, obj);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000080A3 File Offset: 0x000062A3
		private void OnShowHideReplies(int obj)
		{
			if (this.ItemShowHideReplies != null)
			{
				this.ItemShowHideReplies(this, obj);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000080BA File Offset: 0x000062BA
		private void OnShowRelies(int obj)
		{
			if (this.ItemShowReplies != null)
			{
				this.ItemShowReplies(this, obj);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000080D1 File Offset: 0x000062D1
		private void OnLikeClick(int obj)
		{
			if (this.ItemLikeClick != null)
			{
				this.ItemLikeClick(this, obj);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000080E8 File Offset: 0x000062E8
		private void OnDisLikeClick(int obj)
		{
			if (this.ItemDislikeClick != null)
			{
				this.ItemDislikeClick(this, obj);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000080FF File Offset: 0x000062FF
		private void OnProfilePhotoClick(int obj)
		{
			if (this.ItemProfilePhotoClick != null)
			{
				this.ItemProfilePhotoClick(this, obj);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008116 File Offset: 0x00006316
		private void OnShowSpoilerClick(int obj)
		{
			if (this.ItemShowSpoilerClick != null)
			{
				this.ItemShowSpoilerClick(this, obj);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000812D File Offset: 0x0000632D
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000FE RID: 254
		private List<CommentsModel> items;

		// Token: 0x040000FF RID: 255
		private Context context;

		// Token: 0x04000100 RID: 256
		public static WebClient client;

		// Token: 0x04000101 RID: 257
		public static Uri uri;

		// Token: 0x04000102 RID: 258
		public static NameValueCollection parameters;
	}
}
