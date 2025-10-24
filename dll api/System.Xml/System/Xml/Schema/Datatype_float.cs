using System;

namespace System.Xml.Schema
{
	// Token: 0x02000258 RID: 600
	internal class Datatype_float : Datatype_anySimpleType
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x00075BE6 File Offset: 0x00073DE6
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlNumeric2Converter.Create(schemaType);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00075BEE File Offset: 0x00073DEE
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.numeric2FacetsChecker;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00075BF5 File Offset: 0x00073DF5
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Float;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00075BF9 File Offset: 0x00073DF9
		public override Type ValueType
		{
			get
			{
				return Datatype_float.atomicValueType;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00075C00 File Offset: 0x00073E00
		internal override Type ListValueType
		{
			get
			{
				return Datatype_float.listValueType;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00075C07 File Offset: 0x00073E07
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace | RestrictionFlags.MaxInclusive | RestrictionFlags.MaxExclusive | RestrictionFlags.MinInclusive | RestrictionFlags.MinExclusive;
			}
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00075C10 File Offset: 0x00073E10
		internal override int Compare(object value1, object value2)
		{
			return ((float)value1).CompareTo(value2);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00075C2C File Offset: 0x00073E2C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.numeric2FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				float num;
				ex = XmlConvert.TryToSingle(s, out num);
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

		// Token: 0x04000D55 RID: 3413
		private static readonly Type atomicValueType = typeof(float);

		// Token: 0x04000D56 RID: 3414
		private static readonly Type listValueType = typeof(float[]);
	}
}
