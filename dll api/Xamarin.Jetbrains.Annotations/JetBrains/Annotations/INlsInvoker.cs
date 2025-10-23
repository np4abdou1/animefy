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
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Nls", DoNotGenerateAcw = true)]
	internal class INlsInvoker : Java.Lang.Object, INls, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000035F8 File Offset: 0x000017F8
		private static IntPtr java_class_ref
		{
			get
			{
				return INlsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000361C File Offset: 0x0000181C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INlsInvoker._members;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003623 File Offset: 0x00001823
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000362B File Offset: 0x0000182B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INlsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003637 File Offset: 0x00001837
		[NullableContext(2)]
		public static INls GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INls>(handle, transfer);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003640 File Offset: 0x00001840
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INlsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Nls'.");
			}
			return handle;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000366B File Offset: 0x0000186B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000369C File Offset: 0x0000189C
		public INlsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INlsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000036D4 File Offset: 0x000018D4
		private static Delegate GetCapitalizationHandler()
		{
			if (INlsInvoker.cb_capitalization == null)
			{
				INlsInvoker.cb_capitalization = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INlsInvoker.n_Capitalization));
			}
			return INlsInvoker.cb_capitalization;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000036F8 File Offset: 0x000018F8
		private static IntPtr n_Capitalization(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Capitalization());
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000370C File Offset: 0x0000190C
		[NullableContext(2)]
		public NlsCapitalization Capitalization()
		{
			if (this.id_capitalization == IntPtr.Zero)
			{
				this.id_capitalization = JNIEnv.GetMethodID(this.class_ref, "capitalization", "()Lorg/jetbrains/annotations/Nls$Capitalization;");
			}
			return Java.Lang.Object.GetObject<NlsCapitalization>(JNIEnv.CallObjectMethod(base.Handle, this.id_capitalization), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000375D File Offset: 0x0000195D
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INlsInvoker.cb_annotationType == null)
			{
				INlsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INlsInvoker.n_AnnotationType));
			}
			return INlsInvoker.cb_annotationType;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003781 File Offset: 0x00001981
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003798 File Offset: 0x00001998
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000037E9 File Offset: 0x000019E9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INlsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INlsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INlsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INlsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003810 File Offset: 0x00001A10
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003834 File Offset: 0x00001A34
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

		// Token: 0x060000C9 RID: 201 RVA: 0x000038A7 File Offset: 0x00001AA7
		private static Delegate GetGetHashCodeHandler()
		{
			if (INlsInvoker.cb_hashCode == null)
			{
				INlsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INlsInvoker.n_GetHashCode));
			}
			return INlsInvoker.cb_hashCode;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000038CB File Offset: 0x00001ACB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000038DA File Offset: 0x00001ADA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000391A File Offset: 0x00001B1A
		private static Delegate GetToStringHandler()
		{
			if (INlsInvoker.cb_toString == null)
			{
				INlsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INlsInvoker.n_ToString));
			}
			return INlsInvoker.cb_toString;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000393E File Offset: 0x00001B3E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INls>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003954 File Offset: 0x00001B54
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000043 RID: 67
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Nls", typeof(INlsInvoker));

		// Token: 0x04000044 RID: 68
		private IntPtr class_ref;

		// Token: 0x04000045 RID: 69
		[Nullable(2)]
		private static Delegate cb_capitalization;

		// Token: 0x04000046 RID: 70
		private IntPtr id_capitalization;

		// Token: 0x04000047 RID: 71
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000048 RID: 72
		private IntPtr id_annotationType;

		// Token: 0x04000049 RID: 73
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400004A RID: 74
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400004B RID: 75
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400004C RID: 76
		private IntPtr id_hashCode;

		// Token: 0x0400004D RID: 77
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400004E RID: 78
		private IntPtr id_toString;
	}
}
