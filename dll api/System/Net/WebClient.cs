using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	/// <summary>Provides common methods for sending data to and receiving data from a resource identified by a URI.</summary>
	// Token: 0x0200012F RID: 303
	public class WebClient : Component
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebClient" /> class.</summary>
		// Token: 0x060008D1 RID: 2257 RVA: 0x000314BC File Offset: 0x0002F6BC
		public WebClient()
		{
			if (base.GetType() == typeof(WebClient))
			{
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Occurs when an asynchronous upload of a name/value collection completes.</summary>
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060008D2 RID: 2258 RVA: 0x000314F4 File Offset: 0x0002F6F4
		// (remove) Token: 0x060008D3 RID: 2259 RVA: 0x0003152C File Offset: 0x0002F72C
		public event UploadValuesCompletedEventHandler UploadValuesCompleted;

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadStringCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.DownloadStringCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060008D4 RID: 2260 RVA: 0x00031561 File Offset: 0x0002F761
		protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e)
		{
			DownloadStringCompletedEventHandler downloadStringCompleted = this.DownloadStringCompleted;
			if (downloadStringCompleted == null)
			{
				return;
			}
			downloadStringCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadDataCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.DownloadDataCompletedEventArgs" /> object that contains event data.</param>
		// Token: 0x060008D5 RID: 2261 RVA: 0x00031575 File Offset: 0x0002F775
		protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e)
		{
			DownloadDataCompletedEventHandler downloadDataCompleted = this.DownloadDataCompleted;
			if (downloadDataCompleted == null)
			{
				return;
			}
			downloadDataCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadFileCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060008D6 RID: 2262 RVA: 0x00031589 File Offset: 0x0002F789
		protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e)
		{
			AsyncCompletedEventHandler downloadFileCompleted = this.DownloadFileCompleted;
			if (downloadFileCompleted == null)
			{
				return;
			}
			downloadFileCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.DownloadProgressChangedEventArgs" /> object containing event data.</param>
		// Token: 0x060008D7 RID: 2263 RVA: 0x0003159D File Offset: 0x0002F79D
		protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e)
		{
			DownloadProgressChangedEventHandler downloadProgressChanged = this.DownloadProgressChanged;
			if (downloadProgressChanged == null)
			{
				return;
			}
			downloadProgressChanged(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadStringCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.Net.UploadStringCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060008D8 RID: 2264 RVA: 0x000315B1 File Offset: 0x0002F7B1
		protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e)
		{
			UploadStringCompletedEventHandler uploadStringCompleted = this.UploadStringCompleted;
			if (uploadStringCompleted == null)
			{
				return;
			}
			uploadStringCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadDataCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.UploadDataCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060008D9 RID: 2265 RVA: 0x000315C5 File Offset: 0x0002F7C5
		protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e)
		{
			UploadDataCompletedEventHandler uploadDataCompleted = this.UploadDataCompleted;
			if (uploadDataCompleted == null)
			{
				return;
			}
			uploadDataCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadFileCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.Net.UploadFileCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060008DA RID: 2266 RVA: 0x000315D9 File Offset: 0x0002F7D9
		protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e)
		{
			UploadFileCompletedEventHandler uploadFileCompleted = this.UploadFileCompleted;
			if (uploadFileCompleted == null)
			{
				return;
			}
			uploadFileCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadValuesCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.UploadValuesCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060008DB RID: 2267 RVA: 0x000315ED File Offset: 0x0002F7ED
		protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e)
		{
			UploadValuesCompletedEventHandler uploadValuesCompleted = this.UploadValuesCompleted;
			if (uploadValuesCompleted == null)
			{
				return;
			}
			uploadValuesCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadProgressChanged" /> event.</summary>
		/// <param name="e">An <see cref="T:System.Net.UploadProgressChangedEventArgs" /> object containing event data.</param>
		// Token: 0x060008DC RID: 2268 RVA: 0x00031601 File Offset: 0x0002F801
		protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e)
		{
			UploadProgressChangedEventHandler uploadProgressChanged = this.UploadProgressChanged;
			if (uploadProgressChanged == null)
			{
				return;
			}
			uploadProgressChanged(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.OpenReadCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.OpenReadCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060008DD RID: 2269 RVA: 0x00031615 File Offset: 0x0002F815
		protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e)
		{
			OpenReadCompletedEventHandler openReadCompleted = this.OpenReadCompleted;
			if (openReadCompleted == null)
			{
				return;
			}
			openReadCompleted(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.OpenWriteCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.OpenWriteCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060008DE RID: 2270 RVA: 0x00031629 File Offset: 0x0002F829
		protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e)
		{
			OpenWriteCompletedEventHandler openWriteCompleted = this.OpenWriteCompleted;
			if (openWriteCompleted == null)
			{
				return;
			}
			openWriteCompleted(this, e);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00031640 File Offset: 0x0002F840
		private void StartOperation()
		{
			if (Interlocked.Increment(ref this._callNesting) > 1)
			{
				this.EndOperation();
				throw new NotSupportedException("WebClient does not support concurrent I/O operations.");
			}
			this._contentLength = -1L;
			this._webResponse = null;
			this._webRequest = null;
			this._method = null;
			this._canceled = false;
			WebClient.ProgressData progress = this._progress;
			if (progress == null)
			{
				return;
			}
			progress.Reset();
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000316A0 File Offset: 0x0002F8A0
		private AsyncOperation StartAsyncOperation(object userToken)
		{
			if (!this._initWebClientAsync)
			{
				this._openReadOperationCompleted = delegate(object arg)
				{
					this.OnOpenReadCompleted((OpenReadCompletedEventArgs)arg);
				};
				this._openWriteOperationCompleted = delegate(object arg)
				{
					this.OnOpenWriteCompleted((OpenWriteCompletedEventArgs)arg);
				};
				this._downloadStringOperationCompleted = delegate(object arg)
				{
					this.OnDownloadStringCompleted((DownloadStringCompletedEventArgs)arg);
				};
				this._downloadDataOperationCompleted = delegate(object arg)
				{
					this.OnDownloadDataCompleted((DownloadDataCompletedEventArgs)arg);
				};
				this._downloadFileOperationCompleted = delegate(object arg)
				{
					this.OnDownloadFileCompleted((AsyncCompletedEventArgs)arg);
				};
				this._uploadStringOperationCompleted = delegate(object arg)
				{
					this.OnUploadStringCompleted((UploadStringCompletedEventArgs)arg);
				};
				this._uploadDataOperationCompleted = delegate(object arg)
				{
					this.OnUploadDataCompleted((UploadDataCompletedEventArgs)arg);
				};
				this._uploadFileOperationCompleted = delegate(object arg)
				{
					this.OnUploadFileCompleted((UploadFileCompletedEventArgs)arg);
				};
				this._uploadValuesOperationCompleted = delegate(object arg)
				{
					this.OnUploadValuesCompleted((UploadValuesCompletedEventArgs)arg);
				};
				this._reportDownloadProgressChanged = delegate(object arg)
				{
					this.OnDownloadProgressChanged((DownloadProgressChangedEventArgs)arg);
				};
				this._reportUploadProgressChanged = delegate(object arg)
				{
					this.OnUploadProgressChanged((UploadProgressChangedEventArgs)arg);
				};
				this._progress = new WebClient.ProgressData();
				this._initWebClientAsync = true;
			}
			AsyncOperation asyncOperation = AsyncOperationManager.CreateOperation(userToken);
			this.StartOperation();
			this._asyncOp = asyncOperation;
			return asyncOperation;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000317A5 File Offset: 0x0002F9A5
		private void EndOperation()
		{
			Interlocked.Decrement(ref this._callNesting);
		}

		/// <summary>Gets and sets the <see cref="T:System.Text.Encoding" /> used to upload and download strings.</summary>
		/// <returns>A <see cref="T:System.Text.Encoding" /> that is used to encode strings. The default value of this property is the encoding returned by <see cref="P:System.Text.Encoding.Default" />.</returns>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000317B3 File Offset: 0x0002F9B3
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		/// <summary>Gets or sets the network credentials that are sent to the host and used to authenticate the request.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> containing the authentication credentials for the request. The default is <see langword="null" />.</returns>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x000317BB File Offset: 0x0002F9BB
		public ICredentials Credentials
		{
			get
			{
				return this._credentials;
			}
		}

		/// <summary>Gets or sets a collection of header name/value pairs associated with the request.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> containing header name/value pairs associated with this request.</returns>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000317C4 File Offset: 0x0002F9C4
		public WebHeaderCollection Headers
		{
			get
			{
				WebHeaderCollection result;
				if ((result = this._headers) == null)
				{
					result = (this._headers = new WebHeaderCollection());
				}
				return result;
			}
		}

		/// <summary>Gets or sets the application's cache policy for any resources obtained by this WebClient instance using <see cref="T:System.Net.WebRequest" /> objects.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> object that represents the application's caching requirements.</returns>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000317E9 File Offset: 0x0002F9E9
		public RequestCachePolicy CachePolicy { get; }

		/// <summary>Returns a <see cref="T:System.Net.WebRequest" /> object for the specified resource.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> that identifies the resource to request.</param>
		/// <returns>A new <see cref="T:System.Net.WebRequest" /> object for the specified resource.</returns>
		// Token: 0x060008E6 RID: 2278 RVA: 0x000317F4 File Offset: 0x0002F9F4
		protected virtual WebRequest GetWebRequest(Uri address)
		{
			WebRequest webRequest = WebRequest.Create(address);
			this.CopyHeadersTo(webRequest);
			if (this.Credentials != null)
			{
				webRequest.Credentials = this.Credentials;
			}
			if (this._method != null)
			{
				webRequest.Method = this._method;
			}
			if (this._contentLength != -1L)
			{
				webRequest.ContentLength = this._contentLength;
			}
			if (this._proxySet)
			{
				webRequest.Proxy = this._proxy;
			}
			if (this.CachePolicy != null)
			{
				webRequest.CachePolicy = this.CachePolicy;
			}
			return webRequest;
		}

		/// <summary>Returns the <see cref="T:System.Net.WebResponse" /> for the specified <see cref="T:System.Net.WebRequest" />.</summary>
		/// <param name="request">A <see cref="T:System.Net.WebRequest" /> that is used to obtain the response. </param>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response for the specified <see cref="T:System.Net.WebRequest" />.</returns>
		// Token: 0x060008E7 RID: 2279 RVA: 0x00031878 File Offset: 0x0002FA78
		protected virtual WebResponse GetWebResponse(WebRequest request)
		{
			WebResponse response = request.GetResponse();
			this._webResponse = response;
			return response;
		}

		/// <summary>Returns the <see cref="T:System.Net.WebResponse" /> for the specified <see cref="T:System.Net.WebRequest" /> using the specified <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="request">A <see cref="T:System.Net.WebRequest" /> that is used to obtain the response.</param>
		/// <param name="result">An <see cref="T:System.IAsyncResult" /> object obtained from a previous call to <see cref="M:System.Net.WebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> .</param>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response for the specified <see cref="T:System.Net.WebRequest" />.</returns>
		// Token: 0x060008E8 RID: 2280 RVA: 0x00031894 File Offset: 0x0002FA94
		protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			WebResponse webResponse = request.EndGetResponse(result);
			this._webResponse = webResponse;
			return webResponse;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000318B4 File Offset: 0x0002FAB4
		private Task<WebResponse> GetWebResponseTaskAsync(WebRequest request)
		{
			WebClient.<GetWebResponseTaskAsync>d__112 <GetWebResponseTaskAsync>d__;
			<GetWebResponseTaskAsync>d__.<>t__builder = AsyncTaskMethodBuilder<WebResponse>.Create();
			<GetWebResponseTaskAsync>d__.<>4__this = this;
			<GetWebResponseTaskAsync>d__.request = request;
			<GetWebResponseTaskAsync>d__.<>1__state = -1;
			<GetWebResponseTaskAsync>d__.<>t__builder.Start<WebClient.<GetWebResponseTaskAsync>d__112>(ref <GetWebResponseTaskAsync>d__);
			return <GetWebResponseTaskAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00031900 File Offset: 0x0002FB00
		private byte[] DownloadDataInternal(Uri address, out WebRequest request)
		{
			request = null;
			byte[] result;
			try
			{
				request = (this._webRequest = this.GetWebRequest(this.GetUri(address)));
				result = this.DownloadBits(request, new ChunkedMemoryStream());
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				WebClient.AbortRequest(request);
				if (ex is WebException || ex is SecurityException)
				{
					throw;
				}
				throw new WebException("An exception occurred during a WebClient request.", ex);
			}
			return result;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00031990 File Offset: 0x0002FB90
		private byte[] GetValuesToUpload(NameValueCollection data)
		{
			WebHeaderCollection headers = this.Headers;
			string text = headers["Content-Type"];
			if (text != null && !string.Equals(text, "application/x-www-form-urlencoded", StringComparison.OrdinalIgnoreCase))
			{
				throw new WebException("The Content-Type header cannot be changed from its default value for this request.");
			}
			headers["Content-Type"] = "application/x-www-form-urlencoded";
			string value = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string text2 in data.AllKeys)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(WebClient.UrlEncode(text2));
				stringBuilder.Append('=');
				stringBuilder.Append(WebClient.UrlEncode(data[text2]));
				value = "&";
			}
			byte[] bytes = Encoding.ASCII.GetBytes(stringBuilder.ToString());
			this._contentLength = (long)bytes.Length;
			return bytes;
		}

		/// <summary>Downloads the requested resource as a <see cref="T:System.String" />. The resource to download is specified as a <see cref="T:System.String" /> containing the URI.</summary>
		/// <param name="address">A <see cref="T:System.String" /> containing the URI to download.</param>
		/// <returns>A <see cref="T:System.String" /> containing the requested resource.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		// Token: 0x060008EC RID: 2284 RVA: 0x00031A5D File Offset: 0x0002FC5D
		public string DownloadString(string address)
		{
			return this.DownloadString(this.GetUri(address));
		}

		/// <summary>Downloads the requested resource as a <see cref="T:System.String" />. The resource to download is specified as a <see cref="T:System.Uri" />.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> object containing the URI to download.</param>
		/// <returns>A <see cref="T:System.String" /> containing the requested resource.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		// Token: 0x060008ED RID: 2285 RVA: 0x00031A6C File Offset: 0x0002FC6C
		public string DownloadString(Uri address)
		{
			WebClient.ThrowIfNull(address, "address");
			this.StartOperation();
			string stringUsingEncoding;
			try
			{
				WebRequest request;
				byte[] data = this.DownloadDataInternal(address, out request);
				stringUsingEncoding = this.GetStringUsingEncoding(request, data);
			}
			finally
			{
				this.EndOperation();
			}
			return stringUsingEncoding;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		private static void AbortRequest(WebRequest request)
		{
			try
			{
				if (request != null)
				{
					request.Abort();
				}
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00031B00 File Offset: 0x0002FD00
		private void CopyHeadersTo(WebRequest request)
		{
			if (this._headers == null)
			{
				return;
			}
			HttpWebRequest httpWebRequest = request as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return;
			}
			string text = this._headers["Accept"];
			string text2 = this._headers["Connection"];
			string text3 = this._headers["Content-Type"];
			string text4 = this._headers["Expect"];
			string text5 = this._headers["Referer"];
			string text6 = this._headers["User-Agent"];
			string text7 = this._headers["Host"];
			this._headers.Remove("Accept");
			this._headers.Remove("Connection");
			this._headers.Remove("Content-Type");
			this._headers.Remove("Expect");
			this._headers.Remove("Referer");
			this._headers.Remove("User-Agent");
			this._headers.Remove("Host");
			request.Headers = this._headers;
			if (!string.IsNullOrEmpty(text))
			{
				httpWebRequest.Accept = text;
			}
			if (!string.IsNullOrEmpty(text2))
			{
				httpWebRequest.Connection = text2;
			}
			if (!string.IsNullOrEmpty(text3))
			{
				httpWebRequest.ContentType = text3;
			}
			if (!string.IsNullOrEmpty(text4))
			{
				httpWebRequest.Expect = text4;
			}
			if (!string.IsNullOrEmpty(text5))
			{
				httpWebRequest.Referer = text5;
			}
			if (!string.IsNullOrEmpty(text6))
			{
				httpWebRequest.UserAgent = text6;
			}
			if (!string.IsNullOrEmpty(text7))
			{
				httpWebRequest.Host = text7;
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00031C8C File Offset: 0x0002FE8C
		private Uri GetUri(string address)
		{
			WebClient.ThrowIfNull(address, "address");
			Uri address2;
			if (this._baseAddress != null)
			{
				if (!Uri.TryCreate(this._baseAddress, address, out address2))
				{
					return new Uri(Path.GetFullPath(address));
				}
			}
			else if (!Uri.TryCreate(address, UriKind.Absolute, out address2))
			{
				return new Uri(Path.GetFullPath(address));
			}
			return this.GetUri(address2);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00031CEC File Offset: 0x0002FEEC
		private Uri GetUri(Uri address)
		{
			WebClient.ThrowIfNull(address, "address");
			Uri uri = address;
			if (!address.IsAbsoluteUri && this._baseAddress != null && !Uri.TryCreate(this._baseAddress, address, out uri))
			{
				return address;
			}
			if (string.IsNullOrEmpty(uri.Query) && this._requestParameters != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				string value = string.Empty;
				for (int i = 0; i < this._requestParameters.Count; i++)
				{
					stringBuilder.Append(value).Append(this._requestParameters.AllKeys[i]).Append('=').Append(this._requestParameters[i]);
					value = "&";
				}
				uri = new UriBuilder(uri)
				{
					Query = stringBuilder.ToString()
				}.Uri;
			}
			return uri;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		private byte[] DownloadBits(WebRequest request, Stream writeStream)
		{
			byte[] result;
			try
			{
				WebResponse webResponse = this._webResponse = this.GetWebResponse(request);
				long contentLength = webResponse.ContentLength;
				byte[] array = new byte[(contentLength == -1L || contentLength > 65536L) ? 65536L : contentLength];
				if (writeStream is ChunkedMemoryStream)
				{
					if (contentLength > 2147483647L)
					{
						throw new WebException("The message length limit was exceeded", WebExceptionStatus.MessageLengthLimitExceeded);
					}
					writeStream.SetLength((long)array.Length);
				}
				using (Stream responseStream = webResponse.GetResponseStream())
				{
					if (responseStream != null)
					{
						int count;
						while ((count = responseStream.Read(array, 0, array.Length)) != 0)
						{
							writeStream.Write(array, 0, count);
						}
					}
				}
				ChunkedMemoryStream chunkedMemoryStream = writeStream as ChunkedMemoryStream;
				result = ((chunkedMemoryStream != null) ? chunkedMemoryStream.ToArray() : null);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				if (writeStream != null)
				{
					writeStream.Close();
				}
				WebClient.AbortRequest(request);
				if (ex is WebException || ex is SecurityException)
				{
					throw;
				}
				throw new WebException("An exception occurred during a WebClient request.", ex);
			}
			return result;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00031ED8 File Offset: 0x000300D8
		private void DownloadBitsAsync(WebRequest request, Stream writeStream, AsyncOperation asyncOp, Action<byte[], Exception, AsyncOperation> completionDelegate)
		{
			WebClient.<DownloadBitsAsync>d__150 <DownloadBitsAsync>d__;
			<DownloadBitsAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DownloadBitsAsync>d__.<>4__this = this;
			<DownloadBitsAsync>d__.request = request;
			<DownloadBitsAsync>d__.writeStream = writeStream;
			<DownloadBitsAsync>d__.asyncOp = asyncOp;
			<DownloadBitsAsync>d__.completionDelegate = completionDelegate;
			<DownloadBitsAsync>d__.<>1__state = -1;
			<DownloadBitsAsync>d__.<>t__builder.Start<WebClient.<DownloadBitsAsync>d__150>(ref <DownloadBitsAsync>d__);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00031F30 File Offset: 0x00030130
		private void UploadBitsAsync(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, AsyncOperation asyncOp, Action<byte[], Exception, AsyncOperation> completionDelegate)
		{
			WebClient.<UploadBitsAsync>d__152 <UploadBitsAsync>d__;
			<UploadBitsAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UploadBitsAsync>d__.<>4__this = this;
			<UploadBitsAsync>d__.request = request;
			<UploadBitsAsync>d__.readStream = readStream;
			<UploadBitsAsync>d__.buffer = buffer;
			<UploadBitsAsync>d__.chunkSize = chunkSize;
			<UploadBitsAsync>d__.header = header;
			<UploadBitsAsync>d__.footer = footer;
			<UploadBitsAsync>d__.asyncOp = asyncOp;
			<UploadBitsAsync>d__.completionDelegate = completionDelegate;
			<UploadBitsAsync>d__.<>1__state = -1;
			<UploadBitsAsync>d__.<>t__builder.Start<WebClient.<UploadBitsAsync>d__152>(ref <UploadBitsAsync>d__);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00031FAC File Offset: 0x000301AC
		private static bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray)
		{
			if (prefix == null || byteArray == null || prefix.Length > byteArray.Length)
			{
				return false;
			}
			for (int i = 0; i < prefix.Length; i++)
			{
				if (prefix[i] != byteArray[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00031FE4 File Offset: 0x000301E4
		private string GetStringUsingEncoding(WebRequest request, byte[] data)
		{
			Encoding encoding = null;
			int num = -1;
			string text;
			try
			{
				text = request.ContentType;
			}
			catch (Exception ex) when (ex is NotImplementedException || ex is NotSupportedException)
			{
				text = null;
			}
			if (text != null)
			{
				text = text.ToLower(CultureInfo.InvariantCulture);
				string[] array = text.Split(WebClient.s_parseContentTypeSeparators);
				bool flag = false;
				foreach (string text2 in array)
				{
					if (text2 == "charset")
					{
						flag = true;
					}
					else if (flag)
					{
						try
						{
							encoding = Encoding.GetEncoding(text2);
						}
						catch (ArgumentException)
						{
							break;
						}
					}
				}
			}
			if (encoding == null)
			{
				Encoding[] array3 = WebClient.s_knownEncodings;
				for (int j = 0; j < array3.Length; j++)
				{
					byte[] preamble = array3[j].GetPreamble();
					if (WebClient.ByteArrayHasPrefix(preamble, data))
					{
						encoding = array3[j];
						num = preamble.Length;
						break;
					}
				}
			}
			if (encoding == null)
			{
				encoding = this.Encoding;
			}
			if (num == -1)
			{
				byte[] preamble2 = encoding.GetPreamble();
				num = (WebClient.ByteArrayHasPrefix(preamble2, data) ? preamble2.Length : 0);
			}
			return encoding.GetString(data, num, data.Length - num);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00032118 File Offset: 0x00030318
		private string MapToDefaultMethod(Uri address)
		{
			if (!string.Equals(((!address.IsAbsoluteUri && this._baseAddress != null) ? new Uri(this._baseAddress, address) : address).Scheme, Uri.UriSchemeFtp, StringComparison.Ordinal))
			{
				return "POST";
			}
			return "STOR";
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00032168 File Offset: 0x00030368
		private static string UrlEncode(string str)
		{
			if (str == null)
			{
				return null;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			return Encoding.ASCII.GetString(WebClient.UrlEncodeBytesToBytesInternal(bytes, 0, bytes.Length, false));
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0003219C File Offset: 0x0003039C
		private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				char c = (char)bytes[offset + i];
				if (c == ' ')
				{
					num++;
				}
				else if (!WebClient.IsSafe(c))
				{
					num2++;
				}
			}
			if (!alwaysCreateReturnValue && num == 0 && num2 == 0)
			{
				return bytes;
			}
			byte[] array = new byte[count + num2 * 2];
			int num3 = 0;
			for (int j = 0; j < count; j++)
			{
				byte b = bytes[offset + j];
				char c2 = (char)b;
				if (WebClient.IsSafe(c2))
				{
					array[num3++] = b;
				}
				else if (c2 == ' ')
				{
					array[num3++] = 43;
				}
				else
				{
					array[num3++] = 37;
					array[num3++] = (byte)WebClient.IntToHex(b >> 4 & 15);
					array[num3++] = (byte)WebClient.IntToHex((int)(b & 15));
				}
			}
			return array;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00032267 File Offset: 0x00030467
		private static char IntToHex(int n)
		{
			if (n <= 9)
			{
				return (char)(n + 48);
			}
			return (char)(n - 10 + 97);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0003227C File Offset: 0x0003047C
		private static bool IsSafe(char ch)
		{
			if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
			{
				return true;
			}
			if (ch != '!')
			{
				switch (ch)
				{
				case '\'':
				case '(':
				case ')':
				case '*':
				case '-':
				case '.':
					return true;
				case '+':
				case ',':
					break;
				default:
					if (ch == '_')
					{
						return true;
					}
					break;
				}
				return false;
			}
			return true;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000322DF File Offset: 0x000304DF
		private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs)
		{
			if (Interlocked.CompareExchange<AsyncOperation>(ref this._asyncOp, null, asyncOp) == asyncOp)
			{
				this.EndOperation();
				asyncOp.PostOperationCompleted(callback, eventArgs);
			}
		}

		/// <summary>Uploads the data in the specified name/value collection to the resource identified by the specified URI. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the collection. This URI must identify a resource that can accept a request sent with the default method. See remarks.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is <see langword="null" />.-or-The <paramref name="data" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		// Token: 0x060008FD RID: 2301 RVA: 0x000322FF File Offset: 0x000304FF
		public void UploadValuesAsync(Uri address, NameValueCollection data)
		{
			this.UploadValuesAsync(address, null, data, null);
		}

		/// <summary>Uploads the data in the specified name/value collection to the resource identified by the specified URI, using the specified method. This method does not block the calling thread, and allows the caller to pass an object to the method that is invoked when the operation completes.</summary>
		/// <param name="address">The URI of the resource to receive the collection. This URI must identify a resource that can accept a request sent with the <paramref name="method" /> method.</param>
		/// <param name="method">The HTTP method used to send the string to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is <see langword="null" />.-or-The <paramref name="data" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.-or-
		///         <paramref name="method" /> cannot be used to send content.</exception>
		// Token: 0x060008FE RID: 2302 RVA: 0x0003230C File Offset: 0x0003050C
		public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken)
		{
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(data, "data");
			if (method == null)
			{
				method = this.MapToDefaultMethod(address);
			}
			AsyncOperation asyncOp = this.StartAsyncOperation(userToken);
			try
			{
				byte[] valuesToUpload = this.GetValuesToUpload(data);
				this._method = method;
				WebRequest request = this._webRequest = this.GetWebRequest(this.GetUri(address));
				int chunkSize = 0;
				if (this.UploadProgressChanged != null)
				{
					chunkSize = (int)Math.Min(8192L, (long)valuesToUpload.Length);
				}
				this.UploadBitsAsync(request, null, valuesToUpload, chunkSize, null, null, asyncOp, delegate(byte[] result, Exception error, AsyncOperation uploadAsyncOp)
				{
					this.InvokeOperationCompleted(asyncOp, this._uploadValuesOperationCompleted, new UploadValuesCompletedEventArgs(result, error, this._canceled, uploadAsyncOp.UserSuppliedState));
				});
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				UploadValuesCompletedEventArgs eventArgs = new UploadValuesCompletedEventArgs(null, WebClient.GetExceptionToPropagate(ex), this._canceled, asyncOp.UserSuppliedState);
				this.InvokeOperationCompleted(asyncOp, this._uploadValuesOperationCompleted, eventArgs);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00032420 File Offset: 0x00030620
		private static Exception GetExceptionToPropagate(Exception e)
		{
			if (!(e is WebException) && !(e is SecurityException))
			{
				return new WebException("An exception occurred during a WebClient request.", e);
			}
			return e;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00032440 File Offset: 0x00030640
		private void PostProgressChanged(AsyncOperation asyncOp, WebClient.ProgressData progress)
		{
			if (asyncOp != null && (progress.BytesSent > 0L || progress.BytesReceived > 0L))
			{
				if (progress.HasUploadPhase)
				{
					if (this.UploadProgressChanged != null)
					{
						int progressPercentage = (progress.TotalBytesToReceive < 0L && progress.BytesReceived == 0L) ? ((progress.TotalBytesToSend < 0L) ? 0 : ((progress.TotalBytesToSend == 0L) ? 50 : ((int)(50L * progress.BytesSent / progress.TotalBytesToSend)))) : ((progress.TotalBytesToSend < 0L) ? 50 : ((progress.TotalBytesToReceive == 0L) ? 100 : ((int)(50L * progress.BytesReceived / progress.TotalBytesToReceive + 50L))));
						asyncOp.Post(this._reportUploadProgressChanged, new UploadProgressChangedEventArgs(progressPercentage, asyncOp.UserSuppliedState, progress.BytesSent, progress.TotalBytesToSend, progress.BytesReceived, progress.TotalBytesToReceive));
						return;
					}
				}
				else if (this.DownloadProgressChanged != null)
				{
					int progressPercentage = (progress.TotalBytesToReceive < 0L) ? 0 : ((progress.TotalBytesToReceive == 0L) ? 100 : ((int)(100L * progress.BytesReceived / progress.TotalBytesToReceive)));
					asyncOp.Post(this._reportDownloadProgressChanged, new DownloadProgressChangedEventArgs(progressPercentage, asyncOp.UserSuppliedState, progress.BytesReceived, progress.TotalBytesToReceive));
				}
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00032579 File Offset: 0x00030779
		private static void ThrowIfNull(object argument, string parameterName)
		{
			if (argument == null)
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		// Token: 0x04000628 RID: 1576
		private Uri _baseAddress;

		// Token: 0x04000629 RID: 1577
		private ICredentials _credentials;

		// Token: 0x0400062A RID: 1578
		private WebHeaderCollection _headers;

		// Token: 0x0400062B RID: 1579
		private NameValueCollection _requestParameters;

		// Token: 0x0400062C RID: 1580
		private WebResponse _webResponse;

		// Token: 0x0400062D RID: 1581
		private WebRequest _webRequest;

		// Token: 0x0400062E RID: 1582
		private Encoding _encoding = Encoding.Default;

		// Token: 0x0400062F RID: 1583
		private string _method;

		// Token: 0x04000630 RID: 1584
		private long _contentLength = -1L;

		// Token: 0x04000631 RID: 1585
		private bool _initWebClientAsync;

		// Token: 0x04000632 RID: 1586
		private bool _canceled;

		// Token: 0x04000633 RID: 1587
		private WebClient.ProgressData _progress;

		// Token: 0x04000634 RID: 1588
		private IWebProxy _proxy;

		// Token: 0x04000635 RID: 1589
		private bool _proxySet;

		// Token: 0x04000636 RID: 1590
		private int _callNesting;

		// Token: 0x04000637 RID: 1591
		private AsyncOperation _asyncOp;

		// Token: 0x04000638 RID: 1592
		private SendOrPostCallback _downloadDataOperationCompleted;

		// Token: 0x04000639 RID: 1593
		private SendOrPostCallback _openReadOperationCompleted;

		// Token: 0x0400063A RID: 1594
		private SendOrPostCallback _openWriteOperationCompleted;

		// Token: 0x0400063B RID: 1595
		private SendOrPostCallback _downloadStringOperationCompleted;

		// Token: 0x0400063C RID: 1596
		private SendOrPostCallback _downloadFileOperationCompleted;

		// Token: 0x0400063D RID: 1597
		private SendOrPostCallback _uploadStringOperationCompleted;

		// Token: 0x0400063E RID: 1598
		private SendOrPostCallback _uploadDataOperationCompleted;

		// Token: 0x0400063F RID: 1599
		private SendOrPostCallback _uploadFileOperationCompleted;

		// Token: 0x04000640 RID: 1600
		private SendOrPostCallback _uploadValuesOperationCompleted;

		// Token: 0x04000641 RID: 1601
		private SendOrPostCallback _reportDownloadProgressChanged;

		// Token: 0x04000642 RID: 1602
		private SendOrPostCallback _reportUploadProgressChanged;

		// Token: 0x04000643 RID: 1603
		[CompilerGenerated]
		private DownloadStringCompletedEventHandler DownloadStringCompleted;

		// Token: 0x04000644 RID: 1604
		[CompilerGenerated]
		private DownloadDataCompletedEventHandler DownloadDataCompleted;

		// Token: 0x04000645 RID: 1605
		[CompilerGenerated]
		private AsyncCompletedEventHandler DownloadFileCompleted;

		// Token: 0x04000646 RID: 1606
		[CompilerGenerated]
		private UploadStringCompletedEventHandler UploadStringCompleted;

		// Token: 0x04000647 RID: 1607
		[CompilerGenerated]
		private UploadDataCompletedEventHandler UploadDataCompleted;

		// Token: 0x04000648 RID: 1608
		[CompilerGenerated]
		private UploadFileCompletedEventHandler UploadFileCompleted;

		// Token: 0x0400064A RID: 1610
		[CompilerGenerated]
		private OpenReadCompletedEventHandler OpenReadCompleted;

		// Token: 0x0400064B RID: 1611
		[CompilerGenerated]
		private OpenWriteCompletedEventHandler OpenWriteCompleted;

		// Token: 0x0400064C RID: 1612
		[CompilerGenerated]
		private DownloadProgressChangedEventHandler DownloadProgressChanged;

		// Token: 0x0400064D RID: 1613
		[CompilerGenerated]
		private UploadProgressChangedEventHandler UploadProgressChanged;

		// Token: 0x0400064F RID: 1615
		private static readonly char[] s_parseContentTypeSeparators = new char[]
		{
			';',
			'=',
			' '
		};

		// Token: 0x04000650 RID: 1616
		private static readonly Encoding[] s_knownEncodings = new Encoding[]
		{
			Encoding.UTF8,
			Encoding.UTF32,
			Encoding.Unicode,
			Encoding.BigEndianUnicode
		};

		// Token: 0x02000130 RID: 304
		private sealed class ProgressData
		{
			// Token: 0x0600090E RID: 2318 RVA: 0x00032670 File Offset: 0x00030870
			internal void Reset()
			{
				this.BytesSent = 0L;
				this.TotalBytesToSend = -1L;
				this.BytesReceived = 0L;
				this.TotalBytesToReceive = -1L;
				this.HasUploadPhase = false;
			}

			// Token: 0x04000651 RID: 1617
			internal long BytesSent;

			// Token: 0x04000652 RID: 1618
			internal long TotalBytesToSend = -1L;

			// Token: 0x04000653 RID: 1619
			internal long BytesReceived;

			// Token: 0x04000654 RID: 1620
			internal long TotalBytesToReceive = -1L;

			// Token: 0x04000655 RID: 1621
			internal bool HasUploadPhase;
		}
	}
}
