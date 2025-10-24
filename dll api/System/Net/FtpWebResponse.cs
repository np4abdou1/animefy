using System;
using System.IO;

namespace System.Net
{
	/// <summary>Encapsulates a File Transfer Protocol (FTP) server's response to a request.</summary>
	// Token: 0x0200012B RID: 299
	public class FtpWebResponse : WebResponse, IDisposable
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x000310F8 File Offset: 0x0002F2F8
		internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, contentLength, statusLine);
			}
			this._responseStream = responseStream;
			if (responseStream == null && contentLength < 0L)
			{
				contentLength = 0L;
			}
			this._contentLength = contentLength;
			this._responseUri = responseUri;
			this._statusCode = statusCode;
			this._statusLine = statusLine;
			this._lastModified = lastModified;
			this._bannerMessage = bannerMessage;
			this._welcomeMessage = welcomeMessage;
			this._exitMessage = exitMessage;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00031171 File Offset: 0x0002F371
		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
			this._statusCode = statusCode;
			this._statusLine = statusLine;
			this._exitMessage = exitMessage;
		}

		/// <summary>Retrieves the stream that contains response data sent from an FTP server.</summary>
		/// <returns>A readable <see cref="T:System.IO.Stream" /> instance that contains data returned with the response; otherwise, <see cref="F:System.IO.Stream.Null" /> if no response data was returned by the server.</returns>
		/// <exception cref="T:System.InvalidOperationException">The response did not return a data stream. </exception>
		// Token: 0x060008A8 RID: 2216 RVA: 0x00031188 File Offset: 0x0002F388
		public override Stream GetResponseStream()
		{
			Stream result;
			if (this._responseStream != null)
			{
				result = this._responseStream;
			}
			else
			{
				result = (this._responseStream = new FtpWebResponse.EmptyStream());
			}
			return result;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000311B8 File Offset: 0x0002F3B8
		internal void SetResponseStream(Stream stream)
		{
			if (stream == null || stream == Stream.Null || stream is FtpWebResponse.EmptyStream)
			{
				return;
			}
			this._responseStream = stream;
		}

		/// <summary>Frees the resources held by the response.</summary>
		// Token: 0x060008AA RID: 2218 RVA: 0x000311D5 File Offset: 0x0002F3D5
		public override void Close()
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "Close");
			}
			Stream responseStream = this._responseStream;
			if (responseStream != null)
			{
				responseStream.Close();
			}
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Exit(this, null, "Close");
			}
		}

		/// <summary>Gets the length of the data received from the FTP server.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that contains the number of bytes of data received from the FTP server. </returns>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0003120E File Offset: 0x0002F40E
		public override long ContentLength
		{
			get
			{
				return this._contentLength;
			}
		}

		/// <summary>Gets an empty <see cref="T:System.Net.WebHeaderCollection" /> object.</summary>
		/// <returns>An empty <see cref="T:System.Net.WebHeaderCollection" /> object.</returns>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00031218 File Offset: 0x0002F418
		public override WebHeaderCollection Headers
		{
			get
			{
				if (this._ftpRequestHeaders == null)
				{
					lock (this)
					{
						if (this._ftpRequestHeaders == null)
						{
							this._ftpRequestHeaders = new WebHeaderCollection();
						}
					}
				}
				return this._ftpRequestHeaders;
			}
		}

		/// <summary>Gets the URI that sent the response to the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> instance that identifies the resource associated with this response.</returns>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00031270 File Offset: 0x0002F470
		public override Uri ResponseUri
		{
			get
			{
				return this._responseUri;
			}
		}

		/// <summary>Gets the most recent status code sent from the FTP server.</summary>
		/// <returns>An <see cref="T:System.Net.FtpStatusCode" /> value that indicates the most recent status code returned with this response.</returns>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00031278 File Offset: 0x0002F478
		public FtpStatusCode StatusCode
		{
			get
			{
				return this._statusCode;
			}
		}

		// Token: 0x04000615 RID: 1557
		internal Stream _responseStream;

		// Token: 0x04000616 RID: 1558
		private long _contentLength;

		// Token: 0x04000617 RID: 1559
		private Uri _responseUri;

		// Token: 0x04000618 RID: 1560
		private FtpStatusCode _statusCode;

		// Token: 0x04000619 RID: 1561
		private string _statusLine;

		// Token: 0x0400061A RID: 1562
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x0400061B RID: 1563
		private DateTime _lastModified;

		// Token: 0x0400061C RID: 1564
		private string _bannerMessage;

		// Token: 0x0400061D RID: 1565
		private string _welcomeMessage;

		// Token: 0x0400061E RID: 1566
		private string _exitMessage;

		// Token: 0x0200012C RID: 300
		internal sealed class EmptyStream : MemoryStream
		{
			// Token: 0x060008AF RID: 2223 RVA: 0x00031280 File Offset: 0x0002F480
			internal EmptyStream() : base(Array.Empty<byte>(), false)
			{
			}
		}
	}
}
