using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.Content;
using Android.OS;
using Android.Text.Method;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Google.Android.Material.TextField;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x0200009F RID: 159
	public class DialogUpdateUserPassword : DialogFragment
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x00014BE4 File Offset: 0x00012DE4
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558518, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mOldPassword = this.view.FindViewById<EditText>(2131363051);
			this.mOldPassword.TransformationMethod = new PasswordTransformationMethod();
			this.mNewPassword = this.view.FindViewById<EditText>(2131363054);
			this.mNewPassword.TransformationMethod = new PasswordTransformationMethod();
			this.mNewPasswordConfirm = this.view.FindViewById<EditText>(2131363056);
			this.mNewPasswordConfirm.TransformationMethod = new PasswordTransformationMethod();
			this.mOldPasswordTIL = this.view.FindViewById<TextInputLayout>(2131363053);
			this.mNewPasswordTIL = this.view.FindViewById<TextInputLayout>(2131363059);
			this.mNewPasswordConfirmTIL = this.view.FindViewById<TextInputLayout>(2131363057);
			this.mChangeTxt = this.view.FindViewById<TextView>(2131363042);
			this.mChangeButton = this.view.FindViewById<FrameLayout>(2131363041);
			this.mChangeLoader = this.view.FindViewById<FrameLayout>(2131363048);
			this.mChangeButton.Click += this.MChangeButton_Click;
			return this.view;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00014D54 File Offset: 0x00012F54
		private void MChangeButton_Click(object sender, EventArgs e)
		{
			this.mOldPasswordTIL.Error = null;
			this.mNewPasswordTIL.Error = null;
			this.mNewPasswordConfirmTIL.Error = null;
			this.mOldPasswordTIL.ErrorEnabled = false;
			this.mNewPasswordTIL.ErrorEnabled = false;
			this.mNewPasswordConfirmTIL.ErrorEnabled = false;
			if (this.mOldPassword.Text != this.user.Password)
			{
				this.mOldPasswordTIL.ErrorEnabled = true;
				this.mOldPasswordTIL.Error = base.Resources.GetString(2131952269);
				return;
			}
			if (this.mNewPassword.Text == "")
			{
				this.mNewPasswordTIL.ErrorEnabled = true;
				this.mNewPasswordTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mNewPasswordConfirm.Text == "")
			{
				this.mNewPasswordConfirmTIL.ErrorEnabled = true;
				this.mNewPasswordConfirmTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mNewPassword.Text.Length < 5 || this.mNewPasswordConfirm.Text.Length < 5)
			{
				this.mNewPasswordTIL.ErrorEnabled = true;
				this.mNewPasswordConfirmTIL.ErrorEnabled = true;
				this.mNewPasswordTIL.Error = base.Resources.GetString(2131952317);
				this.mNewPasswordConfirmTIL.Error = base.Resources.GetString(2131952317);
				return;
			}
			if (this.mNewPassword.Text != this.mNewPasswordConfirm.Text)
			{
				this.mNewPasswordTIL.ErrorEnabled = true;
				this.mNewPasswordConfirmTIL.ErrorEnabled = true;
				this.mNewPasswordTIL.Error = base.Resources.GetString(2131952288);
				this.mNewPasswordConfirmTIL.Error = base.Resources.GetString(2131952288);
				return;
			}
			this.mChangeLoader.Visibility = ViewStates.Visible;
			this.mChangeTxt.Text = "";
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.UpdatePassword(this.mNewPassword.Text);
			});
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00014F7C File Offset: 0x0001317C
		public void UpdatePassword(string newPassword)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("users/update_password.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString()
				},
				{
					"NewPassword",
					newPassword
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				this.Activity.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						string a = JsonConvert.DeserializeObject<string>(@string);
						if (a == "DONE")
						{
							this.user.Password = newPassword;
							UsersViewModel.SaveUser(this.user);
							this.IsEditMade = true;
							CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952604), 0);
							this.Dismiss();
						}
						else
						{
							this.mChangeLoader.Visibility = ViewStates.Gone;
							this.mChangeTxt.Text = this.view.Resources.GetString(2131951758);
							CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952415), 0);
						}
					}
					catch
					{
						this.mChangeLoader.Visibility = ViewStates.Gone;
						this.mChangeTxt.Text = this.view.Resources.GetString(2131951758);
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952259), 0);
					}
				});
			};
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001500A File Offset: 0x0001320A
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			if (this.IsEditMade)
			{
				base.Activity.Recreate();
			}
		}

		// Token: 0x04000386 RID: 902
		private View view;

		// Token: 0x04000387 RID: 903
		private EditText mOldPassword;

		// Token: 0x04000388 RID: 904
		private EditText mNewPassword;

		// Token: 0x04000389 RID: 905
		private EditText mNewPasswordConfirm;

		// Token: 0x0400038A RID: 906
		private TextInputLayout mOldPasswordTIL;

		// Token: 0x0400038B RID: 907
		private TextInputLayout mNewPasswordTIL;

		// Token: 0x0400038C RID: 908
		private TextInputLayout mNewPasswordConfirmTIL;

		// Token: 0x0400038D RID: 909
		private FrameLayout mChangeLoader;

		// Token: 0x0400038E RID: 910
		private FrameLayout mChangeButton;

		// Token: 0x0400038F RID: 911
		private TextView mChangeTxt;

		// Token: 0x04000390 RID: 912
		private bool IsEditMade;

		// Token: 0x04000391 RID: 913
		private UsersModel user;

		// Token: 0x04000392 RID: 914
		private int userId;
	}
}
