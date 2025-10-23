using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Net
{
	/// <summary>Provides a file system implementation of the <see cref="T:System.Net.WebRequest" /> class.</summary>
	// Token: 0x0200018D RID: 397
	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06000AC1 RID: 2753 RVA: 0x00039250 File Offset: 0x00037450
		internal FileWebRequest(Uri uri)
		{
			if (uri.Scheme != Uri.UriSchemeFile)
			{
				throw new ArgumentOutOfRangeException("uri");
			}
			this.m_uri = uri;
			this.m_fileAccess = FileAccess.Read;
			this.m_headers = new WebHeaderCollection(WebHeaderCollectionType.FileWebRequest);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.FileWebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information that is required to serialize the new <see cref="T:System.Net.FileWebRequest" /> object. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.FileWebRequest" /> object. </param>
		// Token: 0x06000AC2 RID: 2754 RVA: 0x000392AC File Offset: 0x000374AC
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			this.m_headers = (WebHeaderCollection)serializationInfo.GetValue("headers", typeof(WebHeaderCollection));
			this.m_proxy = (IWebProxy)serializationInfo.GetValue("proxy", typeof(IWebProxy));
			this.m_uri = (Uri)serializationInfo.GetValue("uri", typeof(Uri));
			this.m_connectionGroupName = serializationInfo.GetString("connectionGroupName");
			this.m_method = serializationInfo.GetString("method");
			this.m_contentLength = serializationInfo.GetInt64("contentLength");
			this.m_timeout = serializationInfo.GetInt32("timeout");
			this.m_fileAccess = (FileAccess)serializationInfo.GetInt32("fileAccess");
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the required data to serialize the <see cref="T:System.Net.FileWebRequest" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized data for the <see cref="T:System.Net.FileWebRequest" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream that is associated with the new <see cref="T:System.Net.FileWebRequest" />. </param>
		// Token: 0x06000AC3 RID: 2755 RVA: 0x00034EEA File Offset: 0x000330EA
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" />  that specifies the destination for this serialization. </param>
		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003938C File Offset: 0x0003758C
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("headers", this.m_headers, typeof(WebHeaderCollection));
			serializationInfo.AddValue("proxy", this.m_proxy, typeof(IWebProxy));
			serializationInfo.AddValue("uri", this.m_uri, typeof(Uri));
			serializationInfo.AddValue("connectionGroupName", this.m_connectionGroupName);
			serializationInfo.AddValue("method", this.m_method);
			serializationInfo.AddValue("contentLength", this.m_contentLength);
			serializationInfo.AddValue("timeout", this.m_timeout);
			serializationInfo.AddValue("fileAccess", this.m_fileAccess);
			serializationInfo.AddValue("preauthenticate", false);
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00039458 File Offset: 0x00037658
		internal bool Aborted
		{
			get
			{
				return this.m_Aborted != 0;
			}
		}

		/// <summary>Gets or sets the content length of the data being sent.</summary>
		/// <returns>The number of bytes of request data being sent.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <see cref="P:System.Net.FileWebRequest.ContentLength" /> is less than 0. </exception>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00039463 File Offset: 0x00037663
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0003946B File Offset: 0x0003766B
		public override long ContentLength
		{
			get
			{
				return this.m_contentLength;
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentException(SR.GetString("The Content-Length value must be greater than or equal to zero."), "value");
				}
				this.m_contentLength = value;
			}
		}

		/// <summary>Gets or sets the content type of the data being sent. This property is reserved for future use.</summary>
		/// <returns>The content type of the data being sent.</returns>
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0003948E File Offset: 0x0003768E
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x000394A0 File Offset: 0x000376A0
		public override string ContentType
		{
			get
			{
				return this.m_headers["Content-Type"];
			}
			set
			{
				this.m_headers["Content-Type"] = value;
			}
		}

		/// <summary>Gets or sets the credentials that are associated with this request. This property is reserved for future use.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that contains the authentication credentials that are associated with this request. The default is <see langword="null" />.</returns>
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000394B3 File Offset: 0x000376B3
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x000394BB File Offset: 0x000376BB
		public override ICredentials Credentials
		{
			get
			{
				return this.m_credentials;
			}
			set
			{
				this.m_credentials = value;
			}
		}

		/// <summary>Gets a collection of the name/value pairs that are associated with the request. This property is reserved for future use.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains header name/value pairs associated with this request.</returns>
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000394C4 File Offset: 0x000376C4
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.m_headers;
			}
		}

		/// <summary>Gets or sets the protocol method used for the request. This property is reserved for future use.</summary>
		/// <returns>The protocol method to use in this request.</returns>
		/// <exception cref="T:System.ArgumentException">The method is invalid.- or -The method is not supported.- or -Multiple methods were specified.</exception>
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x000394CC File Offset: 0x000376CC
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x000394D4 File Offset: 0x000376D4
		public override string Method
		{
			get
			{
				return this.m_method;
			}
			set
			{
				if (ValidationHelper.IsBlankString(value))
				{
					throw new ArgumentException(SR.GetString("Cannot set null or blank methods on request."), "value");
				}
				this.m_method = value;
			}
		}

		/// <summary>Gets or sets the network proxy to use for this request. This property is reserved for future use.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> that indicates the network proxy to use for this request.</returns>
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000394FA File Offset: 0x000376FA
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00039502 File Offset: 0x00037702
		public override IWebProxy Proxy
		{
			get
			{
				return this.m_proxy;
			}
			set
			{
				this.m_proxy = value;
			}
		}

		/// <summary>Gets or sets the length of time until the request times out.</summary>
		/// <returns>The time, in milliseconds, until the request times out, or the value <see cref="F:System.Threading.Timeout.Infinite" /> to indicate that the request does not time out.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0003950B File Offset: 0x0003770B
		public override int Timeout
		{
			get
			{
				return this.m_timeout;
			}
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the request.</returns>
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00039513 File Offset: 0x00037713
		public override Uri RequestUri
		{
			get
			{
				return this.m_uri;
			}
		}

		/// <summary>Begins an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.FileWebRequest.Method" /> property is GET and the application writes to the stream. </exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is being used by a previous call to <see cref="M:System.Net.FileWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.ApplicationException">No write stream is available. </exception>
		/// <exception cref="T:System.Net.WebException">The <see cref="T:System.Net.FileWebRequest" /> was aborted. </exception>
		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003951C File Offset: 0x0003771C
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			try
			{
				if (this.Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				if (!this.CanGetRequestStream())
				{
					throw new ProtocolViolationException(SR.GetString("Cannot send a content-body with this verb-type."));
				}
				if (this.m_response != null)
				{
					throw new InvalidOperationException(SR.GetString("This operation cannot be performed after the request has been submitted."));
				}
				lock (this)
				{
					if (this.m_writePending)
					{
						throw new InvalidOperationException(SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress."));
					}
					this.m_writePending = true;
				}
				this.m_ReadAResult = new LazyAsyncResult(this, state, callback);
				ThreadPool.QueueUserWorkItem(FileWebRequest.s_GetRequestStreamCallback, this.m_ReadAResult);
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.m_ReadAResult;
		}

		/// <summary>Begins an asynchronous request for a file system resource.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.FileWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.Net.WebException">The <see cref="T:System.Net.FileWebRequest" /> was aborted. </exception>
		// Token: 0x06000AD4 RID: 2772 RVA: 0x000395F8 File Offset: 0x000377F8
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			try
			{
				if (this.Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				lock (this)
				{
					if (this.m_readPending)
					{
						throw new InvalidOperationException(SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress."));
					}
					this.m_readPending = true;
				}
				this.m_WriteAResult = new LazyAsyncResult(this, state, callback);
				ThreadPool.QueueUserWorkItem(FileWebRequest.s_GetResponseCallback, this.m_WriteAResult);
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.m_WriteAResult;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000396A4 File Offset: 0x000378A4
		private bool CanGetRequestStream()
		{
			return !KnownHttpVerb.Parse(this.m_method).ContentBodyNotAllowed;
		}

		/// <summary>Ends an asynchronous request for a <see cref="T:System.IO.Stream" /> instance that the application uses to write data.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references the pending request for a stream. </param>
		/// <returns>A <see cref="T:System.IO.Stream" /> object that the application uses to write data.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		// Token: 0x06000AD6 RID: 2774 RVA: 0x000396BC File Offset: 0x000378BC
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			Stream result;
			try
			{
				LazyAsyncResult lazyAsyncResult = asyncResult as LazyAsyncResult;
				if (asyncResult == null || lazyAsyncResult == null)
				{
					throw (asyncResult == null) ? new ArgumentNullException("asyncResult") : new ArgumentException(SR.GetString("The AsyncResult is not valid."), "asyncResult");
				}
				object obj = lazyAsyncResult.InternalWaitForCompletion();
				if (obj is Exception)
				{
					throw (Exception)obj;
				}
				result = (Stream)obj;
				this.m_writePending = false;
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return result;
		}

		/// <summary>Ends an asynchronous request for a file system resource.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references the pending request for a response. </param>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the file system resource.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		// Token: 0x06000AD7 RID: 2775 RVA: 0x00039748 File Offset: 0x00037948
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			WebResponse result;
			try
			{
				LazyAsyncResult lazyAsyncResult = asyncResult as LazyAsyncResult;
				if (asyncResult == null || lazyAsyncResult == null)
				{
					throw (asyncResult == null) ? new ArgumentNullException("asyncResult") : new ArgumentException(SR.GetString("The AsyncResult is not valid."), "asyncResult");
				}
				object obj = lazyAsyncResult.InternalWaitForCompletion();
				if (obj is Exception)
				{
					throw (Exception)obj;
				}
				result = (WebResponse)obj;
				this.m_readPending = false;
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return result;
		}

		/// <summary>Returns a response to a file system request.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the file system resource.</returns>
		/// <exception cref="T:System.Net.WebException">The request timed out. </exception>
		// Token: 0x06000AD8 RID: 2776 RVA: 0x000397D4 File Offset: 0x000379D4
		public override WebResponse GetResponse()
		{
			this.m_syncHint = true;
			IAsyncResult asyncResult;
			try
			{
				asyncResult = this.BeginGetResponse(null, null);
				if (this.Timeout != -1 && !asyncResult.IsCompleted && (!asyncResult.AsyncWaitHandle.WaitOne(this.Timeout, false) || !asyncResult.IsCompleted))
				{
					if (this.m_response != null)
					{
						this.m_response.Close();
					}
					throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
				}
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.EndGetResponse(asyncResult);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00039870 File Offset: 0x00037A70
		private static void GetRequestStreamCallback(object state)
		{
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)state;
			FileWebRequest fileWebRequest = (FileWebRequest)lazyAsyncResult.AsyncObject;
			try
			{
				if (fileWebRequest.m_stream == null)
				{
					fileWebRequest.m_stream = new FileWebStream(fileWebRequest, fileWebRequest.m_uri.LocalPath, FileMode.Create, FileAccess.Write, FileShare.Read);
					fileWebRequest.m_fileAccess = FileAccess.Write;
					fileWebRequest.m_writing = true;
				}
			}
			catch (Exception ex)
			{
				Exception result = new WebException(ex.Message, ex);
				lazyAsyncResult.InvokeCallback(result);
				return;
			}
			lazyAsyncResult.InvokeCallback(fileWebRequest.m_stream);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000398F8 File Offset: 0x00037AF8
		private static void GetResponseCallback(object state)
		{
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)state;
			FileWebRequest fileWebRequest = (FileWebRequest)lazyAsyncResult.AsyncObject;
			if (fileWebRequest.m_writePending || fileWebRequest.m_writing)
			{
				FileWebRequest obj = fileWebRequest;
				lock (obj)
				{
					if (fileWebRequest.m_writePending || fileWebRequest.m_writing)
					{
						fileWebRequest.m_readerEvent = new ManualResetEvent(false);
					}
				}
			}
			if (fileWebRequest.m_readerEvent != null)
			{
				fileWebRequest.m_readerEvent.WaitOne();
			}
			try
			{
				if (fileWebRequest.m_response == null)
				{
					fileWebRequest.m_response = new FileWebResponse(fileWebRequest, fileWebRequest.m_uri, fileWebRequest.m_fileAccess, !fileWebRequest.m_syncHint);
				}
			}
			catch (Exception ex)
			{
				Exception result = new WebException(ex.Message, ex);
				lazyAsyncResult.InvokeCallback(result);
				return;
			}
			lazyAsyncResult.InvokeCallback(fileWebRequest.m_response);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000399E0 File Offset: 0x00037BE0
		internal void UnblockReader()
		{
			lock (this)
			{
				if (this.m_readerEvent != null)
				{
					this.m_readerEvent.Set();
				}
			}
			this.m_writing = false;
		}

		/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Default credentials are not supported for file Uniform Resource Identifiers (URIs).</exception>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00030D3A File Offset: 0x0002EF3A
		public override bool UseDefaultCredentials
		{
			get
			{
				throw ExceptionHelper.PropertyNotSupportedException;
			}
		}

		/// <summary>Cancels a request to an Internet resource.</summary>
		// Token: 0x06000ADD RID: 2781 RVA: 0x00039A30 File Offset: 0x00037C30
		public override void Abort()
		{
			bool on = Logging.On;
			try
			{
				if (Interlocked.Increment(ref this.m_Aborted) == 1)
				{
					LazyAsyncResult readAResult = this.m_ReadAResult;
					LazyAsyncResult writeAResult = this.m_WriteAResult;
					WebException result = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
					Stream stream = this.m_stream;
					if (readAResult != null && !readAResult.IsCompleted)
					{
						readAResult.InvokeCallback(result);
					}
					if (writeAResult != null && !writeAResult.IsCompleted)
					{
						writeAResult.InvokeCallback(result);
					}
					if (stream != null)
					{
						if (stream is ICloseEx)
						{
							((ICloseEx)stream).CloseEx(CloseExState.Abort);
						}
						else
						{
							stream.Close();
						}
					}
					if (this.m_response != null)
					{
						((ICloseEx)this.m_response).CloseEx(CloseExState.Abort);
					}
				}
			}
			catch (Exception)
			{
				bool on2 = Logging.On;
				throw;
			}
			finally
			{
			}
		}

		// Token: 0x040007DC RID: 2012
		private static WaitCallback s_GetRequestStreamCallback = new WaitCallback(FileWebRequest.GetRequestStreamCallback);

		// Token: 0x040007DD RID: 2013
		private static WaitCallback s_GetResponseCallback = new WaitCallback(FileWebRequest.GetResponseCallback);

		// Token: 0x040007DE RID: 2014
		private string m_connectionGroupName;

		// Token: 0x040007DF RID: 2015
		private long m_contentLength;

		// Token: 0x040007E0 RID: 2016
		private ICredentials m_credentials;

		// Token: 0x040007E1 RID: 2017
		private FileAccess m_fileAccess;

		// Token: 0x040007E2 RID: 2018
		private WebHeaderCollection m_headers;

		// Token: 0x040007E3 RID: 2019
		private string m_method = "GET";

		// Token: 0x040007E4 RID: 2020
		private IWebProxy m_proxy;

		// Token: 0x040007E5 RID: 2021
		private ManualResetEvent m_readerEvent;

		// Token: 0x040007E6 RID: 2022
		private bool m_readPending;

		// Token: 0x040007E7 RID: 2023
		private WebResponse m_response;

		// Token: 0x040007E8 RID: 2024
		private Stream m_stream;

		// Token: 0x040007E9 RID: 2025
		private bool m_syncHint;

		// Token: 0x040007EA RID: 2026
		private int m_timeout = 100000;

		// Token: 0x040007EB RID: 2027
		private Uri m_uri;

		// Token: 0x040007EC RID: 2028
		private bool m_writePending;

		// Token: 0x040007ED RID: 2029
		private bool m_writing;

		// Token: 0x040007EE RID: 2030
		private LazyAsyncResult m_WriteAResult;

		// Token: 0x040007EF RID: 2031
		private LazyAsyncResult m_ReadAResult;

		// Token: 0x040007F0 RID: 2032
		private int m_Aborted;
	}
}
