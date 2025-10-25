using System;
using Android.Net;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace AQ.Dialogs
{
	// Token: 0x020000BB RID: 187
	public class TrailersDialog : DialogFragment
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00024F54 File Offset: 0x00023154
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.mAnimeType = base.Arguments.GetString("AnimeType", "N/A");
			this.mLink = base.Arguments.GetString("TrailerLink", "N/A");
			this.view = inflater.Inflate(2131558517, container, false);
			this.mTrailerView = this.view.FindViewById<VideoView>(2131362507);
			this.mErrorMessages = this.view.FindViewById<TextView>(2131362508);
			try
			{
				this.RunTrailer(this.mLink);
			}
			catch
			{
				this.mErrorMessages.Text = base.Resources.GetString(2131952348);
			}
			return this.view;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00025030 File Offset: 0x00023230
		public void RunTrailer(string link)
		{
			if (link == "")
			{
				this.mErrorMessages.Text = base.Resources.GetString(2131952245);
				return;
			}
			if (link != "" && link != null)
			{
				Android.Net.Uri videoURI = Android.Net.Uri.Parse(Constants.Trailers(link));
				this.mTrailerView.SetVideoURI(videoURI);
				MediaController mediaController = new MediaController(this.view.Context);
				this.mTrailerView.SetMediaController(mediaController);
				this.mTrailerView.Start();
			}
		}

		// Token: 0x04000582 RID: 1410
		private View view;

		// Token: 0x04000583 RID: 1411
		private VideoView mTrailerView;

		// Token: 0x04000584 RID: 1412
		private TextView mErrorMessages;

		// Token: 0x04000585 RID: 1413
		private string mLink;

		// Token: 0x04000586 RID: 1414
		private string mAnimeType;
	}
}
