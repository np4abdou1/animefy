using System;

namespace System
{
	// Token: 0x020000CB RID: 203
	internal enum LazyState
	{
		// Token: 0x04000316 RID: 790
		NoneViaConstructor,
		// Token: 0x04000317 RID: 791
		NoneViaFactory,
		// Token: 0x04000318 RID: 792
		NoneException,
		// Token: 0x04000319 RID: 793
		PublicationOnlyViaConstructor,
		// Token: 0x0400031A RID: 794
		PublicationOnlyViaFactory,
		// Token: 0x0400031B RID: 795
		PublicationOnlyWait,
		// Token: 0x0400031C RID: 796
		PublicationOnlyException,
		// Token: 0x0400031D RID: 797
		ExecutionAndPublicationViaConstructor,
		// Token: 0x0400031E RID: 798
		ExecutionAndPublicationViaFactory,
		// Token: 0x0400031F RID: 799
		ExecutionAndPublicationException
	}
}
