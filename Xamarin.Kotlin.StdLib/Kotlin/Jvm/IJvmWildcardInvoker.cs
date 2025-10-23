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
	// Token: 0x02000169 RID: 361
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmWildcard", DoNotGenerateAcw = true)]
	internal class IJvmWildcardInvoker : Java.Lang.Object, IJvmWildcard, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0003D03C File Offset: 0x0003B23C
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmWildcardInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x0003D060 File Offset: 0x0003B260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmWildcardInvoker._members;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x0003D067 File Offset: 0x0003B267
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x0003D06F File Offset: 0x0003B26F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmWildcardInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0003D07B File Offset: 0x0003B27B
		[NullableContext(2)]
		public static IJvmWildcard GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmWildcard>(handle, transfer);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0003D084 File Offset: 0x0003B284
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmWildcardInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmWildcard'.");
			}
			return handle;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0003D0AF File Offset: 0x0003B2AF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		public IJvmWildcardInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmWildcardInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0003D118 File Offset: 0x0003B318
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmWildcardInvoker.cb_annotationType == null)
			{
				IJvmWildcardInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmWildcardInvoker.n_AnnotationType));
			}
			return IJvmWildcardInvoker.cb_annotationType;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0003D13C File Offset: 0x0003B33C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmWildcard>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0003D150 File Offset: 0x0003B350
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003D1A1 File Offset: 0x0003B3A1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmWildcardInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmWildcardInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmWildcardInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmWildcardInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmWildcard>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0003D1EC File Offset: 0x0003B3EC
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

		// Token: 0x060012A6 RID: 4774 RVA: 0x0003D25F File Offset: 0x0003B45F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmWildcardInvoker.cb_hashCode == null)
			{
				IJvmWildcardInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmWildcardInvoker.n_GetHashCode));
			}
			return IJvmWildcardInvoker.cb_hashCode;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0003D283 File Offset: 0x0003B483
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmWildcard>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0003D292 File Offset: 0x0003B492
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0003D2D2 File Offset: 0x0003B4D2
		private static Delegate GetToStringHandler()
		{
			if (IJvmWildcardInvoker.cb_toString == null)
			{
				IJvmWildcardInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmWildcardInvoker.n_ToString));
			}
			return IJvmWildcardInvoker.cb_toString;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0003D2F6 File Offset: 0x0003B4F6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmWildcard>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0003D30C File Offset: 0x0003B50C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000625 RID: 1573
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmWildcard", typeof(IJvmWildcardInvoker));

		// Token: 0x04000626 RID: 1574
		private IntPtr class_ref;

		// Token: 0x04000627 RID: 1575
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000628 RID: 1576
		private IntPtr id_annotationType;

		// Token: 0x04000629 RID: 1577
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400062A RID: 1578
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400062B RID: 1579
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400062C RID: 1580
		private IntPtr id_hashCode;

		// Token: 0x0400062D RID: 1581
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400062E RID: 1582
		private IntPtr id_toString;
	}
}
