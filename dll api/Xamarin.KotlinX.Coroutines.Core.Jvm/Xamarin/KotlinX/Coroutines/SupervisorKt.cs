using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000081 RID: 129
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/SupervisorKt", DoNotGenerateAcw = true)]
	public sealed class SupervisorKt : Java.Lang.Object
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00013840 File Offset: 0x00011A40
		internal static IntPtr class_ref
		{
			get
			{
				return SupervisorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00013864 File Offset: 0x00011A64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SupervisorKt._members;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001386C File Offset: 0x00011A6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SupervisorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00013890 File Offset: 0x00011A90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SupervisorKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001389C File Offset: 0x00011A9C
		internal SupervisorKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Register("SupervisorJob", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/CompletableJob;", "")]
		public unsafe static ICompletableJob SupervisorJob([Nullable(2)] IJob parent)
		{
			ICompletableJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((Java.Lang.Object)parent).Handle);
				@object = Java.Lang.Object.GetObject<ICompletableJob>(SupervisorKt._members.StaticMethods.InvokeObjectMethod("SupervisorJob.(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/CompletableJob;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00013920 File Offset: 0x00011B20
		[Register("supervisorScope", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SupervisorScope(IFunction2 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SupervisorKt._members.StaticMethods.InvokeObjectMethod("supervisorScope.(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0400020A RID: 522
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/SupervisorKt", typeof(SupervisorKt));
	}
}
