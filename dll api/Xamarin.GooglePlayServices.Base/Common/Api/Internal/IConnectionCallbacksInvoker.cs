using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000028 RID: 40
	[Register("com/google/android/gms/common/api/internal/ConnectionCallbacks", DoNotGenerateAcw = true)]
	internal class IConnectionCallbacksInvoker : Java.Lang.Object, IConnectionCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000057F0 File Offset: 0x000039F0
		private static IntPtr java_class_ref
		{
			get
			{
				return IConnectionCallbacksInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00005814 File Offset: 0x00003A14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConnectionCallbacksInvoker._members;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000581B File Offset: 0x00003A1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00005823 File Offset: 0x00003A23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConnectionCallbacksInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000582F File Offset: 0x00003A2F
		public static IConnectionCallbacks GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConnectionCallbacks>(handle, transfer);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005838 File Offset: 0x00003A38
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConnectionCallbacksInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.ConnectionCallbacks'.");
			}
			return handle;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005863 File Offset: 0x00003A63
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005894 File Offset: 0x00003A94
		public IConnectionCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConnectionCallbacksInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000058CC File Offset: 0x00003ACC
		private static Delegate GetOnConnected_Landroid_os_Bundle_Handler()
		{
			if (IConnectionCallbacksInvoker.cb_onConnected_Landroid_os_Bundle_ == null)
			{
				IConnectionCallbacksInvoker.cb_onConnected_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConnectionCallbacksInvoker.n_OnConnected_Landroid_os_Bundle_));
			}
			return IConnectionCallbacksInvoker.cb_onConnected_Landroid_os_Bundle_;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000058F0 File Offset: 0x00003AF0
		private static void n_OnConnected_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConnectionCallbacks @object = Java.Lang.Object.GetObject<IConnectionCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnConnected(object2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005914 File Offset: 0x00003B14
		public unsafe void OnConnected(Bundle p0)
		{
			if (this.id_onConnected_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onConnected_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onConnected", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnected_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005987 File Offset: 0x00003B87
		private static Delegate GetOnConnectionSuspended_IHandler()
		{
			if (IConnectionCallbacksInvoker.cb_onConnectionSuspended_I == null)
			{
				IConnectionCallbacksInvoker.cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IConnectionCallbacksInvoker.n_OnConnectionSuspended_I));
			}
			return IConnectionCallbacksInvoker.cb_onConnectionSuspended_I;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000059AB File Offset: 0x00003BAB
		private static void n_OnConnectionSuspended_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IConnectionCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnConnectionSuspended(p0);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000059BC File Offset: 0x00003BBC
		public unsafe void OnConnectionSuspended(int p0)
		{
			if (this.id_onConnectionSuspended_I == IntPtr.Zero)
			{
				this.id_onConnectionSuspended_I = JNIEnv.GetMethodID(this.class_ref, "onConnectionSuspended", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnectionSuspended_I, ptr);
		}

		// Token: 0x0400003E RID: 62
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/ConnectionCallbacks", typeof(IConnectionCallbacksInvoker));

		// Token: 0x0400003F RID: 63
		private IntPtr class_ref;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_onConnected_Landroid_os_Bundle_;

		// Token: 0x04000041 RID: 65
		private IntPtr id_onConnected_Landroid_os_Bundle_;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onConnectionSuspended_I;

		// Token: 0x04000043 RID: 67
		private IntPtr id_onConnectionSuspended_I;
	}
}
