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
	// Token: 0x020000BF RID: 191
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ActorKt", DoNotGenerateAcw = true)]
	public sealed class ActorKt : Java.Lang.Object
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0001F7DC File Offset: 0x0001D9DC
		internal static IntPtr class_ref
		{
			get
			{
				return ActorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0001F800 File Offset: 0x0001DA00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActorKt._members;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0001F808 File Offset: 0x0001DA08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0001F82C File Offset: 0x0001DA2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActorKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0001F838 File Offset: 0x0001DA38
		internal ActorKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0001F844 File Offset: 0x0001DA44
		[Register("actor", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/SendChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ISendChannel Actor(ICoroutineScope obj, ICoroutineContext context, int capacity, CoroutineStart start, [Nullable(2)] IFunction1 onCompletion, IFunction2 block)
		{
			ISendChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue(capacity);
				ptr[3] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				ptr[4] = new JniArgumentValue((onCompletion == null) ? IntPtr.Zero : ((Java.Lang.Object)onCompletion).Handle);
				ptr[5] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<ISendChannel>(ActorKt._members.StaticMethods.InvokeObjectMethod("actor.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/SendChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x040002BD RID: 701
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ActorKt", typeof(ActorKt));
	}
}
