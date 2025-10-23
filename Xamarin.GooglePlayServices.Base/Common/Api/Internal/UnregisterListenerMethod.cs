using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200003C RID: 60
	[Register("com/google/android/gms/common/api/internal/UnregisterListenerMethod", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A extends com.google.android.gms.common.api.Api.AnyClient",
		"L"
	})]
	public abstract class UnregisterListenerMethod : Java.Lang.Object
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007C54 File Offset: 0x00005E54
		internal static IntPtr class_ref
		{
			get
			{
				return UnregisterListenerMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00007C78 File Offset: 0x00005E78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnregisterListenerMethod._members;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00007C80 File Offset: 0x00005E80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnregisterListenerMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00007CA4 File Offset: 0x00005EA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnregisterListenerMethod._members.ManagedPeerType;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003280 File Offset: 0x00001480
		protected UnregisterListenerMethod(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Register(".ctor", "(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;)V", "")]
		protected unsafe UnregisterListenerMethod(ListenerHolder.ListenerKey listenerKey) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listenerKey == null) ? IntPtr.Zero : listenerKey.Handle);
				base.SetHandle(UnregisterListenerMethod._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UnregisterListenerMethod._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listenerKey);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00007D60 File Offset: 0x00005F60
		private static Delegate GetGetListenerKeyHandler()
		{
			if (UnregisterListenerMethod.cb_getListenerKey == null)
			{
				UnregisterListenerMethod.cb_getListenerKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(UnregisterListenerMethod.n_GetListenerKey));
			}
			return UnregisterListenerMethod.cb_getListenerKey;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007D84 File Offset: 0x00005F84
		private static IntPtr n_GetListenerKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<UnregisterListenerMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListenerKey);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00007D98 File Offset: 0x00005F98
		public virtual ListenerHolder.ListenerKey ListenerKey
		{
			[Register("getListenerKey", "()Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;", "GetGetListenerKeyHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ListenerHolder.ListenerKey>(UnregisterListenerMethod._members.InstanceMethods.InvokeVirtualObjectMethod("getListenerKey.()Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00007DCA File Offset: 0x00005FCA
		private static Delegate GetUnregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler()
		{
			if (UnregisterListenerMethod.cb_unregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_ == null)
			{
				UnregisterListenerMethod.cb_unregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(UnregisterListenerMethod.n_UnregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_));
			}
			return UnregisterListenerMethod.cb_unregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007DF0 File Offset: 0x00005FF0
		private static void n_UnregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			UnregisterListenerMethod @object = Java.Lang.Object.GetObject<UnregisterListenerMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			TaskCompletionSource object3 = Java.Lang.Object.GetObject<TaskCompletionSource>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterListener(object2, object3);
		}

		// Token: 0x06000250 RID: 592
		[Register("unregisterListener", "(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", "GetUnregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler")]
		protected abstract void UnregisterListener(Java.Lang.Object p0, TaskCompletionSource p1);

		// Token: 0x0400007B RID: 123
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/UnregisterListenerMethod", typeof(UnregisterListenerMethod));

		// Token: 0x0400007C RID: 124
		private static Delegate cb_getListenerKey;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_unregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_;
	}
}
