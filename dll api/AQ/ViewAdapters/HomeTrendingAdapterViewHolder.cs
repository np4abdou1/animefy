using System;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x0200003C RID: 60
	public class HomeTrendingAdapterViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000BCE6 File Offset: 0x00009EE6
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000BCEE File Offset: 0x00009EEE
		public TextView SliderTitle { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000BCF7 File Offset: 0x00009EF7
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000BCFF File Offset: 0x00009EFF
		public TextView SliderHint { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000BD08 File Offset: 0x00009F08
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000BD10 File Offset: 0x00009F10
		public ImageView SliderPhoto { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000BD19 File Offset: 0x00009F19
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000BD21 File Offset: 0x00009F21
		public CardView SliderView { get; set; }

		// Token: 0x06000256 RID: 598 RVA: 0x0000BD2C File Offset: 0x00009F2C
		public HomeTrendingAdapterViewHolder(View itemView, Action<int> clickListener) : base(itemView)
		{
			HomeTrendingAdapterViewHolder <>4__this = this;
			this.SliderTitle = itemView.FindViewById<TextView>(2131362488);
			this.SliderHint = itemView.FindViewById<TextView>(2131362485);
			this.SliderPhoto = itemView.FindViewById<ImageView>(2131362487);
			this.SliderView = itemView.FindViewById<CardView>(2131362486);
			this.SliderView.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
