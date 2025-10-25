using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x02000024 RID: 36
	public class CommentsListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000072E5 File Offset: 0x000054E5
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000072ED File Offset: 0x000054ED
		public TextView FullNameView { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000072F6 File Offset: 0x000054F6
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000072FE File Offset: 0x000054FE
		public TextView CommTimeView { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00007307 File Offset: 0x00005507
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000730F File Offset: 0x0000550F
		public TextView CommBodyView { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00007318 File Offset: 0x00005518
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00007320 File Offset: 0x00005520
		public CircleImageView ProfileImageView { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00007329 File Offset: 0x00005529
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00007331 File Offset: 0x00005531
		public LinearLayout PinnedView { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000733A File Offset: 0x0000553A
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00007342 File Offset: 0x00005542
		public ImageView LikeView { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000734B File Offset: 0x0000554B
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00007353 File Offset: 0x00005553
		public ImageView DislikeView { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000735C File Offset: 0x0000555C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00007364 File Offset: 0x00005564
		public TextView LikesCountView { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000736D File Offset: 0x0000556D
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00007375 File Offset: 0x00005575
		public TextView DislikesCountView { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000737E File Offset: 0x0000557E
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00007386 File Offset: 0x00005586
		public LinearLayout SpoilerContent { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000738F File Offset: 0x0000558F
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00007397 File Offset: 0x00005597
		public RecyclerView RepliesListView { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000073A0 File Offset: 0x000055A0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000073A8 File Offset: 0x000055A8
		public TextView RepliesShowHideView { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000073B1 File Offset: 0x000055B1
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000073B9 File Offset: 0x000055B9
		public ImageView ReplyView { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000073C2 File Offset: 0x000055C2
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000073CA File Offset: 0x000055CA
		public ImageView OptionMenuView { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000073D3 File Offset: 0x000055D3
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000073DB File Offset: 0x000055DB
		public LinearLayout CommentContentView { get; set; }

		// Token: 0x06000144 RID: 324 RVA: 0x000073E4 File Offset: 0x000055E4
		public CommentsListHolder(View itemView, Action<int> contentClickListener, Action<int> optionMenuClickListener, Action<int> showHideRepliesListener, Action<int> showRepliesListenrer, Action<int> likeClickListener, Action<int> dislikeClickListener, Action<int> profilePhotoClickListener, Action<int> showSpoilerClickListener) : base(itemView)
		{
			CommentsListHolder <>4__this = this;
			this.FullNameView = itemView.FindViewById<TextView>(2131362224);
			this.CommTimeView = itemView.FindViewById<TextView>(2131362223);
			this.CommBodyView = itemView.FindViewById<TextView>(2131362210);
			this.ProfileImageView = itemView.FindViewById<CircleImageView>(2131362209);
			this.PinnedView = itemView.FindViewById<LinearLayout>(2131362847);
			this.LikeView = itemView.FindViewById<ImageView>(2131362215);
			this.DislikeView = itemView.FindViewById<ImageView>(2131362213);
			this.LikesCountView = itemView.FindViewById<TextView>(2131362216);
			this.DislikesCountView = itemView.FindViewById<TextView>(2131362214);
			this.SpoilerContent = itemView.FindViewById<LinearLayout>(2131363089);
			this.ReplyView = itemView.FindViewById<ImageView>(2131362222);
			this.RepliesShowHideView = itemView.FindViewById<TextView>(2131362225);
			this.OptionMenuView = itemView.FindViewById<ImageView>(2131362217);
			this.CommentContentView = itemView.FindViewById<LinearLayout>(2131362211);
			this.RepliesShowHideView.Click += delegate(object sender, EventArgs e)
			{
				showHideRepliesListener(<>4__this.LayoutPosition);
			};
			this.ReplyView.Click += delegate(object sender, EventArgs e)
			{
				showRepliesListenrer(<>4__this.LayoutPosition);
			};
			this.LikeView.Click += delegate(object sender, EventArgs e)
			{
				likeClickListener(<>4__this.LayoutPosition);
			};
			this.DislikeView.Click += delegate(object sender, EventArgs e)
			{
				dislikeClickListener(<>4__this.LayoutPosition);
			};
			this.ProfileImageView.Click += delegate(object sender, EventArgs e)
			{
				profilePhotoClickListener(<>4__this.LayoutPosition);
			};
			this.SpoilerContent.Click += delegate(object sender, EventArgs e)
			{
				showSpoilerClickListener(<>4__this.LayoutPosition);
			};
			this.OptionMenuView.Click += delegate(object sender, EventArgs e)
			{
				optionMenuClickListener(<>4__this.LayoutPosition);
			};
			this.CommentContentView.Click += delegate(object sender, EventArgs e)
			{
				contentClickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
