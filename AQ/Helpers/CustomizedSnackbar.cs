using System;
using Android.Views;
using Google.Android.Material.Snackbar;

namespace AQ.Helpers
{
	// Token: 0x0200008D RID: 141
	public class CustomizedSnackbar
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x00011C08 File Offset: 0x0000FE08
		public static Snackbar SnackBar(View view, int stringId, string additionalString = "")
		{
			return Snackbar.Make(view, additionalString + view.Context.Resources.GetString(stringId), 0);
		}
	}
}
