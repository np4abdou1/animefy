using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200007B RID: 123
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/MainCoroutineDispatcher", DoNotGenerateAcw = true)]
	internal class MainCoroutineDispatcherInvoker : MainCoroutineDispatcher
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x00012F05 File Offset: 0x00011105
		public MainCoroutineDispatcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00012F0F File Offset: 0x0001110F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MainCoroutineDispatcherInvoker._members;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00012F16 File Offset: 0x00011116
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MainCoroutineDispatcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00012F24 File Offset: 0x00011124
		public override MainCoroutineDispatcher Immediate
		{
			[Register("getImmediate", "()Lkotlinx/coroutines/MainCoroutineDispatcher;", "GetGetImmediateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MainCoroutineDispatcher>(MainCoroutineDispatcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getImmediate.()Lkotlinx/coroutines/MainCoroutineDispatcher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00012F58 File Offset: 0x00011158
		[Register("dispatch", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", "GetDispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler")]
		public unsafe override void Dispatch(ICoroutineContext context, IRunnable block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				MainCoroutineDispatcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("dispatch.(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x04000205 RID: 517
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/MainCoroutineDispatcher", typeof(MainCoroutineDispatcherInvoker));
	}
}
