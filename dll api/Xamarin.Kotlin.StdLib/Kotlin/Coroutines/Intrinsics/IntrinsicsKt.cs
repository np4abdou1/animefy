using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines.Intrinsics
{
	// Token: 0x0200026A RID: 618
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/intrinsics/IntrinsicsKt", DoNotGenerateAcw = true)]
	public sealed class IntrinsicsKt : Java.Lang.Object
	{
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0005DEC8 File Offset: 0x0005C0C8
		internal static IntPtr class_ref
		{
			get
			{
				return IntrinsicsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x0005DEEC File Offset: 0x0005C0EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntrinsicsKt._members;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0005DEF4 File Offset: 0x0005C0F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntrinsicsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0005DF18 File Offset: 0x0005C118
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntrinsicsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0005DF24 File Offset: 0x0005C124
		internal IntrinsicsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0005DF30 File Offset: 0x0005C130
		public static Java.Lang.Object COROUTINE_SUSPENDED
		{
			[Register("getCOROUTINE_SUSPENDED", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("getCOROUTINE_SUSPENDED.()Ljava/lang/Object;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0005DF64 File Offset: 0x0005C164
		[Register("createCoroutineUnintercepted", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IContinuation CreateCoroutineUnintercepted(IFunction1 _this_createCoroutineUnintercepted, IContinuation completion)
		{
			IContinuation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_createCoroutineUnintercepted == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_createCoroutineUnintercepted).Handle);
				ptr[1] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<IContinuation>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("createCoroutineUnintercepted.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_createCoroutineUnintercepted);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0005E008 File Offset: 0x0005C208
		[Register("createCoroutineUnintercepted", "(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"T"
		})]
		public unsafe static IContinuation CreateCoroutineUnintercepted(IFunction2 _this_createCoroutineUnintercepted, [Nullable(2)] Java.Lang.Object receiver, IContinuation completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			IContinuation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_createCoroutineUnintercepted == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_createCoroutineUnintercepted).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<IContinuation>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("createCoroutineUnintercepted.(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_createCoroutineUnintercepted);
				GC.KeepAlive(receiver);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0005E0D8 File Offset: 0x0005C2D8
		[Register("intercepted", "(Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IContinuation Intercepted(IContinuation _this_intercepted)
		{
			IContinuation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_intercepted == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_intercepted).Handle);
				@object = Java.Lang.Object.GetObject<IContinuation>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("intercepted.(Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_intercepted);
			}
			return @object;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0005E150 File Offset: 0x0005C350
		[Register("wrapWithContinuationImpl", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WrapWithContinuationImpl(IFunction1 _this_wrapWithContinuationImpl, IContinuation completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_wrapWithContinuationImpl == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_wrapWithContinuationImpl).Handle);
				ptr[1] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("wrapWithContinuationImpl.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_wrapWithContinuationImpl);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0005E1F4 File Offset: 0x0005C3F4
		[Register("wrapWithContinuationImpl", "(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WrapWithContinuationImpl(IFunction2 _this_wrapWithContinuationImpl, [Nullable(2)] Java.Lang.Object receiver, IContinuation completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_wrapWithContinuationImpl == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_wrapWithContinuationImpl).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("wrapWithContinuationImpl.(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_wrapWithContinuationImpl);
				GC.KeepAlive(receiver);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0005E2C4 File Offset: 0x0005C4C4
		[NullableContext(2)]
		[Register("wrapWithContinuationImpl", "(Lkotlin/jvm/functions/Function3;Ljava/lang/Object;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"P",
			"T"
		})]
		public unsafe static Java.Lang.Object WrapWithContinuationImpl([Nullable(1)] IFunction3 _this_wrapWithContinuationImpl, Java.Lang.Object receiver, Java.Lang.Object param, [Nullable(1)] IContinuation completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(param);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_wrapWithContinuationImpl == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_wrapWithContinuationImpl).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IntrinsicsKt._members.StaticMethods.InvokeObjectMethod("wrapWithContinuationImpl.(Lkotlin/jvm/functions/Function3;Ljava/lang/Object;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_wrapWithContinuationImpl);
				GC.KeepAlive(receiver);
				GC.KeepAlive(param);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x040008B1 RID: 2225
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/intrinsics/IntrinsicsKt", typeof(IntrinsicsKt));
	}
}
