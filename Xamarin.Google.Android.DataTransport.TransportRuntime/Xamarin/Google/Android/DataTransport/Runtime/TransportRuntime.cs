using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200002C RID: 44
	[Register("com/google/android/datatransport/runtime/TransportRuntime", DoNotGenerateAcw = true)]
	public class TransportRuntime : Java.Lang.Object
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000486C File Offset: 0x00002A6C
		internal static IntPtr class_ref
		{
			get
			{
				return TransportRuntime._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00004890 File Offset: 0x00002A90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportRuntime._members;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00004898 File Offset: 0x00002A98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransportRuntime._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000048BC File Offset: 0x00002ABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportRuntime._members.ManagedPeerType;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000026C4 File Offset: 0x000008C4
		protected TransportRuntime(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000048C8 File Offset: 0x00002AC8
		public static TransportRuntime Instance
		{
			[Register("getInstance", "()Lcom/google/android/datatransport/runtime/TransportRuntime;", "")]
			get
			{
				return Java.Lang.Object.GetObject<TransportRuntime>(TransportRuntime._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/google/android/datatransport/runtime/TransportRuntime;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000048F9 File Offset: 0x00002AF9
		private static Delegate GetGetUploaderHandler()
		{
			if (TransportRuntime.cb_getUploader == null)
			{
				TransportRuntime.cb_getUploader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TransportRuntime.n_GetUploader));
			}
			return TransportRuntime.cb_getUploader;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000491D File Offset: 0x00002B1D
		private static IntPtr n_GetUploader(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TransportRuntime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Uploader);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00004934 File Offset: 0x00002B34
		public virtual Uploader Uploader
		{
			[Register("getUploader", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;", "GetGetUploaderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Uploader>(TransportRuntime._members.InstanceMethods.InvokeVirtualObjectMethod("getUploader.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00004968 File Offset: 0x00002B68
		[Register("initialize", "(Landroid/content/Context;)V", "")]
		public unsafe static void Initialize(Context applicationContext)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				TransportRuntime._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(applicationContext);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000049CC File Offset: 0x00002BCC
		private static Delegate GetNewFactory_Lcom_google_android_datatransport_runtime_Destination_Handler()
		{
			if (TransportRuntime.cb_newFactory_Lcom_google_android_datatransport_runtime_Destination_ == null)
			{
				TransportRuntime.cb_newFactory_Lcom_google_android_datatransport_runtime_Destination_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportRuntime.n_NewFactory_Lcom_google_android_datatransport_runtime_Destination_));
			}
			return TransportRuntime.cb_newFactory_Lcom_google_android_datatransport_runtime_Destination_;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000049F0 File Offset: 0x00002BF0
		private static IntPtr n_NewFactory_Lcom_google_android_datatransport_runtime_Destination_(IntPtr jnienv, IntPtr native__this, IntPtr native_destination)
		{
			TransportRuntime @object = Java.Lang.Object.GetObject<TransportRuntime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDestination object2 = Java.Lang.Object.GetObject<IDestination>(native_destination, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.NewFactory(object2));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004A18 File Offset: 0x00002C18
		[Register("newFactory", "(Lcom/google/android/datatransport/runtime/Destination;)Lcom/google/android/datatransport/TransportFactory;", "GetNewFactory_Lcom_google_android_datatransport_runtime_Destination_Handler")]
		public unsafe virtual ITransportFactory NewFactory(IDestination destination)
		{
			ITransportFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((destination == null) ? IntPtr.Zero : ((Java.Lang.Object)destination).Handle);
				@object = Java.Lang.Object.GetObject<ITransportFactory>(TransportRuntime._members.InstanceMethods.InvokeVirtualObjectMethod("newFactory.(Lcom/google/android/datatransport/runtime/Destination;)Lcom/google/android/datatransport/TransportFactory;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004A90 File Offset: 0x00002C90
		[Obsolete]
		private static Delegate GetNewFactory_Ljava_lang_String_Handler()
		{
			if (TransportRuntime.cb_newFactory_Ljava_lang_String_ == null)
			{
				TransportRuntime.cb_newFactory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportRuntime.n_NewFactory_Ljava_lang_String_));
			}
			return TransportRuntime.cb_newFactory_Ljava_lang_String_;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Obsolete]
		private static IntPtr n_NewFactory_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_backendName)
		{
			TransportRuntime @object = Java.Lang.Object.GetObject<TransportRuntime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_backendName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.NewFactory(@string));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004ADC File Offset: 0x00002CDC
		[Obsolete("deprecated")]
		[Register("newFactory", "(Ljava/lang/String;)Lcom/google/android/datatransport/TransportFactory;", "GetNewFactory_Ljava_lang_String_Handler")]
		public unsafe virtual ITransportFactory NewFactory(string backendName)
		{
			IntPtr intPtr = JNIEnv.NewString(backendName);
			ITransportFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ITransportFactory>(TransportRuntime._members.InstanceMethods.InvokeVirtualObjectMethod("newFactory.(Ljava/lang/String;)Lcom/google/android/datatransport/TransportFactory;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000047 RID: 71
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportRuntime", typeof(TransportRuntime));

		// Token: 0x04000048 RID: 72
		private static Delegate cb_getUploader;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_newFactory_Lcom_google_android_datatransport_runtime_Destination_;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_newFactory_Ljava_lang_String_;
	}
}
