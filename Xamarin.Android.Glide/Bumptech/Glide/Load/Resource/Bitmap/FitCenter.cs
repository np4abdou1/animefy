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
	// Token: 0x0200010F RID: 271
	[Register("com/bumptech/glide/load/resource/bitmap/FitCenter", DoNotGenerateAcw = true)]
	public class FitCenter : BitmapTransformation
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0002B2D0 File Offset: 0x000294D0
		internal new static IntPtr class_ref
		{
			get
			{
				return FitCenter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0002B2F4 File Offset: 0x000294F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FitCenter._members;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0002B2FC File Offset: 0x000294FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FitCenter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0002B320 File Offset: 0x00029520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FitCenter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002B32C File Offset: 0x0002952C
		protected FitCenter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0002B338 File Offset: 0x00029538
		[Register(".ctor", "()V", "")]
		public FitCenter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FitCenter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FitCenter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0002B3A6 File Offset: 0x000295A6
		private static Delegate GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler()
		{
			if (FitCenter.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II == null)
			{
				FitCenter.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(FitCenter.n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II));
			}
			return FitCenter.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002B3CC File Offset: 0x000295CC
		private static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II(IntPtr jnienv, IntPtr native__this, IntPtr native_pool, IntPtr native_toTransform, int outWidth, int outHeight)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<FitCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBitmapPool object2 = Java.Lang.Object.GetObject<IBitmapPool>(native_pool, JniHandleOwnership.DoNotTransfer);
			Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_toTransform, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0002B404 File Offset: 0x00029604
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
				@object = Java.Lang.Object.GetObject<Bitmap>(FitCenter._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(toTransform);
			}
			return @object;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0002B4D4 File Offset: 0x000296D4
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (FitCenter.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				FitCenter.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FitCenter.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return FitCenter.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0002B4F8 File Offset: 0x000296F8
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<FitCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002B51C File Offset: 0x0002971C
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				FitCenter._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000334 RID: 820
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/FitCenter", typeof(FitCenter));

		// Token: 0x04000335 RID: 821
		private static Delegate cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;

		// Token: 0x04000336 RID: 822
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
