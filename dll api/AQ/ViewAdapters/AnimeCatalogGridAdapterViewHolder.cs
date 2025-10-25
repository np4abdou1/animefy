using System;
using System.Runtime.CompilerServices;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using Com.Wang.Avi;

namespace AQ.ViewAdapters
{
	// Token: 0x02000011 RID: 17
	internal class AnimeCatalogGridAdapterViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000562A File Offset: 0x0000382A
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005632 File Offset: 0x00003832
		public TextView TitleView { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000563B File Offset: 0x0000383B
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00005643 File Offset: 0x00003843
		public TextView RateView { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000564C File Offset: 0x0000384C
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00005654 File Offset: 0x00003854
		public TextView HintView { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000565D File Offset: 0x0000385D
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00005665 File Offset: 0x00003865
		public ImageView ThumbnailView { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000566E File Offset: 0x0000386E
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00005676 File Offset: 0x00003876
		public TextView TypeView { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000567F File Offset: 0x0000387F
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00005687 File Offset: 0x00003887
		public LinearLayout TypeContentView { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005690 File Offset: 0x00003890
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00005698 File Offset: 0x00003898
		public ImageView LibraryView { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000056A1 File Offset: 0x000038A1
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000056A9 File Offset: 0x000038A9
		public AVLoadingIndicatorView StatusView { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000056B2 File Offset: 0x000038B2
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000056BA File Offset: 0x000038BA
		public CardView ParentView { get; set; }

		// Token: 0x06000093 RID: 147 RVA: 0x000056C4 File Offset: 0x000038C4
		public AnimeCatalogGridAdapterViewHolder(View itemView, Action<int> clickListener, Action<int> longClickListener, Action<int> favClickListener) : base(itemView)
		{
			AnimeCatalogGridAdapterViewHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131361958);
			this.RateView = itemView.FindViewById<TextView>(2131361952);
			this.HintView = itemView.FindViewById<TextView>(2131361948);
			this.ThumbnailView = itemView.FindViewById<ImageView>(2131361956);
			this.TypeView = itemView.FindViewById<TextView>(2131361959);
			this.TypeContentView = itemView.FindViewById<LinearLayout>(2131361960);
			this.LibraryView = itemView.FindViewById<ImageView>(2131361949);
			this.StatusView = itemView.FindViewById<AVLoadingIndicatorView>(2131361954);
			this.ParentView = itemView.FindViewById<CardView>(2131361946);
			this.ParentView.LongClick += delegate(object sender, [Nullable(1)] View.LongClickEventArgs e)
			{
				longClickListener(<>4__this.LayoutPosition);
			};
			this.ParentView.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
