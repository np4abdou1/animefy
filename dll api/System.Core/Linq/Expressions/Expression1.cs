using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x0200009E RID: 158
	internal sealed class Expression1<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00012A07 File Offset: 0x00010C07
		public Expression1(Expression body, ParameterExpression par0) : base(body)
		{
			this._par0 = par0;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00007357 File Offset: 0x00005557
		internal override int ParameterCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00012A17 File Offset: 0x00010C17
		internal override ParameterExpression GetParameter(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<ParameterExpression>(this._par0);
			}
			throw Error.ArgumentOutOfRange("index");
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00012A32 File Offset: 0x00010C32
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._par0);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00012A40 File Offset: 0x00010C40
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			if (parameters != null)
			{
				return Expression.Lambda<TDelegate>(body, parameters);
			}
			return Expression.Lambda<TDelegate>(body, new ParameterExpression[]
			{
				ExpressionUtils.ReturnObject<ParameterExpression>(this._par0)
			});
		}

		// Token: 0x04000174 RID: 372
		private object _par0;
	}
}
