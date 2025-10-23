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
	// Token: 0x02000107 RID: 263
	[Register("com/bumptech/glide/load/resource/bitmap/CenterInside", DoNotGenerateAcw = true)]
	public class CenterInside : BitmapTransformation
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00029828 File Offset: 0x00027A28
		internal new static IntPtr class_ref
		{
			get
			{
				return CenterInside._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0002984C File Offset: 0x00027A4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CenterInside._members;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00029854 File Offset: 0x00027A54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CenterInside._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00029878 File Offset: 0x00027A78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CenterInside._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00029884 File Offset: 0x00027A84
		protected CenterInside(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00029890 File Offset: 0x00027A90
		[Register(".ctor", "()V", "")]
		public CenterInside() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CenterInside._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CenterInside._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000298FE File Offset: 0x00027AFE
		private static Delegate GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler()
		{
			if (CenterInside.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II == null)
			{
				CenterInside.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(CenterInside.n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II));
			}
			return CenterInside.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00029924 File Offset: 0x00027B24
		private static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II(IntPtr jnienv, IntPtr native__this, IntPtr native_pool, IntPtr native_toTransform, int outWidth, int outHeight)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<CenterInside>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBitmapPool object2 = Java.Lang.Object.GetObject<IBitmapPool>(native_pool, JniHandleOwnership.DoNotTransfer);
			Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_toTransform, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0002995C File Offset: 0x00027B5C
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
				@object = Java.Lang.Object.GetObject<Bitmap>(CenterInside._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(toTransform);
			}
			return @object;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00029A2C File Offset: 0x00027C2C
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (CenterInside.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				CenterInside.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CenterInside.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return CenterInside.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00029A50 File Offset: 0x00027C50
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<CenterInside>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00029A74 File Offset: 0x00027C74
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				CenterInside._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000323 RID: 803
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/CenterInside", typeof(CenterInside));

		// Token: 0x04000324 RID: 804
		private static Delegate cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;

		// Token: 0x04000325 RID: 805
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
