using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x0200003D RID: 61
	public class NewsListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000257 RID: 599 RVA: 0x0000BDB0 File Offset: 0x00009FB0
		// (remove) Token: 0x06000258 RID: 600 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public event EventHandler<int> ItemClick;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000259 RID: 601 RVA: 0x0000BE20 File Offset: 0x0000A020
		// (remove) Token: 0x0600025A RID: 602 RVA: 0x0000BE58 File Offset: 0x0000A058
		public event EventHandler<int> ItemShareClick;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x0600025B RID: 603 RVA: 0x0000BE90 File Offset: 0x0000A090
		// (remove) Token: 0x0600025C RID: 604 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		public event EventHandler<int> ItemRelatedClick;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x0600025D RID: 605 RVA: 0x0000BF00 File Offset: 0x0000A100
		// (remove) Token: 0x0600025E RID: 606 RVA: 0x0000BF38 File Offset: 0x0000A138
		public event EventHandler<int> ItemCommentsClick;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600025F RID: 607 RVA: 0x0000BF70 File Offset: 0x0000A170
		// (remove) Token: 0x06000260 RID: 608 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		public event EventHandler<int> ItemEditorPhotoClick;

		// Token: 0x06000261 RID: 609 RVA: 0x0000BFDD File Offset: 0x0000A1DD
		public NewsListAdapter(Context context, List<NewsModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		public override int GetItemViewType(int position)
		{
			return position;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			NewsListHolder result;
			if (viewType < 6 / NewsModel.CurrentNewsScreenWidthRows * NewsModel.CurrentNewsScreenWidthRows)
			{
				result = new NewsListHolder(LayoutInflater.From(parent.Context).Inflate(2131558483, parent, false), new Action<int>(this.OnClick), new Action<int>(this.OnShareClick), new Action<int>(this.OnRelatedClick), new Action<int>(this.OnCommentsClick), new Action<int>(this.OnEditorPhotoClick));
			}
			else
			{
				result = new NewsListHolder(LayoutInflater.From(parent.Context).Inflate(2131558484, parent, false), new Action<int>(this.OnClick), new Action<int>(this.OnShareClick), new Action<int>(this.OnRelatedClick), new Action<int>(this.OnCommentsClick), new Action<int>(this.OnEditorPhotoClick));
			}
			return result;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			NewsModel newsModel = this.items[position];
			NewsListHolder newsListHolder = viewHolder as NewsListHolder;
			newsListHolder.TitleView.Text = newsModel.Title;
			newsListHolder.DateView.Text = newsModel.Date;
			newsListHolder.ViewsView.Text = string.Format("{0:N0}", newsModel.Views);
			newsListHolder.EditorName.Text = newsModel.Editor.FullName;
			Glide.With(this.context).Load(Constants.ProfilePhoto(newsModel.Editor.ProfileImage, newsModel.Editor.UserID.ToString())).CenterCrop().Into(newsListHolder.EditorPhoto);
			Glide.With(this.context).Load(Constants.NewsCover(newsModel.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(newsListHolder.ThumbnailView);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000C1BF File Offset: 0x0000A3BF
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		private void OnShareClick(int obj)
		{
			if (this.ItemShareClick != null)
			{
				this.ItemShareClick(this, obj);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C1ED File Offset: 0x0000A3ED
		private void OnRelatedClick(int obj)
		{
			if (this.ItemRelatedClick != null)
			{
				this.ItemRelatedClick(this, obj);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000C204 File Offset: 0x0000A404
		private void OnCommentsClick(int obj)
		{
			if (this.ItemCommentsClick != null)
			{
				this.ItemCommentsClick(this, obj);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C21B File Offset: 0x0000A41B
		private void OnEditorPhotoClick(int obj)
		{
			if (this.ItemEditorPhotoClick != null)
			{
				this.ItemEditorPhotoClick(this, obj);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000C232 File Offset: 0x0000A432
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x0400016F RID: 367
		private List<NewsModel> items;

		// Token: 0x04000170 RID: 368
		private Context context;
	}
}
