using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000033 RID: 51
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Unmodifiable", DoNotGenerateAcw = true)]
	internal class IUnmodifiableInvoker : Java.Lang.Object, IUnmodifiable, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00005A80 File Offset: 0x00003C80
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnmodifiableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnmodifiableInvoker._members;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00005AAB File Offset: 0x00003CAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00005AB3 File Offset: 0x00003CB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnmodifiableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00005ABF File Offset: 0x00003CBF
		[NullableContext(2)]
		public static IUnmodifiable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnmodifiable>(handle, transfer);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005AC8 File Offset: 0x00003CC8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnmodifiableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Unmodifiable'.");
			}
			return handle;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005AF3 File Offset: 0x00003CF3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005B24 File Offset: 0x00003D24
		public IUnmodifiableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnmodifiableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00005B5C File Offset: 0x00003D5C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IUnmodifiableInvoker.cb_annotationType == null)
			{
				IUnmodifiableInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnmodifiableInvoker.n_AnnotationType));
			}
			return IUnmodifiableInvoker.cb_annotationType;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00005B80 File Offset: 0x00003D80
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IUnmodifiable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00005B94 File Offset: 0x00003D94
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00005BE5 File Offset: 0x00003DE5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IUnmodifiableInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IUnmodifiableInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IUnmodifiableInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IUnmodifiableInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00005C0C File Offset: 0x00003E0C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IUnmodifiable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00005C30 File Offset: 0x00003E30
		[NullableContext(2)]
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

		// Token: 0x060001B7 RID: 439 RVA: 0x00005CA3 File Offset: 0x00003EA3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IUnmodifiableInvoker.cb_hashCode == null)
			{
				IUnmodifiableInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IUnmodifiableInvoker.n_GetHashCode));
			}
			return IUnmodifiableInvoker.cb_hashCode;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00005CC7 File Offset: 0x00003EC7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnmodifiable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00005CD6 File Offset: 0x00003ED6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005D16 File Offset: 0x00003F16
		private static Delegate GetToStringHandler()
		{
			if (IUnmodifiableInvoker.cb_toString == null)
			{
				IUnmodifiableInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnmodifiableInvoker.n_ToString));
			}
			return IUnmodifiableInvoker.cb_toString;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005D3A File Offset: 0x00003F3A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnmodifiable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00005D50 File Offset: 0x00003F50
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000B7 RID: 183
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Unmodifiable", typeof(IUnmodifiableInvoker));

		// Token: 0x040000B8 RID: 184
		private IntPtr class_ref;

		// Token: 0x040000B9 RID: 185
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000BA RID: 186
		private IntPtr id_annotationType;

		// Token: 0x040000BB RID: 187
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000BC RID: 188
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000BD RID: 189
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000BE RID: 190
		private IntPtr id_hashCode;

		// Token: 0x040000BF RID: 191
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000C0 RID: 192
		private IntPtr id_toString;
	}
}
