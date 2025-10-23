using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C7 RID: 199
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/IntoMap", DoNotGenerateAcw = true)]
	internal class IIntoMapInvoker : Java.Lang.Object, IIntoMap, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0001463C File Offset: 0x0001283C
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntoMapInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00014660 File Offset: 0x00012860
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntoMapInvoker._members;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00014667 File Offset: 0x00012867
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x0001466F File Offset: 0x0001286F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntoMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001467B File Offset: 0x0001287B
		public static IIntoMap GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIntoMap>(handle, transfer);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00014684 File Offset: 0x00012884
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntoMapInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.IntoMap'.");
			}
			return handle;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000146AF File Offset: 0x000128AF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000146E0 File Offset: 0x000128E0
		public IIntoMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntoMapInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00014718 File Offset: 0x00012918
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IIntoMapInvoker.cb_annotationType == null)
			{
				IIntoMapInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIntoMapInvoker.n_AnnotationType));
			}
			return IIntoMapInvoker.cb_annotationType;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001473C File Offset: 0x0001293C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIntoMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00014750 File Offset: 0x00012950
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000147A1 File Offset: 0x000129A1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IIntoMapInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IIntoMapInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IIntoMapInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IIntoMapInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000147C8 File Offset: 0x000129C8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IIntoMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000147EC File Offset: 0x000129EC
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

		// Token: 0x06000736 RID: 1846 RVA: 0x0001485F File Offset: 0x00012A5F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IIntoMapInvoker.cb_hashCode == null)
			{
				IIntoMapInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IIntoMapInvoker.n_GetHashCode));
			}
			return IIntoMapInvoker.cb_hashCode;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00014883 File Offset: 0x00012A83
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIntoMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00014892 File Offset: 0x00012A92
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000148D2 File Offset: 0x00012AD2
		private static Delegate GetToStringHandler()
		{
			if (IIntoMapInvoker.cb_toString == null)
			{
				IIntoMapInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIntoMapInvoker.n_ToString));
			}
			return IIntoMapInvoker.cb_toString;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000148F6 File Offset: 0x00012AF6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IIntoMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001490C File Offset: 0x00012B0C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001EE RID: 494
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/IntoMap", typeof(IIntoMapInvoker));

		// Token: 0x040001EF RID: 495
		private IntPtr class_ref;

		// Token: 0x040001F0 RID: 496
		private static Delegate cb_annotationType;

		// Token: 0x040001F1 RID: 497
		private IntPtr id_annotationType;

		// Token: 0x040001F2 RID: 498
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001F3 RID: 499
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001F4 RID: 500
		private static Delegate cb_hashCode;

		// Token: 0x040001F5 RID: 501
		private IntPtr id_hashCode;

		// Token: 0x040001F6 RID: 502
		private static Delegate cb_toString;

		// Token: 0x040001F7 RID: 503
		private IntPtr id_toString;
	}
}
