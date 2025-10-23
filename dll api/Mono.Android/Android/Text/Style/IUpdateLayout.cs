using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Text.Style
{
	// Token: 0x020001C8 RID: 456
	[Register("android/text/style/UpdateLayout", "", "Android.Text.Style.IUpdateLayoutInvoker")]
	public interface IUpdateLayout : IUpdateAppearance, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
