using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents an infinite loop. It can be exited with "break".</summary>
	// Token: 0x020000A4 RID: 164
	[DebuggerTypeProxy(typeof(Expression.LoopExpressionProxy))]
	public sealed class LoopExpression : Expression
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00012C8F File Offset: 0x00010E8F
		internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
		{
			this.Body = body;
			this.BreakLabel = @break;
			this.ContinueLabel = @continue;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.LoopExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00012CAC File Offset: 0x00010EAC
		public sealed override Type Type
		{
			get
			{
				if (this.BreakLabel != null)
				{
					return this.BreakLabel.Type;
				}
				return typeof(void);
			}
		}

		/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00012CCC File Offset: 0x00010ECC
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Loop;
			}
		}

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.Expression" /> that is the body of the loop.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> that is the body of the loop.</returns>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00012CD0 File Offset: 0x00010ED0
		public Expression Body { get; }

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a break statement target.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a break statement target.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00012CD8 File Offset: 0x00010ED8
		public LabelTarget BreakLabel { get; }

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a continue statement target.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a continue statement target.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00012CE0 File Offset: 0x00010EE0
		public LabelTarget ContinueLabel { get; }

		// Token: 0x0600052D RID: 1325 RVA: 0x00012CE8 File Offset: 0x00010EE8
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitLoop(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="breakLabel">The <see cref="P:System.Linq.Expressions.LoopExpression.BreakLabel" /> property of the result.</param>
		/// <param name="continueLabel">The <see cref="P:System.Linq.Expressions.LoopExpression.ContinueLabel" /> property of the result.</param>
		/// <param name="body">The <see cref="P:System.Linq.Expressions.LoopExpression.Body" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x0600052E RID: 1326 RVA: 0x00012CF1 File Offset: 0x00010EF1
		public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
		{
			if (breakLabel == this.BreakLabel && continueLabel == this.ContinueLabel && body == this.Body)
			{
				return this;
			}
			return Expression.Loop(body, breakLabel, continueLabel);
		}
	}
}
