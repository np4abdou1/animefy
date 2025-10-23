using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000188 RID: 392
	public class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x0003B836 File Offset: 0x00039A36
		[NullableContext(2)]
		public bool Equals(JToken x, JToken y)
		{
			return JToken.DeepEquals(x, y);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0003B83F File Offset: 0x00039A3F
		[NullableContext(1)]
		public int GetHashCode(JToken obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetDeepHashCode();
		}
	}
}
