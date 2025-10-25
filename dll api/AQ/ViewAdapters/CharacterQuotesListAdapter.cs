using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x0200001D RID: 29
	public class CharacterQuotesListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000F8 RID: 248 RVA: 0x00006B68 File Offset: 0x00004D68
		// (remove) Token: 0x060000F9 RID: 249 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public event EventHandler<int> ItemCopyClick;

		// Token: 0x060000FA RID: 250 RVA: 0x00006BD5 File Offset: 0x00004DD5
		public CharacterQuotesListAdapter(Context context, List<CharacterQuotes> items)
		{
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006BF4 File Offset: 0x00004DF4
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558620;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CharacterQuotesHolder(itemView, new Action<int>(this.OnCopyClick));
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006C30 File Offset: 0x00004E30
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CharacterQuotes characterQuotes = this.items[position];
			CharacterQuotesHolder characterQuotesHolder = viewHolder as CharacterQuotesHolder;
			characterQuotesHolder.QuoteNo.Text = "#" + this.itemNo.ToString();
			characterQuotesHolder.QuoteBody.Text = "\"" + characterQuotes.Quote + "\".";
			this.itemNo++;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006C9F File Offset: 0x00004E9F
		private void OnCopyClick(int obj)
		{
			if (this.ItemCopyClick != null)
			{
				this.ItemCopyClick(this, obj);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00006CB6 File Offset: 0x00004EB6
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000C7 RID: 199
		private List<CharacterQuotes> items;

		// Token: 0x040000C8 RID: 200
		private Context mContext;

		// Token: 0x040000C9 RID: 201
		private int itemNo = 1;
	}
}
