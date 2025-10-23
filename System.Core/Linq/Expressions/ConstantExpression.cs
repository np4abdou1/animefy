using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents an expression that has a constant value.</summary>
	// Token: 0x02000082 RID: 130
	[DebuggerTypeProxy(typeof(Expression.ConstantExpressionProxy))]
	public class ConstantExpression : Expression
	{
		// Token: 0x0600037F RID: 895 RVA: 0x0000FEBB File Offset: 0x0000E0BB
		internal ConstantExpression(object value)
		{
			this.Value = value;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.ConstantExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000FECA File Offset: 0x0000E0CA
		public override Type Type
		{
			get
			{
				if (this.Value == null)
				{
					return typeof(object);
				}
				return this.Value.GetType();
			}
		}

		/// <summary>Returns the node type of this Expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000FEEA File Offset: 0x0000E0EA
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Constant;
			}
		}

		/// <summary>Gets the value of the constant expression.</summary>
		/// <returns>An <see cref="T:System.Object" /> equal to the value of the represented expression.</returns>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000FEEE File Offset: 0x0000E0EE
		public object Value { get; }

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x06000383 RID: 899 RVA: 0x0000FEF6 File Offset: 0x0000E0F6
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitConstant(this);
		}
	}
}
