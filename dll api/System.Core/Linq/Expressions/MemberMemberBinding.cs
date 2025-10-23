using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents initializing members of a member of a newly created object.</summary>
	// Token: 0x020000AD RID: 173
	public sealed class MemberMemberBinding : MemberBinding
	{
		// Token: 0x06000558 RID: 1368 RVA: 0x0001307B File Offset: 0x0001127B
		internal MemberMemberBinding(MemberInfo member, ReadOnlyCollection<MemberBinding> bindings) : base(MemberBindingType.MemberBinding, member)
		{
			this.Bindings = bindings;
		}

		/// <summary>Gets the bindings that describe how to initialize the members of a member.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.MemberBinding" /> objects that describe how to initialize the members of the member.</returns>
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001308C File Offset: 0x0001128C
		public ReadOnlyCollection<MemberBinding> Bindings { get; }

		/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
		/// <param name="bindings">The <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings" /> property of the result.</param>
		/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
		// Token: 0x0600055A RID: 1370 RVA: 0x00013094 File Offset: 0x00011294
		public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings)
		{
			if (bindings != null && ExpressionUtils.SameElements<MemberBinding>(ref bindings, this.Bindings))
			{
				return this;
			}
			return Expression.MemberBind(base.Member, bindings);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000073D5 File Offset: 0x000055D5
		internal override void ValidateAsDefinedHere(int index)
		{
		}
	}
}
