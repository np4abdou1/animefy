using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/android/ump/FormError", DoNotGenerateAcw = true)]
	public class FormError : Java.Lang.Object
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002BB8 File Offset: 0x00000DB8
		internal static IntPtr class_ref
		{
			get
			{
				return FormError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002BDC File Offset: 0x00000DDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FormError._members;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002BE4 File Offset: 0x00000DE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FormError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002C08 File Offset: 0x00000E08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FormError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000020B4 File Offset: 0x000002B4
		protected FormError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002C14 File Offset: 0x00000E14
		[Register(".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe FormError(int p0, string p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(FormError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FormError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002CCC File Offset: 0x00000ECC
		private static Delegate GetGetMessageHandler()
		{
			if (FormError.cb_getMessage == null)
			{
				FormError.cb_getMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FormError.n_GetMessage));
			}
			return FormError.cb_getMessage;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002CF0 File Offset: 0x00000EF0
		private static IntPtr n_GetMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<FormError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002D04 File Offset: 0x00000F04
		public virtual string Message
		{
			[Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get
			{
				return JNIEnv.GetString(FormError._members.InstanceMethods.InvokeVirtualObjectMethod("getMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002D36 File Offset: 0x00000F36
		private static Delegate GetErrorCodeDataHandler()
		{
			if (FormError.cb_getErrorCode == null)
			{
				FormError.cb_getErrorCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FormError.n_ErrorCodeData));
			}
			return FormError.cb_getErrorCode;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002D5A File Offset: 0x00000F5A
		private static int n_ErrorCodeData(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FormError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorCodeData();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002D69 File Offset: 0x00000F69
		[Register("getErrorCode", "()I", "GetErrorCodeDataHandler")]
		public virtual int ErrorCodeData()
		{
			return FormError._members.InstanceMethods.InvokeVirtualInt32Method("getErrorCode.()I", this, null);
		}

		// Token: 0x0400001A RID: 26
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/FormError", typeof(FormError));

		// Token: 0x0400001B RID: 27
		private static Delegate cb_getMessage;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_getErrorCode;

		// Token: 0x02000017 RID: 23
		[Register("com/google/android/ump/FormError$ErrorCode", DoNotGenerateAcw = true)]
		public abstract class ErrorCode : Java.Lang.Object
		{
			// Token: 0x06000089 RID: 137 RVA: 0x000024C4 File Offset: 0x000006C4
			internal ErrorCode()
			{
			}

			// Token: 0x0400001D RID: 29
			[Register("INTERNAL_ERROR")]
			public const int InternalError = 1;

			// Token: 0x0400001E RID: 30
			[Register("INTERNET_ERROR")]
			public const int InternetError = 2;

			// Token: 0x0400001F RID: 31
			[Register("INVALID_OPERATION")]
			public const int InvalidOperation = 3;

			// Token: 0x04000020 RID: 32
			[Register("TIME_OUT")]
			public const int TimeOut = 4;
		}

		// Token: 0x02000018 RID: 24
		[Register("com/google/android/ump/FormError$ErrorCode", DoNotGenerateAcw = true)]
		[Obsolete("Use the 'ErrorCode' type. This type will be removed in a future release.", true)]
		public abstract class ErrorCodeConsts : FormError.ErrorCode
		{
			// Token: 0x0600008A RID: 138 RVA: 0x00002D9D File Offset: 0x00000F9D
			private ErrorCodeConsts()
			{
			}
		}

		// Token: 0x02000019 RID: 25
		[Register("com/google/android/ump/FormError$ErrorCode", "", "Xamarin.Google.UserMesssagingPlatform.FormError/IErrorCodeInvoker")]
		public interface IErrorCode : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200001A RID: 26
		[Register("com/google/android/ump/FormError$ErrorCode", DoNotGenerateAcw = true)]
		internal class IErrorCodeInvoker : Java.Lang.Object, FormError.IErrorCode, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00002DA8 File Offset: 0x00000FA8
			private static IntPtr java_class_ref
			{
				get
				{
					return FormError.IErrorCodeInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00002DCC File Offset: 0x00000FCC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FormError.IErrorCodeInvoker._members;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00002DD3 File Offset: 0x00000FD3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600008E RID: 142 RVA: 0x00002DDB File Offset: 0x00000FDB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FormError.IErrorCodeInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00002DE7 File Offset: 0x00000FE7
			public static FormError.IErrorCode GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FormError.IErrorCode>(handle, transfer);
			}

			// Token: 0x06000090 RID: 144 RVA: 0x00002DF0 File Offset: 0x00000FF0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FormError.IErrorCodeInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.FormError.ErrorCode'.");
				}
				return handle;
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002E1B File Offset: 0x0000101B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00002E4C File Offset: 0x0000104C
			public IErrorCodeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FormError.IErrorCodeInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00002E84 File Offset: 0x00001084
			private static Delegate GetAnnotationTypeHandler()
			{
				if (FormError.IErrorCodeInvoker.cb_annotationType == null)
				{
					FormError.IErrorCodeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FormError.IErrorCodeInvoker.n_AnnotationType));
				}
				return FormError.IErrorCodeInvoker.cb_annotationType;
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002EA8 File Offset: 0x000010A8
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FormError.IErrorCode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002EBC File Offset: 0x000010BC
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002F0D File Offset: 0x0000110D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (FormError.IErrorCodeInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					FormError.IErrorCodeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(FormError.IErrorCodeInvoker.n_Equals_Ljava_lang_Object_));
				}
				return FormError.IErrorCodeInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00002F34 File Offset: 0x00001134
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<FormError.IErrorCode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00002F58 File Offset: 0x00001158
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

			// Token: 0x06000099 RID: 153 RVA: 0x00002FCB File Offset: 0x000011CB
			private static Delegate GetGetHashCodeHandler()
			{
				if (FormError.IErrorCodeInvoker.cb_hashCode == null)
				{
					FormError.IErrorCodeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FormError.IErrorCodeInvoker.n_GetHashCode));
				}
				return FormError.IErrorCodeInvoker.cb_hashCode;
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00002FEF File Offset: 0x000011EF
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<FormError.IErrorCode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00002FFE File Offset: 0x000011FE
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600009C RID: 156 RVA: 0x0000303E File Offset: 0x0000123E
			private static Delegate GetToStringHandler()
			{
				if (FormError.IErrorCodeInvoker.cb_toString == null)
				{
					FormError.IErrorCodeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FormError.IErrorCodeInvoker.n_ToString));
				}
				return FormError.IErrorCodeInvoker.cb_toString;
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00003062 File Offset: 0x00001262
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<FormError.IErrorCode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00003078 File Offset: 0x00001278
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000021 RID: 33
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/FormError$ErrorCode", typeof(FormError.IErrorCodeInvoker));

			// Token: 0x04000022 RID: 34
			private IntPtr class_ref;

			// Token: 0x04000023 RID: 35
			private static Delegate cb_annotationType;

			// Token: 0x04000024 RID: 36
			private IntPtr id_annotationType;

			// Token: 0x04000025 RID: 37
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000026 RID: 38
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000027 RID: 39
			private static Delegate cb_hashCode;

			// Token: 0x04000028 RID: 40
			private IntPtr id_hashCode;

			// Token: 0x04000029 RID: 41
			private static Delegate cb_toString;

			// Token: 0x0400002A RID: 42
			private IntPtr id_toString;
		}
	}
}
