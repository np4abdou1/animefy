using System;

namespace System.Xml.Schema
{
	// Token: 0x02000252 RID: 594
	internal class Datatype_union : Datatype_anySimpleType
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x000757B9 File Offset: 0x000739B9
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlUnionConverter.Create(schemaType);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000757C1 File Offset: 0x000739C1
		internal Datatype_union(XmlSchemaSimpleType[] types)
		{
			this.types = types;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000757D0 File Offset: 0x000739D0
		internal override int Compare(object value1, object value2)
		{
			XsdSimpleValue xsdSimpleValue = value1 as XsdSimpleValue;
			XsdSimpleValue xsdSimpleValue2 = value2 as XsdSimpleValue;
			if (xsdSimpleValue == null || xsdSimpleValue2 == null)
			{
				return -1;
			}
			XmlSchemaType xmlType = xsdSimpleValue.XmlType;
			XmlSchemaType xmlType2 = xsdSimpleValue2.XmlType;
			if (xmlType == xmlType2)
			{
				return xmlType.Datatype.Compare(xsdSimpleValue.TypedValue, xsdSimpleValue2.TypedValue);
			}
			return -1;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0007581E File Offset: 0x00073A1E
		public override Type ValueType
		{
			get
			{
				return Datatype_union.atomicValueType;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00048B41 File Offset: 0x00046D41
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.AnyAtomicType;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00075825 File Offset: 0x00073A25
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.unionFacetsChecker;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x0007582C File Offset: 0x00073A2C
		internal override Type ListValueType
		{
			get
			{
				return Datatype_union.listValueType;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00075833 File Offset: 0x00073A33
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.Enumeration;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x00075837 File Offset: 0x00073A37
		internal XmlSchemaSimpleType[] BaseMemberTypes
		{
			get
			{
				return this.types;
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00075840 File Offset: 0x00073A40
		internal bool HasAtomicMembers()
		{
			for (int i = 0; i < this.types.Length; i++)
			{
				if (this.types[i].Datatype.Variety == XmlSchemaDatatypeVariety.List)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00075878 File Offset: 0x00073A78
		internal bool IsUnionBaseOf(DatatypeImplementation derivedType)
		{
			for (int i = 0; i < this.types.Length; i++)
			{
				if (derivedType.IsDerivedFrom(this.types[i].Datatype))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x000758B0 File Offset: 0x00073AB0
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			XmlSchemaSimpleType xmlSchemaSimpleType = null;
			typedValue = null;
			Exception ex = DatatypeImplementation.unionFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				for (int i = 0; i < this.types.Length; i++)
				{
					if (this.types[i].Datatype.TryParseValue(s, nameTable, nsmgr, out typedValue) == null)
					{
						xmlSchemaSimpleType = this.types[i];
						break;
					}
				}
				if (xmlSchemaSimpleType == null)
				{
					ex = new XmlSchemaException("The value '{0}' is not valid according to any of the memberTypes of the union.", s);
				}
				else
				{
					typedValue = new XsdSimpleValue(xmlSchemaSimpleType, typedValue);
					ex = DatatypeImplementation.unionFacetsChecker.CheckValueFacets(typedValue, this);
					if (ex == null)
					{
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00075940 File Offset: 0x00073B40
		internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			typedValue = null;
			string text = value as string;
			if (text != null)
			{
				return this.TryParseValue(text, nameTable, nsmgr, out typedValue);
			}
			object obj = null;
			XmlSchemaSimpleType st = null;
			for (int i = 0; i < this.types.Length; i++)
			{
				if (this.types[i].Datatype.TryParseValue(value, nameTable, nsmgr, out obj) == null)
				{
					st = this.types[i];
					break;
				}
			}
			Exception ex;
			if (obj != null)
			{
				try
				{
					if (this.HasLexicalFacets)
					{
						string text2 = (string)this.ValueConverter.ChangeType(obj, typeof(string), nsmgr);
						ex = DatatypeImplementation.unionFacetsChecker.CheckLexicalFacets(ref text2, this);
						if (ex != null)
						{
							return ex;
						}
					}
					typedValue = new XsdSimpleValue(st, obj);
					if (this.HasValueFacets)
					{
						ex = DatatypeImplementation.unionFacetsChecker.CheckValueFacets(typedValue, this);
						if (ex != null)
						{
							return ex;
						}
					}
					return null;
				}
				catch (FormatException ex)
				{
				}
				catch (InvalidCastException ex)
				{
				}
				catch (OverflowException ex)
				{
				}
				catch (ArgumentException ex)
				{
				}
				return ex;
			}
			ex = new XmlSchemaException("The value '{0}' is not valid according to any of the memberTypes of the union.", value.ToString());
			return ex;
		}

		// Token: 0x04000D4E RID: 3406
		private static readonly Type atomicValueType = typeof(object);

		// Token: 0x04000D4F RID: 3407
		private static readonly Type listValueType = typeof(object[]);

		// Token: 0x04000D50 RID: 3408
		private XmlSchemaSimpleType[] types;
	}
}
