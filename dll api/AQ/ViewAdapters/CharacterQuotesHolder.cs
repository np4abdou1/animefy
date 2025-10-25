using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x0200001C RID: 28
	public class CharacterQuotesHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00006AC0 File Offset: 0x00004CC0
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00006AC8 File Offset: 0x00004CC8
		public TextView QuoteNo { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00006AD1 File Offset: 0x00004CD1
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00006AD9 File Offset: 0x00004CD9
		public TextView QuoteBody { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00006AE2 File Offset: 0x00004CE2
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00006AEA File Offset: 0x00004CEA
		public LinearLayout QuoteCopy { get; set; }

		// Token: 0x060000F7 RID: 247 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public CharacterQuotesHolder(View itemView, Action<int> copyClickListenrer) : base(itemView)
		{
			CharacterQuotesHolder <>4__this = this;
			this.QuoteNo = itemView.FindViewById<TextView>(2131362872);
			this.QuoteBody = itemView.FindViewById<TextView>(2131362870);
			this.QuoteCopy = itemView.FindViewById<LinearLayout>(2131362871);
			this.QuoteCopy.Click += delegate(object sender, EventArgs e)
			{
				copyClickListenrer(<>4__this.LayoutPosition);
			};
		}
	}
}
