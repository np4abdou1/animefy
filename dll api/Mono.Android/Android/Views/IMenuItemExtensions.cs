using System;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000121 RID: 289
	public static class IMenuItemExtensions
	{
		// Token: 0x06000846 RID: 2118 RVA: 0x00013678 File Offset: 0x00011878
		public static IMenuItem SetTitle(this IMenuItem self, string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			IMenuItem result = self.SetTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}
	}
}
