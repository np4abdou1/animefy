﻿using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="union" /> element for simple types from XML Schema as specified by the World Wide Web Consortium (W3C). A <see langword="union" /> datatype can be used to specify the content of a <see langword="simpleType" />. The value of the <see langword="simpleType" /> element must be any one of a set of alternative datatypes specified in the union. Union types are always derived types and must comprise at least two alternative datatypes.</summary>
	// Token: 0x0200031E RID: 798
	public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
	{
		/// <summary>Gets the collection of base types.</summary>
		/// <returns>The collection of simple type base values.</returns>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0009AC22 File Offset: 0x00098E22
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaObjectCollection BaseTypes
		{
			get
			{
				return this.baseTypes;
			}
		}

		/// <summary>Gets or sets the array of qualified member names of built-in data types or <see langword="simpleType" /> elements defined in this schema (or another schema indicated by the specified namespace).</summary>
		/// <returns>An array that consists of a list of members of built-in data types or simple types.</returns>
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0009AC2A File Offset: 0x00098E2A
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x0009AC32 File Offset: 0x00098E32
		[XmlAttribute("memberTypes")]
		public XmlQualifiedName[] MemberTypes
		{
			get
			{
				return this.memberTypes;
			}
			set
			{
				this.memberTypes = value;
			}
		}

		/// <summary>Gets an array of <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> objects representing the type of the <see langword="simpleType" /> element based on the <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeUnion.BaseTypes" /> and <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeUnion.MemberTypes" /> values of the simple type.</summary>
		/// <returns>An array of <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> objects representing the type of the <see langword="simpleType" /> element.</returns>
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0009AC3B File Offset: 0x00098E3B
		[XmlIgnore]
		public XmlSchemaSimpleType[] BaseMemberTypes
		{
			get
			{
				return this.baseMemberTypes;
			}
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0009AC43 File Offset: 0x00098E43
		internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes)
		{
			this.baseMemberTypes = baseMemberTypes;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0009AC4C File Offset: 0x00098E4C
		internal override XmlSchemaObject Clone()
		{
			if (this.memberTypes != null && this.memberTypes.Length != 0)
			{
				XmlSchemaSimpleTypeUnion xmlSchemaSimpleTypeUnion = (XmlSchemaSimpleTypeUnion)base.MemberwiseClone();
				XmlQualifiedName[] array = new XmlQualifiedName[this.memberTypes.Length];
				for (int i = 0; i < this.memberTypes.Length; i++)
				{
					array[i] = this.memberTypes[i].Clone();
				}
				xmlSchemaSimpleTypeUnion.MemberTypes = array;
				return xmlSchemaSimpleTypeUnion;
			}
			return this;
		}

		// Token: 0x0400112F RID: 4399
		private XmlSchemaObjectCollection baseTypes = new XmlSchemaObjectCollection();

		// Token: 0x04001130 RID: 4400
		private XmlQualifiedName[] memberTypes;

		// Token: 0x04001131 RID: 4401
		private XmlSchemaSimpleType[] baseMemberTypes;
	}
}
