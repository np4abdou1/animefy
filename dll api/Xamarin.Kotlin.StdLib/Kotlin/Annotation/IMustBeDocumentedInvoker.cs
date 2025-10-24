using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Annotation
{
	// Token: 0x02000289 RID: 649
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/annotation/MustBeDocumented", DoNotGenerateAcw = true)]
	internal class IMustBeDocumentedInvoker : Java.Lang.Object, IMustBeDocumented, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00061B24 File Offset: 0x0005FD24
		private static IntPtr java_class_ref
		{
			get
			{
				return IMustBeDocumentedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00061B48 File Offset: 0x0005FD48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMustBeDocumentedInvoker._members;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00061B4F File Offset: 0x0005FD4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00061B57 File Offset: 0x0005FD57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMustBeDocumentedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00061B63 File Offset: 0x0005FD63
		[NullableContext(2)]
		public static IMustBeDocumented GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMustBeDocumented>(handle, transfer);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00061B6C File Offset: 0x0005FD6C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMustBeDocumentedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.annotation.MustBeDocumented'.");
			}
			return handle;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00061B97 File Offset: 0x0005FD97
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00061BC8 File Offset: 0x0005FDC8
		public IMustBeDocumentedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMustBeDocumentedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00061C00 File Offset: 0x0005FE00
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMustBeDocumentedInvoker.cb_annotationType == null)
			{
				IMustBeDocumentedInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMustBeDocumentedInvoker.n_AnnotationType));
			}
			return IMustBeDocumentedInvoker.cb_annotationType;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00061C24 File Offset: 0x0005FE24
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMustBeDocumented>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00061C38 File Offset: 0x0005FE38
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00061C89 File Offset: 0x0005FE89
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMustBeDocumentedInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMustBeDocumentedInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMustBeDocumentedInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMustBeDocumentedInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00061CB0 File Offset: 0x0005FEB0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMustBeDocumented>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00061CD4 File Offset: 0x0005FED4
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

		// Token: 0x06001D51 RID: 7505 RVA: 0x00061D47 File Offset: 0x0005FF47
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMustBeDocumentedInvoker.cb_hashCode == null)
			{
				IMustBeDocumentedInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMustBeDocumentedInvoker.n_GetHashCode));
			}
			return IMustBeDocumentedInvoker.cb_hashCode;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00061D6B File Offset: 0x0005FF6B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMustBeDocumented>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00061D7A File Offset: 0x0005FF7A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00061DBA File Offset: 0x0005FFBA
		private static Delegate GetToStringHandler()
		{
			if (IMustBeDocumentedInvoker.cb_toString == null)
			{
				IMustBeDocumentedInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMustBeDocumentedInvoker.n_ToString));
			}
			return IMustBeDocumentedInvoker.cb_toString;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00061DDE File Offset: 0x0005FFDE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMustBeDocumented>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00061DF4 File Offset: 0x0005FFF4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040008E4 RID: 2276
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/annotation/MustBeDocumented", typeof(IMustBeDocumentedInvoker));

		// Token: 0x040008E5 RID: 2277
		private IntPtr class_ref;

		// Token: 0x040008E6 RID: 2278
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040008E7 RID: 2279
		private IntPtr id_annotationType;

		// Token: 0x040008E8 RID: 2280
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040008E9 RID: 2281
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040008EA RID: 2282
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040008EB RID: 2283
		private IntPtr id_hashCode;

		// Token: 0x040008EC RID: 2284
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040008ED RID: 2285
		private IntPtr id_toString;
	}
}
