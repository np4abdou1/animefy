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
	// Token: 0x0200001D RID: 29
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CancellableContinuationKt", DoNotGenerateAcw = true)]
	public sealed class CancellableContinuationKt : Java.Lang.Object
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002A14 File Offset: 0x00000C14
		internal static IntPtr class_ref
		{
			get
			{
				return CancellableContinuationKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002A38 File Offset: 0x00000C38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellableContinuationKt._members;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002A40 File Offset: 0x00000C40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellableContinuationKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002A64 File Offset: 0x00000C64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellableContinuationKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002A70 File Offset: 0x00000C70
		internal CancellableContinuationKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002A7C File Offset: 0x00000C7C
		[Register("disposeOnCancellation", "(Lkotlinx/coroutines/CancellableContinuation;Lkotlinx/coroutines/DisposableHandle;)V", "")]
		public unsafe static void DisposeOnCancellation(ICancellableContinuation obj, IDisposableHandle handle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((handle == null) ? IntPtr.Zero : ((Java.Lang.Object)handle).Handle);
				CancellableContinuationKt._members.StaticMethods.InvokeVoidMethod("disposeOnCancellation.(Lkotlinx/coroutines/CancellableContinuation;Lkotlinx/coroutines/DisposableHandle;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(handle);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002B10 File Offset: 0x00000D10
		[Register("suspendCancellableCoroutine", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SuspendCancellableCoroutine(IFunction1 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CancellableContinuationKt._members.StaticMethods.InvokeObjectMethod("suspendCancellableCoroutine.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CancellableContinuationKt", typeof(CancellableContinuationKt));
	}
}
