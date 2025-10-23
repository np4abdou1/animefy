using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000222 RID: 546
	internal class StackGuard
	{
		// Token: 0x06001375 RID: 4981 RVA: 0x0004D82A File Offset: 0x0004BA2A
		internal bool TryBeginInliningScope()
		{
			if (this.m_inliningDepth < 20 || RuntimeHelpers.TryEnsureSufficientExecutionStack())
			{
				this.m_inliningDepth++;
				return true;
			}
			return false;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0004D84E File Offset: 0x0004BA4E
		internal void EndInliningScope()
		{
			this.m_inliningDepth--;
			if (this.m_inliningDepth < 0)
			{
				this.m_inliningDepth = 0;
			}
		}

		// Token: 0x040007BF RID: 1983
		private int m_inliningDepth;
	}
}
