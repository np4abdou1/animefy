﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000193 RID: 403
	[NullableContext(1)]
	[Nullable(0)]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x06000E05 RID: 3589 RVA: 0x0003DADF File Offset: 0x0003BCDF
		public ArrayMultipleIndexFilter(List<int> indexes)
		{
			this.Indexes = indexes;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0003DAEE File Offset: 0x0003BCEE
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			foreach (JToken t in current)
			{
				foreach (int index in this.Indexes)
				{
					JToken tokenIndex = PathFilter.GetTokenIndex(t, settings, index);
					if (tokenIndex != null)
					{
						yield return tokenIndex;
					}
				}
				List<int>.Enumerator enumerator2 = default(List<int>.Enumerator);
				t = null;
			}
			IEnumerator<JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x04000772 RID: 1906
		internal List<int> Indexes;
	}
}
