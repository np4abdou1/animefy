using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000C RID: 12
	[Register("androidx/lifecycle/LifecycleOwner", DoNotGenerateAcw = true)]
	internal class ILifecycleOwnerInvoker : Java.Lang.Object, ILifecycleOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002654 File Offset: 0x00000854
		private static IntPtr java_class_ref
		{
			get
			{
				return ILifecycleOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002678 File Offset: 0x00000878
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILifecycleOwnerInvoker._members;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000267F File Offset: 0x0000087F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002687 File Offset: 0x00000887
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILifecycleOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002693 File Offset: 0x00000893
		public static ILifecycleOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILifecycleOwner>(handle, transfer);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000269C File Offset: 0x0000089C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILifecycleOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.LifecycleOwner'.");
			}
			return handle;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000026C7 File Offset: 0x000008C7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000026F8 File Offset: 0x000008F8
		public ILifecycleOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILifecycleOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002730 File Offset: 0x00000930
		private static Delegate GetGetLifecycleHandler()
		{
			if (ILifecycleOwnerInvoker.cb_getLifecycle == null)
			{
				ILifecycleOwnerInvoker.cb_getLifecycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILifecycleOwnerInvoker.n_GetLifecycle));
			}
			return ILifecycleOwnerInvoker.cb_getLifecycle;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002754 File Offset: 0x00000954
		private static IntPtr n_GetLifecycle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILifecycleOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lifecycle);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002768 File Offset: 0x00000968
		public Lifecycle Lifecycle
		{
			get
			{
				if (this.id_getLifecycle == IntPtr.Zero)
				{
					this.id_getLifecycle = JNIEnv.GetMethodID(this.class_ref, "getLifecycle", "()Landroidx/lifecycle/Lifecycle;");
				}
				return Java.Lang.Object.GetObject<Lifecycle>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLifecycle), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/LifecycleOwner", typeof(ILifecycleOwnerInvoker));

		// Token: 0x0400000B RID: 11
		private IntPtr class_ref;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getLifecycle;

		// Token: 0x0400000D RID: 13
		private IntPtr id_getLifecycle;
	}
}
