using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport;

namespace Firebase.Messaging
{
	// Token: 0x02000008 RID: 8
	[Register("com/google/firebase/messaging/FirebaseMessaging", DoNotGenerateAcw = true)]
	public class FirebaseMessaging : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		internal static IntPtr class_ref
		{
			get
			{
				return FirebaseMessaging._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002074 File Offset: 0x00000274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FirebaseMessaging._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000207C File Offset: 0x0000027C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FirebaseMessaging._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020A0 File Offset: 0x000002A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FirebaseMessaging._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020AC File Offset: 0x000002AC
		protected FirebaseMessaging(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020B6 File Offset: 0x000002B6
		private static Delegate GetIsAutoInitEnabledHandler()
		{
			if (FirebaseMessaging.cb_isAutoInitEnabled == null)
			{
				FirebaseMessaging.cb_isAutoInitEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FirebaseMessaging.n_IsAutoInitEnabled));
			}
			return FirebaseMessaging.cb_isAutoInitEnabled;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020DA File Offset: 0x000002DA
		private static bool n_IsAutoInitEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoInitEnabled;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020E9 File Offset: 0x000002E9
		private static Delegate GetSetAutoInitEnabled_ZHandler()
		{
			if (FirebaseMessaging.cb_setAutoInitEnabled_Z == null)
			{
				FirebaseMessaging.cb_setAutoInitEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(FirebaseMessaging.n_SetAutoInitEnabled_Z));
			}
			return FirebaseMessaging.cb_setAutoInitEnabled_Z;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000210D File Offset: 0x0000030D
		private static void n_SetAutoInitEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enable)
		{
			Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoInitEnabled = enable;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000211D File Offset: 0x0000031D
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002138 File Offset: 0x00000338
		public unsafe virtual bool AutoInitEnabled
		{
			[Register("isAutoInitEnabled", "()Z", "GetIsAutoInitEnabledHandler")]
			get
			{
				return FirebaseMessaging._members.InstanceMethods.InvokeVirtualBooleanMethod("isAutoInitEnabled.()Z", this, null);
			}
			[Register("setAutoInitEnabled", "(Z)V", "GetSetAutoInitEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FirebaseMessaging._members.InstanceMethods.InvokeVirtualVoidMethod("setAutoInitEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002174 File Offset: 0x00000374
		public static FirebaseMessaging Instance
		{
			[Register("getInstance", "()Lcom/google/firebase/messaging/FirebaseMessaging;", "")]
			get
			{
				return Java.Lang.Object.GetObject<FirebaseMessaging>(FirebaseMessaging._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/google/firebase/messaging/FirebaseMessaging;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021A5 File Offset: 0x000003A5
		private static Delegate GetIsNotificationDelegationEnabledHandler()
		{
			if (FirebaseMessaging.cb_isNotificationDelegationEnabled == null)
			{
				FirebaseMessaging.cb_isNotificationDelegationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FirebaseMessaging.n_IsNotificationDelegationEnabled));
			}
			return FirebaseMessaging.cb_isNotificationDelegationEnabled;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021C9 File Offset: 0x000003C9
		private static bool n_IsNotificationDelegationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNotificationDelegationEnabled;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000021D8 File Offset: 0x000003D8
		public virtual bool IsNotificationDelegationEnabled
		{
			[Register("isNotificationDelegationEnabled", "()Z", "GetIsNotificationDelegationEnabledHandler")]
			get
			{
				return FirebaseMessaging._members.InstanceMethods.InvokeVirtualBooleanMethod("isNotificationDelegationEnabled.()Z", this, null);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021F4 File Offset: 0x000003F4
		public static ITransportFactory TransportFactory
		{
			[Register("getTransportFactory", "()Lcom/google/android/datatransport/TransportFactory;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ITransportFactory>(FirebaseMessaging._members.StaticMethods.InvokeObjectMethod("getTransportFactory.()Lcom/google/android/datatransport/TransportFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002225 File Offset: 0x00000425
		private static Delegate GetDeleteTokenHandler()
		{
			if (FirebaseMessaging.cb_deleteToken == null)
			{
				FirebaseMessaging.cb_deleteToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FirebaseMessaging.n_DeleteToken));
			}
			return FirebaseMessaging.cb_deleteToken;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002249 File Offset: 0x00000449
		private static IntPtr n_DeleteToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeleteToken());
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002260 File Offset: 0x00000460
		[Register("deleteToken", "()Lcom/google/android/gms/tasks/Task;", "GetDeleteTokenHandler")]
		public virtual Task DeleteToken()
		{
			return Java.Lang.Object.GetObject<Task>(FirebaseMessaging._members.InstanceMethods.InvokeVirtualObjectMethod("deleteToken.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002292 File Offset: 0x00000492
		private static Delegate GetDeliveryMetricsExportToBigQueryEnabledHandler()
		{
			if (FirebaseMessaging.cb_deliveryMetricsExportToBigQueryEnabled == null)
			{
				FirebaseMessaging.cb_deliveryMetricsExportToBigQueryEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FirebaseMessaging.n_DeliveryMetricsExportToBigQueryEnabled));
			}
			return FirebaseMessaging.cb_deliveryMetricsExportToBigQueryEnabled;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000022B6 File Offset: 0x000004B6
		private static bool n_DeliveryMetricsExportToBigQueryEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeliveryMetricsExportToBigQueryEnabled();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000022C5 File Offset: 0x000004C5
		[Register("deliveryMetricsExportToBigQueryEnabled", "()Z", "GetDeliveryMetricsExportToBigQueryEnabledHandler")]
		public virtual bool DeliveryMetricsExportToBigQueryEnabled()
		{
			return FirebaseMessaging._members.InstanceMethods.InvokeVirtualBooleanMethod("deliveryMetricsExportToBigQueryEnabled.()Z", this, null);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000022DE File Offset: 0x000004DE
		private static Delegate GetGetTokenHandler()
		{
			if (FirebaseMessaging.cb_getToken == null)
			{
				FirebaseMessaging.cb_getToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FirebaseMessaging.n_GetToken));
			}
			return FirebaseMessaging.cb_getToken;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002302 File Offset: 0x00000502
		private static IntPtr n_GetToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetToken());
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002318 File Offset: 0x00000518
		[Register("getToken", "()Lcom/google/android/gms/tasks/Task;", "GetGetTokenHandler")]
		public virtual Task GetToken()
		{
			return Java.Lang.Object.GetObject<Task>(FirebaseMessaging._members.InstanceMethods.InvokeVirtualObjectMethod("getToken.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000234A File Offset: 0x0000054A
		private static Delegate GetSend_Lcom_google_firebase_messaging_RemoteMessage_Handler()
		{
			if (FirebaseMessaging.cb_send_Lcom_google_firebase_messaging_RemoteMessage_ == null)
			{
				FirebaseMessaging.cb_send_Lcom_google_firebase_messaging_RemoteMessage_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FirebaseMessaging.n_Send_Lcom_google_firebase_messaging_RemoteMessage_));
			}
			return FirebaseMessaging.cb_send_Lcom_google_firebase_messaging_RemoteMessage_;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002370 File Offset: 0x00000570
		private static void n_Send_Lcom_google_firebase_messaging_RemoteMessage_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			FirebaseMessaging @object = Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RemoteMessage object2 = Java.Lang.Object.GetObject<RemoteMessage>(native_message, JniHandleOwnership.DoNotTransfer);
			@object.Send(object2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002394 File Offset: 0x00000594
		[Register("send", "(Lcom/google/firebase/messaging/RemoteMessage;)V", "GetSend_Lcom_google_firebase_messaging_RemoteMessage_Handler")]
		public unsafe virtual void Send(RemoteMessage message)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((message == null) ? IntPtr.Zero : message.Handle);
				FirebaseMessaging._members.InstanceMethods.InvokeVirtualVoidMethod("send.(Lcom/google/firebase/messaging/RemoteMessage;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(message);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000023F8 File Offset: 0x000005F8
		private static Delegate GetSetDeliveryMetricsExportToBigQuery_ZHandler()
		{
			if (FirebaseMessaging.cb_setDeliveryMetricsExportToBigQuery_Z == null)
			{
				FirebaseMessaging.cb_setDeliveryMetricsExportToBigQuery_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(FirebaseMessaging.n_SetDeliveryMetricsExportToBigQuery_Z));
			}
			return FirebaseMessaging.cb_setDeliveryMetricsExportToBigQuery_Z;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000241C File Offset: 0x0000061C
		private static void n_SetDeliveryMetricsExportToBigQuery_Z(IntPtr jnienv, IntPtr native__this, bool enable)
		{
			Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDeliveryMetricsExportToBigQuery(enable);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000242C File Offset: 0x0000062C
		[Register("setDeliveryMetricsExportToBigQuery", "(Z)V", "GetSetDeliveryMetricsExportToBigQuery_ZHandler")]
		public unsafe virtual void SetDeliveryMetricsExportToBigQuery(bool enable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enable);
			FirebaseMessaging._members.InstanceMethods.InvokeVirtualVoidMethod("setDeliveryMetricsExportToBigQuery.(Z)V", this, ptr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002467 File Offset: 0x00000667
		private static Delegate GetSetNotificationDelegationEnabled_ZHandler()
		{
			if (FirebaseMessaging.cb_setNotificationDelegationEnabled_Z == null)
			{
				FirebaseMessaging.cb_setNotificationDelegationEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(FirebaseMessaging.n_SetNotificationDelegationEnabled_Z));
			}
			return FirebaseMessaging.cb_setNotificationDelegationEnabled_Z;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000248B File Offset: 0x0000068B
		private static IntPtr n_SetNotificationDelegationEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enable)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNotificationDelegationEnabled(enable));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024A0 File Offset: 0x000006A0
		[Register("setNotificationDelegationEnabled", "(Z)Lcom/google/android/gms/tasks/Task;", "GetSetNotificationDelegationEnabled_ZHandler")]
		public unsafe virtual Task SetNotificationDelegationEnabled(bool enable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enable);
			return Java.Lang.Object.GetObject<Task>(FirebaseMessaging._members.InstanceMethods.InvokeVirtualObjectMethod("setNotificationDelegationEnabled.(Z)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024E9 File Offset: 0x000006E9
		private static Delegate GetSubscribeToTopic_Ljava_lang_String_Handler()
		{
			if (FirebaseMessaging.cb_subscribeToTopic_Ljava_lang_String_ == null)
			{
				FirebaseMessaging.cb_subscribeToTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FirebaseMessaging.n_SubscribeToTopic_Ljava_lang_String_));
			}
			return FirebaseMessaging.cb_subscribeToTopic_Ljava_lang_String_;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002510 File Offset: 0x00000710
		private static IntPtr n_SubscribeToTopic_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			FirebaseMessaging @object = Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_topic, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SubscribeToTopic(@string));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002538 File Offset: 0x00000738
		[Register("subscribeToTopic", "(Ljava/lang/String;)Lcom/google/android/gms/tasks/Task;", "GetSubscribeToTopic_Ljava_lang_String_Handler")]
		public unsafe virtual Task SubscribeToTopic(string topic)
		{
			IntPtr intPtr = JNIEnv.NewString(topic);
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Task>(FirebaseMessaging._members.InstanceMethods.InvokeVirtualObjectMethod("subscribeToTopic.(Ljava/lang/String;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000025A4 File Offset: 0x000007A4
		private static Delegate GetUnsubscribeFromTopic_Ljava_lang_String_Handler()
		{
			if (FirebaseMessaging.cb_unsubscribeFromTopic_Ljava_lang_String_ == null)
			{
				FirebaseMessaging.cb_unsubscribeFromTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FirebaseMessaging.n_UnsubscribeFromTopic_Ljava_lang_String_));
			}
			return FirebaseMessaging.cb_unsubscribeFromTopic_Ljava_lang_String_;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000025C8 File Offset: 0x000007C8
		private static IntPtr n_UnsubscribeFromTopic_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			FirebaseMessaging @object = Java.Lang.Object.GetObject<FirebaseMessaging>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_topic, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.UnsubscribeFromTopic(@string));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000025F0 File Offset: 0x000007F0
		[Register("unsubscribeFromTopic", "(Ljava/lang/String;)Lcom/google/android/gms/tasks/Task;", "GetUnsubscribeFromTopic_Ljava_lang_String_Handler")]
		public unsafe virtual Task UnsubscribeFromTopic(string topic)
		{
			IntPtr intPtr = JNIEnv.NewString(topic);
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Task>(FirebaseMessaging._members.InstanceMethods.InvokeVirtualObjectMethod("unsubscribeFromTopic.(Ljava/lang/String;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/firebase/messaging/FirebaseMessaging", typeof(FirebaseMessaging));

		// Token: 0x04000002 RID: 2
		private static Delegate cb_isAutoInitEnabled;

		// Token: 0x04000003 RID: 3
		private static Delegate cb_setAutoInitEnabled_Z;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_isNotificationDelegationEnabled;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_deleteToken;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_deliveryMetricsExportToBigQueryEnabled;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getToken;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_send_Lcom_google_firebase_messaging_RemoteMessage_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_setDeliveryMetricsExportToBigQuery_Z;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_setNotificationDelegationEnabled_Z;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_subscribeToTopic_Ljava_lang_String_;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_unsubscribeFromTopic_Ljava_lang_String_;
	}
}
