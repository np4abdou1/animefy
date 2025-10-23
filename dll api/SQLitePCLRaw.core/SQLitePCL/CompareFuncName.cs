using System;
using System.Collections.Generic;

namespace SQLitePCL
{
	// Token: 0x02000030 RID: 48
	internal class CompareFuncName : EqualityComparer<FuncName>
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x000034CA File Offset: 0x000016CA
		public CompareFuncName(IEqualityComparer<byte[]> ptrlencmp)
		{
			this._ptrlencmp = ptrlencmp;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000034D9 File Offset: 0x000016D9
		public override bool Equals(FuncName p1, FuncName p2)
		{
			return p1.n == p2.n && this._ptrlencmp.Equals(p1.name, p2.name);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00003502 File Offset: 0x00001702
		public override int GetHashCode(FuncName p)
		{
			return p.n + p.name.Length;
		}

		// Token: 0x040000E8 RID: 232
		private IEqualityComparer<byte[]> _ptrlencmp;
	}
}
