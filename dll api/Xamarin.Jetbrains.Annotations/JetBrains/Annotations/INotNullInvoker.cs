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
	// Token: 0x02000027 RID: 39
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/NotNull", DoNotGenerateAcw = true)]
	internal class INotNullInvoker : Java.Lang.Object, INotNull, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004374 File Offset: 0x00002574
		private static IntPtr java_class_ref
		{
			get
			{
				return INotNullInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00004398 File Offset: 0x00002598
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return INotNullInvoker._members;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000439F File Offset: 0x0000259F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000043A7 File Offset: 0x000025A7
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return INotNullInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000043B3 File Offset: 0x000025B3
		public static INotNull GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INotNull>(handle, transfer);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000043BC File Offset: 0x000025BC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INotNullInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.NotNull'.");
			}
			return handle;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000043E7 File Offset: 0x000025E7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004418 File Offset: 0x00002618
		public INotNullInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INotNullInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004450 File Offset: 0x00002650
		[NullableContext(1)]
		private static Delegate GetExceptionHandler()
		{
			if (INotNullInvoker.cb_exception == null)
			{
				INotNullInvoker.cb_exception = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INotNullInvoker.n_Exception));
			}
			return INotNullInvoker.cb_exception;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004474 File Offset: 0x00002674
		private static IntPtr n_Exception(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Exception());
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004488 File Offset: 0x00002688
		public Class Exception()
		{
			if (this.id_exception == IntPtr.Zero)
			{
				this.id_exception = JNIEnv.GetMethodID(this.class_ref, "exception", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_exception), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000044D9 File Offset: 0x000026D9
		[NullableContext(1)]
		private static Delegate GetValueHandler()
		{
			if (INotNullInvoker.cb_value == null)
			{
				INotNullInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INotNullInvoker.n_Value));
			}
			return INotNullInvoker.cb_value;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000044FD File Offset: 0x000026FD
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004514 File Offset: 0x00002714
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004565 File Offset: 0x00002765
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INotNullInvoker.cb_annotationType == null)
			{
				INotNullInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INotNullInvoker.n_AnnotationType));
			}
			return INotNullInvoker.cb_annotationType;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004589 File Offset: 0x00002789
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000045A0 File Offset: 0x000027A0
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000045F1 File Offset: 0x000027F1
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INotNullInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INotNullInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INotNullInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INotNullInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004618 File Offset: 0x00002818
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000463C File Offset: 0x0000283C
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

		// Token: 0x06000125 RID: 293 RVA: 0x000046AF File Offset: 0x000028AF
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (INotNullInvoker.cb_hashCode == null)
			{
				INotNullInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INotNullInvoker.n_GetHashCode));
			}
			return INotNullInvoker.cb_hashCode;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000046D3 File Offset: 0x000028D3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000046E2 File Offset: 0x000028E2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004722 File Offset: 0x00002922
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (INotNullInvoker.cb_toString == null)
			{
				INotNullInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INotNullInvoker.n_ToString));
			}
			return INotNullInvoker.cb_toString;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004746 File Offset: 0x00002946
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000475C File Offset: 0x0000295C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400006D RID: 109
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/NotNull", typeof(INotNullInvoker));

		// Token: 0x0400006E RID: 110
		private IntPtr class_ref;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_exception;

		// Token: 0x04000070 RID: 112
		private IntPtr id_exception;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_value;

		// Token: 0x04000072 RID: 114
		private IntPtr id_value;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_annotationType;

		// Token: 0x04000074 RID: 116
		private IntPtr id_annotationType;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000076 RID: 118
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_hashCode;

		// Token: 0x04000078 RID: 120
		private IntPtr id_hashCode;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_toString;

		// Token: 0x0400007A RID: 122
		private IntPtr id_toString;
	}
}
