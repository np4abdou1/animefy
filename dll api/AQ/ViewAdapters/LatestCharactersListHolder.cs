using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x02000016 RID: 22
	public class LatestCharactersListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000063EF File Offset: 0x000045EF
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000063F7 File Offset: 0x000045F7
		public TextView Name { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00006400 File Offset: 0x00004600
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00006408 File Offset: 0x00004608
		public CircleImageView PhotoView { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006411 File Offset: 0x00004611
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00006419 File Offset: 0x00004619
		public ImageView CoverView { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006422 File Offset: 0x00004622
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000642A File Offset: 0x0000462A
		public RelativeLayout ParentClickble { get; set; }

		// Token: 0x060000CC RID: 204 RVA: 0x00006434 File Offset: 0x00004634
		public LatestCharactersListHolder(View itemView, Action<int> clickListener) : base(itemView)
		{
			LatestCharactersListHolder <>4__this = this;
			this.Name = itemView.FindViewById<TextView>(2131362125);
			this.PhotoView = itemView.FindViewById<CircleImageView>(2131362127);
			this.CoverView = itemView.FindViewById<ImageView>(2131362124);
			this.ParentClickble = itemView.FindViewById<RelativeLayout>(2131362126);
			this.ParentClickble.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
