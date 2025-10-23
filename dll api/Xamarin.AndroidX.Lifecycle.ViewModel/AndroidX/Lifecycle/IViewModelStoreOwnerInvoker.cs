using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000D RID: 13
	[Register("androidx/lifecycle/ViewModelStoreOwner", DoNotGenerateAcw = true)]
	internal class IViewModelStoreOwnerInvoker : Java.Lang.Object, IViewModelStoreOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002288 File Offset: 0x00000488
		private static IntPtr java_class_ref
		{
			get
			{
				return IViewModelStoreOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000022AC File Offset: 0x000004AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IViewModelStoreOwnerInvoker._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022B3 File Offset: 0x000004B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000022BB File Offset: 0x000004BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IViewModelStoreOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000022C7 File Offset: 0x000004C7
		public static IViewModelStoreOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IViewModelStoreOwner>(handle, transfer);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000022D0 File Offset: 0x000004D0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IViewModelStoreOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.ViewModelStoreOwner'.");
			}
			return handle;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000022FB File Offset: 0x000004FB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000232C File Offset: 0x0000052C
		public IViewModelStoreOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IViewModelStoreOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002364 File Offset: 0x00000564
		private static Delegate GetGetViewModelStoreHandler()
		{
			if (IViewModelStoreOwnerInvoker.cb_getViewModelStore == null)
			{
				IViewModelStoreOwnerInvoker.cb_getViewModelStore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IViewModelStoreOwnerInvoker.n_GetViewModelStore));
			}
			return IViewModelStoreOwnerInvoker.cb_getViewModelStore;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002388 File Offset: 0x00000588
		private static IntPtr n_GetViewModelStore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IViewModelStoreOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewModelStore);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000239C File Offset: 0x0000059C
		public ViewModelStore ViewModelStore
		{
			get
			{
				if (this.id_getViewModelStore == IntPtr.Zero)
				{
					this.id_getViewModelStore = JNIEnv.GetMethodID(this.class_ref, "getViewModelStore", "()Landroidx/lifecycle/ViewModelStore;");
				}
				return Java.Lang.Object.GetObject<ViewModelStore>(JNIEnv.CallObjectMethod(base.Handle, this.id_getViewModelStore), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModelStoreOwner", typeof(IViewModelStoreOwnerInvoker));

		// Token: 0x0400000A RID: 10
		private IntPtr class_ref;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_getViewModelStore;

		// Token: 0x0400000C RID: 12
		private IntPtr id_getViewModelStore;
	}
}
