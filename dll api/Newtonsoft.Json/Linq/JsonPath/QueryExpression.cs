using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200019F RID: 415
	[NullableContext(1)]
	[Nullable(0)]
	internal abstract class QueryExpression
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x0003FB1D File Offset: 0x0003DD1D
		public QueryExpression(QueryOperator @operator)
		{
			this.Operator = @operator;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0003FB2C File Offset: 0x0003DD2C
		public bool IsMatch(JToken root, JToken t)
		{
			return this.IsMatch(root, t, null);
		}

		// Token: 0x06000E5B RID: 3675
		public abstract bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings);

		// Token: 0x040007BB RID: 1979
		internal QueryOperator Operator;
	}
}
