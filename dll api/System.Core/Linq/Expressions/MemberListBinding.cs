using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents initializing the elements of a collection member of a newly created object.</summary>
	// Token: 0x020000AC RID: 172
	public sealed class MemberListBinding : MemberBinding
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x00013040 File Offset: 0x00011240
		internal MemberListBinding(MemberInfo member, ReadOnlyCollection<ElementInit> initializers) : base(MemberBindingType.ListBinding, member)
		{
			this.Initializers = initializers;
		}

		/// <summary>Gets the element initializers for initializing a collection member of a newly created object.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.ElementInit" /> objects to initialize a collection member with.</returns>
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00013051 File Offset: 0x00011251
		public ReadOnlyCollection<ElementInit> Initializers { get; }

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="initializers">The <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x06000556 RID: 1366 RVA: 0x00013059 File Offset: 0x00011259
		public MemberListBinding Update(IEnumerable<ElementInit> initializers)
		{
			if (initializers != null && ExpressionUtils.SameElements<ElementInit>(ref initializers, this.Initializers))
			{
				return this;
			}
			return Expression.ListBind(base.Member, initializers);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000073D5 File Offset: 0x000055D5
		internal override void ValidateAsDefinedHere(int index)
		{
		}
	}
}
