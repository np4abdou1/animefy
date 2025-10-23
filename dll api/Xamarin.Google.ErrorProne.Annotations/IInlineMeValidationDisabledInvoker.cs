using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000028 RID: 40
	[Register("com/google/errorprone/annotations/InlineMeValidationDisabled", DoNotGenerateAcw = true)]
	internal class IInlineMeValidationDisabledInvoker : Java.Lang.Object, IInlineMeValidationDisabled, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00004BEC File Offset: 0x00002DEC
		private static IntPtr java_class_ref
		{
			get
			{
				return IInlineMeValidationDisabledInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00004C10 File Offset: 0x00002E10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInlineMeValidationDisabledInvoker._members;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00004C17 File Offset: 0x00002E17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00004C1F File Offset: 0x00002E1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInlineMeValidationDisabledInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004C2B File Offset: 0x00002E2B
		public static IInlineMeValidationDisabled GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInlineMeValidationDisabled>(handle, transfer);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004C34 File Offset: 0x00002E34
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInlineMeValidationDisabledInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.InlineMeValidationDisabled'.");
			}
			return handle;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004C5F File Offset: 0x00002E5F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004C90 File Offset: 0x00002E90
		public IInlineMeValidationDisabledInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInlineMeValidationDisabledInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004CC8 File Offset: 0x00002EC8
		private static Delegate GetValueHandler()
		{
			if (IInlineMeValidationDisabledInvoker.cb_value == null)
			{
				IInlineMeValidationDisabledInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeValidationDisabledInvoker.n_Value));
			}
			return IInlineMeValidationDisabledInvoker.cb_value;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004CEC File Offset: 0x00002EEC
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInlineMeValidationDisabled>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00004D00 File Offset: 0x00002F00
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004D51 File Offset: 0x00002F51
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IInlineMeValidationDisabledInvoker.cb_annotationType == null)
			{
				IInlineMeValidationDisabledInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeValidationDisabledInvoker.n_AnnotationType));
			}
			return IInlineMeValidationDisabledInvoker.cb_annotationType;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004D75 File Offset: 0x00002F75
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInlineMeValidationDisabled>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004D8C File Offset: 0x00002F8C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004DDD File Offset: 0x00002FDD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IInlineMeValidationDisabledInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IInlineMeValidationDisabledInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IInlineMeValidationDisabledInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IInlineMeValidationDisabledInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00004E04 File Offset: 0x00003004
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IInlineMeValidationDisabled>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00004E28 File Offset: 0x00003028
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

		// Token: 0x0600014B RID: 331 RVA: 0x00004E9B File Offset: 0x0000309B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IInlineMeValidationDisabledInvoker.cb_hashCode == null)
			{
				IInlineMeValidationDisabledInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IInlineMeValidationDisabledInvoker.n_GetHashCode));
			}
			return IInlineMeValidationDisabledInvoker.cb_hashCode;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004EBF File Offset: 0x000030BF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IInlineMeValidationDisabled>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00004ECE File Offset: 0x000030CE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004F0E File Offset: 0x0000310E
		private static Delegate GetToStringHandler()
		{
			if (IInlineMeValidationDisabledInvoker.cb_toString == null)
			{
				IInlineMeValidationDisabledInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeValidationDisabledInvoker.n_ToString));
			}
			return IInlineMeValidationDisabledInvoker.cb_toString;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004F32 File Offset: 0x00003132
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInlineMeValidationDisabled>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00004F48 File Offset: 0x00003148
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400008C RID: 140
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/InlineMeValidationDisabled", typeof(IInlineMeValidationDisabledInvoker));

		// Token: 0x0400008D RID: 141
		private IntPtr class_ref;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_value;

		// Token: 0x0400008F RID: 143
		private IntPtr id_value;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_annotationType;

		// Token: 0x04000091 RID: 145
		private IntPtr id_annotationType;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000093 RID: 147
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_hashCode;

		// Token: 0x04000095 RID: 149
		private IntPtr id_hashCode;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_toString;

		// Token: 0x04000097 RID: 151
		private IntPtr id_toString;
	}
}
