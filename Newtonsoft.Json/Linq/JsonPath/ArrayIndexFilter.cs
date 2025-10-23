using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000191 RID: 401
	internal class ArrayIndexFilter : PathFilter
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0003D7E7 File Offset: 0x0003B9E7
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x0003D7EF File Offset: 0x0003B9EF
		public int? Index { get; set; }

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			foreach (JToken jtoken in current)
			{
				if (this.Index != null)
				{
					JToken tokenIndex = PathFilter.GetTokenIndex(jtoken, settings, this.Index.GetValueOrDefault());
					if (tokenIndex != null)
					{
						yield return tokenIndex;
					}
				}
				else if (jtoken is JArray || jtoken is JConstructor)
				{
					foreach (JToken jtoken2 in ((IEnumerable<JToken>)jtoken))
					{
						yield return jtoken2;
					}
					IEnumerator<JToken> enumerator2 = null;
				}
				else if (settings != null && settings.ErrorWhenNoMatch)
				{
					throw new JsonException("Index * not valid on {0}.".FormatWith(CultureInfo.InvariantCulture, jtoken.GetType().Name));
				}
			}
			IEnumerator<JToken> enumerator = null;
			yield break;
			yield break;
		}
	}
}
