using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200001E RID: 30
	[Register("com/google/errorprone/annotations/FormatString", DoNotGenerateAcw = true)]
	internal class IFormatStringInvoker : Java.Lang.Object, IFormatString, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000038D4 File Offset: 0x00001AD4
		private static IntPtr java_class_ref
		{
			get
			{
				return IFormatStringInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000038F8 File Offset: 0x00001AF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFormatStringInvoker._members;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000038FF File Offset: 0x00001AFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003907 File Offset: 0x00001B07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFormatStringInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003913 File Offset: 0x00001B13
		public static IFormatString GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFormatString>(handle, transfer);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000391C File Offset: 0x00001B1C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFormatStringInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.FormatString'.");
			}
			return handle;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003947 File Offset: 0x00001B47
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003978 File Offset: 0x00001B78
		public IFormatStringInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFormatStringInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000039B0 File Offset: 0x00001BB0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IFormatStringInvoker.cb_annotationType == null)
			{
				IFormatStringInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFormatStringInvoker.n_AnnotationType));
			}
			return IFormatStringInvoker.cb_annotationType;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000039D4 File Offset: 0x00001BD4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFormatString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000039E8 File Offset: 0x00001BE8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003A39 File Offset: 0x00001C39
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IFormatStringInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IFormatStringInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IFormatStringInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IFormatStringInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003A60 File Offset: 0x00001C60
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IFormatString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003A84 File Offset: 0x00001C84
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

		// Token: 0x060000CA RID: 202 RVA: 0x00003AF7 File Offset: 0x00001CF7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IFormatStringInvoker.cb_hashCode == null)
			{
				IFormatStringInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IFormatStringInvoker.n_GetHashCode));
			}
			return IFormatStringInvoker.cb_hashCode;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003B1B File Offset: 0x00001D1B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFormatString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003B2A File Offset: 0x00001D2A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003B6A File Offset: 0x00001D6A
		private static Delegate GetToStringHandler()
		{
			if (IFormatStringInvoker.cb_toString == null)
			{
				IFormatStringInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFormatStringInvoker.n_ToString));
			}
			return IFormatStringInvoker.cb_toString;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003B8E File Offset: 0x00001D8E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFormatString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000050 RID: 80
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/FormatString", typeof(IFormatStringInvoker));

		// Token: 0x04000051 RID: 81
		private IntPtr class_ref;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_annotationType;

		// Token: 0x04000053 RID: 83
		private IntPtr id_annotationType;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000055 RID: 85
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_hashCode;

		// Token: 0x04000057 RID: 87
		private IntPtr id_hashCode;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_toString;

		// Token: 0x04000059 RID: 89
		private IntPtr id_toString;
	}
}
