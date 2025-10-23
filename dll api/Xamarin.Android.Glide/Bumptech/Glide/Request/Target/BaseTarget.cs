using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B0 RID: 176
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/request/target/BaseTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Z"
	})]
	public abstract class BaseTarget : Java.Lang.Object, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0001C914 File Offset: 0x0001AB14
		internal static IntPtr class_ref
		{
			get
			{
				return BaseTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0001C938 File Offset: 0x0001AB38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseTarget._members;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0001C940 File Offset: 0x0001AB40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0001C964 File Offset: 0x0001AB64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001C970 File Offset: 0x0001AB70
		protected BaseTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001C97C File Offset: 0x0001AB7C
		[Register(".ctor", "()V", "")]
		public BaseTarget() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BaseTarget._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BaseTarget._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001C9EA File Offset: 0x0001ABEA
		private static Delegate GetGetRequestHandler()
		{
			if (BaseTarget.cb_getRequest == null)
			{
				BaseTarget.cb_getRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseTarget.n_GetRequest));
			}
			return BaseTarget.cb_getRequest;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001CA0E File Offset: 0x0001AC0E
		private static IntPtr n_GetRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Request);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0001CA22 File Offset: 0x0001AC22
		private static Delegate GetSetRequest_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (BaseTarget.cb_setRequest_Lcom_bumptech_glide_request_Request_ == null)
			{
				BaseTarget.cb_setRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTarget.n_SetRequest_Lcom_bumptech_glide_request_Request_));
			}
			return BaseTarget.cb_setRequest_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001CA48 File Offset: 0x0001AC48
		private static void n_SetRequest_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			@object.Request = object2;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0001CA6C File Offset: 0x0001AC6C
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		public unsafe virtual IRequest Request
		{
			[Register("getRequest", "()Lcom/bumptech/glide/request/Request;", "GetGetRequestHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IRequest>(BaseTarget._members.InstanceMethods.InvokeVirtualObjectMethod("getRequest.()Lcom/bumptech/glide/request/Request;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetSetRequest_Lcom_bumptech_glide_request_Request_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("setRequest.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0001CB08 File Offset: 0x0001AD08
		private static Delegate GetOnDestroyHandler()
		{
			if (BaseTarget.cb_onDestroy == null)
			{
				BaseTarget.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTarget.n_OnDestroy));
			}
			return BaseTarget.cb_onDestroy;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001CB2C File Offset: 0x0001AD2C
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0001CB3B File Offset: 0x0001AD3B
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0001CB54 File Offset: 0x0001AD54
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (BaseTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				BaseTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTarget.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return BaseTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0001CB78 File Offset: 0x0001AD78
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadCleared(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0001CC00 File Offset: 0x0001AE00
		private static Delegate GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (BaseTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ == null)
			{
				BaseTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTarget.n_OnLoadFailed_Landroid_graphics_drawable_Drawable_));
			}
			return BaseTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001CC24 File Offset: 0x0001AE24
		private static void n_OnLoadFailed_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorDrawable)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_errorDrawable, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0001CC48 File Offset: 0x0001AE48
		[Register("onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadFailed(Drawable errorDrawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorDrawable == null) ? IntPtr.Zero : errorDrawable.Handle);
				BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadFailed.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorDrawable);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0001CCAC File Offset: 0x0001AEAC
		private static Delegate GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (BaseTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ == null)
			{
				BaseTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTarget.n_OnLoadStarted_Landroid_graphics_drawable_Drawable_));
			}
			return BaseTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		private static void n_OnLoadStarted_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadStarted(object2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		[Register("onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadStarted(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadStarted.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001CD58 File Offset: 0x0001AF58
		private static Delegate GetOnStartHandler()
		{
			if (BaseTarget.cb_onStart == null)
			{
				BaseTarget.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTarget.n_OnStart));
			}
			return BaseTarget.cb_onStart;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001CD7C File Offset: 0x0001AF7C
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001CD8B File Offset: 0x0001AF8B
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001CDA4 File Offset: 0x0001AFA4
		private static Delegate GetOnStopHandler()
		{
			if (BaseTarget.cb_onStop == null)
			{
				BaseTarget.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTarget.n_OnStop));
			}
			return BaseTarget.cb_onStop;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0001CDD7 File Offset: 0x0001AFD7
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			BaseTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001CDF0 File Offset: 0x0001AFF0
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (BaseTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				BaseTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BaseTarget.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return BaseTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001CE14 File Offset: 0x0001B014
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x06000934 RID: 2356
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public abstract void OnResourceReady(Java.Lang.Object resource, ITransition transition);

		// Token: 0x06000935 RID: 2357 RVA: 0x0001CE40 File Offset: 0x0001B040
		private static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (BaseTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				BaseTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTarget.n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return BaseTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001CE64 File Offset: 0x0001B064
		private static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.GetSize(object2);
		}

		// Token: 0x06000937 RID: 2359
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public abstract void GetSize(ISizeReadyCallback p0);

		// Token: 0x06000938 RID: 2360 RVA: 0x0001CE87 File Offset: 0x0001B087
		private static Delegate GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (BaseTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				BaseTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTarget.n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return BaseTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		private static void n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<BaseTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x0600093A RID: 2362
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public abstract void RemoveCallback(ISizeReadyCallback p0);

		// Token: 0x04000238 RID: 568
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/BaseTarget", typeof(BaseTarget));

		// Token: 0x04000239 RID: 569
		private static Delegate cb_getRequest;

		// Token: 0x0400023A RID: 570
		private static Delegate cb_setRequest_Lcom_bumptech_glide_request_Request_;

		// Token: 0x0400023B RID: 571
		private static Delegate cb_onDestroy;

		// Token: 0x0400023C RID: 572
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400023D RID: 573
		private static Delegate cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400023E RID: 574
		private static Delegate cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400023F RID: 575
		private static Delegate cb_onStart;

		// Token: 0x04000240 RID: 576
		private static Delegate cb_onStop;

		// Token: 0x04000241 RID: 577
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x04000242 RID: 578
		private static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000243 RID: 579
		private static Delegate cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x020001C1 RID: 449
		public static class InterfaceConsts
		{
			// Token: 0x04000535 RID: 1333
			[Register("SIZE_ORIGINAL")]
			public const int SizeOriginal = -2147483648;
		}
	}
}
