using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Android.Gms.Ads
{
	// Token: 0x02000022 RID: 34
	[Register("com/google/android/gms/ads/ResponseInfo", DoNotGenerateAcw = true)]
	public sealed class ResponseInfo : Java.Lang.Object
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000519C File Offset: 0x0000339C
		internal static IntPtr class_ref
		{
			get
			{
				return ResponseInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000051C0 File Offset: 0x000033C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResponseInfo._members;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000051C8 File Offset: 0x000033C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResponseInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000051EC File Offset: 0x000033EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResponseInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000020AC File Offset: 0x000002AC
		internal ResponseInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000051F8 File Offset: 0x000033F8
		public IList<AdapterResponseInfo> AdapterResponses
		{
			[Register("getAdapterResponses", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<AdapterResponseInfo>.FromJniHandle(ResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdapterResponses.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000522C File Offset: 0x0000342C
		public AdapterResponseInfo LoadedAdapterResponseInfo
		{
			[Register("getLoadedAdapterResponseInfo", "()Lcom/google/android/gms/ads/AdapterResponseInfo;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AdapterResponseInfo>(ResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getLoadedAdapterResponseInfo.()Lcom/google/android/gms/ads/AdapterResponseInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00005260 File Offset: 0x00003460
		public string MediationAdapterClassName
		{
			[Register("getMediationAdapterClassName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getMediationAdapterClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00005294 File Offset: 0x00003494
		public Bundle ResponseExtras
		{
			[Register("getResponseExtras", "()Landroid/os/Bundle;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(ResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getResponseExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000052C8 File Offset: 0x000034C8
		public string ResponseId
		{
			[Register("getResponseId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getResponseId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000052FC File Offset: 0x000034FC
		[Register("zzd", "()Lorg/json/JSONObject;", "")]
		public JSONObject Zzd()
		{
			return Java.Lang.Object.GetObject<JSONObject>(ResponseInfo._members.InstanceMethods.InvokeNonvirtualObjectMethod("zzd.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000046 RID: 70
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/ResponseInfo", typeof(ResponseInfo));
	}
}
