using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x0200006D RID: 109
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore", DoNotGenerateAcw = true)]
	internal class IClientHealthMetricsStoreInvoker : Java.Lang.Object, IClientHealthMetricsStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000B31C File Offset: 0x0000951C
		private static IntPtr java_class_ref
		{
			get
			{
				return IClientHealthMetricsStoreInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000B340 File Offset: 0x00009540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IClientHealthMetricsStoreInvoker._members;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000B347 File Offset: 0x00009547
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000B34F File Offset: 0x0000954F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IClientHealthMetricsStoreInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000B35B File Offset: 0x0000955B
		public static IClientHealthMetricsStore GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IClientHealthMetricsStore>(handle, transfer);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000B364 File Offset: 0x00009564
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IClientHealthMetricsStoreInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore'.");
			}
			return handle;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000B38F File Offset: 0x0000958F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000B3C0 File Offset: 0x000095C0
		public IClientHealthMetricsStoreInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IClientHealthMetricsStoreInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000B3F8 File Offset: 0x000095F8
		private static Delegate GetLoadClientMetricsHandler()
		{
			if (IClientHealthMetricsStoreInvoker.cb_loadClientMetrics == null)
			{
				IClientHealthMetricsStoreInvoker.cb_loadClientMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClientHealthMetricsStoreInvoker.n_LoadClientMetrics));
			}
			return IClientHealthMetricsStoreInvoker.cb_loadClientMetrics;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000B41C File Offset: 0x0000961C
		private static IntPtr n_LoadClientMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClientHealthMetricsStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadClientMetrics());
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000B430 File Offset: 0x00009630
		public ClientMetrics LoadClientMetrics()
		{
			if (this.id_loadClientMetrics == IntPtr.Zero)
			{
				this.id_loadClientMetrics = JNIEnv.GetMethodID(this.class_ref, "loadClientMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;");
			}
			return Java.Lang.Object.GetObject<ClientMetrics>(JNIEnv.CallObjectMethod(base.Handle, this.id_loadClientMetrics), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000B481 File Offset: 0x00009681
		private static Delegate GetRecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_Handler()
		{
			if (IClientHealthMetricsStoreInvoker.cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_ == null)
			{
				IClientHealthMetricsStoreInvoker.cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJLL_V(IClientHealthMetricsStoreInvoker.n_RecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_));
			}
			return IClientHealthMetricsStoreInvoker.cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000B4A8 File Offset: 0x000096A8
		private static void n_RecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			IClientHealthMetricsStore @object = Java.Lang.Object.GetObject<IClientHealthMetricsStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LogEventDropped.Reason object2 = Java.Lang.Object.GetObject<LogEventDropped.Reason>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.RecordLogEventDropped(p0, object2, @string);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000B4D8 File Offset: 0x000096D8
		public unsafe void RecordLogEventDropped(long p0, LogEventDropped.Reason p1, string p2)
		{
			if (this.id_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "recordLogEventDropped", "(JLcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000B581 File Offset: 0x00009781
		private static Delegate GetResetClientMetricsHandler()
		{
			if (IClientHealthMetricsStoreInvoker.cb_resetClientMetrics == null)
			{
				IClientHealthMetricsStoreInvoker.cb_resetClientMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IClientHealthMetricsStoreInvoker.n_ResetClientMetrics));
			}
			return IClientHealthMetricsStoreInvoker.cb_resetClientMetrics;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000B5A5 File Offset: 0x000097A5
		private static void n_ResetClientMetrics(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IClientHealthMetricsStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetClientMetrics();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000B5B4 File Offset: 0x000097B4
		public void ResetClientMetrics()
		{
			if (this.id_resetClientMetrics == IntPtr.Zero)
			{
				this.id_resetClientMetrics = JNIEnv.GetMethodID(this.class_ref, "resetClientMetrics", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_resetClientMetrics);
		}

		// Token: 0x040000C4 RID: 196
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore", typeof(IClientHealthMetricsStoreInvoker));

		// Token: 0x040000C5 RID: 197
		private IntPtr class_ref;

		// Token: 0x040000C6 RID: 198
		private static Delegate cb_loadClientMetrics;

		// Token: 0x040000C7 RID: 199
		private IntPtr id_loadClientMetrics;

		// Token: 0x040000C8 RID: 200
		private static Delegate cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_;

		// Token: 0x040000C9 RID: 201
		private IntPtr id_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_;

		// Token: 0x040000CA RID: 202
		private static Delegate cb_resetClientMetrics;

		// Token: 0x040000CB RID: 203
		private IntPtr id_resetClientMetrics;
	}
}
