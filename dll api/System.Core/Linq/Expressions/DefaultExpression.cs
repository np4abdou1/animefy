using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents the default value of a type or an empty expression.</summary>
	// Token: 0x02000085 RID: 133
	[DebuggerTypeProxy(typeof(Expression.DefaultExpressionProxy))]
	public sealed class DefaultExpression : Expression
	{
		// Token: 0x06000386 RID: 902 RVA: 0x0000FF17 File Offset: 0x0000E117
		internal DefaultExpression(Type type)
		{
			this.Type = type;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.DefaultExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000FF26 File Offset: 0x0000E126
		public sealed override Type Type { get; }

		/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000FF2E File Offset: 0x0000E12E
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Default;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000FF32 File Offset: 0x0000E132
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitDefault(this);
		}
	}
}
