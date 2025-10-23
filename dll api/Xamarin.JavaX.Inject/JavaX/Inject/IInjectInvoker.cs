using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000007 RID: 7
	[Register("javax/inject/Inject", DoNotGenerateAcw = true)]
	internal class IInjectInvoker : Java.Lang.Object, IInject, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002058 File Offset: 0x00000258
		private static IntPtr java_class_ref
		{
			get
			{
				return IInjectInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000207C File Offset: 0x0000027C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInjectInvoker._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002083 File Offset: 0x00000283
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000208B File Offset: 0x0000028B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInjectInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002097 File Offset: 0x00000297
		public static IInject GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInject>(handle, transfer);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020A0 File Offset: 0x000002A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInjectInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.inject.Inject'.");
			}
			return handle;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020CB File Offset: 0x000002CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020FC File Offset: 0x000002FC
		public IInjectInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInjectInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002134 File Offset: 0x00000334
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IInjectInvoker.cb_annotationType == null)
			{
				IInjectInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInjectInvoker.n_AnnotationType));
			}
			return IInjectInvoker.cb_annotationType;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002158 File Offset: 0x00000358
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000216C File Offset: 0x0000036C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021BD File Offset: 0x000003BD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IInjectInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IInjectInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IInjectInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IInjectInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021E4 File Offset: 0x000003E4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IInject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002208 File Offset: 0x00000408
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

		// Token: 0x0600001C RID: 28 RVA: 0x0000227B File Offset: 0x0000047B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IInjectInvoker.cb_hashCode == null)
			{
				IInjectInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IInjectInvoker.n_GetHashCode));
			}
			return IInjectInvoker.cb_hashCode;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000229F File Offset: 0x0000049F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IInject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022AE File Offset: 0x000004AE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022EE File Offset: 0x000004EE
		private static Delegate GetToStringHandler()
		{
			if (IInjectInvoker.cb_toString == null)
			{
				IInjectInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInjectInvoker.n_ToString));
			}
			return IInjectInvoker.cb_toString;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002312 File Offset: 0x00000512
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002328 File Offset: 0x00000528
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/inject/Inject", typeof(IInjectInvoker));

		// Token: 0x04000002 RID: 2
		private IntPtr class_ref;

		// Token: 0x04000003 RID: 3
		private static Delegate cb_annotationType;

		// Token: 0x04000004 RID: 4
		private IntPtr id_annotationType;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000006 RID: 6
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_hashCode;

		// Token: 0x04000008 RID: 8
		private IntPtr id_hashCode;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_toString;

		// Token: 0x0400000A RID: 10
		private IntPtr id_toString;
	}
}
