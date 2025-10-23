using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x0200003A RID: 58
	[Register("com/google/android/gms/ads/initialization/AdapterStatus", DoNotGenerateAcw = true)]
	internal class IAdapterStatusInvoker : Java.Lang.Object, IAdapterStatus, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00007204 File Offset: 0x00005404
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdapterStatusInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007228 File Offset: 0x00005428
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdapterStatusInvoker._members;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000722F File Offset: 0x0000542F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00007237 File Offset: 0x00005437
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdapterStatusInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00007243 File Offset: 0x00005443
		public static IAdapterStatus GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdapterStatus>(handle, transfer);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000724C File Offset: 0x0000544C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdapterStatusInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.initialization.AdapterStatus'.");
			}
			return handle;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00007277 File Offset: 0x00005477
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000072A8 File Offset: 0x000054A8
		public IAdapterStatusInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdapterStatusInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000072E0 File Offset: 0x000054E0
		private static Delegate GetGetDescriptionHandler()
		{
			if (IAdapterStatusInvoker.cb_getDescription == null)
			{
				IAdapterStatusInvoker.cb_getDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdapterStatusInvoker.n_GetDescription));
			}
			return IAdapterStatusInvoker.cb_getDescription;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00007304 File Offset: 0x00005504
		private static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAdapterStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Description);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00007318 File Offset: 0x00005518
		public string Description
		{
			get
			{
				if (this.id_getDescription == IntPtr.Zero)
				{
					this.id_getDescription = JNIEnv.GetMethodID(this.class_ref, "getDescription", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007369 File Offset: 0x00005569
		private static Delegate GetGetInitializationStateHandler()
		{
			if (IAdapterStatusInvoker.cb_getInitializationState == null)
			{
				IAdapterStatusInvoker.cb_getInitializationState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdapterStatusInvoker.n_GetInitializationState));
			}
			return IAdapterStatusInvoker.cb_getInitializationState;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000738D File Offset: 0x0000558D
		private static IntPtr n_GetInitializationState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAdapterStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializationState);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000073A4 File Offset: 0x000055A4
		public AdapterStatusState InitializationState
		{
			get
			{
				if (this.id_getInitializationState == IntPtr.Zero)
				{
					this.id_getInitializationState = JNIEnv.GetMethodID(this.class_ref, "getInitializationState", "()Lcom/google/android/gms/ads/initialization/AdapterStatus$State;");
				}
				return Java.Lang.Object.GetObject<AdapterStatusState>(JNIEnv.CallObjectMethod(base.Handle, this.id_getInitializationState), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000073F5 File Offset: 0x000055F5
		private static Delegate GetGetLatencyHandler()
		{
			if (IAdapterStatusInvoker.cb_getLatency == null)
			{
				IAdapterStatusInvoker.cb_getLatency = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IAdapterStatusInvoker.n_GetLatency));
			}
			return IAdapterStatusInvoker.cb_getLatency;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00007419 File Offset: 0x00005619
		private static int n_GetLatency(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAdapterStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Latency;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007428 File Offset: 0x00005628
		public int Latency
		{
			get
			{
				if (this.id_getLatency == IntPtr.Zero)
				{
					this.id_getLatency = JNIEnv.GetMethodID(this.class_ref, "getLatency", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getLatency);
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/initialization/AdapterStatus", typeof(IAdapterStatusInvoker));

		// Token: 0x04000089 RID: 137
		private IntPtr class_ref;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_getDescription;

		// Token: 0x0400008B RID: 139
		private IntPtr id_getDescription;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_getInitializationState;

		// Token: 0x0400008D RID: 141
		private IntPtr id_getInitializationState;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_getLatency;

		// Token: 0x0400008F RID: 143
		private IntPtr id_getLatency;
	}
}
