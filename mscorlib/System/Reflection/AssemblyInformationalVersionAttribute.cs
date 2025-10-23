using System;

namespace System.Reflection
{
	/// <summary>Defines additional version information for an assembly manifest.</summary>
	// Token: 0x0200048A RID: 1162
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyInformationalVersionAttribute" /> class.</summary>
		/// <param name="informationalVersion">The assembly version information. </param>
		// Token: 0x060020CA RID: 8394 RVA: 0x00089AA3 File Offset: 0x00087CA3
		public AssemblyInformationalVersionAttribute(string informationalVersion)
		{
			this.<InformationalVersion>k__BackingField = informationalVersion;
		}
	}
}
