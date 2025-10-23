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
	// Token: 0x0200005C RID: 92
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/DeprecatedSinceKotlin", DoNotGenerateAcw = true)]
	internal class IDeprecatedSinceKotlinInvoker : Java.Lang.Object, IDeprecatedSinceKotlin, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00003F34 File Offset: 0x00002134
		private static IntPtr java_class_ref
		{
			get
			{
				return IDeprecatedSinceKotlinInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00003F58 File Offset: 0x00002158
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IDeprecatedSinceKotlinInvoker._members;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00003F5F File Offset: 0x0000215F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00003F67 File Offset: 0x00002167
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IDeprecatedSinceKotlinInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00003F73 File Offset: 0x00002173
		public static IDeprecatedSinceKotlin GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(handle, transfer);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00003F7C File Offset: 0x0000217C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDeprecatedSinceKotlinInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.DeprecatedSinceKotlin'.");
			}
			return handle;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00003FA7 File Offset: 0x000021A7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00003FD8 File Offset: 0x000021D8
		public IDeprecatedSinceKotlinInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDeprecatedSinceKotlinInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00004010 File Offset: 0x00002210
		[NullableContext(1)]
		private static Delegate GetErrorSinceHandler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_errorSince == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_errorSince = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedSinceKotlinInvoker.n_ErrorSince));
			}
			return IDeprecatedSinceKotlinInvoker.cb_errorSince;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00004034 File Offset: 0x00002234
		private static IntPtr n_ErrorSince(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorSince());
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00004048 File Offset: 0x00002248
		public string ErrorSince()
		{
			if (this.id_errorSince == IntPtr.Zero)
			{
				this.id_errorSince = JNIEnv.GetMethodID(this.class_ref, "errorSince", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_errorSince), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00004099 File Offset: 0x00002299
		[NullableContext(1)]
		private static Delegate GetHiddenSinceHandler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_hiddenSince == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_hiddenSince = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedSinceKotlinInvoker.n_HiddenSince));
			}
			return IDeprecatedSinceKotlinInvoker.cb_hiddenSince;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000040BD File Offset: 0x000022BD
		private static IntPtr n_HiddenSince(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HiddenSince());
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000040D4 File Offset: 0x000022D4
		public string HiddenSince()
		{
			if (this.id_hiddenSince == IntPtr.Zero)
			{
				this.id_hiddenSince = JNIEnv.GetMethodID(this.class_ref, "hiddenSince", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_hiddenSince), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00004125 File Offset: 0x00002325
		[NullableContext(1)]
		private static Delegate GetWarningSinceHandler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_warningSince == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_warningSince = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedSinceKotlinInvoker.n_WarningSince));
			}
			return IDeprecatedSinceKotlinInvoker.cb_warningSince;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004149 File Offset: 0x00002349
		private static IntPtr n_WarningSince(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WarningSince());
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00004160 File Offset: 0x00002360
		public string WarningSince()
		{
			if (this.id_warningSince == IntPtr.Zero)
			{
				this.id_warningSince = JNIEnv.GetMethodID(this.class_ref, "warningSince", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_warningSince), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000041B1 File Offset: 0x000023B1
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_annotationType == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedSinceKotlinInvoker.n_AnnotationType));
			}
			return IDeprecatedSinceKotlinInvoker.cb_annotationType;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000041D5 File Offset: 0x000023D5
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000041EC File Offset: 0x000023EC
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000423D File Offset: 0x0000243D
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDeprecatedSinceKotlinInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IDeprecatedSinceKotlinInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00004264 File Offset: 0x00002464
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00004288 File Offset: 0x00002488
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

		// Token: 0x060001C7 RID: 455 RVA: 0x000042FB File Offset: 0x000024FB
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_hashCode == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDeprecatedSinceKotlinInvoker.n_GetHashCode));
			}
			return IDeprecatedSinceKotlinInvoker.cb_hashCode;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000431F File Offset: 0x0000251F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000432E File Offset: 0x0000252E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000436E File Offset: 0x0000256E
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IDeprecatedSinceKotlinInvoker.cb_toString == null)
			{
				IDeprecatedSinceKotlinInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedSinceKotlinInvoker.n_ToString));
			}
			return IDeprecatedSinceKotlinInvoker.cb_toString;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004392 File Offset: 0x00002592
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDeprecatedSinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000043A8 File Offset: 0x000025A8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000046 RID: 70
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DeprecatedSinceKotlin", typeof(IDeprecatedSinceKotlinInvoker));

		// Token: 0x04000047 RID: 71
		private IntPtr class_ref;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_errorSince;

		// Token: 0x04000049 RID: 73
		private IntPtr id_errorSince;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_hiddenSince;

		// Token: 0x0400004B RID: 75
		private IntPtr id_hiddenSince;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_warningSince;

		// Token: 0x0400004D RID: 77
		private IntPtr id_warningSince;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_annotationType;

		// Token: 0x0400004F RID: 79
		private IntPtr id_annotationType;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000051 RID: 81
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_hashCode;

		// Token: 0x04000053 RID: 83
		private IntPtr id_hashCode;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_toString;

		// Token: 0x04000055 RID: 85
		private IntPtr id_toString;
	}
}
