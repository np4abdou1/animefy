using System;

namespace System.Reflection
{
	/// <summary>Defines a friendly default alias for an assembly manifest.</summary>
	// Token: 0x02000486 RID: 1158
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDefaultAliasAttribute" /> class.</summary>
		/// <param name="defaultAlias">The assembly default alias information. </param>
		// Token: 0x060020C6 RID: 8390 RVA: 0x00089A59 File Offset: 0x00087C59
		public AssemblyDefaultAliasAttribute(string defaultAlias)
		{
			this.<DefaultAlias>k__BackingField = defaultAlias;
		}
	}
}
