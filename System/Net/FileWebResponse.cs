using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Provides a file system implementation of the <see cref="T:System.Net.WebResponse" /> class.</summary>
	// Token: 0x02000190 RID: 400
	[Serializable]
	public class FileWebResponse : WebResponse, ISerializable, ICloseEx
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x00039D34 File Offset: 0x00037F34
		internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
		{
			try
			{
				this.m_fileAccess = access;
				if (access == FileAccess.Write)
				{
					this.m_stream = Stream.Null;
				}
				else
				{
					this.m_stream = new FileWebStream(request, uri.LocalPath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192, asyncHint);
					this.m_contentLength = this.m_stream.Length;
				}
				this.m_headers = new WebHeaderCollection(WebHeaderCollectionType.FileWebResponse);
				this.m_headers.AddInternal("Content-Length", this.m_contentLength.ToString(NumberFormatInfo.InvariantInfo));
				this.m_headers.AddInternal("Content-Type", "application/octet-stream");
				this.m_uri = uri;
			}
			catch (Exception ex)
			{
				throw new WebException(ex.Message, ex, WebExceptionStatus.ConnectFailure, null);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.FileWebResponse" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance that contains the information required to serialize the new <see cref="T:System.Net.FileWebResponse" /> instance. </param>
		/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that contains the source of the serialized stream associated with the new <see cref="T:System.Net.FileWebResponse" /> instance. </param>
		// Token: 0x06000AED RID: 2797 RVA: 0x00039DF8 File Offset: 0x00037FF8
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			this.m_headers = (WebHeaderCollection)serializationInfo.GetValue("headers", typeof(WebHeaderCollection));
			this.m_uri = (Uri)serializationInfo.GetValue("uri", typeof(Uri));
			this.m_contentLength = serializationInfo.GetInt64("contentLength");
			this.m_fileAccess = (FileAccess)serializationInfo.GetInt32("fileAccess");
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.FileWebResponse" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> , which will hold the serialized data for the <see cref="T:System.Net.FileWebResponse" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> containing the destination of the serialized stream associated with the new <see cref="T:System.Net.FileWebResponse" />. </param>
		// Token: 0x06000AEE RID: 2798 RVA: 0x00035284 File Offset: 0x00033484
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06000AEF RID: 2799 RVA: 0x00039E70 File Offset: 0x00038070
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("headers", this.m_headers, typeof(WebHeaderCollection));
			serializationInfo.AddValue("uri", this.m_uri, typeof(Uri));
			serializationInfo.AddValue("contentLength", this.m_contentLength);
			serializationInfo.AddValue("fileAccess", this.m_fileAccess);
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Gets the length of the content in the file system resource.</summary>
		/// <returns>The number of bytes returned from the file system resource.</returns>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00039EE2 File Offset: 0x000380E2
		public override long ContentLength
		{
			get
			{
				this.CheckDisposed();
				return this.m_contentLength;
			}
		}

		/// <summary>Gets a collection of header name/value pairs associated with the response.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the header name/value pairs associated with the response.</returns>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00039EF0 File Offset: 0x000380F0
		public override WebHeaderCollection Headers
		{
			get
			{
				this.CheckDisposed();
				return this.m_headers;
			}
		}

		/// <summary>Gets the URI of the file system resource that provided the response.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the file system resource that provided the response.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00039EFE File Offset: 0x000380FE
		public override Uri ResponseUri
		{
			get
			{
				this.CheckDisposed();
				return this.m_uri;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00039F0C File Offset: 0x0003810C
		private void CheckDisposed()
		{
			if (this.m_closed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		/// <summary>Closes the response stream.</summary>
		// Token: 0x06000AF4 RID: 2804 RVA: 0x00039F27 File Offset: 0x00038127
		public override void Close()
		{
			((ICloseEx)this).CloseEx(CloseExState.Normal);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00039F30 File Offset: 0x00038130
		void ICloseEx.CloseEx(CloseExState closeState)
		{
			try
			{
				if (!this.m_closed)
				{
					this.m_closed = true;
					Stream stream = this.m_stream;
					if (stream != null)
					{
						if (stream is ICloseEx)
						{
							((ICloseEx)stream).CloseEx(closeState);
						}
						else
						{
							stream.Close();
						}
						this.m_stream = null;
					}
				}
			}
			finally
			{
			}
		}

		/// <summary>Returns the data stream from the file system resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> for reading data from the file system resource.</returns>
		// Token: 0x06000AF6 RID: 2806 RVA: 0x00039F8C File Offset: 0x0003818C
		public override Stream GetResponseStream()
		{
			try
			{
				this.CheckDisposed();
			}
			finally
			{
			}
			return this.m_stream;
		}

		// Token: 0x040007F2 RID: 2034
		private bool m_closed;

		// Token: 0x040007F3 RID: 2035
		private long m_contentLength;

		// Token: 0x040007F4 RID: 2036
		private FileAccess m_fileAccess;

		// Token: 0x040007F5 RID: 2037
		private WebHeaderCollection m_headers;

		// Token: 0x040007F6 RID: 2038
		private Stream m_stream;

		// Token: 0x040007F7 RID: 2039
		private Uri m_uri;
	}
}
