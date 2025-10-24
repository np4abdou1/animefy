using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="annotation" /> element.</summary>
	// Token: 0x020002D2 RID: 722
	public class XmlSchemaAnnotation : XmlSchemaObject
	{
		/// <summary>Gets or sets the string id.</summary>
		/// <returns>The string id. The default is <see langword="String.Empty" />.Optional.</returns>
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00095E5A File Offset: 0x0009405A
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00095E62 File Offset: 0x00094062
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

		/// <summary>Gets the <see langword="Items" /> collection that is used to store the <see langword="appinfo" /> and <see langword="documentation" /> child elements.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of <see langword="appinfo" /> and <see langword="documentation" /> child elements.</returns>
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00095E6B File Offset: 0x0009406B
		[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
		[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
		public XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		/// <summary>Gets or sets the qualified attributes that do not belong to the schema's target namespace.</summary>
		/// <returns>An array of <see cref="T:System.Xml.XmlAttribute" /> objects that do not belong to the schema's target namespace.</returns>
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00095E73 File Offset: 0x00094073
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x00095E7B File Offset: 0x0009407B
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00095E84 File Offset: 0x00094084
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00095E8C File Offset: 0x0009408C
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

		// Token: 0x06001816 RID: 6166 RVA: 0x00095E7B File Offset: 0x0009407B
		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
			this.moreAttributes = moreAttributes;
		}

		// Token: 0x04001033 RID: 4147
		private string id;

		// Token: 0x04001034 RID: 4148
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();

		// Token: 0x04001035 RID: 4149
		private XmlAttribute[] moreAttributes;
	}
}
