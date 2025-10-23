using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000149 RID: 329
	internal sealed class ReferenceEqualityComparer<T> : IEqualityComparer<T> where T : class
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x000072DD File Offset: 0x000054DD
		private ReferenceEqualityComparer()
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0002703F File Offset: 0x0002523F
		public bool Equals(T x, T y)
		{
			return x == y;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002704F File Offset: 0x0002524F
		public int GetHashCode(T obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}

		// Token: 0x04000317 RID: 791
		internal static readonly ReferenceEqualityComparer<T> Instance = new ReferenceEqualityComparer<T>();
	}
}
