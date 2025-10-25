using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000029 RID: 41
	public class EpisodesListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000085D5 File Offset: 0x000067D5
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000085DD File Offset: 0x000067DD
		public TextView TitleView { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000085E6 File Offset: 0x000067E6
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000085EE File Offset: 0x000067EE
		public TextView EpisodeNumber { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000085F7 File Offset: 0x000067F7
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000085FF File Offset: 0x000067FF
		public TextView EpisodeType { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00008608 File Offset: 0x00006808
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00008610 File Offset: 0x00006810
		public ImageView ViewStatus { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00008619 File Offset: 0x00006819
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00008621 File Offset: 0x00006821
		public ImageView Comments { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000862A File Offset: 0x0000682A
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00008632 File Offset: 0x00006832
		public RelativeLayout Content { get; set; }

		// Token: 0x06000193 RID: 403 RVA: 0x0000863C File Offset: 0x0000683C
		public EpisodesListHolder(View itemView, Action<int> clickListener, Action<int> viewStatusListener, Action<int> commentsListener) : base(itemView)
		{
			EpisodesListHolder <>4__this = this;
			this.TitleView = itemView.FindViewById<TextView>(2131362349);
			this.EpisodeNumber = itemView.FindViewById<TextView>(2131362342);
			this.EpisodeType = itemView.FindViewById<TextView>(2131362350);
			this.ViewStatus = itemView.FindViewById<ImageView>(2131362348);
			this.Comments = itemView.FindViewById<ImageView>(2131362340);
			this.Content = itemView.FindViewById<RelativeLayout>(2131362341);
			this.Content.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
			this.ViewStatus.Click += delegate(object sender, EventArgs e)
			{
				viewStatusListener(<>4__this.LayoutPosition);
			};
			this.Comments.Click += delegate(object sender, EventArgs e)
			{
				commentsListener(<>4__this.LayoutPosition);
			};
		}
	}
}
