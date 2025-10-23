using System;

namespace System.Xml.Schema
{
	/// <summary>Defines the post-schema-validation infoset of a validated XML node.</summary>
	// Token: 0x0200029E RID: 670
	public interface IXmlSchemaInfo
	{
		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> value of this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> value of this validated XML node.</returns>
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001528 RID: 5416
		XmlSchemaValidity Validity { get; }

		/// <summary>Gets a value indicating if this validated XML node was set as the result of a default being applied during XML Schema Definition Language (XSD) schema validation.</summary>
		/// <returns>
		///     <see langword="true" /> if this validated XML node was set as the result of a default being applied during schema validation; otherwise, <see langword="false" />.</returns>
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001529 RID: 5417
		bool IsDefault { get; }

		/// <summary>Gets a value indicating if the value for this validated XML node is nil.</summary>
		/// <returns>
		///     <see langword="true" /> if the value for this validated XML node is nil; otherwise, <see langword="false" />.</returns>
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600152A RID: 5418
		bool IsNil { get; }

		/// <summary>Gets the dynamic schema type for this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object that represents the dynamic schema type for this validated XML node.</returns>
		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600152B RID: 5419
		XmlSchemaSimpleType MemberType { get; }

		/// <summary>Gets the static XML Schema Definition Language (XSD) schema type of this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> of this validated XML node.</returns>
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600152C RID: 5420
		XmlSchemaType SchemaType { get; }

		/// <summary>Gets the compiled <see cref="T:System.Xml.Schema.XmlSchemaElement" /> that corresponds to this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaElement" /> that corresponds to this validated XML node.</returns>
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600152D RID: 5421
		XmlSchemaElement SchemaElement { get; }

		/// <summary>Gets the compiled <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> that corresponds to this validated XML node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> that corresponds to this validated XML node.</returns>
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600152E RID: 5422
		XmlSchemaAttribute SchemaAttribute { get; }
	}
}
