using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents creating a new array and possibly initializing the elements of the new array.</summary>
	// Token: 0x020000BC RID: 188
	[DebuggerTypeProxy(typeof(Expression.NewArrayExpressionProxy))]
	public class NewArrayExpression : Expression
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x00013735 File Offset: 0x00011935
		internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions)
		{
			this.Expressions = expressions;
			this.Type = type;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001374B File Offset: 0x0001194B
		internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions)
		{
			if (nodeType == ExpressionType.NewArrayInit)
			{
				return new NewArrayInitExpression(type, expressions);
			}
			return new NewArrayBoundsExpression(type, expressions);
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.NewArrayExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00013761 File Offset: 0x00011961
		public sealed override Type Type { get; }

		/// <summary>Gets the bounds of the array if the value of the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property is <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayBounds" />, or the values to initialize the elements of the new array if the value of the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property is <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayInit" />.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.Expression" /> objects which represent either the bounds of the array or the initialization values.</returns>
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00013769 File Offset: 0x00011969
		public ReadOnlyCollection<Expression> Expressions { get; }

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x060005AA RID: 1450 RVA: 0x00013771 File Offset: 0x00011971
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitNewArray(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="expressions">The <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x060005AB RID: 1451 RVA: 0x0001377C File Offset: 0x0001197C
		public NewArrayExpression Update(IEnumerable<Expression> expressions)
		{
			ContractUtils.RequiresNotNull(expressions, "expressions");
			if (ExpressionUtils.SameElements<Expression>(ref expressions, this.Expressions))
			{
				return this;
			}
			if (this.NodeType != ExpressionType.NewArrayInit)
			{
				return Expression.NewArrayBounds(this.Type.GetElementType(), expressions);
			}
			return Expression.NewArrayInit(this.Type.GetElementType(), expressions);
		}
	}
}
