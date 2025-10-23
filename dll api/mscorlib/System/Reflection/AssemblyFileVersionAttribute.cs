using System;

namespace System.Reflection
{
	/// <summary>Instructs a compiler to use a specific version number for the Win32 file version resource. The Win32 file version is not required to be the same as the assembly's version number.</summary>
	// Token: 0x02000489 RID: 1161
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFileVersionAttribute" /> class, specifying the file version.</summary>
		/// <param name="version">The file version. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="version" /> is <see langword="null" />. </exception>
		// Token: 0x060020C9 RID: 8393 RVA: 0x00089A86 File Offset: 0x00087C86
		public AssemblyFileVersionAttribute(string version)
		{
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			this.<Version>k__BackingField = version;
		}
	}
}
