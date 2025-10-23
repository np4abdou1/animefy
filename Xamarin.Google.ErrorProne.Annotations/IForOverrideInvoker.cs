using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000020 RID: 32
	[Register("com/google/errorprone/annotations/ForOverride", DoNotGenerateAcw = true)]
	internal class IForOverrideInvoker : Java.Lang.Object, IForOverride, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003C10 File Offset: 0x00001E10
		private static IntPtr java_class_ref
		{
			get
			{
				return IForOverrideInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003C34 File Offset: 0x00001E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IForOverrideInvoker._members;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003C3B File Offset: 0x00001E3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003C43 File Offset: 0x00001E43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IForOverrideInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003C4F File Offset: 0x00001E4F
		public static IForOverride GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IForOverride>(handle, transfer);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003C58 File Offset: 0x00001E58
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IForOverrideInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.ForOverride'.");
			}
			return handle;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003C83 File Offset: 0x00001E83
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public IForOverrideInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IForOverrideInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003CEC File Offset: 0x00001EEC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IForOverrideInvoker.cb_annotationType == null)
			{
				IForOverrideInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IForOverrideInvoker.n_AnnotationType));
			}
			return IForOverrideInvoker.cb_annotationType;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003D10 File Offset: 0x00001F10
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IForOverride>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003D24 File Offset: 0x00001F24
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003D75 File Offset: 0x00001F75
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IForOverrideInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IForOverrideInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IForOverrideInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IForOverrideInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003D9C File Offset: 0x00001F9C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IForOverride>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003DC0 File Offset: 0x00001FC0
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

		// Token: 0x060000DF RID: 223 RVA: 0x00003E33 File Offset: 0x00002033
		private static Delegate GetGetHashCodeHandler()
		{
			if (IForOverrideInvoker.cb_hashCode == null)
			{
				IForOverrideInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IForOverrideInvoker.n_GetHashCode));
			}
			return IForOverrideInvoker.cb_hashCode;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003E57 File Offset: 0x00002057
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IForOverride>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003E66 File Offset: 0x00002066
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003EA6 File Offset: 0x000020A6
		private static Delegate GetToStringHandler()
		{
			if (IForOverrideInvoker.cb_toString == null)
			{
				IForOverrideInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IForOverrideInvoker.n_ToString));
			}
			return IForOverrideInvoker.cb_toString;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003ECA File Offset: 0x000020CA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IForOverride>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003EE0 File Offset: 0x000020E0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400005A RID: 90
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/ForOverride", typeof(IForOverrideInvoker));

		// Token: 0x0400005B RID: 91
		private IntPtr class_ref;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_annotationType;

		// Token: 0x0400005D RID: 93
		private IntPtr id_annotationType;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400005F RID: 95
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_hashCode;

		// Token: 0x04000061 RID: 97
		private IntPtr id_hashCode;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_toString;

		// Token: 0x04000063 RID: 99
		private IntPtr id_toString;
	}
}
