using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A6 RID: 422
	[NullableContext(1)]
	[Nullable(0)]
	internal class RootFilter : PathFilter
	{
		// Token: 0x06000E7F RID: 3711 RVA: 0x0003D816 File Offset: 0x0003BA16
		private RootFilter()
		{
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00040597 File Offset: 0x0003E797
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return new JToken[]
			{
				root
			};
		}

		// Token: 0x040007D9 RID: 2009
		public static readonly RootFilter Instance = new RootFilter();
	}
}
