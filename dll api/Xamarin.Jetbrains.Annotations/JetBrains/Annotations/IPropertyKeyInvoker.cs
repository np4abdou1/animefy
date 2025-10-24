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
	// Token: 0x0200002B RID: 43
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/PropertyKey", DoNotGenerateAcw = true)]
	internal class IPropertyKeyInvoker : Java.Lang.Object, IPropertyKey, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00004B90 File Offset: 0x00002D90
		private static IntPtr java_class_ref
		{
			get
			{
				return IPropertyKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00004BB4 File Offset: 0x00002DB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPropertyKeyInvoker._members;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00004BBB File Offset: 0x00002DBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00004BC3 File Offset: 0x00002DC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPropertyKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00004BCF File Offset: 0x00002DCF
		[NullableContext(2)]
		public static IPropertyKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPropertyKey>(handle, transfer);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004BD8 File Offset: 0x00002DD8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPropertyKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.PropertyKey'.");
			}
			return handle;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004C03 File Offset: 0x00002E03
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00004C34 File Offset: 0x00002E34
		public IPropertyKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPropertyKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004C6C File Offset: 0x00002E6C
		private static Delegate GetResourceBundleHandler()
		{
			if (IPropertyKeyInvoker.cb_resourceBundle == null)
			{
				IPropertyKeyInvoker.cb_resourceBundle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPropertyKeyInvoker.n_ResourceBundle));
			}
			return IPropertyKeyInvoker.cb_resourceBundle;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004C90 File Offset: 0x00002E90
		private static IntPtr n_ResourceBundle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPropertyKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceBundle());
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00004CA4 File Offset: 0x00002EA4
		[NullableContext(2)]
		public string ResourceBundle()
		{
			if (this.id_resourceBundle == IntPtr.Zero)
			{
				this.id_resourceBundle = JNIEnv.GetMethodID(this.class_ref, "resourceBundle", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_resourceBundle), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004CF5 File Offset: 0x00002EF5
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IPropertyKeyInvoker.cb_annotationType == null)
			{
				IPropertyKeyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPropertyKeyInvoker.n_AnnotationType));
			}
			return IPropertyKeyInvoker.cb_annotationType;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00004D19 File Offset: 0x00002F19
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPropertyKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00004D30 File Offset: 0x00002F30
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004D81 File Offset: 0x00002F81
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IPropertyKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IPropertyKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPropertyKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IPropertyKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00004DA8 File Offset: 0x00002FA8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IPropertyKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00004DCC File Offset: 0x00002FCC
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

		// Token: 0x06000157 RID: 343 RVA: 0x00004E3F File Offset: 0x0000303F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IPropertyKeyInvoker.cb_hashCode == null)
			{
				IPropertyKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPropertyKeyInvoker.n_GetHashCode));
			}
			return IPropertyKeyInvoker.cb_hashCode;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00004E63 File Offset: 0x00003063
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPropertyKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00004E72 File Offset: 0x00003072
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00004EB2 File Offset: 0x000030B2
		private static Delegate GetToStringHandler()
		{
			if (IPropertyKeyInvoker.cb_toString == null)
			{
				IPropertyKeyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPropertyKeyInvoker.n_ToString));
			}
			return IPropertyKeyInvoker.cb_toString;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00004ED6 File Offset: 0x000030D6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPropertyKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00004EEC File Offset: 0x000030EC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000087 RID: 135
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/PropertyKey", typeof(IPropertyKeyInvoker));

		// Token: 0x04000088 RID: 136
		private IntPtr class_ref;

		// Token: 0x04000089 RID: 137
		[Nullable(2)]
		private static Delegate cb_resourceBundle;

		// Token: 0x0400008A RID: 138
		private IntPtr id_resourceBundle;

		// Token: 0x0400008B RID: 139
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400008C RID: 140
		private IntPtr id_annotationType;

		// Token: 0x0400008D RID: 141
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400008E RID: 142
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400008F RID: 143
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000090 RID: 144
		private IntPtr id_hashCode;

		// Token: 0x04000091 RID: 145
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000092 RID: 146
		private IntPtr id_toString;
	}
}
