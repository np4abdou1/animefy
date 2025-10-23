using System;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
	// Token: 0x020000A2 RID: 162
	internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate>
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public FullExpression(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) : base(body, parameters)
		{
			this.NameCore = name;
			this.TailCallCore = tailCall;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00012C01 File Offset: 0x00010E01
		internal override string NameCore { get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00012C09 File Offset: 0x00010E09
		internal override bool TailCallCore { get; }
	}
}
