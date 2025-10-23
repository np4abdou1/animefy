using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace System.Xml.Schema
{
	/// <summary>The <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> class is an abstract class for mapping XML Schema definition language (XSD) types to Common Language Runtime (CLR) types.</summary>
	// Token: 0x020002E6 RID: 742
	public abstract class XmlSchemaDatatype
	{
		/// <summary>When overridden in a derived class, gets the Common Language Runtime (CLR) type of the item.</summary>
		/// <returns>The Common Language Runtime (CLR) type of the item.</returns>
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060018D0 RID: 6352
		public abstract Type ValueType { get; }

		/// <summary>When overridden in a derived class, gets the type for the <see langword="string" /> as specified in the World Wide Web Consortium (W3C) XML 1.0 specification.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlTokenizedType" /> value for the <see langword="string" />.</returns>
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060018D1 RID: 6353
		public abstract XmlTokenizedType TokenizedType { get; }

		/// <summary>When overridden in a derived class, validates the <see langword="string" /> specified against a built-in or user-defined simple type.</summary>
		/// <param name="s">The <see langword="string" /> to validate against the simple type.</param>
		/// <param name="nameTable">The <see cref="T:System.Xml.XmlNameTable" /> to use for atomization while parsing the <see langword="string" /> if this <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> object represents the xs:NCName type. </param>
		/// <param name="nsmgr">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object to use while parsing the <see langword="string" /> if this <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> object represents the xs:QName type.</param>
		/// <returns>An <see cref="T:System.Object" /> that can be cast safely to the type returned by the <see cref="P:System.Xml.Schema.XmlSchemaDatatype.ValueType" /> property.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The input value is not a valid instance of this W3C XML Schema type.</exception>
		/// <exception cref="T:System.ArgumentNullException">The value to parse cannot be <see langword="null" />.</exception>
		// Token: 0x060018D2 RID: 6354
		public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaDatatypeVariety" /> value for the simple type.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaDatatypeVariety" /> value for the simple type.</returns>
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual XmlSchemaDatatypeVariety Variety
		{
			get
			{
				return XmlSchemaDatatypeVariety.Atomic;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlTypeCode" /> value for the simple type.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlTypeCode" /> value for the simple type.</returns>
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.None;
			}
		}

		/// <summary>The <see cref="M:System.Xml.Schema.XmlSchemaDatatype.IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype)" /> method always returns <see langword="false" />.</summary>
		/// <param name="datatype">The <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />.</param>
		/// <returns>Always returns <see langword="false" />.</returns>
		// Token: 0x060018D5 RID: 6357 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			return false;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060018D6 RID: 6358
		internal abstract bool HasLexicalFacets { get; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060018D7 RID: 6359
		internal abstract bool HasValueFacets { get; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060018D8 RID: 6360
		internal abstract XmlValueConverter ValueConverter { get; }

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060018D9 RID: 6361
		internal abstract RestrictionFacets Restriction { get; }

		// Token: 0x060018DA RID: 6362
		internal abstract int Compare(object value1, object value2);

		// Token: 0x060018DB RID: 6363
		internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

		// Token: 0x060018DC RID: 6364
		internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

		// Token: 0x060018DD RID: 6365
		internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060018DE RID: 6366
		internal abstract FacetsChecker FacetsChecker { get; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060018DF RID: 6367
		internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

		// Token: 0x060018E0 RID: 6368
		internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

		// Token: 0x060018E1 RID: 6369
		internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

		// Token: 0x060018E2 RID: 6370
		internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

		// Token: 0x060018E3 RID: 6371
		internal abstract bool IsEqual(object o1, object o2);

		// Token: 0x060018E4 RID: 6372
		internal abstract bool IsComparable(XmlSchemaDatatype dtype);

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x000971E8 File Offset: 0x000953E8
		internal string TypeCodeString
		{
			get
			{
				string result = string.Empty;
				XmlTypeCode typeCode = this.TypeCode;
				switch (this.Variety)
				{
				case XmlSchemaDatatypeVariety.Atomic:
					if (typeCode == XmlTypeCode.AnyAtomicType)
					{
						result = "anySimpleType";
					}
					else
					{
						result = this.TypeCodeToString(typeCode);
					}
					break;
				case XmlSchemaDatatypeVariety.List:
					if (typeCode == XmlTypeCode.AnyAtomicType)
					{
						result = "List of Union";
					}
					else
					{
						result = "List of " + this.TypeCodeToString(typeCode);
					}
					break;
				case XmlSchemaDatatypeVariety.Union:
					result = "Union";
					break;
				}
				return result;
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0009725C File Offset: 0x0009545C
		internal string TypeCodeToString(XmlTypeCode typeCode)
		{
			switch (typeCode)
			{
			case XmlTypeCode.None:
				return "None";
			case XmlTypeCode.Item:
				return "AnyType";
			case XmlTypeCode.AnyAtomicType:
				return "AnyAtomicType";
			case XmlTypeCode.String:
				return "String";
			case XmlTypeCode.Boolean:
				return "Boolean";
			case XmlTypeCode.Decimal:
				return "Decimal";
			case XmlTypeCode.Float:
				return "Float";
			case XmlTypeCode.Double:
				return "Double";
			case XmlTypeCode.Duration:
				return "Duration";
			case XmlTypeCode.DateTime:
				return "DateTime";
			case XmlTypeCode.Time:
				return "Time";
			case XmlTypeCode.Date:
				return "Date";
			case XmlTypeCode.GYearMonth:
				return "GYearMonth";
			case XmlTypeCode.GYear:
				return "GYear";
			case XmlTypeCode.GMonthDay:
				return "GMonthDay";
			case XmlTypeCode.GDay:
				return "GDay";
			case XmlTypeCode.GMonth:
				return "GMonth";
			case XmlTypeCode.HexBinary:
				return "HexBinary";
			case XmlTypeCode.Base64Binary:
				return "Base64Binary";
			case XmlTypeCode.AnyUri:
				return "AnyUri";
			case XmlTypeCode.QName:
				return "QName";
			case XmlTypeCode.Notation:
				return "Notation";
			case XmlTypeCode.NormalizedString:
				return "NormalizedString";
			case XmlTypeCode.Token:
				return "Token";
			case XmlTypeCode.Language:
				return "Language";
			case XmlTypeCode.NmToken:
				return "NmToken";
			case XmlTypeCode.Name:
				return "Name";
			case XmlTypeCode.NCName:
				return "NCName";
			case XmlTypeCode.Id:
				return "Id";
			case XmlTypeCode.Idref:
				return "Idref";
			case XmlTypeCode.Entity:
				return "Entity";
			case XmlTypeCode.Integer:
				return "Integer";
			case XmlTypeCode.NonPositiveInteger:
				return "NonPositiveInteger";
			case XmlTypeCode.NegativeInteger:
				return "NegativeInteger";
			case XmlTypeCode.Long:
				return "Long";
			case XmlTypeCode.Int:
				return "Int";
			case XmlTypeCode.Short:
				return "Short";
			case XmlTypeCode.Byte:
				return "Byte";
			case XmlTypeCode.NonNegativeInteger:
				return "NonNegativeInteger";
			case XmlTypeCode.UnsignedLong:
				return "UnsignedLong";
			case XmlTypeCode.UnsignedInt:
				return "UnsignedInt";
			case XmlTypeCode.UnsignedShort:
				return "UnsignedShort";
			case XmlTypeCode.UnsignedByte:
				return "UnsignedByte";
			case XmlTypeCode.PositiveInteger:
				return "PositiveInteger";
			}
			return typeCode.ToString();
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00097460 File Offset: 0x00095660
		internal static string ConcatenatedToString(object value)
		{
			Type type = value.GetType();
			string result = string.Empty;
			if (type == typeof(IEnumerable) && type != typeof(string))
			{
				StringBuilder stringBuilder = new StringBuilder();
				IEnumerator enumerator = (value as IEnumerable).GetEnumerator();
				if (enumerator.MoveNext())
				{
					stringBuilder.Append("{");
					object obj = enumerator.Current;
					if (obj is IFormattable)
					{
						stringBuilder.Append(((IFormattable)obj).ToString("", CultureInfo.InvariantCulture));
					}
					else
					{
						stringBuilder.Append(obj.ToString());
					}
					while (enumerator.MoveNext())
					{
						stringBuilder.Append(" , ");
						obj = enumerator.Current;
						if (obj is IFormattable)
						{
							stringBuilder.Append(((IFormattable)obj).ToString("", CultureInfo.InvariantCulture));
						}
						else
						{
							stringBuilder.Append(obj.ToString());
						}
					}
					stringBuilder.Append("}");
					result = stringBuilder.ToString();
				}
			}
			else if (value is IFormattable)
			{
				result = ((IFormattable)value).ToString("", CultureInfo.InvariantCulture);
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0009759C File Offset: 0x0009579C
		internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			return DatatypeImplementation.FromXmlTokenizedType(token);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000975A4 File Offset: 0x000957A4
		internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			return DatatypeImplementation.FromXmlTokenizedTypeXsd(token);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000975AC File Offset: 0x000957AC
		internal static XmlSchemaDatatype FromXdrName(string name)
		{
			return DatatypeImplementation.FromXdrName(name);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000975B4 File Offset: 0x000957B4
		internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType)
		{
			return DatatypeImplementation.DeriveByUnion(types, schemaType);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000975C0 File Offset: 0x000957C0
		internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames)
		{
			int num = 5;
			bool flag = false;
			if (uri.Length > 5 && uri.StartsWith("uuid:", StringComparison.Ordinal))
			{
				flag = true;
			}
			else if (uri.Length > 9 && uri.StartsWith("urn:uuid:", StringComparison.Ordinal))
			{
				flag = true;
				num = 9;
			}
			string text;
			if (flag)
			{
				text = nameTable.Add(uri.Substring(0, num) + uri.Substring(num, uri.Length - num).ToUpper(CultureInfo.InvariantCulture));
			}
			else
			{
				text = uri;
			}
			if (Ref.Equal(schemaNames.NsDataTypeAlias, text) || Ref.Equal(schemaNames.NsDataTypeOld, text))
			{
				text = schemaNames.NsDataType;
			}
			else if (Ref.Equal(schemaNames.NsXdrAlias, text))
			{
				text = schemaNames.NsXdr;
			}
			return text;
		}
	}
}
