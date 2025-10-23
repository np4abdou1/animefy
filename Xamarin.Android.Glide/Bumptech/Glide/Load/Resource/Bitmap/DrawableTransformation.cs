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
	// Token: 0x0200010D RID: 269
	[Register("com/bumptech/glide/load/resource/bitmap/DrawableTransformation", DoNotGenerateAcw = true)]
	public class DrawableTransformation : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0002AC28 File Offset: 0x00028E28
		internal static IntPtr class_ref
		{
			get
			{
				return DrawableTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0002AC4C File Offset: 0x00028E4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableTransformation._members;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0002AC54 File Offset: 0x00028E54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0002AC78 File Offset: 0x00028E78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableTransformation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002AC84 File Offset: 0x00028E84
		protected DrawableTransformation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0002AC90 File Offset: 0x00028E90
		[Register(".ctor", "(Lcom/bumptech/glide/load/Transformation;Z)V", "")]
		public unsafe DrawableTransformation(ITransformation wrapped, bool isRequired) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wrapped == null) ? IntPtr.Zero : ((Java.Lang.Object)wrapped).Handle);
				ptr[1] = new JniArgumentValue(isRequired);
				base.SetHandle(DrawableTransformation._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/Transformation;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableTransformation._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/Transformation;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(wrapped);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002AD58 File Offset: 0x00028F58
		private static Delegate GetAsBitmapDrawableHandler()
		{
			if (DrawableTransformation.cb_asBitmapDrawable == null)
			{
				DrawableTransformation.cb_asBitmapDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DrawableTransformation.n_AsBitmapDrawable));
			}
			return DrawableTransformation.cb_asBitmapDrawable;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0002AD7C File Offset: 0x00028F7C
		private static IntPtr n_AsBitmapDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsBitmapDrawable());
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0002AD90 File Offset: 0x00028F90
		[Register("asBitmapDrawable", "()Lcom/bumptech/glide/load/Transformation;", "GetAsBitmapDrawableHandler")]
		public virtual ITransformation AsBitmapDrawable()
		{
			return Java.Lang.Object.GetObject<ITransformation>(DrawableTransformation._members.InstanceMethods.InvokeVirtualObjectMethod("asBitmapDrawable.()Lcom/bumptech/glide/load/Transformation;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002ADC2 File Offset: 0x00028FC2
		private static Delegate GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler()
		{
			if (DrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II == null)
			{
				DrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(DrawableTransformation.n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II));
			}
			return DrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0002ADE8 File Offset: 0x00028FE8
		private static IntPtr n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_resource, int outWidth, int outHeight)
		{
			DrawableTransformation @object = Java.Lang.Object.GetObject<DrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002AE20 File Offset: 0x00029020
		[Register("transform", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler")]
		public unsafe virtual IResource Transform(Context context, IResource resource, int outWidth, int outHeight)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				ptr[2] = new JniArgumentValue(outWidth);
				ptr[3] = new JniArgumentValue(outHeight);
				@object = Java.Lang.Object.GetObject<IResource>(DrawableTransformation._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0002AEF0 File Offset: 0x000290F0
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (DrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				DrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawableTransformation.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return DrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0002AF14 File Offset: 0x00029114
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			DrawableTransformation @object = Java.Lang.Object.GetObject<DrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0002AF38 File Offset: 0x00029138
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe virtual void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				DrawableTransformation._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0002AF9C File Offset: 0x0002919C
		IResource ITransformation.Transform(Context p0, IResource p1, int p2, int p3)
		{
			return this.Transform(p0, p1.JavaCast<IResource>(), p2, p3).JavaCast<IResource>();
		}

		// Token: 0x0400032F RID: 815
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/DrawableTransformation", typeof(DrawableTransformation));

		// Token: 0x04000330 RID: 816
		private static Delegate cb_asBitmapDrawable;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;

		// Token: 0x04000332 RID: 818
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
