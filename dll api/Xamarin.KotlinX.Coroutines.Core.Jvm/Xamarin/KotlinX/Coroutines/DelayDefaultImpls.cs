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
	// Token: 0x0200005A RID: 90
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Delay$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class DelayDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		internal static IntPtr class_ref
		{
			get
			{
				return DelayDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000CC10 File Offset: 0x0000AE10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DelayDefaultImpls._members;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DelayDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DelayDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000CC48 File Offset: 0x0000AE48
		internal DelayDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000CC54 File Offset: 0x0000AE54
		[Obsolete("deprecated")]
		[Register("delay", "(Lkotlinx/coroutines/Delay;JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Delay(IDelay _this, long time, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(time);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DelayDefaultImpls._members.StaticMethods.InvokeObjectMethod("delay.(Lkotlinx/coroutines/Delay;JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000CD10 File Offset: 0x0000AF10
		[Register("invokeOnTimeout", "(Lkotlinx/coroutines/Delay;JLjava/lang/Runnable;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe static IDisposableHandle InvokeOnTimeout(IDelay _this, long timeMillis, IRunnable block, ICoroutineContext context)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(timeMillis);
				ptr[2] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[3] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(DelayDefaultImpls._members.StaticMethods.InvokeObjectMethod("invokeOnTimeout.(Lkotlinx/coroutines/Delay;JLjava/lang/Runnable;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/DisposableHandle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(block);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000147 RID: 327
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Delay$DefaultImpls", typeof(DelayDefaultImpls));
	}
}
