using System;

namespace System.Linq.Expressions
{
	/// <summary>Describes the binding types that are used in <see cref="T:System.Linq.Expressions.MemberInitExpression" /> objects.</summary>
	// Token: 0x020000A6 RID: 166
	public enum MemberBindingType
	{
		/// <summary>A binding that represents initializing a member with the value of an expression.</summary>
		// Token: 0x04000184 RID: 388
		Assignment,
		/// <summary>A binding that represents recursively initializing members of a member.</summary>
		// Token: 0x04000185 RID: 389
		MemberBinding,
		/// <summary>A binding that represents initializing a member of type <see cref="T:System.Collections.IList" /> or <see cref="T:System.Collections.Generic.ICollection`1" /> from a list of elements.</summary>
		// Token: 0x04000186 RID: 390
		ListBinding
	}
}
