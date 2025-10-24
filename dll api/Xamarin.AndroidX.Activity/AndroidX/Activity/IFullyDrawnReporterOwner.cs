using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Activity
{
	// Token: 0x02000014 RID: 20
	[Register("androidx/activity/FullyDrawnReporterOwner", "", "AndroidX.Activity.IFullyDrawnReporterOwnerInvoker")]
	public interface IFullyDrawnReporterOwner : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141
		FullyDrawnReporter FullyDrawnReporter { [Register("getFullyDrawnReporter", "()Landroidx/activity/FullyDrawnReporter;", "GetGetFullyDrawnReporterHandler:AndroidX.Activity.IFullyDrawnReporterOwnerInvoker, Xamarin.AndroidX.Activity")] get; }
	}
}
