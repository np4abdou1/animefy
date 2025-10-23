using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000C RID: 12
	[Register("androidx/lifecycle/LiveData", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class LiveData : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002230 File Offset: 0x00000430
		internal static IntPtr class_ref
		{
			get
			{
				return LiveData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002254 File Offset: 0x00000454
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LiveData._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000225C File Offset: 0x0000045C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LiveData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002280 File Offset: 0x00000480
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LiveData._members.ManagedPeerType;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000228C File Offset: 0x0000048C
		protected LiveData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002298 File Offset: 0x00000498
		[Register(".ctor", "()V", "")]
		public LiveData() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LiveData._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LiveData._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002308 File Offset: 0x00000508
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe LiveData(Java.Lang.Object value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(LiveData._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LiveData._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000023B4 File Offset: 0x000005B4
		private static Delegate GetHasActiveObserversHandler()
		{
			if (LiveData.cb_hasActiveObservers == null)
			{
				LiveData.cb_hasActiveObservers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LiveData.n_HasActiveObservers));
			}
			return LiveData.cb_hasActiveObservers;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000023D8 File Offset: 0x000005D8
		private static bool n_HasActiveObservers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasActiveObservers;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000023E7 File Offset: 0x000005E7
		public virtual bool HasActiveObservers
		{
			[Register("hasActiveObservers", "()Z", "GetHasActiveObserversHandler")]
			get
			{
				return LiveData._members.InstanceMethods.InvokeVirtualBooleanMethod("hasActiveObservers.()Z", this, null);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002400 File Offset: 0x00000600
		private static Delegate GetHasObserversHandler()
		{
			if (LiveData.cb_hasObservers == null)
			{
				LiveData.cb_hasObservers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LiveData.n_HasObservers));
			}
			return LiveData.cb_hasObservers;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002424 File Offset: 0x00000624
		private static bool n_HasObservers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasObservers;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002433 File Offset: 0x00000633
		public virtual bool HasObservers
		{
			[Register("hasObservers", "()Z", "GetHasObserversHandler")]
			get
			{
				return LiveData._members.InstanceMethods.InvokeVirtualBooleanMethod("hasObservers.()Z", this, null);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000244C File Offset: 0x0000064C
		private static Delegate GetIsInitializedHandler()
		{
			if (LiveData.cb_isInitialized == null)
			{
				LiveData.cb_isInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LiveData.n_IsInitialized));
			}
			return LiveData.cb_isInitialized;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002470 File Offset: 0x00000670
		private static bool n_IsInitialized(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInitialized;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000247F File Offset: 0x0000067F
		public virtual bool IsInitialized
		{
			[Register("isInitialized", "()Z", "GetIsInitializedHandler")]
			get
			{
				return LiveData._members.InstanceMethods.InvokeVirtualBooleanMethod("isInitialized.()Z", this, null);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002498 File Offset: 0x00000698
		private static Delegate GetGetValueHandler()
		{
			if (LiveData.cb_getValue == null)
			{
				LiveData.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LiveData.n_GetValue));
			}
			return LiveData.cb_getValue;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000024BC File Offset: 0x000006BC
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000024D0 File Offset: 0x000006D0
		public virtual Java.Lang.Object Value
		{
			[Register("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(LiveData._members.InstanceMethods.InvokeVirtualObjectMethod("getValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002502 File Offset: 0x00000702
		private static Delegate GetObserve_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_Handler()
		{
			if (LiveData.cb_observe_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_ == null)
			{
				LiveData.cb_observe_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LiveData.n_Observe_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_));
			}
			return LiveData.cb_observe_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002528 File Offset: 0x00000728
		private static void n_Observe_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_(IntPtr jnienv, IntPtr native__this, IntPtr native_owner, IntPtr native_observer)
		{
			LiveData @object = Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object2 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_owner, JniHandleOwnership.DoNotTransfer);
			IObserver object3 = Java.Lang.Object.GetObject<IObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.Observe(object2, object3);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002554 File Offset: 0x00000754
		[Register("observe", "(Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Observer;)V", "GetObserve_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_Handler")]
		public unsafe virtual void Observe(ILifecycleOwner owner, IObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				ptr[1] = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("observe.(Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Observer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(owner);
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000025EC File Offset: 0x000007EC
		private static Delegate GetObserveForever_Landroidx_lifecycle_Observer_Handler()
		{
			if (LiveData.cb_observeForever_Landroidx_lifecycle_Observer_ == null)
			{
				LiveData.cb_observeForever_Landroidx_lifecycle_Observer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LiveData.n_ObserveForever_Landroidx_lifecycle_Observer_));
			}
			return LiveData.cb_observeForever_Landroidx_lifecycle_Observer_;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002610 File Offset: 0x00000810
		private static void n_ObserveForever_Landroidx_lifecycle_Observer_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			LiveData @object = Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IObserver object2 = Java.Lang.Object.GetObject<IObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.ObserveForever(object2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002634 File Offset: 0x00000834
		[Register("observeForever", "(Landroidx/lifecycle/Observer;)V", "GetObserveForever_Landroidx_lifecycle_Observer_Handler")]
		public unsafe virtual void ObserveForever(IObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("observeForever.(Landroidx/lifecycle/Observer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000269C File Offset: 0x0000089C
		private static Delegate GetOnActiveHandler()
		{
			if (LiveData.cb_onActive == null)
			{
				LiveData.cb_onActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LiveData.n_OnActive));
			}
			return LiveData.cb_onActive;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000026C0 File Offset: 0x000008C0
		private static void n_OnActive(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnActive();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000026CF File Offset: 0x000008CF
		[Register("onActive", "()V", "GetOnActiveHandler")]
		protected virtual void OnActive()
		{
			LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("onActive.()V", this, null);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000026E8 File Offset: 0x000008E8
		private static Delegate GetOnInactiveHandler()
		{
			if (LiveData.cb_onInactive == null)
			{
				LiveData.cb_onInactive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LiveData.n_OnInactive));
			}
			return LiveData.cb_onInactive;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000270C File Offset: 0x0000090C
		private static void n_OnInactive(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnInactive();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000271B File Offset: 0x0000091B
		[Register("onInactive", "()V", "GetOnInactiveHandler")]
		protected virtual void OnInactive()
		{
			LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("onInactive.()V", this, null);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002734 File Offset: 0x00000934
		private static Delegate GetPostValue_Ljava_lang_Object_Handler()
		{
			if (LiveData.cb_postValue_Ljava_lang_Object_ == null)
			{
				LiveData.cb_postValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LiveData.n_PostValue_Ljava_lang_Object_));
			}
			return LiveData.cb_postValue_Ljava_lang_Object_;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002758 File Offset: 0x00000958
		private static void n_PostValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			LiveData @object = Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.PostValue(object2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000277C File Offset: 0x0000097C
		[Register("postValue", "(Ljava/lang/Object;)V", "GetPostValue_Ljava_lang_Object_Handler")]
		protected unsafe virtual void PostValue(Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("postValue.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000027E0 File Offset: 0x000009E0
		private static Delegate GetRemoveObserver_Landroidx_lifecycle_Observer_Handler()
		{
			if (LiveData.cb_removeObserver_Landroidx_lifecycle_Observer_ == null)
			{
				LiveData.cb_removeObserver_Landroidx_lifecycle_Observer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LiveData.n_RemoveObserver_Landroidx_lifecycle_Observer_));
			}
			return LiveData.cb_removeObserver_Landroidx_lifecycle_Observer_;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002804 File Offset: 0x00000A04
		private static void n_RemoveObserver_Landroidx_lifecycle_Observer_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			LiveData @object = Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IObserver object2 = Java.Lang.Object.GetObject<IObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RemoveObserver(object2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002828 File Offset: 0x00000A28
		[Register("removeObserver", "(Landroidx/lifecycle/Observer;)V", "GetRemoveObserver_Landroidx_lifecycle_Observer_Handler")]
		public unsafe virtual void RemoveObserver(IObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("removeObserver.(Landroidx/lifecycle/Observer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002890 File Offset: 0x00000A90
		private static Delegate GetRemoveObservers_Landroidx_lifecycle_LifecycleOwner_Handler()
		{
			if (LiveData.cb_removeObservers_Landroidx_lifecycle_LifecycleOwner_ == null)
			{
				LiveData.cb_removeObservers_Landroidx_lifecycle_LifecycleOwner_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LiveData.n_RemoveObservers_Landroidx_lifecycle_LifecycleOwner_));
			}
			return LiveData.cb_removeObservers_Landroidx_lifecycle_LifecycleOwner_;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000028B4 File Offset: 0x00000AB4
		private static void n_RemoveObservers_Landroidx_lifecycle_LifecycleOwner_(IntPtr jnienv, IntPtr native__this, IntPtr native_owner)
		{
			LiveData @object = Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object2 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_owner, JniHandleOwnership.DoNotTransfer);
			@object.RemoveObservers(object2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000028D8 File Offset: 0x00000AD8
		[Register("removeObservers", "(Landroidx/lifecycle/LifecycleOwner;)V", "GetRemoveObservers_Landroidx_lifecycle_LifecycleOwner_Handler")]
		public unsafe virtual void RemoveObservers(ILifecycleOwner owner)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("removeObservers.(Landroidx/lifecycle/LifecycleOwner;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002940 File Offset: 0x00000B40
		private static Delegate GetSetValue_Ljava_lang_Object_Handler()
		{
			if (LiveData.cb_setValue_Ljava_lang_Object_ == null)
			{
				LiveData.cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LiveData.n_SetValue_Ljava_lang_Object_));
			}
			return LiveData.cb_setValue_Ljava_lang_Object_;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002964 File Offset: 0x00000B64
		private static void n_SetValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			LiveData @object = Java.Lang.Object.GetObject<LiveData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.SetValue(object2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002988 File Offset: 0x00000B88
		[Register("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")]
		protected unsafe virtual void SetValue(Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LiveData._members.InstanceMethods.InvokeVirtualVoidMethod("setValue.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/LiveData", typeof(LiveData));

		// Token: 0x04000008 RID: 8
		private static Delegate cb_hasActiveObservers;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_hasObservers;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_isInitialized;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_getValue;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_observe_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Observer_;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_observeForever_Landroidx_lifecycle_Observer_;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_onActive;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_onInactive;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_postValue_Ljava_lang_Object_;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_removeObserver_Landroidx_lifecycle_Observer_;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_removeObservers_Landroidx_lifecycle_LifecycleOwner_;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_setValue_Ljava_lang_Object_;
	}
}
