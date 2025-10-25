using System;
using System.Runtime.CompilerServices;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x0200002B RID: 43
	public class LatestEpisodesGridViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008C87 File Offset: 0x00006E87
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00008C8F File Offset: 0x00006E8F
		public TextView TitleView { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00008C98 File Offset: 0x00006E98
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00008CA0 File Offset: 0x00006EA0
		public TextView EpisodeNoView { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00008CA9 File Offset: 0x00006EA9
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00008CB1 File Offset: 0x00006EB1
		public ImageView ThumbnailView { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00008CBA File Offset: 0x00006EBA
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00008CC2 File Offset: 0x00006EC2
		public CardView ParentView { get; set; }

		// Token: 0x060001AA RID: 426 RVA: 0x00008CCC File Offset: 0x00006ECC
		public LatestEpisodesGridViewHolder(View itemView, Action<int> itemClickListener, Action<int> longClickListener, Action<int> titleClickListener) : base(itemView)
		{
			LatestEpisodesGridViewHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131363168);
			this.EpisodeNoView = itemView.FindViewById<TextView>(2131363170);
			this.ThumbnailView = itemView.FindViewById<ImageView>(2131361956);
			this.ParentView = itemView.FindViewById<CardView>(2131363167);
			this.TitleView.Click += delegate(object sender, EventArgs e)
			{
				titleClickListener(<>4__this.LayoutPosition);
			};
			this.ParentView.Click += delegate(object sender, EventArgs e)
			{
				itemClickListener(<>4__this.LayoutPosition);
			};
			this.ParentView.LongClick += delegate(object sender, [Nullable(1)] View.LongClickEventArgs e)
			{
				longClickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
