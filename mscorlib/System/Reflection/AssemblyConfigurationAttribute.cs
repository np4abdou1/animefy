using System;

namespace System.Reflection
{
	/// <summary>Specifies the build configuration, such as retail or debug, for an assembly.</summary>
	// Token: 0x02000483 RID: 1155
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyConfigurationAttribute" /> class.</summary>
		/// <param name="configuration">The assembly configuration. </param>
		// Token: 0x060020C4 RID: 8388 RVA: 0x00089A3B File Offset: 0x00087C3B
		public AssemblyConfigurationAttribute(string configuration)
		{
			this.<Configuration>k__BackingField = configuration;
		}
	}
}
