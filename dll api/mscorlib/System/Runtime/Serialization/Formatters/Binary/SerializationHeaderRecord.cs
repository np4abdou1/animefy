using System;
using System.IO;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003CB RID: 971
	internal sealed class SerializationHeaderRecord
	{
		// Token: 0x06001D8A RID: 7562 RVA: 0x0007CC13 File Offset: 0x0007AE13
		internal SerializationHeaderRecord()
		{
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0007CC22 File Offset: 0x0007AE22
		internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
			this.topId = topId;
			this.headerId = headerId;
			this.majorVersion = majorVersion;
			this.minorVersion = minorVersion;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0007CC58 File Offset: 0x0007AE58
		public void Write(__BinaryWriter sout)
		{
			this.majorVersion = this.binaryFormatterMajorVersion;
			this.minorVersion = this.binaryFormatterMinorVersion;
			sout.WriteByte((byte)this.binaryHeaderEnum);
			sout.WriteInt32(this.topId);
			sout.WriteInt32(this.headerId);
			sout.WriteInt32(this.binaryFormatterMajorVersion);
			sout.WriteInt32(this.binaryFormatterMinorVersion);
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0007CCBA File Offset: 0x0007AEBA
		private static int GetInt32(byte[] buffer, int index)
		{
			return (int)buffer[index] | (int)buffer[index + 1] << 8 | (int)buffer[index + 2] << 16 | (int)buffer[index + 3] << 24;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0007CCDC File Offset: 0x0007AEDC
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			byte[] array = input.ReadBytes(17);
			if (array.Length < 17)
			{
				__Error.EndOfFile();
			}
			this.majorVersion = SerializationHeaderRecord.GetInt32(array, 9);
			if (this.majorVersion > this.binaryFormatterMajorVersion)
			{
				throw new SerializationException(Environment.GetResourceString("The input stream is not a valid binary format. The starting contents (in bytes) are: {0} ...", new object[]
				{
					BitConverter.ToString(array)
				}));
			}
			this.binaryHeaderEnum = (BinaryHeaderEnum)array[0];
			this.topId = SerializationHeaderRecord.GetInt32(array, 1);
			this.headerId = SerializationHeaderRecord.GetInt32(array, 5);
			this.minorVersion = SerializationHeaderRecord.GetInt32(array, 13);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CD3 RID: 3283
		internal int binaryFormatterMajorVersion = 1;

		// Token: 0x04000CD4 RID: 3284
		internal int binaryFormatterMinorVersion;

		// Token: 0x04000CD5 RID: 3285
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000CD6 RID: 3286
		internal int topId;

		// Token: 0x04000CD7 RID: 3287
		internal int headerId;

		// Token: 0x04000CD8 RID: 3288
		internal int majorVersion;

		// Token: 0x04000CD9 RID: 3289
		internal int minorVersion;
	}
}
