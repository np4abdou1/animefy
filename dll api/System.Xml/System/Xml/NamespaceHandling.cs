using System;

namespace System.Xml
{
	/// <summary>Specifies whether to remove duplicate namespace declarations in the <see cref="T:System.Xml.XmlWriter" />. </summary>
	// Token: 0x02000036 RID: 54
	[Flags]
	public enum NamespaceHandling
	{
		/// <summary>Specifies that duplicate namespace declarations will not be removed.</summary>
		// Token: 0x04000124 RID: 292
		Default = 0,
		/// <summary>Specifies that duplicate namespace declarations will be removed. For the duplicate namespace to be removed, the prefix and the namespace must match.</summary>
		// Token: 0x04000125 RID: 293
		OmitDuplicates = 1
	}
}
