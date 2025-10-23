using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x0200003F RID: 63
	public class NewsListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000C663 File Offset: 0x0000A863
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000C66B File Offset: 0x0000A86B
		public TextView TitleView { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000C674 File Offset: 0x0000A874
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0000C67C File Offset: 0x0000A87C
		public TextView DateView { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000C685 File Offset: 0x0000A885
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0000C68D File Offset: 0x0000A88D
		public TextView ViewsView { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000C696 File Offset: 0x0000A896
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000C69E File Offset: 0x0000A89E
		public TextView EditorName { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000C6A7 File Offset: 0x0000A8A7
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0000C6AF File Offset: 0x0000A8AF
		public CircleImageView EditorPhoto { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		public ImageView ShareBtn { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000C6C9 File Offset: 0x0000A8C9
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0000C6D1 File Offset: 0x0000A8D1
		public ImageView RelatedBtn { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000C6DA File Offset: 0x0000A8DA
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000C6E2 File Offset: 0x0000A8E2
		public ImageView CommentsBtn { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000C6EB File Offset: 0x0000A8EB
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000C6F3 File Offset: 0x0000A8F3
		public ImageView ThumbnailView { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000C704 File Offset: 0x0000A904
		public LinearLayout NewParentView { get; set; }

		// Token: 0x06000293 RID: 659 RVA: 0x0000C710 File Offset: 0x0000A910
		public NewsListHolder(View itemView, Action<int> listener, Action<int> shareListener, Action<int> relatedListener, Action<int> commentsListener, Action<int> editorPhotoClickListener) : base(itemView)
		{
			NewsListHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131362781);
			this.DateView = itemView.FindViewById<TextView>(2131362770);
			this.ViewsView = itemView.FindViewById<TextView>(2131362782);
			this.EditorName = itemView.FindViewById<TextView>(2131362771);
			this.EditorPhoto = itemView.FindViewById<CircleImageView>(2131362772);
			this.ShareBtn = itemView.FindViewById<ImageView>(2131362778);
			this.RelatedBtn = itemView.FindViewById<ImageView>(2131362776);
			this.CommentsBtn = itemView.FindViewById<ImageView>(2131362768);
			this.ThumbnailView = itemView.FindViewById<ImageView>(2131362780);
			this.NewParentView = itemView.FindViewById<LinearLayout>(2131362775);
			this.NewParentView.Click += delegate(object sender, EventArgs e)
			{
				listener(<>4__this.LayoutPosition);
			};
			this.ShareBtn.Click += delegate(object sender, EventArgs e)
			{
				shareListener(<>4__this.LayoutPosition);
			};
			this.RelatedBtn.Click += delegate(object sender, EventArgs e)
			{
				relatedListener(<>4__this.LayoutPosition);
			};
			this.CommentsBtn.Click += delegate(object sender, EventArgs e)
			{
				commentsListener(<>4__this.LayoutPosition);
			};
			this.EditorPhoto.Click += delegate(object sender, EventArgs e)
			{
				editorPhotoClickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
