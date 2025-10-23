using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Android.Gms.Ads
{
	// Token: 0x0200001E RID: 30
	[Register("com/google/android/gms/ads/LoadAdError", DoNotGenerateAcw = true)]
	public sealed class LoadAdError : AdError
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000043C8 File Offset: 0x000025C8
		internal new static IntPtr class_ref
		{
			get
			{
				return LoadAdError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000043EC File Offset: 0x000025EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadAdError._members;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000043F4 File Offset: 0x000025F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadAdError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00004418 File Offset: 0x00002618
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadAdError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002740 File Offset: 0x00000940
		internal LoadAdError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004424 File Offset: 0x00002624
		[Register(".ctor", "(ILjava/lang/String;Ljava/lang/String;Lcom/google/android/gms/ads/AdError;Lcom/google/android/gms/ads/ResponseInfo;)V", "")]
		public unsafe LoadAdError(int code, string message, string domain, AdError cause, ResponseInfo responseInfo) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			IntPtr intPtr2 = JNIEnv.NewString(domain);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				ptr[4] = new JniArgumentValue((responseInfo == null) ? IntPtr.Zero : responseInfo.Handle);
				base.SetHandle(LoadAdError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Ljava/lang/String;Lcom/google/android/gms/ads/AdError;Lcom/google/android/gms/ads/ResponseInfo;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadAdError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Ljava/lang/String;Lcom/google/android/gms/ads/AdError;Lcom/google/android/gms/ads/ResponseInfo;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(cause);
				GC.KeepAlive(responseInfo);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000455C File Offset: 0x0000275C
		public ResponseInfo ResponseInfo
		{
			[Register("getResponseInfo", "()Lcom/google/android/gms/ads/ResponseInfo;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ResponseInfo>(LoadAdError._members.InstanceMethods.InvokeAbstractObjectMethod("getResponseInfo.()Lcom/google/android/gms/ads/ResponseInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004590 File Offset: 0x00002790
		[Register("zzb", "()Lorg/json/JSONObject;", "")]
		public sealed override JSONObject Zzb()
		{
			return Java.Lang.Object.GetObject<JSONObject>(LoadAdError._members.InstanceMethods.InvokeNonvirtualObjectMethod("zzb.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000038 RID: 56
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/LoadAdError", typeof(LoadAdError));
	}
}
