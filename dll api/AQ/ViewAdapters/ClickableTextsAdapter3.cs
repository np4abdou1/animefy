using System;
using System.Linq;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace AQ.ViewAdapters
{
	// Token: 0x02000023 RID: 35
	public class ClickableTextsAdapter3 : RecyclerView.Adapter
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600011F RID: 287 RVA: 0x000071D8 File Offset: 0x000053D8
		// (remove) Token: 0x06000120 RID: 288 RVA: 0x00007210 File Offset: 0x00005410
		public event EventHandler<int> ItemClick;

		// Token: 0x06000121 RID: 289 RVA: 0x00007245 File Offset: 0x00005445
		public ClickableTextsAdapter3(Context context, string[] items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000725C File Offset: 0x0000545C
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558474;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new ClickableTextsViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007298 File Offset: 0x00005498
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			string text = this.items[position];
			ClickableTextsViewHolder clickableTextsViewHolder = viewHolder as ClickableTextsViewHolder;
			clickableTextsViewHolder.GenreName.Text = text;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000072C1 File Offset: 0x000054C1
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000072D8 File Offset: 0x000054D8
		public override int ItemCount
		{
			get
			{
				return this.items.Count<string>();
			}
		}

		// Token: 0x040000D8 RID: 216
		private string[] items;

		// Token: 0x040000D9 RID: 217
		private Context context;
	}
}
