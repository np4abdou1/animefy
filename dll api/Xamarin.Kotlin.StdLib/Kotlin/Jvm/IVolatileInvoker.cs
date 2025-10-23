using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000175 RID: 373
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/Volatile", DoNotGenerateAcw = true)]
	internal class IVolatileInvoker : Java.Lang.Object, IVolatile, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0003E4C8 File Offset: 0x0003C6C8
		private static IntPtr java_class_ref
		{
			get
			{
				return IVolatileInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0003E4EC File Offset: 0x0003C6EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IVolatileInvoker._members;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0003E4F3 File Offset: 0x0003C6F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x0003E4FB File Offset: 0x0003C6FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IVolatileInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0003E507 File Offset: 0x0003C707
		[NullableContext(2)]
		public static IVolatile GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IVolatile>(handle, transfer);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0003E510 File Offset: 0x0003C710
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IVolatileInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.Volatile'.");
			}
			return handle;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0003E53B File Offset: 0x0003C73B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0003E56C File Offset: 0x0003C76C
		public IVolatileInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IVolatileInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IVolatileInvoker.cb_annotationType == null)
			{
				IVolatileInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IVolatileInvoker.n_AnnotationType));
			}
			return IVolatileInvoker.cb_annotationType;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0003E5C8 File Offset: 0x0003C7C8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IVolatile>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0003E5DC File Offset: 0x0003C7DC
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0003E62D File Offset: 0x0003C82D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IVolatileInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IVolatileInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IVolatileInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IVolatileInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0003E654 File Offset: 0x0003C854
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IVolatile>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0003E678 File Offset: 0x0003C878
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

		// Token: 0x0600132C RID: 4908 RVA: 0x0003E6EB File Offset: 0x0003C8EB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IVolatileInvoker.cb_hashCode == null)
			{
				IVolatileInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IVolatileInvoker.n_GetHashCode));
			}
			return IVolatileInvoker.cb_hashCode;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0003E70F File Offset: 0x0003C90F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IVolatile>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0003E71E File Offset: 0x0003C91E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0003E75E File Offset: 0x0003C95E
		private static Delegate GetToStringHandler()
		{
			if (IVolatileInvoker.cb_toString == null)
			{
				IVolatileInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IVolatileInvoker.n_ToString));
			}
			return IVolatileInvoker.cb_toString;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0003E782 File Offset: 0x0003C982
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IVolatile>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0003E798 File Offset: 0x0003C998
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000665 RID: 1637
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/Volatile", typeof(IVolatileInvoker));

		// Token: 0x04000666 RID: 1638
		private IntPtr class_ref;

		// Token: 0x04000667 RID: 1639
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000668 RID: 1640
		private IntPtr id_annotationType;

		// Token: 0x04000669 RID: 1641
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400066A RID: 1642
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400066B RID: 1643
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400066C RID: 1644
		private IntPtr id_hashCode;

		// Token: 0x0400066D RID: 1645
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400066E RID: 1646
		private IntPtr id_toString;
	}
}
