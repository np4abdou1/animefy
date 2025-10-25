using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Auth.Api.SignIn;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Content;
using AndroidX.Fragment.App;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Bumptech.Glide;
using Google.Android.Material.Snackbar;
using Newtonsoft.Json;
using Refractored.Controls;

namespace AQ.Activities
{
	// Token: 0x020000BE RID: 190
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class AccountCPActivity : AppCompatActivity
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00025470 File Offset: 0x00023670
		protected override void OnCreate(Bundle savedInstanceState)
		{
			string a = SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme");
			if (!(a == "BLUE"))
			{
				if (!(a == "PINK"))
				{
					if (!(a == "LIGHT_GRAY"))
					{
						this.SetTheme(2132017171);
					}
					else
					{
						this.SetTheme(2132017174);
					}
				}
				else
				{
					this.SetTheme(2132017177);
				}
			}
			else
			{
				this.SetTheme(2132017168);
			}
			base.OnCreate(savedInstanceState);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SupportActionBar.SetDisplayShowTitleEnabled(false);
			this.SupportActionBar.SetDisplayShowCustomEnabled(true);
			this.SupportActionBar.SetCustomView(2131558646);
			this.SetContentView(2131558430);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mContent = base.FindViewById<RelativeLayout>(2131363075);
			this.mRefreshLoader = base.FindViewById<SwipeRefreshLayout>(2131363242);
			base.FindViewById<RelativeLayout>(2131363234).ClipToOutline = true;
			this.mHeaderDisplayName = base.FindViewById<TextView>(2131363222);
			this.mMembership = base.FindViewById<TextView>(2131363223);
			this.mDisplayName = base.FindViewById<TextView>(2131363209);
			this.mEmail = base.FindViewById<TextView>(2131363212);
			this.mUserBio = base.FindViewById<TextView>(2131363221);
			this.mPremiumMark = base.FindViewById<ImageView>(2131363231);
			this.mBioEditBtn = base.FindViewById<Button>(2131363211);
			this.mProfilePhoto = base.FindViewById<CircleImageView>(2131363235);
			this.mProfileCover = base.FindViewById<ImageView>(2131363232);
			this.mCommentsCount = base.FindViewById<TextView>(2131363208);
			this.mRepliesCount = base.FindViewById<TextView>(2131363238);
			this.mRatingsCount = base.FindViewById<TextView>(2131363237);
			this.mGoogleSyncText = base.FindViewById<TextView>(2131363220);
			this.mAllowLibraryViewToggle = base.FindViewById<AppCompatCheckBox>(2131363224);
			if (this.user.AllowLibraryView == 1)
			{
				this.mAllowLibraryViewToggle.Checked = false;
			}
			if (this.user.Membership == "ADMIN")
			{
				this.mMembership.Text = this.Resources.GetString(2131951669);
				this.mMembership.SetBackgroundResource(2131231248);
				this.mMembership.Visibility = ViewStates.Visible;
				this.mProfilePhoto.BorderColor = ContextCompat.GetColor(this, 2131100510);
			}
			else if (this.user.Membership == "PREMIUM")
			{
				this.mMembership.Text = this.Resources.GetString(2131952304);
				this.mMembership.SetBackgroundResource(2131231245);
				this.mMembership.Visibility = ViewStates.Visible;
				this.mProfilePhoto.BorderColor = Color.Gold;
				this.mPremiumMark.Visibility = ViewStates.Visible;
			}
			else if (this.user.Membership == "EXPIRED_PREMIUM")
			{
				Snackbar snackbar = Snackbar.Make(this.mContent, 2131952305, -2);
				snackbar.SetAction(2131951822, delegate(View v)
				{
					new ContactBottomSheet().Show(this.SupportFragmentManager.BeginTransaction(), "ContactSheet");
				}).Show();
			}
			this.mGenderMale = base.FindViewById<RadioButton>(2131363215);
			this.mGenderFemale = base.FindViewById<RadioButton>(2131363214);
			this.mGenderNotSpecified = base.FindViewById<RadioButton>(2131363216);
			if (this.user.Gender == "MALE")
			{
				this.mGenderMale.Checked = true;
			}
			else if (this.user.Gender == "FEMALE")
			{
				this.mGenderFemale.Checked = true;
			}
			else
			{
				this.mGenderNotSpecified.Checked = true;
			}
			this.mProfilePhotoLoader = base.FindViewById<FrameLayout>(2131363236);
			this.mSyncGoogleLoader = base.FindViewById<ProgressBar>(2131363218);
			this.mSyncGoogle = base.FindViewById<FrameLayout>(2131363217);
			this.mSignOut = base.FindViewById<Button>(2131363226);
			this.mSyncGoogleLoaderIcon = base.FindViewById<ImageView>(2131363219);
			this.mSelectProfilePhoto = base.FindViewById<ImageView>(2131363241);
			this.mSelectProfileCover = base.FindViewById<ImageView>(2131363240);
			this.mProfileCoverLoader = base.FindViewById<ProgressBar>(2131363233);
			this.mChangeFullName = base.FindViewById<ImageView>(2131363210);
			this.mChangePassword = base.FindViewById<ImageView>(2131363229);
			this.mChangePasswordContent = base.FindViewById<RelativeLayout>(2131363228);
			this.mPasswordEditSeperator = base.FindViewById<View>(2131363230);
			GoogleSignInOptions options = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn).RequestEmail().Build();
			this.mGoogleSignInClient = GoogleSignIn.GetClient(this, options);
			this.PrepareUserProfileUI();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.UserStatistics();
			});
			this.mUserBio.Click += this.MUserBio_Click;
			this.mSelectProfilePhoto.Click += this.MSelectProfilePhoto_Click;
			this.mSelectProfileCover.Click += this.MSelectProfileCover_Click;
			this.mChangeFullName.Click += this.MChangeFullName_Click;
			this.mChangePassword.Click += this.MChangePassword_Click;
			this.mSyncGoogle.Click += this.MSyncGoogle_Click;
			this.mSignOut.Click += this.MSignOut_Click;
			this.mRefreshLoader.Refresh += this.MRefreshLoader_Refresh;
			this.mBioEditBtn.Click += this.MBioEditBtn_Click;
			this.mAllowLibraryViewToggle.CheckedChange += this.MAllowLibraryViewToggle_CheckedChange;
			this.mGenderMale.CheckedChange += this.MGenderMale_CheckedChange;
			this.mGenderFemale.CheckedChange += this.MGenderFemale_CheckedChange;
			this.mGenderNotSpecified.CheckedChange += this.MGenderNotSpecified_CheckedChange;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00025A78 File Offset: 0x00023C78
		private void UserStatistics()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/user_statistics.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object senderc, UploadValuesCompletedEventArgs ec)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(ec.Result);
					UserStatistics counterData = JsonConvert.DeserializeObject<UserStatistics>(@string);
					if (counterData != null)
					{
						base.RunOnUiThread(delegate()
						{
							this.mCommentsCount.Text = counterData.comments.ToString();
							this.mRepliesCount.Text = counterData.comments_replies.ToString();
							this.mRatingsCount.Text = counterData.ratings.ToString();
						});
					}
				}
				catch
				{
				}
			};
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00025AE4 File Offset: 0x00023CE4
		private void MUserBio_Click(object sender, EventArgs e)
		{
			if (!(this.user.Bio != ""))
			{
				this.mUserBio.Text = "\"" + this.Resources.GetString(2131952232) + "\"";
				return;
			}
			if (this.isBiographyExpanded)
			{
				this.mUserBio.Post(new Suffixer(this, this.mUserBio, 6, this.Resources.GetString(2131951949)));
				this.isBiographyExpanded = false;
				return;
			}
			this.mUserBio.SetMaxLines(this.bioLinesCount);
			this.mUserBio.Text = "\"" + this.user.Bio + "\"";
			this.isBiographyExpanded = true;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00025BAC File Offset: 0x00023DAC
		private void MSyncGoogle_Click(object sender, EventArgs e)
		{
			if (this.user.GoogleUserID == "" || this.user.GoogleUserID == "0")
			{
				Intent signInIntent = this.mGoogleSignInClient.SignInIntent;
				this.StartActivityForResult(signInIntent, 1003);
				return;
			}
			GoogleSignInAccount lastSignedInAccount = GoogleSignIn.GetLastSignedInAccount(this);
			if (lastSignedInAccount != null)
			{
				this.mSyncGoogleLoader.Visibility = ViewStates.Visible;
				this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Gone;
				this.GoogleSyceAccount(lastSignedInAccount);
				return;
			}
			Intent signInIntent2 = this.mGoogleSignInClient.SignInIntent;
			this.StartActivityForResult(signInIntent2, 1004);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00025C42 File Offset: 0x00023E42
		private void MGenderNotSpecified_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mGenderMale.Checked = false;
				this.mGenderFemale.Checked = false;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.UpdateGender("NOT_SPECIFIED");
				});
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00025C76 File Offset: 0x00023E76
		private void MGenderFemale_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mGenderMale.Checked = false;
				this.mGenderNotSpecified.Checked = false;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.UpdateGender("FEMALE");
				});
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00025CAA File Offset: 0x00023EAA
		private void MGenderMale_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.mGenderFemale.Checked = false;
				this.mGenderNotSpecified.Checked = false;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.UpdateGender("MALE");
				});
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00025CE0 File Offset: 0x00023EE0
		private void MBioEditBtn_Click(object sender, EventArgs e)
		{
			DialogUpdateUserBio dialogUpdateUserBio = new DialogUpdateUserBio();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogUpdateUserBio.Show(transaction, "DialogUpdateUserBio");
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00025D0C File Offset: 0x00023F0C
		private void MAllowLibraryViewToggle_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				this.UpdateLibraryViewAllowance(0);
				return;
			}
			this.UpdateLibraryViewAllowance(1);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00025D25 File Offset: 0x00023F25
		private void MRefreshLoader_Refresh(object sender, EventArgs e)
		{
			this.mRefreshLoader.Refreshing = false;
			this.user = UsersViewModel.GetUserProfile();
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00025D40 File Offset: 0x00023F40
		private void MSignOut_Click(object sender, EventArgs e)
		{
			UsersViewModel.ClearUsers();
			CustomizedToast.ShowToast(this, this.Resources.GetString(2131952600), 0);
			if (this.user.GoogleUserID != "" || this.user.GoogleUserID != "0")
			{
				SharedPreferencesSaves.IntSharedPreferencesSave("CurrentUserNotifications", 0);
				this.mGoogleSignInClient.SignOut();
			}
			base.StartActivity(typeof(MainActivity));
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00025DC0 File Offset: 0x00023FC0
		public void HandleLinkResult(Task<GoogleSignInAccount> tast)
		{
			try
			{
				GoogleSignInAccount result = tast.Result;
				this.GoogleLinkAccount(result);
			}
			catch
			{
				base.RunOnUiThread(delegate()
				{
					this.mSyncGoogleLoader.Visibility = ViewStates.Gone;
					this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Visible;
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951821), 0);
				});
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00025E04 File Offset: 0x00024004
		public void HandleSyceResult(Task<GoogleSignInAccount> tast)
		{
			try
			{
				GoogleSignInAccount result = tast.Result;
				this.GoogleSyceAccount(result);
			}
			catch
			{
				base.RunOnUiThread(delegate()
				{
					this.mSyncGoogleLoader.Visibility = ViewStates.Gone;
					this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Visible;
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951821), 0);
				});
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00025E48 File Offset: 0x00024048
		private void MChangePassword_Click(object sender, EventArgs e)
		{
			DialogUpdateUserPassword dialogUpdateUserPassword = new DialogUpdateUserPassword();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogUpdateUserPassword.Show(transaction, "DialogUpdateUserPassword");
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00025E74 File Offset: 0x00024074
		private void MChangeFullName_Click(object sender, EventArgs e)
		{
			DialogUpdateUserInfo dialogUpdateUserInfo = new DialogUpdateUserInfo();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogUpdateUserInfo.Show(transaction, "DialogUpdateUserInfo");
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00025EA0 File Offset: 0x000240A0
		private void MSelectProfilePhoto_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.PICK", MediaStore.Images.Media.ExternalContentUri);
			intent.SetType("image/*");
			this.StartActivityForResult(Intent.CreateChooser(intent, this.Resources.GetString(2131952376)), AccountCPActivity.SELECT_PROFILE_IMAGE);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00025EEC File Offset: 0x000240EC
		private void MSelectProfileCover_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.PICK", MediaStore.Images.Media.ExternalContentUri);
			intent.SetType("image/*");
			this.StartActivityForResult(Intent.CreateChooser(intent, this.Resources.GetString(2131952375)), AccountCPActivity.SELECT_PROFILE_COVER);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00025F36 File Offset: 0x00024136
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689478, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00025F50 File Offset: 0x00024150
		private void PrepareUserProfileUI()
		{
			if (this.user != null)
			{
				this.mHeaderDisplayName.Text = this.user.FullName;
				this.mDisplayName.Text = this.user.FullName;
				this.mEmail.Text = this.user.Email;
				if (this.user.Bio != "")
				{
					this.mUserBio.Text = "\"" + this.user.Bio + "\"";
					this.bioLinesCount = this.mUserBio.MaxLines;
					this.mUserBio.Post(new Suffixer(this, this.mUserBio, 6, this.Resources.GetString(2131951949)));
				}
				else
				{
					this.mUserBio.Text = "\"" + this.Resources.GetString(2131952232) + "\"";
				}
				if (this.user.IsActivated == 0 && (this.user.GoogleUserID == "0" || this.user.GoogleUserID == ""))
				{
					Snackbar snack = Snackbar.Make(this.mContent, this.Resources.GetString(2131951654), -2);
					snack.SetAction(this.Resources.GetString(2131952323), delegate(View v)
					{
						ActivationMail.SendActivationMailApis(this, this.Resources.GetString(2131951706), this.user.Email);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951656), 0);
						snack.Dismiss();
					}).Show();
				}
				if (this.user.GoogleUserID == "" || this.user.GoogleUserID == "0")
				{
					this.mGoogleSyncText.Text = this.Resources.GetString(2131952036);
				}
				else
				{
					this.mChangePasswordContent.Visibility = ViewStates.Gone;
					this.mPasswordEditSeperator.Visibility = ViewStates.Gone;
					this.mGoogleSyncText.Text = this.Resources.GetString(2131952455);
				}
				if (this.user.ProfileImage != "")
				{
					Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).Into(this.mProfilePhoto);
				}
				else if (this.user.GoogleProfilePhotoUrl != "")
				{
					Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).Into(this.mProfilePhoto);
				}
				if (this.user.ProfileCover != "")
				{
					Glide.With(this).Load(Constants.ProfileCover(this.user.ProfileCover, this.user.UserID.ToString())).Into(this.mProfileCover);
				}
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00026240 File Offset: 0x00024440
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok)
			{
				if (requestCode == 1003)
				{
					Task<GoogleSignInAccount> tast = GoogleSignIn.GetSignedInAccountFromIntentAsync(data);
					this.mSyncGoogleLoader.Visibility = ViewStates.Visible;
					this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Gone;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.HandleLinkResult(tast);
					});
					return;
				}
				if (requestCode == 1004)
				{
					Task<GoogleSignInAccount> tast = GoogleSignIn.GetSignedInAccountFromIntentAsync(data);
					this.mSyncGoogleLoader.Visibility = ViewStates.Visible;
					this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Gone;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.HandleSyceResult(tast);
					});
					return;
				}
				if (requestCode == AccountCPActivity.SELECT_PROFILE_IMAGE)
				{
					this.mProfilePhotoLoader.Visibility = ViewStates.Visible;
					this.UploadeImageAsync(data.Data, 500, 500);
					return;
				}
				if (requestCode == AccountCPActivity.SELECT_PROFILE_COVER)
				{
					this.mProfileCoverLoader.Visibility = ViewStates.Visible;
					this.UploadeCoverAsync(data.Data, 1920, 1080);
				}
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0002634C File Offset: 0x0002454C
		public void UploadeImageAsync(Android.Net.Uri data, int requestedWidth, int requestedHeight)
		{
			AccountCPActivity.<UploadeImageAsync>d__60 <UploadeImageAsync>d__;
			<UploadeImageAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UploadeImageAsync>d__.<>4__this = this;
			<UploadeImageAsync>d__.data = data;
			<UploadeImageAsync>d__.requestedWidth = requestedWidth;
			<UploadeImageAsync>d__.requestedHeight = requestedHeight;
			<UploadeImageAsync>d__.<>1__state = -1;
			<UploadeImageAsync>d__.<>t__builder.Start<AccountCPActivity.<UploadeImageAsync>d__60>(ref <UploadeImageAsync>d__);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002639C File Offset: 0x0002459C
		public void UploadeCoverAsync(Android.Net.Uri data, int requestedWidth, int requestedHeight)
		{
			AccountCPActivity.<UploadeCoverAsync>d__61 <UploadeCoverAsync>d__;
			<UploadeCoverAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UploadeCoverAsync>d__.<>4__this = this;
			<UploadeCoverAsync>d__.data = data;
			<UploadeCoverAsync>d__.requestedWidth = requestedWidth;
			<UploadeCoverAsync>d__.requestedHeight = requestedHeight;
			<UploadeCoverAsync>d__.<>1__state = -1;
			<UploadeCoverAsync>d__.<>t__builder.Start<AccountCPActivity.<UploadeCoverAsync>d__61>(ref <UploadeCoverAsync>d__);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000263EC File Offset: 0x000245EC
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

		// Token: 0x06000889 RID: 2185 RVA: 0x00026440 File Offset: 0x00024640
		public void DeleteProfilePhoto()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/delete_pofile_photo.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a == "DONE")
					{
						this.user.ProfileImage = "";
						UsersViewModel.SaveUser(this.user);
						this.mProfilePhoto.SetImageResource(2131230965);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952309), 0);
					}
					else
					{
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952415), 0);
					}
				}
				catch
				{
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131952259), 0);
				}
			};
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000264AC File Offset: 0x000246AC
		public void DeleteProfileCover()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/delete_pofile_cover.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					string a = JsonConvert.DeserializeObject<string>(@string);
					if (a == "DONE")
					{
						this.user.ProfileCover = "";
						UsersViewModel.SaveUser(this.user);
						this.Recreate();
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952308), 0);
					}
					else
					{
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952415), 0);
					}
				}
				catch
				{
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131952259), 0);
				}
			};
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00026518 File Offset: 0x00024718
		private void GoogleSyceAccount(GoogleSignInAccount acct)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/google_account_sync.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"GoogleId",
					acct.Id
				},
				{
					"GoogleDisplayName",
					acct.DisplayName
				},
				{
					"GoogleEmail",
					acct.Email
				},
				{
					"GooglePhotoUrl",
					(acct.PhotoUrl == null) ? "" : acct.PhotoUrl.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(@string);
					base.RunOnUiThread(delegate()
					{
						UsersViewModel.SaveUser(userResponse.data);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952604), 0);
						this.Recreate();
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mSyncGoogleLoader.Visibility = ViewStates.Gone;
						this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Visible;
					});
				}
			};
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000265DC File Offset: 0x000247DC
		private void GoogleLinkAccount(GoogleSignInAccount acct)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/google_account_link.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"GoogleId",
					acct.Id
				},
				{
					"GoogleDisplayName",
					acct.DisplayName
				},
				{
					"GoogleEmail",
					acct.Email
				},
				{
					"GooglePhotoUrl",
					(acct.PhotoUrl == null) ? "" : acct.PhotoUrl.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(@string);
					base.RunOnUiThread(delegate()
					{
						if (userResponse.message == "GOOGLE_ACCOUNT_ALREADY_LINKED")
						{
							this.mSyncGoogleLoader.Visibility = ViewStates.Gone;
							this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Visible;
							CustomizedToast.ShowToast(this, this.Resources.GetString(2131952463), 0);
							return;
						}
						UsersViewModel.SaveUser(userResponse.data);
						this.Recreate();
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mSyncGoogleLoader.Visibility = ViewStates.Gone;
						this.mSyncGoogleLoaderIcon.Visibility = ViewStates.Visible;
					});
				}
			};
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000266A0 File Offset: 0x000248A0
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			if (itemId == 2131361808)
			{
				if (this.user != null)
				{
					if (this.user.ProfileCover == "")
					{
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131952238), 0);
					}
					else
					{
						this.DeleteProfileCover();
					}
				}
				return true;
			}
			if (itemId != 2131361809)
			{
				return base.OnOptionsItemSelected(item);
			}
			if (this.user != null)
			{
				if (this.user.ProfileImage == "" && this.user.GoogleProfilePhotoUrl == "")
				{
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131952238), 0);
				}
				else
				{
					this.DeleteProfilePhoto();
				}
			}
			return true;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00026778 File Offset: 0x00024978
		public void UpdateLibraryViewAllowance(int toggle)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/toggle_library_view_allowance.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString()
				},
				{
					"AllowLibraryView",
					toggle.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				this.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						string a = JsonConvert.DeserializeObject<string>(@string);
						if (a == "DONE")
						{
							this.user.AllowLibraryView = toggle;
							UsersViewModel.SaveUser(this.user);
						}
					}
					catch
					{
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951821), 0);
					}
				});
			};
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0002680C File Offset: 0x00024A0C
		public void UpdateGender(string gender)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/update_gender.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString()
				},
				{
					"NewGender",
					gender
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				this.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						string a = JsonConvert.DeserializeObject<string>(@string);
						if (a == "DONE")
						{
							this.user.Gender = gender;
							UsersViewModel.SaveUser(this.user);
						}
					}
					catch
					{
						if (this.user.Gender == "MALE")
						{
							this.mGenderMale.Checked = true;
						}
						else if (this.user.Gender == "FEMALE")
						{
							this.mGenderFemale.Checked = true;
						}
						else
						{
							this.mGenderNotSpecified.Checked = true;
						}
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951821), 0);
					}
				});
			};
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x0400058C RID: 1420
		private UsersModel user;

		// Token: 0x0400058D RID: 1421
		private int userId;

		// Token: 0x0400058E RID: 1422
		private View mPasswordEditSeperator;

		// Token: 0x0400058F RID: 1423
		private ImageView mProfileCover;

		// Token: 0x04000590 RID: 1424
		private ImageView mSelectProfilePhoto;

		// Token: 0x04000591 RID: 1425
		private ImageView mSelectProfileCover;

		// Token: 0x04000592 RID: 1426
		private ImageView mChangeFullName;

		// Token: 0x04000593 RID: 1427
		private ImageView mChangePassword;

		// Token: 0x04000594 RID: 1428
		private ImageView mSyncGoogleLoaderIcon;

		// Token: 0x04000595 RID: 1429
		private CircleImageView mProfilePhoto;

		// Token: 0x04000596 RID: 1430
		private AppCompatCheckBox mAllowLibraryViewToggle;

		// Token: 0x04000597 RID: 1431
		private Button mBioEditBtn;

		// Token: 0x04000598 RID: 1432
		private Button mSignOut;

		// Token: 0x04000599 RID: 1433
		private TextView mHeaderDisplayName;

		// Token: 0x0400059A RID: 1434
		private TextView mMembership;

		// Token: 0x0400059B RID: 1435
		private TextView mDisplayName;

		// Token: 0x0400059C RID: 1436
		private TextView mEmail;

		// Token: 0x0400059D RID: 1437
		private TextView mUserBio;

		// Token: 0x0400059E RID: 1438
		private TextView mCommentsCount;

		// Token: 0x0400059F RID: 1439
		private TextView mRepliesCount;

		// Token: 0x040005A0 RID: 1440
		private TextView mRatingsCount;

		// Token: 0x040005A1 RID: 1441
		private TextView mGoogleSyncText;

		// Token: 0x040005A2 RID: 1442
		private SwipeRefreshLayout mRefreshLoader;

		// Token: 0x040005A3 RID: 1443
		private ImageView mPremiumMark;

		// Token: 0x040005A4 RID: 1444
		private FrameLayout mSyncGoogle;

		// Token: 0x040005A5 RID: 1445
		private FrameLayout mProfilePhotoLoader;

		// Token: 0x040005A6 RID: 1446
		private RelativeLayout mContent;

		// Token: 0x040005A7 RID: 1447
		private RelativeLayout mChangePasswordContent;

		// Token: 0x040005A8 RID: 1448
		private ProgressBar mProfileCoverLoader;

		// Token: 0x040005A9 RID: 1449
		private ProgressBar mSyncGoogleLoader;

		// Token: 0x040005AA RID: 1450
		private RadioButton mGenderMale;

		// Token: 0x040005AB RID: 1451
		private RadioButton mGenderFemale;

		// Token: 0x040005AC RID: 1452
		private RadioButton mGenderNotSpecified;

		// Token: 0x040005AD RID: 1453
		private GoogleSignInClient mGoogleSignInClient;

		// Token: 0x040005AE RID: 1454
		private static readonly int SELECT_PROFILE_IMAGE = 1;

		// Token: 0x040005AF RID: 1455
		private static readonly int SELECT_PROFILE_COVER = 2;

		// Token: 0x040005B0 RID: 1456
		private int bioLinesCount = 1;

		// Token: 0x040005B1 RID: 1457
		private bool isBiographyExpanded;

		// Token: 0x040005B2 RID: 1458
		private const int RC_SIGN_LINK = 1003;

		// Token: 0x040005B3 RID: 1459
		private const int RC_SIGN_IN_SYCE = 1004;
	}
}
