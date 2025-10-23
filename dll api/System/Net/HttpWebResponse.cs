using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Net
{
	/// <summary>Provides an HTTP-specific implementation of the <see cref="T:System.Net.WebResponse" /> class.</summary>
	// Token: 0x020001B4 RID: 436
	[Serializable]
	public class HttpWebResponse : WebResponse, ISerializable, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebResponse" /> class.</summary>
		// Token: 0x06000BDB RID: 3035 RVA: 0x0003E68E File Offset: 0x0003C88E
		public HttpWebResponse()
		{
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0003E698 File Offset: 0x0003C898
		internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
		{
			this.uri = uri;
			this.method = method;
			this.statusCode = status;
			this.statusDescription = HttpStatusDescription.Get(status);
			this.webHeaders = headers;
			this.version = HttpVersion.Version10;
			this.contentLength = -1L;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
		internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
		{
			this.uri = uri;
			this.method = method;
			this.stream = stream;
			this.webHeaders = (stream.Headers ?? new WebHeaderCollection());
			this.version = stream.Version;
			this.statusCode = stream.StatusCode;
			this.statusDescription = (stream.StatusDescription ?? HttpStatusDescription.Get(this.statusCode));
			this.contentLength = -1L;
			try
			{
				string text = this.webHeaders["Content-Length"];
				if (string.IsNullOrEmpty(text) || !long.TryParse(text, out this.contentLength))
				{
					this.contentLength = -1L;
				}
			}
			catch (Exception)
			{
				this.contentLength = -1L;
			}
			if (container != null)
			{
				this.cookie_container = container;
				this.FillCookies();
			}
			string a = this.webHeaders["Content-Encoding"];
			if (a == "gzip" && (stream.Request.AutomaticDecompression & DecompressionMethods.GZip) != DecompressionMethods.None)
			{
				this.stream = new GZipStream(stream, CompressionMode.Decompress);
				this.webHeaders.Remove(HttpRequestHeader.ContentEncoding);
				return;
			}
			if (a == "deflate" && (stream.Request.AutomaticDecompression & DecompressionMethods.Deflate) != DecompressionMethods.None)
			{
				this.stream = new DeflateStream(stream, CompressionMode.Decompress);
				this.webHeaders.Remove(HttpRequestHeader.ContentEncoding);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebResponse" /> class from the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.HttpWebRequest" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.HttpWebRequest" />. </param>
		// Token: 0x06000BDE RID: 3038 RVA: 0x0003E83C File Offset: 0x0003CA3C
		protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.uri = (Uri)serializationInfo.GetValue("uri", typeof(Uri));
			this.contentLength = serializationInfo.GetInt64("contentLength");
			this.contentType = serializationInfo.GetString("contentType");
			this.method = serializationInfo.GetString("method");
			this.statusDescription = serializationInfo.GetString("statusDescription");
			this.cookieCollection = (CookieCollection)serializationInfo.GetValue("cookieCollection", typeof(CookieCollection));
			this.version = (Version)serializationInfo.GetValue("version", typeof(Version));
			this.statusCode = (HttpStatusCode)serializationInfo.GetValue("statusCode", typeof(HttpStatusCode));
		}

		/// <summary>Gets the length of the content returned by the request.</summary>
		/// <returns>The number of bytes returned by the request. Content length does not include header information.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0003E915 File Offset: 0x0003CB15
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
		}

		/// <summary>Gets the headers that are associated with this response from the server.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the header information returned with the response.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0003E91D File Offset: 0x0003CB1D
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
		}

		/// <summary>Gets the URI of the Internet resource that responded to the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the Internet resource that responded to the request.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0003E925 File Offset: 0x0003CB25
		public override Uri ResponseUri
		{
			get
			{
				this.CheckDisposed();
				return this.uri;
			}
		}

		/// <summary>Gets the status of the response.</summary>
		/// <returns>One of the <see cref="T:System.Net.HttpStatusCode" /> values.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0003E933 File Offset: 0x0003CB33
		public virtual HttpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
		}

		/// <summary>Gets the status description returned with the response.</summary>
		/// <returns>A string that describes the status of the response.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0003E93B File Offset: 0x0003CB3B
		public virtual string StatusDescription
		{
			get
			{
				this.CheckDisposed();
				return this.statusDescription;
			}
		}

		/// <summary>Gets the stream that is used to read the body of the response from the server.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> containing the body of the response.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">There is no response stream. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		// Token: 0x06000BE4 RID: 3044 RVA: 0x0003E949 File Offset: 0x0003CB49
		public override Stream GetResponseStream()
		{
			this.CheckDisposed();
			if (this.stream == null)
			{
				return Stream.Null;
			}
			if (string.Equals(this.method, "HEAD", StringComparison.OrdinalIgnoreCase))
			{
				return Stream.Null;
			}
			return this.stream;
		}

		/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
		/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.HttpWebResponse" /> will be serialized. </param>
		/// <param name="streamingContext">The destination of the serialization. </param>
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00035284 File Offset: 0x00033484
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06000BE6 RID: 3046 RVA: 0x0003E980 File Offset: 0x0003CB80
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("uri", this.uri);
			serializationInfo.AddValue("contentLength", this.contentLength);
			serializationInfo.AddValue("contentType", this.contentType);
			serializationInfo.AddValue("method", this.method);
			serializationInfo.AddValue("statusDescription", this.statusDescription);
			serializationInfo.AddValue("cookieCollection", this.cookieCollection);
			serializationInfo.AddValue("version", this.version);
			serializationInfo.AddValue("statusCode", this.statusCode);
		}

		/// <summary>Closes the response stream.</summary>
		// Token: 0x06000BE7 RID: 3047 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		public override void Close()
		{
			Stream stream = Interlocked.Exchange<Stream>(ref this.stream, null);
			if (stream != null)
			{
				stream.Close();
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0003EA3F File Offset: 0x0003CC3F
		void IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.HttpWebResponse" />, and optionally disposes of the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources. </param>
		// Token: 0x06000BE9 RID: 3049 RVA: 0x0003EA48 File Offset: 0x0003CC48
		protected override void Dispose(bool disposing)
		{
			this.disposed = true;
			base.Dispose(true);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0003EA58 File Offset: 0x0003CC58
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0003EA74 File Offset: 0x0003CC74
		private void FillCookies()
		{
			if (this.webHeaders == null)
			{
				return;
			}
			CookieCollection cookieCollection = null;
			try
			{
				string text = this.webHeaders.Get("Set-Cookie");
				if (text != null)
				{
					cookieCollection = this.cookie_container.CookieCutter(this.uri, "Set-Cookie", text, false);
				}
			}
			catch
			{
			}
			try
			{
				string text = this.webHeaders.Get("Set-Cookie2");
				if (text != null)
				{
					CookieCollection cookieCollection2 = this.cookie_container.CookieCutter(this.uri, "Set-Cookie2", text, false);
					if (cookieCollection != null && cookieCollection.Count != 0)
					{
						cookieCollection.Add(cookieCollection2);
					}
					else
					{
						cookieCollection = cookieCollection2;
					}
				}
			}
			catch
			{
			}
			this.cookieCollection = cookieCollection;
		}

		// Token: 0x0400089F RID: 2207
		private Uri uri;

		// Token: 0x040008A0 RID: 2208
		private WebHeaderCollection webHeaders;

		// Token: 0x040008A1 RID: 2209
		private CookieCollection cookieCollection;

		// Token: 0x040008A2 RID: 2210
		private string method;

		// Token: 0x040008A3 RID: 2211
		private Version version;

		// Token: 0x040008A4 RID: 2212
		private HttpStatusCode statusCode;

		// Token: 0x040008A5 RID: 2213
		private string statusDescription;

		// Token: 0x040008A6 RID: 2214
		private long contentLength;

		// Token: 0x040008A7 RID: 2215
		private string contentType;

		// Token: 0x040008A8 RID: 2216
		private CookieContainer cookie_container;

		// Token: 0x040008A9 RID: 2217
		private bool disposed;

		// Token: 0x040008AA RID: 2218
		private Stream stream;
	}
}
