using System;

namespace System.Xml.Serialization
{
	/// <summary>Defines the reader, writer, and methods for pre-generated, typed serializers.</summary>
	// Token: 0x0200020A RID: 522
	public abstract class XmlSerializerImplementation
	{
		/// <summary>Gets the XML writer object for the serializer.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> that is used to write to an XML data stream or document.</returns>
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00004836 File Offset: 0x00002A36
		public virtual XmlSerializationWriter Writer
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
