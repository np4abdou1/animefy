using System;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001DC RID: 476
	internal class ThreadHelper
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x0004796F File Offset: 0x00045B6F
		internal ThreadHelper(Delegate start)
		{
			this._start = start;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0004797E File Offset: 0x00045B7E
		internal void SetExecutionContextHelper(ExecutionContext ec)
		{
			this._executionContext = ec;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00047988 File Offset: 0x00045B88
		[SecurityCritical]
		private static void ThreadStart_Context(object state)
		{
			ThreadHelper threadHelper = (ThreadHelper)state;
			if (threadHelper._start is ThreadStart)
			{
				((ThreadStart)threadHelper._start)();
				return;
			}
			((ParameterizedThreadStart)threadHelper._start)(threadHelper._startArg);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000479D0 File Offset: 0x00045BD0
		[SecurityCritical]
		internal void ThreadStart(object obj)
		{
			this._startArg = obj;
			if (this._executionContext != null)
			{
				ExecutionContext.Run(this._executionContext, ThreadHelper._ccb, this);
				return;
			}
			((ParameterizedThreadStart)this._start)(obj);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00047A04 File Offset: 0x00045C04
		[SecurityCritical]
		internal void ThreadStart()
		{
			if (this._executionContext != null)
			{
				ExecutionContext.Run(this._executionContext, ThreadHelper._ccb, this);
				return;
			}
			((ThreadStart)this._start)();
		}

		// Token: 0x040006B5 RID: 1717
		private Delegate _start;

		// Token: 0x040006B6 RID: 1718
		private object _startArg;

		// Token: 0x040006B7 RID: 1719
		private ExecutionContext _executionContext;

		// Token: 0x040006B8 RID: 1720
		[SecurityCritical]
		internal static ContextCallback _ccb = new ContextCallback(ThreadHelper.ThreadStart_Context);
	}
}
