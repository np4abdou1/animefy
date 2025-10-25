using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000046 RID: 70
	public class WatchHistoryListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060002C4 RID: 708 RVA: 0x0000D66C File Offset: 0x0000B86C
		// (remove) Token: 0x060002C5 RID: 709 RVA: 0x0000D6A4 File Offset: 0x0000B8A4
		public event EventHandler<int> ItemClick;

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060002C6 RID: 710 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		// (remove) Token: 0x060002C7 RID: 711 RVA: 0x0000D714 File Offset: 0x0000B914
		public event EventHandler<int> ItemDelete;

		// Token: 0x060002C8 RID: 712 RVA: 0x0000D749 File Offset: 0x0000B949
		public WatchHistoryListAdapter(Context context, List<AnimeModelWithOtherData> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000D760 File Offset: 0x0000B960
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558627;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new WatchHistoryHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnDelete));
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			AnimeModelWithOtherData animeModelWithOtherData = this.items[position];
			WatchHistoryHolder watchHistoryHolder = viewHolder as WatchHistoryHolder;
			watchHistoryHolder.Title.Text = animeModelWithOtherData.Anime.EN_Title;
			if (animeModelWithOtherData.Episode != null)
			{
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
				if (animeModelWithOtherData.Episode.Type == "SPECIAL")
				{
					watchHistoryHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952542) + ")";
				}
				else if (animeModelWithOtherData.Episode.Type == "OVA")
				{
					watchHistoryHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952541) + ")";
				}
				else if (animeModelWithOtherData.Episode.MarkedAs == "FILLER")
				{
					watchHistoryHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952538) + ")";
				}
				else if (animeModelWithOtherData.Episode.MarkedAs == "LAST_FILLER")
				{
					watchHistoryHolder.EpisodeView.Text = string.Concat(new string[]
					{
						text,
						" (",
						this.context.Resources.GetString(2131952025),
						" • ",
						this.context.Resources.GetString(2131952538),
						")"
					});
				}
				else if (animeModelWithOtherData.Episode.MarkedAs == "LAST")
				{
					watchHistoryHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952025) + ")";
				}
				else
				{
					watchHistoryHolder.EpisodeView.Text = text;
				}
			}
			else
			{
				watchHistoryHolder.EpisodeView.Text = " " + this.context.Resources.GetString(2131952539);
			}
			Glide.With(this.context).Load(Constants.Thumbnails(animeModelWithOtherData.Anime.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(watchHistoryHolder.ThumbnailView);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000DAD7 File Offset: 0x0000BCD7
		private void OnDelete(int obj)
		{
			if (this.ItemDelete != null)
			{
				this.ItemDelete(this, obj);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000DAEE File Offset: 0x0000BCEE
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000198 RID: 408
		private List<AnimeModelWithOtherData> items;

		// Token: 0x04000199 RID: 409
		private Context context;
	}
}
