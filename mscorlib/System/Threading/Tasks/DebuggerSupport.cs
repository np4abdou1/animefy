using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x0200020F RID: 527
	internal static class DebuggerSupport
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public static bool LoggingOn
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
		{
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status)
		{
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0004ACA7 File Offset: 0x00048EA7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddToActiveTasks(Task task)
		{
			if (Task.s_asyncDebuggingEnabled)
			{
				DebuggerSupport.AddToActiveTasksNonInlined(task);
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0004ACB8 File Offset: 0x00048EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void AddToActiveTasksNonInlined(Task task)
		{
			int id = task.Id;
			object obj = DebuggerSupport.s_activeTasksLock;
			lock (obj)
			{
				DebuggerSupport.s_activeTasks[id] = task;
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0004AD04 File Offset: 0x00048F04
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RemoveFromActiveTasks(Task task)
		{
			if (Task.s_asyncDebuggingEnabled)
			{
				DebuggerSupport.RemoveFromActiveTasksNonInlined(task);
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0004AD14 File Offset: 0x00048F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RemoveFromActiveTasksNonInlined(Task task)
		{
			int id = task.Id;
			object obj = DebuggerSupport.s_activeTasksLock;
			lock (obj)
			{
				DebuggerSupport.s_activeTasks.Remove(id);
			}
		}

		// Token: 0x0400075C RID: 1884
		private static readonly LowLevelDictionary<int, Task> s_activeTasks = new LowLevelDictionary<int, Task>();

		// Token: 0x0400075D RID: 1885
		private static readonly object s_activeTasksLock = new object();
	}
}
