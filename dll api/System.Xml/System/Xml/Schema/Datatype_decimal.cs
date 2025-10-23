using System;

namespace System.Xml.Schema
{
	// Token: 0x0200025A RID: 602
	internal class Datatype_decimal : Datatype_anySimpleType
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x00075D2E File Offset: 0x00073F2E
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlNumeric10Converter.Create(schemaType);
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00075D36 File Offset: 0x00073F36
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_decimal.numeric10FacetsChecker;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0004E7A1 File Offset: 0x0004C9A1
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Decimal;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00075D3D File Offset: 0x00073F3D
		public override Type ValueType
		{
			get
			{
				return Datatype_decimal.atomicValueType;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00075D44 File Offset: 0x00073F44
		internal override Type ListValueType
		{
			get
			{
				return Datatype_decimal.listValueType;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00075D4B File Offset: 0x00073F4B
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace | RestrictionFlags.MaxInclusive | RestrictionFlags.MaxExclusive | RestrictionFlags.MinInclusive | RestrictionFlags.MinExclusive | RestrictionFlags.TotalDigits | RestrictionFlags.FractionDigits;
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00075D54 File Offset: 0x00073F54
		internal override int Compare(object value1, object value2)
		{
			return ((decimal)value1).CompareTo(value2);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00075D70 File Offset: 0x00073F70
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_decimal.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				decimal num;
				ex = XmlConvert.TryToDecimal(s, out num);
				if (ex == null)
				{
					ex = Datatype_decimal.numeric10FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D59 RID: 3417
		private static readonly Type atomicValueType = typeof(decimal);

		// Token: 0x04000D5A RID: 3418
		private static readonly Type listValueType = typeof(decimal[]);

		// Token: 0x04000D5B RID: 3419
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(decimal.MinValue, decimal.MaxValue);
	}
}
