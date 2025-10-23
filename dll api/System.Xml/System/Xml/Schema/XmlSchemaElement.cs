using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="element" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is the base class for all particle types and is used to describe an element in an XML document.</summary>
	// Token: 0x020002E9 RID: 745
	public class XmlSchemaElement : XmlSchemaParticle
	{
		/// <summary>Gets or sets information to indicate if the element can be used in an instance document.</summary>
		/// <returns>If <see langword="true" />, the element cannot appear in the instance document. The default is <see langword="false" />.Optional.</returns>
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000976DC File Offset: 0x000958DC
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x000976E4 File Offset: 0x000958E4
		[XmlAttribute("abstract")]
		[DefaultValue(false)]
		public bool IsAbstract
		{
			get
			{
				return this.isAbstract;
			}
			set
			{
				this.isAbstract = value;
				this.hasAbstractAttribute = true;
			}
		}

		/// <summary>Gets or sets a <see langword="Block" /> derivation.</summary>
		/// <returns>The attribute used to block a type derivation. Default value is <see langword="XmlSchemaDerivationMethod.None" />.Optional.</returns>
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x000976F4 File Offset: 0x000958F4
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x000976FC File Offset: 0x000958FC
		[XmlAttribute("block")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod Block
		{
			get
			{
				return this.block;
			}
			set
			{
				this.block = value;
			}
		}

		/// <summary>Gets or sets the default value of the element if its content is a simple type or content of the element is <see langword="textOnly" />.</summary>
		/// <returns>The default value for the element. The default is a null reference.Optional.</returns>
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00097705 File Offset: 0x00095905
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0009770D File Offset: 0x0009590D
		[XmlAttribute("default")]
		[DefaultValue(null)]
		public string DefaultValue
		{
			get
			{
				return this.defaultValue;
			}
			set
			{
				this.defaultValue = value;
			}
		}

		/// <summary>Gets or sets the <see langword="Final" /> property to indicate that no further derivations are allowed.</summary>
		/// <returns>The <see langword="Final" /> property. The default is <see langword="XmlSchemaDerivationMethod.None" />.Optional.</returns>
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00097716 File Offset: 0x00095916
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0009771E File Offset: 0x0009591E
		[XmlAttribute("final")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod Final
		{
			get
			{
				return this.final;
			}
			set
			{
				this.final = value;
			}
		}

		/// <summary>Gets or sets the fixed value.</summary>
		/// <returns>The fixed value that is predetermined and unchangeable. The default is a null reference.Optional.</returns>
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x00097727 File Offset: 0x00095927
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0009772F File Offset: 0x0009592F
		[XmlAttribute("fixed")]
		[DefaultValue(null)]
		public string FixedValue
		{
			get
			{
				return this.fixedValue;
			}
			set
			{
				this.fixedValue = value;
			}
		}

		/// <summary>Gets or sets the form for the element.</summary>
		/// <returns>The form for the element. The default is the <see cref="P:System.Xml.Schema.XmlSchema.ElementFormDefault" /> value.Optional.</returns>
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00097738 File Offset: 0x00095938
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x00097740 File Offset: 0x00095940
		[XmlAttribute("form")]
		[DefaultValue(XmlSchemaForm.None)]
		public XmlSchemaForm Form
		{
			get
			{
				return this.form;
			}
			set
			{
				this.form = value;
			}
		}

		/// <summary>Gets or sets the name of the element.</summary>
		/// <returns>The name of the element. The default is <see langword="String.Empty" />.</returns>
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00097749 File Offset: 0x00095949
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00097751 File Offset: 0x00095951
		[XmlAttribute("name")]
		[DefaultValue("")]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets information that indicates if <see langword="xsi:nil" /> can occur in the instance data. Indicates if an explicit nil value can be assigned to the element.</summary>
		/// <returns>If nillable is <see langword="true" />, this enables an instance of the element to have the <see langword="nil" /> attribute set to <see langword="true" />. The <see langword="nil" /> attribute is defined as part of the XML Schema namespace for instances. The default is <see langword="false" />.Optional.</returns>
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x0009775A File Offset: 0x0009595A
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00097762 File Offset: 0x00095962
		[XmlAttribute("nillable")]
		[DefaultValue(false)]
		public bool IsNillable
		{
			get
			{
				return this.isNillable;
			}
			set
			{
				this.isNillable = value;
				this.hasNillableAttribute = true;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00097772 File Offset: 0x00095972
		[XmlIgnore]
		internal bool HasNillableAttribute
		{
			get
			{
				return this.hasNillableAttribute;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0009777A File Offset: 0x0009597A
		[XmlIgnore]
		internal bool HasAbstractAttribute
		{
			get
			{
				return this.hasAbstractAttribute;
			}
		}

		/// <summary>Gets or sets the reference name of an element declared in this schema (or another schema indicated by the specified namespace).</summary>
		/// <returns>The reference name of the element.</returns>
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00097782 File Offset: 0x00095982
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0009778A File Offset: 0x0009598A
		[XmlAttribute("ref")]
		public XmlQualifiedName RefName
		{
			get
			{
				return this.refName;
			}
			set
			{
				this.refName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>Gets or sets the name of an element that is being substituted by this element.</summary>
		/// <returns>The qualified name of an element that is being substituted by this element.Optional.</returns>
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x000977A3 File Offset: 0x000959A3
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x000977AB File Offset: 0x000959AB
		[XmlAttribute("substitutionGroup")]
		public XmlQualifiedName SubstitutionGroup
		{
			get
			{
				return this.substitutionGroup;
			}
			set
			{
				this.substitutionGroup = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>Gets or sets the name of a built-in data type defined in this schema or another schema indicated by the specified namespace.</summary>
		/// <returns>The name of the built-in data type.</returns>
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x000977C4 File Offset: 0x000959C4
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x000977CC File Offset: 0x000959CC
		[XmlAttribute("type")]
		public XmlQualifiedName SchemaTypeName
		{
			get
			{
				return this.typeName;
			}
			set
			{
				this.typeName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>Gets or sets the type of the element. This can either be a complex type or a simple type.</summary>
		/// <returns>The type of the element.</returns>
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000977E5 File Offset: 0x000959E5
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x000977ED File Offset: 0x000959ED
		[XmlElement("complexType", typeof(XmlSchemaComplexType))]
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaType SchemaType
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		/// <summary>Gets the collection of constraints on the element.</summary>
		/// <returns>The collection of constraints.</returns>
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000977F6 File Offset: 0x000959F6
		[XmlElement("key", typeof(XmlSchemaKey))]
		[XmlElement("keyref", typeof(XmlSchemaKeyref))]
		[XmlElement("unique", typeof(XmlSchemaUnique))]
		public XmlSchemaObjectCollection Constraints
		{
			get
			{
				if (this.constraints == null)
				{
					this.constraints = new XmlSchemaObjectCollection();
				}
				return this.constraints;
			}
		}

		/// <summary>Gets the actual qualified name for the given element. </summary>
		/// <returns>The qualified name of the element. The post-compilation value of the <see langword="QualifiedName" /> property.</returns>
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00097811 File Offset: 0x00095A11
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qualifiedName;
			}
		}

		/// <summary>Gets an <see cref="T:System.Xml.Schema.XmlSchemaType" /> object representing the type of the element based on the <see cref="P:System.Xml.Schema.XmlSchemaElement.SchemaType" /> or <see cref="P:System.Xml.Schema.XmlSchemaElement.SchemaTypeName" /> values of the element.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object.</returns>
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00097819 File Offset: 0x00095A19
		[XmlIgnore]
		public XmlSchemaType ElementSchemaType
		{
			get
			{
				return this.elementType;
			}
		}

		/// <summary>Gets the post-compilation value of the <see langword="Block" /> property.</summary>
		/// <returns>The post-compilation value of the <see langword="Block" /> property. The default is the <see langword="BlockDefault" /> value on the <see langword="schema" /> element.</returns>
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00097821 File Offset: 0x00095A21
		[XmlIgnore]
		public XmlSchemaDerivationMethod BlockResolved
		{
			get
			{
				return this.blockResolved;
			}
		}

		/// <summary>Gets the post-compilation value of the <see langword="Final" /> property.</summary>
		/// <returns>The post-compilation value of the <see langword="Final" /> property. Default value is the <see langword="FinalDefault" /> value on the <see langword="schema" /> element.</returns>
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00097829 File Offset: 0x00095A29
		[XmlIgnore]
		public XmlSchemaDerivationMethod FinalResolved
		{
			get
			{
				return this.finalResolved;
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00097831 File Offset: 0x00095A31
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qualifiedName = value;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0009783A File Offset: 0x00095A3A
		internal void SetElementType(XmlSchemaType value)
		{
			this.elementType = value;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00097843 File Offset: 0x00095A43
		internal void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
			this.blockResolved = value;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0009784C File Offset: 0x00095A4C
		internal void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
			this.finalResolved = value;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00097855 File Offset: 0x00095A55
		internal bool HasConstraints
		{
			get
			{
				return this.constraints != null && this.constraints.Count > 0;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0009786F File Offset: 0x00095A6F
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00097877 File Offset: 0x00095A77
		internal bool IsLocalTypeDerivationChecked
		{
			get
			{
				return this.isLocalTypeDerivationChecked;
			}
			set
			{
				this.isLocalTypeDerivationChecked = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00097880 File Offset: 0x00095A80
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x00097888 File Offset: 0x00095A88
		internal SchemaElementDecl ElementDecl
		{
			get
			{
				return this.elementDecl;
			}
			set
			{
				this.elementDecl = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00097891 File Offset: 0x00095A91
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00097899 File Offset: 0x00095A99
		[XmlIgnore]
		internal override string NameAttribute
		{
			get
			{
				return this.Name;
			}
			set
			{
				this.Name = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x000978A2 File Offset: 0x00095AA2
		[XmlIgnore]
		internal override string NameString
		{
			get
			{
				return this.qualifiedName.ToString();
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000978AF File Offset: 0x00095AAF
		internal override XmlSchemaObject Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000978B8 File Offset: 0x00095AB8
		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)base.MemberwiseClone();
			xmlSchemaElement.refName = this.refName.Clone();
			xmlSchemaElement.substitutionGroup = this.substitutionGroup.Clone();
			xmlSchemaElement.typeName = this.typeName.Clone();
			xmlSchemaElement.qualifiedName = this.qualifiedName.Clone();
			XmlSchemaComplexType xmlSchemaComplexType = this.type as XmlSchemaComplexType;
			if (xmlSchemaComplexType != null && xmlSchemaComplexType.QualifiedName.IsEmpty)
			{
				xmlSchemaElement.type = (XmlSchemaType)xmlSchemaComplexType.Clone(parentSchema);
			}
			xmlSchemaElement.constraints = null;
			return xmlSchemaElement;
		}

		// Token: 0x04001090 RID: 4240
		private bool isAbstract;

		// Token: 0x04001091 RID: 4241
		private bool hasAbstractAttribute;

		// Token: 0x04001092 RID: 4242
		private bool isNillable;

		// Token: 0x04001093 RID: 4243
		private bool hasNillableAttribute;

		// Token: 0x04001094 RID: 4244
		private bool isLocalTypeDerivationChecked;

		// Token: 0x04001095 RID: 4245
		private XmlSchemaDerivationMethod block = XmlSchemaDerivationMethod.None;

		// Token: 0x04001096 RID: 4246
		private XmlSchemaDerivationMethod final = XmlSchemaDerivationMethod.None;

		// Token: 0x04001097 RID: 4247
		private XmlSchemaForm form;

		// Token: 0x04001098 RID: 4248
		private string defaultValue;

		// Token: 0x04001099 RID: 4249
		private string fixedValue;

		// Token: 0x0400109A RID: 4250
		private string name;

		// Token: 0x0400109B RID: 4251
		private XmlQualifiedName refName = XmlQualifiedName.Empty;

		// Token: 0x0400109C RID: 4252
		private XmlQualifiedName substitutionGroup = XmlQualifiedName.Empty;

		// Token: 0x0400109D RID: 4253
		private XmlQualifiedName typeName = XmlQualifiedName.Empty;

		// Token: 0x0400109E RID: 4254
		private XmlSchemaType type;

		// Token: 0x0400109F RID: 4255
		private XmlQualifiedName qualifiedName = XmlQualifiedName.Empty;

		// Token: 0x040010A0 RID: 4256
		private XmlSchemaType elementType;

		// Token: 0x040010A1 RID: 4257
		private XmlSchemaDerivationMethod blockResolved;

		// Token: 0x040010A2 RID: 4258
		private XmlSchemaDerivationMethod finalResolved;

		// Token: 0x040010A3 RID: 4259
		private XmlSchemaObjectCollection constraints;

		// Token: 0x040010A4 RID: 4260
		private SchemaElementDecl elementDecl;
	}
}
