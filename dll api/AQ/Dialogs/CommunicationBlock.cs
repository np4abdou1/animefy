using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace AQ.Dialogs
{
	// Token: 0x020000B1 RID: 177
	public class CommunicationBlock : DialogFragment
	{
		// Token: 0x06000823 RID: 2083 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00023104 File Offset: 0x00021304
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558507, container, false);
			this.mOkBtn = this.view.FindViewById<Button>(2131362011);
			this.mOkBtn.Click += this.MOkBtn_Click;
			return this.view;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MOkBtn_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x04000539 RID: 1337
		private View view;

		// Token: 0x0400053A RID: 1338
		private Button mOkBtn;
	}
}
