using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>The base class for any element that can contain annotation elements.</summary>
	// Token: 0x020002D1 RID: 721
	public class XmlSchemaAnnotated : XmlSchemaObject
	{
		/// <summary>Gets or sets the string id.</summary>
		/// <returns>The string id. The default is <see langword="String.Empty" />.Optional.</returns>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00095E0E File Offset: 0x0009400E
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x00095E16 File Offset: 0x00094016
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

		/// <summary>Gets or sets the <see langword="annotation" /> property.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaAnnotation" /> representing the <see langword="annotation" /> property.</returns>
		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00095E1F File Offset: 0x0009401F
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x00095E27 File Offset: 0x00094027
		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		public XmlSchemaAnnotation Annotation
		{
			get
			{
				return this.annotation;
			}
			set
			{
				this.annotation = value;
			}
		}

		/// <summary>Gets or sets the qualified attributes that do not belong to the current schema's target namespace.</summary>
		/// <returns>An array of qualified <see cref="T:System.Xml.XmlAttribute" /> objects that do not belong to the schema's target namespace.</returns>
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00095E30 File Offset: 0x00094030
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x00095E38 File Offset: 0x00094038
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x00095E41 File Offset: 0x00094041
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00095E49 File Offset: 0x00094049
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

		// Token: 0x0600180C RID: 6156 RVA: 0x00095E38 File Offset: 0x00094038
		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
			this.moreAttributes = moreAttributes;
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00095E27 File Offset: 0x00094027
		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			this.annotation = annotation;
		}

		// Token: 0x04001030 RID: 4144
		private string id;

		// Token: 0x04001031 RID: 4145
		private XmlSchemaAnnotation annotation;

		// Token: 0x04001032 RID: 4146
		private XmlAttribute[] moreAttributes;
	}
}
