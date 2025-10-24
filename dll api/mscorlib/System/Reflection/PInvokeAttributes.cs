using System;

namespace System.Reflection
{
	// Token: 0x020004CC RID: 1228
	[Flags]
	[Serializable]
	internal enum PInvokeAttributes
	{
		// Token: 0x040010D9 RID: 4313
		NoMangle = 1,
		// Token: 0x040010DA RID: 4314
		CharSetMask = 6,
		// Token: 0x040010DB RID: 4315
		CharSetNotSpec = 0,
		// Token: 0x040010DC RID: 4316
		CharSetAnsi = 2,
		// Token: 0x040010DD RID: 4317
		CharSetUnicode = 4,
		// Token: 0x040010DE RID: 4318
		CharSetAuto = 6,
		// Token: 0x040010DF RID: 4319
		BestFitUseAssem = 0,
		// Token: 0x040010E0 RID: 4320
		BestFitEnabled = 16,
		// Token: 0x040010E1 RID: 4321
		BestFitDisabled = 32,
		// Token: 0x040010E2 RID: 4322
		BestFitMask = 48,
		// Token: 0x040010E3 RID: 4323
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x040010E4 RID: 4324
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x040010E5 RID: 4325
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x040010E6 RID: 4326
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x040010E7 RID: 4327
		SupportsLastError = 64,
		// Token: 0x040010E8 RID: 4328
		CallConvMask = 1792,
		// Token: 0x040010E9 RID: 4329
		CallConvWinapi = 256,
		// Token: 0x040010EA RID: 4330
		CallConvCdecl = 512,
		// Token: 0x040010EB RID: 4331
		CallConvStdcall = 768,
		// Token: 0x040010EC RID: 4332
		CallConvThiscall = 1024,
		// Token: 0x040010ED RID: 4333
		CallConvFastcall = 1280,
		// Token: 0x040010EE RID: 4334
		MaxValue = 65535
	}
}
