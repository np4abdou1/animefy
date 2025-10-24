using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.ViewPager2.Adapter
{
	// Token: 0x02000015 RID: 21
	[Register("androidx/viewpager2/adapter/StatefulAdapter", "", "AndroidX.ViewPager2.Adapter.IStatefulAdapterInvoker")]
	public interface IStatefulAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000092 RID: 146
		[Register("restoreState", "(Landroid/os/Parcelable;)V", "GetRestoreState_Landroid_os_Parcelable_Handler:AndroidX.ViewPager2.Adapter.IStatefulAdapterInvoker, Xamarin.AndroidX.ViewPager2")]
		void RestoreState(IParcelable p0);

		// Token: 0x06000093 RID: 147
		[Register("saveState", "()Landroid/os/Parcelable;", "GetSaveStateHandler:AndroidX.ViewPager2.Adapter.IStatefulAdapterInvoker, Xamarin.AndroidX.ViewPager2")]
		IParcelable SaveState();
	}
}
