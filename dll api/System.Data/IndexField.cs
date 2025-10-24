using System;

namespace System.Data
{
	// Token: 0x0200008D RID: 141
	internal readonly struct IndexField
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x0002A9E2 File Offset: 0x00028BE2
		internal IndexField(DataColumn column, bool isDescending)
		{
			this.Column = column;
			this.IsDescending = isDescending;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0002A9F2 File Offset: 0x00028BF2
		public static bool operator ==(IndexField if1, IndexField if2)
		{
			return if1.Column == if2.Column && if1.IsDescending == if2.IsDescending;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0002AA12 File Offset: 0x00028C12
		public override bool Equals(object obj)
		{
			return obj is IndexField && this == (IndexField)obj;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0002AA2F File Offset: 0x00028C2F
		public override int GetHashCode()
		{
			return this.Column.GetHashCode() ^ this.IsDescending.GetHashCode();
		}

		// Token: 0x040002DA RID: 730
		public readonly DataColumn Column;

		// Token: 0x040002DB RID: 731
		public readonly bool IsDescending;
	}
}
