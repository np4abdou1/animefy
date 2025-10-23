using System;
using System.IO;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Provides a response from a Uniform Resource Identifier (URI). This is an <see langword="abstract" /> class.</summary>
	// Token: 0x0200016B RID: 363
	[Serializable]
	public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebResponse" /> class.</summary>
		// Token: 0x060009F8 RID: 2552 RVA: 0x00034EE2 File Offset: 0x000330E2
		protected WebResponse()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebResponse" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">An instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class that contains the information required to serialize the new <see cref="T:System.Net.WebRequest" /> instance. </param>
		/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that indicates the source of the serialized stream that is associated with the new <see cref="T:System.Net.WebRequest" /> instance. </param>
		/// <exception cref="T:System.NotSupportedException">Any attempt is made to access the constructor, when the constructor is not overridden in a descendant class. </exception>
		// Token: 0x060009F9 RID: 2553 RVA: 0x00034EE2 File Offset: 0x000330E2
		protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data that is needed to serialize <see cref="T:System.Net.WebResponse" />.  </summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that will hold the serialized data for the <see cref="T:System.Net.WebResponse" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream that is associated with the new <see cref="T:System.Net.WebResponse" />. </param>
		// Token: 0x060009FA RID: 2554 RVA: 0x00035284 File Offset: 0x00033484
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization. </param>
		// Token: 0x060009FB RID: 2555 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>When overridden by a descendant class, closes the response stream.</summary>
		/// <exception cref="T:System.NotSupportedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009FC RID: 2556 RVA: 0x00004D67 File Offset: 0x00002F67
		public virtual void Close()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.WebResponse" /> object.</summary>
		// Token: 0x060009FD RID: 2557 RVA: 0x0003528E File Offset: 0x0003348E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.WebResponse" /> object, and optionally disposes of the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources. </param>
		// Token: 0x060009FE RID: 2558 RVA: 0x000352A0 File Offset: 0x000334A0
		protected virtual void Dispose(bool disposing)
		{
			if (!disposing)
			{
				return;
			}
			try
			{
				this.Close();
			}
			catch
			{
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether this response was obtained from the cache.</summary>
		/// <returns>
		///     <see langword="true" /> if the response was taken from the cache; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x000352D0 File Offset: 0x000334D0
		public virtual bool IsFromCache
		{
			get
			{
				return this.m_IsFromCache;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the content length of data being received.</summary>
		/// <returns>The number of bytes returned from the Internet resource.</returns>
		/// <exception cref="T:System.NotSupportedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual long ContentLength
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, returns the data stream from the Internet resource.</summary>
		/// <returns>An instance of the <see cref="T:System.IO.Stream" /> class for reading data from the Internet resource.</returns>
		/// <exception cref="T:System.NotSupportedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x06000A01 RID: 2561 RVA: 0x00033402 File Offset: 0x00031602
		public virtual Stream GetResponseStream()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>When overridden in a derived class, gets the URI of the Internet resource that actually responded to the request.</summary>
		/// <returns>An instance of the <see cref="T:System.Uri" /> class that contains the URI of the Internet resource that actually responded to the request.</returns>
		/// <exception cref="T:System.NotSupportedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual Uri ResponseUri
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a derived class, gets a collection of header name-value pairs associated with this request.</summary>
		/// <returns>An instance of the <see cref="T:System.Net.WebHeaderCollection" /> class that contains header values associated with this response.</returns>
		/// <exception cref="T:System.NotSupportedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual WebHeaderCollection Headers
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		// Token: 0x0400074C RID: 1868
		private bool m_IsFromCache;
	}
}
