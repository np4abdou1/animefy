using System;
using Android.App;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AQ.Helpers
{
	// Token: 0x02000093 RID: 147
	public class PopupConfirm
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x000139AC File Offset: 0x00011BAC
		public static void Confirm(Activity activity, Func<int, int> func)
		{
			LayoutInflater layoutInflater = LayoutInflater.From(activity);
			View view = layoutInflater.Inflate(2131558618, null);
			view.FindViewById<TextView>(2131362279).Text = view.Resources.GetString(2131951864);
			Button button = view.FindViewById<Button>(2131362300);
			Button button2 = view.FindViewById<Button>(2131362263);
			AlertDialog.Builder builder = new AlertDialog.Builder(activity);
			builder.SetView(view);
			builder.SetCancelable(true);
			AlertDialog dialog = builder.Create();
			dialog.Show();
			button.Click += delegate(object <p0>, EventArgs <p1>)
			{
				func(0);
				dialog.Dismiss();
			};
			button2.Click += delegate(object <p0>, EventArgs <p1>)
			{
				dialog.Dismiss();
			};
		}
	}
}
