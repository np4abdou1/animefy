using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F7 RID: 1015
	[Flags]
	[Serializable]
	internal enum MessageEnum
	{
		// Token: 0x04000E6E RID: 3694
		NoArgs = 1,
		// Token: 0x04000E6F RID: 3695
		ArgsInline = 2,
		// Token: 0x04000E70 RID: 3696
		ArgsIsArray = 4,
		// Token: 0x04000E71 RID: 3697
		ArgsInArray = 8,
		// Token: 0x04000E72 RID: 3698
		NoContext = 16,
		// Token: 0x04000E73 RID: 3699
		ContextInline = 32,
		// Token: 0x04000E74 RID: 3700
		ContextInArray = 64,
		// Token: 0x04000E75 RID: 3701
		MethodSignatureInArray = 128,
		// Token: 0x04000E76 RID: 3702
		PropertyInArray = 256,
		// Token: 0x04000E77 RID: 3703
		NoReturnValue = 512,
		// Token: 0x04000E78 RID: 3704
		ReturnValueVoid = 1024,
		// Token: 0x04000E79 RID: 3705
		ReturnValueInline = 2048,
		// Token: 0x04000E7A RID: 3706
		ReturnValueInArray = 4096,
		// Token: 0x04000E7B RID: 3707
		ExceptionInArray = 8192,
		// Token: 0x04000E7C RID: 3708
		GenericMethod = 32768
	}
}
