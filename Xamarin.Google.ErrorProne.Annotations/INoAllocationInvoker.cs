using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000032 RID: 50
	[Register("com/google/errorprone/annotations/NoAllocation", DoNotGenerateAcw = true)]
	internal class INoAllocationInvoker : Java.Lang.Object, INoAllocation, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00005684 File Offset: 0x00003884
		private static IntPtr java_class_ref
		{
			get
			{
				return INoAllocationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000056A8 File Offset: 0x000038A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INoAllocationInvoker._members;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000056AF File Offset: 0x000038AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000056B7 File Offset: 0x000038B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INoAllocationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000056C3 File Offset: 0x000038C3
		public static INoAllocation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INoAllocation>(handle, transfer);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000056CC File Offset: 0x000038CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INoAllocationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.NoAllocation'.");
			}
			return handle;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000056F7 File Offset: 0x000038F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00005728 File Offset: 0x00003928
		public INoAllocationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INoAllocationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005760 File Offset: 0x00003960
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INoAllocationInvoker.cb_annotationType == null)
			{
				INoAllocationInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INoAllocationInvoker.n_AnnotationType));
			}
			return INoAllocationInvoker.cb_annotationType;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005784 File Offset: 0x00003984
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INoAllocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005798 File Offset: 0x00003998
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000057E9 File Offset: 0x000039E9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INoAllocationInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INoAllocationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INoAllocationInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INoAllocationInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00005810 File Offset: 0x00003A10
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INoAllocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005834 File Offset: 0x00003A34
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

		// Token: 0x06000198 RID: 408 RVA: 0x000058A7 File Offset: 0x00003AA7
		private static Delegate GetGetHashCodeHandler()
		{
			if (INoAllocationInvoker.cb_hashCode == null)
			{
				INoAllocationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INoAllocationInvoker.n_GetHashCode));
			}
			return INoAllocationInvoker.cb_hashCode;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000058CB File Offset: 0x00003ACB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INoAllocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000058DA File Offset: 0x00003ADA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000591A File Offset: 0x00003B1A
		private static Delegate GetToStringHandler()
		{
			if (INoAllocationInvoker.cb_toString == null)
			{
				INoAllocationInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INoAllocationInvoker.n_ToString));
			}
			return INoAllocationInvoker.cb_toString;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000593E File Offset: 0x00003B3E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INoAllocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005954 File Offset: 0x00003B54
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000B1 RID: 177
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/NoAllocation", typeof(INoAllocationInvoker));

		// Token: 0x040000B2 RID: 178
		private IntPtr class_ref;

		// Token: 0x040000B3 RID: 179
		private static Delegate cb_annotationType;

		// Token: 0x040000B4 RID: 180
		private IntPtr id_annotationType;

		// Token: 0x040000B5 RID: 181
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000B6 RID: 182
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000B7 RID: 183
		private static Delegate cb_hashCode;

		// Token: 0x040000B8 RID: 184
		private IntPtr id_hashCode;

		// Token: 0x040000B9 RID: 185
		private static Delegate cb_toString;

		// Token: 0x040000BA RID: 186
		private IntPtr id_toString;
	}
}
