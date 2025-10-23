using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x0200002A RID: 42
	[Register("androidx/activity/result/ActivityResultRegistryOwner", DoNotGenerateAcw = true)]
	internal class IActivityResultRegistryOwnerInvoker : Java.Lang.Object, IActivityResultRegistryOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00005234 File Offset: 0x00003434
		private static IntPtr java_class_ref
		{
			get
			{
				return IActivityResultRegistryOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00005258 File Offset: 0x00003458
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IActivityResultRegistryOwnerInvoker._members;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000525F File Offset: 0x0000345F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005267 File Offset: 0x00003467
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IActivityResultRegistryOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005273 File Offset: 0x00003473
		public static IActivityResultRegistryOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IActivityResultRegistryOwner>(handle, transfer);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000527C File Offset: 0x0000347C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IActivityResultRegistryOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.result.ActivityResultRegistryOwner'.");
			}
			return handle;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000052A7 File Offset: 0x000034A7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000052D8 File Offset: 0x000034D8
		public IActivityResultRegistryOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IActivityResultRegistryOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005310 File Offset: 0x00003510
		private static Delegate GetGetActivityResultRegistryHandler()
		{
			if (IActivityResultRegistryOwnerInvoker.cb_getActivityResultRegistry == null)
			{
				IActivityResultRegistryOwnerInvoker.cb_getActivityResultRegistry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActivityResultRegistryOwnerInvoker.n_GetActivityResultRegistry));
			}
			return IActivityResultRegistryOwnerInvoker.cb_getActivityResultRegistry;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005334 File Offset: 0x00003534
		private static IntPtr n_GetActivityResultRegistry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActivityResultRegistryOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActivityResultRegistry);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00005348 File Offset: 0x00003548
		public ActivityResultRegistry ActivityResultRegistry
		{
			get
			{
				if (this.id_getActivityResultRegistry == IntPtr.Zero)
				{
					this.id_getActivityResultRegistry = JNIEnv.GetMethodID(this.class_ref, "getActivityResultRegistry", "()Landroidx/activity/result/ActivityResultRegistry;");
				}
				return Java.Lang.Object.GetObject<ActivityResultRegistry>(JNIEnv.CallObjectMethod(base.Handle, this.id_getActivityResultRegistry), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultRegistryOwner", typeof(IActivityResultRegistryOwnerInvoker));

		// Token: 0x0400004B RID: 75
		private IntPtr class_ref;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_getActivityResultRegistry;

		// Token: 0x0400004D RID: 77
		private IntPtr id_getActivityResultRegistry;
	}
}
