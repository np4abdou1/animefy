using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents a call to either static or an instance method.</summary>
	// Token: 0x020000AE RID: 174
	[DebuggerTypeProxy(typeof(Expression.MethodCallExpressionProxy))]
	public class MethodCallExpression : Expression, IArgumentProvider
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x000130B6 File Offset: 0x000112B6
		internal MethodCallExpression(MethodInfo method)
		{
			this.Method = method;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00008E73 File Offset: 0x00007073
		internal virtual Expression GetInstance()
		{
			return null;
		}

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x000130C5 File Offset: 0x000112C5
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Call;
			}
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.MethodCallExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x000130C8 File Offset: 0x000112C8
		public sealed override Type Type
		{
			get
			{
				return this.Method.ReturnType;
			}
		}

		/// <summary>Gets the <see cref="T:System.Reflection.MethodInfo" /> for the method to be called.</summary>
		/// <returns>The <see cref="T:System.Reflection.MethodInfo" /> that represents the called method.</returns>
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000130D5 File Offset: 0x000112D5
		public MethodInfo Method { get; }

		/// <summary>Gets the <see cref="T:System.Linq.Expressions.Expression" /> that represents the instance for instance method calls or null for static method calls.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the receiving object of the method.</returns>
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x000130DD File Offset: 0x000112DD
		public Expression Object
		{
			get
			{
				return this.GetInstance();
			}
		}

		/// <summary>Gets a collection of expressions that represent arguments of the called method.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.Expression" /> objects which represent the arguments to the called method.</returns>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000130E5 File Offset: 0x000112E5
		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return this.GetOrMakeArguments();
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			throw ContractUtils.Unreachable;
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x06000564 RID: 1380 RVA: 0x000130ED File Offset: 0x000112ED
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitMethodCall(this);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}
	}
}
