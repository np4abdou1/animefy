using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="attributeGroup" /> element from the XML Schema as specified by the World Wide Web Consortium (W3C). AttributesGroups provides a mechanism to group a set of attribute declarations so that they can be incorporated as a group into complex type definitions.</summary>
	// Token: 0x020002D7 RID: 727
	public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the name of the attribute group.</summary>
		/// <returns>The name of the attribute group.</returns>
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00096327 File Offset: 0x00094527
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x0009632F File Offset: 0x0009452F
		[XmlAttribute("name")]
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

		/// <summary>Gets the collection of attributes for the attribute group. Contains <see langword="XmlSchemaAttribute" /> and <see langword="XmlSchemaAttributeGroupRef" /> elements.</summary>
		/// <returns>The collection of attributes for the attribute group.</returns>
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00096338 File Offset: 0x00094538
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the attribute group.</summary>
		/// <returns>The World Wide Web Consortium (W3C) <see langword="anyAttribute" /> element.</returns>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00096340 File Offset: 0x00094540
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x00096348 File Offset: 0x00094548
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

		/// <summary>Gets the qualified name of the attribute group.</summary>
		/// <returns>The qualified name of the attribute group.</returns>
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00096351 File Offset: 0x00094551
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00096359 File Offset: 0x00094559
		[XmlIgnore]
		internal XmlSchemaObjectTable AttributeUses
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00096374 File Offset: 0x00094574
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0009637C File Offset: 0x0009457C
		[XmlIgnore]
		internal XmlSchemaAnyAttribute AttributeWildcard
		{
			get
			{
				return this.attributeWildcard;
			}
			set
			{
				this.attributeWildcard = value;
			}
		}

		/// <summary>Gets the redefined attribute group property from the XML Schema.</summary>
		/// <returns>The redefined attribute group property.</returns>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00096385 File Offset: 0x00094585
		[XmlIgnore]
		public XmlSchemaAttributeGroup RedefinedAttributeGroup
		{
			get
			{
				return this.redefined;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00096385 File Offset: 0x00094585
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x0009638D File Offset: 0x0009458D
		[XmlIgnore]
		internal XmlSchemaAttributeGroup Redefined
		{
			get
			{
				return this.redefined;
			}
			set
			{
				this.redefined = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00096396 File Offset: 0x00094596
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x0009639E File Offset: 0x0009459E
		[XmlIgnore]
		internal int SelfReferenceCount
		{
			get
			{
				return this.selfReferenceCount;
			}
			set
			{
				this.selfReferenceCount = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x000963A7 File Offset: 0x000945A7
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x000963AF File Offset: 0x000945AF
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

		// Token: 0x06001861 RID: 6241 RVA: 0x000963B8 File Offset: 0x000945B8
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000963C4 File Offset: 0x000945C4
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaAttributeGroup xmlSchemaAttributeGroup = (XmlSchemaAttributeGroup)base.MemberwiseClone();
			if (XmlSchemaComplexType.HasAttributeQNameRef(this.attributes))
			{
				xmlSchemaAttributeGroup.attributes = XmlSchemaComplexType.CloneAttributes(this.attributes);
				xmlSchemaAttributeGroup.attributeUses = null;
			}
			return xmlSchemaAttributeGroup;
		}

		// Token: 0x04001049 RID: 4169
		private string name;

		// Token: 0x0400104A RID: 4170
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x0400104B RID: 4171
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x0400104C RID: 4172
		private XmlQualifiedName qname = XmlQualifiedName.Empty;

		// Token: 0x0400104D RID: 4173
		private XmlSchemaAttributeGroup redefined;

		// Token: 0x0400104E RID: 4174
		private XmlSchemaObjectTable attributeUses;

		// Token: 0x0400104F RID: 4175
		private XmlSchemaAnyAttribute attributeWildcard;

		// Token: 0x04001050 RID: 4176
		private int selfReferenceCount;
	}
}
