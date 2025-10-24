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
	// Token: 0x0200015F RID: 351
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmRecord", DoNotGenerateAcw = true)]
	internal class IJvmRecordInvoker : Java.Lang.Object, IJvmRecord, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0003BF9C File Offset: 0x0003A19C
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmRecordInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0003BFC0 File Offset: 0x0003A1C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmRecordInvoker._members;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0003BFC7 File Offset: 0x0003A1C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0003BFCF File Offset: 0x0003A1CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmRecordInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0003BFDB File Offset: 0x0003A1DB
		[NullableContext(2)]
		public static IJvmRecord GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmRecord>(handle, transfer);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0003BFE4 File Offset: 0x0003A1E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmRecordInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmRecord'.");
			}
			return handle;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0003C00F File Offset: 0x0003A20F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0003C040 File Offset: 0x0003A240
		public IJvmRecordInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmRecordInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0003C078 File Offset: 0x0003A278
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmRecordInvoker.cb_annotationType == null)
			{
				IJvmRecordInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmRecordInvoker.n_AnnotationType));
			}
			return IJvmRecordInvoker.cb_annotationType;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0003C09C File Offset: 0x0003A29C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmRecord>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0003C101 File Offset: 0x0003A301
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmRecordInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmRecordInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmRecordInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmRecordInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0003C128 File Offset: 0x0003A328
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmRecord>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0003C14C File Offset: 0x0003A34C
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

		// Token: 0x06001239 RID: 4665 RVA: 0x0003C1BF File Offset: 0x0003A3BF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmRecordInvoker.cb_hashCode == null)
			{
				IJvmRecordInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmRecordInvoker.n_GetHashCode));
			}
			return IJvmRecordInvoker.cb_hashCode;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0003C1E3 File Offset: 0x0003A3E3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmRecord>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0003C1F2 File Offset: 0x0003A3F2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0003C232 File Offset: 0x0003A432
		private static Delegate GetToStringHandler()
		{
			if (IJvmRecordInvoker.cb_toString == null)
			{
				IJvmRecordInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmRecordInvoker.n_ToString));
			}
			return IJvmRecordInvoker.cb_toString;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0003C256 File Offset: 0x0003A456
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmRecord>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0003C26C File Offset: 0x0003A46C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005F1 RID: 1521
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmRecord", typeof(IJvmRecordInvoker));

		// Token: 0x040005F2 RID: 1522
		private IntPtr class_ref;

		// Token: 0x040005F3 RID: 1523
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005F4 RID: 1524
		private IntPtr id_annotationType;

		// Token: 0x040005F5 RID: 1525
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005F6 RID: 1526
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005F7 RID: 1527
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005F8 RID: 1528
		private IntPtr id_hashCode;

		// Token: 0x040005F9 RID: 1529
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005FA RID: 1530
		private IntPtr id_toString;
	}
}
