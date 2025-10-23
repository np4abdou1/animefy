using System;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using Com.Wang.Avi;

namespace AQ.ViewAdapters
{
	// Token: 0x02000010 RID: 16
	internal class AnimeCatalogListAdapterViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000053F1 File Offset: 0x000035F1
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000053F9 File Offset: 0x000035F9
		public TextView TitleView { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005402 File Offset: 0x00003602
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000540A File Offset: 0x0000360A
		public TextView RateView { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005413 File Offset: 0x00003613
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000541B File Offset: 0x0000361B
		public TextView HintView { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00005424 File Offset: 0x00003624
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000542C File Offset: 0x0000362C
		public TextView SubTitleView { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00005435 File Offset: 0x00003635
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000543D File Offset: 0x0000363D
		public TextView GenresView { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005446 File Offset: 0x00003646
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000544E File Offset: 0x0000364E
		public TextView ReleaseDateView { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005457 File Offset: 0x00003657
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000545F File Offset: 0x0000365F
		public ImageView ThumbnailView { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005468 File Offset: 0x00003668
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00005470 File Offset: 0x00003670
		public TextView PlotView { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005479 File Offset: 0x00003679
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00005481 File Offset: 0x00003681
		public TextView TypeView { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000548A File Offset: 0x0000368A
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005492 File Offset: 0x00003692
		public LinearLayout TypeContentView { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000549B File Offset: 0x0000369B
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000054A3 File Offset: 0x000036A3
		public ImageView OptionMenuView { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000054AC File Offset: 0x000036AC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000054B4 File Offset: 0x000036B4
		public AVLoadingIndicatorView StatusView { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000054BD File Offset: 0x000036BD
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000054C5 File Offset: 0x000036C5
		public CardView ParentView { get; set; }

		// Token: 0x06000080 RID: 128 RVA: 0x000054D0 File Offset: 0x000036D0
		public AnimeCatalogListAdapterViewHolder(View itemView, Action<int> clickListener, Action<int> favClickListener, Action<int> optionMenuListener, Action<int> plotListener) : base(itemView)
		{
			AnimeCatalogListAdapterViewHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131361958);
			this.RateView = itemView.FindViewById<TextView>(2131361952);
			this.HintView = itemView.FindViewById<TextView>(2131361948);
			this.SubTitleView = itemView.FindViewById<TextView>(2131361955);
			this.ThumbnailView = itemView.FindViewById<ImageView>(2131361956);
			this.GenresView = itemView.FindViewById<TextView>(2131361947);
			this.ReleaseDateView = itemView.FindViewById<TextView>(2131361953);
			this.PlotView = itemView.FindViewById<TextView>(2131361951);
			this.TypeView = itemView.FindViewById<TextView>(2131361959);
			this.TypeContentView = itemView.FindViewById<LinearLayout>(2131361960);
			this.OptionMenuView = itemView.FindViewById<ImageView>(2131361950);
			this.StatusView = itemView.FindViewById<AVLoadingIndicatorView>(2131361954);
			this.ParentView = itemView.FindViewById<CardView>(2131361946);
			this.PlotView.Click += delegate(object sender, EventArgs e)
			{
				plotListener(<>4__this.LayoutPosition);
			};
			this.OptionMenuView.Click += delegate(object sender, EventArgs e)
			{
				optionMenuListener(<>4__this.LayoutPosition);
			};
			this.ParentView.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
