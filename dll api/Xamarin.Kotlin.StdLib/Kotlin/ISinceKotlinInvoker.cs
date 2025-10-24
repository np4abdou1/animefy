using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000080 RID: 128
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/SinceKotlin", DoNotGenerateAcw = true)]
	internal class ISinceKotlinInvoker : Java.Lang.Object, ISinceKotlin, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00007E4C File Offset: 0x0000604C
		private static IntPtr java_class_ref
		{
			get
			{
				return ISinceKotlinInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00007E70 File Offset: 0x00006070
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISinceKotlinInvoker._members;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00007E77 File Offset: 0x00006077
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00007E7F File Offset: 0x0000607F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISinceKotlinInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00007E8B File Offset: 0x0000608B
		[NullableContext(2)]
		public static ISinceKotlin GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISinceKotlin>(handle, transfer);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00007E94 File Offset: 0x00006094
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISinceKotlinInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.SinceKotlin'.");
			}
			return handle;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00007EBF File Offset: 0x000060BF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00007EF0 File Offset: 0x000060F0
		public ISinceKotlinInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISinceKotlinInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00007F28 File Offset: 0x00006128
		private static Delegate GetVersionHandler()
		{
			if (ISinceKotlinInvoker.cb_version == null)
			{
				ISinceKotlinInvoker.cb_version = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISinceKotlinInvoker.n_Version));
			}
			return ISinceKotlinInvoker.cb_version;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00007F4C File Offset: 0x0000614C
		private static IntPtr n_Version(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Version());
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00007F60 File Offset: 0x00006160
		[NullableContext(2)]
		public string Version()
		{
			if (this.id_version == IntPtr.Zero)
			{
				this.id_version = JNIEnv.GetMethodID(this.class_ref, "version", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_version), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00007FB1 File Offset: 0x000061B1
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISinceKotlinInvoker.cb_annotationType == null)
			{
				ISinceKotlinInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISinceKotlinInvoker.n_AnnotationType));
			}
			return ISinceKotlinInvoker.cb_annotationType;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00007FD5 File Offset: 0x000061D5
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00007FEC File Offset: 0x000061EC
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000803D File Offset: 0x0000623D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISinceKotlinInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISinceKotlinInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISinceKotlinInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISinceKotlinInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00008064 File Offset: 0x00006264
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00008088 File Offset: 0x00006288
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

		// Token: 0x06000369 RID: 873 RVA: 0x000080FB File Offset: 0x000062FB
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISinceKotlinInvoker.cb_hashCode == null)
			{
				ISinceKotlinInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISinceKotlinInvoker.n_GetHashCode));
			}
			return ISinceKotlinInvoker.cb_hashCode;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000811F File Offset: 0x0000631F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000812E File Offset: 0x0000632E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000816E File Offset: 0x0000636E
		private static Delegate GetToStringHandler()
		{
			if (ISinceKotlinInvoker.cb_toString == null)
			{
				ISinceKotlinInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISinceKotlinInvoker.n_ToString));
			}
			return ISinceKotlinInvoker.cb_toString;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00008192 File Offset: 0x00006392
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISinceKotlin>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000081A8 File Offset: 0x000063A8
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000108 RID: 264
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/SinceKotlin", typeof(ISinceKotlinInvoker));

		// Token: 0x04000109 RID: 265
		private IntPtr class_ref;

		// Token: 0x0400010A RID: 266
		[Nullable(2)]
		private static Delegate cb_version;

		// Token: 0x0400010B RID: 267
		private IntPtr id_version;

		// Token: 0x0400010C RID: 268
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400010D RID: 269
		private IntPtr id_annotationType;

		// Token: 0x0400010E RID: 270
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400010F RID: 271
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000110 RID: 272
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000111 RID: 273
		private IntPtr id_hashCode;

		// Token: 0x04000112 RID: 274
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000113 RID: 275
		private IntPtr id_toString;
	}
}
