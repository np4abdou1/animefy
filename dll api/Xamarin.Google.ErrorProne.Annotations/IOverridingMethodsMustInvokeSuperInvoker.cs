using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000034 RID: 52
	[Register("com/google/errorprone/annotations/OverridingMethodsMustInvokeSuper", DoNotGenerateAcw = true)]
	internal class IOverridingMethodsMustInvokeSuperInvoker : Java.Lang.Object, IOverridingMethodsMustInvokeSuper, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000059C0 File Offset: 0x00003BC0
		private static IntPtr java_class_ref
		{
			get
			{
				return IOverridingMethodsMustInvokeSuperInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000059E4 File Offset: 0x00003BE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOverridingMethodsMustInvokeSuperInvoker._members;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000059EB File Offset: 0x00003BEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000059F3 File Offset: 0x00003BF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOverridingMethodsMustInvokeSuperInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000059FF File Offset: 0x00003BFF
		public static IOverridingMethodsMustInvokeSuper GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOverridingMethodsMustInvokeSuper>(handle, transfer);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005A08 File Offset: 0x00003C08
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOverridingMethodsMustInvokeSuperInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.OverridingMethodsMustInvokeSuper'.");
			}
			return handle;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005A33 File Offset: 0x00003C33
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00005A64 File Offset: 0x00003C64
		public IOverridingMethodsMustInvokeSuperInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOverridingMethodsMustInvokeSuperInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005A9C File Offset: 0x00003C9C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IOverridingMethodsMustInvokeSuperInvoker.cb_annotationType == null)
			{
				IOverridingMethodsMustInvokeSuperInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOverridingMethodsMustInvokeSuperInvoker.n_AnnotationType));
			}
			return IOverridingMethodsMustInvokeSuperInvoker.cb_annotationType;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005AC0 File Offset: 0x00003CC0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOverridingMethodsMustInvokeSuper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005B25 File Offset: 0x00003D25
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IOverridingMethodsMustInvokeSuperInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IOverridingMethodsMustInvokeSuperInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IOverridingMethodsMustInvokeSuperInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IOverridingMethodsMustInvokeSuperInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005B4C File Offset: 0x00003D4C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IOverridingMethodsMustInvokeSuper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005B70 File Offset: 0x00003D70
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

		// Token: 0x060001AD RID: 429 RVA: 0x00005BE3 File Offset: 0x00003DE3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IOverridingMethodsMustInvokeSuperInvoker.cb_hashCode == null)
			{
				IOverridingMethodsMustInvokeSuperInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IOverridingMethodsMustInvokeSuperInvoker.n_GetHashCode));
			}
			return IOverridingMethodsMustInvokeSuperInvoker.cb_hashCode;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005C07 File Offset: 0x00003E07
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IOverridingMethodsMustInvokeSuper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005C16 File Offset: 0x00003E16
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005C56 File Offset: 0x00003E56
		private static Delegate GetToStringHandler()
		{
			if (IOverridingMethodsMustInvokeSuperInvoker.cb_toString == null)
			{
				IOverridingMethodsMustInvokeSuperInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOverridingMethodsMustInvokeSuperInvoker.n_ToString));
			}
			return IOverridingMethodsMustInvokeSuperInvoker.cb_toString;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00005C7A File Offset: 0x00003E7A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IOverridingMethodsMustInvokeSuper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00005C90 File Offset: 0x00003E90
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000BB RID: 187
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/OverridingMethodsMustInvokeSuper", typeof(IOverridingMethodsMustInvokeSuperInvoker));

		// Token: 0x040000BC RID: 188
		private IntPtr class_ref;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_annotationType;

		// Token: 0x040000BE RID: 190
		private IntPtr id_annotationType;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000C0 RID: 192
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000C1 RID: 193
		private static Delegate cb_hashCode;

		// Token: 0x040000C2 RID: 194
		private IntPtr id_hashCode;

		// Token: 0x040000C3 RID: 195
		private static Delegate cb_toString;

		// Token: 0x040000C4 RID: 196
		private IntPtr id_toString;
	}
}
