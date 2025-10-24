using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x020000A0 RID: 160
	internal sealed class Expression3<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00012AE4 File Offset: 0x00010CE4
		public Expression3(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) : base(body)
		{
			this._par0 = par0;
			this._par1 = par1;
			this._par2 = par2;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000F766 File Offset: 0x0000D966
		internal override int ParameterCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00012B03 File Offset: 0x00010D03
		internal override ParameterExpression GetParameter(int index)
		{
			switch (index)
			{
			case 0:
				return ExpressionUtils.ReturnObject<ParameterExpression>(this._par0);
			case 1:
				return this._par1;
			case 2:
				return this._par2;
			default:
				throw Error.ArgumentOutOfRange("index");
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00012B3D File Offset: 0x00010D3D
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._par0);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00012B4B File Offset: 0x00010D4B
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			if (parameters != null)
			{
				return Expression.Lambda<TDelegate>(body, parameters);
			}
			return Expression.Lambda<TDelegate>(body, new ParameterExpression[]
			{
				ExpressionUtils.ReturnObject<ParameterExpression>(this._par0),
				this._par1,
				this._par2
			});
		}

		// Token: 0x04000177 RID: 375
		private object _par0;

		// Token: 0x04000178 RID: 376
		private readonly ParameterExpression _par1;

		// Token: 0x04000179 RID: 377
		private readonly ParameterExpression _par2;
	}
}
