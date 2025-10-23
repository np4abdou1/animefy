using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C1 RID: 193
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/BroadcastKt", DoNotGenerateAcw = true)]
	public sealed class BroadcastKt : Java.Lang.Object
	{
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0001FA84 File Offset: 0x0001DC84
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastKt._members;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0001FAB0 File Offset: 0x0001DCB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0001FAE0 File Offset: 0x0001DCE0
		internal BroadcastKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		[Obsolete("deprecated")]
		[Register("broadcast", "(Lkotlinx/coroutines/channels/ReceiveChannel;ILkotlinx/coroutines/CoroutineStart;)Lkotlinx/coroutines/channels/BroadcastChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IBroadcastChannel Broadcast(IReceiveChannel obj, int capacity, CoroutineStart start)
		{
			IBroadcastChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(capacity);
				ptr[2] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				@object = Java.Lang.Object.GetObject<IBroadcastChannel>(BroadcastKt._members.StaticMethods.InvokeObjectMethod("broadcast.(Lkotlinx/coroutines/channels/ReceiveChannel;ILkotlinx/coroutines/CoroutineStart;)Lkotlinx/coroutines/channels/BroadcastChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(start);
			}
			return @object;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
		[Obsolete("deprecated")]
		[Register("broadcast", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/BroadcastChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IBroadcastChannel Broadcast(ICoroutineScope obj, ICoroutineContext context, int capacity, CoroutineStart start, [Nullable(2)] IFunction1 onCompletion, IFunction2 block)
		{
			IBroadcastChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue(capacity);
				ptr[3] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				ptr[4] = new JniArgumentValue((onCompletion == null) ? IntPtr.Zero : ((Java.Lang.Object)onCompletion).Handle);
				ptr[5] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IBroadcastChannel>(BroadcastKt._members.StaticMethods.InvokeObjectMethod("broadcast.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/BroadcastChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
				GC.KeepAlive(start);
				GC.KeepAlive(onCompletion);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x040002BF RID: 703
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/BroadcastKt", typeof(BroadcastKt));
	}
}
