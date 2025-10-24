using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport;
using Xamarin.Google.Android.DataTransport.Runtime.Synchronization;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000073 RID: 115
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore", DoNotGenerateAcw = true)]
	public class SQLiteEventStore : Java.Lang.Object, IClientHealthMetricsStore, IJavaObject, IDisposable, IJavaPeerable, IEventStore, ICloseable, ISynchronizationGuard
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000C42C File Offset: 0x0000A62C
		internal static IntPtr class_ref
		{
			get
			{
				return SQLiteEventStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000C450 File Offset: 0x0000A650
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SQLiteEventStore._members;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000C458 File Offset: 0x0000A658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SQLiteEventStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000C47C File Offset: 0x0000A67C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SQLiteEventStore._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000026C4 File Offset: 0x000008C4
		protected SQLiteEventStore(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000C488 File Offset: 0x0000A688
		private static Delegate GetCleanUpHandler()
		{
			if (SQLiteEventStore.cb_cleanUp == null)
			{
				SQLiteEventStore.cb_cleanUp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SQLiteEventStore.n_CleanUp));
			}
			return SQLiteEventStore.cb_cleanUp;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		private static int n_CleanUp(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CleanUp();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000C4BB File Offset: 0x0000A6BB
		[Register("cleanUp", "()I", "GetCleanUpHandler")]
		public virtual int CleanUp()
		{
			return SQLiteEventStore._members.InstanceMethods.InvokeVirtualInt32Method("cleanUp.()I", this, null);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
		private static Delegate GetClearDbHandler()
		{
			if (SQLiteEventStore.cb_clearDb == null)
			{
				SQLiteEventStore.cb_clearDb = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SQLiteEventStore.n_ClearDb));
			}
			return SQLiteEventStore.cb_clearDb;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		private static void n_ClearDb(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearDb();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000C507 File Offset: 0x0000A707
		[Register("clearDb", "()V", "GetClearDbHandler")]
		public virtual void ClearDb()
		{
			SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("clearDb.()V", this, null);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000C520 File Offset: 0x0000A720
		private static Delegate GetCloseHandler()
		{
			if (SQLiteEventStore.cb_close == null)
			{
				SQLiteEventStore.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SQLiteEventStore.n_Close));
			}
			return SQLiteEventStore.cb_close;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000C544 File Offset: 0x0000A744
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000C553 File Offset: 0x0000A753
		[Register("close", "()V", "GetCloseHandler")]
		public virtual void Close()
		{
			SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000C56C File Offset: 0x0000A76C
		private static Delegate GetGetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_Handler()
		{
			if (SQLiteEventStore.cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_ == null)
			{
				SQLiteEventStore.cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(SQLiteEventStore.n_GetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_));
			}
			return SQLiteEventStore.cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000C590 File Offset: 0x0000A790
		private static long n_GetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			return @object.GetNextCallTime(object2);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		[Register("getNextCallTime", "(Lcom/google/android/datatransport/runtime/TransportContext;)J", "GetGetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_Handler")]
		public unsafe virtual long GetNextCallTime(TransportContext transportContext)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				result = SQLiteEventStore._members.InstanceMethods.InvokeVirtualInt64Method("getNextCallTime.(Lcom/google/android/datatransport/runtime/TransportContext;)J", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
			return result;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000C61C File Offset: 0x0000A81C
		private static Delegate GetHasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_Handler()
		{
			if (SQLiteEventStore.cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_ == null)
			{
				SQLiteEventStore.cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SQLiteEventStore.n_HasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_));
			}
			return SQLiteEventStore.cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000C640 File Offset: 0x0000A840
		private static bool n_HasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			return @object.HasPendingEventsFor(object2);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000C664 File Offset: 0x0000A864
		[Register("hasPendingEventsFor", "(Lcom/google/android/datatransport/runtime/TransportContext;)Z", "GetHasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_Handler")]
		public unsafe virtual bool HasPendingEventsFor(TransportContext transportContext)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				result = SQLiteEventStore._members.InstanceMethods.InvokeVirtualBooleanMethod("hasPendingEventsFor.(Lcom/google/android/datatransport/runtime/TransportContext;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
			return result;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		private static Delegate GetLoadActiveContextsHandler()
		{
			if (SQLiteEventStore.cb_loadActiveContexts == null)
			{
				SQLiteEventStore.cb_loadActiveContexts = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SQLiteEventStore.n_LoadActiveContexts));
			}
			return SQLiteEventStore.cb_loadActiveContexts;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		private static IntPtr n_LoadActiveContexts(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadActiveContexts());
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000C704 File Offset: 0x0000A904
		[Register("loadActiveContexts", "()Ljava/lang/Iterable;", "GetLoadActiveContextsHandler")]
		public virtual IIterable LoadActiveContexts()
		{
			return Java.Lang.Object.GetObject<IIterable>(SQLiteEventStore._members.InstanceMethods.InvokeVirtualObjectMethod("loadActiveContexts.()Ljava/lang/Iterable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000C736 File Offset: 0x0000A936
		private static Delegate GetLoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_Handler()
		{
			if (SQLiteEventStore.cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_ == null)
			{
				SQLiteEventStore.cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SQLiteEventStore.n_LoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_));
			}
			return SQLiteEventStore.cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000C75C File Offset: 0x0000A95C
		private static IntPtr n_LoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadBatch(object2));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000C784 File Offset: 0x0000A984
		[Register("loadBatch", "(Lcom/google/android/datatransport/runtime/TransportContext;)Ljava/lang/Iterable;", "GetLoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_Handler")]
		public unsafe virtual IIterable LoadBatch(TransportContext transportContext)
		{
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				@object = Java.Lang.Object.GetObject<IIterable>(SQLiteEventStore._members.InstanceMethods.InvokeVirtualObjectMethod("loadBatch.(Lcom/google/android/datatransport/runtime/TransportContext;)Ljava/lang/Iterable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
			return @object;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		private static Delegate GetLoadClientMetricsHandler()
		{
			if (SQLiteEventStore.cb_loadClientMetrics == null)
			{
				SQLiteEventStore.cb_loadClientMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SQLiteEventStore.n_LoadClientMetrics));
			}
			return SQLiteEventStore.cb_loadClientMetrics;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000C81C File Offset: 0x0000AA1C
		private static IntPtr n_LoadClientMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadClientMetrics());
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000C830 File Offset: 0x0000AA30
		[Register("loadClientMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", "GetLoadClientMetricsHandler")]
		public virtual ClientMetrics LoadClientMetrics()
		{
			return Java.Lang.Object.GetObject<ClientMetrics>(SQLiteEventStore._members.InstanceMethods.InvokeVirtualObjectMethod("loadClientMetrics.()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000C862 File Offset: 0x0000AA62
		private static Delegate GetPersist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Handler()
		{
			if (SQLiteEventStore.cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_ == null)
			{
				SQLiteEventStore.cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SQLiteEventStore.n_Persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_));
			}
			return SQLiteEventStore.cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000C888 File Offset: 0x0000AA88
		private static IntPtr n_Persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, IntPtr native_e)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			EventInternal object3 = Java.Lang.Object.GetObject<EventInternal>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Persist(object2, object3));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000C8BC File Offset: 0x0000AABC
		[Register("persist", "(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent;", "GetPersist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Handler")]
		public unsafe virtual PersistedEvent Persist(TransportContext transportContext, EventInternal e)
		{
			PersistedEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				@object = Java.Lang.Object.GetObject<PersistedEvent>(SQLiteEventStore._members.InstanceMethods.InvokeVirtualObjectMethod("persist.(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transportContext);
				GC.KeepAlive(e);
			}
			return @object;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000C958 File Offset: 0x0000AB58
		private static Delegate GetRecordFailure_Ljava_lang_Iterable_Handler()
		{
			if (SQLiteEventStore.cb_recordFailure_Ljava_lang_Iterable_ == null)
			{
				SQLiteEventStore.cb_recordFailure_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SQLiteEventStore.n_RecordFailure_Ljava_lang_Iterable_));
			}
			return SQLiteEventStore.cb_recordFailure_Ljava_lang_Iterable_;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000C97C File Offset: 0x0000AB7C
		private static void n_RecordFailure_Ljava_lang_Iterable_(IntPtr jnienv, IntPtr native__this, IntPtr native_events)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IIterable object2 = Java.Lang.Object.GetObject<IIterable>(native_events, JniHandleOwnership.DoNotTransfer);
			@object.RecordFailure(object2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
		[Register("recordFailure", "(Ljava/lang/Iterable;)V", "GetRecordFailure_Ljava_lang_Iterable_Handler")]
		public unsafe virtual void RecordFailure(IIterable events)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((events == null) ? IntPtr.Zero : ((Java.Lang.Object)events).Handle);
				SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("recordFailure.(Ljava/lang/Iterable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(events);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000CA08 File Offset: 0x0000AC08
		private static Delegate GetRecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_Handler()
		{
			if (SQLiteEventStore.cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_ == null)
			{
				SQLiteEventStore.cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJLL_V(SQLiteEventStore.n_RecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_));
			}
			return SQLiteEventStore.cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		private static void n_RecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, long eventsDroppedCount, IntPtr native_reason, IntPtr native_logSource)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LogEventDropped.Reason object2 = Java.Lang.Object.GetObject<LogEventDropped.Reason>(native_reason, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_logSource, JniHandleOwnership.DoNotTransfer);
			@object.RecordLogEventDropped(eventsDroppedCount, object2, @string);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		[Register("recordLogEventDropped", "(JLcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;Ljava/lang/String;)V", "GetRecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_Handler")]
		public unsafe virtual void RecordLogEventDropped(long eventsDroppedCount, LogEventDropped.Reason reason, string logSource)
		{
			IntPtr intPtr = JNIEnv.NewString(logSource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(eventsDroppedCount);
				ptr[1] = new JniArgumentValue((reason == null) ? IntPtr.Zero : reason.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("recordLogEventDropped.(JLcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(reason);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		private static Delegate GetRecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_JHandler()
		{
			if (SQLiteEventStore.cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J == null)
			{
				SQLiteEventStore.cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_V(SQLiteEventStore.n_RecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J));
			}
			return SQLiteEventStore.cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000CB1C File Offset: 0x0000AD1C
		private static void n_RecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, long timestampMs)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			@object.RecordNextCallTime(object2, timestampMs);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Register("recordNextCallTime", "(Lcom/google/android/datatransport/runtime/TransportContext;J)V", "GetRecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_JHandler")]
		public unsafe virtual void RecordNextCallTime(TransportContext transportContext, long timestampMs)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(timestampMs);
				SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("recordNextCallTime.(Lcom/google/android/datatransport/runtime/TransportContext;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		private static Delegate GetRecordSuccess_Ljava_lang_Iterable_Handler()
		{
			if (SQLiteEventStore.cb_recordSuccess_Ljava_lang_Iterable_ == null)
			{
				SQLiteEventStore.cb_recordSuccess_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SQLiteEventStore.n_RecordSuccess_Ljava_lang_Iterable_));
			}
			return SQLiteEventStore.cb_recordSuccess_Ljava_lang_Iterable_;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000CBDC File Offset: 0x0000ADDC
		private static void n_RecordSuccess_Ljava_lang_Iterable_(IntPtr jnienv, IntPtr native__this, IntPtr native_events)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IIterable object2 = Java.Lang.Object.GetObject<IIterable>(native_events, JniHandleOwnership.DoNotTransfer);
			@object.RecordSuccess(object2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Register("recordSuccess", "(Ljava/lang/Iterable;)V", "GetRecordSuccess_Ljava_lang_Iterable_Handler")]
		public unsafe virtual void RecordSuccess(IIterable events)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((events == null) ? IntPtr.Zero : ((Java.Lang.Object)events).Handle);
				SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("recordSuccess.(Ljava/lang/Iterable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(events);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000CC68 File Offset: 0x0000AE68
		private static Delegate GetResetClientMetricsHandler()
		{
			if (SQLiteEventStore.cb_resetClientMetrics == null)
			{
				SQLiteEventStore.cb_resetClientMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SQLiteEventStore.n_ResetClientMetrics));
			}
			return SQLiteEventStore.cb_resetClientMetrics;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		private static void n_ResetClientMetrics(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetClientMetrics();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000CC9B File Offset: 0x0000AE9B
		[Register("resetClientMetrics", "()V", "GetResetClientMetricsHandler")]
		public virtual void ResetClientMetrics()
		{
			SQLiteEventStore._members.InstanceMethods.InvokeVirtualVoidMethod("resetClientMetrics.()V", this, null);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
		private static Delegate GetRunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_Handler()
		{
			if (SQLiteEventStore.cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_ == null)
			{
				SQLiteEventStore.cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SQLiteEventStore.n_RunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_));
			}
			return SQLiteEventStore.cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		private static IntPtr n_RunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_(IntPtr jnienv, IntPtr native__this, IntPtr native_criticalSection)
		{
			SQLiteEventStore @object = Java.Lang.Object.GetObject<SQLiteEventStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISynchronizationGuardCriticalSection object2 = Java.Lang.Object.GetObject<ISynchronizationGuardCriticalSection>(native_criticalSection, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunCriticalSection(object2));
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000CD00 File Offset: 0x0000AF00
		[Register("runCriticalSection", "(Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection;)Ljava/lang/Object;", "GetRunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object RunCriticalSection(ISynchronizationGuardCriticalSection criticalSection)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((criticalSection == null) ? IntPtr.Zero : ((Java.Lang.Object)criticalSection).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SQLiteEventStore._members.InstanceMethods.InvokeVirtualObjectMethod("runCriticalSection.(Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(criticalSection);
			}
			return @object;
		}

		// Token: 0x040000E8 RID: 232
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore", typeof(SQLiteEventStore));

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_cleanUp;

		// Token: 0x040000EA RID: 234
		private static Delegate cb_clearDb;

		// Token: 0x040000EB RID: 235
		private static Delegate cb_close;

		// Token: 0x040000EC RID: 236
		private static Delegate cb_getNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_hasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000EE RID: 238
		private static Delegate cb_loadActiveContexts;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_loadBatch_Lcom_google_android_datatransport_runtime_TransportContext_;

		// Token: 0x040000F0 RID: 240
		private static Delegate cb_loadClientMetrics;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_persist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_recordFailure_Ljava_lang_Iterable_;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_recordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_;

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_recordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_J;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_recordSuccess_Ljava_lang_Iterable_;

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_resetClientMetrics;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_;
	}
}
