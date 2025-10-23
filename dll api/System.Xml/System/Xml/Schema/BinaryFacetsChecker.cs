﻿using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200029B RID: 667
	internal class BinaryFacetsChecker : FacetsChecker
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x0007A2E8 File Offset: 0x000784E8
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			byte[] value2 = (byte[])value;
			return this.CheckValueFacets(value2, datatype);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0007A304 File Offset: 0x00078504
		internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
		{
			RestrictionFacets restriction = datatype.Restriction;
			int num = value.Length;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			if (restrictionFlags != (RestrictionFlags)0)
			{
				if ((restrictionFlags & RestrictionFlags.Length) != (RestrictionFlags)0 && restriction.Length != num)
				{
					return new XmlSchemaException("The actual length is not equal to the specified length.", string.Empty);
				}
				if ((restrictionFlags & RestrictionFlags.MinLength) != (RestrictionFlags)0 && num < restriction.MinLength)
				{
					return new XmlSchemaException("The actual length is less than the MinLength value.", string.Empty);
				}
				if ((restrictionFlags & RestrictionFlags.MaxLength) != (RestrictionFlags)0 && restriction.MaxLength < num)
				{
					return new XmlSchemaException("The actual length is greater than the MaxLength value.", string.Empty);
				}
				if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration, datatype))
				{
					return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
				}
			}
			return null;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0007A3B0 File Offset: 0x000785B0
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration((byte[])value, enumeration, datatype);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0007A3C0 File Offset: 0x000785C0
		private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			for (int i = 0; i < enumeration.Count; i++)
			{
				if (datatype.Compare(value, (byte[])enumeration[i]) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}
}
