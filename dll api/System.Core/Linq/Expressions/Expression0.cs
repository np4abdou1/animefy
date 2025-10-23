using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x0200009D RID: 157
	internal sealed class Expression0<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x000129E9 File Offset: 0x00010BE9
		public Expression0(Expression body) : base(body)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00008049 File Offset: 0x00006249
		internal override int ParameterCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000129F2 File Offset: 0x00010BF2
		internal override ParameterExpression GetParameter(int index)
		{
			throw Error.ArgumentOutOfRange("index");
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000F679 File Offset: 0x0000D879
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			return EmptyReadOnlyCollection<ParameterExpression>.Instance;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000129FE File Offset: 0x00010BFE
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return Expression.Lambda<TDelegate>(body, parameters);
		}
	}
}
