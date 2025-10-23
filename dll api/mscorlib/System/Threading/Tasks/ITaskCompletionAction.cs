using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000224 RID: 548
	internal interface ITaskCompletionAction
	{
		// Token: 0x06001378 RID: 4984
		void Invoke(Task completingTask);

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06001379 RID: 4985
		bool InvokeMayRunArbitraryCode { get; }
	}
}
