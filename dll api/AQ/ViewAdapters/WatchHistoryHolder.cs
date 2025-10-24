using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000045 RID: 69
	public class WatchHistoryHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000D55E File Offset: 0x0000B75E
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000D566 File Offset: 0x0000B766
		public TextView Title { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000D56F File Offset: 0x0000B76F
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000D577 File Offset: 0x0000B777
		public TextView EpisodeView { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000D580 File Offset: 0x0000B780
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0000D588 File Offset: 0x0000B788
		public ImageView ThumbnailView { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000D591 File Offset: 0x0000B791
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0000D599 File Offset: 0x0000B799
		public RelativeLayout HistoryContent { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000D5A2 File Offset: 0x0000B7A2
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000D5AA File Offset: 0x0000B7AA
		public ImageView DelIconn { get; set; }

		// Token: 0x060002C3 RID: 707 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public WatchHistoryHolder(View itemView, Action<int> itemClickListener, Action<int> itemDeleteLiseneer) : base(itemView)
		{
			WatchHistoryHolder <>4__this = this;
			this.Title = itemView.FindViewById<TextView>(2131362465);
			this.EpisodeView = itemView.FindViewById<TextView>(2131362460);
			this.ThumbnailView = base.ItemView.FindViewById<ImageView>(2131362464);
			this.DelIconn = itemView.FindViewById<ImageView>(2131362459);
			this.HistoryContent = itemView.FindViewById<RelativeLayout>(2131362458);
			this.HistoryContent.Click += delegate(object sender, EventArgs e)
			{
				itemClickListener(<>4__this.LayoutPosition);
			};
			this.DelIconn.Click += delegate(object sender, EventArgs e)
			{
				itemDeleteLiseneer(<>4__this.LayoutPosition);
			};
		}
	}
}
