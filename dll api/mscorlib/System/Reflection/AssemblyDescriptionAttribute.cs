using System;

namespace System.Reflection
{
	/// <summary>Provides a text description for an assembly.</summary>
	// Token: 0x02000488 RID: 1160
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDescriptionAttribute" /> class.</summary>
		/// <param name="description">The assembly description. </param>
		// Token: 0x060020C8 RID: 8392 RVA: 0x00089A77 File Offset: 0x00087C77
		public AssemblyDescriptionAttribute(string description)
		{
			this.<Description>k__BackingField = description;
		}
	}
}
