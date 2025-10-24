using System;
using System.Text;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000036 RID: 54
	public class Type2Message : MessageBase
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000093E5 File Offset: 0x000075E5
		public Type2Message(byte[] message) : base(2)
		{
			this._nonce = new byte[8];
			this.Decode(message);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00009404 File Offset: 0x00007604
		~Type2Message()
		{
			if (this._nonce != null)
			{
				Array.Clear(this._nonce, 0, this._nonce.Length);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00009448 File Offset: 0x00007648
		public byte[] Nonce
		{
			get
			{
				return (byte[])this._nonce.Clone();
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000945A File Offset: 0x0000765A
		public string TargetName
		{
			get
			{
				return this._targetName;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00009462 File Offset: 0x00007662
		public byte[] TargetInfo
		{
			get
			{
				return (byte[])this._targetInfo.Clone();
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00009474 File Offset: 0x00007674
		protected override void Decode(byte[] message)
		{
			base.Decode(message);
			base.Flags = (NtlmFlags)BitConverterLE.ToUInt32(message, 20);
			Buffer.BlockCopy(message, 24, this._nonce, 0, 8);
			ushort num = BitConverterLE.ToUInt16(message, 12);
			ushort index = BitConverterLE.ToUInt16(message, 16);
			if (num > 0)
			{
				if ((base.Flags & NtlmFlags.NegotiateOem) != (NtlmFlags)0)
				{
					this._targetName = Encoding.ASCII.GetString(message, (int)index, (int)num);
				}
				else
				{
					this._targetName = Encoding.Unicode.GetString(message, (int)index, (int)num);
				}
			}
			if (message.Length >= 48)
			{
				ushort num2 = BitConverterLE.ToUInt16(message, 40);
				ushort srcOffset = BitConverterLE.ToUInt16(message, 44);
				if (num2 > 0)
				{
					this._targetInfo = new byte[(int)num2];
					Buffer.BlockCopy(message, (int)srcOffset, this._targetInfo, 0, (int)num2);
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00009528 File Offset: 0x00007728
		public override byte[] GetBytes()
		{
			byte[] array = base.PrepareMessage(40);
			short num = (short)array.Length;
			array[16] = (byte)num;
			array[17] = (byte)(num >> 8);
			array[20] = (byte)base.Flags;
			array[21] = (byte)(base.Flags >> 8);
			array[22] = (byte)(base.Flags >> 16);
			array[23] = (byte)(base.Flags >> 24);
			Buffer.BlockCopy(this._nonce, 0, array, 24, this._nonce.Length);
			return array;
		}

		// Token: 0x040000A4 RID: 164
		private byte[] _nonce;

		// Token: 0x040000A5 RID: 165
		private string _targetName;

		// Token: 0x040000A6 RID: 166
		private byte[] _targetInfo;
	}
}
