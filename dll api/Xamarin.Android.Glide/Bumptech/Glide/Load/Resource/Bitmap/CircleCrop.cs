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
	// Token: 0x02000108 RID: 264
	[Register("com/bumptech/glide/load/resource/bitmap/CircleCrop", DoNotGenerateAcw = true)]
	public class CircleCrop : BitmapTransformation
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00029AF4 File Offset: 0x00027CF4
		internal new static IntPtr class_ref
		{
			get
			{
				return CircleCrop._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00029B18 File Offset: 0x00027D18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CircleCrop._members;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00029B20 File Offset: 0x00027D20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CircleCrop._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00029B44 File Offset: 0x00027D44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CircleCrop._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00029B50 File Offset: 0x00027D50
		protected CircleCrop(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00029B5C File Offset: 0x00027D5C
		[Register(".ctor", "()V", "")]
		public CircleCrop() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CircleCrop._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CircleCrop._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00029BCA File Offset: 0x00027DCA
		private static Delegate GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler()
		{
			if (CircleCrop.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II == null)
			{
				CircleCrop.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(CircleCrop.n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II));
			}
			return CircleCrop.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00029BF0 File Offset: 0x00027DF0
		private static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II(IntPtr jnienv, IntPtr native__this, IntPtr native_pool, IntPtr native_toTransform, int outWidth, int outHeight)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<CircleCrop>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBitmapPool object2 = Java.Lang.Object.GetObject<IBitmapPool>(native_pool, JniHandleOwnership.DoNotTransfer);
			Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_toTransform, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00029C28 File Offset: 0x00027E28
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
				@object = Java.Lang.Object.GetObject<Bitmap>(CircleCrop._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(toTransform);
			}
			return @object;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00029CF8 File Offset: 0x00027EF8
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (CircleCrop.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				CircleCrop.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CircleCrop.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return CircleCrop.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00029D1C File Offset: 0x00027F1C
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<CircleCrop>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00029D40 File Offset: 0x00027F40
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				CircleCrop._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000326 RID: 806
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/CircleCrop", typeof(CircleCrop));

		// Token: 0x04000327 RID: 807
		private static Delegate cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;

		// Token: 0x04000328 RID: 808
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
