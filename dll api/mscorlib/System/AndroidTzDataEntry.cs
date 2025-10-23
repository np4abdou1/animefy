using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000182 RID: 386
	[StructLayout(0, Pack = 1)]
	internal struct AndroidTzDataEntry
	{
		// Token: 0x040005B8 RID: 1464
		[FixedBuffer(typeof(byte), 40)]
		public AndroidTzDataEntry.<id>e__FixedBuffer id;

		// Token: 0x040005B9 RID: 1465
		public int byteOffset;

		// Token: 0x040005BA RID: 1466
		public int length;

		// Token: 0x040005BB RID: 1467
		public int rawUtcOffset;

		// Token: 0x02000183 RID: 387
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(0, Size = 40)]
		public struct <id>e__FixedBuffer
		{
			// Token: 0x040005BC RID: 1468
			public byte FixedElementField;
		}
	}
}
