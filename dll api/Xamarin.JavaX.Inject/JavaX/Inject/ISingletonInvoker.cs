using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000012 RID: 18
	[Register("javax/inject/Singleton", DoNotGenerateAcw = true)]
	internal class ISingletonInvoker : Java.Lang.Object, ISingleton, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002F54 File Offset: 0x00001154
		private static IntPtr java_class_ref
		{
			get
			{
				return ISingletonInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002F78 File Offset: 0x00001178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISingletonInvoker._members;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002F7F File Offset: 0x0000117F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002F87 File Offset: 0x00001187
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISingletonInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002F93 File Offset: 0x00001193
		public static ISingleton GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISingleton>(handle, transfer);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002F9C File Offset: 0x0000119C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISingletonInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.inject.Singleton'.");
			}
			return handle;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002FC7 File Offset: 0x000011C7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002FF8 File Offset: 0x000011F8
		public ISingletonInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISingletonInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003030 File Offset: 0x00001230
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISingletonInvoker.cb_annotationType == null)
			{
				ISingletonInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISingletonInvoker.n_AnnotationType));
			}
			return ISingletonInvoker.cb_annotationType;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003054 File Offset: 0x00001254
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISingleton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003068 File Offset: 0x00001268
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000030B9 File Offset: 0x000012B9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISingletonInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISingletonInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISingletonInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISingletonInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000030E0 File Offset: 0x000012E0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISingleton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003104 File Offset: 0x00001304
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

		// Token: 0x06000082 RID: 130 RVA: 0x00003177 File Offset: 0x00001377
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISingletonInvoker.cb_hashCode == null)
			{
				ISingletonInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISingletonInvoker.n_GetHashCode));
			}
			return ISingletonInvoker.cb_hashCode;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000319B File Offset: 0x0000139B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISingleton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000031AA File Offset: 0x000013AA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000031EA File Offset: 0x000013EA
		private static Delegate GetToStringHandler()
		{
			if (ISingletonInvoker.cb_toString == null)
			{
				ISingletonInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISingletonInvoker.n_ToString));
			}
			return ISingletonInvoker.cb_toString;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000320E File Offset: 0x0000140E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISingleton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003224 File Offset: 0x00001424
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400002F RID: 47
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/inject/Singleton", typeof(ISingletonInvoker));

		// Token: 0x04000030 RID: 48
		private IntPtr class_ref;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_annotationType;

		// Token: 0x04000032 RID: 50
		private IntPtr id_annotationType;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000034 RID: 52
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_hashCode;

		// Token: 0x04000036 RID: 54
		private IntPtr id_hashCode;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_toString;

		// Token: 0x04000038 RID: 56
		private IntPtr id_toString;
	}
}
