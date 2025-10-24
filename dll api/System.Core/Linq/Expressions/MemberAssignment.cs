using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents assignment operation for a field or property of an object.</summary>
	// Token: 0x020000A5 RID: 165
	public sealed class MemberAssignment : MemberBinding
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00012D18 File Offset: 0x00010F18
		internal MemberAssignment(MemberInfo member, Expression expression) : base(MemberBindingType.Assignment, member)
		{
			this._expression = expression;
		}

		/// <summary>Gets the expression to assign to the field or property.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> that represents the value to assign to the field or property.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00012D29 File Offset: 0x00010F29
		public Expression Expression
		{
			get
			{
				return this._expression;
			}
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="expression">The <see cref="P:System.Linq.Expressions.MemberAssignment.Expression" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000531 RID: 1329 RVA: 0x00012D31 File Offset: 0x00010F31
		public MemberAssignment Update(Expression expression)
		{
			if (expression == this.Expression)
			{
				return this;
			}
			return Expression.Bind(base.Member, expression);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000073D5 File Offset: 0x000055D5
		internal override void ValidateAsDefinedHere(int index)
		{
		}

		// Token: 0x04000182 RID: 386
		private readonly Expression _expression;
	}
}
