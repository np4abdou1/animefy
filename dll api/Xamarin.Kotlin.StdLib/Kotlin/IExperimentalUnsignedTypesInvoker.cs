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
	// Token: 0x02000066 RID: 102
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ExperimentalUnsignedTypes", DoNotGenerateAcw = true)]
	internal class IExperimentalUnsignedTypesInvoker : Java.Lang.Object, IExperimentalUnsignedTypes, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00005104 File Offset: 0x00003304
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalUnsignedTypesInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00005128 File Offset: 0x00003328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalUnsignedTypesInvoker._members;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000512F File Offset: 0x0000332F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00005137 File Offset: 0x00003337
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalUnsignedTypesInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00005143 File Offset: 0x00003343
		[NullableContext(2)]
		public static IExperimentalUnsignedTypes GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalUnsignedTypes>(handle, transfer);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000514C File Offset: 0x0000334C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalUnsignedTypesInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ExperimentalUnsignedTypes'.");
			}
			return handle;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00005177 File Offset: 0x00003377
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000051A8 File Offset: 0x000033A8
		public IExperimentalUnsignedTypesInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalUnsignedTypesInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000051E0 File Offset: 0x000033E0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalUnsignedTypesInvoker.cb_annotationType == null)
			{
				IExperimentalUnsignedTypesInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalUnsignedTypesInvoker.n_AnnotationType));
			}
			return IExperimentalUnsignedTypesInvoker.cb_annotationType;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00005204 File Offset: 0x00003404
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalUnsignedTypes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00005218 File Offset: 0x00003418
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00005269 File Offset: 0x00003469
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalUnsignedTypesInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalUnsignedTypesInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalUnsignedTypesInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalUnsignedTypesInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00005290 File Offset: 0x00003490
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalUnsignedTypes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000052B4 File Offset: 0x000034B4
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

		// Token: 0x06000230 RID: 560 RVA: 0x00005327 File Offset: 0x00003527
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalUnsignedTypesInvoker.cb_hashCode == null)
			{
				IExperimentalUnsignedTypesInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalUnsignedTypesInvoker.n_GetHashCode));
			}
			return IExperimentalUnsignedTypesInvoker.cb_hashCode;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000534B File Offset: 0x0000354B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalUnsignedTypes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000535A File Offset: 0x0000355A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000539A File Offset: 0x0000359A
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalUnsignedTypesInvoker.cb_toString == null)
			{
				IExperimentalUnsignedTypesInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalUnsignedTypesInvoker.n_ToString));
			}
			return IExperimentalUnsignedTypesInvoker.cb_toString;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000053BE File Offset: 0x000035BE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalUnsignedTypes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000053D4 File Offset: 0x000035D4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400007E RID: 126
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ExperimentalUnsignedTypes", typeof(IExperimentalUnsignedTypesInvoker));

		// Token: 0x0400007F RID: 127
		private IntPtr class_ref;

		// Token: 0x04000080 RID: 128
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000081 RID: 129
		private IntPtr id_annotationType;

		// Token: 0x04000082 RID: 130
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000083 RID: 131
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000084 RID: 132
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000085 RID: 133
		private IntPtr id_hashCode;

		// Token: 0x04000086 RID: 134
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000087 RID: 135
		private IntPtr id_toString;
	}
}
