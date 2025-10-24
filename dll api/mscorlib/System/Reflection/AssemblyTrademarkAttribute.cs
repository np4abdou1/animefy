using System;

namespace System.Reflection
{
	/// <summary>Defines a trademark custom attribute for an assembly manifest.</summary>
	// Token: 0x02000490 RID: 1168
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyTrademarkAttribute" /> class.</summary>
		/// <param name="trademark">The trademark information. </param>
		// Token: 0x060020CF RID: 8399 RVA: 0x00089AF5 File Offset: 0x00087CF5
		public AssemblyTrademarkAttribute(string trademark)
		{
			this.<Trademark>k__BackingField = trademark;
		}
	}
}
