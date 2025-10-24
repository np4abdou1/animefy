using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A6 RID: 166
	[Register("com/google/android/datatransport/runtime/dagger/Component", DoNotGenerateAcw = true)]
	internal class IComponentInvoker : Java.Lang.Object, IComponent, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00011AB4 File Offset: 0x0000FCB4
		private static IntPtr java_class_ref
		{
			get
			{
				return IComponentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComponentInvoker._members;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00011ADF File Offset: 0x0000FCDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00011AE7 File Offset: 0x0000FCE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComponentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00011AF3 File Offset: 0x0000FCF3
		public static IComponent GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IComponent>(handle, transfer);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00011AFC File Offset: 0x0000FCFC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComponentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Component'.");
			}
			return handle;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00011B27 File Offset: 0x0000FD27
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00011B58 File Offset: 0x0000FD58
		public IComponentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComponentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00011B90 File Offset: 0x0000FD90
		private static Delegate GetDependenciesHandler()
		{
			if (IComponentInvoker.cb_dependencies == null)
			{
				IComponentInvoker.cb_dependencies = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentInvoker.n_Dependencies));
			}
			return IComponentInvoker.cb_dependencies;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		private static IntPtr n_Dependencies(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dependencies());
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		public Class[] Dependencies()
		{
			if (this.id_dependencies == IntPtr.Zero)
			{
				this.id_dependencies = JNIEnv.GetMethodID(this.class_ref, "dependencies", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_dependencies), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00011C28 File Offset: 0x0000FE28
		private static Delegate GetModulesHandler()
		{
			if (IComponentInvoker.cb_modules == null)
			{
				IComponentInvoker.cb_modules = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentInvoker.n_Modules));
			}
			return IComponentInvoker.cb_modules;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00011C4C File Offset: 0x0000FE4C
		private static IntPtr n_Modules(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Modules());
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00011C60 File Offset: 0x0000FE60
		public Class[] Modules()
		{
			if (this.id_modules == IntPtr.Zero)
			{
				this.id_modules = JNIEnv.GetMethodID(this.class_ref, "modules", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_modules), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IComponentInvoker.cb_annotationType == null)
			{
				IComponentInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentInvoker.n_AnnotationType));
			}
			return IComponentInvoker.cb_annotationType;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00011D49 File Offset: 0x0000FF49
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IComponentInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IComponentInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IComponentInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IComponentInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00011D70 File Offset: 0x0000FF70
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00011D94 File Offset: 0x0000FF94
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

		// Token: 0x0600060C RID: 1548 RVA: 0x00011E07 File Offset: 0x00010007
		private static Delegate GetGetHashCodeHandler()
		{
			if (IComponentInvoker.cb_hashCode == null)
			{
				IComponentInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IComponentInvoker.n_GetHashCode));
			}
			return IComponentInvoker.cb_hashCode;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00011E2B File Offset: 0x0001002B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00011E3A File Offset: 0x0001003A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00011E7A File Offset: 0x0001007A
		private static Delegate GetToStringHandler()
		{
			if (IComponentInvoker.cb_toString == null)
			{
				IComponentInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentInvoker.n_ToString));
			}
			return IComponentInvoker.cb_toString;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00011E9E File Offset: 0x0001009E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00011EB4 File Offset: 0x000100B4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000163 RID: 355
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Component", typeof(IComponentInvoker));

		// Token: 0x04000164 RID: 356
		private IntPtr class_ref;

		// Token: 0x04000165 RID: 357
		private static Delegate cb_dependencies;

		// Token: 0x04000166 RID: 358
		private IntPtr id_dependencies;

		// Token: 0x04000167 RID: 359
		private static Delegate cb_modules;

		// Token: 0x04000168 RID: 360
		private IntPtr id_modules;

		// Token: 0x04000169 RID: 361
		private static Delegate cb_annotationType;

		// Token: 0x0400016A RID: 362
		private IntPtr id_annotationType;

		// Token: 0x0400016B RID: 363
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400016C RID: 364
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400016D RID: 365
		private static Delegate cb_hashCode;

		// Token: 0x0400016E RID: 366
		private IntPtr id_hashCode;

		// Token: 0x0400016F RID: 367
		private static Delegate cb_toString;

		// Token: 0x04000170 RID: 368
		private IntPtr id_toString;
	}
}
