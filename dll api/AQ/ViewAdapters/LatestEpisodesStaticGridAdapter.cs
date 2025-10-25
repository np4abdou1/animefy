using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x0200002D RID: 45
	public class LatestEpisodesStaticGridAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060001C0 RID: 448 RVA: 0x00008F80 File Offset: 0x00007180
		// (remove) Token: 0x060001C1 RID: 449 RVA: 0x00008FB8 File Offset: 0x000071B8
		public event EventHandler<int> ItemClick;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060001C2 RID: 450 RVA: 0x00008FF0 File Offset: 0x000071F0
		// (remove) Token: 0x060001C3 RID: 451 RVA: 0x00009028 File Offset: 0x00007228
		public event EventHandler<int> ItemLongClick;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060001C4 RID: 452 RVA: 0x00009060 File Offset: 0x00007260
		// (remove) Token: 0x060001C5 RID: 453 RVA: 0x00009098 File Offset: 0x00007298
		public event EventHandler<int> ItemTitleClick;

		// Token: 0x060001C6 RID: 454 RVA: 0x000090CD File Offset: 0x000072CD
		public LatestEpisodesStaticGridAdapter(Context context, List<AnimeModelWithOtherData> items, int itemWidth = 0)
		{
			this.items = items;
			this.context = context;
			this.itemWidth = itemWidth;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000090EC File Offset: 0x000072EC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558481;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new LatestEpisodesGridViewHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnLongClick), new Action<int>(this.OnTitleClick));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009140 File Offset: 0x00007340
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			AnimeModelWithOtherData animeModelWithOtherData = this.items[position];
			LatestEpisodesGridViewHolder latestEpisodesGridViewHolder = viewHolder as LatestEpisodesGridViewHolder;
			if (animeModelWithOtherData.Anime != null)
			{
				latestEpisodesGridViewHolder.TitleView.Text = animeModelWithOtherData.Anime.EN_Title;
			}
			else
			{
				latestEpisodesGridViewHolder.TitleView.Text = "";
			}
			if (this.itemWidth > 0)
			{
				latestEpisodesGridViewHolder.ParentView.LayoutParameters.Width = this.itemWidth;
			}
			string text = animeModelWithOtherData.Episode.Episode.ToString();
			if (animeModelWithOtherData.Episode.ExtraEpisodes == "")
			{
				text = this.context.Resources.GetString(2131951895) + " " + animeModelWithOtherData.Episode.Episode.ToString();
			}
			else
			{
				text = string.Concat(new string[]
				{
					this.context.Resources.GetString(2131951895),
					" ",
					animeModelWithOtherData.Episode.Episode.ToString(),
					"-",
					animeModelWithOtherData.Episode.ExtraEpisodes
				});
			}
			if (animeModelWithOtherData.Episode.Type == "OVA")
			{
				latestEpisodesGridViewHolder.EpisodeNoView.Text = text + " (" + this.context.Resources.GetString(2131952541) + ")";
			}
			else if (animeModelWithOtherData.Episode.Type == "SPECIAL")
			{
				latestEpisodesGridViewHolder.EpisodeNoView.Text = text + " (" + this.context.Resources.GetString(2131952542) + ")";
			}
			else if (animeModelWithOtherData.Episode.Type == "ONA")
			{
				latestEpisodesGridViewHolder.EpisodeNoView.Text = text + " (" + this.context.Resources.GetString(2131952540) + ")";
			}
			else if (animeModelWithOtherData.Episode.MarkedAs == "FILLER")
			{
				latestEpisodesGridViewHolder.EpisodeNoView.Text = text + " (" + this.context.Resources.GetString(2131952538) + ")";
			}
			else if (animeModelWithOtherData.Episode.MarkedAs == "LAST_FILLER")
			{
				latestEpisodesGridViewHolder.EpisodeNoView.Text = string.Concat(new string[]
				{
					text,
					" (",
					this.context.Resources.GetString(2131952025),
					" - ",
					this.context.Resources.GetString(2131952538),
					")"
				});
			}
			else
			{
				latestEpisodesGridViewHolder.EpisodeNoView.Text = text;
			}
			if (animeModelWithOtherData.Anime != null)
			{
				Glide.With(this.context).Load(Constants.Thumbnails(animeModelWithOtherData.Anime.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(latestEpisodesGridViewHolder.ThumbnailView);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009462 File Offset: 0x00007662
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009479 File Offset: 0x00007679
		private void OnLongClick(int obj)
		{
			if (this.ItemLongClick != null)
			{
				this.ItemLongClick(this, obj);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009490 File Offset: 0x00007690
		private void OnTitleClick(int obj)
		{
			if (this.ItemTitleClick != null)
			{
				this.ItemTitleClick(this, obj);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000094A7 File Offset: 0x000076A7
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000129 RID: 297
		private List<AnimeModelWithOtherData> items;

		// Token: 0x0400012A RID: 298
		private Context context;

		// Token: 0x0400012B RID: 299
		private int itemWidth;
	}
}
