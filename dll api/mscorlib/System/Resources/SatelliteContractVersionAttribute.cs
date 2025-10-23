using System;

namespace System.Resources
{
	/// <summary>Instructs a <see cref="T:System.Resources.ResourceManager" /> object to ask for a particular version of a satellite assembly.</summary>
	// Token: 0x0200047D RID: 1149
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> class.</summary>
		/// <param name="version">A string that specifies the version of the satellite assemblies to load. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="version" /> parameter is <see langword="null" />. </exception>
		// Token: 0x060020BF RID: 8383 RVA: 0x000899E3 File Offset: 0x00087BE3
		public SatelliteContractVersionAttribute(string version)
		{
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			this.<Version>k__BackingField = version;
		}
	}
}
