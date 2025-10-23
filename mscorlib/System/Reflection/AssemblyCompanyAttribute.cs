using System;

namespace System.Reflection
{
	/// <summary>Defines a company name custom attribute for an assembly manifest.</summary>
	// Token: 0x02000482 RID: 1154
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyCompanyAttribute" /> class.</summary>
		/// <param name="company">The company name information. </param>
		// Token: 0x060020C3 RID: 8387 RVA: 0x00089A2C File Offset: 0x00087C2C
		public AssemblyCompanyAttribute(string company)
		{
			this.<Company>k__BackingField = company;
		}
	}
}
