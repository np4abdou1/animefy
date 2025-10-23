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
	// Token: 0x0200001C RID: 28
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/MustBeInvokedByOverriders", DoNotGenerateAcw = true)]
	internal class IMustBeInvokedByOverridersInvoker : Java.Lang.Object, IMustBeInvokedByOverriders, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000030FC File Offset: 0x000012FC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMustBeInvokedByOverridersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003120 File Offset: 0x00001320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMustBeInvokedByOverridersInvoker._members;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003127 File Offset: 0x00001327
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000312F File Offset: 0x0000132F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMustBeInvokedByOverridersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000313B File Offset: 0x0000133B
		[NullableContext(2)]
		public static IMustBeInvokedByOverriders GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMustBeInvokedByOverriders>(handle, transfer);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003144 File Offset: 0x00001344
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMustBeInvokedByOverridersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.MustBeInvokedByOverriders'.");
			}
			return handle;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000316F File Offset: 0x0000136F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000031A0 File Offset: 0x000013A0
		public IMustBeInvokedByOverridersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMustBeInvokedByOverridersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000031D8 File Offset: 0x000013D8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMustBeInvokedByOverridersInvoker.cb_annotationType == null)
			{
				IMustBeInvokedByOverridersInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMustBeInvokedByOverridersInvoker.n_AnnotationType));
			}
			return IMustBeInvokedByOverridersInvoker.cb_annotationType;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000031FC File Offset: 0x000013FC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMustBeInvokedByOverriders>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003210 File Offset: 0x00001410
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003261 File Offset: 0x00001461
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMustBeInvokedByOverridersInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMustBeInvokedByOverridersInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMustBeInvokedByOverridersInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMustBeInvokedByOverridersInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003288 File Offset: 0x00001488
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMustBeInvokedByOverriders>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000032AC File Offset: 0x000014AC
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

		// Token: 0x060000A5 RID: 165 RVA: 0x0000331F File Offset: 0x0000151F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMustBeInvokedByOverridersInvoker.cb_hashCode == null)
			{
				IMustBeInvokedByOverridersInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMustBeInvokedByOverridersInvoker.n_GetHashCode));
			}
			return IMustBeInvokedByOverridersInvoker.cb_hashCode;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003343 File Offset: 0x00001543
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMustBeInvokedByOverriders>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003352 File Offset: 0x00001552
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003392 File Offset: 0x00001592
		private static Delegate GetToStringHandler()
		{
			if (IMustBeInvokedByOverridersInvoker.cb_toString == null)
			{
				IMustBeInvokedByOverridersInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMustBeInvokedByOverridersInvoker.n_ToString));
			}
			return IMustBeInvokedByOverridersInvoker.cb_toString;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000033B6 File Offset: 0x000015B6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMustBeInvokedByOverriders>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000033CC File Offset: 0x000015CC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000038 RID: 56
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/MustBeInvokedByOverriders", typeof(IMustBeInvokedByOverridersInvoker));

		// Token: 0x04000039 RID: 57
		private IntPtr class_ref;

		// Token: 0x0400003A RID: 58
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400003B RID: 59
		private IntPtr id_annotationType;

		// Token: 0x0400003C RID: 60
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400003D RID: 61
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400003E RID: 62
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400003F RID: 63
		private IntPtr id_hashCode;

		// Token: 0x04000040 RID: 64
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000041 RID: 65
		private IntPtr id_toString;
	}
}
