using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000010 RID: 16
	[Register("com/google/errorprone/annotations/CanIgnoreReturnValue", DoNotGenerateAcw = true)]
	internal class ICanIgnoreReturnValueInvoker : Java.Lang.Object, ICanIgnoreReturnValue, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000208C File Offset: 0x0000028C
		private static IntPtr java_class_ref
		{
			get
			{
				return ICanIgnoreReturnValueInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020B0 File Offset: 0x000002B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICanIgnoreReturnValueInvoker._members;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000020B7 File Offset: 0x000002B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020BF File Offset: 0x000002BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICanIgnoreReturnValueInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020CB File Offset: 0x000002CB
		public static ICanIgnoreReturnValue GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICanIgnoreReturnValue>(handle, transfer);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020D4 File Offset: 0x000002D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICanIgnoreReturnValueInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.CanIgnoreReturnValue'.");
			}
			return handle;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020FF File Offset: 0x000002FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002130 File Offset: 0x00000330
		public ICanIgnoreReturnValueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICanIgnoreReturnValueInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002168 File Offset: 0x00000368
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ICanIgnoreReturnValueInvoker.cb_annotationType == null)
			{
				ICanIgnoreReturnValueInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICanIgnoreReturnValueInvoker.n_AnnotationType));
			}
			return ICanIgnoreReturnValueInvoker.cb_annotationType;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000218C File Offset: 0x0000038C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICanIgnoreReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021A0 File Offset: 0x000003A0
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000021F1 File Offset: 0x000003F1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ICanIgnoreReturnValueInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ICanIgnoreReturnValueInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICanIgnoreReturnValueInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ICanIgnoreReturnValueInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002218 File Offset: 0x00000418
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ICanIgnoreReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000223C File Offset: 0x0000043C
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

		// Token: 0x0600002B RID: 43 RVA: 0x000022AF File Offset: 0x000004AF
		private static Delegate GetGetHashCodeHandler()
		{
			if (ICanIgnoreReturnValueInvoker.cb_hashCode == null)
			{
				ICanIgnoreReturnValueInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICanIgnoreReturnValueInvoker.n_GetHashCode));
			}
			return ICanIgnoreReturnValueInvoker.cb_hashCode;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000022D3 File Offset: 0x000004D3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICanIgnoreReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000022E2 File Offset: 0x000004E2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002322 File Offset: 0x00000522
		private static Delegate GetToStringHandler()
		{
			if (ICanIgnoreReturnValueInvoker.cb_toString == null)
			{
				ICanIgnoreReturnValueInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICanIgnoreReturnValueInvoker.n_ToString));
			}
			return ICanIgnoreReturnValueInvoker.cb_toString;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002346 File Offset: 0x00000546
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICanIgnoreReturnValue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000235C File Offset: 0x0000055C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/CanIgnoreReturnValue", typeof(ICanIgnoreReturnValueInvoker));

		// Token: 0x04000005 RID: 5
		private IntPtr class_ref;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_annotationType;

		// Token: 0x04000007 RID: 7
		private IntPtr id_annotationType;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000009 RID: 9
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_hashCode;

		// Token: 0x0400000B RID: 11
		private IntPtr id_hashCode;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_toString;

		// Token: 0x0400000D RID: 13
		private IntPtr id_toString;
	}
}
