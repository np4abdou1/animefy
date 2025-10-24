using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/errorprone/annotations/CompileTimeConstant", DoNotGenerateAcw = true)]
	internal class ICompileTimeConstantInvoker : Java.Lang.Object, ICompileTimeConstant, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002ACC File Offset: 0x00000CCC
		private static IntPtr java_class_ref
		{
			get
			{
				return ICompileTimeConstantInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICompileTimeConstantInvoker._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002AF7 File Offset: 0x00000CF7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002AFF File Offset: 0x00000CFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICompileTimeConstantInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002B0B File Offset: 0x00000D0B
		public static ICompileTimeConstant GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICompileTimeConstant>(handle, transfer);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002B14 File Offset: 0x00000D14
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICompileTimeConstantInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.CompileTimeConstant'.");
			}
			return handle;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002B3F File Offset: 0x00000D3F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002B70 File Offset: 0x00000D70
		public ICompileTimeConstantInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICompileTimeConstantInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002BA8 File Offset: 0x00000DA8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ICompileTimeConstantInvoker.cb_annotationType == null)
			{
				ICompileTimeConstantInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompileTimeConstantInvoker.n_AnnotationType));
			}
			return ICompileTimeConstantInvoker.cb_annotationType;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002BCC File Offset: 0x00000DCC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompileTimeConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002C31 File Offset: 0x00000E31
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ICompileTimeConstantInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ICompileTimeConstantInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICompileTimeConstantInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ICompileTimeConstantInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C58 File Offset: 0x00000E58
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ICompileTimeConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002C7C File Offset: 0x00000E7C
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

		// Token: 0x0600006E RID: 110 RVA: 0x00002CEF File Offset: 0x00000EEF
		private static Delegate GetGetHashCodeHandler()
		{
			if (ICompileTimeConstantInvoker.cb_hashCode == null)
			{
				ICompileTimeConstantInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICompileTimeConstantInvoker.n_GetHashCode));
			}
			return ICompileTimeConstantInvoker.cb_hashCode;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002D13 File Offset: 0x00000F13
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompileTimeConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002D22 File Offset: 0x00000F22
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002D62 File Offset: 0x00000F62
		private static Delegate GetToStringHandler()
		{
			if (ICompileTimeConstantInvoker.cb_toString == null)
			{
				ICompileTimeConstantInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompileTimeConstantInvoker.n_ToString));
			}
			return ICompileTimeConstantInvoker.cb_toString;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002D86 File Offset: 0x00000F86
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICompileTimeConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002D9C File Offset: 0x00000F9C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000024 RID: 36
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/CompileTimeConstant", typeof(ICompileTimeConstantInvoker));

		// Token: 0x04000025 RID: 37
		private IntPtr class_ref;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_annotationType;

		// Token: 0x04000027 RID: 39
		private IntPtr id_annotationType;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000029 RID: 41
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_hashCode;

		// Token: 0x0400002B RID: 43
		private IntPtr id_hashCode;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_toString;

		// Token: 0x0400002D RID: 45
		private IntPtr id_toString;
	}
}
