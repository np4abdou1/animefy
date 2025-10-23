using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C1 RID: 193
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/ClassKey", DoNotGenerateAcw = true)]
	internal class IClassKeyInvoker : Java.Lang.Object, IClassKey, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00013B88 File Offset: 0x00011D88
		private static IntPtr java_class_ref
		{
			get
			{
				return IClassKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00013BAC File Offset: 0x00011DAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IClassKeyInvoker._members;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00013BB3 File Offset: 0x00011DB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00013BBB File Offset: 0x00011DBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IClassKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00013BC7 File Offset: 0x00011DC7
		public static IClassKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IClassKey>(handle, transfer);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00013BD0 File Offset: 0x00011DD0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IClassKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.ClassKey'.");
			}
			return handle;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00013BFB File Offset: 0x00011DFB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00013C2C File Offset: 0x00011E2C
		public IClassKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IClassKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00013C64 File Offset: 0x00011E64
		private static Delegate GetValueHandler()
		{
			if (IClassKeyInvoker.cb_value == null)
			{
				IClassKeyInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClassKeyInvoker.n_Value));
			}
			return IClassKeyInvoker.cb_value;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00013C88 File Offset: 0x00011E88
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00013C9C File Offset: 0x00011E9C
		public Class Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00013CED File Offset: 0x00011EED
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IClassKeyInvoker.cb_annotationType == null)
			{
				IClassKeyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClassKeyInvoker.n_AnnotationType));
			}
			return IClassKeyInvoker.cb_annotationType;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00013D11 File Offset: 0x00011F11
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00013D28 File Offset: 0x00011F28
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00013D79 File Offset: 0x00011F79
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IClassKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IClassKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IClassKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IClassKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00013DA0 File Offset: 0x00011FA0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00013DC4 File Offset: 0x00011FC4
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

		// Token: 0x060006F3 RID: 1779 RVA: 0x00013E37 File Offset: 0x00012037
		private static Delegate GetGetHashCodeHandler()
		{
			if (IClassKeyInvoker.cb_hashCode == null)
			{
				IClassKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IClassKeyInvoker.n_GetHashCode));
			}
			return IClassKeyInvoker.cb_hashCode;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00013E5B File Offset: 0x0001205B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00013E6A File Offset: 0x0001206A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00013EAA File Offset: 0x000120AA
		private static Delegate GetToStringHandler()
		{
			if (IClassKeyInvoker.cb_toString == null)
			{
				IClassKeyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClassKeyInvoker.n_ToString));
			}
			return IClassKeyInvoker.cb_toString;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00013ECE File Offset: 0x000120CE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00013EE4 File Offset: 0x000120E4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001CC RID: 460
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/ClassKey", typeof(IClassKeyInvoker));

		// Token: 0x040001CD RID: 461
		private IntPtr class_ref;

		// Token: 0x040001CE RID: 462
		private static Delegate cb_value;

		// Token: 0x040001CF RID: 463
		private IntPtr id_value;

		// Token: 0x040001D0 RID: 464
		private static Delegate cb_annotationType;

		// Token: 0x040001D1 RID: 465
		private IntPtr id_annotationType;

		// Token: 0x040001D2 RID: 466
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001D3 RID: 467
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001D4 RID: 468
		private static Delegate cb_hashCode;

		// Token: 0x040001D5 RID: 469
		private IntPtr id_hashCode;

		// Token: 0x040001D6 RID: 470
		private static Delegate cb_toString;

		// Token: 0x040001D7 RID: 471
		private IntPtr id_toString;
	}
}
