using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000AE RID: 174
	[Register("com/google/android/datatransport/runtime/dagger/Module", DoNotGenerateAcw = true)]
	internal class IModuleInvoker : Java.Lang.Object, IModule, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00012600 File Offset: 0x00010800
		private static IntPtr java_class_ref
		{
			get
			{
				return IModuleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00012624 File Offset: 0x00010824
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IModuleInvoker._members;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001262B File Offset: 0x0001082B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00012633 File Offset: 0x00010833
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001263F File Offset: 0x0001083F
		public static IModule GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IModule>(handle, transfer);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00012648 File Offset: 0x00010848
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IModuleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Module'.");
			}
			return handle;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00012673 File Offset: 0x00010873
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000126A4 File Offset: 0x000108A4
		public IModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IModuleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000126DC File Offset: 0x000108DC
		private static Delegate GetIncludesHandler()
		{
			if (IModuleInvoker.cb_includes == null)
			{
				IModuleInvoker.cb_includes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IModuleInvoker.n_Includes));
			}
			return IModuleInvoker.cb_includes;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00012700 File Offset: 0x00010900
		private static IntPtr n_Includes(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Includes());
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00012714 File Offset: 0x00010914
		public Class[] Includes()
		{
			if (this.id_includes == IntPtr.Zero)
			{
				this.id_includes = JNIEnv.GetMethodID(this.class_ref, "includes", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_includes), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00012774 File Offset: 0x00010974
		private static Delegate GetSubcomponentsHandler()
		{
			if (IModuleInvoker.cb_subcomponents == null)
			{
				IModuleInvoker.cb_subcomponents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IModuleInvoker.n_Subcomponents));
			}
			return IModuleInvoker.cb_subcomponents;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00012798 File Offset: 0x00010998
		private static IntPtr n_Subcomponents(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Subcomponents());
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000127AC File Offset: 0x000109AC
		public Class[] Subcomponents()
		{
			if (this.id_subcomponents == IntPtr.Zero)
			{
				this.id_subcomponents = JNIEnv.GetMethodID(this.class_ref, "subcomponents", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_subcomponents), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001280C File Offset: 0x00010A0C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IModuleInvoker.cb_annotationType == null)
			{
				IModuleInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IModuleInvoker.n_AnnotationType));
			}
			return IModuleInvoker.cb_annotationType;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00012830 File Offset: 0x00010A30
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00012844 File Offset: 0x00010A44
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00012895 File Offset: 0x00010A95
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IModuleInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IModuleInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IModuleInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IModuleInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000128BC File Offset: 0x00010ABC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000128E0 File Offset: 0x00010AE0
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

		// Token: 0x0600065C RID: 1628 RVA: 0x00012953 File Offset: 0x00010B53
		private static Delegate GetGetHashCodeHandler()
		{
			if (IModuleInvoker.cb_hashCode == null)
			{
				IModuleInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IModuleInvoker.n_GetHashCode));
			}
			return IModuleInvoker.cb_hashCode;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00012977 File Offset: 0x00010B77
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00012986 File Offset: 0x00010B86
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000129C6 File Offset: 0x00010BC6
		private static Delegate GetToStringHandler()
		{
			if (IModuleInvoker.cb_toString == null)
			{
				IModuleInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IModuleInvoker.n_ToString));
			}
			return IModuleInvoker.cb_toString;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000129EA File Offset: 0x00010BEA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00012A00 File Offset: 0x00010C00
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000185 RID: 389
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Module", typeof(IModuleInvoker));

		// Token: 0x04000186 RID: 390
		private IntPtr class_ref;

		// Token: 0x04000187 RID: 391
		private static Delegate cb_includes;

		// Token: 0x04000188 RID: 392
		private IntPtr id_includes;

		// Token: 0x04000189 RID: 393
		private static Delegate cb_subcomponents;

		// Token: 0x0400018A RID: 394
		private IntPtr id_subcomponents;

		// Token: 0x0400018B RID: 395
		private static Delegate cb_annotationType;

		// Token: 0x0400018C RID: 396
		private IntPtr id_annotationType;

		// Token: 0x0400018D RID: 397
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400018E RID: 398
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400018F RID: 399
		private static Delegate cb_hashCode;

		// Token: 0x04000190 RID: 400
		private IntPtr id_hashCode;

		// Token: 0x04000191 RID: 401
		private static Delegate cb_toString;

		// Token: 0x04000192 RID: 402
		private IntPtr id_toString;
	}
}
