using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x0200006F RID: 111
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStore", DoNotGenerateAcw = true)]
	internal class IEventStoreInvoker : Java.Lang.Object, IEventStore, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000B610 File Offset: 0x00009810
		private static IntPtr java_class_ref
		{
			get
			{
				return IEventStoreInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000B634 File Offset: 0x00009834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEventStoreInvoker._members;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000B63B File Offset: 0x0000983B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000B643 File Offset: 0x00009843
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEventStoreInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000B64F File Offset: 0x0000984F
		public static IEventStore GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEventStore>(handle, transfer);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000B658 File Offset: 0x00009858
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEventStoreInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.scheduling.persistence.EventStore'.");
			}
			return handle;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000B683 File Offset: 0x00009883
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000B6B4 File Offset: 0x000098B4
		public IEventStoreInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEventStoreInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000B6EC File Offset: 0x000098EC
		private static Delegate GetCleanUpHandler()
		{
			if (IEventStoreInvoker.cb_cleanUp == null)
			{
				IEventStoreInvoker.cb_cleanUp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IEventStoreInvoker.n_CleanUp));
			}
			return IEventStoreInvoker.cb_cleanUp;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000B710 File Offset: 0x00009910
		private static int n_CleanUp(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CleanUp();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000B71F File Offset: 0x0000991F
		public int CleanUp()
		{
			if (this.id_cleanUp == IntPtr.Zero)
			{
				this.id_cleanUp = JNIEnv.GetMethodID(this.class_ref, "cleanUp", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_cleanUp);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000B75F File Offset: 0x0000995F
		private static Delegate GetGetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_Handler()
		{
			if (IEventStoreInvoker.cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_ == null)
			{
				IEventStoreInvoker.cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(IEventStoreInvoker.n_GetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_));
			}
			return IEventStoreInvoker.cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000B784 File Offset: 0x00009984
		private static long n_GetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetNextCallTime(object2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000B7A8 File Offset: 0x000099A8
		public unsafe long GetNextCallTime(TransportContext p0)
		{
			if (this.id_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_ == IntPtr.Zero)
			{
				this.id_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_ = JNIEnv.GetMethodID(this.class_ref, "getNextCallTime", "(Lcom/google/android/datatransport/runtime/TransportContext;)J");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallLongMethod(base.Handle, this.id_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_, ptr);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000B81B File Offset: 0x00009A1B
		private static Delegate GetHasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_Handler()
		{
			if (IEventStoreInvoker.cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_ == null)
			{
				IEventStoreInvoker.cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEventStoreInvoker.n_HasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_));
			}
			return IEventStoreInvoker.cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000B840 File Offset: 0x00009A40
		private static bool n_HasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.HasPendingEventsFor(object2);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000B864 File Offset: 0x00009A64
		public unsafe bool HasPendingEventsFor(TransportContext p0)
		{
			if (this.id_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_ == IntPtr.Zero)
			{
				this.id_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_ = JNIEnv.GetMethodID(this.class_ref, "hasPendingEventsFor", "(Lcom/google/android/datatransport/runtime/TransportContext;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_, ptr);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000B8D7 File Offset: 0x00009AD7
		private static Delegate GetLoadActiveContextsHandler()
		{
			if (IEventStoreInvoker.cb_loadActiveContexts == null)
			{
				IEventStoreInvoker.cb_loadActiveContexts = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEventStoreInvoker.n_LoadActiveContexts));
			}
			return IEventStoreInvoker.cb_loadActiveContexts;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000B8FB File Offset: 0x00009AFB
		private static IntPtr n_LoadActiveContexts(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadActiveContexts());
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000B910 File Offset: 0x00009B10
		public IIterable LoadActiveContexts()
		{
			if (this.id_loadActiveContexts == IntPtr.Zero)
			{
				this.id_loadActiveContexts = JNIEnv.GetMethodID(this.class_ref, "loadActiveContexts", "()Ljava/lang/Iterable;");
			}
			return Java.Lang.Object.GetObject<IIterable>(JNIEnv.CallObjectMethod(base.Handle, this.id_loadActiveContexts), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000B961 File Offset: 0x00009B61
		private static Delegate GetLoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_Handler()
		{
			if (IEventStoreInvoker.cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_ == null)
			{
				IEventStoreInvoker.cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IEventStoreInvoker.n_LoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_));
			}
			return IEventStoreInvoker.cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000B988 File Offset: 0x00009B88
		private static IntPtr n_LoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadBatch(object2));
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		public unsafe IIterable LoadBatch(TransportContext p0)
		{
			if (this.id_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_ == IntPtr.Zero)
			{
				this.id_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_ = JNIEnv.GetMethodID(this.class_ref, "loadBatch", "(Lcom/google/android/datatransport/runtime/TransportContext;)Ljava/lang/Iterable;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<IIterable>(JNIEnv.CallObjectMethod(base.Handle, this.id_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000BA29 File Offset: 0x00009C29
		private static Delegate GetPersist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Handler()
		{
			if (IEventStoreInvoker.cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_ == null)
			{
				IEventStoreInvoker.cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IEventStoreInvoker.n_Persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_));
			}
			return IEventStoreInvoker.cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000BA50 File Offset: 0x00009C50
		private static IntPtr n_Persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			EventInternal object3 = Java.Lang.Object.GetObject<EventInternal>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Persist(object2, object3));
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000BA84 File Offset: 0x00009C84
		public unsafe PersistedEvent Persist(TransportContext p0, EventInternal p1)
		{
			if (this.id_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_ == IntPtr.Zero)
			{
				this.id_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_ = JNIEnv.GetMethodID(this.class_ref, "persist", "(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			return Java.Lang.Object.GetObject<PersistedEvent>(JNIEnv.CallObjectMethod(base.Handle, this.id_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000BB1F File Offset: 0x00009D1F
		private static Delegate GetRecordFailure_Ljava_lang_Iterable_Handler()
		{
			if (IEventStoreInvoker.cb_recordFailure_Ljava_lang_Iterable_ == null)
			{
				IEventStoreInvoker.cb_recordFailure_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IEventStoreInvoker.n_RecordFailure_Ljava_lang_Iterable_));
			}
			return IEventStoreInvoker.cb_recordFailure_Ljava_lang_Iterable_;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000BB44 File Offset: 0x00009D44
		private static void n_RecordFailure_Ljava_lang_Iterable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IIterable object2 = Java.Lang.Object.GetObject<IIterable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RecordFailure(object2);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000BB68 File Offset: 0x00009D68
		public unsafe void RecordFailure(IIterable p0)
		{
			if (this.id_recordFailure_Ljava_lang_Iterable_ == IntPtr.Zero)
			{
				this.id_recordFailure_Ljava_lang_Iterable_ = JNIEnv.GetMethodID(this.class_ref, "recordFailure", "(Ljava/lang/Iterable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_recordFailure_Ljava_lang_Iterable_, ptr);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		private static Delegate GetRecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_JHandler()
		{
			if (IEventStoreInvoker.cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J == null)
			{
				IEventStoreInvoker.cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_V(IEventStoreInvoker.n_RecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J));
			}
			return IEventStoreInvoker.cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000BC04 File Offset: 0x00009E04
		private static void n_RecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RecordNextCallTime(object2, p1);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000BC28 File Offset: 0x00009E28
		public unsafe void RecordNextCallTime(TransportContext p0, long p1)
		{
			if (this.id_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J == IntPtr.Zero)
			{
				this.id_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J = JNIEnv.GetMethodID(this.class_ref, "recordNextCallTime", "(Lcom/google/android/datatransport/runtime/TransportContext;J)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J, ptr);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000BCAE File Offset: 0x00009EAE
		private static Delegate GetRecordSuccess_Ljava_lang_Iterable_Handler()
		{
			if (IEventStoreInvoker.cb_recordSuccess_Ljava_lang_Iterable_ == null)
			{
				IEventStoreInvoker.cb_recordSuccess_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IEventStoreInvoker.n_RecordSuccess_Ljava_lang_Iterable_));
			}
			return IEventStoreInvoker.cb_recordSuccess_Ljava_lang_Iterable_;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		private static void n_RecordSuccess_Ljava_lang_Iterable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IEventStore @object = Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IIterable object2 = Java.Lang.Object.GetObject<IIterable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RecordSuccess(object2);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000BCF8 File Offset: 0x00009EF8
		public unsafe void RecordSuccess(IIterable p0)
		{
			if (this.id_recordSuccess_Ljava_lang_Iterable_ == IntPtr.Zero)
			{
				this.id_recordSuccess_Ljava_lang_Iterable_ = JNIEnv.GetMethodID(this.class_ref, "recordSuccess", "(Ljava/lang/Iterable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_recordSuccess_Ljava_lang_Iterable_, ptr);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000BD70 File Offset: 0x00009F70
		private static Delegate GetCloseHandler()
		{
			if (IEventStoreInvoker.cb_close == null)
			{
				IEventStoreInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IEventStoreInvoker.n_Close));
			}
			return IEventStoreInvoker.cb_close;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000BD94 File Offset: 0x00009F94
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000BDA3 File Offset: 0x00009FA3
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040000CC RID: 204
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStore", typeof(IEventStoreInvoker));

		// Token: 0x040000CD RID: 205
		private IntPtr class_ref;

		// Token: 0x040000CE RID: 206
		private static Delegate cb_cleanUp;

		// Token: 0x040000CF RID: 207
		private IntPtr id_cleanUp;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000D1 RID: 209
		private IntPtr id_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000D2 RID: 210
		private static Delegate cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000D3 RID: 211
		private IntPtr id_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000D4 RID: 212
		private static Delegate cb_loadActiveContexts;

		// Token: 0x040000D5 RID: 213
		private IntPtr id_loadActiveContexts;

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000D7 RID: 215
		private IntPtr id_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000D8 RID: 216
		private static Delegate cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_;

		// Token: 0x040000D9 RID: 217
		private IntPtr id_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_;

		// Token: 0x040000DA RID: 218
		private static Delegate cb_recordFailure_Ljava_lang_Iterable_;

		// Token: 0x040000DB RID: 219
		private IntPtr id_recordFailure_Ljava_lang_Iterable_;

		// Token: 0x040000DC RID: 220
		private static Delegate cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J;

		// Token: 0x040000DD RID: 221
		private IntPtr id_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J;

		// Token: 0x040000DE RID: 222
		private static Delegate cb_recordSuccess_Ljava_lang_Iterable_;

		// Token: 0x040000DF RID: 223
		private IntPtr id_recordSuccess_Ljava_lang_Iterable_;

		// Token: 0x040000E0 RID: 224
		private static Delegate cb_close;

		// Token: 0x040000E1 RID: 225
		private IntPtr id_close;
	}
}
