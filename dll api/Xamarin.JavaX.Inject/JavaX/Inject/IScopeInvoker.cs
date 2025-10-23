using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000010 RID: 16
	[Register("javax/inject/Scope", DoNotGenerateAcw = true)]
	internal class IScopeInvoker : Java.Lang.Object, IScope, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002C18 File Offset: 0x00000E18
		private static IntPtr java_class_ref
		{
			get
			{
				return IScopeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002C3C File Offset: 0x00000E3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScopeInvoker._members;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002C43 File Offset: 0x00000E43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002C4B File Offset: 0x00000E4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScopeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002C57 File Offset: 0x00000E57
		public static IScope GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScope>(handle, transfer);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002C60 File Offset: 0x00000E60
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScopeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.inject.Scope'.");
			}
			return handle;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002C8B File Offset: 0x00000E8B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002CBC File Offset: 0x00000EBC
		public IScopeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScopeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002CF4 File Offset: 0x00000EF4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IScopeInvoker.cb_annotationType == null)
			{
				IScopeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IScopeInvoker.n_AnnotationType));
			}
			return IScopeInvoker.cb_annotationType;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002D18 File Offset: 0x00000F18
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002D2C File Offset: 0x00000F2C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002D7D File Offset: 0x00000F7D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IScopeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IScopeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IScopeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IScopeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002DA4 File Offset: 0x00000FA4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002DC8 File Offset: 0x00000FC8
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

		// Token: 0x0600006D RID: 109 RVA: 0x00002E3B File Offset: 0x0000103B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IScopeInvoker.cb_hashCode == null)
			{
				IScopeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScopeInvoker.n_GetHashCode));
			}
			return IScopeInvoker.cb_hashCode;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002E5F File Offset: 0x0000105F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002E6E File Offset: 0x0000106E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002EAE File Offset: 0x000010AE
		private static Delegate GetToStringHandler()
		{
			if (IScopeInvoker.cb_toString == null)
			{
				IScopeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IScopeInvoker.n_ToString));
			}
			return IScopeInvoker.cb_toString;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002ED2 File Offset: 0x000010D2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002EE8 File Offset: 0x000010E8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000025 RID: 37
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/inject/Scope", typeof(IScopeInvoker));

		// Token: 0x04000026 RID: 38
		private IntPtr class_ref;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_annotationType;

		// Token: 0x04000028 RID: 40
		private IntPtr id_annotationType;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400002A RID: 42
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_hashCode;

		// Token: 0x0400002C RID: 44
		private IntPtr id_hashCode;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_toString;

		// Token: 0x0400002E RID: 46
		private IntPtr id_toString;
	}
}
