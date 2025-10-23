using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Class for the identity constraints: <see langword="key" />, <see langword="keyref" />, and <see langword="unique" /> elements.</summary>
	// Token: 0x020002FF RID: 767
	public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the name of the identity constraint.</summary>
		/// <returns>The name of the identity constraint.</returns>
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00097FCF File Offset: 0x000961CF
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x00097FD7 File Offset: 0x000961D7
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

		/// <summary>Gets or sets the XPath expression <see langword="selector" /> element.</summary>
		/// <returns>The XPath expression <see langword="selector" /> element.</returns>
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x00097FE0 File Offset: 0x000961E0
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x00097FE8 File Offset: 0x000961E8
		[XmlElement("selector", typeof(XmlSchemaXPath))]
		public XmlSchemaXPath Selector
		{
			get
			{
				return this.selector;
			}
			set
			{
				this.selector = value;
			}
		}

		/// <summary>Gets the collection of fields that apply as children for the XML Path Language (XPath) expression selector.</summary>
		/// <returns>The collection of fields.</returns>
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x00097FF1 File Offset: 0x000961F1
		[XmlElement("field", typeof(XmlSchemaXPath))]
		public XmlSchemaObjectCollection Fields
		{
			get
			{
				return this.fields;
			}
		}

		/// <summary>Gets the qualified name of the identity constraint, which holds the post-compilation value of the <see langword="QualifiedName" /> property.</summary>
		/// <returns>The post-compilation value of the <see langword="QualifiedName" /> property.</returns>
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00097FF9 File Offset: 0x000961F9
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qualifiedName;
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00098001 File Offset: 0x00096201
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qualifiedName = value;
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x0009800A File Offset: 0x0009620A
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x00098012 File Offset: 0x00096212
		[XmlIgnore]
		internal CompiledIdentityConstraint CompiledConstraint
		{
			get
			{
				return this.compiledConstraint;
			}
			set
			{
				this.compiledConstraint = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x0009801B File Offset: 0x0009621B
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x00098023 File Offset: 0x00096223
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

		// Token: 0x040010D0 RID: 4304
		private string name;

		// Token: 0x040010D1 RID: 4305
		private XmlSchemaXPath selector;

		// Token: 0x040010D2 RID: 4306
		private XmlSchemaObjectCollection fields = new XmlSchemaObjectCollection();

		// Token: 0x040010D3 RID: 4307
		private XmlQualifiedName qualifiedName = XmlQualifiedName.Empty;

		// Token: 0x040010D4 RID: 4308
		private CompiledIdentityConstraint compiledConstraint;
	}
}
