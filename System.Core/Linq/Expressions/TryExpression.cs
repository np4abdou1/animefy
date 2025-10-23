using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents a try/catch/finally/fault block.</summary>
	// Token: 0x020000CD RID: 205
	[DebuggerTypeProxy(typeof(Expression.TryExpressionProxy))]
	public sealed class TryExpression : Expression
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x00014420 File Offset: 0x00012620
		internal TryExpression(Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers)
		{
			this.Type = type;
			this.Body = body;
			this.Handlers = handlers;
			this.Finally = @finally;
			this.Fault = fault;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.TryExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001444D File Offset: 0x0001264D
		public sealed override Type Type { get; }

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00014455 File Offset: 0x00012655
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Try;
			}
		}

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.Expression" /> representing the body of the try block.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> representing the body of the try block.</returns>
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00014459 File Offset: 0x00012659
		public Expression Body { get; }

		/// <summary>Gets the collection of <see cref="T:System.Linq.Expressions.CatchBlock" /> expressions associated with the try block.</summary>
		/// <returns>The collection of <see cref="T:System.Linq.Expressions.CatchBlock" /> expressions associated with the try block.</returns>
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00014461 File Offset: 0x00012661
		public ReadOnlyCollection<CatchBlock> Handlers { get; }

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.Expression" /> representing the finally block.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> representing the finally block.</returns>
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00014469 File Offset: 0x00012669
		public Expression Finally { get; }

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.Expression" /> representing the fault block.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> representing the fault block.</returns>
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00014471 File Offset: 0x00012671
		public Expression Fault { get; }

		// Token: 0x0600068E RID: 1678 RVA: 0x00014479 File Offset: 0x00012679
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitTry(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="body">The <see cref="P:System.Linq.Expressions.TryExpression.Body" /> property of the result.</param>
		/// <param name="handlers">The <see cref="P:System.Linq.Expressions.TryExpression.Handlers" /> property of the result.</param>
		/// <param name="finally">The <see cref="P:System.Linq.Expressions.TryExpression.Finally" /> property of the result.</param>
		/// <param name="fault">The <see cref="P:System.Linq.Expressions.TryExpression.Fault" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x0600068F RID: 1679 RVA: 0x00014484 File Offset: 0x00012684
		public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
		{
			if ((body == this.Body & @finally == this.Finally & fault == this.Fault) && ExpressionUtils.SameElements<CatchBlock>(ref handlers, this.Handlers))
			{
				return this;
			}
			return Expression.MakeTry(this.Type, body, @finally, fault, handlers);
		}
	}
}
