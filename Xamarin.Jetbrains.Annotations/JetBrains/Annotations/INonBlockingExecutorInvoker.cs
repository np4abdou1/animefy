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
	// Token: 0x02000023 RID: 35
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/NonBlockingExecutor", DoNotGenerateAcw = true)]
	internal class INonBlockingExecutorInvoker : Java.Lang.Object, INonBlockingExecutor, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00003CFC File Offset: 0x00001EFC
		private static IntPtr java_class_ref
		{
			get
			{
				return INonBlockingExecutorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00003D20 File Offset: 0x00001F20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INonBlockingExecutorInvoker._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003D27 File Offset: 0x00001F27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003D2F File Offset: 0x00001F2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INonBlockingExecutorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003D3B File Offset: 0x00001F3B
		[NullableContext(2)]
		public static INonBlockingExecutor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INonBlockingExecutor>(handle, transfer);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003D44 File Offset: 0x00001F44
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INonBlockingExecutorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.NonBlockingExecutor'.");
			}
			return handle;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003D6F File Offset: 0x00001F6F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public INonBlockingExecutorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INonBlockingExecutorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003DD8 File Offset: 0x00001FD8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (INonBlockingExecutorInvoker.cb_annotationType == null)
			{
				INonBlockingExecutorInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INonBlockingExecutorInvoker.n_AnnotationType));
			}
			return INonBlockingExecutorInvoker.cb_annotationType;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003DFC File Offset: 0x00001FFC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INonBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003E10 File Offset: 0x00002010
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003E61 File Offset: 0x00002061
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (INonBlockingExecutorInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				INonBlockingExecutorInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(INonBlockingExecutorInvoker.n_Equals_Ljava_lang_Object_));
			}
			return INonBlockingExecutorInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003E88 File Offset: 0x00002088
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<INonBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003EAC File Offset: 0x000020AC
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

		// Token: 0x060000F3 RID: 243 RVA: 0x00003F1F File Offset: 0x0000211F
		private static Delegate GetGetHashCodeHandler()
		{
			if (INonBlockingExecutorInvoker.cb_hashCode == null)
			{
				INonBlockingExecutorInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INonBlockingExecutorInvoker.n_GetHashCode));
			}
			return INonBlockingExecutorInvoker.cb_hashCode;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003F43 File Offset: 0x00002143
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INonBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003F52 File Offset: 0x00002152
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003F92 File Offset: 0x00002192
		private static Delegate GetToStringHandler()
		{
			if (INonBlockingExecutorInvoker.cb_toString == null)
			{
				INonBlockingExecutorInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INonBlockingExecutorInvoker.n_ToString));
			}
			return INonBlockingExecutorInvoker.cb_toString;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003FB6 File Offset: 0x000021B6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<INonBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003FCC File Offset: 0x000021CC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000059 RID: 89
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/NonBlockingExecutor", typeof(INonBlockingExecutorInvoker));

		// Token: 0x0400005A RID: 90
		private IntPtr class_ref;

		// Token: 0x0400005B RID: 91
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400005C RID: 92
		private IntPtr id_annotationType;

		// Token: 0x0400005D RID: 93
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400005E RID: 94
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400005F RID: 95
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000060 RID: 96
		private IntPtr id_hashCode;

		// Token: 0x04000061 RID: 97
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000062 RID: 98
		private IntPtr id_toString;
	}
}
