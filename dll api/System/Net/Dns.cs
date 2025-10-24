using System;
using System.Collections;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;

namespace System.Net
{
	/// <summary>Provides simple domain name resolution functionality.</summary>
	// Token: 0x020001A7 RID: 423
	public static class Dns
	{
		/// <summary>Asynchronously returns the Internet Protocol (IP) addresses for the specified host.</summary>
		/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
		/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete. </param>
		/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the <paramref name="requestCallback" /> delegate when the operation is complete.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> instance that references the asynchronous request.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="hostNameOrAddress" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> is greater than 255 characters. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hostNameOrAddress" /> is an invalid IP address.</exception>
		// Token: 0x06000B57 RID: 2903 RVA: 0x0003B99C File Offset: 0x00039B9C
		public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostName");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			return new Dns.GetHostAddressesCallback(Dns.GetHostAddresses).BeginInvoke(hostNameOrAddress, requestCallback, state);
		}

		/// <summary>Ends an asynchronous request for DNS information.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to the <see cref="M:System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)" /> method.</param>
		/// <returns>An array of type <see cref="T:System.Net.IPAddress" /> that holds the IP addresses for the host specified by the <paramref name="hostNameOrAddress" /> parameter of <see cref="M:System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)" />.</returns>
		// Token: 0x06000B58 RID: 2904 RVA: 0x0003B9F5 File Offset: 0x00039BF5
		public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			return ((Dns.GetHostAddressesCallback)((AsyncResult)asyncResult).AsyncDelegate).EndInvoke(asyncResult);
		}

		// Token: 0x06000B59 RID: 2905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06000B5A RID: 2906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06000B5B RID: 2907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHostName_icall(out string h_name);

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003BA1B File Offset: 0x00039C1B
		private static void Error_11001(string hostName)
		{
			throw new SocketException(11001, string.Format("Could not resolve host '{0}'", hostName));
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0003BA34 File Offset: 0x00039C34
		private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist)
		{
			IPHostEntry iphostEntry = new IPHostEntry();
			ArrayList arrayList = new ArrayList();
			iphostEntry.HostName = h_name;
			iphostEntry.Aliases = h_aliases;
			for (int i = 0; i < h_addrlist.Length; i++)
			{
				try
				{
					IPAddress ipaddress = IPAddress.Parse(h_addrlist[i]);
					if ((Socket.OSSupportsIPv6 && ipaddress.AddressFamily == AddressFamily.InterNetworkV6) || (Socket.OSSupportsIPv4 && ipaddress.AddressFamily == AddressFamily.InterNetwork))
					{
						arrayList.Add(ipaddress);
					}
				}
				catch (ArgumentNullException)
				{
				}
			}
			if (arrayList.Count == 0)
			{
				Dns.Error_11001(originalHostName);
			}
			iphostEntry.AddressList = (arrayList.ToArray(typeof(IPAddress)) as IPAddress[]);
			return iphostEntry;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0003BADC File Offset: 0x00039CDC
		private static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			if (address.Equals("0.0.0.0"))
			{
				address = "127.0.0.1";
				parse = false;
			}
			if (parse)
			{
				IPAddress.Parse(address);
			}
			string h_name;
			string[] h_aliases;
			string[] h_addrlist;
			if (!Dns.GetHostByAddr_icall(address, out h_name, out h_aliases, out h_addrlist, Socket.FamilyHint))
			{
				Dns.Error_11001(address);
			}
			return Dns.hostent_to_IPHostEntry(address, h_name, h_aliases, h_addrlist);
		}

		/// <summary>Resolves a host name or IP address to an <see cref="T:System.Net.IPHostEntry" /> instance.</summary>
		/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
		/// <returns>An <see cref="T:System.Net.IPHostEntry" /> instance that contains address information about the host specified in <paramref name="hostNameOrAddress" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="hostNameOrAddress" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> parameter is greater than 255 characters. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error was encountered when resolving the <paramref name="hostNameOrAddress" /> parameter. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="hostNameOrAddress" /> parameter is an invalid IP address. </exception>
		// Token: 0x06000B5F RID: 2911 RVA: 0x0003BB2C File Offset: 0x00039D2C
		public static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostNameOrAddress");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			IPAddress address;
			if (hostNameOrAddress.Length > 0 && IPAddress.TryParse(hostNameOrAddress, out address))
			{
				return Dns.GetHostEntry(address);
			}
			return Dns.GetHostByName(hostNameOrAddress);
		}

		/// <summary>Resolves an IP address to an <see cref="T:System.Net.IPHostEntry" /> instance.</summary>
		/// <param name="address">An IP address.</param>
		/// <returns>An <see cref="T:System.Net.IPHostEntry" /> instance that contains address information about the host specified in <paramref name="address" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="address" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="address" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="address" /> is an invalid IP address.</exception>
		// Token: 0x06000B60 RID: 2912 RVA: 0x0003BB91 File Offset: 0x00039D91
		public static IPHostEntry GetHostEntry(IPAddress address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return Dns.GetHostByAddressFromString(address.ToString(), false);
		}

		/// <summary>Returns the Internet Protocol (IP) addresses for the specified host.</summary>
		/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
		/// <returns>An array of type <see cref="T:System.Net.IPAddress" /> that holds the IP addresses for the host that is specified by the <paramref name="hostNameOrAddress" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="hostNameOrAddress" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> is greater than 255 characters. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hostNameOrAddress" /> is an invalid IP address.</exception>
		// Token: 0x06000B61 RID: 2913 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostNameOrAddress");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			IPAddress ipaddress;
			if (hostNameOrAddress.Length > 0 && IPAddress.TryParse(hostNameOrAddress, out ipaddress))
			{
				return new IPAddress[]
				{
					ipaddress
				};
			}
			return Dns.GetHostEntry(hostNameOrAddress).AddressList;
		}

		/// <summary>Gets the DNS information for the specified DNS host name.</summary>
		/// <param name="hostName">The DNS name of the host. </param>
		/// <returns>An <see cref="T:System.Net.IPHostEntry" /> object that contains host information for the address specified in <paramref name="hostName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="hostName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostName" /> is greater than 255 characters. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostName" />. </exception>
		// Token: 0x06000B62 RID: 2914 RVA: 0x0003BC20 File Offset: 0x00039E20
		public static IPHostEntry GetHostByName(string hostName)
		{
			if (hostName == null)
			{
				throw new ArgumentNullException("hostName");
			}
			string h_name;
			string[] h_aliases;
			string[] h_addrlist;
			if (!Dns.GetHostByName_icall(hostName, out h_name, out h_aliases, out h_addrlist, Socket.FamilyHint))
			{
				Dns.Error_11001(hostName);
			}
			return Dns.hostent_to_IPHostEntry(hostName, h_name, h_aliases, h_addrlist);
		}

		/// <summary>Gets the host name of the local computer.</summary>
		/// <returns>A string that contains the DNS host name of the local computer.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving the local host name. </exception>
		// Token: 0x06000B63 RID: 2915 RVA: 0x0003BC60 File Offset: 0x00039E60
		public static string GetHostName()
		{
			string text;
			if (!Dns.GetHostName_icall(out text))
			{
				Dns.Error_11001(text);
			}
			return text;
		}

		/// <summary>Returns the Internet Protocol (IP) addresses for the specified host as an asynchronous operation.</summary>
		/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task`1.Result" /> property on the task object returns an array of type <see cref="T:System.Net.IPAddress" /> that holds the IP addresses for the host that is specified by the <paramref name="hostNameOrAddress" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="hostNameOrAddress" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> is greater than 255 characters. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hostNameOrAddress" /> is an invalid IP address.</exception>
		// Token: 0x06000B64 RID: 2916 RVA: 0x0003BC7D File Offset: 0x00039E7D
		public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
		{
			return Task<IPAddress[]>.Factory.FromAsync<string>(new Func<string, AsyncCallback, object, IAsyncResult>(Dns.BeginGetHostAddresses), new Func<IAsyncResult, IPAddress[]>(Dns.EndGetHostAddresses), hostNameOrAddress, null);
		}

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000B66 RID: 2918
		private delegate IPAddress[] GetHostAddressesCallback(string hostName);
	}
}
