using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000036 RID: 54
	[Register("com/google/android/datatransport/runtime/time/WallTime", DoNotGenerateAcw = true)]
	internal class IWallTimeInvoker : Java.Lang.Object, IWallTime, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00005734 File Offset: 0x00003934
		private static IntPtr java_class_ref
		{
			get
			{
				return IWallTimeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00005758 File Offset: 0x00003958
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWallTimeInvoker._members;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000575F File Offset: 0x0000395F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00005767 File Offset: 0x00003967
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWallTimeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005773 File Offset: 0x00003973
		public static IWallTime GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWallTime>(handle, transfer);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000577C File Offset: 0x0000397C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWallTimeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.time.WallTime'.");
			}
			return handle;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000057A7 File Offset: 0x000039A7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000057D8 File Offset: 0x000039D8
		public IWallTimeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWallTimeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005810 File Offset: 0x00003A10
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IWallTimeInvoker.cb_annotationType == null)
			{
				IWallTimeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWallTimeInvoker.n_AnnotationType));
			}
			return IWallTimeInvoker.cb_annotationType;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00005834 File Offset: 0x00003A34
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWallTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00005848 File Offset: 0x00003A48
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00005899 File Offset: 0x00003A99
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IWallTimeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IWallTimeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IWallTimeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IWallTimeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000058C0 File Offset: 0x00003AC0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IWallTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000058E4 File Offset: 0x00003AE4
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

		// Token: 0x060001B6 RID: 438 RVA: 0x00005957 File Offset: 0x00003B57
		private static Delegate GetGetHashCodeHandler()
		{
			if (IWallTimeInvoker.cb_hashCode == null)
			{
				IWallTimeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IWallTimeInvoker.n_GetHashCode));
			}
			return IWallTimeInvoker.cb_hashCode;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000597B File Offset: 0x00003B7B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWallTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000598A File Offset: 0x00003B8A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000059CA File Offset: 0x00003BCA
		private static Delegate GetToStringHandler()
		{
			if (IWallTimeInvoker.cb_toString == null)
			{
				IWallTimeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWallTimeInvoker.n_ToString));
			}
			return IWallTimeInvoker.cb_toString;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000059EE File Offset: 0x00003BEE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IWallTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005A04 File Offset: 0x00003C04
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400005E RID: 94
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/WallTime", typeof(IWallTimeInvoker));

		// Token: 0x0400005F RID: 95
		private IntPtr class_ref;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_annotationType;

		// Token: 0x04000061 RID: 97
		private IntPtr id_annotationType;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000063 RID: 99
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_hashCode;

		// Token: 0x04000065 RID: 101
		private IntPtr id_hashCode;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_toString;

		// Token: 0x04000067 RID: 103
		private IntPtr id_toString;
	}
}
