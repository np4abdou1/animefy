using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000020 RID: 32
	public class ClickableTextsViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00006F23 File Offset: 0x00005123
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00006F2B File Offset: 0x0000512B
		public TextView GenreName { get; set; }

		// Token: 0x06000110 RID: 272 RVA: 0x00006F34 File Offset: 0x00005134
		public ClickableTextsViewHolder(View itemView, Action<int> clickListener) : base(itemView)
		{
			ClickableTextsViewHolder <>4__this = this;
			this.GenreName = itemView.FindViewById<TextView>(2131363147);
			this.GenreName.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
