using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x02000036 RID: 54
	public class MainGenresAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000222 RID: 546 RVA: 0x0000A7C8 File Offset: 0x000089C8
		// (remove) Token: 0x06000223 RID: 547 RVA: 0x0000A800 File Offset: 0x00008A00
		public event EventHandler<int> ItemClick;

		// Token: 0x06000224 RID: 548 RVA: 0x0000A835 File Offset: 0x00008A35
		public MainGenresAdapter(Context context, List<SelectableListModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000A84C File Offset: 0x00008A4C
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558475;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new MainGenresViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000A888 File Offset: 0x00008A88
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			SelectableListModel selectableListModel = this.items[position];
			MainGenresViewHolder mainGenresViewHolder = viewHolder as MainGenresViewHolder;
			mainGenresViewHolder.GenreName.Text = selectableListModel.Title;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000A8BA File Offset: 0x00008ABA
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000A8D1 File Offset: 0x00008AD1
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000152 RID: 338
		private List<SelectableListModel> items;

		// Token: 0x04000153 RID: 339
		private Context context;

		// Token: 0x04000154 RID: 340
		private bool isFirstLoaded;
	}
}
