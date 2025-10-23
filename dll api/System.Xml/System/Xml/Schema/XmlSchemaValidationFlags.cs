using System;

namespace System.Xml.Schema
{
	/// <summary>Specifies schema validation options used by the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> and <see cref="T:System.Xml.XmlReader" /> classes.</summary>
	// Token: 0x02000325 RID: 805
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		/// <summary>Do not process identity constraints, inline schemas, schema location hints, or report schema validation warnings.</summary>
		// Token: 0x04001145 RID: 4421
		None = 0,
		/// <summary>Process inline schemas encountered during validation.</summary>
		// Token: 0x04001146 RID: 4422
		ProcessInlineSchema = 1,
		/// <summary>Process schema location hints (xsi:schemaLocation, xsi:noNamespaceSchemaLocation) encountered during validation.</summary>
		// Token: 0x04001147 RID: 4423
		ProcessSchemaLocation = 2,
		/// <summary>Report schema validation warnings encountered during validation.</summary>
		// Token: 0x04001148 RID: 4424
		ReportValidationWarnings = 4,
		/// <summary>Process identity constraints (xs:ID, xs:IDREF, xs:key, xs:keyref, xs:unique) encountered during validation.</summary>
		// Token: 0x04001149 RID: 4425
		ProcessIdentityConstraints = 8,
		/// <summary>Allow xml:* attributes even if they are not defined in the schema. The attributes will be validated based on their data type.</summary>
		// Token: 0x0400114A RID: 4426
		AllowXmlAttributes = 16
	}
}
