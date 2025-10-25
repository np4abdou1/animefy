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
	// Token: 0x02000030 RID: 48
	public class FavouriteCharsListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00009CBC File Offset: 0x00007EBC
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public event EventHandler<int> ItemClick;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060001F0 RID: 496 RVA: 0x00009D2C File Offset: 0x00007F2C
		// (remove) Token: 0x060001F1 RID: 497 RVA: 0x00009D64 File Offset: 0x00007F64
		public event EventHandler<int> ItemLoveClick;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060001F2 RID: 498 RVA: 0x00009D9C File Offset: 0x00007F9C
		// (remove) Token: 0x060001F3 RID: 499 RVA: 0x00009DD4 File Offset: 0x00007FD4
		public event EventHandler<int> ItemUnloveClick;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060001F4 RID: 500 RVA: 0x00009E0C File Offset: 0x0000800C
		// (remove) Token: 0x060001F5 RID: 501 RVA: 0x00009E44 File Offset: 0x00008044
		public event EventHandler<int> ItemCommentsClick;

		// Token: 0x060001F6 RID: 502 RVA: 0x00009E79 File Offset: 0x00008079
		public FavouriteCharsListAdapter(Context context, List<CharacterModel> items, bool loved)
		{
			this.loved = loved;
			this.items = items;
			this.mContext = context;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00009E98 File Offset: 0x00008098
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558624;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new FavouriteCharsListHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnLoveClick), new Action<int>(this.OnUnLoveClick), new Action<int>(this.OnCommentsClick));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00009EF8 File Offset: 0x000080F8
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			CharacterModel characterModel = this.items[position];
			FavouriteCharsListHolder favouriteCharsListHolder = viewHolder as FavouriteCharsListHolder;
			if (this.loved)
			{
				favouriteCharsListHolder.LoveButton.Visibility = ViewStates.Gone;
			}
			else
			{
				favouriteCharsListHolder.UnloveButton.Visibility = ViewStates.Gone;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "ar")
			{
				favouriteCharsListHolder.Name.Text = characterModel.NameAR;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "jp")
			{
				favouriteCharsListHolder.Name.Text = characterModel.NameJP;
			}
			else
			{
				favouriteCharsListHolder.Name.Text = characterModel.NameEN;
			}
			favouriteCharsListHolder.ReactionsCount.Text = string.Format("{0:N0}", characterModel.LikersCount + characterModel.DislikersCount);
			Glide.With(this.mContext).Load(Constants.CharPhoto(characterModel.Photo)).CenterCrop().Placeholder(2131231224).Into(favouriteCharsListHolder.Photo);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00009FFB File Offset: 0x000081FB
		public void SetData(List<CharacterModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000A014 File Offset: 0x00008214
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000A02B File Offset: 0x0000822B
		private void OnLoveClick(int obj)
		{
			if (this.ItemLoveClick != null)
			{
				this.ItemLoveClick(this, obj);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000A042 File Offset: 0x00008242
		private void OnUnLoveClick(int obj)
		{
			if (this.ItemUnloveClick != null)
			{
				this.ItemUnloveClick(this, obj);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A059 File Offset: 0x00008259
		private void OnCommentsClick(int obj)
		{
			if (this.ItemCommentsClick != null)
			{
				this.ItemCommentsClick(this, obj);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000A070 File Offset: 0x00008270
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x0400013F RID: 319
		private bool loved;

		// Token: 0x04000140 RID: 320
		private List<CharacterModel> items;

		// Token: 0x04000141 RID: 321
		private Context mContext;
	}
}
