using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Gms.Common.Api.Internal;
using Android.OS;
using Android.Runtime;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000046 RID: 70
	[Register("com/google/android/gms/common/api/GoogleApiClient", DoNotGenerateAcw = true)]
	public abstract class GoogleApiClient : Java.Lang.Object
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000092BC File Offset: 0x000074BC
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleApiClient._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000092E0 File Offset: 0x000074E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleApiClient._members;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x000092E8 File Offset: 0x000074E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleApiClient._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000930C File Offset: 0x0000750C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleApiClient._members.ManagedPeerType;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003280 File Offset: 0x00001480
		protected GoogleApiClient(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009318 File Offset: 0x00007518
		[Register(".ctor", "()V", "")]
		public GoogleApiClient() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GoogleApiClient._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GoogleApiClient._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00009388 File Offset: 0x00007588
		public static ICollection<GoogleApiClient> AllClients
		{
			[Register("getAllClients", "()Ljava/util/Set;", "")]
			get
			{
				return JavaSet<GoogleApiClient>.FromJniHandle(GoogleApiClient._members.StaticMethods.InvokeObjectMethod("getAllClients.()Ljava/util/Set;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000093B9 File Offset: 0x000075B9
		private static Delegate GetGetContextHandler()
		{
			if (GoogleApiClient.cb_getContext == null)
			{
				GoogleApiClient.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApiClient.n_GetContext));
			}
			return GoogleApiClient.cb_getContext;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000093DD File Offset: 0x000075DD
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000093F4 File Offset: 0x000075F4
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(GoogleApiClient._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009426 File Offset: 0x00007626
		private static Delegate GetIsConnectedHandler()
		{
			if (GoogleApiClient.cb_isConnected == null)
			{
				GoogleApiClient.cb_isConnected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GoogleApiClient.n_IsConnected));
			}
			return GoogleApiClient.cb_isConnected;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000944A File Offset: 0x0000764A
		private static bool n_IsConnected(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConnected;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002D1 RID: 721
		public abstract bool IsConnected { [Register("isConnected", "()Z", "GetIsConnectedHandler")] get; }

		// Token: 0x060002D2 RID: 722 RVA: 0x00009459 File Offset: 0x00007659
		private static Delegate GetIsConnectingHandler()
		{
			if (GoogleApiClient.cb_isConnecting == null)
			{
				GoogleApiClient.cb_isConnecting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GoogleApiClient.n_IsConnecting));
			}
			return GoogleApiClient.cb_isConnecting;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000947D File Offset: 0x0000767D
		private static bool n_IsConnecting(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConnecting;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002D4 RID: 724
		public abstract bool IsConnecting { [Register("isConnecting", "()Z", "GetIsConnectingHandler")] get; }

		// Token: 0x060002D5 RID: 725 RVA: 0x0000948C File Offset: 0x0000768C
		private static Delegate GetGetLooperHandler()
		{
			if (GoogleApiClient.cb_getLooper == null)
			{
				GoogleApiClient.cb_getLooper = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApiClient.n_GetLooper));
			}
			return GoogleApiClient.cb_getLooper;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000094B0 File Offset: 0x000076B0
		private static IntPtr n_GetLooper(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Looper);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000094C4 File Offset: 0x000076C4
		public virtual Looper Looper
		{
			[Register("getLooper", "()Landroid/os/Looper;", "GetGetLooperHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Looper>(GoogleApiClient._members.InstanceMethods.InvokeVirtualObjectMethod("getLooper.()Landroid/os/Looper;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000094F6 File Offset: 0x000076F6
		private static Delegate GetBlockingConnectHandler()
		{
			if (GoogleApiClient.cb_blockingConnect == null)
			{
				GoogleApiClient.cb_blockingConnect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApiClient.n_BlockingConnect));
			}
			return GoogleApiClient.cb_blockingConnect;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000951A File Offset: 0x0000771A
		private static IntPtr n_BlockingConnect(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BlockingConnect());
		}

		// Token: 0x060002DA RID: 730
		[Register("blockingConnect", "()Lcom/google/android/gms/common/ConnectionResult;", "GetBlockingConnectHandler")]
		public abstract ConnectionResult BlockingConnect();

		// Token: 0x060002DB RID: 731 RVA: 0x0000952E File Offset: 0x0000772E
		private static Delegate GetBlockingConnect_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (GoogleApiClient.cb_blockingConnect_JLjava_util_concurrent_TimeUnit_ == null)
			{
				GoogleApiClient.cb_blockingConnect_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(GoogleApiClient.n_BlockingConnect_JLjava_util_concurrent_TimeUnit_));
			}
			return GoogleApiClient.cb_blockingConnect_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00009554 File Offset: 0x00007754
		private static IntPtr n_BlockingConnect_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BlockingConnect(p0, object2));
		}

		// Token: 0x060002DD RID: 733
		[Register("blockingConnect", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/ConnectionResult;", "GetBlockingConnect_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract ConnectionResult BlockingConnect(long p0, TimeUnit p1);

		// Token: 0x060002DE RID: 734 RVA: 0x0000957D File Offset: 0x0000777D
		private static Delegate GetClearDefaultAccountAndReconnectHandler()
		{
			if (GoogleApiClient.cb_clearDefaultAccountAndReconnect == null)
			{
				GoogleApiClient.cb_clearDefaultAccountAndReconnect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApiClient.n_ClearDefaultAccountAndReconnect));
			}
			return GoogleApiClient.cb_clearDefaultAccountAndReconnect;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000095A1 File Offset: 0x000077A1
		private static IntPtr n_ClearDefaultAccountAndReconnect(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearDefaultAccountAndReconnect());
		}

		// Token: 0x060002E0 RID: 736
		[Register("clearDefaultAccountAndReconnect", "()Lcom/google/android/gms/common/api/PendingResult;", "GetClearDefaultAccountAndReconnectHandler")]
		public abstract PendingResult ClearDefaultAccountAndReconnect();

		// Token: 0x060002E1 RID: 737 RVA: 0x000095B5 File Offset: 0x000077B5
		private static Delegate GetConnectHandler()
		{
			if (GoogleApiClient.cb_connect == null)
			{
				GoogleApiClient.cb_connect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GoogleApiClient.n_Connect));
			}
			return GoogleApiClient.cb_connect;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000095D9 File Offset: 0x000077D9
		private static void n_Connect(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Connect();
		}

		// Token: 0x060002E3 RID: 739
		[Register("connect", "()V", "GetConnectHandler")]
		public abstract void Connect();

		// Token: 0x060002E4 RID: 740 RVA: 0x000095E8 File Offset: 0x000077E8
		private static Delegate GetConnect_IHandler()
		{
			if (GoogleApiClient.cb_connect_I == null)
			{
				GoogleApiClient.cb_connect_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(GoogleApiClient.n_Connect_I));
			}
			return GoogleApiClient.cb_connect_I;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000960C File Offset: 0x0000780C
		private static void n_Connect_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Connect(p0);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000961C File Offset: 0x0000781C
		[Register("connect", "(I)V", "GetConnect_IHandler")]
		public unsafe virtual void Connect(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			GoogleApiClient._members.InstanceMethods.InvokeVirtualVoidMethod("connect.(I)V", this, ptr);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00009657 File Offset: 0x00007857
		private static Delegate GetDisconnectHandler()
		{
			if (GoogleApiClient.cb_disconnect == null)
			{
				GoogleApiClient.cb_disconnect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GoogleApiClient.n_Disconnect));
			}
			return GoogleApiClient.cb_disconnect;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000967B File Offset: 0x0000787B
		private static void n_Disconnect(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Disconnect();
		}

		// Token: 0x060002E9 RID: 745
		[Register("disconnect", "()V", "GetDisconnectHandler")]
		public abstract void Disconnect();

		// Token: 0x060002EA RID: 746 RVA: 0x0000968A File Offset: 0x0000788A
		private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (GoogleApiClient.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				GoogleApiClient.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(GoogleApiClient.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return GoogleApiClient.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000096B0 File Offset: 0x000078B0
		private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_p1, JniHandleOwnership.DoNotTransfer);
			PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_p2, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.Dump(@string, object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p3);
			}
		}

		// Token: 0x060002EC RID: 748
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public abstract void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3);

		// Token: 0x060002ED RID: 749 RVA: 0x0000970C File Offset: 0x0000790C
		[Register("dumpAll", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "")]
		public unsafe static void DumpAll(string prefix, FileDescriptor fd, PrintWriter writer, string[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewArray(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((fd == null) ? IntPtr.Zero : fd.Handle);
				ptr[2] = new JniArgumentValue((writer == null) ? IntPtr.Zero : writer.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				GoogleApiClient._members.StaticMethods.InvokeVoidMethod("dumpAll.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(fd);
				GC.KeepAlive(writer);
				GC.KeepAlive(args);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000097EC File Offset: 0x000079EC
		private static Delegate GetEnqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler()
		{
			if (GoogleApiClient.cb_enqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ == null)
			{
				GoogleApiClient.cb_enqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApiClient.n_Enqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_));
			}
			return GoogleApiClient.cb_enqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00009810 File Offset: 0x00007A10
		private static IntPtr n_Enqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Enqueue(object2));
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00009838 File Offset: 0x00007A38
		[Register("enqueue", "(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", "GetEnqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"R extends com.google.android.gms.common.api.Result",
			"T extends com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl<R, A>"
		})]
		public unsafe virtual Java.Lang.Object Enqueue(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApiClient._members.InstanceMethods.InvokeVirtualObjectMethod("enqueue.(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000098AC File Offset: 0x00007AAC
		private static Delegate GetExecute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler()
		{
			if (GoogleApiClient.cb_execute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ == null)
			{
				GoogleApiClient.cb_execute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApiClient.n_Execute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_));
			}
			return GoogleApiClient.cb_execute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000098D0 File Offset: 0x00007AD0
		private static IntPtr n_Execute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Execute(object2));
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000098F8 File Offset: 0x00007AF8
		[Register("execute", "(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", "GetExecute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"T extends com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl<? extends com.google.android.gms.common.api.Result, A>"
		})]
		public unsafe virtual Java.Lang.Object Execute(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApiClient._members.InstanceMethods.InvokeVirtualObjectMethod("execute.(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000996C File Offset: 0x00007B6C
		private static Delegate GetGetClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_Handler()
		{
			if (GoogleApiClient.cb_getClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_ == null)
			{
				GoogleApiClient.cb_getClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApiClient.n_GetClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_));
			}
			return GoogleApiClient.cb_getClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00009990 File Offset: 0x00007B90
		private static IntPtr n_GetClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Api.AnyClientKey object2 = Java.Lang.Object.GetObject<Api.AnyClientKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetClient(object2));
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000099B8 File Offset: 0x00007BB8
		[Register("getClient", "(Lcom/google/android/gms/common/api/Api$AnyClientKey;)Lcom/google/android/gms/common/api/Api$Client;", "GetGetClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_Handler")]
		[JavaTypeParameters(new string[]
		{
			"C extends com.google.android.gms.common.api.Api.Client"
		})]
		public unsafe virtual Java.Lang.Object GetClient(Api.AnyClientKey p0)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApiClient._members.InstanceMethods.InvokeVirtualObjectMethod("getClient.(Lcom/google/android/gms/common/api/Api$AnyClientKey;)Lcom/google/android/gms/common/api/Api$Client;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00009A2C File Offset: 0x00007C2C
		private static Delegate GetGetConnectionResult_Lcom_google_android_gms_common_api_Api_Handler()
		{
			if (GoogleApiClient.cb_getConnectionResult_Lcom_google_android_gms_common_api_Api_ == null)
			{
				GoogleApiClient.cb_getConnectionResult_Lcom_google_android_gms_common_api_Api_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApiClient.n_GetConnectionResult_Lcom_google_android_gms_common_api_Api_));
			}
			return GoogleApiClient.cb_getConnectionResult_Lcom_google_android_gms_common_api_Api_;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00009A50 File Offset: 0x00007C50
		private static IntPtr n_GetConnectionResult_Lcom_google_android_gms_common_api_Api_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Api object2 = Java.Lang.Object.GetObject<Api>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetConnectionResult(object2));
		}

		// Token: 0x060002F9 RID: 761
		[Register("getConnectionResult", "(Lcom/google/android/gms/common/api/Api;)Lcom/google/android/gms/common/ConnectionResult;", "GetGetConnectionResult_Lcom_google_android_gms_common_api_Api_Handler")]
		public abstract ConnectionResult GetConnectionResult(Api p0);

		// Token: 0x060002FA RID: 762 RVA: 0x00009A78 File Offset: 0x00007C78
		private static Delegate GetHasApi_Lcom_google_android_gms_common_api_Api_Handler()
		{
			if (GoogleApiClient.cb_hasApi_Lcom_google_android_gms_common_api_Api_ == null)
			{
				GoogleApiClient.cb_hasApi_Lcom_google_android_gms_common_api_Api_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GoogleApiClient.n_HasApi_Lcom_google_android_gms_common_api_Api_));
			}
			return GoogleApiClient.cb_hasApi_Lcom_google_android_gms_common_api_Api_;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009A9C File Offset: 0x00007C9C
		private static bool n_HasApi_Lcom_google_android_gms_common_api_Api_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Api object2 = Java.Lang.Object.GetObject<Api>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.HasApi(object2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00009AC0 File Offset: 0x00007CC0
		[Register("hasApi", "(Lcom/google/android/gms/common/api/Api;)Z", "GetHasApi_Lcom_google_android_gms_common_api_Api_Handler")]
		public unsafe virtual bool HasApi(Api p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = GoogleApiClient._members.InstanceMethods.InvokeVirtualBooleanMethod("hasApi.(Lcom/google/android/gms/common/api/Api;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00009B28 File Offset: 0x00007D28
		private static Delegate GetHasConnectedApi_Lcom_google_android_gms_common_api_Api_Handler()
		{
			if (GoogleApiClient.cb_hasConnectedApi_Lcom_google_android_gms_common_api_Api_ == null)
			{
				GoogleApiClient.cb_hasConnectedApi_Lcom_google_android_gms_common_api_Api_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GoogleApiClient.n_HasConnectedApi_Lcom_google_android_gms_common_api_Api_));
			}
			return GoogleApiClient.cb_hasConnectedApi_Lcom_google_android_gms_common_api_Api_;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00009B4C File Offset: 0x00007D4C
		private static bool n_HasConnectedApi_Lcom_google_android_gms_common_api_Api_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Api object2 = Java.Lang.Object.GetObject<Api>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.HasConnectedApi(object2);
		}

		// Token: 0x060002FF RID: 767
		[Register("hasConnectedApi", "(Lcom/google/android/gms/common/api/Api;)Z", "GetHasConnectedApi_Lcom_google_android_gms_common_api_Api_Handler")]
		public abstract bool HasConnectedApi(Api p0);

		// Token: 0x06000300 RID: 768 RVA: 0x00009B6F File Offset: 0x00007D6F
		private static Delegate GetIsConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler()
		{
			if (GoogleApiClient.cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_ == null)
			{
				GoogleApiClient.cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GoogleApiClient.n_IsConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_));
			}
			return GoogleApiClient.cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00009B94 File Offset: 0x00007D94
		private static bool n_IsConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GoogleApiClient.IConnectionCallbacks object2 = Java.Lang.Object.GetObject<GoogleApiClient.IConnectionCallbacks>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.IsConnectionCallbacksRegistered(object2);
		}

		// Token: 0x06000302 RID: 770
		[Register("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)Z", "GetIsConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler")]
		public abstract bool IsConnectionCallbacksRegistered(GoogleApiClient.IConnectionCallbacks p0);

		// Token: 0x06000303 RID: 771 RVA: 0x00009BB7 File Offset: 0x00007DB7
		private static Delegate GetIsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler()
		{
			if (GoogleApiClient.cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_ == null)
			{
				GoogleApiClient.cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GoogleApiClient.n_IsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_));
			}
			return GoogleApiClient.cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00009BDC File Offset: 0x00007DDC
		private static bool n_IsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GoogleApiClient.IOnConnectionFailedListener object2 = Java.Lang.Object.GetObject<GoogleApiClient.IOnConnectionFailedListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.IsConnectionFailedListenerRegistered(object2);
		}

		// Token: 0x06000305 RID: 773
		[Register("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)Z", "GetIsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler")]
		public abstract bool IsConnectionFailedListenerRegistered(GoogleApiClient.IOnConnectionFailedListener p0);

		// Token: 0x06000306 RID: 774 RVA: 0x00009BFF File Offset: 0x00007DFF
		private static Delegate GetMaybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_Handler()
		{
			if (GoogleApiClient.cb_maybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_ == null)
			{
				GoogleApiClient.cb_maybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GoogleApiClient.n_MaybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_));
			}
			return GoogleApiClient.cb_maybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00009C24 File Offset: 0x00007E24
		private static bool n_MaybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISignInConnectionListener object2 = Java.Lang.Object.GetObject<ISignInConnectionListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.MaybeSignIn(object2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00009C48 File Offset: 0x00007E48
		[Register("maybeSignIn", "(Lcom/google/android/gms/common/api/internal/SignInConnectionListener;)Z", "GetMaybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_Handler")]
		public unsafe virtual bool MaybeSignIn(ISignInConnectionListener p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				result = GoogleApiClient._members.InstanceMethods.InvokeVirtualBooleanMethod("maybeSignIn.(Lcom/google/android/gms/common/api/internal/SignInConnectionListener;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00009CB4 File Offset: 0x00007EB4
		private static Delegate GetMaybeSignOutHandler()
		{
			if (GoogleApiClient.cb_maybeSignOut == null)
			{
				GoogleApiClient.cb_maybeSignOut = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GoogleApiClient.n_MaybeSignOut));
			}
			return GoogleApiClient.cb_maybeSignOut;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00009CD8 File Offset: 0x00007ED8
		private static void n_MaybeSignOut(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaybeSignOut();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00009CE7 File Offset: 0x00007EE7
		[Register("maybeSignOut", "()V", "GetMaybeSignOutHandler")]
		public virtual void MaybeSignOut()
		{
			GoogleApiClient._members.InstanceMethods.InvokeVirtualVoidMethod("maybeSignOut.()V", this, null);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00009D00 File Offset: 0x00007F00
		private static Delegate GetReconnectHandler()
		{
			if (GoogleApiClient.cb_reconnect == null)
			{
				GoogleApiClient.cb_reconnect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GoogleApiClient.n_Reconnect));
			}
			return GoogleApiClient.cb_reconnect;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00009D24 File Offset: 0x00007F24
		private static void n_Reconnect(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reconnect();
		}

		// Token: 0x0600030E RID: 782
		[Register("reconnect", "()V", "GetReconnectHandler")]
		public abstract void Reconnect();

		// Token: 0x0600030F RID: 783 RVA: 0x00009D33 File Offset: 0x00007F33
		private static Delegate GetRegisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler()
		{
			if (GoogleApiClient.cb_registerConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_ == null)
			{
				GoogleApiClient.cb_registerConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.n_RegisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_));
			}
			return GoogleApiClient.cb_registerConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00009D58 File Offset: 0x00007F58
		private static void n_RegisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GoogleApiClient.IConnectionCallbacks object2 = Java.Lang.Object.GetObject<GoogleApiClient.IConnectionCallbacks>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RegisterConnectionCallbacks(object2);
		}

		// Token: 0x06000311 RID: 785
		[Register("registerConnectionCallbacks", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", "GetRegisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler")]
		public abstract void RegisterConnectionCallbacks(GoogleApiClient.IConnectionCallbacks p0);

		// Token: 0x06000312 RID: 786 RVA: 0x00009D7B File Offset: 0x00007F7B
		private static Delegate GetRegisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler()
		{
			if (GoogleApiClient.cb_registerConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_ == null)
			{
				GoogleApiClient.cb_registerConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.n_RegisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_));
			}
			return GoogleApiClient.cb_registerConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00009DA0 File Offset: 0x00007FA0
		private static void n_RegisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GoogleApiClient.IOnConnectionFailedListener object2 = Java.Lang.Object.GetObject<GoogleApiClient.IOnConnectionFailedListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RegisterConnectionFailedListener(object2);
		}

		// Token: 0x06000314 RID: 788
		[Register("registerConnectionFailedListener", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", "GetRegisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler")]
		public abstract void RegisterConnectionFailedListener(GoogleApiClient.IOnConnectionFailedListener p0);

		// Token: 0x06000315 RID: 789 RVA: 0x00009DC3 File Offset: 0x00007FC3
		private static Delegate GetRegisterListener_Ljava_lang_Object_Handler()
		{
			if (GoogleApiClient.cb_registerListener_Ljava_lang_Object_ == null)
			{
				GoogleApiClient.cb_registerListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApiClient.n_RegisterListener_Ljava_lang_Object_));
			}
			return GoogleApiClient.cb_registerListener_Ljava_lang_Object_;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00009DE8 File Offset: 0x00007FE8
		private static IntPtr n_RegisterListener_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RegisterListener(object2));
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00009E10 File Offset: 0x00008010
		[Register("registerListener", "(Ljava/lang/Object;)Lcom/google/android/gms/common/api/internal/ListenerHolder;", "GetRegisterListener_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"L"
		})]
		public unsafe virtual ListenerHolder RegisterListener(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			ListenerHolder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ListenerHolder>(GoogleApiClient._members.InstanceMethods.InvokeVirtualObjectMethod("registerListener.(Ljava/lang/Object;)Lcom/google/android/gms/common/api/internal/ListenerHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00009E84 File Offset: 0x00008084
		private static Delegate GetStopAutoManage_Landroidx_fragment_app_FragmentActivity_Handler()
		{
			if (GoogleApiClient.cb_stopAutoManage_Landroidx_fragment_app_FragmentActivity_ == null)
			{
				GoogleApiClient.cb_stopAutoManage_Landroidx_fragment_app_FragmentActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.n_StopAutoManage_Landroidx_fragment_app_FragmentActivity_));
			}
			return GoogleApiClient.cb_stopAutoManage_Landroidx_fragment_app_FragmentActivity_;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00009EA8 File Offset: 0x000080A8
		private static void n_StopAutoManage_Landroidx_fragment_app_FragmentActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentActivity object2 = Java.Lang.Object.GetObject<FragmentActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.StopAutoManage(object2);
		}

		// Token: 0x0600031A RID: 794
		[Register("stopAutoManage", "(Landroidx/fragment/app/FragmentActivity;)V", "GetStopAutoManage_Landroidx_fragment_app_FragmentActivity_Handler")]
		public abstract void StopAutoManage(FragmentActivity p0);

		// Token: 0x0600031B RID: 795 RVA: 0x00009ECB File Offset: 0x000080CB
		private static Delegate GetUnregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler()
		{
			if (GoogleApiClient.cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_ == null)
			{
				GoogleApiClient.cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.n_UnregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_));
			}
			return GoogleApiClient.cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00009EF0 File Offset: 0x000080F0
		private static void n_UnregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GoogleApiClient.IConnectionCallbacks object2 = Java.Lang.Object.GetObject<GoogleApiClient.IConnectionCallbacks>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterConnectionCallbacks(object2);
		}

		// Token: 0x0600031D RID: 797
		[Register("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", "GetUnregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_Handler")]
		public abstract void UnregisterConnectionCallbacks(GoogleApiClient.IConnectionCallbacks p0);

		// Token: 0x0600031E RID: 798 RVA: 0x00009F13 File Offset: 0x00008113
		private static Delegate GetUnregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler()
		{
			if (GoogleApiClient.cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_ == null)
			{
				GoogleApiClient.cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.n_UnregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_));
			}
			return GoogleApiClient.cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00009F38 File Offset: 0x00008138
		private static void n_UnregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			GoogleApiClient @object = Java.Lang.Object.GetObject<GoogleApiClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GoogleApiClient.IOnConnectionFailedListener object2 = Java.Lang.Object.GetObject<GoogleApiClient.IOnConnectionFailedListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterConnectionFailedListener(object2);
		}

		// Token: 0x06000320 RID: 800
		[Register("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", "GetUnregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_Handler")]
		public abstract void UnregisterConnectionFailedListener(GoogleApiClient.IOnConnectionFailedListener p0);

		// Token: 0x0400008D RID: 141
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApiClient", typeof(GoogleApiClient));

		// Token: 0x0400008E RID: 142
		private static Delegate cb_getContext;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_isConnected;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_isConnecting;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_getLooper;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_blockingConnect;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_blockingConnect_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_clearDefaultAccountAndReconnect;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_connect;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_connect_I;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_disconnect;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_enqueue_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_execute_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_getClient_Lcom_google_android_gms_common_api_Api_AnyClientKey_;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_getConnectionResult_Lcom_google_android_gms_common_api_Api_;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_hasApi_Lcom_google_android_gms_common_api_Api_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_hasConnectedApi_Lcom_google_android_gms_common_api_Api_;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_maybeSignIn_Lcom_google_android_gms_common_api_internal_SignInConnectionListener_;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_maybeSignOut;

		// Token: 0x040000A3 RID: 163
		private static Delegate cb_reconnect;

		// Token: 0x040000A4 RID: 164
		private static Delegate cb_registerConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_;

		// Token: 0x040000A5 RID: 165
		private static Delegate cb_registerConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_;

		// Token: 0x040000A6 RID: 166
		private static Delegate cb_registerListener_Ljava_lang_Object_;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_stopAutoManage_Landroidx_fragment_app_FragmentActivity_;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_api_GoogleApiClient_ConnectionCallbacks_;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_api_GoogleApiClient_OnConnectionFailedListener_;

		// Token: 0x02000047 RID: 71
		[Register("com/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks", "", "Android.Gms.Common.Apis.GoogleApiClient/IConnectionCallbacksInvoker")]
		public interface IConnectionCallbacks : Android.Gms.Common.Api.Internal.IConnectionCallbacks, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000048 RID: 72
		[Register("com/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks", DoNotGenerateAcw = true)]
		internal class IConnectionCallbacksInvoker : Java.Lang.Object, GoogleApiClient.IConnectionCallbacks, Android.Gms.Common.Api.Internal.IConnectionCallbacks, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000322 RID: 802 RVA: 0x00009F78 File Offset: 0x00008178
			private static IntPtr java_class_ref
			{
				get
				{
					return GoogleApiClient.IConnectionCallbacksInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000323 RID: 803 RVA: 0x00009F9C File Offset: 0x0000819C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GoogleApiClient.IConnectionCallbacksInvoker._members;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000324 RID: 804 RVA: 0x00009FA3 File Offset: 0x000081A3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000325 RID: 805 RVA: 0x00009FAB File Offset: 0x000081AB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GoogleApiClient.IConnectionCallbacksInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00009FB7 File Offset: 0x000081B7
			public static GoogleApiClient.IConnectionCallbacks GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<GoogleApiClient.IConnectionCallbacks>(handle, transfer);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x00009FC0 File Offset: 0x000081C0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, GoogleApiClient.IConnectionCallbacksInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.GoogleApiClient.ConnectionCallbacks'.");
				}
				return handle;
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00009FEB File Offset: 0x000081EB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000A01C File Offset: 0x0000821C
			public IConnectionCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(GoogleApiClient.IConnectionCallbacksInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600032A RID: 810 RVA: 0x0000A054 File Offset: 0x00008254
			private static Delegate GetOnConnected_Landroid_os_Bundle_Handler()
			{
				if (GoogleApiClient.IConnectionCallbacksInvoker.cb_onConnected_Landroid_os_Bundle_ == null)
				{
					GoogleApiClient.IConnectionCallbacksInvoker.cb_onConnected_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.IConnectionCallbacksInvoker.n_OnConnected_Landroid_os_Bundle_));
				}
				return GoogleApiClient.IConnectionCallbacksInvoker.cb_onConnected_Landroid_os_Bundle_;
			}

			// Token: 0x0600032B RID: 811 RVA: 0x0000A078 File Offset: 0x00008278
			private static void n_OnConnected_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Android.Gms.Common.Api.Internal.IConnectionCallbacks @object = Java.Lang.Object.GetObject<GoogleApiClient.IConnectionCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnConnected(object2);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0000A09C File Offset: 0x0000829C
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

			// Token: 0x0600032D RID: 813 RVA: 0x0000A10F File Offset: 0x0000830F
			private static Delegate GetOnConnectionSuspended_IHandler()
			{
				if (GoogleApiClient.IConnectionCallbacksInvoker.cb_onConnectionSuspended_I == null)
				{
					GoogleApiClient.IConnectionCallbacksInvoker.cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(GoogleApiClient.IConnectionCallbacksInvoker.n_OnConnectionSuspended_I));
				}
				return GoogleApiClient.IConnectionCallbacksInvoker.cb_onConnectionSuspended_I;
			}

			// Token: 0x0600032E RID: 814 RVA: 0x0000A133 File Offset: 0x00008333
			private static void n_OnConnectionSuspended_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				Java.Lang.Object.GetObject<GoogleApiClient.IConnectionCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnConnectionSuspended(p0);
			}

			// Token: 0x0600032F RID: 815 RVA: 0x0000A144 File Offset: 0x00008344
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

			// Token: 0x040000AA RID: 170
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks", typeof(GoogleApiClient.IConnectionCallbacksInvoker));

			// Token: 0x040000AB RID: 171
			private IntPtr class_ref;

			// Token: 0x040000AC RID: 172
			private static Delegate cb_onConnected_Landroid_os_Bundle_;

			// Token: 0x040000AD RID: 173
			private IntPtr id_onConnected_Landroid_os_Bundle_;

			// Token: 0x040000AE RID: 174
			private static Delegate cb_onConnectionSuspended_I;

			// Token: 0x040000AF RID: 175
			private IntPtr id_onConnectionSuspended_I;
		}

		// Token: 0x02000049 RID: 73
		[Register("com/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener", "", "Android.Gms.Common.Apis.GoogleApiClient/IOnConnectionFailedListenerInvoker")]
		public interface IOnConnectionFailedListener : Android.Gms.Common.Api.Internal.IOnConnectionFailedListener, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200004A RID: 74
		[Register("com/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener", DoNotGenerateAcw = true)]
		internal class IOnConnectionFailedListenerInvoker : Java.Lang.Object, GoogleApiClient.IOnConnectionFailedListener, Android.Gms.Common.Api.Internal.IOnConnectionFailedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000331 RID: 817 RVA: 0x0000A1C4 File Offset: 0x000083C4
			private static IntPtr java_class_ref
			{
				get
				{
					return GoogleApiClient.IOnConnectionFailedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000332 RID: 818 RVA: 0x0000A1E8 File Offset: 0x000083E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GoogleApiClient.IOnConnectionFailedListenerInvoker._members;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0000A1EF File Offset: 0x000083EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000334 RID: 820 RVA: 0x0000A1F7 File Offset: 0x000083F7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GoogleApiClient.IOnConnectionFailedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000335 RID: 821 RVA: 0x0000A203 File Offset: 0x00008403
			public static GoogleApiClient.IOnConnectionFailedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<GoogleApiClient.IOnConnectionFailedListener>(handle, transfer);
			}

			// Token: 0x06000336 RID: 822 RVA: 0x0000A20C File Offset: 0x0000840C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, GoogleApiClient.IOnConnectionFailedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.GoogleApiClient.OnConnectionFailedListener'.");
				}
				return handle;
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0000A237 File Offset: 0x00008437
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000338 RID: 824 RVA: 0x0000A268 File Offset: 0x00008468
			public IOnConnectionFailedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(GoogleApiClient.IOnConnectionFailedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000339 RID: 825 RVA: 0x0000A2A0 File Offset: 0x000084A0
			private static Delegate GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler()
			{
				if (GoogleApiClient.IOnConnectionFailedListenerInvoker.cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == null)
				{
					GoogleApiClient.IOnConnectionFailedListenerInvoker.cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GoogleApiClient.IOnConnectionFailedListenerInvoker.n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_));
				}
				return GoogleApiClient.IOnConnectionFailedListenerInvoker.cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000A2C4 File Offset: 0x000084C4
			private static void n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Android.Gms.Common.Api.Internal.IOnConnectionFailedListener @object = Java.Lang.Object.GetObject<GoogleApiClient.IOnConnectionFailedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ConnectionResult object2 = Java.Lang.Object.GetObject<ConnectionResult>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnConnectionFailed(object2);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000A2E8 File Offset: 0x000084E8
			public unsafe void OnConnectionFailed(ConnectionResult p0)
			{
				if (this.id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == IntPtr.Zero)
				{
					this.id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNIEnv.GetMethodID(this.class_ref, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_, ptr);
			}

			// Token: 0x040000B0 RID: 176
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener", typeof(GoogleApiClient.IOnConnectionFailedListenerInvoker));

			// Token: 0x040000B1 RID: 177
			private IntPtr class_ref;

			// Token: 0x040000B2 RID: 178
			private static Delegate cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;

			// Token: 0x040000B3 RID: 179
			private IntPtr id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		}
	}
}
