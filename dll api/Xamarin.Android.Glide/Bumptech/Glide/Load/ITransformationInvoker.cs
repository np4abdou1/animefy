using System;
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
	// Token: 0x020000DC RID: 220
	[Register("com/bumptech/glide/load/Transformation", DoNotGenerateAcw = true)]
	internal class ITransformationInvoker : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x000223B8 File Offset: 0x000205B8
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransformationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000223DC File Offset: 0x000205DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransformationInvoker._members;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x000223E3 File Offset: 0x000205E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000223EB File Offset: 0x000205EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransformationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000223F7 File Offset: 0x000205F7
		public static ITransformation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransformation>(handle, transfer);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00022400 File Offset: 0x00020600
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransformationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.Transformation'.");
			}
			return handle;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0002242B File Offset: 0x0002062B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0002245C File Offset: 0x0002065C
		public ITransformationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransformationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00022494 File Offset: 0x00020694
		private static Delegate GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler()
		{
			if (ITransformationInvoker.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II == null)
			{
				ITransformationInvoker.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(ITransformationInvoker.n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II));
			}
			return ITransformationInvoker.cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000224B8 File Offset: 0x000206B8
		private static IntPtr n_Transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			ITransformation @object = Java.Lang.Object.GetObject<ITransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform(object2, object3, p2, p3));
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000224F0 File Offset: 0x000206F0
		public unsafe IResource Transform(Context p0, IResource p1, int p2, int p3)
		{
			if (this.id_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II == IntPtr.Zero)
			{
				this.id_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II = JNIEnv.GetMethodID(this.class_ref, "transform", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue(p3);
			return Java.Lang.Object.GetObject<IResource>(JNIEnv.CallObjectMethod(base.Handle, this.id_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000225BD File Offset: 0x000207BD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ITransformationInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ITransformationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ITransformationInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ITransformationInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000225E4 File Offset: 0x000207E4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IKey @object = Java.Lang.Object.GetObject<ITransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00022608 File Offset: 0x00020808
		public new unsafe bool Equals(Java.Lang.Object p0)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002267B File Offset: 0x0002087B
		private static Delegate GetGetHashCodeHandler()
		{
			if (ITransformationInvoker.cb_hashCode == null)
			{
				ITransformationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ITransformationInvoker.n_GetHashCode));
			}
			return ITransformationInvoker.cb_hashCode;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002269F File Offset: 0x0002089F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000226AE File Offset: 0x000208AE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000226EE File Offset: 0x000208EE
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (ITransformationInvoker.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				ITransformationInvoker.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITransformationInvoker.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return ITransformationInvoker.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00022714 File Offset: 0x00020914
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IKey @object = Java.Lang.Object.GetObject<ITransformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00022738 File Offset: 0x00020938
		public unsafe void UpdateDiskCacheKey(MessageDigest p0)
		{
			if (this.id_updateDiskCacheKey_Ljava_security_MessageDigest_ == IntPtr.Zero)
			{
				this.id_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID(this.class_ref, "updateDiskCacheKey", "(Ljava/security/MessageDigest;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_updateDiskCacheKey_Ljava_security_MessageDigest_, ptr);
		}

		// Token: 0x040002BB RID: 699
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Transformation", typeof(ITransformationInvoker));

		// Token: 0x040002BC RID: 700
		private IntPtr class_ref;

		// Token: 0x040002BD RID: 701
		private static Delegate cb_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;

		// Token: 0x040002BE RID: 702
		private IntPtr id_transform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_II;

		// Token: 0x040002BF RID: 703
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040002C0 RID: 704
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040002C1 RID: 705
		private static Delegate cb_hashCode;

		// Token: 0x040002C2 RID: 706
		private IntPtr id_hashCode;

		// Token: 0x040002C3 RID: 707
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;

		// Token: 0x040002C4 RID: 708
		private IntPtr id_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
