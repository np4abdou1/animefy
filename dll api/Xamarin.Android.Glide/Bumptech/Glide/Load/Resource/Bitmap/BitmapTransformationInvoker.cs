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
	// Token: 0x02000102 RID: 258
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapTransformation", DoNotGenerateAcw = true)]
	internal class BitmapTransformationInvoker : BitmapTransformation, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000CF1 RID: 3313 RVA: 0x000288E9 File Offset: 0x00026AE9
		public BitmapTransformationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000288F3 File Offset: 0x00026AF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapTransformationInvoker._members;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000288FA File Offset: 0x00026AFA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapTransformationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00028908 File Offset: 0x00026B08
		[Register("transform", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler")]
		protected unsafe override Bitmap Transform(IBitmapPool p0, Bitmap p1, int p2, int p3)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(p2);
				ptr[3] = new JniArgumentValue(p3);
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapTransformationInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000289D8 File Offset: 0x00026BD8
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				BitmapTransformationInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400031A RID: 794
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapTransformation", typeof(BitmapTransformationInvoker));
	}
}
