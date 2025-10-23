using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x02000122 RID: 290
	[Register("com/bumptech/glide/load/resource/gif/GifDrawableTransformation", DoNotGenerateAcw = true)]
	public class GifDrawableTransformation : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0002F90C File Offset: 0x0002DB0C
		internal static IntPtr class_ref
		{
			get
			{
				return GifDrawableTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0002F930 File Offset: 0x0002DB30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifDrawableTransformation._members;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0002F938 File Offset: 0x0002DB38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifDrawableTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0002F95C File Offset: 0x0002DB5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifDrawableTransformation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0002F968 File Offset: 0x0002DB68
		protected GifDrawableTransformation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0002F974 File Offset: 0x0002DB74
		[Register(".ctor", "(Lcom/bumptech/glide/load/Transformation;)V", "")]
		public unsafe GifDrawableTransformation(ITransformation wrapped) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wrapped == null) ? IntPtr.Zero : ((Java.Lang.Object)wrapped).Handle);
				base.SetHandle(GifDrawableTransformation._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/Transformation;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifDrawableTransformation._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/Transformation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(wrapped);
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0002FA28 File Offset: 0x0002DC28
		private static Delegate GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler()
		{
			if (GifDrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II == null)
			{
				GifDrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(GifDrawableTransformation.n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II));
			}
			return GifDrawableTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		private static IntPtr n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_resource, int outWidth, int outHeight)
		{
			GifDrawableTransformation @object = Java.Lang.Object.GetObject<GifDrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0002FA84 File Offset: 0x0002DC84
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
				@object = Java.Lang.Object.GetObject<IResource>(GifDrawableTransformation._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0002FB54 File Offset: 0x0002DD54
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (GifDrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				GifDrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GifDrawableTransformation.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return GifDrawableTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0002FB78 File Offset: 0x0002DD78
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			GifDrawableTransformation @object = Java.Lang.Object.GetObject<GifDrawableTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0002FB9C File Offset: 0x0002DD9C
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe virtual void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				GifDrawableTransformation._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002FC00 File Offset: 0x0002DE00
		IResource ITransformation.Transform(Context p0, IResource p1, int p2, int p3)
		{
			return this.Transform(p0, p1.JavaCast<IResource>(), p2, p3).JavaCast<IResource>();
		}

		// Token: 0x04000372 RID: 882
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifDrawableTransformation", typeof(GifDrawableTransformation));

		// Token: 0x04000373 RID: 883
		private static Delegate cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;

		// Token: 0x04000374 RID: 884
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
