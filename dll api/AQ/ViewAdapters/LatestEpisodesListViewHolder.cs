using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x0200002C RID: 44
	public class LatestEpisodesListViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00008D8C File Offset: 0x00006F8C
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00008D94 File Offset: 0x00006F94
		public TextView TitleView { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00008D9D File Offset: 0x00006F9D
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00008DA5 File Offset: 0x00006FA5
		public TextView Genre { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00008DAE File Offset: 0x00006FAE
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00008DB6 File Offset: 0x00006FB6
		public TextView EpisodeView { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00008DBF File Offset: 0x00006FBF
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00008DC7 File Offset: 0x00006FC7
		public TextView DurationView { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00008DD0 File Offset: 0x00006FD0
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00008DD8 File Offset: 0x00006FD8
		public ImageView ThumbnailView { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00008DE1 File Offset: 0x00006FE1
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00008DE9 File Offset: 0x00006FE9
		public ImageView HomeView { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00008DF2 File Offset: 0x00006FF2
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00008DFA File Offset: 0x00006FFA
		public ImageView NotificationView { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00008E03 File Offset: 0x00007003
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00008E0B File Offset: 0x0000700B
		public ImageView CommentsView { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00008E14 File Offset: 0x00007014
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00008E1C File Offset: 0x0000701C
		public ImageView IndicatorsView { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00008E25 File Offset: 0x00007025
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00008E2D File Offset: 0x0000702D
		public LinearLayout LatestUploadsContent { get; set; }

		// Token: 0x060001BF RID: 447 RVA: 0x00008E38 File Offset: 0x00007038
		public LatestEpisodesListViewHolder(View itemView, Action<int> itemClickListener, Action<int> homeListener, Action<int> commentsListener, Action<int> notificationListener) : base(itemView)
		{
			LatestEpisodesListViewHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131362534);
			this.Genre = itemView.FindViewById<TextView>(2131362529);
			this.EpisodeView = itemView.FindViewById<TextView>(2131362528);
			this.DurationView = itemView.FindViewById<TextView>(2131362527);
			this.ThumbnailView = itemView.FindViewById<ImageView>(2131361956);
			this.HomeView = itemView.FindViewById<ImageView>(2131362530);
			this.NotificationView = itemView.FindViewById<ImageView>(2131362532);
			this.CommentsView = itemView.FindViewById<ImageView>(2131362525);
			this.IndicatorsView = itemView.FindViewById<ImageView>(2131361949);
			this.LatestUploadsContent = itemView.FindViewById<LinearLayout>(2131362526);
			this.LatestUploadsContent.Click += delegate(object sender, EventArgs e)
			{
				itemClickListener(<>4__this.LayoutPosition);
			};
			this.HomeView.Click += delegate(object sender, EventArgs e)
			{
				homeListener(<>4__this.LayoutPosition);
			};
			this.CommentsView.Click += delegate(object sender, EventArgs e)
			{
				commentsListener(<>4__this.LayoutPosition);
			};
			this.NotificationView.Click += delegate(object sender, EventArgs e)
			{
				notificationListener(<>4__this.LayoutPosition);
			};
		}
	}
}
