using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000061 RID: 97
	[Register("com/google/android/gms/common/api/GoogleApiClient", DoNotGenerateAcw = true)]
	internal class GoogleApiClientInvoker : GoogleApiClient
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x0000D03B File Offset: 0x0000B23B
		public GoogleApiClientInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0000D045 File Offset: 0x0000B245
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleApiClientInvoker._members;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000D04C File Offset: 0x0000B24C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleApiClientInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000D058 File Offset: 0x0000B258
		public override bool IsConnected
		{
			[Register("isConnected", "()Z", "GetIsConnectedHandler")]
			get
			{
				return GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isConnected.()Z", this, null);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000D071 File Offset: 0x0000B271
		public override bool IsConnecting
		{
			[Register("isConnecting", "()Z", "GetIsConnectingHandler")]
			get
			{
				return GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isConnecting.()Z", this, null);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000D08C File Offset: 0x0000B28C
		[Register("blockingConnect", "()Lcom/google/android/gms/common/ConnectionResult;", "GetBlockingConnectHandler")]
		public override ConnectionResult BlockingConnect()
		{
			return Java.Lang.Object.GetObject<ConnectionResult>(GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("blockingConnect.()Lcom/google/android/gms/common/ConnectionResult;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		[Register("blockingConnect", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/ConnectionResult;", "GetBlockingConnect_JLjava_util_concurrent_TimeUnit_Handler")]
		public unsafe override ConnectionResult BlockingConnect(long p0, TimeUnit p1)
		{
			ConnectionResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<ConnectionResult>(GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("blockingConnect.(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/ConnectionResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000D148 File Offset: 0x0000B348
		[Register("clearDefaultAccountAndReconnect", "()Lcom/google/android/gms/common/api/PendingResult;", "GetClearDefaultAccountAndReconnectHandler")]
		public override PendingResult ClearDefaultAccountAndReconnect()
		{
			return Java.Lang.Object.GetObject<PendingResult>(GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("clearDefaultAccountAndReconnect.()Lcom/google/android/gms/common/api/PendingResult;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000D17A File Offset: 0x0000B37A
		[Register("connect", "()V", "GetConnectHandler")]
		public override void Connect()
		{
			GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("connect.()V", this, null);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000D193 File Offset: 0x0000B393
		[Register("disconnect", "()V", "GetDisconnectHandler")]
		public override void Disconnect()
		{
			GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("disconnect.()V", this, null);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe override void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p3);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("dump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p3 != null)
				{
					JNIEnv.CopyArray(intPtr2, p3);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000D294 File Offset: 0x0000B494
		[Register("getConnectionResult", "(Lcom/google/android/gms/common/api/Api;)Lcom/google/android/gms/common/ConnectionResult;", "GetGetConnectionResult_Lcom_google_android_gms_common_api_Api_Handler")]
		public unsafe override ConnectionResult GetConnectionResult(Api p0)
		{
			ConnectionResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<ConnectionResult>(GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getConnectionResult.(Lcom/google/android/gms/common/api/Api;)Lcom/google/android/gms/common/ConnectionResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000D308 File Offset: 0x0000B508
		[Register("hasConnectedApi", "(Lcom/google/android/gms/common/api/Api;)Z", "GetHasConnectedApi_Lcom_google_android_gms_common_api_Api_Handler")]
		public unsafe override bool HasConnectedApi(Api p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasConnectedApi.(Lcom/google/android/gms/common/api/Api;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000D370 File Offset: 0x0000B570
		[Register("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)Z", "GetIsConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler")]
		public unsafe override bool IsConnectionCallbacksRegistered(GoogleApiClient.IConnectionCallbacks p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				result = GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isConnectionCallbacksRegistered.(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		[Register("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)Z", "GetIsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler")]
		public unsafe override bool IsConnectionFailedListenerRegistered(GoogleApiClient.IOnConnectionFailedListener p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				result = GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isConnectionFailedListenerRegistered.(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000D448 File Offset: 0x0000B648
		[Register("reconnect", "()V", "GetReconnectHandler")]
		public override void Reconnect()
		{
			GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("reconnect.()V", this, null);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000D464 File Offset: 0x0000B664
		[Register("registerConnectionCallbacks", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", "GetRegisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler")]
		public unsafe override void RegisterConnectionCallbacks(GoogleApiClient.IConnectionCallbacks p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("registerConnectionCallbacks.(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		[Register("registerConnectionFailedListener", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", "GetRegisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler")]
		public unsafe override void RegisterConnectionFailedListener(GoogleApiClient.IOnConnectionFailedListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("registerConnectionFailedListener.(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000D534 File Offset: 0x0000B734
		[Register("stopAutoManage", "(Landroidx/fragment/app/FragmentActivity;)V", "GetStopAutoManage_Landroidx_fragment_app_FragmentActivity_Handler")]
		public unsafe override void StopAutoManage(FragmentActivity p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("stopAutoManage.(Landroidx/fragment/app/FragmentActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000D598 File Offset: 0x0000B798
		[Register("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", "GetUnregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler")]
		public unsafe override void UnregisterConnectionCallbacks(GoogleApiClient.IConnectionCallbacks p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("unregisterConnectionCallbacks.(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000D600 File Offset: 0x0000B800
		[Register("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", "GetUnregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler")]
		public unsafe override void UnregisterConnectionFailedListener(GoogleApiClient.IOnConnectionFailedListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				GoogleApiClientInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("unregisterConnectionFailedListener.(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApiClient", typeof(GoogleApiClientInvoker));
	}
}
