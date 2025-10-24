using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C9 RID: 201
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/IntoSet", DoNotGenerateAcw = true)]
	internal class IIntoSetInvoker : Java.Lang.Object, IIntoSet, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00014978 File Offset: 0x00012B78
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntoSetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001499C File Offset: 0x00012B9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntoSetInvoker._members;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x000149A3 File Offset: 0x00012BA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x000149AB File Offset: 0x00012BAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntoSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000149B7 File Offset: 0x00012BB7
		public static IIntoSet GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIntoSet>(handle, transfer);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000149C0 File Offset: 0x00012BC0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntoSetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.IntoSet'.");
			}
			return handle;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000149EB File Offset: 0x00012BEB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00014A1C File Offset: 0x00012C1C
		public IIntoSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntoSetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00014A54 File Offset: 0x00012C54
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IIntoSetInvoker.cb_annotationType == null)
			{
				IIntoSetInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIntoSetInvoker.n_AnnotationType));
			}
			return IIntoSetInvoker.cb_annotationType;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00014A78 File Offset: 0x00012C78
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00014A8C File Offset: 0x00012C8C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00014ADD File Offset: 0x00012CDD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IIntoSetInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IIntoSetInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IIntoSetInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IIntoSetInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00014B04 File Offset: 0x00012D04
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00014B28 File Offset: 0x00012D28
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

		// Token: 0x0600074B RID: 1867 RVA: 0x00014B9B File Offset: 0x00012D9B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IIntoSetInvoker.cb_hashCode == null)
			{
				IIntoSetInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IIntoSetInvoker.n_GetHashCode));
			}
			return IIntoSetInvoker.cb_hashCode;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00014BBF File Offset: 0x00012DBF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00014BCE File Offset: 0x00012DCE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00014C0E File Offset: 0x00012E0E
		private static Delegate GetToStringHandler()
		{
			if (IIntoSetInvoker.cb_toString == null)
			{
				IIntoSetInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIntoSetInvoker.n_ToString));
			}
			return IIntoSetInvoker.cb_toString;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00014C32 File Offset: 0x00012E32
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00014C48 File Offset: 0x00012E48
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001F8 RID: 504
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/IntoSet", typeof(IIntoSetInvoker));

		// Token: 0x040001F9 RID: 505
		private IntPtr class_ref;

		// Token: 0x040001FA RID: 506
		private static Delegate cb_annotationType;

		// Token: 0x040001FB RID: 507
		private IntPtr id_annotationType;

		// Token: 0x040001FC RID: 508
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001FD RID: 509
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001FE RID: 510
		private static Delegate cb_hashCode;

		// Token: 0x040001FF RID: 511
		private IntPtr id_hashCode;

		// Token: 0x04000200 RID: 512
		private static Delegate cb_toString;

		// Token: 0x04000201 RID: 513
		private IntPtr id_toString;
	}
}
