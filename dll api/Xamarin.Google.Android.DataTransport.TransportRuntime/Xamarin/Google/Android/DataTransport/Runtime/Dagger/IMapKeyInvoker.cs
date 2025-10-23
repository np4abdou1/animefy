using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000AA RID: 170
	[Register("com/google/android/datatransport/runtime/dagger/MapKey", DoNotGenerateAcw = true)]
	internal class IMapKeyInvoker : Java.Lang.Object, IMapKey, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x000120A0 File Offset: 0x000102A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IMapKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000120C4 File Offset: 0x000102C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMapKeyInvoker._members;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000120CB File Offset: 0x000102CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000120D3 File Offset: 0x000102D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMapKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x000120DF File Offset: 0x000102DF
		public static IMapKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMapKey>(handle, transfer);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000120E8 File Offset: 0x000102E8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMapKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.MapKey'.");
			}
			return handle;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00012113 File Offset: 0x00010313
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00012144 File Offset: 0x00010344
		public IMapKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMapKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001217C File Offset: 0x0001037C
		private static Delegate GetUnwrapValueHandler()
		{
			if (IMapKeyInvoker.cb_unwrapValue == null)
			{
				IMapKeyInvoker.cb_unwrapValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMapKeyInvoker.n_UnwrapValue));
			}
			return IMapKeyInvoker.cb_unwrapValue;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000121A0 File Offset: 0x000103A0
		private static bool n_UnwrapValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMapKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UnwrapValue();
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000121AF File Offset: 0x000103AF
		public bool UnwrapValue()
		{
			if (this.id_unwrapValue == IntPtr.Zero)
			{
				this.id_unwrapValue = JNIEnv.GetMethodID(this.class_ref, "unwrapValue", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_unwrapValue);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000121EF File Offset: 0x000103EF
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMapKeyInvoker.cb_annotationType == null)
			{
				IMapKeyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapKeyInvoker.n_AnnotationType));
			}
			return IMapKeyInvoker.cb_annotationType;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00012213 File Offset: 0x00010413
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMapKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00012228 File Offset: 0x00010428
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00012279 File Offset: 0x00010479
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMapKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMapKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMapKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMapKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000122A0 File Offset: 0x000104A0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMapKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000122C4 File Offset: 0x000104C4
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

		// Token: 0x06000632 RID: 1586 RVA: 0x00012337 File Offset: 0x00010537
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMapKeyInvoker.cb_hashCode == null)
			{
				IMapKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMapKeyInvoker.n_GetHashCode));
			}
			return IMapKeyInvoker.cb_hashCode;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001235B File Offset: 0x0001055B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMapKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001236A File Offset: 0x0001056A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000123AA File Offset: 0x000105AA
		private static Delegate GetToStringHandler()
		{
			if (IMapKeyInvoker.cb_toString == null)
			{
				IMapKeyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapKeyInvoker.n_ToString));
			}
			return IMapKeyInvoker.cb_toString;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000123CE File Offset: 0x000105CE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMapKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000123E4 File Offset: 0x000105E4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000175 RID: 373
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/MapKey", typeof(IMapKeyInvoker));

		// Token: 0x04000176 RID: 374
		private IntPtr class_ref;

		// Token: 0x04000177 RID: 375
		private static Delegate cb_unwrapValue;

		// Token: 0x04000178 RID: 376
		private IntPtr id_unwrapValue;

		// Token: 0x04000179 RID: 377
		private static Delegate cb_annotationType;

		// Token: 0x0400017A RID: 378
		private IntPtr id_annotationType;

		// Token: 0x0400017B RID: 379
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400017C RID: 380
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400017D RID: 381
		private static Delegate cb_hashCode;

		// Token: 0x0400017E RID: 382
		private IntPtr id_hashCode;

		// Token: 0x0400017F RID: 383
		private static Delegate cb_toString;

		// Token: 0x04000180 RID: 384
		private IntPtr id_toString;
	}
}
