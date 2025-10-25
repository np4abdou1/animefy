using System;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace AQ.Helpers
{
	// Token: 0x0200008B RID: 139
	public class FullnameFilter : Java.Lang.Object, IInputFilter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x0001173E File Offset: 0x0000F93E
		public ICharSequence FilterFormatted(ICharSequence source, int start, int end, ISpanned dest, int dstart, int dend)
		{
			if (source != null && this.BlockedCharacterSet.Contains(((source != null) ? source.ToString() : null) ?? ""))
			{
				return new Java.Lang.String("");
			}
			return null;
		}

		// Token: 0x04000352 RID: 850
		private string BlockedCharacterSet = "~@#^|$%&*!";
	}
}
