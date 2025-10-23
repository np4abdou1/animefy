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
	// Token: 0x0200005A RID: 90
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/Subst", DoNotGenerateAcw = true)]
	internal class ISubstInvoker : Java.Lang.Object, ISubst, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00008540 File Offset: 0x00006740
		private static IntPtr java_class_ref
		{
			get
			{
				return ISubstInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00008564 File Offset: 0x00006764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISubstInvoker._members;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000856B File Offset: 0x0000676B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00008573 File Offset: 0x00006773
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISubstInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000857F File Offset: 0x0000677F
		[NullableContext(2)]
		public static ISubst GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISubst>(handle, transfer);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00008588 File Offset: 0x00006788
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISubstInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.Subst'.");
			}
			return handle;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000085B3 File Offset: 0x000067B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000085E4 File Offset: 0x000067E4
		public ISubstInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISubstInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000861C File Offset: 0x0000681C
		private static Delegate GetValueHandler()
		{
			if (ISubstInvoker.cb_value == null)
			{
				ISubstInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubstInvoker.n_Value));
			}
			return ISubstInvoker.cb_value;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00008640 File Offset: 0x00006840
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISubst>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00008654 File Offset: 0x00006854
		[NullableContext(2)]
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000086A5 File Offset: 0x000068A5
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISubstInvoker.cb_annotationType == null)
			{
				ISubstInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubstInvoker.n_AnnotationType));
			}
			return ISubstInvoker.cb_annotationType;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000086C9 File Offset: 0x000068C9
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubst>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000086E0 File Offset: 0x000068E0
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00008731 File Offset: 0x00006931
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISubstInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISubstInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISubstInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISubstInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00008758 File Offset: 0x00006958
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISubst>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000877C File Offset: 0x0000697C
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

		// Token: 0x060002F6 RID: 758 RVA: 0x000087EF File Offset: 0x000069EF
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISubstInvoker.cb_hashCode == null)
			{
				ISubstInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISubstInvoker.n_GetHashCode));
			}
			return ISubstInvoker.cb_hashCode;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00008813 File Offset: 0x00006A13
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISubst>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00008822 File Offset: 0x00006A22
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00008862 File Offset: 0x00006A62
		private static Delegate GetToStringHandler()
		{
			if (ISubstInvoker.cb_toString == null)
			{
				ISubstInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubstInvoker.n_ToString));
			}
			return ISubstInvoker.cb_toString;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00008886 File Offset: 0x00006A86
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISubst>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000889C File Offset: 0x00006A9C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400014B RID: 331
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/Subst", typeof(ISubstInvoker));

		// Token: 0x0400014C RID: 332
		private IntPtr class_ref;

		// Token: 0x0400014D RID: 333
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x0400014E RID: 334
		private IntPtr id_value;

		// Token: 0x0400014F RID: 335
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000150 RID: 336
		private IntPtr id_annotationType;

		// Token: 0x04000151 RID: 337
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000152 RID: 338
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000153 RID: 339
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000154 RID: 340
		private IntPtr id_hashCode;

		// Token: 0x04000155 RID: 341
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000156 RID: 342
		private IntPtr id_toString;
	}
}
