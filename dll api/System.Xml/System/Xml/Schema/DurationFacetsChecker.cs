using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000296 RID: 662
	internal class DurationFacetsChecker : FacetsChecker
	{
		// Token: 0x06001505 RID: 5381 RVA: 0x00079C24 File Offset: 0x00077E24
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			TimeSpan value2 = (TimeSpan)datatype.ValueConverter.ChangeType(value, typeof(TimeSpan));
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00079C58 File Offset: 0x00077E58
		internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			if ((restrictionFlags & RestrictionFlags.MaxInclusive) != (RestrictionFlags)0 && TimeSpan.Compare(value, (TimeSpan)restriction.MaxInclusive) > 0)
			{
				return new XmlSchemaException("The MaxInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MaxExclusive) != (RestrictionFlags)0 && TimeSpan.Compare(value, (TimeSpan)restriction.MaxExclusive) >= 0)
			{
				return new XmlSchemaException("The MaxExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinInclusive) != (RestrictionFlags)0 && TimeSpan.Compare(value, (TimeSpan)restriction.MinInclusive) < 0)
			{
				return new XmlSchemaException("The MinInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinExclusive) != (RestrictionFlags)0 && TimeSpan.Compare(value, (TimeSpan)restriction.MinExclusive) <= 0)
			{
				return new XmlSchemaException("The MinExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration))
			{
				return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
			}
			return null;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00079D50 File Offset: 0x00077F50
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration((TimeSpan)value, enumeration);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00079D60 File Offset: 0x00077F60
		private bool MatchEnumeration(TimeSpan value, ArrayList enumeration)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (TimeSpan.Compare(value, (TimeSpan)enumeration[i]) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}
}
