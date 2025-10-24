using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000049 RID: 73
	[Register("com/bumptech/glide/util/Executors", DoNotGenerateAcw = true)]
	public sealed class Executors : Java.Lang.Object
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000B05C File Offset: 0x0000925C
		internal static IntPtr class_ref
		{
			get
			{
				return Executors._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000B080 File Offset: 0x00009280
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Executors._members;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000B088 File Offset: 0x00009288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Executors._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000B0AC File Offset: 0x000092AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Executors._members.ManagedPeerType;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000B0B8 File Offset: 0x000092B8
		internal Executors(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000B0C4 File Offset: 0x000092C4
		[Register("directExecutor", "()Ljava/util/concurrent/Executor;", "")]
		public static IExecutor DirectExecutor()
		{
			return Java.Lang.Object.GetObject<IExecutor>(Executors._members.StaticMethods.InvokeObjectMethod("directExecutor.()Ljava/util/concurrent/Executor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000B0F8 File Offset: 0x000092F8
		[Register("mainThreadExecutor", "()Ljava/util/concurrent/Executor;", "")]
		public static IExecutor MainThreadExecutor()
		{
			return Java.Lang.Object.GetObject<IExecutor>(Executors._members.StaticMethods.InvokeObjectMethod("mainThreadExecutor.()Ljava/util/concurrent/Executor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000B12C File Offset: 0x0000932C
		[Register("shutdownAndAwaitTermination", "(Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe static void ShutdownAndAwaitTermination(IExecutorService pool)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				Executors._members.StaticMethods.InvokeVoidMethod("shutdownAndAwaitTermination.(Ljava/util/concurrent/ExecutorService;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(pool);
			}
		}

		// Token: 0x040000AC RID: 172
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/Executors", typeof(Executors));
	}
}
