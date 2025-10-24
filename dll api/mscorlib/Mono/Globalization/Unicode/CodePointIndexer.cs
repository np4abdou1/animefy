using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000032 RID: 50
	internal class CodePointIndexer
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000038AC File Offset: 0x00001AAC
		public CodePointIndexer(int[] starts, int[] ends, int defaultIndex, int defaultCP)
		{
			this.defaultIndex = defaultIndex;
			this.defaultCP = defaultCP;
			this.ranges = new CodePointIndexer.TableRange[starts.Length];
			for (int i = 0; i < this.ranges.Length; i++)
			{
				this.ranges[i] = new CodePointIndexer.TableRange(starts[i], ends[i], (i == 0) ? 0 : (this.ranges[i - 1].IndexStart + this.ranges[i - 1].Count));
			}
			for (int j = 0; j < this.ranges.Length; j++)
			{
				this.TotalCount += this.ranges[j].Count;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003964 File Offset: 0x00001B64
		public int ToIndex(int cp)
		{
			for (int i = 0; i < this.ranges.Length; i++)
			{
				if (cp < this.ranges[i].Start)
				{
					return this.defaultIndex;
				}
				if (cp < this.ranges[i].End)
				{
					return cp - this.ranges[i].Start + this.ranges[i].IndexStart;
				}
			}
			return this.defaultIndex;
		}

		// Token: 0x040000D1 RID: 209
		private readonly CodePointIndexer.TableRange[] ranges;

		// Token: 0x040000D2 RID: 210
		public readonly int TotalCount;

		// Token: 0x040000D3 RID: 211
		private int defaultIndex;

		// Token: 0x040000D4 RID: 212
		private int defaultCP;

		// Token: 0x02000033 RID: 51
		[Serializable]
		internal struct TableRange
		{
			// Token: 0x060000A4 RID: 164 RVA: 0x000039DF File Offset: 0x00001BDF
			public TableRange(int start, int end, int indexStart)
			{
				this.Start = start;
				this.End = end;
				this.Count = this.End - this.Start;
				this.IndexStart = indexStart;
				this.IndexEnd = this.IndexStart + this.Count;
			}

			// Token: 0x040000D5 RID: 213
			public readonly int Start;

			// Token: 0x040000D6 RID: 214
			public readonly int End;

			// Token: 0x040000D7 RID: 215
			public readonly int Count;

			// Token: 0x040000D8 RID: 216
			public readonly int IndexStart;

			// Token: 0x040000D9 RID: 217
			public readonly int IndexEnd;
		}
	}
}
