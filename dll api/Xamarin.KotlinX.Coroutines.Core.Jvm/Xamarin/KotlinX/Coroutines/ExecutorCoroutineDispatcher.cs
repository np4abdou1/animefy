using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000035 RID: 53
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ExecutorCoroutineDispatcher", DoNotGenerateAcw = true)]
	public abstract class ExecutorCoroutineDispatcher : CoroutineDispatcher, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00005038 File Offset: 0x00003238
		internal new static IntPtr class_ref
		{
			get
			{
				return ExecutorCoroutineDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000505C File Offset: 0x0000325C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExecutorCoroutineDispatcher._members;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00005064 File Offset: 0x00003264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExecutorCoroutineDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00005088 File Offset: 0x00003288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExecutorCoroutineDispatcher._members.ManagedPeerType;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005094 File Offset: 0x00003294
		protected ExecutorCoroutineDispatcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000050A0 File Offset: 0x000032A0
		[Register(".ctor", "()V", "")]
		public ExecutorCoroutineDispatcher() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ExecutorCoroutineDispatcher._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ExecutorCoroutineDispatcher._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000510E File Offset: 0x0000330E
		private static Delegate GetGetExecutorHandler()
		{
			if (ExecutorCoroutineDispatcher.cb_getExecutor == null)
			{
				ExecutorCoroutineDispatcher.cb_getExecutor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExecutorCoroutineDispatcher.n_GetExecutor));
			}
			return ExecutorCoroutineDispatcher.cb_getExecutor;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005132 File Offset: 0x00003332
		private static IntPtr n_GetExecutor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExecutorCoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Executor);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600014B RID: 331
		public abstract IExecutor Executor { [Register("getExecutor", "()Ljava/util/concurrent/Executor;", "GetGetExecutorHandler")] get; }

		// Token: 0x0600014C RID: 332 RVA: 0x00005146 File Offset: 0x00003346
		private static Delegate GetCloseHandler()
		{
			if (ExecutorCoroutineDispatcher.cb_close == null)
			{
				ExecutorCoroutineDispatcher.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ExecutorCoroutineDispatcher.n_Close));
			}
			return ExecutorCoroutineDispatcher.cb_close;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000516A File Offset: 0x0000336A
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ExecutorCoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x0600014E RID: 334
		[Register("close", "()V", "GetCloseHandler")]
		public abstract void Close();

		// Token: 0x0400002B RID: 43
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ExecutorCoroutineDispatcher", typeof(ExecutorCoroutineDispatcher));

		// Token: 0x0400002C RID: 44
		[Nullable(2)]
		private static Delegate cb_getExecutor;

		// Token: 0x0400002D RID: 45
		[Nullable(2)]
		private static Delegate cb_close;
	}
}
