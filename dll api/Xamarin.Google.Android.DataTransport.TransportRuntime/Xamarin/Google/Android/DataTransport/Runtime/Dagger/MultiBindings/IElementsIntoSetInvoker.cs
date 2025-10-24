using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C3 RID: 195
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/ElementsIntoSet", DoNotGenerateAcw = true)]
	internal class IElementsIntoSetInvoker : Java.Lang.Object, IElementsIntoSet, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00013F50 File Offset: 0x00012150
		private static IntPtr java_class_ref
		{
			get
			{
				return IElementsIntoSetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00013F74 File Offset: 0x00012174
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IElementsIntoSetInvoker._members;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00013F7B File Offset: 0x0001217B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00013F83 File Offset: 0x00012183
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IElementsIntoSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00013F8F File Offset: 0x0001218F
		public static IElementsIntoSet GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IElementsIntoSet>(handle, transfer);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00013F98 File Offset: 0x00012198
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IElementsIntoSetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.multibindings.ElementsIntoSet'.");
			}
			return handle;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00013FC3 File Offset: 0x000121C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00013FF4 File Offset: 0x000121F4
		public IElementsIntoSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IElementsIntoSetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001402C File Offset: 0x0001222C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IElementsIntoSetInvoker.cb_annotationType == null)
			{
				IElementsIntoSetInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IElementsIntoSetInvoker.n_AnnotationType));
			}
			return IElementsIntoSetInvoker.cb_annotationType;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00014050 File Offset: 0x00012250
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IElementsIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00014064 File Offset: 0x00012264
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000140B5 File Offset: 0x000122B5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IElementsIntoSetInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IElementsIntoSetInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IElementsIntoSetInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IElementsIntoSetInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000140DC File Offset: 0x000122DC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IElementsIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00014100 File Offset: 0x00012300
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

		// Token: 0x06000708 RID: 1800 RVA: 0x00014173 File Offset: 0x00012373
		private static Delegate GetGetHashCodeHandler()
		{
			if (IElementsIntoSetInvoker.cb_hashCode == null)
			{
				IElementsIntoSetInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IElementsIntoSetInvoker.n_GetHashCode));
			}
			return IElementsIntoSetInvoker.cb_hashCode;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00014197 File Offset: 0x00012397
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IElementsIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000141A6 File Offset: 0x000123A6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000141E6 File Offset: 0x000123E6
		private static Delegate GetToStringHandler()
		{
			if (IElementsIntoSetInvoker.cb_toString == null)
			{
				IElementsIntoSetInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IElementsIntoSetInvoker.n_ToString));
			}
			return IElementsIntoSetInvoker.cb_toString;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001420A File Offset: 0x0001240A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IElementsIntoSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00014220 File Offset: 0x00012420
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001D8 RID: 472
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/multibindings/ElementsIntoSet", typeof(IElementsIntoSetInvoker));

		// Token: 0x040001D9 RID: 473
		private IntPtr class_ref;

		// Token: 0x040001DA RID: 474
		private static Delegate cb_annotationType;

		// Token: 0x040001DB RID: 475
		private IntPtr id_annotationType;

		// Token: 0x040001DC RID: 476
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001DD RID: 477
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_hashCode;

		// Token: 0x040001DF RID: 479
		private IntPtr id_hashCode;

		// Token: 0x040001E0 RID: 480
		private static Delegate cb_toString;

		// Token: 0x040001E1 RID: 481
		private IntPtr id_toString;
	}
}
