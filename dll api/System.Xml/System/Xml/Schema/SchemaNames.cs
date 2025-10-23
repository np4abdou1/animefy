using System;

namespace System.Xml.Schema
{
	// Token: 0x020002B6 RID: 694
	internal sealed class SchemaNames
	{
		// Token: 0x060016B6 RID: 5814 RVA: 0x0008AE68 File Offset: 0x00089068
		public SchemaNames(XmlNameTable nameTable)
		{
			this.nameTable = nameTable;
			this.NsDataType = nameTable.Add("urn:schemas-microsoft-com:datatypes");
			this.NsDataTypeAlias = nameTable.Add("uuid:C2F41010-65B3-11D1-A29F-00AA00C14882");
			this.NsDataTypeOld = nameTable.Add("urn:uuid:C2F41010-65B3-11D1-A29F-00AA00C14882/");
			this.NsXml = nameTable.Add("http://www.w3.org/XML/1998/namespace");
			this.NsXmlNs = nameTable.Add("http://www.w3.org/2000/xmlns/");
			this.NsXdr = nameTable.Add("urn:schemas-microsoft-com:xml-data");
			this.NsXdrAlias = nameTable.Add("uuid:BDC6E3F0-6DA3-11D1-A2A3-00AA00C14882");
			this.NsXs = nameTable.Add("http://www.w3.org/2001/XMLSchema");
			this.NsXsi = nameTable.Add("http://www.w3.org/2001/XMLSchema-instance");
			this.XsiType = nameTable.Add("type");
			this.XsiNil = nameTable.Add("nil");
			this.XsiSchemaLocation = nameTable.Add("schemaLocation");
			this.XsiNoNamespaceSchemaLocation = nameTable.Add("noNamespaceSchemaLocation");
			this.XsdSchema = nameTable.Add("schema");
			this.XdrSchema = nameTable.Add("Schema");
			this.QnPCData = new XmlQualifiedName(nameTable.Add("#PCDATA"));
			this.QnXml = new XmlQualifiedName(nameTable.Add("xml"));
			this.QnXmlNs = new XmlQualifiedName(nameTable.Add("xmlns"), this.NsXmlNs);
			this.QnDtDt = new XmlQualifiedName(nameTable.Add("dt"), this.NsDataType);
			this.QnXmlLang = new XmlQualifiedName(nameTable.Add("lang"), this.NsXml);
			this.QnName = new XmlQualifiedName(nameTable.Add("name"));
			this.QnType = new XmlQualifiedName(nameTable.Add("type"));
			this.QnMaxOccurs = new XmlQualifiedName(nameTable.Add("maxOccurs"));
			this.QnMinOccurs = new XmlQualifiedName(nameTable.Add("minOccurs"));
			this.QnInfinite = new XmlQualifiedName(nameTable.Add("*"));
			this.QnModel = new XmlQualifiedName(nameTable.Add("model"));
			this.QnOpen = new XmlQualifiedName(nameTable.Add("open"));
			this.QnClosed = new XmlQualifiedName(nameTable.Add("closed"));
			this.QnContent = new XmlQualifiedName(nameTable.Add("content"));
			this.QnMixed = new XmlQualifiedName(nameTable.Add("mixed"));
			this.QnEmpty = new XmlQualifiedName(nameTable.Add("empty"));
			this.QnEltOnly = new XmlQualifiedName(nameTable.Add("eltOnly"));
			this.QnTextOnly = new XmlQualifiedName(nameTable.Add("textOnly"));
			this.QnOrder = new XmlQualifiedName(nameTable.Add("order"));
			this.QnSeq = new XmlQualifiedName(nameTable.Add("seq"));
			this.QnOne = new XmlQualifiedName(nameTable.Add("one"));
			this.QnMany = new XmlQualifiedName(nameTable.Add("many"));
			this.QnRequired = new XmlQualifiedName(nameTable.Add("required"));
			this.QnYes = new XmlQualifiedName(nameTable.Add("yes"));
			this.QnNo = new XmlQualifiedName(nameTable.Add("no"));
			this.QnString = new XmlQualifiedName(nameTable.Add("string"));
			this.QnID = new XmlQualifiedName(nameTable.Add("id"));
			this.QnIDRef = new XmlQualifiedName(nameTable.Add("idref"));
			this.QnIDRefs = new XmlQualifiedName(nameTable.Add("idrefs"));
			this.QnEntity = new XmlQualifiedName(nameTable.Add("entity"));
			this.QnEntities = new XmlQualifiedName(nameTable.Add("entities"));
			this.QnNmToken = new XmlQualifiedName(nameTable.Add("nmtoken"));
			this.QnNmTokens = new XmlQualifiedName(nameTable.Add("nmtokens"));
			this.QnEnumeration = new XmlQualifiedName(nameTable.Add("enumeration"));
			this.QnDefault = new XmlQualifiedName(nameTable.Add("default"));
			this.QnTargetNamespace = new XmlQualifiedName(nameTable.Add("targetNamespace"));
			this.QnVersion = new XmlQualifiedName(nameTable.Add("version"));
			this.QnFinalDefault = new XmlQualifiedName(nameTable.Add("finalDefault"));
			this.QnBlockDefault = new XmlQualifiedName(nameTable.Add("blockDefault"));
			this.QnFixed = new XmlQualifiedName(nameTable.Add("fixed"));
			this.QnAbstract = new XmlQualifiedName(nameTable.Add("abstract"));
			this.QnBlock = new XmlQualifiedName(nameTable.Add("block"));
			this.QnSubstitutionGroup = new XmlQualifiedName(nameTable.Add("substitutionGroup"));
			this.QnFinal = new XmlQualifiedName(nameTable.Add("final"));
			this.QnNillable = new XmlQualifiedName(nameTable.Add("nillable"));
			this.QnRef = new XmlQualifiedName(nameTable.Add("ref"));
			this.QnBase = new XmlQualifiedName(nameTable.Add("base"));
			this.QnDerivedBy = new XmlQualifiedName(nameTable.Add("derivedBy"));
			this.QnNamespace = new XmlQualifiedName(nameTable.Add("namespace"));
			this.QnProcessContents = new XmlQualifiedName(nameTable.Add("processContents"));
			this.QnRefer = new XmlQualifiedName(nameTable.Add("refer"));
			this.QnPublic = new XmlQualifiedName(nameTable.Add("public"));
			this.QnSystem = new XmlQualifiedName(nameTable.Add("system"));
			this.QnSchemaLocation = new XmlQualifiedName(nameTable.Add("schemaLocation"));
			this.QnValue = new XmlQualifiedName(nameTable.Add("value"));
			this.QnUse = new XmlQualifiedName(nameTable.Add("use"));
			this.QnForm = new XmlQualifiedName(nameTable.Add("form"));
			this.QnAttributeFormDefault = new XmlQualifiedName(nameTable.Add("attributeFormDefault"));
			this.QnElementFormDefault = new XmlQualifiedName(nameTable.Add("elementFormDefault"));
			this.QnSource = new XmlQualifiedName(nameTable.Add("source"));
			this.QnMemberTypes = new XmlQualifiedName(nameTable.Add("memberTypes"));
			this.QnItemType = new XmlQualifiedName(nameTable.Add("itemType"));
			this.QnXPath = new XmlQualifiedName(nameTable.Add("xpath"));
			this.QnXdrSchema = new XmlQualifiedName(this.XdrSchema, this.NsXdr);
			this.QnXdrElementType = new XmlQualifiedName(nameTable.Add("ElementType"), this.NsXdr);
			this.QnXdrElement = new XmlQualifiedName(nameTable.Add("element"), this.NsXdr);
			this.QnXdrGroup = new XmlQualifiedName(nameTable.Add("group"), this.NsXdr);
			this.QnXdrAttributeType = new XmlQualifiedName(nameTable.Add("AttributeType"), this.NsXdr);
			this.QnXdrAttribute = new XmlQualifiedName(nameTable.Add("attribute"), this.NsXdr);
			this.QnXdrDataType = new XmlQualifiedName(nameTable.Add("datatype"), this.NsXdr);
			this.QnXdrDescription = new XmlQualifiedName(nameTable.Add("description"), this.NsXdr);
			this.QnXdrExtends = new XmlQualifiedName(nameTable.Add("extends"), this.NsXdr);
			this.QnXdrAliasSchema = new XmlQualifiedName(nameTable.Add("Schema"), this.NsDataTypeAlias);
			this.QnDtType = new XmlQualifiedName(nameTable.Add("type"), this.NsDataType);
			this.QnDtValues = new XmlQualifiedName(nameTable.Add("values"), this.NsDataType);
			this.QnDtMaxLength = new XmlQualifiedName(nameTable.Add("maxLength"), this.NsDataType);
			this.QnDtMinLength = new XmlQualifiedName(nameTable.Add("minLength"), this.NsDataType);
			this.QnDtMax = new XmlQualifiedName(nameTable.Add("max"), this.NsDataType);
			this.QnDtMin = new XmlQualifiedName(nameTable.Add("min"), this.NsDataType);
			this.QnDtMinExclusive = new XmlQualifiedName(nameTable.Add("minExclusive"), this.NsDataType);
			this.QnDtMaxExclusive = new XmlQualifiedName(nameTable.Add("maxExclusive"), this.NsDataType);
			this.QnXsdSchema = new XmlQualifiedName(this.XsdSchema, this.NsXs);
			this.QnXsdAnnotation = new XmlQualifiedName(nameTable.Add("annotation"), this.NsXs);
			this.QnXsdInclude = new XmlQualifiedName(nameTable.Add("include"), this.NsXs);
			this.QnXsdImport = new XmlQualifiedName(nameTable.Add("import"), this.NsXs);
			this.QnXsdElement = new XmlQualifiedName(nameTable.Add("element"), this.NsXs);
			this.QnXsdAttribute = new XmlQualifiedName(nameTable.Add("attribute"), this.NsXs);
			this.QnXsdAttributeGroup = new XmlQualifiedName(nameTable.Add("attributeGroup"), this.NsXs);
			this.QnXsdAnyAttribute = new XmlQualifiedName(nameTable.Add("anyAttribute"), this.NsXs);
			this.QnXsdGroup = new XmlQualifiedName(nameTable.Add("group"), this.NsXs);
			this.QnXsdAll = new XmlQualifiedName(nameTable.Add("all"), this.NsXs);
			this.QnXsdChoice = new XmlQualifiedName(nameTable.Add("choice"), this.NsXs);
			this.QnXsdSequence = new XmlQualifiedName(nameTable.Add("sequence"), this.NsXs);
			this.QnXsdAny = new XmlQualifiedName(nameTable.Add("any"), this.NsXs);
			this.QnXsdNotation = new XmlQualifiedName(nameTable.Add("notation"), this.NsXs);
			this.QnXsdSimpleType = new XmlQualifiedName(nameTable.Add("simpleType"), this.NsXs);
			this.QnXsdComplexType = new XmlQualifiedName(nameTable.Add("complexType"), this.NsXs);
			this.QnXsdUnique = new XmlQualifiedName(nameTable.Add("unique"), this.NsXs);
			this.QnXsdKey = new XmlQualifiedName(nameTable.Add("key"), this.NsXs);
			this.QnXsdKeyRef = new XmlQualifiedName(nameTable.Add("keyref"), this.NsXs);
			this.QnXsdSelector = new XmlQualifiedName(nameTable.Add("selector"), this.NsXs);
			this.QnXsdField = new XmlQualifiedName(nameTable.Add("field"), this.NsXs);
			this.QnXsdMinExclusive = new XmlQualifiedName(nameTable.Add("minExclusive"), this.NsXs);
			this.QnXsdMinInclusive = new XmlQualifiedName(nameTable.Add("minInclusive"), this.NsXs);
			this.QnXsdMaxInclusive = new XmlQualifiedName(nameTable.Add("maxInclusive"), this.NsXs);
			this.QnXsdMaxExclusive = new XmlQualifiedName(nameTable.Add("maxExclusive"), this.NsXs);
			this.QnXsdTotalDigits = new XmlQualifiedName(nameTable.Add("totalDigits"), this.NsXs);
			this.QnXsdFractionDigits = new XmlQualifiedName(nameTable.Add("fractionDigits"), this.NsXs);
			this.QnXsdLength = new XmlQualifiedName(nameTable.Add("length"), this.NsXs);
			this.QnXsdMinLength = new XmlQualifiedName(nameTable.Add("minLength"), this.NsXs);
			this.QnXsdMaxLength = new XmlQualifiedName(nameTable.Add("maxLength"), this.NsXs);
			this.QnXsdEnumeration = new XmlQualifiedName(nameTable.Add("enumeration"), this.NsXs);
			this.QnXsdPattern = new XmlQualifiedName(nameTable.Add("pattern"), this.NsXs);
			this.QnXsdDocumentation = new XmlQualifiedName(nameTable.Add("documentation"), this.NsXs);
			this.QnXsdAppinfo = new XmlQualifiedName(nameTable.Add("appinfo"), this.NsXs);
			this.QnXsdComplexContent = new XmlQualifiedName(nameTable.Add("complexContent"), this.NsXs);
			this.QnXsdSimpleContent = new XmlQualifiedName(nameTable.Add("simpleContent"), this.NsXs);
			this.QnXsdRestriction = new XmlQualifiedName(nameTable.Add("restriction"), this.NsXs);
			this.QnXsdExtension = new XmlQualifiedName(nameTable.Add("extension"), this.NsXs);
			this.QnXsdUnion = new XmlQualifiedName(nameTable.Add("union"), this.NsXs);
			this.QnXsdList = new XmlQualifiedName(nameTable.Add("list"), this.NsXs);
			this.QnXsdWhiteSpace = new XmlQualifiedName(nameTable.Add("whiteSpace"), this.NsXs);
			this.QnXsdRedefine = new XmlQualifiedName(nameTable.Add("redefine"), this.NsXs);
			this.QnXsdAnyType = new XmlQualifiedName(nameTable.Add("anyType"), this.NsXs);
			this.CreateTokenToQNameTable();
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0008BBB4 File Offset: 0x00089DB4
		public void CreateTokenToQNameTable()
		{
			this.TokenToQName[1] = this.QnName;
			this.TokenToQName[2] = this.QnType;
			this.TokenToQName[3] = this.QnMaxOccurs;
			this.TokenToQName[4] = this.QnMinOccurs;
			this.TokenToQName[5] = this.QnInfinite;
			this.TokenToQName[6] = this.QnModel;
			this.TokenToQName[7] = this.QnOpen;
			this.TokenToQName[8] = this.QnClosed;
			this.TokenToQName[9] = this.QnContent;
			this.TokenToQName[10] = this.QnMixed;
			this.TokenToQName[11] = this.QnEmpty;
			this.TokenToQName[12] = this.QnEltOnly;
			this.TokenToQName[13] = this.QnTextOnly;
			this.TokenToQName[14] = this.QnOrder;
			this.TokenToQName[15] = this.QnSeq;
			this.TokenToQName[16] = this.QnOne;
			this.TokenToQName[17] = this.QnMany;
			this.TokenToQName[18] = this.QnRequired;
			this.TokenToQName[19] = this.QnYes;
			this.TokenToQName[20] = this.QnNo;
			this.TokenToQName[21] = this.QnString;
			this.TokenToQName[22] = this.QnID;
			this.TokenToQName[23] = this.QnIDRef;
			this.TokenToQName[24] = this.QnIDRefs;
			this.TokenToQName[25] = this.QnEntity;
			this.TokenToQName[26] = this.QnEntities;
			this.TokenToQName[27] = this.QnNmToken;
			this.TokenToQName[28] = this.QnNmTokens;
			this.TokenToQName[29] = this.QnEnumeration;
			this.TokenToQName[30] = this.QnDefault;
			this.TokenToQName[31] = this.QnXdrSchema;
			this.TokenToQName[32] = this.QnXdrElementType;
			this.TokenToQName[33] = this.QnXdrElement;
			this.TokenToQName[34] = this.QnXdrGroup;
			this.TokenToQName[35] = this.QnXdrAttributeType;
			this.TokenToQName[36] = this.QnXdrAttribute;
			this.TokenToQName[37] = this.QnXdrDataType;
			this.TokenToQName[38] = this.QnXdrDescription;
			this.TokenToQName[39] = this.QnXdrExtends;
			this.TokenToQName[40] = this.QnXdrAliasSchema;
			this.TokenToQName[41] = this.QnDtType;
			this.TokenToQName[42] = this.QnDtValues;
			this.TokenToQName[43] = this.QnDtMaxLength;
			this.TokenToQName[44] = this.QnDtMinLength;
			this.TokenToQName[45] = this.QnDtMax;
			this.TokenToQName[46] = this.QnDtMin;
			this.TokenToQName[47] = this.QnDtMinExclusive;
			this.TokenToQName[48] = this.QnDtMaxExclusive;
			this.TokenToQName[49] = this.QnTargetNamespace;
			this.TokenToQName[50] = this.QnVersion;
			this.TokenToQName[51] = this.QnFinalDefault;
			this.TokenToQName[52] = this.QnBlockDefault;
			this.TokenToQName[53] = this.QnFixed;
			this.TokenToQName[54] = this.QnAbstract;
			this.TokenToQName[55] = this.QnBlock;
			this.TokenToQName[56] = this.QnSubstitutionGroup;
			this.TokenToQName[57] = this.QnFinal;
			this.TokenToQName[58] = this.QnNillable;
			this.TokenToQName[59] = this.QnRef;
			this.TokenToQName[60] = this.QnBase;
			this.TokenToQName[61] = this.QnDerivedBy;
			this.TokenToQName[62] = this.QnNamespace;
			this.TokenToQName[63] = this.QnProcessContents;
			this.TokenToQName[64] = this.QnRefer;
			this.TokenToQName[65] = this.QnPublic;
			this.TokenToQName[66] = this.QnSystem;
			this.TokenToQName[67] = this.QnSchemaLocation;
			this.TokenToQName[68] = this.QnValue;
			this.TokenToQName[119] = this.QnItemType;
			this.TokenToQName[120] = this.QnMemberTypes;
			this.TokenToQName[121] = this.QnXPath;
			this.TokenToQName[74] = this.QnXsdSchema;
			this.TokenToQName[75] = this.QnXsdAnnotation;
			this.TokenToQName[76] = this.QnXsdInclude;
			this.TokenToQName[77] = this.QnXsdImport;
			this.TokenToQName[78] = this.QnXsdElement;
			this.TokenToQName[79] = this.QnXsdAttribute;
			this.TokenToQName[80] = this.QnXsdAttributeGroup;
			this.TokenToQName[81] = this.QnXsdAnyAttribute;
			this.TokenToQName[82] = this.QnXsdGroup;
			this.TokenToQName[83] = this.QnXsdAll;
			this.TokenToQName[84] = this.QnXsdChoice;
			this.TokenToQName[85] = this.QnXsdSequence;
			this.TokenToQName[86] = this.QnXsdAny;
			this.TokenToQName[87] = this.QnXsdNotation;
			this.TokenToQName[88] = this.QnXsdSimpleType;
			this.TokenToQName[89] = this.QnXsdComplexType;
			this.TokenToQName[90] = this.QnXsdUnique;
			this.TokenToQName[91] = this.QnXsdKey;
			this.TokenToQName[92] = this.QnXsdKeyRef;
			this.TokenToQName[93] = this.QnXsdSelector;
			this.TokenToQName[94] = this.QnXsdField;
			this.TokenToQName[95] = this.QnXsdMinExclusive;
			this.TokenToQName[96] = this.QnXsdMinInclusive;
			this.TokenToQName[97] = this.QnXsdMaxExclusive;
			this.TokenToQName[98] = this.QnXsdMaxInclusive;
			this.TokenToQName[99] = this.QnXsdTotalDigits;
			this.TokenToQName[100] = this.QnXsdFractionDigits;
			this.TokenToQName[101] = this.QnXsdLength;
			this.TokenToQName[102] = this.QnXsdMinLength;
			this.TokenToQName[103] = this.QnXsdMaxLength;
			this.TokenToQName[104] = this.QnXsdEnumeration;
			this.TokenToQName[105] = this.QnXsdPattern;
			this.TokenToQName[117] = this.QnXsdWhiteSpace;
			this.TokenToQName[106] = this.QnXsdDocumentation;
			this.TokenToQName[107] = this.QnXsdAppinfo;
			this.TokenToQName[108] = this.QnXsdComplexContent;
			this.TokenToQName[110] = this.QnXsdRestriction;
			this.TokenToQName[113] = this.QnXsdRestriction;
			this.TokenToQName[115] = this.QnXsdRestriction;
			this.TokenToQName[109] = this.QnXsdExtension;
			this.TokenToQName[112] = this.QnXsdExtension;
			this.TokenToQName[111] = this.QnXsdSimpleContent;
			this.TokenToQName[116] = this.QnXsdUnion;
			this.TokenToQName[114] = this.QnXsdList;
			this.TokenToQName[118] = this.QnXsdRedefine;
			this.TokenToQName[69] = this.QnSource;
			this.TokenToQName[72] = this.QnUse;
			this.TokenToQName[73] = this.QnForm;
			this.TokenToQName[71] = this.QnElementFormDefault;
			this.TokenToQName[70] = this.QnAttributeFormDefault;
			this.TokenToQName[122] = this.QnXmlLang;
			this.TokenToQName[0] = XmlQualifiedName.Empty;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0008C2EC File Offset: 0x0008A4EC
		public SchemaType SchemaTypeFromRoot(string localName, string ns)
		{
			if (this.IsXSDRoot(localName, ns))
			{
				return SchemaType.XSD;
			}
			if (this.IsXDRRoot(localName, XmlSchemaDatatype.XdrCanonizeUri(ns, this.nameTable, this)))
			{
				return SchemaType.XDR;
			}
			return SchemaType.None;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0008C313 File Offset: 0x0008A513
		public bool IsXSDRoot(string localName, string ns)
		{
			return localName == this.XsdSchema && ns == this.NsXs;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0008C331 File Offset: 0x0008A531
		public bool IsXDRRoot(string localName, string ns)
		{
			return localName == this.XdrSchema && ns == this.NsXdr;
		}

		// Token: 0x04000E68 RID: 3688
		private XmlNameTable nameTable;

		// Token: 0x04000E69 RID: 3689
		public string NsDataType;

		// Token: 0x04000E6A RID: 3690
		public string NsDataTypeAlias;

		// Token: 0x04000E6B RID: 3691
		public string NsDataTypeOld;

		// Token: 0x04000E6C RID: 3692
		public string NsXml;

		// Token: 0x04000E6D RID: 3693
		public string NsXmlNs;

		// Token: 0x04000E6E RID: 3694
		public string NsXdr;

		// Token: 0x04000E6F RID: 3695
		public string NsXdrAlias;

		// Token: 0x04000E70 RID: 3696
		public string NsXs;

		// Token: 0x04000E71 RID: 3697
		public string NsXsi;

		// Token: 0x04000E72 RID: 3698
		public string XsiType;

		// Token: 0x04000E73 RID: 3699
		public string XsiNil;

		// Token: 0x04000E74 RID: 3700
		public string XsiSchemaLocation;

		// Token: 0x04000E75 RID: 3701
		public string XsiNoNamespaceSchemaLocation;

		// Token: 0x04000E76 RID: 3702
		public string XsdSchema;

		// Token: 0x04000E77 RID: 3703
		public string XdrSchema;

		// Token: 0x04000E78 RID: 3704
		public XmlQualifiedName QnPCData;

		// Token: 0x04000E79 RID: 3705
		public XmlQualifiedName QnXml;

		// Token: 0x04000E7A RID: 3706
		public XmlQualifiedName QnXmlNs;

		// Token: 0x04000E7B RID: 3707
		public XmlQualifiedName QnDtDt;

		// Token: 0x04000E7C RID: 3708
		public XmlQualifiedName QnXmlLang;

		// Token: 0x04000E7D RID: 3709
		public XmlQualifiedName QnName;

		// Token: 0x04000E7E RID: 3710
		public XmlQualifiedName QnType;

		// Token: 0x04000E7F RID: 3711
		public XmlQualifiedName QnMaxOccurs;

		// Token: 0x04000E80 RID: 3712
		public XmlQualifiedName QnMinOccurs;

		// Token: 0x04000E81 RID: 3713
		public XmlQualifiedName QnInfinite;

		// Token: 0x04000E82 RID: 3714
		public XmlQualifiedName QnModel;

		// Token: 0x04000E83 RID: 3715
		public XmlQualifiedName QnOpen;

		// Token: 0x04000E84 RID: 3716
		public XmlQualifiedName QnClosed;

		// Token: 0x04000E85 RID: 3717
		public XmlQualifiedName QnContent;

		// Token: 0x04000E86 RID: 3718
		public XmlQualifiedName QnMixed;

		// Token: 0x04000E87 RID: 3719
		public XmlQualifiedName QnEmpty;

		// Token: 0x04000E88 RID: 3720
		public XmlQualifiedName QnEltOnly;

		// Token: 0x04000E89 RID: 3721
		public XmlQualifiedName QnTextOnly;

		// Token: 0x04000E8A RID: 3722
		public XmlQualifiedName QnOrder;

		// Token: 0x04000E8B RID: 3723
		public XmlQualifiedName QnSeq;

		// Token: 0x04000E8C RID: 3724
		public XmlQualifiedName QnOne;

		// Token: 0x04000E8D RID: 3725
		public XmlQualifiedName QnMany;

		// Token: 0x04000E8E RID: 3726
		public XmlQualifiedName QnRequired;

		// Token: 0x04000E8F RID: 3727
		public XmlQualifiedName QnYes;

		// Token: 0x04000E90 RID: 3728
		public XmlQualifiedName QnNo;

		// Token: 0x04000E91 RID: 3729
		public XmlQualifiedName QnString;

		// Token: 0x04000E92 RID: 3730
		public XmlQualifiedName QnID;

		// Token: 0x04000E93 RID: 3731
		public XmlQualifiedName QnIDRef;

		// Token: 0x04000E94 RID: 3732
		public XmlQualifiedName QnIDRefs;

		// Token: 0x04000E95 RID: 3733
		public XmlQualifiedName QnEntity;

		// Token: 0x04000E96 RID: 3734
		public XmlQualifiedName QnEntities;

		// Token: 0x04000E97 RID: 3735
		public XmlQualifiedName QnNmToken;

		// Token: 0x04000E98 RID: 3736
		public XmlQualifiedName QnNmTokens;

		// Token: 0x04000E99 RID: 3737
		public XmlQualifiedName QnEnumeration;

		// Token: 0x04000E9A RID: 3738
		public XmlQualifiedName QnDefault;

		// Token: 0x04000E9B RID: 3739
		public XmlQualifiedName QnXdrSchema;

		// Token: 0x04000E9C RID: 3740
		public XmlQualifiedName QnXdrElementType;

		// Token: 0x04000E9D RID: 3741
		public XmlQualifiedName QnXdrElement;

		// Token: 0x04000E9E RID: 3742
		public XmlQualifiedName QnXdrGroup;

		// Token: 0x04000E9F RID: 3743
		public XmlQualifiedName QnXdrAttributeType;

		// Token: 0x04000EA0 RID: 3744
		public XmlQualifiedName QnXdrAttribute;

		// Token: 0x04000EA1 RID: 3745
		public XmlQualifiedName QnXdrDataType;

		// Token: 0x04000EA2 RID: 3746
		public XmlQualifiedName QnXdrDescription;

		// Token: 0x04000EA3 RID: 3747
		public XmlQualifiedName QnXdrExtends;

		// Token: 0x04000EA4 RID: 3748
		public XmlQualifiedName QnXdrAliasSchema;

		// Token: 0x04000EA5 RID: 3749
		public XmlQualifiedName QnDtType;

		// Token: 0x04000EA6 RID: 3750
		public XmlQualifiedName QnDtValues;

		// Token: 0x04000EA7 RID: 3751
		public XmlQualifiedName QnDtMaxLength;

		// Token: 0x04000EA8 RID: 3752
		public XmlQualifiedName QnDtMinLength;

		// Token: 0x04000EA9 RID: 3753
		public XmlQualifiedName QnDtMax;

		// Token: 0x04000EAA RID: 3754
		public XmlQualifiedName QnDtMin;

		// Token: 0x04000EAB RID: 3755
		public XmlQualifiedName QnDtMinExclusive;

		// Token: 0x04000EAC RID: 3756
		public XmlQualifiedName QnDtMaxExclusive;

		// Token: 0x04000EAD RID: 3757
		public XmlQualifiedName QnTargetNamespace;

		// Token: 0x04000EAE RID: 3758
		public XmlQualifiedName QnVersion;

		// Token: 0x04000EAF RID: 3759
		public XmlQualifiedName QnFinalDefault;

		// Token: 0x04000EB0 RID: 3760
		public XmlQualifiedName QnBlockDefault;

		// Token: 0x04000EB1 RID: 3761
		public XmlQualifiedName QnFixed;

		// Token: 0x04000EB2 RID: 3762
		public XmlQualifiedName QnAbstract;

		// Token: 0x04000EB3 RID: 3763
		public XmlQualifiedName QnBlock;

		// Token: 0x04000EB4 RID: 3764
		public XmlQualifiedName QnSubstitutionGroup;

		// Token: 0x04000EB5 RID: 3765
		public XmlQualifiedName QnFinal;

		// Token: 0x04000EB6 RID: 3766
		public XmlQualifiedName QnNillable;

		// Token: 0x04000EB7 RID: 3767
		public XmlQualifiedName QnRef;

		// Token: 0x04000EB8 RID: 3768
		public XmlQualifiedName QnBase;

		// Token: 0x04000EB9 RID: 3769
		public XmlQualifiedName QnDerivedBy;

		// Token: 0x04000EBA RID: 3770
		public XmlQualifiedName QnNamespace;

		// Token: 0x04000EBB RID: 3771
		public XmlQualifiedName QnProcessContents;

		// Token: 0x04000EBC RID: 3772
		public XmlQualifiedName QnRefer;

		// Token: 0x04000EBD RID: 3773
		public XmlQualifiedName QnPublic;

		// Token: 0x04000EBE RID: 3774
		public XmlQualifiedName QnSystem;

		// Token: 0x04000EBF RID: 3775
		public XmlQualifiedName QnSchemaLocation;

		// Token: 0x04000EC0 RID: 3776
		public XmlQualifiedName QnValue;

		// Token: 0x04000EC1 RID: 3777
		public XmlQualifiedName QnUse;

		// Token: 0x04000EC2 RID: 3778
		public XmlQualifiedName QnForm;

		// Token: 0x04000EC3 RID: 3779
		public XmlQualifiedName QnElementFormDefault;

		// Token: 0x04000EC4 RID: 3780
		public XmlQualifiedName QnAttributeFormDefault;

		// Token: 0x04000EC5 RID: 3781
		public XmlQualifiedName QnItemType;

		// Token: 0x04000EC6 RID: 3782
		public XmlQualifiedName QnMemberTypes;

		// Token: 0x04000EC7 RID: 3783
		public XmlQualifiedName QnXPath;

		// Token: 0x04000EC8 RID: 3784
		public XmlQualifiedName QnXsdSchema;

		// Token: 0x04000EC9 RID: 3785
		public XmlQualifiedName QnXsdAnnotation;

		// Token: 0x04000ECA RID: 3786
		public XmlQualifiedName QnXsdInclude;

		// Token: 0x04000ECB RID: 3787
		public XmlQualifiedName QnXsdImport;

		// Token: 0x04000ECC RID: 3788
		public XmlQualifiedName QnXsdElement;

		// Token: 0x04000ECD RID: 3789
		public XmlQualifiedName QnXsdAttribute;

		// Token: 0x04000ECE RID: 3790
		public XmlQualifiedName QnXsdAttributeGroup;

		// Token: 0x04000ECF RID: 3791
		public XmlQualifiedName QnXsdAnyAttribute;

		// Token: 0x04000ED0 RID: 3792
		public XmlQualifiedName QnXsdGroup;

		// Token: 0x04000ED1 RID: 3793
		public XmlQualifiedName QnXsdAll;

		// Token: 0x04000ED2 RID: 3794
		public XmlQualifiedName QnXsdChoice;

		// Token: 0x04000ED3 RID: 3795
		public XmlQualifiedName QnXsdSequence;

		// Token: 0x04000ED4 RID: 3796
		public XmlQualifiedName QnXsdAny;

		// Token: 0x04000ED5 RID: 3797
		public XmlQualifiedName QnXsdNotation;

		// Token: 0x04000ED6 RID: 3798
		public XmlQualifiedName QnXsdSimpleType;

		// Token: 0x04000ED7 RID: 3799
		public XmlQualifiedName QnXsdComplexType;

		// Token: 0x04000ED8 RID: 3800
		public XmlQualifiedName QnXsdUnique;

		// Token: 0x04000ED9 RID: 3801
		public XmlQualifiedName QnXsdKey;

		// Token: 0x04000EDA RID: 3802
		public XmlQualifiedName QnXsdKeyRef;

		// Token: 0x04000EDB RID: 3803
		public XmlQualifiedName QnXsdSelector;

		// Token: 0x04000EDC RID: 3804
		public XmlQualifiedName QnXsdField;

		// Token: 0x04000EDD RID: 3805
		public XmlQualifiedName QnXsdMinExclusive;

		// Token: 0x04000EDE RID: 3806
		public XmlQualifiedName QnXsdMinInclusive;

		// Token: 0x04000EDF RID: 3807
		public XmlQualifiedName QnXsdMaxInclusive;

		// Token: 0x04000EE0 RID: 3808
		public XmlQualifiedName QnXsdMaxExclusive;

		// Token: 0x04000EE1 RID: 3809
		public XmlQualifiedName QnXsdTotalDigits;

		// Token: 0x04000EE2 RID: 3810
		public XmlQualifiedName QnXsdFractionDigits;

		// Token: 0x04000EE3 RID: 3811
		public XmlQualifiedName QnXsdLength;

		// Token: 0x04000EE4 RID: 3812
		public XmlQualifiedName QnXsdMinLength;

		// Token: 0x04000EE5 RID: 3813
		public XmlQualifiedName QnXsdMaxLength;

		// Token: 0x04000EE6 RID: 3814
		public XmlQualifiedName QnXsdEnumeration;

		// Token: 0x04000EE7 RID: 3815
		public XmlQualifiedName QnXsdPattern;

		// Token: 0x04000EE8 RID: 3816
		public XmlQualifiedName QnXsdDocumentation;

		// Token: 0x04000EE9 RID: 3817
		public XmlQualifiedName QnXsdAppinfo;

		// Token: 0x04000EEA RID: 3818
		public XmlQualifiedName QnSource;

		// Token: 0x04000EEB RID: 3819
		public XmlQualifiedName QnXsdComplexContent;

		// Token: 0x04000EEC RID: 3820
		public XmlQualifiedName QnXsdSimpleContent;

		// Token: 0x04000EED RID: 3821
		public XmlQualifiedName QnXsdRestriction;

		// Token: 0x04000EEE RID: 3822
		public XmlQualifiedName QnXsdExtension;

		// Token: 0x04000EEF RID: 3823
		public XmlQualifiedName QnXsdUnion;

		// Token: 0x04000EF0 RID: 3824
		public XmlQualifiedName QnXsdList;

		// Token: 0x04000EF1 RID: 3825
		public XmlQualifiedName QnXsdWhiteSpace;

		// Token: 0x04000EF2 RID: 3826
		public XmlQualifiedName QnXsdRedefine;

		// Token: 0x04000EF3 RID: 3827
		public XmlQualifiedName QnXsdAnyType;

		// Token: 0x04000EF4 RID: 3828
		internal XmlQualifiedName[] TokenToQName = new XmlQualifiedName[123];

		// Token: 0x020002B7 RID: 695
		public enum Token
		{
			// Token: 0x04000EF6 RID: 3830
			Empty,
			// Token: 0x04000EF7 RID: 3831
			SchemaName,
			// Token: 0x04000EF8 RID: 3832
			SchemaType,
			// Token: 0x04000EF9 RID: 3833
			SchemaMaxOccurs,
			// Token: 0x04000EFA RID: 3834
			SchemaMinOccurs,
			// Token: 0x04000EFB RID: 3835
			SchemaInfinite,
			// Token: 0x04000EFC RID: 3836
			SchemaModel,
			// Token: 0x04000EFD RID: 3837
			SchemaOpen,
			// Token: 0x04000EFE RID: 3838
			SchemaClosed,
			// Token: 0x04000EFF RID: 3839
			SchemaContent,
			// Token: 0x04000F00 RID: 3840
			SchemaMixed,
			// Token: 0x04000F01 RID: 3841
			SchemaEmpty,
			// Token: 0x04000F02 RID: 3842
			SchemaElementOnly,
			// Token: 0x04000F03 RID: 3843
			SchemaTextOnly,
			// Token: 0x04000F04 RID: 3844
			SchemaOrder,
			// Token: 0x04000F05 RID: 3845
			SchemaSeq,
			// Token: 0x04000F06 RID: 3846
			SchemaOne,
			// Token: 0x04000F07 RID: 3847
			SchemaMany,
			// Token: 0x04000F08 RID: 3848
			SchemaRequired,
			// Token: 0x04000F09 RID: 3849
			SchemaYes,
			// Token: 0x04000F0A RID: 3850
			SchemaNo,
			// Token: 0x04000F0B RID: 3851
			SchemaString,
			// Token: 0x04000F0C RID: 3852
			SchemaId,
			// Token: 0x04000F0D RID: 3853
			SchemaIdref,
			// Token: 0x04000F0E RID: 3854
			SchemaIdrefs,
			// Token: 0x04000F0F RID: 3855
			SchemaEntity,
			// Token: 0x04000F10 RID: 3856
			SchemaEntities,
			// Token: 0x04000F11 RID: 3857
			SchemaNmtoken,
			// Token: 0x04000F12 RID: 3858
			SchemaNmtokens,
			// Token: 0x04000F13 RID: 3859
			SchemaEnumeration,
			// Token: 0x04000F14 RID: 3860
			SchemaDefault,
			// Token: 0x04000F15 RID: 3861
			XdrRoot,
			// Token: 0x04000F16 RID: 3862
			XdrElementType,
			// Token: 0x04000F17 RID: 3863
			XdrElement,
			// Token: 0x04000F18 RID: 3864
			XdrGroup,
			// Token: 0x04000F19 RID: 3865
			XdrAttributeType,
			// Token: 0x04000F1A RID: 3866
			XdrAttribute,
			// Token: 0x04000F1B RID: 3867
			XdrDatatype,
			// Token: 0x04000F1C RID: 3868
			XdrDescription,
			// Token: 0x04000F1D RID: 3869
			XdrExtends,
			// Token: 0x04000F1E RID: 3870
			SchemaXdrRootAlias,
			// Token: 0x04000F1F RID: 3871
			SchemaDtType,
			// Token: 0x04000F20 RID: 3872
			SchemaDtValues,
			// Token: 0x04000F21 RID: 3873
			SchemaDtMaxLength,
			// Token: 0x04000F22 RID: 3874
			SchemaDtMinLength,
			// Token: 0x04000F23 RID: 3875
			SchemaDtMax,
			// Token: 0x04000F24 RID: 3876
			SchemaDtMin,
			// Token: 0x04000F25 RID: 3877
			SchemaDtMinExclusive,
			// Token: 0x04000F26 RID: 3878
			SchemaDtMaxExclusive,
			// Token: 0x04000F27 RID: 3879
			SchemaTargetNamespace,
			// Token: 0x04000F28 RID: 3880
			SchemaVersion,
			// Token: 0x04000F29 RID: 3881
			SchemaFinalDefault,
			// Token: 0x04000F2A RID: 3882
			SchemaBlockDefault,
			// Token: 0x04000F2B RID: 3883
			SchemaFixed,
			// Token: 0x04000F2C RID: 3884
			SchemaAbstract,
			// Token: 0x04000F2D RID: 3885
			SchemaBlock,
			// Token: 0x04000F2E RID: 3886
			SchemaSubstitutionGroup,
			// Token: 0x04000F2F RID: 3887
			SchemaFinal,
			// Token: 0x04000F30 RID: 3888
			SchemaNillable,
			// Token: 0x04000F31 RID: 3889
			SchemaRef,
			// Token: 0x04000F32 RID: 3890
			SchemaBase,
			// Token: 0x04000F33 RID: 3891
			SchemaDerivedBy,
			// Token: 0x04000F34 RID: 3892
			SchemaNamespace,
			// Token: 0x04000F35 RID: 3893
			SchemaProcessContents,
			// Token: 0x04000F36 RID: 3894
			SchemaRefer,
			// Token: 0x04000F37 RID: 3895
			SchemaPublic,
			// Token: 0x04000F38 RID: 3896
			SchemaSystem,
			// Token: 0x04000F39 RID: 3897
			SchemaSchemaLocation,
			// Token: 0x04000F3A RID: 3898
			SchemaValue,
			// Token: 0x04000F3B RID: 3899
			SchemaSource,
			// Token: 0x04000F3C RID: 3900
			SchemaAttributeFormDefault,
			// Token: 0x04000F3D RID: 3901
			SchemaElementFormDefault,
			// Token: 0x04000F3E RID: 3902
			SchemaUse,
			// Token: 0x04000F3F RID: 3903
			SchemaForm,
			// Token: 0x04000F40 RID: 3904
			XsdSchema,
			// Token: 0x04000F41 RID: 3905
			XsdAnnotation,
			// Token: 0x04000F42 RID: 3906
			XsdInclude,
			// Token: 0x04000F43 RID: 3907
			XsdImport,
			// Token: 0x04000F44 RID: 3908
			XsdElement,
			// Token: 0x04000F45 RID: 3909
			XsdAttribute,
			// Token: 0x04000F46 RID: 3910
			xsdAttributeGroup,
			// Token: 0x04000F47 RID: 3911
			XsdAnyAttribute,
			// Token: 0x04000F48 RID: 3912
			XsdGroup,
			// Token: 0x04000F49 RID: 3913
			XsdAll,
			// Token: 0x04000F4A RID: 3914
			XsdChoice,
			// Token: 0x04000F4B RID: 3915
			XsdSequence,
			// Token: 0x04000F4C RID: 3916
			XsdAny,
			// Token: 0x04000F4D RID: 3917
			XsdNotation,
			// Token: 0x04000F4E RID: 3918
			XsdSimpleType,
			// Token: 0x04000F4F RID: 3919
			XsdComplexType,
			// Token: 0x04000F50 RID: 3920
			XsdUnique,
			// Token: 0x04000F51 RID: 3921
			XsdKey,
			// Token: 0x04000F52 RID: 3922
			XsdKeyref,
			// Token: 0x04000F53 RID: 3923
			XsdSelector,
			// Token: 0x04000F54 RID: 3924
			XsdField,
			// Token: 0x04000F55 RID: 3925
			XsdMinExclusive,
			// Token: 0x04000F56 RID: 3926
			XsdMinInclusive,
			// Token: 0x04000F57 RID: 3927
			XsdMaxExclusive,
			// Token: 0x04000F58 RID: 3928
			XsdMaxInclusive,
			// Token: 0x04000F59 RID: 3929
			XsdTotalDigits,
			// Token: 0x04000F5A RID: 3930
			XsdFractionDigits,
			// Token: 0x04000F5B RID: 3931
			XsdLength,
			// Token: 0x04000F5C RID: 3932
			XsdMinLength,
			// Token: 0x04000F5D RID: 3933
			XsdMaxLength,
			// Token: 0x04000F5E RID: 3934
			XsdEnumeration,
			// Token: 0x04000F5F RID: 3935
			XsdPattern,
			// Token: 0x04000F60 RID: 3936
			XsdDocumentation,
			// Token: 0x04000F61 RID: 3937
			XsdAppInfo,
			// Token: 0x04000F62 RID: 3938
			XsdComplexContent,
			// Token: 0x04000F63 RID: 3939
			XsdComplexContentExtension,
			// Token: 0x04000F64 RID: 3940
			XsdComplexContentRestriction,
			// Token: 0x04000F65 RID: 3941
			XsdSimpleContent,
			// Token: 0x04000F66 RID: 3942
			XsdSimpleContentExtension,
			// Token: 0x04000F67 RID: 3943
			XsdSimpleContentRestriction,
			// Token: 0x04000F68 RID: 3944
			XsdSimpleTypeList,
			// Token: 0x04000F69 RID: 3945
			XsdSimpleTypeRestriction,
			// Token: 0x04000F6A RID: 3946
			XsdSimpleTypeUnion,
			// Token: 0x04000F6B RID: 3947
			XsdWhitespace,
			// Token: 0x04000F6C RID: 3948
			XsdRedefine,
			// Token: 0x04000F6D RID: 3949
			SchemaItemType,
			// Token: 0x04000F6E RID: 3950
			SchemaMemberTypes,
			// Token: 0x04000F6F RID: 3951
			SchemaXPath,
			// Token: 0x04000F70 RID: 3952
			XmlLang
		}
	}
}
