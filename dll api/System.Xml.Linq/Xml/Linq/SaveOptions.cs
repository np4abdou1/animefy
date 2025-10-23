using System;

namespace System.Xml.Linq
{
	/// <summary>Specifies serialization options.</summary>
	// Token: 0x0200002E RID: 46
	[Flags]
	public enum SaveOptions
	{
		/// <summary>Format (indent) the XML while serializing.</summary>
		// Token: 0x040000C2 RID: 194
		None = 0,
		/// <summary>Preserve all insignificant white space while serializing.</summary>
		// Token: 0x040000C3 RID: 195
		DisableFormatting = 1,
		/// <summary>Remove the duplicate namespace declarations while serializing.</summary>
		// Token: 0x040000C4 RID: 196
		OmitDuplicateNamespaces = 2
	}
}
