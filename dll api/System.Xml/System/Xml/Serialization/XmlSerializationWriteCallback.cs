using System;

namespace System.Xml.Serialization
{
	/// <summary>Delegate that is used by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class for serialization of types from SOAP-encoded, non-root XML data. </summary>
	/// <param name="o">The object being serialized.</param>
	// Token: 0x02000202 RID: 514
	// (Invoke) Token: 0x060010E5 RID: 4325
	public delegate void XmlSerializationWriteCallback(object o);
}
