using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000083 RID: 131
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ThreadPoolDispatcherKt", DoNotGenerateAcw = true)]
	public sealed class ThreadPoolDispatcherKt : Java.Lang.Object
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00013C3C File Offset: 0x00011E3C
		internal static IntPtr class_ref
		{
			get
			{
				return ThreadPoolDispatcherKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00013C60 File Offset: 0x00011E60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThreadPoolDispatcherKt._members;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00013C68 File Offset: 0x00011E68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThreadPoolDispatcherKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00013C8C File Offset: 0x00011E8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThreadPoolDispatcherKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00013C98 File Offset: 0x00011E98
		internal ThreadPoolDispatcherKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00013CA4 File Offset: 0x00011EA4
		[Register("newFixedThreadPoolContext", "(ILjava/lang/String;)Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "")]
		public unsafe static ExecutorCoroutineDispatcher NewFixedThreadPoolContext(int nThreads, string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ExecutorCoroutineDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(nThreads);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ExecutorCoroutineDispatcher>(ThreadPoolDispatcherKt._members.StaticMethods.InvokeObjectMethod("newFixedThreadPoolContext.(ILjava/lang/String;)Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00013D24 File Offset: 0x00011F24
		[Register("newSingleThreadContext", "(Ljava/lang/String;)Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "")]
		public unsafe static ExecutorCoroutineDispatcher NewSingleThreadContext(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ExecutorCoroutineDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ExecutorCoroutineDispatcher>(ThreadPoolDispatcherKt._members.StaticMethods.InvokeObjectMethod("newSingleThreadContext.(Ljava/lang/String;)Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0400020C RID: 524
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ThreadPoolDispatcherKt", typeof(ThreadPoolDispatcherKt));
	}
}
