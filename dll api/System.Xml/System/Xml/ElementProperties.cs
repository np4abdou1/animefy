using System;

namespace System.Xml
{
	// Token: 0x0200003D RID: 61
	internal enum ElementProperties : uint
	{
		// Token: 0x04000148 RID: 328
		DEFAULT,
		// Token: 0x04000149 RID: 329
		URI_PARENT,
		// Token: 0x0400014A RID: 330
		BOOL_PARENT,
		// Token: 0x0400014B RID: 331
		NAME_PARENT = 4U,
		// Token: 0x0400014C RID: 332
		EMPTY = 8U,
		// Token: 0x0400014D RID: 333
		NO_ENTITIES = 16U,
		// Token: 0x0400014E RID: 334
		HEAD = 32U,
		// Token: 0x0400014F RID: 335
		BLOCK_WS = 64U,
		// Token: 0x04000150 RID: 336
		HAS_NS = 128U
	}
}
