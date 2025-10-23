using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x02000021 RID: 33
	public class ClickableTextsAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000111 RID: 273 RVA: 0x00006F84 File Offset: 0x00005184
		// (remove) Token: 0x06000112 RID: 274 RVA: 0x00006FBC File Offset: 0x000051BC
		public event EventHandler<int> ItemClick;

		// Token: 0x06000113 RID: 275 RVA: 0x00006FF1 File Offset: 0x000051F1
		public ClickableTextsAdapter(Context context, List<SelectableListModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007008 File Offset: 0x00005208
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558474;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new ClickableTextsViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00007044 File Offset: 0x00005244
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			SelectableListModel selectableListModel = this.items[position];
			ClickableTextsViewHolder clickableTextsViewHolder = viewHolder as ClickableTextsViewHolder;
			clickableTextsViewHolder.GenreName.Text = selectableListModel.Title;
			if (selectableListModel.Selected)
			{
				clickableTextsViewHolder.GenreName.SetBackgroundResource(2131230943);
				return;
			}
			clickableTextsViewHolder.GenreName.SetBackgroundResource(2131230944);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000709F File Offset: 0x0000529F
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000070B6 File Offset: 0x000052B6
		public override int ItemCount
		{
			get
			{
				return this.items.Count<SelectableListModel>();
			}
		}

		// Token: 0x040000D2 RID: 210
		private List<SelectableListModel> items;

		// Token: 0x040000D3 RID: 211
		private Context context;
	}
}
