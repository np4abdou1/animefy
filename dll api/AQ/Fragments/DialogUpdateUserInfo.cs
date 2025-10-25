using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.Content;
using Android.OS;
using Android.Text;
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
	// Token: 0x0200009E RID: 158
	public class DialogUpdateUserInfo : DialogFragment
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x000146DC File Offset: 0x000128DC
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558520, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mFullName = this.view.FindViewById<EditText>(2131363044);
			this.mFullName.SetFilters(new IInputFilter[]
			{
				new FullnameFilter()
			});
			this.mEmail = this.view.FindViewById<EditText>(2131363038);
			this.mEmail.SetFilters(new IInputFilter[]
			{
				new EmailFilter()
			});
			if (this.user != null)
			{
				this.mFullName.Text = this.user.FullName;
				this.mEmail.Text = this.user.Email;
				this.mCurrentEmail = this.mEmail.Text;
				this.mFullName.SetSelection(this.user.FullName.Length);
				this.mEmail.SetSelection(this.user.Email.Length);
			}
			this.mFullNameTIL = this.view.FindViewById<TextInputLayout>(2131363045);
			this.mEmailTIL = this.view.FindViewById<TextInputLayout>(2131363039);
			this.mChangeTxt = this.view.FindViewById<TextView>(2131363042);
			this.mChangeButton = this.view.FindViewById<FrameLayout>(2131363041);
			this.mChangeLoader = this.view.FindViewById<FrameLayout>(2131363048);
			this.mChangeButton.Click += this.MChangeButton_Click;
			this.mEmail.TextChanged += this.MEmail_TextChanged;
			this.mFullName.TextChanged += this.MFullName_TextChanged;
			return this.view;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000148CA File Offset: 0x00012ACA
		private void MFullName_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.mFullNameTIL.Error = null;
			this.mFullNameTIL.ErrorEnabled = false;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000148E4 File Offset: 0x00012AE4
		private void MEmail_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.mEmailTIL.Error = null;
			this.mEmailTIL.ErrorEnabled = false;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00014900 File Offset: 0x00012B00
		private void MChangeButton_Click(object sender, EventArgs e)
		{
			this.mFullNameTIL.Error = null;
			this.mEmailTIL.Error = null;
			this.mFullNameTIL.ErrorEnabled = false;
			this.mEmailTIL.ErrorEnabled = false;
			if (this.mFullName.Text == "")
			{
				this.mFullNameTIL.ErrorEnabled = true;
				this.mFullNameTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mEmail.Text == "")
			{
				this.mEmailTIL.ErrorEnabled = true;
				this.mEmailTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mFullName.Text.Length < 3)
			{
				this.mFullNameTIL.ErrorEnabled = true;
				this.mFullNameTIL.Error = base.Resources.GetString(2131952138);
				return;
			}
			if (!DialogUpdateUserInfo.IsEmailFormatValid(this.mEmail.Text))
			{
				this.mEmailTIL.ErrorEnabled = true;
				this.mEmailTIL.Error = base.Resources.GetString(2131952011);
				return;
			}
			this.mChangeTxt.Text = "";
			this.mChangeLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.UpdateInfo(this.mFullName.Text, this.mEmail.Text);
			});
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00014A60 File Offset: 0x00012C60
		public void UpdateInfo(string fullname, string email)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("users/update_info.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString()
				},
				{
					"NewFullname",
					fullname
				},
				{
					"NewEmail",
					email.ToLower()
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
						this.user.FullName = fullname;
						this.IsEditMade = true;
						if (this.mCurrentEmail != this.mEmail.Text && a == "EMAIL_ALEADY_EXISTS")
						{
							this.mEmailTIL.ErrorEnabled = true;
							this.mEmailTIL.Error = this.Resources.GetString(2131951892);
							this.mChangeTxt.Text = this.view.Resources.GetString(2131951758);
							this.mChangeLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.user.Email = email;
							UsersViewModel.SaveUser(this.user);
						}
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952604), 0);
						this.Dismiss();
					}
					catch
					{
						this.mChangeTxt.Text = this.view.Resources.GetString(2131951758);
						this.mChangeLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952259), 0);
					}
				});
			};
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00014B0C File Offset: 0x00012D0C
		public static bool IsEmailFormatValid(string eMail)
		{
			return eMail.Substring(eMail.Length - 4).ToLower() == ".com".ToLower() && eMail.Contains("@") && (eMail.ToLower().Contains("@gmail.com".ToLower()) || eMail.ToLower().Contains("@yahoo.com".ToLower()) || eMail.ToLower().Contains("@outlook.com".ToLower()) || eMail.ToLower().Contains("@hotmail.com".ToLower()));
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00014BA9 File Offset: 0x00012DA9
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			if (this.IsEditMade)
			{
				base.Activity.Recreate();
			}
		}

		// Token: 0x0400037A RID: 890
		private View view;

		// Token: 0x0400037B RID: 891
		private EditText mFullName;

		// Token: 0x0400037C RID: 892
		private EditText mEmail;

		// Token: 0x0400037D RID: 893
		private TextInputLayout mFullNameTIL;

		// Token: 0x0400037E RID: 894
		private TextInputLayout mEmailTIL;

		// Token: 0x0400037F RID: 895
		private FrameLayout mChangeLoader;

		// Token: 0x04000380 RID: 896
		private FrameLayout mChangeButton;

		// Token: 0x04000381 RID: 897
		private string mCurrentEmail;

		// Token: 0x04000382 RID: 898
		private bool IsEditMade;

		// Token: 0x04000383 RID: 899
		private TextView mChangeTxt;

		// Token: 0x04000384 RID: 900
		private UsersModel user;

		// Token: 0x04000385 RID: 901
		private int userId;
	}
}
