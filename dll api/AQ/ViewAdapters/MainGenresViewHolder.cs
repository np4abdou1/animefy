using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000035 RID: 53
	public class MainGenresViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000A764 File Offset: 0x00008964
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000A76C File Offset: 0x0000896C
		public TextView GenreName { get; set; }

		// Token: 0x06000221 RID: 545 RVA: 0x0000A778 File Offset: 0x00008978
		public MainGenresViewHolder(View itemView, Action<int> clickListener) : base(itemView)
		{
			MainGenresViewHolder <>4__this = this;
			this.GenreName = itemView.FindViewById<TextView>(2131363147);
			this.GenreName.Click += delegate(object sender, EventArgs e)
			{
				clickListener(<>4__this.LayoutPosition);
			};
		}
	}
}
