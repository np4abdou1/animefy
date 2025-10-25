using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x02000037 RID: 55
	public class HomeGenresAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000229 RID: 553 RVA: 0x0000A8E0 File Offset: 0x00008AE0
		// (remove) Token: 0x0600022A RID: 554 RVA: 0x0000A918 File Offset: 0x00008B18
		public event EventHandler<int> ItemClick;

		// Token: 0x0600022B RID: 555 RVA: 0x0000A94D File Offset: 0x00008B4D
		public HomeGenresAdapter(Context context, List<SelectableListModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000A964 File Offset: 0x00008B64
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558475;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new MainGenresViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			SelectableListModel selectableListModel = this.items[position];
			MainGenresViewHolder mainGenresViewHolder = viewHolder as MainGenresViewHolder;
			mainGenresViewHolder.GenreName.Text = selectableListModel.Title;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000A9D2 File Offset: 0x00008BD2
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000A9E9 File Offset: 0x00008BE9
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000156 RID: 342
		private List<SelectableListModel> items;

		// Token: 0x04000157 RID: 343
		private Context context;
	}
}
