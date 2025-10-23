using System;

namespace System.Runtime.Serialization
{
	/// <summary>Enables serialization of custom exception data in security-transparent code.</summary>
	// Token: 0x020003AE RID: 942
	public interface ISafeSerializationData
	{
		/// <summary>This method is called when the instance is deserialized. </summary>
		/// <param name="deserialized">An object that contains the state of the instance.</param>
		// Token: 0x06001D33 RID: 7475
		void CompleteDeserialization(object deserialized);
	}
}
