using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000DD RID: 221
	[Register("com/bumptech/glide/load/MultiTransformation", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class MultiTransformation : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000227C8 File Offset: 0x000209C8
		internal static IntPtr class_ref
		{
			get
			{
				return MultiTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x000227EC File Offset: 0x000209EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MultiTransformation._members;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000227F4 File Offset: 0x000209F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MultiTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00022818 File Offset: 0x00020A18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MultiTransformation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00022824 File Offset: 0x00020A24
		protected MultiTransformation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00022830 File Offset: 0x00020A30
		[Register(".ctor", "([Lcom/bumptech/glide/load/Transformation;)V", "")]
		public unsafe MultiTransformation(params ITransformation[] transformations) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<ITransformation>(transformations);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(MultiTransformation._members.InstanceMethods.StartCreateInstance("([Lcom/bumptech/glide/load/Transformation;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MultiTransformation._members.InstanceMethods.FinishCreateInstance("([Lcom/bumptech/glide/load/Transformation;)V", this, ptr);
			}
			finally
			{
				if (transformations != null)
				{
					JNIEnv.CopyArray<ITransformation>(intPtr, transformations);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(transformations);
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000228E4 File Offset: 0x00020AE4
		[Register(".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe MultiTransformation(ICollection transformationList) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(transformationList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(MultiTransformation._members.InstanceMethods.StartCreateInstance("(Ljava/util/Collection;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MultiTransformation._members.InstanceMethods.FinishCreateInstance("(Ljava/util/Collection;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(transformationList);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00022990 File Offset: 0x00020B90
		private static Delegate GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler()
		{
			if (MultiTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II == null)
			{
				MultiTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(MultiTransformation.n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II));
			}
			return MultiTransformation.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x000229B4 File Offset: 0x00020BB4
		private static IntPtr n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_resource, int outWidth, int outHeight)
		{
			MultiTransformation @object = Java.Lang.Object.GetObject<MultiTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, outWidth, outHeight));
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000229EC File Offset: 0x00020BEC
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
				@object = Java.Lang.Object.GetObject<IResource>(MultiTransformation._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00022ABC File Offset: 0x00020CBC
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (MultiTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				MultiTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MultiTransformation.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return MultiTransformation.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00022AE0 File Offset: 0x00020CE0
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			MultiTransformation @object = Java.Lang.Object.GetObject<MultiTransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00022B04 File Offset: 0x00020D04
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe virtual void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				MultiTransformation._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/MultiTransformation", typeof(MultiTransformation));

		// Token: 0x040002C6 RID: 710
		private static Delegate cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;

		// Token: 0x040002C7 RID: 711
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
