using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Util;
using AndroidX.Fragment.App;
using AQ.Activities;
using AQ.Helpers;
using Bumptech.Glide;
using Java.Lang;
using Refractored.Controls;

namespace AQ.Fragments
{
	// Token: 0x020000A0 RID: 160
	public class DialogUserProfile : DialogFragment
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x0001503C File Offset: 0x0001323C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.userId = base.Arguments.GetString("UserId");
			this.userDisplayName = base.Arguments.GetString("DisplayName");
			this.userBio = base.Arguments.GetString("Bio");
			this.userGender = base.Arguments.GetString("Gender");
			this.userMembership = base.Arguments.GetString("Membership");
			this.userProfilePhoto = base.Arguments.GetString("ProfilePhoto");
			this.userGglProfilePhoto = base.Arguments.GetString("GglPforilePhoto");
			this.userProfileCover = base.Arguments.GetString("ProfileCover");
			this.allowLibraryView = base.Arguments.GetInt("LibraryViewAllowed", 0);
			this.view = inflater.Inflate(2131558522, container, false);
			this.view.FindViewById<RelativeLayout>(2131362859).ClipToOutline = true;
			this.mDialogDisplayName = this.view.FindViewById<TextView>(2131362855);
			this.mDialogMembership = this.view.FindViewById<TextView>(2131362857);
			this.mDialogBio = this.view.FindViewById<TextView>(2131362854);
			this.mDialogGoProfile = this.view.FindViewById<Button>(2131362856);
			this.mProfilePhoto = this.view.FindViewById<CircleImageView>(2131362860);
			this.mProfileCover = this.view.FindViewById<ImageView>(2131362858);
			this.mClose = this.view.FindViewById<ImageView>(2131363243);
			this.mDialogDisplayName.Text = this.userDisplayName;
			if (this.userBio != "")
			{
				this.mDialogBio.Text = "\"" + this.userBio + "\"";
			}
			else
			{
				this.mDialogBio.Text = "\"" + this.view.Resources.GetString(2131952232) + "\"";
			}
			if (this.userMembership == "ADMIN")
			{
				this.mDialogMembership.Text = base.Resources.GetString(2131951669);
				this.mDialogMembership.SetBackgroundResource(2131231248);
				this.mDialogMembership.Visibility = ViewStates.Visible;
				this.mProfilePhoto.BorderColor = Color.Red;
			}
			else if (this.userMembership == "PREMIUM")
			{
				this.mDialogMembership.Text = base.Resources.GetString(2131952304);
				this.mDialogMembership.SetBackgroundResource(2131231245);
				this.mDialogMembership.Visibility = ViewStates.Visible;
				this.mProfilePhoto.BorderColor = Color.Gold;
			}
			if (this.userProfilePhoto != "")
			{
				Glide.With(this).Load(Constants.ProfilePhoto(this.userProfilePhoto, this.userId)).Into(this.mProfilePhoto);
			}
			else if (this.userGglProfilePhoto != "")
			{
				Glide.With(this).Load(this.userGglProfilePhoto).Into(this.mProfilePhoto);
			}
			if (this.userProfileCover != "")
			{
				Glide.With(this).Load(Constants.ProfileCover(this.userProfileCover, this.userId)).Into(this.mProfileCover);
			}
			this.mDialogGoProfile.Click += this.MDialogGoProfile_Click;
			this.mClose.Click += this.MClose_Click;
			return this.view;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MClose_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000153F4 File Offset: 0x000135F4
		private void MDialogGoProfile_Click(object sender, EventArgs e)
		{
			if (this.IsFirstTime)
			{
				this.IsFirstTime = false;
			}
			else
			{
				long num = JavaSystem.CurrentTimeMillis();
				if (num - this.mLastClickTime < DialogUserProfile.CLICK_TIME_INTERVAL)
				{
					return;
				}
				this.mLastClickTime = num;
			}
			if (this.userMembership == "ADMIN")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951670), 0);
				return;
			}
			Intent intent = new Intent(Application.Context, typeof(UserProfileActivity));
			intent.PutExtra("UserId", this.userId);
			intent.PutExtra("DisplayName", this.userDisplayName);
			intent.PutExtra("Bio", this.userBio);
			intent.PutExtra("Gender", this.userGender);
			intent.PutExtra("Membership", this.userMembership);
			intent.PutExtra("ProfilePhoto", this.userProfilePhoto);
			intent.PutExtra("GglProfilePhoto", this.userGglProfilePhoto);
			intent.PutExtra("ProfileCover", this.userProfileCover);
			intent.PutExtra("LibraryViewAllowed", this.allowLibraryView);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Pair pair = Pair.Create(this.mDialogDisplayName, "displayname");
				Pair pair2 = Pair.Create(this.mDialogBio, "bio");
				Pair pair3 = Pair.Create(this.mProfilePhoto, "profilephoto");
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, new Pair[]
				{
					pair,
					pair2,
					pair3
				});
				this.StartActivity(intent, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivity(intent);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001559C File Offset: 0x0001379C
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			this.Dialog.Window.Attributes.WindowAnimations = 2132018311;
			base.OnActivityCreated(savedInstanceState);
		}

		// Token: 0x04000393 RID: 915
		private View view;

		// Token: 0x04000394 RID: 916
		private string userId;

		// Token: 0x04000395 RID: 917
		private string userDisplayName;

		// Token: 0x04000396 RID: 918
		private string userBio;

		// Token: 0x04000397 RID: 919
		private string userGender;

		// Token: 0x04000398 RID: 920
		private string userMembership;

		// Token: 0x04000399 RID: 921
		private string userProfilePhoto;

		// Token: 0x0400039A RID: 922
		private string userGglProfilePhoto;

		// Token: 0x0400039B RID: 923
		private string userProfileCover;

		// Token: 0x0400039C RID: 924
		private int allowLibraryView;

		// Token: 0x0400039D RID: 925
		private TextView mDialogDisplayName;

		// Token: 0x0400039E RID: 926
		private TextView mDialogMembership;

		// Token: 0x0400039F RID: 927
		private TextView mDialogBio;

		// Token: 0x040003A0 RID: 928
		private Button mDialogGoProfile;

		// Token: 0x040003A1 RID: 929
		private CircleImageView mProfilePhoto;

		// Token: 0x040003A2 RID: 930
		private ImageView mProfileCover;

		// Token: 0x040003A3 RID: 931
		private ImageView mClose;

		// Token: 0x040003A4 RID: 932
		private bool IsFirstTime = true;

		// Token: 0x040003A5 RID: 933
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x040003A6 RID: 934
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
