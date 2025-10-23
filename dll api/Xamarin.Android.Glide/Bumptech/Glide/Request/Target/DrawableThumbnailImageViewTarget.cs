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
	// Token: 0x020000AE RID: 174
	[Register("com/bumptech/glide/request/target/DrawableThumbnailImageViewTarget", DoNotGenerateAcw = true)]
	public class DrawableThumbnailImageViewTarget : ThumbnailImageViewTarget
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x0001C01B File Offset: 0x0001A21B
		protected override Drawable GetDrawable(Java.Lang.Object resource)
		{
			return this.GetDrawable((Drawable)resource);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0001C02C File Offset: 0x0001A22C
		internal new static IntPtr class_ref
		{
			get
			{
				return DrawableThumbnailImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001C050 File Offset: 0x0001A250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableThumbnailImageViewTarget._members;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0001C058 File Offset: 0x0001A258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableThumbnailImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0001C07C File Offset: 0x0001A27C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableThumbnailImageViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001C088 File Offset: 0x0001A288
		protected DrawableThumbnailImageViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001C094 File Offset: 0x0001A294
		[Register(".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe DrawableThumbnailImageViewTarget(ImageView view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(DrawableThumbnailImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableThumbnailImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0001C144 File Offset: 0x0001A344
		[Register(".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe DrawableThumbnailImageViewTarget(ImageView view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(DrawableThumbnailImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableThumbnailImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001C204 File Offset: 0x0001A404
		private static Delegate GetGetDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (DrawableThumbnailImageViewTarget.cb_getDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				DrawableThumbnailImageViewTarget.cb_getDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DrawableThumbnailImageViewTarget.n_GetDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return DrawableThumbnailImageViewTarget.cb_getDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001C228 File Offset: 0x0001A428
		private static IntPtr n_GetDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			DrawableThumbnailImageViewTarget @object = Java.Lang.Object.GetObject<DrawableThumbnailImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDrawable(object2));
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001C250 File Offset: 0x0001A450
		[Register("getDrawable", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		protected unsafe virtual Drawable GetDrawable(Drawable resource)
		{
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : resource.Handle);
				@object = Java.Lang.Object.GetObject<Drawable>(DrawableThumbnailImageViewTarget._members.InstanceMethods.InvokeVirtualObjectMethod("getDrawable.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x04000233 RID: 563
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/DrawableThumbnailImageViewTarget", typeof(DrawableThumbnailImageViewTarget));

		// Token: 0x04000234 RID: 564
		private static Delegate cb_getDrawable_Landroid_graphics_drawable_Drawable_;
	}
}
