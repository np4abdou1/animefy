using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x020000A1 RID: 161
	internal class ExpressionN<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x00012B84 File Offset: 0x00010D84
		public ExpressionN(Expression body, IReadOnlyList<ParameterExpression> parameters) : base(body)
		{
			this._parameters = parameters;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00012B94 File Offset: 0x00010D94
		internal override int ParameterCount
		{
			get
			{
				return this._parameters.Count;
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00012BA1 File Offset: 0x00010DA1
		internal override ParameterExpression GetParameter(int index)
		{
			return this._parameters[index];
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00012BAF File Offset: 0x00010DAF
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			return ExpressionUtils.ReturnReadOnly<ParameterExpression>(ref this._parameters);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00012BBC File Offset: 0x00010DBC
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return Expression.Lambda<TDelegate>(body, base.Name, base.TailCall, parameters ?? this._parameters);
		}

		// Token: 0x0400017A RID: 378
		private IReadOnlyList<ParameterExpression> _parameters;
	}
}
