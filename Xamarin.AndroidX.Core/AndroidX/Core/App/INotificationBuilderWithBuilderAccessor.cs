using System;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.App
{
	// Token: 0x02000068 RID: 104
	[Register("androidx/core/app/NotificationBuilderWithBuilderAccessor", "", "AndroidX.Core.App.INotificationBuilderWithBuilderAccessorInvoker")]
	public interface INotificationBuilderWithBuilderAccessor : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600040F RID: 1039
		Notification.Builder Builder { [Register("getBuilder", "()Landroid/app/Notification$Builder;", "GetGetBuilderHandler:AndroidX.Core.App.INotificationBuilderWithBuilderAccessorInvoker, Xamarin.AndroidX.Core")] get; }
	}
}
