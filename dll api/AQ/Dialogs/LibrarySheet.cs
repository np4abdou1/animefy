using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Activities;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Google.Android.Material.BottomSheet;
using Newtonsoft.Json;

namespace AQ.Dialogs
{
	// Token: 0x020000B5 RID: 181
	public class LibrarySheet : RoundedBottomSheet
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00023A48 File Offset: 0x00021C48
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.detailsData = (AnimeDetails)base.Activity;
			this.mainId = this.detailsData.animeId;
			this.status = this.detailsData.status;
			this.type = this.detailsData.type;
			this.view = inflater.Inflate(2131558638, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mDetailsLibraryIcon = base.Activity.FindViewById<ImageView>(2131361944);
			this.mWatchCurrently = this.view.FindViewById<RelativeLayout>(2131363277);
			this.mWatchLater = this.view.FindViewById<RelativeLayout>(2131363285);
			this.mWatchDone = this.view.FindViewById<RelativeLayout>(2131363281);
			this.mWatchCurrentlyTick = this.view.FindViewById<ImageView>(2131363280);
			this.mWatchLaterTick = this.view.FindViewById<ImageView>(2131363287);
			this.mWatchDoneTick = this.view.FindViewById<ImageView>(2131363284);
			this.mWatchCurrentlyLoader = this.view.FindViewById<ProgressBar>(2131363278);
			this.mWatchLaterLoader = this.view.FindViewById<ProgressBar>(2131363286);
			this.mWatchDoneLoader = this.view.FindViewById<ProgressBar>(2131363282);
			if (this.status == "AIRING")
			{
				this.mWatchDone.Visibility = ViewStates.Gone;
			}
			if (this.type == "MOVIE")
			{
				this.mWatchCurrently.Visibility = ViewStates.Gone;
			}
			if (this.detailsData.animeDetails.Library.Library == "WATCH_CURRENTLY")
			{
				this.mWatchCurrentlyTick.SetImageResource(2131231227);
			}
			else if (this.detailsData.animeDetails.Library.Library == "WATCH_LATER")
			{
				this.mWatchLaterTick.SetImageResource(2131231227);
			}
			else if (this.detailsData.animeDetails.Library.Library == "WATCH_DONE")
			{
				this.mWatchDoneTick.SetImageResource(2131231227);
			}
			this.mWatchCurrently.Click += this.MWatchCurrently_Click;
			this.mWatchLater.Click += this.MWatchLater_Click;
			this.mWatchDone.Click += this.MWatchDone_Click;
			return this.view;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00023CD0 File Offset: 0x00021ED0
		private void MWatchDone_Click(object sender, EventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (this.status == "AIRING")
			{
				CustomizedToast.ShowToast(base.Activity, base.Resources.GetString(2131951692), 0);
				return;
			}
			this.isLoading = true;
			this.mWatchDoneLoader.Visibility = ViewStates.Visible;
			this.mWatchDoneTick.Visibility = ViewStates.Gone;
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("library/library/library_crud.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("AnimeId", this.mainId);
			this.parameters.Add("Library", "WATCH_DONE");
			this.parameters.Add("Type", this.type);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object sender2, UploadValuesCompletedEventArgs e2)
			{
				try
				{
					if (!this.isDismissed)
					{
						string @string = Encoding.UTF8.GetString(e2.Result);
						string a = JsonConvert.DeserializeObject<string>(@string);
						if (a == "INSERT" || a == "UPDATE")
						{
							this.detailsData.animeDetails.Library.Library = "WATCH_DONE";
						}
						else if (a == "DELETE")
						{
							this.detailsData.animeDetails.Library.Library = "";
						}
						this.isLoading = false;
						this.Dismiss();
					}
				}
				catch
				{
					this.isLoading = false;
					this.mWatchDoneLoader.Visibility = ViewStates.Gone;
					this.mWatchDoneTick.Visibility = ViewStates.Visible;
				}
			};
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00023E20 File Offset: 0x00022020
		private void MWatchLater_Click(object sender, EventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			this.isLoading = true;
			this.mWatchLaterLoader.Visibility = ViewStates.Visible;
			this.mWatchLaterTick.Visibility = ViewStates.Gone;
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("library/library/library_crud.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("AnimeId", this.mainId);
			this.parameters.Add("Library", "WATCH_LATER");
			this.parameters.Add("Type", this.type);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object sender2, UploadValuesCompletedEventArgs e2)
			{
				try
				{
					if (!this.isDismissed)
					{
						string @string = Encoding.UTF8.GetString(e2.Result);
						string a = JsonConvert.DeserializeObject<string>(@string);
						if (a == "INSERT" || a == "UPDATE")
						{
							this.detailsData.animeDetails.Library.Library = "WATCH_LATER";
						}
						else if (a == "DELETE")
						{
							this.detailsData.animeDetails.Library.Library = "";
						}
						this.isLoading = false;
						this.Dismiss();
					}
				}
				catch
				{
					this.isLoading = true;
					this.mWatchLaterLoader.Visibility = ViewStates.Gone;
					this.mWatchLaterTick.Visibility = ViewStates.Visible;
					CustomizedToast.ShowToast(base.Activity, base.Resources.GetString(2131951826), 0);
				}
			};
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00023F40 File Offset: 0x00022140
		private void MWatchCurrently_Click(object sender, EventArgs e)
		{
			if (this.isLoading)
			{
				return;
			}
			if (this.userId == 0)
			{
				this.SignInPormpt(base.Resources.GetString(2131951866));
				return;
			}
			if (this.type != "MOVIE")
			{
				this.isLoading = true;
				this.mWatchCurrentlyLoader.Visibility = ViewStates.Visible;
				this.mWatchCurrentlyTick.Visibility = ViewStates.Gone;
				this.client = new WebClient();
				this.uri = new Uri(Constants.ApiPhp("library/library/library_crud.php"));
				this.parameters = new NameValueCollection();
				this.parameters.Add("UserId", this.userId.ToString());
				this.parameters.Add("AnimeId", this.mainId);
				this.parameters.Add("Library", "WATCH_CURRENTLY");
				this.parameters.Add("Type", this.type);
				this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
				this.client.UploadValuesAsync(this.uri, this.parameters);
				this.client.UploadValuesCompleted += delegate(object sender2, UploadValuesCompletedEventArgs e2)
				{
					try
					{
						if (!this.isDismissed)
						{
							string @string = Encoding.UTF8.GetString(e2.Result);
							string a = JsonConvert.DeserializeObject<string>(@string);
							if (a == "INSERT" || a == "UPDATE")
							{
								this.detailsData.animeDetails.Library.Library = "WATCH_CURRENTLY";
							}
							else if (a == "DELETE")
							{
								this.detailsData.animeDetails.Library.Library = "";
							}
							this.isLoading = false;
							this.Dismiss();
						}
					}
					catch
					{
						this.isLoading = false;
						this.mWatchCurrentlyLoader.Visibility = ViewStates.Gone;
						this.mWatchCurrentlyTick.Visibility = ViewStates.Visible;
						CustomizedToast.ShowToast(base.Activity, base.Resources.GetString(2131951826), 0);
					}
				};
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00024074 File Offset: 0x00022274
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000240B9 File Offset: 0x000222B9
		public override void OnStart()
		{
			base.OnStart();
			BottomSheetBehavior.From((View)this.view.Parent).State = 3;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000240DC File Offset: 0x000222DC
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			this.isDismissed = true;
			if (this.detailsData.animeDetails.Library.Library == "WATCH_CURRENTLY" || this.detailsData.animeDetails.Library.Library == "WATCH_LATER" || this.detailsData.animeDetails.Library.Library == "WATCH_DONE")
			{
				if (this.detailsData.animeDetails.Library.Library == "WATCH_CURRENTLY")
				{
					this.mDetailsLibraryIcon.SetImageResource(2131231004);
					return;
				}
				if (this.detailsData.animeDetails.Library.Library == "WATCH_LATER")
				{
					this.mDetailsLibraryIcon.SetImageResource(2131231186);
					return;
				}
				if (this.detailsData.animeDetails.Library.Library == "WATCH_DONE")
				{
					this.mDetailsLibraryIcon.SetImageResource(2131231013);
					return;
				}
			}
			else
			{
				this.mDetailsLibraryIcon.SetImageResource(2131231158);
			}
		}

		// Token: 0x04000554 RID: 1364
		private UsersModel user;

		// Token: 0x04000555 RID: 1365
		private int userId;

		// Token: 0x04000556 RID: 1366
		private View view;

		// Token: 0x04000557 RID: 1367
		private RelativeLayout mWatchCurrently;

		// Token: 0x04000558 RID: 1368
		private RelativeLayout mWatchLater;

		// Token: 0x04000559 RID: 1369
		private RelativeLayout mWatchDone;

		// Token: 0x0400055A RID: 1370
		private ImageView mDetailsLibraryIcon;

		// Token: 0x0400055B RID: 1371
		private ImageView mWatchCurrentlyTick;

		// Token: 0x0400055C RID: 1372
		private ImageView mWatchLaterTick;

		// Token: 0x0400055D RID: 1373
		private ImageView mWatchDoneTick;

		// Token: 0x0400055E RID: 1374
		private ProgressBar mWatchCurrentlyLoader;

		// Token: 0x0400055F RID: 1375
		private ProgressBar mWatchLaterLoader;

		// Token: 0x04000560 RID: 1376
		private ProgressBar mWatchDoneLoader;

		// Token: 0x04000561 RID: 1377
		private WebClient client;

		// Token: 0x04000562 RID: 1378
		private Uri uri;

		// Token: 0x04000563 RID: 1379
		private NameValueCollection parameters;

		// Token: 0x04000564 RID: 1380
		private bool isDismissed;

		// Token: 0x04000565 RID: 1381
		private bool isLoading;

		// Token: 0x04000566 RID: 1382
		private string mainId;

		// Token: 0x04000567 RID: 1383
		private string status;

		// Token: 0x04000568 RID: 1384
		private string type;

		// Token: 0x04000569 RID: 1385
		private AnimeDetails detailsData;
	}
}
