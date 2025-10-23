using System;

namespace System.Data
{
	// Token: 0x0200007D RID: 125
	internal enum RBTreeError
	{
		// Token: 0x04000280 RID: 640
		InvalidPageSize = 1,
		// Token: 0x04000281 RID: 641
		PagePositionInSlotInUse = 3,
		// Token: 0x04000282 RID: 642
		NoFreeSlots,
		// Token: 0x04000283 RID: 643
		InvalidStateinInsert,
		// Token: 0x04000284 RID: 644
		InvalidNextSizeInDelete = 7,
		// Token: 0x04000285 RID: 645
		InvalidStateinDelete,
		// Token: 0x04000286 RID: 646
		InvalidNodeSizeinDelete,
		// Token: 0x04000287 RID: 647
		InvalidStateinEndDelete,
		// Token: 0x04000288 RID: 648
		CannotRotateInvalidsuccessorNodeinDelete,
		// Token: 0x04000289 RID: 649
		IndexOutOFRangeinGetNodeByIndex = 13,
		// Token: 0x0400028A RID: 650
		RBDeleteFixup,
		// Token: 0x0400028B RID: 651
		UnsupportedAccessMethod1,
		// Token: 0x0400028C RID: 652
		UnsupportedAccessMethod2,
		// Token: 0x0400028D RID: 653
		UnsupportedAccessMethodInNonNillRootSubtree,
		// Token: 0x0400028E RID: 654
		AttachedNodeWithZerorbTreeNodeId,
		// Token: 0x0400028F RID: 655
		CompareNodeInDataRowTree,
		// Token: 0x04000290 RID: 656
		CompareSateliteTreeNodeInDataRowTree,
		// Token: 0x04000291 RID: 657
		NestedSatelliteTreeEnumerator
	}
}
