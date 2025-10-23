using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B6 RID: 182
	[Register("com/google/android/datatransport/runtime/dagger/Subcomponent$Factory", DoNotGenerateAcw = true)]
	internal class ISubcomponentFactoryInvoker : Java.Lang.Object, ISubcomponentFactory, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00013420 File Offset: 0x00011620
		private static IntPtr java_class_ref
		{
			get
			{
				return ISubcomponentFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00013444 File Offset: 0x00011644
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISubcomponentFactoryInvoker._members;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0001344B File Offset: 0x0001164B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00013453 File Offset: 0x00011653
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISubcomponentFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001345F File Offset: 0x0001165F
		public static ISubcomponentFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISubcomponentFactory>(handle, transfer);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00013468 File Offset: 0x00011668
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISubcomponentFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Subcomponent.Factory'.");
			}
			return handle;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00013493 File Offset: 0x00011693
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000134C4 File Offset: 0x000116C4
		public ISubcomponentFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISubcomponentFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000134FC File Offset: 0x000116FC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISubcomponentFactoryInvoker.cb_annotationType == null)
			{
				ISubcomponentFactoryInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentFactoryInvoker.n_AnnotationType));
			}
			return ISubcomponentFactoryInvoker.cb_annotationType;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00013520 File Offset: 0x00011720
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubcomponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00013534 File Offset: 0x00011734
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00013585 File Offset: 0x00011785
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISubcomponentFactoryInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISubcomponentFactoryInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISubcomponentFactoryInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISubcomponentFactoryInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000135AC File Offset: 0x000117AC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISubcomponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000135D0 File Offset: 0x000117D0
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

		// Token: 0x060006B0 RID: 1712 RVA: 0x00013643 File Offset: 0x00011843
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISubcomponentFactoryInvoker.cb_hashCode == null)
			{
				ISubcomponentFactoryInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISubcomponentFactoryInvoker.n_GetHashCode));
			}
			return ISubcomponentFactoryInvoker.cb_hashCode;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00013667 File Offset: 0x00011867
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISubcomponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00013676 File Offset: 0x00011876
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000136B6 File Offset: 0x000118B6
		private static Delegate GetToStringHandler()
		{
			if (ISubcomponentFactoryInvoker.cb_toString == null)
			{
				ISubcomponentFactoryInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubcomponentFactoryInvoker.n_ToString));
			}
			return ISubcomponentFactoryInvoker.cb_toString;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000136DA File Offset: 0x000118DA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISubcomponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000136F0 File Offset: 0x000118F0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001B1 RID: 433
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Subcomponent$Factory", typeof(ISubcomponentFactoryInvoker));

		// Token: 0x040001B2 RID: 434
		private IntPtr class_ref;

		// Token: 0x040001B3 RID: 435
		private static Delegate cb_annotationType;

		// Token: 0x040001B4 RID: 436
		private IntPtr id_annotationType;

		// Token: 0x040001B5 RID: 437
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001B6 RID: 438
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001B7 RID: 439
		private static Delegate cb_hashCode;

		// Token: 0x040001B8 RID: 440
		private IntPtr id_hashCode;

		// Token: 0x040001B9 RID: 441
		private static Delegate cb_toString;

		// Token: 0x040001BA RID: 442
		private IntPtr id_toString;
	}
}
