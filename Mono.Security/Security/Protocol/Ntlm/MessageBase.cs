using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000031 RID: 49
	public abstract class MessageBase
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00009040 File Offset: 0x00007240
		protected MessageBase(int messageType)
		{
			this._type = messageType;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000904F File Offset: 0x0000724F
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00009057 File Offset: 0x00007257
		public NtlmFlags Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				this._flags = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00009060 File Offset: 0x00007260
		public int Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00009068 File Offset: 0x00007268
		protected byte[] PrepareMessage(int messageSize)
		{
			byte[] array = new byte[messageSize];
			Buffer.BlockCopy(MessageBase.header, 0, array, 0, 8);
			array[8] = (byte)this._type;
			array[9] = (byte)(this._type >> 8);
			array[10] = (byte)(this._type >> 16);
			array[11] = (byte)(this._type >> 24);
			return array;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000090C0 File Offset: 0x000072C0
		protected virtual void Decode(byte[] message)
		{
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			if (message.Length < 12)
			{
				string text = Locale.GetText("Minimum message length is 12 bytes.");
				throw new ArgumentOutOfRangeException("message", message.Length, text);
			}
			if (!this.CheckHeader(message))
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid Type{0} message."), this._type), "message");
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00009130 File Offset: 0x00007330
		protected bool CheckHeader(byte[] message)
		{
			for (int i = 0; i < MessageBase.header.Length; i++)
			{
				if (message[i] != MessageBase.header[i])
				{
					return false;
				}
			}
			return (ulong)BitConverterLE.ToUInt32(message, 8) == (ulong)((long)this._type);
		}

		// Token: 0x06000124 RID: 292
		public abstract byte[] GetBytes();

		// Token: 0x0400008E RID: 142
		private static byte[] header = new byte[]
		{
			78,
			84,
			76,
			77,
			83,
			83,
			80,
			0
		};

		// Token: 0x0400008F RID: 143
		private int _type;

		// Token: 0x04000090 RID: 144
		private NtlmFlags _flags;
	}
}
