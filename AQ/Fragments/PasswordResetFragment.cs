using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;
using Google.Android.Material.TextField;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A8 RID: 168
	public class PasswordResetFragment : DialogFragment
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.emailOrUsername = base.Arguments.GetString("EmailOrUserName", "");
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			inflater.Inflate(2131558456, container, false);
			this.Dialog.Window.SetSoftInputMode(SoftInput.AdjustResize);
			this.view = inflater.Inflate(2131558456, container, false);
			this.mEmailTypingFeild = this.view.FindViewById<EditText>(2131362865);
			this.mEmailTypingFeild.Text = this.emailOrUsername;
			this.mEmailTypingFeildTIL = this.view.FindViewById<TextInputLayout>(2131362866);
			this.mSendLoader = this.view.FindViewById<FrameLayout>(2131362867);
			this.mPasswordSendBtn = this.view.FindViewById<FrameLayout>(2131362864);
			this.mResetText = this.view.FindViewById<TextView>(2131362868);
			this.mPasswordSendBtn.Click += this.MPasswordSendBtn_Click;
			return this.view;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		private void MPasswordSendBtn_Click(object sender, EventArgs e)
		{
			this.mEmailTypingFeildTIL.Error = null;
			this.mEmailTypingFeildTIL.ErrorEnabled = false;
			if (this.mEmailTypingFeild.Text == "")
			{
				this.mEmailTypingFeildTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			this.mResetText.Text = "";
			this.mSendLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.CreatSendNewPassword();
			});
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00014189 File Offset: 0x00012389
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
			base.OnActivityCreated(savedInstanceState);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001CE48 File Offset: 0x0001B048
		private void CreatSendNewPassword()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("users/mail_reset_password.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("EmailOrUsername", this.mEmailTypingFeild.Text.ToLower());
			nameValueCollection.Add("Lang", base.Resources.GetString(2131951706));
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, nameValueCollection);
			this.mClient.UploadValuesCompleted += delegate(object sender2, UploadValuesCompletedEventArgs e2)
			{
				base.Activity.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e2.Result);
						string a = JsonConvert.DeserializeObject<string>(@string);
						if (a == "DONE")
						{
							CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952286), 0);
							this.Dismiss();
						}
						else if (a == "USER_NOT_FOUND")
						{
							this.mEmailTypingFeildTIL.ErrorEnabled = true;
							this.mEmailTypingFeildTIL.Error = this.Resources.GetString(2131951893);
							this.mSendLoader.Visibility = ViewStates.Gone;
							this.mResetText.Text = this.Resources.GetString(2131952341);
						}
						else
						{
							CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951832), 0);
							this.mSendLoader.Visibility = ViewStates.Gone;
							this.mResetText.Text = this.Resources.GetString(2131952341);
						}
					}
					catch
					{
						this.mEmailTypingFeildTIL.ErrorEnabled = true;
						this.mEmailTypingFeildTIL.Error = this.Resources.GetString(2131952259);
						this.mSendLoader.Visibility = ViewStates.Gone;
						this.mResetText.Text = this.Resources.GetString(2131952341);
					}
				});
			};
		}

		// Token: 0x04000487 RID: 1159
		private View view;

		// Token: 0x04000488 RID: 1160
		private EditText mEmailTypingFeild;

		// Token: 0x04000489 RID: 1161
		private TextInputLayout mEmailTypingFeildTIL;

		// Token: 0x0400048A RID: 1162
		private FrameLayout mSendLoader;

		// Token: 0x0400048B RID: 1163
		private FrameLayout mPasswordSendBtn;

		// Token: 0x0400048C RID: 1164
		private TextView mResetText;

		// Token: 0x0400048D RID: 1165
		private WebClient mClient;

		// Token: 0x0400048E RID: 1166
		private Uri mUri;

		// Token: 0x0400048F RID: 1167
		private string emailOrUsername;
	}
}
