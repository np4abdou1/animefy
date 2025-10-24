using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000014 RID: 20
	[Register("com/google/errorprone/annotations/CompatibleWith", DoNotGenerateAcw = true)]
	internal class ICompatibleWithInvoker : Java.Lang.Object, ICompatibleWith, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002704 File Offset: 0x00000904
		private static IntPtr java_class_ref
		{
			get
			{
				return ICompatibleWithInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002728 File Offset: 0x00000928
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICompatibleWithInvoker._members;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000272F File Offset: 0x0000092F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002737 File Offset: 0x00000937
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICompatibleWithInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002743 File Offset: 0x00000943
		public static ICompatibleWith GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICompatibleWith>(handle, transfer);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000274C File Offset: 0x0000094C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICompatibleWithInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.CompatibleWith'.");
			}
			return handle;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002777 File Offset: 0x00000977
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000027A8 File Offset: 0x000009A8
		public ICompatibleWithInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICompatibleWithInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000027E0 File Offset: 0x000009E0
		private static Delegate GetValueHandler()
		{
			if (ICompatibleWithInvoker.cb_value == null)
			{
				ICompatibleWithInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompatibleWithInvoker.n_Value));
			}
			return ICompatibleWithInvoker.cb_value;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002804 File Offset: 0x00000A04
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICompatibleWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002818 File Offset: 0x00000A18
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002869 File Offset: 0x00000A69
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ICompatibleWithInvoker.cb_annotationType == null)
			{
				ICompatibleWithInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompatibleWithInvoker.n_AnnotationType));
			}
			return ICompatibleWithInvoker.cb_annotationType;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000288D File Offset: 0x00000A8D
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompatibleWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000028A4 File Offset: 0x00000AA4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000028F5 File Offset: 0x00000AF5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ICompatibleWithInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ICompatibleWithInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICompatibleWithInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ICompatibleWithInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000291C File Offset: 0x00000B1C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ICompatibleWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002940 File Offset: 0x00000B40
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

		// Token: 0x06000059 RID: 89 RVA: 0x000029B3 File Offset: 0x00000BB3
		private static Delegate GetGetHashCodeHandler()
		{
			if (ICompatibleWithInvoker.cb_hashCode == null)
			{
				ICompatibleWithInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICompatibleWithInvoker.n_GetHashCode));
			}
			return ICompatibleWithInvoker.cb_hashCode;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000029D7 File Offset: 0x00000BD7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompatibleWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000029E6 File Offset: 0x00000BE6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A26 File Offset: 0x00000C26
		private static Delegate GetToStringHandler()
		{
			if (ICompatibleWithInvoker.cb_toString == null)
			{
				ICompatibleWithInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompatibleWithInvoker.n_ToString));
			}
			return ICompatibleWithInvoker.cb_toString;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A4A File Offset: 0x00000C4A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICompatibleWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A60 File Offset: 0x00000C60
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000018 RID: 24
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/CompatibleWith", typeof(ICompatibleWithInvoker));

		// Token: 0x04000019 RID: 25
		private IntPtr class_ref;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_value;

		// Token: 0x0400001B RID: 27
		private IntPtr id_value;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_annotationType;

		// Token: 0x0400001D RID: 29
		private IntPtr id_annotationType;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400001F RID: 31
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_hashCode;

		// Token: 0x04000021 RID: 33
		private IntPtr id_hashCode;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_toString;

		// Token: 0x04000023 RID: 35
		private IntPtr id_toString;
	}
}
