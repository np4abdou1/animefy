using System;

namespace System.Reflection
{
	/// <summary>Defines a key/value metadata pair for the decorated assembly.</summary>
	// Token: 0x0200048C RID: 1164
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyMetadataAttribute" /> class by using the specified metadata key and value.</summary>
		/// <param name="key">The metadata key.</param>
		/// <param name="value">The metadata value.</param>
		// Token: 0x060020CC RID: 8396 RVA: 0x00089AC1 File Offset: 0x00087CC1
		public AssemblyMetadataAttribute(string key, string value)
		{
			this.<Key>k__BackingField = key;
			this.<Value>k__BackingField = value;
		}
	}
}
