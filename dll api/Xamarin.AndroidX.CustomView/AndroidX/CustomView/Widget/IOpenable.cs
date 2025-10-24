using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.CustomView.Widget
{
	// Token: 0x02000007 RID: 7
	[Register("androidx/customview/widget/Openable", "", "AndroidX.CustomView.Widget.IOpenableInvoker")]
	public interface IOpenable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12
		bool IsOpen { [Register("isOpen", "()Z", "GetIsOpenHandler:AndroidX.CustomView.Widget.IOpenableInvoker, Xamarin.AndroidX.CustomView")] get; }

		// Token: 0x0600000D RID: 13
		[Register("close", "()V", "GetCloseHandler:AndroidX.CustomView.Widget.IOpenableInvoker, Xamarin.AndroidX.CustomView")]
		void Close();

		// Token: 0x0600000E RID: 14
		[Register("open", "()V", "GetOpenHandler:AndroidX.CustomView.Widget.IOpenableInvoker, Xamarin.AndroidX.CustomView")]
		void Open();
	}
}
