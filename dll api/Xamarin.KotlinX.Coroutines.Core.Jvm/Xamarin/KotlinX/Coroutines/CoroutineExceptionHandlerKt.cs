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
	// Token: 0x02000026 RID: 38
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineExceptionHandlerKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineExceptionHandlerKt : Java.Lang.Object
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003A78 File Offset: 0x00001C78
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineExceptionHandlerKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003A9C File Offset: 0x00001C9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineExceptionHandlerKt._members;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003AA4 File Offset: 0x00001CA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineExceptionHandlerKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineExceptionHandlerKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003AD4 File Offset: 0x00001CD4
		internal CoroutineExceptionHandlerKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Register("CoroutineExceptionHandler", "(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/CoroutineExceptionHandler;", "")]
		public unsafe static ICoroutineExceptionHandler CoroutineExceptionHandler(IFunction2 handler)
		{
			ICoroutineExceptionHandler @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(CoroutineExceptionHandlerKt._members.StaticMethods.InvokeObjectMethod("CoroutineExceptionHandler.(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/CoroutineExceptionHandler;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(handler);
			}
			return @object;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003B58 File Offset: 0x00001D58
		[Register("handleCoroutineException", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Throwable;)V", "")]
		public unsafe static void HandleCoroutineException(ICoroutineContext context, Throwable exception)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((exception == null) ? IntPtr.Zero : exception.Handle);
				CoroutineExceptionHandlerKt._members.StaticMethods.InvokeVoidMethod("handleCoroutineException.(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Throwable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(exception);
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineExceptionHandlerKt", typeof(CoroutineExceptionHandlerKt));
	}
}
