using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000180 RID: 384
	[StructLayout(0, Pack = 1)]
	internal struct AndroidTzDataHeader
	{
		// Token: 0x040005B3 RID: 1459
		[FixedBuffer(typeof(byte), 12)]
		public AndroidTzDataHeader.<signature>e__FixedBuffer signature;

		// Token: 0x040005B4 RID: 1460
		public int indexOffset;

		// Token: 0x040005B5 RID: 1461
		public int dataOffset;

		// Token: 0x040005B6 RID: 1462
		public int zoneTabOffset;

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(0, Size = 12)]
		public struct <signature>e__FixedBuffer
		{
			// Token: 0x040005B7 RID: 1463
			public byte FixedElementField;
		}
	}
}
