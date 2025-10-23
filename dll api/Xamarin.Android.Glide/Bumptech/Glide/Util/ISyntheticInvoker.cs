using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Bumptech.Glide.Util
{
	// Token: 0x0200004D RID: 77
	[Register("com/bumptech/glide/util/Synthetic", DoNotGenerateAcw = true)]
	internal class ISyntheticInvoker : Java.Lang.Object, ISynthetic, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000B4C4 File Offset: 0x000096C4
		private static IntPtr java_class_ref
		{
			get
			{
				return ISyntheticInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000B4E8 File Offset: 0x000096E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISyntheticInvoker._members;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000B4EF File Offset: 0x000096EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000B4F7 File Offset: 0x000096F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISyntheticInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000B503 File Offset: 0x00009703
		public static ISynthetic GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISynthetic>(handle, transfer);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000B50C File Offset: 0x0000970C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISyntheticInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.util.Synthetic'.");
			}
			return handle;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000B537 File Offset: 0x00009737
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000B568 File Offset: 0x00009768
		public ISyntheticInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISyntheticInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000B5A0 File Offset: 0x000097A0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISyntheticInvoker.cb_annotationType == null)
			{
				ISyntheticInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISyntheticInvoker.n_AnnotationType));
			}
			return ISyntheticInvoker.cb_annotationType;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000B5C4 File Offset: 0x000097C4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B5D8 File Offset: 0x000097D8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B629 File Offset: 0x00009829
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISyntheticInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISyntheticInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISyntheticInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISyntheticInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B650 File Offset: 0x00009850
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B674 File Offset: 0x00009874
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

		// Token: 0x06000360 RID: 864 RVA: 0x0000B6E7 File Offset: 0x000098E7
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISyntheticInvoker.cb_hashCode == null)
			{
				ISyntheticInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISyntheticInvoker.n_GetHashCode));
			}
			return ISyntheticInvoker.cb_hashCode;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000B70B File Offset: 0x0000990B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000B71A File Offset: 0x0000991A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000B75A File Offset: 0x0000995A
		private static Delegate GetToStringHandler()
		{
			if (ISyntheticInvoker.cb_toString == null)
			{
				ISyntheticInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISyntheticInvoker.n_ToString));
			}
			return ISyntheticInvoker.cb_toString;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000B77E File Offset: 0x0000997E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000B794 File Offset: 0x00009994
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000B0 RID: 176
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/Synthetic", typeof(ISyntheticInvoker));

		// Token: 0x040000B1 RID: 177
		private IntPtr class_ref;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_annotationType;

		// Token: 0x040000B3 RID: 179
		private IntPtr id_annotationType;

		// Token: 0x040000B4 RID: 180
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000B5 RID: 181
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000B6 RID: 182
		private static Delegate cb_hashCode;

		// Token: 0x040000B7 RID: 183
		private IntPtr id_hashCode;

		// Token: 0x040000B8 RID: 184
		private static Delegate cb_toString;

		// Token: 0x040000B9 RID: 185
		private IntPtr id_toString;
	}
}
