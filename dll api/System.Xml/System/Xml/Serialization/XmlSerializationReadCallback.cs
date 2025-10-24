using System;

namespace System.Xml.Serialization
{
	/// <summary>Delegate used by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class for deserialization of types from SOAP-encoded, non-root XML data. </summary>
	/// <returns>The object returned by the callback.</returns>
	// Token: 0x020001F9 RID: 505
	// (Invoke) Token: 0x06001074 RID: 4212
	public delegate object XmlSerializationReadCallback();
}
