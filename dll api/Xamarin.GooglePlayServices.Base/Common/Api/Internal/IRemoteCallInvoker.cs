using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200002C RID: 44
	[Register("com/google/android/gms/common/api/internal/RemoteCall", DoNotGenerateAcw = true)]
	internal class IRemoteCallInvoker : Java.Lang.Object, IRemoteCall, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00005BF0 File Offset: 0x00003DF0
		private static IntPtr java_class_ref
		{
			get
			{
				return IRemoteCallInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00005C14 File Offset: 0x00003E14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRemoteCallInvoker._members;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00005C1B File Offset: 0x00003E1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00005C23 File Offset: 0x00003E23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRemoteCallInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005C2F File Offset: 0x00003E2F
		public static IRemoteCall GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRemoteCall>(handle, transfer);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005C38 File Offset: 0x00003E38
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRemoteCallInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.RemoteCall'.");
			}
			return handle;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005C63 File Offset: 0x00003E63
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005C94 File Offset: 0x00003E94
		public IRemoteCallInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRemoteCallInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005CCC File Offset: 0x00003ECC
		private static Delegate GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IRemoteCallInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IRemoteCallInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IRemoteCallInvoker.n_Accept_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IRemoteCallInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005CF0 File Offset: 0x00003EF0
		private static void n_Accept_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IRemoteCall @object = Java.Lang.Object.GetObject<IRemoteCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Accept(object2, object3);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005D1C File Offset: 0x00003F1C
		public unsafe void Accept(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			if (this.id_accept_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "accept", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_accept_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x04000048 RID: 72
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/RemoteCall", typeof(IRemoteCallInvoker));

		// Token: 0x04000049 RID: 73
		private IntPtr class_ref;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_accept_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400004B RID: 75
		private IntPtr id_accept_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
