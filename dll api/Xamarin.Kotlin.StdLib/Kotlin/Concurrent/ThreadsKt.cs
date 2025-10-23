using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Concurrent
{
	// Token: 0x02000281 RID: 641
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/concurrent/ThreadsKt", DoNotGenerateAcw = true)]
	public sealed class ThreadsKt : Java.Lang.Object
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0005F6E4 File Offset: 0x0005D8E4
		internal static IntPtr class_ref
		{
			get
			{
				return ThreadsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x0005F708 File Offset: 0x0005D908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThreadsKt._members;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0005F710 File Offset: 0x0005D910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThreadsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x0005F734 File Offset: 0x0005D934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThreadsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0005F740 File Offset: 0x0005D940
		internal ThreadsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0005F74C File Offset: 0x0005D94C
		[Register("thread", "(ZZLjava/lang/ClassLoader;Ljava/lang/String;ILkotlin/jvm/functions/Function0;)Ljava/lang/Thread;", "")]
		public unsafe static Thread Thread(bool start, bool isDaemon, [Nullable(2)] ClassLoader contextClassLoader, [Nullable(2)] string name, int priority, IFunction0 block)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Thread @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(isDaemon);
				ptr[2] = new JniArgumentValue((contextClassLoader == null) ? IntPtr.Zero : contextClassLoader.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue(priority);
				ptr[5] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<Thread>(ThreadsKt._members.StaticMethods.InvokeObjectMethod("thread.(ZZLjava/lang/ClassLoader;Ljava/lang/String;ILkotlin/jvm/functions/Function0;)Ljava/lang/Thread;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(contextClassLoader);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x040008DD RID: 2269
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/concurrent/ThreadsKt", typeof(ThreadsKt));
	}
}
