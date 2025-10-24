using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x02000097 RID: 151
	[Flags]
	internal enum DynamicallyAccessedMemberTypes
	{
		// Token: 0x0400001D RID: 29
		None = 0,
		// Token: 0x0400001E RID: 30
		PublicParameterlessConstructor = 1,
		// Token: 0x0400001F RID: 31
		PublicConstructors = 3,
		// Token: 0x04000020 RID: 32
		NonPublicConstructors = 4,
		// Token: 0x04000021 RID: 33
		PublicMethods = 8,
		// Token: 0x04000022 RID: 34
		NonPublicMethods = 16,
		// Token: 0x04000023 RID: 35
		PublicFields = 32,
		// Token: 0x04000024 RID: 36
		NonPublicFields = 64,
		// Token: 0x04000025 RID: 37
		PublicNestedTypes = 128,
		// Token: 0x04000026 RID: 38
		NonPublicNestedTypes = 256,
		// Token: 0x04000027 RID: 39
		PublicProperties = 512,
		// Token: 0x04000028 RID: 40
		NonPublicProperties = 1024,
		// Token: 0x04000029 RID: 41
		PublicEvents = 2048,
		// Token: 0x0400002A RID: 42
		NonPublicEvents = 4096,
		// Token: 0x0400002B RID: 43
		All = -1
	}
}
