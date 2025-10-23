using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.IO.Encoding
{
	// Token: 0x0200023A RID: 570
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/encoding/ExperimentalEncodingApi", DoNotGenerateAcw = true)]
	internal class IExperimentalEncodingApiInvoker : Java.Lang.Object, IExperimentalEncodingApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00058B7C File Offset: 0x00056D7C
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalEncodingApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00058BA0 File Offset: 0x00056DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalEncodingApiInvoker._members;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00058BA7 File Offset: 0x00056DA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00058BAF File Offset: 0x00056DAF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalEncodingApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00058BBB File Offset: 0x00056DBB
		[NullableContext(2)]
		public static IExperimentalEncodingApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalEncodingApi>(handle, transfer);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00058BC4 File Offset: 0x00056DC4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalEncodingApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.io.encoding.ExperimentalEncodingApi'.");
			}
			return handle;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00058BEF File Offset: 0x00056DEF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00058C20 File Offset: 0x00056E20
		public IExperimentalEncodingApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalEncodingApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00058C58 File Offset: 0x00056E58
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalEncodingApiInvoker.cb_annotationType == null)
			{
				IExperimentalEncodingApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalEncodingApiInvoker.n_AnnotationType));
			}
			return IExperimentalEncodingApiInvoker.cb_annotationType;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00058C7C File Offset: 0x00056E7C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalEncodingApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00058C90 File Offset: 0x00056E90
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00058CE1 File Offset: 0x00056EE1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalEncodingApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalEncodingApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalEncodingApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalEncodingApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00058D08 File Offset: 0x00056F08
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalEncodingApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00058D2C File Offset: 0x00056F2C
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

		// Token: 0x06001A5E RID: 6750 RVA: 0x00058D9F File Offset: 0x00056F9F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalEncodingApiInvoker.cb_hashCode == null)
			{
				IExperimentalEncodingApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalEncodingApiInvoker.n_GetHashCode));
			}
			return IExperimentalEncodingApiInvoker.cb_hashCode;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00058DC3 File Offset: 0x00056FC3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalEncodingApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00058DD2 File Offset: 0x00056FD2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00058E12 File Offset: 0x00057012
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalEncodingApiInvoker.cb_toString == null)
			{
				IExperimentalEncodingApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalEncodingApiInvoker.n_ToString));
			}
			return IExperimentalEncodingApiInvoker.cb_toString;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00058E36 File Offset: 0x00057036
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalEncodingApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00058E4C File Offset: 0x0005704C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040007FE RID: 2046
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/encoding/ExperimentalEncodingApi", typeof(IExperimentalEncodingApiInvoker));

		// Token: 0x040007FF RID: 2047
		private IntPtr class_ref;

		// Token: 0x04000800 RID: 2048
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000801 RID: 2049
		private IntPtr id_annotationType;

		// Token: 0x04000802 RID: 2050
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000803 RID: 2051
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000804 RID: 2052
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000805 RID: 2053
		private IntPtr id_hashCode;

		// Token: 0x04000806 RID: 2054
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000807 RID: 2055
		private IntPtr id_toString;
	}
}
