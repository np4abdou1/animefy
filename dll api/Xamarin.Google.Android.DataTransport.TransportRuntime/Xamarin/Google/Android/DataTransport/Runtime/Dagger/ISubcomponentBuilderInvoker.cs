using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B4 RID: 180
	[Register("com/google/android/datatransport/runtime/dagger/Subcomponent$Builder", DoNotGenerateAcw = true)]
	internal class ISubcomponentBuilderInvoker : Java.Lang.Object, ISubcomponentBuilder, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x000130E4 File Offset: 0x000112E4
		private static IntPtr java_class_ref
		{
			get
			{
				return ISubcomponentBuilderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00013108 File Offset: 0x00011308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISubcomponentBuilderInvoker._members;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001310F File Offset: 0x0001130F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00013117 File Offset: 0x00011317
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISubcomponentBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00013123 File Offset: 0x00011323
		public static ISubcomponentBuilder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISubcomponentBuilder>(handle, transfer);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001312C File Offset: 0x0001132C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISubcomponentBuilderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Subcomponent.Builder'.");
			}
			return handle;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00013157 File Offset: 0x00011357
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00013188 File Offset: 0x00011388
		public ISubcomponentBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISubcomponentBuilderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000131C0 File Offset: 0x000113C0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISubcomponentBuilderInvoker.cb_annotationType == null)
			{
				ISubcomponentBuilderInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentBuilderInvoker.n_AnnotationType));
			}
			return ISubcomponentBuilderInvoker.cb_annotationType;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000131E4 File Offset: 0x000113E4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubcomponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000131F8 File Offset: 0x000113F8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00013249 File Offset: 0x00011449
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISubcomponentBuilderInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISubcomponentBuilderInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISubcomponentBuilderInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISubcomponentBuilderInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00013270 File Offset: 0x00011470
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISubcomponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00013294 File Offset: 0x00011494
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

		// Token: 0x0600069B RID: 1691 RVA: 0x00013307 File Offset: 0x00011507
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISubcomponentBuilderInvoker.cb_hashCode == null)
			{
				ISubcomponentBuilderInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISubcomponentBuilderInvoker.n_GetHashCode));
			}
			return ISubcomponentBuilderInvoker.cb_hashCode;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001332B File Offset: 0x0001152B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISubcomponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001333A File Offset: 0x0001153A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001337A File Offset: 0x0001157A
		private static Delegate GetToStringHandler()
		{
			if (ISubcomponentBuilderInvoker.cb_toString == null)
			{
				ISubcomponentBuilderInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentBuilderInvoker.n_ToString));
			}
			return ISubcomponentBuilderInvoker.cb_toString;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001339E File Offset: 0x0001159E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISubcomponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000133B4 File Offset: 0x000115B4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001A7 RID: 423
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Subcomponent$Builder", typeof(ISubcomponentBuilderInvoker));

		// Token: 0x040001A8 RID: 424
		private IntPtr class_ref;

		// Token: 0x040001A9 RID: 425
		private static Delegate cb_annotationType;

		// Token: 0x040001AA RID: 426
		private IntPtr id_annotationType;

		// Token: 0x040001AB RID: 427
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001AC RID: 428
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001AD RID: 429
		private static Delegate cb_hashCode;

		// Token: 0x040001AE RID: 430
		private IntPtr id_hashCode;

		// Token: 0x040001AF RID: 431
		private static Delegate cb_toString;

		// Token: 0x040001B0 RID: 432
		private IntPtr id_toString;
	}
}
