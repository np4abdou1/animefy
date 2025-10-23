using System;

namespace System.Runtime.Serialization
{
	/// <summary>Indicates that a class is to be notified when deserialization of the entire object graph has been completed. Note that this interface is not called when deserializing with the XmlSerializer (System.Xml.Serialization.XmlSerializer).</summary>
	// Token: 0x0200038E RID: 910
	public interface IDeserializationCallback
	{
		/// <summary>Runs when the entire object graph has been deserialized.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented. </param>
		// Token: 0x06001C69 RID: 7273
		void OnDeserialization(object sender);
	}
}
