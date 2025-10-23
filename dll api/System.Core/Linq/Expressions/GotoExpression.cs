using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents an unconditional jump. This includes return statements, break and continue statements, and other jumps.</summary>
	// Token: 0x0200008C RID: 140
	[DebuggerTypeProxy(typeof(Expression.GotoExpressionProxy))]
	public sealed class GotoExpression : Expression
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x00012338 File Offset: 0x00010538
		internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
			this.Kind = kind;
			this.Value = value;
			this.Target = target;
			this.Type = type;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.GotoExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001235D File Offset: 0x0001055D
		public sealed override Type Type { get; }

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00012365 File Offset: 0x00010565
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Goto;
			}
		}

		/// <summary>The value passed to the target, or null if the target is of type System.Void.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object representing the value passed to the target or null.</returns>
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00012369 File Offset: 0x00010569
		public Expression Value { get; }

		/// <summary>The target label where this node jumps to.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.LabelTarget" /> object representing the target label for this node.</returns>
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00012371 File Offset: 0x00010571
		public LabelTarget Target { get; }

		/// <summary>The kind of the "go to" expression. Serves information purposes only.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.GotoExpressionKind" /> object representing the kind of the "go to" expression.</returns>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00012379 File Offset: 0x00010579
		public GotoExpressionKind Kind { get; }

		// Token: 0x060004A3 RID: 1187 RVA: 0x00012381 File Offset: 0x00010581
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitGoto(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="target">The <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property of the result. </param>
		/// <param name="value">The <see cref="P:System.Linq.Expressions.GotoExpression.Value" /> property of the result. </param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x060004A4 RID: 1188 RVA: 0x0001238A File Offset: 0x0001058A
		public GotoExpression Update(LabelTarget target, Expression value)
		{
			if (target == this.Target && value == this.Value)
			{
				return this;
			}
			return Expression.MakeGoto(this.Kind, target, value, this.Type);
		}
	}
}
