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
	// Token: 0x02000014 RID: 20
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Blocking", DoNotGenerateAcw = true)]
	internal class IBlockingInvoker : Java.Lang.Object, IBlocking, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002284 File Offset: 0x00000484
		private static IntPtr java_class_ref
		{
			get
			{
				return IBlockingInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000022A8 File Offset: 0x000004A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBlockingInvoker._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022AF File Offset: 0x000004AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000022B7 File Offset: 0x000004B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBlockingInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000022C3 File Offset: 0x000004C3
		[NullableContext(2)]
		public static IBlocking GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBlocking>(handle, transfer);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000022CC File Offset: 0x000004CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBlockingInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Blocking'.");
			}
			return handle;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022F7 File Offset: 0x000004F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002328 File Offset: 0x00000528
		public IBlockingInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBlockingInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002360 File Offset: 0x00000560
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBlockingInvoker.cb_annotationType == null)
			{
				IBlockingInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBlockingInvoker.n_AnnotationType));
			}
			return IBlockingInvoker.cb_annotationType;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002384 File Offset: 0x00000584
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002398 File Offset: 0x00000598
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000023E9 File Offset: 0x000005E9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBlockingInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBlockingInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBlockingInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBlockingInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002410 File Offset: 0x00000610
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002434 File Offset: 0x00000634
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

		// Token: 0x06000045 RID: 69 RVA: 0x000024A7 File Offset: 0x000006A7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBlockingInvoker.cb_hashCode == null)
			{
				IBlockingInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBlockingInvoker.n_GetHashCode));
			}
			return IBlockingInvoker.cb_hashCode;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000024CB File Offset: 0x000006CB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000024DA File Offset: 0x000006DA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000251A File Offset: 0x0000071A
		private static Delegate GetToStringHandler()
		{
			if (IBlockingInvoker.cb_toString == null)
			{
				IBlockingInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBlockingInvoker.n_ToString));
			}
			return IBlockingInvoker.cb_toString;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000253E File Offset: 0x0000073E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002554 File Offset: 0x00000754
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400000A RID: 10
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Blocking", typeof(IBlockingInvoker));

		// Token: 0x0400000B RID: 11
		private IntPtr class_ref;

		// Token: 0x0400000C RID: 12
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400000D RID: 13
		private IntPtr id_annotationType;

		// Token: 0x0400000E RID: 14
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400000F RID: 15
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000010 RID: 16
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000011 RID: 17
		private IntPtr id_hashCode;

		// Token: 0x04000012 RID: 18
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000013 RID: 19
		private IntPtr id_toString;
	}
}
