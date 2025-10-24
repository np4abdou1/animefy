using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000101 RID: 257
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapTransformation", DoNotGenerateAcw = true)]
	public abstract class BitmapTransformation : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0002866C File Offset: 0x0002686C
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00028690 File Offset: 0x00026890
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapTransformation._members;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00028698 File Offset: 0x00026898
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000286BC File Offset: 0x000268BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapTransformation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000286C8 File Offset: 0x000268C8
		protected BitmapTransformation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000286D4 File Offset: 0x000268D4
		[Register(".ctor", "()V", "")]
		public BitmapTransformation() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BitmapTransformation._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BitmapTransformation._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00028744 File Offset: 0x00026944
		[Register("transform", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Transform(Context context, IResource resource, int outWidth, int outHeight)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				ptr[2] = new JniArgumentValue(outWidth);
				ptr[3] = new JniArgumentValue(outHeight);
				@object = Java.Lang.Object.GetObject<IResource>(BitmapTransformation._members.InstanceMethods.InvokeNonvirtualObjectMethod("transform.(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00028814 File Offset: 0x00026A14
		private static Delegate GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler()
		{
			if (BitmapTransformation.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II == null)
			{
				BitmapTransformation.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(BitmapTransformation.n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II));
			}
			return BitmapTransformation.cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00028838 File Offset: 0x00026A38
		private static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<BitmapTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBitmapPool object2 = Java.Lang.Object.GetObject<IBitmapPool>(native_p0, JniHandleOwnership.DoNotTransfer);
			Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, p2, p3));
		}

		// Token: 0x06000CEB RID: 3307
		[Register("transform", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler")]
		protected abstract Bitmap Transform(IBitmapPool p0, Bitmap p1, int p2, int p3);

		// Token: 0x06000CEC RID: 3308 RVA: 0x0002886D File Offset: 0x00026A6D
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (BitmapTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				BitmapTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BitmapTransformation.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return BitmapTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00028894 File Offset: 0x00026A94
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BitmapTransformation @object = Java.Lang.Object.GetObject<BitmapTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000CEE RID: 3310
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public abstract void UpdateDiskCacheKey(MessageDigest p0);

		// Token: 0x06000CEF RID: 3311 RVA: 0x000288B7 File Offset: 0x00026AB7
		IResource ITransformation.Transform(Context p0, IResource p1, int p2, int p3)
		{
			return this.Transform(p0, p1.JavaCast<IResource>(), p2, p3).JavaCast<IResource>();
		}

		// Token: 0x04000317 RID: 791
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapTransformation", typeof(BitmapTransformation));

		// Token: 0x04000318 RID: 792
		private static Delegate cb_transform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_II;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
