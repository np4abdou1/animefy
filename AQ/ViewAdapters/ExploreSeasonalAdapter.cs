using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Helpers;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x02000038 RID: 56
	public class ExploreSeasonalAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000230 RID: 560 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (remove) Token: 0x06000231 RID: 561 RVA: 0x0000AA30 File Offset: 0x00008C30
		public event EventHandler<int> ItemClick;

		// Token: 0x06000232 RID: 562 RVA: 0x0000AA65 File Offset: 0x00008C65
		public ExploreSeasonalAdapter(Context context, List<SelectableListModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000AA7C File Offset: 0x00008C7C
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558474;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new MainGenresViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			SelectableListModel selectableListModel = this.items[position];
			MainGenresViewHolder mainGenresViewHolder = viewHolder as MainGenresViewHolder;
			mainGenresViewHolder.GenreName.Text = selectableListModel.Title;
			if (selectableListModel.Selected)
			{
				if (SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") != "Dark")
				{
					mainGenresViewHolder.GenreName.SetTextColor(Color.ParseColor("#e6e6e6"));
				}
				mainGenresViewHolder.GenreName.SetBackgroundResource(2131230943);
				return;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") != "Dark")
			{
				mainGenresViewHolder.GenreName.SetTextColor(Color.ParseColor("#666666"));
			}
			mainGenresViewHolder.GenreName.SetBackgroundResource(2131230944);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000AB69 File Offset: 0x00008D69
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000AB80 File Offset: 0x00008D80
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000159 RID: 345
		private List<SelectableListModel> items;

		// Token: 0x0400015A RID: 346
		private Context context;
	}
}
