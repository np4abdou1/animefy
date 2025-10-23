using System;

namespace System.Resources
{
	/// <summary>Informs the resource manager of an app's default culture. This class cannot be inherited.</summary>
	// Token: 0x0200047C RID: 1148
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> class.</summary>
		/// <param name="cultureName">The name of the culture that the current assembly's neutral resources were written in. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="cultureName" /> parameter is <see langword="null" />. </exception>
		// Token: 0x060020BE RID: 8382 RVA: 0x000899BF File Offset: 0x00087BBF
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
			if (cultureName == null)
			{
				throw new ArgumentNullException("cultureName");
			}
			this.<CultureName>k__BackingField = cultureName;
			this.<Location>k__BackingField = UltimateResourceFallbackLocation.MainAssembly;
		}
	}
}
