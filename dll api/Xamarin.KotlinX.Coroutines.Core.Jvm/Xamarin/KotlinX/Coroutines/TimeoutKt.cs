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
	// Token: 0x02000085 RID: 133
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/TimeoutKt", DoNotGenerateAcw = true)]
	public sealed class TimeoutKt : Java.Lang.Object
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00013E70 File Offset: 0x00012070
		internal static IntPtr class_ref
		{
			get
			{
				return TimeoutKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00013E94 File Offset: 0x00012094
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeoutKt._members;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00013E9C File Offset: 0x0001209C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeoutKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00013EC0 File Offset: 0x000120C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeoutKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00013ECC File Offset: 0x000120CC
		internal TimeoutKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Register("withTimeout", "(JLkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WithTimeout(long timeMillis, IFunction2 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeMillis);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TimeoutKt._members.StaticMethods.InvokeObjectMethod("withTimeout.(JLkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00013F94 File Offset: 0x00012194
		[Register("withTimeoutOrNull", "(JLkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WithTimeoutOrNull(long timeMillis, IFunction2 block, IContinuation p2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeMillis);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TimeoutKt._members.StaticMethods.InvokeObjectMethod("withTimeoutOrNull.(JLkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x0400020E RID: 526
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/TimeoutKt", typeof(TimeoutKt));
	}
}
