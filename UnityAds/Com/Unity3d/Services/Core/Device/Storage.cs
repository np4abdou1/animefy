using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000121 RID: 289
	[Register("com/unity3d/services/core/device/Storage", DoNotGenerateAcw = true)]
	public class Storage : JsonStorage
	{
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000205DC File Offset: 0x0001E7DC
		internal new static IntPtr class_ref
		{
			get
			{
				return Storage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00020600 File Offset: 0x0001E800
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Storage._members;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00020608 File Offset: 0x0001E808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Storage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0002062C File Offset: 0x0001E82C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Storage._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00020638 File Offset: 0x0001E838
		protected Storage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00020644 File Offset: 0x0001E844
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", "")]
		public unsafe Storage(string targetFileName, StorageManager.StorageType type) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(targetFileName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				base.SetHandle(Storage._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Storage._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(type);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00020710 File Offset: 0x0001E910
		private static Delegate GetGetTypeHandler()
		{
			if (Storage.cb_getType == null)
			{
				Storage.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Storage.n_GetType));
			}
			return Storage.cb_getType;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00020734 File Offset: 0x0001E934
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00020748 File Offset: 0x0001E948
		public virtual StorageManager.StorageType Type
		{
			[Register("getType", "()Lcom/unity3d/services/core/device/StorageManager$StorageType;", "GetGetTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<StorageManager.StorageType>(Storage._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Lcom/unity3d/services/core/device/StorageManager$StorageType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0002077A File Offset: 0x0001E97A
		private static Delegate GetClearStorageHandler()
		{
			if (Storage.cb_clearStorage == null)
			{
				Storage.cb_clearStorage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Storage.n_ClearStorage));
			}
			return Storage.cb_clearStorage;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0002079E File Offset: 0x0001E99E
		private static bool n_ClearStorage(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearStorage();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000207AD File Offset: 0x0001E9AD
		[Register("clearStorage", "()Z", "GetClearStorageHandler")]
		public virtual bool ClearStorage()
		{
			return Storage._members.InstanceMethods.InvokeVirtualBooleanMethod("clearStorage.()Z", this, null);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000207C6 File Offset: 0x0001E9C6
		private static Delegate GetInitStorageHandler()
		{
			if (Storage.cb_initStorage == null)
			{
				Storage.cb_initStorage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Storage.n_InitStorage));
			}
			return Storage.cb_initStorage;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000207EA File Offset: 0x0001E9EA
		private static bool n_InitStorage(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitStorage();
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000207F9 File Offset: 0x0001E9F9
		[Register("initStorage", "()Z", "GetInitStorageHandler")]
		public virtual bool InitStorage()
		{
			return Storage._members.InstanceMethods.InvokeVirtualBooleanMethod("initStorage.()Z", this, null);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00020812 File Offset: 0x0001EA12
		private static Delegate GetReadStorageHandler()
		{
			if (Storage.cb_readStorage == null)
			{
				Storage.cb_readStorage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Storage.n_ReadStorage));
			}
			return Storage.cb_readStorage;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00020836 File Offset: 0x0001EA36
		private static bool n_ReadStorage(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReadStorage();
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00020845 File Offset: 0x0001EA45
		[Register("readStorage", "()Z", "GetReadStorageHandler")]
		public virtual bool ReadStorage()
		{
			return Storage._members.InstanceMethods.InvokeVirtualBooleanMethod("readStorage.()Z", this, null);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0002085E File Offset: 0x0001EA5E
		private static Delegate GetSendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_Handler()
		{
			if (Storage.cb_sendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_ == null)
			{
				Storage.cb_sendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Storage.n_SendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_));
			}
			return Storage.cb_sendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00020884 File Offset: 0x0001EA84
		private static void n_SendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_eventType, IntPtr native_value)
		{
			Storage @object = Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			StorageEvent object2 = Java.Lang.Object.GetObject<StorageEvent>(native_eventType, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(object2, object3);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000208B0 File Offset: 0x0001EAB0
		[Register("sendEvent", "(Lcom/unity3d/services/core/device/StorageEvent;Ljava/lang/Object;)V", "GetSendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_Handler")]
		public unsafe virtual void SendEvent(StorageEvent eventType, Java.Lang.Object value)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventType == null) ? IntPtr.Zero : eventType.Handle);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				Storage._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Lcom/unity3d/services/core/device/StorageEvent;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(eventType);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002093C File Offset: 0x0001EB3C
		private static Delegate GetStorageFileExistsHandler()
		{
			if (Storage.cb_storageFileExists == null)
			{
				Storage.cb_storageFileExists = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Storage.n_StorageFileExists));
			}
			return Storage.cb_storageFileExists;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00020960 File Offset: 0x0001EB60
		private static bool n_StorageFileExists(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StorageFileExists();
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0002096F File Offset: 0x0001EB6F
		[Register("storageFileExists", "()Z", "GetStorageFileExistsHandler")]
		public virtual bool StorageFileExists()
		{
			return Storage._members.InstanceMethods.InvokeVirtualBooleanMethod("storageFileExists.()Z", this, null);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00020988 File Offset: 0x0001EB88
		private static Delegate GetWriteStorageHandler()
		{
			if (Storage.cb_writeStorage == null)
			{
				Storage.cb_writeStorage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Storage.n_WriteStorage));
			}
			return Storage.cb_writeStorage;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000209AC File Offset: 0x0001EBAC
		private static bool n_WriteStorage(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Storage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WriteStorage();
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000209BB File Offset: 0x0001EBBB
		[Register("writeStorage", "()Z", "GetWriteStorageHandler")]
		public virtual bool WriteStorage()
		{
			return Storage._members.InstanceMethods.InvokeVirtualBooleanMethod("writeStorage.()Z", this, null);
		}

		// Token: 0x0400029F RID: 671
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/Storage", typeof(Storage));

		// Token: 0x040002A0 RID: 672
		private static Delegate cb_getType;

		// Token: 0x040002A1 RID: 673
		private static Delegate cb_clearStorage;

		// Token: 0x040002A2 RID: 674
		private static Delegate cb_initStorage;

		// Token: 0x040002A3 RID: 675
		private static Delegate cb_readStorage;

		// Token: 0x040002A4 RID: 676
		private static Delegate cb_sendEvent_Lcom_unity3d_services_core_device_StorageEvent_Ljava_lang_Object_;

		// Token: 0x040002A5 RID: 677
		private static Delegate cb_storageFileExists;

		// Token: 0x040002A6 RID: 678
		private static Delegate cb_writeStorage;
	}
}
