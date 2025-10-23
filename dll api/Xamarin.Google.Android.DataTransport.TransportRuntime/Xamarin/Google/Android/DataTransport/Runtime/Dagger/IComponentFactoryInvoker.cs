using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A4 RID: 164
	[Register("com/google/android/datatransport/runtime/dagger/Component$Factory", DoNotGenerateAcw = true)]
	internal class IComponentFactoryInvoker : Java.Lang.Object, IComponentFactory, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00011778 File Offset: 0x0000F978
		private static IntPtr java_class_ref
		{
			get
			{
				return IComponentFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001179C File Offset: 0x0000F99C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComponentFactoryInvoker._members;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x000117A3 File Offset: 0x0000F9A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000117AB File Offset: 0x0000F9AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComponentFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000117B7 File Offset: 0x0000F9B7
		public static IComponentFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IComponentFactory>(handle, transfer);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000117C0 File Offset: 0x0000F9C0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComponentFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Component.Factory'.");
			}
			return handle;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000117EB File Offset: 0x0000F9EB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0001181C File Offset: 0x0000FA1C
		public IComponentFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComponentFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00011854 File Offset: 0x0000FA54
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IComponentFactoryInvoker.cb_annotationType == null)
			{
				IComponentFactoryInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentFactoryInvoker.n_AnnotationType));
			}
			return IComponentFactoryInvoker.cb_annotationType;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00011878 File Offset: 0x0000FA78
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001188C File Offset: 0x0000FA8C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000118DD File Offset: 0x0000FADD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IComponentFactoryInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IComponentFactoryInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IComponentFactoryInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IComponentFactoryInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00011904 File Offset: 0x0000FB04
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IComponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00011928 File Offset: 0x0000FB28
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

		// Token: 0x060005EF RID: 1519 RVA: 0x0001199B File Offset: 0x0000FB9B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IComponentFactoryInvoker.cb_hashCode == null)
			{
				IComponentFactoryInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IComponentFactoryInvoker.n_GetHashCode));
			}
			return IComponentFactoryInvoker.cb_hashCode;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000119BF File Offset: 0x0000FBBF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000119CE File Offset: 0x0000FBCE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00011A0E File Offset: 0x0000FC0E
		private static Delegate GetToStringHandler()
		{
			if (IComponentFactoryInvoker.cb_toString == null)
			{
				IComponentFactoryInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentFactoryInvoker.n_ToString));
			}
			return IComponentFactoryInvoker.cb_toString;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00011A32 File Offset: 0x0000FC32
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IComponentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00011A48 File Offset: 0x0000FC48
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000159 RID: 345
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Component$Factory", typeof(IComponentFactoryInvoker));

		// Token: 0x0400015A RID: 346
		private IntPtr class_ref;

		// Token: 0x0400015B RID: 347
		private static Delegate cb_annotationType;

		// Token: 0x0400015C RID: 348
		private IntPtr id_annotationType;

		// Token: 0x0400015D RID: 349
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400015E RID: 350
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400015F RID: 351
		private static Delegate cb_hashCode;

		// Token: 0x04000160 RID: 352
		private IntPtr id_hashCode;

		// Token: 0x04000161 RID: 353
		private static Delegate cb_toString;

		// Token: 0x04000162 RID: 354
		private IntPtr id_toString;
	}
}
