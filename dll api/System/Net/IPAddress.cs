using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net
{
	/// <summary>Provides an Internet Protocol (IP) address.</summary>
	// Token: 0x02000114 RID: 276
	[Serializable]
	public class IPAddress
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x0002C2C0 File Offset: 0x0002A4C0
		private bool IsIPv4
		{
			get
			{
				return this._numbers == null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0002C2CB File Offset: 0x0002A4CB
		private bool IsIPv6
		{
			get
			{
				return this._numbers != null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0002C2D6 File Offset: 0x0002A4D6
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0002C2DE File Offset: 0x0002A4DE
		private uint PrivateAddress
		{
			get
			{
				return this._addressOrScopeId;
			}
			set
			{
				this._toString = null;
				this._hashCode = 0;
				this._addressOrScopeId = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0002C2D6 File Offset: 0x0002A4D6
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0002C2DE File Offset: 0x0002A4DE
		private uint PrivateScopeId
		{
			get
			{
				return this._addressOrScopeId;
			}
			set
			{
				this._toString = null;
				this._hashCode = 0;
				this._addressOrScopeId = value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as an <see cref="T:System.Int64" />.</summary>
		/// <param name="newAddress">The long value of the IP address. For example, the value 0x2414188f in big-endian format would be the IP address "143.24.20.36". </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="newAddress" /> &lt; 0 or 
		///         <paramref name="newAddress" /> &gt; 0x00000000FFFFFFFF </exception>
		// Token: 0x060007D5 RID: 2005 RVA: 0x0002C2F5 File Offset: 0x0002A4F5
		public IPAddress(long newAddress)
		{
			if (newAddress < 0L || newAddress > (long)((ulong)-1))
			{
				throw new ArgumentOutOfRangeException("newAddress");
			}
			this.PrivateAddress = (uint)newAddress;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as a <see cref="T:System.Byte" /> array and the specified scope identifier.</summary>
		/// <param name="address">The byte array value of the IP address. </param>
		/// <param name="scopeid">The long value of the scope identifier. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="address" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="address" /> contains a bad IP address. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="scopeid" /> &lt; 0 or 
		///         <paramref name="scopeid" /> &gt; 0x00000000FFFFFFFF </exception>
		// Token: 0x060007D6 RID: 2006 RVA: 0x0002C31A File Offset: 0x0002A51A
		public IPAddress(byte[] address, long scopeid) : this(new ReadOnlySpan<byte>(address ?? IPAddress.ThrowAddressNullException()), scopeid)
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0002C334 File Offset: 0x0002A534
		public unsafe IPAddress(ReadOnlySpan<byte> address, long scopeid)
		{
			if (address.Length != 16)
			{
				throw new ArgumentException("An invalid IP address was specified.", "address");
			}
			if (scopeid < 0L || scopeid > (long)((ulong)-1))
			{
				throw new ArgumentOutOfRangeException("scopeid");
			}
			this._numbers = new ushort[8];
			for (int i = 0; i < 8; i++)
			{
				this._numbers[i] = (ushort)((int)(*address[i * 2]) * 256 + (int)(*address[i * 2 + 1]));
			}
			this.PrivateScopeId = (uint)scopeid;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
		{
			ushort[] array = new ushort[8];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = numbers[i];
			}
			this._numbers = array;
			this.PrivateScopeId = scopeid;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002C400 File Offset: 0x0002A600
		private IPAddress(ushort[] numbers, uint scopeid)
		{
			this._numbers = numbers;
			this.PrivateScopeId = scopeid;
		}

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="ipString" /> was able to be parsed as an IP address; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007DA RID: 2010 RVA: 0x0002C416 File Offset: 0x0002A616
		public static bool TryParse(string ipString, out IPAddress address)
		{
			if (ipString == null)
			{
				address = null;
				return false;
			}
			address = IPAddressParser.Parse(ipString.AsSpan(), true);
			return address != null;
		}

		/// <summary>Converts an IP address string to an <see cref="T:System.Net.IPAddress" /> instance.</summary>
		/// <param name="ipString">A string that contains an IP address in dotted-quad notation for IPv4 and in colon-hexadecimal notation for IPv6. </param>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="ipString" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="ipString" /> is not a valid IP address. </exception>
		// Token: 0x060007DB RID: 2011 RVA: 0x0002C433 File Offset: 0x0002A633
		public static IPAddress Parse(string ipString)
		{
			if (ipString == null)
			{
				throw new ArgumentNullException("ipString");
			}
			return IPAddressParser.Parse(ipString.AsSpan(), false);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0002C450 File Offset: 0x0002A650
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
		{
			if (this.IsIPv6)
			{
				if (destination.Length < 16)
				{
					bytesWritten = 0;
					return false;
				}
				this.WriteIPv6Bytes(destination);
				bytesWritten = 16;
			}
			else
			{
				if (destination.Length < 4)
				{
					bytesWritten = 0;
					return false;
				}
				this.WriteIPv4Bytes(destination);
				bytesWritten = 4;
			}
			return true;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0002C49C File Offset: 0x0002A69C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteIPv6Bytes(Span<byte> destination)
		{
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				*destination[num++] = (byte)(this._numbers[i] >> 8 & 255);
				*destination[num++] = (byte)(this._numbers[i] & 255);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0002C4F4 File Offset: 0x0002A6F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteIPv4Bytes(Span<byte> destination)
		{
			uint privateAddress = this.PrivateAddress;
			*destination[0] = (byte)privateAddress;
			*destination[1] = (byte)(privateAddress >> 8);
			*destination[2] = (byte)(privateAddress >> 16);
			*destination[3] = (byte)(privateAddress >> 24);
		}

		/// <summary>Provides a copy of the <see cref="T:System.Net.IPAddress" /> as an array of bytes.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array.</returns>
		// Token: 0x060007DF RID: 2015 RVA: 0x0002C53C File Offset: 0x0002A73C
		public byte[] GetAddressBytes()
		{
			if (this.IsIPv6)
			{
				byte[] array = new byte[16];
				this.WriteIPv6Bytes(array);
				return array;
			}
			byte[] array2 = new byte[4];
			this.WriteIPv4Bytes(array2);
			return array2;
		}

		/// <summary>Gets the address family of the IP address.</summary>
		/// <returns>Returns <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> for IPv4 or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> for IPv6.</returns>
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0002C57B File Offset: 0x0002A77B
		public AddressFamily AddressFamily
		{
			get
			{
				if (!this.IsIPv4)
				{
					return AddressFamily.InterNetworkV6;
				}
				return AddressFamily.InterNetwork;
			}
		}

		/// <summary>Gets or sets the IPv6 address scope identifier.</summary>
		/// <returns>A long integer that specifies the scope of the address.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///         <see langword="AddressFamily" /> = <see langword="InterNetwork" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="scopeId" /> &lt; 0- or -
		///             <paramref name="scopeId" /> &gt; 0x00000000FFFFFFFF  </exception>
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0002C589 File Offset: 0x0002A789
		public long ScopeId
		{
			get
			{
				if (this.IsIPv4)
				{
					throw new SocketException(SocketError.OperationNotSupported);
				}
				return (long)((ulong)this.PrivateScopeId);
			}
		}

		/// <summary>Converts an Internet address to its standard notation.</summary>
		/// <returns>A string that contains the IP address in either IPv4 dotted-quad or in IPv6 colon-hexadecimal notation.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">The address family is <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> and the address is bad. </exception>
		// Token: 0x060007E2 RID: 2018 RVA: 0x0002C5A5 File Offset: 0x0002A7A5
		public override string ToString()
		{
			if (this._toString == null)
			{
				this._toString = (this.IsIPv4 ? IPAddressParser.IPv4AddressToString(this.PrivateAddress) : IPAddressParser.IPv6AddressToString(this._numbers, this.PrivateScopeId));
			}
			return this._toString;
		}

		/// <summary>Indicates whether the specified IP address is the loopback address.</summary>
		/// <param name="address">An IP address. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="address" /> is the loopback address; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007E3 RID: 2019 RVA: 0x0002C5E4 File Offset: 0x0002A7E4
		public static bool IsLoopback(IPAddress address)
		{
			if (address == null)
			{
				IPAddress.ThrowAddressNullException();
			}
			if (address.IsIPv6)
			{
				return address.Equals(IPAddress.IPv6Loopback);
			}
			return ((ulong)address.PrivateAddress & 255UL) == ((ulong)IPAddress.Loopback.PrivateAddress & 255UL);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002C630 File Offset: 0x0002A830
		internal bool Equals(object comparandObj, bool compareScopeId)
		{
			IPAddress ipaddress = comparandObj as IPAddress;
			if (ipaddress == null)
			{
				return false;
			}
			if (this.AddressFamily != ipaddress.AddressFamily)
			{
				return false;
			}
			if (this.IsIPv6)
			{
				for (int i = 0; i < 8; i++)
				{
					if (ipaddress._numbers[i] != this._numbers[i])
					{
						return false;
					}
				}
				return ipaddress.PrivateScopeId == this.PrivateScopeId || !compareScopeId;
			}
			return ipaddress.PrivateAddress == this.PrivateAddress;
		}

		/// <summary>Compares two IP addresses.</summary>
		/// <param name="comparand">An <see cref="T:System.Net.IPAddress" /> instance to compare to the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if the two addresses are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007E5 RID: 2021 RVA: 0x0002C6A4 File Offset: 0x0002A8A4
		public override bool Equals(object comparand)
		{
			return this.Equals(comparand, true);
		}

		/// <summary>Returns a hash value for an IP address.</summary>
		/// <returns>An integer hash value.</returns>
		// Token: 0x060007E6 RID: 2022 RVA: 0x0002C6B0 File Offset: 0x0002A8B0
		public unsafe override int GetHashCode()
		{
			if (this._hashCode != 0)
			{
				return this._hashCode;
			}
			int hashCode;
			if (this.IsIPv6)
			{
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
				MemoryMarshal.AsBytes<ushort>(new ReadOnlySpan<ushort>(this._numbers)).CopyTo(span);
				BitConverter.TryWriteBytes(span.Slice(16), this._addressOrScopeId);
				hashCode = Marvin.ComputeHash32(span, Marvin.DefaultSeed);
			}
			else
			{
				hashCode = Marvin.ComputeHash32(MemoryMarshal.AsBytes<uint>(MemoryMarshal.CreateReadOnlySpan<uint>(ref this._addressOrScopeId, 1)), Marvin.DefaultSeed);
			}
			this._hashCode = hashCode;
			return this._hashCode;
		}

		/// <summary>Maps the <see cref="T:System.Net.IPAddress" /> object to an IPv6 address.</summary>
		/// <returns>Returns <see cref="T:System.Net.IPAddress" />.An IPv6 address.</returns>
		// Token: 0x060007E7 RID: 2023 RVA: 0x0002C74C File Offset: 0x0002A94C
		public IPAddress MapToIPv6()
		{
			if (this.IsIPv6)
			{
				return this;
			}
			uint privateAddress = this.PrivateAddress;
			return new IPAddress(new ushort[]
			{
				0,
				0,
				0,
				0,
				0,
				ushort.MaxValue,
				(ushort)((privateAddress & 65280U) >> 8 | (privateAddress & 255U) << 8),
				(ushort)((privateAddress & 4278190080U) >> 24 | (privateAddress & 16711680U) >> 8)
			}, 0U);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0002C7AD File Offset: 0x0002A9AD
		private static byte[] ThrowAddressNullException()
		{
			throw new ArgumentNullException("address");
		}

		/// <summary>Provides an IP address that indicates that the server must listen for client activity on all network interfaces. This field is read-only.</summary>
		// Token: 0x0400056D RID: 1389
		public static readonly IPAddress Any = new IPAddress.ReadOnlyIPAddress(0L);

		/// <summary>Provides the IP loopback address. This field is read-only.</summary>
		// Token: 0x0400056E RID: 1390
		public static readonly IPAddress Loopback = new IPAddress.ReadOnlyIPAddress(16777343L);

		/// <summary>Provides the IP broadcast address. This field is read-only.</summary>
		// Token: 0x0400056F RID: 1391
		public static readonly IPAddress Broadcast = new IPAddress.ReadOnlyIPAddress((long)((ulong)-1));

		/// <summary>Provides an IP address that indicates that no network interface should be used. This field is read-only.</summary>
		// Token: 0x04000570 RID: 1392
		public static readonly IPAddress None = IPAddress.Broadcast;

		/// <summary>The <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> method uses the <see cref="F:System.Net.IPAddress.IPv6Any" /> field to indicate that a <see cref="T:System.Net.Sockets.Socket" /> must listen for client activity on all network interfaces.</summary>
		// Token: 0x04000571 RID: 1393
		public static readonly IPAddress IPv6Any = new IPAddress(new byte[16], 0L);

		/// <summary>Provides the IP loopback address. This property is read-only.</summary>
		// Token: 0x04000572 RID: 1394
		public static readonly IPAddress IPv6Loopback = new IPAddress(new byte[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1
		}, 0L);

		/// <summary>Provides an IP address that indicates that no network interface should be used. This property is read-only.</summary>
		// Token: 0x04000573 RID: 1395
		public static readonly IPAddress IPv6None = new IPAddress(new byte[16], 0L);

		// Token: 0x04000574 RID: 1396
		private uint _addressOrScopeId;

		// Token: 0x04000575 RID: 1397
		private readonly ushort[] _numbers;

		// Token: 0x04000576 RID: 1398
		private string _toString;

		// Token: 0x04000577 RID: 1399
		private int _hashCode;

		// Token: 0x02000115 RID: 277
		private sealed class ReadOnlyIPAddress : IPAddress
		{
			// Token: 0x060007EA RID: 2026 RVA: 0x0002C839 File Offset: 0x0002AA39
			public ReadOnlyIPAddress(long newAddress) : base(newAddress)
			{
			}
		}
	}
}
