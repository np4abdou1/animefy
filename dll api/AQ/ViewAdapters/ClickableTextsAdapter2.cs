using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000022 RID: 34
	public class ClickableTextsAdapter2 : RecyclerView.Adapter
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000118 RID: 280 RVA: 0x000070C4 File Offset: 0x000052C4
		// (remove) Token: 0x06000119 RID: 281 RVA: 0x000070FC File Offset: 0x000052FC
		public event EventHandler<int> ItemClick;

		// Token: 0x0600011A RID: 282 RVA: 0x00007131 File Offset: 0x00005331
		public ClickableTextsAdapter2(Context context, List<string> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00007148 File Offset: 0x00005348
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558474;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new ClickableTextsViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007184 File Offset: 0x00005384
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			string text = this.items[position];
			ClickableTextsViewHolder clickableTextsViewHolder = viewHolder as ClickableTextsViewHolder;
			clickableTextsViewHolder.GenreName.Text = text;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000071B1 File Offset: 0x000053B1
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000071C8 File Offset: 0x000053C8
		public override int ItemCount
		{
			get
			{
				return this.items.Count<string>();
			}
		}

		// Token: 0x040000D5 RID: 213
		private List<string> items;

		// Token: 0x040000D6 RID: 214
		private Context context;
	}
}
