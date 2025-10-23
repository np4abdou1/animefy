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
	// Token: 0x02000064 RID: 100
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ExperimentalSubclassOptIn", DoNotGenerateAcw = true)]
	internal class IExperimentalSubclassOptInInvoker : Java.Lang.Object, IExperimentalSubclassOptIn, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00004DC8 File Offset: 0x00002FC8
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalSubclassOptInInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00004DEC File Offset: 0x00002FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalSubclassOptInInvoker._members;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00004DF3 File Offset: 0x00002FF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00004DFB File Offset: 0x00002FFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalSubclassOptInInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00004E07 File Offset: 0x00003007
		[NullableContext(2)]
		public static IExperimentalSubclassOptIn GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalSubclassOptIn>(handle, transfer);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00004E10 File Offset: 0x00003010
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalSubclassOptInInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ExperimentalSubclassOptIn'.");
			}
			return handle;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00004E3B File Offset: 0x0000303B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004E6C File Offset: 0x0000306C
		public IExperimentalSubclassOptInInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalSubclassOptInInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00004EA4 File Offset: 0x000030A4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalSubclassOptInInvoker.cb_annotationType == null)
			{
				IExperimentalSubclassOptInInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalSubclassOptInInvoker.n_AnnotationType));
			}
			return IExperimentalSubclassOptInInvoker.cb_annotationType;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00004EC8 File Offset: 0x000030C8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalSubclassOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00004EDC File Offset: 0x000030DC
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00004F2D File Offset: 0x0000312D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalSubclassOptInInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalSubclassOptInInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalSubclassOptInInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalSubclassOptInInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00004F54 File Offset: 0x00003154
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalSubclassOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00004F78 File Offset: 0x00003178
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

		// Token: 0x0600021B RID: 539 RVA: 0x00004FEB File Offset: 0x000031EB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalSubclassOptInInvoker.cb_hashCode == null)
			{
				IExperimentalSubclassOptInInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalSubclassOptInInvoker.n_GetHashCode));
			}
			return IExperimentalSubclassOptInInvoker.cb_hashCode;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000500F File Offset: 0x0000320F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalSubclassOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000501E File Offset: 0x0000321E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000505E File Offset: 0x0000325E
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalSubclassOptInInvoker.cb_toString == null)
			{
				IExperimentalSubclassOptInInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalSubclassOptInInvoker.n_ToString));
			}
			return IExperimentalSubclassOptInInvoker.cb_toString;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00005082 File Offset: 0x00003282
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalSubclassOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005098 File Offset: 0x00003298
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000074 RID: 116
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ExperimentalSubclassOptIn", typeof(IExperimentalSubclassOptInInvoker));

		// Token: 0x04000075 RID: 117
		private IntPtr class_ref;

		// Token: 0x04000076 RID: 118
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000077 RID: 119
		private IntPtr id_annotationType;

		// Token: 0x04000078 RID: 120
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000079 RID: 121
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400007A RID: 122
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400007B RID: 123
		private IntPtr id_hashCode;

		// Token: 0x0400007C RID: 124
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400007D RID: 125
		private IntPtr id_toString;
	}
}
