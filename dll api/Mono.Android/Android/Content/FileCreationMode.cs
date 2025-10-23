using System;

namespace Android.Content
{
	// Token: 0x020002A4 RID: 676
	[Flags]
	public enum FileCreationMode
	{
		// Token: 0x04000B0D RID: 2829
		Append = 32768,
		// Token: 0x04000B0E RID: 2830
		EnableWriteAheadLogging = 8,
		// Token: 0x04000B0F RID: 2831
		MultiProcess = 4,
		// Token: 0x04000B10 RID: 2832
		NoLocalizedCollators = 16,
		// Token: 0x04000B11 RID: 2833
		Private = 0,
		// Token: 0x04000B12 RID: 2834
		WorldReadable = 1,
		// Token: 0x04000B13 RID: 2835
		WorldWriteable = 2
	}
}
