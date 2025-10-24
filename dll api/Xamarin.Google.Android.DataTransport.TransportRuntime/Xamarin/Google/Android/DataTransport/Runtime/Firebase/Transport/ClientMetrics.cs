using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport
{
	// Token: 0x02000076 RID: 118
	[Register("com/google/android/datatransport/runtime/firebase/transport/ClientMetrics", DoNotGenerateAcw = true)]
	public sealed class ClientMetrics : Java.Lang.Object
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000D740 File Offset: 0x0000B940
		internal static IntPtr class_ref
		{
			get
			{
				return ClientMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000D764 File Offset: 0x0000B964
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClientMetrics._members;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000D76C File Offset: 0x0000B96C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClientMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000D790 File Offset: 0x0000B990
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClientMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000026C4 File Offset: 0x000008C4
		internal ClientMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0000D79C File Offset: 0x0000B99C
		public string AppNamespace
		{
			[Register("getAppNamespace", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getAppNamespace.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		public static ClientMetrics DefaultInstance
		{
			[Register("getDefaultInstance", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ClientMetrics>(ClientMetrics._members.StaticMethods.InvokeObjectMethod("getDefaultInstance.()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000D804 File Offset: 0x0000BA04
		public GlobalMetrics GlobalMetrics
		{
			[Register("getGlobalMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<GlobalMetrics>(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getGlobalMetrics.()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000D838 File Offset: 0x0000BA38
		public GlobalMetrics GlobalMetricsInternal
		{
			[Register("getGlobalMetricsInternal", "()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<GlobalMetrics>(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getGlobalMetricsInternal.()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000D86C File Offset: 0x0000BA6C
		public IList<LogSourceMetrics> LogSourceMetricsList
		{
			[Register("getLogSourceMetricsList", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<LogSourceMetrics>.FromJniHandle(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getLogSourceMetricsList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public TimeWindow Window
		{
			[Register("getWindow", "()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", "")]
			get
			{
				return Java.Lang.Object.GetObject<TimeWindow>(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getWindow.()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
		public TimeWindow WindowInternal
		{
			[Register("getWindowInternal", "()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", "")]
			get
			{
				return Java.Lang.Object.GetObject<TimeWindow>(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getWindowInternal.()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000D908 File Offset: 0x0000BB08
		[Register("newBuilder", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", "")]
		public static ClientMetrics.Builder NewBuilder()
		{
			return Java.Lang.Object.GetObject<ClientMetrics.Builder>(ClientMetrics._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000D93C File Offset: 0x0000BB3C
		[Register("toByteArray", "()[B", "")]
		public byte[] ToByteArray()
		{
			return (byte[])JNIEnv.GetArray(ClientMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("toByteArray.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000D980 File Offset: 0x0000BB80
		[Register("writeTo", "(Ljava/io/OutputStream;)V", "")]
		public unsafe void WriteTo(Stream output)
		{
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(output);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ClientMetrics._members.InstanceMethods.InvokeAbstractVoidMethod("writeTo.(Ljava/io/OutputStream;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(output);
			}
		}

		// Token: 0x040000FA RID: 250
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/ClientMetrics", typeof(ClientMetrics));

		// Token: 0x02000077 RID: 119
		[Register("com/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x1700014F RID: 335
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000DA00 File Offset: 0x0000BC00
			internal static IntPtr class_ref
			{
				get
				{
					return ClientMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000DA24 File Offset: 0x0000BC24
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ClientMetrics.Builder._members;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000DA2C File Offset: 0x0000BC2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ClientMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000DA50 File Offset: 0x0000BC50
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ClientMetrics.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x0000DA5C File Offset: 0x0000BC5C
			[Register("addLogSourceMetrics", "(Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", "")]
			public unsafe ClientMetrics.Builder AddLogSourceMetrics(LogSourceMetrics log_source_metrics_)
			{
				ClientMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((log_source_metrics_ == null) ? IntPtr.Zero : log_source_metrics_.Handle);
					@object = Java.Lang.Object.GetObject<ClientMetrics.Builder>(ClientMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addLogSourceMetrics.(Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(log_source_metrics_);
				}
				return @object;
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
			[Register("build", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", "")]
			public ClientMetrics Build()
			{
				return Java.Lang.Object.GetObject<ClientMetrics>(ClientMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x0000DB04 File Offset: 0x0000BD04
			[Register("setAppNamespace", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", "")]
			public unsafe ClientMetrics.Builder SetAppNamespace(string app_namespace_)
			{
				IntPtr intPtr = JNIEnv.NewString(app_namespace_);
				ClientMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ClientMetrics.Builder>(ClientMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAppNamespace.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x0000DB70 File Offset: 0x0000BD70
			[Register("setGlobalMetrics", "(Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", "")]
			public unsafe ClientMetrics.Builder SetGlobalMetrics(GlobalMetrics global_metrics_)
			{
				ClientMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((global_metrics_ == null) ? IntPtr.Zero : global_metrics_.Handle);
					@object = Java.Lang.Object.GetObject<ClientMetrics.Builder>(ClientMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setGlobalMetrics.(Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(global_metrics_);
				}
				return @object;
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
			[Register("setLogSourceMetricsList", "(Ljava/util/List;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", "")]
			public unsafe ClientMetrics.Builder SetLogSourceMetricsList(IList<LogSourceMetrics> log_source_metrics_)
			{
				IntPtr intPtr = JavaList<LogSourceMetrics>.ToLocalJniHandle(log_source_metrics_);
				ClientMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ClientMetrics.Builder>(ClientMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setLogSourceMetricsList.(Ljava/util/List;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(log_source_metrics_);
				}
				return @object;
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x0000DC58 File Offset: 0x0000BE58
			[Register("setWindow", "(Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", "")]
			public unsafe ClientMetrics.Builder SetWindow(TimeWindow window_)
			{
				ClientMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((window_ == null) ? IntPtr.Zero : window_.Handle);
					@object = Java.Lang.Object.GetObject<ClientMetrics.Builder>(ClientMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setWindow.(Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;)Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(window_);
				}
				return @object;
			}

			// Token: 0x040000FB RID: 251
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder", typeof(ClientMetrics.Builder));
		}
	}
}
