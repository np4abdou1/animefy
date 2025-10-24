using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the post-schema-validation infoset of a validated XML node.</summary>
	// Token: 0x02000306 RID: 774
	public class XmlSchemaInfo : IXmlSchemaInfo
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> class.</summary>
		// Token: 0x0600199B RID: 6555 RVA: 0x000980E8 File Offset: 0x000962E8
		public XmlSchemaInfo()
		{
			this.Clear();
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000980F6 File Offset: 0x000962F6
		internal XmlSchemaInfo(XmlSchemaValidity validity) : this()
		{
			this.validity = validity;
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> value of this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> value.</returns>
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00098105 File Offset: 0x00096305
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x0009810D File Offset: 0x0009630D
		public XmlSchemaValidity Validity
		{
			get
			{
				return this.validity;
			}
			set
			{
				this.validity = value;
			}
		}

		/// <summary>Gets or sets a value indicating if this validated XML node was set as the result of a default being applied during XML Schema Definition Language (XSD) schema validation.</summary>
		/// <returns>A <see langword="bool" /> value.</returns>
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x00098116 File Offset: 0x00096316
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0009811E File Offset: 0x0009631E
		public bool IsDefault
		{
			get
			{
				return this.isDefault;
			}
			set
			{
				this.isDefault = value;
			}
		}

		/// <summary>Gets or sets a value indicating if the value for this validated XML node is nil.</summary>
		/// <returns>A <see langword="bool" /> value.</returns>
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00098127 File Offset: 0x00096327
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0009812F File Offset: 0x0009632F
		public bool IsNil
		{
			get
			{
				return this.isNil;
			}
			set
			{
				this.isNil = value;
			}
		}

		/// <summary>Gets or sets the dynamic schema type for this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object.</returns>
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00098138 File Offset: 0x00096338
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x00098140 File Offset: 0x00096340
		public XmlSchemaSimpleType MemberType
		{
			get
			{
				return this.memberType;
			}
			set
			{
				this.memberType = value;
			}
		}

		/// <summary>Gets or sets the static XML Schema Definition Language (XSD) schema type of this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object.</returns>
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00098149 File Offset: 0x00096349
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x00098151 File Offset: 0x00096351
		public XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
			set
			{
				this.schemaType = value;
				if (this.schemaType != null)
				{
					this.contentType = this.schemaType.SchemaContentType;
					return;
				}
				this.contentType = XmlSchemaContentType.Empty;
			}
		}

		/// <summary>Gets or sets the compiled <see cref="T:System.Xml.Schema.XmlSchemaElement" /> object that corresponds to this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaElement" /> object.</returns>
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0009817B File Offset: 0x0009637B
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x00098183 File Offset: 0x00096383
		public XmlSchemaElement SchemaElement
		{
			get
			{
				return this.schemaElement;
			}
			set
			{
				this.schemaElement = value;
				if (value != null)
				{
					this.schemaAttribute = null;
				}
			}
		}

		/// <summary>Gets or sets the compiled <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> object that corresponds to this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> object.</returns>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00098196 File Offset: 0x00096396
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0009819E File Offset: 0x0009639E
		public XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				return this.schemaAttribute;
			}
			set
			{
				this.schemaAttribute = value;
				if (value != null)
				{
					this.schemaElement = null;
				}
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaContentType" /> object that corresponds to the content type of this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaContentType" /> object.</returns>
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000981B1 File Offset: 0x000963B1
		public XmlSchemaContentType ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x000981B9 File Offset: 0x000963B9
		internal XmlSchemaType XmlType
		{
			get
			{
				if (this.memberType != null)
				{
					return this.memberType;
				}
				return this.schemaType;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x000981D0 File Offset: 0x000963D0
		internal bool HasDefaultValue
		{
			get
			{
				return this.schemaElement != null && this.schemaElement.ElementDecl.DefaultValueTyped != null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x000981EF File Offset: 0x000963EF
		internal bool IsUnionType
		{
			get
			{
				return this.schemaType != null && this.schemaType.Datatype != null && this.schemaType.Datatype.Variety == XmlSchemaDatatypeVariety.Union;
			}
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0009821B File Offset: 0x0009641B
		internal void Clear()
		{
			this.isNil = false;
			this.isDefault = false;
			this.schemaType = null;
			this.schemaElement = null;
			this.schemaAttribute = null;
			this.memberType = null;
			this.validity = XmlSchemaValidity.NotKnown;
			this.contentType = XmlSchemaContentType.Empty;
		}

		// Token: 0x040010DA RID: 4314
		private bool isDefault;

		// Token: 0x040010DB RID: 4315
		private bool isNil;

		// Token: 0x040010DC RID: 4316
		private XmlSchemaElement schemaElement;

		// Token: 0x040010DD RID: 4317
		private XmlSchemaAttribute schemaAttribute;

		// Token: 0x040010DE RID: 4318
		private XmlSchemaType schemaType;

		// Token: 0x040010DF RID: 4319
		private XmlSchemaSimpleType memberType;

		// Token: 0x040010E0 RID: 4320
		private XmlSchemaValidity validity;

		// Token: 0x040010E1 RID: 4321
		private XmlSchemaContentType contentType;
	}
}
