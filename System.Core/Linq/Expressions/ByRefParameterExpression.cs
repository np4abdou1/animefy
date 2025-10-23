using System;

namespace System.Linq.Expressions
{
	// Token: 0x020000C2 RID: 194
	internal sealed class ByRefParameterExpression : TypedParameterExpression
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x00013A1B File Offset: 0x00011C1B
		internal ByRefParameterExpression(Type type, string name) : base(type, name)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00007357 File Offset: 0x00005557
		internal override bool GetIsByRef()
		{
			return true;
		}
	}
}
