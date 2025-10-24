using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents an initializer for a single element of an <see cref="T:System.Collections.IEnumerable" /> collection.</summary>
	// Token: 0x02000086 RID: 134
	public sealed class ElementInit : IArgumentProvider
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0000FF3B File Offset: 0x0000E13B
		internal ElementInit(MethodInfo addMethod, ReadOnlyCollection<Expression> arguments)
		{
			this.AddMethod = addMethod;
			this.Arguments = arguments;
		}

		/// <summary>Gets the instance method that is used to add an element to an <see cref="T:System.Collections.IEnumerable" /> collection.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> that represents an instance method that adds an element to a collection.</returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000FF51 File Offset: 0x0000E151
		public MethodInfo AddMethod { get; }

		/// <summary>Gets the collection of arguments that are passed to a method that adds an element to an <see cref="T:System.Collections.IEnumerable" /> collection.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.Expression" /> objects that represent the arguments for a method that adds an element to a collection.</returns>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000FF59 File Offset: 0x0000E159
		public ReadOnlyCollection<Expression> Arguments { get; }

		// Token: 0x0600038D RID: 909 RVA: 0x0000FF61 File Offset: 0x0000E161
		public Expression GetArgument(int index)
		{
			return this.Arguments[index];
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000FF6F File Offset: 0x0000E16F
		public int ArgumentCount
		{
			get
			{
				return this.Arguments.Count;
			}
		}

		/// <summary>Returns a textual representation of an <see cref="T:System.Linq.Expressions.ElementInit" /> object.</summary>
		/// <returns>A textual representation of the <see cref="T:System.Linq.Expressions.ElementInit" /> object.</returns>
		// Token: 0x0600038F RID: 911 RVA: 0x0000FF7C File Offset: 0x0000E17C
		public override string ToString()
		{
			return ExpressionStringBuilder.ElementInitBindingToString(this);
		}

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="arguments">The <see cref="P:System.Linq.Expressions.ElementInit.Arguments" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000390 RID: 912 RVA: 0x0000FF84 File Offset: 0x0000E184
		public ElementInit Update(IEnumerable<Expression> arguments)
		{
			if (arguments == this.Arguments)
			{
				return this;
			}
			return Expression.ElementInit(this.AddMethod, arguments);
		}
	}
}
