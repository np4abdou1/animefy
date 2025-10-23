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
	// Token: 0x02000018 RID: 24
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/CheckReturnValue", DoNotGenerateAcw = true)]
	internal class ICheckReturnValueInvoker : Java.Lang.Object, ICheckReturnValue, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000028FC File Offset: 0x00000AFC
		private static IntPtr java_class_ref
		{
			get
			{
				return ICheckReturnValueInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002920 File Offset: 0x00000B20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICheckReturnValueInvoker._members;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002927 File Offset: 0x00000B27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000292F File Offset: 0x00000B2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICheckReturnValueInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000293B File Offset: 0x00000B3B
		[NullableContext(2)]
		public static ICheckReturnValue GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICheckReturnValue>(handle, transfer);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002944 File Offset: 0x00000B44
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICheckReturnValueInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.CheckReturnValue'.");
			}
			return handle;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000296F File Offset: 0x00000B6F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000029A0 File Offset: 0x00000BA0
		public ICheckReturnValueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICheckReturnValueInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000029D8 File Offset: 0x00000BD8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ICheckReturnValueInvoker.cb_annotationType == null)
			{
				ICheckReturnValueInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICheckReturnValueInvoker.n_AnnotationType));
			}
			return ICheckReturnValueInvoker.cb_annotationType;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000029FC File Offset: 0x00000BFC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002A10 File Offset: 0x00000C10
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002A61 File Offset: 0x00000C61
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ICheckReturnValueInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ICheckReturnValueInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICheckReturnValueInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ICheckReturnValueInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002A88 File Offset: 0x00000C88
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002AAC File Offset: 0x00000CAC
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

		// Token: 0x0600006F RID: 111 RVA: 0x00002B1F File Offset: 0x00000D1F
		private static Delegate GetGetHashCodeHandler()
		{
			if (ICheckReturnValueInvoker.cb_hashCode == null)
			{
				ICheckReturnValueInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICheckReturnValueInvoker.n_GetHashCode));
			}
			return ICheckReturnValueInvoker.cb_hashCode;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002B43 File Offset: 0x00000D43
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002B52 File Offset: 0x00000D52
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002B92 File Offset: 0x00000D92
		private static Delegate GetToStringHandler()
		{
			if (ICheckReturnValueInvoker.cb_toString == null)
			{
				ICheckReturnValueInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICheckReturnValueInvoker.n_ToString));
			}
			return ICheckReturnValueInvoker.cb_toString;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002BB6 File Offset: 0x00000DB6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002BCC File Offset: 0x00000DCC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400001E RID: 30
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/CheckReturnValue", typeof(ICheckReturnValueInvoker));

		// Token: 0x0400001F RID: 31
		private IntPtr class_ref;

		// Token: 0x04000020 RID: 32
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000021 RID: 33
		private IntPtr id_annotationType;

		// Token: 0x04000022 RID: 34
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000023 RID: 35
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000024 RID: 36
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000025 RID: 37
		private IntPtr id_hashCode;

		// Token: 0x04000026 RID: 38
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000027 RID: 39
		private IntPtr id_toString;
	}
}
