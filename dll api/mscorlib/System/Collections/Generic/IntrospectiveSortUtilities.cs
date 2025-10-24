using System;

namespace System.Collections.Generic
{
	// Token: 0x0200063A RID: 1594
	internal static class IntrospectiveSortUtilities
	{
		// Token: 0x06003069 RID: 12393 RVA: 0x000C37E8 File Offset: 0x000C19E8
		internal static int FloorLog2PlusOne(int n)
		{
			int num = 0;
			while (n >= 1)
			{
				num++;
				n /= 2;
			}
			return num;
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x000C3807 File Offset: 0x000C1A07
		internal static void ThrowOrIgnoreBadComparer(object comparer)
		{
			throw new ArgumentException(SR.Format("Unable to sort because the IComparer.Compare() method returns inconsistent results. Either a value does not compare equal to itself, or one value repeatedly compared to another value yields different results. IComparer: '{0}'.", comparer));
		}
	}
}
