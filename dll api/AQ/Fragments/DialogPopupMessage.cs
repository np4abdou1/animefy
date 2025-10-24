using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace AQ.Fragments
{
	// Token: 0x0200009A RID: 154
	public class DialogPopupMessage : DialogFragment
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x00014074 File Offset: 0x00012274
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.title = base.Arguments.GetString("DialogTitle");
			this.messgae = base.Arguments.GetString("DialogMessage");
			this.isOnCancelFinish = base.Arguments.GetBoolean("IsOnCancelFinish", false);
			this.view = inflater.Inflate(2131558513, container, false);
			this.mOkBtn = this.view.FindViewById<Button>(2131362284);
			this.mTitle = this.view.FindViewById<TextView>(2131362295);
			this.mTitle.Text = this.title;
			this.mMessage = this.view.FindViewById<TextView>(2131362279);
			this.mMessage.Text = this.messgae;
			this.mOkBtn.Click += this.MOkBtn_Click;
			return this.view;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001416D File Offset: 0x0001236D
		private void MOkBtn_Click(object sender, EventArgs e)
		{
			if (this.isOnCancelFinish)
			{
				base.Activity.Finish();
				return;
			}
			this.Dismiss();
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00014189 File Offset: 0x00012389
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
			base.OnActivityCreated(savedInstanceState);
		}

		// Token: 0x0400035F RID: 863
		private View view;

		// Token: 0x04000360 RID: 864
		private Button mOkBtn;

		// Token: 0x04000361 RID: 865
		private TextView mTitle;

		// Token: 0x04000362 RID: 866
		private TextView mMessage;

		// Token: 0x04000363 RID: 867
		private string title;

		// Token: 0x04000364 RID: 868
		private string messgae;

		// Token: 0x04000365 RID: 869
		private bool isOnCancelFinish;
	}
}
