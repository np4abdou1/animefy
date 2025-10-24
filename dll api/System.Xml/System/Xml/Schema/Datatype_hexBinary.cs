using System;

namespace System.Xml.Schema
{
	// Token: 0x0200026B RID: 619
	internal class Datatype_hexBinary : Datatype_anySimpleType
	{
		// Token: 0x060013E1 RID: 5089 RVA: 0x00075DF8 File Offset: 0x00073FF8
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlMiscConverter.Create(schemaType);
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0007617E File Offset: 0x0007437E
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.binaryFacetsChecker;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00076185 File Offset: 0x00074385
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.HexBinary;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x00076189 File Offset: 0x00074389
		public override Type ValueType
		{
			get
			{
				return Datatype_hexBinary.atomicValueType;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00076190 File Offset: 0x00074390
		internal override Type ListValueType
		{
			get
			{
				return Datatype_hexBinary.listValueType;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00076197 File Offset: 0x00074397
		internal override int Compare(object value1, object value2)
		{
			return base.Compare((byte[])value1, (byte[])value2);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000761AC File Offset: 0x000743AC
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.binaryFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				byte[] array = null;
				try
				{
					array = XmlConvert.FromBinHexString(s, false);
				}
				catch (ArgumentException ex)
				{
					return ex;
				}
				catch (XmlException ex)
				{
					return ex;
				}
				ex = DatatypeImplementation.binaryFacetsChecker.CheckValueFacets(array, this);
				if (ex == null)
				{
					typedValue = array;
					return null;
				}
			}
			return ex;
		}

		// Token: 0x04000D61 RID: 3425
		private static readonly Type atomicValueType = typeof(byte[]);

		// Token: 0x04000D62 RID: 3426
		private static readonly Type listValueType = typeof(byte[][]);
	}
}
