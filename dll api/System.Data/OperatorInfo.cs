using System;

namespace System.Data
{
	// Token: 0x02000060 RID: 96
	internal sealed class OperatorInfo
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x000225EA File Offset: 0x000207EA
		internal OperatorInfo(Nodes type, int op, int pri)
		{
			this._type = type;
			this._op = op;
			this._priority = pri;
		}

		// Token: 0x04000214 RID: 532
		internal Nodes _type;

		// Token: 0x04000215 RID: 533
		internal int _op;

		// Token: 0x04000216 RID: 534
		internal int _priority;
	}
}
