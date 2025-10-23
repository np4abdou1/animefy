using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Views.Animations;
using AndroidX.RecyclerView.Widget;
using AQ.Helpers;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000013 RID: 19
	public class AnimeCatalogGridAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000A6 RID: 166 RVA: 0x00005D3C File Offset: 0x00003F3C
		// (remove) Token: 0x060000A7 RID: 167 RVA: 0x00005D74 File Offset: 0x00003F74
		public event EventHandler<int> ItemClick;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000A8 RID: 168 RVA: 0x00005DAC File Offset: 0x00003FAC
		// (remove) Token: 0x060000A9 RID: 169 RVA: 0x00005DE4 File Offset: 0x00003FE4
		public event EventHandler<int> ItemLongClick;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000AA RID: 170 RVA: 0x00005E1C File Offset: 0x0000401C
		// (remove) Token: 0x060000AB RID: 171 RVA: 0x00005E54 File Offset: 0x00004054
		public event EventHandler<int> ItemFavouriteClick;

		// Token: 0x060000AC RID: 172 RVA: 0x00005E89 File Offset: 0x00004089
		public AnimeCatalogGridAdapter(Context context, List<AnimeModel> items, int itemWidth = 0)
		{
			this.items = items;
			this.context = context;
			this.itemWidth = itemWidth;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005EB0 File Offset: 0x000040B0
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558472;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new AnimeCatalogGridAdapterViewHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnLongClick), new Action<int>(this.OnFavouriteClick));
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005F04 File Offset: 0x00004104
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			AnimeModel animeModel = this.items[position];
			AnimeCatalogGridAdapterViewHolder animeCatalogGridAdapterViewHolder = viewHolder as AnimeCatalogGridAdapterViewHolder;
			if (position > this.lastPosition)
			{
				Animation animation = AnimationUtils.LoadAnimation(this.context, 2130772002);
				if (AnimeModel.IsAnimationAllowed)
				{
					animeCatalogGridAdapterViewHolder.ItemView.StartAnimation(animation);
				}
			}
			this.lastPosition = position;
			animeCatalogGridAdapterViewHolder.TitleView.Text = animeModel.EN_Title;
			animeCatalogGridAdapterViewHolder.RateView.Text = RatingCalculator.CalculateRating(animeModel);
			if (this.itemWidth > 0)
			{
				animeCatalogGridAdapterViewHolder.ParentView.LayoutParameters.Width = this.itemWidth;
			}
			if (animeModel.Status == "AIRING")
			{
				animeCatalogGridAdapterViewHolder.StatusView.Visibility = ViewStates.Visible;
			}
			else
			{
				animeCatalogGridAdapterViewHolder.StatusView.Visibility = ViewStates.Gone;
			}
			if (animeModel.Status == "UPCOMING")
			{
				animeCatalogGridAdapterViewHolder.HintView.Visibility = ViewStates.Visible;
			}
			else
			{
				animeCatalogGridAdapterViewHolder.HintView.Visibility = ViewStates.Gone;
			}
			if (animeModel.Type == "OVA")
			{
				animeCatalogGridAdapterViewHolder.TypeContentView.Visibility = ViewStates.Visible;
				animeCatalogGridAdapterViewHolder.TypeView.Text = this.context.Resources.GetString(2131952541);
			}
			if (animeModel.Type == "ONA")
			{
				animeCatalogGridAdapterViewHolder.TypeContentView.Visibility = ViewStates.Visible;
				animeCatalogGridAdapterViewHolder.TypeView.Text = this.context.Resources.GetString(2131952540);
			}
			else if (animeModel.Type == "SPECIAL")
			{
				animeCatalogGridAdapterViewHolder.TypeContentView.Visibility = ViewStates.Visible;
				animeCatalogGridAdapterViewHolder.TypeView.Text = this.context.Resources.GetString(2131952542);
			}
			else
			{
				animeCatalogGridAdapterViewHolder.TypeContentView.Visibility = ViewStates.Gone;
			}
			Glide.With(this.context).Load(Constants.Thumbnails(animeModel.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(animeCatalogGridAdapterViewHolder.ThumbnailView);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000060F4 File Offset: 0x000042F4
		public void SetFadeAnimation(View view)
		{
			view.StartAnimation(new AlphaAnimation(0f, 1f)
			{
				Duration = 500L
			});
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006124 File Offset: 0x00004324
		public void SetData(List<AnimeModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000613D File Offset: 0x0000433D
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006154 File Offset: 0x00004354
		private void OnLongClick(int obj)
		{
			if (this.ItemLongClick != null)
			{
				this.ItemLongClick(this, obj);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000616B File Offset: 0x0000436B
		private void OnFavouriteClick(int obj)
		{
			if (this.ItemFavouriteClick != null)
			{
				this.ItemFavouriteClick(this, obj);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00006182 File Offset: 0x00004382
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x040000A6 RID: 166
		private List<AnimeModel> items;

		// Token: 0x040000A7 RID: 167
		private Context context;

		// Token: 0x040000A8 RID: 168
		private int lastPosition = -1;

		// Token: 0x040000A9 RID: 169
		private int itemWidth;
	}
}
