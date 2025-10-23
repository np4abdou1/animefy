using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents an expression that has a conditional operator.</summary>
	// Token: 0x0200007F RID: 127
	[DebuggerTypeProxy(typeof(Expression.ConditionalExpressionProxy))]
	public class ConditionalExpression : Expression
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0000FDAA File Offset: 0x0000DFAA
		internal ConditionalExpression(Expression test, Expression ifTrue)
		{
			this.Test = test;
			this.IfTrue = ifTrue;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			if (ifTrue.Type != type || ifFalse.Type != type)
			{
				return new FullConditionalExpressionWithType(test, ifTrue, ifFalse, type);
			}
			if (ifFalse is DefaultExpression && ifFalse.Type == typeof(void))
			{
				return new ConditionalExpression(test, ifTrue);
			}
			return new FullConditionalExpression(test, ifTrue, ifFalse);
		}

		/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000FE22 File Offset: 0x0000E022
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Conditional;
			}
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.ConditionalExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000FE25 File Offset: 0x0000E025
		public override Type Type
		{
			get
			{
				return this.IfTrue.Type;
			}
		}

		/// <summary>Gets the test of the conditional operation.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the test of the conditional operation.</returns>
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000FE32 File Offset: 0x0000E032
		public Expression Test { get; }

		/// <summary>Gets the expression to execute if the test evaluates to <see langword="true" />.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the expression to execute if the test is <see langword="true" />.</returns>
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000FE3A File Offset: 0x0000E03A
		public Expression IfTrue { get; }

		/// <summary>Gets the expression to execute if the test evaluates to <see langword="false" />.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the expression to execute if the test is <see langword="false" />.</returns>
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000FE42 File Offset: 0x0000E042
		public Expression IfFalse
		{
			get
			{
				return this.GetFalse();
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000FE4A File Offset: 0x0000E04A
		internal virtual Expression GetFalse()
		{
			return Utils.Empty;
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x06000379 RID: 889 RVA: 0x0000FE51 File Offset: 0x0000E051
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitConditional(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression</summary>
		/// <param name="test">The <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" /> property of the result.</param>
		/// <param name="ifTrue">The <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" /> property of the result.</param>
		/// <param name="ifFalse">The <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> property of the result.</param>
		/// <returns>This expression if no children changed, or an expression with the updated children.</returns>
		// Token: 0x0600037A RID: 890 RVA: 0x0000FE5A File Offset: 0x0000E05A
		public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
		{
			if (test == this.Test && ifTrue == this.IfTrue && ifFalse == this.IfFalse)
			{
				return this;
			}
			return Expression.Condition(test, ifTrue, ifFalse, this.Type);
		}
	}
}
