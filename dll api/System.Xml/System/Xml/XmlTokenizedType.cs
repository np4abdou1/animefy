using System;

namespace System.Xml
{
	/// <summary>Represents the XML type for the string. This allows the string to be read as a particular XML type, for example a CDATA section type.</summary>
	// Token: 0x0200019A RID: 410
	public enum XmlTokenizedType
	{
		/// <summary>CDATA type.</summary>
		// Token: 0x04000A88 RID: 2696
		CDATA,
		/// <summary>ID type.</summary>
		// Token: 0x04000A89 RID: 2697
		ID,
		/// <summary>IDREF type.</summary>
		// Token: 0x04000A8A RID: 2698
		IDREF,
		/// <summary>IDREFS type.</summary>
		// Token: 0x04000A8B RID: 2699
		IDREFS,
		/// <summary>ENTITY type.</summary>
		// Token: 0x04000A8C RID: 2700
		ENTITY,
		/// <summary>ENTITIES type.</summary>
		// Token: 0x04000A8D RID: 2701
		ENTITIES,
		/// <summary>NMTOKEN type.</summary>
		// Token: 0x04000A8E RID: 2702
		NMTOKEN,
		/// <summary>NMTOKENS type.</summary>
		// Token: 0x04000A8F RID: 2703
		NMTOKENS,
		/// <summary>NOTATION type.</summary>
		// Token: 0x04000A90 RID: 2704
		NOTATION,
		/// <summary>ENUMERATION type.</summary>
		// Token: 0x04000A91 RID: 2705
		ENUMERATION,
		/// <summary>QName type.</summary>
		// Token: 0x04000A92 RID: 2706
		QName,
		/// <summary>NCName type.</summary>
		// Token: 0x04000A93 RID: 2707
		NCName,
		/// <summary>No type.</summary>
		// Token: 0x04000A94 RID: 2708
		None
	}
}
