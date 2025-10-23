using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200003A RID: 58
	[Register("com/google/errorprone/annotations/SuppressPackageLocation", DoNotGenerateAcw = true)]
	internal class ISuppressPackageLocationInvoker : Java.Lang.Object, ISuppressPackageLocation, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000066E0 File Offset: 0x000048E0
		private static IntPtr java_class_ref
		{
			get
			{
				return ISuppressPackageLocationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00006704 File Offset: 0x00004904
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISuppressPackageLocationInvoker._members;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000670B File Offset: 0x0000490B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00006713 File Offset: 0x00004913
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISuppressPackageLocationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000671F File Offset: 0x0000491F
		public static ISuppressPackageLocation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISuppressPackageLocation>(handle, transfer);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00006728 File Offset: 0x00004928
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISuppressPackageLocationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.SuppressPackageLocation'.");
			}
			return handle;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00006753 File Offset: 0x00004953
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006784 File Offset: 0x00004984
		public ISuppressPackageLocationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISuppressPackageLocationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000067BC File Offset: 0x000049BC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISuppressPackageLocationInvoker.cb_annotationType == null)
			{
				ISuppressPackageLocationInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISuppressPackageLocationInvoker.n_AnnotationType));
			}
			return ISuppressPackageLocationInvoker.cb_annotationType;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000067E0 File Offset: 0x000049E0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISuppressPackageLocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000067F4 File Offset: 0x000049F4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006845 File Offset: 0x00004A45
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISuppressPackageLocationInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISuppressPackageLocationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISuppressPackageLocationInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISuppressPackageLocationInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000686C File Offset: 0x00004A6C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISuppressPackageLocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00006890 File Offset: 0x00004A90
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

		// Token: 0x06000204 RID: 516 RVA: 0x00006903 File Offset: 0x00004B03
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISuppressPackageLocationInvoker.cb_hashCode == null)
			{
				ISuppressPackageLocationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISuppressPackageLocationInvoker.n_GetHashCode));
			}
			return ISuppressPackageLocationInvoker.cb_hashCode;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00006927 File Offset: 0x00004B27
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISuppressPackageLocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00006936 File Offset: 0x00004B36
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00006976 File Offset: 0x00004B76
		private static Delegate GetToStringHandler()
		{
			if (ISuppressPackageLocationInvoker.cb_toString == null)
			{
				ISuppressPackageLocationInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISuppressPackageLocationInvoker.n_ToString));
			}
			return ISuppressPackageLocationInvoker.cb_toString;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000699A File Offset: 0x00004B9A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISuppressPackageLocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000069B0 File Offset: 0x00004BB0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000E5 RID: 229
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/SuppressPackageLocation", typeof(ISuppressPackageLocationInvoker));

		// Token: 0x040000E6 RID: 230
		private IntPtr class_ref;

		// Token: 0x040000E7 RID: 231
		private static Delegate cb_annotationType;

		// Token: 0x040000E8 RID: 232
		private IntPtr id_annotationType;

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000EA RID: 234
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000EB RID: 235
		private static Delegate cb_hashCode;

		// Token: 0x040000EC RID: 236
		private IntPtr id_hashCode;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_toString;

		// Token: 0x040000EE RID: 238
		private IntPtr id_toString;
	}
}
