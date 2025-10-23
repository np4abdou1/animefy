using System;

namespace System.Runtime.Serialization
{
	/// <summary>Allows an object to control its own serialization and deserialization.</summary>
	// Token: 0x02000391 RID: 913
	public interface ISerializable
	{
		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001C71 RID: 7281
		void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}
