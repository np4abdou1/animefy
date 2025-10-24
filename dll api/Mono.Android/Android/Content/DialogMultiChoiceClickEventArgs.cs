using System;

namespace Android.Content
{
	// Token: 0x02000296 RID: 662
	public class DialogMultiChoiceClickEventArgs : EventArgs
	{
		// Token: 0x06001932 RID: 6450 RVA: 0x000411A8 File Offset: 0x0003F3A8
		public DialogMultiChoiceClickEventArgs(int which, bool isChecked)
		{
			this.which = which;
			this.isChecked = isChecked;
		}

		// Token: 0x04000A94 RID: 2708
		private int which;

		// Token: 0x04000A95 RID: 2709
		private bool isChecked;
	}
}
