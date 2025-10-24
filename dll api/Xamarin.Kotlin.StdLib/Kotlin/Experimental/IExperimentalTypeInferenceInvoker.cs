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
	// Token: 0x02000248 RID: 584
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/experimental/ExperimentalTypeInference", DoNotGenerateAcw = true)]
	internal class IExperimentalTypeInferenceInvoker : Java.Lang.Object, IExperimentalTypeInference, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0005990C File Offset: 0x00057B0C
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalTypeInferenceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00059930 File Offset: 0x00057B30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalTypeInferenceInvoker._members;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00059937 File Offset: 0x00057B37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0005993F File Offset: 0x00057B3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalTypeInferenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0005994B File Offset: 0x00057B4B
		[NullableContext(2)]
		public static IExperimentalTypeInference GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalTypeInference>(handle, transfer);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00059954 File Offset: 0x00057B54
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalTypeInferenceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.experimental.ExperimentalTypeInference'.");
			}
			return handle;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0005997F File Offset: 0x00057B7F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000599B0 File Offset: 0x00057BB0
		public IExperimentalTypeInferenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalTypeInferenceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000599E8 File Offset: 0x00057BE8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalTypeInferenceInvoker.cb_annotationType == null)
			{
				IExperimentalTypeInferenceInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalTypeInferenceInvoker.n_AnnotationType));
			}
			return IExperimentalTypeInferenceInvoker.cb_annotationType;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00059A0C File Offset: 0x00057C0C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalTypeInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00059A20 File Offset: 0x00057C20
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00059A71 File Offset: 0x00057C71
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalTypeInferenceInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalTypeInferenceInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalTypeInferenceInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalTypeInferenceInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00059A98 File Offset: 0x00057C98
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalTypeInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00059ABC File Offset: 0x00057CBC
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

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00059B2F File Offset: 0x00057D2F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalTypeInferenceInvoker.cb_hashCode == null)
			{
				IExperimentalTypeInferenceInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalTypeInferenceInvoker.n_GetHashCode));
			}
			return IExperimentalTypeInferenceInvoker.cb_hashCode;
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00059B53 File Offset: 0x00057D53
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalTypeInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00059B62 File Offset: 0x00057D62
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00059BA2 File Offset: 0x00057DA2
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalTypeInferenceInvoker.cb_toString == null)
			{
				IExperimentalTypeInferenceInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalTypeInferenceInvoker.n_ToString));
			}
			return IExperimentalTypeInferenceInvoker.cb_toString;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00059BC6 File Offset: 0x00057DC6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalTypeInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00059BDC File Offset: 0x00057DDC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000821 RID: 2081
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/experimental/ExperimentalTypeInference", typeof(IExperimentalTypeInferenceInvoker));

		// Token: 0x04000822 RID: 2082
		private IntPtr class_ref;

		// Token: 0x04000823 RID: 2083
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000824 RID: 2084
		private IntPtr id_annotationType;

		// Token: 0x04000825 RID: 2085
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000826 RID: 2086
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000827 RID: 2087
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000828 RID: 2088
		private IntPtr id_hashCode;

		// Token: 0x04000829 RID: 2089
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400082A RID: 2090
		private IntPtr id_toString;
	}
}
