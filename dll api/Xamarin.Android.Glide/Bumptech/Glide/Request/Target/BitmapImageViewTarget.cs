using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000AB RID: 171
	[Register("com/bumptech/glide/request/target/BitmapImageViewTarget", DoNotGenerateAcw = true)]
	public class BitmapImageViewTarget : ImageViewTarget
	{
		// Token: 0x060008D4 RID: 2260 RVA: 0x0001B7F7 File Offset: 0x000199F7
		protected override void SetResource(Java.Lang.Object resource)
		{
			this.SetResource((Bitmap)resource);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0001B808 File Offset: 0x00019A08
		internal new static IntPtr class_ref
		{
			get
			{
				return BitmapImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0001B82C File Offset: 0x00019A2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapImageViewTarget._members;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0001B834 File Offset: 0x00019A34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0001B858 File Offset: 0x00019A58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapImageViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0001B864 File Offset: 0x00019A64
		protected BitmapImageViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0001B870 File Offset: 0x00019A70
		[Register(".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe BitmapImageViewTarget(ImageView view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(BitmapImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0001B920 File Offset: 0x00019B20
		[Register(".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe BitmapImageViewTarget(ImageView view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(BitmapImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		private static Delegate GetSetResource_Landroid_graphics_Bitmap_Handler()
		{
			if (BitmapImageViewTarget.cb_setResource_Landroid_graphics_Bitmap_ == null)
			{
				BitmapImageViewTarget.cb_setResource_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BitmapImageViewTarget.n_SetResource_Landroid_graphics_Bitmap_));
			}
			return BitmapImageViewTarget.cb_setResource_Landroid_graphics_Bitmap_;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0001BA04 File Offset: 0x00019C04
		private static void n_SetResource_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			BitmapImageViewTarget @object = Java.Lang.Object.GetObject<BitmapImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_resource, JniHandleOwnership.DoNotTransfer);
			@object.SetResource(object2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0001BA28 File Offset: 0x00019C28
		[Register("setResource", "(Landroid/graphics/Bitmap;)V", "GetSetResource_Landroid_graphics_Bitmap_Handler")]
		protected unsafe virtual void SetResource(Bitmap resource)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : resource.Handle);
				BitmapImageViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("setResource.(Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
		}

		// Token: 0x0400022D RID: 557
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/BitmapImageViewTarget", typeof(BitmapImageViewTarget));

		// Token: 0x0400022E RID: 558
		private static Delegate cb_setResource_Landroid_graphics_Bitmap_;
	}
}
