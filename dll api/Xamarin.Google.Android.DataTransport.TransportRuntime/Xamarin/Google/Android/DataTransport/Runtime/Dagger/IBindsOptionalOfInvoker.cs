using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A0 RID: 160
	[Register("com/google/android/datatransport/runtime/dagger/BindsOptionalOf", DoNotGenerateAcw = true)]
	internal class IBindsOptionalOfInvoker : Java.Lang.Object, IBindsOptionalOf, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00011100 File Offset: 0x0000F300
		private static IntPtr java_class_ref
		{
			get
			{
				return IBindsOptionalOfInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00011124 File Offset: 0x0000F324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBindsOptionalOfInvoker._members;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001112B File Offset: 0x0000F32B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00011133 File Offset: 0x0000F333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBindsOptionalOfInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001113F File Offset: 0x0000F33F
		public static IBindsOptionalOf GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBindsOptionalOf>(handle, transfer);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00011148 File Offset: 0x0000F348
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBindsOptionalOfInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.BindsOptionalOf'.");
			}
			return handle;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00011173 File Offset: 0x0000F373
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000111A4 File Offset: 0x0000F3A4
		public IBindsOptionalOfInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBindsOptionalOfInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000111DC File Offset: 0x0000F3DC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBindsOptionalOfInvoker.cb_annotationType == null)
			{
				IBindsOptionalOfInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBindsOptionalOfInvoker.n_AnnotationType));
			}
			return IBindsOptionalOfInvoker.cb_annotationType;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00011200 File Offset: 0x0000F400
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBindsOptionalOf>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00011214 File Offset: 0x0000F414
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00011265 File Offset: 0x0000F465
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBindsOptionalOfInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBindsOptionalOfInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBindsOptionalOfInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBindsOptionalOfInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0001128C File Offset: 0x0000F48C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBindsOptionalOf>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000112B0 File Offset: 0x0000F4B0
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

		// Token: 0x060005C5 RID: 1477 RVA: 0x00011323 File Offset: 0x0000F523
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBindsOptionalOfInvoker.cb_hashCode == null)
			{
				IBindsOptionalOfInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBindsOptionalOfInvoker.n_GetHashCode));
			}
			return IBindsOptionalOfInvoker.cb_hashCode;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00011347 File Offset: 0x0000F547
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBindsOptionalOf>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00011356 File Offset: 0x0000F556
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00011396 File Offset: 0x0000F596
		private static Delegate GetToStringHandler()
		{
			if (IBindsOptionalOfInvoker.cb_toString == null)
			{
				IBindsOptionalOfInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBindsOptionalOfInvoker.n_ToString));
			}
			return IBindsOptionalOfInvoker.cb_toString;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000113BA File Offset: 0x0000F5BA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBindsOptionalOf>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000113D0 File Offset: 0x0000F5D0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000145 RID: 325
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/BindsOptionalOf", typeof(IBindsOptionalOfInvoker));

		// Token: 0x04000146 RID: 326
		private IntPtr class_ref;

		// Token: 0x04000147 RID: 327
		private static Delegate cb_annotationType;

		// Token: 0x04000148 RID: 328
		private IntPtr id_annotationType;

		// Token: 0x04000149 RID: 329
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400014A RID: 330
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400014B RID: 331
		private static Delegate cb_hashCode;

		// Token: 0x0400014C RID: 332
		private IntPtr id_hashCode;

		// Token: 0x0400014D RID: 333
		private static Delegate cb_toString;

		// Token: 0x0400014E RID: 334
		private IntPtr id_toString;
	}
}
