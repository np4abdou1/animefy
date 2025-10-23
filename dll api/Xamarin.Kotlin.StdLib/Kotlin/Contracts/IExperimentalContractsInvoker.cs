using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Contracts
{
	// Token: 0x02000278 RID: 632
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/contracts/ExperimentalContracts", DoNotGenerateAcw = true)]
	internal class IExperimentalContractsInvoker : Java.Lang.Object, IExperimentalContracts, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0005EC20 File Offset: 0x0005CE20
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalContractsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0005EC44 File Offset: 0x0005CE44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalContractsInvoker._members;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0005EC4B File Offset: 0x0005CE4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0005EC53 File Offset: 0x0005CE53
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalContractsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0005EC5F File Offset: 0x0005CE5F
		[NullableContext(2)]
		public static IExperimentalContracts GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalContracts>(handle, transfer);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0005EC68 File Offset: 0x0005CE68
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalContractsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.ExperimentalContracts'.");
			}
			return handle;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0005EC93 File Offset: 0x0005CE93
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0005ECC4 File Offset: 0x0005CEC4
		public IExperimentalContractsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalContractsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0005ECFC File Offset: 0x0005CEFC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalContractsInvoker.cb_annotationType == null)
			{
				IExperimentalContractsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalContractsInvoker.n_AnnotationType));
			}
			return IExperimentalContractsInvoker.cb_annotationType;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0005ED20 File Offset: 0x0005CF20
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalContracts>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0005ED34 File Offset: 0x0005CF34
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0005ED85 File Offset: 0x0005CF85
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalContractsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalContractsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalContractsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalContractsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0005EDAC File Offset: 0x0005CFAC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalContracts>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
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

		// Token: 0x06001C8F RID: 7311 RVA: 0x0005EE43 File Offset: 0x0005D043
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalContractsInvoker.cb_hashCode == null)
			{
				IExperimentalContractsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalContractsInvoker.n_GetHashCode));
			}
			return IExperimentalContractsInvoker.cb_hashCode;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0005EE67 File Offset: 0x0005D067
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalContracts>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0005EE76 File Offset: 0x0005D076
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0005EEB6 File Offset: 0x0005D0B6
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalContractsInvoker.cb_toString == null)
			{
				IExperimentalContractsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalContractsInvoker.n_ToString));
			}
			return IExperimentalContractsInvoker.cb_toString;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0005EEDA File Offset: 0x0005D0DA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalContracts>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040008C5 RID: 2245
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/ExperimentalContracts", typeof(IExperimentalContractsInvoker));

		// Token: 0x040008C6 RID: 2246
		private IntPtr class_ref;

		// Token: 0x040008C7 RID: 2247
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040008C8 RID: 2248
		private IntPtr id_annotationType;

		// Token: 0x040008C9 RID: 2249
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040008CA RID: 2250
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040008CB RID: 2251
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040008CC RID: 2252
		private IntPtr id_hashCode;

		// Token: 0x040008CD RID: 2253
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040008CE RID: 2254
		private IntPtr id_toString;
	}
}
