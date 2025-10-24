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
	// Token: 0x0200007E RID: 126
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/RequiresOptIn", DoNotGenerateAcw = true)]
	internal class IRequiresOptInInvoker : Java.Lang.Object, IRequiresOptIn, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000079F8 File Offset: 0x00005BF8
		private static IntPtr java_class_ref
		{
			get
			{
				return IRequiresOptInInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00007A1C File Offset: 0x00005C1C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IRequiresOptInInvoker._members;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00007A23 File Offset: 0x00005C23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00007A2B File Offset: 0x00005C2B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IRequiresOptInInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00007A37 File Offset: 0x00005C37
		public static IRequiresOptIn GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRequiresOptIn>(handle, transfer);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00007A40 File Offset: 0x00005C40
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRequiresOptInInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.RequiresOptIn'.");
			}
			return handle;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00007A6B File Offset: 0x00005C6B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00007A9C File Offset: 0x00005C9C
		public IRequiresOptInInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRequiresOptInInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00007AD4 File Offset: 0x00005CD4
		[NullableContext(1)]
		private static Delegate GetLevelHandler()
		{
			if (IRequiresOptInInvoker.cb_level == null)
			{
				IRequiresOptInInvoker.cb_level = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiresOptInInvoker.n_Level));
			}
			return IRequiresOptInInvoker.cb_level;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00007AF8 File Offset: 0x00005CF8
		private static IntPtr n_Level(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRequiresOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Level());
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00007B0C File Offset: 0x00005D0C
		public RequiresOptInLevel Level()
		{
			if (this.id_level == IntPtr.Zero)
			{
				this.id_level = JNIEnv.GetMethodID(this.class_ref, "level", "()Lkotlin/RequiresOptIn$Level;");
			}
			return Java.Lang.Object.GetObject<RequiresOptInLevel>(JNIEnv.CallObjectMethod(base.Handle, this.id_level), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00007B5D File Offset: 0x00005D5D
		[NullableContext(1)]
		private static Delegate GetMessageHandler()
		{
			if (IRequiresOptInInvoker.cb_message == null)
			{
				IRequiresOptInInvoker.cb_message = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiresOptInInvoker.n_Message));
			}
			return IRequiresOptInInvoker.cb_message;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00007B81 File Offset: 0x00005D81
		private static IntPtr n_Message(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRequiresOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message());
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00007B98 File Offset: 0x00005D98
		public string Message()
		{
			if (this.id_message == IntPtr.Zero)
			{
				this.id_message = JNIEnv.GetMethodID(this.class_ref, "message", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_message), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00007BE9 File Offset: 0x00005DE9
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRequiresOptInInvoker.cb_annotationType == null)
			{
				IRequiresOptInInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiresOptInInvoker.n_AnnotationType));
			}
			return IRequiresOptInInvoker.cb_annotationType;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00007C0D File Offset: 0x00005E0D
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRequiresOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00007C24 File Offset: 0x00005E24
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00007C75 File Offset: 0x00005E75
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRequiresOptInInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRequiresOptInInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRequiresOptInInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRequiresOptInInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00007C9C File Offset: 0x00005E9C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRequiresOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00007CC0 File Offset: 0x00005EC0
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

		// Token: 0x06000350 RID: 848 RVA: 0x00007D33 File Offset: 0x00005F33
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRequiresOptInInvoker.cb_hashCode == null)
			{
				IRequiresOptInInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRequiresOptInInvoker.n_GetHashCode));
			}
			return IRequiresOptInInvoker.cb_hashCode;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00007D57 File Offset: 0x00005F57
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequiresOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00007D66 File Offset: 0x00005F66
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00007DA6 File Offset: 0x00005FA6
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IRequiresOptInInvoker.cb_toString == null)
			{
				IRequiresOptInInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiresOptInInvoker.n_ToString));
			}
			return IRequiresOptInInvoker.cb_toString;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00007DCA File Offset: 0x00005FCA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRequiresOptIn>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00007DE0 File Offset: 0x00005FE0
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000FA RID: 250
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/RequiresOptIn", typeof(IRequiresOptInInvoker));

		// Token: 0x040000FB RID: 251
		private IntPtr class_ref;

		// Token: 0x040000FC RID: 252
		private static Delegate cb_level;

		// Token: 0x040000FD RID: 253
		private IntPtr id_level;

		// Token: 0x040000FE RID: 254
		private static Delegate cb_message;

		// Token: 0x040000FF RID: 255
		private IntPtr id_message;

		// Token: 0x04000100 RID: 256
		private static Delegate cb_annotationType;

		// Token: 0x04000101 RID: 257
		private IntPtr id_annotationType;

		// Token: 0x04000102 RID: 258
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000103 RID: 259
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000104 RID: 260
		private static Delegate cb_hashCode;

		// Token: 0x04000105 RID: 261
		private IntPtr id_hashCode;

		// Token: 0x04000106 RID: 262
		private static Delegate cb_toString;

		// Token: 0x04000107 RID: 263
		private IntPtr id_toString;
	}
}
