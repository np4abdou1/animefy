﻿using System;

namespace System.Xml.Serialization
{
	/// <summary>Delegate used by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class for deserialization of SOAP-encoded XML data types that map to collections or enumerations. </summary>
	/// <param name="collection">The collection into which the collection items array is copied.</param>
	/// <param name="collectionItems">An array of items to be copied into the <paramref name="object collection" />.</param>
	// Token: 0x020001F6 RID: 502
	// (Invoke) Token: 0x0600106B RID: 4203
	public delegate void XmlSerializationCollectionFixupCallback(object collection, object collectionItems);
}
