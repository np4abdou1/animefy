using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x0200003A RID: 58
	public class MainGenresAdapterV2 : RecyclerView.Adapter
	{
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000240 RID: 576 RVA: 0x0000AC58 File Offset: 0x00008E58
		// (remove) Token: 0x06000241 RID: 577 RVA: 0x0000AC90 File Offset: 0x00008E90
		public event EventHandler<int> ItemClick;

		// Token: 0x06000242 RID: 578 RVA: 0x0000ACC5 File Offset: 0x00008EC5
		public MainGenresAdapterV2(Context context, List<SelectableListModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000ACDC File Offset: 0x00008EDC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558479;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new MainGenresViewHolderV2(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000AD18 File Offset: 0x00008F18
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			SelectableListModel selectableListModel = this.items[position];
			MainGenresViewHolderV2 mainGenresViewHolderV = viewHolder as MainGenresViewHolderV2;
			mainGenresViewHolderV.TitleView.Text = selectableListModel.Title;
			mainGenresViewHolderV.ParentView.ClipToOutline = true;
			if (selectableListModel.Title == this.context.Resources.GetString(2131951652))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231039);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951672))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231040);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951790))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231042);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951884))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231044);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952426))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231069);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952412))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231067);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951923))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231046);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952067))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231051);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952452))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231071);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952001))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231050);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952563))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231073);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952217))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231056);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952467))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231072);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952316))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231058);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952426))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231069);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952212))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231055);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951955))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231047);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951998))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231049);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952346))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231059);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952360))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231062);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952359))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231061);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952400))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231066);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951974))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231048);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952373))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231063);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952399))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231065);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951885))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231045);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952356))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231060);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952072))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231052);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952451))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231070);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952137))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231054);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952300))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231057);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951853))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231043);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952422))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231068);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131951754))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231041);
			}
			else if (selectableListModel.Title == this.context.Resources.GetString(2131952096))
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231053);
			}
			else
			{
				mainGenresViewHolderV.BackgroundView.SetImageResource(2131231039);
			}
			if (selectableListModel.Selected)
			{
				mainGenresViewHolderV.BackgroundSelector.Visibility = ViewStates.Visible;
				return;
			}
			mainGenresViewHolderV.BackgroundSelector.Visibility = ViewStates.Gone;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000B503 File Offset: 0x00009703
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000B51A File Offset: 0x0000971A
		public override int ItemCount
		{
			get
			{
				return this.items.Count<SelectableListModel>();
			}
		}

		// Token: 0x04000160 RID: 352
		private List<SelectableListModel> items;

		// Token: 0x04000161 RID: 353
		private Context context;
	}
}
