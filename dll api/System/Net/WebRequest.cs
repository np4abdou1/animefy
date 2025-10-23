using System;
using System.Collections;
using System.IO;
using System.Net.Cache;
using System.Net.Configuration;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	/// <summary>Makes a request to a Uniform Resource Identifier (URI). This is an <see langword="abstract" /> class.</summary>
	// Token: 0x02000167 RID: 359
	[Serializable]
	public abstract class WebRequest : MarshalByRefObject, ISerializable
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00034CDC File Offset: 0x00032EDC
		private static object InternalSyncObject
		{
			get
			{
				if (WebRequest.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange(ref WebRequest.s_InternalSyncObject, value, null);
				}
				return WebRequest.s_InternalSyncObject;
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00034D08 File Offset: 0x00032F08
		private static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			bool on = Logging.On;
			WebRequestPrefixElement webRequestPrefixElement = null;
			bool flag = false;
			string text;
			if (!useUriBase)
			{
				text = requestUri.AbsoluteUri;
			}
			else
			{
				text = requestUri.Scheme + ":";
			}
			int length = text.Length;
			ArrayList prefixList = WebRequest.PrefixList;
			for (int i = 0; i < prefixList.Count; i++)
			{
				webRequestPrefixElement = (WebRequestPrefixElement)prefixList[i];
				if (length >= webRequestPrefixElement.Prefix.Length && string.Compare(webRequestPrefixElement.Prefix, 0, text, 0, webRequestPrefixElement.Prefix.Length, StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				WebRequest result = webRequestPrefixElement.Creator.Create(requestUri);
				bool on2 = Logging.On;
				return result;
			}
			bool on3 = Logging.On;
			throw new NotSupportedException(SR.GetString("The URI prefix is not recognized."));
		}

		/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
		/// <param name="requestUriString">The URI that identifies the Internet resource. </param>
		/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specific URI scheme.</returns>
		/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUriString" /> has not been registered. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="requestUriString" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission to connect to the requested URI or a URI that the request is redirected to. </exception>
		/// <exception cref="T:System.UriFormatException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.The URI specified in <paramref name="requestUriString" /> is not a valid URI. </exception>
		// Token: 0x060009CA RID: 2506 RVA: 0x00034DC8 File Offset: 0x00032FC8
		public static WebRequest Create(string requestUriString)
		{
			if (requestUriString == null)
			{
				throw new ArgumentNullException("requestUriString");
			}
			return WebRequest.Create(new Uri(requestUriString), false);
		}

		/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
		/// <param name="requestUri">A <see cref="T:System.Uri" /> containing the URI of the requested resource. </param>
		/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specified URI scheme.</returns>
		/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUri" /> is not registered. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="requestUri" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission to connect to the requested URI or a URI that the request is redirected to. </exception>
		// Token: 0x060009CB RID: 2507 RVA: 0x00034DE4 File Offset: 0x00032FE4
		public static WebRequest Create(Uri requestUri)
		{
			if (requestUri == null)
			{
				throw new ArgumentNullException("requestUri");
			}
			return WebRequest.Create(requestUri, false);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00034E04 File Offset: 0x00033004
		internal static ArrayList PrefixList
		{
			get
			{
				if (WebRequest.s_PrefixList == null)
				{
					object internalSyncObject = WebRequest.InternalSyncObject;
					lock (internalSyncObject)
					{
						if (WebRequest.s_PrefixList == null)
						{
							WebRequest.s_PrefixList = WebRequest.PopulatePrefixList();
						}
					}
				}
				return WebRequest.s_PrefixList;
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00034E64 File Offset: 0x00033064
		private static ArrayList PopulatePrefixList()
		{
			ArrayList arrayList = new ArrayList();
			IWebRequestCreate c = new HttpRequestCreator();
			arrayList.Add(new WebRequestPrefixElement("http", c));
			arrayList.Add(new WebRequestPrefixElement("https", c));
			arrayList.Add(new WebRequestPrefixElement("file", new FileWebRequestCreator()));
			arrayList.Add(new WebRequestPrefixElement("ftp", new FtpWebRequestCreator()));
			return arrayList;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebRequest" /> class.</summary>
		// Token: 0x060009CE RID: 2510 RVA: 0x00034ECC File Offset: 0x000330CC
		protected WebRequest()
		{
			this.m_ImpersonationLevel = TokenImpersonationLevel.Delegation;
			this.m_AuthenticationLevel = AuthenticationLevel.MutualAuthRequested;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.WebRequest" /> instance. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that indicates the source of the serialized stream associated with the new <see cref="T:System.Net.WebRequest" /> instance. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the constructor, when the constructor is not overridden in a descendant class. </exception>
		// Token: 0x060009CF RID: 2511 RVA: 0x00034EE2 File Offset: 0x000330E2
		protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>When overridden in a descendant class, populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.WebRequest" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" />, which holds the serialized data for the <see cref="T:System.Net.WebRequest" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream associated with the new <see cref="T:System.Net.WebRequest" />. </param>
		/// <exception cref="T:System.NotImplementedException">An attempt is made to serialize the object, when the interface is not overridden in a descendant class. </exception>
		// Token: 0x060009D0 RID: 2512 RVA: 0x00034EEA File Offset: 0x000330EA
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x060009D1 RID: 2513 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>Gets or sets the cache policy for this request.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> object that defines a cache policy.</returns>
		// Token: 0x170001BE RID: 446
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00034EF4 File Offset: 0x000330F4
		public virtual RequestCachePolicy CachePolicy
		{
			set
			{
				this.InternalSetCachePolicy(value);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00034F00 File Offset: 0x00033100
		private void InternalSetCachePolicy(RequestCachePolicy policy)
		{
			if (this.m_CacheBinding != null && this.m_CacheBinding.Cache != null && this.m_CacheBinding.Validator != null && this.CacheProtocol == null && policy != null && policy.Level != RequestCacheLevel.BypassCache)
			{
				this.CacheProtocol = new RequestCacheProtocol(this.m_CacheBinding.Cache, this.m_CacheBinding.Validator.CreateValidator());
			}
			this.m_CachePolicy = policy;
		}

		/// <summary>When overridden in a descendant class, gets or sets the protocol method to use in this request.</summary>
		/// <returns>The protocol method to use in this request.</returns>
		/// <exception cref="T:System.NotImplementedException">If the property is not overridden in a descendant class, any attempt is made to get or set the property. </exception>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual string Method
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets the URI of the Internet resource associated with the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> representing the resource associated with the request </returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual Uri RequestUri
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the collection of header name/value pairs associated with the request.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> containing the header name/value pairs associated with this request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual WebHeaderCollection Headers
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the content length of the request data being sent.</summary>
		/// <returns>The number of bytes of request data being sent.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual long ContentLength
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the content type of the request data being sent.</summary>
		/// <returns>The content type of the request data.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual string ContentType
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the network credentials used for authenticating the request with the Internet resource.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> containing the authentication credentials associated with the request. The default is <see langword="null" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual ICredentials Credentials
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets a <see cref="T:System.Boolean" /> value that controls whether <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
		/// <returns>
		///     <see langword="true" /> if the default credentials are used; otherwise <see langword="false" />. The default value is <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property after the request was sent.</exception>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual bool UseDefaultCredentials
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the network proxy to use to access this Internet resource.</summary>
		/// <returns>The <see cref="T:System.Net.IWebProxy" /> to use to access the Internet resource.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual IWebProxy Proxy
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>Gets or sets the length of time, in milliseconds, before the request times out.</summary>
		/// <returns>The length of time, in milliseconds, until the request times out, or the value <see cref="F:System.Threading.Timeout.Infinite" /> to indicate that the request does not time out. The default value is defined by the descendant class.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual int Timeout
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>When overridden in a descendant class, returns a response to an Internet request.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response to the Internet request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009E3 RID: 2531 RVA: 0x00033402 File Offset: 0x00031602
		public virtual WebResponse GetResponse()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>When overridden in a descendant class, begins an asynchronous request for an Internet resource.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object containing state information for this asynchronous request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009E4 RID: 2532 RVA: 0x00033402 File Offset: 0x00031602
		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>When overridden in a descendant class, returns a <see cref="T:System.Net.WebResponse" />.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references a pending request for a response. </param>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains a response to the Internet request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009E5 RID: 2533 RVA: 0x00033402 File Offset: 0x00031602
		public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>When overridden in a descendant class, provides an asynchronous version of the <see cref="M:System.Net.WebRequest.GetRequestStream" /> method.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object containing state information for this asynchronous request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009E6 RID: 2534 RVA: 0x00033402 File Offset: 0x00031602
		public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>When overridden in a descendant class, returns a <see cref="T:System.IO.Stream" /> for writing data to the Internet resource.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references a pending request for a stream. </param>
		/// <returns>A <see cref="T:System.IO.Stream" /> to write data to.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009E7 RID: 2535 RVA: 0x00033402 File Offset: 0x00031602
		public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>When overridden in a descendant class, returns a <see cref="T:System.IO.Stream" /> for writing data to the Internet resource as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		// Token: 0x060009E8 RID: 2536 RVA: 0x00034F70 File Offset: 0x00033170
		public virtual Task<Stream> GetRequestStreamAsync()
		{
			IWebProxy webProxy = null;
			try
			{
				webProxy = this.Proxy;
			}
			catch (NotImplementedException)
			{
			}
			if (ExecutionContext.IsFlowSuppressed() && (this.UseDefaultCredentials || this.Credentials != null || (webProxy != null && webProxy.Credentials != null)))
			{
				WindowsIdentity currentUser = this.SafeCaptureIdenity();
				return Task.Run<Stream>(delegate()
				{
					Task<Stream> result;
					using (WindowsIdentity currentUser = currentUser)
					{
						using (currentUser.Impersonate())
						{
							result = Task<Stream>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetRequestStream), new Func<IAsyncResult, Stream>(this.EndGetRequestStream), null);
						}
					}
					return result;
				});
			}
			return Task.Run<Stream>(() => Task<Stream>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetRequestStream), new Func<IAsyncResult, Stream>(this.EndGetRequestStream), null));
		}

		/// <summary>When overridden in a descendant class, returns a response to an Internet request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		// Token: 0x060009E9 RID: 2537 RVA: 0x00034FF8 File Offset: 0x000331F8
		public virtual Task<WebResponse> GetResponseAsync()
		{
			IWebProxy webProxy = null;
			try
			{
				webProxy = this.Proxy;
			}
			catch (NotImplementedException)
			{
			}
			if (ExecutionContext.IsFlowSuppressed() && (this.UseDefaultCredentials || this.Credentials != null || (webProxy != null && webProxy.Credentials != null)))
			{
				WindowsIdentity currentUser = this.SafeCaptureIdenity();
				return Task.Run<WebResponse>(delegate()
				{
					Task<WebResponse> result;
					using (WindowsIdentity currentUser = currentUser)
					{
						using (currentUser.Impersonate())
						{
							result = Task<WebResponse>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetResponse), new Func<IAsyncResult, WebResponse>(this.EndGetResponse), null);
						}
					}
					return result;
				});
			}
			return Task.Run<WebResponse>(() => Task<WebResponse>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetResponse), new Func<IAsyncResult, WebResponse>(this.EndGetResponse), null));
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00035080 File Offset: 0x00033280
		[SecuritySafeCritical]
		private WindowsIdentity SafeCaptureIdenity()
		{
			return WindowsIdentity.GetCurrent();
		}

		/// <summary>Aborts the Request </summary>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060009EB RID: 2539 RVA: 0x00033402 File Offset: 0x00031602
		public virtual void Abort()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00035087 File Offset: 0x00033287
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0003508F File Offset: 0x0003328F
		internal RequestCacheProtocol CacheProtocol
		{
			get
			{
				return this.m_CacheProtocol;
			}
			set
			{
				this.m_CacheProtocol = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00035098 File Offset: 0x00033298
		internal static IWebProxy InternalDefaultWebProxy
		{
			get
			{
				if (!WebRequest.s_DefaultWebProxyInitialized)
				{
					object internalSyncObject = WebRequest.InternalSyncObject;
					lock (internalSyncObject)
					{
						if (!WebRequest.s_DefaultWebProxyInitialized)
						{
							DefaultProxySectionInternal section = DefaultProxySectionInternal.GetSection();
							if (section != null)
							{
								WebRequest.s_DefaultWebProxy = section.WebProxy;
							}
							WebRequest.s_DefaultWebProxyInitialized = true;
						}
					}
				}
				return WebRequest.s_DefaultWebProxy;
			}
		}

		// Token: 0x0400073D RID: 1853
		private static volatile ArrayList s_PrefixList;

		// Token: 0x0400073E RID: 1854
		private static object s_InternalSyncObject;

		// Token: 0x0400073F RID: 1855
		private static TimerThread.Queue s_DefaultTimerQueue = TimerThread.CreateQueue(100000);

		// Token: 0x04000740 RID: 1856
		private AuthenticationLevel m_AuthenticationLevel;

		// Token: 0x04000741 RID: 1857
		private TokenImpersonationLevel m_ImpersonationLevel;

		// Token: 0x04000742 RID: 1858
		private RequestCachePolicy m_CachePolicy;

		// Token: 0x04000743 RID: 1859
		private RequestCacheProtocol m_CacheProtocol;

		// Token: 0x04000744 RID: 1860
		private RequestCacheBinding m_CacheBinding;

		// Token: 0x04000745 RID: 1861
		private static WebRequest.DesignerWebRequestCreate webRequestCreate = new WebRequest.DesignerWebRequestCreate();

		// Token: 0x04000746 RID: 1862
		private static volatile IWebProxy s_DefaultWebProxy;

		// Token: 0x04000747 RID: 1863
		private static volatile bool s_DefaultWebProxyInitialized;

		// Token: 0x02000168 RID: 360
		internal class DesignerWebRequestCreate : IWebRequestCreate
		{
			// Token: 0x060009F2 RID: 2546 RVA: 0x00035171 File Offset: 0x00033371
			public WebRequest Create(Uri uri)
			{
				return WebRequest.Create(uri);
			}
		}
	}
}
