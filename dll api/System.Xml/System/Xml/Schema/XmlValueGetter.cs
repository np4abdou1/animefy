﻿using System;

namespace System.Xml.Schema
{
	/// <summary>A <see langword="delegate" /> used by the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> class to pass attribute, text, and white space values as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute, text, or white space.</summary>
	/// <returns>An object containing the attribute, text, or white space value. The object is a CLR type that that corresponds to the XSD type of the attribute, text, or white space value.</returns>
	// Token: 0x02000324 RID: 804
	// (Invoke) Token: 0x06001AA8 RID: 6824
	public delegate object XmlValueGetter();
}
