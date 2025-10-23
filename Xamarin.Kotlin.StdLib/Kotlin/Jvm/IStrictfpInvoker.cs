using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x0200016D RID: 365
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/Strictfp", DoNotGenerateAcw = true)]
	internal class IStrictfpInvoker : Java.Lang.Object, IStrictfp, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0003D740 File Offset: 0x0003B940
		private static IntPtr java_class_ref
		{
			get
			{
				return IStrictfpInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0003D764 File Offset: 0x0003B964
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IStrictfpInvoker._members;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x0003D76B File Offset: 0x0003B96B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0003D773 File Offset: 0x0003B973
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IStrictfpInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0003D77F File Offset: 0x0003B97F
		[NullableContext(2)]
		public static IStrictfp GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IStrictfp>(handle, transfer);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0003D788 File Offset: 0x0003B988
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IStrictfpInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.Strictfp'.");
			}
			return handle;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0003D7B3 File Offset: 0x0003B9B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
		public IStrictfpInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IStrictfpInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0003D81C File Offset: 0x0003BA1C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IStrictfpInvoker.cb_annotationType == null)
			{
				IStrictfpInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStrictfpInvoker.n_AnnotationType));
			}
			return IStrictfpInvoker.cb_annotationType;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0003D840 File Offset: 0x0003BA40
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IStrictfp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0003D854 File Offset: 0x0003BA54
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0003D8A5 File Offset: 0x0003BAA5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IStrictfpInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IStrictfpInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IStrictfpInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IStrictfpInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0003D8CC File Offset: 0x0003BACC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IStrictfp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0003D8F0 File Offset: 0x0003BAF0
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

		// Token: 0x060012D4 RID: 4820 RVA: 0x0003D963 File Offset: 0x0003BB63
		private static Delegate GetGetHashCodeHandler()
		{
			if (IStrictfpInvoker.cb_hashCode == null)
			{
				IStrictfpInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IStrictfpInvoker.n_GetHashCode));
			}
			return IStrictfpInvoker.cb_hashCode;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0003D987 File Offset: 0x0003BB87
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IStrictfp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0003D996 File Offset: 0x0003BB96
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0003D9D6 File Offset: 0x0003BBD6
		private static Delegate GetToStringHandler()
		{
			if (IStrictfpInvoker.cb_toString == null)
			{
				IStrictfpInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStrictfpInvoker.n_ToString));
			}
			return IStrictfpInvoker.cb_toString;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0003D9FA File Offset: 0x0003BBFA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IStrictfp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0003DA10 File Offset: 0x0003BC10
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400063B RID: 1595
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/Strictfp", typeof(IStrictfpInvoker));

		// Token: 0x0400063C RID: 1596
		private IntPtr class_ref;

		// Token: 0x0400063D RID: 1597
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400063E RID: 1598
		private IntPtr id_annotationType;

		// Token: 0x0400063F RID: 1599
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000640 RID: 1600
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000641 RID: 1601
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000642 RID: 1602
		private IntPtr id_hashCode;

		// Token: 0x04000643 RID: 1603
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000644 RID: 1604
		private IntPtr id_toString;
	}
}
