﻿using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Provides information about the validation mode of <see langword="any" /> and <see langword="anyAttribute" /> element replacements.</summary>
	// Token: 0x020002E4 RID: 740
	public enum XmlSchemaContentProcessing
	{
		/// <summary>Document items are not validated.</summary>
		// Token: 0x0400107A RID: 4218
		[XmlIgnore]
		None,
		/// <summary>Document items must consist of well-formed XML and are not validated by the schema.</summary>
		// Token: 0x0400107B RID: 4219
		[XmlEnum("skip")]
		Skip,
		/// <summary>If the associated schema is found, the document items will be validated. No errors will be thrown otherwise.</summary>
		// Token: 0x0400107C RID: 4220
		[XmlEnum("lax")]
		Lax,
		/// <summary>The schema processor must find a schema associated with the indicated namespace to validate the document items.</summary>
		// Token: 0x0400107D RID: 4221
		[XmlEnum("strict")]
		Strict
	}
}
