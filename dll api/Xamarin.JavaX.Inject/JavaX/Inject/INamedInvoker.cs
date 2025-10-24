using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000009 RID: 9
	[Register("javax/inject/Named", DoNotGenerateAcw = true)]
	internal class INamedInvoker : Java.Lang.Object, INamed, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002394 File Offset: 0x00000594
		private static IntPtr java_class_ref
		{
			get
			{
				return INamedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000023B8 File Offset: 0x000005B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INamedInvoker._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000023BF File Offset: 0x000005BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000023C7 File Offset: 0x000005C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INamedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000023D3 File Offset: 0x000005D3
		public static INamed GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INamed>(handle, transfer);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000023DC File Offset: 0x000005DC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INamedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.inject.Named'.");
			}
			return handle;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002407 File Offset: 0x00000607
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002438 File Offset: 0x00000638
		public INamedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INamedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002470 File Offset: 0x00000670
		private static Delegate GetValueHandler()
		{
			if (INamedInvoker.cb_value == null)
			{
				INamedInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INamedInvoker.n_Value));
			}
			return INamedInvoker.cb_value;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002494 File Offset: 0x00000694
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INamed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024A8 File Offset: 0x000006A8
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024F9 File Offset: 0x000006F9
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INamedInvoker.cb_annotationType == null)
			{
				INamedInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INamedInvoker.n_AnnotationType));
			}
			return INamedInvoker.cb_annotationType;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000251D File Offset: 0x0000071D
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INamed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002534 File Offset: 0x00000734
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002585 File Offset: 0x00000785
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INamedInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INamedInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INamedInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INamedInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000025AC File Offset: 0x000007AC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INamed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// Token: 0x06000035 RID: 53 RVA: 0x00002643 File Offset: 0x00000843
		private static Delegate GetGetHashCodeHandler()
		{
			if (INamedInvoker.cb_hashCode == null)
			{
				INamedInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INamedInvoker.n_GetHashCode));
			}
			return INamedInvoker.cb_hashCode;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002667 File Offset: 0x00000867
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INamed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002676 File Offset: 0x00000876
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000026B6 File Offset: 0x000008B6
		private static Delegate GetToStringHandler()
		{
			if (INamedInvoker.cb_toString == null)
			{
				INamedInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INamedInvoker.n_ToString));
			}
			return INamedInvoker.cb_toString;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000026DA File Offset: 0x000008DA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INamed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000026F0 File Offset: 0x000008F0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400000B RID: 11
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/inject/Named", typeof(INamedInvoker));

		// Token: 0x0400000C RID: 12
		private IntPtr class_ref;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_value;

		// Token: 0x0400000E RID: 14
		private IntPtr id_value;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_annotationType;

		// Token: 0x04000010 RID: 16
		private IntPtr id_annotationType;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000012 RID: 18
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_hashCode;

		// Token: 0x04000014 RID: 20
		private IntPtr id_hashCode;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_toString;

		// Token: 0x04000016 RID: 22
		private IntPtr id_toString;
	}
}
