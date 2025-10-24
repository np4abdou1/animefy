using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x0200009F RID: 159
	internal sealed class Expression2<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x00012A67 File Offset: 0x00010C67
		public Expression2(Expression body, ParameterExpression par0, ParameterExpression par1) : base(body)
		{
			this._par0 = par0;
			this._par1 = par1;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		internal override int ParameterCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00012A7E File Offset: 0x00010C7E
		internal override ParameterExpression GetParameter(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<ParameterExpression>(this._par0);
			}
			if (index != 1)
			{
				throw Error.ArgumentOutOfRange("index");
			}
			return this._par1;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00012AA6 File Offset: 0x00010CA6
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._par0);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00012AB4 File Offset: 0x00010CB4
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			if (parameters != null)
			{
				return Expression.Lambda<TDelegate>(body, parameters);
			}
			return Expression.Lambda<TDelegate>(body, new ParameterExpression[]
			{
				ExpressionUtils.ReturnObject<ParameterExpression>(this._par0),
				this._par1
			});
		}

		// Token: 0x04000175 RID: 373
		private object _par0;

		// Token: 0x04000176 RID: 374
		private readonly ParameterExpression _par1;
	}
}
