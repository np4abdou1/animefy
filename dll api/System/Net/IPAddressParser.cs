using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net
{
	// Token: 0x02000116 RID: 278
	internal class IPAddressParser
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x0002C844 File Offset: 0x0002AA44
		internal unsafe static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
		{
			long newAddress;
			if (ipSpan.Contains(':'))
			{
				ushort* ptr = stackalloc ushort[(UIntPtr)16];
				new Span<ushort>((void*)ptr, 8).Clear();
				uint scopeid;
				if (IPAddressParser.Ipv6StringToAddress(ipSpan, ptr, 8, out scopeid))
				{
					return new IPAddress(ptr, 8, scopeid);
				}
			}
			else if (IPAddressParser.Ipv4StringToAddress(ipSpan, out newAddress))
			{
				return new IPAddress(newAddress);
			}
			if (tryParse)
			{
				return null;
			}
			throw new FormatException("An invalid IP address was specified.", new SocketException(SocketError.InvalidArgument));
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		internal unsafe static string IPv4AddressToString(uint address)
		{
			char* ptr = stackalloc char[(UIntPtr)30];
			int length = IPAddressParser.IPv4AddressToStringHelper(address, ptr);
			return new string(ptr, 0, length);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0002C8D4 File Offset: 0x0002AAD4
		internal unsafe static void IPv4AddressToString(uint address, StringBuilder destination)
		{
			char* ptr = stackalloc char[(UIntPtr)30];
			int valueCount = IPAddressParser.IPv4AddressToStringHelper(address, ptr);
			destination.Append(ptr, valueCount);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		private unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
		{
			int result = 0;
			IPAddressParser.FormatIPv4AddressNumber((int)(address & 255U), addressString, ref result);
			addressString[result++] = '.';
			IPAddressParser.FormatIPv4AddressNumber((int)(address >> 8 & 255U), addressString, ref result);
			addressString[result++] = '.';
			IPAddressParser.FormatIPv4AddressNumber((int)(address >> 16 & 255U), addressString, ref result);
			addressString[result++] = '.';
			IPAddressParser.FormatIPv4AddressNumber((int)(address >> 24 & 255U), addressString, ref result);
			return result;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0002C973 File Offset: 0x0002AB73
		internal static string IPv6AddressToString(ushort[] address, uint scopeId)
		{
			return StringBuilderCache.GetStringAndRelease(IPAddressParser.IPv6AddressToStringHelper(address, scopeId));
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002C984 File Offset: 0x0002AB84
		internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(65);
			if (IPv6AddressHelper.ShouldHaveIpv4Embedded(address))
			{
				IPAddressParser.AppendSections(address, 0, 6, stringBuilder);
				if (stringBuilder[stringBuilder.Length - 1] != ':')
				{
					stringBuilder.Append(':');
				}
				IPAddressParser.IPv4AddressToString(IPAddressParser.ExtractIPv4Address(address), stringBuilder);
			}
			else
			{
				IPAddressParser.AppendSections(address, 0, 8, stringBuilder);
			}
			if (scopeId != 0U)
			{
				stringBuilder.Append('%').Append(scopeId);
			}
			return stringBuilder;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
		private unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
		{
			offset += ((number > 99) ? 3 : ((number > 9) ? 2 : 1));
			int num = offset;
			do
			{
				int num2;
				number = Math.DivRem(number, 10, out num2);
				addressString[--num] = (char)(48 + num2);
			}
			while (number != 0);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0002CA3C File Offset: 0x0002AC3C
		public unsafe static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address)
		{
			int length = ipSpan.Length;
			long num;
			fixed (char* reference = MemoryMarshal.GetReference<char>(ipSpan))
			{
				num = IPv4AddressHelper.ParseNonCanonical(reference, 0, ref length, true);
			}
			if (num != -1L && length == ipSpan.Length)
			{
				address = (long)(((ulong)-16777216 & (ulong)num) >> 24 | (ulong)((16711680L & num) >> 8) | (ulong)((ulong)(65280L & num) << 8) | (ulong)((ulong)(255L & num) << 24));
				return true;
			}
			address = 0L;
			return false;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0002CAAC File Offset: 0x0002ACAC
		public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope)
		{
			int length = ipSpan.Length;
			bool flag;
			fixed (char* reference = MemoryMarshal.GetReference<char>(ipSpan))
			{
				flag = IPv6AddressHelper.IsValidStrict(reference, 0, ref length);
			}
			if (flag || length != ipSpan.Length)
			{
				string text = null;
				IPv6AddressHelper.Parse(ipSpan, numbers, 0, ref text);
				long num = 0L;
				if (!string.IsNullOrEmpty(text))
				{
					if (text.Length < 2)
					{
						scope = 0U;
						return false;
					}
					for (int i = 1; i < text.Length; i++)
					{
						char c = text[i];
						if (c < '0' || c > '9')
						{
							scope = 0U;
							return true;
						}
						num = num * 10L + (long)(c - '0');
						if (num > (long)((ulong)-1))
						{
							scope = 0U;
							return false;
						}
					}
				}
				scope = (uint)num;
				return true;
			}
			scope = 0U;
			return false;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0002CB58 File Offset: 0x0002AD58
		private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer)
		{
			ValueTuple<int, int> valueTuple = IPv6AddressHelper.FindCompressionRange(new ReadOnlySpan<ushort>(address, fromInclusive, toExclusive - fromInclusive));
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			bool flag = false;
			for (int i = fromInclusive; i < item; i++)
			{
				if (flag)
				{
					buffer.Append(':');
				}
				flag = true;
				IPAddressParser.AppendHex(address[i], buffer);
			}
			if (item >= 0)
			{
				buffer.Append("::");
				flag = false;
				fromInclusive = item2;
			}
			for (int j = fromInclusive; j < toExclusive; j++)
			{
				if (flag)
				{
					buffer.Append(':');
				}
				flag = true;
				IPAddressParser.AppendHex(address[j], buffer);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0002CBE4 File Offset: 0x0002ADE4
		private unsafe static void AppendHex(ushort value, StringBuilder buffer)
		{
			char* ptr = stackalloc char[(UIntPtr)8];
			int num = 4;
			do
			{
				int num2 = (int)(value % 16);
				value /= 16;
				ptr[(IntPtr)(--num) * 2] = ((num2 < 10) ? ((char)(48 + num2)) : ((char)(97 + (num2 - 10))));
			}
			while (value != 0);
			buffer.Append(ptr + num, 4 - num);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0002CC36 File Offset: 0x0002AE36
		private static uint ExtractIPv4Address(ushort[] address)
		{
			return (uint)((int)IPAddressParser.Reverse(address[7]) << 16 | (int)IPAddressParser.Reverse(address[6]));
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0002CC4C File Offset: 0x0002AE4C
		private static ushort Reverse(ushort number)
		{
			return (ushort)((number >> 8 & 255) | ((int)number << 8 & 65280));
		}
	}
}
