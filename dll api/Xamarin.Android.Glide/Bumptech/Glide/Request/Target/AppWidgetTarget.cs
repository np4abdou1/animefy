using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000AA RID: 170
	[Register("com/bumptech/glide/request/target/AppWidgetTarget", DoNotGenerateAcw = true)]
	public class AppWidgetTarget : CustomTarget
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x0001B0F7 File Offset: 0x000192F7
		public override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			this.OnResourceReady((Bitmap)resource, transition);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0001B108 File Offset: 0x00019308
		internal new static IntPtr class_ref
		{
			get
			{
				return AppWidgetTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0001B12C File Offset: 0x0001932C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppWidgetTarget._members;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0001B134 File Offset: 0x00019334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppWidgetTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0001B158 File Offset: 0x00019358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppWidgetTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0001B164 File Offset: 0x00019364
		protected AppWidgetTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0001B170 File Offset: 0x00019370
		[Register(".ctor", "(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/content/ComponentName;)V", "")]
		public unsafe AppWidgetTarget(Context context, int viewId, RemoteViews remoteViews, ComponentName componentName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(viewId);
				ptr[2] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[3] = new JniArgumentValue((componentName == null) ? IntPtr.Zero : componentName.Handle);
				base.SetHandle(AppWidgetTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/content/ComponentName;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppWidgetTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/content/ComponentName;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(componentName);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0001B28C File Offset: 0x0001948C
		[Register(".ctor", "(Landroid/content/Context;ILandroid/widget/RemoteViews;[I)V", "")]
		public unsafe AppWidgetTarget(Context context, int viewId, RemoteViews remoteViews, params int[] widgetIds) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray(widgetIds);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(viewId);
				ptr[2] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				base.SetHandle(AppWidgetTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;[I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppWidgetTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;[I)V", this, ptr);
			}
			finally
			{
				if (widgetIds != null)
				{
					JNIEnv.CopyArray(intPtr, widgetIds);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(widgetIds);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0001B3B0 File Offset: 0x000195B0
		[Register(".ctor", "(Landroid/content/Context;IIILandroid/widget/RemoteViews;Landroid/content/ComponentName;)V", "")]
		public unsafe AppWidgetTarget(Context context, int width, int height, int viewId, RemoteViews remoteViews, ComponentName componentName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue(viewId);
				ptr[4] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[5] = new JniArgumentValue((componentName == null) ? IntPtr.Zero : componentName.Handle);
				base.SetHandle(AppWidgetTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;IIILandroid/widget/RemoteViews;Landroid/content/ComponentName;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppWidgetTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;IIILandroid/widget/RemoteViews;Landroid/content/ComponentName;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(componentName);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001B4FC File Offset: 0x000196FC
		[Register(".ctor", "(Landroid/content/Context;IIILandroid/widget/RemoteViews;[I)V", "")]
		public unsafe AppWidgetTarget(Context context, int width, int height, int viewId, RemoteViews remoteViews, params int[] widgetIds) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray(widgetIds);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue(viewId);
				ptr[4] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[5] = new JniArgumentValue(intPtr);
				base.SetHandle(AppWidgetTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;IIILandroid/widget/RemoteViews;[I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppWidgetTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;IIILandroid/widget/RemoteViews;[I)V", this, ptr);
			}
			finally
			{
				if (widgetIds != null)
				{
					JNIEnv.CopyArray(intPtr, widgetIds);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(widgetIds);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0001B650 File Offset: 0x00019850
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (AppWidgetTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				AppWidgetTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppWidgetTarget.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return AppWidgetTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0001B674 File Offset: 0x00019874
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			CustomTarget @object = Java.Lang.Object.GetObject<AppWidgetTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001B698 File Offset: 0x00019898
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void OnLoadCleared(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				AppWidgetTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001B6FC File Offset: 0x000198FC
		private static Delegate GetOnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (AppWidgetTarget.cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				AppWidgetTarget.cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppWidgetTarget.n_OnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return AppWidgetTarget.cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001B720 File Offset: 0x00019920
		private static void n_OnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			AppWidgetTarget @object = Java.Lang.Object.GetObject<AppWidgetTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001B74C File Offset: 0x0001994C
		[Register("onResourceReady", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe virtual void OnResourceReady(Bitmap resource, ITransition transition)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : resource.Handle);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				AppWidgetTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onResourceReady.(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x0400022A RID: 554
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/AppWidgetTarget", typeof(AppWidgetTarget));

		// Token: 0x0400022B RID: 555
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400022C RID: 556
		private static Delegate cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_;
	}
}
