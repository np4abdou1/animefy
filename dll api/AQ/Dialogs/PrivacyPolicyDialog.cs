using System;
using Android.Content;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Text;
using Android.Text.Method;
using Android.Text.Style;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;

namespace AQ.Dialogs
{
	// Token: 0x020000B7 RID: 183
	public class PrivacyPolicyDialog : DialogFragment
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x000155E6 File Offset: 0x000137E6
		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			this.Dialog.Window.Attributes.WindowAnimations = 2132018313;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00024598 File Offset: 0x00022798
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558514, container, false);
			this.accept = this.view.FindViewById<Button>(2131362284);
			this.termsCheckBox = this.view.FindViewById<CheckBox>(2131361812);
			SpannableStringBuilder spannableStringBuilder = new SpannableStringBuilder();
			spannableStringBuilder.Append(base.Resources.GetString(2131952004) + " ");
			int start = spannableStringBuilder.Length();
			spannableStringBuilder.Append(base.Resources.GetString(2131952459));
			spannableStringBuilder.SetSpan(new StyleSpan(TypefaceStyle.Bold), start, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder.SetSpan(new PrivacyPolicyDialog.TermsOnClick(this.view.Context), start, spannableStringBuilder.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder.Append(".");
			this.termsCheckBox.MovementMethod = LinkMovementMethod.Instance;
			this.termsCheckBox.SetText(spannableStringBuilder, TextView.BufferType.Spannable);
			this.privacyCheckBox = this.view.FindViewById<CheckBox>(2131361811);
			SpannableStringBuilder spannableStringBuilder2 = new SpannableStringBuilder();
			spannableStringBuilder2.Append(base.Resources.GetString(2131952004) + " ");
			int start2 = spannableStringBuilder2.Length();
			spannableStringBuilder2.Append(base.Resources.GetString(2131952306));
			spannableStringBuilder2.SetSpan(new StyleSpan(TypefaceStyle.Bold), start2, spannableStringBuilder2.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder2.SetSpan(new PrivacyPolicyDialog.PrivacyOnClick(this.view.Context), start2, spannableStringBuilder2.Length(), SpanTypes.ExclusiveExclusive);
			spannableStringBuilder2.Append(".");
			this.privacyCheckBox.MovementMethod = LinkMovementMethod.Instance;
			this.privacyCheckBox.SetText(spannableStringBuilder2, TextView.BufferType.Spannable);
			this.accept.Click += this.Accept_Click;
			return this.view;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00024778 File Offset: 0x00022978
		private void Accept_Click(object sender, EventArgs e)
		{
			if (this.termsCheckBox.Checked && this.privacyCheckBox.Checked)
			{
				SharedPreferencesSaves.IntSharedPreferencesSave("PrivayPolicyAccepted2", 1);
				this.Dismiss();
				return;
			}
			if (!this.termsCheckBox.Checked)
			{
				this.termsCheckBox.Error = base.Resources.GetString(2131951648);
			}
			if (!this.privacyCheckBox.Checked)
			{
				this.privacyCheckBox.Error = base.Resources.GetString(2131951648);
			}
		}

		// Token: 0x04000570 RID: 1392
		private View view;

		// Token: 0x04000571 RID: 1393
		private CheckBox privacyCheckBox;

		// Token: 0x04000572 RID: 1394
		private CheckBox termsCheckBox;

		// Token: 0x04000573 RID: 1395
		private Button accept;

		// Token: 0x02000145 RID: 325
		private class TermsOnClick : ClickableSpan
		{
			// Token: 0x06000BD9 RID: 3033 RVA: 0x00040C6C File Offset: 0x0003EE6C
			public TermsOnClick(Context context)
			{
				this.context = context;
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x00040C7B File Offset: 0x0003EE7B
			public override void OnClick(View widget)
			{
				this.context.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse("https://animefyo.blogspot.com/2022/12/animefyo-terms.html")));
			}

			// Token: 0x06000BDB RID: 3035 RVA: 0x0003ED15 File Offset: 0x0003CF15
			public override void UpdateDrawState(TextPaint ds)
			{
				base.UpdateDrawState(ds);
				ds.UnderlineText = true;
			}

			// Token: 0x040030C4 RID: 12484
			private Context context;
		}

		// Token: 0x02000146 RID: 326
		private class PrivacyOnClick : ClickableSpan
		{
			// Token: 0x06000BDC RID: 3036 RVA: 0x00040CA1 File Offset: 0x0003EEA1
			public PrivacyOnClick(Context context)
			{
				this.context = context;
			}

			// Token: 0x06000BDD RID: 3037 RVA: 0x00040CB0 File Offset: 0x0003EEB0
			public override void OnClick(View widget)
			{
				this.context.StartActivity(new Intent("android.intent.action.VIEW").SetData(Android.Net.Uri.Parse("https://animefyo.blogspot.com/2022/12/animefyo-privacy-policy-we-want-you-to.html")));
			}

			// Token: 0x06000BDE RID: 3038 RVA: 0x0003ED15 File Offset: 0x0003CF15
			public override void UpdateDrawState(TextPaint ds)
			{
				base.UpdateDrawState(ds);
				ds.UnderlineText = true;
			}

			// Token: 0x040030C5 RID: 12485
			private Context context;
		}

		// Token: 0x02000147 RID: 327
		public class PrivacyWebViewClient : WebViewClient
		{
			// Token: 0x06000BDF RID: 3039 RVA: 0x00040CD6 File Offset: 0x0003EED6
			[Obsolete("Deprecated Method got a Replacement")]
			public override bool ShouldOverrideUrlLoading(WebView view, string url)
			{
				view.LoadUrl(url);
				return false;
			}

			// Token: 0x06000BE0 RID: 3040 RVA: 0x00040CE0 File Offset: 0x0003EEE0
			public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
			{
				view.LoadUrl(request.Url.ToString());
				return false;
			}
		}
	}
}
