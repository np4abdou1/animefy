using System;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	/// <summary>Provides connection management for HTTP connections.</summary>
	// Token: 0x020001BD RID: 445
	public class ServicePoint
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
		internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
		{
			this.Key = key;
			this.uri = uri;
			this.connectionLimit = connectionLimit;
			this.maxIdleTime = maxIdleTime;
			this.Scheduler = new ServicePointScheduler(this, connectionLimit, maxIdleTime);
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0003F71F File Offset: 0x0003D91F
		internal ServicePointManager.SPKey Key { get; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003F727 File Offset: 0x0003D927
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0003F72F File Offset: 0x0003D92F
		private ServicePointScheduler Scheduler { get; set; }

		/// <summary>Gets the Uniform Resource Identifier (URI) of the server that this <see cref="T:System.Net.ServicePoint" /> object connects to.</summary>
		/// <returns>An instance of the <see cref="T:System.Uri" /> class that contains the URI of the Internet server that this <see cref="T:System.Net.ServicePoint" /> object connects to.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Net.ServicePoint" /> is in host mode.</exception>
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003F738 File Offset: 0x0003D938
		public Uri Address
		{
			get
			{
				return this.uri;
			}
		}

		/// <summary>Gets or sets the maximum number of connections allowed on this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>The maximum number of connections allowed on this <see cref="T:System.Net.ServicePoint" /> object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The connection limit is equal to or less than 0. </exception>
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003F740 File Offset: 0x0003D940
		public int ConnectionLimit
		{
			get
			{
				return this.connectionLimit;
			}
		}

		/// <summary>Gets the version of the HTTP protocol that the <see cref="T:System.Net.ServicePoint" /> object uses.</summary>
		/// <returns>A <see cref="T:System.Version" /> object that contains the HTTP protocol version that the <see cref="T:System.Net.ServicePoint" /> object uses.</returns>
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0003F748 File Offset: 0x0003D948
		public virtual Version ProtocolVersion
		{
			get
			{
				return this.protocolVersion;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether 100-Continue behavior is used.</summary>
		/// <returns>
		///     <see langword="true" /> to expect 100-Continue responses for <see langword="POST" /> requests; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
		// Token: 0x17000266 RID: 614
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0003F750 File Offset: 0x0003D950
		public bool Expect100Continue
		{
			set
			{
				this.SendContinue = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether the Nagle algorithm is used on connections managed by this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>
		///     <see langword="true" /> to use the Nagle algorithm; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0003F759 File Offset: 0x0003D959
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0003F761 File Offset: 0x0003D961
		public bool UseNagleAlgorithm
		{
			get
			{
				return this.useNagle;
			}
			set
			{
				this.useNagle = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003F76A File Offset: 0x0003D96A
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0003F796 File Offset: 0x0003D996
		internal bool SendContinue
		{
			get
			{
				return this.sendContinue && (this.protocolVersion == null || this.protocolVersion == HttpVersion.Version11);
			}
			set
			{
				this.sendContinue = value;
			}
		}

		/// <summary>Enables or disables the keep-alive option on a TCP connection.</summary>
		/// <param name="enabled">If set to true, then the TCP keep-alive option on a TCP connection will be enabled using the specified <paramref name="keepAliveTime " />and <paramref name="keepAliveInterval" /> values. If set to false, then the TCP keep-alive option is disabled and the remaining parameters are ignored.The default value is false.</param>
		/// <param name="keepAliveTime">Specifies the timeout, in milliseconds, with no activity until the first keep-alive packet is sent. The value must be greater than 0.  If a value of less than or equal to zero is passed an <see cref="T:System.ArgumentOutOfRangeException" /> is thrown.</param>
		/// <param name="keepAliveInterval">Specifies the interval, in milliseconds, between when successive keep-alive packets are sent if no acknowledgement is received.The value must be greater than 0.  If a value of less than or equal to zero is passed an <see cref="T:System.ArgumentOutOfRangeException" /> is thrown.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for <paramref name="keepAliveTime" /> or <paramref name="keepAliveInterval" /> parameter is less than or equal to 0.</exception>
		// Token: 0x06000C16 RID: 3094 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			if (enabled)
			{
				if (keepAliveTime <= 0)
				{
					throw new ArgumentOutOfRangeException("keepAliveTime", "Must be greater than 0");
				}
				if (keepAliveInterval <= 0)
				{
					throw new ArgumentOutOfRangeException("keepAliveInterval", "Must be greater than 0");
				}
			}
			this.tcp_keepalive = enabled;
			this.tcp_keepalive_time = keepAliveTime;
			this.tcp_keepalive_interval = keepAliveInterval;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0003F7F0 File Offset: 0x0003D9F0
		internal void KeepAliveSetup(Socket socket)
		{
			if (!this.tcp_keepalive)
			{
				return;
			}
			byte[] array = new byte[12];
			ServicePoint.PutBytes(array, this.tcp_keepalive ? 1U : 0U, 0);
			ServicePoint.PutBytes(array, (uint)this.tcp_keepalive_time, 4);
			ServicePoint.PutBytes(array, (uint)this.tcp_keepalive_interval, 8);
			socket.IOControl((IOControlCode)((ulong)-1744830460), array, null);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0003F84C File Offset: 0x0003DA4C
		private static void PutBytes(byte[] bytes, uint v, int offset)
		{
			if (BitConverter.IsLittleEndian)
			{
				bytes[offset] = (byte)(v & 255U);
				bytes[offset + 1] = (byte)((v & 65280U) >> 8);
				bytes[offset + 2] = (byte)((v & 16711680U) >> 16);
				bytes[offset + 3] = (byte)((v & 4278190080U) >> 24);
				return;
			}
			bytes[offset + 3] = (byte)(v & 255U);
			bytes[offset + 2] = (byte)((v & 65280U) >> 8);
			bytes[offset + 1] = (byte)((v & 16711680U) >> 16);
			bytes[offset] = (byte)((v & 4278190080U) >> 24);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003F8D5 File Offset: 0x0003DAD5
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x0003F8DD File Offset: 0x0003DADD
		internal bool UsesProxy
		{
			get
			{
				return this.usesProxy;
			}
			set
			{
				this.usesProxy = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0003F8E6 File Offset: 0x0003DAE6
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x0003F8EE File Offset: 0x0003DAEE
		internal bool UseConnect
		{
			get
			{
				return this.useConnect;
			}
			set
			{
				this.useConnect = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0003F8F8 File Offset: 0x0003DAF8
		private bool HasTimedOut
		{
			get
			{
				int dnsRefreshTimeout = ServicePointManager.DnsRefreshTimeout;
				return dnsRefreshTimeout != -1 && this.lastDnsResolve + TimeSpan.FromMilliseconds((double)dnsRefreshTimeout) < DateTime.UtcNow;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003F930 File Offset: 0x0003DB30
		internal IPHostEntry HostEntry
		{
			get
			{
				object obj = this.hostE;
				lock (obj)
				{
					string text = this.uri.Host;
					if (this.uri.HostNameType == UriHostNameType.IPv6 || this.uri.HostNameType == UriHostNameType.IPv4)
					{
						if (this.host != null)
						{
							return this.host;
						}
						if (this.uri.HostNameType == UriHostNameType.IPv6)
						{
							text = text.Substring(1, text.Length - 2);
						}
						this.host = new IPHostEntry();
						this.host.AddressList = new IPAddress[]
						{
							IPAddress.Parse(text)
						};
						return this.host;
					}
					else
					{
						if (!this.HasTimedOut && this.host != null)
						{
							return this.host;
						}
						this.lastDnsResolve = DateTime.UtcNow;
						try
						{
							this.host = Dns.GetHostEntry(text);
						}
						catch
						{
							return null;
						}
					}
				}
				return this.host;
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003FA3C File Offset: 0x0003DC3C
		internal void SetVersion(Version version)
		{
			this.protocolVersion = version;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0003FA48 File Offset: 0x0003DC48
		internal void SendRequest(WebOperation operation, string groupName)
		{
			lock (this)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(typeof(ServicePoint).FullName);
				}
				this.Scheduler.SendRequest(operation, groupName);
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003FAA8 File Offset: 0x0003DCA8
		internal void FreeServicePoint()
		{
			this.disposed = true;
			this.Scheduler = null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003FAB8 File Offset: 0x0003DCB8
		internal void UpdateServerCertificate(X509Certificate certificate)
		{
			if (certificate != null)
			{
				this.m_ServerCertificateOrBytes = certificate.GetRawCertData();
				return;
			}
			this.m_ServerCertificateOrBytes = null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0003FAD1 File Offset: 0x0003DCD1
		internal void UpdateClientCertificate(X509Certificate certificate)
		{
			if (certificate != null)
			{
				this.m_ClientCertificateOrBytes = certificate.GetRawCertData();
				return;
			}
			this.m_ClientCertificateOrBytes = null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0003FAEC File Offset: 0x0003DCEC
		internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			if (this.endPointCallback == null)
			{
				return true;
			}
			int num = 0;
			checked
			{
				for (;;)
				{
					IPEndPoint ipendPoint = null;
					try
					{
						ipendPoint = this.endPointCallback(this, remote, num);
					}
					catch
					{
						return false;
					}
					if (ipendPoint == null)
					{
						break;
					}
					try
					{
						sock.Bind(ipendPoint);
					}
					catch (SocketException)
					{
						num++;
						continue;
					}
					return true;
				}
				return true;
			}
		}

		// Token: 0x040008D0 RID: 2256
		private readonly Uri uri;

		// Token: 0x040008D1 RID: 2257
		private DateTime lastDnsResolve;

		// Token: 0x040008D2 RID: 2258
		private Version protocolVersion;

		// Token: 0x040008D3 RID: 2259
		private IPHostEntry host;

		// Token: 0x040008D4 RID: 2260
		private bool usesProxy;

		// Token: 0x040008D5 RID: 2261
		private bool sendContinue = true;

		// Token: 0x040008D6 RID: 2262
		private bool useConnect;

		// Token: 0x040008D7 RID: 2263
		private object hostE = new object();

		// Token: 0x040008D8 RID: 2264
		private bool useNagle;

		// Token: 0x040008D9 RID: 2265
		private BindIPEndPoint endPointCallback;

		// Token: 0x040008DA RID: 2266
		private bool tcp_keepalive;

		// Token: 0x040008DB RID: 2267
		private int tcp_keepalive_time;

		// Token: 0x040008DC RID: 2268
		private int tcp_keepalive_interval;

		// Token: 0x040008DD RID: 2269
		private bool disposed;

		// Token: 0x040008DE RID: 2270
		private int connectionLeaseTimeout = -1;

		// Token: 0x040008DF RID: 2271
		private int receiveBufferSize = -1;

		// Token: 0x040008E2 RID: 2274
		private int connectionLimit;

		// Token: 0x040008E3 RID: 2275
		private int maxIdleTime;

		// Token: 0x040008E4 RID: 2276
		private object m_ServerCertificateOrBytes;

		// Token: 0x040008E5 RID: 2277
		private object m_ClientCertificateOrBytes;
	}
}
