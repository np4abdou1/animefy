using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200001A RID: 26
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Contract", DoNotGenerateAcw = true)]
	internal class IContractInvoker : Java.Lang.Object, IContract, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002C38 File Offset: 0x00000E38
		private static IntPtr java_class_ref
		{
			get
			{
				return IContractInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002C5C File Offset: 0x00000E5C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IContractInvoker._members;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002C63 File Offset: 0x00000E63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002C6B File Offset: 0x00000E6B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IContractInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002C77 File Offset: 0x00000E77
		public static IContract GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContract>(handle, transfer);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002C80 File Offset: 0x00000E80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContractInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Contract'.");
			}
			return handle;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002CAB File Offset: 0x00000EAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002CDC File Offset: 0x00000EDC
		public IContractInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContractInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002D14 File Offset: 0x00000F14
		[NullableContext(1)]
		private static Delegate GetMutatesHandler()
		{
			if (IContractInvoker.cb_mutates == null)
			{
				IContractInvoker.cb_mutates = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContractInvoker.n_Mutates));
			}
			return IContractInvoker.cb_mutates;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002D38 File Offset: 0x00000F38
		private static IntPtr n_Mutates(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Mutates());
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002D4C File Offset: 0x00000F4C
		public string Mutates()
		{
			if (this.id_mutates == IntPtr.Zero)
			{
				this.id_mutates = JNIEnv.GetMethodID(this.class_ref, "mutates", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_mutates), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002D9D File Offset: 0x00000F9D
		[NullableContext(1)]
		private static Delegate GetPureHandler()
		{
			if (IContractInvoker.cb_pure == null)
			{
				IContractInvoker.cb_pure = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IContractInvoker.n_Pure));
			}
			return IContractInvoker.cb_pure;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002DC1 File Offset: 0x00000FC1
		private static bool n_Pure(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pure();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public bool Pure()
		{
			if (this.id_pure == IntPtr.Zero)
			{
				this.id_pure = JNIEnv.GetMethodID(this.class_ref, "pure", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_pure);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002E10 File Offset: 0x00001010
		[NullableContext(1)]
		private static Delegate GetValueHandler()
		{
			if (IContractInvoker.cb_value == null)
			{
				IContractInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContractInvoker.n_Value));
			}
			return IContractInvoker.cb_value;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002E34 File Offset: 0x00001034
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002E48 File Offset: 0x00001048
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002E99 File Offset: 0x00001099
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IContractInvoker.cb_annotationType == null)
			{
				IContractInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContractInvoker.n_AnnotationType));
			}
			return IContractInvoker.cb_annotationType;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002EBD File Offset: 0x000010BD
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002ED4 File Offset: 0x000010D4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002F25 File Offset: 0x00001125
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IContractInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IContractInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IContractInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IContractInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002F4C File Offset: 0x0000114C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002F70 File Offset: 0x00001170
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

		// Token: 0x06000090 RID: 144 RVA: 0x00002FE3 File Offset: 0x000011E3
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IContractInvoker.cb_hashCode == null)
			{
				IContractInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IContractInvoker.n_GetHashCode));
			}
			return IContractInvoker.cb_hashCode;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003007 File Offset: 0x00001207
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003016 File Offset: 0x00001216
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003056 File Offset: 0x00001256
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IContractInvoker.cb_toString == null)
			{
				IContractInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContractInvoker.n_ToString));
			}
			return IContractInvoker.cb_toString;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000307A File Offset: 0x0000127A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003090 File Offset: 0x00001290
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000028 RID: 40
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Contract", typeof(IContractInvoker));

		// Token: 0x04000029 RID: 41
		private IntPtr class_ref;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_mutates;

		// Token: 0x0400002B RID: 43
		private IntPtr id_mutates;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_pure;

		// Token: 0x0400002D RID: 45
		private IntPtr id_pure;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_value;

		// Token: 0x0400002F RID: 47
		private IntPtr id_value;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_annotationType;

		// Token: 0x04000031 RID: 49
		private IntPtr id_annotationType;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000033 RID: 51
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_hashCode;

		// Token: 0x04000035 RID: 53
		private IntPtr id_hashCode;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_toString;

		// Token: 0x04000037 RID: 55
		private IntPtr id_toString;
	}
}
