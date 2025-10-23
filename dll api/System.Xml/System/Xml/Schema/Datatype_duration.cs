using System;

namespace System.Xml.Schema
{
	// Token: 0x0200025B RID: 603
	internal class Datatype_duration : Datatype_anySimpleType
	{
		// Token: 0x060013B2 RID: 5042 RVA: 0x00075DF8 File Offset: 0x00073FF8
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlMiscConverter.Create(schemaType);
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00075E00 File Offset: 0x00074000
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.durationFacetsChecker;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0004750B File Offset: 0x0004570B
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Duration;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00075E07 File Offset: 0x00074007
		public override Type ValueType
		{
			get
			{
				return Datatype_duration.atomicValueType;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00075E0E File Offset: 0x0007400E
		internal override Type ListValueType
		{
			get
			{
				return Datatype_duration.listValueType;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00075C07 File Offset: 0x00073E07
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace | RestrictionFlags.MaxInclusive | RestrictionFlags.MaxExclusive | RestrictionFlags.MinInclusive | RestrictionFlags.MinExclusive;
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00075E18 File Offset: 0x00074018
		internal override int Compare(object value1, object value2)
		{
			return ((TimeSpan)value1).CompareTo(value2);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00075E34 File Offset: 0x00074034
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			if (s == null || s.Length == 0)
			{
				return new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
			}
			Exception ex = DatatypeImplementation.durationFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				TimeSpan timeSpan;
				ex = XmlConvert.TryToTimeSpan(s, out timeSpan);
				if (ex == null)
				{
					ex = DatatypeImplementation.durationFacetsChecker.CheckValueFacets(timeSpan, this);
					if (ex == null)
					{
						typedValue = timeSpan;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D5C RID: 3420
		private static readonly Type atomicValueType = typeof(TimeSpan);

		// Token: 0x04000D5D RID: 3421
		private static readonly Type listValueType = typeof(TimeSpan[]);
	}
}
