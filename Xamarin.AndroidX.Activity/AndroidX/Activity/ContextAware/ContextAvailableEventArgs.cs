using System;
using Android.Content;

namespace AndroidX.Activity.ContextAware
{
	// Token: 0x0200001F RID: 31
	public class ContextAvailableEventArgs : EventArgs
	{
		// Token: 0x060000EA RID: 234 RVA: 0x000043BA File Offset: 0x000025BA
		public ContextAvailableEventArgs(Context context)
		{
			this.context = context;
		}

		// Token: 0x04000034 RID: 52
		private Context context;
	}
}
