using System;
using Android.Runtime;
using AndroidX.Lifecycle.ViewModels;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000A RID: 10
	[Register("androidx/lifecycle/HasDefaultViewModelProviderFactory", "", "AndroidX.Lifecycle.IHasDefaultViewModelProviderFactoryInvoker")]
	public interface IHasDefaultViewModelProviderFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000018 RID: 24
		ViewModelProvider.IFactory DefaultViewModelProviderFactory { [Register("getDefaultViewModelProviderFactory", "()Landroidx/lifecycle/ViewModelProvider$Factory;", "GetGetDefaultViewModelProviderFactoryHandler:AndroidX.Lifecycle.IHasDefaultViewModelProviderFactoryInvoker, Xamarin.AndroidX.Lifecycle.ViewModel")] get; }

		// Token: 0x06000019 RID: 25 RVA: 0x0000207F File Offset: 0x0000027F
		private static Delegate GetGetDefaultViewModelCreationExtrasHandler()
		{
			if (IHasDefaultViewModelProviderFactory.cb_getDefaultViewModelCreationExtras == null)
			{
				IHasDefaultViewModelProviderFactory.cb_getDefaultViewModelCreationExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IHasDefaultViewModelProviderFactory.n_GetDefaultViewModelCreationExtras));
			}
			return IHasDefaultViewModelProviderFactory.cb_getDefaultViewModelCreationExtras;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020A3 File Offset: 0x000002A3
		private static IntPtr n_GetDefaultViewModelCreationExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IHasDefaultViewModelProviderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultViewModelCreationExtras);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020B8 File Offset: 0x000002B8
		CreationExtras DefaultViewModelCreationExtras
		{
			[Register("getDefaultViewModelCreationExtras", "()Landroidx/lifecycle/viewmodel/CreationExtras;", "GetGetDefaultViewModelCreationExtrasHandler:AndroidX.Lifecycle.IHasDefaultViewModelProviderFactory, Xamarin.AndroidX.Lifecycle.ViewModel")]
			get
			{
				return Java.Lang.Object.GetObject<CreationExtras>(IHasDefaultViewModelProviderFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultViewModelCreationExtras.()Landroidx/lifecycle/viewmodel/CreationExtras;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/HasDefaultViewModelProviderFactory", typeof(IHasDefaultViewModelProviderFactory), true);

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getDefaultViewModelCreationExtras;
	}
}
