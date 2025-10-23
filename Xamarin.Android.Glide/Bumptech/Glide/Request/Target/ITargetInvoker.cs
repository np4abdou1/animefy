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
	// Token: 0x020000BF RID: 191
	[Register("com/bumptech/glide/request/target/Target", DoNotGenerateAcw = true)]
	internal class ITargetInvoker : Java.Lang.Object, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
		private static IntPtr java_class_ref
		{
			get
			{
				return ITargetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0001EBCC File Offset: 0x0001CDCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITargetInvoker._members;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0001EBD3 File Offset: 0x0001CDD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0001EBDB File Offset: 0x0001CDDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0001EBE7 File Offset: 0x0001CDE7
		public static ITarget GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITarget>(handle, transfer);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITargetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.target.Target'.");
			}
			return handle;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001EC1B File Offset: 0x0001CE1B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		public ITargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITargetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0001EC84 File Offset: 0x0001CE84
		private static Delegate GetGetRequestHandler()
		{
			if (ITargetInvoker.cb_getRequest == null)
			{
				ITargetInvoker.cb_getRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITargetInvoker.n_GetRequest));
			}
			return ITargetInvoker.cb_getRequest;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		private static IntPtr n_GetRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Request);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0001ECBC File Offset: 0x0001CEBC
		private static Delegate GetSetRequest_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (ITargetInvoker.cb_setRequest_Lcom_bumptech_glide_request_Request_ == null)
			{
				ITargetInvoker.cb_setRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITargetInvoker.n_SetRequest_Lcom_bumptech_glide_request_Request_));
			}
			return ITargetInvoker.cb_setRequest_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
		private static void n_SetRequest_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Request = object2;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0001ED04 File Offset: 0x0001CF04
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0001ED58 File Offset: 0x0001CF58
		public unsafe IRequest Request
		{
			get
			{
				if (this.id_getRequest == IntPtr.Zero)
				{
					this.id_getRequest = JNIEnv.GetMethodID(this.class_ref, "getRequest", "()Lcom/bumptech/glide/request/Request;");
				}
				return Java.Lang.Object.GetObject<IRequest>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRequest), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setRequest_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				{
					this.id_setRequest_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "setRequest", "(Lcom/bumptech/glide/request/Request;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setRequest_Lcom_bumptech_glide_request_Request_, ptr);
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001EDD0 File Offset: 0x0001CFD0
		private static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (ITargetInvoker.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				ITargetInvoker.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITargetInvoker.n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return ITargetInvoker.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001EDF4 File Offset: 0x0001CFF4
		private static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.GetSize(object2);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001EE18 File Offset: 0x0001D018
		public unsafe void GetSize(ISizeReadyCallback p0)
		{
			if (this.id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
			{
				this.id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID(this.class_ref, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_, ptr);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0001EE90 File Offset: 0x0001D090
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ITargetInvoker.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				ITargetInvoker.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITargetInvoker.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return ITargetInvoker.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0001EED8 File Offset: 0x0001D0D8
		public unsafe void OnLoadCleared(Drawable p0)
		{
			if (this.id_onLoadCleared_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadCleared_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0001EF4B File Offset: 0x0001D14B
		private static Delegate GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ITargetInvoker.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ == null)
			{
				ITargetInvoker.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITargetInvoker.n_OnLoadFailed_Landroid_graphics_drawable_Drawable_));
			}
			return ITargetInvoker.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001EF70 File Offset: 0x0001D170
		private static void n_OnLoadFailed_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001EF94 File Offset: 0x0001D194
		public unsafe void OnLoadFailed(Drawable p0)
		{
			if (this.id_onLoadFailed_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadFailed_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001F007 File Offset: 0x0001D207
		private static Delegate GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ITargetInvoker.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ == null)
			{
				ITargetInvoker.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITargetInvoker.n_OnLoadStarted_Landroid_graphics_drawable_Drawable_));
			}
			return ITargetInvoker.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0001F02C File Offset: 0x0001D22C
		private static void n_OnLoadStarted_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadStarted(object2);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0001F050 File Offset: 0x0001D250
		public unsafe void OnLoadStarted(Drawable p0)
		{
			if (this.id_onLoadStarted_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadStarted_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0001F0C3 File Offset: 0x0001D2C3
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (ITargetInvoker.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				ITargetInvoker.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ITargetInvoker.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return ITargetInvoker.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001F114 File Offset: 0x0001D314
		public unsafe void OnResourceReady(Java.Lang.Object p0, ITransition p1)
		{
			if (this.id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == IntPtr.Zero)
			{
				this.id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNIEnv.GetMethodID(this.class_ref, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		private static Delegate GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (ITargetInvoker.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				ITargetInvoker.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITargetInvoker.n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return ITargetInvoker.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		private static void n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		public unsafe void RemoveCallback(ISizeReadyCallback p0)
		{
			if (this.id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
			{
				this.id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID(this.class_ref, "removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_, ptr);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0001F26C File Offset: 0x0001D46C
		private static Delegate GetOnDestroyHandler()
		{
			if (ITargetInvoker.cb_onDestroy == null)
			{
				ITargetInvoker.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ITargetInvoker.n_OnDestroy));
			}
			return ITargetInvoker.cb_onDestroy;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0001F290 File Offset: 0x0001D490
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001F29F File Offset: 0x0001D49F
		public void OnDestroy()
		{
			if (this.id_onDestroy == IntPtr.Zero)
			{
				this.id_onDestroy = JNIEnv.GetMethodID(this.class_ref, "onDestroy", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroy);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001F2DF File Offset: 0x0001D4DF
		private static Delegate GetOnStartHandler()
		{
			if (ITargetInvoker.cb_onStart == null)
			{
				ITargetInvoker.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ITargetInvoker.n_OnStart));
			}
			return ITargetInvoker.cb_onStart;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0001F303 File Offset: 0x0001D503
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0001F312 File Offset: 0x0001D512
		public void OnStart()
		{
			if (this.id_onStart == IntPtr.Zero)
			{
				this.id_onStart = JNIEnv.GetMethodID(this.class_ref, "onStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStart);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0001F352 File Offset: 0x0001D552
		private static Delegate GetOnStopHandler()
		{
			if (ITargetInvoker.cb_onStop == null)
			{
				ITargetInvoker.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ITargetInvoker.n_OnStop));
			}
			return ITargetInvoker.cb_onStop;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0001F376 File Offset: 0x0001D576
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0001F385 File Offset: 0x0001D585
		public void OnStop()
		{
			if (this.id_onStop == IntPtr.Zero)
			{
				this.id_onStop = JNIEnv.GetMethodID(this.class_ref, "onStop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStop);
		}

		// Token: 0x04000269 RID: 617
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/Target", typeof(ITargetInvoker));

		// Token: 0x0400026A RID: 618
		private IntPtr class_ref;

		// Token: 0x0400026B RID: 619
		private static Delegate cb_getRequest;

		// Token: 0x0400026C RID: 620
		private static Delegate cb_setRequest_Lcom_bumptech_glide_request_Request_;

		// Token: 0x0400026D RID: 621
		private IntPtr id_getRequest;

		// Token: 0x0400026E RID: 622
		private IntPtr id_setRequest_Lcom_bumptech_glide_request_Request_;

		// Token: 0x0400026F RID: 623
		private static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000270 RID: 624
		private IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000271 RID: 625
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000272 RID: 626
		private IntPtr id_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000273 RID: 627
		private static Delegate cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000274 RID: 628
		private IntPtr id_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000275 RID: 629
		private static Delegate cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000276 RID: 630
		private IntPtr id_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000277 RID: 631
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x04000278 RID: 632
		private IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x04000279 RID: 633
		private static Delegate cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x0400027A RID: 634
		private IntPtr id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x0400027B RID: 635
		private static Delegate cb_onDestroy;

		// Token: 0x0400027C RID: 636
		private IntPtr id_onDestroy;

		// Token: 0x0400027D RID: 637
		private static Delegate cb_onStart;

		// Token: 0x0400027E RID: 638
		private IntPtr id_onStart;

		// Token: 0x0400027F RID: 639
		private static Delegate cb_onStop;

		// Token: 0x04000280 RID: 640
		private IntPtr id_onStop;
	}
}
