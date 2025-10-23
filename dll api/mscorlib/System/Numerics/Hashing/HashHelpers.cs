using System;

namespace System.Numerics.Hashing
{
	// Token: 0x02000520 RID: 1312
	internal static class HashHelpers
	{
		// Token: 0x060026C2 RID: 9922 RVA: 0x0009AD6B File Offset: 0x00098F6B
		public static int Combine(int h1, int h2)
		{
			return (h1 << 5 | (int)((uint)h1 >> 27)) + h1 ^ h2;
		}

		// Token: 0x04001429 RID: 5161
		public static readonly int RandomSeed = new Random().Next(int.MinValue, int.MaxValue);
	}
}
