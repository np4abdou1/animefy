using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using AQ.ViewModels;

namespace AQ.ViewAdapters
{
	// Token: 0x0200002A RID: 42
	public class EpisodesListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000194 RID: 404 RVA: 0x00008720 File Offset: 0x00006920
		// (remove) Token: 0x06000195 RID: 405 RVA: 0x00008758 File Offset: 0x00006958
		public event EventHandler<int> ItemClick;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000196 RID: 406 RVA: 0x00008790 File Offset: 0x00006990
		// (remove) Token: 0x06000197 RID: 407 RVA: 0x000087C8 File Offset: 0x000069C8
		public event EventHandler<int> ViewClick;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000198 RID: 408 RVA: 0x00008800 File Offset: 0x00006A00
		// (remove) Token: 0x06000199 RID: 409 RVA: 0x00008838 File Offset: 0x00006A38
		public event EventHandler<int> CommentsClick;

		// Token: 0x0600019A RID: 410 RVA: 0x0000886D File Offset: 0x00006A6D
		public EpisodesListAdapter(Context context, List<EpisodeModel> items, string type)
		{
			this.items = items;
			this.context = context;
			this.type = type;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000888C File Offset: 0x00006A8C
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558478;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new EpisodesListHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnViewClick), new Action<int>(this.OnCommentsClick));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000088E0 File Offset: 0x00006AE0
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			EpisodeModel episodeModel = this.items[position];
			EpisodesListHolder episodesListHolder = viewHolder as EpisodesListHolder;
			if (this.type == "MOVIE")
			{
				episodesListHolder.TitleView.Text = this.context.Resources.GetString(2131952281);
			}
			else
			{
				episodesListHolder.TitleView.Text = this.context.Resources.GetString(2131951895);
			}
			if (episodeModel.ExtraEpisodes == "")
			{
				episodesListHolder.EpisodeNumber.Text = " " + episodeModel.Episode.ToString() + " ";
			}
			else
			{
				episodesListHolder.EpisodeNumber.Text = string.Concat(new string[]
				{
					" ",
					episodeModel.Episode.ToString(),
					"-",
					episodeModel.ExtraEpisodes,
					" "
				});
			}
			if (episodeModel.Type == "" && episodeModel.MarkedAs == "")
			{
				episodesListHolder.EpisodeType.Visibility = ViewStates.Gone;
			}
			else
			{
				episodesListHolder.EpisodeType.Visibility = ViewStates.Visible;
				if (episodeModel.Type == "SPECIAL")
				{
					episodesListHolder.EpisodeType.SetTextColor(Color.ParseColor("#ff9900"));
					episodesListHolder.EpisodeType.Text = " " + this.context.Resources.GetString(2131952542);
				}
				else if (episodeModel.Type == "OVA")
				{
					episodesListHolder.EpisodeType.SetTextColor(Color.ParseColor("#ff9900"));
					episodesListHolder.EpisodeType.Text = " " + this.context.Resources.GetString(2131952541);
				}
				else if (episodeModel.MarkedAs == "FILLER")
				{
					episodesListHolder.EpisodeType.SetTextColor(Color.ParseColor("#ff4d4d"));
					episodesListHolder.EpisodeType.Text = " " + this.context.Resources.GetString(2131952538);
				}
				else if (episodeModel.MarkedAs == "LAST_FILLER")
				{
					episodesListHolder.EpisodeType.SetTextColor(Color.ParseColor("#1DB954"));
					episodesListHolder.EpisodeType.Text = " " + this.context.Resources.GetString(2131952025) + " • " + this.context.Resources.GetString(2131952538);
				}
				else if (episodeModel.MarkedAs == "LAST")
				{
					episodesListHolder.EpisodeType.SetTextColor(Color.ParseColor("#1DB954"));
					episodesListHolder.EpisodeType.Text = " " + this.context.Resources.GetString(2131952025);
				}
				else
				{
					episodesListHolder.EpisodeType.Visibility = ViewStates.Gone;
				}
			}
			if (WatchHistoryViewModel.IsLocaleHistoryExists(episodeModel.AnimeID, episodeModel.Episode))
			{
				episodesListHolder.ViewStatus.SetImageResource(2131231195);
				return;
			}
			episodesListHolder.ViewStatus.SetImageResource(2131231231);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008C1C File Offset: 0x00006E1C
		public void SetData(List<EpisodeModel> newItems)
		{
			this.items.Clear();
			this.items.AddRange(newItems);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00008C35 File Offset: 0x00006E35
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008C4C File Offset: 0x00006E4C
		private void OnViewClick(int obj)
		{
			if (this.ViewClick != null)
			{
				this.ViewClick(this, obj);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008C63 File Offset: 0x00006E63
		private void OnCommentsClick(int obj)
		{
			if (this.CommentsClick != null)
			{
				this.CommentsClick(this, obj);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00008C7A File Offset: 0x00006E7A
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000115 RID: 277
		private List<EpisodeModel> items;

		// Token: 0x04000116 RID: 278
		private Context context;

		// Token: 0x04000117 RID: 279
		private string type;
	}
}
