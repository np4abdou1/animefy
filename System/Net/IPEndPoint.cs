using System;
using System.Globalization;
using System.Net.Sockets;

namespace System.Net
{
	/// <summary>Represents a network endpoint as an IP address and a port number.</summary>
	// Token: 0x02000117 RID: 279
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		/// <summary>Gets the Internet Protocol (IP) address family.</summary>
		/// <returns>Returns <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</returns>
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002CC62 File Offset: 0x0002AE62
		public override AddressFamily AddressFamily
		{
			get
			{
				return this._address.AddressFamily;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPEndPoint" /> class with the specified address and port number.</summary>
		/// <param name="address">An <see cref="T:System.Net.IPAddress" />. </param>
		/// <param name="port">The port number associated with the <paramref name="address" />, or 0 to specify any available port. <paramref name="port" /> is in host order.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="address" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="port" /> is less than <see cref="F:System.Net.IPEndPoint.MinPort" />.-or- 
		///         <paramref name="port" /> is greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />.-or- 
		///         <paramref name="address" /> is less than 0 or greater than 0x00000000FFFFFFFF. </exception>
		// Token: 0x060007F9 RID: 2041 RVA: 0x0002CC6F File Offset: 0x0002AE6F
		public IPEndPoint(IPAddress address, int port)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (!TcpValidationHelpers.ValidatePortNumber(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this._port = port;
			this._address = address;
		}

		/// <summary>Gets or sets the IP address of the endpoint.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance containing the IP address of the endpoint.</returns>
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002CCA6 File Offset: 0x0002AEA6
		public IPAddress Address
		{
			get
			{
				return this._address;
			}
		}

		/// <summary>Gets or sets the port number of the endpoint.</summary>
		/// <returns>An integer value in the range <see cref="F:System.Net.IPEndPoint.MinPort" /> to <see cref="F:System.Net.IPEndPoint.MaxPort" /> indicating the port number of the endpoint.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value that was specified for a set operation is less than <see cref="F:System.Net.IPEndPoint.MinPort" /> or greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0002CCAE File Offset: 0x0002AEAE
		public int Port
		{
			get
			{
				return this._port;
			}
		}

		/// <summary>Returns the IP address and port number of the specified endpoint.</summary>
		/// <returns>A string containing the IP address and the port number of the specified endpoint (for example, 192.168.1.2:80).</returns>
		// Token: 0x060007FC RID: 2044 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		public override string ToString()
		{
			return string.Format((this._address.AddressFamily == AddressFamily.InterNetworkV6) ? "[{0}]:{1}" : "{0}:{1}", this._address.ToString(), this.Port.ToString(NumberFormatInfo.InvariantInfo));
		}

		/// <summary>Serializes endpoint information into a <see cref="T:System.Net.SocketAddress" /> instance.</summary>
		/// <returns>A <see cref="T:System.Net.SocketAddress" /> instance containing the socket address for the endpoint.</returns>
		// Token: 0x060007FD RID: 2045 RVA: 0x0002CD03 File Offset: 0x0002AF03
		public override SocketAddress Serialize()
		{
			return new SocketAddress(this.Address, this.Port);
		}

		/// <summary>Creates an endpoint from a socket address.</summary>
		/// <param name="socketAddress">The <see cref="T:System.Net.SocketAddress" /> to use for the endpoint. </param>
		/// <returns>An <see cref="T:System.Net.EndPoint" /> instance using the specified socket address.</returns>
		/// <exception cref="T:System.ArgumentException">The AddressFamily of <paramref name="socketAddress" /> is not equal to the AddressFamily of the current instance.-or- 
		///         <paramref name="socketAddress" />.Size &lt; 8. </exception>
		// Token: 0x060007FE RID: 2046 RVA: 0x0002CD18 File Offset: 0x0002AF18
		public override EndPoint Create(SocketAddress socketAddress)
		{
			if (socketAddress.Family != this.AddressFamily)
			{
				throw new ArgumentException(SR.Format("The AddressFamily {0} is not valid for the {1} end point, use {2} instead.", socketAddress.Family.ToString(), base.GetType().FullName, this.AddressFamily.ToString()), "socketAddress");
			}
			if (socketAddress.Size < 8)
			{
				throw new ArgumentException(SR.Format("The supplied {0} is an invalid size for the {1} end point.", socketAddress.GetType().FullName, base.GetType().FullName), "socketAddress");
			}
			return socketAddress.GetIPEndPoint();
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary>
		/// <param name="comparand">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />.</param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007FF RID: 2047 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
		public override bool Equals(object comparand)
		{
			IPEndPoint ipendPoint = comparand as IPEndPoint;
			return ipendPoint != null && ipendPoint._address.Equals(this._address) && ipendPoint._port == this._port;
		}

		/// <summary>Returns a hash value for a <see cref="T:System.Net.IPEndPoint" /> instance.</summary>
		/// <returns>An integer hash value.</returns>
		// Token: 0x06000800 RID: 2048 RVA: 0x0002CDF2 File Offset: 0x0002AFF2
		public override int GetHashCode()
		{
			return this._address.GetHashCode() ^ this._port;
		}

		// Token: 0x04000578 RID: 1400
		private IPAddress _address;

		// Token: 0x04000579 RID: 1401
		private int _port;

		// Token: 0x0400057A RID: 1402
		internal static IPEndPoint Any = new IPEndPoint(IPAddress.Any, 0);

		// Token: 0x0400057B RID: 1403
		internal static IPEndPoint IPv6Any = new IPEndPoint(IPAddress.IPv6Any, 0);
	}
}
