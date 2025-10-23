using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x0200000E RID: 14
	[Register("javax/inject/Qualifier", DoNotGenerateAcw = true)]
	internal class IQualifierInvoker : Java.Lang.Object, IQualifier, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000028DC File Offset: 0x00000ADC
		private static IntPtr java_class_ref
		{
			get
			{
				return IQualifierInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002900 File Offset: 0x00000B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IQualifierInvoker._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002907 File Offset: 0x00000B07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000290F File Offset: 0x00000B0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IQualifierInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000291B File Offset: 0x00000B1B
		public static IQualifier GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IQualifier>(handle, transfer);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002924 File Offset: 0x00000B24
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IQualifierInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.inject.Qualifier'.");
			}
			return handle;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000294F File Offset: 0x00000B4F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002980 File Offset: 0x00000B80
		public IQualifierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IQualifierInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000029B8 File Offset: 0x00000BB8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IQualifierInvoker.cb_annotationType == null)
			{
				IQualifierInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IQualifierInvoker.n_AnnotationType));
			}
			return IQualifierInvoker.cb_annotationType;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000029DC File Offset: 0x00000BDC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IQualifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000029F0 File Offset: 0x00000BF0
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A41 File Offset: 0x00000C41
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IQualifierInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IQualifierInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IQualifierInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IQualifierInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002A68 File Offset: 0x00000C68
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IQualifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002A8C File Offset: 0x00000C8C
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

		// Token: 0x06000058 RID: 88 RVA: 0x00002AFF File Offset: 0x00000CFF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IQualifierInvoker.cb_hashCode == null)
			{
				IQualifierInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IQualifierInvoker.n_GetHashCode));
			}
			return IQualifierInvoker.cb_hashCode;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002B23 File Offset: 0x00000D23
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IQualifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002B32 File Offset: 0x00000D32
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002B72 File Offset: 0x00000D72
		private static Delegate GetToStringHandler()
		{
			if (IQualifierInvoker.cb_toString == null)
			{
				IQualifierInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IQualifierInvoker.n_ToString));
			}
			return IQualifierInvoker.cb_toString;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002B96 File Offset: 0x00000D96
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IQualifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002BAC File Offset: 0x00000DAC
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400001B RID: 27
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/inject/Qualifier", typeof(IQualifierInvoker));

		// Token: 0x0400001C RID: 28
		private IntPtr class_ref;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_annotationType;

		// Token: 0x0400001E RID: 30
		private IntPtr id_annotationType;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000020 RID: 32
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_hashCode;

		// Token: 0x04000022 RID: 34
		private IntPtr id_hashCode;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_toString;

		// Token: 0x04000024 RID: 36
		private IntPtr id_toString;
	}
}
