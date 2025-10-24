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
	// Token: 0x02000068 RID: 104
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ExtensionFunctionType", DoNotGenerateAcw = true)]
	internal class IExtensionFunctionTypeInvoker : Java.Lang.Object, IExtensionFunctionType, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00005440 File Offset: 0x00003640
		private static IntPtr java_class_ref
		{
			get
			{
				return IExtensionFunctionTypeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00005464 File Offset: 0x00003664
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExtensionFunctionTypeInvoker._members;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000546B File Offset: 0x0000366B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00005473 File Offset: 0x00003673
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExtensionFunctionTypeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000547F File Offset: 0x0000367F
		[NullableContext(2)]
		public static IExtensionFunctionType GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExtensionFunctionType>(handle, transfer);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00005488 File Offset: 0x00003688
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExtensionFunctionTypeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ExtensionFunctionType'.");
			}
			return handle;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000054B3 File Offset: 0x000036B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000054E4 File Offset: 0x000036E4
		public IExtensionFunctionTypeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExtensionFunctionTypeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000551C File Offset: 0x0000371C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExtensionFunctionTypeInvoker.cb_annotationType == null)
			{
				IExtensionFunctionTypeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExtensionFunctionTypeInvoker.n_AnnotationType));
			}
			return IExtensionFunctionTypeInvoker.cb_annotationType;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00005540 File Offset: 0x00003740
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExtensionFunctionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00005554 File Offset: 0x00003754
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000055A5 File Offset: 0x000037A5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExtensionFunctionTypeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExtensionFunctionTypeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExtensionFunctionTypeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExtensionFunctionTypeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000055CC File Offset: 0x000037CC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExtensionFunctionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000055F0 File Offset: 0x000037F0
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

		// Token: 0x06000245 RID: 581 RVA: 0x00005663 File Offset: 0x00003863
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExtensionFunctionTypeInvoker.cb_hashCode == null)
			{
				IExtensionFunctionTypeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExtensionFunctionTypeInvoker.n_GetHashCode));
			}
			return IExtensionFunctionTypeInvoker.cb_hashCode;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00005687 File Offset: 0x00003887
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExtensionFunctionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00005696 File Offset: 0x00003896
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000056D6 File Offset: 0x000038D6
		private static Delegate GetToStringHandler()
		{
			if (IExtensionFunctionTypeInvoker.cb_toString == null)
			{
				IExtensionFunctionTypeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExtensionFunctionTypeInvoker.n_ToString));
			}
			return IExtensionFunctionTypeInvoker.cb_toString;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000056FA File Offset: 0x000038FA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExtensionFunctionType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00005710 File Offset: 0x00003910
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000088 RID: 136
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ExtensionFunctionType", typeof(IExtensionFunctionTypeInvoker));

		// Token: 0x04000089 RID: 137
		private IntPtr class_ref;

		// Token: 0x0400008A RID: 138
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400008B RID: 139
		private IntPtr id_annotationType;

		// Token: 0x0400008C RID: 140
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400008D RID: 141
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400008E RID: 142
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400008F RID: 143
		private IntPtr id_hashCode;

		// Token: 0x04000090 RID: 144
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000091 RID: 145
		private IntPtr id_toString;
	}
}
