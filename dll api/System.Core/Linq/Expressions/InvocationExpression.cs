using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents an expression that applies a delegate or lambda expression to a list of argument expressions.</summary>
	// Token: 0x02000091 RID: 145
	[DebuggerTypeProxy(typeof(Expression.InvocationExpressionProxy))]
	public class InvocationExpression : Expression, IArgumentProvider
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x00012462 File Offset: 0x00010662
		internal InvocationExpression(Expression expression, Type returnType)
		{
			this.Expression = expression;
			this.Type = returnType;
		}

		/// <summary>Gets the static type of the expression that this <see cref="P:System.Linq.Expressions.InvocationExpression.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.InvocationExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00012478 File Offset: 0x00010678
		public sealed override Type Type { get; }

		/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00012480 File Offset: 0x00010680
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Invoke;
			}
		}

		/// <summary>Gets the delegate or lambda expression to be applied.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the delegate to be applied.</returns>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00012484 File Offset: 0x00010684
		public Expression Expression { get; }

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001248C File Offset: 0x0001068C
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitInvocation(this);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00012495 File Offset: 0x00010695
		internal LambdaExpression LambdaOperand
		{
			get
			{
				if (this.Expression.NodeType != ExpressionType.Quote)
				{
					return this.Expression as LambdaExpression;
				}
				return (LambdaExpression)((UnaryExpression)this.Expression).Operand;
			}
		}
	}
}
