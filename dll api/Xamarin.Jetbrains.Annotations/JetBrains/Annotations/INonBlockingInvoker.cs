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
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/NonBlocking", DoNotGenerateAcw = true)]
	internal class INonBlockingInvoker : Java.Lang.Object, INonBlocking, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000039C0 File Offset: 0x00001BC0
		private static IntPtr java_class_ref
		{
			get
			{
				return INonBlockingInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000039E4 File Offset: 0x00001BE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INonBlockingInvoker._members;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000039EB File Offset: 0x00001BEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000039F3 File Offset: 0x00001BF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INonBlockingInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000039FF File Offset: 0x00001BFF
		[NullableContext(2)]
		public static INonBlocking GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INonBlocking>(handle, transfer);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003A08 File Offset: 0x00001C08
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INonBlockingInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.NonBlocking'.");
			}
			return handle;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003A33 File Offset: 0x00001C33
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003A64 File Offset: 0x00001C64
		public INonBlockingInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INonBlockingInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003A9C File Offset: 0x00001C9C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INonBlockingInvoker.cb_annotationType == null)
			{
				INonBlockingInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INonBlockingInvoker.n_AnnotationType));
			}
			return INonBlockingInvoker.cb_annotationType;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003AC0 File Offset: 0x00001CC0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INonBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003B25 File Offset: 0x00001D25
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INonBlockingInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INonBlockingInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INonBlockingInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INonBlockingInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003B4C File Offset: 0x00001D4C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INonBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003B70 File Offset: 0x00001D70
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

		// Token: 0x060000DE RID: 222 RVA: 0x00003BE3 File Offset: 0x00001DE3
		private static Delegate GetGetHashCodeHandler()
		{
			if (INonBlockingInvoker.cb_hashCode == null)
			{
				INonBlockingInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INonBlockingInvoker.n_GetHashCode));
			}
			return INonBlockingInvoker.cb_hashCode;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003C07 File Offset: 0x00001E07
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INonBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003C16 File Offset: 0x00001E16
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003C56 File Offset: 0x00001E56
		private static Delegate GetToStringHandler()
		{
			if (INonBlockingInvoker.cb_toString == null)
			{
				INonBlockingInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INonBlockingInvoker.n_ToString));
			}
			return INonBlockingInvoker.cb_toString;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003C7A File Offset: 0x00001E7A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INonBlocking>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003C90 File Offset: 0x00001E90
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400004F RID: 79
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/NonBlocking", typeof(INonBlockingInvoker));

		// Token: 0x04000050 RID: 80
		private IntPtr class_ref;

		// Token: 0x04000051 RID: 81
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000052 RID: 82
		private IntPtr id_annotationType;

		// Token: 0x04000053 RID: 83
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000054 RID: 84
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000055 RID: 85
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000056 RID: 86
		private IntPtr id_hashCode;

		// Token: 0x04000057 RID: 87
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000058 RID: 88
		private IntPtr id_toString;
	}
}
