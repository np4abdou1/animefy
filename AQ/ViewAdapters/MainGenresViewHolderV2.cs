using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000039 RID: 57
	public class MainGenresViewHolderV2 : RecyclerView.ViewHolder
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000AB8D File Offset: 0x00008D8D
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000AB95 File Offset: 0x00008D95
		public TextView TitleView { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000AB9E File Offset: 0x00008D9E
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000ABA6 File Offset: 0x00008DA6
		public ImageView BackgroundView { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000ABAF File Offset: 0x00008DAF
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000ABB7 File Offset: 0x00008DB7
		public FrameLayout BackgroundSelector { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		public LinearLayout ParentView { get; set; }

		// Token: 0x0600023F RID: 575 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		public MainGenresViewHolderV2(View itemView, Action<int> clickListener) : base(itemView)
		{
			MainGenresViewHolderV2 <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131362574);
			this.BackgroundView = itemView.FindViewById<ImageView>(2131362571);
			this.BackgroundSelector = itemView.FindViewById<FrameLayout>(2131362572);
			this.ParentView = itemView.FindViewById<LinearLayout>(2131362573);
			this.ParentView.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
