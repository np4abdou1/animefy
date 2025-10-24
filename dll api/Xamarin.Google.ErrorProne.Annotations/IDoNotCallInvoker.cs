using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000018 RID: 24
	[Register("com/google/errorprone/annotations/DoNotCall", DoNotGenerateAcw = true)]
	internal class IDoNotCallInvoker : Java.Lang.Object, IDoNotCall, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002E08 File Offset: 0x00001008
		private static IntPtr java_class_ref
		{
			get
			{
				return IDoNotCallInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002E2C File Offset: 0x0000102C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDoNotCallInvoker._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002E33 File Offset: 0x00001033
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002E3B File Offset: 0x0000103B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDoNotCallInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002E47 File Offset: 0x00001047
		public static IDoNotCall GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDoNotCall>(handle, transfer);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002E50 File Offset: 0x00001050
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDoNotCallInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.DoNotCall'.");
			}
			return handle;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002E7B File Offset: 0x0000107B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002EAC File Offset: 0x000010AC
		public IDoNotCallInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDoNotCallInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002EE4 File Offset: 0x000010E4
		private static Delegate GetValueHandler()
		{
			if (IDoNotCallInvoker.cb_value == null)
			{
				IDoNotCallInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDoNotCallInvoker.n_Value));
			}
			return IDoNotCallInvoker.cb_value;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002F08 File Offset: 0x00001108
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDoNotCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002F1C File Offset: 0x0000111C
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002F6D File Offset: 0x0000116D
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IDoNotCallInvoker.cb_annotationType == null)
			{
				IDoNotCallInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDoNotCallInvoker.n_AnnotationType));
			}
			return IDoNotCallInvoker.cb_annotationType;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002F91 File Offset: 0x00001191
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDoNotCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002FA8 File Offset: 0x000011A8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002FF9 File Offset: 0x000011F9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IDoNotCallInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IDoNotCallInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDoNotCallInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IDoNotCallInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003020 File Offset: 0x00001220
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IDoNotCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003044 File Offset: 0x00001244
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

		// Token: 0x06000087 RID: 135 RVA: 0x000030B7 File Offset: 0x000012B7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IDoNotCallInvoker.cb_hashCode == null)
			{
				IDoNotCallInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDoNotCallInvoker.n_GetHashCode));
			}
			return IDoNotCallInvoker.cb_hashCode;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000030DB File Offset: 0x000012DB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDoNotCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000030EA File Offset: 0x000012EA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000312A File Offset: 0x0000132A
		private static Delegate GetToStringHandler()
		{
			if (IDoNotCallInvoker.cb_toString == null)
			{
				IDoNotCallInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDoNotCallInvoker.n_ToString));
			}
			return IDoNotCallInvoker.cb_toString;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000314E File Offset: 0x0000134E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDoNotCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003164 File Offset: 0x00001364
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400002E RID: 46
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/DoNotCall", typeof(IDoNotCallInvoker));

		// Token: 0x0400002F RID: 47
		private IntPtr class_ref;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_value;

		// Token: 0x04000031 RID: 49
		private IntPtr id_value;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_annotationType;

		// Token: 0x04000033 RID: 51
		private IntPtr id_annotationType;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000035 RID: 53
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_hashCode;

		// Token: 0x04000037 RID: 55
		private IntPtr id_hashCode;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_toString;

		// Token: 0x04000039 RID: 57
		private IntPtr id_toString;
	}
}
