using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000251 RID: 593
	internal class Datatype_List : Datatype_anySimpleType
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x00075320 File Offset: 0x00073520
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			XmlSchemaType xmlSchemaType = null;
			XmlSchemaComplexType xmlSchemaComplexType = schemaType as XmlSchemaComplexType;
			XmlSchemaSimpleType xmlSchemaSimpleType;
			if (xmlSchemaComplexType != null)
			{
				do
				{
					xmlSchemaSimpleType = (xmlSchemaComplexType.BaseXmlSchemaType as XmlSchemaSimpleType);
					if (xmlSchemaSimpleType != null)
					{
						break;
					}
					xmlSchemaComplexType = (xmlSchemaComplexType.BaseXmlSchemaType as XmlSchemaComplexType);
					if (xmlSchemaComplexType == null)
					{
						break;
					}
				}
				while (xmlSchemaComplexType != XmlSchemaComplexType.AnyType);
			}
			else
			{
				xmlSchemaSimpleType = (schemaType as XmlSchemaSimpleType);
			}
			if (xmlSchemaSimpleType != null)
			{
				XmlSchemaSimpleTypeList xmlSchemaSimpleTypeList;
				for (;;)
				{
					xmlSchemaSimpleTypeList = (xmlSchemaSimpleType.Content as XmlSchemaSimpleTypeList);
					if (xmlSchemaSimpleTypeList != null)
					{
						break;
					}
					xmlSchemaSimpleType = (xmlSchemaSimpleType.BaseXmlSchemaType as XmlSchemaSimpleType);
					if (xmlSchemaSimpleType == null || xmlSchemaSimpleType == DatatypeImplementation.AnySimpleType)
					{
						goto IL_6D;
					}
				}
				xmlSchemaType = xmlSchemaSimpleTypeList.BaseItemType;
			}
			IL_6D:
			if (xmlSchemaType == null)
			{
				xmlSchemaType = DatatypeImplementation.GetSimpleTypeFromTypeCode(schemaType.Datatype.TypeCode);
			}
			return XmlListConverter.Create(xmlSchemaType.ValueConverter);
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000753B9 File Offset: 0x000735B9
		internal Datatype_List(DatatypeImplementation type, int minListSize)
		{
			this.itemType = type;
			this.minListSize = minListSize;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000753D0 File Offset: 0x000735D0
		internal override int Compare(object value1, object value2)
		{
			Array array = (Array)value1;
			Array array2 = (Array)value2;
			if (array.Length != array2.Length)
			{
				return -1;
			}
			XmlAtomicValue[] array3 = array as XmlAtomicValue[];
			if (array3 != null)
			{
				XmlAtomicValue[] array4 = array2 as XmlAtomicValue[];
				for (int i = 0; i < array3.Length; i++)
				{
					XmlSchemaType xmlType = array3[i].XmlType;
					if (xmlType != array4[i].XmlType || !xmlType.Datatype.IsEqual(array3[i].TypedValue, array4[i].TypedValue))
					{
						return -1;
					}
				}
				return 0;
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (this.itemType.Compare(array.GetValue(j), array2.GetValue(j)) != 0)
				{
					return -1;
				}
			}
			return 0;
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0007548F File Offset: 0x0007368F
		public override Type ValueType
		{
			get
			{
				return this.ListValueType;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00075497 File Offset: 0x00073697
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return this.itemType.TokenizedType;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x000754A4 File Offset: 0x000736A4
		internal override Type ListValueType
		{
			get
			{
				return this.itemType.ListValueType;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x000754B1 File Offset: 0x000736B1
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.listFacetsChecker;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x000754B8 File Offset: 0x000736B8
		public override XmlTypeCode TypeCode
		{
			get
			{
				return this.itemType.TypeCode;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000754CC File Offset: 0x000736CC
		internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			string text = value as string;
			typedValue = null;
			if (text != null)
			{
				return this.TryParseValue(text, nameTable, namespaceResolver, out typedValue);
			}
			Exception ex;
			try
			{
				object obj = this.ValueConverter.ChangeType(value, this.ValueType, namespaceResolver);
				Array array = obj as Array;
				bool hasLexicalFacets = this.itemType.HasLexicalFacets;
				bool hasValueFacets = this.itemType.HasValueFacets;
				FacetsChecker facetsChecker = this.itemType.FacetsChecker;
				XmlValueConverter valueConverter = this.itemType.ValueConverter;
				for (int i = 0; i < array.Length; i++)
				{
					object value2 = array.GetValue(i);
					if (hasLexicalFacets)
					{
						string text2 = (string)valueConverter.ChangeType(value2, typeof(string), namespaceResolver);
						ex = facetsChecker.CheckLexicalFacets(ref text2, this.itemType);
						if (ex != null)
						{
							return ex;
						}
					}
					if (hasValueFacets)
					{
						ex = facetsChecker.CheckValueFacets(value2, this.itemType);
						if (ex != null)
						{
							return ex;
						}
					}
				}
				if (this.HasLexicalFacets)
				{
					string text3 = (string)this.ValueConverter.ChangeType(obj, typeof(string), namespaceResolver);
					ex = DatatypeImplementation.listFacetsChecker.CheckLexicalFacets(ref text3, this);
					if (ex != null)
					{
						return ex;
					}
				}
				if (this.HasValueFacets)
				{
					ex = DatatypeImplementation.listFacetsChecker.CheckValueFacets(obj, this);
					if (ex != null)
					{
						return ex;
					}
				}
				typedValue = obj;
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

		// Token: 0x0600135B RID: 4955 RVA: 0x00075690 File Offset: 0x00073890
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.listFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				ArrayList arrayList = new ArrayList();
				object obj2;
				if (this.itemType.Variety == XmlSchemaDatatypeVariety.Union)
				{
					string[] array = XmlConvert.SplitString(s);
					for (int i = 0; i < array.Length; i++)
					{
						object obj;
						ex = this.itemType.TryParseValue(array[i], nameTable, nsmgr, out obj);
						if (ex != null)
						{
							return ex;
						}
						XsdSimpleValue xsdSimpleValue = (XsdSimpleValue)obj;
						arrayList.Add(new XmlAtomicValue(xsdSimpleValue.XmlType, xsdSimpleValue.TypedValue, nsmgr));
					}
					obj2 = arrayList.ToArray(typeof(XmlAtomicValue));
				}
				else
				{
					string[] array2 = XmlConvert.SplitString(s);
					for (int j = 0; j < array2.Length; j++)
					{
						ex = this.itemType.TryParseValue(array2[j], nameTable, nsmgr, out typedValue);
						if (ex != null)
						{
							return ex;
						}
						arrayList.Add(typedValue);
					}
					obj2 = arrayList.ToArray(this.itemType.ValueType);
				}
				if (arrayList.Count < this.minListSize)
				{
					return new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
				}
				ex = DatatypeImplementation.listFacetsChecker.CheckValueFacets(obj2, this);
				if (ex == null)
				{
					typedValue = obj2;
					return null;
				}
			}
			return ex;
		}

		// Token: 0x04000D4C RID: 3404
		private DatatypeImplementation itemType;

		// Token: 0x04000D4D RID: 3405
		private int minListSize;
	}
}
