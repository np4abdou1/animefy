using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x02000033 RID: 51
	public class FeedbacksRepliesListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000A46E File Offset: 0x0000866E
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000A476 File Offset: 0x00008676
		public TextView FullnameView { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000A47F File Offset: 0x0000867F
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000A487 File Offset: 0x00008687
		public TextView ReplyBodyView { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000A490 File Offset: 0x00008690
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0000A498 File Offset: 0x00008698
		public CircleImageView AvatarView { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000A4A1 File Offset: 0x000086A1
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000A4A9 File Offset: 0x000086A9
		public RelativeLayout ContentView { get; set; }

		// Token: 0x06000217 RID: 535 RVA: 0x0000A4B4 File Offset: 0x000086B4
		public FeedbacksRepliesListHolder(View itemView, Action<int> avatarClickListner) : base(itemView)
		{
			FeedbacksRepliesListHolder <>4__this = this;
			this.FullnameView = itemView.FindViewById<TextView>(2131362405);
			this.ReplyBodyView = itemView.FindViewById<TextView>(2131362404);
			this.AvatarView = itemView.FindViewById<CircleImageView>(2131362403);
			this.AvatarView.Click += delegate(object sender, EventArgs e)
			{
				avatarClickListner(<>4__this.LayoutPosition);
			};
		}
	}
}
