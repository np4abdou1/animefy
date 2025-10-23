using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B2 RID: 178
	[Register("com/google/android/datatransport/runtime/dagger/Reusable", DoNotGenerateAcw = true)]
	internal class IReusableInvoker : Java.Lang.Object, IReusable, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00012DA8 File Offset: 0x00010FA8
		private static IntPtr java_class_ref
		{
			get
			{
				return IReusableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00012DCC File Offset: 0x00010FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReusableInvoker._members;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00012DD3 File Offset: 0x00010FD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00012DDB File Offset: 0x00010FDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReusableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00012DE7 File Offset: 0x00010FE7
		public static IReusable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReusable>(handle, transfer);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00012DF0 File Offset: 0x00010FF0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReusableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Reusable'.");
			}
			return handle;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00012E1B File Offset: 0x0001101B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00012E4C File Offset: 0x0001104C
		public IReusableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReusableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00012E84 File Offset: 0x00011084
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IReusableInvoker.cb_annotationType == null)
			{
				IReusableInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReusableInvoker.n_AnnotationType));
			}
			return IReusableInvoker.cb_annotationType;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00012EA8 File Offset: 0x000110A8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReusable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00012EBC File Offset: 0x000110BC
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00012F0D File Offset: 0x0001110D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IReusableInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IReusableInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IReusableInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IReusableInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00012F34 File Offset: 0x00011134
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IReusable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00012F58 File Offset: 0x00011158
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

		// Token: 0x06000686 RID: 1670 RVA: 0x00012FCB File Offset: 0x000111CB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IReusableInvoker.cb_hashCode == null)
			{
				IReusableInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IReusableInvoker.n_GetHashCode));
			}
			return IReusableInvoker.cb_hashCode;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00012FEF File Offset: 0x000111EF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IReusable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00012FFE File Offset: 0x000111FE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001303E File Offset: 0x0001123E
		private static Delegate GetToStringHandler()
		{
			if (IReusableInvoker.cb_toString == null)
			{
				IReusableInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReusableInvoker.n_ToString));
			}
			return IReusableInvoker.cb_toString;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00013062 File Offset: 0x00011262
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IReusable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00013078 File Offset: 0x00011278
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400019D RID: 413
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Reusable", typeof(IReusableInvoker));

		// Token: 0x0400019E RID: 414
		private IntPtr class_ref;

		// Token: 0x0400019F RID: 415
		private static Delegate cb_annotationType;

		// Token: 0x040001A0 RID: 416
		private IntPtr id_annotationType;

		// Token: 0x040001A1 RID: 417
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001A2 RID: 418
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001A3 RID: 419
		private static Delegate cb_hashCode;

		// Token: 0x040001A4 RID: 420
		private IntPtr id_hashCode;

		// Token: 0x040001A5 RID: 421
		private static Delegate cb_toString;

		// Token: 0x040001A6 RID: 422
		private IntPtr id_toString;
	}
}
