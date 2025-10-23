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
	// Token: 0x02000056 RID: 86
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/BuilderInference", DoNotGenerateAcw = true)]
	internal class IBuilderInferenceInvoker : Java.Lang.Object, IBuilderInference, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00003368 File Offset: 0x00001568
		private static IntPtr java_class_ref
		{
			get
			{
				return IBuilderInferenceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000338C File Offset: 0x0000158C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBuilderInferenceInvoker._members;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00003393 File Offset: 0x00001593
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000339B File Offset: 0x0000159B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBuilderInferenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000033A7 File Offset: 0x000015A7
		[NullableContext(2)]
		public static IBuilderInference GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBuilderInference>(handle, transfer);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000033B0 File Offset: 0x000015B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBuilderInferenceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.BuilderInference'.");
			}
			return handle;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000033DB File Offset: 0x000015DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000340C File Offset: 0x0000160C
		public IBuilderInferenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBuilderInferenceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003444 File Offset: 0x00001644
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBuilderInferenceInvoker.cb_annotationType == null)
			{
				IBuilderInferenceInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBuilderInferenceInvoker.n_AnnotationType));
			}
			return IBuilderInferenceInvoker.cb_annotationType;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003468 File Offset: 0x00001668
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBuilderInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000347C File Offset: 0x0000167C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000034CD File Offset: 0x000016CD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBuilderInferenceInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBuilderInferenceInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBuilderInferenceInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBuilderInferenceInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000034F4 File Offset: 0x000016F4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBuilderInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00003518 File Offset: 0x00001718
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

		// Token: 0x0600016C RID: 364 RVA: 0x0000358B File Offset: 0x0000178B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBuilderInferenceInvoker.cb_hashCode == null)
			{
				IBuilderInferenceInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBuilderInferenceInvoker.n_GetHashCode));
			}
			return IBuilderInferenceInvoker.cb_hashCode;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000035AF File Offset: 0x000017AF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBuilderInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000035BE File Offset: 0x000017BE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000035FE File Offset: 0x000017FE
		private static Delegate GetToStringHandler()
		{
			if (IBuilderInferenceInvoker.cb_toString == null)
			{
				IBuilderInferenceInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBuilderInferenceInvoker.n_ToString));
			}
			return IBuilderInferenceInvoker.cb_toString;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00003622 File Offset: 0x00001822
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBuilderInference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00003638 File Offset: 0x00001838
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000020 RID: 32
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/BuilderInference", typeof(IBuilderInferenceInvoker));

		// Token: 0x04000021 RID: 33
		private IntPtr class_ref;

		// Token: 0x04000022 RID: 34
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000023 RID: 35
		private IntPtr id_annotationType;

		// Token: 0x04000024 RID: 36
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000025 RID: 37
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000026 RID: 38
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000027 RID: 39
		private IntPtr id_hashCode;

		// Token: 0x04000028 RID: 40
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000029 RID: 41
		private IntPtr id_toString;
	}
}
