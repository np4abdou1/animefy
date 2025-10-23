using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Provides the base class from which the classes that represent bindings that are used to initialize members of a newly created object derive.</summary>
	// Token: 0x020000A7 RID: 167
	public abstract class MemberBinding
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Linq.Expressions.MemberBinding" /> class.</summary>
		/// <param name="type">The <see cref="T:System.Linq.Expressions.MemberBindingType" /> that discriminates the type of binding that is represented.</param>
		/// <param name="member">The <see cref="T:System.Reflection.MemberInfo" /> that represents a field or property to be initialized.</param>
		// Token: 0x06000533 RID: 1331 RVA: 0x00012D4A File Offset: 0x00010F4A
		protected MemberBinding(MemberBindingType type, MemberInfo member)
		{
			this.BindingType = type;
			this.Member = member;
		}

		/// <summary>Gets the type of binding that is represented.</summary>
		/// <returns>One of the <see cref="T:System.Linq.Expressions.MemberBindingType" /> values.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00012D60 File Offset: 0x00010F60
		public MemberBindingType BindingType { get; }

		/// <summary>Gets the field or property to be initialized.</summary>
		/// <returns>The <see cref="T:System.Reflection.MemberInfo" /> that represents the field or property to be initialized.</returns>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00012D68 File Offset: 0x00010F68
		public MemberInfo Member { get; }

		/// <summary>Returns a textual representation of the <see cref="T:System.Linq.Expressions.MemberBinding" />.</summary>
		/// <returns>A textual representation of the <see cref="T:System.Linq.Expressions.MemberBinding" />.</returns>
		// Token: 0x06000536 RID: 1334 RVA: 0x00012D70 File Offset: 0x00010F70
		public override string ToString()
		{
			return ExpressionStringBuilder.MemberBindingToString(this);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00012D78 File Offset: 0x00010F78
		internal virtual void ValidateAsDefinedHere(int index)
		{
			throw Error.UnknownBindingType(index);
		}
	}
}
