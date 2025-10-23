using System;

namespace System.Reflection
{
	/// <summary>Specifies the name of a file containing the key pair used to generate a strong name.</summary>
	// Token: 0x0200048B RID: 1163
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see langword="AssemblyKeyFileAttribute" /> class with the name of the file containing the key pair to generate a strong name for the assembly being attributed.</summary>
		/// <param name="keyFile">The name of the file containing the key pair. </param>
		// Token: 0x060020CB RID: 8395 RVA: 0x00089AB2 File Offset: 0x00087CB2
		public AssemblyKeyFileAttribute(string keyFile)
		{
			this.<KeyFile>k__BackingField = keyFile;
		}
	}
}
