using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x0200003E RID: 62
	public class HomeNewsListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600026B RID: 619 RVA: 0x0000C240 File Offset: 0x0000A440
		// (remove) Token: 0x0600026C RID: 620 RVA: 0x0000C278 File Offset: 0x0000A478
		public event EventHandler<int> ItemClick;

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600026D RID: 621 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		// (remove) Token: 0x0600026E RID: 622 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		public event EventHandler<int> ItemShareClick;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600026F RID: 623 RVA: 0x0000C320 File Offset: 0x0000A520
		// (remove) Token: 0x06000270 RID: 624 RVA: 0x0000C358 File Offset: 0x0000A558
		public event EventHandler<int> ItemRelatedClick;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000271 RID: 625 RVA: 0x0000C390 File Offset: 0x0000A590
		// (remove) Token: 0x06000272 RID: 626 RVA: 0x0000C3C8 File Offset: 0x0000A5C8
		public event EventHandler<int> ItemCommentsClick;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000273 RID: 627 RVA: 0x0000C400 File Offset: 0x0000A600
		// (remove) Token: 0x06000274 RID: 628 RVA: 0x0000C438 File Offset: 0x0000A638
		public event EventHandler<int> ItemEditorPhotoClick;

		// Token: 0x06000275 RID: 629 RVA: 0x0000C46D File Offset: 0x0000A66D
		public HomeNewsListAdapter(Context context, List<NewsModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		public override int GetItemViewType(int position)
		{
			return position;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000C484 File Offset: 0x0000A684
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558484;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new NewsListHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnShareClick), new Action<int>(this.OnRelatedClick), new Action<int>(this.OnCommentsClick), new Action<int>(this.OnEditorPhotoClick));
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			NewsModel newsModel = this.items[position];
			NewsListHolder newsListHolder = viewHolder as NewsListHolder;
			newsListHolder.TitleView.Text = newsModel.Title;
			newsListHolder.DateView.Text = newsModel.Date;
			newsListHolder.EditorName.Text = newsModel.Editor.FullName;
			newsListHolder.ViewsView.Text = string.Format("{0:N0}", newsModel.Views);
			Glide.With(this.context).Load(Constants.ProfilePhoto(newsModel.Editor.ProfileImage, newsModel.Editor.UserID.ToString())).CenterCrop().Into(newsListHolder.EditorPhoto);
			Glide.With(this.context).Load(Constants.NewsCover(newsModel.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(newsListHolder.ThumbnailView);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000C5E3 File Offset: 0x0000A7E3
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000C5FA File Offset: 0x0000A7FA
		private void OnShareClick(int obj)
		{
			if (this.ItemShareClick != null)
			{
				this.ItemShareClick(this, obj);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000C611 File Offset: 0x0000A811
		private void OnRelatedClick(int obj)
		{
			if (this.ItemRelatedClick != null)
			{
				this.ItemRelatedClick(this, obj);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000C628 File Offset: 0x0000A828
		private void OnCommentsClick(int obj)
		{
			if (this.ItemCommentsClick != null)
			{
				this.ItemCommentsClick(this, obj);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000C63F File Offset: 0x0000A83F
		private void OnEditorPhotoClick(int obj)
		{
			if (this.ItemEditorPhotoClick != null)
			{
				this.ItemEditorPhotoClick(this, obj);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000C656 File Offset: 0x0000A856
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000176 RID: 374
		private List<NewsModel> items;

		// Token: 0x04000177 RID: 375
		private Context context;
	}
}
