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
	// Token: 0x02000173 RID: 371
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/Transient", DoNotGenerateAcw = true)]
	internal class ITransientInvoker : Java.Lang.Object, ITransient, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0003E18C File Offset: 0x0003C38C
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransientInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0003E1B0 File Offset: 0x0003C3B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransientInvoker._members;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0003E1B7 File Offset: 0x0003C3B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0003E1BF File Offset: 0x0003C3BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransientInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0003E1CB File Offset: 0x0003C3CB
		[NullableContext(2)]
		public static ITransient GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransient>(handle, transfer);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransientInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.Transient'.");
			}
			return handle;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0003E1FF File Offset: 0x0003C3FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0003E230 File Offset: 0x0003C430
		public ITransientInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransientInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0003E268 File Offset: 0x0003C468
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ITransientInvoker.cb_annotationType == null)
			{
				ITransientInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITransientInvoker.n_AnnotationType));
			}
			return ITransientInvoker.cb_annotationType;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0003E28C File Offset: 0x0003C48C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITransient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0003E2F1 File Offset: 0x0003C4F1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ITransientInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ITransientInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ITransientInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ITransientInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003E318 File Offset: 0x0003C518
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ITransient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003E33C File Offset: 0x0003C53C
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

		// Token: 0x06001317 RID: 4887 RVA: 0x0003E3AF File Offset: 0x0003C5AF
		private static Delegate GetGetHashCodeHandler()
		{
			if (ITransientInvoker.cb_hashCode == null)
			{
				ITransientInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ITransientInvoker.n_GetHashCode));
			}
			return ITransientInvoker.cb_hashCode;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003E3D3 File Offset: 0x0003C5D3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITransient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0003E3E2 File Offset: 0x0003C5E2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0003E422 File Offset: 0x0003C622
		private static Delegate GetToStringHandler()
		{
			if (ITransientInvoker.cb_toString == null)
			{
				ITransientInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITransientInvoker.n_ToString));
			}
			return ITransientInvoker.cb_toString;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0003E446 File Offset: 0x0003C646
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ITransient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0003E45C File Offset: 0x0003C65C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400065B RID: 1627
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/Transient", typeof(ITransientInvoker));

		// Token: 0x0400065C RID: 1628
		private IntPtr class_ref;

		// Token: 0x0400065D RID: 1629
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400065E RID: 1630
		private IntPtr id_annotationType;

		// Token: 0x0400065F RID: 1631
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000660 RID: 1632
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000661 RID: 1633
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000662 RID: 1634
		private IntPtr id_hashCode;

		// Token: 0x04000663 RID: 1635
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000664 RID: 1636
		private IntPtr id_toString;
	}
}
