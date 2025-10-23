using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C5 RID: 197
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/IntKey", DoNotGenerateAcw = true)]
	internal class IIntKeyInvoker : Java.Lang.Object, IIntKey, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001428C File Offset: 0x0001248C
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x000142B0 File Offset: 0x000124B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntKeyInvoker._members;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x000142B7 File Offset: 0x000124B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000142BF File Offset: 0x000124BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000142CB File Offset: 0x000124CB
		public static IIntKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIntKey>(handle, transfer);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000142D4 File Offset: 0x000124D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.IntKey'.");
			}
			return handle;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000142FF File Offset: 0x000124FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00014330 File Offset: 0x00012530
		public IIntKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00014368 File Offset: 0x00012568
		private static Delegate GetValueHandler()
		{
			if (IIntKeyInvoker.cb_value == null)
			{
				IIntKeyInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IIntKeyInvoker.n_Value));
			}
			return IIntKeyInvoker.cb_value;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001438C File Offset: 0x0001258C
		private static int n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIntKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value();
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001439B File Offset: 0x0001259B
		public int Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_value);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000143DB File Offset: 0x000125DB
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IIntKeyInvoker.cb_annotationType == null)
			{
				IIntKeyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIntKeyInvoker.n_AnnotationType));
			}
			return IIntKeyInvoker.cb_annotationType;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000143FF File Offset: 0x000125FF
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIntKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00014414 File Offset: 0x00012614
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00014465 File Offset: 0x00012665
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IIntKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IIntKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IIntKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IIntKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001448C File Offset: 0x0001268C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IIntKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000144B0 File Offset: 0x000126B0
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

		// Token: 0x06000721 RID: 1825 RVA: 0x00014523 File Offset: 0x00012723
		private static Delegate GetGetHashCodeHandler()
		{
			if (IIntKeyInvoker.cb_hashCode == null)
			{
				IIntKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IIntKeyInvoker.n_GetHashCode));
			}
			return IIntKeyInvoker.cb_hashCode;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00014547 File Offset: 0x00012747
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIntKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00014556 File Offset: 0x00012756
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00014596 File Offset: 0x00012796
		private static Delegate GetToStringHandler()
		{
			if (IIntKeyInvoker.cb_toString == null)
			{
				IIntKeyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIntKeyInvoker.n_ToString));
			}
			return IIntKeyInvoker.cb_toString;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000145BA File Offset: 0x000127BA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IIntKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000145D0 File Offset: 0x000127D0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001E2 RID: 482
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/IntKey", typeof(IIntKeyInvoker));

		// Token: 0x040001E3 RID: 483
		private IntPtr class_ref;

		// Token: 0x040001E4 RID: 484
		private static Delegate cb_value;

		// Token: 0x040001E5 RID: 485
		private IntPtr id_value;

		// Token: 0x040001E6 RID: 486
		private static Delegate cb_annotationType;

		// Token: 0x040001E7 RID: 487
		private IntPtr id_annotationType;

		// Token: 0x040001E8 RID: 488
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001E9 RID: 489
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001EA RID: 490
		private static Delegate cb_hashCode;

		// Token: 0x040001EB RID: 491
		private IntPtr id_hashCode;

		// Token: 0x040001EC RID: 492
		private static Delegate cb_toString;

		// Token: 0x040001ED RID: 493
		private IntPtr id_toString;
	}
}
