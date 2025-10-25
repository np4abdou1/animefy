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
	// Token: 0x0200001F RID: 31
	public class CharacterRelatedCharsAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000106 RID: 262 RVA: 0x00006D6C File Offset: 0x00004F6C
		// (remove) Token: 0x06000107 RID: 263 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public event EventHandler<int> ItemClick;

		// Token: 0x06000108 RID: 264 RVA: 0x00006DD9 File Offset: 0x00004FD9
		public CharacterRelatedCharsAdapter(Context context, List<CharacterModel> items)
		{
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006DF0 File Offset: 0x00004FF0
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558632;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CharacterRelatedCharsHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006E2C File Offset: 0x0000502C
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CharacterModel characterModel = this.items[position];
			CharacterRelatedCharsHolder characterRelatedCharsHolder = viewHolder as CharacterRelatedCharsHolder;
			if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "ar")
			{
				characterRelatedCharsHolder.Name.Text = characterModel.NameAR;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "jp")
			{
				characterRelatedCharsHolder.Name.Text = characterModel.NameJP;
			}
			else
			{
				characterRelatedCharsHolder.Name.Text = characterModel.NameEN;
			}
			Glide.With(this.mContext).Load(Constants.CharPhoto(characterModel.Photo)).CenterCrop().Placeholder(2131231224).Into(characterRelatedCharsHolder.PhotoView);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006EE6 File Offset: 0x000050E6
		public void SetData(List<CharacterModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006EFF File Offset: 0x000050FF
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006F16 File Offset: 0x00005116
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000CE RID: 206
		private List<CharacterModel> items;

		// Token: 0x040000CF RID: 207
		private Context mContext;
	}
}
