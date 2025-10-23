using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003EE RID: 1006
	internal sealed class ParseRecord
	{
		// Token: 0x06001EF4 RID: 7924 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal ParseRecord()
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0008584C File Offset: 0x00083A4C
		internal void Init()
		{
			this.PRparseTypeEnum = InternalParseTypeE.Empty;
			this.PRobjectTypeEnum = InternalObjectTypeE.Empty;
			this.PRarrayTypeEnum = InternalArrayTypeE.Empty;
			this.PRmemberTypeEnum = InternalMemberTypeE.Empty;
			this.PRmemberValueEnum = InternalMemberValueE.Empty;
			this.PRobjectPositionEnum = InternalObjectPositionE.Empty;
			this.PRname = null;
			this.PRvalue = null;
			this.PRkeyDt = null;
			this.PRdtType = null;
			this.PRdtTypeCode = InternalPrimitiveTypeE.Invalid;
			this.PRisEnum = false;
			this.PRobjectId = 0L;
			this.PRidRef = 0L;
			this.PRarrayElementTypeString = null;
			this.PRarrayElementType = null;
			this.PRisArrayVariant = false;
			this.PRarrayElementTypeCode = InternalPrimitiveTypeE.Invalid;
			this.PRrank = 0;
			this.PRlengthA = null;
			this.PRpositionA = null;
			this.PRlowerBoundA = null;
			this.PRupperBoundA = null;
			this.PRindexMap = null;
			this.PRmemberIndex = 0;
			this.PRlinearlength = 0;
			this.PRrectangularMap = null;
			this.PRisLowerBound = false;
			this.PRtopId = 0L;
			this.PRheaderId = 0L;
			this.PRisValueTypeFixup = false;
			this.PRnewObj = null;
			this.PRobjectA = null;
			this.PRprimitiveArray = null;
			this.PRobjectInfo = null;
			this.PRisRegistered = false;
			this.PRmemberData = null;
			this.PRsi = null;
			this.PRnullCount = 0;
		}

		// Token: 0x04000E16 RID: 3606
		internal static int parseRecordIdCount = 1;

		// Token: 0x04000E17 RID: 3607
		internal InternalParseTypeE PRparseTypeEnum;

		// Token: 0x04000E18 RID: 3608
		internal InternalObjectTypeE PRobjectTypeEnum;

		// Token: 0x04000E19 RID: 3609
		internal InternalArrayTypeE PRarrayTypeEnum;

		// Token: 0x04000E1A RID: 3610
		internal InternalMemberTypeE PRmemberTypeEnum;

		// Token: 0x04000E1B RID: 3611
		internal InternalMemberValueE PRmemberValueEnum;

		// Token: 0x04000E1C RID: 3612
		internal InternalObjectPositionE PRobjectPositionEnum;

		// Token: 0x04000E1D RID: 3613
		internal string PRname;

		// Token: 0x04000E1E RID: 3614
		internal string PRvalue;

		// Token: 0x04000E1F RID: 3615
		internal object PRvarValue;

		// Token: 0x04000E20 RID: 3616
		internal string PRkeyDt;

		// Token: 0x04000E21 RID: 3617
		internal Type PRdtType;

		// Token: 0x04000E22 RID: 3618
		internal InternalPrimitiveTypeE PRdtTypeCode;

		// Token: 0x04000E23 RID: 3619
		internal bool PRisEnum;

		// Token: 0x04000E24 RID: 3620
		internal long PRobjectId;

		// Token: 0x04000E25 RID: 3621
		internal long PRidRef;

		// Token: 0x04000E26 RID: 3622
		internal string PRarrayElementTypeString;

		// Token: 0x04000E27 RID: 3623
		internal Type PRarrayElementType;

		// Token: 0x04000E28 RID: 3624
		internal bool PRisArrayVariant;

		// Token: 0x04000E29 RID: 3625
		internal InternalPrimitiveTypeE PRarrayElementTypeCode;

		// Token: 0x04000E2A RID: 3626
		internal int PRrank;

		// Token: 0x04000E2B RID: 3627
		internal int[] PRlengthA;

		// Token: 0x04000E2C RID: 3628
		internal int[] PRpositionA;

		// Token: 0x04000E2D RID: 3629
		internal int[] PRlowerBoundA;

		// Token: 0x04000E2E RID: 3630
		internal int[] PRupperBoundA;

		// Token: 0x04000E2F RID: 3631
		internal int[] PRindexMap;

		// Token: 0x04000E30 RID: 3632
		internal int PRmemberIndex;

		// Token: 0x04000E31 RID: 3633
		internal int PRlinearlength;

		// Token: 0x04000E32 RID: 3634
		internal int[] PRrectangularMap;

		// Token: 0x04000E33 RID: 3635
		internal bool PRisLowerBound;

		// Token: 0x04000E34 RID: 3636
		internal long PRtopId;

		// Token: 0x04000E35 RID: 3637
		internal long PRheaderId;

		// Token: 0x04000E36 RID: 3638
		internal ReadObjectInfo PRobjectInfo;

		// Token: 0x04000E37 RID: 3639
		internal bool PRisValueTypeFixup;

		// Token: 0x04000E38 RID: 3640
		internal object PRnewObj;

		// Token: 0x04000E39 RID: 3641
		internal object[] PRobjectA;

		// Token: 0x04000E3A RID: 3642
		internal PrimitiveArray PRprimitiveArray;

		// Token: 0x04000E3B RID: 3643
		internal bool PRisRegistered;

		// Token: 0x04000E3C RID: 3644
		internal object[] PRmemberData;

		// Token: 0x04000E3D RID: 3645
		internal SerializationInfo PRsi;

		// Token: 0x04000E3E RID: 3646
		internal int PRnullCount;
	}
}
