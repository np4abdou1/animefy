using System;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	/// <summary>Represents an operation between an expression and a type.</summary>
	// Token: 0x020000CE RID: 206
	[DebuggerTypeProxy(typeof(Expression.TypeBinaryExpressionProxy))]
	public sealed class TypeBinaryExpression : Expression
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x000144D2 File Offset: 0x000126D2
		internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType)
		{
			this.Expression = expression;
			this.TypeOperand = typeOperand;
			this.NodeType = nodeType;
		}

		/// <summary>Gets the static type of the expression that this <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00009571 File Offset: 0x00007771
		public sealed override Type Type
		{
			get
			{
				return typeof(bool);
			}
		}

		/// <summary>Returns the node type of this Expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x000144EF File Offset: 0x000126EF
		public sealed override ExpressionType NodeType { get; }

		/// <summary>Gets the expression operand of a type test operation.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the expression operand of a type test operation.</returns>
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000144F7 File Offset: 0x000126F7
		public Expression Expression { get; }

		/// <summary>Gets the type operand of a type test operation.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type operand of a type test operation.</returns>
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000144FF File Offset: 0x000126FF
		public Type TypeOperand { get; }

		// Token: 0x06000695 RID: 1685 RVA: 0x00014508 File Offset: 0x00012708
		internal Expression ReduceTypeEqual()
		{
			Type type = this.Expression.Type;
			if (type.IsValueType || this.TypeOperand.IsPointer)
			{
				if (!type.IsNullableType())
				{
					return Expression.Block(this.Expression, Utils.Constant(type == this.TypeOperand.GetNonNullableType()));
				}
				if (type.GetNonNullableType() != this.TypeOperand.GetNonNullableType())
				{
					return Expression.Block(this.Expression, Utils.Constant(false));
				}
				return Expression.NotEqual(this.Expression, Expression.Constant(null, this.Expression.Type));
			}
			else
			{
				if (this.Expression.NodeType == ExpressionType.Constant)
				{
					return this.ReduceConstantTypeEqual();
				}
				ParameterExpression parameterExpression = this.Expression as ParameterExpression;
				if (parameterExpression != null && !parameterExpression.IsByRef)
				{
					return this.ByValParameterTypeEqual(parameterExpression);
				}
				parameterExpression = Expression.Parameter(typeof(object));
				return Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					Expression.Assign(parameterExpression, this.Expression),
					this.ByValParameterTypeEqual(parameterExpression)
				}));
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00014624 File Offset: 0x00012824
		private Expression ByValParameterTypeEqual(ParameterExpression value)
		{
			Expression expression = Expression.Call(value, CachedReflectionInfo.Object_GetType);
			if (this.TypeOperand.IsInterface)
			{
				ParameterExpression parameterExpression = Expression.Parameter(typeof(Type));
				expression = Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					Expression.Assign(parameterExpression, expression),
					parameterExpression
				}));
			}
			return Expression.AndAlso(Expression.ReferenceNotEqual(value, Utils.Null), Expression.ReferenceEqual(expression, Expression.Constant(this.TypeOperand.GetNonNullableType(), typeof(Type))));
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000146B8 File Offset: 0x000128B8
		private Expression ReduceConstantTypeEqual()
		{
			ConstantExpression constantExpression = this.Expression as ConstantExpression;
			if (constantExpression.Value == null)
			{
				return Utils.Constant(false);
			}
			return Utils.Constant(this.TypeOperand.GetNonNullableType() == constantExpression.Value.GetType());
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00014700 File Offset: 0x00012900
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitTypeBinary(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="expression">The <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000699 RID: 1689 RVA: 0x00014709 File Offset: 0x00012909
		public TypeBinaryExpression Update(Expression expression)
		{
			if (expression == this.Expression)
			{
				return this;
			}
			if (this.NodeType == ExpressionType.TypeIs)
			{
				return Expression.TypeIs(expression, this.TypeOperand);
			}
			return Expression.TypeEqual(expression, this.TypeOperand);
		}
	}
}
