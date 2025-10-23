using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000D2 RID: 210
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/StringKey", DoNotGenerateAcw = true)]
	internal class IStringKeyInvoker : Java.Lang.Object, IStringKey, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000153B4 File Offset: 0x000135B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IStringKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000153D8 File Offset: 0x000135D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IStringKeyInvoker._members;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000153DF File Offset: 0x000135DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000153E7 File Offset: 0x000135E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IStringKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000153F3 File Offset: 0x000135F3
		public static IStringKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IStringKey>(handle, transfer);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000153FC File Offset: 0x000135FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IStringKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.StringKey'.");
			}
			return handle;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00015427 File Offset: 0x00013627
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00015458 File Offset: 0x00013658
		public IStringKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IStringKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00015490 File Offset: 0x00013690
		private static Delegate GetValueHandler()
		{
			if (IStringKeyInvoker.cb_value == null)
			{
				IStringKeyInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStringKeyInvoker.n_Value));
			}
			return IStringKeyInvoker.cb_value;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000154B4 File Offset: 0x000136B4
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IStringKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000154C8 File Offset: 0x000136C8
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00015519 File Offset: 0x00013719
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IStringKeyInvoker.cb_annotationType == null)
			{
				IStringKeyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStringKeyInvoker.n_AnnotationType));
			}
			return IStringKeyInvoker.cb_annotationType;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001553D File Offset: 0x0001373D
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IStringKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00015554 File Offset: 0x00013754
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000155A5 File Offset: 0x000137A5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IStringKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IStringKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IStringKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IStringKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000155CC File Offset: 0x000137CC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IStringKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000155F0 File Offset: 0x000137F0
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

		// Token: 0x06000797 RID: 1943 RVA: 0x00015663 File Offset: 0x00013863
		private static Delegate GetGetHashCodeHandler()
		{
			if (IStringKeyInvoker.cb_hashCode == null)
			{
				IStringKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IStringKeyInvoker.n_GetHashCode));
			}
			return IStringKeyInvoker.cb_hashCode;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00015687 File Offset: 0x00013887
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IStringKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00015696 File Offset: 0x00013896
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000156D6 File Offset: 0x000138D6
		private static Delegate GetToStringHandler()
		{
			if (IStringKeyInvoker.cb_toString == null)
			{
				IStringKeyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStringKeyInvoker.n_ToString));
			}
			return IStringKeyInvoker.cb_toString;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000156FA File Offset: 0x000138FA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IStringKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00015710 File Offset: 0x00013910
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000219 RID: 537
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/StringKey", typeof(IStringKeyInvoker));

		// Token: 0x0400021A RID: 538
		private IntPtr class_ref;

		// Token: 0x0400021B RID: 539
		private static Delegate cb_value;

		// Token: 0x0400021C RID: 540
		private IntPtr id_value;

		// Token: 0x0400021D RID: 541
		private static Delegate cb_annotationType;

		// Token: 0x0400021E RID: 542
		private IntPtr id_annotationType;

		// Token: 0x0400021F RID: 543
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000220 RID: 544
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000221 RID: 545
		private static Delegate cb_hashCode;

		// Token: 0x04000222 RID: 546
		private IntPtr id_hashCode;

		// Token: 0x04000223 RID: 547
		private static Delegate cb_toString;

		// Token: 0x04000224 RID: 548
		private IntPtr id_toString;
	}
}
