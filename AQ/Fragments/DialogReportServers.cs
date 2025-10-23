using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;
using AQ.ViewModels;

namespace AQ.Fragments
{
	// Token: 0x0200009B RID: 155
	public class DialogReportServers : DialogFragment
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x000141AC File Offset: 0x000123AC
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.mAnimeId = base.Arguments.GetString("AnimeId");
			this.mType = base.Arguments.GetString("Type");
			this.mEpisode = base.Arguments.GetString("Episode");
			this.view = inflater.Inflate(2131558515, container, false);
			this.mSendBtn = this.view.FindViewById<Button>(2131362287);
			this.mCancelBtn = this.view.FindViewById<Button>(2131362286);
			this.mSendBtn.Click += this.MSendBtn_Click;
			this.mCancelBtn.Click += this.MCancelBtn_Click;
			return this.view;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MCancelBtn_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00014283 File Offset: 0x00012483
		private void MSendBtn_Click(object sender, EventArgs e)
		{
			FeedBackViewModel.SendServerFeedback(this.mAnimeId, this.mType, this.mEpisode);
			CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952339), 0);
			this.Dismiss();
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00014189 File Offset: 0x00012389
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
			base.OnActivityCreated(savedInstanceState);
		}

		// Token: 0x04000366 RID: 870
		private View view;

		// Token: 0x04000367 RID: 871
		private Button mSendBtn;

		// Token: 0x04000368 RID: 872
		private Button mCancelBtn;

		// Token: 0x04000369 RID: 873
		private string mAnimeId;

		// Token: 0x0400036A RID: 874
		private string mType;

		// Token: 0x0400036B RID: 875
		private string mEpisode;
	}
}
