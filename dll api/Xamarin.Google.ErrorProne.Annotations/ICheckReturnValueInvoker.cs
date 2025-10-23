using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000012 RID: 18
	[Register("com/google/errorprone/annotations/CheckReturnValue", DoNotGenerateAcw = true)]
	internal class ICheckReturnValueInvoker : Java.Lang.Object, ICheckReturnValue, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000023C8 File Offset: 0x000005C8
		private static IntPtr java_class_ref
		{
			get
			{
				return ICheckReturnValueInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000023EC File Offset: 0x000005EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICheckReturnValueInvoker._members;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000023F3 File Offset: 0x000005F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000023FB File Offset: 0x000005FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICheckReturnValueInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002407 File Offset: 0x00000607
		public static ICheckReturnValue GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICheckReturnValue>(handle, transfer);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002410 File Offset: 0x00000610
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICheckReturnValueInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.CheckReturnValue'.");
			}
			return handle;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000243B File Offset: 0x0000063B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000246C File Offset: 0x0000066C
		public ICheckReturnValueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICheckReturnValueInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024A4 File Offset: 0x000006A4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ICheckReturnValueInvoker.cb_annotationType == null)
			{
				ICheckReturnValueInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICheckReturnValueInvoker.n_AnnotationType));
			}
			return ICheckReturnValueInvoker.cb_annotationType;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024C8 File Offset: 0x000006C8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024DC File Offset: 0x000006DC
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000252D File Offset: 0x0000072D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ICheckReturnValueInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ICheckReturnValueInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICheckReturnValueInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ICheckReturnValueInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002554 File Offset: 0x00000754
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002578 File Offset: 0x00000778
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

		// Token: 0x06000040 RID: 64 RVA: 0x000025EB File Offset: 0x000007EB
		private static Delegate GetGetHashCodeHandler()
		{
			if (ICheckReturnValueInvoker.cb_hashCode == null)
			{
				ICheckReturnValueInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICheckReturnValueInvoker.n_GetHashCode));
			}
			return ICheckReturnValueInvoker.cb_hashCode;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000260F File Offset: 0x0000080F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000261E File Offset: 0x0000081E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000265E File Offset: 0x0000085E
		private static Delegate GetToStringHandler()
		{
			if (ICheckReturnValueInvoker.cb_toString == null)
			{
				ICheckReturnValueInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICheckReturnValueInvoker.n_ToString));
			}
			return ICheckReturnValueInvoker.cb_toString;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002682 File Offset: 0x00000882
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICheckReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002698 File Offset: 0x00000898
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400000E RID: 14
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/CheckReturnValue", typeof(ICheckReturnValueInvoker));

		// Token: 0x0400000F RID: 15
		private IntPtr class_ref;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_annotationType;

		// Token: 0x04000011 RID: 17
		private IntPtr id_annotationType;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000013 RID: 19
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_hashCode;

		// Token: 0x04000015 RID: 21
		private IntPtr id_hashCode;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_toString;

		// Token: 0x04000017 RID: 23
		private IntPtr id_toString;
	}
}
