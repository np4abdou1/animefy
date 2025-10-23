using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x0200009C RID: 156
	[Register("com/google/android/datatransport/runtime/dagger/Binds", DoNotGenerateAcw = true)]
	internal class IBindsInvoker : Java.Lang.Object, IBinds, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00010A88 File Offset: 0x0000EC88
		private static IntPtr java_class_ref
		{
			get
			{
				return IBindsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00010AAC File Offset: 0x0000ECAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBindsInvoker._members;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00010AB3 File Offset: 0x0000ECB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00010ABB File Offset: 0x0000ECBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBindsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00010AC7 File Offset: 0x0000ECC7
		public static IBinds GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBinds>(handle, transfer);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBindsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Binds'.");
			}
			return handle;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00010AFB File Offset: 0x0000ECFB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00010B2C File Offset: 0x0000ED2C
		public IBindsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBindsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00010B64 File Offset: 0x0000ED64
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBindsInvoker.cb_annotationType == null)
			{
				IBindsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBindsInvoker.n_AnnotationType));
			}
			return IBindsInvoker.cb_annotationType;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00010B88 File Offset: 0x0000ED88
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00010B9C File Offset: 0x0000ED9C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00010BED File Offset: 0x0000EDED
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBindsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBindsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBindsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBindsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00010C14 File Offset: 0x0000EE14
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00010C38 File Offset: 0x0000EE38
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

		// Token: 0x0600059B RID: 1435 RVA: 0x00010CAB File Offset: 0x0000EEAB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBindsInvoker.cb_hashCode == null)
			{
				IBindsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBindsInvoker.n_GetHashCode));
			}
			return IBindsInvoker.cb_hashCode;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00010CCF File Offset: 0x0000EECF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00010CDE File Offset: 0x0000EEDE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00010D1E File Offset: 0x0000EF1E
		private static Delegate GetToStringHandler()
		{
			if (IBindsInvoker.cb_toString == null)
			{
				IBindsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBindsInvoker.n_ToString));
			}
			return IBindsInvoker.cb_toString;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00010D42 File Offset: 0x0000EF42
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBinds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00010D58 File Offset: 0x0000EF58
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000131 RID: 305
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Binds", typeof(IBindsInvoker));

		// Token: 0x04000132 RID: 306
		private IntPtr class_ref;

		// Token: 0x04000133 RID: 307
		private static Delegate cb_annotationType;

		// Token: 0x04000134 RID: 308
		private IntPtr id_annotationType;

		// Token: 0x04000135 RID: 309
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000136 RID: 310
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000137 RID: 311
		private static Delegate cb_hashCode;

		// Token: 0x04000138 RID: 312
		private IntPtr id_hashCode;

		// Token: 0x04000139 RID: 313
		private static Delegate cb_toString;

		// Token: 0x0400013A RID: 314
		private IntPtr id_toString;
	}
}
