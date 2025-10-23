using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000AD RID: 173
	[Register("com/bumptech/glide/request/target/DrawableImageViewTarget", DoNotGenerateAcw = true)]
	public class DrawableImageViewTarget : ImageViewTarget
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x0001BD6B File Offset: 0x00019F6B
		protected override void SetResource(Java.Lang.Object resource)
		{
			this.SetResource((Drawable)resource);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0001BD7C File Offset: 0x00019F7C
		internal new static IntPtr class_ref
		{
			get
			{
				return DrawableImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableImageViewTarget._members;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0001BDA8 File Offset: 0x00019FA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0001BDCC File Offset: 0x00019FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableImageViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		protected DrawableImageViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0001BDE4 File Offset: 0x00019FE4
		[Register(".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe DrawableImageViewTarget(ImageView view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(DrawableImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0001BE94 File Offset: 0x0001A094
		[Register(".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe DrawableImageViewTarget(ImageView view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(DrawableImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001BF54 File Offset: 0x0001A154
		private static Delegate GetSetResource_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (DrawableImageViewTarget.cb_setResource_Landroid_graphics_drawable_Drawable_ == null)
			{
				DrawableImageViewTarget.cb_setResource_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawableImageViewTarget.n_SetResource_Landroid_graphics_drawable_Drawable_));
			}
			return DrawableImageViewTarget.cb_setResource_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0001BF78 File Offset: 0x0001A178
		private static void n_SetResource_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			DrawableImageViewTarget @object = Java.Lang.Object.GetObject<DrawableImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_resource, JniHandleOwnership.DoNotTransfer);
			@object.SetResource(object2);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0001BF9C File Offset: 0x0001A19C
		[Register("setResource", "(Landroid/graphics/drawable/Drawable;)V", "GetSetResource_Landroid_graphics_drawable_Drawable_Handler")]
		protected unsafe virtual void SetResource(Drawable resource)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : resource.Handle);
				DrawableImageViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("setResource.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
		}

		// Token: 0x04000231 RID: 561
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/DrawableImageViewTarget", typeof(DrawableImageViewTarget));

		// Token: 0x04000232 RID: 562
		private static Delegate cb_setResource_Landroid_graphics_drawable_Drawable_;
	}
}
