using System;

namespace System.Reflection
{
	/// <summary>Defines a product name custom attribute for an assembly manifest.</summary>
	// Token: 0x0200048E RID: 1166
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyProductAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyProductAttribute" /> class.</summary>
		/// <param name="product">The product name information. </param>
		// Token: 0x060020CD RID: 8397 RVA: 0x00089AD7 File Offset: 0x00087CD7
		public AssemblyProductAttribute(string product)
		{
			this.<Product>k__BackingField = product;
		}
	}
}
