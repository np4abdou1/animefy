using System;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	/// <summary>Provides an HTTP-specific implementation of the <see cref="T:System.Net.WebRequest" /> class.</summary>
	// Token: 0x020001AC RID: 428
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06000B71 RID: 2929 RVA: 0x0003BE84 File Offset: 0x0003A084
		public HttpWebRequest(Uri uri)
		{
			this.requestUri = uri;
			this.actualUri = uri;
			this.proxy = WebRequest.InternalDefaultWebProxy;
			this.webHeaders = new WebHeaderCollection(WebHeaderCollectionType.HttpWebRequest);
			this.ThrowOnError = true;
			this.ResetAuthorization();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Net.HttpWebRequest" /> object. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Net.HttpWebRequest" /> object. </param>
		// Token: 0x06000B72 RID: 2930 RVA: 0x0003BF50 File Offset: 0x0003A150
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new SerializationException();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0003BFEC File Offset: 0x0003A1EC
		private void ResetAuthorization()
		{
			this.auth_state = new HttpWebRequest.AuthorizationState(this, false);
			this.proxy_auth_state = new HttpWebRequest.AuthorizationState(this, true);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0003C008 File Offset: 0x0003A208
		private void SetSpecialHeaders(string HeaderName, string value)
		{
			value = WebHeaderCollection.CheckBadChars(value, true);
			this.webHeaders.RemoveInternal(HeaderName);
			if (value.Length != 0)
			{
				this.webHeaders.AddInternal(HeaderName, value);
			}
		}

		/// <summary>Gets or sets the value of the <see langword="Accept" /> HTTP header.</summary>
		/// <returns>The value of the <see langword="Accept" /> HTTP header. The default value is <see langword="null" />.</returns>
		// Token: 0x1700022C RID: 556
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x0003C034 File Offset: 0x0003A234
		public string Accept
		{
			set
			{
				this.CheckRequestStarted();
				this.SetSpecialHeaders("Accept", value);
			}
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of the Internet resource that actually responds to the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that identifies the Internet resource that actually responds to the request. The default is the URI used by the <see cref="M:System.Net.WebRequest.Create(System.String)" /> method to initialize the request.</returns>
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0003C048 File Offset: 0x0003A248
		public Uri Address
		{
			get
			{
				return this.actualUri;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to buffer the data sent to the Internet resource.</summary>
		/// <returns>
		///     <see langword="true" /> to enable buffering of the data sent to the Internet resource; <see langword="false" /> to disable buffering. The default is <see langword="true" />.</returns>
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0003C050 File Offset: 0x0003A250
		public virtual bool AllowWriteStreamBuffering
		{
			get
			{
				return this.allowBuffering;
			}
		}

		/// <summary>Gets or sets the type of decompression that is used.</summary>
		/// <returns>A T:System.Net.DecompressionMethods object that indicates the type of decompression that is used. </returns>
		/// <exception cref="T:System.InvalidOperationException">The object's current state does not allow this property to be set.</exception>
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0003C058 File Offset: 0x0003A258
		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this.auto_decomp;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0003C060 File Offset: 0x0003A260
		internal bool InternalAllowBuffering
		{
			get
			{
				return this.allowBuffering && this.MethodWithBuffer;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0003C074 File Offset: 0x0003A274
		private bool MethodWithBuffer
		{
			get
			{
				return this.method != "HEAD" && this.method != "GET" && this.method != "MKCOL" && this.method != "CONNECT" && this.method != "TRACE";
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0003C0DB File Offset: 0x0003A2DB
		internal MobileTlsProvider TlsProvider
		{
			get
			{
				return this.tlsProvider;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0003C0E3 File Offset: 0x0003A2E3
		internal MonoTlsSettings TlsSettings
		{
			get
			{
				return this.tlsSettings;
			}
		}

		/// <summary>Gets or sets the collection of security certificates that are associated with this request.</summary>
		/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains the security certificates associated with this request.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is <see langword="null" />. </exception>
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0003C0EB File Offset: 0x0003A2EB
		public X509CertificateCollection ClientCertificates
		{
			get
			{
				if (this.certificates == null)
				{
					this.certificates = new X509CertificateCollection();
				}
				return this.certificates;
			}
		}

		/// <summary>Gets or sets the value of the <see langword="Connection" /> HTTP header.</summary>
		/// <returns>The value of the <see langword="Connection" /> HTTP header. The default value is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">The value of <see cref="P:System.Net.HttpWebRequest.Connection" /> is set to Keep-alive or Close. </exception>
		// Token: 0x17000235 RID: 565
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0003C108 File Offset: 0x0003A308
		public string Connection
		{
			set
			{
				this.CheckRequestStarted();
				if (string.IsNullOrWhiteSpace(value))
				{
					this.webHeaders.RemoveInternal("Connection");
					return;
				}
				string text = value.ToLowerInvariant();
				if (text.Contains("keep-alive") || text.Contains("close"))
				{
					throw new ArgumentException("Keep-Alive and Close may not be set using this property.", "value");
				}
				string value2 = HttpValidationHelpers.CheckBadHeaderValueChars(value);
				this.webHeaders.CheckUpdate("Connection", value2);
			}
		}

		/// <summary>Gets or sets the <see langword="Content-length" /> HTTP header.</summary>
		/// <returns>The number of bytes of data to send to the Internet resource. The default is -1, which indicates the property has not been set and that there is no request data to send.</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The new <see cref="P:System.Net.HttpWebRequest.ContentLength" /> value is less than 0. </exception>
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003C17D File Offset: 0x0003A37D
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0003C185 File Offset: 0x0003A385
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", "Content-Length must be >= 0");
				}
				this.contentLength = value;
				this.haveContentLength = true;
			}
		}

		// Token: 0x17000237 RID: 567
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
		internal long InternalContentLength
		{
			set
			{
				this.contentLength = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0003C1B9 File Offset: 0x0003A3B9
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0003C1C1 File Offset: 0x0003A3C1
		internal bool ThrowOnError { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Content-type" /> HTTP header.</summary>
		/// <returns>The value of the <see langword="Content-type" /> HTTP header. The default value is <see langword="null" />.</returns>
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0003C1CA File Offset: 0x0003A3CA
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		public override string ContentType
		{
			get
			{
				return this.webHeaders["Content-Type"];
			}
			set
			{
				this.SetSpecialHeaders("Content-Type", value);
			}
		}

		/// <summary>Gets or sets authentication information for the request.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that contains the authentication credentials associated with the request. The default is <see langword="null" />.</returns>
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0003C1EA File Offset: 0x0003A3EA
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0003C1F2 File Offset: 0x0003A3F2
		public override ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.credentials = value;
			}
		}

		/// <summary>Gets or sets the default maximum length of an HTTP error response.</summary>
		/// <returns>The default maximum length of an HTTP error response.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value is less than 0 and is not equal to -1. </exception>
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0003C1FB File Offset: 0x0003A3FB
		public static int DefaultMaximumErrorResponseLength
		{
			get
			{
				return HttpWebRequest.defaultMaximumErrorResponseLength;
			}
		}

		/// <summary>Gets or sets the value of the <see langword="Expect" /> HTTP header.</summary>
		/// <returns>The contents of the <see langword="Expect" /> HTTP header. The default value is <see langword="null" />.The value for this property is stored in <see cref="T:System.Net.WebHeaderCollection" />. If WebHeaderCollection is set, the property value is lost.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <see langword="Expect" /> is set to a string that contains "100-continue" as a substring. </exception>
		// Token: 0x1700023C RID: 572
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0003C204 File Offset: 0x0003A404
		public string Expect
		{
			set
			{
				this.CheckRequestStarted();
				string text = value;
				if (text != null)
				{
					text = text.Trim().ToLower();
				}
				if (text == null || text.Length == 0)
				{
					this.webHeaders.RemoveInternal("Expect");
					return;
				}
				if (text == "100-continue")
				{
					throw new ArgumentException("100-Continue cannot be set with this property.", "value");
				}
				this.webHeaders.CheckUpdate("Expect", value);
			}
		}

		/// <summary>Specifies a collection of the name/value pairs that make up the HTTP headers.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the name/value pairs that make up the headers for the HTTP request.</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method. </exception>
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0003C272 File Offset: 0x0003A472
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0003C27C File Offset: 0x0003A47C
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
			set
			{
				this.CheckRequestStarted();
				WebHeaderCollection webHeaderCollection = new WebHeaderCollection(WebHeaderCollectionType.HttpWebRequest);
				foreach (string name in value.AllKeys)
				{
					webHeaderCollection.Add(name, value[name]);
				}
				this.webHeaders = webHeaderCollection;
			}
		}

		/// <summary>Get or set the Host header value to use in an HTTP request independent from the request URI.</summary>
		/// <returns>The Host header value in the HTTP request.</returns>
		/// <exception cref="T:System.ArgumentNullException">The Host header cannot be set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The Host header cannot be set to an invalid value. </exception>
		/// <exception cref="T:System.InvalidOperationException">The Host header cannot be set after the <see cref="T:System.Net.HttpWebRequest" /> has already started to be sent. </exception>
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003C2CC File Offset: 0x0003A4CC
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0003C334 File Offset: 0x0003A534
		public string Host
		{
			get
			{
				Uri uri = this.hostUri ?? this.Address;
				if ((!(this.hostUri == null) && this.hostHasPort) || !this.Address.IsDefaultPort)
				{
					return uri.Host + ":" + uri.Port.ToString();
				}
				return uri.Host;
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				Uri uri;
				if (value.IndexOf('/') != -1 || !this.TryGetHostUri(value, out uri))
				{
					throw new ArgumentException("The specified value is not a valid Host header string.", "value");
				}
				this.hostUri = uri;
				if (!this.hostUri.IsDefaultPort)
				{
					this.hostHasPort = true;
					return;
				}
				if (value.IndexOf(':') == -1)
				{
					this.hostHasPort = false;
					return;
				}
				int num = value.IndexOf(']');
				this.hostHasPort = (num == -1 || value.LastIndexOf(':') > num);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0003C3CB File Offset: 0x0003A5CB
		private bool TryGetHostUri(string hostName, out Uri hostUri)
		{
			return Uri.TryCreate(this.Address.Scheme + "://" + hostName + this.Address.PathAndQuery, UriKind.Absolute, out hostUri);
		}

		/// <summary>Gets or sets a value that indicates whether to make a persistent connection to the Internet resource.</summary>
		/// <returns>
		///     <see langword="true" /> if the request to the Internet resource should contain a <see langword="Connection" /> HTTP header with the value Keep-alive; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003C3F5 File Offset: 0x0003A5F5
		public bool KeepAlive
		{
			get
			{
				return this.keepAlive;
			}
		}

		/// <summary>Gets or sets a time-out in milliseconds when writing to or reading from a stream.</summary>
		/// <returns>The number of milliseconds before the writing or reading times out. The default value is 300,000 milliseconds (5 minutes).</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has already been sent. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than or equal to zero and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /></exception>
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0003C3FD File Offset: 0x0003A5FD
		public int ReadWriteTimeout
		{
			get
			{
				return this.readWriteTimeout;
			}
		}

		/// <summary>Gets or sets the method for the request.</summary>
		/// <returns>The request method to use to contact the Internet resource. The default value is GET.</returns>
		/// <exception cref="T:System.ArgumentException">No method is supplied.-or- The method string contains invalid characters. </exception>
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003C405 File Offset: 0x0003A605
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0003C410 File Offset: 0x0003A610
		public override string Method
		{
			get
			{
				return this.method;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Cannot set null or blank methods on request.", "value");
				}
				if (HttpValidationHelpers.IsInvalidMethodOrHeaderString(value))
				{
					throw new ArgumentException("Cannot set null or blank methods on request.", "value");
				}
				this.method = value.ToUpperInvariant();
				if (this.method != "HEAD" && this.method != "GET" && this.method != "POST" && this.method != "PUT" && this.method != "DELETE" && this.method != "CONNECT" && this.method != "TRACE" && this.method != "MKCOL")
				{
					this.method = value;
				}
			}
		}

		/// <summary>Gets or sets the version of HTTP to use for the request.</summary>
		/// <returns>The HTTP version to use for the request. The default is <see cref="F:System.Net.HttpVersion.Version11" />.</returns>
		/// <exception cref="T:System.ArgumentException">The HTTP version is set to a value other than 1.0 or 1.1. </exception>
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003C4F3 File Offset: 0x0003A6F3
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
		}

		/// <summary>Gets or sets proxy information for the request.</summary>
		/// <returns>The <see cref="T:System.Net.IWebProxy" /> object to use to proxy the request. The default value is set by calling the <see cref="P:System.Net.GlobalProxySelection.Select" /> property.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <see cref="P:System.Net.HttpWebRequest.Proxy" /> is set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission for the requested operation. </exception>
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0003C4FB File Offset: 0x0003A6FB
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0003C503 File Offset: 0x0003A703
		public override IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			set
			{
				this.CheckRequestStarted();
				this.proxy = value;
				this.servicePoint = null;
				this.GetServicePoint();
			}
		}

		/// <summary>Gets or sets the value of the <see langword="Referer" /> HTTP header.</summary>
		/// <returns>The value of the <see langword="Referer" /> HTTP header. The default value is <see langword="null" />.</returns>
		// Token: 0x17000244 RID: 580
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0003C520 File Offset: 0x0003A720
		public string Referer
		{
			set
			{
				this.CheckRequestStarted();
				if (value == null || value.Trim().Length == 0)
				{
					this.webHeaders.RemoveInternal("Referer");
					return;
				}
				this.webHeaders.SetInternal("Referer", value);
			}
		}

		/// <summary>Gets the original Uniform Resource Identifier (URI) of the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the Internet resource passed to the <see cref="M:System.Net.WebRequest.Create(System.String)" /> method.</returns>
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0003C55A File Offset: 0x0003A75A
		public override Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to send data in segments to the Internet resource.</summary>
		/// <returns>
		///     <see langword="true" /> to send data to the Internet resource in segments; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method. </exception>
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0003C562 File Offset: 0x0003A762
		public bool SendChunked
		{
			get
			{
				return this.sendChunked;
			}
		}

		/// <summary>Gets the service point to use for the request.</summary>
		/// <returns>A <see cref="T:System.Net.ServicePoint" /> that represents the network connection to the Internet resource.</returns>
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0003C56A File Offset: 0x0003A76A
		public ServicePoint ServicePoint
		{
			get
			{
				return this.GetServicePoint();
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0003C572 File Offset: 0x0003A772
		internal ServicePoint ServicePointNoLock
		{
			get
			{
				return this.servicePoint;
			}
		}

		/// <summary>Gets or sets the time-out value in milliseconds for the <see cref="M:System.Net.HttpWebRequest.GetResponse" /> and <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> methods.</summary>
		/// <returns>The number of milliseconds to wait before the request times out. The default value is 100,000 milliseconds (100 seconds).</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0003C57A File Offset: 0x0003A77A
		public override int Timeout
		{
			get
			{
				return this.timeout;
			}
		}

		/// <summary>Gets or sets the value of the <see langword="Transfer-encoding" /> HTTP header.</summary>
		/// <returns>The value of the <see langword="Transfer-encoding" /> HTTP header. The default value is <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set when <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to the value "Chunked". </exception>
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0003C582 File Offset: 0x0003A782
		public string TransferEncoding
		{
			get
			{
				return this.webHeaders["Transfer-Encoding"];
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether default credentials are sent with requests.</summary>
		/// <returns>
		///     <see langword="true" /> if the default credentials are used; otherwise <see langword="false" />. The default value is <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property after the request was sent.</exception>
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0003C594 File Offset: 0x0003A794
		public override bool UseDefaultCredentials
		{
			get
			{
				return CredentialCache.DefaultCredentials == this.Credentials;
			}
		}

		/// <summary>Gets or sets the value of the <see langword="User-agent" /> HTTP header.</summary>
		/// <returns>The value of the <see langword="User-agent" /> HTTP header. The default value is <see langword="null" />.The value for this property is stored in <see cref="T:System.Net.WebHeaderCollection" />. If WebHeaderCollection is set, the property value is lost.</returns>
		// Token: 0x1700024C RID: 588
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x0003C5A3 File Offset: 0x0003A7A3
		public string UserAgent
		{
			set
			{
				this.webHeaders.SetInternal("User-Agent", value);
			}
		}

		/// <summary>Gets or sets a value that indicates whether to allow high-speed NTLM-authenticated connection sharing.</summary>
		/// <returns>
		///     <see langword="true" /> to keep the authenticated connection open; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0003C5B6 File Offset: 0x0003A7B6
		public bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_auth_blah;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0003C5BE File Offset: 0x0003A7BE
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0003C5C6 File Offset: 0x0003A7C6
		internal bool ExpectContinue
		{
			get
			{
				return this.expectContinue;
			}
			set
			{
				this.expectContinue = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003C048 File Offset: 0x0003A248
		internal Uri AuthUri
		{
			get
			{
				return this.actualUri;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0003C5CF File Offset: 0x0003A7CF
		internal bool ProxyQuery
		{
			get
			{
				return this.servicePoint.UsesProxy && !this.servicePoint.UseConnect;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0003C5EE File Offset: 0x0003A7EE
		internal ServerCertValidationCallback ServerCertValidationCallback
		{
			get
			{
				return this.certValidationCallback;
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		internal ServicePoint GetServicePoint()
		{
			object obj = this.locker;
			lock (obj)
			{
				if (this.hostChanged || this.servicePoint == null)
				{
					this.servicePoint = ServicePointManager.FindServicePoint(this.actualUri, this.proxy);
					this.hostChanged = false;
				}
			}
			return this.servicePoint;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0003C668 File Offset: 0x0003A868
		private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			object obj = this.locker;
			WebOperation result;
			lock (obj)
			{
				if (!redirecting && this.requestSent)
				{
					WebOperation webOperation = this.currentOperation;
					if (webOperation == null)
					{
						throw new InvalidOperationException("Should never happen!");
					}
					result = webOperation;
				}
				else
				{
					WebOperation webOperation = new WebOperation(this, writeBuffer, false, cancellationToken);
					if (Interlocked.CompareExchange<WebOperation>(ref this.currentOperation, webOperation, null) != null)
					{
						throw new InvalidOperationException("Invalid nested call.");
					}
					this.requestSent = true;
					if (!redirecting)
					{
						this.redirects = 0;
					}
					this.servicePoint = this.GetServicePoint();
					this.servicePoint.SendRequest(webOperation, this.connectionGroup);
					result = webOperation;
				}
			}
			return result;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0003C71C File Offset: 0x0003A91C
		private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
		{
			if (this.Aborted)
			{
				throw HttpWebRequest.CreateRequestAbortedException();
			}
			bool flag = !(this.method == "GET") && !(this.method == "CONNECT") && !(this.method == "HEAD") && !(this.method == "TRACE");
			if (this.method == null || !flag)
			{
				throw new ProtocolViolationException("Cannot send a content-body with this verb-type.");
			}
			if (this.contentLength == -1L && !this.sendChunked && !this.allowBuffering && this.KeepAlive)
			{
				throw new ProtocolViolationException("Content-Length not set");
			}
			string transferEncoding = this.TransferEncoding;
			if (!this.sendChunked && transferEncoding != null && transferEncoding.Trim() != "")
			{
				throw new InvalidOperationException("TransferEncoding requires the SendChunked property to be set to true.");
			}
			object obj = this.locker;
			WebOperation webOperation;
			lock (obj)
			{
				if (this.getResponseCalled)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				webOperation = this.currentOperation;
				if (webOperation == null)
				{
					this.initialMethod = this.method;
					this.gotRequestStream = true;
					webOperation = this.SendRequest(false, null, cancellationToken);
				}
			}
			return webOperation.GetRequestStream();
		}

		/// <summary>Begins an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">The state object for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.HttpWebRequest.Method" /> property is GET or HEAD.-or- 
		///         <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT. </exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is being used by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />-or- 
		///         <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />.-or- The thread pool is running out of threads. </exception>
		/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, requests that write data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented. </exception>
		/// <exception cref="T:System.Net.WebException">
		///         <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called. </exception>
		/// <exception cref="T:System.ObjectDisposedException">In a .NET Compact Framework application, a request stream with zero content length was not obtained and closed correctly. For more information about handling zero content length requests, see Network Programming in the .NET Compact Framework.</exception>
		// Token: 0x06000BA8 RID: 2984 RVA: 0x0003C868 File Offset: 0x0003AA68
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.RunWithTimeout<Stream>(new Func<CancellationToken, Task<Stream>>(this.MyGetRequestStreamAsync)), callback, state);
		}

		/// <summary>Ends an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
		/// <param name="asyncResult">The pending request for a stream. </param>
		/// <returns>A <see cref="T:System.IO.Stream" /> to use to write request data.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.IOException">The request did not complete, and no stream is available. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by the current instance from a call to <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">This method was called previously using <paramref name="asyncResult" />. </exception>
		/// <exception cref="T:System.Net.WebException">
		///         <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- An error occurred while processing the request. </exception>
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0003C884 File Offset: 0x0003AA84
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Stream result;
			try
			{
				result = TaskToApm.End<Stream>(asyncResult);
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0003C8C4 File Offset: 0x0003AAC4
		public override Task<Stream> GetRequestStreamAsync()
		{
			return this.RunWithTimeout<Stream>(new Func<CancellationToken, Task<Stream>>(this.MyGetRequestStreamAsync));
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
		internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			return HttpWebRequest.RunWithTimeoutWorker<T>(func(cancellationTokenSource.Token), timeout, abort, aborted, cancellationTokenSource);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0003C904 File Offset: 0x0003AB04
		private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			HttpWebRequest.<RunWithTimeoutWorker>d__241<T> <RunWithTimeoutWorker>d__;
			<RunWithTimeoutWorker>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<RunWithTimeoutWorker>d__.workerTask = workerTask;
			<RunWithTimeoutWorker>d__.timeout = timeout;
			<RunWithTimeoutWorker>d__.abort = abort;
			<RunWithTimeoutWorker>d__.aborted = aborted;
			<RunWithTimeoutWorker>d__.cts = cts;
			<RunWithTimeoutWorker>d__.<>1__state = -1;
			<RunWithTimeoutWorker>d__.<>t__builder.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<T>>(ref <RunWithTimeoutWorker>d__);
			return <RunWithTimeoutWorker>d__.<>t__builder.Task;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0003C968 File Offset: 0x0003AB68
		private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			return HttpWebRequest.RunWithTimeoutWorker<T>(func(cancellationTokenSource.Token), this.timeout, new Action(this.Abort), () => this.Aborted, cancellationTokenSource);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0003C9AC File Offset: 0x0003ABAC
		private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			HttpWebRequest.<MyGetResponseAsync>d__243 <MyGetResponseAsync>d__;
			<MyGetResponseAsync>d__.<>t__builder = AsyncTaskMethodBuilder<HttpWebResponse>.Create();
			<MyGetResponseAsync>d__.<>4__this = this;
			<MyGetResponseAsync>d__.cancellationToken = cancellationToken;
			<MyGetResponseAsync>d__.<>1__state = -1;
			<MyGetResponseAsync>d__.<>t__builder.Start<HttpWebRequest.<MyGetResponseAsync>d__243>(ref <MyGetResponseAsync>d__);
			return <MyGetResponseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0003C9F8 File Offset: 0x0003ABF8
		[return: TupleElementNames(new string[]
		{
			"response",
			"redirect",
			"mustReadAll",
			"writeBuffer",
			"ntlm"
		})]
		private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			HttpWebRequest.<GetResponseFromData>d__244 <GetResponseFromData>d__;
			<GetResponseFromData>d__.<>t__builder = AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.Create();
			<GetResponseFromData>d__.<>4__this = this;
			<GetResponseFromData>d__.stream = stream;
			<GetResponseFromData>d__.cancellationToken = cancellationToken;
			<GetResponseFromData>d__.<>1__state = -1;
			<GetResponseFromData>d__.<>t__builder.Start<HttpWebRequest.<GetResponseFromData>d__244>(ref <GetResponseFromData>d__);
			return <GetResponseFromData>d__.<>t__builder.Task;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0003CA4C File Offset: 0x0003AC4C
		internal static Exception FlattenException(Exception e)
		{
			AggregateException ex = e as AggregateException;
			if (ex != null)
			{
				ex = ex.Flatten();
				if (ex.InnerExceptions.Count == 1)
				{
					return ex.InnerException;
				}
			}
			return e;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0003CA80 File Offset: 0x0003AC80
		private WebException GetWebException(Exception e)
		{
			return HttpWebRequest.GetWebException(e, this.Aborted);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0003CA90 File Offset: 0x0003AC90
		private static WebException GetWebException(Exception e, bool aborted)
		{
			e = HttpWebRequest.FlattenException(e);
			WebException ex = e as WebException;
			if (ex != null && (!aborted || ex.Status == WebExceptionStatus.RequestCanceled || ex.Status == WebExceptionStatus.Timeout))
			{
				return ex;
			}
			if (aborted || e is OperationCanceledException || e is ObjectDisposedException)
			{
				return HttpWebRequest.CreateRequestAbortedException();
			}
			return new WebException(e.Message, e, WebExceptionStatus.UnknownError, null);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0003CAEF File Offset: 0x0003ACEF
		internal static WebException CreateRequestAbortedException()
		{
			return new WebException(SR.Format("The request was aborted: The request was canceled.", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}

		/// <summary>Begins an asynchronous request to an Internet resource.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate </param>
		/// <param name="state">The state object for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request for a response.</returns>
		/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />-or- 
		///         <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />.-or- The thread pool is running out of threads. </exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">
		///         <see cref="P:System.Net.HttpWebRequest.Method" /> is GET or HEAD, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero or <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="true" />.-or- 
		///         <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is <see langword="false" />, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" /> and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT.-or- The <see cref="T:System.Net.HttpWebRequest" /> has an entity body but the <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method is called without calling the <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" /> method. -or- The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero, but the application does not write all of the promised data.</exception>
		/// <exception cref="T:System.Net.WebException">
		///         <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called. </exception>
		// Token: 0x06000BB4 RID: 2996 RVA: 0x0003CB08 File Offset: 0x0003AD08
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			if (this.Aborted)
			{
				throw HttpWebRequest.CreateRequestAbortedException();
			}
			string transferEncoding = this.TransferEncoding;
			if (!this.sendChunked && transferEncoding != null && transferEncoding.Trim() != "")
			{
				throw new InvalidOperationException("TransferEncoding requires the SendChunked property to be set to true.");
			}
			return TaskToApm.Begin(this.RunWithTimeout<HttpWebResponse>(new Func<CancellationToken, Task<HttpWebResponse>>(this.MyGetResponseAsync)), callback, state);
		}

		/// <summary>Ends an asynchronous request to an Internet resource.</summary>
		/// <param name="asyncResult">The pending request for a response. </param>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the Internet resource.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">This method was called previously using <paramref name="asyncResult." />-or- The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> property is greater than 0 but the data has not been written to the request stream. </exception>
		/// <exception cref="T:System.Net.WebException">
		///         <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- An error occurred while processing the request. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by the current instance from a call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		// Token: 0x06000BB5 RID: 2997 RVA: 0x0003CB6C File Offset: 0x0003AD6C
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			WebResponse result;
			try
			{
				result = TaskToApm.End<HttpWebResponse>(asyncResult);
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		/// <summary>Returns a response from an Internet resource.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the Internet resource.</returns>
		/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.-or- 
		///         <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />. </exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">
		///         <see cref="P:System.Net.HttpWebRequest.Method" /> is GET or HEAD, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater or equal to zero or <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="true" />.-or- 
		///         <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT. -or- The <see cref="T:System.Net.HttpWebRequest" /> has an entity body but the <see cref="M:System.Net.HttpWebRequest.GetResponse" /> method is called without calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> method. -or- The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero, but the application does not write all of the promised data.</exception>
		/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, this request includes data to be sent to the server. Requests that send data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented. </exception>
		/// <exception cref="T:System.Net.WebException">
		///         <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- The time-out period for the request expired.-or- An error occurred while processing the request. </exception>
		// Token: 0x06000BB6 RID: 2998 RVA: 0x0003CBAC File Offset: 0x0003ADAC
		public override WebResponse GetResponse()
		{
			WebResponse result;
			try
			{
				result = this.GetResponseAsync().Result;
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		// Token: 0x17000252 RID: 594
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
		internal bool FinishedReading
		{
			set
			{
				this.finished_reading = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0003CBED File Offset: 0x0003ADED
		internal bool Aborted
		{
			get
			{
				return Interlocked.CompareExchange(ref this.aborted, 0, 0) == 1;
			}
		}

		/// <summary>Cancels a request to an Internet resource.</summary>
		// Token: 0x06000BB9 RID: 3001 RVA: 0x0003CC00 File Offset: 0x0003AE00
		public override void Abort()
		{
			if (Interlocked.CompareExchange(ref this.aborted, 1, 0) == 1)
			{
				return;
			}
			this.haveResponse = true;
			WebOperation webOperation = this.currentOperation;
			if (webOperation != null)
			{
				webOperation.Abort();
			}
			WebCompletionSource webCompletionSource = this.responseTask;
			if (webCompletionSource != null)
			{
				webCompletionSource.TrySetCanceled();
			}
			if (this.webResponse != null)
			{
				try
				{
					this.webResponse.Close();
					this.webResponse = null;
				}
				catch
				{
				}
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06000BBA RID: 3002 RVA: 0x0003CC78 File Offset: 0x0003AE78
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new SerializationException();
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data required to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06000BBB RID: 3003 RVA: 0x0003CC78 File Offset: 0x0003AE78
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new SerializationException();
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0003CC7F File Offset: 0x0003AE7F
		private void CheckRequestStarted()
		{
			if (this.requestSent)
			{
				throw new InvalidOperationException("request started");
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0003CC94 File Offset: 0x0003AE94
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			if (this.continueDelegate != null)
			{
				this.continueDelegate(statusCode, headers);
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0003CCAB File Offset: 0x0003AEAB
		private void RewriteRedirectToGet()
		{
			this.method = "GET";
			this.webHeaders.RemoveInternal("Transfer-Encoding");
			this.sendChunked = false;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		private bool Redirect(HttpStatusCode code, WebResponse response)
		{
			this.redirects++;
			Exception ex = null;
			string text = null;
			switch (code)
			{
			case HttpStatusCode.MultipleChoices:
				ex = new WebException("Ambiguous redirect.");
				goto IL_97;
			case HttpStatusCode.MovedPermanently:
			case HttpStatusCode.Found:
				if (this.method == "POST")
				{
					this.RewriteRedirectToGet();
					goto IL_97;
				}
				goto IL_97;
			case HttpStatusCode.SeeOther:
				this.RewriteRedirectToGet();
				goto IL_97;
			case HttpStatusCode.NotModified:
				return false;
			case HttpStatusCode.UseProxy:
				ex = new NotImplementedException("Proxy support not available.");
				goto IL_97;
			case HttpStatusCode.TemporaryRedirect:
				goto IL_97;
			}
			string str = "Invalid status code: ";
			int num = (int)code;
			ex = new ProtocolViolationException(str + num.ToString());
			IL_97:
			if (this.method != "GET" && !this.InternalAllowBuffering && this.ResendContentFactory == null && (this.writeStream.WriteBufferLength > 0 || this.contentLength > 0L))
			{
				ex = new WebException("The request requires buffering data to succeed.", null, WebExceptionStatus.ProtocolError, response);
			}
			if (ex != null)
			{
				throw ex;
			}
			if (this.AllowWriteStreamBuffering || this.method == "GET")
			{
				this.contentLength = -1L;
			}
			text = response.Headers["Location"];
			if (text == null)
			{
				throw new WebException(string.Format("No Location header found for {0}", (int)code), null, WebExceptionStatus.ProtocolError, response);
			}
			Uri uri = this.actualUri;
			try
			{
				this.actualUri = new Uri(this.actualUri, text);
			}
			catch (Exception)
			{
				throw new WebException(string.Format("Invalid URL ({0}) for {1}", text, (int)code), null, WebExceptionStatus.ProtocolError, response);
			}
			this.hostChanged = (this.actualUri.Scheme != uri.Scheme || this.Host != uri.Authority);
			return true;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0003CE8C File Offset: 0x0003B08C
		private string GetHeaders()
		{
			bool flag = false;
			if (this.sendChunked)
			{
				flag = true;
				this.webHeaders.ChangeInternal("Transfer-Encoding", "chunked");
				this.webHeaders.RemoveInternal("Content-Length");
			}
			else if (this.contentLength != -1L)
			{
				if (this.auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge || this.proxy_auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge)
				{
					if (this.haveContentLength || this.gotRequestStream || this.contentLength > 0L)
					{
						this.webHeaders.SetInternal("Content-Length", "0");
					}
					else
					{
						this.webHeaders.RemoveInternal("Content-Length");
					}
				}
				else
				{
					if (this.contentLength > 0L)
					{
						flag = true;
					}
					if (this.haveContentLength || this.gotRequestStream || this.contentLength > 0L)
					{
						this.webHeaders.SetInternal("Content-Length", this.contentLength.ToString());
					}
				}
				this.webHeaders.RemoveInternal("Transfer-Encoding");
			}
			else
			{
				this.webHeaders.RemoveInternal("Content-Length");
			}
			if (this.actualVersion == HttpVersion.Version11 && flag && this.servicePoint.SendContinue)
			{
				this.webHeaders.ChangeInternal("Expect", "100-continue");
				this.expectContinue = true;
			}
			else
			{
				this.webHeaders.RemoveInternal("Expect");
				this.expectContinue = false;
			}
			bool proxyQuery = this.ProxyQuery;
			string name = proxyQuery ? "Proxy-Connection" : "Connection";
			this.webHeaders.RemoveInternal((!proxyQuery) ? "Proxy-Connection" : "Connection");
			Version protocolVersion = this.servicePoint.ProtocolVersion;
			bool flag2 = protocolVersion == null || protocolVersion == HttpVersion.Version10;
			if (this.keepAlive && (this.version == HttpVersion.Version10 || flag2))
			{
				if (this.webHeaders[name] == null || this.webHeaders[name].IndexOf("keep-alive", StringComparison.OrdinalIgnoreCase) == -1)
				{
					this.webHeaders.ChangeInternal(name, "keep-alive");
				}
			}
			else if (!this.keepAlive && this.version == HttpVersion.Version11)
			{
				this.webHeaders.ChangeInternal(name, "close");
			}
			string components;
			if (this.hostUri != null)
			{
				if (this.hostHasPort)
				{
					components = this.hostUri.GetComponents(UriComponents.HostAndPort, UriFormat.Unescaped);
				}
				else
				{
					components = this.hostUri.GetComponents(UriComponents.Host, UriFormat.Unescaped);
				}
			}
			else if (this.Address.IsDefaultPort)
			{
				components = this.Address.GetComponents(UriComponents.Host, UriFormat.Unescaped);
			}
			else
			{
				components = this.Address.GetComponents(UriComponents.HostAndPort, UriFormat.Unescaped);
			}
			this.webHeaders.SetInternal("Host", components);
			if (this.cookieContainer != null)
			{
				string cookieHeader = this.cookieContainer.GetCookieHeader(this.actualUri);
				if (cookieHeader != "")
				{
					this.webHeaders.ChangeInternal("Cookie", cookieHeader);
				}
				else
				{
					this.webHeaders.RemoveInternal("Cookie");
				}
			}
			string text = null;
			if ((this.auto_decomp & DecompressionMethods.GZip) != DecompressionMethods.None)
			{
				text = "gzip";
			}
			if ((this.auto_decomp & DecompressionMethods.Deflate) != DecompressionMethods.None)
			{
				text = ((text != null) ? "gzip, deflate" : "deflate");
			}
			if (text != null)
			{
				this.webHeaders.ChangeInternal("Accept-Encoding", text);
			}
			if (!this.usedPreAuth && this.preAuthenticate)
			{
				this.DoPreAuthenticate();
			}
			return this.webHeaders.ToString();
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0003D200 File Offset: 0x0003B400
		private void DoPreAuthenticate()
		{
			bool flag = this.proxy != null && !this.proxy.IsBypassed(this.actualUri);
			ICredentials credentials = (!flag || this.credentials != null) ? this.credentials : this.proxy.Credentials;
			Authorization authorization = AuthenticationManager.PreAuthenticate(this, credentials);
			if (authorization == null)
			{
				return;
			}
			this.webHeaders.RemoveInternal("Proxy-Authorization");
			this.webHeaders.RemoveInternal("Authorization");
			string name = (flag && this.credentials == null) ? "Proxy-Authorization" : "Authorization";
			this.webHeaders[name] = authorization.Message;
			this.usedPreAuth = true;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0003D2AC File Offset: 0x0003B4AC
		internal byte[] GetRequestHeaders()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text;
			if (!this.ProxyQuery)
			{
				text = this.actualUri.PathAndQuery;
			}
			else
			{
				text = string.Format("{0}://{1}{2}", this.actualUri.Scheme, this.Host, this.actualUri.PathAndQuery);
			}
			if (!this.force_version && this.servicePoint.ProtocolVersion != null && this.servicePoint.ProtocolVersion < this.version)
			{
				this.actualVersion = this.servicePoint.ProtocolVersion;
			}
			else
			{
				this.actualVersion = this.version;
			}
			stringBuilder.AppendFormat("{0} {1} HTTP/{2}.{3}\r\n", new object[]
			{
				this.method,
				text,
				this.actualVersion.Major,
				this.actualVersion.Minor
			});
			stringBuilder.Append(this.GetHeaders());
			string s = stringBuilder.ToString();
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0003D3B4 File Offset: 0x0003B5B4
		private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			bool flag = response.StatusCode == HttpStatusCode.ProxyAuthenticationRequired;
			if ((flag ? this.proxy_auth_state : this.auth_state).NtlmAuthState == HttpWebRequest.NtlmAuthState.None)
			{
				return new ValueTuple<WebOperation, bool>(null, false);
			}
			bool flag2 = this.auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge || this.proxy_auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge;
			WebOperation webOperation = new WebOperation(this, writeBuffer, flag2, cancellationToken);
			stream.Operation.SetPriorityRequest(webOperation);
			ICredentials credentials = (!flag || this.proxy == null) ? this.credentials : this.proxy.Credentials;
			if (credentials != null)
			{
				stream.Connection.NtlmCredential = credentials.GetCredential(this.requestUri, "NTLM");
				stream.Connection.UnsafeAuthenticatedConnectionSharing = this.unsafe_auth_blah;
			}
			return new ValueTuple<WebOperation, bool>(webOperation, flag2);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0003D480 File Offset: 0x0003B680
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			if (code != HttpStatusCode.ProxyAuthenticationRequired)
			{
				return this.auth_state.CheckAuthorization(response, code);
			}
			return this.proxy_auth_state.CheckAuthorization(response, code);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
		[return: TupleElementNames(new string[]
		{
			"task",
			"throwMe"
		})]
		private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			if (redirect)
			{
				if (!this.MethodWithBuffer)
				{
					return new ValueTuple<Task<BufferOffsetSize>, WebException>(null, null);
				}
				if (this.writeStream.WriteBufferLength == 0 || this.contentLength == 0L)
				{
					return new ValueTuple<Task<BufferOffsetSize>, WebException>(null, null);
				}
			}
			if (this.AllowWriteStreamBuffering)
			{
				return new ValueTuple<Task<BufferOffsetSize>, WebException>(Task.FromResult<BufferOffsetSize>(this.writeStream.GetWriteBuffer()), null);
			}
			if (this.ResendContentFactory == null)
			{
				return new ValueTuple<Task<BufferOffsetSize>, WebException>(null, new WebException("The request requires buffering data to succeed.", null, WebExceptionStatus.ProtocolError, response));
			}
			return new ValueTuple<Task<BufferOffsetSize>, WebException>(delegate
			{
				HttpWebRequest.<<GetRewriteHandler>b__271_0>d <<GetRewriteHandler>b__271_0>d;
				<<GetRewriteHandler>b__271_0>d.<>t__builder = AsyncTaskMethodBuilder<BufferOffsetSize>.Create();
				<<GetRewriteHandler>b__271_0>d.<>4__this = this;
				<<GetRewriteHandler>b__271_0>d.<>1__state = -1;
				<<GetRewriteHandler>b__271_0>d.<>t__builder.Start<HttpWebRequest.<<GetRewriteHandler>b__271_0>d>(ref <<GetRewriteHandler>b__271_0>d);
				return <<GetRewriteHandler>b__271_0>d.<>t__builder.Task;
			}(), null);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0003D538 File Offset: 0x0003B738
		[return: TupleElementNames(new string[]
		{
			"redirect",
			"mustReadAll",
			"writeBuffer",
			"throwMe"
		})]
		private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			WebException ex = null;
			bool item = false;
			Task<BufferOffsetSize> item2 = null;
			HttpStatusCode statusCode = response.StatusCode;
			if (((!this.auth_state.IsCompleted && statusCode == HttpStatusCode.Unauthorized && this.credentials != null) || (this.ProxyQuery && !this.proxy_auth_state.IsCompleted && statusCode == HttpStatusCode.ProxyAuthenticationRequired)) && !this.usedPreAuth && this.CheckAuthorization(response, statusCode))
			{
				item = true;
				if (!this.MethodWithBuffer)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(true, item, null, null);
				}
				ValueTuple<Task<BufferOffsetSize>, WebException> rewriteHandler = this.GetRewriteHandler(response, false);
				item2 = rewriteHandler.Item1;
				ex = rewriteHandler.Item2;
				if (ex == null)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(true, item, item2, null);
				}
				if (!this.ThrowOnError)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, null);
				}
				this.writeStream.InternalClose();
				this.writeStream = null;
				response.Close();
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, ex);
			}
			else
			{
				if (statusCode >= HttpStatusCode.BadRequest)
				{
					ex = new WebException(string.Format("The remote server returned an error: ({0}) {1}.", (int)statusCode, response.StatusDescription), null, WebExceptionStatus.ProtocolError, response);
					item = true;
				}
				else if (statusCode == HttpStatusCode.NotModified && this.allowAutoRedirect)
				{
					ex = new WebException(string.Format("The remote server returned an error: ({0}) {1}.", (int)statusCode, response.StatusDescription), null, WebExceptionStatus.ProtocolError, response);
				}
				else if (statusCode >= HttpStatusCode.MultipleChoices && this.allowAutoRedirect && this.redirects >= this.maxAutoRedirect)
				{
					ex = new WebException("Max. redirections exceeded.", null, WebExceptionStatus.ProtocolError, response);
					item = true;
				}
				if (ex == null)
				{
					int num = (int)statusCode;
					bool flag = false;
					if (this.allowAutoRedirect && num >= 300)
					{
						flag = this.Redirect(statusCode, response);
						ValueTuple<Task<BufferOffsetSize>, WebException> rewriteHandler2 = this.GetRewriteHandler(response, true);
						item2 = rewriteHandler2.Item1;
						ex = rewriteHandler2.Item2;
						if (flag && !this.unsafe_auth_blah)
						{
							this.auth_state.Reset();
							this.proxy_auth_state.Reset();
						}
					}
					if (num >= 300 && num != 304)
					{
						item = true;
					}
					if (ex == null)
					{
						return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(flag, item, item2, null);
					}
				}
				if (!this.ThrowOnError)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, null);
				}
				if (this.writeStream != null)
				{
					this.writeStream.InternalClose();
					this.writeStream = null;
				}
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, ex);
			}
		}

		// Token: 0x04000833 RID: 2099
		private Uri requestUri;

		// Token: 0x04000834 RID: 2100
		private Uri actualUri;

		// Token: 0x04000835 RID: 2101
		private bool hostChanged;

		// Token: 0x04000836 RID: 2102
		private bool allowAutoRedirect = true;

		// Token: 0x04000837 RID: 2103
		private bool allowBuffering = true;

		// Token: 0x04000838 RID: 2104
		private X509CertificateCollection certificates;

		// Token: 0x04000839 RID: 2105
		private string connectionGroup;

		// Token: 0x0400083A RID: 2106
		private bool haveContentLength;

		// Token: 0x0400083B RID: 2107
		private long contentLength = -1L;

		// Token: 0x0400083C RID: 2108
		private HttpContinueDelegate continueDelegate;

		// Token: 0x0400083D RID: 2109
		private CookieContainer cookieContainer;

		// Token: 0x0400083E RID: 2110
		private ICredentials credentials;

		// Token: 0x0400083F RID: 2111
		private bool haveResponse;

		// Token: 0x04000840 RID: 2112
		private bool requestSent;

		// Token: 0x04000841 RID: 2113
		private WebHeaderCollection webHeaders;

		// Token: 0x04000842 RID: 2114
		private bool keepAlive = true;

		// Token: 0x04000843 RID: 2115
		private int maxAutoRedirect = 50;

		// Token: 0x04000844 RID: 2116
		private string mediaType = string.Empty;

		// Token: 0x04000845 RID: 2117
		private string method = "GET";

		// Token: 0x04000846 RID: 2118
		private string initialMethod = "GET";

		// Token: 0x04000847 RID: 2119
		private bool pipelined = true;

		// Token: 0x04000848 RID: 2120
		private bool preAuthenticate;

		// Token: 0x04000849 RID: 2121
		private bool usedPreAuth;

		// Token: 0x0400084A RID: 2122
		private Version version = HttpVersion.Version11;

		// Token: 0x0400084B RID: 2123
		private bool force_version;

		// Token: 0x0400084C RID: 2124
		private Version actualVersion;

		// Token: 0x0400084D RID: 2125
		private IWebProxy proxy;

		// Token: 0x0400084E RID: 2126
		private bool sendChunked;

		// Token: 0x0400084F RID: 2127
		private ServicePoint servicePoint;

		// Token: 0x04000850 RID: 2128
		private int timeout = 100000;

		// Token: 0x04000851 RID: 2129
		private int continueTimeout = 350;

		// Token: 0x04000852 RID: 2130
		private WebRequestStream writeStream;

		// Token: 0x04000853 RID: 2131
		private HttpWebResponse webResponse;

		// Token: 0x04000854 RID: 2132
		private WebCompletionSource responseTask;

		// Token: 0x04000855 RID: 2133
		private WebOperation currentOperation;

		// Token: 0x04000856 RID: 2134
		private int aborted;

		// Token: 0x04000857 RID: 2135
		private bool gotRequestStream;

		// Token: 0x04000858 RID: 2136
		private int redirects;

		// Token: 0x04000859 RID: 2137
		private bool expectContinue;

		// Token: 0x0400085A RID: 2138
		private bool getResponseCalled;

		// Token: 0x0400085B RID: 2139
		private object locker = new object();

		// Token: 0x0400085C RID: 2140
		private bool finished_reading;

		// Token: 0x0400085D RID: 2141
		private DecompressionMethods auto_decomp;

		// Token: 0x0400085E RID: 2142
		private static int defaultMaxResponseHeadersLength = 64;

		// Token: 0x0400085F RID: 2143
		private static int defaultMaximumErrorResponseLength = 64;

		// Token: 0x04000860 RID: 2144
		private static RequestCachePolicy defaultCachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);

		// Token: 0x04000861 RID: 2145
		private int readWriteTimeout = 300000;

		// Token: 0x04000862 RID: 2146
		private MobileTlsProvider tlsProvider;

		// Token: 0x04000863 RID: 2147
		private MonoTlsSettings tlsSettings;

		// Token: 0x04000864 RID: 2148
		private ServerCertValidationCallback certValidationCallback;

		// Token: 0x04000865 RID: 2149
		private bool hostHasPort;

		// Token: 0x04000866 RID: 2150
		private Uri hostUri;

		// Token: 0x04000867 RID: 2151
		private HttpWebRequest.AuthorizationState auth_state;

		// Token: 0x04000868 RID: 2152
		private HttpWebRequest.AuthorizationState proxy_auth_state;

		// Token: 0x04000869 RID: 2153
		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		// Token: 0x0400086B RID: 2155
		private bool unsafe_auth_blah;

		// Token: 0x020001AD RID: 429
		private enum NtlmAuthState
		{
			// Token: 0x0400086D RID: 2157
			None,
			// Token: 0x0400086E RID: 2158
			Challenge,
			// Token: 0x0400086F RID: 2159
			Response
		}

		// Token: 0x020001AE RID: 430
		private struct AuthorizationState
		{
			// Token: 0x17000254 RID: 596
			// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0003D797 File Offset: 0x0003B997
			public bool IsCompleted
			{
				get
				{
					return this.isCompleted;
				}
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0003D79F File Offset: 0x0003B99F
			public HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				get
				{
					return this.ntlm_auth_state;
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0003D7A7 File Offset: 0x0003B9A7
			public bool IsNtlmAuthenticated
			{
				get
				{
					return this.isCompleted && this.ntlm_auth_state > HttpWebRequest.NtlmAuthState.None;
				}
			}

			// Token: 0x06000BCC RID: 3020 RVA: 0x0003D7BC File Offset: 0x0003B9BC
			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
				this.request = request;
				this.isProxy = isProxy;
				this.isCompleted = false;
				this.ntlm_auth_state = HttpWebRequest.NtlmAuthState.None;
			}

			// Token: 0x06000BCD RID: 3021 RVA: 0x0003D7DC File Offset: 0x0003B9DC
			public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				this.isCompleted = false;
				if (code == HttpStatusCode.Unauthorized && this.request.credentials == null)
				{
					return false;
				}
				if (this.isProxy != (code == HttpStatusCode.ProxyAuthenticationRequired))
				{
					return false;
				}
				if (this.isProxy && (this.request.proxy == null || this.request.proxy.Credentials == null))
				{
					return false;
				}
				string[] values = response.Headers.GetValues(this.isProxy ? "Proxy-Authenticate" : "WWW-Authenticate");
				if (values == null || values.Length == 0)
				{
					return false;
				}
				ICredentials credentials = (!this.isProxy) ? this.request.credentials : this.request.proxy.Credentials;
				Authorization authorization = null;
				string[] array = values;
				for (int i = 0; i < array.Length; i++)
				{
					authorization = AuthenticationManager.Authenticate(array[i], this.request, credentials);
					if (authorization != null)
					{
						break;
					}
				}
				if (authorization == null)
				{
					return false;
				}
				this.request.webHeaders[this.isProxy ? "Proxy-Authorization" : "Authorization"] = authorization.Message;
				this.isCompleted = authorization.Complete;
				if (authorization.ModuleAuthenticationType == "NTLM")
				{
					this.ntlm_auth_state++;
				}
				return true;
			}

			// Token: 0x06000BCE RID: 3022 RVA: 0x0003D917 File Offset: 0x0003BB17
			public void Reset()
			{
				this.isCompleted = false;
				this.ntlm_auth_state = HttpWebRequest.NtlmAuthState.None;
				this.request.webHeaders.RemoveInternal(this.isProxy ? "Proxy-Authorization" : "Authorization");
			}

			// Token: 0x06000BCF RID: 3023 RVA: 0x0003D94B File Offset: 0x0003BB4B
			public override string ToString()
			{
				return string.Format("{0}AuthState [{1}:{2}]", this.isProxy ? "Proxy" : "", this.isCompleted, this.ntlm_auth_state);
			}

			// Token: 0x04000870 RID: 2160
			private readonly HttpWebRequest request;

			// Token: 0x04000871 RID: 2161
			private readonly bool isProxy;

			// Token: 0x04000872 RID: 2162
			private bool isCompleted;

			// Token: 0x04000873 RID: 2163
			private HttpWebRequest.NtlmAuthState ntlm_auth_state;
		}
	}
}
