using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000CD RID: 205
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/Multibinds", DoNotGenerateAcw = true)]
	internal class IMultibindsInvoker : Java.Lang.Object, IMultibinds, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00015064 File Offset: 0x00013264
		private static IntPtr java_class_ref
		{
			get
			{
				return IMultibindsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00015088 File Offset: 0x00013288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMultibindsInvoker._members;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0001508F File Offset: 0x0001328F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00015097 File Offset: 0x00013297
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMultibindsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000150A3 File Offset: 0x000132A3
		public static IMultibinds GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMultibinds>(handle, transfer);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000150AC File Offset: 0x000132AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMultibindsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.Multibinds'.");
			}
			return handle;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000150D7 File Offset: 0x000132D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00015108 File Offset: 0x00013308
		public IMultibindsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMultibindsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00015140 File Offset: 0x00013340
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMultibindsInvoker.cb_annotationType == null)
			{
				IMultibindsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMultibindsInvoker.n_AnnotationType));
			}
			return IMultibindsInvoker.cb_annotationType;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00015164 File Offset: 0x00013364
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMultibinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00015178 File Offset: 0x00013378
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000151C9 File Offset: 0x000133C9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMultibindsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMultibindsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMultibindsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMultibindsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000151F0 File Offset: 0x000133F0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMultibinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00015214 File Offset: 0x00013414
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

		// Token: 0x06000779 RID: 1913 RVA: 0x00015287 File Offset: 0x00013487
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMultibindsInvoker.cb_hashCode == null)
			{
				IMultibindsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMultibindsInvoker.n_GetHashCode));
			}
			return IMultibindsInvoker.cb_hashCode;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000152AB File Offset: 0x000134AB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMultibinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000152BA File Offset: 0x000134BA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000152FA File Offset: 0x000134FA
		private static Delegate GetToStringHandler()
		{
			if (IMultibindsInvoker.cb_toString == null)
			{
				IMultibindsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMultibindsInvoker.n_ToString));
			}
			return IMultibindsInvoker.cb_toString;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001531E File Offset: 0x0001351E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMultibinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00015334 File Offset: 0x00013534
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400020E RID: 526
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/Multibinds", typeof(IMultibindsInvoker));

		// Token: 0x0400020F RID: 527
		private IntPtr class_ref;

		// Token: 0x04000210 RID: 528
		private static Delegate cb_annotationType;

		// Token: 0x04000211 RID: 529
		private IntPtr id_annotationType;

		// Token: 0x04000212 RID: 530
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000213 RID: 531
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000214 RID: 532
		private static Delegate cb_hashCode;

		// Token: 0x04000215 RID: 533
		private IntPtr id_hashCode;

		// Token: 0x04000216 RID: 534
		private static Delegate cb_toString;

		// Token: 0x04000217 RID: 535
		private IntPtr id_toString;
	}
}
