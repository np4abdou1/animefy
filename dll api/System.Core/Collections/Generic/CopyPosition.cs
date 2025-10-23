using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x02000146 RID: 326
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	internal readonly struct CopyPosition
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x00026BEC File Offset: 0x00024DEC
		internal CopyPosition(int row, int column)
		{
			this.Row = row;
			this.Column = column;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00026BFC File Offset: 0x00024DFC
		public static CopyPosition Start
		{
			get
			{
				return default(CopyPosition);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00026C12 File Offset: 0x00024E12
		internal int Row { get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00026C1A File Offset: 0x00024E1A
		internal int Column { get; }

		// Token: 0x06000A64 RID: 2660 RVA: 0x00026C22 File Offset: 0x00024E22
		public CopyPosition Normalize(int endColumn)
		{
			if (this.Column != endColumn)
			{
				return this;
			}
			return new CopyPosition(this.Row + 1, 0);
		}
	}
}
