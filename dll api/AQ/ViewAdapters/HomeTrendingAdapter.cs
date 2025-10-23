using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AndroidX.ViewPager2.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x0200003B RID: 59
	public class HomeTrendingAdapter : RecyclerView.Adapter
	{
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000247 RID: 583 RVA: 0x0000B528 File Offset: 0x00009728
		// (remove) Token: 0x06000248 RID: 584 RVA: 0x0000B560 File Offset: 0x00009760
		public event EventHandler<int> ItemClick;

		// Token: 0x06000249 RID: 585 RVA: 0x0000B595 File Offset: 0x00009795
		public HomeTrendingAdapter(Context context, ViewPager2 viewPager2, List<HomeTrendingModel> items)
		{
			this.items = items;
			this.viewPager2 = viewPager2;
			this.context = context;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000B5B4 File Offset: 0x000097B4
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558480;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new HomeTrendingAdapterViewHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000B5F0 File Offset: 0x000097F0
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			HomeTrendingModel homeTrendingModel = this.items[position];
			HomeTrendingAdapterViewHolder homeTrendingAdapterViewHolder = viewHolder as HomeTrendingAdapterViewHolder;
			if (homeTrendingModel.TextTheme == "DARK_GRAY" || homeTrendingModel.TextTheme == "LIGHT_GRAY")
			{
				homeTrendingAdapterViewHolder.SliderTitle.SetTextColor(Color.ParseColor("#B3B3B3"));
				homeTrendingAdapterViewHolder.SliderHint.SetTextColor(Color.ParseColor("#999999"));
			}
			else
			{
				homeTrendingAdapterViewHolder.SliderTitle.SetTextColor(Color.ParseColor("#F2F2F2"));
				homeTrendingAdapterViewHolder.SliderHint.SetTextColor(Color.ParseColor("#E6E6E6"));
			}
			if (homeTrendingModel.Title == "")
			{
				string type = homeTrendingModel.Type;
				if (!(type == "ANIME"))
				{
					if (!(type == "EPISODE"))
					{
						if (!(type == "NEWS"))
						{
							if (!(type == "CHARACTER"))
							{
								homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.Title;
							}
							else if (this.context.Resources.GetString(2131952024) == "AR")
							{
								homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.Character.NameAR;
							}
							else
							{
								homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.Character.NameEN;
							}
						}
						else
						{
							homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.News.Title;
						}
					}
					else
					{
						homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.Anime.EN_Title;
					}
				}
				else
				{
					homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.Anime.EN_Title;
				}
			}
			else
			{
				homeTrendingAdapterViewHolder.SliderTitle.Text = homeTrendingModel.Title;
			}
			if (homeTrendingModel.Hint == "")
			{
				string type2 = homeTrendingModel.Type;
				if (type2 == "EPISODE")
				{
					if (homeTrendingModel.Episode.Type == "OVA")
					{
						homeTrendingAdapterViewHolder.SliderHint.Text = string.Concat(new string[]
						{
							this.context.Resources.GetString(2131951895),
							" ",
							homeTrendingModel.Episodes,
							" (",
							this.context.Resources.GetString(2131952541),
							")"
						});
					}
					else if (homeTrendingModel.Episode.Type == "SPECIAL")
					{
						homeTrendingAdapterViewHolder.SliderHint.Text = string.Concat(new string[]
						{
							this.context.Resources.GetString(2131951895),
							" ",
							homeTrendingModel.Episodes,
							" (",
							this.context.Resources.GetString(2131952542),
							")"
						});
					}
					else if (homeTrendingModel.Episode.MarkedAs == "FILLER")
					{
						homeTrendingAdapterViewHolder.SliderHint.Text = string.Concat(new string[]
						{
							this.context.Resources.GetString(2131951895),
							" ",
							homeTrendingModel.Episodes,
							" (",
							this.context.Resources.GetString(2131952538),
							")"
						});
					}
					else if (homeTrendingModel.Episode.MarkedAs == "LAST_FILLER")
					{
						homeTrendingAdapterViewHolder.SliderHint.Text = string.Concat(new string[]
						{
							this.context.Resources.GetString(2131951895),
							" ",
							homeTrendingModel.Episodes,
							" (",
							this.context.Resources.GetString(2131952025),
							" • ",
							this.context.Resources.GetString(2131952538),
							")"
						});
					}
					else if (homeTrendingModel.Episode.MarkedAs == "LAST")
					{
						homeTrendingAdapterViewHolder.SliderHint.Text = string.Concat(new string[]
						{
							this.context.Resources.GetString(2131951895),
							" ",
							homeTrendingModel.Episodes,
							" (",
							this.context.Resources.GetString(2131952025),
							")"
						});
					}
					else
					{
						homeTrendingAdapterViewHolder.SliderHint.Text = this.context.Resources.GetString(2131951895) + " " + homeTrendingModel.Episodes;
					}
					homeTrendingAdapterViewHolder.SliderHint.Visibility = ViewStates.Visible;
				}
				else
				{
					homeTrendingAdapterViewHolder.SliderHint.Visibility = ViewStates.Gone;
				}
			}
			else
			{
				homeTrendingAdapterViewHolder.SliderHint.Text = homeTrendingModel.Hint;
				homeTrendingAdapterViewHolder.SliderHint.Visibility = ViewStates.Visible;
			}
			if (!(homeTrendingModel.Photo == ""))
			{
				Glide.With(this.viewPager2.Context).Load(Constants.TrendingPhotos(homeTrendingModel.Photo)).CenterCrop().Placeholder(2131231224).Into(homeTrendingAdapterViewHolder.SliderPhoto);
				return;
			}
			string type3 = homeTrendingModel.Type;
			if (type3 == "ANIME")
			{
				Glide.With(this.viewPager2.Context).Load(Constants.Thumbnails(homeTrendingModel.Anime.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(homeTrendingAdapterViewHolder.SliderPhoto);
				return;
			}
			if (type3 == "EPISODE")
			{
				Glide.With(this.viewPager2.Context).Load(Constants.Thumbnails(homeTrendingModel.Anime.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(homeTrendingAdapterViewHolder.SliderPhoto);
				return;
			}
			if (type3 == "NEWS")
			{
				Glide.With(this.viewPager2.Context).Load(Constants.NewsCover(homeTrendingModel.News.Thumbnail)).CenterCrop().Placeholder(2131231224).Into(homeTrendingAdapterViewHolder.SliderPhoto);
				return;
			}
			if (!(type3 == "CHARACTER"))
			{
				Glide.With(this.viewPager2.Context).Load(Constants.TrendingPhotos(homeTrendingModel.Photo)).CenterCrop().Placeholder(2131231224).Into(homeTrendingAdapterViewHolder.SliderPhoto);
				return;
			}
			Glide.With(this.viewPager2.Context).Load(Constants.CharPhoto(homeTrendingModel.Character.Photo)).CenterCrop().Placeholder(2131231224).Into(homeTrendingAdapterViewHolder.SliderPhoto);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000BCC2 File Offset: 0x00009EC2
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000BCD9 File Offset: 0x00009ED9
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000163 RID: 355
		private List<HomeTrendingModel> items;

		// Token: 0x04000164 RID: 356
		private ViewPager2 viewPager2;

		// Token: 0x04000165 RID: 357
		private Context context;
	}
}
