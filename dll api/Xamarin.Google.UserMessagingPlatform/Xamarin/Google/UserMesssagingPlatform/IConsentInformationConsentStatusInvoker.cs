using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000024 RID: 36
	[Register("com/google/android/ump/ConsentInformation$ConsentStatus", DoNotGenerateAcw = true)]
	internal class IConsentInformationConsentStatusInvoker : Java.Lang.Object, IConsentInformationConsentStatus, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003508 File Offset: 0x00001708
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsentInformationConsentStatusInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000352C File Offset: 0x0000172C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsentInformationConsentStatusInvoker._members;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003533 File Offset: 0x00001733
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000353B File Offset: 0x0000173B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsentInformationConsentStatusInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003547 File Offset: 0x00001747
		public static IConsentInformationConsentStatus GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsentInformationConsentStatus>(handle, transfer);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003550 File Offset: 0x00001750
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsentInformationConsentStatusInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentInformation.ConsentStatus'.");
			}
			return handle;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000357B File Offset: 0x0000177B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000035AC File Offset: 0x000017AC
		public IConsentInformationConsentStatusInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsentInformationConsentStatusInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000035E4 File Offset: 0x000017E4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IConsentInformationConsentStatusInvoker.cb_annotationType == null)
			{
				IConsentInformationConsentStatusInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IConsentInformationConsentStatusInvoker.n_AnnotationType));
			}
			return IConsentInformationConsentStatusInvoker.cb_annotationType;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003608 File Offset: 0x00001808
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IConsentInformationConsentStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000361C File Offset: 0x0000181C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000366D File Offset: 0x0000186D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IConsentInformationConsentStatusInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IConsentInformationConsentStatusInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IConsentInformationConsentStatusInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IConsentInformationConsentStatusInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003694 File Offset: 0x00001894
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IConsentInformationConsentStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000036B8 File Offset: 0x000018B8
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

		// Token: 0x060000CF RID: 207 RVA: 0x0000372B File Offset: 0x0000192B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IConsentInformationConsentStatusInvoker.cb_hashCode == null)
			{
				IConsentInformationConsentStatusInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IConsentInformationConsentStatusInvoker.n_GetHashCode));
			}
			return IConsentInformationConsentStatusInvoker.cb_hashCode;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000374F File Offset: 0x0000194F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IConsentInformationConsentStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000375E File Offset: 0x0000195E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000379E File Offset: 0x0000199E
		private static Delegate GetToStringHandler()
		{
			if (IConsentInformationConsentStatusInvoker.cb_toString == null)
			{
				IConsentInformationConsentStatusInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IConsentInformationConsentStatusInvoker.n_ToString));
			}
			return IConsentInformationConsentStatusInvoker.cb_toString;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000037C2 File Offset: 0x000019C2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IConsentInformationConsentStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000037D8 File Offset: 0x000019D8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400003A RID: 58
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentInformation$ConsentStatus", typeof(IConsentInformationConsentStatusInvoker));

		// Token: 0x0400003B RID: 59
		private IntPtr class_ref;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_annotationType;

		// Token: 0x0400003D RID: 61
		private IntPtr id_annotationType;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400003F RID: 63
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_hashCode;

		// Token: 0x04000041 RID: 65
		private IntPtr id_hashCode;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_toString;

		// Token: 0x04000043 RID: 67
		private IntPtr id_toString;
	}
}
