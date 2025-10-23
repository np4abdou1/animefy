using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200033A RID: 826
	[Register("java/util/function/ToDoubleFunction", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IToDoubleFunctionInvoker : Java.Lang.Object, IToDoubleFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x00063030 File Offset: 0x00061230
		private static IntPtr java_class_ref
		{
			get
			{
				return IToDoubleFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x00063054 File Offset: 0x00061254
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IToDoubleFunctionInvoker._members;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0006305B File Offset: 0x0006125B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x00063063 File Offset: 0x00061263
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IToDoubleFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0006306F File Offset: 0x0006126F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IToDoubleFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.ToDoubleFunction'.");
			}
			return handle;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0006309A File Offset: 0x0006129A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x000630CC File Offset: 0x000612CC
		public IToDoubleFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IToDoubleFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00063104 File Offset: 0x00061304
		private static Delegate GetApplyAsDouble_Ljava_lang_Object_Handler()
		{
			if (IToDoubleFunctionInvoker.cb_applyAsDouble_Ljava_lang_Object_ == null)
			{
				IToDoubleFunctionInvoker.cb_applyAsDouble_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_D(IToDoubleFunctionInvoker.n_ApplyAsDouble_Ljava_lang_Object_));
			}
			return IToDoubleFunctionInvoker.cb_applyAsDouble_Ljava_lang_Object_;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00063128 File Offset: 0x00061328
		private static double n_ApplyAsDouble_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IToDoubleFunction @object = Java.Lang.Object.GetObject<IToDoubleFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ApplyAsDouble(object2);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0006314C File Offset: 0x0006134C
		public unsafe double ApplyAsDouble(Java.Lang.Object value)
		{
			if (this.id_applyAsDouble_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_applyAsDouble_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "applyAsDouble", "(Ljava/lang/Object;)D");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			double result = JNIEnv.CallDoubleMethod(base.Handle, this.id_applyAsDouble_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000E7C RID: 3708
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/ToDoubleFunction", typeof(IToDoubleFunctionInvoker));

		// Token: 0x04000E7D RID: 3709
		private IntPtr class_ref;

		// Token: 0x04000E7E RID: 3710
		private static Delegate cb_applyAsDouble_Ljava_lang_Object_;

		// Token: 0x04000E7F RID: 3711
		private IntPtr id_applyAsDouble_Ljava_lang_Object_;
	}
}
