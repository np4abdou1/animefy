using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x0200001B RID: 27
	public class CharactersVoiceActorsListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000EA RID: 234 RVA: 0x00006948 File Offset: 0x00004B48
		// (remove) Token: 0x060000EB RID: 235 RVA: 0x00006980 File Offset: 0x00004B80
		public event EventHandler<int> ItemPhotoClick;

		// Token: 0x060000EC RID: 236 RVA: 0x000069B5 File Offset: 0x00004BB5
		public CharactersVoiceActorsListAdapter(Context context, List<CharacterVoiceActors> items)
		{
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000069CC File Offset: 0x00004BCC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558622;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new CharactersVoiceActorsListHolder(itemView, new Action<int>(this.OnPhotoClick));
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006A08 File Offset: 0x00004C08
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CharacterVoiceActors characterVoiceActors = this.items[position];
			CharactersVoiceActorsListHolder charactersVoiceActorsListHolder = viewHolder as CharactersVoiceActorsListHolder;
			charactersVoiceActorsListHolder.NameView.Text = characterVoiceActors.Name;
			charactersVoiceActorsListHolder.ArNameView.Text = characterVoiceActors.NameAR;
			charactersVoiceActorsListHolder.Language.Text = " " + characterVoiceActors.Language;
			Glide.With(this.mContext).Load(Constants.PeoplePhoto(characterVoiceActors.Photo)).CenterCrop().Placeholder(2131231224).Into(charactersVoiceActorsListHolder.PhotoView);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006A9C File Offset: 0x00004C9C
		private void OnPhotoClick(int obj)
		{
			if (this.ItemPhotoClick != null)
			{
				this.ItemPhotoClick(this, obj);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006AB3 File Offset: 0x00004CB3
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000C1 RID: 193
		private List<CharacterVoiceActors> items;

		// Token: 0x040000C2 RID: 194
		private Context mContext;
	}
}
