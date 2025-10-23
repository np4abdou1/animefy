using System;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>The exception that is thrown when an error occurs while accessing the network through a pluggable protocol.</summary>
	// Token: 0x0200015F RID: 351
	[Serializable]
	public class WebException : InvalidOperationException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class.</summary>
		// Token: 0x06000991 RID: 2449 RVA: 0x00033DE5 File Offset: 0x00031FE5
		public WebException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message.</summary>
		/// <param name="message">The text of the error message. </param>
		// Token: 0x06000992 RID: 2450 RVA: 0x00033DF5 File Offset: 0x00031FF5
		public WebException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message and nested exception.</summary>
		/// <param name="message">The text of the error message. </param>
		/// <param name="innerException">A nested exception. </param>
		// Token: 0x06000993 RID: 2451 RVA: 0x00033DFF File Offset: 0x00031FFF
		public WebException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message and status.</summary>
		/// <param name="message">The text of the error message. </param>
		/// <param name="status">One of the <see cref="T:System.Net.WebExceptionStatus" /> values. </param>
		// Token: 0x06000994 RID: 2452 RVA: 0x00033E11 File Offset: 0x00032011
		public WebException(string message, WebExceptionStatus status) : this(message, null, status, null)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00033E1D File Offset: 0x0003201D
		internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) : this(message, innerException, status, null, internalStatus)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message, nested exception, status, and response.</summary>
		/// <param name="message">The text of the error message. </param>
		/// <param name="innerException">A nested exception. </param>
		/// <param name="status">One of the <see cref="T:System.Net.WebExceptionStatus" /> values. </param>
		/// <param name="response">A <see cref="T:System.Net.WebResponse" /> instance that contains the response from the remote host. </param>
		// Token: 0x06000996 RID: 2454 RVA: 0x00033E2B File Offset: 0x0003202B
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) : this(message, null, innerException, status, response)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00033E3C File Offset: 0x0003203C
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) : base(message + ((data != null) ? (": '" + data + "'") : ""), innerException)
		{
			this.m_Status = status;
			this.m_Response = response;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00033E88 File Offset: 0x00032088
		internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) : this(message, null, innerException, status, response, internalStatus)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00033E98 File Offset: 0x00032098
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) : base(message + ((data != null) ? (": '" + data + "'") : ""), innerException)
		{
			this.m_Status = status;
			this.m_Response = response;
			this.m_InternalStatus = internalStatus;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class from the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.WebException" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.WebException" />. </param>
		// Token: 0x0600099A RID: 2458 RVA: 0x00033EEC File Offset: 0x000320EC
		protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
		/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.WebException" /> will be serialized. </param>
		/// <param name="streamingContext">The destination of the serialization. </param>
		// Token: 0x0600099B RID: 2459 RVA: 0x00033EFE File Offset: 0x000320FE
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.WebException" />.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used. </param>
		/// <param name="streamingContext">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> to be used. </param>
		// Token: 0x0600099C RID: 2460 RVA: 0x00013FA6 File Offset: 0x000121A6
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Gets the status of the response.</summary>
		/// <returns>One of the <see cref="T:System.Net.WebExceptionStatus" /> values.</returns>
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00033F08 File Offset: 0x00032108
		public WebExceptionStatus Status
		{
			get
			{
				return this.m_Status;
			}
		}

		/// <summary>Gets the response that the remote host returned.</summary>
		/// <returns>If a response is available from the Internet resource, a <see cref="T:System.Net.WebResponse" /> instance that contains the error response from an Internet resource; otherwise, <see langword="null" />.</returns>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00033F10 File Offset: 0x00032110
		public WebResponse Response
		{
			get
			{
				return this.m_Response;
			}
		}

		// Token: 0x040006FE RID: 1790
		private WebExceptionStatus m_Status = WebExceptionStatus.UnknownError;

		// Token: 0x040006FF RID: 1791
		private WebResponse m_Response;

		// Token: 0x04000700 RID: 1792
		[NonSerialized]
		private WebExceptionInternalStatus m_InternalStatus;
	}
}
