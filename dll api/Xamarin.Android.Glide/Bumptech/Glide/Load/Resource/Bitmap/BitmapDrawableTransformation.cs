using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x020000FE RID: 254
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapDrawableTransformation", DoNotGenerateAcw = true)]
	public class BitmapDrawableTransformation : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00027D04 File Offset: 0x00025F04
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapDrawableTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00027D28 File Offset: 0x00025F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapDrawableTransformation._members;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00027D30 File Offset: 0x00025F30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapDrawableTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00027D54 File Offset: 0x00025F54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapDrawableTransformation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00027D60 File Offset: 0x00025F60
		protected BitmapDrawableTransformation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00027D6C File Offset: 0x00025F6C
		[Register(".ctor", "(Lcom/bumptech/glide/load/Transformation;)V", "")]
		public unsafe BitmapDrawableTransformation(ITransformation wrapped) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wrapped == null) ? IntPtr.Zero : ((Java.Lang.Object)wrapped).Handle);
				base.SetHandle(BitmapDrawableTransformation._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/Transformation;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableTransformation._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/Transformation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(wrapped);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00027E20 File Offset: 0x00026020
		private static Delegate GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler()
		{
			if (BitmapDrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II == null)
			{
				BitmapDrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(BitmapDrawableTransformation.n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II));
			}
			return BitmapDrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00027E44 File Offset: 0x00026044
		private static IntPtr n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_drawableResourceToTransform, int outWidth, int outHeight)
		{
			BitmapDrawableTransformation @object = Java.Lang.Object.GetObject<BitmapDrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_drawableResourceToTransform, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00027E7C File Offset: 0x0002607C
		[Register("transform", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler")]
		public unsafe virtual IResource Transform(Context context, IResource drawableResourceToTransform, int outWidth, int outHeight)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((drawableResourceToTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)drawableResourceToTransform).Handle);
				ptr[2] = new JniArgumentValue(outWidth);
				ptr[3] = new JniArgumentValue(outHeight);
				@object = Java.Lang.Object.GetObject<IResource>(BitmapDrawableTransformation._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(drawableResourceToTransform);
			}
			return @object;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00027F4C File Offset: 0x0002614C
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (BitmapDrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				BitmapDrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BitmapDrawableTransformation.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return BitmapDrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00027F70 File Offset: 0x00026170
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			BitmapDrawableTransformation @object = Java.Lang.Object.GetObject<BitmapDrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00027F94 File Offset: 0x00026194
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe virtual void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				BitmapDrawableTransformation._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00027FF8 File Offset: 0x000261F8
		IResource ITransformation.Transform(Context p0, IResource p1, int p2, int p3)
		{
			return this.Transform(p0, p1.JavaCast<IResource>(), p2, p3).JavaCast<IResource>();
		}

		// Token: 0x0400030D RID: 781
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapDrawableTransformation", typeof(BitmapDrawableTransformation));

		// Token: 0x0400030E RID: 782
		private static Delegate cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;

		// Token: 0x0400030F RID: 783
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
