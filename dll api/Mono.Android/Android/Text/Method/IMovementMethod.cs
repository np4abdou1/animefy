using System;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Android.Text.Method
{
	// Token: 0x020001CF RID: 463
	[Register("android/text/method/MovementMethod", "", "Android.Text.Method.IMovementMethodInvoker")]
	public interface IMovementMethod : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060010B9 RID: 4281
		bool CanSelectArbitrarily();

		// Token: 0x060010BA RID: 4282
		void Initialize(TextView widget, ISpannable text);

		// Token: 0x060010BB RID: 4283
		bool OnGenericMotionEvent(TextView widget, ISpannable text, MotionEvent e);

		// Token: 0x060010BC RID: 4284
		bool OnKeyDown(TextView widget, ISpannable text, [GeneratedEnum] Keycode keyCode, KeyEvent e);

		// Token: 0x060010BD RID: 4285
		bool OnKeyOther(TextView view, ISpannable text, KeyEvent e);

		// Token: 0x060010BE RID: 4286
		bool OnKeyUp(TextView widget, ISpannable text, [GeneratedEnum] Keycode keyCode, KeyEvent e);

		// Token: 0x060010BF RID: 4287
		void OnTakeFocus(TextView widget, ISpannable text, [GeneratedEnum] FocusSearchDirection direction);

		// Token: 0x060010C0 RID: 4288
		bool OnTouchEvent(TextView widget, ISpannable text, MotionEvent e);

		// Token: 0x060010C1 RID: 4289
		bool OnTrackballEvent(TextView widget, ISpannable text, MotionEvent e);
	}
}
