using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D5 RID: 981
	internal sealed class BinaryObjectWithMap
	{
		// Token: 0x06001DBA RID: 7610 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryObjectWithMap()
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0007D9B8 File Offset: 0x0007BBB8
		internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0007D9C7 File Offset: 0x0007BBC7
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId)
		{
			this.objectId = objectId;
			this.name = name;
			this.numMembers = numMembers;
			this.memberNames = memberNames;
			this.assemId = assemId;
			if (assemId > 0)
			{
				this.binaryHeaderEnum = BinaryHeaderEnum.ObjectWithMapAssemId;
				return;
			}
			this.binaryHeaderEnum = BinaryHeaderEnum.ObjectWithMap;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0007DA04 File Offset: 0x0007BC04
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte((byte)this.binaryHeaderEnum);
			sout.WriteInt32(this.objectId);
			sout.WriteString(this.name);
			sout.WriteInt32(this.numMembers);
			for (int i = 0; i < this.numMembers; i++)
			{
				sout.WriteString(this.memberNames[i]);
			}
			if (this.assemId > 0)
			{
				sout.WriteInt32(this.assemId);
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0007DA78 File Offset: 0x0007BC78
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.objectId = input.ReadInt32();
			this.name = input.ReadString();
			this.numMembers = input.ReadInt32();
			this.memberNames = new string[this.numMembers];
			for (int i = 0; i < this.numMembers; i++)
			{
				this.memberNames[i] = input.ReadString();
			}
			if (this.binaryHeaderEnum == BinaryHeaderEnum.ObjectWithMapAssemId)
			{
				this.assemId = input.ReadInt32();
			}
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000D00 RID: 3328
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000D01 RID: 3329
		internal int objectId;

		// Token: 0x04000D02 RID: 3330
		internal string name;

		// Token: 0x04000D03 RID: 3331
		internal int numMembers;

		// Token: 0x04000D04 RID: 3332
		internal string[] memberNames;

		// Token: 0x04000D05 RID: 3333
		internal int assemId;
	}
}
