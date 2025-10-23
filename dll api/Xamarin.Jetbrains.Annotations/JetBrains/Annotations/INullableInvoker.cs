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
	// Token: 0x02000029 RID: 41
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Nullable", DoNotGenerateAcw = true)]
	internal class INullableInvoker : Java.Lang.Object, INullable, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000047C8 File Offset: 0x000029C8
		private static IntPtr java_class_ref
		{
			get
			{
				return INullableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000047EC File Offset: 0x000029EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INullableInvoker._members;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000047F3 File Offset: 0x000029F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000047FB File Offset: 0x000029FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INullableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004807 File Offset: 0x00002A07
		[NullableContext(2)]
		public static INullable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INullable>(handle, transfer);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004810 File Offset: 0x00002A10
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INullableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Nullable'.");
			}
			return handle;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000483B File Offset: 0x00002A3B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000486C File Offset: 0x00002A6C
		public INullableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INullableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000048A4 File Offset: 0x00002AA4
		private static Delegate GetValueHandler()
		{
			if (INullableInvoker.cb_value == null)
			{
				INullableInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INullableInvoker.n_Value));
			}
			return INullableInvoker.cb_value;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000048C8 File Offset: 0x00002AC8
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INullable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000048DC File Offset: 0x00002ADC
		[NullableContext(2)]
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000492D File Offset: 0x00002B2D
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INullableInvoker.cb_annotationType == null)
			{
				INullableInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INullableInvoker.n_AnnotationType));
			}
			return INullableInvoker.cb_annotationType;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004951 File Offset: 0x00002B51
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INullable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004968 File Offset: 0x00002B68
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000049B9 File Offset: 0x00002BB9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INullableInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INullableInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INullableInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INullableInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000049E0 File Offset: 0x00002BE0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INullable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004A04 File Offset: 0x00002C04
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

		// Token: 0x0600013E RID: 318 RVA: 0x00004A77 File Offset: 0x00002C77
		private static Delegate GetGetHashCodeHandler()
		{
			if (INullableInvoker.cb_hashCode == null)
			{
				INullableInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INullableInvoker.n_GetHashCode));
			}
			return INullableInvoker.cb_hashCode;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004A9B File Offset: 0x00002C9B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INullable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004AAA File Offset: 0x00002CAA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004AEA File Offset: 0x00002CEA
		private static Delegate GetToStringHandler()
		{
			if (INullableInvoker.cb_toString == null)
			{
				INullableInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INullableInvoker.n_ToString));
			}
			return INullableInvoker.cb_toString;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004B0E File Offset: 0x00002D0E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INullable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004B24 File Offset: 0x00002D24
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400007B RID: 123
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Nullable", typeof(INullableInvoker));

		// Token: 0x0400007C RID: 124
		private IntPtr class_ref;

		// Token: 0x0400007D RID: 125
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x0400007E RID: 126
		private IntPtr id_value;

		// Token: 0x0400007F RID: 127
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000080 RID: 128
		private IntPtr id_annotationType;

		// Token: 0x04000081 RID: 129
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000082 RID: 130
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000083 RID: 131
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000084 RID: 132
		private IntPtr id_hashCode;

		// Token: 0x04000085 RID: 133
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000086 RID: 134
		private IntPtr id_toString;
	}
}
