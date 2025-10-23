using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace System.Net
{
	/// <summary>Contains HTTP proxy settings for the <see cref="T:System.Net.WebRequest" /> class.</summary>
	// Token: 0x02000192 RID: 402
	[Serializable]
	public class WebProxy : IWebProxy, ISerializable
	{
		/// <summary>Initializes an empty instance of the <see cref="T:System.Net.WebProxy" /> class.</summary>
		// Token: 0x06000AFA RID: 2810 RVA: 0x00039FB8 File Offset: 0x000381B8
		public WebProxy() : this(null, false, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified <see cref="T:System.Uri" /> instance, bypass setting, list of URIs to bypass, and credentials.</summary>
		/// <param name="Address">A <see cref="T:System.Uri" /> instance that contains the address of the proxy server. </param>
		/// <param name="BypassOnLocal">
		///       <see langword="true" /> to bypass the proxy for local addresses; otherwise, <see langword="false" />. </param>
		/// <param name="BypassList">An array of regular expression strings that contains the URIs of the servers to bypass. </param>
		/// <param name="Credentials">An <see cref="T:System.Net.ICredentials" /> instance to submit to the proxy server for authentication. </param>
		// Token: 0x06000AFB RID: 2811 RVA: 0x00039FC4 File Offset: 0x000381C4
		public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
			this._ProxyAddress = Address;
			this._BypassOnLocal = BypassOnLocal;
			if (BypassList != null)
			{
				this._BypassList = new ArrayList(BypassList);
				this.UpdateRegExList(true);
			}
			this._Credentials = Credentials;
			this.m_EnableAutoproxy = true;
		}

		/// <summary>Gets or sets the credentials to submit to the proxy server for authentication.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> instance that contains the credentials to submit to the proxy server for authentication.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property when the <see cref="P:System.Net.WebProxy.UseDefaultCredentials" />  property was set to <see langword="true" />. </exception>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00039FFF File Offset: 0x000381FF
		public ICredentials Credentials
		{
			get
			{
				return this._Credentials;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether the <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
		/// <returns>
		///     <see langword="true" /> if the default credentials are used; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property when the <see cref="P:System.Net.WebProxy.Credentials" /> property contains credentials other than the default credentials. For more information, see the Remarks section.</exception>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0003A007 File Offset: 0x00038207
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x0003A019 File Offset: 0x00038219
		public bool UseDefaultCredentials
		{
			get
			{
				return this.Credentials is SystemNetworkCredential;
			}
			set
			{
				this._Credentials = (value ? CredentialCache.DefaultCredentials : null);
			}
		}

		/// <summary>Returns the proxied URI for a request.</summary>
		/// <param name="destination">The <see cref="T:System.Uri" /> instance of the requested Internet resource. </param>
		/// <returns>The <see cref="T:System.Uri" /> instance of the Internet resource, if the resource is on the bypass list; otherwise, the <see cref="T:System.Uri" /> instance of the proxy.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="destination" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06000AFF RID: 2815 RVA: 0x0003A02C File Offset: 0x0003822C
		public Uri GetProxy(Uri destination)
		{
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			Uri result;
			if (this.GetProxyAuto(destination, out result))
			{
				return result;
			}
			if (this.IsBypassedManual(destination))
			{
				return destination;
			}
			Hashtable proxyHostAddresses = this._ProxyHostAddresses;
			Uri uri = (proxyHostAddresses != null) ? (proxyHostAddresses[destination.Scheme] as Uri) : this._ProxyAddress;
			if (!(uri != null))
			{
				return destination;
			}
			return uri;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003A098 File Offset: 0x00038298
		private void UpdateRegExList(bool canThrow)
		{
			Regex[] array = null;
			ArrayList bypassList = this._BypassList;
			try
			{
				if (bypassList != null && bypassList.Count > 0)
				{
					array = new Regex[bypassList.Count];
					for (int i = 0; i < bypassList.Count; i++)
					{
						array[i] = new Regex((string)bypassList[i], RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
					}
				}
			}
			catch
			{
				if (!canThrow)
				{
					this._RegExBypassList = null;
					return;
				}
				throw;
			}
			this._RegExBypassList = array;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003A118 File Offset: 0x00038318
		private bool IsMatchInBypassList(Uri input)
		{
			this.UpdateRegExList(false);
			if (this._RegExBypassList == null)
			{
				return false;
			}
			string input2 = input.Scheme + "://" + input.Host + ((!input.IsDefaultPort) ? (":" + input.Port.ToString()) : "");
			for (int i = 0; i < this._BypassList.Count; i++)
			{
				if (this._RegExBypassList[i].IsMatch(input2))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003A1A0 File Offset: 0x000383A0
		private bool IsLocal(Uri host)
		{
			string host2 = host.Host;
			IPAddress ipaddress;
			if (IPAddress.TryParse(host2, out ipaddress))
			{
				return IPAddress.IsLoopback(ipaddress) || NclUtilities.IsAddressLocal(ipaddress);
			}
			int num = host2.IndexOf('.');
			if (num == -1)
			{
				return true;
			}
			string text = "." + IPGlobalProperties.InternalGetIPGlobalProperties().DomainName;
			return text != null && text.Length == host2.Length - num && string.Compare(text, 0, host2, num, text.Length, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003A21C File Offset: 0x0003841C
		private bool IsLocalInProxyHash(Uri host)
		{
			Hashtable proxyHostAddresses = this._ProxyHostAddresses;
			return proxyHostAddresses != null && (Uri)proxyHostAddresses[host.Scheme] == null;
		}

		/// <summary>Indicates whether to use the proxy server for the specified host.</summary>
		/// <param name="host">The <see cref="T:System.Uri" /> instance of the host to check for proxy use. </param>
		/// <returns>
		///     <see langword="true" /> if the proxy server should not be used for <paramref name="host" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06000B04 RID: 2820 RVA: 0x0003A250 File Offset: 0x00038450
		public bool IsBypassed(Uri host)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			bool result;
			if (this.IsBypassedAuto(host, out result))
			{
				return result;
			}
			return this.IsBypassedManual(host);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003A288 File Offset: 0x00038488
		private bool IsBypassedManual(Uri host)
		{
			return host.IsLoopback || (this._ProxyAddress == null && this._ProxyHostAddresses == null) || (this._BypassOnLocal && this.IsLocal(host)) || this.IsMatchInBypassList(host) || this.IsLocalInProxyHash(host);
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Net.WebProxy" /> class using previously serialized content.</summary>
		/// <param name="serializationInfo">The serialization data. </param>
		/// <param name="streamingContext">The context for the serialized data. </param>
		// Token: 0x06000B06 RID: 2822 RVA: 0x0003A2D8 File Offset: 0x000384D8
		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			bool flag = false;
			try
			{
				flag = serializationInfo.GetBoolean("_UseRegistry");
			}
			catch
			{
			}
			if (flag)
			{
				this.UnsafeUpdateFromRegistry();
				return;
			}
			this._ProxyAddress = (Uri)serializationInfo.GetValue("_ProxyAddress", typeof(Uri));
			this._BypassOnLocal = serializationInfo.GetBoolean("_BypassOnLocal");
			this._BypassList = (ArrayList)serializationInfo.GetValue("_BypassList", typeof(ArrayList));
			try
			{
				this.UseDefaultCredentials = serializationInfo.GetBoolean("_UseDefaultCredentials");
			}
			catch
			{
			}
		}

		/// <summary>Creates the serialization data and context that are used by the system to serialize a <see cref="T:System.Net.WebProxy" /> object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that indicates the destination for this serialization. </param>
		// Token: 0x06000B07 RID: 2823 RVA: 0x0003A38C File Offset: 0x0003858C
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06000B08 RID: 2824 RVA: 0x0003A398 File Offset: 0x00038598
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("_BypassOnLocal", this._BypassOnLocal);
			serializationInfo.AddValue("_ProxyAddress", this._ProxyAddress);
			serializationInfo.AddValue("_BypassList", this._BypassList);
			serializationInfo.AddValue("_UseDefaultCredentials", this.UseDefaultCredentials);
			if (this._UseRegistry)
			{
				serializationInfo.AddValue("_UseRegistry", true);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0003A3FD File Offset: 0x000385FD
		internal AutoWebProxyScriptEngine ScriptEngine
		{
			get
			{
				return this.m_ScriptEngine;
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0003A408 File Offset: 0x00038608
		public static IWebProxy CreateDefaultProxy()
		{
			IWebProxy defaultProxy = AndroidPlatform.GetDefaultProxy();
			if (defaultProxy != null)
			{
				return defaultProxy;
			}
			return new WebProxy(true);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003A426 File Offset: 0x00038626
		internal WebProxy(bool enableAutoproxy)
		{
			this.m_EnableAutoproxy = enableAutoproxy;
			this.UnsafeUpdateFromRegistry();
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0003A43B File Offset: 0x0003863B
		internal void UnsafeUpdateFromRegistry()
		{
			this._UseRegistry = true;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0003A444 File Offset: 0x00038644
		private bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			proxyUri = null;
			if (this.ScriptEngine == null)
			{
				return false;
			}
			IList<string> list = null;
			if (!this.ScriptEngine.GetProxies(destination, out list))
			{
				return false;
			}
			if (list.Count > 0)
			{
				if (WebProxy.AreAllBypassed(list, true))
				{
					proxyUri = destination;
				}
				else
				{
					proxyUri = WebProxy.ProxyUri(list[0]);
				}
			}
			return true;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0003A498 File Offset: 0x00038698
		private bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			isBypassed = true;
			if (this.ScriptEngine == null)
			{
				return false;
			}
			IList<string> list;
			if (!this.ScriptEngine.GetProxies(destination, out list))
			{
				return false;
			}
			if (list.Count == 0)
			{
				isBypassed = false;
			}
			else
			{
				isBypassed = WebProxy.AreAllBypassed(list, true);
			}
			return true;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0003A4DC File Offset: 0x000386DC
		private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			bool flag = true;
			foreach (string value in proxies)
			{
				flag = string.IsNullOrEmpty(value);
				if (checkFirstOnly)
				{
					break;
				}
				if (!flag)
				{
					break;
				}
			}
			return flag;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0003A530 File Offset: 0x00038730
		private static Uri ProxyUri(string proxyName)
		{
			if (proxyName != null && proxyName.Length != 0)
			{
				return new Uri("http://" + proxyName);
			}
			return null;
		}

		// Token: 0x040007F8 RID: 2040
		private bool _UseRegistry;

		// Token: 0x040007F9 RID: 2041
		private bool _BypassOnLocal;

		// Token: 0x040007FA RID: 2042
		private bool m_EnableAutoproxy;

		// Token: 0x040007FB RID: 2043
		private Uri _ProxyAddress;

		// Token: 0x040007FC RID: 2044
		private ArrayList _BypassList;

		// Token: 0x040007FD RID: 2045
		private ICredentials _Credentials;

		// Token: 0x040007FE RID: 2046
		private Regex[] _RegExBypassList;

		// Token: 0x040007FF RID: 2047
		private Hashtable _ProxyHostAddresses;

		// Token: 0x04000800 RID: 2048
		private AutoWebProxyScriptEngine m_ScriptEngine;
	}
}
