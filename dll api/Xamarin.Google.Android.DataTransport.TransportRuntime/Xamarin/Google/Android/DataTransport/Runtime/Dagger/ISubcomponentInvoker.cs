using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B8 RID: 184
	[Register("com/google/android/datatransport/runtime/dagger/Subcomponent", DoNotGenerateAcw = true)]
	internal class ISubcomponentInvoker : Java.Lang.Object, ISubcomponent, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001375C File Offset: 0x0001195C
		private static IntPtr java_class_ref
		{
			get
			{
				return ISubcomponentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00013780 File Offset: 0x00011980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISubcomponentInvoker._members;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00013787 File Offset: 0x00011987
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001378F File Offset: 0x0001198F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISubcomponentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001379B File Offset: 0x0001199B
		public static ISubcomponent GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISubcomponent>(handle, transfer);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000137A4 File Offset: 0x000119A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISubcomponentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Subcomponent'.");
			}
			return handle;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000137CF File Offset: 0x000119CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00013800 File Offset: 0x00011A00
		public ISubcomponentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISubcomponentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00013838 File Offset: 0x00011A38
		private static Delegate GetModulesHandler()
		{
			if (ISubcomponentInvoker.cb_modules == null)
			{
				ISubcomponentInvoker.cb_modules = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentInvoker.n_Modules));
			}
			return ISubcomponentInvoker.cb_modules;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001385C File Offset: 0x00011A5C
		private static IntPtr n_Modules(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<ISubcomponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Modules());
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00013870 File Offset: 0x00011A70
		public Class[] Modules()
		{
			if (this.id_modules == IntPtr.Zero)
			{
				this.id_modules = JNIEnv.GetMethodID(this.class_ref, "modules", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_modules), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000138D0 File Offset: 0x00011AD0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISubcomponentInvoker.cb_annotationType == null)
			{
				ISubcomponentInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentInvoker.n_AnnotationType));
			}
			return ISubcomponentInvoker.cb_annotationType;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000138F4 File Offset: 0x00011AF4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubcomponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00013908 File Offset: 0x00011B08
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00013959 File Offset: 0x00011B59
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISubcomponentInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISubcomponentInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISubcomponentInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISubcomponentInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00013980 File Offset: 0x00011B80
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISubcomponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000139A4 File Offset: 0x00011BA4
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

		// Token: 0x060006C9 RID: 1737 RVA: 0x00013A17 File Offset: 0x00011C17
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISubcomponentInvoker.cb_hashCode == null)
			{
				ISubcomponentInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISubcomponentInvoker.n_GetHashCode));
			}
			return ISubcomponentInvoker.cb_hashCode;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00013A3B File Offset: 0x00011C3B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISubcomponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00013A4A File Offset: 0x00011C4A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00013A8A File Offset: 0x00011C8A
		private static Delegate GetToStringHandler()
		{
			if (ISubcomponentInvoker.cb_toString == null)
			{
				ISubcomponentInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentInvoker.n_ToString));
			}
			return ISubcomponentInvoker.cb_toString;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00013AAE File Offset: 0x00011CAE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISubcomponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001BB RID: 443
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Subcomponent", typeof(ISubcomponentInvoker));

		// Token: 0x040001BC RID: 444
		private IntPtr class_ref;

		// Token: 0x040001BD RID: 445
		private static Delegate cb_modules;

		// Token: 0x040001BE RID: 446
		private IntPtr id_modules;

		// Token: 0x040001BF RID: 447
		private static Delegate cb_annotationType;

		// Token: 0x040001C0 RID: 448
		private IntPtr id_annotationType;

		// Token: 0x040001C1 RID: 449
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001C2 RID: 450
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001C3 RID: 451
		private static Delegate cb_hashCode;

		// Token: 0x040001C4 RID: 452
		private IntPtr id_hashCode;

		// Token: 0x040001C5 RID: 453
		private static Delegate cb_toString;

		// Token: 0x040001C6 RID: 454
		private IntPtr id_toString;
	}
}
