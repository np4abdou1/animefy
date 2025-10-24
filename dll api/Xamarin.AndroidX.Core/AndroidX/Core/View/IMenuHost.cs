using System;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000A2 RID: 162
	[Register("androidx/core/view/MenuHost", "", "AndroidX.Core.View.IMenuHostInvoker")]
	public interface IMenuHost : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060008A4 RID: 2212
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Handler:AndroidX.Core.View.IMenuHostInvoker, Xamarin.AndroidX.Core")]
		void AddMenuProvider(IMenuProvider p0);

		// Token: 0x060008A5 RID: 2213
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Handler:AndroidX.Core.View.IMenuHostInvoker, Xamarin.AndroidX.Core")]
		void AddMenuProvider(IMenuProvider p0, ILifecycleOwner p1);

		// Token: 0x060008A6 RID: 2214
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_Handler:AndroidX.Core.View.IMenuHostInvoker, Xamarin.AndroidX.Core")]
		void AddMenuProvider(IMenuProvider p0, ILifecycleOwner p1, Lifecycle.State p2);

		// Token: 0x060008A7 RID: 2215
		[Register("invalidateMenu", "()V", "GetInvalidateMenuHandler:AndroidX.Core.View.IMenuHostInvoker, Xamarin.AndroidX.Core")]
		void InvalidateMenu();

		// Token: 0x060008A8 RID: 2216
		[Register("removeMenuProvider", "(Landroidx/core/view/MenuProvider;)V", "GetRemoveMenuProvider_Landroidx_core_view_MenuProvider_Handler:AndroidX.Core.View.IMenuHostInvoker, Xamarin.AndroidX.Core")]
		void RemoveMenuProvider(IMenuProvider p0);
	}
}
