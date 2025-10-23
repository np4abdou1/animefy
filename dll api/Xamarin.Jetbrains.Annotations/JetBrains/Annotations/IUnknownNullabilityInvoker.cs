using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000031 RID: 49
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/UnknownNullability", DoNotGenerateAcw = true)]
	internal class IUnknownNullabilityInvoker : Java.Lang.Object, IUnknownNullability, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000056B8 File Offset: 0x000038B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnknownNullabilityInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000056DC File Offset: 0x000038DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnknownNullabilityInvoker._members;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000056E3 File Offset: 0x000038E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000056EB File Offset: 0x000038EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnknownNullabilityInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000056F7 File Offset: 0x000038F7
		[NullableContext(2)]
		public static IUnknownNullability GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnknownNullability>(handle, transfer);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00005700 File Offset: 0x00003900
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnknownNullabilityInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.UnknownNullability'.");
			}
			return handle;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000572B File Offset: 0x0000392B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000575C File Offset: 0x0000395C
		public IUnknownNullabilityInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnknownNullabilityInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005794 File Offset: 0x00003994
		private static Delegate GetValueHandler()
		{
			if (IUnknownNullabilityInvoker.cb_value == null)
			{
				IUnknownNullabilityInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnknownNullabilityInvoker.n_Value));
			}
			return IUnknownNullabilityInvoker.cb_value;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000057B8 File Offset: 0x000039B8
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnknownNullability>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000057CC File Offset: 0x000039CC
		[NullableContext(2)]
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000581D File Offset: 0x00003A1D
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IUnknownNullabilityInvoker.cb_annotationType == null)
			{
				IUnknownNullabilityInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnknownNullabilityInvoker.n_AnnotationType));
			}
			return IUnknownNullabilityInvoker.cb_annotationType;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005841 File Offset: 0x00003A41
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IUnknownNullability>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005858 File Offset: 0x00003A58
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000058A9 File Offset: 0x00003AA9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IUnknownNullabilityInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IUnknownNullabilityInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IUnknownNullabilityInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IUnknownNullabilityInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000058D0 File Offset: 0x00003AD0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IUnknownNullability>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000058F4 File Offset: 0x00003AF4
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

		// Token: 0x060001A2 RID: 418 RVA: 0x00005967 File Offset: 0x00003B67
		private static Delegate GetGetHashCodeHandler()
		{
			if (IUnknownNullabilityInvoker.cb_hashCode == null)
			{
				IUnknownNullabilityInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IUnknownNullabilityInvoker.n_GetHashCode));
			}
			return IUnknownNullabilityInvoker.cb_hashCode;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000598B File Offset: 0x00003B8B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnknownNullability>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000599A File Offset: 0x00003B9A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000059DA File Offset: 0x00003BDA
		private static Delegate GetToStringHandler()
		{
			if (IUnknownNullabilityInvoker.cb_toString == null)
			{
				IUnknownNullabilityInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnknownNullabilityInvoker.n_ToString));
			}
			return IUnknownNullabilityInvoker.cb_toString;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000059FE File Offset: 0x00003BFE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnknownNullability>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005A14 File Offset: 0x00003C14
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000AB RID: 171
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/UnknownNullability", typeof(IUnknownNullabilityInvoker));

		// Token: 0x040000AC RID: 172
		private IntPtr class_ref;

		// Token: 0x040000AD RID: 173
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x040000AE RID: 174
		private IntPtr id_value;

		// Token: 0x040000AF RID: 175
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000B0 RID: 176
		private IntPtr id_annotationType;

		// Token: 0x040000B1 RID: 177
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000B2 RID: 178
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000B3 RID: 179
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000B4 RID: 180
		private IntPtr id_hashCode;

		// Token: 0x040000B5 RID: 181
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000B6 RID: 182
		private IntPtr id_toString;
	}
}
