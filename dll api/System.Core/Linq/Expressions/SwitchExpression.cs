using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents a control expression that handles multiple selections by passing control to <see cref="T:System.Linq.Expressions.SwitchCase" />.</summary>
	// Token: 0x020000CC RID: 204
	[DebuggerTypeProxy(typeof(Expression.SwitchExpressionProxy))]
	public sealed class SwitchExpression : Expression
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x00014316 File Offset: 0x00012516
		internal SwitchExpression(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, ReadOnlyCollection<SwitchCase> cases)
		{
			this.Type = type;
			this.SwitchValue = switchValue;
			this.DefaultBody = defaultBody;
			this.Comparison = comparison;
			this.Cases = cases;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.SwitchExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00014343 File Offset: 0x00012543
		public sealed override Type Type { get; }

		/// <summary>Returns the node type of this Expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001434B File Offset: 0x0001254B
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Switch;
			}
		}

		/// <summary>Gets the test for the switch.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object representing the test for the switch.</returns>
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001434F File Offset: 0x0001254F
		public Expression SwitchValue { get; }

		/// <summary>Gets the collection of <see cref="T:System.Linq.Expressions.SwitchCase" /> objects for the switch.</summary>
		/// <returns>The collection of <see cref="T:System.Linq.Expressions.SwitchCase" /> objects.</returns>
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00014357 File Offset: 0x00012557
		public ReadOnlyCollection<SwitchCase> Cases { get; }

		/// <summary>Gets the test for the switch.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object representing the test for the switch.</returns>
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0001435F File Offset: 0x0001255F
		public Expression DefaultBody { get; }

		/// <summary>Gets the equality comparison method, if any.</summary>
		/// <returns>The <see cref="T:System.Reflection.MethodInfo" /> object representing the equality comparison method.</returns>
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00014367 File Offset: 0x00012567
		public MethodInfo Comparison { get; }

		// Token: 0x06000684 RID: 1668 RVA: 0x0001436F File Offset: 0x0001256F
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitSwitch(this);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00014378 File Offset: 0x00012578
		internal bool IsLifted
		{
			get
			{
				return this.SwitchValue.Type.IsNullableType() && (this.Comparison == null || !TypeUtils.AreEquivalent(this.SwitchValue.Type, this.Comparison.GetParametersCached()[0].ParameterType.GetNonRefType()));
			}
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="switchValue">The <see cref="P:System.Linq.Expressions.SwitchExpression.SwitchValue" /> property of the result.</param>
		/// <param name="cases">The <see cref="P:System.Linq.Expressions.SwitchExpression.Cases" /> property of the result.</param>
		/// <param name="defaultBody">The <see cref="P:System.Linq.Expressions.SwitchExpression.DefaultBody" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000686 RID: 1670 RVA: 0x000143D4 File Offset: 0x000125D4
		public SwitchExpression Update(Expression switchValue, IEnumerable<SwitchCase> cases, Expression defaultBody)
		{
			if ((switchValue == this.SwitchValue & defaultBody == this.DefaultBody & cases != null) && ExpressionUtils.SameElements<SwitchCase>(ref cases, this.Cases))
			{
				return this;
			}
			return Expression.Switch(this.Type, switchValue, defaultBody, this.Comparison, cases);
		}
	}
}
