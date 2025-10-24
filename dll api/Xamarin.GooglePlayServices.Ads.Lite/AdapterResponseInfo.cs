using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Android.Gms.Ads
{
	// Token: 0x0200000C RID: 12
	[Register("com/google/android/gms/ads/AdapterResponseInfo", DoNotGenerateAcw = true)]
	public sealed class AdapterResponseInfo : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		internal static IntPtr class_ref
		{
			get
			{
				return AdapterResponseInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002074 File Offset: 0x00000274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdapterResponseInfo._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000207C File Offset: 0x0000027C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdapterResponseInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000020A0 File Offset: 0x000002A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdapterResponseInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020AC File Offset: 0x000002AC
		internal AdapterResponseInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000020B8 File Offset: 0x000002B8
		public AdError AdError
		{
			[Register("getAdError", "()Lcom/google/android/gms/ads/AdError;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AdError>(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdError.()Lcom/google/android/gms/ads/AdError;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000020EC File Offset: 0x000002EC
		public string AdSourceId
		{
			[Register("getAdSourceId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSourceId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002120 File Offset: 0x00000320
		public string AdSourceInstanceId
		{
			[Register("getAdSourceInstanceId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSourceInstanceId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002154 File Offset: 0x00000354
		public string AdSourceInstanceName
		{
			[Register("getAdSourceInstanceName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSourceInstanceName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002188 File Offset: 0x00000388
		public string AdSourceName
		{
			[Register("getAdSourceName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSourceName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000021BC File Offset: 0x000003BC
		public string AdapterClassName
		{
			[Register("getAdapterClassName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getAdapterClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021F0 File Offset: 0x000003F0
		public Bundle Credentials
		{
			[Register("getCredentials", "()Landroid/os/Bundle;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(AdapterResponseInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getCredentials.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002222 File Offset: 0x00000422
		public long LatencyMillis
		{
			[Register("getLatencyMillis", "()J", "")]
			get
			{
				return AdapterResponseInfo._members.InstanceMethods.InvokeAbstractInt64Method("getLatencyMillis.()J", this, null);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000223C File Offset: 0x0000043C
		[Register("zzb", "()Lorg/json/JSONObject;", "")]
		public JSONObject Zzb()
		{
			return Java.Lang.Object.GetObject<JSONObject>(AdapterResponseInfo._members.InstanceMethods.InvokeNonvirtualObjectMethod("zzb.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdapterResponseInfo", typeof(AdapterResponseInfo));
	}
}
