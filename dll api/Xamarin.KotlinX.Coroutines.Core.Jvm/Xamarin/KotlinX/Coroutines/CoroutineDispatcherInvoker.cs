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
	// Token: 0x02000025 RID: 37
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineDispatcher", DoNotGenerateAcw = true)]
	internal class CoroutineDispatcherInvoker : CoroutineDispatcher
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x000039A7 File Offset: 0x00001BA7
		public CoroutineDispatcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000039B1 File Offset: 0x00001BB1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineDispatcherInvoker._members;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000039B8 File Offset: 0x00001BB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineDispatcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000039C4 File Offset: 0x00001BC4
		[Register("dispatch", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", "GetDispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler")]
		public unsafe override void Dispatch(ICoroutineContext context, IRunnable block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				CoroutineDispatcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("dispatch.(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x04000017 RID: 23
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineDispatcher", typeof(CoroutineDispatcherInvoker));
	}
}
