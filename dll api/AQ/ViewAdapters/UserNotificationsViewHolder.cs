using System;
using System.Runtime.CompilerServices;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x02000040 RID: 64
	public class UserNotificationsViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000C874 File Offset: 0x0000AA74
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000C87C File Offset: 0x0000AA7C
		public TextView TitleView { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000C885 File Offset: 0x0000AA85
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000C88D File Offset: 0x0000AA8D
		public TextView BodyView { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000C896 File Offset: 0x0000AA96
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000C89E File Offset: 0x0000AA9E
		public TextView DateView { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000C8AF File Offset: 0x0000AAAF
		public CircleImageView AvatarView { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000C8C0 File Offset: 0x0000AAC0
		public FrameLayout NewNotificationShadowView { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000C8C9 File Offset: 0x0000AAC9
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000C8D1 File Offset: 0x0000AAD1
		public LinearLayout ContentView { get; set; }

		// Token: 0x060002A0 RID: 672 RVA: 0x0000C8DC File Offset: 0x0000AADC
		public UserNotificationsViewHolder(View itemView, Action<int> clickListener, Action<int> avatarClickListener, Action<int> longClickListener) : base(itemView)
		{
			UserNotificationsViewHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131362806);
			this.BodyView = itemView.FindViewById<TextView>(2131362800);
			this.DateView = itemView.FindViewById<TextView>(2131362802);
			this.AvatarView = itemView.FindViewById<CircleImageView>(2131362798);
			this.NewNotificationShadowView = itemView.FindViewById<FrameLayout>(2131362774);
			this.ContentView = itemView.FindViewById<LinearLayout>(2131362801);
			this.ContentView.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
			this.AvatarView.Click += delegate(object sender, EventArgs e)
			{
				avatarClickListener(<>4__this.LayoutPosition);
			};
			this.ContentView.LongClick += delegate(object sender, [Nullable(1)] View.LongClickEventArgs e)
			{
				longClickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
