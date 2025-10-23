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
	// Token: 0x02000079 RID: 121
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/PublishedApi", DoNotGenerateAcw = true)]
	internal class IPublishedApiInvoker : Java.Lang.Object, IPublishedApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00007098 File Offset: 0x00005298
		private static IntPtr java_class_ref
		{
			get
			{
				return IPublishedApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000070BC File Offset: 0x000052BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPublishedApiInvoker._members;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002FF RID: 767 RVA: 0x000070C3 File Offset: 0x000052C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000070CB File Offset: 0x000052CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPublishedApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000070D7 File Offset: 0x000052D7
		[NullableContext(2)]
		public static IPublishedApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPublishedApi>(handle, transfer);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000070E0 File Offset: 0x000052E0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPublishedApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.PublishedApi'.");
			}
			return handle;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000710B File Offset: 0x0000530B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000713C File Offset: 0x0000533C
		public IPublishedApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPublishedApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00007174 File Offset: 0x00005374
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IPublishedApiInvoker.cb_annotationType == null)
			{
				IPublishedApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPublishedApiInvoker.n_AnnotationType));
			}
			return IPublishedApiInvoker.cb_annotationType;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00007198 File Offset: 0x00005398
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPublishedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000071AC File Offset: 0x000053AC
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000071FD File Offset: 0x000053FD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IPublishedApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IPublishedApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPublishedApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IPublishedApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00007224 File Offset: 0x00005424
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IPublishedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00007248 File Offset: 0x00005448
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

		// Token: 0x0600030B RID: 779 RVA: 0x000072BB File Offset: 0x000054BB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IPublishedApiInvoker.cb_hashCode == null)
			{
				IPublishedApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPublishedApiInvoker.n_GetHashCode));
			}
			return IPublishedApiInvoker.cb_hashCode;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000072DF File Offset: 0x000054DF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPublishedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000072EE File Offset: 0x000054EE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000732E File Offset: 0x0000552E
		private static Delegate GetToStringHandler()
		{
			if (IPublishedApiInvoker.cb_toString == null)
			{
				IPublishedApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPublishedApiInvoker.n_ToString));
			}
			return IPublishedApiInvoker.cb_toString;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00007352 File Offset: 0x00005552
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPublishedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00007368 File Offset: 0x00005568
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000E1 RID: 225
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/PublishedApi", typeof(IPublishedApiInvoker));

		// Token: 0x040000E2 RID: 226
		private IntPtr class_ref;

		// Token: 0x040000E3 RID: 227
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000E4 RID: 228
		private IntPtr id_annotationType;

		// Token: 0x040000E5 RID: 229
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000E6 RID: 230
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000E7 RID: 231
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000E8 RID: 232
		private IntPtr id_hashCode;

		// Token: 0x040000E9 RID: 233
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000EA RID: 234
		private IntPtr id_toString;
	}
}
