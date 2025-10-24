using System;
using System.Text;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000037 RID: 55
	public class Type3Message : MessageBase
	{
		// Token: 0x06000134 RID: 308 RVA: 0x000095A0 File Offset: 0x000077A0
		public Type3Message(Type2Message type2) : base(3)
		{
			this._type2 = type2;
			this._level = NtlmSettings.DefaultAuthLevel;
			this._challenge = (byte[])type2.Nonce.Clone();
			this._domain = type2.TargetName;
			this._host = Environment.MachineName;
			this._username = Environment.UserName;
			base.Flags = (NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateAlwaysSign);
			if ((type2.Flags & NtlmFlags.NegotiateUnicode) != (NtlmFlags)0)
			{
				base.Flags |= NtlmFlags.NegotiateUnicode;
			}
			else
			{
				base.Flags |= NtlmFlags.NegotiateOem;
			}
			if ((type2.Flags & NtlmFlags.NegotiateNtlm2Key) != (NtlmFlags)0)
			{
				base.Flags |= NtlmFlags.NegotiateNtlm2Key;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00009654 File Offset: 0x00007854
		~Type3Message()
		{
			if (this._challenge != null)
			{
				Array.Clear(this._challenge, 0, this._challenge.Length);
			}
			if (this._lm != null)
			{
				Array.Clear(this._lm, 0, this._lm.Length);
			}
			if (this._nt != null)
			{
				Array.Clear(this._nt, 0, this._nt.Length);
			}
		}

		// Token: 0x17000059 RID: 89
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000096D0 File Offset: 0x000078D0
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

		// Token: 0x1700005A RID: 90
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00009721 File Offset: 0x00007921
		public string Password
		{
			set
			{
				this._password = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000972A File Offset: 0x0000792A
		public string Username
		{
			set
			{
				this._username = value;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009734 File Offset: 0x00007934
		protected override void Decode(byte[] message)
		{
			base.Decode(message);
			this._password = null;
			if (message.Length >= 64)
			{
				base.Flags = (NtlmFlags)BitConverterLE.ToUInt32(message, 60);
			}
			else
			{
				base.Flags = (NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateAlwaysSign);
			}
			int num = (int)BitConverterLE.ToUInt16(message, 12);
			int srcOffset = (int)BitConverterLE.ToUInt16(message, 16);
			this._lm = new byte[num];
			Buffer.BlockCopy(message, srcOffset, this._lm, 0, num);
			int num2 = (int)BitConverterLE.ToUInt16(message, 20);
			int srcOffset2 = (int)BitConverterLE.ToUInt16(message, 24);
			this._nt = new byte[num2];
			Buffer.BlockCopy(message, srcOffset2, this._nt, 0, num2);
			int len = (int)BitConverterLE.ToUInt16(message, 28);
			int offset = (int)BitConverterLE.ToUInt16(message, 32);
			this._domain = this.DecodeString(message, offset, len);
			int len2 = (int)BitConverterLE.ToUInt16(message, 36);
			int offset2 = (int)BitConverterLE.ToUInt16(message, 40);
			this._username = this.DecodeString(message, offset2, len2);
			int len3 = (int)BitConverterLE.ToUInt16(message, 44);
			int offset3 = (int)BitConverterLE.ToUInt16(message, 48);
			this._host = this.DecodeString(message, offset3, len3);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000983A File Offset: 0x00007A3A
		private string DecodeString(byte[] buffer, int offset, int len)
		{
			if ((base.Flags & NtlmFlags.NegotiateUnicode) != (NtlmFlags)0)
			{
				return Encoding.Unicode.GetString(buffer, offset, len);
			}
			return Encoding.ASCII.GetString(buffer, offset, len);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009861 File Offset: 0x00007A61
		private byte[] EncodeString(string text)
		{
			if (text == null)
			{
				return new byte[0];
			}
			if ((base.Flags & NtlmFlags.NegotiateUnicode) != (NtlmFlags)0)
			{
				return Encoding.Unicode.GetBytes(text);
			}
			return Encoding.ASCII.GetBytes(text);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009890 File Offset: 0x00007A90
		public override byte[] GetBytes()
		{
			byte[] array = this.EncodeString(this._domain);
			byte[] array2 = this.EncodeString(this._username);
			byte[] array3 = this.EncodeString(this._host);
			byte[] lm;
			byte[] nt;
			if (this._type2 == null)
			{
				if (this._level != NtlmAuthLevel.LM_and_NTLM)
				{
					throw new InvalidOperationException("Refusing to use legacy-mode LM/NTLM authentication unless explicitly enabled using DefaultAuthLevel.");
				}
				using (ChallengeResponse challengeResponse = new ChallengeResponse(this._password, this._challenge))
				{
					lm = challengeResponse.LM;
					nt = challengeResponse.NT;
					goto IL_9B;
				}
			}
			ChallengeResponse2.Compute(this._type2, this._level, this._username, this._password, this._domain, out lm, out nt);
			IL_9B:
			int num = (lm != null) ? lm.Length : 0;
			int num2 = (nt != null) ? nt.Length : 0;
			byte[] array4 = base.PrepareMessage(64 + array.Length + array2.Length + array3.Length + num + num2);
			short num3 = (short)(64 + array.Length + array2.Length + array3.Length);
			array4[12] = (byte)num;
			array4[13] = 0;
			array4[14] = (byte)num;
			array4[15] = 0;
			array4[16] = (byte)num3;
			array4[17] = (byte)(num3 >> 8);
			short num4 = (short)((int)num3 + num);
			array4[20] = (byte)num2;
			array4[21] = (byte)(num2 >> 8);
			array4[22] = (byte)num2;
			array4[23] = (byte)(num2 >> 8);
			array4[24] = (byte)num4;
			array4[25] = (byte)(num4 >> 8);
			short num5 = (short)array.Length;
			short num6 = 64;
			array4[28] = (byte)num5;
			array4[29] = (byte)(num5 >> 8);
			array4[30] = array4[28];
			array4[31] = array4[29];
			array4[32] = (byte)num6;
			array4[33] = (byte)(num6 >> 8);
			short num7 = (short)array2.Length;
			short num8 = num6 + num5;
			array4[36] = (byte)num7;
			array4[37] = (byte)(num7 >> 8);
			array4[38] = array4[36];
			array4[39] = array4[37];
			array4[40] = (byte)num8;
			array4[41] = (byte)(num8 >> 8);
			short num9 = (short)array3.Length;
			short num10 = num8 + num7;
			array4[44] = (byte)num9;
			array4[45] = (byte)(num9 >> 8);
			array4[46] = array4[44];
			array4[47] = array4[45];
			array4[48] = (byte)num10;
			array4[49] = (byte)(num10 >> 8);
			short num11 = (short)array4.Length;
			array4[56] = (byte)num11;
			array4[57] = (byte)(num11 >> 8);
			int flags = (int)base.Flags;
			array4[60] = (byte)flags;
			array4[61] = (byte)((uint)flags >> 8);
			array4[62] = (byte)((uint)flags >> 16);
			array4[63] = (byte)((uint)flags >> 24);
			Buffer.BlockCopy(array, 0, array4, (int)num6, array.Length);
			Buffer.BlockCopy(array2, 0, array4, (int)num8, array2.Length);
			Buffer.BlockCopy(array3, 0, array4, (int)num10, array3.Length);
			if (lm != null)
			{
				Buffer.BlockCopy(lm, 0, array4, (int)num3, lm.Length);
				Array.Clear(lm, 0, lm.Length);
			}
			Buffer.BlockCopy(nt, 0, array4, (int)num4, nt.Length);
			Array.Clear(nt, 0, nt.Length);
			return array4;
		}

		// Token: 0x040000A7 RID: 167
		private NtlmAuthLevel _level;

		// Token: 0x040000A8 RID: 168
		private byte[] _challenge;

		// Token: 0x040000A9 RID: 169
		private string _host;

		// Token: 0x040000AA RID: 170
		private string _domain;

		// Token: 0x040000AB RID: 171
		private string _username;

		// Token: 0x040000AC RID: 172
		private string _password;

		// Token: 0x040000AD RID: 173
		private Type2Message _type2;

		// Token: 0x040000AE RID: 174
		private byte[] _lm;

		// Token: 0x040000AF RID: 175
		private byte[] _nt;
	}
}
