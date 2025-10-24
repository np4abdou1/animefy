using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Annotation
{
	// Token: 0x0200028F RID: 655
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/annotation/Target", DoNotGenerateAcw = true)]
	internal class ITargetInvoker : Java.Lang.Object, ITarget, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00062564 File Offset: 0x00060764
		private static IntPtr java_class_ref
		{
			get
			{
				return ITargetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00062588 File Offset: 0x00060788
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITargetInvoker._members;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0006258F File Offset: 0x0006078F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00062597 File Offset: 0x00060797
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000625A3 File Offset: 0x000607A3
		[NullableContext(2)]
		public static ITarget GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITarget>(handle, transfer);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000625AC File Offset: 0x000607AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITargetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.annotation.Target'.");
			}
			return handle;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000625D7 File Offset: 0x000607D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00062608 File Offset: 0x00060808
		public ITargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITargetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00062640 File Offset: 0x00060840
		private static Delegate GetAllowedTargetsHandler()
		{
			if (ITargetInvoker.cb_allowedTargets == null)
			{
				ITargetInvoker.cb_allowedTargets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITargetInvoker.n_AllowedTargets));
			}
			return ITargetInvoker.cb_allowedTargets;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00062664 File Offset: 0x00060864
		private static IntPtr n_AllowedTargets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<AnnotationTarget>(Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowedTargets());
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00062678 File Offset: 0x00060878
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public AnnotationTarget[] AllowedTargets()
		{
			if (this.id_allowedTargets == IntPtr.Zero)
			{
				this.id_allowedTargets = JNIEnv.GetMethodID(this.class_ref, "allowedTargets", "()[Lkotlin/annotation/AnnotationTarget;");
			}
			return (AnnotationTarget[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_allowedTargets), JniHandleOwnership.TransferLocalRef, typeof(AnnotationTarget));
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000626D8 File Offset: 0x000608D8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ITargetInvoker.cb_annotationType == null)
			{
				ITargetInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITargetInvoker.n_AnnotationType));
			}
			return ITargetInvoker.cb_annotationType;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000626FC File Offset: 0x000608FC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00062710 File Offset: 0x00060910
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00062761 File Offset: 0x00060961
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ITargetInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ITargetInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ITargetInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ITargetInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00062788 File Offset: 0x00060988
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000627AC File Offset: 0x000609AC
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

		// Token: 0x06001D98 RID: 7576 RVA: 0x0006281F File Offset: 0x00060A1F
		private static Delegate GetGetHashCodeHandler()
		{
			if (ITargetInvoker.cb_hashCode == null)
			{
				ITargetInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ITargetInvoker.n_GetHashCode));
			}
			return ITargetInvoker.cb_hashCode;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00062843 File Offset: 0x00060A43
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00062852 File Offset: 0x00060A52
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00062892 File Offset: 0x00060A92
		private static Delegate GetToStringHandler()
		{
			if (ITargetInvoker.cb_toString == null)
			{
				ITargetInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITargetInvoker.n_ToString));
			}
			return ITargetInvoker.cb_toString;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000628B6 File Offset: 0x00060AB6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ITarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000628CC File Offset: 0x00060ACC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000904 RID: 2308
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/annotation/Target", typeof(ITargetInvoker));

		// Token: 0x04000905 RID: 2309
		private IntPtr class_ref;

		// Token: 0x04000906 RID: 2310
		[Nullable(2)]
		private static Delegate cb_allowedTargets;

		// Token: 0x04000907 RID: 2311
		private IntPtr id_allowedTargets;

		// Token: 0x04000908 RID: 2312
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000909 RID: 2313
		private IntPtr id_annotationType;

		// Token: 0x0400090A RID: 2314
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400090B RID: 2315
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400090C RID: 2316
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400090D RID: 2317
		private IntPtr id_hashCode;

		// Token: 0x0400090E RID: 2318
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400090F RID: 2319
		private IntPtr id_toString;
	}
}
