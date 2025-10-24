using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E2 RID: 226
	[Register("com/google/android/datatransport/runtime/dagger/internal/ComponentDefinitionType", DoNotGenerateAcw = true)]
	internal class IComponentDefinitionTypeInvoker : Java.Lang.Object, IComponentDefinitionType, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00016498 File Offset: 0x00014698
		private static IntPtr java_class_ref
		{
			get
			{
				return IComponentDefinitionTypeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000164BC File Offset: 0x000146BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComponentDefinitionTypeInvoker._members;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000164C3 File Offset: 0x000146C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000164CB File Offset: 0x000146CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComponentDefinitionTypeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000164D7 File Offset: 0x000146D7
		public static IComponentDefinitionType GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IComponentDefinitionType>(handle, transfer);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000164E0 File Offset: 0x000146E0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComponentDefinitionTypeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.internal.ComponentDefinitionType'.");
			}
			return handle;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0001650B File Offset: 0x0001470B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0001653C File Offset: 0x0001473C
		public IComponentDefinitionTypeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComponentDefinitionTypeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00016574 File Offset: 0x00014774
		private static Delegate GetValueHandler()
		{
			if (IComponentDefinitionTypeInvoker.cb_value == null)
			{
				IComponentDefinitionTypeInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentDefinitionTypeInvoker.n_Value));
			}
			return IComponentDefinitionTypeInvoker.cb_value;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00016598 File Offset: 0x00014798
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComponentDefinitionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000165AC File Offset: 0x000147AC
		public Class Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000165FD File Offset: 0x000147FD
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IComponentDefinitionTypeInvoker.cb_annotationType == null)
			{
				IComponentDefinitionTypeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentDefinitionTypeInvoker.n_AnnotationType));
			}
			return IComponentDefinitionTypeInvoker.cb_annotationType;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00016621 File Offset: 0x00014821
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComponentDefinitionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00016638 File Offset: 0x00014838
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00016689 File Offset: 0x00014889
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IComponentDefinitionTypeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IComponentDefinitionTypeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IComponentDefinitionTypeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IComponentDefinitionTypeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000166B0 File Offset: 0x000148B0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IComponentDefinitionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000166D4 File Offset: 0x000148D4
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

		// Token: 0x06000808 RID: 2056 RVA: 0x00016747 File Offset: 0x00014947
		private static Delegate GetGetHashCodeHandler()
		{
			if (IComponentDefinitionTypeInvoker.cb_hashCode == null)
			{
				IComponentDefinitionTypeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IComponentDefinitionTypeInvoker.n_GetHashCode));
			}
			return IComponentDefinitionTypeInvoker.cb_hashCode;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0001676B File Offset: 0x0001496B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComponentDefinitionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0001677A File Offset: 0x0001497A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000167BA File Offset: 0x000149BA
		private static Delegate GetToStringHandler()
		{
			if (IComponentDefinitionTypeInvoker.cb_toString == null)
			{
				IComponentDefinitionTypeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentDefinitionTypeInvoker.n_ToString));
			}
			return IComponentDefinitionTypeInvoker.cb_toString;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000167DE File Offset: 0x000149DE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IComponentDefinitionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000167F4 File Offset: 0x000149F4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000238 RID: 568
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/ComponentDefinitionType", typeof(IComponentDefinitionTypeInvoker));

		// Token: 0x04000239 RID: 569
		private IntPtr class_ref;

		// Token: 0x0400023A RID: 570
		private static Delegate cb_value;

		// Token: 0x0400023B RID: 571
		private IntPtr id_value;

		// Token: 0x0400023C RID: 572
		private static Delegate cb_annotationType;

		// Token: 0x0400023D RID: 573
		private IntPtr id_annotationType;

		// Token: 0x0400023E RID: 574
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400023F RID: 575
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000240 RID: 576
		private static Delegate cb_hashCode;

		// Token: 0x04000241 RID: 577
		private IntPtr id_hashCode;

		// Token: 0x04000242 RID: 578
		private static Delegate cb_toString;

		// Token: 0x04000243 RID: 579
		private IntPtr id_toString;
	}
}
