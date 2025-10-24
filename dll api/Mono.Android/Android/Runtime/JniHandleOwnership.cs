using System;

namespace Android.Runtime
{
	// Token: 0x020002E7 RID: 743
	[Flags]
	public enum JniHandleOwnership
	{
		// Token: 0x04000C32 RID: 3122
		DoNotTransfer = 0,
		// Token: 0x04000C33 RID: 3123
		TransferLocalRef = 1,
		// Token: 0x04000C34 RID: 3124
		TransferGlobalRef = 2,
		// Token: 0x04000C35 RID: 3125
		DoNotRegister = 16
	}
}
