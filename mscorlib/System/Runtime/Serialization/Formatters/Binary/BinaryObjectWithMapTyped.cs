using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D6 RID: 982
	internal sealed class BinaryObjectWithMapTyped
	{
		// Token: 0x06001DC0 RID: 7616 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryObjectWithMapTyped()
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0007DAEE File Offset: 0x0007BCEE
		internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0007DB00 File Offset: 0x0007BD00
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId)
		{
			this.objectId = objectId;
			this.assemId = assemId;
			this.name = name;
			this.numMembers = numMembers;
			this.memberNames = memberNames;
			this.binaryTypeEnumA = binaryTypeEnumA;
			this.typeInformationA = typeInformationA;
			this.memberAssemIds = memberAssemIds;
			this.assemId = assemId;
			if (assemId > 0)
			{
				this.binaryHeaderEnum = BinaryHeaderEnum.ObjectWithMapTypedAssemId;
				return;
			}
			this.binaryHeaderEnum = BinaryHeaderEnum.ObjectWithMapTyped;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0007DB68 File Offset: 0x0007BD68
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
			for (int j = 0; j < this.numMembers; j++)
			{
				sout.WriteByte((byte)this.binaryTypeEnumA[j]);
			}
			for (int k = 0; k < this.numMembers; k++)
			{
				BinaryConverter.WriteTypeInfo(this.binaryTypeEnumA[k], this.typeInformationA[k], this.memberAssemIds[k], sout);
			}
			if (this.assemId > 0)
			{
				sout.WriteInt32(this.assemId);
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0007DC2C File Offset: 0x0007BE2C
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.objectId = input.ReadInt32();
			this.name = input.ReadString();
			this.numMembers = input.ReadInt32();
			this.memberNames = new string[this.numMembers];
			this.binaryTypeEnumA = new BinaryTypeEnum[this.numMembers];
			this.typeInformationA = new object[this.numMembers];
			this.memberAssemIds = new int[this.numMembers];
			for (int i = 0; i < this.numMembers; i++)
			{
				this.memberNames[i] = input.ReadString();
			}
			for (int j = 0; j < this.numMembers; j++)
			{
				this.binaryTypeEnumA[j] = (BinaryTypeEnum)input.ReadByte();
			}
			for (int k = 0; k < this.numMembers; k++)
			{
				if (this.binaryTypeEnumA[k] != BinaryTypeEnum.ObjectUrt && this.binaryTypeEnumA[k] != BinaryTypeEnum.ObjectUser)
				{
					this.typeInformationA[k] = BinaryConverter.ReadTypeInfo(this.binaryTypeEnumA[k], input, out this.memberAssemIds[k]);
				}
				else
				{
					BinaryConverter.ReadTypeInfo(this.binaryTypeEnumA[k], input, out this.memberAssemIds[k]);
				}
			}
			if (this.binaryHeaderEnum == BinaryHeaderEnum.ObjectWithMapTypedAssemId)
			{
				this.assemId = input.ReadInt32();
			}
		}

		// Token: 0x04000D06 RID: 3334
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000D07 RID: 3335
		internal int objectId;

		// Token: 0x04000D08 RID: 3336
		internal string name;

		// Token: 0x04000D09 RID: 3337
		internal int numMembers;

		// Token: 0x04000D0A RID: 3338
		internal string[] memberNames;

		// Token: 0x04000D0B RID: 3339
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x04000D0C RID: 3340
		internal object[] typeInformationA;

		// Token: 0x04000D0D RID: 3341
		internal int[] memberAssemIds;

		// Token: 0x04000D0E RID: 3342
		internal int assemId;
	}
}
