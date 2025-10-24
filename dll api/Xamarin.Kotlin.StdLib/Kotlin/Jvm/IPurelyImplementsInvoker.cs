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
	// Token: 0x0200016B RID: 363
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/PurelyImplements", DoNotGenerateAcw = true)]
	internal class IPurelyImplementsInvoker : Java.Lang.Object, IPurelyImplements, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0003D378 File Offset: 0x0003B578
		private static IntPtr java_class_ref
		{
			get
			{
				return IPurelyImplementsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0003D39C File Offset: 0x0003B59C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPurelyImplementsInvoker._members;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0003D3A3 File Offset: 0x0003B5A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0003D3AB File Offset: 0x0003B5AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPurelyImplementsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003D3B7 File Offset: 0x0003B5B7
		[NullableContext(2)]
		public static IPurelyImplements GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPurelyImplements>(handle, transfer);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPurelyImplementsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.PurelyImplements'.");
			}
			return handle;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0003D3EB File Offset: 0x0003B5EB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0003D41C File Offset: 0x0003B61C
		public IPurelyImplementsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPurelyImplementsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003D454 File Offset: 0x0003B654
		private static Delegate GetValueHandler()
		{
			if (IPurelyImplementsInvoker.cb_value == null)
			{
				IPurelyImplementsInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPurelyImplementsInvoker.n_Value));
			}
			return IPurelyImplementsInvoker.cb_value;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0003D478 File Offset: 0x0003B678
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPurelyImplements>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0003D48C File Offset: 0x0003B68C
		[NullableContext(2)]
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0003D4DD File Offset: 0x0003B6DD
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IPurelyImplementsInvoker.cb_annotationType == null)
			{
				IPurelyImplementsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPurelyImplementsInvoker.n_AnnotationType));
			}
			return IPurelyImplementsInvoker.cb_annotationType;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0003D501 File Offset: 0x0003B701
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPurelyImplements>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0003D518 File Offset: 0x0003B718
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0003D569 File Offset: 0x0003B769
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IPurelyImplementsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IPurelyImplementsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPurelyImplementsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IPurelyImplementsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0003D590 File Offset: 0x0003B790
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IPurelyImplements>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0003D5B4 File Offset: 0x0003B7B4
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

		// Token: 0x060012BF RID: 4799 RVA: 0x0003D627 File Offset: 0x0003B827
		private static Delegate GetGetHashCodeHandler()
		{
			if (IPurelyImplementsInvoker.cb_hashCode == null)
			{
				IPurelyImplementsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPurelyImplementsInvoker.n_GetHashCode));
			}
			return IPurelyImplementsInvoker.cb_hashCode;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0003D64B File Offset: 0x0003B84B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPurelyImplements>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0003D65A File Offset: 0x0003B85A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0003D69A File Offset: 0x0003B89A
		private static Delegate GetToStringHandler()
		{
			if (IPurelyImplementsInvoker.cb_toString == null)
			{
				IPurelyImplementsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPurelyImplementsInvoker.n_ToString));
			}
			return IPurelyImplementsInvoker.cb_toString;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0003D6BE File Offset: 0x0003B8BE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPurelyImplements>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400062F RID: 1583
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/PurelyImplements", typeof(IPurelyImplementsInvoker));

		// Token: 0x04000630 RID: 1584
		private IntPtr class_ref;

		// Token: 0x04000631 RID: 1585
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x04000632 RID: 1586
		private IntPtr id_value;

		// Token: 0x04000633 RID: 1587
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000634 RID: 1588
		private IntPtr id_annotationType;

		// Token: 0x04000635 RID: 1589
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000636 RID: 1590
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000637 RID: 1591
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000638 RID: 1592
		private IntPtr id_hashCode;

		// Token: 0x04000639 RID: 1593
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400063A RID: 1594
		private IntPtr id_toString;
	}
}
