using System;

namespace System.Xml.Schema
{
	// Token: 0x02000259 RID: 601
	internal class Datatype_double : Datatype_anySimpleType
	{
		// Token: 0x0600139C RID: 5020 RVA: 0x00075BE6 File Offset: 0x00073DE6
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlNumeric2Converter.Create(schemaType);
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00075BEE File Offset: 0x00073DEE
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.numeric2FacetsChecker;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00075C96 File Offset: 0x00073E96
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Double;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00075C9A File Offset: 0x00073E9A
		public override Type ValueType
		{
			get
			{
				return Datatype_double.atomicValueType;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00075CA1 File Offset: 0x00073EA1
		internal override Type ListValueType
		{
			get
			{
				return Datatype_double.listValueType;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00075C07 File Offset: 0x00073E07
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace | RestrictionFlags.MaxInclusive | RestrictionFlags.MaxExclusive | RestrictionFlags.MinInclusive | RestrictionFlags.MinExclusive;
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00075CA8 File Offset: 0x00073EA8
		internal override int Compare(object value1, object value2)
		{
			return ((double)value1).CompareTo(value2);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00075CC4 File Offset: 0x00073EC4
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.numeric2FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				double num;
				ex = XmlConvert.TryToDouble(s, out num);
				if (ex == null)
				{
					ex = DatatypeImplementation.numeric2FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D57 RID: 3415
		private static readonly Type atomicValueType = typeof(double);

		// Token: 0x04000D58 RID: 3416
		private static readonly Type listValueType = typeof(double[]);
	}
}
