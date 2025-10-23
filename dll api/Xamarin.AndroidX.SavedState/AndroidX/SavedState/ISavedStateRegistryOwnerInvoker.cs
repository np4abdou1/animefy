using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.SavedState
{
	// Token: 0x02000007 RID: 7
	[Register("androidx/savedstate/SavedStateRegistryOwner", DoNotGenerateAcw = true)]
	internal class ISavedStateRegistryOwnerInvoker : Java.Lang.Object, ISavedStateRegistryOwner, ILifecycleOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002080 File Offset: 0x00000280
		private static IntPtr java_class_ref
		{
			get
			{
				return ISavedStateRegistryOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISavedStateRegistryOwnerInvoker._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020AB File Offset: 0x000002AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B3 File Offset: 0x000002B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISavedStateRegistryOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BF File Offset: 0x000002BF
		public static ISavedStateRegistryOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISavedStateRegistryOwner>(handle, transfer);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C8 File Offset: 0x000002C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISavedStateRegistryOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.savedstate.SavedStateRegistryOwner'.");
			}
			return handle;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020F3 File Offset: 0x000002F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002124 File Offset: 0x00000324
		public ISavedStateRegistryOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISavedStateRegistryOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
		private static Delegate GetGetSavedStateRegistryHandler()
		{
			if (ISavedStateRegistryOwnerInvoker.cb_getSavedStateRegistry == null)
			{
				ISavedStateRegistryOwnerInvoker.cb_getSavedStateRegistry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISavedStateRegistryOwnerInvoker.n_GetSavedStateRegistry));
			}
			return ISavedStateRegistryOwnerInvoker.cb_getSavedStateRegistry;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002180 File Offset: 0x00000380
		private static IntPtr n_GetSavedStateRegistry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISavedStateRegistryOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SavedStateRegistry);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002194 File Offset: 0x00000394
		public SavedStateRegistry SavedStateRegistry
		{
			get
			{
				if (this.id_getSavedStateRegistry == IntPtr.Zero)
				{
					this.id_getSavedStateRegistry = JNIEnv.GetMethodID(this.class_ref, "getSavedStateRegistry", "()Landroidx/savedstate/SavedStateRegistry;");
				}
				return Java.Lang.Object.GetObject<SavedStateRegistry>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSavedStateRegistry), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021E5 File Offset: 0x000003E5
		private static Delegate GetGetLifecycleHandler()
		{
			if (ISavedStateRegistryOwnerInvoker.cb_getLifecycle == null)
			{
				ISavedStateRegistryOwnerInvoker.cb_getLifecycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISavedStateRegistryOwnerInvoker.n_GetLifecycle));
			}
			return ISavedStateRegistryOwnerInvoker.cb_getLifecycle;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002209 File Offset: 0x00000409
		private static IntPtr n_GetLifecycle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISavedStateRegistryOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lifecycle);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002220 File Offset: 0x00000420
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

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/savedstate/SavedStateRegistryOwner", typeof(ISavedStateRegistryOwnerInvoker));

		// Token: 0x04000004 RID: 4
		private IntPtr class_ref;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getSavedStateRegistry;

		// Token: 0x04000006 RID: 6
		private IntPtr id_getSavedStateRegistry;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getLifecycle;

		// Token: 0x04000008 RID: 8
		private IntPtr id_getLifecycle;
	}
}
