using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents calling a constructor and initializing one or more members of the new object.</summary>
	// Token: 0x020000AB RID: 171
	[DebuggerTypeProxy(typeof(Expression.MemberInitExpressionProxy))]
	public sealed class MemberInitExpression : Expression
	{
		// Token: 0x06000548 RID: 1352 RVA: 0x00012E55 File Offset: 0x00011055
		internal MemberInitExpression(NewExpression newExpression, ReadOnlyCollection<MemberBinding> bindings)
		{
			this.NewExpression = newExpression;
			this.Bindings = bindings;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.MemberInitExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00012E6B File Offset: 0x0001106B
		public sealed override Type Type
		{
			get
			{
				return this.NewExpression.Type;
			}
		}

		/// <summary>Gets a value that indicates whether the expression tree node can be reduced.</summary>
		/// <returns>True if the node can be reduced, otherwise false.</returns>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00007357 File Offset: 0x00005557
		public override bool CanReduce
		{
			get
			{
				return true;
			}
		}

		/// <summary>Returns the node type of this Expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00012E78 File Offset: 0x00011078
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.MemberInit;
			}
		}

		/// <summary>Gets the expression that represents the constructor call.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that represents the constructor call.</returns>
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00012E7C File Offset: 0x0001107C
		public NewExpression NewExpression { get; }

		/// <summary>Gets the bindings that describe how to initialize the members of the newly created object.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.MemberBinding" /> objects which describe how to initialize the members.</returns>
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00012E84 File Offset: 0x00011084
		public ReadOnlyCollection<MemberBinding> Bindings { get; }

		// Token: 0x0600054E RID: 1358 RVA: 0x00012E8C File Offset: 0x0001108C
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitMemberInit(this);
		}

		/// <summary>Reduces the <see cref="T:System.Linq.Expressions.MemberInitExpression" /> to a simpler expression. </summary>
		/// <returns>The reduced expression.</returns>
		// Token: 0x0600054F RID: 1359 RVA: 0x00012E95 File Offset: 0x00011095
		public override Expression Reduce()
		{
			return MemberInitExpression.ReduceMemberInit(this.NewExpression, this.Bindings, true);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00012EAC File Offset: 0x000110AC
		private static Expression ReduceMemberInit(Expression objExpression, ReadOnlyCollection<MemberBinding> bindings, bool keepOnStack)
		{
			ParameterExpression parameterExpression = Expression.Variable(objExpression.Type);
			int count = bindings.Count;
			Expression[] array = new Expression[count + 2];
			array[0] = Expression.Assign(parameterExpression, objExpression);
			for (int i = 0; i < count; i++)
			{
				array[i + 1] = MemberInitExpression.ReduceMemberBinding(parameterExpression, bindings[i]);
			}
			array[count + 1] = (keepOnStack ? parameterExpression : Utils.Empty);
			return Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, array);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00012F20 File Offset: 0x00011120
		internal static Expression ReduceListInit(Expression listExpression, ReadOnlyCollection<ElementInit> initializers, bool keepOnStack)
		{
			ParameterExpression parameterExpression = Expression.Variable(listExpression.Type);
			int count = initializers.Count;
			Expression[] array = new Expression[count + 2];
			array[0] = Expression.Assign(parameterExpression, listExpression);
			for (int i = 0; i < count; i++)
			{
				ElementInit elementInit = initializers[i];
				array[i + 1] = Expression.Call(parameterExpression, elementInit.AddMethod, elementInit.Arguments);
			}
			array[count + 1] = (keepOnStack ? parameterExpression : Utils.Empty);
			return Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, array);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00012FA4 File Offset: 0x000111A4
		internal static Expression ReduceMemberBinding(ParameterExpression objVar, MemberBinding binding)
		{
			MemberExpression memberExpression = Expression.MakeMemberAccess(objVar, binding.Member);
			switch (binding.BindingType)
			{
			case MemberBindingType.Assignment:
				return Expression.Assign(memberExpression, ((MemberAssignment)binding).Expression);
			case MemberBindingType.MemberBinding:
				return MemberInitExpression.ReduceMemberInit(memberExpression, ((MemberMemberBinding)binding).Bindings, false);
			case MemberBindingType.ListBinding:
				return MemberInitExpression.ReduceListInit(memberExpression, ((MemberListBinding)binding).Initializers, false);
			default:
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="newExpression">The <see cref="P:System.Linq.Expressions.MemberInitExpression.NewExpression" /> property of the result.</param>
		/// <param name="bindings">The <see cref="P:System.Linq.Expressions.MemberInitExpression.Bindings" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000553 RID: 1363 RVA: 0x00013016 File Offset: 0x00011216
		public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
		{
			if ((newExpression == this.NewExpression & bindings != null) && ExpressionUtils.SameElements<MemberBinding>(ref bindings, this.Bindings))
			{
				return this;
			}
			return Expression.MemberInit(newExpression, bindings);
		}
	}
}
