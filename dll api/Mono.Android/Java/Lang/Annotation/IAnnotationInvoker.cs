using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Annotation
{
	// Token: 0x02000410 RID: 1040
	[Register("java/lang/annotation/Annotation", DoNotGenerateAcw = true)]
	internal class IAnnotationInvoker : Object, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x0007D550 File Offset: 0x0007B750
		private static IntPtr java_class_ref
		{
			get
			{
				return IAnnotationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x0007D574 File Offset: 0x0007B774
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAnnotationInvoker._members;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x0007D57B File Offset: 0x0007B77B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x0007D583 File Offset: 0x0007B783
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAnnotationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0007D58F File Offset: 0x0007B78F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAnnotationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.annotation.Annotation'.");
			}
			return handle;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x0007D5BA File Offset: 0x0007B7BA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x0007D5EC File Offset: 0x0007B7EC
		public IAnnotationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAnnotationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x0007D624 File Offset: 0x0007B824
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IAnnotationInvoker.cb_annotationType == null)
			{
				IAnnotationInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAnnotationInvoker.n_AnnotationType));
			}
			return IAnnotationInvoker.cb_annotationType;
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x0007D648 File Offset: 0x0007B848
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<IAnnotation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x0007D65C File Offset: 0x0007B85C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0007D6AD File Offset: 0x0007B8AD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IAnnotationInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IAnnotationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAnnotationInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IAnnotationInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Object.GetObject<IAnnotation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Object object2 = Object.GetObject<Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x0007D6F8 File Offset: 0x0007B8F8
		public new unsafe bool Equals(Object obj)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x0007D76B File Offset: 0x0007B96B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IAnnotationInvoker.cb_hashCode == null)
			{
				IAnnotationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IAnnotationInvoker.n_GetHashCode));
			}
			return IAnnotationInvoker.cb_hashCode;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0007D78F File Offset: 0x0007B98F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<IAnnotation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0007D79E File Offset: 0x0007B99E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0007D7DE File Offset: 0x0007B9DE
		private static Delegate GetToStringHandler()
		{
			if (IAnnotationInvoker.cb_toString == null)
			{
				IAnnotationInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAnnotationInvoker.n_ToString));
			}
			return IAnnotationInvoker.cb_toString;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x0007D802 File Offset: 0x0007BA02
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<IAnnotation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x0007D818 File Offset: 0x0007BA18
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040011F8 RID: 4600
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/annotation/Annotation", typeof(IAnnotationInvoker));

		// Token: 0x040011F9 RID: 4601
		private IntPtr class_ref;

		// Token: 0x040011FA RID: 4602
		private static Delegate cb_annotationType;

		// Token: 0x040011FB RID: 4603
		private IntPtr id_annotationType;

		// Token: 0x040011FC RID: 4604
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040011FD RID: 4605
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040011FE RID: 4606
		private static Delegate cb_hashCode;

		// Token: 0x040011FF RID: 4607
		private IntPtr id_hashCode;

		// Token: 0x04001200 RID: 4608
		private static Delegate cb_toString;

		// Token: 0x04001201 RID: 4609
		private IntPtr id_toString;
	}
}
