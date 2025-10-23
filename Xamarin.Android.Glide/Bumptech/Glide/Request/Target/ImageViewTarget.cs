using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B7 RID: 183
	[Register("com/bumptech/glide/request/target/ImageViewTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Z"
	})]
	public abstract class ImageViewTarget : ViewTarget, ITransitionViewAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0001E338 File Offset: 0x0001C538
		internal new static IntPtr class_ref
		{
			get
			{
				return ImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0001E35C File Offset: 0x0001C55C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageViewTarget._members;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0001E364 File Offset: 0x0001C564
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0001E388 File Offset: 0x0001C588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0001E394 File Offset: 0x0001C594
		protected ImageViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
		[Register(".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe ImageViewTarget(ImageView view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(ImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0001E450 File Offset: 0x0001C650
		[Register(".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe ImageViewTarget(ImageView view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(waitForLayout);
				base.SetHandle(ImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0001E510 File Offset: 0x0001C710
		private static Delegate GetGetCurrentDrawableHandler()
		{
			if (ImageViewTarget.cb_getCurrentDrawable == null)
			{
				ImageViewTarget.cb_getCurrentDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ImageViewTarget.n_GetCurrentDrawable));
			}
			return ImageViewTarget.cb_getCurrentDrawable;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001E534 File Offset: 0x0001C734
		private static IntPtr n_GetCurrentDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentDrawable);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0001E548 File Offset: 0x0001C748
		public virtual Drawable CurrentDrawable
		{
			[Register("getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetCurrentDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(ImageViewTarget._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0001E57A File Offset: 0x0001C77A
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (ImageViewTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				ImageViewTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ImageViewTarget.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return ImageViewTarget.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<ImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0001E5CC File Offset: 0x0001C7CC
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				ImageViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0001E65C File Offset: 0x0001C85C
		private static Delegate GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ImageViewTarget.cb_setDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				ImageViewTarget.cb_setDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ImageViewTarget.n_SetDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return ImageViewTarget.cb_setDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0001E680 File Offset: 0x0001C880
		private static void n_SetDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			ImageViewTarget @object = Java.Lang.Object.GetObject<ImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawable(object2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		[Register("setDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetDrawable(Drawable drawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				ImageViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0001E708 File Offset: 0x0001C908
		private static Delegate GetSetResource_Ljava_lang_Object_Handler()
		{
			if (ImageViewTarget.cb_setResource_Ljava_lang_Object_ == null)
			{
				ImageViewTarget.cb_setResource_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ImageViewTarget.n_SetResource_Ljava_lang_Object_));
			}
			return ImageViewTarget.cb_setResource_Ljava_lang_Object_;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0001E72C File Offset: 0x0001C92C
		private static void n_SetResource_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ImageViewTarget @object = Java.Lang.Object.GetObject<ImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetResource(object2);
		}

		// Token: 0x060009BC RID: 2492
		[Register("setResource", "(Ljava/lang/Object;)V", "GetSetResource_Ljava_lang_Object_Handler")]
		protected abstract void SetResource(Java.Lang.Object p0);

		// Token: 0x0400025C RID: 604
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ImageViewTarget", typeof(ImageViewTarget));

		// Token: 0x0400025D RID: 605
		private static Delegate cb_getCurrentDrawable;

		// Token: 0x0400025E RID: 606
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x0400025F RID: 607
		private static Delegate cb_setDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000260 RID: 608
		private static Delegate cb_setResource_Ljava_lang_Object_;
	}
}
