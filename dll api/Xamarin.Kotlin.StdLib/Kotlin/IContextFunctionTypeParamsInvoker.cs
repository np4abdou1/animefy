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
	// Token: 0x02000058 RID: 88
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ContextFunctionTypeParams", DoNotGenerateAcw = true)]
	internal class IContextFunctionTypeParamsInvoker : Java.Lang.Object, IContextFunctionTypeParams, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000036A4 File Offset: 0x000018A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IContextFunctionTypeParamsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000036C8 File Offset: 0x000018C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContextFunctionTypeParamsInvoker._members;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000036CF File Offset: 0x000018CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000036D7 File Offset: 0x000018D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContextFunctionTypeParamsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000036E3 File Offset: 0x000018E3
		[NullableContext(2)]
		public static IContextFunctionTypeParams GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContextFunctionTypeParams>(handle, transfer);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000036EC File Offset: 0x000018EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContextFunctionTypeParamsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ContextFunctionTypeParams'.");
			}
			return handle;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003717 File Offset: 0x00001917
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003748 File Offset: 0x00001948
		public IContextFunctionTypeParamsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContextFunctionTypeParamsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00003780 File Offset: 0x00001980
		private static Delegate GetCountHandler()
		{
			if (IContextFunctionTypeParamsInvoker.cb_count == null)
			{
				IContextFunctionTypeParamsInvoker.cb_count = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IContextFunctionTypeParamsInvoker.n_Count));
			}
			return IContextFunctionTypeParamsInvoker.cb_count;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000037A4 File Offset: 0x000019A4
		private static int n_Count(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IContextFunctionTypeParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000037B3 File Offset: 0x000019B3
		public int Count()
		{
			if (this.id_count == IntPtr.Zero)
			{
				this.id_count = JNIEnv.GetMethodID(this.class_ref, "count", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_count);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000037F3 File Offset: 0x000019F3
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IContextFunctionTypeParamsInvoker.cb_annotationType == null)
			{
				IContextFunctionTypeParamsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContextFunctionTypeParamsInvoker.n_AnnotationType));
			}
			return IContextFunctionTypeParamsInvoker.cb_annotationType;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00003817 File Offset: 0x00001A17
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContextFunctionTypeParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000382C File Offset: 0x00001A2C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000387D File Offset: 0x00001A7D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IContextFunctionTypeParamsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IContextFunctionTypeParamsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IContextFunctionTypeParamsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IContextFunctionTypeParamsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000038A4 File Offset: 0x00001AA4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IContextFunctionTypeParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000038C8 File Offset: 0x00001AC8
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

		// Token: 0x06000185 RID: 389 RVA: 0x0000393B File Offset: 0x00001B3B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IContextFunctionTypeParamsInvoker.cb_hashCode == null)
			{
				IContextFunctionTypeParamsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IContextFunctionTypeParamsInvoker.n_GetHashCode));
			}
			return IContextFunctionTypeParamsInvoker.cb_hashCode;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000395F File Offset: 0x00001B5F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IContextFunctionTypeParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000396E File Offset: 0x00001B6E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000039AE File Offset: 0x00001BAE
		private static Delegate GetToStringHandler()
		{
			if (IContextFunctionTypeParamsInvoker.cb_toString == null)
			{
				IContextFunctionTypeParamsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContextFunctionTypeParamsInvoker.n_ToString));
			}
			return IContextFunctionTypeParamsInvoker.cb_toString;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000039D2 File Offset: 0x00001BD2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IContextFunctionTypeParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000039E8 File Offset: 0x00001BE8
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400002A RID: 42
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ContextFunctionTypeParams", typeof(IContextFunctionTypeParamsInvoker));

		// Token: 0x0400002B RID: 43
		private IntPtr class_ref;

		// Token: 0x0400002C RID: 44
		[Nullable(2)]
		private static Delegate cb_count;

		// Token: 0x0400002D RID: 45
		private IntPtr id_count;

		// Token: 0x0400002E RID: 46
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400002F RID: 47
		private IntPtr id_annotationType;

		// Token: 0x04000030 RID: 48
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000031 RID: 49
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000032 RID: 50
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000033 RID: 51
		private IntPtr id_hashCode;

		// Token: 0x04000034 RID: 52
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000035 RID: 53
		private IntPtr id_toString;
	}
}
