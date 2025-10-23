using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/OptIn", DoNotGenerateAcw = true)]
	internal class IOptInInvoker : Java.Lang.Object, IOptIn, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00006284 File Offset: 0x00004484
		private static IntPtr java_class_ref
		{
			get
			{
				return IOptInInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000062A8 File Offset: 0x000044A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOptInInvoker._members;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000062AF File Offset: 0x000044AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000062B7 File Offset: 0x000044B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOptInInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000062C3 File Offset: 0x000044C3
		[NullableContext(2)]
		public static IOptIn GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOptIn>(handle, transfer);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000062CC File Offset: 0x000044CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOptInInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.OptIn'.");
			}
			return handle;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000062F7 File Offset: 0x000044F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00006328 File Offset: 0x00004528
		public IOptInInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOptInInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00006360 File Offset: 0x00004560
		private static Delegate GetMarkerClassHandler()
		{
			if (IOptInInvoker.cb_markerClass == null)
			{
				IOptInInvoker.cb_markerClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOptInInvoker.n_MarkerClass));
			}
			return IOptInInvoker.cb_markerClass;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00006384 File Offset: 0x00004584
		private static IntPtr n_MarkerClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkerClass());
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00006398 File Offset: 0x00004598
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Class[] MarkerClass()
		{
			if (this.id_markerClass == IntPtr.Zero)
			{
				this.id_markerClass = JNIEnv.GetMethodID(this.class_ref, "markerClass", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_markerClass), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000063F8 File Offset: 0x000045F8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IOptInInvoker.cb_annotationType == null)
			{
				IOptInInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOptInInvoker.n_AnnotationType));
			}
			return IOptInInvoker.cb_annotationType;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000641C File Offset: 0x0000461C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00006430 File Offset: 0x00004630
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00006481 File Offset: 0x00004681
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IOptInInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IOptInInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IOptInInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IOptInInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000064A8 File Offset: 0x000046A8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000064CC File Offset: 0x000046CC
		[NullableContext(2)]
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

		// Token: 0x060002B3 RID: 691 RVA: 0x0000653F File Offset: 0x0000473F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IOptInInvoker.cb_hashCode == null)
			{
				IOptInInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IOptInInvoker.n_GetHashCode));
			}
			return IOptInInvoker.cb_hashCode;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00006563 File Offset: 0x00004763
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00006572 File Offset: 0x00004772
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000065B2 File Offset: 0x000047B2
		private static Delegate GetToStringHandler()
		{
			if (IOptInInvoker.cb_toString == null)
			{
				IOptInInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOptInInvoker.n_ToString));
			}
			return IOptInInvoker.cb_toString;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000065D6 File Offset: 0x000047D6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000065EC File Offset: 0x000047EC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000B5 RID: 181
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/OptIn", typeof(IOptInInvoker));

		// Token: 0x040000B6 RID: 182
		private IntPtr class_ref;

		// Token: 0x040000B7 RID: 183
		[Nullable(2)]
		private static Delegate cb_markerClass;

		// Token: 0x040000B8 RID: 184
		private IntPtr id_markerClass;

		// Token: 0x040000B9 RID: 185
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000BA RID: 186
		private IntPtr id_annotationType;

		// Token: 0x040000BB RID: 187
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000BC RID: 188
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000BD RID: 189
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000BE RID: 190
		private IntPtr id_hashCode;

		// Token: 0x040000BF RID: 191
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000C0 RID: 192
		private IntPtr id_toString;
	}
}
