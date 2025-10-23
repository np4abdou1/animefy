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
	// Token: 0x02000086 RID: 134
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UnsafeVariance", DoNotGenerateAcw = true)]
	internal class IUnsafeVarianceInvoker : Java.Lang.Object, IUnsafeVariance, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000089B0 File Offset: 0x00006BB0
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnsafeVarianceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000089D4 File Offset: 0x00006BD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnsafeVarianceInvoker._members;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000089DB File Offset: 0x00006BDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000089E3 File Offset: 0x00006BE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnsafeVarianceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000089EF File Offset: 0x00006BEF
		[NullableContext(2)]
		public static IUnsafeVariance GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnsafeVariance>(handle, transfer);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000089F8 File Offset: 0x00006BF8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnsafeVarianceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.UnsafeVariance'.");
			}
			return handle;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00008A23 File Offset: 0x00006C23
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00008A54 File Offset: 0x00006C54
		public IUnsafeVarianceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnsafeVarianceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00008A8C File Offset: 0x00006C8C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IUnsafeVarianceInvoker.cb_annotationType == null)
			{
				IUnsafeVarianceInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnsafeVarianceInvoker.n_AnnotationType));
			}
			return IUnsafeVarianceInvoker.cb_annotationType;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00008AB0 File Offset: 0x00006CB0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IUnsafeVariance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00008AC4 File Offset: 0x00006CC4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00008B15 File Offset: 0x00006D15
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IUnsafeVarianceInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IUnsafeVarianceInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IUnsafeVarianceInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IUnsafeVarianceInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00008B3C File Offset: 0x00006D3C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IUnsafeVariance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00008B60 File Offset: 0x00006D60
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

		// Token: 0x060003B0 RID: 944 RVA: 0x00008BD3 File Offset: 0x00006DD3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IUnsafeVarianceInvoker.cb_hashCode == null)
			{
				IUnsafeVarianceInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IUnsafeVarianceInvoker.n_GetHashCode));
			}
			return IUnsafeVarianceInvoker.cb_hashCode;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00008BF7 File Offset: 0x00006DF7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnsafeVariance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00008C06 File Offset: 0x00006E06
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00008C46 File Offset: 0x00006E46
		private static Delegate GetToStringHandler()
		{
			if (IUnsafeVarianceInvoker.cb_toString == null)
			{
				IUnsafeVarianceInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnsafeVarianceInvoker.n_ToString));
			}
			return IUnsafeVarianceInvoker.cb_toString;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00008C6A File Offset: 0x00006E6A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnsafeVariance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00008C80 File Offset: 0x00006E80
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400012C RID: 300
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UnsafeVariance", typeof(IUnsafeVarianceInvoker));

		// Token: 0x0400012D RID: 301
		private IntPtr class_ref;

		// Token: 0x0400012E RID: 302
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400012F RID: 303
		private IntPtr id_annotationType;

		// Token: 0x04000130 RID: 304
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000131 RID: 305
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000132 RID: 306
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000133 RID: 307
		private IntPtr id_hashCode;

		// Token: 0x04000134 RID: 308
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000135 RID: 309
		private IntPtr id_toString;
	}
}
