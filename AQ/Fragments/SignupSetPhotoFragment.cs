using System;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Provider;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Models;
using Refractored.Controls;

namespace AQ.Fragments
{
	// Token: 0x020000AA RID: 170
	public class SignupSetPhotoFragment : Fragment
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x0001DA58 File Offset: 0x0001BC58
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001DA64 File Offset: 0x0001BC64
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558458, container, false);
			this.mUserId = base.Arguments.GetString("UserId", "N/A");
			this.mUseName = base.Arguments.GetString("UserName", "N/A");
			this.mFullName = base.Arguments.GetString("FullName", "N/A");
			this.mPassword = base.Arguments.GetString("Password", "N/A");
			this.mSelectedIamge = this.view.FindViewById<CircleImageView>(2131362884);
			this.mSelectImage = this.view.FindViewById<Button>(2131362891);
			this.mProgressView = this.view.FindViewById<RelativeLayout>(2131362899);
			this.mImageLoadingShadow = this.view.FindViewById<LinearLayout>(2131362883);
			this.mWelcome = this.view.FindViewById<TextView>(2131362896);
			this.mSkip = this.view.FindViewById<TextView>(2131362892);
			this.mWelcome.Text = base.Resources.GetString(2131951994) + " " + this.mFullName;
			Bundle bundle = new Bundle();
			bundle.PutString("DialogTitle", this.view.Resources.GetString(2131951650));
			bundle.PutString("DialogMessage", this.view.Resources.GetString(2131952298));
			DialogPopupMessage dialogPopupMessage = new DialogPopupMessage();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogPopupMessage.Arguments = bundle;
			dialogPopupMessage.Show(transaction, "DialogPopupMessage");
			this.mSelectImage.Click += this.MSelectImage_Click;
			this.mSkip.Click += this.MSkip_Click;
			this.mProgressView.Click += this.MProgressView_Click;
			return this.view;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00004097 File Offset: 0x00002297
		private void MProgressView_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0001DC56 File Offset: 0x0001BE56
		private void MSkip_Click(object sender, EventArgs e)
		{
			this.mProgressView.Visibility = ViewStates.Visible;
			UsersModel.OnResumeLogin = true;
			base.Activity.Finish();
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001DC78 File Offset: 0x0001BE78
		private void MSelectImage_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.PICK", MediaStore.Images.Media.ExternalContentUri);
			intent.SetType("image/*");
			this.StartActivityForResult(Intent.CreateChooser(intent, "Select a Picture"), SignupSetPhotoFragment.SELECT_SIGNUP_PROFILE_IMAGE);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0001DCB7 File Offset: 0x0001BEB7
		public override void OnActivityResult(int requestCode, int resultCode, Intent data)
		{
			if (resultCode == -1 && requestCode == SignupSetPhotoFragment.SELECT_SIGNUP_PROFILE_IMAGE)
			{
				this.UploadeImageAsync(data.Data, 500, 500);
			}
			base.OnActivityResult(requestCode, resultCode, data);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		public void UploadeImageAsync(Android.Net.Uri data, int requestedWidth, int requestedHeight)
		{
			SignupSetPhotoFragment.<UploadeImageAsync>d__18 <UploadeImageAsync>d__;
			<UploadeImageAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UploadeImageAsync>d__.<>4__this = this;
			<UploadeImageAsync>d__.data = data;
			<UploadeImageAsync>d__.requestedWidth = requestedWidth;
			<UploadeImageAsync>d__.requestedHeight = requestedHeight;
			<UploadeImageAsync>d__.<>1__state = -1;
			<UploadeImageAsync>d__.<>t__builder.Start<SignupSetPhotoFragment.<UploadeImageAsync>d__18>(ref <UploadeImageAsync>d__);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0001DD34 File Offset: 0x0001BF34
		public static int CalculateInSampleSize(BitmapFactory.Options options, int reqWidth, int reqHeight)
		{
			float num = (float)options.OutHeight;
			float num2 = (float)options.OutWidth;
			double num3 = 1.0;
			if (num > (float)reqHeight || num2 > (float)reqWidth)
			{
				int num4 = (int)(num / 2f);
				int num5 = (int)(num2 / 2f);
				num3 *= 2.0;
			}
			return (int)num3;
		}

		// Token: 0x040004A1 RID: 1185
		private View view;

		// Token: 0x040004A2 RID: 1186
		private TextView mWelcome;

		// Token: 0x040004A3 RID: 1187
		private TextView mSkip;

		// Token: 0x040004A4 RID: 1188
		private Button mSelectImage;

		// Token: 0x040004A5 RID: 1189
		private CircleImageView mSelectedIamge;

		// Token: 0x040004A6 RID: 1190
		private LinearLayout mImageLoadingShadow;

		// Token: 0x040004A7 RID: 1191
		private RelativeLayout mProgressView;

		// Token: 0x040004A8 RID: 1192
		private static readonly int SELECT_SIGNUP_PROFILE_IMAGE = 1;

		// Token: 0x040004A9 RID: 1193
		private string mUserId;

		// Token: 0x040004AA RID: 1194
		private string mUseName;

		// Token: 0x040004AB RID: 1195
		private string mFullName;

		// Token: 0x040004AC RID: 1196
		private string mPassword;
	}
}
