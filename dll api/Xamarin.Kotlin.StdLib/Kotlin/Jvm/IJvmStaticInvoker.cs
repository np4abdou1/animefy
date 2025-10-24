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
	// Token: 0x02000163 RID: 355
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmStatic", DoNotGenerateAcw = true)]
	internal class IJvmStaticInvoker : Java.Lang.Object, IJvmStatic, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x0003C614 File Offset: 0x0003A814
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmStaticInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0003C638 File Offset: 0x0003A838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmStaticInvoker._members;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0003C63F File Offset: 0x0003A83F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0003C647 File Offset: 0x0003A847
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmStaticInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0003C653 File Offset: 0x0003A853
		[NullableContext(2)]
		public static IJvmStatic GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmStatic>(handle, transfer);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0003C65C File Offset: 0x0003A85C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmStaticInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmStatic'.");
			}
			return handle;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0003C687 File Offset: 0x0003A887
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0003C6B8 File Offset: 0x0003A8B8
		public IJvmStaticInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmStaticInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0003C6F0 File Offset: 0x0003A8F0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmStaticInvoker.cb_annotationType == null)
			{
				IJvmStaticInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmStaticInvoker.n_AnnotationType));
			}
			return IJvmStaticInvoker.cb_annotationType;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0003C714 File Offset: 0x0003A914
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmStatic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0003C728 File Offset: 0x0003A928
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0003C779 File Offset: 0x0003A979
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmStaticInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmStaticInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmStaticInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmStaticInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0003C7A0 File Offset: 0x0003A9A0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmStatic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0003C7C4 File Offset: 0x0003A9C4
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

		// Token: 0x06001263 RID: 4707 RVA: 0x0003C837 File Offset: 0x0003AA37
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmStaticInvoker.cb_hashCode == null)
			{
				IJvmStaticInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmStaticInvoker.n_GetHashCode));
			}
			return IJvmStaticInvoker.cb_hashCode;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0003C85B File Offset: 0x0003AA5B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmStatic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0003C86A File Offset: 0x0003AA6A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0003C8AA File Offset: 0x0003AAAA
		private static Delegate GetToStringHandler()
		{
			if (IJvmStaticInvoker.cb_toString == null)
			{
				IJvmStaticInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmStaticInvoker.n_ToString));
			}
			return IJvmStaticInvoker.cb_toString;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0003C8CE File Offset: 0x0003AACE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmStatic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000605 RID: 1541
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmStatic", typeof(IJvmStaticInvoker));

		// Token: 0x04000606 RID: 1542
		private IntPtr class_ref;

		// Token: 0x04000607 RID: 1543
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000608 RID: 1544
		private IntPtr id_annotationType;

		// Token: 0x04000609 RID: 1545
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400060A RID: 1546
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400060B RID: 1547
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400060C RID: 1548
		private IntPtr id_hashCode;

		// Token: 0x0400060D RID: 1549
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400060E RID: 1550
		private IntPtr id_toString;
	}
}
