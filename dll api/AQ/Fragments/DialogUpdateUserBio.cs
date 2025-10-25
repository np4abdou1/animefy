using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x0200009D RID: 157
	public class DialogUpdateUserBio : DialogFragment
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x000143E0 File Offset: 0x000125E0
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558519, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mBioEditFeild = this.view.FindViewById<EditText>(2131362021);
			this.mChangeButton = this.view.FindViewById<FrameLayout>(2131363041);
			this.mChangeLoader = this.view.FindViewById<FrameLayout>(2131363048);
			this.mChangeTxt = this.view.FindViewById<TextView>(2131363042);
			this.mCharsCounter = this.view.FindViewById<TextView>(2131363040);
			if (this.user != null)
			{
				this.mBioEditFeild.Text = this.user.Bio;
				this.mBioEditFeild.SetSelection(this.user.Bio.Length);
				this.mCharsCounter.Text = base.Resources.GetString(2131951936) + " " + (DialogUpdateUserBio.BIO_LIMIT - this.mBioEditFeild.Text.Length).ToString();
			}
			this.mChangeButton.Click += this.MChangeButton_Click;
			this.mBioEditFeild.TextChanged += this.MBioEditFeild_TextChanged;
			return this.view;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001455C File Offset: 0x0001275C
		private void MBioEditFeild_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.mBioEditFeild.Text.Length >= 250)
			{
				return;
			}
			this.mCharsCounter.Text = base.Resources.GetString(2131951936) + " " + (DialogUpdateUserBio.BIO_LIMIT - this.mBioEditFeild.Text.Length).ToString();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000145C4 File Offset: 0x000127C4
		private void MChangeButton_Click(object sender, EventArgs e)
		{
			this.mChangeTxt.Visibility = ViewStates.Gone;
			this.mChangeLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.UpdateBio(this.mBioEditFeild.Text);
			});
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000145F0 File Offset: 0x000127F0
		public void UpdateBio(string bio)
		{
			bio = Regex.Replace(bio, "^\\s+$[\\r\\n]*", string.Empty, RegexOptions.Multiline);
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("users/update_bio.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					this.userId.ToString().ToString()
				},
				{
					"NewBio",
					bio
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
							this.user.Bio = bio;
							UsersViewModel.SaveUser(this.user);
							this.IsEditMade = true;
							this.mChangeTxt.Text = this.Resources.GetString(2131951886);
							this.mChangeLoader.Visibility = ViewStates.Gone;
							CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131952605), 0);
							this.Dismiss();
						}
						this.mChangeTxt.Text = this.Resources.GetString(2131951758);
						this.mChangeTxt.Visibility = ViewStates.Visible;
						this.mChangeLoader.Visibility = ViewStates.Gone;
					}
					catch
					{
						this.mChangeTxt.Text = this.Resources.GetString(2131951886);
						this.mChangeTxt.Visibility = ViewStates.Visible;
						this.mChangeLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951821), 0);
					}
				});
			};
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001469F File Offset: 0x0001289F
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			if (this.IsEditMade)
			{
				base.Activity.Recreate();
			}
		}

		// Token: 0x04000370 RID: 880
		private View view;

		// Token: 0x04000371 RID: 881
		private UsersModel user;

		// Token: 0x04000372 RID: 882
		private int userId;

		// Token: 0x04000373 RID: 883
		private EditText mBioEditFeild;

		// Token: 0x04000374 RID: 884
		private FrameLayout mChangeLoader;

		// Token: 0x04000375 RID: 885
		private FrameLayout mChangeButton;

		// Token: 0x04000376 RID: 886
		private TextView mChangeTxt;

		// Token: 0x04000377 RID: 887
		private TextView mCharsCounter;

		// Token: 0x04000378 RID: 888
		private bool IsEditMade;

		// Token: 0x04000379 RID: 889
		private static readonly int BIO_LIMIT = 250;
	}
}
