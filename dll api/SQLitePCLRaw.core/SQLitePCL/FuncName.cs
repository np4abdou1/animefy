using System;

namespace SQLitePCL
{
	// Token: 0x0200002F RID: 47
	internal class FuncName
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00003492 File Offset: 0x00001692
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0000349A File Offset: 0x0000169A
		public byte[] name { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000034A3 File Offset: 0x000016A3
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000034AB File Offset: 0x000016AB
		public int n { get; private set; }

		// Token: 0x060001CF RID: 463 RVA: 0x000034B4 File Offset: 0x000016B4
		public FuncName(byte[] _name, int _n)
		{
			this.name = _name;
			this.n = _n;
		}
	}
}
