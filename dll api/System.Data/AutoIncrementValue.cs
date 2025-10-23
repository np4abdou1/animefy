using System;

namespace System.Data
{
	// Token: 0x02000010 RID: 16
	internal abstract class AutoIncrementValue
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005963 File Offset: 0x00003B63
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000596B File Offset: 0x00003B6B
		internal bool Auto { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DD RID: 221
		// (set) Token: 0x060000DE RID: 222
		internal abstract object Current { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DF RID: 223
		// (set) Token: 0x060000E0 RID: 224
		internal abstract long Seed { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E1 RID: 225
		// (set) Token: 0x060000E2 RID: 226
		internal abstract long Step { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E3 RID: 227
		internal abstract Type DataType { get; }

		// Token: 0x060000E4 RID: 228
		internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

		// Token: 0x060000E5 RID: 229
		internal abstract void SetCurrentAndIncrement(object value);

		// Token: 0x060000E6 RID: 230
		internal abstract void MoveAfter();

		// Token: 0x060000E7 RID: 231 RVA: 0x00005974 File Offset: 0x00003B74
		internal AutoIncrementValue Clone()
		{
			AutoIncrementInt64 autoIncrementInt = (this is AutoIncrementInt64) ? new AutoIncrementInt64() : new AutoIncrementBigInteger();
			autoIncrementInt.Auto = this.Auto;
			autoIncrementInt.Seed = this.Seed;
			autoIncrementInt.Step = this.Step;
			autoIncrementInt.Current = this.Current;
			return autoIncrementInt;
		}
	}
}
