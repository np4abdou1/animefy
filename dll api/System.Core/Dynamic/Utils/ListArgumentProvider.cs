using System;
using System.Linq.Expressions;

namespace System.Dynamic.Utils
{
	// Token: 0x0200013F RID: 319
	internal sealed class ListArgumentProvider : ListProvider<Expression>
	{
		// Token: 0x06000A0F RID: 2575 RVA: 0x00025A3D File Offset: 0x00023C3D
		internal ListArgumentProvider(IArgumentProvider provider, Expression arg0)
		{
			this._provider = provider;
			this._arg0 = arg0;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00025A53 File Offset: 0x00023C53
		protected override Expression First
		{
			get
			{
				return this._arg0;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00025A5B File Offset: 0x00023C5B
		protected override int ElementCount
		{
			get
			{
				return this._provider.ArgumentCount;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00025A68 File Offset: 0x00023C68
		protected override Expression GetElement(int index)
		{
			return this._provider.GetArgument(index);
		}

		// Token: 0x04000303 RID: 771
		private readonly IArgumentProvider _provider;

		// Token: 0x04000304 RID: 772
		private readonly Expression _arg0;
	}
}
