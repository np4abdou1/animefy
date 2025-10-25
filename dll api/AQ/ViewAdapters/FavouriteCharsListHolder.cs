using System;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x0200002F RID: 47
	public class FavouriteCharsListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00009B0D File Offset: 0x00007D0D
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00009B15 File Offset: 0x00007D15
		public ImageView LoveButton { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00009B1E File Offset: 0x00007D1E
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00009B26 File Offset: 0x00007D26
		public ImageView UnloveButton { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00009B2F File Offset: 0x00007D2F
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00009B37 File Offset: 0x00007D37
		public ImageView Comments { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00009B40 File Offset: 0x00007D40
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00009B48 File Offset: 0x00007D48
		public TextView Name { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00009B51 File Offset: 0x00007D51
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00009B59 File Offset: 0x00007D59
		public TextView Aka { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00009B62 File Offset: 0x00007D62
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00009B6A File Offset: 0x00007D6A
		public TextView ReactionsCount { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00009B73 File Offset: 0x00007D73
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00009B7B File Offset: 0x00007D7B
		public CircleImageView Photo { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00009B84 File Offset: 0x00007D84
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00009B8C File Offset: 0x00007D8C
		public CardView Parent { get; set; }

		// Token: 0x060001ED RID: 493 RVA: 0x00009B98 File Offset: 0x00007D98
		public FavouriteCharsListHolder(View itemView, Action<int> clickListenrer, Action<int> loveListener, Action<int> unloveListener, Action<int> commentsListener) : base(itemView)
		{
			FavouriteCharsListHolder <>4__this = this;
			this.LoveButton = itemView.FindViewById<ImageView>(2131362109);
			this.UnloveButton = itemView.FindViewById<ImageView>(2131362114);
			this.Comments = itemView.FindViewById<ImageView>(2131362054);
			this.Name = itemView.FindViewById<TextView>(2131362125);
			this.Aka = itemView.FindViewById<TextView>(2131362123);
			this.ReactionsCount = itemView.FindViewById<TextView>(2131362129);
			this.Photo = itemView.FindViewById<CircleImageView>(2131362127);
			this.Parent = itemView.FindViewById<CardView>(2131362567);
			this.LoveButton.Click += delegate(object sender, EventArgs e)
			{
				loveListener(<>4__this.LayoutPosition);
			};
			this.UnloveButton.Click += delegate(object sender, EventArgs e)
			{
				unloveListener(<>4__this.LayoutPosition);
			};
			this.Comments.Click += delegate(object sender, EventArgs e)
			{
				commentsListener(<>4__this.LayoutPosition);
			};
			this.Parent.Click += delegate(object ss, EventArgs ew)
			{
				clickListenrer(<>4__this.LayoutPosition);
			};
		}
	}
}
