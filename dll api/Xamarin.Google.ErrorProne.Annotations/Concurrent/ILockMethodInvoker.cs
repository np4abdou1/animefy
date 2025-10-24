using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x0200004F RID: 79
	[Register("com/google/errorprone/annotations/concurrent/LockMethod", DoNotGenerateAcw = true)]
	internal class ILockMethodInvoker : Java.Lang.Object, ILockMethod, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00007B70 File Offset: 0x00005D70
		private static IntPtr java_class_ref
		{
			get
			{
				return ILockMethodInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00007B94 File Offset: 0x00005D94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILockMethodInvoker._members;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00007B9B File Offset: 0x00005D9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00007BA3 File Offset: 0x00005DA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILockMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00007BAF File Offset: 0x00005DAF
		public static ILockMethod GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILockMethod>(handle, transfer);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00007BB8 File Offset: 0x00005DB8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILockMethodInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.concurrent.LockMethod'.");
			}
			return handle;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00007BE3 File Offset: 0x00005DE3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00007C14 File Offset: 0x00005E14
		public ILockMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILockMethodInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00007C4C File Offset: 0x00005E4C
		private static Delegate GetValueHandler()
		{
			if (ILockMethodInvoker.cb_value == null)
			{
				ILockMethodInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILockMethodInvoker.n_Value));
			}
			return ILockMethodInvoker.cb_value;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00007C70 File Offset: 0x00005E70
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<ILockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00007C84 File Offset: 0x00005E84
		public string[] Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00007CE4 File Offset: 0x00005EE4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ILockMethodInvoker.cb_annotationType == null)
			{
				ILockMethodInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILockMethodInvoker.n_AnnotationType));
			}
			return ILockMethodInvoker.cb_annotationType;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00007D08 File Offset: 0x00005F08
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00007D1C File Offset: 0x00005F1C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00007D6D File Offset: 0x00005F6D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ILockMethodInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ILockMethodInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ILockMethodInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ILockMethodInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00007D94 File Offset: 0x00005F94
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ILockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00007DB8 File Offset: 0x00005FB8
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

		// Token: 0x0600029F RID: 671 RVA: 0x00007E2B File Offset: 0x0000602B
		private static Delegate GetGetHashCodeHandler()
		{
			if (ILockMethodInvoker.cb_hashCode == null)
			{
				ILockMethodInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ILockMethodInvoker.n_GetHashCode));
			}
			return ILockMethodInvoker.cb_hashCode;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00007E4F File Offset: 0x0000604F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00007E5E File Offset: 0x0000605E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00007E9E File Offset: 0x0000609E
		private static Delegate GetToStringHandler()
		{
			if (ILockMethodInvoker.cb_toString == null)
			{
				ILockMethodInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILockMethodInvoker.n_ToString));
			}
			return ILockMethodInvoker.cb_toString;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00007EC2 File Offset: 0x000060C2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILockMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00007ED8 File Offset: 0x000060D8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000120 RID: 288
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/concurrent/LockMethod", typeof(ILockMethodInvoker));

		// Token: 0x04000121 RID: 289
		private IntPtr class_ref;

		// Token: 0x04000122 RID: 290
		private static Delegate cb_value;

		// Token: 0x04000123 RID: 291
		private IntPtr id_value;

		// Token: 0x04000124 RID: 292
		private static Delegate cb_annotationType;

		// Token: 0x04000125 RID: 293
		private IntPtr id_annotationType;

		// Token: 0x04000126 RID: 294
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000127 RID: 295
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000128 RID: 296
		private static Delegate cb_hashCode;

		// Token: 0x04000129 RID: 297
		private IntPtr id_hashCode;

		// Token: 0x0400012A RID: 298
		private static Delegate cb_toString;

		// Token: 0x0400012B RID: 299
		private IntPtr id_toString;
	}
}
