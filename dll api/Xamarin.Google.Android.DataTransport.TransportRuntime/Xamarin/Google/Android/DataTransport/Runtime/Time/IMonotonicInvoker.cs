using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000034 RID: 52
	[Register("com/google/android/datatransport/runtime/time/Monotonic", DoNotGenerateAcw = true)]
	internal class IMonotonicInvoker : Java.Lang.Object, IMonotonic, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000053F8 File Offset: 0x000035F8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMonotonicInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000541C File Offset: 0x0000361C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMonotonicInvoker._members;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005423 File Offset: 0x00003623
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000542B File Offset: 0x0000362B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMonotonicInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005437 File Offset: 0x00003637
		public static IMonotonic GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMonotonic>(handle, transfer);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005440 File Offset: 0x00003640
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMonotonicInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.time.Monotonic'.");
			}
			return handle;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000546B File Offset: 0x0000366B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000549C File Offset: 0x0000369C
		public IMonotonicInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMonotonicInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000054D4 File Offset: 0x000036D4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMonotonicInvoker.cb_annotationType == null)
			{
				IMonotonicInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMonotonicInvoker.n_AnnotationType));
			}
			return IMonotonicInvoker.cb_annotationType;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000054F8 File Offset: 0x000036F8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMonotonic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000550C File Offset: 0x0000370C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000555D File Offset: 0x0000375D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMonotonicInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMonotonicInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMonotonicInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMonotonicInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005584 File Offset: 0x00003784
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMonotonic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000055A8 File Offset: 0x000037A8
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

		// Token: 0x060001A1 RID: 417 RVA: 0x0000561B File Offset: 0x0000381B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMonotonicInvoker.cb_hashCode == null)
			{
				IMonotonicInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMonotonicInvoker.n_GetHashCode));
			}
			return IMonotonicInvoker.cb_hashCode;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000563F File Offset: 0x0000383F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMonotonic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000564E File Offset: 0x0000384E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000568E File Offset: 0x0000388E
		private static Delegate GetToStringHandler()
		{
			if (IMonotonicInvoker.cb_toString == null)
			{
				IMonotonicInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMonotonicInvoker.n_ToString));
			}
			return IMonotonicInvoker.cb_toString;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000056B2 File Offset: 0x000038B2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMonotonic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000056C8 File Offset: 0x000038C8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000054 RID: 84
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/Monotonic", typeof(IMonotonicInvoker));

		// Token: 0x04000055 RID: 85
		private IntPtr class_ref;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_annotationType;

		// Token: 0x04000057 RID: 87
		private IntPtr id_annotationType;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000059 RID: 89
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_hashCode;

		// Token: 0x0400005B RID: 91
		private IntPtr id_hashCode;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_toString;

		// Token: 0x0400005D RID: 93
		private IntPtr id_toString;
	}
}
