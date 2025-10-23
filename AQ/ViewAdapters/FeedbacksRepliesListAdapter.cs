using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.Core.Content;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000034 RID: 52
	public class FeedbacksRepliesListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000218 RID: 536 RVA: 0x0000A528 File Offset: 0x00008728
		// (remove) Token: 0x06000219 RID: 537 RVA: 0x0000A560 File Offset: 0x00008760
		public event EventHandler<int> ItemAvatarClick;

		// Token: 0x0600021A RID: 538 RVA: 0x0000A595 File Offset: 0x00008795
		public FeedbacksRepliesListAdapter(Context context, List<FeedBackRepliesModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000A5AC File Offset: 0x000087AC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558625;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new FeedbacksRepliesListHolder(itemView, new Action<int>(this.OnAvatarClick));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000A5E8 File Offset: 0x000087E8
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			FeedBackRepliesModel feedBackRepliesModel = this.items[position];
			FeedbacksRepliesListHolder feedbacksRepliesListHolder = viewHolder as FeedbacksRepliesListHolder;
			feedbacksRepliesListHolder.FullnameView.Text = feedBackRepliesModel.UserData.FullName;
			feedbacksRepliesListHolder.ReplyBodyView.Text = feedBackRepliesModel.ReplyBody;
			if (feedBackRepliesModel.UserData.Membership == "ADMIN")
			{
				feedbacksRepliesListHolder.AvatarView.BorderWidth = 2;
				feedbacksRepliesListHolder.AvatarView.BorderColor = ContextCompat.GetColor(this.context, 2131099751);
			}
			else
			{
				feedbacksRepliesListHolder.AvatarView.BorderWidth = 2;
				feedbacksRepliesListHolder.AvatarView.BorderColor = ContextCompat.GetColor(this.context, 2131100506);
			}
			if (feedBackRepliesModel.UserData.ProfileImage != "")
			{
				Glide.With(this.context).Load(Constants.ProfilePhoto(feedBackRepliesModel.UserData.ProfileImage, feedBackRepliesModel.UserData.UserID.ToString())).CenterCrop().Into(feedbacksRepliesListHolder.AvatarView);
				return;
			}
			if (feedBackRepliesModel.UserData.GoogleProfilePhotoUrl != "")
			{
				Glide.With(this.context).Load(feedBackRepliesModel.UserData.GoogleProfilePhotoUrl).CenterCrop().Placeholder(2131231224).Into(feedbacksRepliesListHolder.AvatarView);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000A740 File Offset: 0x00008940
		private void OnAvatarClick(int obj)
		{
			if (this.ItemAvatarClick != null)
			{
				this.ItemAvatarClick(this, obj);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000A757 File Offset: 0x00008957
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x0400014E RID: 334
		private List<FeedBackRepliesModel> items;

		// Token: 0x0400014F RID: 335
		private Context context;
	}
}
