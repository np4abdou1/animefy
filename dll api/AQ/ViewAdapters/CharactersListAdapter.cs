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
	// Token: 0x02000015 RID: 21
	public class CharactersListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000BC RID: 188 RVA: 0x00006238 File Offset: 0x00004438
		// (remove) Token: 0x060000BD RID: 189 RVA: 0x00006270 File Offset: 0x00004470
		public event EventHandler<int> ItemClick;

		// Token: 0x060000BE RID: 190 RVA: 0x000062A5 File Offset: 0x000044A5
		public CharactersListAdapter(Context context, List<CharacterModel> items)
		{
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000062BC File Offset: 0x000044BC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558621;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CharactersListHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000062F8 File Offset: 0x000044F8
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CharacterModel characterModel = this.items[position];
			CharactersListHolder charactersListHolder = viewHolder as CharactersListHolder;
			if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "ar")
			{
				charactersListHolder.Name.Text = characterModel.NameAR;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "jp")
			{
				charactersListHolder.Name.Text = characterModel.NameJP;
			}
			else
			{
				charactersListHolder.Name.Text = characterModel.NameEN;
			}
			Glide.With(this.mContext).Load(Constants.CharPhoto(characterModel.Photo)).CenterCrop().Placeholder(2131231224).Into(charactersListHolder.PhotoView);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000063B2 File Offset: 0x000045B2
		public void SetData(List<CharacterModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000063CB File Offset: 0x000045CB
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000063E2 File Offset: 0x000045E2
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000AE RID: 174
		private List<CharacterModel> items;

		// Token: 0x040000AF RID: 175
		private Context mContext;
	}
}
