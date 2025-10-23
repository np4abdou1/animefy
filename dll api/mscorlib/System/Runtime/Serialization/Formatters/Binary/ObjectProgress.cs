using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003DD RID: 989
	internal sealed class ObjectProgress
	{
		// Token: 0x06001DE4 RID: 7652 RVA: 0x0007E4C0 File Offset: 0x0007C6C0
		internal ObjectProgress()
		{
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0007E4DC File Offset: 0x0007C6DC
		internal void Init()
		{
			this.isInitial = false;
			this.count = 0;
			this.expectedType = BinaryTypeEnum.ObjectUrt;
			this.expectedTypeInformation = null;
			this.name = null;
			this.objectTypeEnum = InternalObjectTypeE.Empty;
			this.memberTypeEnum = InternalMemberTypeE.Empty;
			this.memberValueEnum = InternalMemberValueE.Empty;
			this.dtType = null;
			this.numItems = 0;
			this.nullCount = 0;
			this.typeInformation = null;
			this.memberLength = 0;
			this.binaryTypeEnumA = null;
			this.typeInformationA = null;
			this.memberNames = null;
			this.memberTypes = null;
			this.pr.Init();
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0007E56B File Offset: 0x0007C76B
		internal void ArrayCountIncrement(int value)
		{
			this.count += value;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0007E57C File Offset: 0x0007C77C
		internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation)
		{
			outBinaryTypeEnum = BinaryTypeEnum.Primitive;
			outTypeInformation = null;
			if (this.objectTypeEnum == InternalObjectTypeE.Array)
			{
				if (this.count == this.numItems)
				{
					return false;
				}
				outBinaryTypeEnum = this.binaryTypeEnum;
				outTypeInformation = this.typeInformation;
				if (this.count == 0)
				{
					this.isInitial = false;
				}
				this.count++;
				return true;
			}
			else
			{
				if (this.count == this.memberLength && !this.isInitial)
				{
					return false;
				}
				outBinaryTypeEnum = this.binaryTypeEnumA[this.count];
				outTypeInformation = this.typeInformationA[this.count];
				if (this.count == 0)
				{
					this.isInitial = false;
				}
				this.name = this.memberNames[this.count];
				Type[] array = this.memberTypes;
				this.dtType = this.memberTypes[this.count];
				this.count++;
				return true;
			}
		}

		// Token: 0x04000D27 RID: 3367
		internal static int opRecordIdCount = 1;

		// Token: 0x04000D28 RID: 3368
		internal bool isInitial;

		// Token: 0x04000D29 RID: 3369
		internal int count;

		// Token: 0x04000D2A RID: 3370
		internal BinaryTypeEnum expectedType = BinaryTypeEnum.ObjectUrt;

		// Token: 0x04000D2B RID: 3371
		internal object expectedTypeInformation;

		// Token: 0x04000D2C RID: 3372
		internal string name;

		// Token: 0x04000D2D RID: 3373
		internal InternalObjectTypeE objectTypeEnum;

		// Token: 0x04000D2E RID: 3374
		internal InternalMemberTypeE memberTypeEnum;

		// Token: 0x04000D2F RID: 3375
		internal InternalMemberValueE memberValueEnum;

		// Token: 0x04000D30 RID: 3376
		internal Type dtType;

		// Token: 0x04000D31 RID: 3377
		internal int numItems;

		// Token: 0x04000D32 RID: 3378
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x04000D33 RID: 3379
		internal object typeInformation;

		// Token: 0x04000D34 RID: 3380
		internal int nullCount;

		// Token: 0x04000D35 RID: 3381
		internal int memberLength;

		// Token: 0x04000D36 RID: 3382
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x04000D37 RID: 3383
		internal object[] typeInformationA;

		// Token: 0x04000D38 RID: 3384
		internal string[] memberNames;

		// Token: 0x04000D39 RID: 3385
		internal Type[] memberTypes;

		// Token: 0x04000D3A RID: 3386
		internal ParseRecord pr = new ParseRecord();
	}
}
