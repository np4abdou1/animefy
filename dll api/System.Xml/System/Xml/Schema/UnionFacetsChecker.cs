using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200029D RID: 669
	internal class UnionFacetsChecker : FacetsChecker
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x0007A4E4 File Offset: 0x000786E4
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			if ((((restriction != null && restriction.Flags != (RestrictionFlags)0) ? 1 : 0) & 16) != 0 && !this.MatchEnumeration(value, restriction.Enumeration, datatype))
			{
				return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
			}
			return null;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0007A52C File Offset: 0x0007872C
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (datatype.Compare(value, enumeration[i]) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}
}
