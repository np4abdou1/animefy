using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000014 RID: 20
	public class CharactersListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000618F File Offset: 0x0000438F
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00006197 File Offset: 0x00004397
		public TextView Name { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000061A0 File Offset: 0x000043A0
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000061A8 File Offset: 0x000043A8
		public ImageView PhotoView { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000061B1 File Offset: 0x000043B1
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000061B9 File Offset: 0x000043B9
		public RelativeLayout ParentClickble { get; set; }

		// Token: 0x060000BB RID: 187 RVA: 0x000061C4 File Offset: 0x000043C4
		public CharactersListHolder(View itemView, Action<int> clickListenrer) : base(itemView)
		{
			CharactersListHolder <>4__this = this;
			this.Name = itemView.FindViewById<TextView>(2131362125);
			this.PhotoView = itemView.FindViewById<ImageView>(2131362127);
			this.ParentClickble = itemView.FindViewById<RelativeLayout>(2131362126);
			this.ParentClickble.Click += delegate(object sender, EventArgs e)
			{
				clickListenrer(<>4__this.LayoutPosition);
			};
		}
	}
}
