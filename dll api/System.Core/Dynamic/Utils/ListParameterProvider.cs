using System;
using System.Linq.Expressions;

namespace System.Dynamic.Utils
{
	// Token: 0x02000140 RID: 320
	internal sealed class ListParameterProvider : ListProvider<ParameterExpression>
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x00025A76 File Offset: 0x00023C76
		internal ListParameterProvider(IParameterProvider provider, ParameterExpression arg0)
		{
			this._provider = provider;
			this._arg0 = arg0;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00025A8C File Offset: 0x00023C8C
		protected override ParameterExpression First
		{
			get
			{
				return this._arg0;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00025A94 File Offset: 0x00023C94
		protected override int ElementCount
		{
			get
			{
				return this._provider.ParameterCount;
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00025AA1 File Offset: 0x00023CA1
		protected override ParameterExpression GetElement(int index)
		{
			return this._provider.GetParameter(index);
		}

		// Token: 0x04000305 RID: 773
		private readonly IParameterProvider _provider;

		// Token: 0x04000306 RID: 774
		private readonly ParameterExpression _arg0;
	}
}
