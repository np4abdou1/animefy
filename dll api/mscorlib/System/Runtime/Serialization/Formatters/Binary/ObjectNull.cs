using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003DA RID: 986
	internal sealed class ObjectNull
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal ObjectNull()
		{
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0007E1B9 File Offset: 0x0007C3B9
		internal void SetNullCount(int nullCount)
		{
			this.nullCount = nullCount;
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0007E1C4 File Offset: 0x0007C3C4
		public void Write(__BinaryWriter sout)
		{
			if (this.nullCount == 1)
			{
				sout.WriteByte(10);
				return;
			}
			if (this.nullCount < 256)
			{
				sout.WriteByte(13);
				sout.WriteByte((byte)this.nullCount);
				return;
			}
			sout.WriteByte(14);
			sout.WriteInt32(this.nullCount);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0007E21C File Offset: 0x0007C41C
		public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
			switch (binaryHeaderEnum)
			{
			case BinaryHeaderEnum.ObjectNull:
				this.nullCount = 1;
				return;
			case BinaryHeaderEnum.MessageEnd:
			case BinaryHeaderEnum.Assembly:
				break;
			case BinaryHeaderEnum.ObjectNullMultiple256:
				this.nullCount = (int)input.ReadByte();
				return;
			case BinaryHeaderEnum.ObjectNullMultiple:
				this.nullCount = input.ReadInt32();
				break;
			default:
				return;
			}
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000D1B RID: 3355
		internal int nullCount;
	}
}
