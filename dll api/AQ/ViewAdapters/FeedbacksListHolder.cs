using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000031 RID: 49
	public class FeedbacksListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000A07D File Offset: 0x0000827D
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000A085 File Offset: 0x00008285
		public TextView SubjectView { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000A08E File Offset: 0x0000828E
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000A096 File Offset: 0x00008296
		public TextView BodyView { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000A09F File Offset: 0x0000829F
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000A0A7 File Offset: 0x000082A7
		public ImageView DoneView { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000A0B0 File Offset: 0x000082B0
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public RelativeLayout ContentView { get; set; }

		// Token: 0x06000207 RID: 519 RVA: 0x0000A0C4 File Offset: 0x000082C4
		public FeedbacksListHolder(View itemView, Action<int> listener) : base(itemView)
		{
			FeedbacksListHolder <>4__this = this;
			this.SubjectView = itemView.FindViewById<TextView>(2131362410);
			this.BodyView = itemView.FindViewById<TextView>(2131362396);
			this.DoneView = itemView.FindViewById<ImageView>(2131362400);
			this.ContentView = itemView.FindViewById<RelativeLayout>(2131362399);
			this.ContentView.Click += delegate(object sender, EventArgs e)
			{
				listener(<>4__this.LayoutPosition);
			};
		}
	}
}
