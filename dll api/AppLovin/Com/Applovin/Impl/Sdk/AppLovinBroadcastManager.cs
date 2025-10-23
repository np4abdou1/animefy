using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x0200012C RID: 300
	[Register("com/applovin/impl/sdk/AppLovinBroadcastManager", DoNotGenerateAcw = true)]
	public class AppLovinBroadcastManager : Java.Lang.Object
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00024CE4 File Offset: 0x00022EE4
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinBroadcastManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00024D08 File Offset: 0x00022F08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinBroadcastManager._members;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00024D10 File Offset: 0x00022F10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinBroadcastManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00024D34 File Offset: 0x00022F34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinBroadcastManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinBroadcastManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00024D40 File Offset: 0x00022F40
		[Register("getInstance", "(Landroid/content/Context;)Lcom/applovin/impl/sdk/AppLovinBroadcastManager;", "")]
		public unsafe static AppLovinBroadcastManager GetInstance(Context p0)
		{
			AppLovinBroadcastManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(AppLovinBroadcastManager._members.StaticMethods.InvokeObjectMethod("getInstance.(Landroid/content/Context;)Lcom/applovin/impl/sdk/AppLovinBroadcastManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00024DB4 File Offset: 0x00022FB4
		private static Delegate GetRegisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_Handler()
		{
			if (AppLovinBroadcastManager.cb_registerReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_ == null)
			{
				AppLovinBroadcastManager.cb_registerReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinBroadcastManager.n_RegisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_));
			}
			return AppLovinBroadcastManager.cb_registerReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00024DD8 File Offset: 0x00022FD8
		private static void n_RegisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinBroadcastManager @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinBroadcastManager.IReceiver object2 = Java.Lang.Object.GetObject<AppLovinBroadcastManager.IReceiver>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntentFilter object3 = Java.Lang.Object.GetObject<IntentFilter>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.RegisterReceiver(object2, object3);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00024E04 File Offset: 0x00023004
		[Register("registerReceiver", "(Lcom/applovin/impl/sdk/AppLovinBroadcastManager$Receiver;Landroid/content/IntentFilter;)V", "GetRegisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_Handler")]
		public unsafe virtual void RegisterReceiver(AppLovinBroadcastManager.IReceiver p0, IntentFilter p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AppLovinBroadcastManager._members.InstanceMethods.InvokeVirtualVoidMethod("registerReceiver.(Lcom/applovin/impl/sdk/AppLovinBroadcastManager$Receiver;Landroid/content/IntentFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00024E94 File Offset: 0x00023094
		private static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_util_Map_Handler()
		{
			if (AppLovinBroadcastManager.cb_sendBroadcast_Landroid_content_Intent_Ljava_util_Map_ == null)
			{
				AppLovinBroadcastManager.cb_sendBroadcast_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(AppLovinBroadcastManager.n_SendBroadcast_Landroid_content_Intent_Ljava_util_Map_));
			}
			return AppLovinBroadcastManager.cb_sendBroadcast_Landroid_content_Intent_Ljava_util_Map_;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00024EB8 File Offset: 0x000230B8
		private static bool n_SendBroadcast_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinBroadcastManager @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> p = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.SendBroadcast(object2, p);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00024EE4 File Offset: 0x000230E4
		[Register("sendBroadcast", "(Landroid/content/Intent;Ljava/util/Map;)Z", "GetSendBroadcast_Landroid_content_Intent_Ljava_util_Map_Handler")]
		public unsafe virtual bool SendBroadcast(Intent p0, IDictionary<string, Java.Lang.Object> p1)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p1);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = AppLovinBroadcastManager._members.InstanceMethods.InvokeVirtualBooleanMethod("sendBroadcast.(Landroid/content/Intent;Ljava/util/Map;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00024F70 File Offset: 0x00023170
		private static Delegate GetSendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_Handler()
		{
			if (AppLovinBroadcastManager.cb_sendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_ == null)
			{
				AppLovinBroadcastManager.cb_sendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinBroadcastManager.n_SendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_));
			}
			return AppLovinBroadcastManager.cb_sendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00024F94 File Offset: 0x00023194
		private static void n_SendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinBroadcastManager @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> p = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SendBroadcastSync(object2, p);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00024FC0 File Offset: 0x000231C0
		[Register("sendBroadcastSync", "(Landroid/content/Intent;Ljava/util/Map;)V", "GetSendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_Handler")]
		public unsafe virtual void SendBroadcastSync(Intent p0, IDictionary<string, Java.Lang.Object> p1)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AppLovinBroadcastManager._members.InstanceMethods.InvokeVirtualVoidMethod("sendBroadcastSync.(Landroid/content/Intent;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0002504C File Offset: 0x0002324C
		private static Delegate GetSendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_Handler()
		{
			if (AppLovinBroadcastManager.cb_sendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_ == null)
			{
				AppLovinBroadcastManager.cb_sendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinBroadcastManager.n_SendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_));
			}
			return AppLovinBroadcastManager.cb_sendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00025070 File Offset: 0x00023270
		private static void n_SendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinBroadcastManager @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> p = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SendBroadcastSyncWithPendingBroadcasts(object2, p);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002509C File Offset: 0x0002329C
		[Register("sendBroadcastSyncWithPendingBroadcasts", "(Landroid/content/Intent;Ljava/util/Map;)V", "GetSendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_Handler")]
		public unsafe virtual void SendBroadcastSyncWithPendingBroadcasts(Intent p0, IDictionary<string, Java.Lang.Object> p1)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AppLovinBroadcastManager._members.InstanceMethods.InvokeVirtualVoidMethod("sendBroadcastSyncWithPendingBroadcasts.(Landroid/content/Intent;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00025128 File Offset: 0x00023328
		private static Delegate GetSendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (AppLovinBroadcastManager.cb_sendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				AppLovinBroadcastManager.cb_sendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(AppLovinBroadcastManager.n_SendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_));
			}
			return AppLovinBroadcastManager.cb_sendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002514C File Offset: 0x0002334C
		private static bool n_SendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinBroadcastManager @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.SendBroadcastWithAdObject(@string, object2);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00025178 File Offset: 0x00023378
		[Register("sendBroadcastWithAdObject", "(Ljava/lang/String;Ljava/lang/Object;)Z", "GetSendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual bool SendBroadcastWithAdObject(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = AppLovinBroadcastManager._members.InstanceMethods.InvokeVirtualBooleanMethod("sendBroadcastWithAdObject.(Ljava/lang/String;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00025200 File Offset: 0x00023400
		private static Delegate GetUnregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Handler()
		{
			if (AppLovinBroadcastManager.cb_unregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_ == null)
			{
				AppLovinBroadcastManager.cb_unregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinBroadcastManager.n_UnregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_));
			}
			return AppLovinBroadcastManager.cb_unregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00025224 File Offset: 0x00023424
		private static void n_UnregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinBroadcastManager @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinBroadcastManager.IReceiver object2 = Java.Lang.Object.GetObject<AppLovinBroadcastManager.IReceiver>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterReceiver(object2);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00025248 File Offset: 0x00023448
		[Register("unregisterReceiver", "(Lcom/applovin/impl/sdk/AppLovinBroadcastManager$Receiver;)V", "GetUnregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Handler")]
		public unsafe virtual void UnregisterReceiver(AppLovinBroadcastManager.IReceiver p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinBroadcastManager._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterReceiver.(Lcom/applovin/impl/sdk/AppLovinBroadcastManager$Receiver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040004BE RID: 1214
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinBroadcastManager", typeof(AppLovinBroadcastManager));

		// Token: 0x040004BF RID: 1215
		private static Delegate cb_registerReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_Landroid_content_IntentFilter_;

		// Token: 0x040004C0 RID: 1216
		private static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_util_Map_;

		// Token: 0x040004C1 RID: 1217
		private static Delegate cb_sendBroadcastSync_Landroid_content_Intent_Ljava_util_Map_;

		// Token: 0x040004C2 RID: 1218
		private static Delegate cb_sendBroadcastSyncWithPendingBroadcasts_Landroid_content_Intent_Ljava_util_Map_;

		// Token: 0x040004C3 RID: 1219
		private static Delegate cb_sendBroadcastWithAdObject_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x040004C4 RID: 1220
		private static Delegate cb_unregisterReceiver_Lcom_applovin_impl_sdk_AppLovinBroadcastManager_Receiver_;

		// Token: 0x0200012D RID: 301
		[Register("com/applovin/impl/sdk/AppLovinBroadcastManager$Receiver", "", "Com.Applovin.Impl.Sdk.AppLovinBroadcastManager/IReceiverInvoker")]
		public interface IReceiver : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000DBF RID: 3519
			[Register("onReceive", "(Landroid/content/Context;Landroid/content/Intent;Ljava/util/Map;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_Handler:Com.Applovin.Impl.Sdk.AppLovinBroadcastManager/IReceiverInvoker, AppLovin")]
			void OnReceive(Context p0, Intent p1, IDictionary<string, Java.Lang.Object> p2);
		}

		// Token: 0x0200012E RID: 302
		[Register("com/applovin/impl/sdk/AppLovinBroadcastManager$Receiver", DoNotGenerateAcw = true)]
		internal class IReceiverInvoker : Java.Lang.Object, AppLovinBroadcastManager.IReceiver, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000252CC File Offset: 0x000234CC
			private static IntPtr java_class_ref
			{
				get
				{
					return AppLovinBroadcastManager.IReceiverInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000252F0 File Offset: 0x000234F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinBroadcastManager.IReceiverInvoker._members;
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x000252F7 File Offset: 0x000234F7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000252FF File Offset: 0x000234FF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinBroadcastManager.IReceiverInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000DC4 RID: 3524 RVA: 0x0002530B File Offset: 0x0002350B
			public static AppLovinBroadcastManager.IReceiver GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<AppLovinBroadcastManager.IReceiver>(handle, transfer);
			}

			// Token: 0x06000DC5 RID: 3525 RVA: 0x00025314 File Offset: 0x00023514
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AppLovinBroadcastManager.IReceiverInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.impl.sdk.AppLovinBroadcastManager.Receiver'.");
				}
				return handle;
			}

			// Token: 0x06000DC6 RID: 3526 RVA: 0x0002533F File Offset: 0x0002353F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000DC7 RID: 3527 RVA: 0x00025370 File Offset: 0x00023570
			public IReceiverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AppLovinBroadcastManager.IReceiverInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000DC8 RID: 3528 RVA: 0x000253A8 File Offset: 0x000235A8
			private static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_Handler()
			{
				if (AppLovinBroadcastManager.IReceiverInvoker.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_ == null)
				{
					AppLovinBroadcastManager.IReceiverInvoker.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinBroadcastManager.IReceiverInvoker.n_OnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_));
				}
				return AppLovinBroadcastManager.IReceiverInvoker.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_;
			}

			// Token: 0x06000DC9 RID: 3529 RVA: 0x000253CC File Offset: 0x000235CC
			private static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				AppLovinBroadcastManager.IReceiver @object = Java.Lang.Object.GetObject<AppLovinBroadcastManager.IReceiver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
				Intent object3 = Java.Lang.Object.GetObject<Intent>(native_p1, JniHandleOwnership.DoNotTransfer);
				IDictionary<string, Java.Lang.Object> p = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
				@object.OnReceive(object2, object3, p);
			}

			// Token: 0x06000DCA RID: 3530 RVA: 0x00025404 File Offset: 0x00023604
			public unsafe void OnReceive(Context p0, Intent p1, IDictionary<string, Java.Lang.Object> p2)
			{
				if (this.id_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_ == IntPtr.Zero)
				{
					this.id_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;Ljava/util/Map;)V");
				}
				IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p2);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x040004C5 RID: 1221
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinBroadcastManager$Receiver", typeof(AppLovinBroadcastManager.IReceiverInvoker));

			// Token: 0x040004C6 RID: 1222
			private IntPtr class_ref;

			// Token: 0x040004C7 RID: 1223
			private static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_;

			// Token: 0x040004C8 RID: 1224
			private IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_;
		}
	}
}
