using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Refractored.Controls;

namespace AQ.ViewAdapters
{
	// Token: 0x02000025 RID: 37
	public class CommentsRepliesListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000075E9 File Offset: 0x000057E9
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000075F1 File Offset: 0x000057F1
		public CircleImageView ProfileImageView { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000075FA File Offset: 0x000057FA
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00007602 File Offset: 0x00005802
		public TextView FullNameView { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000760B File Offset: 0x0000580B
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00007613 File Offset: 0x00005813
		public TextView ReplyTimeView { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000761C File Offset: 0x0000581C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00007624 File Offset: 0x00005824
		public TextView ReplyBodyView { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000762D File Offset: 0x0000582D
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00007635 File Offset: 0x00005835
		public ImageView LikeView { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000763E File Offset: 0x0000583E
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00007646 File Offset: 0x00005846
		public ImageView DislikeView { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000764F File Offset: 0x0000584F
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00007657 File Offset: 0x00005857
		public TextView LikesCountView { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00007660 File Offset: 0x00005860
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00007668 File Offset: 0x00005868
		public TextView DislikesCountView { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007671 File Offset: 0x00005871
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00007679 File Offset: 0x00005879
		public ImageView OptionMenuView { get; set; }

		// Token: 0x06000157 RID: 343 RVA: 0x00007684 File Offset: 0x00005884
		public CommentsRepliesListHolder(View itemView, Action<int> optionMenuListener, Action<int> likeListener, Action<int> dislikeListener, Action<int> profilePhotoClickListener) : base(itemView)
		{
			CommentsRepliesListHolder <>4__this = this;
			this.ProfileImageView = itemView.FindViewById<CircleImageView>(2131362172);
			this.FullNameView = itemView.FindViewById<TextView>(2131362183);
			this.ReplyTimeView = itemView.FindViewById<TextView>(2131362182);
			this.ReplyBodyView = itemView.FindViewById<TextView>(2131362173);
			this.LikeView = itemView.FindViewById<ImageView>(2131362177);
			this.DislikeView = itemView.FindViewById<ImageView>(2131362175);
			this.LikesCountView = itemView.FindViewById<TextView>(2131362178);
			this.DislikesCountView = itemView.FindViewById<TextView>(2131362176);
			this.OptionMenuView = itemView.FindViewById<ImageView>(2131362179);
			this.OptionMenuView.Click += delegate(object sender, EventArgs e)
			{
				optionMenuListener(<>4__this.LayoutPosition);
			};
			this.LikeView.Click += delegate(object sender, EventArgs e)
			{
				likeListener(<>4__this.LayoutPosition);
			};
			this.DislikeView.Click += delegate(object sender, EventArgs e)
			{
				dislikeListener(<>4__this.LayoutPosition);
			};
			this.ProfileImageView.Click += delegate(object sender, EventArgs e)
			{
				profilePhotoClickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
