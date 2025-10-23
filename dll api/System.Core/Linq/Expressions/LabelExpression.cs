using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents a label, which can be put in any <see cref="T:System.Linq.Expressions.Expression" /> context. If it is jumped to, it will get the value provided by the corresponding <see cref="T:System.Linq.Expressions.GotoExpression" />. Otherwise, it receives the value in <see cref="P:System.Linq.Expressions.LabelExpression.DefaultValue" />. If the <see cref="T:System.Type" /> equals System.Void, no value should be provided.</summary>
	// Token: 0x02000099 RID: 153
	[DebuggerTypeProxy(typeof(Expression.LabelExpressionProxy))]
	public sealed class LabelExpression : Expression
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x00012807 File Offset: 0x00010A07
		internal LabelExpression(LabelTarget label, Expression defaultValue)
		{
			this.Target = label;
			this.DefaultValue = defaultValue;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.LabelExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001281D File Offset: 0x00010A1D
		public sealed override Type Type
		{
			get
			{
				return this.Target.Type;
			}
		}

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0001282A File Offset: 0x00010A2A
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Label;
			}
		}

		/// <summary>The <see cref="T:System.Linq.Expressions.LabelTarget" /> which this label is associated with.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.LabelTarget" /> which this label is associated with.</returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0001282E File Offset: 0x00010A2E
		public LabelTarget Target { get; }

		/// <summary>The value of the <see cref="T:System.Linq.Expressions.LabelExpression" /> when the label is reached through regular control flow (for example, is not jumped to).</summary>
		/// <returns>The Expression object representing the value of the <see cref="T:System.Linq.Expressions.LabelExpression" />.</returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00012836 File Offset: 0x00010A36
		public Expression DefaultValue { get; }

		// Token: 0x060004DF RID: 1247 RVA: 0x0001283E File Offset: 0x00010A3E
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitLabel(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="target">The <see cref="P:System.Linq.Expressions.LabelExpression.Target" /> property of the result.</param>
		/// <param name="defaultValue">The <see cref="P:System.Linq.Expressions.LabelExpression.DefaultValue" /> property of the result</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x060004E0 RID: 1248 RVA: 0x00012847 File Offset: 0x00010A47
		public LabelExpression Update(LabelTarget target, Expression defaultValue)
		{
			if (target == this.Target && defaultValue == this.DefaultValue)
			{
				return this;
			}
			return Expression.Label(target, defaultValue);
		}
	}
}
