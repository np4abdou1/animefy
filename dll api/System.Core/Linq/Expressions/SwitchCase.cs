using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents one case of a <see cref="T:System.Linq.Expressions.SwitchExpression" />.</summary>
	// Token: 0x020000CB RID: 203
	[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
	public sealed class SwitchCase
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x000142BE File Offset: 0x000124BE
		internal SwitchCase(Expression body, ReadOnlyCollection<Expression> testValues)
		{
			this.Body = body;
			this.TestValues = testValues;
		}

		/// <summary>Gets the values of this case. This case is selected for execution when the <see cref="P:System.Linq.Expressions.SwitchExpression.SwitchValue" /> matches any of these values.</summary>
		/// <returns>The read-only collection of the values for this case block.</returns>
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000142D4 File Offset: 0x000124D4
		public ReadOnlyCollection<Expression> TestValues { get; }

		/// <summary>Gets the body of this case.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object that represents the body of the case block.</returns>
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x000142DC File Offset: 0x000124DC
		public Expression Body { get; }

		/// <summary>Returns a <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.</summary>
		/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.</returns>
		// Token: 0x0600067B RID: 1659 RVA: 0x000142E4 File Offset: 0x000124E4
		public override string ToString()
		{
			return ExpressionStringBuilder.SwitchCaseToString(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="testValues">The <see cref="P:System.Linq.Expressions.SwitchCase.TestValues" /> property of the result.</param>
		/// <param name="body">The <see cref="P:System.Linq.Expressions.SwitchCase.Body" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x0600067C RID: 1660 RVA: 0x000142EC File Offset: 0x000124EC
		public SwitchCase Update(IEnumerable<Expression> testValues, Expression body)
		{
			if ((body == this.Body & testValues != null) && ExpressionUtils.SameElements<Expression>(ref testValues, this.TestValues))
			{
				return this;
			}
			return Expression.SwitchCase(body, testValues);
		}
	}
}
