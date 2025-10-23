using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000066 RID: 102
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/InternalCoroutinesApi", DoNotGenerateAcw = true)]
	internal class IInternalCoroutinesApiInvoker : Java.Lang.Object, IInternalCoroutinesApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		private static IntPtr java_class_ref
		{
			get
			{
				return IInternalCoroutinesApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0000DD20 File Offset: 0x0000BF20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInternalCoroutinesApiInvoker._members;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000DD27 File Offset: 0x0000BF27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0000DD2F File Offset: 0x0000BF2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInternalCoroutinesApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000DD3B File Offset: 0x0000BF3B
		[NullableContext(2)]
		public static IInternalCoroutinesApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInternalCoroutinesApi>(handle, transfer);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000DD44 File Offset: 0x0000BF44
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInternalCoroutinesApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.InternalCoroutinesApi'.");
			}
			return handle;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000DD6F File Offset: 0x0000BF6F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		public IInternalCoroutinesApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInternalCoroutinesApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IInternalCoroutinesApiInvoker.cb_annotationType == null)
			{
				IInternalCoroutinesApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInternalCoroutinesApiInvoker.n_AnnotationType));
			}
			return IInternalCoroutinesApiInvoker.cb_annotationType;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInternalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000DE10 File Offset: 0x0000C010
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000DE61 File Offset: 0x0000C061
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IInternalCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IInternalCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IInternalCoroutinesApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IInternalCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000DE88 File Offset: 0x0000C088
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IInternalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000DEAC File Offset: 0x0000C0AC
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

		// Token: 0x06000421 RID: 1057 RVA: 0x0000DF1F File Offset: 0x0000C11F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IInternalCoroutinesApiInvoker.cb_hashCode == null)
			{
				IInternalCoroutinesApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IInternalCoroutinesApiInvoker.n_GetHashCode));
			}
			return IInternalCoroutinesApiInvoker.cb_hashCode;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000DF43 File Offset: 0x0000C143
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IInternalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000DF52 File Offset: 0x0000C152
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000DF92 File Offset: 0x0000C192
		private static Delegate GetToStringHandler()
		{
			if (IInternalCoroutinesApiInvoker.cb_toString == null)
			{
				IInternalCoroutinesApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInternalCoroutinesApiInvoker.n_ToString));
			}
			return IInternalCoroutinesApiInvoker.cb_toString;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000DFB6 File Offset: 0x0000C1B6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInternalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000172 RID: 370
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/InternalCoroutinesApi", typeof(IInternalCoroutinesApiInvoker));

		// Token: 0x04000173 RID: 371
		private IntPtr class_ref;

		// Token: 0x04000174 RID: 372
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000175 RID: 373
		private IntPtr id_annotationType;

		// Token: 0x04000176 RID: 374
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000177 RID: 375
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000178 RID: 376
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000179 RID: 377
		private IntPtr id_hashCode;

		// Token: 0x0400017A RID: 378
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400017B RID: 379
		private IntPtr id_toString;
	}
}
