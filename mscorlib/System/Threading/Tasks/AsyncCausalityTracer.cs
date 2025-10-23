using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200023D RID: 573
	[FriendAccessAllowed]
	internal static class AsyncCausalityTracer
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		[FriendAccessAllowed]
		internal static bool LoggingOn
		{
			[FriendAccessAllowed]
			get
			{
				return false;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002A7D File Offset: 0x00000C7D
		[FriendAccessAllowed]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002A7D File Offset: 0x00000C7D
		[FriendAccessAllowed]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002A7D File Offset: 0x00000C7D
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002A7D File Offset: 0x00000C7D
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
		}
	}
}
