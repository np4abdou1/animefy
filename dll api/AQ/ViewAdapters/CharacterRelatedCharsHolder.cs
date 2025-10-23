using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x0200001E RID: 30
	public class CharacterRelatedCharsHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00006CC3 File Offset: 0x00004EC3
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00006CCB File Offset: 0x00004ECB
		public TextView Name { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00006CD4 File Offset: 0x00004ED4
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00006CDC File Offset: 0x00004EDC
		public ImageView PhotoView { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00006CE5 File Offset: 0x00004EE5
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00006CED File Offset: 0x00004EED
		public RelativeLayout ParentClickble { get; set; }

		// Token: 0x06000105 RID: 261 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public CharacterRelatedCharsHolder(View itemView, Action<int> clickListenrer) : base(itemView)
		{
			CharacterRelatedCharsHolder <>4__this = this;
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
