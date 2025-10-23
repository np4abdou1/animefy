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
	// Token: 0x0200002D RID: 45
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DelayKt", DoNotGenerateAcw = true)]
	public sealed class DelayKt : Java.Lang.Object
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000048DC File Offset: 0x00002ADC
		internal static IntPtr class_ref
		{
			get
			{
				return DelayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004900 File Offset: 0x00002B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DelayKt._members;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004908 File Offset: 0x00002B08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DelayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000492C File Offset: 0x00002B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DelayKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004938 File Offset: 0x00002B38
		internal DelayKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004944 File Offset: 0x00002B44
		[Register("awaitCancellation", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object AwaitCancellation(IContinuation p0)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DelayKt._members.StaticMethods.InvokeObjectMethod("awaitCancellation.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000049BC File Offset: 0x00002BBC
		[Register("delay", "(JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Delay(long timeMillis, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeMillis);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DelayKt._members.StaticMethods.InvokeObjectMethod("delay.(JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004A48 File Offset: 0x00002C48
		[Register("getDelay", "(Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/Delay;", "")]
		public unsafe static IDelay GetDelay(ICoroutineContext obj)
		{
			IDelay @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<IDelay>(DelayKt._members.StaticMethods.InvokeObjectMethod("getDelay.(Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/Delay;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x04000023 RID: 35
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DelayKt", typeof(DelayKt));
	}
}
