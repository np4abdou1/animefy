using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200002E RID: 46
	[Register("com/google/android/gms/common/api/internal/SignInConnectionListener", DoNotGenerateAcw = true)]
	internal class ISignInConnectionListenerInvoker : Java.Lang.Object, ISignInConnectionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005DC8 File Offset: 0x00003FC8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISignInConnectionListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00005DEC File Offset: 0x00003FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISignInConnectionListenerInvoker._members;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00005DF3 File Offset: 0x00003FF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00005DFB File Offset: 0x00003FFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISignInConnectionListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005E07 File Offset: 0x00004007
		public static ISignInConnectionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISignInConnectionListener>(handle, transfer);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005E10 File Offset: 0x00004010
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISignInConnectionListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.SignInConnectionListener'.");
			}
			return handle;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005E3B File Offset: 0x0000403B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00005E6C File Offset: 0x0000406C
		public ISignInConnectionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISignInConnectionListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005EA4 File Offset: 0x000040A4
		private static Delegate GetOnCompleteHandler()
		{
			if (ISignInConnectionListenerInvoker.cb_onComplete == null)
			{
				ISignInConnectionListenerInvoker.cb_onComplete = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISignInConnectionListenerInvoker.n_OnComplete));
			}
			return ISignInConnectionListenerInvoker.cb_onComplete;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005EC8 File Offset: 0x000040C8
		private static void n_OnComplete(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISignInConnectionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnComplete();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005ED7 File Offset: 0x000040D7
		public void OnComplete()
		{
			if (this.id_onComplete == IntPtr.Zero)
			{
				this.id_onComplete = JNIEnv.GetMethodID(this.class_ref, "onComplete", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onComplete);
		}

		// Token: 0x0400004C RID: 76
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/SignInConnectionListener", typeof(ISignInConnectionListenerInvoker));

		// Token: 0x0400004D RID: 77
		private IntPtr class_ref;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_onComplete;

		// Token: 0x0400004F RID: 79
		private IntPtr id_onComplete;
	}
}
