using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines
{
	// Token: 0x0200024E RID: 590
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/ContinuationKt", DoNotGenerateAcw = true)]
	public sealed class ContinuationKt : Java.Lang.Object
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0005B3D0 File Offset: 0x000595D0
		internal static IntPtr class_ref
		{
			get
			{
				return ContinuationKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0005B3F4 File Offset: 0x000595F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContinuationKt._members;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x0005B3FC File Offset: 0x000595FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContinuationKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0005B420 File Offset: 0x00059620
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContinuationKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0005B42C File Offset: 0x0005962C
		internal ContinuationKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0005B438 File Offset: 0x00059638
		[Register("createCoroutine", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IContinuation CreateCoroutine(IFunction1 obj, IContinuation completion)
		{
			IContinuation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<IContinuation>(ContinuationKt._members.StaticMethods.InvokeObjectMethod("createCoroutine.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0005B4DC File Offset: 0x000596DC
		[Register("createCoroutine", "(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"T"
		})]
		public unsafe static IContinuation CreateCoroutine(IFunction2 obj, [Nullable(2)] Java.Lang.Object receiver, IContinuation completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			IContinuation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				@object = Java.Lang.Object.GetObject<IContinuation>(ContinuationKt._members.StaticMethods.InvokeObjectMethod("createCoroutine.(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(receiver);
				GC.KeepAlive(completion);
			}
			return @object;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0005B5AC File Offset: 0x000597AC
		[Register("startCoroutine", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void StartCoroutine(IFunction1 obj, IContinuation completion)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				ContinuationKt._members.StaticMethods.InvokeVoidMethod("startCoroutine.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(completion);
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0005B640 File Offset: 0x00059840
		[Register("startCoroutine", "(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"T"
		})]
		public unsafe static void StartCoroutine(IFunction2 obj, [Nullable(2)] Java.Lang.Object receiver, IContinuation completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				ContinuationKt._members.StaticMethods.InvokeVoidMethod("startCoroutine.(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(receiver);
				GC.KeepAlive(completion);
			}
		}

		// Token: 0x04000867 RID: 2151
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/ContinuationKt", typeof(ContinuationKt));
	}
}
