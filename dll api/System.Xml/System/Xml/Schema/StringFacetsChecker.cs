using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

namespace System.Xml.Schema
{
	// Token: 0x02000298 RID: 664
	internal class StringFacetsChecker : FacetsChecker
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00079F38 File Offset: 0x00078138
		private static Regex LanguagePattern
		{
			get
			{
				if (StringFacetsChecker.languagePattern == null)
				{
					Regex value = new Regex("^([a-zA-Z]{1,8})(-[a-zA-Z0-9]{1,8})*$", RegexOptions.None);
					Interlocked.CompareExchange<Regex>(ref StringFacetsChecker.languagePattern, value, null);
				}
				return StringFacetsChecker.languagePattern;
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00079F6C File Offset: 0x0007816C
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			string value2 = datatype.ValueConverter.ToString(value);
			return this.CheckValueFacets(value2, datatype, true);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00079F8F File Offset: 0x0007818F
		internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			return this.CheckValueFacets(value, datatype, true);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00079F9C File Offset: 0x0007819C
		internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri)
		{
			int length = value.Length;
			RestrictionFacets restriction = datatype.Restriction;
			RestrictionFlags restrictionFlags = (restriction != null) ? restriction.Flags : ((RestrictionFlags)0);
			Exception ex = this.CheckBuiltInFacets(value, datatype.TypeCode, verifyUri);
			if (ex != null)
			{
				return ex;
			}
			if (restrictionFlags != (RestrictionFlags)0)
			{
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
				if ((restrictionFlags & RestrictionFlags.Enumeration) != (RestrictionFlags)0 && !this.MatchEnumeration(value, restriction.Enumeration, datatype))
				{
					return new XmlSchemaException("The Enumeration constraint failed.", string.Empty);
				}
			}
			return null;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0007A05F File Offset: 0x0007825F
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return this.MatchEnumeration(datatype.ValueConverter.ToString(value), enumeration, datatype);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0007A078 File Offset: 0x00078278
		private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			if (datatype.TypeCode == XmlTypeCode.AnyUri)
			{
				for (int i = 0; i < enumeration.Count; i++)
				{
					if (value.Equals(((Uri)enumeration[i]).OriginalString))
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < enumeration.Count; j++)
				{
					if (value.Equals((string)enumeration[j]))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0007A0E8 File Offset: 0x000782E8
		private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri)
		{
			Exception result = null;
			switch (typeCode)
			{
			case XmlTypeCode.AnyUri:
				if (verifyUri)
				{
					Uri uri;
					result = XmlConvert.TryToUri(s, out uri);
				}
				break;
			case XmlTypeCode.NormalizedString:
				result = XmlConvert.TryVerifyNormalizedString(s);
				break;
			case XmlTypeCode.Token:
				result = XmlConvert.TryVerifyTOKEN(s);
				break;
			case XmlTypeCode.Language:
				if (s == null || s.Length == 0)
				{
					return new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
				}
				if (!StringFacetsChecker.LanguagePattern.IsMatch(s))
				{
					return new XmlSchemaException("'{0}' is an invalid language identifier.", string.Empty);
				}
				break;
			case XmlTypeCode.NmToken:
				result = XmlConvert.TryVerifyNMTOKEN(s);
				break;
			case XmlTypeCode.Name:
				result = XmlConvert.TryVerifyName(s);
				break;
			case XmlTypeCode.NCName:
			case XmlTypeCode.Id:
			case XmlTypeCode.Idref:
			case XmlTypeCode.Entity:
				result = XmlConvert.TryVerifyNCName(s);
				break;
			}
			return result;
		}

		// Token: 0x04000DA5 RID: 3493
		private static Regex languagePattern;
	}
}
