using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Android.Gms.Ads
{
	// Token: 0x0200000D RID: 13
	[Register("com/google/android/gms/ads/AdError", DoNotGenerateAcw = true)]
	public class AdError : Java.Lang.Object
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000228C File Offset: 0x0000048C
		internal static IntPtr class_ref
		{
			get
			{
				return AdError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022B0 File Offset: 0x000004B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdError._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000022B8 File Offset: 0x000004B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000022DC File Offset: 0x000004DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdError._members.ManagedPeerType;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020AC File Offset: 0x000002AC
		protected AdError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022E8 File Offset: 0x000004E8
		[Register(".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AdError(int code, string message, string domain) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			IntPtr intPtr2 = JNIEnv.NewString(domain);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				base.SetHandle(AdError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000023C4 File Offset: 0x000005C4
		[Register(".ctor", "(ILjava/lang/String;Ljava/lang/String;Lcom/google/android/gms/ads/AdError;)V", "")]
		public unsafe AdError(int code, string message, string domain, AdError cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			IntPtr intPtr2 = JNIEnv.NewString(domain);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(AdError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Ljava/lang/String;Lcom/google/android/gms/ads/AdError;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Ljava/lang/String;Lcom/google/android/gms/ads/AdError;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000024CC File Offset: 0x000006CC
		private static Delegate GetGetCauseHandler()
		{
			if (AdError.cb_getCause == null)
			{
				AdError.cb_getCause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdError.n_GetCause));
			}
			return AdError.cb_getCause;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000024F0 File Offset: 0x000006F0
		private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cause);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002504 File Offset: 0x00000704
		public virtual AdError Cause
		{
			[Register("getCause", "()Lcom/google/android/gms/ads/AdError;", "GetGetCauseHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdError>(AdError._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Lcom/google/android/gms/ads/AdError;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002536 File Offset: 0x00000736
		private static Delegate GetGetCodeHandler()
		{
			if (AdError.cb_getCode == null)
			{
				AdError.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdError.n_GetCode));
			}
			return AdError.cb_getCode;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000255A File Offset: 0x0000075A
		private static int n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002569 File Offset: 0x00000769
		public virtual int Code
		{
			[Register("getCode", "()I", "GetGetCodeHandler")]
			get
			{
				return AdError._members.InstanceMethods.InvokeVirtualInt32Method("getCode.()I", this, null);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002582 File Offset: 0x00000782
		private static Delegate GetGetDomainHandler()
		{
			if (AdError.cb_getDomain == null)
			{
				AdError.cb_getDomain = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdError.n_GetDomain));
			}
			return AdError.cb_getDomain;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025A6 File Offset: 0x000007A6
		private static IntPtr n_GetDomain(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Domain);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000025BC File Offset: 0x000007BC
		public virtual string Domain
		{
			[Register("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get
			{
				return JNIEnv.GetString(AdError._members.InstanceMethods.InvokeVirtualObjectMethod("getDomain.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025EE File Offset: 0x000007EE
		private static Delegate GetGetMessageHandler()
		{
			if (AdError.cb_getMessage == null)
			{
				AdError.cb_getMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdError.n_GetMessage));
			}
			return AdError.cb_getMessage;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002612 File Offset: 0x00000812
		private static IntPtr n_GetMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002628 File Offset: 0x00000828
		public virtual string Message
		{
			[Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get
			{
				return JNIEnv.GetString(AdError._members.InstanceMethods.InvokeVirtualObjectMethod("getMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000265A File Offset: 0x0000085A
		private static Delegate GetZzbHandler()
		{
			if (AdError.cb_zzb == null)
			{
				AdError.cb_zzb = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdError.n_Zzb));
			}
			return AdError.cb_zzb;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000267E File Offset: 0x0000087E
		private static IntPtr n_Zzb(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Zzb());
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002694 File Offset: 0x00000894
		[Register("zzb", "()Lorg/json/JSONObject;", "GetZzbHandler")]
		public virtual JSONObject Zzb()
		{
			return Java.Lang.Object.GetObject<JSONObject>(AdError._members.InstanceMethods.InvokeVirtualObjectMethod("zzb.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000002 RID: 2
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdError", typeof(AdError));

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getCause;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getCode;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getDomain;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getMessage;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_zzb;
	}
}
