using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000106 RID: 262
	[Register("com/bumptech/glide/load/resource/bitmap/CenterCrop", DoNotGenerateAcw = true)]
	public class CenterCrop : BitmapTransformation
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0002955C File Offset: 0x0002775C
		internal new static IntPtr class_ref
		{
			get
			{
				return CenterCrop._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00029580 File Offset: 0x00027780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CenterCrop._members;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00029588 File Offset: 0x00027788
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CenterCrop._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000295AC File Offset: 0x000277AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CenterCrop._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x000295B8 File Offset: 0x000277B8
		protected CenterCrop(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000295C4 File Offset: 0x000277C4
		[Register(".ctor", "()V", "")]
		public CenterCrop() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CenterCrop._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CenterCrop._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00029632 File Offset: 0x00027832
		private static Delegate GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler()
		{
			if (CenterCrop.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II == null)
			{
				CenterCrop.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(CenterCrop.n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II));
			}
			return CenterCrop.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00029658 File Offset: 0x00027858
		private static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II(IntPtr jnienv, IntPtr native__this, IntPtr native_pool, IntPtr native_toTransform, int outWidth, int outHeight)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<CenterCrop>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBitmapPool object2 = Java.Lang.Object.GetObject<IBitmapPool>(native_pool, JniHandleOwnership.DoNotTransfer);
			Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_toTransform, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00029690 File Offset: 0x00027890
		[Register("transform", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler")]
		protected unsafe override Bitmap Transform(IBitmapPool pool, Bitmap toTransform, int outWidth, int outHeight)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((toTransform == null) ? IntPtr.Zero : toTransform.Handle);
				ptr[2] = new JniArgumentValue(outWidth);
				ptr[3] = new JniArgumentValue(outHeight);
				@object = Java.Lang.Object.GetObject<Bitmap>(CenterCrop._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(toTransform);
			}
			return @object;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00029760 File Offset: 0x00027960
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (CenterCrop.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				CenterCrop.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CenterCrop.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return CenterCrop.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00029784 File Offset: 0x00027984
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<CenterCrop>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000297A8 File Offset: 0x000279A8
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				CenterCrop._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000320 RID: 800
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/CenterCrop", typeof(CenterCrop));

		// Token: 0x04000321 RID: 801
		private static Delegate cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;

		// Token: 0x04000322 RID: 802
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
