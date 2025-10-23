using System;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>The exception that is thrown when an error is made adding a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieContainer" />.</summary>
	// Token: 0x0200018C RID: 396
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.CookieException" /> class.</summary>
		// Token: 0x06000ABB RID: 2747 RVA: 0x00013F81 File Offset: 0x00012181
		public CookieException()
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00013F89 File Offset: 0x00012189
		internal CookieException(string message) : base(message)
		{
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00013F92 File Offset: 0x00012192
		internal CookieException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.CookieException" /> class with specific values of <paramref name="serializationInfo" /> and <paramref name="streamingContext" />.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used. </param>
		/// <param name="streamingContext">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> to be used. </param>
		// Token: 0x06000ABE RID: 2750 RVA: 0x00013F9C File Offset: 0x0001219C
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.CookieException" />.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used. </param>
		/// <param name="streamingContext">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> to be used. </param>
		// Token: 0x06000ABF RID: 2751 RVA: 0x00013FA6 File Offset: 0x000121A6
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.CookieException" />.</summary>
		/// <param name="serializationInfo">The object that holds the serialized object data. The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
		/// <param name="streamingContext">The contextual information about the source or destination. A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00013FA6 File Offset: 0x000121A6
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
