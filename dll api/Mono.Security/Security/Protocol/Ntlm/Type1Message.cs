using System;
using System.Globalization;
using System.Text;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000035 RID: 53
	public class Type1Message : MessageBase
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00009195 File Offset: 0x00007395
		public Type1Message() : base(1)
		{
			this._domain = Environment.UserDomainName;
			this._host = Environment.MachineName;
			base.Flags = (NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateOem | NtlmFlags.RequestTarget | NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateDomainSupplied | NtlmFlags.NegotiateWorkstationSupplied | NtlmFlags.NegotiateAlwaysSign);
		}

		// Token: 0x17000054 RID: 84
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000091C0 File Offset: 0x000073C0
		public string Domain
		{
			set
			{
				if (value == null)
				{
					value = "";
				}
				if (value == "")
				{
					base.Flags &= ~NtlmFlags.NegotiateDomainSupplied;
				}
				else
				{
					base.Flags |= NtlmFlags.NegotiateDomainSupplied;
				}
				this._domain = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00009214 File Offset: 0x00007414
		public string Host
		{
			set
			{
				if (value == null)
				{
					value = "";
				}
				if (value == "")
				{
					base.Flags &= ~NtlmFlags.NegotiateWorkstationSupplied;
				}
				else
				{
					base.Flags |= NtlmFlags.NegotiateWorkstationSupplied;
				}
				this._host = value;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00009268 File Offset: 0x00007468
		protected override void Decode(byte[] message)
		{
			base.Decode(message);
			base.Flags = (NtlmFlags)BitConverterLE.ToUInt32(message, 12);
			int count = (int)BitConverterLE.ToUInt16(message, 16);
			int index = (int)BitConverterLE.ToUInt16(message, 20);
			this._domain = Encoding.ASCII.GetString(message, index, count);
			int count2 = (int)BitConverterLE.ToUInt16(message, 24);
			this._host = Encoding.ASCII.GetString(message, 32, count2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000092CC File Offset: 0x000074CC
		public override byte[] GetBytes()
		{
			short num = (short)this._domain.Length;
			short num2 = (short)this._host.Length;
			byte[] array = base.PrepareMessage((int)(32 + num + num2));
			array[12] = (byte)base.Flags;
			array[13] = (byte)(base.Flags >> 8);
			array[14] = (byte)(base.Flags >> 16);
			array[15] = (byte)(base.Flags >> 24);
			short num3 = 32 + num2;
			array[16] = (byte)num;
			array[17] = (byte)(num >> 8);
			array[18] = array[16];
			array[19] = array[17];
			array[20] = (byte)num3;
			array[21] = (byte)(num3 >> 8);
			array[24] = (byte)num2;
			array[25] = (byte)(num2 >> 8);
			array[26] = array[24];
			array[27] = array[25];
			array[28] = 32;
			array[29] = 0;
			byte[] bytes = Encoding.ASCII.GetBytes(this._host.ToUpper(CultureInfo.InvariantCulture));
			Buffer.BlockCopy(bytes, 0, array, 32, bytes.Length);
			byte[] bytes2 = Encoding.ASCII.GetBytes(this._domain.ToUpper(CultureInfo.InvariantCulture));
			Buffer.BlockCopy(bytes2, 0, array, (int)num3, bytes2.Length);
			return array;
		}

		// Token: 0x040000A2 RID: 162
		private string _host;

		// Token: 0x040000A3 RID: 163
		private string _domain;
	}
}
