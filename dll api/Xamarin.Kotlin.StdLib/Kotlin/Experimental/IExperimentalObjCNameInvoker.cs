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
	// Token: 0x02000244 RID: 580
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/experimental/ExperimentalObjCName", DoNotGenerateAcw = true)]
	internal class IExperimentalObjCNameInvoker : Java.Lang.Object, IExperimentalObjCName, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00059294 File Offset: 0x00057494
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalObjCNameInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x000592B8 File Offset: 0x000574B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalObjCNameInvoker._members;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x000592BF File Offset: 0x000574BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x000592C7 File Offset: 0x000574C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalObjCNameInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000592D3 File Offset: 0x000574D3
		[NullableContext(2)]
		public static IExperimentalObjCName GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalObjCName>(handle, transfer);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000592DC File Offset: 0x000574DC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalObjCNameInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.experimental.ExperimentalObjCName'.");
			}
			return handle;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00059307 File Offset: 0x00057507
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00059338 File Offset: 0x00057538
		public IExperimentalObjCNameInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalObjCNameInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00059370 File Offset: 0x00057570
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalObjCNameInvoker.cb_annotationType == null)
			{
				IExperimentalObjCNameInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalObjCNameInvoker.n_AnnotationType));
			}
			return IExperimentalObjCNameInvoker.cb_annotationType;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00059394 File Offset: 0x00057594
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalObjCName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000593A8 File Offset: 0x000575A8
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000593F9 File Offset: 0x000575F9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalObjCNameInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalObjCNameInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalObjCNameInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalObjCNameInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00059420 File Offset: 0x00057620
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalObjCName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00059444 File Offset: 0x00057644
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

		// Token: 0x06001A96 RID: 6806 RVA: 0x000594B7 File Offset: 0x000576B7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalObjCNameInvoker.cb_hashCode == null)
			{
				IExperimentalObjCNameInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalObjCNameInvoker.n_GetHashCode));
			}
			return IExperimentalObjCNameInvoker.cb_hashCode;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000594DB File Offset: 0x000576DB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalObjCName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x000594EA File Offset: 0x000576EA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0005952A File Offset: 0x0005772A
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalObjCNameInvoker.cb_toString == null)
			{
				IExperimentalObjCNameInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalObjCNameInvoker.n_ToString));
			}
			return IExperimentalObjCNameInvoker.cb_toString;
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0005954E File Offset: 0x0005774E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalObjCName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00059564 File Offset: 0x00057764
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400080D RID: 2061
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/experimental/ExperimentalObjCName", typeof(IExperimentalObjCNameInvoker));

		// Token: 0x0400080E RID: 2062
		private IntPtr class_ref;

		// Token: 0x0400080F RID: 2063
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000810 RID: 2064
		private IntPtr id_annotationType;

		// Token: 0x04000811 RID: 2065
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000812 RID: 2066
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000813 RID: 2067
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000814 RID: 2068
		private IntPtr id_hashCode;

		// Token: 0x04000815 RID: 2069
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000816 RID: 2070
		private IntPtr id_toString;
	}
}
