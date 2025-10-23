using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x02000127 RID: 295
	[Register("android/view/ViewManager", "", "Android.Views.IViewManagerInvoker")]
	public interface IViewManager : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600091E RID: 2334
		void AddView(View view, ViewGroup.LayoutParams @params);

		// Token: 0x0600091F RID: 2335
		void RemoveView(View view);

		// Token: 0x06000920 RID: 2336
		void UpdateViewLayout(View view, ViewGroup.LayoutParams @params);
	}
}
