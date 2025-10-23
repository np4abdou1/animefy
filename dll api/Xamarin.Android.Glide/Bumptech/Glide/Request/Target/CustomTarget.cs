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
	// Token: 0x020000B2 RID: 178
	[Register("com/bumptech/glide/request/target/CustomTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class CustomTarget : Java.Lang.Object, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0001D084 File Offset: 0x0001B284
		internal static IntPtr class_ref
		{
			get
			{
				return CustomTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CustomTarget._members;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CustomTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0001D0D4 File Offset: 0x0001B2D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CustomTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		protected CustomTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0001D0EC File Offset: 0x0001B2EC
		[Register(".ctor", "()V", "")]
		public CustomTarget() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CustomTarget._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CustomTarget._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001D15C File Offset: 0x0001B35C
		[Register(".ctor", "(II)V", "")]
		public unsafe CustomTarget(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			base.SetHandle(CustomTarget._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			CustomTarget._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x0001D228 File Offset: 0x0001B428
		public unsafe IRequest Request
		{
			[Register("getRequest", "()Lcom/bumptech/glide/request/Request;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IRequest>(CustomTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("getRequest.()Lcom/bumptech/glide/request/Request;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequest", "(Lcom/bumptech/glide/request/Request;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					CustomTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("setRequest.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001D290 File Offset: 0x0001B490
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "")]
		public unsafe void GetSize(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				CustomTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("getSize.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		private static Delegate GetOnDestroyHandler()
		{
			if (CustomTarget.cb_onDestroy == null)
			{
				CustomTarget.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomTarget.n_OnDestroy));
			}
			return CustomTarget.cb_onDestroy;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0001D31C File Offset: 0x0001B51C
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0001D32B File Offset: 0x0001B52B
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			CustomTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0001D344 File Offset: 0x0001B544
		private static Delegate GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CustomTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ == null)
			{
				CustomTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CustomTarget.n_OnLoadFailed_Landroid_graphics_drawable_Drawable_));
			}
			return CustomTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001D368 File Offset: 0x0001B568
		private static void n_OnLoadFailed_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorDrawable)
		{
			CustomTarget @object = Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_errorDrawable, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0001D38C File Offset: 0x0001B58C
		[Register("onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadFailed(Drawable errorDrawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorDrawable == null) ? IntPtr.Zero : errorDrawable.Handle);
				CustomTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadFailed.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorDrawable);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		private static Delegate GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CustomTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ == null)
			{
				CustomTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CustomTarget.n_OnLoadStarted_Landroid_graphics_drawable_Drawable_));
			}
			return CustomTarget.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001D414 File Offset: 0x0001B614
		private static void n_OnLoadStarted_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			CustomTarget @object = Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadStarted(object2);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0001D438 File Offset: 0x0001B638
		[Register("onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnLoadStarted(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				CustomTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadStarted.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0001D49C File Offset: 0x0001B69C
		private static Delegate GetOnStartHandler()
		{
			if (CustomTarget.cb_onStart == null)
			{
				CustomTarget.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomTarget.n_OnStart));
			}
			return CustomTarget.cb_onStart;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001D4CF File Offset: 0x0001B6CF
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			CustomTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001D4E8 File Offset: 0x0001B6E8
		private static Delegate GetOnStopHandler()
		{
			if (CustomTarget.cb_onStop == null)
			{
				CustomTarget.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomTarget.n_OnStop));
			}
			return CustomTarget.cb_onStop;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0001D50C File Offset: 0x0001B70C
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001D51B File Offset: 0x0001B71B
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			CustomTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001D534 File Offset: 0x0001B734
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "")]
		public unsafe void RemoveCallback(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				CustomTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeCallback.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0001D59C File Offset: 0x0001B79C
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (CustomTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				CustomTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(CustomTarget.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return CustomTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			CustomTarget @object = Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x0600095F RID: 2399
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public abstract void OnResourceReady(Java.Lang.Object resource, ITransition transition);

		// Token: 0x06000960 RID: 2400 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CustomTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				CustomTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CustomTarget.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return CustomTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0001D610 File Offset: 0x0001B810
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			CustomTarget @object = Java.Lang.Object.GetObject<CustomTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x06000962 RID: 2402
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void OnLoadCleared(Drawable p0);

		// Token: 0x04000245 RID: 581
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/CustomTarget", typeof(CustomTarget));

		// Token: 0x04000246 RID: 582
		private static Delegate cb_onDestroy;

		// Token: 0x04000247 RID: 583
		private static Delegate cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000248 RID: 584
		private static Delegate cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000249 RID: 585
		private static Delegate cb_onStart;

		// Token: 0x0400024A RID: 586
		private static Delegate cb_onStop;

		// Token: 0x0400024B RID: 587
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x0400024C RID: 588
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x020001C2 RID: 450
		public static class InterfaceConsts
		{
			// Token: 0x04000536 RID: 1334
			[Register("SIZE_ORIGINAL")]
			public const int SizeOriginal = -2147483648;
		}
	}
}
