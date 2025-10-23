using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000334 RID: 820
	[Register("java/util/function/Function", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IFunctionInvoker : Java.Lang.Object, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00062840 File Offset: 0x00060A40
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x00062864 File Offset: 0x00060A64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFunctionInvoker._members;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0006286B File Offset: 0x00060A6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00062873 File Offset: 0x00060A73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0006287F File Offset: 0x00060A7F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.Function'.");
			}
			return handle;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000628AA File Offset: 0x00060AAA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000628DC File Offset: 0x00060ADC
		public IFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00062914 File Offset: 0x00060B14
		private static Delegate GetApply_Ljava_lang_Object_Handler()
		{
			if (IFunctionInvoker.cb_apply_Ljava_lang_Object_ == null)
			{
				IFunctionInvoker.cb_apply_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFunctionInvoker.n_Apply_Ljava_lang_Object_));
			}
			return IFunctionInvoker.cb_apply_Ljava_lang_Object_;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00062938 File Offset: 0x00060B38
		private static IntPtr n_Apply_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			IFunction @object = Java.Lang.Object.GetObject<IFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_t, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Apply(object2));
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00062960 File Offset: 0x00060B60
		public unsafe Java.Lang.Object Apply(Java.Lang.Object t)
		{
			if (this.id_apply_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_apply_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "apply", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_apply_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000E6C RID: 3692
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/Function", typeof(IFunctionInvoker));

		// Token: 0x04000E6D RID: 3693
		private IntPtr class_ref;

		// Token: 0x04000E6E RID: 3694
		private static Delegate cb_apply_Ljava_lang_Object_;

		// Token: 0x04000E6F RID: 3695
		private IntPtr id_apply_Ljava_lang_Object_;
	}
}
