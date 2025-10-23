using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000062 RID: 98
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ExperimentalStdlibApi", DoNotGenerateAcw = true)]
	internal class IExperimentalStdlibApiInvoker : Java.Lang.Object, IExperimentalStdlibApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00004A8C File Offset: 0x00002C8C
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalStdlibApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00004AB0 File Offset: 0x00002CB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalStdlibApiInvoker._members;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00004AB7 File Offset: 0x00002CB7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00004ABF File Offset: 0x00002CBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalStdlibApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00004ACB File Offset: 0x00002CCB
		[NullableContext(2)]
		public static IExperimentalStdlibApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalStdlibApi>(handle, transfer);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00004AD4 File Offset: 0x00002CD4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalStdlibApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ExperimentalStdlibApi'.");
			}
			return handle;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00004AFF File Offset: 0x00002CFF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00004B30 File Offset: 0x00002D30
		public IExperimentalStdlibApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalStdlibApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00004B68 File Offset: 0x00002D68
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalStdlibApiInvoker.cb_annotationType == null)
			{
				IExperimentalStdlibApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalStdlibApiInvoker.n_AnnotationType));
			}
			return IExperimentalStdlibApiInvoker.cb_annotationType;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00004B8C File Offset: 0x00002D8C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalStdlibApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00004BA0 File Offset: 0x00002DA0
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00004BF1 File Offset: 0x00002DF1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalStdlibApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalStdlibApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalStdlibApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalStdlibApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004C18 File Offset: 0x00002E18
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalStdlibApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00004C3C File Offset: 0x00002E3C
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

		// Token: 0x06000206 RID: 518 RVA: 0x00004CAF File Offset: 0x00002EAF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalStdlibApiInvoker.cb_hashCode == null)
			{
				IExperimentalStdlibApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalStdlibApiInvoker.n_GetHashCode));
			}
			return IExperimentalStdlibApiInvoker.cb_hashCode;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00004CD3 File Offset: 0x00002ED3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalStdlibApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00004D22 File Offset: 0x00002F22
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalStdlibApiInvoker.cb_toString == null)
			{
				IExperimentalStdlibApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalStdlibApiInvoker.n_ToString));
			}
			return IExperimentalStdlibApiInvoker.cb_toString;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00004D46 File Offset: 0x00002F46
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalStdlibApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00004D5C File Offset: 0x00002F5C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400006A RID: 106
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ExperimentalStdlibApi", typeof(IExperimentalStdlibApiInvoker));

		// Token: 0x0400006B RID: 107
		private IntPtr class_ref;

		// Token: 0x0400006C RID: 108
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400006D RID: 109
		private IntPtr id_annotationType;

		// Token: 0x0400006E RID: 110
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400006F RID: 111
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000070 RID: 112
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000071 RID: 113
		private IntPtr id_hashCode;

		// Token: 0x04000072 RID: 114
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000073 RID: 115
		private IntPtr id_toString;
	}
}
