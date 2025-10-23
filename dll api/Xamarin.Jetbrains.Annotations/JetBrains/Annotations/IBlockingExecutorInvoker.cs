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
	// Token: 0x02000016 RID: 22
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/BlockingExecutor", DoNotGenerateAcw = true)]
	internal class IBlockingExecutorInvoker : Java.Lang.Object, IBlockingExecutor, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000025C0 File Offset: 0x000007C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IBlockingExecutorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000025E4 File Offset: 0x000007E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBlockingExecutorInvoker._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000025EB File Offset: 0x000007EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000025F3 File Offset: 0x000007F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBlockingExecutorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000025FF File Offset: 0x000007FF
		[NullableContext(2)]
		public static IBlockingExecutor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBlockingExecutor>(handle, transfer);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002608 File Offset: 0x00000808
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBlockingExecutorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.BlockingExecutor'.");
			}
			return handle;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002633 File Offset: 0x00000833
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002664 File Offset: 0x00000864
		public IBlockingExecutorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBlockingExecutorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000269C File Offset: 0x0000089C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBlockingExecutorInvoker.cb_annotationType == null)
			{
				IBlockingExecutorInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBlockingExecutorInvoker.n_AnnotationType));
			}
			return IBlockingExecutorInvoker.cb_annotationType;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000026C0 File Offset: 0x000008C0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026D4 File Offset: 0x000008D4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002725 File Offset: 0x00000925
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBlockingExecutorInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBlockingExecutorInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBlockingExecutorInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBlockingExecutorInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000274C File Offset: 0x0000094C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002770 File Offset: 0x00000970
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

		// Token: 0x0600005A RID: 90 RVA: 0x000027E3 File Offset: 0x000009E3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBlockingExecutorInvoker.cb_hashCode == null)
			{
				IBlockingExecutorInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBlockingExecutorInvoker.n_GetHashCode));
			}
			return IBlockingExecutorInvoker.cb_hashCode;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002807 File Offset: 0x00000A07
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002816 File Offset: 0x00000A16
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002856 File Offset: 0x00000A56
		private static Delegate GetToStringHandler()
		{
			if (IBlockingExecutorInvoker.cb_toString == null)
			{
				IBlockingExecutorInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBlockingExecutorInvoker.n_ToString));
			}
			return IBlockingExecutorInvoker.cb_toString;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000287A File Offset: 0x00000A7A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBlockingExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002890 File Offset: 0x00000A90
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000014 RID: 20
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/BlockingExecutor", typeof(IBlockingExecutorInvoker));

		// Token: 0x04000015 RID: 21
		private IntPtr class_ref;

		// Token: 0x04000016 RID: 22
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000017 RID: 23
		private IntPtr id_annotationType;

		// Token: 0x04000018 RID: 24
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000019 RID: 25
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400001A RID: 26
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400001B RID: 27
		private IntPtr id_hashCode;

		// Token: 0x0400001C RID: 28
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400001D RID: 29
		private IntPtr id_toString;
	}
}
