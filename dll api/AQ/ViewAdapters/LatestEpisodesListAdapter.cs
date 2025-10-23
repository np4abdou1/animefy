using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Views.Animations;
using AndroidX.RecyclerView.Widget;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x0200002E RID: 46
	public class LatestEpisodesListAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060001CD RID: 461 RVA: 0x000094B4 File Offset: 0x000076B4
		// (remove) Token: 0x060001CE RID: 462 RVA: 0x000094EC File Offset: 0x000076EC
		public event EventHandler<int> ItemClick;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060001CF RID: 463 RVA: 0x00009524 File Offset: 0x00007724
		// (remove) Token: 0x060001D0 RID: 464 RVA: 0x0000955C File Offset: 0x0000775C
		public event EventHandler<int> HomeClick;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060001D1 RID: 465 RVA: 0x00009594 File Offset: 0x00007794
		// (remove) Token: 0x060001D2 RID: 466 RVA: 0x000095CC File Offset: 0x000077CC
		public event EventHandler<int> CommentsClick;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060001D3 RID: 467 RVA: 0x00009604 File Offset: 0x00007804
		// (remove) Token: 0x060001D4 RID: 468 RVA: 0x0000963C File Offset: 0x0000783C
		public event EventHandler<int> NotificationClick;

		// Token: 0x060001D5 RID: 469 RVA: 0x00009671 File Offset: 0x00007871
		public LatestEpisodesListAdapter(Context context, List<AnimeModelWithOtherData> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00009690 File Offset: 0x00007890
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558482;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new LatestEpisodesListViewHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnHomeClick), new Action<int>(this.OnCommentsClick), new Action<int>(this.OnNotificationClick));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000096F0 File Offset: 0x000078F0
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			AnimeModelWithOtherData animeModelWithOtherData = this.items[position];
			LatestEpisodesListViewHolder latestEpisodesListViewHolder = viewHolder as LatestEpisodesListViewHolder;
			if (position > this.lastPosition)
			{
				Animation animation = AnimationUtils.LoadAnimation(this.context, 2130772002);
				if (AnimeModel.IsAnimationAllowed)
				{
					latestEpisodesListViewHolder.ItemView.StartAnimation(animation);
				}
			}
			this.lastPosition = position;
			latestEpisodesListViewHolder.TitleView.Text = animeModelWithOtherData.Anime.EN_Title;
			latestEpisodesListViewHolder.Genre.Text = LanguageConvertor.GenresToStringList(this.context, animeModelWithOtherData.Anime.Genres);
			latestEpisodesListViewHolder.DurationView.Text = Calculators.ConvertMinutesToDuration(this.context, animeModelWithOtherData.Anime.Duration);
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
				latestEpisodesListViewHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952542) + ")";
			}
			else if (animeModelWithOtherData.Episode.Type == "OVA")
			{
				latestEpisodesListViewHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952541) + ")";
			}
			else if (animeModelWithOtherData.Episode.MarkedAs == "FILLER")
			{
				latestEpisodesListViewHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952538) + ")";
			}
			else if (animeModelWithOtherData.Episode.MarkedAs == "LAST_FILLER")
			{
				latestEpisodesListViewHolder.EpisodeView.Text = string.Concat(new string[]
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
				latestEpisodesListViewHolder.EpisodeView.Text = text + " (" + this.context.Resources.GetString(2131952025) + ")";
			}
			else
			{
				latestEpisodesListViewHolder.EpisodeView.Text = text;
			}
			if (animeModelWithOtherData.Anime.Status == "AIRED")
			{
				latestEpisodesListViewHolder.NotificationView.SetImageResource(2131231137);
			}
			else if (NotificationsViewModel.IsNotifExist(animeModelWithOtherData.Anime.AnimeId))
			{
				latestEpisodesListViewHolder.NotificationView.SetImageResource(2131231142);
			}
			else
			{
				latestEpisodesListViewHolder.NotificationView.SetImageResource(2131231140);
			}
			Glide.With(this.context).Load(Constants.Thumbnails(animeModelWithOtherData.Anime.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(latestEpisodesListViewHolder.ThumbnailView);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00009AA4 File Offset: 0x00007CA4
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00009ABB File Offset: 0x00007CBB
		private void OnHomeClick(int obj)
		{
			if (this.HomeClick != null)
			{
				this.HomeClick(this, obj);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00009AD2 File Offset: 0x00007CD2
		private void OnCommentsClick(int obj)
		{
			if (this.CommentsClick != null)
			{
				this.CommentsClick(this, obj);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009AE9 File Offset: 0x00007CE9
		private void OnNotificationClick(int obj)
		{
			if (this.NotificationClick != null)
			{
				this.NotificationClick(this, obj);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00009B00 File Offset: 0x00007D00
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000130 RID: 304
		private List<AnimeModelWithOtherData> items;

		// Token: 0x04000131 RID: 305
		private Context context;

		// Token: 0x04000132 RID: 306
		private int lastPosition = -1;
	}
}
