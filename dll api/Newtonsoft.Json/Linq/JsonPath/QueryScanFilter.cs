﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A4 RID: 420
	[NullableContext(1)]
	[Nullable(0)]
	internal class QueryScanFilter : PathFilter
	{
		// Token: 0x06000E73 RID: 3699 RVA: 0x000402CF File Offset: 0x0003E4CF
		public QueryScanFilter(QueryExpression expression)
		{
			this.Expression = expression;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000402DE File Offset: 0x0003E4DE
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			foreach (JToken jtoken in current)
			{
				JContainer jcontainer = jtoken as JContainer;
				if (jcontainer != null)
				{
					foreach (JToken jtoken2 in jcontainer.DescendantsAndSelf())
					{
						if (this.Expression.IsMatch(root, jtoken2, settings))
						{
							yield return jtoken2;
						}
					}
					IEnumerator<JToken> enumerator2 = null;
				}
				else if (this.Expression.IsMatch(root, jtoken, settings))
				{
					yield return jtoken;
				}
			}
			IEnumerator<JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040007CC RID: 1996
		internal QueryExpression Expression;
	}
}
