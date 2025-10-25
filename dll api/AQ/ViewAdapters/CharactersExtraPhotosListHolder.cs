using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000018 RID: 24
	public class CharactersExtraPhotosListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000066AF File Offset: 0x000048AF
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000066B7 File Offset: 0x000048B7
		public ImageView PhotoView { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000066C8 File Offset: 0x000048C8
		public RelativeLayout PhotoViewParent { get; set; }

		// Token: 0x060000D9 RID: 217 RVA: 0x000066D4 File Offset: 0x000048D4
		public CharactersExtraPhotosListHolder(View itemView, Action<int> photoClickListenrer) : base(itemView)
		{
			CharactersExtraPhotosListHolder <>4__this = this;
			this.PhotoView = itemView.FindViewById<ImageView>(2131362372);
			this.PhotoViewParent = itemView.FindViewById<RelativeLayout>(2131362373);
			this.PhotoViewParent.Click += delegate(object sender, EventArgs e)
			{
				photoClickListenrer(<>4__this.LayoutPosition);
			};
		}
	}
}
