using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B0 RID: 176
	[Register("com/google/android/datatransport/runtime/dagger/Provides", DoNotGenerateAcw = true)]
	internal class IProvidesInvoker : Java.Lang.Object, IProvides, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00012A6C File Offset: 0x00010C6C
		private static IntPtr java_class_ref
		{
			get
			{
				return IProvidesInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00012A90 File Offset: 0x00010C90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IProvidesInvoker._members;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00012A97 File Offset: 0x00010C97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00012A9F File Offset: 0x00010C9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IProvidesInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00012AAB File Offset: 0x00010CAB
		public static IProvides GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IProvides>(handle, transfer);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00012AB4 File Offset: 0x00010CB4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IProvidesInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Provides'.");
			}
			return handle;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00012ADF File Offset: 0x00010CDF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00012B10 File Offset: 0x00010D10
		public IProvidesInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IProvidesInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00012B48 File Offset: 0x00010D48
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IProvidesInvoker.cb_annotationType == null)
			{
				IProvidesInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IProvidesInvoker.n_AnnotationType));
			}
			return IProvidesInvoker.cb_annotationType;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00012B6C File Offset: 0x00010D6C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IProvides>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00012B80 File Offset: 0x00010D80
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00012BD1 File Offset: 0x00010DD1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IProvidesInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IProvidesInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IProvidesInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IProvidesInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00012BF8 File Offset: 0x00010DF8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IProvides>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00012C1C File Offset: 0x00010E1C
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

		// Token: 0x06000671 RID: 1649 RVA: 0x00012C8F File Offset: 0x00010E8F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IProvidesInvoker.cb_hashCode == null)
			{
				IProvidesInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IProvidesInvoker.n_GetHashCode));
			}
			return IProvidesInvoker.cb_hashCode;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00012CB3 File Offset: 0x00010EB3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IProvides>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00012CC2 File Offset: 0x00010EC2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00012D02 File Offset: 0x00010F02
		private static Delegate GetToStringHandler()
		{
			if (IProvidesInvoker.cb_toString == null)
			{
				IProvidesInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IProvidesInvoker.n_ToString));
			}
			return IProvidesInvoker.cb_toString;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00012D26 File Offset: 0x00010F26
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IProvides>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00012D3C File Offset: 0x00010F3C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000193 RID: 403
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Provides", typeof(IProvidesInvoker));

		// Token: 0x04000194 RID: 404
		private IntPtr class_ref;

		// Token: 0x04000195 RID: 405
		private static Delegate cb_annotationType;

		// Token: 0x04000196 RID: 406
		private IntPtr id_annotationType;

		// Token: 0x04000197 RID: 407
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000198 RID: 408
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000199 RID: 409
		private static Delegate cb_hashCode;

		// Token: 0x0400019A RID: 410
		private IntPtr id_hashCode;

		// Token: 0x0400019B RID: 411
		private static Delegate cb_toString;

		// Token: 0x0400019C RID: 412
		private IntPtr id_toString;
	}
}
