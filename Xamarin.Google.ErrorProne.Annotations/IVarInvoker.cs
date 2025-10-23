using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200003E RID: 62
	[Register("com/google/errorprone/annotations/Var", DoNotGenerateAcw = true)]
	internal class IVarInvoker : Java.Lang.Object, IVar, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00006D58 File Offset: 0x00004F58
		private static IntPtr java_class_ref
		{
			get
			{
				return IVarInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00006D7C File Offset: 0x00004F7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IVarInvoker._members;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00006D83 File Offset: 0x00004F83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00006D8B File Offset: 0x00004F8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IVarInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00006D97 File Offset: 0x00004F97
		public static IVar GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IVar>(handle, transfer);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00006DA0 File Offset: 0x00004FA0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IVarInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.Var'.");
			}
			return handle;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00006DCB File Offset: 0x00004FCB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00006DFC File Offset: 0x00004FFC
		public IVarInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IVarInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00006E34 File Offset: 0x00005034
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IVarInvoker.cb_annotationType == null)
			{
				IVarInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IVarInvoker.n_AnnotationType));
			}
			return IVarInvoker.cb_annotationType;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00006E58 File Offset: 0x00005058
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IVar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00006E6C File Offset: 0x0000506C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00006EBD File Offset: 0x000050BD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IVarInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IVarInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IVarInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IVarInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00006EE4 File Offset: 0x000050E4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IVar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00006F08 File Offset: 0x00005108
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

		// Token: 0x0600022E RID: 558 RVA: 0x00006F7B File Offset: 0x0000517B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IVarInvoker.cb_hashCode == null)
			{
				IVarInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IVarInvoker.n_GetHashCode));
			}
			return IVarInvoker.cb_hashCode;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00006F9F File Offset: 0x0000519F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IVar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00006FAE File Offset: 0x000051AE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00006FEE File Offset: 0x000051EE
		private static Delegate GetToStringHandler()
		{
			if (IVarInvoker.cb_toString == null)
			{
				IVarInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IVarInvoker.n_ToString));
			}
			return IVarInvoker.cb_toString;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007012 File Offset: 0x00005212
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IVar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007028 File Offset: 0x00005228
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000F9 RID: 249
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/Var", typeof(IVarInvoker));

		// Token: 0x040000FA RID: 250
		private IntPtr class_ref;

		// Token: 0x040000FB RID: 251
		private static Delegate cb_annotationType;

		// Token: 0x040000FC RID: 252
		private IntPtr id_annotationType;

		// Token: 0x040000FD RID: 253
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000FE RID: 254
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000FF RID: 255
		private static Delegate cb_hashCode;

		// Token: 0x04000100 RID: 256
		private IntPtr id_hashCode;

		// Token: 0x04000101 RID: 257
		private static Delegate cb_toString;

		// Token: 0x04000102 RID: 258
		private IntPtr id_toString;
	}
}
