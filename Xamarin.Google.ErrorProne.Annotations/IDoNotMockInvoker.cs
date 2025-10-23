using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200001A RID: 26
	[Register("com/google/errorprone/annotations/DoNotMock", DoNotGenerateAcw = true)]
	internal class IDoNotMockInvoker : Java.Lang.Object, IDoNotMock, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000031D0 File Offset: 0x000013D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IDoNotMockInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000031F4 File Offset: 0x000013F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDoNotMockInvoker._members;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000031FB File Offset: 0x000013FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003203 File Offset: 0x00001403
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDoNotMockInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000320F File Offset: 0x0000140F
		public static IDoNotMock GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDoNotMock>(handle, transfer);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003218 File Offset: 0x00001418
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDoNotMockInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.DoNotMock'.");
			}
			return handle;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003243 File Offset: 0x00001443
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003274 File Offset: 0x00001474
		public IDoNotMockInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDoNotMockInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000032AC File Offset: 0x000014AC
		private static Delegate GetValueHandler()
		{
			if (IDoNotMockInvoker.cb_value == null)
			{
				IDoNotMockInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDoNotMockInvoker.n_Value));
			}
			return IDoNotMockInvoker.cb_value;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000032D0 File Offset: 0x000014D0
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDoNotMock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000032E4 File Offset: 0x000014E4
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003335 File Offset: 0x00001535
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IDoNotMockInvoker.cb_annotationType == null)
			{
				IDoNotMockInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDoNotMockInvoker.n_AnnotationType));
			}
			return IDoNotMockInvoker.cb_annotationType;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003359 File Offset: 0x00001559
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDoNotMock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003370 File Offset: 0x00001570
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000033C1 File Offset: 0x000015C1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IDoNotMockInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IDoNotMockInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDoNotMockInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IDoNotMockInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000033E8 File Offset: 0x000015E8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IDoNotMock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000340C File Offset: 0x0000160C
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

		// Token: 0x060000A0 RID: 160 RVA: 0x0000347F File Offset: 0x0000167F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IDoNotMockInvoker.cb_hashCode == null)
			{
				IDoNotMockInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDoNotMockInvoker.n_GetHashCode));
			}
			return IDoNotMockInvoker.cb_hashCode;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000034A3 File Offset: 0x000016A3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDoNotMock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000034B2 File Offset: 0x000016B2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000034F2 File Offset: 0x000016F2
		private static Delegate GetToStringHandler()
		{
			if (IDoNotMockInvoker.cb_toString == null)
			{
				IDoNotMockInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDoNotMockInvoker.n_ToString));
			}
			return IDoNotMockInvoker.cb_toString;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003516 File Offset: 0x00001716
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDoNotMock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000352C File Offset: 0x0000172C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400003A RID: 58
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/DoNotMock", typeof(IDoNotMockInvoker));

		// Token: 0x0400003B RID: 59
		private IntPtr class_ref;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_value;

		// Token: 0x0400003D RID: 61
		private IntPtr id_value;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_annotationType;

		// Token: 0x0400003F RID: 63
		private IntPtr id_annotationType;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000041 RID: 65
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_hashCode;

		// Token: 0x04000043 RID: 67
		private IntPtr id_hashCode;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_toString;

		// Token: 0x04000045 RID: 69
		private IntPtr id_toString;
	}
}
