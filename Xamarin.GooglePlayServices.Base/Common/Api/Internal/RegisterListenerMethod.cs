using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000035 RID: 53
	[Register("com/google/android/gms/common/api/internal/RegisterListenerMethod", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A extends com.google.android.gms.common.api.Api.AnyClient",
		"L"
	})]
	public abstract class RegisterListenerMethod : Java.Lang.Object
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00006698 File Offset: 0x00004898
		internal static IntPtr class_ref
		{
			get
			{
				return RegisterListenerMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000066BC File Offset: 0x000048BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RegisterListenerMethod._members;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000066C4 File Offset: 0x000048C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RegisterListenerMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000066E8 File Offset: 0x000048E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RegisterListenerMethod._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00003280 File Offset: 0x00001480
		protected RegisterListenerMethod(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000066F4 File Offset: 0x000048F4
		[Register(".ctor", "(Lcom/google/android/gms/common/api/internal/ListenerHolder;)V", "")]
		protected unsafe RegisterListenerMethod(ListenerHolder listenerHolder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listenerHolder == null) ? IntPtr.Zero : listenerHolder.Handle);
				base.SetHandle(RegisterListenerMethod._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RegisterListenerMethod._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listenerHolder);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000067A4 File Offset: 0x000049A4
		[Register(".ctor", "(Lcom/google/android/gms/common/api/internal/ListenerHolder;[Lcom/google/android/gms/common/Feature;Z)V", "")]
		protected unsafe RegisterListenerMethod(ListenerHolder listenerHolder, Feature[] requiredFeatures, bool shouldAutoResolveMissingFeatures) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<Feature>(requiredFeatures);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listenerHolder == null) ? IntPtr.Zero : listenerHolder.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(shouldAutoResolveMissingFeatures);
				base.SetHandle(RegisterListenerMethod._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder;[Lcom/google/android/gms/common/Feature;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RegisterListenerMethod._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder;[Lcom/google/android/gms/common/Feature;Z)V", this, ptr);
			}
			finally
			{
				if (requiredFeatures != null)
				{
					JNIEnv.CopyArray<Feature>(intPtr, requiredFeatures);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(listenerHolder);
				GC.KeepAlive(requiredFeatures);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006898 File Offset: 0x00004A98
		[Register(".ctor", "(Lcom/google/android/gms/common/api/internal/ListenerHolder;[Lcom/google/android/gms/common/Feature;ZI)V", "")]
		protected unsafe RegisterListenerMethod(ListenerHolder listenerHolder, Feature[] requiredFeatures, bool shouldAutoResolveMissingFeatures, int methodKey) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<Feature>(requiredFeatures);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listenerHolder == null) ? IntPtr.Zero : listenerHolder.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(shouldAutoResolveMissingFeatures);
				ptr[3] = new JniArgumentValue(methodKey);
				base.SetHandle(RegisterListenerMethod._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder;[Lcom/google/android/gms/common/Feature;ZI)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RegisterListenerMethod._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder;[Lcom/google/android/gms/common/Feature;ZI)V", this, ptr);
			}
			finally
			{
				if (requiredFeatures != null)
				{
					JNIEnv.CopyArray<Feature>(intPtr, requiredFeatures);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(listenerHolder);
				GC.KeepAlive(requiredFeatures);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000069A4 File Offset: 0x00004BA4
		private static Delegate GetGetListenerKeyHandler()
		{
			if (RegisterListenerMethod.cb_getListenerKey == null)
			{
				RegisterListenerMethod.cb_getListenerKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RegisterListenerMethod.n_GetListenerKey));
			}
			return RegisterListenerMethod.cb_getListenerKey;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000069C8 File Offset: 0x00004BC8
		private static IntPtr n_GetListenerKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RegisterListenerMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListenerKey);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000069DC File Offset: 0x00004BDC
		public virtual ListenerHolder.ListenerKey ListenerKey
		{
			[Register("getListenerKey", "()Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;", "GetGetListenerKeyHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ListenerHolder.ListenerKey>(RegisterListenerMethod._members.InstanceMethods.InvokeVirtualObjectMethod("getListenerKey.()Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006A0E File Offset: 0x00004C0E
		private static Delegate GetClearListenerHandler()
		{
			if (RegisterListenerMethod.cb_clearListener == null)
			{
				RegisterListenerMethod.cb_clearListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RegisterListenerMethod.n_ClearListener));
			}
			return RegisterListenerMethod.cb_clearListener;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006A32 File Offset: 0x00004C32
		private static void n_ClearListener(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RegisterListenerMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearListener();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006A41 File Offset: 0x00004C41
		[Register("clearListener", "()V", "GetClearListenerHandler")]
		public virtual void ClearListener()
		{
			RegisterListenerMethod._members.InstanceMethods.InvokeVirtualVoidMethod("clearListener.()V", this, null);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006A5A File Offset: 0x00004C5A
		private static Delegate GetGetRequiredFeaturesHandler()
		{
			if (RegisterListenerMethod.cb_getRequiredFeatures == null)
			{
				RegisterListenerMethod.cb_getRequiredFeatures = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RegisterListenerMethod.n_GetRequiredFeatures));
			}
			return RegisterListenerMethod.cb_getRequiredFeatures;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006A7E File Offset: 0x00004C7E
		private static IntPtr n_GetRequiredFeatures(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Feature>(Java.Lang.Object.GetObject<RegisterListenerMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRequiredFeatures());
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006A94 File Offset: 0x00004C94
		[Register("getRequiredFeatures", "()[Lcom/google/android/gms/common/Feature;", "GetGetRequiredFeaturesHandler")]
		public virtual Feature[] GetRequiredFeatures()
		{
			return (Feature[])JNIEnv.GetArray(RegisterListenerMethod._members.InstanceMethods.InvokeVirtualObjectMethod("getRequiredFeatures.()[Lcom/google/android/gms/common/Feature;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Feature));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00006AD5 File Offset: 0x00004CD5
		private static Delegate GetRegisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler()
		{
			if (RegisterListenerMethod.cb_registerListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_ == null)
			{
				RegisterListenerMethod.cb_registerListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RegisterListenerMethod.n_RegisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_));
			}
			return RegisterListenerMethod.cb_registerListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006AFC File Offset: 0x00004CFC
		private static void n_RegisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			RegisterListenerMethod @object = Java.Lang.Object.GetObject<RegisterListenerMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			TaskCompletionSource object3 = Java.Lang.Object.GetObject<TaskCompletionSource>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.RegisterListener(object2, object3);
		}

		// Token: 0x060001E3 RID: 483
		[Register("registerListener", "(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", "GetRegisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler")]
		protected abstract void RegisterListener(Java.Lang.Object p0, TaskCompletionSource p1);

		// Token: 0x060001E4 RID: 484 RVA: 0x00006B28 File Offset: 0x00004D28
		[Register("zaa", "()I", "")]
		public int Zaa()
		{
			return RegisterListenerMethod._members.InstanceMethods.InvokeNonvirtualInt32Method("zaa.()I", this, null);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006B41 File Offset: 0x00004D41
		[Register("zab", "()Z", "")]
		public bool Zab()
		{
			return RegisterListenerMethod._members.InstanceMethods.InvokeNonvirtualBooleanMethod("zab.()Z", this, null);
		}

		// Token: 0x04000060 RID: 96
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/RegisterListenerMethod", typeof(RegisterListenerMethod));

		// Token: 0x04000061 RID: 97
		private static Delegate cb_getListenerKey;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_clearListener;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_getRequiredFeatures;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_registerListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_;
	}
}
