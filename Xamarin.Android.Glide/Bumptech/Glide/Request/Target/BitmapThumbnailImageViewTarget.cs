using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000AC RID: 172
	[Register("com/bumptech/glide/request/target/BitmapThumbnailImageViewTarget", DoNotGenerateAcw = true)]
	public class BitmapThumbnailImageViewTarget : ThumbnailImageViewTarget
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x0001BAA7 File Offset: 0x00019CA7
		protected override Drawable GetDrawable(Java.Lang.Object resource)
		{
			return this.GetDrawable((Bitmap)resource);
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		internal new static IntPtr class_ref
		{
			get
			{
				return BitmapThumbnailImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0001BADC File Offset: 0x00019CDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapThumbnailImageViewTarget._members;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0001BAE4 File Offset: 0x00019CE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapThumbnailImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0001BB08 File Offset: 0x00019D08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapThumbnailImageViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001BB14 File Offset: 0x00019D14
		protected BitmapThumbnailImageViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001BB20 File Offset: 0x00019D20
		[Register(".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe BitmapThumbnailImageViewTarget(ImageView view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(BitmapThumbnailImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapThumbnailImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Register(".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe BitmapThumbnailImageViewTarget(ImageView view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(BitmapThumbnailImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapThumbnailImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0001BC90 File Offset: 0x00019E90
		private static Delegate GetGetDrawable_Landroid_graphics_Bitmap_Handler()
		{
			if (BitmapThumbnailImageViewTarget.cb_getDrawable_Landroid_graphics_Bitmap_ == null)
			{
				BitmapThumbnailImageViewTarget.cb_getDrawable_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BitmapThumbnailImageViewTarget.n_GetDrawable_Landroid_graphics_Bitmap_));
			}
			return BitmapThumbnailImageViewTarget.cb_getDrawable_Landroid_graphics_Bitmap_;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0001BCB4 File Offset: 0x00019EB4
		private static IntPtr n_GetDrawable_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			BitmapThumbnailImageViewTarget @object = Java.Lang.Object.GetObject<BitmapThumbnailImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDrawable(object2));
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001BCDC File Offset: 0x00019EDC
		[Register("getDrawable", "(Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Landroid_graphics_Bitmap_Handler")]
		protected unsafe virtual Drawable GetDrawable(Bitmap resource)
		{
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : resource.Handle);
				@object = Java.Lang.Object.GetObject<Drawable>(BitmapThumbnailImageViewTarget._members.InstanceMethods.InvokeVirtualObjectMethod("getDrawable.(Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Drawable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x0400022F RID: 559
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/BitmapThumbnailImageViewTarget", typeof(BitmapThumbnailImageViewTarget));

		// Token: 0x04000230 RID: 560
		private static Delegate cb_getDrawable_Landroid_graphics_Bitmap_;
	}
}
