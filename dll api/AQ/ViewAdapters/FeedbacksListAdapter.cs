using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using AQ.Models;

namespace AQ.ViewAdapters
{
	// Token: 0x02000032 RID: 50
	public class FeedbacksListAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000208 RID: 520 RVA: 0x0000A148 File Offset: 0x00008348
		// (remove) Token: 0x06000209 RID: 521 RVA: 0x0000A180 File Offset: 0x00008380
		public event EventHandler<int> ItemClick;

		// Token: 0x0600020A RID: 522 RVA: 0x0000A1B5 File Offset: 0x000083B5
		public FeedbacksListAdapter(Context context, List<FeedBackModel> items)
		{
			this.items = items;
			this.context = context;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000A1CC File Offset: 0x000083CC
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558626;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new FeedbacksListHolder(itemView, new Action<int>(this.OnClick));
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A208 File Offset: 0x00008408
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			FeedBackModel feedBackModel = this.items[position];
			FeedbacksListHolder feedbacksListHolder = viewHolder as FeedbacksListHolder;
			if (feedBackModel.Subject == "")
			{
				feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131952244);
			}
			else
			{
				string subject = feedBackModel.Subject;
				if (!(subject == "NO_SUBJECT"))
				{
					if (!(subject == "ANIME_REQUEST"))
					{
						if (!(subject == "CHAR_PAGE_SUGGESTION"))
						{
							if (!(subject == "SUGGESTION"))
							{
								if (!(subject == "CONVERSATION"))
								{
									if (!(subject == "REPORT_ERROR"))
									{
										feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131952244);
									}
									else
									{
										feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131952336);
									}
								}
								else
								{
									feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131951823);
								}
							}
							else
							{
								feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131952448);
							}
						}
						else
						{
							feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131952448);
						}
					}
					else
					{
						feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131951697);
					}
				}
				else
				{
					feedbacksListHolder.SubjectView.Text = " " + this.context.Resources.GetString(2131952244);
				}
			}
			feedbacksListHolder.BodyView.Text = " " + feedBackModel.Note;
			if (feedBackModel.Status == 0)
			{
				feedbacksListHolder.DoneView.Visibility = ViewStates.Visible;
				return;
			}
			feedbacksListHolder.DoneView.Visibility = ViewStates.Gone;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000A44A File Offset: 0x0000864A
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000A461 File Offset: 0x00008661
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x04000147 RID: 327
		private List<FeedBackModel> items;

		// Token: 0x04000148 RID: 328
		private Context context;
	}
}
