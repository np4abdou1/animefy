using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000B RID: 11
	[Register("androidx/lifecycle/HasDefaultViewModelProviderFactory", DoNotGenerateAcw = true)]
	internal class IHasDefaultViewModelProviderFactoryInvoker : Java.Lang.Object, IHasDefaultViewModelProviderFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002108 File Offset: 0x00000308
		private static IntPtr java_class_ref
		{
			get
			{
				return IHasDefaultViewModelProviderFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000212C File Offset: 0x0000032C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IHasDefaultViewModelProviderFactoryInvoker._members;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002133 File Offset: 0x00000333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000213B File Offset: 0x0000033B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IHasDefaultViewModelProviderFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002147 File Offset: 0x00000347
		public static IHasDefaultViewModelProviderFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IHasDefaultViewModelProviderFactory>(handle, transfer);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002150 File Offset: 0x00000350
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IHasDefaultViewModelProviderFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.HasDefaultViewModelProviderFactory'.");
			}
			return handle;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000217B File Offset: 0x0000037B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021AC File Offset: 0x000003AC
		public IHasDefaultViewModelProviderFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IHasDefaultViewModelProviderFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021E4 File Offset: 0x000003E4
		private static Delegate GetGetDefaultViewModelProviderFactoryHandler()
		{
			if (IHasDefaultViewModelProviderFactoryInvoker.cb_getDefaultViewModelProviderFactory == null)
			{
				IHasDefaultViewModelProviderFactoryInvoker.cb_getDefaultViewModelProviderFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IHasDefaultViewModelProviderFactoryInvoker.n_GetDefaultViewModelProviderFactory));
			}
			return IHasDefaultViewModelProviderFactoryInvoker.cb_getDefaultViewModelProviderFactory;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002208 File Offset: 0x00000408
		private static IntPtr n_GetDefaultViewModelProviderFactory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IHasDefaultViewModelProviderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultViewModelProviderFactory);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000221C File Offset: 0x0000041C
		public ViewModelProvider.IFactory DefaultViewModelProviderFactory
		{
			get
			{
				if (this.id_getDefaultViewModelProviderFactory == IntPtr.Zero)
				{
					this.id_getDefaultViewModelProviderFactory = JNIEnv.GetMethodID(this.class_ref, "getDefaultViewModelProviderFactory", "()Landroidx/lifecycle/ViewModelProvider$Factory;");
				}
				return Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDefaultViewModelProviderFactory), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/HasDefaultViewModelProviderFactory", typeof(IHasDefaultViewModelProviderFactoryInvoker));

		// Token: 0x04000006 RID: 6
		private IntPtr class_ref;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getDefaultViewModelProviderFactory;

		// Token: 0x04000008 RID: 8
		private IntPtr id_getDefaultViewModelProviderFactory;
	}
}
