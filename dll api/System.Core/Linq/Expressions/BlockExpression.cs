using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Threading;

namespace System.Linq.Expressions
{
	/// <summary>Represents a block that contains a sequence of expressions where variables can be defined.</summary>
	// Token: 0x0200006F RID: 111
	[DebuggerTypeProxy(typeof(Expression.BlockExpressionProxy))]
	public class BlockExpression : Expression
	{
		/// <summary>Gets the expressions in this block.</summary>
		/// <returns>The read-only collection containing all the expressions in this block.</returns>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000F638 File Offset: 0x0000D838
		public ReadOnlyCollection<Expression> Expressions
		{
			get
			{
				return this.GetOrMakeExpressions();
			}
		}

		/// <summary>Gets the variables defined in this block.</summary>
		/// <returns>The read-only collection containing all the variables defined in this block.</returns>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000F640 File Offset: 0x0000D840
		public ReadOnlyCollection<ParameterExpression> Variables
		{
			get
			{
				return this.GetOrMakeVariables();
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000F648 File Offset: 0x0000D848
		internal BlockExpression()
		{
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x0600031C RID: 796 RVA: 0x0000F650 File Offset: 0x0000D850
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitBlock(this);
		}

		/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000F659 File Offset: 0x0000D859
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Block;
			}
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.BlockExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000F65D File Offset: 0x0000D85D
		public override Type Type
		{
			get
			{
				return this.GetExpression(this.ExpressionCount - 1).Type;
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual Expression GetExpression(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual int ExpressionCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000F679 File Offset: 0x0000D879
		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return EmptyReadOnlyCollection<ParameterExpression>.Instance;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000F680 File Offset: 0x0000D880
		internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection)
		{
			Expression expression = collection as Expression;
			if (expression != null)
			{
				Interlocked.CompareExchange(ref collection, new ReadOnlyCollection<Expression>(new BlockExpressionList(provider, expression)), expression);
			}
			return (ReadOnlyCollection<Expression>)collection;
		}
	}
}
