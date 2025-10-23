using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Experimental
{
	// Token: 0x02000246 RID: 582
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/experimental/ExperimentalObjCRefinement", DoNotGenerateAcw = true)]
	internal class IExperimentalObjCRefinementInvoker : Java.Lang.Object, IExperimentalObjCRefinement, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000595D0 File Offset: 0x000577D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalObjCRefinementInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x000595F4 File Offset: 0x000577F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalObjCRefinementInvoker._members;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x000595FB File Offset: 0x000577FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00059603 File Offset: 0x00057803
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalObjCRefinementInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0005960F File Offset: 0x0005780F
		[NullableContext(2)]
		public static IExperimentalObjCRefinement GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalObjCRefinement>(handle, transfer);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00059618 File Offset: 0x00057818
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalObjCRefinementInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.experimental.ExperimentalObjCRefinement'.");
			}
			return handle;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00059643 File Offset: 0x00057843
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00059674 File Offset: 0x00057874
		public IExperimentalObjCRefinementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalObjCRefinementInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000596AC File Offset: 0x000578AC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalObjCRefinementInvoker.cb_annotationType == null)
			{
				IExperimentalObjCRefinementInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalObjCRefinementInvoker.n_AnnotationType));
			}
			return IExperimentalObjCRefinementInvoker.cb_annotationType;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000596D0 File Offset: 0x000578D0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalObjCRefinement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000596E4 File Offset: 0x000578E4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00059735 File Offset: 0x00057935
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalObjCRefinementInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalObjCRefinementInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalObjCRefinementInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalObjCRefinementInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0005975C File Offset: 0x0005795C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalObjCRefinement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00059780 File Offset: 0x00057980
		[NullableContext(2)]
		public new unsafe bool Equals(Java.Lang.Object obj)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000597F3 File Offset: 0x000579F3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalObjCRefinementInvoker.cb_hashCode == null)
			{
				IExperimentalObjCRefinementInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalObjCRefinementInvoker.n_GetHashCode));
			}
			return IExperimentalObjCRefinementInvoker.cb_hashCode;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00059817 File Offset: 0x00057A17
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalObjCRefinement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00059826 File Offset: 0x00057A26
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00059866 File Offset: 0x00057A66
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalObjCRefinementInvoker.cb_toString == null)
			{
				IExperimentalObjCRefinementInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalObjCRefinementInvoker.n_ToString));
			}
			return IExperimentalObjCRefinementInvoker.cb_toString;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0005988A File Offset: 0x00057A8A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalObjCRefinement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000598A0 File Offset: 0x00057AA0
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000817 RID: 2071
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/experimental/ExperimentalObjCRefinement", typeof(IExperimentalObjCRefinementInvoker));

		// Token: 0x04000818 RID: 2072
		private IntPtr class_ref;

		// Token: 0x04000819 RID: 2073
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400081A RID: 2074
		private IntPtr id_annotationType;

		// Token: 0x0400081B RID: 2075
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400081C RID: 2076
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400081D RID: 2077
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400081E RID: 2078
		private IntPtr id_hashCode;

		// Token: 0x0400081F RID: 2079
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000820 RID: 2080
		private IntPtr id_toString;
	}
}
