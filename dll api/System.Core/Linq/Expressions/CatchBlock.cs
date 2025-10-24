using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Represents a catch statement in a try block.</summary>
	// Token: 0x0200007B RID: 123
	[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
	public sealed class CatchBlock
	{
		// Token: 0x06000366 RID: 870 RVA: 0x0000FC4E File Offset: 0x0000DE4E
		internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter)
		{
			this.Test = test;
			this.Variable = variable;
			this.Body = body;
			this.Filter = filter;
		}

		/// <summary>Gets a reference to the <see cref="T:System.Exception" /> object caught by this handler.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ParameterExpression" /> object representing a reference to the <see cref="T:System.Exception" /> object caught by this handler.</returns>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000FC73 File Offset: 0x0000DE73
		public ParameterExpression Variable { get; }

		/// <summary>Gets the type of <see cref="T:System.Exception" /> this handler catches.</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the type of <see cref="T:System.Exception" /> this handler catches.</returns>
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		public Type Test { get; }

		/// <summary>Gets the body of the catch block.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object representing the catch body.</returns>
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000FC83 File Offset: 0x0000DE83
		public Expression Body { get; }

		/// <summary>Gets the body of the <see cref="T:System.Linq.Expressions.CatchBlock" /> filter.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object representing the body of the <see cref="T:System.Linq.Expressions.CatchBlock" /> filter.</returns>
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000FC8B File Offset: 0x0000DE8B
		public Expression Filter { get; }

		/// <summary>Returns a <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.</summary>
		/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.</returns>
		// Token: 0x0600036B RID: 875 RVA: 0x0000FC93 File Offset: 0x0000DE93
		public override string ToString()
		{
			return ExpressionStringBuilder.CatchBlockToString(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="variable">The <see cref="P:System.Linq.Expressions.CatchBlock.Variable" /> property of the result.</param>
		/// <param name="filter">The <see cref="P:System.Linq.Expressions.CatchBlock.Filter" /> property of the result.</param>
		/// <param name="body">The <see cref="P:System.Linq.Expressions.CatchBlock.Body" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x0600036C RID: 876 RVA: 0x0000FC9B File Offset: 0x0000DE9B
		public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
		{
			if (variable == this.Variable && filter == this.Filter && body == this.Body)
			{
				return this;
			}
			return Expression.MakeCatchBlock(this.Test, variable, body, filter);
		}
	}
}
