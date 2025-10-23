using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="complexType" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class defines a complex type that determines the set of attributes and content of an element.</summary>
	// Token: 0x020002E1 RID: 737
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x060018A4 RID: 6308 RVA: 0x00096930 File Offset: 0x00094B30
		static XmlSchemaComplexType()
		{
			XmlSchemaComplexType.untypedAnyType.SetQualifiedName(new XmlQualifiedName("untypedAny", "http://www.w3.org/2003/11/xpath-datatypes"));
			XmlSchemaComplexType.untypedAnyType.IsMixed = true;
			XmlSchemaComplexType.untypedAnyType.SetContentTypeParticle(XmlSchemaComplexType.anyTypeLax.ContentTypeParticle);
			XmlSchemaComplexType.untypedAnyType.SetContentType(XmlSchemaContentType.Mixed);
			XmlSchemaComplexType.untypedAnyType.ElementDecl = SchemaElementDecl.CreateAnyTypeElementDecl();
			XmlSchemaComplexType.untypedAnyType.ElementDecl.SchemaType = XmlSchemaComplexType.untypedAnyType;
			XmlSchemaComplexType.untypedAnyType.ElementDecl.ContentValidator = XmlSchemaComplexType.AnyTypeContentValidator;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000969D8 File Offset: 0x00094BD8
		private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			xmlSchemaComplexType.SetQualifiedName(DatatypeImplementation.QnAnyType);
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = processContents;
			xmlSchemaAny.BuildNamespaceList(null);
			xmlSchemaComplexType.SetContentTypeParticle(new XmlSchemaSequence
			{
				Items = 
				{
					xmlSchemaAny
				}
			});
			xmlSchemaComplexType.SetContentType(XmlSchemaContentType.Mixed);
			xmlSchemaComplexType.ElementDecl = SchemaElementDecl.CreateAnyTypeElementDecl();
			xmlSchemaComplexType.ElementDecl.SchemaType = xmlSchemaComplexType;
			ParticleContentValidator particleContentValidator = new ParticleContentValidator(XmlSchemaContentType.Mixed);
			particleContentValidator.Start();
			particleContentValidator.OpenGroup();
			particleContentValidator.AddNamespaceList(xmlSchemaAny.NamespaceList, xmlSchemaAny);
			particleContentValidator.AddStar();
			particleContentValidator.CloseGroup();
			ContentValidator contentValidator = particleContentValidator.Finish(true);
			xmlSchemaComplexType.ElementDecl.ContentValidator = contentValidator;
			XmlSchemaAnyAttribute xmlSchemaAnyAttribute = new XmlSchemaAnyAttribute();
			xmlSchemaAnyAttribute.ProcessContents = processContents;
			xmlSchemaAnyAttribute.BuildNamespaceList(null);
			xmlSchemaComplexType.SetAttributeWildcard(xmlSchemaAnyAttribute);
			xmlSchemaComplexType.ElementDecl.AnyAttribute = xmlSchemaAnyAttribute;
			return xmlSchemaComplexType;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00096AE6 File Offset: 0x00094CE6
		[XmlIgnore]
		internal static XmlSchemaComplexType AnyType
		{
			get
			{
				return XmlSchemaComplexType.anyTypeLax;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00096AED File Offset: 0x00094CED
		[XmlIgnore]
		internal static XmlSchemaComplexType UntypedAnyType
		{
			get
			{
				return XmlSchemaComplexType.untypedAnyType;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00096AF4 File Offset: 0x00094CF4
		internal static ContentValidator AnyTypeContentValidator
		{
			get
			{
				return XmlSchemaComplexType.anyTypeLax.ElementDecl.ContentValidator;
			}
		}

		/// <summary>Gets or sets the information that determines if the <see langword="complexType" /> element can be used in the instance document.</summary>
		/// <returns>If <see langword="true" />, an element cannot use this <see langword="complexType" /> element directly and must use a complex type that is derived from this <see langword="complexType" /> element. The default is <see langword="false" />.Optional.</returns>
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00096B05 File Offset: 0x00094D05
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x00096B12 File Offset: 0x00094D12
		[XmlAttribute("abstract")]
		[DefaultValue(false)]
		public bool IsAbstract
		{
			get
			{
				return (this.pvFlags & 4) > 0;
			}
			set
			{
				if (value)
				{
					this.pvFlags |= 4;
					return;
				}
				this.pvFlags = (byte)((int)this.pvFlags & -5);
			}
		}

		/// <summary>Gets or sets the <see langword="block" /> attribute.</summary>
		/// <returns>The <see langword="block" /> attribute prevents a complex type from being used in the specified type of derivation. The default is <see langword="XmlSchemaDerivationMethod.None" />.Optional.</returns>
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00096B37 File Offset: 0x00094D37
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00096B3F File Offset: 0x00094D3F
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

		/// <summary>Gets or sets information that determines if the complex type has a mixed content model (markup within the content).</summary>
		/// <returns>
		///     <see langword="true" />, if character data can appear between child elements of this complex type; otherwise, <see langword="false" />. The default is <see langword="false" />.Optional.</returns>
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00096B48 File Offset: 0x00094D48
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00096B55 File Offset: 0x00094D55
		[XmlAttribute("mixed")]
		[DefaultValue(false)]
		public override bool IsMixed
		{
			get
			{
				return (this.pvFlags & 2) > 0;
			}
			set
			{
				if (value)
				{
					this.pvFlags |= 2;
					return;
				}
				this.pvFlags = (byte)((int)this.pvFlags & -3);
			}
		}

		/// <summary>Gets or sets the post-compilation <see cref="T:System.Xml.Schema.XmlSchemaContentModel" /> of this complex type.</summary>
		/// <returns>The content model type that is one of the <see cref="T:System.Xml.Schema.XmlSchemaSimpleContent" /> or <see cref="T:System.Xml.Schema.XmlSchemaComplexContent" /> classes.</returns>
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00096B7A File Offset: 0x00094D7A
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00096B82 File Offset: 0x00094D82
		[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
		[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
		public XmlSchemaContentModel ContentModel
		{
			get
			{
				return this.contentModel;
			}
			set
			{
				this.contentModel = value;
			}
		}

		/// <summary>Gets or sets the compositor type as one of the <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</summary>
		/// <returns>The compositor type.</returns>
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00096B8B File Offset: 0x00094D8B
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00096B93 File Offset: 0x00094D93
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		public XmlSchemaParticle Particle
		{
			get
			{
				return this.particle;
			}
			set
			{
				this.particle = value;
			}
		}

		/// <summary>Gets the collection of attributes for the complex type.</summary>
		/// <returns>Contains <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> classes.</returns>
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00096B9C File Offset: 0x00094D9C
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				if (this.attributes == null)
				{
					this.attributes = new XmlSchemaObjectCollection();
				}
				return this.attributes;
			}
		}

		/// <summary>Gets or sets the value for the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex type.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex type.</returns>
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x00096BB7 File Offset: 0x00094DB7
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x00096BBF File Offset: 0x00094DBF
		[XmlElement("anyAttribute")]
		public XmlSchemaAnyAttribute AnyAttribute
		{
			get
			{
				return this.anyAttribute;
			}
			set
			{
				this.anyAttribute = value;
			}
		}

		/// <summary>Gets the content model of the complex type which holds the post-compilation value.</summary>
		/// <returns>The post-compilation value of the content model for the complex type.</returns>
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x00096BC8 File Offset: 0x00094DC8
		[XmlIgnore]
		public XmlSchemaContentType ContentType
		{
			get
			{
				return base.SchemaContentType;
			}
		}

		/// <summary>Gets the particle that holds the post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaComplexType.ContentType" /> particle.</summary>
		/// <returns>The particle for the content type. The post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaComplexType.ContentType" /> particle.</returns>
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00096BD0 File Offset: 0x00094DD0
		[XmlIgnore]
		public XmlSchemaParticle ContentTypeParticle
		{
			get
			{
				return this.contentTypeParticle;
			}
		}

		/// <summary>Gets the value after the type has been compiled to the post-schema-validation information set (infoset). This value indicates how the type is enforced when <see langword="xsi:type" /> is used in the instance document.</summary>
		/// <returns>The post-schema-validated infoset value. The default is <see langword="BlockDefault" /> value on the <see langword="schema" /> element.</returns>
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x00096BD8 File Offset: 0x00094DD8
		[XmlIgnore]
		public XmlSchemaDerivationMethod BlockResolved
		{
			get
			{
				return this.blockResolved;
			}
		}

		/// <summary>Gets the collection of all the complied attributes of this complex type and its base types.</summary>
		/// <returns>The collection of all the attributes from this complex type and its base types. The post-compilation value of the <see langword="AttributeUses" /> property.</returns>
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00096BE0 File Offset: 0x00094DE0
		[XmlIgnore]
		public XmlSchemaObjectTable AttributeUses
		{
			get
			{
				if (this.attributeUses == null)
				{
					this.attributeUses = new XmlSchemaObjectTable();
				}
				return this.attributeUses;
			}
		}

		/// <summary>Gets the post-compilation value for <see langword="anyAttribute" /> for this complex type and its base type(s).</summary>
		/// <returns>The post-compilation value of the <see langword="anyAttribute" /> element.</returns>
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x00096BFB File Offset: 0x00094DFB
		[XmlIgnore]
		public XmlSchemaAnyAttribute AttributeWildcard
		{
			get
			{
				return this.attributeWildcard;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00096C03 File Offset: 0x00094E03
		[XmlIgnore]
		internal XmlSchemaObjectTable LocalElements
		{
			get
			{
				if (this.localElements == null)
				{
					this.localElements = new XmlSchemaObjectTable();
				}
				return this.localElements;
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00096C1E File Offset: 0x00094E1E
		internal void SetContentTypeParticle(XmlSchemaParticle value)
		{
			this.contentTypeParticle = value;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00096C27 File Offset: 0x00094E27
		internal void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
			this.blockResolved = value;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00096C30 File Offset: 0x00094E30
		internal void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
			this.attributeWildcard = value;
		}

		// Token: 0x170005B7 RID: 1463
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00096C39 File Offset: 0x00094E39
		internal bool HasWildCard
		{
			set
			{
				if (value)
				{
					this.pvFlags |= 1;
					return;
				}
				this.pvFlags = (byte)((int)this.pvFlags & -2);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00096C5E File Offset: 0x00094E5E
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00096C68 File Offset: 0x00094E68
		internal bool ContainsIdAttribute(bool findAll)
		{
			int num = 0;
			foreach (object obj in this.AttributeUses.Values)
			{
				XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)obj;
				if (xmlSchemaAttribute.Use != XmlSchemaUse.Prohibited)
				{
					XmlSchemaDatatype datatype = xmlSchemaAttribute.Datatype;
					if (datatype != null && datatype.TypeCode == XmlTypeCode.Id)
					{
						num++;
						if (num > 1)
						{
							break;
						}
					}
				}
			}
			if (!findAll)
			{
				return num > 0;
			}
			return num > 1;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00096CF8 File Offset: 0x00094EF8
		internal override XmlSchemaObject Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00096D04 File Offset: 0x00094F04
		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			XmlSchemaComplexType xmlSchemaComplexType = (XmlSchemaComplexType)base.MemberwiseClone();
			if (xmlSchemaComplexType.ContentModel != null)
			{
				XmlSchemaSimpleContent xmlSchemaSimpleContent = xmlSchemaComplexType.ContentModel as XmlSchemaSimpleContent;
				if (xmlSchemaSimpleContent != null)
				{
					XmlSchemaSimpleContent xmlSchemaSimpleContent2 = (XmlSchemaSimpleContent)xmlSchemaSimpleContent.Clone();
					XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = xmlSchemaSimpleContent.Content as XmlSchemaSimpleContentExtension;
					if (xmlSchemaSimpleContentExtension != null)
					{
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension2 = (XmlSchemaSimpleContentExtension)xmlSchemaSimpleContentExtension.Clone();
						xmlSchemaSimpleContentExtension2.BaseTypeName = xmlSchemaSimpleContentExtension.BaseTypeName.Clone();
						xmlSchemaSimpleContentExtension2.SetAttributes(XmlSchemaComplexType.CloneAttributes(xmlSchemaSimpleContentExtension.Attributes));
						xmlSchemaSimpleContent2.Content = xmlSchemaSimpleContentExtension2;
					}
					else
					{
						XmlSchemaSimpleContentRestriction xmlSchemaSimpleContentRestriction = (XmlSchemaSimpleContentRestriction)xmlSchemaSimpleContent.Content;
						XmlSchemaSimpleContentRestriction xmlSchemaSimpleContentRestriction2 = (XmlSchemaSimpleContentRestriction)xmlSchemaSimpleContentRestriction.Clone();
						xmlSchemaSimpleContentRestriction2.BaseTypeName = xmlSchemaSimpleContentRestriction.BaseTypeName.Clone();
						xmlSchemaSimpleContentRestriction2.SetAttributes(XmlSchemaComplexType.CloneAttributes(xmlSchemaSimpleContentRestriction.Attributes));
						xmlSchemaSimpleContent2.Content = xmlSchemaSimpleContentRestriction2;
					}
					xmlSchemaComplexType.ContentModel = xmlSchemaSimpleContent2;
				}
				else
				{
					XmlSchemaComplexContent xmlSchemaComplexContent = (XmlSchemaComplexContent)xmlSchemaComplexType.ContentModel;
					XmlSchemaComplexContent xmlSchemaComplexContent2 = (XmlSchemaComplexContent)xmlSchemaComplexContent.Clone();
					XmlSchemaComplexContentExtension xmlSchemaComplexContentExtension = xmlSchemaComplexContent.Content as XmlSchemaComplexContentExtension;
					if (xmlSchemaComplexContentExtension != null)
					{
						XmlSchemaComplexContentExtension xmlSchemaComplexContentExtension2 = (XmlSchemaComplexContentExtension)xmlSchemaComplexContentExtension.Clone();
						xmlSchemaComplexContentExtension2.BaseTypeName = xmlSchemaComplexContentExtension.BaseTypeName.Clone();
						xmlSchemaComplexContentExtension2.SetAttributes(XmlSchemaComplexType.CloneAttributes(xmlSchemaComplexContentExtension.Attributes));
						if (XmlSchemaComplexType.HasParticleRef(xmlSchemaComplexContentExtension.Particle, parentSchema))
						{
							xmlSchemaComplexContentExtension2.Particle = XmlSchemaComplexType.CloneParticle(xmlSchemaComplexContentExtension.Particle, parentSchema);
						}
						xmlSchemaComplexContent2.Content = xmlSchemaComplexContentExtension2;
					}
					else
					{
						XmlSchemaComplexContentRestriction xmlSchemaComplexContentRestriction = xmlSchemaComplexContent.Content as XmlSchemaComplexContentRestriction;
						XmlSchemaComplexContentRestriction xmlSchemaComplexContentRestriction2 = (XmlSchemaComplexContentRestriction)xmlSchemaComplexContentRestriction.Clone();
						xmlSchemaComplexContentRestriction2.BaseTypeName = xmlSchemaComplexContentRestriction.BaseTypeName.Clone();
						xmlSchemaComplexContentRestriction2.SetAttributes(XmlSchemaComplexType.CloneAttributes(xmlSchemaComplexContentRestriction.Attributes));
						if (XmlSchemaComplexType.HasParticleRef(xmlSchemaComplexContentRestriction2.Particle, parentSchema))
						{
							xmlSchemaComplexContentRestriction2.Particle = XmlSchemaComplexType.CloneParticle(xmlSchemaComplexContentRestriction2.Particle, parentSchema);
						}
						xmlSchemaComplexContent2.Content = xmlSchemaComplexContentRestriction2;
					}
					xmlSchemaComplexType.ContentModel = xmlSchemaComplexContent2;
				}
			}
			else
			{
				if (XmlSchemaComplexType.HasParticleRef(xmlSchemaComplexType.Particle, parentSchema))
				{
					xmlSchemaComplexType.Particle = XmlSchemaComplexType.CloneParticle(xmlSchemaComplexType.Particle, parentSchema);
				}
				xmlSchemaComplexType.SetAttributes(XmlSchemaComplexType.CloneAttributes(xmlSchemaComplexType.Attributes));
			}
			xmlSchemaComplexType.ClearCompiledState();
			return xmlSchemaComplexType;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00096F24 File Offset: 0x00095124
		private void ClearCompiledState()
		{
			this.attributeUses = null;
			this.localElements = null;
			this.attributeWildcard = null;
			this.contentTypeParticle = XmlSchemaParticle.Empty;
			this.blockResolved = XmlSchemaDerivationMethod.None;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00096F54 File Offset: 0x00095154
		internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes)
		{
			if (XmlSchemaComplexType.HasAttributeQNameRef(attributes))
			{
				XmlSchemaObjectCollection xmlSchemaObjectCollection = attributes.Clone();
				for (int i = 0; i < attributes.Count; i++)
				{
					XmlSchemaObject xmlSchemaObject = attributes[i];
					XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef = xmlSchemaObject as XmlSchemaAttributeGroupRef;
					if (xmlSchemaAttributeGroupRef != null)
					{
						XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef2 = (XmlSchemaAttributeGroupRef)xmlSchemaAttributeGroupRef.Clone();
						xmlSchemaAttributeGroupRef2.RefName = xmlSchemaAttributeGroupRef.RefName.Clone();
						xmlSchemaObjectCollection[i] = xmlSchemaAttributeGroupRef2;
					}
					else
					{
						XmlSchemaAttribute xmlSchemaAttribute = xmlSchemaObject as XmlSchemaAttribute;
						if (!xmlSchemaAttribute.RefName.IsEmpty || !xmlSchemaAttribute.SchemaTypeName.IsEmpty)
						{
							xmlSchemaObjectCollection[i] = xmlSchemaAttribute.Clone();
						}
					}
				}
				return xmlSchemaObjectCollection;
			}
			return attributes;
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00096FFC File Offset: 0x000951FC
		private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema)
		{
			XmlSchemaObjectCollection xmlSchemaObjectCollection = groupBaseParticles.Clone();
			for (int i = 0; i < groupBaseParticles.Count; i++)
			{
				XmlSchemaParticle xmlSchemaParticle = (XmlSchemaParticle)groupBaseParticles[i];
				xmlSchemaObjectCollection[i] = XmlSchemaComplexType.CloneParticle(xmlSchemaParticle, parentSchema);
			}
			return xmlSchemaObjectCollection;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00097040 File Offset: 0x00095240
		internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			XmlSchemaGroupBase xmlSchemaGroupBase = particle as XmlSchemaGroupBase;
			if (xmlSchemaGroupBase != null)
			{
				XmlSchemaObjectCollection items = XmlSchemaComplexType.CloneGroupBaseParticles(xmlSchemaGroupBase.Items, parentSchema);
				XmlSchemaGroupBase xmlSchemaGroupBase2 = (XmlSchemaGroupBase)xmlSchemaGroupBase.Clone();
				xmlSchemaGroupBase2.SetItems(items);
				return xmlSchemaGroupBase2;
			}
			if (particle is XmlSchemaGroupRef)
			{
				XmlSchemaGroupRef xmlSchemaGroupRef = (XmlSchemaGroupRef)particle.Clone();
				xmlSchemaGroupRef.RefName = xmlSchemaGroupRef.RefName.Clone();
				return xmlSchemaGroupRef;
			}
			XmlSchemaElement xmlSchemaElement = particle as XmlSchemaElement;
			if (xmlSchemaElement != null && (!xmlSchemaElement.RefName.IsEmpty || !xmlSchemaElement.SchemaTypeName.IsEmpty || XmlSchemaComplexType.GetResolvedElementForm(parentSchema, xmlSchemaElement) == XmlSchemaForm.Qualified))
			{
				return (XmlSchemaElement)xmlSchemaElement.Clone(parentSchema);
			}
			return particle;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000970D8 File Offset: 0x000952D8
		private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element)
		{
			if (element.Form == XmlSchemaForm.None && parentSchema != null)
			{
				return parentSchema.ElementFormDefault;
			}
			return element.Form;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000970F4 File Offset: 0x000952F4
		internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			XmlSchemaGroupBase xmlSchemaGroupBase = particle as XmlSchemaGroupBase;
			if (xmlSchemaGroupBase != null)
			{
				bool flag = false;
				int num = 0;
				while (num < xmlSchemaGroupBase.Items.Count && !flag)
				{
					XmlSchemaParticle xmlSchemaParticle = (XmlSchemaParticle)xmlSchemaGroupBase.Items[num++];
					if (xmlSchemaParticle is XmlSchemaGroupRef)
					{
						flag = true;
					}
					else
					{
						XmlSchemaElement xmlSchemaElement = xmlSchemaParticle as XmlSchemaElement;
						flag = ((xmlSchemaElement != null && (!xmlSchemaElement.RefName.IsEmpty || !xmlSchemaElement.SchemaTypeName.IsEmpty || XmlSchemaComplexType.GetResolvedElementForm(parentSchema, xmlSchemaElement) == XmlSchemaForm.Qualified)) || XmlSchemaComplexType.HasParticleRef(xmlSchemaParticle, parentSchema));
					}
				}
				return flag;
			}
			return particle is XmlSchemaGroupRef;
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00097190 File Offset: 0x00095390
		internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes)
		{
			for (int i = 0; i < attributes.Count; i++)
			{
				if (attributes[i] is XmlSchemaAttributeGroupRef)
				{
					return true;
				}
				XmlSchemaAttribute xmlSchemaAttribute = attributes[i] as XmlSchemaAttribute;
				if (!xmlSchemaAttribute.RefName.IsEmpty || !xmlSchemaAttribute.SchemaTypeName.IsEmpty)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400106B RID: 4203
		private XmlSchemaDerivationMethod block = XmlSchemaDerivationMethod.None;

		// Token: 0x0400106C RID: 4204
		private XmlSchemaContentModel contentModel;

		// Token: 0x0400106D RID: 4205
		private XmlSchemaParticle particle;

		// Token: 0x0400106E RID: 4206
		private XmlSchemaObjectCollection attributes;

		// Token: 0x0400106F RID: 4207
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04001070 RID: 4208
		private XmlSchemaParticle contentTypeParticle = XmlSchemaParticle.Empty;

		// Token: 0x04001071 RID: 4209
		private XmlSchemaDerivationMethod blockResolved;

		// Token: 0x04001072 RID: 4210
		private XmlSchemaObjectTable localElements;

		// Token: 0x04001073 RID: 4211
		private XmlSchemaObjectTable attributeUses;

		// Token: 0x04001074 RID: 4212
		private XmlSchemaAnyAttribute attributeWildcard;

		// Token: 0x04001075 RID: 4213
		private static XmlSchemaComplexType anyTypeLax = XmlSchemaComplexType.CreateAnyType(XmlSchemaContentProcessing.Lax);

		// Token: 0x04001076 RID: 4214
		private static XmlSchemaComplexType anyTypeSkip = XmlSchemaComplexType.CreateAnyType(XmlSchemaContentProcessing.Skip);

		// Token: 0x04001077 RID: 4215
		private static XmlSchemaComplexType untypedAnyType = new XmlSchemaComplexType();

		// Token: 0x04001078 RID: 4216
		private byte pvFlags;
	}
}
