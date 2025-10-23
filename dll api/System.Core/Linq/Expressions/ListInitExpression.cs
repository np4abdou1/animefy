using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents a constructor call that has a collection initializer.</summary>
	// Token: 0x020000A3 RID: 163
	[DebuggerTypeProxy(typeof(Expression.ListInitExpressionProxy))]
	public sealed class ListInitExpression : Expression
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00012C11 File Offset: 0x00010E11
		internal ListInitExpression(NewExpression newExpression, ReadOnlyCollection<ElementInit> initializers)
		{
			this.NewExpression = newExpression;
			this.Initializers = initializers;
		}

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00012C27 File Offset: 0x00010E27
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.ListInit;
			}
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.ListInitExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00012C2B File Offset: 0x00010E2B
		public sealed override Type Type
		{
			get
			{
				return this.NewExpression.Type;
			}
		}

		/// <summary>Gets a value that indicates whether the expression tree node can be reduced.</summary>
		/// <returns>True if the node can be reduced, otherwise false.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00007357 File Offset: 0x00005557
		public override bool CanReduce
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the expression that contains a call to the constructor of a collection type.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that represents the call to the constructor of a collection type.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00012C38 File Offset: 0x00010E38
		public NewExpression NewExpression { get; }

		/// <summary>Gets the element initializers that are used to initialize a collection.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.ElementInit" /> objects which represent the elements that are used to initialize the collection.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00012C40 File Offset: 0x00010E40
		public ReadOnlyCollection<ElementInit> Initializers { get; }

		// Token: 0x06000524 RID: 1316 RVA: 0x00012C48 File Offset: 0x00010E48
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitListInit(this);
		}

		/// <summary>Reduces the binary expression node to a simpler expression.</summary>
		/// <returns>The reduced expression.</returns>
		// Token: 0x06000525 RID: 1317 RVA: 0x00012C51 File Offset: 0x00010E51
		public override Expression Reduce()
		{
			return MemberInitExpression.ReduceListInit(this.NewExpression, this.Initializers, true);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="newExpression">The <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression" /> property of the result.</param>
		/// <param name="initializers">The <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000526 RID: 1318 RVA: 0x00012C65 File Offset: 0x00010E65
		public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers)
		{
			if ((newExpression == this.NewExpression & initializers != null) && ExpressionUtils.SameElements<ElementInit>(ref initializers, this.Initializers))
			{
				return this;
			}
			return Expression.ListInit(newExpression, initializers);
		}
	}
}
