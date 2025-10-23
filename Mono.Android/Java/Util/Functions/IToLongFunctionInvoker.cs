using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200033E RID: 830
	[Register("java/util/function/ToLongFunction", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IToLongFunctionInvoker : Java.Lang.Object, IToLongFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00063380 File Offset: 0x00061580
		private static IntPtr java_class_ref
		{
			get
			{
				return IToLongFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000633A4 File Offset: 0x000615A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IToLongFunctionInvoker._members;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000633AB File Offset: 0x000615AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000633B3 File Offset: 0x000615B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IToLongFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x000633BF File Offset: 0x000615BF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IToLongFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.ToLongFunction'.");
			}
			return handle;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000633EA File Offset: 0x000615EA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0006341C File Offset: 0x0006161C
		public IToLongFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IToLongFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00063454 File Offset: 0x00061654
		private static Delegate GetApplyAsLong_Ljava_lang_Object_Handler()
		{
			if (IToLongFunctionInvoker.cb_applyAsLong_Ljava_lang_Object_ == null)
			{
				IToLongFunctionInvoker.cb_applyAsLong_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(IToLongFunctionInvoker.n_ApplyAsLong_Ljava_lang_Object_));
			}
			return IToLongFunctionInvoker.cb_applyAsLong_Ljava_lang_Object_;
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00063478 File Offset: 0x00061678
		private static long n_ApplyAsLong_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IToLongFunction @object = Java.Lang.Object.GetObject<IToLongFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ApplyAsLong(object2);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0006349C File Offset: 0x0006169C
		public unsafe long ApplyAsLong(Java.Lang.Object value)
		{
			if (this.id_applyAsLong_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_applyAsLong_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "applyAsLong", "(Ljava/lang/Object;)J");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			long result = JNIEnv.CallLongMethod(base.Handle, this.id_applyAsLong_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000E84 RID: 3716
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/ToLongFunction", typeof(IToLongFunctionInvoker));

		// Token: 0x04000E85 RID: 3717
		private IntPtr class_ref;

		// Token: 0x04000E86 RID: 3718
		private static Delegate cb_applyAsLong_Ljava_lang_Object_;

		// Token: 0x04000E87 RID: 3719
		private IntPtr id_applyAsLong_Ljava_lang_Object_;
	}
}
