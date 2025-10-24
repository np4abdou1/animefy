using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x0200009E RID: 158
	[Register("com/google/android/datatransport/runtime/dagger/BindsInstance", DoNotGenerateAcw = true)]
	internal class IBindsInstanceInvoker : Java.Lang.Object, IBindsInstance, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		private static IntPtr java_class_ref
		{
			get
			{
				return IBindsInstanceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBindsInstanceInvoker._members;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00010DEF File Offset: 0x0000EFEF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00010DF7 File Offset: 0x0000EFF7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBindsInstanceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00010E03 File Offset: 0x0000F003
		public static IBindsInstance GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBindsInstance>(handle, transfer);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00010E0C File Offset: 0x0000F00C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBindsInstanceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.BindsInstance'.");
			}
			return handle;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00010E37 File Offset: 0x0000F037
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00010E68 File Offset: 0x0000F068
		public IBindsInstanceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBindsInstanceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBindsInstanceInvoker.cb_annotationType == null)
			{
				IBindsInstanceInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBindsInstanceInvoker.n_AnnotationType));
			}
			return IBindsInstanceInvoker.cb_annotationType;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBindsInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00010F29 File Offset: 0x0000F129
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBindsInstanceInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBindsInstanceInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBindsInstanceInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBindsInstanceInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00010F50 File Offset: 0x0000F150
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBindsInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00010F74 File Offset: 0x0000F174
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

		// Token: 0x060005B0 RID: 1456 RVA: 0x00010FE7 File Offset: 0x0000F1E7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBindsInstanceInvoker.cb_hashCode == null)
			{
				IBindsInstanceInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBindsInstanceInvoker.n_GetHashCode));
			}
			return IBindsInstanceInvoker.cb_hashCode;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001100B File Offset: 0x0000F20B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBindsInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001101A File Offset: 0x0000F21A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0001105A File Offset: 0x0000F25A
		private static Delegate GetToStringHandler()
		{
			if (IBindsInstanceInvoker.cb_toString == null)
			{
				IBindsInstanceInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBindsInstanceInvoker.n_ToString));
			}
			return IBindsInstanceInvoker.cb_toString;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001107E File Offset: 0x0000F27E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBindsInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00011094 File Offset: 0x0000F294
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400013B RID: 315
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/BindsInstance", typeof(IBindsInstanceInvoker));

		// Token: 0x0400013C RID: 316
		private IntPtr class_ref;

		// Token: 0x0400013D RID: 317
		private static Delegate cb_annotationType;

		// Token: 0x0400013E RID: 318
		private IntPtr id_annotationType;

		// Token: 0x0400013F RID: 319
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000140 RID: 320
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000141 RID: 321
		private static Delegate cb_hashCode;

		// Token: 0x04000142 RID: 322
		private IntPtr id_hashCode;

		// Token: 0x04000143 RID: 323
		private static Delegate cb_toString;

		// Token: 0x04000144 RID: 324
		private IntPtr id_toString;
	}
}
