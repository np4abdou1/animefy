using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000297 RID: 663
	internal class DateTimeFacetsChecker : FacetsChecker
	{
		// Token: 0x0600150A RID: 5386 RVA: 0x00079D98 File Offset: 0x00077F98
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			DateTime value2 = datatype.ValueConverter.ToDateTime(value);
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00079DBC File Offset: 0x00077FBC
		internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			if ((restrictionFlags & RestrictionFlags.MaxInclusive) != (RestrictionFlags)0 && datatype.Compare(value, (DateTime)restriction.MaxInclusive) > 0)
			{
				return new XmlSchemaException("The MaxInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MaxExclusive) != (RestrictionFlags)0 && datatype.Compare(value, (DateTime)restriction.MaxExclusive) >= 0)
			{
				return new XmlSchemaException("The MaxExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinInclusive) != (RestrictionFlags)0 && datatype.Compare(value, (DateTime)restriction.MinInclusive) < 0)
			{
				return new XmlSchemaException("The MinInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinExclusive) != (RestrictionFlags)0 && datatype.Compare(value, (DateTime)restriction.MinExclusive) <= 0)
			{
				return new XmlSchemaException("The MinExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration, datatype))
			{
				return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
			}
			return null;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00079EE1 File Offset: 0x000780E1
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration(datatype.ValueConverter.ToDateTime(value), enumeration, datatype);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00079EF8 File Offset: 0x000780F8
		private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (datatype.Compare(value, (DateTime)enumeration[i]) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}
}
