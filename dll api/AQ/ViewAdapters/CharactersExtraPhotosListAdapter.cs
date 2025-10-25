using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000019 RID: 25
	public class CharactersExtraPhotosListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000DA RID: 218 RVA: 0x00006738 File Offset: 0x00004938
		// (remove) Token: 0x060000DB RID: 219 RVA: 0x00006770 File Offset: 0x00004970
		public event EventHandler<int> ItemPhotoClick;

		// Token: 0x060000DC RID: 220 RVA: 0x000067A5 File Offset: 0x000049A5
		public CharactersExtraPhotosListAdapter(Context context, List<string> items)
		{
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000067BC File Offset: 0x000049BC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558623;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CharactersExtraPhotosListHolder(itemView, new Action<int>(this.OnPhotoClick));
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000067F8 File Offset: 0x000049F8
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			string str = this.items[position];
			CharactersExtraPhotosListHolder charactersExtraPhotosListHolder = viewHolder as CharactersExtraPhotosListHolder;
			Glide.With(this.mContext).Load(Constants.CharPhoto("extras/" + str + ".jpg")).CenterCrop().Placeholder(2131231224).Into(charactersExtraPhotosListHolder.PhotoView);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006859 File Offset: 0x00004A59
		private void OnPhotoClick(int obj)
		{
			if (this.ItemPhotoClick != null)
			{
				this.ItemPhotoClick(this, obj);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00006870 File Offset: 0x00004A70
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000BA RID: 186
		private List<string> items;

		// Token: 0x040000BB RID: 187
		private Context mContext;
	}
}
