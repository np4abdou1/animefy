using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Dialogs
{
	// Token: 0x020000AC RID: 172
	public class AnimeDetailsGlance : DialogFragment
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x0001E028 File Offset: 0x0001C228
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.title = base.Arguments.GetString("Title", "");
			this.genres = base.Arguments.GetString("Genres", "");
			this.animeId = base.Arguments.GetString("AnimeId", "");
			this.type = base.Arguments.GetString("AnimeType", "");
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558505, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mTitle = this.view.FindViewById<TextView>(2131362295);
			this.mGenre = this.view.FindViewById<TextView>(2131362270);
			this.mPlot = this.view.FindViewById<TextView>(2131362282);
			this.mComments = this.view.FindViewById<TextView>(2131362266);
			this.mTitle.Text = this.title;
			if (this.Context.Resources.GetString(2131951706) == "AR")
			{
				TextView textView = this.mGenre;
				textView.Text += LanguageConvertor.GenresToStringList(this.view.Context, this.genres);
			}
			else
			{
				TextView textView2 = this.mGenre;
				textView2.Text += this.genres;
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadPlot();
			});
			this.mComments.Click += this.MComments_Click;
			return this.view;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001E1F4 File Offset: 0x0001C3F4
		private void LoadPlot()
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("anime/load_anime_details_glance.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"AnimeId",
					this.animeId
				},
				{
					"Language",
					base.Resources.GetString(2131951706)
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sss, UploadValuesCompletedEventArgs eee)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(eee.Result);
					string plot = JsonConvert.DeserializeObject<string>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						this.mPlot.Text = plot;
					});
				}
				catch
				{
				}
			};
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0001E274 File Offset: 0x0001C474
		private void MComments_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetailsGlance.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.animeId);
			bundle.PutString("CommType", this.type);
			Comments comments = new Comments();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00014189 File Offset: 0x00012389
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
			base.OnActivityCreated(savedInstanceState);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001E2EC File Offset: 0x0001C4EC
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			this.isDismissed = true;
		}

		// Token: 0x040004B5 RID: 1205
		private View view;

		// Token: 0x040004B6 RID: 1206
		private UsersModel user;

		// Token: 0x040004B7 RID: 1207
		private int userId;

		// Token: 0x040004B8 RID: 1208
		private TextView mTitle;

		// Token: 0x040004B9 RID: 1209
		private TextView mGenre;

		// Token: 0x040004BA RID: 1210
		private TextView mPlot;

		// Token: 0x040004BB RID: 1211
		private TextView mComments;

		// Token: 0x040004BC RID: 1212
		private string title;

		// Token: 0x040004BD RID: 1213
		private string animeId;

		// Token: 0x040004BE RID: 1214
		private string type;

		// Token: 0x040004BF RID: 1215
		private string genres;

		// Token: 0x040004C0 RID: 1216
		private bool isDismissed;

		// Token: 0x040004C1 RID: 1217
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x040004C2 RID: 1218
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
