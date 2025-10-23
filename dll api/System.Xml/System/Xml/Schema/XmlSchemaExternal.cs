using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>An abstract class. Provides information about the included schema.</summary>
	// Token: 0x020002EB RID: 747
	public abstract class XmlSchemaExternal : XmlSchemaObject
	{
		/// <summary>Gets or sets the Uniform Resource Identifier (URI) location for the schema, which tells the schema processor where the schema physically resides.</summary>
		/// <returns>The URI location for the schema.Optional for imported schemas.</returns>
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00097D20 File Offset: 0x00095F20
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x00097D28 File Offset: 0x00095F28
		[XmlAttribute("schemaLocation", DataType = "anyURI")]
		public string SchemaLocation
		{
			get
			{
				return this.location;
			}
			set
			{
				this.location = value;
			}
		}

		/// <summary>Gets or sets the <see langword="XmlSchema" /> for the referenced schema.</summary>
		/// <returns>The <see langword="XmlSchema" /> for the referenced schema.</returns>
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00097D31 File Offset: 0x00095F31
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x00097D39 File Offset: 0x00095F39
		[XmlIgnore]
		public XmlSchema Schema
		{
			get
			{
				return this.schema;
			}
			set
			{
				this.schema = value;
			}
		}

		/// <summary>Gets or sets the string id.</summary>
		/// <returns>The string id. The default is <see langword="String.Empty" />.Optional.</returns>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00097D42 File Offset: 0x00095F42
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x00097D4A File Offset: 0x00095F4A
		[XmlAttribute("id", DataType = "ID")]
		public string Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		/// <summary>Gets and sets the qualified attributes, which do not belong to the schema target namespace.</summary>
		/// <returns>Qualified attributes that belong to another target namespace.</returns>
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00097D53 File Offset: 0x00095F53
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x00097D5B File Offset: 0x00095F5B
		[XmlAnyAttribute]
		public XmlAttribute[] UnhandledAttributes
		{
			get
			{
				return this.moreAttributes;
			}
			set
			{
				this.moreAttributes = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00097D64 File Offset: 0x00095F64
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x00097D6C File Offset: 0x00095F6C
		[XmlIgnore]
		internal Uri BaseUri
		{
			get
			{
				return this.baseUri;
			}
			set
			{
				this.baseUri = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00097D75 File Offset: 0x00095F75
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00097D7D File Offset: 0x00095F7D
		[XmlIgnore]
		internal override string IdAttribute
		{
			get
			{
				return this.Id;
			}
			set
			{
				this.Id = value;
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00097D5B File Offset: 0x00095F5B
		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
			this.moreAttributes = moreAttributes;
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00097D86 File Offset: 0x00095F86
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x00097D8E File Offset: 0x00095F8E
		internal Compositor Compositor
		{
			get
			{
				return this.compositor;
			}
			set
			{
				this.compositor = value;
			}
		}

		// Token: 0x040010AC RID: 4268
		private string location;

		// Token: 0x040010AD RID: 4269
		private Uri baseUri;

		// Token: 0x040010AE RID: 4270
		private XmlSchema schema;

		// Token: 0x040010AF RID: 4271
		private string id;

		// Token: 0x040010B0 RID: 4272
		private XmlAttribute[] moreAttributes;

		// Token: 0x040010B1 RID: 4273
		private Compositor compositor;
	}
}
