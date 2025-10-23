using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E6 RID: 230
	[Register("com/google/android/datatransport/runtime/dagger/internal/GwtIncompatible", DoNotGenerateAcw = true)]
	internal class IGwtIncompatibleInvoker : Java.Lang.Object, IGwtIncompatible, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000169E0 File Offset: 0x00014BE0
		private static IntPtr java_class_ref
		{
			get
			{
				return IGwtIncompatibleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00016A04 File Offset: 0x00014C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGwtIncompatibleInvoker._members;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00016A0B File Offset: 0x00014C0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00016A13 File Offset: 0x00014C13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGwtIncompatibleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00016A1F File Offset: 0x00014C1F
		public static IGwtIncompatible GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGwtIncompatible>(handle, transfer);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00016A28 File Offset: 0x00014C28
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGwtIncompatibleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.internal.GwtIncompatible'.");
			}
			return handle;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00016A53 File Offset: 0x00014C53
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00016A84 File Offset: 0x00014C84
		public IGwtIncompatibleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGwtIncompatibleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00016ABC File Offset: 0x00014CBC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IGwtIncompatibleInvoker.cb_annotationType == null)
			{
				IGwtIncompatibleInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGwtIncompatibleInvoker.n_AnnotationType));
			}
			return IGwtIncompatibleInvoker.cb_annotationType;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00016AE0 File Offset: 0x00014CE0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGwtIncompatible>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00016AF4 File Offset: 0x00014CF4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00016B45 File Offset: 0x00014D45
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IGwtIncompatibleInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IGwtIncompatibleInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IGwtIncompatibleInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IGwtIncompatibleInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00016B6C File Offset: 0x00014D6C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IGwtIncompatible>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00016B90 File Offset: 0x00014D90
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

		// Token: 0x06000829 RID: 2089 RVA: 0x00016C03 File Offset: 0x00014E03
		private static Delegate GetGetHashCodeHandler()
		{
			if (IGwtIncompatibleInvoker.cb_hashCode == null)
			{
				IGwtIncompatibleInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGwtIncompatibleInvoker.n_GetHashCode));
			}
			return IGwtIncompatibleInvoker.cb_hashCode;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00016C27 File Offset: 0x00014E27
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGwtIncompatible>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00016C36 File Offset: 0x00014E36
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00016C76 File Offset: 0x00014E76
		private static Delegate GetToStringHandler()
		{
			if (IGwtIncompatibleInvoker.cb_toString == null)
			{
				IGwtIncompatibleInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGwtIncompatibleInvoker.n_ToString));
			}
			return IGwtIncompatibleInvoker.cb_toString;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00016C9A File Offset: 0x00014E9A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IGwtIncompatible>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000248 RID: 584
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/GwtIncompatible", typeof(IGwtIncompatibleInvoker));

		// Token: 0x04000249 RID: 585
		private IntPtr class_ref;

		// Token: 0x0400024A RID: 586
		private static Delegate cb_annotationType;

		// Token: 0x0400024B RID: 587
		private IntPtr id_annotationType;

		// Token: 0x0400024C RID: 588
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400024D RID: 589
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400024E RID: 590
		private static Delegate cb_hashCode;

		// Token: 0x0400024F RID: 591
		private IntPtr id_hashCode;

		// Token: 0x04000250 RID: 592
		private static Delegate cb_toString;

		// Token: 0x04000251 RID: 593
		private IntPtr id_toString;
	}
}
