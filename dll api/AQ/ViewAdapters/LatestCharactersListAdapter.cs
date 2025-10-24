using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Helpers;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000017 RID: 23
	public class LatestCharactersListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000CD RID: 205 RVA: 0x000064B8 File Offset: 0x000046B8
		// (remove) Token: 0x060000CE RID: 206 RVA: 0x000064F0 File Offset: 0x000046F0
		public event EventHandler<int> ItemClick;

		// Token: 0x060000CF RID: 207 RVA: 0x00006525 File Offset: 0x00004725
		public LatestCharactersListAdapter(Context context, List<CharacterModel> items)
		{
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000653C File Offset: 0x0000473C
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558628;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new LatestCharactersListHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006578 File Offset: 0x00004778
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CharacterModel characterModel = this.items[position];
			LatestCharactersListHolder latestCharactersListHolder = viewHolder as LatestCharactersListHolder;
			if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "ar")
			{
				latestCharactersListHolder.Name.Text = characterModel.NameAR;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "jp")
			{
				latestCharactersListHolder.Name.Text = characterModel.NameJP;
			}
			else
			{
				latestCharactersListHolder.Name.Text = characterModel.NameEN;
			}
			Glide.With(this.mContext).Load(Constants.CharPhoto(characterModel.Photo)).CenterCrop().Placeholder(2131231224).Into(latestCharactersListHolder.PhotoView);
			Glide.With(this.mContext).Load(Constants.CharPhoto("covers/" + characterModel.Cover)).CenterCrop().Placeholder(2131231224).Into(latestCharactersListHolder.CoverView);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006672 File Offset: 0x00004872
		public void SetData(List<CharacterModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000668B File Offset: 0x0000488B
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000066A2 File Offset: 0x000048A2
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000B5 RID: 181
		private List<CharacterModel> items;

		// Token: 0x040000B6 RID: 182
		private Context mContext;
	}
}
