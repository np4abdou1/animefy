using System;
using System.Collections.Concurrent;
using System.Net.Security;

namespace System.Net
{
	/// <summary>Manages the collection of <see cref="T:System.Net.ServicePoint" /> objects.</summary>
	// Token: 0x020001BE RID: 446
	public class ServicePointManager
	{
		// Token: 0x06000C26 RID: 3110 RVA: 0x0003FB93 File Offset: 0x0003DD93
		internal static ICertificatePolicy GetLegacyCertificatePolicy()
		{
			return ServicePointManager.policy;
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that indicates whether the certificate is checked against the certificate authority revocation list.</summary>
		/// <returns>
		///     <see langword="true" /> if the certificate revocation list is checked; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0003FB9A File Offset: 0x0003DD9A
		public static bool CheckCertificateRevocationList
		{
			get
			{
				return ServicePointManager._checkCRL;
			}
		}

		/// <summary>Gets or sets a value that indicates how long a Domain Name Service (DNS) resolution is considered valid.</summary>
		/// <returns>The time-out value, in milliseconds. A value of -1 indicates an infinite time-out period. The default value is 120,000 milliseconds (two minutes).</returns>
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003FBA1 File Offset: 0x0003DDA1
		public static int DnsRefreshTimeout
		{
			get
			{
				return ServicePointManager.dnsRefreshTimeout;
			}
		}

		/// <summary>Gets or sets the security protocol used by the <see cref="T:System.Net.ServicePoint" /> objects managed by the <see cref="T:System.Net.ServicePointManager" /> object.</summary>
		/// <returns>One of the values defined in the <see cref="T:System.Net.SecurityProtocolType" /> enumeration.</returns>
		/// <exception cref="T:System.NotSupportedException">The value specified to set the property is not a valid <see cref="T:System.Net.SecurityProtocolType" /> enumeration value. </exception>
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
		public static SecurityProtocolType SecurityProtocol
		{
			get
			{
				return ServicePointManager._securityProtocol;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0003FBAF File Offset: 0x0003DDAF
		internal static ServerCertValidationCallback ServerCertValidationCallback
		{
			get
			{
				return ServicePointManager.server_cert_cb;
			}
		}

		/// <summary>Gets or sets the callback to validate a server certificate.</summary>
		/// <returns>A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" />. The default value is <see langword="null" />.</returns>
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0003FBB6 File Offset: 0x0003DDB6
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x0003FBCB File Offset: 0x0003DDCB
		public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				if (ServicePointManager.server_cert_cb == null)
				{
					return null;
				}
				return ServicePointManager.server_cert_cb.ValidationCallback;
			}
			set
			{
				if (value == null)
				{
					ServicePointManager.server_cert_cb = null;
					return;
				}
				ServicePointManager.server_cert_cb = new ServerCertValidationCallback(value);
			}
		}

		/// <summary>Finds an existing <see cref="T:System.Net.ServicePoint" /> object or creates a new <see cref="T:System.Net.ServicePoint" /> object to manage communications with the specified <see cref="T:System.Uri" /> object.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> object that contains the address of the Internet resource to contact. </param>
		/// <param name="proxy">The proxy data for this request. </param>
		/// <returns>The <see cref="T:System.Net.ServicePoint" /> object that manages communications for the request.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="address" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The maximum number of <see cref="T:System.Net.ServicePoint" /> objects defined in <see cref="P:System.Net.ServicePointManager.MaxServicePoints" /> has been reached. </exception>
		// Token: 0x06000C2D RID: 3117 RVA: 0x0003FBE4 File Offset: 0x0003DDE4
		public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			Uri uri = new Uri(address.Scheme + "://" + address.Authority);
			bool flag = false;
			bool flag2 = false;
			if (proxy != null && !proxy.IsBypassed(address))
			{
				flag = true;
				bool flag3 = address.Scheme == "https";
				address = proxy.GetProxy(address);
				if (address.Scheme != "http")
				{
					throw new NotSupportedException("Proxy scheme not supported.");
				}
				if (flag3 && address.Scheme == "http")
				{
					flag2 = true;
				}
			}
			address = new Uri(address.Scheme + "://" + address.Authority);
			ServicePointManager.SPKey key = new ServicePointManager.SPKey(uri, flag ? address : null, flag2);
			ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> obj = ServicePointManager.servicePoints;
			ServicePoint result;
			lock (obj)
			{
				ServicePoint servicePoint;
				if (ServicePointManager.servicePoints.TryGetValue(key, out servicePoint))
				{
					result = servicePoint;
				}
				else
				{
					if (ServicePointManager.maxServicePoints > 0 && ServicePointManager.servicePoints.Count >= ServicePointManager.maxServicePoints)
					{
						throw new InvalidOperationException("maximum number of service points reached");
					}
					int connectionLimit = ServicePointManager.defaultConnectionLimit;
					servicePoint = new ServicePoint(key, address, connectionLimit, ServicePointManager.maxServicePointIdleTime);
					servicePoint.Expect100Continue = ServicePointManager.expectContinue;
					servicePoint.UseNagleAlgorithm = ServicePointManager.useNagle;
					servicePoint.UsesProxy = flag;
					servicePoint.UseConnect = flag2;
					servicePoint.SetTcpKeepAlive(ServicePointManager.tcp_keepalive, ServicePointManager.tcp_keepalive_time, ServicePointManager.tcp_keepalive_interval);
					result = ServicePointManager.servicePoints.GetOrAdd(key, servicePoint);
				}
			}
			return result;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0003FD7C File Offset: 0x0003DF7C
		internal static void RemoveServicePoint(ServicePoint sp)
		{
			ServicePoint servicePoint;
			ServicePointManager.servicePoints.TryRemove(sp.Key, out servicePoint);
		}

		// Token: 0x040008E6 RID: 2278
		private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints = new ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint>();

		// Token: 0x040008E7 RID: 2279
		private static ICertificatePolicy policy;

		// Token: 0x040008E8 RID: 2280
		private static int defaultConnectionLimit = 10;

		// Token: 0x040008E9 RID: 2281
		private static int maxServicePointIdleTime = 100000;

		// Token: 0x040008EA RID: 2282
		private static int maxServicePoints = 0;

		// Token: 0x040008EB RID: 2283
		private static int dnsRefreshTimeout = 120000;

		// Token: 0x040008EC RID: 2284
		private static bool _checkCRL = false;

		// Token: 0x040008ED RID: 2285
		private static SecurityProtocolType _securityProtocol = SecurityProtocolType.SystemDefault;

		// Token: 0x040008EE RID: 2286
		private static bool expectContinue = true;

		// Token: 0x040008EF RID: 2287
		private static bool useNagle;

		// Token: 0x040008F0 RID: 2288
		private static ServerCertValidationCallback server_cert_cb;

		// Token: 0x040008F1 RID: 2289
		private static bool tcp_keepalive;

		// Token: 0x040008F2 RID: 2290
		private static int tcp_keepalive_time;

		// Token: 0x040008F3 RID: 2291
		private static int tcp_keepalive_interval;

		// Token: 0x020001BF RID: 447
		internal class SPKey
		{
			// Token: 0x06000C2F RID: 3119 RVA: 0x0003FD9C File Offset: 0x0003DF9C
			public SPKey(Uri uri, Uri proxy, bool use_connect)
			{
				this.uri = uri;
				this.proxy = proxy;
				this.use_connect = use_connect;
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0003FDB9 File Offset: 0x0003DFB9
			public bool UsesProxy
			{
				get
				{
					return this.proxy != null;
				}
			}

			// Token: 0x06000C31 RID: 3121 RVA: 0x0003FDC8 File Offset: 0x0003DFC8
			public override int GetHashCode()
			{
				return ((23 * 31 + (this.use_connect ? 1 : 0)) * 31 + this.uri.GetHashCode()) * 31 + ((this.proxy != null) ? this.proxy.GetHashCode() : 0);
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x0003FE18 File Offset: 0x0003E018
			public override bool Equals(object obj)
			{
				ServicePointManager.SPKey spkey = obj as ServicePointManager.SPKey;
				return obj != null && this.uri.Equals(spkey.uri) && this.use_connect == spkey.use_connect && this.UsesProxy == spkey.UsesProxy && (!this.UsesProxy || this.proxy.Equals(spkey.proxy));
			}

			// Token: 0x040008F4 RID: 2292
			private Uri uri;

			// Token: 0x040008F5 RID: 2293
			private Uri proxy;

			// Token: 0x040008F6 RID: 2294
			private bool use_connect;
		}
	}
}
