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
	// Token: 0x02000073 RID: 115
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/OptionalExpectation", DoNotGenerateAcw = true)]
	internal class IOptionalExpectationInvoker : Java.Lang.Object, IOptionalExpectation, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00006658 File Offset: 0x00004858
		private static IntPtr java_class_ref
		{
			get
			{
				return IOptionalExpectationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000667C File Offset: 0x0000487C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOptionalExpectationInvoker._members;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00006683 File Offset: 0x00004883
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000668B File Offset: 0x0000488B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOptionalExpectationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00006697 File Offset: 0x00004897
		[NullableContext(2)]
		public static IOptionalExpectation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOptionalExpectation>(handle, transfer);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000066A0 File Offset: 0x000048A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOptionalExpectationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.OptionalExpectation'.");
			}
			return handle;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000066CB File Offset: 0x000048CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000066FC File Offset: 0x000048FC
		public IOptionalExpectationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOptionalExpectationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00006734 File Offset: 0x00004934
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IOptionalExpectationInvoker.cb_annotationType == null)
			{
				IOptionalExpectationInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOptionalExpectationInvoker.n_AnnotationType));
			}
			return IOptionalExpectationInvoker.cb_annotationType;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00006758 File Offset: 0x00004958
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOptionalExpectation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000676C File Offset: 0x0000496C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000067BD File Offset: 0x000049BD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IOptionalExpectationInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IOptionalExpectationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IOptionalExpectationInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IOptionalExpectationInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000067E4 File Offset: 0x000049E4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IOptionalExpectation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00006808 File Offset: 0x00004A08
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

		// Token: 0x060002C8 RID: 712 RVA: 0x0000687B File Offset: 0x00004A7B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IOptionalExpectationInvoker.cb_hashCode == null)
			{
				IOptionalExpectationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IOptionalExpectationInvoker.n_GetHashCode));
			}
			return IOptionalExpectationInvoker.cb_hashCode;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000689F File Offset: 0x00004A9F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IOptionalExpectation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000068AE File Offset: 0x00004AAE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000068EE File Offset: 0x00004AEE
		private static Delegate GetToStringHandler()
		{
			if (IOptionalExpectationInvoker.cb_toString == null)
			{
				IOptionalExpectationInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOptionalExpectationInvoker.n_ToString));
			}
			return IOptionalExpectationInvoker.cb_toString;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00006912 File Offset: 0x00004B12
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IOptionalExpectation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00006928 File Offset: 0x00004B28
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000C1 RID: 193
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/OptionalExpectation", typeof(IOptionalExpectationInvoker));

		// Token: 0x040000C2 RID: 194
		private IntPtr class_ref;

		// Token: 0x040000C3 RID: 195
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000C4 RID: 196
		private IntPtr id_annotationType;

		// Token: 0x040000C5 RID: 197
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000C6 RID: 198
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000C7 RID: 199
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000C8 RID: 200
		private IntPtr id_hashCode;

		// Token: 0x040000C9 RID: 201
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000CA RID: 202
		private IntPtr id_toString;
	}
}
