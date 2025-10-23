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
	// Token: 0x02000064 RID: 100
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/FlowPreview", DoNotGenerateAcw = true)]
	internal class IFlowPreviewInvoker : Java.Lang.Object, IFlowPreview, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
		private static IntPtr java_class_ref
		{
			get
			{
				return IFlowPreviewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFlowPreviewInvoker._members;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000D9EB File Offset: 0x0000BBEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000D9F3 File Offset: 0x0000BBF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFlowPreviewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000D9FF File Offset: 0x0000BBFF
		[NullableContext(2)]
		public static IFlowPreview GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFlowPreview>(handle, transfer);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000DA08 File Offset: 0x0000BC08
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFlowPreviewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.FlowPreview'.");
			}
			return handle;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000DA33 File Offset: 0x0000BC33
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000DA64 File Offset: 0x0000BC64
		public IFlowPreviewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFlowPreviewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000DA9C File Offset: 0x0000BC9C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IFlowPreviewInvoker.cb_annotationType == null)
			{
				IFlowPreviewInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFlowPreviewInvoker.n_AnnotationType));
			}
			return IFlowPreviewInvoker.cb_annotationType;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFlowPreview>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000DB25 File Offset: 0x0000BD25
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IFlowPreviewInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IFlowPreviewInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IFlowPreviewInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IFlowPreviewInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IFlowPreview>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000DB70 File Offset: 0x0000BD70
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

		// Token: 0x0600040C RID: 1036 RVA: 0x0000DBE3 File Offset: 0x0000BDE3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IFlowPreviewInvoker.cb_hashCode == null)
			{
				IFlowPreviewInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IFlowPreviewInvoker.n_GetHashCode));
			}
			return IFlowPreviewInvoker.cb_hashCode;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000DC07 File Offset: 0x0000BE07
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFlowPreview>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000DC16 File Offset: 0x0000BE16
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000DC56 File Offset: 0x0000BE56
		private static Delegate GetToStringHandler()
		{
			if (IFlowPreviewInvoker.cb_toString == null)
			{
				IFlowPreviewInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFlowPreviewInvoker.n_ToString));
			}
			return IFlowPreviewInvoker.cb_toString;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000DC7A File Offset: 0x0000BE7A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFlowPreview>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000DC90 File Offset: 0x0000BE90
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000168 RID: 360
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/FlowPreview", typeof(IFlowPreviewInvoker));

		// Token: 0x04000169 RID: 361
		private IntPtr class_ref;

		// Token: 0x0400016A RID: 362
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400016B RID: 363
		private IntPtr id_annotationType;

		// Token: 0x0400016C RID: 364
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400016D RID: 365
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400016E RID: 366
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400016F RID: 367
		private IntPtr id_hashCode;

		// Token: 0x04000170 RID: 368
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000171 RID: 369
		private IntPtr id_toString;
	}
}
