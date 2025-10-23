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
	// Token: 0x02000171 RID: 369
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/Throws", DoNotGenerateAcw = true)]
	internal class IThrowsInvoker : Java.Lang.Object, IThrows, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x0003DDB8 File Offset: 0x0003BFB8
		private static IntPtr java_class_ref
		{
			get
			{
				return IThrowsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x0003DDDC File Offset: 0x0003BFDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IThrowsInvoker._members;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x0003DDE3 File Offset: 0x0003BFE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0003DDEB File Offset: 0x0003BFEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IThrowsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0003DDF7 File Offset: 0x0003BFF7
		[NullableContext(2)]
		public static IThrows GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IThrows>(handle, transfer);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0003DE00 File Offset: 0x0003C000
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IThrowsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.Throws'.");
			}
			return handle;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0003DE2B File Offset: 0x0003C02B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0003DE5C File Offset: 0x0003C05C
		public IThrowsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IThrowsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0003DE94 File Offset: 0x0003C094
		private static Delegate GetExceptionClassesHandler()
		{
			if (IThrowsInvoker.cb_exceptionClasses == null)
			{
				IThrowsInvoker.cb_exceptionClasses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThrowsInvoker.n_ExceptionClasses));
			}
			return IThrowsInvoker.cb_exceptionClasses;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		private static IntPtr n_ExceptionClasses(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IThrows>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExceptionClasses());
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0003DECC File Offset: 0x0003C0CC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Class[] ExceptionClasses()
		{
			if (this.id_exceptionClasses == IntPtr.Zero)
			{
				this.id_exceptionClasses = JNIEnv.GetMethodID(this.class_ref, "exceptionClasses", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_exceptionClasses), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0003DF2C File Offset: 0x0003C12C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IThrowsInvoker.cb_annotationType == null)
			{
				IThrowsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThrowsInvoker.n_AnnotationType));
			}
			return IThrowsInvoker.cb_annotationType;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0003DF50 File Offset: 0x0003C150
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IThrows>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0003DF64 File Offset: 0x0003C164
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0003DFB5 File Offset: 0x0003C1B5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IThrowsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IThrowsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IThrowsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IThrowsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0003DFDC File Offset: 0x0003C1DC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IThrows>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0003E000 File Offset: 0x0003C200
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

		// Token: 0x06001302 RID: 4866 RVA: 0x0003E073 File Offset: 0x0003C273
		private static Delegate GetGetHashCodeHandler()
		{
			if (IThrowsInvoker.cb_hashCode == null)
			{
				IThrowsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IThrowsInvoker.n_GetHashCode));
			}
			return IThrowsInvoker.cb_hashCode;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0003E097 File Offset: 0x0003C297
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IThrows>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0003E0A6 File Offset: 0x0003C2A6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0003E0E6 File Offset: 0x0003C2E6
		private static Delegate GetToStringHandler()
		{
			if (IThrowsInvoker.cb_toString == null)
			{
				IThrowsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThrowsInvoker.n_ToString));
			}
			return IThrowsInvoker.cb_toString;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0003E10A File Offset: 0x0003C30A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IThrows>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0003E120 File Offset: 0x0003C320
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400064F RID: 1615
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/Throws", typeof(IThrowsInvoker));

		// Token: 0x04000650 RID: 1616
		private IntPtr class_ref;

		// Token: 0x04000651 RID: 1617
		[Nullable(2)]
		private static Delegate cb_exceptionClasses;

		// Token: 0x04000652 RID: 1618
		private IntPtr id_exceptionClasses;

		// Token: 0x04000653 RID: 1619
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000654 RID: 1620
		private IntPtr id_annotationType;

		// Token: 0x04000655 RID: 1621
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000656 RID: 1622
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000657 RID: 1623
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000658 RID: 1624
		private IntPtr id_hashCode;

		// Token: 0x04000659 RID: 1625
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400065A RID: 1626
		private IntPtr id_toString;
	}
}
