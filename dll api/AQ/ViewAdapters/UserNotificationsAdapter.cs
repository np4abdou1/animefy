using System;
using System.Collections.Generic;
using System.Globalization;
using Android.Content;
using Android.Graphics;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using AQ.Models;
using Bumptech.Glide;

namespace AQ.ViewAdapters
{
	// Token: 0x02000041 RID: 65
	public class UserNotificationsAdapter : RecyclerView.Adapter
	{
		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060002A1 RID: 673 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		// (remove) Token: 0x060002A2 RID: 674 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public event EventHandler<int> ItemClick;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060002A3 RID: 675 RVA: 0x0000CA30 File Offset: 0x0000AC30
		// (remove) Token: 0x060002A4 RID: 676 RVA: 0x0000CA68 File Offset: 0x0000AC68
		public event EventHandler<int> ItemAvatarClick;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060002A5 RID: 677 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		// (remove) Token: 0x060002A6 RID: 678 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public event EventHandler<int> ItemLongClick;

		// Token: 0x060002A7 RID: 679 RVA: 0x0000CB0D File Offset: 0x0000AD0D
		public UserNotificationsAdapter(Context context, List<UserNotificationsModel> items, int lastNotificationId)
		{
			this.items = items;
			this.context = context;
			this.lastNotificationId = lastNotificationId;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			int resource = 2131558633;
			View itemView = LayoutInflater.From(parent.Context).Inflate(resource, parent, false);
			return new UserNotificationsViewHolder(itemView, new Action<int>(this.OnClick), new Action<int>(this.OnAvatarClick), new Action<int>(this.OnLongClick));
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000CB80 File Offset: 0x0000AD80
		public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
		{
			UserNotificationsModel userNotificationsModel = this.items[position];
			UserNotificationsViewHolder userNotificationsViewHolder = viewHolder as UserNotificationsViewHolder;
			if (userNotificationsModel.Subject == "COMMENT")
			{
				SpannableStringBuilder spannableStringBuilder = new SpannableStringBuilder();
				if (userNotificationsModel.Action == "LIKE" || userNotificationsModel.Action == "DISLIKE")
				{
					if (this.context.Resources.GetString(2131951706) == "AR")
					{
						if (userNotificationsModel.Action == "LIKE")
						{
							spannableStringBuilder.Append(this.context.Resources.GetString(2131951992) + " ");
						}
						else
						{
							spannableStringBuilder.Append(this.context.Resources.GetString(2131951990) + " ");
						}
						int start = spannableStringBuilder.Length();
						spannableStringBuilder.Append(userNotificationsModel.User.FullName + " ");
						spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
						spannableStringBuilder.Append(this.context.Resources.GetString(2131952603) + ".");
					}
					else
					{
						spannableStringBuilder.Append(userNotificationsModel.User.FullName + " ");
						int start2 = spannableStringBuilder.Length();
						spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start2, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
						if (userNotificationsModel.Action == "LIKE")
						{
							spannableStringBuilder.Append(this.context.Resources.GetString(2131951977) + " ");
						}
						else
						{
							spannableStringBuilder.Append(this.context.Resources.GetString(2131951975) + " ");
						}
						spannableStringBuilder.Append(this.context.Resources.GetString(2131952603) + ".");
					}
					userNotificationsViewHolder.BodyView.Visibility = ViewStates.Visible;
					userNotificationsViewHolder.BodyView.Text = "\"" + userNotificationsModel.Comment.CommBody + "\"";
				}
				else if (userNotificationsModel.Action == "REPLY")
				{
					if (this.context.Resources.GetString(2131951706) == "AR")
					{
						spannableStringBuilder.Append(this.context.Resources.GetString(2131951991) + " ");
						int start3 = spannableStringBuilder.Length();
						spannableStringBuilder.Append(userNotificationsModel.User.FullName + " ");
						spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start3, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
						spannableStringBuilder.Append(this.context.Resources.GetString(2131951978) + ".");
					}
					else
					{
						spannableStringBuilder.Append(userNotificationsModel.User.FullName + " ");
						int start4 = spannableStringBuilder.Length();
						spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start4, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
						spannableStringBuilder.Append(this.context.Resources.GetString(2131951978) + ".");
					}
					userNotificationsViewHolder.BodyView.Visibility = ViewStates.Gone;
				}
				userNotificationsViewHolder.TitleView.SetText(spannableStringBuilder, TextView.BufferType.Spannable);
			}
			else if (userNotificationsModel.Subject == "REPLY" && (userNotificationsModel.Action == "LIKE" || userNotificationsModel.Action == "DISLIKE"))
			{
				SpannableStringBuilder spannableStringBuilder2 = new SpannableStringBuilder();
				if (this.context.Resources.GetString(2131951706) == "AR")
				{
					if (userNotificationsModel.Action == "LIKE")
					{
						spannableStringBuilder2.Append(this.context.Resources.GetString(2131951992) + " ");
					}
					else
					{
						spannableStringBuilder2.Append(this.context.Resources.GetString(2131951990) + " ");
					}
					int start5 = spannableStringBuilder2.Length();
					spannableStringBuilder2.Append(userNotificationsModel.User.FullName + " ");
					spannableStringBuilder2.SetSpan(new StyleSpan(TypefaceStyle.Bold), start5, spannableStringBuilder2.Length(), SpanTypes.ExclusiveExclusive);
					spannableStringBuilder2.Append(this.context.Resources.GetString(2131952610) + ".");
				}
				else
				{
					spannableStringBuilder2.Append(userNotificationsModel.User.FullName + " ");
					int start6 = spannableStringBuilder2.Length();
					spannableStringBuilder2.SetSpan(new StyleSpan(TypefaceStyle.Bold), start6, spannableStringBuilder2.Length(), SpanTypes.ExclusiveExclusive);
					if (userNotificationsModel.Action == "LIKE")
					{
						spannableStringBuilder2.Append(this.context.Resources.GetString(2131951977) + " ");
					}
					else
					{
						spannableStringBuilder2.Append(this.context.Resources.GetString(2131951975) + " ");
					}
					spannableStringBuilder2.Append(this.context.Resources.GetString(2131952610) + ".");
				}
				userNotificationsViewHolder.TitleView.SetText(spannableStringBuilder2, TextView.BufferType.Spannable);
				userNotificationsViewHolder.BodyView.Text = "\"" + userNotificationsModel.Reply.ReplyBody + "\"";
				userNotificationsViewHolder.BodyView.Visibility = ViewStates.Visible;
			}
			if (this.context.Resources.GetString(2131951706) == "AR")
			{
				double totalHours = DateTime.Now.Subtract(DateTime.Parse(userNotificationsModel.Date)).TotalHours;
				if (totalHours <= 24.0)
				{
					userNotificationsViewHolder.DateView.Text = this.context.Resources.GetString(2131952521) + " " + DateTime.Parse(userNotificationsModel.Date).ToString("hh:mm tt", new CultureInfo("ar-EG"));
				}
				else if (totalHours <= 48.0)
				{
					userNotificationsViewHolder.DateView.Text = this.context.Resources.GetString(2131952589) + " " + DateTime.Parse(userNotificationsModel.Date).ToString("hh:mm tt", new CultureInfo("ar-EG"));
				}
				else
				{
					userNotificationsViewHolder.DateView.Text = DateTime.Parse(userNotificationsModel.Date).ToString("dddd dd MMMM hh:mm tt", new CultureInfo("ar-EG"));
				}
			}
			else
			{
				double totalHours2 = DateTime.Now.Subtract(DateTime.Parse(userNotificationsModel.Date)).TotalHours;
				if (totalHours2 <= 24.0)
				{
					userNotificationsViewHolder.DateView.Text = this.context.Resources.GetString(2131952521) + " " + DateTime.Parse(userNotificationsModel.Date).ToString("hh:mm tt");
				}
				else if (totalHours2 <= 48.0)
				{
					userNotificationsViewHolder.DateView.Text = this.context.Resources.GetString(2131952589) + " " + DateTime.Parse(userNotificationsModel.Date).ToString("hh:mm tt");
				}
				else
				{
					userNotificationsViewHolder.DateView.Text = DateTime.Parse(userNotificationsModel.Date).ToString("ddd dd MMM hh:mm tt");
				}
			}
			if (userNotificationsModel.Id > this.lastNotificationId)
			{
				userNotificationsViewHolder.NewNotificationShadowView.Visibility = ViewStates.Visible;
			}
			else
			{
				userNotificationsViewHolder.NewNotificationShadowView.Visibility = ViewStates.Gone;
			}
			if (userNotificationsModel.User.ProfileImage != "")
			{
				Glide.With(this.context).Load(Constants.ProfilePhoto(userNotificationsModel.User.ProfileImage, userNotificationsModel.User.UserID.ToString())).CenterCrop().Into(userNotificationsViewHolder.AvatarView);
				return;
			}
			if (userNotificationsModel.User.GoogleProfilePhotoUrl != "")
			{
				Glide.With(this.context).Load(userNotificationsModel.User.GoogleProfilePhotoUrl).CenterCrop().Placeholder(2131231224).Into(userNotificationsViewHolder.AvatarView);
				return;
			}
			userNotificationsViewHolder.AvatarView.SetImageResource(2131231168);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000D448 File Offset: 0x0000B648
		private void OnClick(int obj)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, obj);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000D45F File Offset: 0x0000B65F
		private void OnAvatarClick(int obj)
		{
			if (this.ItemAvatarClick != null)
			{
				this.ItemAvatarClick(this, obj);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000D476 File Offset: 0x0000B676
		private void OnLongClick(int obj)
		{
			if (this.ItemLongClick != null)
			{
				this.ItemLongClick(this, obj);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000D48D File Offset: 0x0000B68D
		public override int ItemCount
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x0400018B RID: 395
		private List<UserNotificationsModel> items;

		// Token: 0x0400018C RID: 396
		private Context context;

		// Token: 0x0400018D RID: 397
		private int lastNotificationId;
	}
}
