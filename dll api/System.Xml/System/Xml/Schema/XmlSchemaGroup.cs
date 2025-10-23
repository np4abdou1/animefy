using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="group" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class defines groups at the <see langword="schema" /> level that are referenced from the complex types. It groups a set of element declarations so that they can be incorporated as a group into complex type definitions.</summary>
	// Token: 0x020002FC RID: 764
	public class XmlSchemaGroup : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the name of the schema group.</summary>
		/// <returns>The name of the schema group.</returns>
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00097E9A File Offset: 0x0009609A
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00097EA2 File Offset: 0x000960A2
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

		/// <summary>Gets or sets one of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</returns>
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00097EAB File Offset: 0x000960AB
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00097EB3 File Offset: 0x000960B3
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		public XmlSchemaGroupBase Particle
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

		/// <summary>Gets the qualified name of the schema group.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlQualifiedName" /> object representing the qualified name of the schema group.</returns>
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00097EBC File Offset: 0x000960BC
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00097EC4 File Offset: 0x000960C4
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x00097ECC File Offset: 0x000960CC
		[XmlIgnore]
		internal XmlSchemaParticle CanonicalParticle
		{
			get
			{
				return this.canonicalParticle;
			}
			set
			{
				this.canonicalParticle = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00097ED5 File Offset: 0x000960D5
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x00097EDD File Offset: 0x000960DD
		[XmlIgnore]
		internal XmlSchemaGroup Redefined
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00097EE6 File Offset: 0x000960E6
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x00097EEE File Offset: 0x000960EE
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00097EF7 File Offset: 0x000960F7
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x00097EFF File Offset: 0x000960FF
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

		// Token: 0x0600196F RID: 6511 RVA: 0x00097F08 File Offset: 0x00096108
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00097F11 File Offset: 0x00096111
		internal override XmlSchemaObject Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00097F1C File Offset: 0x0009611C
		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			XmlSchemaGroup xmlSchemaGroup = (XmlSchemaGroup)base.MemberwiseClone();
			if (XmlSchemaComplexType.HasParticleRef(this.particle, parentSchema))
			{
				xmlSchemaGroup.particle = (XmlSchemaComplexType.CloneParticle(this.particle, parentSchema) as XmlSchemaGroupBase);
			}
			xmlSchemaGroup.canonicalParticle = XmlSchemaParticle.Empty;
			return xmlSchemaGroup;
		}

		// Token: 0x040010C7 RID: 4295
		private string name;

		// Token: 0x040010C8 RID: 4296
		private XmlSchemaGroupBase particle;

		// Token: 0x040010C9 RID: 4297
		private XmlSchemaParticle canonicalParticle;

		// Token: 0x040010CA RID: 4298
		private XmlQualifiedName qname = XmlQualifiedName.Empty;

		// Token: 0x040010CB RID: 4299
		private XmlSchemaGroup redefined;

		// Token: 0x040010CC RID: 4300
		private int selfReferenceCount;
	}
}
