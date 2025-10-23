using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E8 RID: 232
	[Register("com/google/android/datatransport/runtime/dagger/internal/InjectedFieldSignature", DoNotGenerateAcw = true)]
	internal class IInjectedFieldSignatureInvoker : Java.Lang.Object, IInjectedFieldSignature, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00016D1C File Offset: 0x00014F1C
		private static IntPtr java_class_ref
		{
			get
			{
				return IInjectedFieldSignatureInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00016D40 File Offset: 0x00014F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInjectedFieldSignatureInvoker._members;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00016D47 File Offset: 0x00014F47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00016D4F File Offset: 0x00014F4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInjectedFieldSignatureInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00016D5B File Offset: 0x00014F5B
		public static IInjectedFieldSignature GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInjectedFieldSignature>(handle, transfer);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00016D64 File Offset: 0x00014F64
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInjectedFieldSignatureInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.internal.InjectedFieldSignature'.");
			}
			return handle;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00016D8F File Offset: 0x00014F8F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00016DC0 File Offset: 0x00014FC0
		public IInjectedFieldSignatureInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInjectedFieldSignatureInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00016DF8 File Offset: 0x00014FF8
		private static Delegate GetValueHandler()
		{
			if (IInjectedFieldSignatureInvoker.cb_value == null)
			{
				IInjectedFieldSignatureInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInjectedFieldSignatureInvoker.n_Value));
			}
			return IInjectedFieldSignatureInvoker.cb_value;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00016E1C File Offset: 0x0001501C
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInjectedFieldSignature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00016E30 File Offset: 0x00015030
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00016E81 File Offset: 0x00015081
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IInjectedFieldSignatureInvoker.cb_annotationType == null)
			{
				IInjectedFieldSignatureInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInjectedFieldSignatureInvoker.n_AnnotationType));
			}
			return IInjectedFieldSignatureInvoker.cb_annotationType;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00016EA5 File Offset: 0x000150A5
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInjectedFieldSignature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00016EBC File Offset: 0x000150BC
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00016F0D File Offset: 0x0001510D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IInjectedFieldSignatureInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IInjectedFieldSignatureInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IInjectedFieldSignatureInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IInjectedFieldSignatureInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00016F34 File Offset: 0x00015134
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IInjectedFieldSignature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00016F58 File Offset: 0x00015158
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

		// Token: 0x06000842 RID: 2114 RVA: 0x00016FCB File Offset: 0x000151CB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IInjectedFieldSignatureInvoker.cb_hashCode == null)
			{
				IInjectedFieldSignatureInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IInjectedFieldSignatureInvoker.n_GetHashCode));
			}
			return IInjectedFieldSignatureInvoker.cb_hashCode;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00016FEF File Offset: 0x000151EF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IInjectedFieldSignature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00016FFE File Offset: 0x000151FE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0001703E File Offset: 0x0001523E
		private static Delegate GetToStringHandler()
		{
			if (IInjectedFieldSignatureInvoker.cb_toString == null)
			{
				IInjectedFieldSignatureInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInjectedFieldSignatureInvoker.n_ToString));
			}
			return IInjectedFieldSignatureInvoker.cb_toString;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00017062 File Offset: 0x00015262
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInjectedFieldSignature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00017078 File Offset: 0x00015278
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000252 RID: 594
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/InjectedFieldSignature", typeof(IInjectedFieldSignatureInvoker));

		// Token: 0x04000253 RID: 595
		private IntPtr class_ref;

		// Token: 0x04000254 RID: 596
		private static Delegate cb_value;

		// Token: 0x04000255 RID: 597
		private IntPtr id_value;

		// Token: 0x04000256 RID: 598
		private static Delegate cb_annotationType;

		// Token: 0x04000257 RID: 599
		private IntPtr id_annotationType;

		// Token: 0x04000258 RID: 600
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000259 RID: 601
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_hashCode;

		// Token: 0x0400025B RID: 603
		private IntPtr id_hashCode;

		// Token: 0x0400025C RID: 604
		private static Delegate cb_toString;

		// Token: 0x0400025D RID: 605
		private IntPtr id_toString;
	}
}
