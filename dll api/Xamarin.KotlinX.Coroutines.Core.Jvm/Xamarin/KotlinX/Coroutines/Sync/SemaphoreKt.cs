using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x0200008E RID: 142
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/sync/SemaphoreKt", DoNotGenerateAcw = true)]
	public sealed class SemaphoreKt : Java.Lang.Object
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00014C7C File Offset: 0x00012E7C
		internal static IntPtr class_ref
		{
			get
			{
				return SemaphoreKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SemaphoreKt._members;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00014CA8 File Offset: 0x00012EA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SemaphoreKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00014CCC File Offset: 0x00012ECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SemaphoreKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00014CD8 File Offset: 0x00012ED8
		internal SemaphoreKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00014CE4 File Offset: 0x00012EE4
		[Register("Semaphore", "(II)Lkotlinx/coroutines/sync/Semaphore;", "")]
		public unsafe static ISemaphore Semaphore(int permits, int acquiredPermits)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(permits);
			ptr[1] = new JniArgumentValue(acquiredPermits);
			return Java.Lang.Object.GetObject<ISemaphore>(SemaphoreKt._members.StaticMethods.InvokeObjectMethod("Semaphore.(II)Lkotlinx/coroutines/sync/Semaphore;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00014D40 File Offset: 0x00012F40
		[Register("withPermit", "(Lkotlinx/coroutines/sync/Semaphore;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WithPermit(ISemaphore p0, IFunction0 action, IContinuation p2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SemaphoreKt._members.StaticMethods.InvokeObjectMethod("withPermit.(Lkotlinx/coroutines/sync/Semaphore;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(action);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x0400022B RID: 555
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/sync/SemaphoreKt", typeof(SemaphoreKt));
	}
}
