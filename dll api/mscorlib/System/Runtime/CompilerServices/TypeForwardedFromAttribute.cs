using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Specifies a source <see cref="T:System.Type" /> in another assembly. </summary>
	// Token: 0x02000455 RID: 1109
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.TypeForwardedFromAttribute" /> class. </summary>
		/// <param name="assemblyFullName">The source <see cref="T:System.Type" /> in another assembly. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyFullName" /> is <see langword="null" /> or empty.</exception>
		// Token: 0x0600201F RID: 8223 RVA: 0x0008800C File Offset: 0x0008620C
		public TypeForwardedFromAttribute(string assemblyFullName)
		{
			if (string.IsNullOrEmpty(assemblyFullName))
			{
				throw new ArgumentNullException("assemblyFullName");
			}
			this.AssemblyFullName = assemblyFullName;
		}

		/// <summary>Gets the assembly-qualified name of the source type.</summary>
		/// <returns>The assembly-qualified name of the source type.</returns>
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0008802E File Offset: 0x0008622E
		public string AssemblyFullName { get; }
	}
}
