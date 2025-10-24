using System;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Method
{
	// Token: 0x020001D1 RID: 465
	[Register("android/text/method/TransformationMethod", "", "Android.Text.Method.ITransformationMethodInvoker")]
	public interface ITransformationMethod : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060010E5 RID: 4325
		ICharSequence GetTransformationFormatted(ICharSequence source, View view);

		// Token: 0x060010E6 RID: 4326
		void OnFocusChanged(View view, ICharSequence sourceText, bool focused, [GeneratedEnum] FocusSearchDirection direction, Rect previouslyFocusedRect);
	}
}
