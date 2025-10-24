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
	// Token: 0x02000025 RID: 37
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/NonNls", DoNotGenerateAcw = true)]
	internal class INonNlsInvoker : Java.Lang.Object, INonNls, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004038 File Offset: 0x00002238
		private static IntPtr java_class_ref
		{
			get
			{
				return INonNlsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000405C File Offset: 0x0000225C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INonNlsInvoker._members;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004063 File Offset: 0x00002263
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000406B File Offset: 0x0000226B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INonNlsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004077 File Offset: 0x00002277
		[NullableContext(2)]
		public static INonNls GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INonNls>(handle, transfer);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004080 File Offset: 0x00002280
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INonNlsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.NonNls'.");
			}
			return handle;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000040AB File Offset: 0x000022AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000040DC File Offset: 0x000022DC
		public INonNlsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INonNlsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004114 File Offset: 0x00002314
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INonNlsInvoker.cb_annotationType == null)
			{
				INonNlsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INonNlsInvoker.n_AnnotationType));
			}
			return INonNlsInvoker.cb_annotationType;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004138 File Offset: 0x00002338
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INonNls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000414C File Offset: 0x0000234C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000419D File Offset: 0x0000239D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INonNlsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INonNlsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INonNlsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INonNlsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000041C4 File Offset: 0x000023C4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INonNls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000041E8 File Offset: 0x000023E8
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

		// Token: 0x06000108 RID: 264 RVA: 0x0000425B File Offset: 0x0000245B
		private static Delegate GetGetHashCodeHandler()
		{
			if (INonNlsInvoker.cb_hashCode == null)
			{
				INonNlsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INonNlsInvoker.n_GetHashCode));
			}
			return INonNlsInvoker.cb_hashCode;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000427F File Offset: 0x0000247F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INonNls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000428E File Offset: 0x0000248E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000042CE File Offset: 0x000024CE
		private static Delegate GetToStringHandler()
		{
			if (INonNlsInvoker.cb_toString == null)
			{
				INonNlsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INonNlsInvoker.n_ToString));
			}
			return INonNlsInvoker.cb_toString;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000042F2 File Offset: 0x000024F2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INonNls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004308 File Offset: 0x00002508
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000063 RID: 99
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/NonNls", typeof(INonNlsInvoker));

		// Token: 0x04000064 RID: 100
		private IntPtr class_ref;

		// Token: 0x04000065 RID: 101
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000066 RID: 102
		private IntPtr id_annotationType;

		// Token: 0x04000067 RID: 103
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000068 RID: 104
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000069 RID: 105
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400006A RID: 106
		private IntPtr id_hashCode;

		// Token: 0x0400006B RID: 107
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400006C RID: 108
		private IntPtr id_toString;
	}
}
