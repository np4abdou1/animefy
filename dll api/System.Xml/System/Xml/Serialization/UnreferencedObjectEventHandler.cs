using System;

namespace System.Xml.Serialization
{
	/// <summary>Represents the method that handles the <see cref="E:System.Xml.Serialization.XmlSerializer.UnreferencedObject" /> event of an <see cref="T:System.Xml.Serialization.XmlSerializer" />.</summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">An <see cref="T:System.Xml.Serialization.UnreferencedObjectEventArgs" /> that contains the event data. </param>
	// Token: 0x020001CE RID: 462
	// (Invoke) Token: 0x06000F8F RID: 3983
	public delegate void UnreferencedObjectEventHandler(object sender, UnreferencedObjectEventArgs e);
}
