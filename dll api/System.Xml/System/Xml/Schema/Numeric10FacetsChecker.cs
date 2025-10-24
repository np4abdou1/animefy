using System;
using System.Collections;
using System.Globalization;

namespace System.Xml.Schema
{
	// Token: 0x02000294 RID: 660
	internal class Numeric10FacetsChecker : FacetsChecker
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x0007979C File Offset: 0x0007799C
		internal Numeric10FacetsChecker(decimal minVal, decimal maxVal)
		{
			this.minValue = minVal;
			this.maxValue = maxVal;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000797B4 File Offset: 0x000779B4
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			decimal value2 = datatype.ValueConverter.ToDecimal(value);
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000797D8 File Offset: 0x000779D8
		internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			XmlValueConverter valueConverter = datatype.ValueConverter;
			if (value > this.maxValue || value < this.minValue)
			{
				return new OverflowException(Res.GetString("Value '{0}' was either too large or too small for {1}.", new object[]
				{
					value.ToString(CultureInfo.InvariantCulture),
					datatype.TypeCodeString
				}));
			}
			if (restrictionFlags == (RestrictionFlags)0)
			{
				return null;
			}
			if ((restrictionFlags & RestrictionFlags.MaxInclusive) != (RestrictionFlags)0 && value > valueConverter.ToDecimal(restriction.MaxInclusive))
			{
				return new XmlSchemaException("The MaxInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MaxExclusive) != (RestrictionFlags)0 && value >= valueConverter.ToDecimal(restriction.MaxExclusive))
			{
				return new XmlSchemaException("The MaxExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinInclusive) != (RestrictionFlags)0 && value < valueConverter.ToDecimal(restriction.MinInclusive))
			{
				return new XmlSchemaException("The MinInclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.MinExclusive) != (RestrictionFlags)0 && value <= valueConverter.ToDecimal(restriction.MinExclusive))
			{
				return new XmlSchemaException("The MinExclusive constraint failed.", string.Empty);
			}
			if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration, valueConverter))
			{
				return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
			}
			return this.CheckTotalAndFractionDigits(value, restriction.TotalDigits, restriction.FractionDigits, (restrictionFlags & RestrictionFlags.TotalDigits) > (RestrictionFlags)0, (restrictionFlags & RestrictionFlags.FractionDigits) > (RestrictionFlags)0);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00079950 File Offset: 0x00077B50
		internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			decimal value2 = value;
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0007996C File Offset: 0x00077B6C
		internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			decimal value2 = value;
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00079988 File Offset: 0x00077B88
		internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			decimal value2 = value;
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000799A4 File Offset: 0x00077BA4
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration(datatype.ValueConverter.ToDecimal(value), enumeration, datatype.ValueConverter);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000799C0 File Offset: 0x00077BC0
		internal bool MatchEnumeration(decimal value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (value == valueConverter.ToDecimal(enumeration[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000799F8 File Offset: 0x00077BF8
		internal Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction)
		{
			decimal d = FacetsChecker.Power(10, totalDigits) - 1m;
			int num = 0;
			if (value < 0m)
			{
				value = decimal.Negate(value);
			}
			while (decimal.Truncate(value) != value)
			{
				value *= 10m;
				num++;
			}
			if (checkTotal && (value > d || num > totalDigits))
			{
				return new XmlSchemaException("The TotalDigits constraint failed.", string.Empty);
			}
			if (checkFraction && num > fractionDigits)
			{
				return new XmlSchemaException("The FractionDigits constraint failed.", string.Empty);
			}
			return null;
		}

		// Token: 0x04000DA2 RID: 3490
		private static readonly char[] signs = new char[]
		{
			'+',
			'-'
		};

		// Token: 0x04000DA3 RID: 3491
		private decimal maxValue;

		// Token: 0x04000DA4 RID: 3492
		private decimal minValue;
	}
}
