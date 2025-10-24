using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents a constructor call.</summary>
	// Token: 0x020000BF RID: 191
	[DebuggerTypeProxy(typeof(Expression.NewExpressionProxy))]
	public class NewExpression : Expression, IArgumentProvider
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x000137E4 File Offset: 0x000119E4
		internal NewExpression(ConstructorInfo constructor, IReadOnlyList<Expression> arguments, ReadOnlyCollection<MemberInfo> members)
		{
			this.Constructor = constructor;
			this._arguments = arguments;
			this.Members = members;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.NewExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00013801 File Offset: 0x00011A01
		public override Type Type
		{
			get
			{
				return this.Constructor.DeclaringType;
			}
		}

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001380E File Offset: 0x00011A0E
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.New;
			}
		}

		/// <summary>Gets the called constructor.</summary>
		/// <returns>The <see cref="T:System.Reflection.ConstructorInfo" /> that represents the called constructor.</returns>
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00013812 File Offset: 0x00011A12
		public ConstructorInfo Constructor { get; }

		/// <summary>Gets the arguments to the constructor.</summary>
		/// <returns>A collection of <see cref="T:System.Linq.Expressions.Expression" /> objects that represent the arguments to the constructor.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001381A File Offset: 0x00011A1A
		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return ExpressionUtils.ReturnReadOnly<Expression>(ref this._arguments);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00013827 File Offset: 0x00011A27
		public Expression GetArgument(int index)
		{
			return this._arguments[index];
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00013835 File Offset: 0x00011A35
		public int ArgumentCount
		{
			get
			{
				return this._arguments.Count;
			}
		}

		/// <summary>Gets the members that can retrieve the values of the fields that were initialized with constructor arguments.</summary>
		/// <returns>A collection of <see cref="T:System.Reflection.MemberInfo" /> objects that represent the members that can retrieve the values of the fields that were initialized with constructor arguments.</returns>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00013842 File Offset: 0x00011A42
		public ReadOnlyCollection<MemberInfo> Members { get; }

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x060005B8 RID: 1464 RVA: 0x0001384A File Offset: 0x00011A4A
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitNew(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="arguments">The <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x060005B9 RID: 1465 RVA: 0x00013853 File Offset: 0x00011A53
		public NewExpression Update(IEnumerable<Expression> arguments)
		{
			if (ExpressionUtils.SameElements<Expression>(ref arguments, this.Arguments))
			{
				return this;
			}
			if (this.Members == null)
			{
				return Expression.New(this.Constructor, arguments);
			}
			return Expression.New(this.Constructor, arguments, this.Members);
		}

		// Token: 0x040001AB RID: 427
		private IReadOnlyList<Expression> _arguments;
	}
}
