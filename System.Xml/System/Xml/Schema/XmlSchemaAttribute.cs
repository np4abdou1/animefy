using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="attribute" /> element from the XML Schema as specified by the World Wide Web Consortium (W3C). Attributes provide additional information for other document elements. The attribute tag is nested between the tags of a document's element for the schema. The XML document displays attributes as named items in the opening tag of an element.</summary>
	// Token: 0x020002D6 RID: 726
	public class XmlSchemaAttribute : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the default value for the attribute.</summary>
		/// <returns>The default value for the attribute. The default is a null reference.Optional.</returns>
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x000961BB File Offset: 0x000943BB
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x000961C3 File Offset: 0x000943C3
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

		/// <summary>Gets or sets the fixed value for the attribute.</summary>
		/// <returns>The fixed value for the attribute. The default is null.Optional.</returns>
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x000961CC File Offset: 0x000943CC
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x000961D4 File Offset: 0x000943D4
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

		/// <summary>Gets or sets the form for the attribute.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaForm" /> values. The default is the value of the <see cref="P:System.Xml.Schema.XmlSchema.AttributeFormDefault" /> of the schema element containing the attribute.Optional.</returns>
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x000961DD File Offset: 0x000943DD
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x000961E5 File Offset: 0x000943E5
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

		/// <summary>Gets or sets the name of the attribute.</summary>
		/// <returns>The name of the attribute.</returns>
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000961EE File Offset: 0x000943EE
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x000961F6 File Offset: 0x000943F6
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

		/// <summary>Gets or sets the name of an attribute declared in this schema (or another schema indicated by the specified namespace).</summary>
		/// <returns>The name of the attribute declared.</returns>
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000961FF File Offset: 0x000943FF
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x00096207 File Offset: 0x00094407
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

		/// <summary>Gets or sets the name of the simple type defined in this schema (or another schema indicated by the specified namespace).</summary>
		/// <returns>The name of the simple type.</returns>
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00096220 File Offset: 0x00094420
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x00096228 File Offset: 0x00094428
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

		/// <summary>Gets or sets the attribute type to a simple type.</summary>
		/// <returns>The simple type defined in this schema.</returns>
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00096241 File Offset: 0x00094441
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00096249 File Offset: 0x00094449
		[XmlElement("simpleType")]
		public XmlSchemaSimpleType SchemaType
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

		/// <summary>Gets or sets information about how the attribute is used.</summary>
		/// <returns>One of the following values: None, Prohibited, Optional, or Required. The default is Optional.Optional.</returns>
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00096252 File Offset: 0x00094452
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0009625A File Offset: 0x0009445A
		[XmlAttribute("use")]
		[DefaultValue(XmlSchemaUse.None)]
		public XmlSchemaUse Use
		{
			get
			{
				return this.use;
			}
			set
			{
				this.use = value;
			}
		}

		/// <summary>Gets the qualified name for the attribute.</summary>
		/// <returns>The post-compilation value of the <see langword="QualifiedName" /> property.</returns>
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x00096263 File Offset: 0x00094463
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qualifiedName;
			}
		}

		/// <summary>Gets an <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object representing the type of the attribute based on the <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaType" /> or <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaTypeName" /> of the attribute.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object.</returns>
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0009626B File Offset: 0x0009446B
		[XmlIgnore]
		public XmlSchemaSimpleType AttributeSchemaType
		{
			get
			{
				return this.attributeType;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00096273 File Offset: 0x00094473
		[XmlIgnore]
		internal XmlSchemaDatatype Datatype
		{
			get
			{
				if (this.attributeType != null)
				{
					return this.attributeType.Datatype;
				}
				return null;
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0009628A File Offset: 0x0009448A
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qualifiedName = value;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00096293 File Offset: 0x00094493
		internal void SetAttributeType(XmlSchemaSimpleType value)
		{
			this.attributeType = value;
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0009629C File Offset: 0x0009449C
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x000962A4 File Offset: 0x000944A4
		internal SchemaAttDef AttDef
		{
			get
			{
				return this.attDef;
			}
			set
			{
				this.attDef = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000962AD File Offset: 0x000944AD
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x000962B5 File Offset: 0x000944B5
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

		// Token: 0x0600184F RID: 6223 RVA: 0x000962BE File Offset: 0x000944BE
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)base.MemberwiseClone();
			xmlSchemaAttribute.refName = this.refName.Clone();
			xmlSchemaAttribute.typeName = this.typeName.Clone();
			xmlSchemaAttribute.qualifiedName = this.qualifiedName.Clone();
			return xmlSchemaAttribute;
		}

		// Token: 0x0400103E RID: 4158
		private string defaultValue;

		// Token: 0x0400103F RID: 4159
		private string fixedValue;

		// Token: 0x04001040 RID: 4160
		private string name;

		// Token: 0x04001041 RID: 4161
		private XmlSchemaForm form;

		// Token: 0x04001042 RID: 4162
		private XmlSchemaUse use;

		// Token: 0x04001043 RID: 4163
		private XmlQualifiedName refName = XmlQualifiedName.Empty;

		// Token: 0x04001044 RID: 4164
		private XmlQualifiedName typeName = XmlQualifiedName.Empty;

		// Token: 0x04001045 RID: 4165
		private XmlQualifiedName qualifiedName = XmlQualifiedName.Empty;

		// Token: 0x04001046 RID: 4166
		private XmlSchemaSimpleType type;

		// Token: 0x04001047 RID: 4167
		private XmlSchemaSimpleType attributeType;

		// Token: 0x04001048 RID: 4168
		private SchemaAttDef attDef;
	}
}
