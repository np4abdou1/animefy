using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200001C RID: 28
	[Register("com/google/errorprone/annotations/FormatMethod", DoNotGenerateAcw = true)]
	internal class IFormatMethodInvoker : Java.Lang.Object, IFormatMethod, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003598 File Offset: 0x00001798
		private static IntPtr java_class_ref
		{
			get
			{
				return IFormatMethodInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000035BC File Offset: 0x000017BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFormatMethodInvoker._members;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000035C3 File Offset: 0x000017C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000035CB File Offset: 0x000017CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFormatMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000035D7 File Offset: 0x000017D7
		public static IFormatMethod GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFormatMethod>(handle, transfer);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000035E0 File Offset: 0x000017E0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFormatMethodInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.FormatMethod'.");
			}
			return handle;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000360B File Offset: 0x0000180B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000363C File Offset: 0x0000183C
		public IFormatMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFormatMethodInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003674 File Offset: 0x00001874
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IFormatMethodInvoker.cb_annotationType == null)
			{
				IFormatMethodInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFormatMethodInvoker.n_AnnotationType));
			}
			return IFormatMethodInvoker.cb_annotationType;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003698 File Offset: 0x00001898
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFormatMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000036AC File Offset: 0x000018AC
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000036FD File Offset: 0x000018FD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IFormatMethodInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IFormatMethodInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IFormatMethodInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IFormatMethodInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003724 File Offset: 0x00001924
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IFormatMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003748 File Offset: 0x00001948
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

		// Token: 0x060000B5 RID: 181 RVA: 0x000037BB File Offset: 0x000019BB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IFormatMethodInvoker.cb_hashCode == null)
			{
				IFormatMethodInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IFormatMethodInvoker.n_GetHashCode));
			}
			return IFormatMethodInvoker.cb_hashCode;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000037DF File Offset: 0x000019DF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFormatMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000037EE File Offset: 0x000019EE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000382E File Offset: 0x00001A2E
		private static Delegate GetToStringHandler()
		{
			if (IFormatMethodInvoker.cb_toString == null)
			{
				IFormatMethodInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFormatMethodInvoker.n_ToString));
			}
			return IFormatMethodInvoker.cb_toString;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003852 File Offset: 0x00001A52
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFormatMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003868 File Offset: 0x00001A68
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000046 RID: 70
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/FormatMethod", typeof(IFormatMethodInvoker));

		// Token: 0x04000047 RID: 71
		private IntPtr class_ref;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_annotationType;

		// Token: 0x04000049 RID: 73
		private IntPtr id_annotationType;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400004B RID: 75
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_hashCode;

		// Token: 0x0400004D RID: 77
		private IntPtr id_hashCode;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_toString;

		// Token: 0x0400004F RID: 79
		private IntPtr id_toString;
	}
}
