using System;

namespace System.Reflection
{
	// Token: 0x020004E1 RID: 1249
	[Flags]
	internal enum PInfo
	{
		// Token: 0x0400114D RID: 4429
		Attributes = 1,
		// Token: 0x0400114E RID: 4430
		GetMethod = 2,
		// Token: 0x0400114F RID: 4431
		SetMethod = 4,
		// Token: 0x04001150 RID: 4432
		ReflectedType = 8,
		// Token: 0x04001151 RID: 4433
		DeclaringType = 16,
		// Token: 0x04001152 RID: 4434
		Name = 32
	}
}
