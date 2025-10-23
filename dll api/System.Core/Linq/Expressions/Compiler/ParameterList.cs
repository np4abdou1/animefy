using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000DD RID: 221
	internal sealed class ParameterList : IReadOnlyList<ParameterExpression>, IReadOnlyCollection<ParameterExpression>, IEnumerable<ParameterExpression>, IEnumerable
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x00016134 File Offset: 0x00014334
		public ParameterList(IParameterProvider provider)
		{
			this._provider = provider;
		}

		// Token: 0x17000166 RID: 358
		public ParameterExpression this[int index]
		{
			get
			{
				return this._provider.GetParameter(index);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00016151 File Offset: 0x00014351
		public int Count
		{
			get
			{
				return this._provider.ParameterCount;
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001615E File Offset: 0x0001435E
		public IEnumerator<ParameterExpression> GetEnumerator()
		{
			int i = 0;
			int j = this._provider.ParameterCount;
			while (i < j)
			{
				yield return this._provider.GetParameter(i);
				int num = i;
				i = num + 1;
			}
			yield break;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001616D File Offset: 0x0001436D
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400020D RID: 525
		private readonly IParameterProvider _provider;
	}
}
