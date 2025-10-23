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
	// Token: 0x020000B4 RID: 180
	[Register("com/bumptech/glide/request/target/CustomViewTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends android.view.View",
		"Z"
	})]
	public abstract class CustomViewTarget : Java.Lang.Object, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0001D77C File Offset: 0x0001B97C
		internal static IntPtr class_ref
		{
			get
			{
				return CustomViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CustomViewTarget._members;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CustomViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0001D7CC File Offset: 0x0001B9CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CustomViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		protected CustomViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0001D7E4 File Offset: 0x0001B9E4
		[Register(".ctor", "(Landroid/view/View;)V", "")]
		public unsafe CustomViewTarget(Java.Lang.Object view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(view);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(CustomViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CustomViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0001D890 File Offset: 0x0001BA90
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
		public unsafe IRequest Request
		{
			[Register("getRequest", "()Lcom/bumptech/glide/request/Request;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IRequest>(CustomViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("getRequest.()Lcom/bumptech/glide/request/Request;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequest", "(Lcom/bumptech/glide/request/Request;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					CustomViewTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("setRequest.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0001D92C File Offset: 0x0001BB2C
		public Java.Lang.Object View
		{
			[Register("getView", "()Landroid/view/View;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(CustomViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0001D960 File Offset: 0x0001BB60
		[Register("clearOnDetach", "()Lcom/bumptech/glide/request/target/CustomViewTarget;", "")]
		public CustomViewTarget ClearOnDetach()
		{
			return Java.Lang.Object.GetObject<CustomViewTarget>(CustomViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("clearOnDetach.()Lcom/bumptech/glide/request/target/CustomViewTarget;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0001D994 File Offset: 0x0001BB94
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "")]
		public unsafe void GetSize(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				CustomViewTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("getSize.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		private static Delegate GetOnDestroyHandler()
		{
			if (CustomViewTarget.cb_onDestroy == null)
			{
				CustomViewTarget.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomViewTarget.n_OnDestroy));
			}
			return CustomViewTarget.cb_onDestroy;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0001DA20 File Offset: 0x0001BC20
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0001DA2F File Offset: 0x0001BC2F
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			CustomViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0001DA48 File Offset: 0x0001BC48
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe void OnLoadCleared(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				CustomViewTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0001DAAC File Offset: 0x0001BCAC
		[Register("onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe void OnLoadStarted(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				CustomViewTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("onLoadStarted.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0001DB10 File Offset: 0x0001BD10
		private static Delegate GetOnResourceCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CustomViewTarget.cb_onResourceCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				CustomViewTarget.cb_onResourceCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CustomViewTarget.n_OnResourceCleared_Landroid_graphics_drawable_Drawable_));
			}
			return CustomViewTarget.cb_onResourceCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001DB34 File Offset: 0x0001BD34
		private static void n_OnResourceCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			CustomViewTarget @object = Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceCleared(object2);
		}

		// Token: 0x0600097C RID: 2428
		[Register("onResourceCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnResourceCleared_Landroid_graphics_drawable_Drawable_Handler")]
		protected abstract void OnResourceCleared(Drawable p0);

		// Token: 0x0600097D RID: 2429 RVA: 0x0001DB57 File Offset: 0x0001BD57
		private static Delegate GetOnResourceLoading_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CustomViewTarget.cb_onResourceLoading_Landroid_graphics_drawable_Drawable_ == null)
			{
				CustomViewTarget.cb_onResourceLoading_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CustomViewTarget.n_OnResourceLoading_Landroid_graphics_drawable_Drawable_));
			}
			return CustomViewTarget.cb_onResourceLoading_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0001DB7C File Offset: 0x0001BD7C
		private static void n_OnResourceLoading_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			CustomViewTarget @object = Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceLoading(object2);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0001DBA0 File Offset: 0x0001BDA0
		[Register("onResourceLoading", "(Landroid/graphics/drawable/Drawable;)V", "GetOnResourceLoading_Landroid_graphics_drawable_Drawable_Handler")]
		protected unsafe virtual void OnResourceLoading(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				CustomViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onResourceLoading.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0001DC04 File Offset: 0x0001BE04
		private static Delegate GetOnStartHandler()
		{
			if (CustomViewTarget.cb_onStart == null)
			{
				CustomViewTarget.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomViewTarget.n_OnStart));
			}
			return CustomViewTarget.cb_onStart;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001DC28 File Offset: 0x0001BE28
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0001DC37 File Offset: 0x0001BE37
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			CustomViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0001DC50 File Offset: 0x0001BE50
		private static Delegate GetOnStopHandler()
		{
			if (CustomViewTarget.cb_onStop == null)
			{
				CustomViewTarget.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomViewTarget.n_OnStop));
			}
			return CustomViewTarget.cb_onStop;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0001DC74 File Offset: 0x0001BE74
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001DC83 File Offset: 0x0001BE83
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			CustomViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "")]
		public unsafe void RemoveCallback(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				CustomViewTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeCallback.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0001DD04 File Offset: 0x0001BF04
		[Obsolete("deprecated")]
		[Register("useTagId", "(I)Lcom/bumptech/glide/request/target/CustomViewTarget;", "")]
		public unsafe CustomViewTarget UseTagId(int tagId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tagId);
			return Java.Lang.Object.GetObject<CustomViewTarget>(CustomViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("useTagId.(I)Lcom/bumptech/glide/request/target/CustomViewTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0001DD50 File Offset: 0x0001BF50
		[Register("waitForLayout", "()Lcom/bumptech/glide/request/target/CustomViewTarget;", "")]
		public CustomViewTarget WaitForLayout()
		{
			return Java.Lang.Object.GetObject<CustomViewTarget>(CustomViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("waitForLayout.()Lcom/bumptech/glide/request/target/CustomViewTarget;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0001DD82 File Offset: 0x0001BF82
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (CustomViewTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				CustomViewTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(CustomViewTarget.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return CustomViewTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			CustomViewTarget @object = Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x0600098B RID: 2443
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public abstract void OnResourceReady(Java.Lang.Object resource, ITransition transition);

		// Token: 0x0600098C RID: 2444 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		private static Delegate GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CustomViewTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ == null)
			{
				CustomViewTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CustomViewTarget.n_OnLoadFailed_Landroid_graphics_drawable_Drawable_));
			}
			return CustomViewTarget.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
		private static void n_OnLoadFailed_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			CustomViewTarget @object = Java.Lang.Object.GetObject<CustomViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x0600098E RID: 2446
		[Register("onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void OnLoadFailed(Drawable p0);

		// Token: 0x0400024E RID: 590
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/CustomViewTarget", typeof(CustomViewTarget));

		// Token: 0x0400024F RID: 591
		private static Delegate cb_onDestroy;

		// Token: 0x04000250 RID: 592
		private static Delegate cb_onResourceCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000251 RID: 593
		private static Delegate cb_onResourceLoading_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000252 RID: 594
		private static Delegate cb_onStart;

		// Token: 0x04000253 RID: 595
		private static Delegate cb_onStop;

		// Token: 0x04000254 RID: 596
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x04000255 RID: 597
		private static Delegate cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x020001C3 RID: 451
		public static class InterfaceConsts
		{
			// Token: 0x04000537 RID: 1335
			[Register("SIZE_ORIGINAL")]
			public const int SizeOriginal = -2147483648;
		}
	}
}
