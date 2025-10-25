using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.Content;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Text;
using Android.Text.Method;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Google.Android.Material.Snackbar;
using Google.Android.Material.TextField;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A9 RID: 169
	public class SignupFragment : Fragment
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x0001CF2C File Offset: 0x0001B12C
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558459, container, false);
			this.mUserName = this.view.FindViewById<EditText>(2131362894);
			this.mUserName.SetFilters(new IInputFilter[]
			{
				new UsernameFilter()
			});
			this.mFullName = this.view.FindViewById<EditText>(2131362881);
			this.mFullName.SetFilters(new IInputFilter[]
			{
				new FullnameFilter()
			});
			this.mEmail = this.view.FindViewById<EditText>(2131362879);
			this.mEmail.SetFilters(new IInputFilter[]
			{
				new EmailFilter()
			});
			this.mPassword = this.view.FindViewById<EditText>(2131362887);
			this.mPassword.TransformationMethod = new PasswordTransformationMethod();
			this.mPasswordConfirm = this.view.FindViewById<EditText>(2131362888);
			this.mPasswordConfirm.TransformationMethod = new PasswordTransformationMethod();
			this.mRegisterButton = this.view.FindViewById<FrameLayout>(2131362897);
			this.mRegisterLoader = this.view.FindViewById<FrameLayout>(2131362898);
			this.mRegisterText = this.view.FindViewById<TextView>(2131362900);
			this.mSigninBtn = this.view.FindViewById<TextView>(2131362885);
			this.mUserNameTIL = this.view.FindViewById<TextInputLayout>(2131362895);
			this.mFullNameTIL = this.view.FindViewById<TextInputLayout>(2131362882);
			this.mEmailTIL = this.view.FindViewById<TextInputLayout>(2131362880);
			this.mPasswordTIL = this.view.FindViewById<TextInputLayout>(2131362890);
			this.mPasswordConfirmTIL = this.view.FindViewById<TextInputLayout>(2131362889);
			this.mScroller = this.view.FindViewById<ScrollView>(2131363069);
			this.mTermsCheckBox = this.view.FindViewById<CheckBox>(2131361812);
			SpannableStringBuilder spannableStringBuilder = new SpannableStringBuilder();
			spannableStringBuilder.Append(base.Resources.GetString(2131952004) + " ");
			int start = spannableStringBuilder.Length();
			spannableStringBuilder.Append(base.Resources.GetString(2131952459) + " ");
			spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder.SetSpan(new SignupFragment.TermsOnClick(this.view.Context), start, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder.Append(base.Resources.GetString(2131951689));
			int start2 = spannableStringBuilder.Length();
			spannableStringBuilder.Append(base.Resources.GetString(2131952306));
			spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start2, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder.SetSpan(new SignupFragment.PrivacyOnClick(this.view.Context), start2, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder.Append(".");
			this.mTermsCheckBox.MovementMethod = LinkMovementMethod.Instance;
			this.mTermsCheckBox.SetText(spannableStringBuilder, TextView.BufferType.Spannable);
			if (SharedPreferencesSaves.IntSharedPreferencesGet("RegistrationStatus") != 0)
			{
				Bundle bundle = new Bundle();
				bundle.PutString("DialogTitle", base.Resources.GetString(2131951834));
				bundle.PutString("DialogMessage", base.Resources.GetString(2131952329));
				PageClose pageClose = new PageClose();
				FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
				pageClose.Arguments = bundle;
				pageClose.Show(transaction, "DialogPopupMessage");
			}
			this.mRegisterButton.Click += this.MRegisterButton_Click;
			this.mSigninBtn.Click += this.MSigninBtn_Click;
			return this.view;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001D2D8 File Offset: 0x0001B4D8
		private void MSigninBtn_Click(object sender, EventArgs e)
		{
			FragmentTransaction fragmentTransaction = base.ParentFragmentManager.BeginTransaction();
			fragmentTransaction.SetCustomAnimations(17432576, 17432577);
			fragmentTransaction.Replace(2131362434, new LoginFragment(), "LogIN");
			fragmentTransaction.AddToBackStack(null);
			fragmentTransaction.Commit();
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0001D328 File Offset: 0x0001B528
		private void MRegisterButton_Click(object sender, EventArgs e)
		{
			if (SharedPreferencesSaves.IntSharedPreferencesGet("RegistrationStatus") != 0)
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952329), 0);
				return;
			}
			this.mUserNameTIL.Error = null;
			this.mFullNameTIL.Error = null;
			this.mEmailTIL.Error = null;
			this.mPasswordTIL.Error = null;
			this.mPasswordConfirmTIL.Error = null;
			this.mUserNameTIL.ErrorEnabled = false;
			this.mFullNameTIL.ErrorEnabled = false;
			this.mEmailTIL.ErrorEnabled = false;
			this.mPasswordTIL.ErrorEnabled = false;
			this.mPasswordConfirmTIL.ErrorEnabled = false;
			this.mTermsCheckBox.Error = null;
			if (this.mUserName.Text == "" && this.mFullName.Text == "" && this.mEmail.Text == "" && this.mPassword.Text == "" && this.mPasswordConfirm.Text == "")
			{
				this.mUserNameTIL.ErrorEnabled = true;
				this.mFullNameTIL.ErrorEnabled = true;
				this.mEmailTIL.ErrorEnabled = true;
				this.mPasswordTIL.ErrorEnabled = true;
				this.mPasswordConfirmTIL.ErrorEnabled = true;
				this.mUserNameTIL.Error = base.Resources.GetString(2131952465);
				this.mFullNameTIL.Error = base.Resources.GetString(2131952465);
				this.mEmailTIL.Error = base.Resources.GetString(2131952465);
				this.mPasswordTIL.Error = base.Resources.GetString(2131952465);
				this.mPasswordConfirmTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mUserName.Text == "")
			{
				this.mUserNameTIL.ErrorEnabled = true;
				this.mUserNameTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mUserName.Text.Contains(" "))
			{
				this.mUserNameTIL.ErrorEnabled = true;
				this.mUserNameTIL.Error = base.Resources.GetString(2131952424);
				return;
			}
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
			if (this.mPassword.Text == "")
			{
				this.mPasswordTIL.ErrorEnabled = true;
				this.mPasswordTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mPasswordConfirm.Text == "")
			{
				this.mPasswordConfirmTIL.ErrorEnabled = true;
				this.mPasswordConfirmTIL.Error = base.Resources.GetString(2131952465);
				return;
			}
			if (this.mUserName.Text.Length < 3)
			{
				this.mUserNameTIL.ErrorEnabled = true;
				this.mUserNameTIL.Error = base.Resources.GetString(2131952138);
				return;
			}
			if (this.mFullName.Text.Length < 3)
			{
				this.mFullNameTIL.ErrorEnabled = true;
				this.mFullNameTIL.Error = base.Resources.GetString(2131952138);
				return;
			}
			if (this.mPassword.Text.Length < 5 || this.mPasswordConfirm.Text.Length < 5)
			{
				this.mPasswordTIL.ErrorEnabled = true;
				this.mPasswordConfirmTIL.ErrorEnabled = true;
				this.mPasswordTIL.Error = base.Resources.GetString(2131952317);
				this.mPasswordConfirmTIL.Error = base.Resources.GetString(2131952317);
				return;
			}
			if (!SignupFragment.IsEmailFormatValid(this.mEmail.Text))
			{
				this.mEmailTIL.ErrorEnabled = true;
				this.mEmailTIL.Error = base.Resources.GetString(2131952011);
				return;
			}
			if (this.mPasswordConfirm.Text != this.mPassword.Text)
			{
				this.mPasswordTIL.ErrorEnabled = true;
				this.mPasswordConfirmTIL.ErrorEnabled = true;
				this.mPasswordTIL.Error = base.Resources.GetString(2131952288);
				this.mPasswordConfirmTIL.Error = base.Resources.GetString(2131952288);
				return;
			}
			if (!this.mTermsCheckBox.Checked)
			{
				this.mTermsCheckBox.Error = base.Resources.GetString(2131952465);
				return;
			}
			this.mRegisterLoader.Visibility = ViewStates.Visible;
			this.mRegisterText.Text = "";
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.Signup();
			});
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0001D890 File Offset: 0x0001BA90
		private void Signup()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("users/register.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"Username",
					this.mUserName.Text.ToLower()
				},
				{
					"FullName",
					this.mFullName.Text
				},
				{
					"Password",
					this.mPassword.Text
				},
				{
					"Email",
					this.mEmail.Text.ToLower()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object ss, UploadValuesCompletedEventArgs ee)
			{
				base.Activity.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(ee.Result);
						UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(@string);
						if (userResponse.code == 1)
						{
							ActivationMail.SendActivationMailApis(this.view.Context, this.Resources.GetString(2131951706), this.mEmail.Text);
							UsersViewModel.SaveUser(userResponse.data);
							Bundle bundle = new Bundle();
							bundle.PutString("UserId", userResponse.data.UserID.ToString());
							bundle.PutString("UserName", userResponse.data.UserName);
							bundle.PutString("FullName", userResponse.data.FullName);
							bundle.PutString("Password", userResponse.data.Password);
							FragmentTransaction fragmentTransaction = this.ParentFragmentManager.BeginTransaction();
							SignupSetPhotoFragment signupSetPhotoFragment = new SignupSetPhotoFragment();
							fragmentTransaction.SetCustomAnimations(17432576, 17432577);
							fragmentTransaction.Replace(2131362434, signupSetPhotoFragment, "SignupSetPhotoFragment");
							signupSetPhotoFragment.Arguments = bundle;
							fragmentTransaction.Commit();
						}
						else if (userResponse.message == "USERNAME_EXISTS")
						{
							this.mUserNameTIL.ErrorEnabled = true;
							this.mUserNameTIL.Error = this.Resources.GetString(2131952558);
						}
						else if (userResponse.message == "EMAIL_EXISTS")
						{
							this.mEmailTIL.ErrorEnabled = true;
							this.mEmailTIL.Error = this.Resources.GetString(2131951892);
						}
						this.mRegisterLoader.Visibility = ViewStates.Gone;
						this.mRegisterText.Text = this.Resources.GetString(2131951835);
					}
					catch
					{
						this.mRegisterLoader.Visibility = ViewStates.Gone;
						this.mRegisterText.Text = this.Resources.GetString(2131951835);
						Snackbar snackbar = Snackbar.Make(this.view, 2131951821, -2);
						snackbar.SetAction(2131952343, delegate(View v)
						{
							this.mRegisterText.Text = "";
							this.mRegisterLoader.Visibility = ViewStates.Visible;
							ThreadPool.QueueUserWorkItem(delegate(object o)
							{
								this.Signup();
							});
						}).Show();
					}
				});
			};
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001D948 File Offset: 0x0001BB48
		public static bool IsEmailFormatValid(string eMail)
		{
			return eMail.Substring(eMail.Length - 4).ToLower() == ".com".ToLower() && eMail.Contains("@") && (eMail.ToLower().Contains("@gmail.com".ToLower()) || eMail.ToLower().Contains("@yahoo.com".ToLower()) || eMail.ToLower().Contains("@outlook.com".ToLower()) || eMail.ToLower().Contains("@hotmail.com".ToLower()));
		}

		// Token: 0x04000490 RID: 1168
		private View view;

		// Token: 0x04000491 RID: 1169
		private EditText mUserName;

		// Token: 0x04000492 RID: 1170
		private EditText mFullName;

		// Token: 0x04000493 RID: 1171
		private EditText mEmail;

		// Token: 0x04000494 RID: 1172
		private EditText mPassword;

		// Token: 0x04000495 RID: 1173
		private EditText mPasswordConfirm;

		// Token: 0x04000496 RID: 1174
		private TextInputLayout mUserNameTIL;

		// Token: 0x04000497 RID: 1175
		private TextInputLayout mFullNameTIL;

		// Token: 0x04000498 RID: 1176
		private TextInputLayout mEmailTIL;

		// Token: 0x04000499 RID: 1177
		private TextInputLayout mPasswordTIL;

		// Token: 0x0400049A RID: 1178
		private TextInputLayout mPasswordConfirmTIL;

		// Token: 0x0400049B RID: 1179
		private FrameLayout mRegisterLoader;

		// Token: 0x0400049C RID: 1180
		private FrameLayout mRegisterButton;

		// Token: 0x0400049D RID: 1181
		private TextView mRegisterText;

		// Token: 0x0400049E RID: 1182
		private TextView mSigninBtn;

		// Token: 0x0400049F RID: 1183
		private ScrollView mScroller;

		// Token: 0x040004A0 RID: 1184
		private CheckBox mTermsCheckBox;

		// Token: 0x02000137 RID: 311
		private class TermsOnClick : ClickableSpan
		{
			// Token: 0x06000BAD RID: 2989 RVA: 0x0003ECE0 File Offset: 0x0003CEE0
			public TermsOnClick(Context context)
			{
				this.context = context;
			}

			// Token: 0x06000BAE RID: 2990 RVA: 0x0003ECEF File Offset: 0x0003CEEF
			public override void OnClick(View widget)
			{
				this.context.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse("https://animeify.net/terms")));
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x0003ED15 File Offset: 0x0003CF15
			public override void UpdateDrawState(TextPaint ds)
			{
				base.UpdateDrawState(ds);
				ds.UnderlineText = true;
			}

			// Token: 0x04003093 RID: 12435
			private Context context;
		}

		// Token: 0x02000138 RID: 312
		private class PrivacyOnClick : ClickableSpan
		{
			// Token: 0x06000BB0 RID: 2992 RVA: 0x0003ED25 File Offset: 0x0003CF25
			public PrivacyOnClick(Context context)
			{
				this.context = context;
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x0003ED34 File Offset: 0x0003CF34
			public override void OnClick(View widget)
			{
				this.context.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse("https://animeify.net/privacy")));
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x0003ED15 File Offset: 0x0003CF15
			public override void UpdateDrawState(TextPaint ds)
			{
				base.UpdateDrawState(ds);
				ds.UnderlineText = true;
			}

			// Token: 0x04003094 RID: 12436
			private Context context;
		}
	}
}
