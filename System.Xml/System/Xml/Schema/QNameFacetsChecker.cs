using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000299 RID: 665
	internal class QNameFacetsChecker : FacetsChecker
	{
		// Token: 0x06001517 RID: 5399 RVA: 0x0007A1A4 File Offset: 0x000783A4
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			XmlQualifiedName value2 = (XmlQualifiedName)datatype.ValueConverter.ChangeType(value, typeof(XmlQualifiedName));
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0007A1D8 File Offset: 0x000783D8
		internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			if (restrictionFlags != (RestrictionFlags)0)
			{
				int length = value.ToString().Length;
				if ((restrictionFlags & RestrictionFlags.Length) != (RestrictionFlags)0 && restriction.Length != length)
				{
					return new XmlSchemaException("The actual length is not equal to the specified length.", string.Empty);
				}
				if ((restrictionFlags & RestrictionFlags.MinLength) != (RestrictionFlags)0 && length < restriction.MinLength)
				{
					return new XmlSchemaException("The actual length is less than the MinLength value.", string.Empty);
				}
				if ((restrictionFlags & RestrictionFlags.MaxLength) != (RestrictionFlags)0 && restriction.MaxLength < length)
				{
					return new XmlSchemaException("The actual length is greater than the MaxLength value.", string.Empty);
				}
				if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration))
				{
					return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
				}
			}
			return null;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0007A28B File Offset: 0x0007848B
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration((XmlQualifiedName)datatype.ValueConverter.ChangeType(value, typeof(XmlQualifiedName)), enumeration);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0007A2B0 File Offset: 0x000784B0
		private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (value.Equals((XmlQualifiedName)enumeration[i]))
				{
					return true;
				}
			}
			return false;
		}
	}
}
