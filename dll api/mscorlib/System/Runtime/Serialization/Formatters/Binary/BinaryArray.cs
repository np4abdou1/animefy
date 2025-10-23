using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D7 RID: 983
	internal sealed class BinaryArray
	{
		// Token: 0x06001DC5 RID: 7621 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryArray()
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0007DD5A File Offset: 0x0007BF5A
		internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0007DD6C File Offset: 0x0007BF6C
		internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
			this.objectId = objectId;
			this.binaryArrayTypeEnum = binaryArrayTypeEnum;
			this.rank = rank;
			this.lengthA = lengthA;
			this.lowerBoundA = lowerBoundA;
			this.binaryTypeEnum = binaryTypeEnum;
			this.typeInformation = typeInformation;
			this.assemId = assemId;
			this.binaryHeaderEnum = BinaryHeaderEnum.Array;
			if (binaryArrayTypeEnum == BinaryArrayTypeEnum.Single)
			{
				if (binaryTypeEnum == BinaryTypeEnum.Primitive)
				{
					this.binaryHeaderEnum = BinaryHeaderEnum.ArraySinglePrimitive;
					return;
				}
				if (binaryTypeEnum == BinaryTypeEnum.String)
				{
					this.binaryHeaderEnum = BinaryHeaderEnum.ArraySingleString;
					return;
				}
				if (binaryTypeEnum == BinaryTypeEnum.Object)
				{
					this.binaryHeaderEnum = BinaryHeaderEnum.ArraySingleObject;
				}
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0007DDEC File Offset: 0x0007BFEC
		public void Write(__BinaryWriter sout)
		{
			switch (this.binaryHeaderEnum)
			{
			case BinaryHeaderEnum.ArraySinglePrimitive:
				sout.WriteByte((byte)this.binaryHeaderEnum);
				sout.WriteInt32(this.objectId);
				sout.WriteInt32(this.lengthA[0]);
				sout.WriteByte((byte)((InternalPrimitiveTypeE)this.typeInformation));
				return;
			case BinaryHeaderEnum.ArraySingleObject:
				sout.WriteByte((byte)this.binaryHeaderEnum);
				sout.WriteInt32(this.objectId);
				sout.WriteInt32(this.lengthA[0]);
				return;
			case BinaryHeaderEnum.ArraySingleString:
				sout.WriteByte((byte)this.binaryHeaderEnum);
				sout.WriteInt32(this.objectId);
				sout.WriteInt32(this.lengthA[0]);
				return;
			default:
				sout.WriteByte((byte)this.binaryHeaderEnum);
				sout.WriteInt32(this.objectId);
				sout.WriteByte((byte)this.binaryArrayTypeEnum);
				sout.WriteInt32(this.rank);
				for (int i = 0; i < this.rank; i++)
				{
					sout.WriteInt32(this.lengthA[i]);
				}
				if (this.binaryArrayTypeEnum == BinaryArrayTypeEnum.SingleOffset || this.binaryArrayTypeEnum == BinaryArrayTypeEnum.JaggedOffset || this.binaryArrayTypeEnum == BinaryArrayTypeEnum.RectangularOffset)
				{
					for (int j = 0; j < this.rank; j++)
					{
						sout.WriteInt32(this.lowerBoundA[j]);
					}
				}
				sout.WriteByte((byte)this.binaryTypeEnum);
				BinaryConverter.WriteTypeInfo(this.binaryTypeEnum, this.typeInformation, this.assemId, sout);
				return;
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0007DF54 File Offset: 0x0007C154
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			switch (this.binaryHeaderEnum)
			{
			case BinaryHeaderEnum.ArraySinglePrimitive:
				this.objectId = input.ReadInt32();
				this.lengthA = new int[1];
				this.lengthA[0] = input.ReadInt32();
				this.binaryArrayTypeEnum = BinaryArrayTypeEnum.Single;
				this.rank = 1;
				this.lowerBoundA = new int[this.rank];
				this.binaryTypeEnum = BinaryTypeEnum.Primitive;
				this.typeInformation = (InternalPrimitiveTypeE)input.ReadByte();
				return;
			case BinaryHeaderEnum.ArraySingleObject:
				this.objectId = input.ReadInt32();
				this.lengthA = new int[1];
				this.lengthA[0] = input.ReadInt32();
				this.binaryArrayTypeEnum = BinaryArrayTypeEnum.Single;
				this.rank = 1;
				this.lowerBoundA = new int[this.rank];
				this.binaryTypeEnum = BinaryTypeEnum.Object;
				this.typeInformation = null;
				return;
			case BinaryHeaderEnum.ArraySingleString:
				this.objectId = input.ReadInt32();
				this.lengthA = new int[1];
				this.lengthA[0] = input.ReadInt32();
				this.binaryArrayTypeEnum = BinaryArrayTypeEnum.Single;
				this.rank = 1;
				this.lowerBoundA = new int[this.rank];
				this.binaryTypeEnum = BinaryTypeEnum.String;
				this.typeInformation = null;
				return;
			default:
				this.objectId = input.ReadInt32();
				this.binaryArrayTypeEnum = (BinaryArrayTypeEnum)input.ReadByte();
				this.rank = input.ReadInt32();
				this.lengthA = new int[this.rank];
				this.lowerBoundA = new int[this.rank];
				for (int i = 0; i < this.rank; i++)
				{
					this.lengthA[i] = input.ReadInt32();
				}
				if (this.binaryArrayTypeEnum == BinaryArrayTypeEnum.SingleOffset || this.binaryArrayTypeEnum == BinaryArrayTypeEnum.JaggedOffset || this.binaryArrayTypeEnum == BinaryArrayTypeEnum.RectangularOffset)
				{
					for (int j = 0; j < this.rank; j++)
					{
						this.lowerBoundA[j] = input.ReadInt32();
					}
				}
				this.binaryTypeEnum = (BinaryTypeEnum)input.ReadByte();
				this.typeInformation = BinaryConverter.ReadTypeInfo(this.binaryTypeEnum, input, out this.assemId);
				return;
			}
		}

		// Token: 0x04000D0F RID: 3343
		internal int objectId;

		// Token: 0x04000D10 RID: 3344
		internal int rank;

		// Token: 0x04000D11 RID: 3345
		internal int[] lengthA;

		// Token: 0x04000D12 RID: 3346
		internal int[] lowerBoundA;

		// Token: 0x04000D13 RID: 3347
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x04000D14 RID: 3348
		internal object typeInformation;

		// Token: 0x04000D15 RID: 3349
		internal int assemId;

		// Token: 0x04000D16 RID: 3350
		private BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000D17 RID: 3351
		internal BinaryArrayTypeEnum binaryArrayTypeEnum;
	}
}
