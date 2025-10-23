using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request.Target;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000097 RID: 151
	[Register("com/bumptech/glide/request/RequestFutureTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public class RequestFutureTarget : Java.Lang.Object, IFutureTarget, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable, IFuture, IRequestListener
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00017B7C File Offset: 0x00015D7C
		internal static IntPtr class_ref
		{
			get
			{
				return RequestFutureTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00017BA0 File Offset: 0x00015DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestFutureTarget._members;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00017BA8 File Offset: 0x00015DA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestFutureTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00017BCC File Offset: 0x00015DCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestFutureTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00017BD8 File Offset: 0x00015DD8
		protected RequestFutureTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00017BE4 File Offset: 0x00015DE4
		[Register(".ctor", "(II)V", "")]
		public unsafe RequestFutureTarget(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			base.SetHandle(RequestFutureTarget._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			RequestFutureTarget._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00017C7B File Offset: 0x00015E7B
		private static Delegate GetIsCancelledHandler()
		{
			if (RequestFutureTarget.cb_isCancelled == null)
			{
				RequestFutureTarget.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RequestFutureTarget.n_IsCancelled));
			}
			return RequestFutureTarget.cb_isCancelled;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00017C9F File Offset: 0x00015E9F
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00017CAE File Offset: 0x00015EAE
		public virtual bool IsCancelled
		{
			[Register("isCancelled", "()Z", "GetIsCancelledHandler")]
			get
			{
				return RequestFutureTarget._members.InstanceMethods.InvokeVirtualBooleanMethod("isCancelled.()Z", this, null);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00017CC7 File Offset: 0x00015EC7
		private static Delegate GetIsDoneHandler()
		{
			if (RequestFutureTarget.cb_isDone == null)
			{
				RequestFutureTarget.cb_isDone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RequestFutureTarget.n_IsDone));
			}
			return RequestFutureTarget.cb_isDone;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00017CEB File Offset: 0x00015EEB
		private static bool n_IsDone(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDone;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00017CFA File Offset: 0x00015EFA
		public virtual bool IsDone
		{
			[Register("isDone", "()Z", "GetIsDoneHandler")]
			get
			{
				return RequestFutureTarget._members.InstanceMethods.InvokeVirtualBooleanMethod("isDone.()Z", this, null);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00017D13 File Offset: 0x00015F13
		private static Delegate GetGetRequestHandler()
		{
			if (RequestFutureTarget.cb_getRequest == null)
			{
				RequestFutureTarget.cb_getRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestFutureTarget.n_GetRequest));
			}
			return RequestFutureTarget.cb_getRequest;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00017D37 File Offset: 0x00015F37
		private static IntPtr n_GetRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Request);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00017D4B File Offset: 0x00015F4B
		private static Delegate GetSetRequest_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (RequestFutureTarget.cb_setRequest_Lcom_bumptech_glide_request_Request_ == null)
			{
				RequestFutureTarget.cb_setRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestFutureTarget.n_SetRequest_Lcom_bumptech_glide_request_Request_));
			}
			return RequestFutureTarget.cb_setRequest_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00017D70 File Offset: 0x00015F70
		private static void n_SetRequest_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			@object.Request = object2;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00017D94 File Offset: 0x00015F94
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00017DC8 File Offset: 0x00015FC8
		public unsafe virtual IRequest Request
		{
			[Register("getRequest", "()Lcom/bumptech/glide/request/Request;", "GetGetRequestHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IRequest>(RequestFutureTarget._members.InstanceMethods.InvokeVirtualObjectMethod("getRequest.()Lcom/bumptech/glide/request/Request;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetSetRequest_Lcom_bumptech_glide_request_Request_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("setRequest.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00017E30 File Offset: 0x00016030
		private static Delegate GetCancel_ZHandler()
		{
			if (RequestFutureTarget.cb_cancel_Z == null)
			{
				RequestFutureTarget.cb_cancel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(RequestFutureTarget.n_Cancel_Z));
			}
			return RequestFutureTarget.cb_cancel_Z;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00017E54 File Offset: 0x00016054
		private static bool n_Cancel_Z(IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			return Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel(mayInterruptIfRunning);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00017E64 File Offset: 0x00016064
		[Register("cancel", "(Z)Z", "GetCancel_ZHandler")]
		public unsafe virtual bool Cancel(bool mayInterruptIfRunning)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(mayInterruptIfRunning);
			return RequestFutureTarget._members.InstanceMethods.InvokeVirtualBooleanMethod("cancel.(Z)Z", this, ptr);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00017E9F File Offset: 0x0001609F
		private static Delegate GetGetHandler()
		{
			if (RequestFutureTarget.cb_get == null)
			{
				RequestFutureTarget.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestFutureTarget.n_Get));
			}
			return RequestFutureTarget.cb_get;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00017EC3 File Offset: 0x000160C3
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00017ED8 File Offset: 0x000160D8
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(RequestFutureTarget._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00017F0A File Offset: 0x0001610A
		private static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (RequestFutureTarget.cb_get_JLjava_util_concurrent_TimeUnit_ == null)
			{
				RequestFutureTarget.cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(RequestFutureTarget.n_Get_JLjava_util_concurrent_TimeUnit_));
			}
			return RequestFutureTarget.cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00017F30 File Offset: 0x00016130
		private static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long time, IntPtr native_timeUnit)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_timeUnit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(time, object2));
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00017F5C File Offset: 0x0001615C
		[Register("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public unsafe virtual Java.Lang.Object Get(long time, TimeUnit timeUnit)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(time);
				ptr[1] = new JniArgumentValue((timeUnit == null) ? IntPtr.Zero : timeUnit.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RequestFutureTarget._members.InstanceMethods.InvokeVirtualObjectMethod("get.(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(timeUnit);
			}
			return @object;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00017FE4 File Offset: 0x000161E4
		private static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (RequestFutureTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				RequestFutureTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestFutureTarget.n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return RequestFutureTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00018008 File Offset: 0x00016208
		private static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.GetSize(object2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0001802C File Offset: 0x0001622C
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe virtual void GetSize(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("getSize.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00018094 File Offset: 0x00016294
		private static Delegate GetOnDestroyHandler()
		{
			if (RequestFutureTarget.cb_onDestroy == null)
			{
				RequestFutureTarget.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestFutureTarget.n_OnDestroy));
			}
			return RequestFutureTarget.cb_onDestroy;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000180B8 File Offset: 0x000162B8
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000180C7 File Offset: 0x000162C7
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000180E0 File Offset: 0x000162E0
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (RequestFutureTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				RequestFutureTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestFutureTarget.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return RequestFutureTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00018104 File Offset: 0x00016304
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00018128 File Offset: 0x00016328
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadCleared(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001818C File Offset: 0x0001638C
		private static Delegate GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (RequestFutureTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ == null)
			{
				RequestFutureTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestFutureTarget.n_OnLoadFailed_Landroid_graphics_drawable_Drawable_));
			}
			return RequestFutureTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000181B0 File Offset: 0x000163B0
		private static void n_OnLoadFailed_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorDrawable)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_errorDrawable, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000181D4 File Offset: 0x000163D4
		[Register("onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadFailed(Drawable errorDrawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorDrawable == null) ? IntPtr.Zero : errorDrawable.Handle);
				RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadFailed.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorDrawable);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00018238 File Offset: 0x00016438
		private static Delegate GetOnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler()
		{
			if (RequestFutureTarget.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z == null)
			{
				RequestFutureTarget.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLZ_Z(RequestFutureTarget.n_OnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z));
			}
			return RequestFutureTarget.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001825C File Offset: 0x0001645C
		private static bool n_OnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_model, IntPtr native_target, bool isFirstResource)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GlideException object2 = Java.Lang.Object.GetObject<GlideException>(native_e, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			ITarget object4 = Java.Lang.Object.GetObject<ITarget>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnLoadFailed(object2, object3, object4, isFirstResource);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00018294 File Offset: 0x00016494
		[Register("onLoadFailed", "(Lcom/bumptech/glide/load/engine/GlideException;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z", "GetOnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler")]
		public unsafe virtual bool OnLoadFailed(GlideException e, Java.Lang.Object model, ITarget target, bool isFirstResource)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				ptr[1] = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				ptr[3] = new JniArgumentValue(isFirstResource);
				result = RequestFutureTarget._members.InstanceMethods.InvokeVirtualBooleanMethod("onLoadFailed.(Lcom/bumptech/glide/load/engine/GlideException;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
				GC.KeepAlive(model);
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00018368 File Offset: 0x00016568
		private static Delegate GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (RequestFutureTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ == null)
			{
				RequestFutureTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestFutureTarget.n_OnLoadStarted_Landroid_graphics_drawable_Drawable_));
			}
			return RequestFutureTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001838C File Offset: 0x0001658C
		private static void n_OnLoadStarted_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadStarted(object2);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000183B0 File Offset: 0x000165B0
		[Register("onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadStarted(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadStarted.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00018414 File Offset: 0x00016614
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (RequestFutureTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				RequestFutureTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RequestFutureTarget.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return RequestFutureTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00018438 File Offset: 0x00016638
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00018464 File Offset: 0x00016664
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe virtual void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000184F4 File Offset: 0x000166F4
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (RequestFutureTarget.cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				RequestFutureTarget.cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLZ_Z(RequestFutureTarget.n_OnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return RequestFutureTarget.cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00018518 File Offset: 0x00016718
		private static bool n_OnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_model, IntPtr native_target, IntPtr native_dataSource, bool isFirstResource)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			ITarget object4 = Java.Lang.Object.GetObject<ITarget>(native_target, JniHandleOwnership.DoNotTransfer);
			DataSource object5 = Java.Lang.Object.GetObject<DataSource>(native_dataSource, JniHandleOwnership.DoNotTransfer);
			return @object.OnResourceReady(object2, object3, object4, object5, isFirstResource);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0001855C File Offset: 0x0001675C
		[Register("onResourceReady", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Lcom/bumptech/glide/load/DataSource;Z)Z", "GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_ZHandler")]
		public unsafe virtual bool OnResourceReady(Java.Lang.Object resource, Java.Lang.Object model, ITarget target, DataSource dataSource, bool isFirstResource)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				ptr[3] = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
				ptr[4] = new JniArgumentValue(isFirstResource);
				result = RequestFutureTarget._members.InstanceMethods.InvokeVirtualBooleanMethod("onResourceReady.(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Lcom/bumptech/glide/load/DataSource;Z)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(model);
				GC.KeepAlive(target);
				GC.KeepAlive(dataSource);
			}
			return result;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001865C File Offset: 0x0001685C
		private static Delegate GetOnStartHandler()
		{
			if (RequestFutureTarget.cb_onStart == null)
			{
				RequestFutureTarget.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestFutureTarget.n_OnStart));
			}
			return RequestFutureTarget.cb_onStart;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00018680 File Offset: 0x00016880
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001868F File Offset: 0x0001688F
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000186A8 File Offset: 0x000168A8
		private static Delegate GetOnStopHandler()
		{
			if (RequestFutureTarget.cb_onStop == null)
			{
				RequestFutureTarget.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestFutureTarget.n_OnStop));
			}
			return RequestFutureTarget.cb_onStop;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000186CC File Offset: 0x000168CC
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000186DB File Offset: 0x000168DB
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000186F4 File Offset: 0x000168F4
		private static Delegate GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (RequestFutureTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				RequestFutureTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestFutureTarget.n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return RequestFutureTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00018718 File Offset: 0x00016918
		private static void n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			RequestFutureTarget @object = Java.Lang.Object.GetObject<RequestFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0001873C File Offset: 0x0001693C
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe virtual void RemoveCallback(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				RequestFutureTarget._members.InstanceMethods.InvokeVirtualVoidMethod("removeCallback.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x040001E2 RID: 482
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/RequestFutureTarget", typeof(RequestFutureTarget));

		// Token: 0x040001E3 RID: 483
		private static Delegate cb_isCancelled;

		// Token: 0x040001E4 RID: 484
		private static Delegate cb_isDone;

		// Token: 0x040001E5 RID: 485
		private static Delegate cb_getRequest;

		// Token: 0x040001E6 RID: 486
		private static Delegate cb_setRequest_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001E7 RID: 487
		private static Delegate cb_cancel_Z;

		// Token: 0x040001E8 RID: 488
		private static Delegate cb_get;

		// Token: 0x040001E9 RID: 489
		private static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x040001EA RID: 490
		private static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x040001EB RID: 491
		private static Delegate cb_onDestroy;

		// Token: 0x040001EC RID: 492
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001ED RID: 493
		private static Delegate cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001EE RID: 494
		private static Delegate cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;

		// Token: 0x040001EF RID: 495
		private static Delegate cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001F0 RID: 496
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x040001F1 RID: 497
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z;

		// Token: 0x040001F2 RID: 498
		private static Delegate cb_onStart;

		// Token: 0x040001F3 RID: 499
		private static Delegate cb_onStop;

		// Token: 0x040001F4 RID: 500
		private static Delegate cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
	}
}
