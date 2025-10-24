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
	// Token: 0x0200006E RID: 110
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/InterruptibleKt", DoNotGenerateAcw = true)]
	public sealed class InterruptibleKt : Java.Lang.Object
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0000F294 File Offset: 0x0000D494
		internal static IntPtr class_ref
		{
			get
			{
				return InterruptibleKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InterruptibleKt._members;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InterruptibleKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InterruptibleKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		internal InterruptibleKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		[Register("runInterruptible", "(Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RunInterruptible(ICoroutineContext context, IFunction0 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(InterruptibleKt._members.StaticMethods.InvokeObjectMethod("runInterruptible.(Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x040001A7 RID: 423
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/InterruptibleKt", typeof(InterruptibleKt));
	}
}
