using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;
using Android.Gms.Auth.Api.SignIn;
using Android.OS;
using Android.Text.Method;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Google.Android.Material.Snackbar;
using Google.Android.Material.TextField;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A5 RID: 165
	public class LoginFragment : Fragment
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x00019EE0 File Offset: 0x000180E0
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558457, container, false);
			this.mLogin = this.view.FindViewById<FrameLayout>(2131362558);
			this.mLoginLoader = this.view.FindViewById<FrameLayout>(2131362560);
			this.mLoginText = this.view.FindViewById<TextView>(2131362564);
			this.mGglLogin = this.view.FindViewById<FrameLayout>(2131362446);
			this.mGglLoginLoader = this.view.FindViewById<FrameLayout>(2131362447);
			this.mGglLoginText = this.view.FindViewById<TextView>(2131362448);
			this.userNameField = this.view.FindViewById<EditText>(2131362565);
			this.passwordField = this.view.FindViewById<EditText>(2131362561);
			this.passwordField.TransformationMethod = new PasswordTransformationMethod();
			this.mForgotenPwd = this.view.FindViewById<TextView>(2131362562);
			this.mSignupBtn = this.view.FindViewById<TextView>(2131362559);
			this.mUserNameTIL = this.view.FindViewById<TextInputLayout>(2131362566);
			this.mPasswordTIL = this.view.FindViewById<TextInputLayout>(2131362563);
			GoogleSignInOptions options = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn).RequestEmail().Build();
			this.mGoogleSignInClient = GoogleSignIn.GetClient(base.Activity, options);
			this.mLogin.Click += this.loginButton_Click;
			this.mGglLogin.Click += this.MGglLogin_Click;
			this.mSignupBtn.Click += this.MSignupBtn_Click;
			this.passwordField.EditorAction += this.PasswordField_EditorAction;
			this.mForgotenPwd.Click += this.MForgotenPwd_Click;
			return this.view;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001A0B8 File Offset: 0x000182B8
		private void PasswordField_EditorAction(object sender, TextView.EditorActionEventArgs e)
		{
			if (e.ActionId == ImeAction.Go)
			{
				this.Login();
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001A0CC File Offset: 0x000182CC
		private void MForgotenPwd_Click(object sender, EventArgs e)
		{
			Bundle bundle = new Bundle();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			PasswordResetFragment passwordResetFragment = new PasswordResetFragment();
			bundle.PutString("EmailOrUserName", this.userNameField.Text.Replace(" ", ""));
			passwordResetFragment.Arguments = bundle;
			passwordResetFragment.Show(transaction, "PasswordResetFragment");
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001A12C File Offset: 0x0001832C
		public override void OnActivityResult(int requestCode, int resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (requestCode == 1002)
			{
				Task<GoogleSignInAccount> tast = GoogleSignIn.GetSignedInAccountFromIntentAsync(data);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.HandleSignInResult(tast);
				});
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001A178 File Offset: 0x00018378
		public void HandleSignInResult(Task<GoogleSignInAccount> tast)
		{
			try
			{
				GoogleSignInAccount result = tast.Result;
				this.GoogleSinging(result);
			}
			catch
			{
				base.Activity.RunOnUiThread(delegate()
				{
					this.mGglLoginText.Text = base.Resources.GetString(2131952406);
					this.mGglLoginLoader.Visibility = ViewStates.Gone;
					CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952044), 0);
				});
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001A1C0 File Offset: 0x000183C0
		private void loginButton_Click(object sender, EventArgs e)
		{
			this.Login();
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001A1C8 File Offset: 0x000183C8
		private void Login()
		{
			this.ResetUi();
			if (this.userNameField.Text == "" && this.passwordField.Text == "")
			{
				this.mUserNameTIL.ErrorEnabled = true;
				this.mPasswordTIL.ErrorEnabled = true;
				this.mUserNameTIL.Error = base.Resources.GetString(2131952465);
				this.mPasswordTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.userNameField.Text == "")
			{
				this.mUserNameTIL.ErrorEnabled = true;
				this.mUserNameTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.passwordField.Text == "")
			{
				this.mPasswordTIL.ErrorEnabled = true;
				this.mPasswordTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			this.mLoginText.Text = "";
			this.mLoginLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.Login(this.userNameField.Text, this.passwordField.Text);
			});
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001A304 File Offset: 0x00018504
		private void MGglLogin_Click(object sender, EventArgs e)
		{
			this.mGglLoginText.Text = "";
			this.mGglLoginLoader.Visibility = ViewStates.Visible;
			this.ResetUi();
			Intent signInIntent = this.mGoogleSignInClient.SignInIntent;
			this.StartActivityForResult(signInIntent, 1002);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001A34C File Offset: 0x0001854C
		private void ResetUi()
		{
			this.mUserNameTIL.Error = null;
			this.mPasswordTIL.Error = null;
			this.mUserNameTIL.ErrorEnabled = false;
			this.mPasswordTIL.ErrorEnabled = false;
			InputMethodManager inputMethodManager = (InputMethodManager)this.view.Context.GetSystemService("input_method");
			inputMethodManager.HideSoftInputFromWindow(this.userNameField.WindowToken, HideSoftInputFlags.NotAlways);
			inputMethodManager.HideSoftInputFromWindow(this.passwordField.WindowToken, HideSoftInputFlags.NotAlways);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001A3CC File Offset: 0x000185CC
		private void Login(string userName, string password)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("users/login.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserName", userName.ToLower());
			nameValueCollection.Add("Password", password);
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, nameValueCollection);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				base.Activity.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(@string);
						if (userResponse.code == 1)
						{
							UsersViewModel.SaveUser(userResponse.data);
							UsersModel.OnResumeLogin = true;
							this.Activity.Finish();
							this.Activity.OverridePendingTransition(2130772024, 2130772027);
						}
						else if (userResponse.message == "INCORRECT_USERNAME")
						{
							this.mUserNameTIL.ErrorEnabled = true;
							this.mUserNameTIL.Error = this.Resources.GetString(2131952047);
						}
						else if (userResponse.message == "INCORRECT_PASSWORD")
						{
							this.mPasswordTIL.ErrorEnabled = true;
							this.mPasswordTIL.Error = this.Resources.GetString(2131952046);
						}
					}
					catch
					{
						Snackbar snackbar = Snackbar.Make(this.view, 2131951821, -2);
						snackbar.SetAction(2131952343, delegate(View v)
						{
							this.mLoginText.Text = "";
							this.mLoginLoader.Visibility = ViewStates.Visible;
							ThreadPool.QueueUserWorkItem(delegate(object o)
							{
								this.Login(this.userNameField.Text, this.passwordField.Text);
							});
						}).Show();
					}
					this.mLoginText.Text = this.Resources.GetString(2131952043);
					this.mLoginLoader.Visibility = ViewStates.Gone;
				});
			};
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001A458 File Offset: 0x00018658
		private void GoogleSinging(GoogleSignInAccount acct)
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("users/google_signing.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("GoogleId", acct.Id);
			nameValueCollection.Add("GoogleDisplayName", acct.DisplayName);
			nameValueCollection.Add("GoogleEmail", acct.Email);
			nameValueCollection.Add("GooglePhotoUrl", (acct.PhotoUrl == null) ? "" : acct.PhotoUrl.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, nameValueCollection);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				base.Activity.RunOnUiThread(delegate()
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(@string);
					if (userResponse.code == 1)
					{
						UsersViewModel.SaveUser(userResponse.data);
						UsersModel.OnResumeLogin = true;
						this.Activity.Finish();
						this.Activity.OverridePendingTransition(2130772024, 2130772027);
					}
					this.mGglLoginLoader.Visibility = ViewStates.Gone;
					this.mGglLoginText.Text = this.Resources.GetString(2131952406);
				});
			};
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001A51C File Offset: 0x0001871C
		private void MSignupBtn_Click(object sender, EventArgs e)
		{
			FragmentTransaction fragmentTransaction = base.ParentFragmentManager.BeginTransaction();
			fragmentTransaction.SetCustomAnimations(17432576, 17432577);
			fragmentTransaction.Replace(2131362434, new SignupFragment(), "SignUP");
			fragmentTransaction.Commit();
		}

		// Token: 0x0400042B RID: 1067
		private View view;

		// Token: 0x0400042C RID: 1068
		private EditText userNameField;

		// Token: 0x0400042D RID: 1069
		private EditText passwordField;

		// Token: 0x0400042E RID: 1070
		private TextInputLayout mUserNameTIL;

		// Token: 0x0400042F RID: 1071
		private TextInputLayout mPasswordTIL;

		// Token: 0x04000430 RID: 1072
		private FrameLayout mLoginLoader;

		// Token: 0x04000431 RID: 1073
		private FrameLayout mGglLoginLoader;

		// Token: 0x04000432 RID: 1074
		private FrameLayout mLogin;

		// Token: 0x04000433 RID: 1075
		private FrameLayout mGglLogin;

		// Token: 0x04000434 RID: 1076
		private TextView mForgotenPwd;

		// Token: 0x04000435 RID: 1077
		private TextView mSignupBtn;

		// Token: 0x04000436 RID: 1078
		private TextView mLoginText;

		// Token: 0x04000437 RID: 1079
		private TextView mGglLoginText;

		// Token: 0x04000438 RID: 1080
		private WebClient mClient;

		// Token: 0x04000439 RID: 1081
		private Uri mUri;

		// Token: 0x0400043A RID: 1082
		private GoogleSignInClient mGoogleSignInClient;

		// Token: 0x0400043B RID: 1083
		private const int RC_SIGN_IN = 1002;
	}
}
