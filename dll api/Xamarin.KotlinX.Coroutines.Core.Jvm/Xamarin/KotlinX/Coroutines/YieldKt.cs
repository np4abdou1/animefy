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
	// Token: 0x02000086 RID: 134
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/YieldKt", DoNotGenerateAcw = true)]
	public sealed class YieldKt : Java.Lang.Object
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001406C File Offset: 0x0001226C
		internal static IntPtr class_ref
		{
			get
			{
				return YieldKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00014090 File Offset: 0x00012290
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return YieldKt._members;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00014098 File Offset: 0x00012298
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return YieldKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000140BC File Offset: 0x000122BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return YieldKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000140C8 File Offset: 0x000122C8
		internal YieldKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000140D4 File Offset: 0x000122D4
		[Register("yield", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Yield(IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(YieldKt._members.StaticMethods.InvokeObjectMethod("yield.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0400020F RID: 527
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/YieldKt", typeof(YieldKt));
	}
}
