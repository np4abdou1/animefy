using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x0200001A RID: 26
	public class CharactersVoiceActorsListHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000687D File Offset: 0x00004A7D
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00006885 File Offset: 0x00004A85
		public TextView NameView { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000688E File Offset: 0x00004A8E
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00006896 File Offset: 0x00004A96
		public TextView ArNameView { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000689F File Offset: 0x00004A9F
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000068A7 File Offset: 0x00004AA7
		public TextView Language { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000068B0 File Offset: 0x00004AB0
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000068B8 File Offset: 0x00004AB8
		public ImageView PhotoView { get; set; }

		// Token: 0x060000E9 RID: 233 RVA: 0x000068C4 File Offset: 0x00004AC4
		public CharactersVoiceActorsListHolder(View itemView, Action<int> photoClickListenrer) : base(itemView)
		{
			CharactersVoiceActorsListHolder <>4__this = this;
			this.NameView = itemView.FindViewById<TextView>(2131362155);
			this.ArNameView = itemView.FindViewById<TextView>(2131362152);
			this.Language = itemView.FindViewById<TextView>(2131362154);
			this.PhotoView = itemView.FindViewById<ImageView>(2131362157);
			this.PhotoView.Click += delegate(object sender, EventArgs e)
			{
				photoClickListenrer(<>4__this.LayoutPosition);
			};
		}
	}
}
