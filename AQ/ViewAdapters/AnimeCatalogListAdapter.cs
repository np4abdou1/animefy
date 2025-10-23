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
	// Token: 0x02000012 RID: 18
	public class AnimeCatalogListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000094 RID: 148 RVA: 0x000057BC File Offset: 0x000039BC
		// (remove) Token: 0x06000095 RID: 149 RVA: 0x000057F4 File Offset: 0x000039F4
		public event EventHandler<int> ItemClick;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000096 RID: 150 RVA: 0x0000582C File Offset: 0x00003A2C
		// (remove) Token: 0x06000097 RID: 151 RVA: 0x00005864 File Offset: 0x00003A64
		public event EventHandler<int> ItemFavouriteClick;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000098 RID: 152 RVA: 0x0000589C File Offset: 0x00003A9C
		// (remove) Token: 0x06000099 RID: 153 RVA: 0x000058D4 File Offset: 0x00003AD4
		public event EventHandler<int> ItemOptionMenuClick;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600009A RID: 154 RVA: 0x0000590C File Offset: 0x00003B0C
		// (remove) Token: 0x0600009B RID: 155 RVA: 0x00005944 File Offset: 0x00003B44
		public event EventHandler<int> ItemPlotClick;

		// Token: 0x0600009C RID: 156 RVA: 0x00005979 File Offset: 0x00003B79
		public AnimeCatalogListAdapter(Context context, List<AnimeModel> items, bool showOptionMenu = false)
		{
			this.items = items;
			this.context = context;
			this.showOptionMenu = showOptionMenu;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000059A0 File Offset: 0x00003BA0
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558473;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new AnimeCatalogListAdapterViewHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnFavouriteClick), new Action<int>(this.OnOptionMenuClick), new Action<int>(this.OnPlotClick));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005A00 File Offset: 0x00003C00
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			AnimeModel animeModel = this.items[position];
			AnimeCatalogListAdapterViewHolder animeCatalogListAdapterViewHolder = viewHolder as AnimeCatalogListAdapterViewHolder;
			if (position > this.lastPosition && AnimeModel.IsAnimationAllowed)
			{
				this.SetFadeAnimation(animeCatalogListAdapterViewHolder.ItemView);
			}
			this.lastPosition = position;
			animeCatalogListAdapterViewHolder.TitleView.Text = animeModel.EN_Title;
			animeCatalogListAdapterViewHolder.RateView.Text = RatingCalculator.CalculateRating(animeModel);
			animeCatalogListAdapterViewHolder.GenresView.Text = LanguageConvertor.GenresToStringList(this.context, animeModel.Genres);
			if (animeModel.Synonyms == "" || animeModel.Synonyms == null)
			{
				animeCatalogListAdapterViewHolder.SubTitleView.Visibility = ViewStates.Gone;
			}
			else
			{
				animeCatalogListAdapterViewHolder.SubTitleView.Visibility = ViewStates.Visible;
				animeCatalogListAdapterViewHolder.SubTitleView.Text = "(" + animeModel.Synonyms + ")";
			}
			if (animeModel.Type == "MOVIE")
			{
				animeCatalogListAdapterViewHolder.ReleaseDateView.Text = LanguageConvertor.PremieredMonth(this.context, animeModel.Premiered);
			}
			else
			{
				animeCatalogListAdapterViewHolder.ReleaseDateView.Text = LanguageConvertor.PremieredYear(animeModel.Premiered);
			}
			if (animeModel.Status == "AIRING")
			{
				animeCatalogListAdapterViewHolder.StatusView.Visibility = ViewStates.Visible;
			}
			else
			{
				animeCatalogListAdapterViewHolder.StatusView.Visibility = ViewStates.Gone;
			}
			if (animeModel.Status == "UPCOMING")
			{
				animeCatalogListAdapterViewHolder.HintView.Visibility = ViewStates.Visible;
			}
			else
			{
				animeCatalogListAdapterViewHolder.HintView.Visibility = ViewStates.Gone;
			}
			if (this.showOptionMenu)
			{
				animeCatalogListAdapterViewHolder.OptionMenuView.Visibility = ViewStates.Visible;
			}
			if (animeModel.Type == "OVA")
			{
				animeCatalogListAdapterViewHolder.TypeContentView.Visibility = ViewStates.Visible;
				animeCatalogListAdapterViewHolder.TypeView.Text = this.context.Resources.GetString(2131952541);
			}
			if (animeModel.Type == "ONA")
			{
				animeCatalogListAdapterViewHolder.TypeContentView.Visibility = ViewStates.Visible;
				animeCatalogListAdapterViewHolder.TypeView.Text = this.context.Resources.GetString(2131952540);
			}
			else if (animeModel.Type == "SPECIAL")
			{
				animeCatalogListAdapterViewHolder.TypeContentView.Visibility = ViewStates.Visible;
				animeCatalogListAdapterViewHolder.TypeView.Text = this.context.Resources.GetString(2131952542);
			}
			else
			{
				animeCatalogListAdapterViewHolder.TypeContentView.Visibility = ViewStates.Gone;
			}
			Glide.With(this.context).Load(Constants.Thumbnails(animeModel.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(animeCatalogListAdapterViewHolder.ThumbnailView);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005C88 File Offset: 0x00003E88
		public void SetFadeAnimation(View view)
		{
			view.StartAnimation(new AlphaAnimation(0f, 1f)
			{
				Duration = 400L
			});
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public void SetData(List<AnimeModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005CD1 File Offset: 0x00003ED1
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005CE8 File Offset: 0x00003EE8
		private void OnPlotClick(int obj)
		{
			if (this.ItemPlotClick != null)
			{
				this.ItemPlotClick(this, obj);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005CFF File Offset: 0x00003EFF
		private void OnFavouriteClick(int obj)
		{
			if (this.ItemFavouriteClick != null)
			{
				this.ItemFavouriteClick(this, obj);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005D16 File Offset: 0x00003F16
		private void OnOptionMenuClick(int obj)
		{
			if (this.ItemOptionMenuClick != null)
			{
				this.ItemOptionMenuClick(this, obj);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005D2D File Offset: 0x00003F2D
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x0400009F RID: 159
		private List<AnimeModel> items;

		// Token: 0x040000A0 RID: 160
		private Context context;

		// Token: 0x040000A1 RID: 161
		private int lastPosition = -1;

		// Token: 0x040000A2 RID: 162
		private bool showOptionMenu;
	}
}
