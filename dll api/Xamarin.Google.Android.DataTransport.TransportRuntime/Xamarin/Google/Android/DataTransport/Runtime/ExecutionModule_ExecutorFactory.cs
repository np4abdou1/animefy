using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000020 RID: 32
	[Register("com/google/android/datatransport/runtime/ExecutionModule_ExecutorFactory", DoNotGenerateAcw = true)]
	public sealed class ExecutionModule_ExecutorFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003728 File Offset: 0x00001928
		internal static IntPtr class_ref
		{
			get
			{
				return ExecutionModule_ExecutorFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000374C File Offset: 0x0000194C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExecutionModule_ExecutorFactory._members;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003754 File Offset: 0x00001954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExecutionModule_ExecutorFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003778 File Offset: 0x00001978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExecutionModule_ExecutorFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000026C4 File Offset: 0x000008C4
		internal ExecutionModule_ExecutorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003784 File Offset: 0x00001984
		[Register(".ctor", "()V", "")]
		public ExecutionModule_ExecutorFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ExecutionModule_ExecutorFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ExecutionModule_ExecutorFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000037F4 File Offset: 0x000019F4
		[Register("create", "()Lcom/google/android/datatransport/runtime/ExecutionModule_ExecutorFactory;", "")]
		public static ExecutionModule_ExecutorFactory Create()
		{
			return Java.Lang.Object.GetObject<ExecutionModule_ExecutorFactory>(ExecutionModule_ExecutorFactory._members.StaticMethods.InvokeObjectMethod("create.()Lcom/google/android/datatransport/runtime/ExecutionModule_ExecutorFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003828 File Offset: 0x00001A28
		[Register("executor", "()Ljava/util/concurrent/Executor;", "")]
		public static IExecutor Executor()
		{
			return Java.Lang.Object.GetObject<IExecutor>(ExecutionModule_ExecutorFactory._members.StaticMethods.InvokeObjectMethod("executor.()Ljava/util/concurrent/Executor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000385C File Offset: 0x00001A5C
		[Register("get", "()Ljava/util/concurrent/Executor;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ExecutionModule_ExecutorFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/util/concurrent/Executor;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000027 RID: 39
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/ExecutionModule_ExecutorFactory", typeof(ExecutionModule_ExecutorFactory));
	}
}
