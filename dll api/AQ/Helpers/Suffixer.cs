using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AQ.Helpers
{
	// Token: 0x02000098 RID: 152
	public class Suffixer : Java.Lang.Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060006A2 RID: 1698 RVA: 0x00013C95 File Offset: 0x00011E95
		public Suffixer(Context context, TextView textView, int maxLines, string moreString)
		{
			this.context = context;
			this.textView = textView;
			this.maxLines = maxLines;
			this.moreString = moreString;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00013CBC File Offset: 0x00011EBC
		public void Run()
		{
			if (this.textView.LineCount > this.maxLines)
			{
				int lineVisibleEnd = this.textView.Layout.GetLineVisibleEnd(this.maxLines - 1);
				string text = this.moreString ?? "";
				this.textView.SetMaxLines(this.maxLines);
				string text2;
				try
				{
					text2 = this.textView.Text.Substring(0, lineVisibleEnd - text.Length - 3) + "..." + text;
				}
				catch
				{
					text2 = this.textView.Text.Substring(0, lineVisibleEnd) + "..." + text;
				}
				int num = text2.IndexOf(this.moreString);
				SpannableString spannableString = new SpannableString(text2);
				spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#538ac6")), num, num + this.moreString.Length, SpanTypes.ExclusiveExclusive);
				spannableString.SetSpan(new UnderlineSpan(), num, num + this.moreString.Length, SpanTypes.ExclusiveExclusive);
				this.textView.SetText(spannableString, TextView.BufferType.Spannable);
			}
		}

		// Token: 0x04000354 RID: 852
		private Context context;

		// Token: 0x04000355 RID: 853
		private TextView textView;

		// Token: 0x04000356 RID: 854
		private int maxLines;

		// Token: 0x04000357 RID: 855
		private string moreString;
	}
}
