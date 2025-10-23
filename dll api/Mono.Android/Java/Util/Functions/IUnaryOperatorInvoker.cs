using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000340 RID: 832
	[Register("java/util/function/UnaryOperator", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IUnaryOperatorInvoker : Java.Lang.Object, IUnaryOperator, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x00063578 File Offset: 0x00061778
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnaryOperatorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x0006359C File Offset: 0x0006179C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnaryOperatorInvoker._members;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000635A3 File Offset: 0x000617A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000635AB File Offset: 0x000617AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnaryOperatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x000635B7 File Offset: 0x000617B7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnaryOperatorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.UnaryOperator'.");
			}
			return handle;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x000635E2 File Offset: 0x000617E2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00063614 File Offset: 0x00061814
		public IUnaryOperatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnaryOperatorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0006364C File Offset: 0x0006184C
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

		// Token: 0x04000E89 RID: 3721
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/UnaryOperator", typeof(IUnaryOperatorInvoker));

		// Token: 0x04000E8A RID: 3722
		private IntPtr class_ref;

		// Token: 0x04000E8B RID: 3723
		private IntPtr id_apply_Ljava_lang_Object_;
	}
}
