using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200024F RID: 591
	internal abstract class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x0600131F RID: 4895 RVA: 0x00073DFC File Offset: 0x00071FFC
		static DatatypeImplementation()
		{
			DatatypeImplementation[] array = new DatatypeImplementation[13];
			array[0] = DatatypeImplementation.c_string;
			array[1] = DatatypeImplementation.c_ID;
			array[2] = DatatypeImplementation.c_IDREF;
			array[3] = DatatypeImplementation.c_IDREFS;
			array[4] = DatatypeImplementation.c_ENTITY;
			array[5] = DatatypeImplementation.c_ENTITIES;
			array[6] = DatatypeImplementation.c_NMTOKEN;
			array[7] = DatatypeImplementation.c_NMTOKENS;
			array[8] = DatatypeImplementation.c_NOTATION;
			array[9] = DatatypeImplementation.c_ENUMERATION;
			array[10] = DatatypeImplementation.c_QNameXdr;
			array[11] = DatatypeImplementation.c_NCName;
			DatatypeImplementation.c_tokenizedTypes = array;
			DatatypeImplementation[] array2 = new DatatypeImplementation[13];
			array2[0] = DatatypeImplementation.c_string;
			array2[1] = DatatypeImplementation.c_ID;
			array2[2] = DatatypeImplementation.c_IDREF;
			array2[3] = DatatypeImplementation.c_IDREFS;
			array2[4] = DatatypeImplementation.c_ENTITY;
			array2[5] = DatatypeImplementation.c_ENTITIES;
			array2[6] = DatatypeImplementation.c_NMTOKEN;
			array2[7] = DatatypeImplementation.c_NMTOKENS;
			array2[8] = DatatypeImplementation.c_NOTATION;
			array2[9] = DatatypeImplementation.c_ENUMERATION;
			array2[10] = DatatypeImplementation.c_QName;
			array2[11] = DatatypeImplementation.c_NCName;
			DatatypeImplementation.c_tokenizedTypesXsd = array2;
			DatatypeImplementation.c_XdrTypes = new DatatypeImplementation.SchemaDatatypeMap[]
			{
				new DatatypeImplementation.SchemaDatatypeMap("bin.base64", DatatypeImplementation.c_base64Binary),
				new DatatypeImplementation.SchemaDatatypeMap("bin.hex", DatatypeImplementation.c_hexBinary),
				new DatatypeImplementation.SchemaDatatypeMap("boolean", DatatypeImplementation.c_boolean),
				new DatatypeImplementation.SchemaDatatypeMap("char", DatatypeImplementation.c_char),
				new DatatypeImplementation.SchemaDatatypeMap("date", DatatypeImplementation.c_date),
				new DatatypeImplementation.SchemaDatatypeMap("dateTime", DatatypeImplementation.c_dateTimeNoTz),
				new DatatypeImplementation.SchemaDatatypeMap("dateTime.tz", DatatypeImplementation.c_dateTimeTz),
				new DatatypeImplementation.SchemaDatatypeMap("decimal", DatatypeImplementation.c_decimal),
				new DatatypeImplementation.SchemaDatatypeMap("entities", DatatypeImplementation.c_ENTITIES),
				new DatatypeImplementation.SchemaDatatypeMap("entity", DatatypeImplementation.c_ENTITY),
				new DatatypeImplementation.SchemaDatatypeMap("enumeration", DatatypeImplementation.c_ENUMERATION),
				new DatatypeImplementation.SchemaDatatypeMap("fixed.14.4", DatatypeImplementation.c_fixed),
				new DatatypeImplementation.SchemaDatatypeMap("float", DatatypeImplementation.c_doubleXdr),
				new DatatypeImplementation.SchemaDatatypeMap("float.ieee.754.32", DatatypeImplementation.c_floatXdr),
				new DatatypeImplementation.SchemaDatatypeMap("float.ieee.754.64", DatatypeImplementation.c_doubleXdr),
				new DatatypeImplementation.SchemaDatatypeMap("i1", DatatypeImplementation.c_byte),
				new DatatypeImplementation.SchemaDatatypeMap("i2", DatatypeImplementation.c_short),
				new DatatypeImplementation.SchemaDatatypeMap("i4", DatatypeImplementation.c_int),
				new DatatypeImplementation.SchemaDatatypeMap("i8", DatatypeImplementation.c_long),
				new DatatypeImplementation.SchemaDatatypeMap("id", DatatypeImplementation.c_ID),
				new DatatypeImplementation.SchemaDatatypeMap("idref", DatatypeImplementation.c_IDREF),
				new DatatypeImplementation.SchemaDatatypeMap("idrefs", DatatypeImplementation.c_IDREFS),
				new DatatypeImplementation.SchemaDatatypeMap("int", DatatypeImplementation.c_int),
				new DatatypeImplementation.SchemaDatatypeMap("nmtoken", DatatypeImplementation.c_NMTOKEN),
				new DatatypeImplementation.SchemaDatatypeMap("nmtokens", DatatypeImplementation.c_NMTOKENS),
				new DatatypeImplementation.SchemaDatatypeMap("notation", DatatypeImplementation.c_NOTATION),
				new DatatypeImplementation.SchemaDatatypeMap("number", DatatypeImplementation.c_doubleXdr),
				new DatatypeImplementation.SchemaDatatypeMap("r4", DatatypeImplementation.c_floatXdr),
				new DatatypeImplementation.SchemaDatatypeMap("r8", DatatypeImplementation.c_doubleXdr),
				new DatatypeImplementation.SchemaDatatypeMap("string", DatatypeImplementation.c_string),
				new DatatypeImplementation.SchemaDatatypeMap("time", DatatypeImplementation.c_timeNoTz),
				new DatatypeImplementation.SchemaDatatypeMap("time.tz", DatatypeImplementation.c_timeTz),
				new DatatypeImplementation.SchemaDatatypeMap("ui1", DatatypeImplementation.c_unsignedByte),
				new DatatypeImplementation.SchemaDatatypeMap("ui2", DatatypeImplementation.c_unsignedShort),
				new DatatypeImplementation.SchemaDatatypeMap("ui4", DatatypeImplementation.c_unsignedInt),
				new DatatypeImplementation.SchemaDatatypeMap("ui8", DatatypeImplementation.c_unsignedLong),
				new DatatypeImplementation.SchemaDatatypeMap("uri", DatatypeImplementation.c_anyURI),
				new DatatypeImplementation.SchemaDatatypeMap("uuid", DatatypeImplementation.c_uuid)
			};
			DatatypeImplementation.c_XsdTypes = new DatatypeImplementation.SchemaDatatypeMap[]
			{
				new DatatypeImplementation.SchemaDatatypeMap("ENTITIES", DatatypeImplementation.c_ENTITIES, 11),
				new DatatypeImplementation.SchemaDatatypeMap("ENTITY", DatatypeImplementation.c_ENTITY, 11),
				new DatatypeImplementation.SchemaDatatypeMap("ID", DatatypeImplementation.c_ID, 5),
				new DatatypeImplementation.SchemaDatatypeMap("IDREF", DatatypeImplementation.c_IDREF, 5),
				new DatatypeImplementation.SchemaDatatypeMap("IDREFS", DatatypeImplementation.c_IDREFS, 11),
				new DatatypeImplementation.SchemaDatatypeMap("NCName", DatatypeImplementation.c_NCName, 9),
				new DatatypeImplementation.SchemaDatatypeMap("NMTOKEN", DatatypeImplementation.c_NMTOKEN, 40),
				new DatatypeImplementation.SchemaDatatypeMap("NMTOKENS", DatatypeImplementation.c_NMTOKENS, 11),
				new DatatypeImplementation.SchemaDatatypeMap("NOTATION", DatatypeImplementation.c_NOTATION, 11),
				new DatatypeImplementation.SchemaDatatypeMap("Name", DatatypeImplementation.c_Name, 40),
				new DatatypeImplementation.SchemaDatatypeMap("QName", DatatypeImplementation.c_QName, 11),
				new DatatypeImplementation.SchemaDatatypeMap("anySimpleType", DatatypeImplementation.c_anySimpleType, -1),
				new DatatypeImplementation.SchemaDatatypeMap("anyURI", DatatypeImplementation.c_anyURI, 11),
				new DatatypeImplementation.SchemaDatatypeMap("base64Binary", DatatypeImplementation.c_base64Binary, 11),
				new DatatypeImplementation.SchemaDatatypeMap("boolean", DatatypeImplementation.c_boolean, 11),
				new DatatypeImplementation.SchemaDatatypeMap("byte", DatatypeImplementation.c_byte, 37),
				new DatatypeImplementation.SchemaDatatypeMap("date", DatatypeImplementation.c_date, 11),
				new DatatypeImplementation.SchemaDatatypeMap("dateTime", DatatypeImplementation.c_dateTime, 11),
				new DatatypeImplementation.SchemaDatatypeMap("decimal", DatatypeImplementation.c_decimal, 11),
				new DatatypeImplementation.SchemaDatatypeMap("double", DatatypeImplementation.c_double, 11),
				new DatatypeImplementation.SchemaDatatypeMap("duration", DatatypeImplementation.c_duration, 11),
				new DatatypeImplementation.SchemaDatatypeMap("float", DatatypeImplementation.c_float, 11),
				new DatatypeImplementation.SchemaDatatypeMap("gDay", DatatypeImplementation.c_day, 11),
				new DatatypeImplementation.SchemaDatatypeMap("gMonth", DatatypeImplementation.c_month, 11),
				new DatatypeImplementation.SchemaDatatypeMap("gMonthDay", DatatypeImplementation.c_monthDay, 11),
				new DatatypeImplementation.SchemaDatatypeMap("gYear", DatatypeImplementation.c_year, 11),
				new DatatypeImplementation.SchemaDatatypeMap("gYearMonth", DatatypeImplementation.c_yearMonth, 11),
				new DatatypeImplementation.SchemaDatatypeMap("hexBinary", DatatypeImplementation.c_hexBinary, 11),
				new DatatypeImplementation.SchemaDatatypeMap("int", DatatypeImplementation.c_int, 31),
				new DatatypeImplementation.SchemaDatatypeMap("integer", DatatypeImplementation.c_integer, 18),
				new DatatypeImplementation.SchemaDatatypeMap("language", DatatypeImplementation.c_language, 40),
				new DatatypeImplementation.SchemaDatatypeMap("long", DatatypeImplementation.c_long, 29),
				new DatatypeImplementation.SchemaDatatypeMap("negativeInteger", DatatypeImplementation.c_negativeInteger, 34),
				new DatatypeImplementation.SchemaDatatypeMap("nonNegativeInteger", DatatypeImplementation.c_nonNegativeInteger, 29),
				new DatatypeImplementation.SchemaDatatypeMap("nonPositiveInteger", DatatypeImplementation.c_nonPositiveInteger, 29),
				new DatatypeImplementation.SchemaDatatypeMap("normalizedString", DatatypeImplementation.c_normalizedString, 38),
				new DatatypeImplementation.SchemaDatatypeMap("positiveInteger", DatatypeImplementation.c_positiveInteger, 33),
				new DatatypeImplementation.SchemaDatatypeMap("short", DatatypeImplementation.c_short, 28),
				new DatatypeImplementation.SchemaDatatypeMap("string", DatatypeImplementation.c_string, 11),
				new DatatypeImplementation.SchemaDatatypeMap("time", DatatypeImplementation.c_time, 11),
				new DatatypeImplementation.SchemaDatatypeMap("token", DatatypeImplementation.c_token, 35),
				new DatatypeImplementation.SchemaDatatypeMap("unsignedByte", DatatypeImplementation.c_unsignedByte, 44),
				new DatatypeImplementation.SchemaDatatypeMap("unsignedInt", DatatypeImplementation.c_unsignedInt, 43),
				new DatatypeImplementation.SchemaDatatypeMap("unsignedLong", DatatypeImplementation.c_unsignedLong, 33),
				new DatatypeImplementation.SchemaDatatypeMap("unsignedShort", DatatypeImplementation.c_unsignedShort, 42)
			};
			DatatypeImplementation.CreateBuiltinTypes();
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0007489A File Offset: 0x00072A9A
		internal static XmlSchemaSimpleType AnySimpleType
		{
			get
			{
				return DatatypeImplementation.anySimpleType;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x000748A1 File Offset: 0x00072AA1
		internal static XmlSchemaSimpleType UntypedAtomicType
		{
			get
			{
				return DatatypeImplementation.untypedAtomicType;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000748A8 File Offset: 0x00072AA8
		internal new static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			return DatatypeImplementation.c_tokenizedTypes[(int)token];
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000748B1 File Offset: 0x00072AB1
		internal new static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			return DatatypeImplementation.c_tokenizedTypesXsd[(int)token];
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000748BC File Offset: 0x00072ABC
		internal new static DatatypeImplementation FromXdrName(string name)
		{
			int num = Array.BinarySearch(DatatypeImplementation.c_XdrTypes, name, null);
			if (num >= 0)
			{
				return (DatatypeImplementation)DatatypeImplementation.c_XdrTypes[num];
			}
			return null;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000748E8 File Offset: 0x00072AE8
		private static DatatypeImplementation FromTypeName(string name)
		{
			int num = Array.BinarySearch(DatatypeImplementation.c_XsdTypes, name, null);
			if (num >= 0)
			{
				return (DatatypeImplementation)DatatypeImplementation.c_XsdTypes[num];
			}
			return null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00074914 File Offset: 0x00072B14
		internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			XmlSchemaSimpleType xmlSchemaSimpleType = new XmlSchemaSimpleType();
			xmlSchemaSimpleType.SetQualifiedName(qname);
			xmlSchemaSimpleType.SetDatatype(dataType);
			xmlSchemaSimpleType.ElementDecl = new SchemaElementDecl(dataType);
			xmlSchemaSimpleType.ElementDecl.SchemaType = xmlSchemaSimpleType;
			return xmlSchemaSimpleType;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00074950 File Offset: 0x00072B50
		internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
			derivedType.SetBaseSchemaType(baseType);
			derivedType.SetDerivedBy(XmlSchemaDerivationMethod.Restriction);
			if (derivedType.Datatype.Variety == XmlSchemaDatatypeVariety.Atomic)
			{
				derivedType.Content = new XmlSchemaSimpleTypeRestriction
				{
					BaseTypeName = baseType.QualifiedName
				};
			}
			if (derivedType.Datatype.Variety == XmlSchemaDatatypeVariety.List)
			{
				XmlSchemaSimpleTypeList xmlSchemaSimpleTypeList = new XmlSchemaSimpleTypeList();
				derivedType.SetDerivedBy(XmlSchemaDerivationMethod.List);
				XmlTypeCode typeCode = derivedType.Datatype.TypeCode;
				if (typeCode != XmlTypeCode.NmToken)
				{
					if (typeCode != XmlTypeCode.Idref)
					{
						if (typeCode == XmlTypeCode.Entity)
						{
							xmlSchemaSimpleTypeList.ItemType = (xmlSchemaSimpleTypeList.BaseItemType = DatatypeImplementation.enumToTypeCode[39]);
						}
					}
					else
					{
						xmlSchemaSimpleTypeList.ItemType = (xmlSchemaSimpleTypeList.BaseItemType = DatatypeImplementation.enumToTypeCode[38]);
					}
				}
				else
				{
					xmlSchemaSimpleTypeList.ItemType = (xmlSchemaSimpleTypeList.BaseItemType = DatatypeImplementation.enumToTypeCode[34]);
				}
				derivedType.Content = xmlSchemaSimpleTypeList;
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00074A1C File Offset: 0x00072C1C
		internal static void CreateBuiltinTypes()
		{
			DatatypeImplementation.SchemaDatatypeMap schemaDatatypeMap = DatatypeImplementation.c_XsdTypes[11];
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(schemaDatatypeMap.Name, "http://www.w3.org/2001/XMLSchema");
			DatatypeImplementation datatypeImplementation = DatatypeImplementation.FromTypeName(xmlQualifiedName.Name);
			DatatypeImplementation.anySimpleType = DatatypeImplementation.StartBuiltinType(xmlQualifiedName, datatypeImplementation);
			datatypeImplementation.parentSchemaType = DatatypeImplementation.anySimpleType;
			DatatypeImplementation.builtinTypes.Add(xmlQualifiedName, DatatypeImplementation.anySimpleType);
			for (int i = 0; i < DatatypeImplementation.c_XsdTypes.Length; i++)
			{
				if (i != 11)
				{
					schemaDatatypeMap = DatatypeImplementation.c_XsdTypes[i];
					xmlQualifiedName = new XmlQualifiedName(schemaDatatypeMap.Name, "http://www.w3.org/2001/XMLSchema");
					datatypeImplementation = DatatypeImplementation.FromTypeName(xmlQualifiedName.Name);
					XmlSchemaSimpleType xmlSchemaSimpleType = DatatypeImplementation.StartBuiltinType(xmlQualifiedName, datatypeImplementation);
					datatypeImplementation.parentSchemaType = xmlSchemaSimpleType;
					DatatypeImplementation.builtinTypes.Add(xmlQualifiedName, xmlSchemaSimpleType);
					if (datatypeImplementation.variety == XmlSchemaDatatypeVariety.Atomic)
					{
						DatatypeImplementation.enumToTypeCode[(int)datatypeImplementation.TypeCode] = xmlSchemaSimpleType;
					}
				}
			}
			for (int j = 0; j < DatatypeImplementation.c_XsdTypes.Length; j++)
			{
				if (j != 11)
				{
					schemaDatatypeMap = DatatypeImplementation.c_XsdTypes[j];
					XmlSchemaSimpleType derivedType = (XmlSchemaSimpleType)DatatypeImplementation.builtinTypes[new XmlQualifiedName(schemaDatatypeMap.Name, "http://www.w3.org/2001/XMLSchema")];
					if (schemaDatatypeMap.ParentIndex == 11)
					{
						DatatypeImplementation.FinishBuiltinType(derivedType, DatatypeImplementation.anySimpleType);
					}
					else
					{
						XmlSchemaSimpleType xmlSchemaSimpleType2 = (XmlSchemaSimpleType)DatatypeImplementation.builtinTypes[new XmlQualifiedName(DatatypeImplementation.c_XsdTypes[schemaDatatypeMap.ParentIndex].Name, "http://www.w3.org/2001/XMLSchema")];
						DatatypeImplementation.FinishBuiltinType(derivedType, xmlSchemaSimpleType2);
					}
				}
			}
			xmlQualifiedName = new XmlQualifiedName("anyAtomicType", "http://www.w3.org/2003/11/xpath-datatypes");
			DatatypeImplementation.anyAtomicType = DatatypeImplementation.StartBuiltinType(xmlQualifiedName, DatatypeImplementation.c_anyAtomicType);
			DatatypeImplementation.c_anyAtomicType.parentSchemaType = DatatypeImplementation.anyAtomicType;
			DatatypeImplementation.FinishBuiltinType(DatatypeImplementation.anyAtomicType, DatatypeImplementation.anySimpleType);
			DatatypeImplementation.builtinTypes.Add(xmlQualifiedName, DatatypeImplementation.anyAtomicType);
			DatatypeImplementation.enumToTypeCode[10] = DatatypeImplementation.anyAtomicType;
			xmlQualifiedName = new XmlQualifiedName("untypedAtomic", "http://www.w3.org/2003/11/xpath-datatypes");
			DatatypeImplementation.untypedAtomicType = DatatypeImplementation.StartBuiltinType(xmlQualifiedName, DatatypeImplementation.c_untypedAtomicType);
			DatatypeImplementation.c_untypedAtomicType.parentSchemaType = DatatypeImplementation.untypedAtomicType;
			DatatypeImplementation.FinishBuiltinType(DatatypeImplementation.untypedAtomicType, DatatypeImplementation.anyAtomicType);
			DatatypeImplementation.builtinTypes.Add(xmlQualifiedName, DatatypeImplementation.untypedAtomicType);
			DatatypeImplementation.enumToTypeCode[11] = DatatypeImplementation.untypedAtomicType;
			xmlQualifiedName = new XmlQualifiedName("yearMonthDuration", "http://www.w3.org/2003/11/xpath-datatypes");
			DatatypeImplementation.yearMonthDurationType = DatatypeImplementation.StartBuiltinType(xmlQualifiedName, DatatypeImplementation.c_yearMonthDuration);
			DatatypeImplementation.c_yearMonthDuration.parentSchemaType = DatatypeImplementation.yearMonthDurationType;
			DatatypeImplementation.FinishBuiltinType(DatatypeImplementation.yearMonthDurationType, DatatypeImplementation.enumToTypeCode[17]);
			DatatypeImplementation.builtinTypes.Add(xmlQualifiedName, DatatypeImplementation.yearMonthDurationType);
			DatatypeImplementation.enumToTypeCode[53] = DatatypeImplementation.yearMonthDurationType;
			xmlQualifiedName = new XmlQualifiedName("dayTimeDuration", "http://www.w3.org/2003/11/xpath-datatypes");
			DatatypeImplementation.dayTimeDurationType = DatatypeImplementation.StartBuiltinType(xmlQualifiedName, DatatypeImplementation.c_dayTimeDuration);
			DatatypeImplementation.c_dayTimeDuration.parentSchemaType = DatatypeImplementation.dayTimeDurationType;
			DatatypeImplementation.FinishBuiltinType(DatatypeImplementation.dayTimeDurationType, DatatypeImplementation.enumToTypeCode[17]);
			DatatypeImplementation.builtinTypes.Add(xmlQualifiedName, DatatypeImplementation.dayTimeDurationType);
			DatatypeImplementation.enumToTypeCode[54] = DatatypeImplementation.dayTimeDurationType;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00074CF3 File Offset: 0x00072EF3
		internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			return DatatypeImplementation.enumToTypeCode[(int)typeCode];
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00074CFC File Offset: 0x00072EFC
		internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname)
		{
			return (XmlSchemaSimpleType)DatatypeImplementation.builtinTypes[qname];
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00074D10 File Offset: 0x00072F10
		internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
		{
			if (DatatypeImplementation.normalizedStringTypeV1Compat == null)
			{
				XmlSchemaSimpleType xmlSchemaSimpleType = DatatypeImplementation.GetSimpleTypeFromTypeCode(XmlTypeCode.NormalizedString).Clone() as XmlSchemaSimpleType;
				xmlSchemaSimpleType.SetDatatype(DatatypeImplementation.c_normalizedStringV1Compat);
				xmlSchemaSimpleType.ElementDecl = new SchemaElementDecl(DatatypeImplementation.c_normalizedStringV1Compat);
				xmlSchemaSimpleType.ElementDecl.SchemaType = xmlSchemaSimpleType;
				DatatypeImplementation.normalizedStringTypeV1Compat = xmlSchemaSimpleType;
			}
			return DatatypeImplementation.normalizedStringTypeV1Compat;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00074D70 File Offset: 0x00072F70
		internal static XmlSchemaSimpleType GetTokenTypeV1Compat()
		{
			if (DatatypeImplementation.tokenTypeV1Compat == null)
			{
				XmlSchemaSimpleType xmlSchemaSimpleType = DatatypeImplementation.GetSimpleTypeFromTypeCode(XmlTypeCode.Token).Clone() as XmlSchemaSimpleType;
				xmlSchemaSimpleType.SetDatatype(DatatypeImplementation.c_tokenV1Compat);
				xmlSchemaSimpleType.ElementDecl = new SchemaElementDecl(DatatypeImplementation.c_tokenV1Compat);
				xmlSchemaSimpleType.ElementDecl.SchemaType = xmlSchemaSimpleType;
				DatatypeImplementation.tokenTypeV1Compat = xmlSchemaSimpleType;
			}
			return DatatypeImplementation.tokenTypeV1Compat;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00074DCE File Offset: 0x00072FCE
		internal static XmlSchemaSimpleType[] GetBuiltInTypes()
		{
			return DatatypeImplementation.enumToTypeCode;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00074DD8 File Offset: 0x00072FD8
		internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode)
		{
			XmlSchemaSimpleType xmlSchemaSimpleType = DatatypeImplementation.enumToTypeCode[(int)typeCode];
			while (xmlSchemaSimpleType.BaseXmlSchemaType != DatatypeImplementation.AnySimpleType)
			{
				xmlSchemaSimpleType = (xmlSchemaSimpleType.BaseXmlSchemaType as XmlSchemaSimpleType);
			}
			return xmlSchemaSimpleType.TypeCode;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00074E0E File Offset: 0x0007300E
		internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
		{
			DatatypeImplementation datatypeImplementation = (DatatypeImplementation)base.MemberwiseClone();
			datatypeImplementation.restriction = this.FacetsChecker.ConstructRestriction(this, facets, nameTable);
			datatypeImplementation.baseType = this;
			datatypeImplementation.parentSchemaType = schemaType;
			datatypeImplementation.valueConverter = null;
			return datatypeImplementation;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00074E44 File Offset: 0x00073044
		internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
		{
			return this.DeriveByList(0, schemaType);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00074E50 File Offset: 0x00073050
		internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			if (this.variety == XmlSchemaDatatypeVariety.List)
			{
				throw new XmlSchemaException("A list data type must be derived from an atomic or union data type.", string.Empty);
			}
			if (this.variety == XmlSchemaDatatypeVariety.Union && !((Datatype_union)this).HasAtomicMembers())
			{
				throw new XmlSchemaException("A list data type must be derived from an atomic or union data type.", string.Empty);
			}
			return new Datatype_List(this, minSize)
			{
				variety = XmlSchemaDatatypeVariety.List,
				restriction = null,
				baseType = DatatypeImplementation.c_anySimpleType,
				parentSchemaType = schemaType
			};
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00074EC3 File Offset: 0x000730C3
		internal new static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType)
		{
			return new Datatype_union(types)
			{
				baseType = DatatypeImplementation.c_anySimpleType,
				variety = XmlSchemaDatatypeVariety.Union,
				parentSchemaType = schemaType
			};
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00008574 File Offset: 0x00006774
		internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
		{
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00074EE4 File Offset: 0x000730E4
		public override bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			if (datatype == null)
			{
				return false;
			}
			for (DatatypeImplementation datatypeImplementation = this; datatypeImplementation != null; datatypeImplementation = datatypeImplementation.baseType)
			{
				if (datatypeImplementation == datatype)
				{
					return true;
				}
			}
			if (((DatatypeImplementation)datatype).baseType == null)
			{
				Type type = base.GetType();
				Type type2 = datatype.GetType();
				return type2 == type || type.IsSubclassOf(type2);
			}
			if (datatype.Variety == XmlSchemaDatatypeVariety.Union && !datatype.HasLexicalFacets && !datatype.HasValueFacets && this.variety != XmlSchemaDatatypeVariety.Union)
			{
				return ((Datatype_union)datatype).IsUnionBaseOf(this);
			}
			return (this.variety == XmlSchemaDatatypeVariety.Union || this.variety == XmlSchemaDatatypeVariety.List) && this.restriction == null && datatype == DatatypeImplementation.anySimpleType.Datatype;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00074F90 File Offset: 0x00073190
		internal override bool IsEqual(object o1, object o2)
		{
			return this.Compare(o1, o2) == 0;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00074FA0 File Offset: 0x000731A0
		internal override bool IsComparable(XmlSchemaDatatype dtype)
		{
			XmlTypeCode typeCode = this.TypeCode;
			XmlTypeCode typeCode2 = dtype.TypeCode;
			return typeCode == typeCode2 || DatatypeImplementation.GetPrimitiveTypeCode(typeCode) == DatatypeImplementation.GetPrimitiveTypeCode(typeCode2) || (this.IsDerivedFrom(dtype) || dtype.IsDerivedFrom(this));
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0001520A File Offset: 0x0001340A
		internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00074FE6 File Offset: 0x000731E6
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.miscFacetsChecker;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00074FED File Offset: 0x000731ED
		internal override XmlValueConverter ValueConverter
		{
			get
			{
				if (this.valueConverter == null)
				{
					this.valueConverter = this.CreateValueConverter(this.parentSchemaType);
				}
				return this.valueConverter;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00008318 File Offset: 0x00006518
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.None;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00015257 File Offset: 0x00013457
		public override Type ValueType
		{
			get
			{
				return typeof(string);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0007500F File Offset: 0x0007320F
		public override XmlSchemaDatatypeVariety Variety
		{
			get
			{
				return this.variety;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0000A216 File Offset: 0x00008416
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x00075017 File Offset: 0x00073217
		internal override RestrictionFacets Restriction
		{
			get
			{
				return this.restriction;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00075020 File Offset: 0x00073220
		internal override bool HasLexicalFacets
		{
			get
			{
				RestrictionFlags restrictionFlags = (this.restriction != null) ? this.restriction.Flags : ((RestrictionFlags)0);
				return restrictionFlags != (RestrictionFlags)0 && (restrictionFlags & (RestrictionFlags.Pattern | RestrictionFlags.WhiteSpace | RestrictionFlags.TotalDigits | RestrictionFlags.FractionDigits)) != (RestrictionFlags)0;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x00075054 File Offset: 0x00073254
		internal override bool HasValueFacets
		{
			get
			{
				RestrictionFlags restrictionFlags = (this.restriction != null) ? this.restriction.Flags : ((RestrictionFlags)0);
				return restrictionFlags != (RestrictionFlags)0 && (restrictionFlags & (RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Enumeration | RestrictionFlags.MaxInclusive | RestrictionFlags.MaxExclusive | RestrictionFlags.MinInclusive | RestrictionFlags.MinExclusive | RestrictionFlags.TotalDigits | RestrictionFlags.FractionDigits)) != (RestrictionFlags)0;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00075087 File Offset: 0x00073287
		protected DatatypeImplementation Base
		{
			get
			{
				return this.baseType;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001342 RID: 4930
		internal abstract Type ListValueType { get; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001343 RID: 4931
		internal abstract RestrictionFlags ValidRestrictionFlags { get; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0000A216 File Offset: 0x00008416
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00075090 File Offset: 0x00073290
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			object obj;
			Exception ex = this.TryParseValue(s, nameTable, nsmgr, out obj);
			if (ex != null)
			{
				throw new XmlSchemaException("The value '{0}' is invalid according to its schema type '{1}' - {2}", new string[]
				{
					s,
					this.GetTypeName(),
					ex.Message
				}, ex, null, 0, 0, null);
			}
			if (this.Variety == XmlSchemaDatatypeVariety.Union)
			{
				return (obj as XsdSimpleValue).TypedValue;
			}
			return obj;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000750F0 File Offset: 0x000732F0
		internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
		{
			if (!createAtomicValue)
			{
				return this.ParseValue(s, nameTable, nsmgr);
			}
			object result;
			Exception ex = this.TryParseValue(s, nameTable, nsmgr, out result);
			if (ex != null)
			{
				throw new XmlSchemaException("The value '{0}' is invalid according to its schema type '{1}' - {2}", new string[]
				{
					s,
					this.GetTypeName(),
					ex.Message
				}, ex, null, 0, 0, null);
			}
			return result;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00075148 File Offset: 0x00073348
		internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue)
		{
			Exception ex = null;
			typedValue = null;
			if (value == null)
			{
				return new ArgumentNullException("value");
			}
			string text = value as string;
			if (text != null)
			{
				return this.TryParseValue(text, nameTable, namespaceResolver, out typedValue);
			}
			try
			{
				object obj = value;
				if (value.GetType() != this.ValueType)
				{
					obj = this.ValueConverter.ChangeType(value, this.ValueType, namespaceResolver);
				}
				if (this.HasLexicalFacets)
				{
					string text2 = (string)this.ValueConverter.ChangeType(value, typeof(string), namespaceResolver);
					ex = this.FacetsChecker.CheckLexicalFacets(ref text2, this);
					if (ex != null)
					{
						return ex;
					}
				}
				if (this.HasValueFacets)
				{
					ex = this.FacetsChecker.CheckValueFacets(obj, this);
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

		// Token: 0x06001348 RID: 4936 RVA: 0x0007524C File Offset: 0x0007344C
		internal string GetTypeName()
		{
			XmlSchemaType xmlSchemaType = this.parentSchemaType;
			string result;
			if (xmlSchemaType == null || xmlSchemaType.QualifiedName.IsEmpty)
			{
				result = base.TypeCodeString;
			}
			else
			{
				result = xmlSchemaType.QualifiedName.ToString();
			}
			return result;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00075288 File Offset: 0x00073488
		protected int Compare(byte[] value1, byte[] value2)
		{
			int num = value1.Length;
			if (num != value2.Length)
			{
				return -1;
			}
			for (int i = 0; i < num; i++)
			{
				if (value1[i] != value2[i])
				{
					return -1;
				}
			}
			return 0;
		}

		// Token: 0x04000CEE RID: 3310
		private XmlSchemaDatatypeVariety variety;

		// Token: 0x04000CEF RID: 3311
		private RestrictionFacets restriction;

		// Token: 0x04000CF0 RID: 3312
		private DatatypeImplementation baseType;

		// Token: 0x04000CF1 RID: 3313
		private XmlValueConverter valueConverter;

		// Token: 0x04000CF2 RID: 3314
		private XmlSchemaType parentSchemaType;

		// Token: 0x04000CF3 RID: 3315
		private static Hashtable builtinTypes = new Hashtable();

		// Token: 0x04000CF4 RID: 3316
		private static XmlSchemaSimpleType[] enumToTypeCode = new XmlSchemaSimpleType[55];

		// Token: 0x04000CF5 RID: 3317
		private static XmlSchemaSimpleType anySimpleType;

		// Token: 0x04000CF6 RID: 3318
		private static XmlSchemaSimpleType anyAtomicType;

		// Token: 0x04000CF7 RID: 3319
		private static XmlSchemaSimpleType untypedAtomicType;

		// Token: 0x04000CF8 RID: 3320
		private static XmlSchemaSimpleType yearMonthDurationType;

		// Token: 0x04000CF9 RID: 3321
		private static XmlSchemaSimpleType dayTimeDurationType;

		// Token: 0x04000CFA RID: 3322
		private static volatile XmlSchemaSimpleType normalizedStringTypeV1Compat;

		// Token: 0x04000CFB RID: 3323
		private static volatile XmlSchemaSimpleType tokenTypeV1Compat;

		// Token: 0x04000CFC RID: 3324
		internal static XmlQualifiedName QnAnySimpleType = new XmlQualifiedName("anySimpleType", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000CFD RID: 3325
		internal static XmlQualifiedName QnAnyType = new XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000CFE RID: 3326
		internal static FacetsChecker stringFacetsChecker = new StringFacetsChecker();

		// Token: 0x04000CFF RID: 3327
		internal static FacetsChecker miscFacetsChecker = new MiscFacetsChecker();

		// Token: 0x04000D00 RID: 3328
		internal static FacetsChecker numeric2FacetsChecker = new Numeric2FacetsChecker();

		// Token: 0x04000D01 RID: 3329
		internal static FacetsChecker binaryFacetsChecker = new BinaryFacetsChecker();

		// Token: 0x04000D02 RID: 3330
		internal static FacetsChecker dateTimeFacetsChecker = new DateTimeFacetsChecker();

		// Token: 0x04000D03 RID: 3331
		internal static FacetsChecker durationFacetsChecker = new DurationFacetsChecker();

		// Token: 0x04000D04 RID: 3332
		internal static FacetsChecker listFacetsChecker = new ListFacetsChecker();

		// Token: 0x04000D05 RID: 3333
		internal static FacetsChecker qnameFacetsChecker = new QNameFacetsChecker();

		// Token: 0x04000D06 RID: 3334
		internal static FacetsChecker unionFacetsChecker = new UnionFacetsChecker();

		// Token: 0x04000D07 RID: 3335
		private static readonly DatatypeImplementation c_anySimpleType = new Datatype_anySimpleType();

		// Token: 0x04000D08 RID: 3336
		private static readonly DatatypeImplementation c_anyURI = new Datatype_anyURI();

		// Token: 0x04000D09 RID: 3337
		private static readonly DatatypeImplementation c_base64Binary = new Datatype_base64Binary();

		// Token: 0x04000D0A RID: 3338
		private static readonly DatatypeImplementation c_boolean = new Datatype_boolean();

		// Token: 0x04000D0B RID: 3339
		private static readonly DatatypeImplementation c_byte = new Datatype_byte();

		// Token: 0x04000D0C RID: 3340
		private static readonly DatatypeImplementation c_char = new Datatype_char();

		// Token: 0x04000D0D RID: 3341
		private static readonly DatatypeImplementation c_date = new Datatype_date();

		// Token: 0x04000D0E RID: 3342
		private static readonly DatatypeImplementation c_dateTime = new Datatype_dateTime();

		// Token: 0x04000D0F RID: 3343
		private static readonly DatatypeImplementation c_dateTimeNoTz = new Datatype_dateTimeNoTimeZone();

		// Token: 0x04000D10 RID: 3344
		private static readonly DatatypeImplementation c_dateTimeTz = new Datatype_dateTimeTimeZone();

		// Token: 0x04000D11 RID: 3345
		private static readonly DatatypeImplementation c_day = new Datatype_day();

		// Token: 0x04000D12 RID: 3346
		private static readonly DatatypeImplementation c_decimal = new Datatype_decimal();

		// Token: 0x04000D13 RID: 3347
		private static readonly DatatypeImplementation c_double = new Datatype_double();

		// Token: 0x04000D14 RID: 3348
		private static readonly DatatypeImplementation c_doubleXdr = new Datatype_doubleXdr();

		// Token: 0x04000D15 RID: 3349
		private static readonly DatatypeImplementation c_duration = new Datatype_duration();

		// Token: 0x04000D16 RID: 3350
		private static readonly DatatypeImplementation c_ENTITY = new Datatype_ENTITY();

		// Token: 0x04000D17 RID: 3351
		private static readonly DatatypeImplementation c_ENTITIES = (DatatypeImplementation)DatatypeImplementation.c_ENTITY.DeriveByList(1, null);

		// Token: 0x04000D18 RID: 3352
		private static readonly DatatypeImplementation c_ENUMERATION = new Datatype_ENUMERATION();

		// Token: 0x04000D19 RID: 3353
		private static readonly DatatypeImplementation c_fixed = new Datatype_fixed();

		// Token: 0x04000D1A RID: 3354
		private static readonly DatatypeImplementation c_float = new Datatype_float();

		// Token: 0x04000D1B RID: 3355
		private static readonly DatatypeImplementation c_floatXdr = new Datatype_floatXdr();

		// Token: 0x04000D1C RID: 3356
		private static readonly DatatypeImplementation c_hexBinary = new Datatype_hexBinary();

		// Token: 0x04000D1D RID: 3357
		private static readonly DatatypeImplementation c_ID = new Datatype_ID();

		// Token: 0x04000D1E RID: 3358
		private static readonly DatatypeImplementation c_IDREF = new Datatype_IDREF();

		// Token: 0x04000D1F RID: 3359
		private static readonly DatatypeImplementation c_IDREFS = (DatatypeImplementation)DatatypeImplementation.c_IDREF.DeriveByList(1, null);

		// Token: 0x04000D20 RID: 3360
		private static readonly DatatypeImplementation c_int = new Datatype_int();

		// Token: 0x04000D21 RID: 3361
		private static readonly DatatypeImplementation c_integer = new Datatype_integer();

		// Token: 0x04000D22 RID: 3362
		private static readonly DatatypeImplementation c_language = new Datatype_language();

		// Token: 0x04000D23 RID: 3363
		private static readonly DatatypeImplementation c_long = new Datatype_long();

		// Token: 0x04000D24 RID: 3364
		private static readonly DatatypeImplementation c_month = new Datatype_month();

		// Token: 0x04000D25 RID: 3365
		private static readonly DatatypeImplementation c_monthDay = new Datatype_monthDay();

		// Token: 0x04000D26 RID: 3366
		private static readonly DatatypeImplementation c_Name = new Datatype_Name();

		// Token: 0x04000D27 RID: 3367
		private static readonly DatatypeImplementation c_NCName = new Datatype_NCName();

		// Token: 0x04000D28 RID: 3368
		private static readonly DatatypeImplementation c_negativeInteger = new Datatype_negativeInteger();

		// Token: 0x04000D29 RID: 3369
		private static readonly DatatypeImplementation c_NMTOKEN = new Datatype_NMTOKEN();

		// Token: 0x04000D2A RID: 3370
		private static readonly DatatypeImplementation c_NMTOKENS = (DatatypeImplementation)DatatypeImplementation.c_NMTOKEN.DeriveByList(1, null);

		// Token: 0x04000D2B RID: 3371
		private static readonly DatatypeImplementation c_nonNegativeInteger = new Datatype_nonNegativeInteger();

		// Token: 0x04000D2C RID: 3372
		private static readonly DatatypeImplementation c_nonPositiveInteger = new Datatype_nonPositiveInteger();

		// Token: 0x04000D2D RID: 3373
		private static readonly DatatypeImplementation c_normalizedString = new Datatype_normalizedString();

		// Token: 0x04000D2E RID: 3374
		private static readonly DatatypeImplementation c_NOTATION = new Datatype_NOTATION();

		// Token: 0x04000D2F RID: 3375
		private static readonly DatatypeImplementation c_positiveInteger = new Datatype_positiveInteger();

		// Token: 0x04000D30 RID: 3376
		private static readonly DatatypeImplementation c_QName = new Datatype_QName();

		// Token: 0x04000D31 RID: 3377
		private static readonly DatatypeImplementation c_QNameXdr = new Datatype_QNameXdr();

		// Token: 0x04000D32 RID: 3378
		private static readonly DatatypeImplementation c_short = new Datatype_short();

		// Token: 0x04000D33 RID: 3379
		private static readonly DatatypeImplementation c_string = new Datatype_string();

		// Token: 0x04000D34 RID: 3380
		private static readonly DatatypeImplementation c_time = new Datatype_time();

		// Token: 0x04000D35 RID: 3381
		private static readonly DatatypeImplementation c_timeNoTz = new Datatype_timeNoTimeZone();

		// Token: 0x04000D36 RID: 3382
		private static readonly DatatypeImplementation c_timeTz = new Datatype_timeTimeZone();

		// Token: 0x04000D37 RID: 3383
		private static readonly DatatypeImplementation c_token = new Datatype_token();

		// Token: 0x04000D38 RID: 3384
		private static readonly DatatypeImplementation c_unsignedByte = new Datatype_unsignedByte();

		// Token: 0x04000D39 RID: 3385
		private static readonly DatatypeImplementation c_unsignedInt = new Datatype_unsignedInt();

		// Token: 0x04000D3A RID: 3386
		private static readonly DatatypeImplementation c_unsignedLong = new Datatype_unsignedLong();

		// Token: 0x04000D3B RID: 3387
		private static readonly DatatypeImplementation c_unsignedShort = new Datatype_unsignedShort();

		// Token: 0x04000D3C RID: 3388
		private static readonly DatatypeImplementation c_uuid = new Datatype_uuid();

		// Token: 0x04000D3D RID: 3389
		private static readonly DatatypeImplementation c_year = new Datatype_year();

		// Token: 0x04000D3E RID: 3390
		private static readonly DatatypeImplementation c_yearMonth = new Datatype_yearMonth();

		// Token: 0x04000D3F RID: 3391
		internal static readonly DatatypeImplementation c_normalizedStringV1Compat = new Datatype_normalizedStringV1Compat();

		// Token: 0x04000D40 RID: 3392
		internal static readonly DatatypeImplementation c_tokenV1Compat = new Datatype_tokenV1Compat();

		// Token: 0x04000D41 RID: 3393
		private static readonly DatatypeImplementation c_anyAtomicType = new Datatype_anyAtomicType();

		// Token: 0x04000D42 RID: 3394
		private static readonly DatatypeImplementation c_dayTimeDuration = new Datatype_dayTimeDuration();

		// Token: 0x04000D43 RID: 3395
		private static readonly DatatypeImplementation c_untypedAtomicType = new Datatype_untypedAtomicType();

		// Token: 0x04000D44 RID: 3396
		private static readonly DatatypeImplementation c_yearMonthDuration = new Datatype_yearMonthDuration();

		// Token: 0x04000D45 RID: 3397
		private static readonly DatatypeImplementation[] c_tokenizedTypes;

		// Token: 0x04000D46 RID: 3398
		private static readonly DatatypeImplementation[] c_tokenizedTypesXsd;

		// Token: 0x04000D47 RID: 3399
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;

		// Token: 0x04000D48 RID: 3400
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;

		// Token: 0x02000250 RID: 592
		private class SchemaDatatypeMap : IComparable
		{
			// Token: 0x0600134B RID: 4939 RVA: 0x000752C0 File Offset: 0x000734C0
			internal SchemaDatatypeMap(string name, DatatypeImplementation type)
			{
				this.name = name;
				this.type = type;
			}

			// Token: 0x0600134C RID: 4940 RVA: 0x000752D6 File Offset: 0x000734D6
			internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
			{
				this.name = name;
				this.type = type;
				this.parentIndex = parentIndex;
			}

			// Token: 0x0600134D RID: 4941 RVA: 0x000752F3 File Offset: 0x000734F3
			public static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				return sdm.type;
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x0600134E RID: 4942 RVA: 0x000752FB File Offset: 0x000734FB
			public string Name
			{
				get
				{
					return this.name;
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x0600134F RID: 4943 RVA: 0x00075303 File Offset: 0x00073503
			public int ParentIndex
			{
				get
				{
					return this.parentIndex;
				}
			}

			// Token: 0x06001350 RID: 4944 RVA: 0x0007530B File Offset: 0x0007350B
			public int CompareTo(object obj)
			{
				return string.Compare(this.name, (string)obj, StringComparison.Ordinal);
			}

			// Token: 0x04000D49 RID: 3401
			private string name;

			// Token: 0x04000D4A RID: 3402
			private DatatypeImplementation type;

			// Token: 0x04000D4B RID: 3403
			private int parentIndex;
		}
	}
}
