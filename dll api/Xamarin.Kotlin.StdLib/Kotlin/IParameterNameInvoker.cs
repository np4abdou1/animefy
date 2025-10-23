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
	// Token: 0x02000077 RID: 119
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ParameterName", DoNotGenerateAcw = true)]
	internal class IParameterNameInvoker : Java.Lang.Object, IParameterName, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00006CD0 File Offset: 0x00004ED0
		private static IntPtr java_class_ref
		{
			get
			{
				return IParameterNameInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00006CF4 File Offset: 0x00004EF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IParameterNameInvoker._members;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00006CFB File Offset: 0x00004EFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00006D03 File Offset: 0x00004F03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IParameterNameInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00006D0F File Offset: 0x00004F0F
		[NullableContext(2)]
		public static IParameterName GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IParameterName>(handle, transfer);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00006D18 File Offset: 0x00004F18
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IParameterNameInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ParameterName'.");
			}
			return handle;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00006D43 File Offset: 0x00004F43
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00006D74 File Offset: 0x00004F74
		public IParameterNameInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IParameterNameInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00006DAC File Offset: 0x00004FAC
		private static Delegate GetNameHandler()
		{
			if (IParameterNameInvoker.cb_name == null)
			{
				IParameterNameInvoker.cb_name = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParameterNameInvoker.n_Name));
			}
			return IParameterNameInvoker.cb_name;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00006DD0 File Offset: 0x00004FD0
		private static IntPtr n_Name(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IParameterName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name());
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00006DE4 File Offset: 0x00004FE4
		[NullableContext(2)]
		public string Name()
		{
			if (this.id_name == IntPtr.Zero)
			{
				this.id_name = JNIEnv.GetMethodID(this.class_ref, "name", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_name), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00006E35 File Offset: 0x00005035
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IParameterNameInvoker.cb_annotationType == null)
			{
				IParameterNameInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParameterNameInvoker.n_AnnotationType));
			}
			return IParameterNameInvoker.cb_annotationType;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00006E59 File Offset: 0x00005059
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParameterName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00006E70 File Offset: 0x00005070
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00006EC1 File Offset: 0x000050C1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IParameterNameInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IParameterNameInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IParameterNameInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IParameterNameInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00006EE8 File Offset: 0x000050E8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IParameterName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00006F0C File Offset: 0x0000510C
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

		// Token: 0x060002F6 RID: 758 RVA: 0x00006F7F File Offset: 0x0000517F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IParameterNameInvoker.cb_hashCode == null)
			{
				IParameterNameInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IParameterNameInvoker.n_GetHashCode));
			}
			return IParameterNameInvoker.cb_hashCode;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00006FA3 File Offset: 0x000051A3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParameterName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00006FB2 File Offset: 0x000051B2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00006FF2 File Offset: 0x000051F2
		private static Delegate GetToStringHandler()
		{
			if (IParameterNameInvoker.cb_toString == null)
			{
				IParameterNameInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParameterNameInvoker.n_ToString));
			}
			return IParameterNameInvoker.cb_toString;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00007016 File Offset: 0x00005216
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IParameterName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000702C File Offset: 0x0000522C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000D5 RID: 213
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ParameterName", typeof(IParameterNameInvoker));

		// Token: 0x040000D6 RID: 214
		private IntPtr class_ref;

		// Token: 0x040000D7 RID: 215
		[Nullable(2)]
		private static Delegate cb_name;

		// Token: 0x040000D8 RID: 216
		private IntPtr id_name;

		// Token: 0x040000D9 RID: 217
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000DA RID: 218
		private IntPtr id_annotationType;

		// Token: 0x040000DB RID: 219
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000DC RID: 220
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000DD RID: 221
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000DE RID: 222
		private IntPtr id_hashCode;

		// Token: 0x040000DF RID: 223
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000E0 RID: 224
		private IntPtr id_toString;
	}
}
