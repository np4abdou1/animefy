﻿using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an invalid Uniform Resource Identifier (URI) is detected.</summary>
	// Token: 0x0200007E RID: 126
	[Serializable]
	public class UriFormatException : FormatException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.UriFormatException" /> class.</summary>
		// Token: 0x0600036F RID: 879 RVA: 0x00013F81 File Offset: 0x00012181
		public UriFormatException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriFormatException" /> class with the specified message.</summary>
		/// <param name="textString">The error message string. </param>
		// Token: 0x06000370 RID: 880 RVA: 0x00013F89 File Offset: 0x00012189
		public UriFormatException(string textString) : base(textString)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriFormatException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="textString">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		/// <param name="e">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000371 RID: 881 RVA: 0x00013F92 File Offset: 0x00012192
		public UriFormatException(string textString, Exception e) : base(textString, e)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriFormatException" /> class from the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information that is required to serialize the new <see cref="T:System.UriFormatException" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.UriFormatException" />. </param>
		// Token: 0x06000372 RID: 882 RVA: 0x00013F9C File Offset: 0x0001219C
		protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data that is needed to serialize the <see cref="T:System.UriFormatException" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that will hold the serialized data for the <see cref="T:System.UriFormatException" />.</param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream that is associated with the new <see cref="T:System.UriFormatException" />. </param>
		// Token: 0x06000373 RID: 883 RVA: 0x00013FA6 File Offset: 0x000121A6
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
