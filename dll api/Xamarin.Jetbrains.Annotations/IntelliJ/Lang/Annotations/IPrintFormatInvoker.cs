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
	// Token: 0x02000056 RID: 86
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/PrintFormat", DoNotGenerateAcw = true)]
	internal class IPrintFormatInvoker : Java.Lang.Object, IPrintFormat, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00007DB0 File Offset: 0x00005FB0
		private static IntPtr java_class_ref
		{
			get
			{
				return IPrintFormatInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00007DD4 File Offset: 0x00005FD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPrintFormatInvoker._members;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00007DDB File Offset: 0x00005FDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00007DE3 File Offset: 0x00005FE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPrintFormatInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00007DEF File Offset: 0x00005FEF
		[NullableContext(2)]
		public static IPrintFormat GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPrintFormat>(handle, transfer);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00007DF8 File Offset: 0x00005FF8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPrintFormatInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.PrintFormat'.");
			}
			return handle;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00007E23 File Offset: 0x00006023
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00007E54 File Offset: 0x00006054
		public IPrintFormatInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPrintFormatInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00007E8C File Offset: 0x0000608C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IPrintFormatInvoker.cb_annotationType == null)
			{
				IPrintFormatInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPrintFormatInvoker.n_AnnotationType));
			}
			return IPrintFormatInvoker.cb_annotationType;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00007EB0 File Offset: 0x000060B0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPrintFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00007EC4 File Offset: 0x000060C4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00007F15 File Offset: 0x00006115
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IPrintFormatInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IPrintFormatInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPrintFormatInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IPrintFormatInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00007F3C File Offset: 0x0000613C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IPrintFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00007F60 File Offset: 0x00006160
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

		// Token: 0x060002C0 RID: 704 RVA: 0x00007FD3 File Offset: 0x000061D3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IPrintFormatInvoker.cb_hashCode == null)
			{
				IPrintFormatInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPrintFormatInvoker.n_GetHashCode));
			}
			return IPrintFormatInvoker.cb_hashCode;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00007FF7 File Offset: 0x000061F7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPrintFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00008006 File Offset: 0x00006206
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008046 File Offset: 0x00006246
		private static Delegate GetToStringHandler()
		{
			if (IPrintFormatInvoker.cb_toString == null)
			{
				IPrintFormatInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPrintFormatInvoker.n_ToString));
			}
			return IPrintFormatInvoker.cb_toString;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000806A File Offset: 0x0000626A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPrintFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00008080 File Offset: 0x00006280
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000133 RID: 307
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/PrintFormat", typeof(IPrintFormatInvoker));

		// Token: 0x04000134 RID: 308
		private IntPtr class_ref;

		// Token: 0x04000135 RID: 309
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000136 RID: 310
		private IntPtr id_annotationType;

		// Token: 0x04000137 RID: 311
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000138 RID: 312
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000139 RID: 313
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400013A RID: 314
		private IntPtr id_hashCode;

		// Token: 0x0400013B RID: 315
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400013C RID: 316
		private IntPtr id_toString;
	}
}
