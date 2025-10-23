using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000295 RID: 661
	internal class Numeric2FacetsChecker : FacetsChecker
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x00079AA4 File Offset: 0x00077CA4
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			double value2 = datatype.ValueConverter.ToDouble(value);
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00079AC8 File Offset: 0x00077CC8
		internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			XmlValueConverter valueConverter = datatype.ValueConverter;
			if ((restrictionFlags & RestrictionFlags.MaxInclusive) != (RestrictionFlags)0 && value > valueConverter.ToDouble(restriction.MaxInclusive))
			{
				return new XmlSchemaException("The MaxInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MaxExclusive) != (RestrictionFlags)0 && value >= valueConverter.ToDouble(restriction.MaxExclusive))
			{
				return new XmlSchemaException("The MaxExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinInclusive) != (RestrictionFlags)0 && value < valueConverter.ToDouble(restriction.MinInclusive))
			{
				return new XmlSchemaException("The MinInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinExclusive) != (RestrictionFlags)0 && value <= valueConverter.ToDouble(restriction.MinExclusive))
			{
				return new XmlSchemaException("The MinExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration, valueConverter))
			{
				return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
			}
			return null;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00079BB4 File Offset: 0x00077DB4
		internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			double value2 = (double)value;
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00079BCC File Offset: 0x00077DCC
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration(datatype.ValueConverter.ToDouble(value), enumeration, datatype.ValueConverter);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00079BE8 File Offset: 0x00077DE8
		private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (value == valueConverter.ToDouble(enumeration[i]))
				{
					return true;
				}
			}
			return false;
		}
	}
}
