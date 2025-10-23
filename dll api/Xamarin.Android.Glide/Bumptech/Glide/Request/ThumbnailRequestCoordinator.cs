using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000099 RID: 153
	[Register("com/bumptech/glide/request/ThumbnailRequestCoordinator", DoNotGenerateAcw = true)]
	public class ThumbnailRequestCoordinator : Java.Lang.Object, IRequest, IJavaObject, IDisposable, IJavaPeerable, IRequestCoordinator
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00018E00 File Offset: 0x00017000
		internal static IntPtr class_ref
		{
			get
			{
				return ThumbnailRequestCoordinator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00018E24 File Offset: 0x00017024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThumbnailRequestCoordinator._members;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00018E2C File Offset: 0x0001702C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThumbnailRequestCoordinator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00018E50 File Offset: 0x00017050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThumbnailRequestCoordinator._members.ManagedPeerType;
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00018E5C File Offset: 0x0001705C
		protected ThumbnailRequestCoordinator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00018E68 File Offset: 0x00017068
		[Register(".ctor", "(Ljava/lang/Object;Lcom/bumptech/glide/request/RequestCoordinator;)V", "")]
		public unsafe ThumbnailRequestCoordinator(Java.Lang.Object requestLock, IRequestCoordinator parent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestLock == null) ? IntPtr.Zero : requestLock.Handle);
				ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((Java.Lang.Object)parent).Handle);
				base.SetHandle(ThumbnailRequestCoordinator._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Lcom/bumptech/glide/request/RequestCoordinator;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ThumbnailRequestCoordinator._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Lcom/bumptech/glide/request/RequestCoordinator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(requestLock);
				GC.KeepAlive(parent);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00018F44 File Offset: 0x00017144
		private static Delegate GetIsAnyResourceSetHandler()
		{
			if (ThumbnailRequestCoordinator.cb_isAnyResourceSet == null)
			{
				ThumbnailRequestCoordinator.cb_isAnyResourceSet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ThumbnailRequestCoordinator.n_IsAnyResourceSet));
			}
			return ThumbnailRequestCoordinator.cb_isAnyResourceSet;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00018F68 File Offset: 0x00017168
		private static bool n_IsAnyResourceSet(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAnyResourceSet;
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00018F77 File Offset: 0x00017177
		public virtual bool IsAnyResourceSet
		{
			[Register("isAnyResourceSet", "()Z", "GetIsAnyResourceSetHandler")]
			get
			{
				return ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("isAnyResourceSet.()Z", this, null);
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00018F90 File Offset: 0x00017190
		private static Delegate GetIsClearedHandler()
		{
			if (ThumbnailRequestCoordinator.cb_isCleared == null)
			{
				ThumbnailRequestCoordinator.cb_isCleared = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ThumbnailRequestCoordinator.n_IsCleared));
			}
			return ThumbnailRequestCoordinator.cb_isCleared;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00018FB4 File Offset: 0x000171B4
		private static bool n_IsCleared(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCleared;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00018FC3 File Offset: 0x000171C3
		public virtual bool IsCleared
		{
			[Register("isCleared", "()Z", "GetIsClearedHandler")]
			get
			{
				return ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("isCleared.()Z", this, null);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00018FDC File Offset: 0x000171DC
		private static Delegate GetIsCompleteHandler()
		{
			if (ThumbnailRequestCoordinator.cb_isComplete == null)
			{
				ThumbnailRequestCoordinator.cb_isComplete = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ThumbnailRequestCoordinator.n_IsComplete));
			}
			return ThumbnailRequestCoordinator.cb_isComplete;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00019000 File Offset: 0x00017200
		private static bool n_IsComplete(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsComplete;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0001900F File Offset: 0x0001720F
		public virtual bool IsComplete
		{
			[Register("isComplete", "()Z", "GetIsCompleteHandler")]
			get
			{
				return ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("isComplete.()Z", this, null);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00019028 File Offset: 0x00017228
		private static Delegate GetIsRunningHandler()
		{
			if (ThumbnailRequestCoordinator.cb_isRunning == null)
			{
				ThumbnailRequestCoordinator.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ThumbnailRequestCoordinator.n_IsRunning));
			}
			return ThumbnailRequestCoordinator.cb_isRunning;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0001904C File Offset: 0x0001724C
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0001905B File Offset: 0x0001725B
		public virtual bool IsRunning
		{
			[Register("isRunning", "()Z", "GetIsRunningHandler")]
			get
			{
				return ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("isRunning.()Z", this, null);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00019074 File Offset: 0x00017274
		private static Delegate GetGetRootHandler()
		{
			if (ThumbnailRequestCoordinator.cb_getRoot == null)
			{
				ThumbnailRequestCoordinator.cb_getRoot = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ThumbnailRequestCoordinator.n_GetRoot));
			}
			return ThumbnailRequestCoordinator.cb_getRoot;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00019098 File Offset: 0x00017298
		private static IntPtr n_GetRoot(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Root);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000190AC File Offset: 0x000172AC
		public virtual IRequestCoordinator Root
		{
			[Register("getRoot", "()Lcom/bumptech/glide/request/RequestCoordinator;", "GetGetRootHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IRequestCoordinator>(ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualObjectMethod("getRoot.()Lcom/bumptech/glide/request/RequestCoordinator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000190DE File Offset: 0x000172DE
		private static Delegate GetBeginHandler()
		{
			if (ThumbnailRequestCoordinator.cb_begin == null)
			{
				ThumbnailRequestCoordinator.cb_begin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ThumbnailRequestCoordinator.n_Begin));
			}
			return ThumbnailRequestCoordinator.cb_begin;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00019102 File Offset: 0x00017302
		private static void n_Begin(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Begin();
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00019111 File Offset: 0x00017311
		[Register("begin", "()V", "GetBeginHandler")]
		public virtual void Begin()
		{
			ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualVoidMethod("begin.()V", this, null);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0001912A File Offset: 0x0001732A
		private static Delegate GetCanNotifyCleared_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ThumbnailRequestCoordinator.n_CanNotifyCleared_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00019150 File Offset: 0x00017350
		private static bool n_CanNotifyCleared_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			return @object.CanNotifyCleared(object2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00019174 File Offset: 0x00017374
		[Register("canNotifyCleared", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanNotifyCleared_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual bool CanNotifyCleared(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("canNotifyCleared.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000191E0 File Offset: 0x000173E0
		private static Delegate GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ThumbnailRequestCoordinator.n_CanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00019204 File Offset: 0x00017404
		private static bool n_CanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			return @object.CanNotifyStatusChanged(object2);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00019228 File Offset: 0x00017428
		[Register("canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual bool CanNotifyStatusChanged(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("canNotifyStatusChanged.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00019294 File Offset: 0x00017494
		private static Delegate GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_canSetImage_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_canSetImage_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ThumbnailRequestCoordinator.n_CanSetImage_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_canSetImage_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000192B8 File Offset: 0x000174B8
		private static bool n_CanSetImage_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			return @object.CanSetImage(object2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000192DC File Offset: 0x000174DC
		[Register("canSetImage", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual bool CanSetImage(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("canSetImage.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00019348 File Offset: 0x00017548
		private static Delegate GetClearHandler()
		{
			if (ThumbnailRequestCoordinator.cb_clear == null)
			{
				ThumbnailRequestCoordinator.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ThumbnailRequestCoordinator.n_Clear));
			}
			return ThumbnailRequestCoordinator.cb_clear;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001936C File Offset: 0x0001756C
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001937B File Offset: 0x0001757B
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00019394 File Offset: 0x00017594
		private static Delegate GetIsEquivalentTo_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ThumbnailRequestCoordinator.n_IsEquivalentTo_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000193B8 File Offset: 0x000175B8
		private static bool n_IsEquivalentTo_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.IsEquivalentTo(object2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000193DC File Offset: 0x000175DC
		[Register("isEquivalentTo", "(Lcom/bumptech/glide/request/Request;)Z", "GetIsEquivalentTo_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual bool IsEquivalentTo(IRequest o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : ((Java.Lang.Object)o).Handle);
				result = ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualBooleanMethod("isEquivalentTo.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00019448 File Offset: 0x00017648
		private static Delegate GetOnRequestFailed_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_onRequestFailed_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_onRequestFailed_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ThumbnailRequestCoordinator.n_OnRequestFailed_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_onRequestFailed_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0001946C File Offset: 0x0001766C
		private static void n_OnRequestFailed_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestFailed(object2);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00019490 File Offset: 0x00017690
		[Register("onRequestFailed", "(Lcom/bumptech/glide/request/Request;)V", "GetOnRequestFailed_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual void OnRequestFailed(IRequest request)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestFailed.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000194F8 File Offset: 0x000176F8
		private static Delegate GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ThumbnailRequestCoordinator.n_OnRequestSuccess_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001951C File Offset: 0x0001771C
		private static void n_OnRequestSuccess_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestSuccess(object2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00019540 File Offset: 0x00017740
		[Register("onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V", "GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual void OnRequestSuccess(IRequest request)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestSuccess.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000195A8 File Offset: 0x000177A8
		private static Delegate GetPauseHandler()
		{
			if (ThumbnailRequestCoordinator.cb_pause == null)
			{
				ThumbnailRequestCoordinator.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ThumbnailRequestCoordinator.n_Pause));
			}
			return ThumbnailRequestCoordinator.cb_pause;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000195CC File Offset: 0x000177CC
		private static void n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000195DB File Offset: 0x000177DB
		[Register("pause", "()V", "GetPauseHandler")]
		public virtual void Pause()
		{
			ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualVoidMethod("pause.()V", this, null);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000195F4 File Offset: 0x000177F4
		private static Delegate GetSetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ThumbnailRequestCoordinator.cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ == null)
			{
				ThumbnailRequestCoordinator.cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ThumbnailRequestCoordinator.n_SetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_));
			}
			return ThumbnailRequestCoordinator.cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00019618 File Offset: 0x00017818
		private static void n_SetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_full, IntPtr native_thumb)
		{
			ThumbnailRequestCoordinator @object = Java.Lang.Object.GetObject<ThumbnailRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_full, JniHandleOwnership.DoNotTransfer);
			IRequest object3 = Java.Lang.Object.GetObject<IRequest>(native_thumb, JniHandleOwnership.DoNotTransfer);
			@object.SetRequests(object2, object3);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00019644 File Offset: 0x00017844
		[Register("setRequests", "(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V", "GetSetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual void SetRequests(IRequest full, IRequest thumb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((full == null) ? IntPtr.Zero : ((Java.Lang.Object)full).Handle);
				ptr[1] = new JniArgumentValue((thumb == null) ? IntPtr.Zero : ((Java.Lang.Object)thumb).Handle);
				ThumbnailRequestCoordinator._members.InstanceMethods.InvokeVirtualVoidMethod("setRequests.(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(full);
				GC.KeepAlive(thumb);
			}
		}

		// Token: 0x040001F6 RID: 502
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/ThumbnailRequestCoordinator", typeof(ThumbnailRequestCoordinator));

		// Token: 0x040001F7 RID: 503
		private static Delegate cb_isAnyResourceSet;

		// Token: 0x040001F8 RID: 504
		private static Delegate cb_isCleared;

		// Token: 0x040001F9 RID: 505
		private static Delegate cb_isComplete;

		// Token: 0x040001FA RID: 506
		private static Delegate cb_isRunning;

		// Token: 0x040001FB RID: 507
		private static Delegate cb_getRoot;

		// Token: 0x040001FC RID: 508
		private static Delegate cb_begin;

		// Token: 0x040001FD RID: 509
		private static Delegate cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001FE RID: 510
		private static Delegate cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001FF RID: 511
		private static Delegate cb_canSetImage_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000200 RID: 512
		private static Delegate cb_clear;

		// Token: 0x04000201 RID: 513
		private static Delegate cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000202 RID: 514
		private static Delegate cb_onRequestFailed_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000203 RID: 515
		private static Delegate cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000204 RID: 516
		private static Delegate cb_pause;

		// Token: 0x04000205 RID: 517
		private static Delegate cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_;
	}
}
