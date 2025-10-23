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
	// Token: 0x0200002F RID: 47
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/TestOnly", DoNotGenerateAcw = true)]
	internal class ITestOnlyInvoker : Java.Lang.Object, ITestOnly, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000537C File Offset: 0x0000357C
		private static IntPtr java_class_ref
		{
			get
			{
				return ITestOnlyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000053A0 File Offset: 0x000035A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITestOnlyInvoker._members;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000053A7 File Offset: 0x000035A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000053AF File Offset: 0x000035AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITestOnlyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000053BB File Offset: 0x000035BB
		[NullableContext(2)]
		public static ITestOnly GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITestOnly>(handle, transfer);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000053C4 File Offset: 0x000035C4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITestOnlyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.TestOnly'.");
			}
			return handle;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000053EF File Offset: 0x000035EF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005420 File Offset: 0x00003620
		public ITestOnlyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITestOnlyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00005458 File Offset: 0x00003658
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ITestOnlyInvoker.cb_annotationType == null)
			{
				ITestOnlyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITestOnlyInvoker.n_AnnotationType));
			}
			return ITestOnlyInvoker.cb_annotationType;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000547C File Offset: 0x0000367C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITestOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005490 File Offset: 0x00003690
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000054E1 File Offset: 0x000036E1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ITestOnlyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ITestOnlyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ITestOnlyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ITestOnlyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005508 File Offset: 0x00003708
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ITestOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000552C File Offset: 0x0000372C
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

		// Token: 0x06000189 RID: 393 RVA: 0x0000559F File Offset: 0x0000379F
		private static Delegate GetGetHashCodeHandler()
		{
			if (ITestOnlyInvoker.cb_hashCode == null)
			{
				ITestOnlyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ITestOnlyInvoker.n_GetHashCode));
			}
			return ITestOnlyInvoker.cb_hashCode;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000055C3 File Offset: 0x000037C3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITestOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000055D2 File Offset: 0x000037D2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005612 File Offset: 0x00003812
		private static Delegate GetToStringHandler()
		{
			if (ITestOnlyInvoker.cb_toString == null)
			{
				ITestOnlyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITestOnlyInvoker.n_ToString));
			}
			return ITestOnlyInvoker.cb_toString;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005636 File Offset: 0x00003836
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ITestOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000564C File Offset: 0x0000384C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000A1 RID: 161
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/TestOnly", typeof(ITestOnlyInvoker));

		// Token: 0x040000A2 RID: 162
		private IntPtr class_ref;

		// Token: 0x040000A3 RID: 163
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000A4 RID: 164
		private IntPtr id_annotationType;

		// Token: 0x040000A5 RID: 165
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000A6 RID: 166
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000A7 RID: 167
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000A8 RID: 168
		private IntPtr id_hashCode;

		// Token: 0x040000A9 RID: 169
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000AA RID: 170
		private IntPtr id_toString;
	}
}
