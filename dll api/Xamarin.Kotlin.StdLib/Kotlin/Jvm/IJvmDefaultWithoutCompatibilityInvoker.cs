using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000153 RID: 339
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmDefaultWithoutCompatibility", DoNotGenerateAcw = true)]
	internal class IJvmDefaultWithoutCompatibilityInvoker : Java.Lang.Object, IJvmDefaultWithoutCompatibility, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0003ABA8 File Offset: 0x00038DA8
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmDefaultWithoutCompatibilityInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0003ABCC File Offset: 0x00038DCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmDefaultWithoutCompatibilityInvoker._members;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0003ABD3 File Offset: 0x00038DD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x0003ABDB File Offset: 0x00038DDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmDefaultWithoutCompatibilityInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0003ABE7 File Offset: 0x00038DE7
		[NullableContext(2)]
		public static IJvmDefaultWithoutCompatibility GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmDefaultWithoutCompatibility>(handle, transfer);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0003ABF0 File Offset: 0x00038DF0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmDefaultWithoutCompatibilityInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmDefaultWithoutCompatibility'.");
			}
			return handle;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0003AC1B File Offset: 0x00038E1B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0003AC4C File Offset: 0x00038E4C
		public IJvmDefaultWithoutCompatibilityInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmDefaultWithoutCompatibilityInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0003AC84 File Offset: 0x00038E84
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmDefaultWithoutCompatibilityInvoker.cb_annotationType == null)
			{
				IJvmDefaultWithoutCompatibilityInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmDefaultWithoutCompatibilityInvoker.n_AnnotationType));
			}
			return IJvmDefaultWithoutCompatibilityInvoker.cb_annotationType;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0003ACA8 File Offset: 0x00038EA8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmDefaultWithoutCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0003ACBC File Offset: 0x00038EBC
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0003AD0D File Offset: 0x00038F0D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmDefaultWithoutCompatibilityInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmDefaultWithoutCompatibilityInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmDefaultWithoutCompatibilityInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmDefaultWithoutCompatibilityInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0003AD34 File Offset: 0x00038F34
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmDefaultWithoutCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0003AD58 File Offset: 0x00038F58
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

		// Token: 0x060011B7 RID: 4535 RVA: 0x0003ADCB File Offset: 0x00038FCB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmDefaultWithoutCompatibilityInvoker.cb_hashCode == null)
			{
				IJvmDefaultWithoutCompatibilityInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmDefaultWithoutCompatibilityInvoker.n_GetHashCode));
			}
			return IJvmDefaultWithoutCompatibilityInvoker.cb_hashCode;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0003ADEF File Offset: 0x00038FEF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmDefaultWithoutCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0003ADFE File Offset: 0x00038FFE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0003AE3E File Offset: 0x0003903E
		private static Delegate GetToStringHandler()
		{
			if (IJvmDefaultWithoutCompatibilityInvoker.cb_toString == null)
			{
				IJvmDefaultWithoutCompatibilityInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmDefaultWithoutCompatibilityInvoker.n_ToString));
			}
			return IJvmDefaultWithoutCompatibilityInvoker.cb_toString;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0003AE62 File Offset: 0x00039062
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmDefaultWithoutCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0003AE78 File Offset: 0x00039078
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005B3 RID: 1459
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmDefaultWithoutCompatibility", typeof(IJvmDefaultWithoutCompatibilityInvoker));

		// Token: 0x040005B4 RID: 1460
		private IntPtr class_ref;

		// Token: 0x040005B5 RID: 1461
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005B6 RID: 1462
		private IntPtr id_annotationType;

		// Token: 0x040005B7 RID: 1463
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005B8 RID: 1464
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005B9 RID: 1465
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005BA RID: 1466
		private IntPtr id_hashCode;

		// Token: 0x040005BB RID: 1467
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005BC RID: 1468
		private IntPtr id_toString;
	}
}
