using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents accessing a field or property.</summary>
	// Token: 0x020000A8 RID: 168
	[DebuggerTypeProxy(typeof(Expression.MemberExpressionProxy))]
	public class MemberExpression : Expression
	{
		/// <summary>Gets the field or property to be accessed.</summary>
		/// <returns>The <see cref="T:System.Reflection.MemberInfo" /> that represents the field or property to be accessed.</returns>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00012D80 File Offset: 0x00010F80
		public MemberInfo Member
		{
			get
			{
				return this.GetMember();
			}
		}

		/// <summary>Gets the containing object of the field or property.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the containing object of the field or property.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00012D88 File Offset: 0x00010F88
		public Expression Expression { get; }

		// Token: 0x0600053A RID: 1338 RVA: 0x00012D90 File Offset: 0x00010F90
		internal MemberExpression(Expression expression)
		{
			this.Expression = expression;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00012D9F File Offset: 0x00010F9F
		internal static PropertyExpression Make(Expression expression, PropertyInfo property)
		{
			return new PropertyExpression(expression, property);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00012DA8 File Offset: 0x00010FA8
		internal static FieldExpression Make(Expression expression, FieldInfo field)
		{
			return new FieldExpression(expression, field);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00012DB4 File Offset: 0x00010FB4
		internal static MemberExpression Make(Expression expression, MemberInfo member)
		{
			FieldInfo fieldInfo = member as FieldInfo;
			if (!(fieldInfo == null))
			{
				return MemberExpression.Make(expression, fieldInfo);
			}
			return MemberExpression.Make(expression, (PropertyInfo)member);
		}

		/// <summary>Returns the node type of this <see cref="P:System.Linq.Expressions.MemberExpression.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00012DE5 File Offset: 0x00010FE5
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.MemberAccess;
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual MemberInfo GetMember()
		{
			throw ContractUtils.Unreachable;
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x06000540 RID: 1344 RVA: 0x00012DE9 File Offset: 0x00010FE9
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitMember(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="expression">The <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000541 RID: 1345 RVA: 0x00012DF2 File Offset: 0x00010FF2
		public MemberExpression Update(Expression expression)
		{
			if (expression == this.Expression)
			{
				return this;
			}
			return Expression.MakeMemberAccess(expression, this.Member);
		}
	}
}
