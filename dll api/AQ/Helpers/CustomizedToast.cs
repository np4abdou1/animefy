using System;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace AQ.Helpers
{
	// Token: 0x0200008E RID: 142
	public class CustomizedToast
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00011C38 File Offset: 0x0000FE38
		public static void ShowToast(Context context, string toastText, int toastImage = 0)
		{
			LayoutInflater layoutInflater = (LayoutInflater)context.GetSystemService("layout_inflater");
			View view = layoutInflater.Inflate(2131558655, null, true);
			ImageView imageView = (ImageView)view.FindViewById(2131363156);
			TextView textView = (TextView)view.FindViewById(2131363158);
			if (toastImage != 0)
			{
				imageView.SetImageResource(toastImage);
			}
			else
			{
				imageView.Visibility = ViewStates.Gone;
			}
			textView.Text = toastText;
			new Toast(context)
			{
				Duration = ToastLength.Long,
				View = view
			}.Show();
		}
	}
}
