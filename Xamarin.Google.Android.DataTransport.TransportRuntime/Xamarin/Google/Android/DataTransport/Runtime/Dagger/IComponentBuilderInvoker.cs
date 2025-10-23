using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A2 RID: 162
	[Register("com/google/android/datatransport/runtime/dagger/Component$Builder", DoNotGenerateAcw = true)]
	internal class IComponentBuilderInvoker : Java.Lang.Object, IComponentBuilder, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001143C File Offset: 0x0000F63C
		private static IntPtr java_class_ref
		{
			get
			{
				return IComponentBuilderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00011460 File Offset: 0x0000F660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComponentBuilderInvoker._members;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00011467 File Offset: 0x0000F667
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001146F File Offset: 0x0000F66F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComponentBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001147B File Offset: 0x0000F67B
		public static IComponentBuilder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IComponentBuilder>(handle, transfer);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00011484 File Offset: 0x0000F684
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComponentBuilderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Component.Builder'.");
			}
			return handle;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000114AF File Offset: 0x0000F6AF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000114E0 File Offset: 0x0000F6E0
		public IComponentBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComponentBuilderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00011518 File Offset: 0x0000F718
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IComponentBuilderInvoker.cb_annotationType == null)
			{
				IComponentBuilderInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentBuilderInvoker.n_AnnotationType));
			}
			return IComponentBuilderInvoker.cb_annotationType;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001153C File Offset: 0x0000F73C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00011550 File Offset: 0x0000F750
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000115A1 File Offset: 0x0000F7A1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IComponentBuilderInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IComponentBuilderInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IComponentBuilderInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IComponentBuilderInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000115C8 File Offset: 0x0000F7C8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IComponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000115EC File Offset: 0x0000F7EC
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

		// Token: 0x060005DA RID: 1498 RVA: 0x0001165F File Offset: 0x0000F85F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IComponentBuilderInvoker.cb_hashCode == null)
			{
				IComponentBuilderInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IComponentBuilderInvoker.n_GetHashCode));
			}
			return IComponentBuilderInvoker.cb_hashCode;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00011683 File Offset: 0x0000F883
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00011692 File Offset: 0x0000F892
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000116D2 File Offset: 0x0000F8D2
		private static Delegate GetToStringHandler()
		{
			if (IComponentBuilderInvoker.cb_toString == null)
			{
				IComponentBuilderInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComponentBuilderInvoker.n_ToString));
			}
			return IComponentBuilderInvoker.cb_toString;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000116F6 File Offset: 0x0000F8F6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IComponentBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001170C File Offset: 0x0000F90C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400014F RID: 335
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Component$Builder", typeof(IComponentBuilderInvoker));

		// Token: 0x04000150 RID: 336
		private IntPtr class_ref;

		// Token: 0x04000151 RID: 337
		private static Delegate cb_annotationType;

		// Token: 0x04000152 RID: 338
		private IntPtr id_annotationType;

		// Token: 0x04000153 RID: 339
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000154 RID: 340
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000155 RID: 341
		private static Delegate cb_hashCode;

		// Token: 0x04000156 RID: 342
		private IntPtr id_hashCode;

		// Token: 0x04000157 RID: 343
		private static Delegate cb_toString;

		// Token: 0x04000158 RID: 344
		private IntPtr id_toString;
	}
}
