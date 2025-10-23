using System;

namespace System.Xml.Schema
{
	// Token: 0x0200026C RID: 620
	internal class Datatype_base64Binary : Datatype_anySimpleType
	{
		// Token: 0x060013EC RID: 5100 RVA: 0x00075DF8 File Offset: 0x00073FF8
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlMiscConverter.Create(schemaType);
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0007617E File Offset: 0x0007437E
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.binaryFacetsChecker;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00076234 File Offset: 0x00074434
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Base64Binary;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00076238 File Offset: 0x00074438
		public override Type ValueType
		{
			get
			{
				return Datatype_base64Binary.atomicValueType;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0007623F File Offset: 0x0007443F
		internal override Type ListValueType
		{
			get
			{
				return Datatype_base64Binary.listValueType;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00076197 File Offset: 0x00074397
		internal override int Compare(object value1, object value2)
		{
			return base.Compare((byte[])value1, (byte[])value2);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00076248 File Offset: 0x00074448
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.binaryFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				byte[] array = null;
				try
				{
					array = Convert.FromBase64String(s);
				}
				catch (ArgumentException ex)
				{
					return ex;
				}
				catch (FormatException ex)
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

		// Token: 0x04000D63 RID: 3427
		private static readonly Type atomicValueType = typeof(byte[]);

		// Token: 0x04000D64 RID: 3428
		private static readonly Type listValueType = typeof(byte[][]);
	}
}
