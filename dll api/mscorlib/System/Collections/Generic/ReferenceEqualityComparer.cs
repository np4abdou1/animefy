using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x0200062E RID: 1582
	internal sealed class ReferenceEqualityComparer<T> : IEqualityComparer<T> where T : class
	{
		// Token: 0x0600301C RID: 12316 RVA: 0x00003ACD File Offset: 0x00001CCD
		private ReferenceEqualityComparer()
		{
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x000C27F8 File Offset: 0x000C09F8
		public bool Equals(T x, T y)
		{
			return x == y;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x000C2808 File Offset: 0x000C0A08
		public int GetHashCode(T obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}

		// Token: 0x0400192B RID: 6443
		internal static readonly ReferenceEqualityComparer<T> Instance = new ReferenceEqualityComparer<T>();
	}
}
