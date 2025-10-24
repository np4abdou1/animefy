using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AQ.ViewAdapters
{
	// Token: 0x02000026 RID: 38
	public class ReedMoreHelper : Java.Lang.Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000158 RID: 344 RVA: 0x000077B8 File Offset: 0x000059B8
		public ReedMoreHelper(Context context, TextView textView)
		{
			this.context = context;
			this.textView = textView;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000077D0 File Offset: 0x000059D0
		public void Run()
		{
			this.tempTextViewText = this.textView.Text;
			if (this.textView.LineCount > ReedMoreHelper.MAX_LINES)
			{
				try
				{
					int lineVisibleEnd = this.textView.Layout.GetLineVisibleEnd(ReedMoreHelper.MAX_LINES - 1);
					string @string = this.context.Resources.GetString(2131952325);
					string text = @string ?? "";
					this.textView.SetMaxLines(ReedMoreHelper.MAX_LINES);
					string text2;
					try
					{
						text2 = this.textView.Text.Substring(0, lineVisibleEnd - text.Length - 3) + "..." + text;
					}
					catch
					{
						text2 = this.textView.Text.Substring(0, lineVisibleEnd) + "..." + text;
					}
					int num = text2.IndexOf(@string);
					SpannableString spannableString = new SpannableString(text2);
					spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#538ac6")), num, num + @string.Length, SpanTypes.ExclusiveExclusive);
					spannableString.SetSpan(new UnderlineSpan(), num, num + @string.Length, SpanTypes.ExclusiveExclusive);
					this.textView.SetText(spannableString, TextView.BufferType.Spannable);
				}
				catch
				{
					this.textView.Text = this.tempTextViewText.Replace("\n\n\n\n\n", "\n");
				}
			}
		}

		// Token: 0x040000F2 RID: 242
		private Context context;

		// Token: 0x040000F3 RID: 243
		private TextView textView;

		// Token: 0x040000F4 RID: 244
		private string tempTextViewText;

		// Token: 0x040000F5 RID: 245
		private static readonly int MAX_LINES = 4;
	}
}
