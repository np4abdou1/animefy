using System;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace AQ.Helpers
{
	// Token: 0x0200008A RID: 138
	public class EmailFilter : Java.Lang.Object, IInputFilter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600066A RID: 1642 RVA: 0x000116F7 File Offset: 0x0000F8F7
		public ICharSequence FilterFormatted(ICharSequence source, int start, int end, ISpanned dest, int dstart, int dend)
		{
			if (source != null && this.BlockedCharacterSet.Contains(((source != null) ? source.ToString() : null) ?? ""))
			{
				return new Java.Lang.String("");
			}
			return null;
		}

		// Token: 0x04000351 RID: 849
		private string BlockedCharacterSet = "~#^|$%&*!";
	}
}
