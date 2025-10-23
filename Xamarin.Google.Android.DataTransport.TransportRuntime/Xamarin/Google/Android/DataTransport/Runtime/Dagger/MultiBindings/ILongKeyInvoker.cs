using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000CB RID: 203
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/LongKey", DoNotGenerateAcw = true)]
	internal class ILongKeyInvoker : Java.Lang.Object, ILongKey, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00014CB4 File Offset: 0x00012EB4
		private static IntPtr java_class_ref
		{
			get
			{
				return ILongKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00014CD8 File Offset: 0x00012ED8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILongKeyInvoker._members;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00014CDF File Offset: 0x00012EDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00014CE7 File Offset: 0x00012EE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILongKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00014CF3 File Offset: 0x00012EF3
		public static ILongKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILongKey>(handle, transfer);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00014CFC File Offset: 0x00012EFC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILongKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.LongKey'.");
			}
			return handle;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00014D27 File Offset: 0x00012F27
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00014D58 File Offset: 0x00012F58
		public ILongKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILongKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00014D90 File Offset: 0x00012F90
		private static Delegate GetValueHandler()
		{
			if (ILongKeyInvoker.cb_value == null)
			{
				ILongKeyInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ILongKeyInvoker.n_Value));
			}
			return ILongKeyInvoker.cb_value;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00014DB4 File Offset: 0x00012FB4
		private static long n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILongKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value();
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00014DC3 File Offset: 0x00012FC3
		public long Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_value);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00014E03 File Offset: 0x00013003
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ILongKeyInvoker.cb_annotationType == null)
			{
				ILongKeyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILongKeyInvoker.n_AnnotationType));
			}
			return ILongKeyInvoker.cb_annotationType;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00014E27 File Offset: 0x00013027
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILongKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00014E3C File Offset: 0x0001303C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00014E8D File Offset: 0x0001308D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ILongKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ILongKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ILongKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ILongKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00014EB4 File Offset: 0x000130B4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ILongKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00014ED8 File Offset: 0x000130D8
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

		// Token: 0x06000764 RID: 1892 RVA: 0x00014F4B File Offset: 0x0001314B
		private static Delegate GetGetHashCodeHandler()
		{
			if (ILongKeyInvoker.cb_hashCode == null)
			{
				ILongKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ILongKeyInvoker.n_GetHashCode));
			}
			return ILongKeyInvoker.cb_hashCode;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00014F6F File Offset: 0x0001316F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILongKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00014F7E File Offset: 0x0001317E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00014FBE File Offset: 0x000131BE
		private static Delegate GetToStringHandler()
		{
			if (ILongKeyInvoker.cb_toString == null)
			{
				ILongKeyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILongKeyInvoker.n_ToString));
			}
			return ILongKeyInvoker.cb_toString;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00014FE2 File Offset: 0x000131E2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILongKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00014FF8 File Offset: 0x000131F8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000202 RID: 514
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/LongKey", typeof(ILongKeyInvoker));

		// Token: 0x04000203 RID: 515
		private IntPtr class_ref;

		// Token: 0x04000204 RID: 516
		private static Delegate cb_value;

		// Token: 0x04000205 RID: 517
		private IntPtr id_value;

		// Token: 0x04000206 RID: 518
		private static Delegate cb_annotationType;

		// Token: 0x04000207 RID: 519
		private IntPtr id_annotationType;

		// Token: 0x04000208 RID: 520
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000209 RID: 521
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400020A RID: 522
		private static Delegate cb_hashCode;

		// Token: 0x0400020B RID: 523
		private IntPtr id_hashCode;

		// Token: 0x0400020C RID: 524
		private static Delegate cb_toString;

		// Token: 0x0400020D RID: 525
		private IntPtr id_toString;
	}
}
