using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000350 RID: 848
	[Register("java/util/concurrent/Executor", DoNotGenerateAcw = true)]
	internal class IExecutorInvoker : Java.Lang.Object, IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x0006AF94 File Offset: 0x00069194
		private static IntPtr java_class_ref
		{
			get
			{
				return IExecutorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x0006AFB8 File Offset: 0x000691B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExecutorInvoker._members;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x0006AFBF File Offset: 0x000691BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x0006AFC7 File Offset: 0x000691C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExecutorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x0006AFD3 File Offset: 0x000691D3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExecutorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.Executor'.");
			}
			return handle;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x0006AFFE File Offset: 0x000691FE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x0006B030 File Offset: 0x00069230
		public IExecutorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExecutorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x0006B068 File Offset: 0x00069268
		private static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (IExecutorInvoker.cb_execute_Ljava_lang_Runnable_ == null)
			{
				IExecutorInvoker.cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IExecutorInvoker.n_Execute_Ljava_lang_Runnable_));
			}
			return IExecutorInvoker.cb_execute_Ljava_lang_Runnable_;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x0006B08C File Offset: 0x0006928C
		private static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			IExecutor @object = Java.Lang.Object.GetObject<IExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			@object.Execute(object2);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x0006B0B0 File Offset: 0x000692B0
		public unsafe void Execute(IRunnable command)
		{
			if (this.id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "execute", "(Ljava/lang/Runnable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_execute_Ljava_lang_Runnable_, ptr);
		}

		// Token: 0x04000F67 RID: 3943
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/Executor", typeof(IExecutorInvoker));

		// Token: 0x04000F68 RID: 3944
		private IntPtr class_ref;

		// Token: 0x04000F69 RID: 3945
		private static Delegate cb_execute_Ljava_lang_Runnable_;

		// Token: 0x04000F6A RID: 3946
		private IntPtr id_execute_Ljava_lang_Runnable_;
	}
}
