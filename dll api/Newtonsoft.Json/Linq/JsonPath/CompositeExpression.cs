using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A0 RID: 416
	[NullableContext(1)]
	[Nullable(0)]
	internal class CompositeExpression : QueryExpression
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0003FB37 File Offset: 0x0003DD37
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0003FB3F File Offset: 0x0003DD3F
		public List<QueryExpression> Expressions { get; set; }

		// Token: 0x06000E5E RID: 3678 RVA: 0x0003FB48 File Offset: 0x0003DD48
		public CompositeExpression(QueryOperator @operator) : base(@operator)
		{
			this.Expressions = new List<QueryExpression>();
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0003FB5C File Offset: 0x0003DD5C
		public override bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			QueryOperator @operator = this.Operator;
			if (@operator == QueryOperator.And)
			{
				using (List<QueryExpression>.Enumerator enumerator = this.Expressions.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsMatch(root, t, settings))
						{
							return false;
						}
					}
				}
				return true;
			}
			if (@operator != QueryOperator.Or)
			{
				throw new ArgumentOutOfRangeException();
			}
			using (List<QueryExpression>.Enumerator enumerator = this.Expressions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsMatch(root, t, settings))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
