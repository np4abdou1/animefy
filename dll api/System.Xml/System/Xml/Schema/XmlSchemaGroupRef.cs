using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="group" /> element with <see langword="ref" /> attribute from the XML Schema as specified by the World Wide Web Consortium (W3C). This class is used within complex types that reference a <see langword="group" /> defined at the <see langword="schema" /> level.</summary>
	// Token: 0x020002FE RID: 766
	public class XmlSchemaGroupRef : XmlSchemaParticle
	{
		/// <summary>Gets or sets the name of a group defined in this schema (or another schema indicated by the specified namespace).</summary>
		/// <returns>The name of a group defined in this schema.</returns>
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00097F79 File Offset: 0x00096179
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x00097F81 File Offset: 0x00096181
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

		/// <summary>Gets one of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes, which holds the post-compilation value of the <see langword="Particle" /> property.</summary>
		/// <returns>The post-compilation value of the <see langword="Particle" /> property, which is one of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</returns>
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x00097F9A File Offset: 0x0009619A
		[XmlIgnore]
		public XmlSchemaGroupBase Particle
		{
			get
			{
				return this.particle;
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00097FA2 File Offset: 0x000961A2
		internal void SetParticle(XmlSchemaGroupBase value)
		{
			this.particle = value;
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x00097FAB File Offset: 0x000961AB
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x00097FB3 File Offset: 0x000961B3
		[XmlIgnore]
		internal XmlSchemaGroup Redefined
		{
			get
			{
				return this.refined;
			}
			set
			{
				this.refined = value;
			}
		}

		// Token: 0x040010CD RID: 4301
		private XmlQualifiedName refName = XmlQualifiedName.Empty;

		// Token: 0x040010CE RID: 4302
		private XmlSchemaGroupBase particle;

		// Token: 0x040010CF RID: 4303
		private XmlSchemaGroup refined;
	}
}
