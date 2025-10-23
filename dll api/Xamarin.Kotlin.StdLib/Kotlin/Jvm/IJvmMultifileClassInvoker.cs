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
	// Token: 0x02000159 RID: 345
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmMultifileClass", DoNotGenerateAcw = true)]
	internal class IJvmMultifileClassInvoker : Java.Lang.Object, IJvmMultifileClass, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0003B55C File Offset: 0x0003975C
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmMultifileClassInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0003B580 File Offset: 0x00039780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmMultifileClassInvoker._members;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0003B587 File Offset: 0x00039787
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0003B58F File Offset: 0x0003978F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmMultifileClassInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0003B59B File Offset: 0x0003979B
		[NullableContext(2)]
		public static IJvmMultifileClass GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmMultifileClass>(handle, transfer);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0003B5A4 File Offset: 0x000397A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmMultifileClassInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmMultifileClass'.");
			}
			return handle;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0003B5CF File Offset: 0x000397CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0003B600 File Offset: 0x00039800
		public IJvmMultifileClassInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmMultifileClassInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0003B638 File Offset: 0x00039838
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmMultifileClassInvoker.cb_annotationType == null)
			{
				IJvmMultifileClassInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmMultifileClassInvoker.n_AnnotationType));
			}
			return IJvmMultifileClassInvoker.cb_annotationType;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0003B65C File Offset: 0x0003985C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmMultifileClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0003B670 File Offset: 0x00039870
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0003B6C1 File Offset: 0x000398C1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmMultifileClassInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmMultifileClassInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmMultifileClassInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmMultifileClassInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0003B6E8 File Offset: 0x000398E8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmMultifileClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0003B70C File Offset: 0x0003990C
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

		// Token: 0x060011F6 RID: 4598 RVA: 0x0003B77F File Offset: 0x0003997F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmMultifileClassInvoker.cb_hashCode == null)
			{
				IJvmMultifileClassInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmMultifileClassInvoker.n_GetHashCode));
			}
			return IJvmMultifileClassInvoker.cb_hashCode;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0003B7A3 File Offset: 0x000399A3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmMultifileClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0003B7B2 File Offset: 0x000399B2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0003B7F2 File Offset: 0x000399F2
		private static Delegate GetToStringHandler()
		{
			if (IJvmMultifileClassInvoker.cb_toString == null)
			{
				IJvmMultifileClassInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmMultifileClassInvoker.n_ToString));
			}
			return IJvmMultifileClassInvoker.cb_toString;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0003B816 File Offset: 0x00039A16
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmMultifileClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0003B82C File Offset: 0x00039A2C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmMultifileClass", typeof(IJvmMultifileClassInvoker));

		// Token: 0x040005D2 RID: 1490
		private IntPtr class_ref;

		// Token: 0x040005D3 RID: 1491
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005D4 RID: 1492
		private IntPtr id_annotationType;

		// Token: 0x040005D5 RID: 1493
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005D6 RID: 1494
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005D7 RID: 1495
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005D8 RID: 1496
		private IntPtr id_hashCode;

		// Token: 0x040005D9 RID: 1497
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005DA RID: 1498
		private IntPtr id_toString;
	}
}
