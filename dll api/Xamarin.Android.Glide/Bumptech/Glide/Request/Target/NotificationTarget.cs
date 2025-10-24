using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
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
	// Token: 0x020000AF RID: 175
	[Register("com/bumptech/glide/request/target/NotificationTarget", DoNotGenerateAcw = true)]
	public class NotificationTarget : CustomTarget
	{
		// Token: 0x06000904 RID: 2308 RVA: 0x0001C2DF File Offset: 0x0001A4DF
		public override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			this.OnResourceReady((Bitmap)resource, transition);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		internal new static IntPtr class_ref
		{
			get
			{
				return NotificationTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0001C314 File Offset: 0x0001A514
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationTarget._members;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0001C31C File Offset: 0x0001A51C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0001C340 File Offset: 0x0001A540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0001C34C File Offset: 0x0001A54C
		protected NotificationTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0001C358 File Offset: 0x0001A558
		[Register(".ctor", "(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/app/Notification;I)V", "")]
		public unsafe NotificationTarget(Context context, int viewId, RemoteViews remoteViews, Notification notification, int notificationId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(viewId);
				ptr[2] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[3] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				ptr[4] = new JniArgumentValue(notificationId);
				base.SetHandle(NotificationTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/app/Notification;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NotificationTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/app/Notification;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(notification);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0001C488 File Offset: 0x0001A688
		[Register(".ctor", "(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/app/Notification;ILjava/lang/String;)V", "")]
		public unsafe NotificationTarget(Context context, int viewId, RemoteViews remoteViews, Notification notification, int notificationId, string notificationTag) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(notificationTag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(viewId);
				ptr[2] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[3] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				ptr[4] = new JniArgumentValue(notificationId);
				ptr[5] = new JniArgumentValue(intPtr);
				base.SetHandle(NotificationTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/app/Notification;ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NotificationTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;ILandroid/widget/RemoteViews;Landroid/app/Notification;ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(notification);
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		[Register(".ctor", "(Landroid/content/Context;IIILandroid/widget/RemoteViews;Landroid/app/Notification;ILjava/lang/String;)V", "")]
		public unsafe NotificationTarget(Context context, int width, int height, int viewId, RemoteViews remoteViews, Notification notification, int notificationId, string notificationTag) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(notificationTag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue(viewId);
				ptr[4] = new JniArgumentValue((remoteViews == null) ? IntPtr.Zero : remoteViews.Handle);
				ptr[5] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				ptr[6] = new JniArgumentValue(notificationId);
				ptr[7] = new JniArgumentValue(intPtr);
				base.SetHandle(NotificationTarget._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;IIILandroid/widget/RemoteViews;Landroid/app/Notification;ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NotificationTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;IIILandroid/widget/RemoteViews;Landroid/app/Notification;ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(remoteViews);
				GC.KeepAlive(notification);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0001C76C File Offset: 0x0001A96C
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (NotificationTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				NotificationTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationTarget.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return NotificationTarget.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001C790 File Offset: 0x0001A990
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
		{
			CustomTarget @object = Java.Lang.Object.GetObject<NotificationTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_placeholder, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void OnLoadCleared(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				NotificationTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001C818 File Offset: 0x0001AA18
		private static Delegate GetOnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (NotificationTarget.cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				NotificationTarget.cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(NotificationTarget.n_OnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return NotificationTarget.cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0001C83C File Offset: 0x0001AA3C
		private static void n_OnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_transition)
		{
			NotificationTarget @object = Java.Lang.Object.GetObject<NotificationTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_resource, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001C868 File Offset: 0x0001AA68
		[Register("onResourceReady", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe virtual void OnResourceReady(Bitmap resource, ITransition transition)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : resource.Handle);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				NotificationTarget._members.InstanceMethods.InvokeVirtualVoidMethod("onResourceReady.(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x04000235 RID: 565
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/NotificationTarget", typeof(NotificationTarget));

		// Token: 0x04000236 RID: 566
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000237 RID: 567
		private static Delegate cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_transition_Transition_;
	}
}
