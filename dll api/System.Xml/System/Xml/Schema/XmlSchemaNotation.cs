using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="notation" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). An XML Schema <see langword="notation" /> declaration is a reconstruction of <see langword="XML 1.0 NOTATION" /> declarations. The purpose of notations is to describe the format of non-XML data within an XML document.</summary>
	// Token: 0x02000307 RID: 775
	public class XmlSchemaNotation : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the name of the notation.</summary>
		/// <returns>The name of the notation.</returns>
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00098255 File Offset: 0x00096455
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0009825D File Offset: 0x0009645D
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

		/// <summary>Gets or sets the <see langword="public" /> identifier.</summary>
		/// <returns>The <see langword="public" /> identifier. The value must be a valid Uniform Resource Identifier (URI).</returns>
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00098266 File Offset: 0x00096466
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0009826E File Offset: 0x0009646E
		[XmlAttribute("public")]
		public string Public
		{
			get
			{
				return this.publicId;
			}
			set
			{
				this.publicId = value;
			}
		}

		/// <summary>Gets or sets the <see langword="system" /> identifier.</summary>
		/// <returns>The <see langword="system" /> identifier. The value must be a valid URI.</returns>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00098277 File Offset: 0x00096477
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0009827F File Offset: 0x0009647F
		[XmlAttribute("system")]
		public string System
		{
			get
			{
				return this.systemId;
			}
			set
			{
				this.systemId = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00098288 File Offset: 0x00096488
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x00098290 File Offset: 0x00096490
		[XmlIgnore]
		internal XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
			set
			{
				this.qname = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00098299 File Offset: 0x00096499
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x000982A1 File Offset: 0x000964A1
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

		// Token: 0x040010E2 RID: 4322
		private string name;

		// Token: 0x040010E3 RID: 4323
		private string publicId;

		// Token: 0x040010E4 RID: 4324
		private string systemId;

		// Token: 0x040010E5 RID: 4325
		private XmlQualifiedName qname = XmlQualifiedName.Empty;
	}
}
