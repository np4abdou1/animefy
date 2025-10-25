using System;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace AQ.Helpers
{
	// Token: 0x02000089 RID: 137
	public class UsernameFilter : Java.Lang.Object, IInputFilter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x000116B0 File Offset: 0x0000F8B0
		public ICharSequence FilterFormatted(ICharSequence source, int start, int end, ISpanned dest, int dstart, int dend)
		{
			if (source != null && this.BlockedCharacterSet.Contains(((source != null) ? source.ToString() : null) ?? ""))
			{
				return new Java.Lang.String("");
			}
			return null;
		}

		// Token: 0x04000350 RID: 848
		private string BlockedCharacterSet = "~@#^|$%&*.!";
	}
}
