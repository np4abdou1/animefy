using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000054 RID: 84
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/Pattern", DoNotGenerateAcw = true)]
	internal class IPatternInvoker : Java.Lang.Object, IPattern, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000079E8 File Offset: 0x00005BE8
		private static IntPtr java_class_ref
		{
			get
			{
				return IPatternInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00007A0C File Offset: 0x00005C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPatternInvoker._members;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00007A13 File Offset: 0x00005C13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00007A1B File Offset: 0x00005C1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPatternInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00007A27 File Offset: 0x00005C27
		[NullableContext(2)]
		public static IPattern GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPattern>(handle, transfer);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00007A30 File Offset: 0x00005C30
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPatternInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.Pattern'.");
			}
			return handle;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00007A5B File Offset: 0x00005C5B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00007A8C File Offset: 0x00005C8C
		public IPatternInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPatternInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00007AC4 File Offset: 0x00005CC4
		private static Delegate GetValueHandler()
		{
			if (IPatternInvoker.cb_value == null)
			{
				IPatternInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPatternInvoker.n_Value));
			}
			return IPatternInvoker.cb_value;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00007AE8 File Offset: 0x00005CE8
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPattern>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00007AFC File Offset: 0x00005CFC
		[NullableContext(2)]
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00007B4D File Offset: 0x00005D4D
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IPatternInvoker.cb_annotationType == null)
			{
				IPatternInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPatternInvoker.n_AnnotationType));
			}
			return IPatternInvoker.cb_annotationType;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00007B71 File Offset: 0x00005D71
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPattern>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00007B88 File Offset: 0x00005D88
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00007BD9 File Offset: 0x00005DD9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IPatternInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IPatternInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPatternInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IPatternInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00007C00 File Offset: 0x00005E00
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IPattern>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00007C24 File Offset: 0x00005E24
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

		// Token: 0x060002AB RID: 683 RVA: 0x00007C97 File Offset: 0x00005E97
		private static Delegate GetGetHashCodeHandler()
		{
			if (IPatternInvoker.cb_hashCode == null)
			{
				IPatternInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPatternInvoker.n_GetHashCode));
			}
			return IPatternInvoker.cb_hashCode;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00007CBB File Offset: 0x00005EBB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPattern>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00007CCA File Offset: 0x00005ECA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00007D0A File Offset: 0x00005F0A
		private static Delegate GetToStringHandler()
		{
			if (IPatternInvoker.cb_toString == null)
			{
				IPatternInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPatternInvoker.n_ToString));
			}
			return IPatternInvoker.cb_toString;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00007D2E File Offset: 0x00005F2E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPattern>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00007D44 File Offset: 0x00005F44
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000127 RID: 295
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/Pattern", typeof(IPatternInvoker));

		// Token: 0x04000128 RID: 296
		private IntPtr class_ref;

		// Token: 0x04000129 RID: 297
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x0400012A RID: 298
		private IntPtr id_value;

		// Token: 0x0400012B RID: 299
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400012C RID: 300
		private IntPtr id_annotationType;

		// Token: 0x0400012D RID: 301
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400012E RID: 302
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400012F RID: 303
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000130 RID: 304
		private IntPtr id_hashCode;

		// Token: 0x04000131 RID: 305
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000132 RID: 306
		private IntPtr id_toString;
	}
}
