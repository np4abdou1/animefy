using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x02000051 RID: 81
	[Register("com/google/errorprone/annotations/concurrent/UnlockMethod", DoNotGenerateAcw = true)]
	internal class IUnlockMethodInvoker : Java.Lang.Object, IUnlockMethod, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00007F44 File Offset: 0x00006144
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnlockMethodInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00007F68 File Offset: 0x00006168
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnlockMethodInvoker._members;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00007F6F File Offset: 0x0000616F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00007F77 File Offset: 0x00006177
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnlockMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00007F83 File Offset: 0x00006183
		public static IUnlockMethod GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnlockMethod>(handle, transfer);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00007F8C File Offset: 0x0000618C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnlockMethodInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.concurrent.UnlockMethod'.");
			}
			return handle;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00007FB7 File Offset: 0x000061B7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00007FE8 File Offset: 0x000061E8
		public IUnlockMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnlockMethodInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00008020 File Offset: 0x00006220
		private static Delegate GetValueHandler()
		{
			if (IUnlockMethodInvoker.cb_value == null)
			{
				IUnlockMethodInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnlockMethodInvoker.n_Value));
			}
			return IUnlockMethodInvoker.cb_value;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00008044 File Offset: 0x00006244
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IUnlockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00008058 File Offset: 0x00006258
		public string[] Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000080B8 File Offset: 0x000062B8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IUnlockMethodInvoker.cb_annotationType == null)
			{
				IUnlockMethodInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnlockMethodInvoker.n_AnnotationType));
			}
			return IUnlockMethodInvoker.cb_annotationType;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000080DC File Offset: 0x000062DC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IUnlockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000080F0 File Offset: 0x000062F0
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00008141 File Offset: 0x00006341
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IUnlockMethodInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IUnlockMethodInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IUnlockMethodInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IUnlockMethodInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00008168 File Offset: 0x00006368
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IUnlockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000818C File Offset: 0x0000638C
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

		// Token: 0x060002B8 RID: 696 RVA: 0x000081FF File Offset: 0x000063FF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IUnlockMethodInvoker.cb_hashCode == null)
			{
				IUnlockMethodInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IUnlockMethodInvoker.n_GetHashCode));
			}
			return IUnlockMethodInvoker.cb_hashCode;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00008223 File Offset: 0x00006423
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnlockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008232 File Offset: 0x00006432
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00008272 File Offset: 0x00006472
		private static Delegate GetToStringHandler()
		{
			if (IUnlockMethodInvoker.cb_toString == null)
			{
				IUnlockMethodInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnlockMethodInvoker.n_ToString));
			}
			return IUnlockMethodInvoker.cb_toString;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00008296 File Offset: 0x00006496
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnlockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000082AC File Offset: 0x000064AC
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400012C RID: 300
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/concurrent/UnlockMethod", typeof(IUnlockMethodInvoker));

		// Token: 0x0400012D RID: 301
		private IntPtr class_ref;

		// Token: 0x0400012E RID: 302
		private static Delegate cb_value;

		// Token: 0x0400012F RID: 303
		private IntPtr id_value;

		// Token: 0x04000130 RID: 304
		private static Delegate cb_annotationType;

		// Token: 0x04000131 RID: 305
		private IntPtr id_annotationType;

		// Token: 0x04000132 RID: 306
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000133 RID: 307
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000134 RID: 308
		private static Delegate cb_hashCode;

		// Token: 0x04000135 RID: 309
		private IntPtr id_hashCode;

		// Token: 0x04000136 RID: 310
		private static Delegate cb_toString;

		// Token: 0x04000137 RID: 311
		private IntPtr id_toString;
	}
}
