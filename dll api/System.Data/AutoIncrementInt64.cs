using System;
using System.Data.Common;
using System.Globalization;
using System.Numerics;

namespace System.Data
{
	// Token: 0x02000011 RID: 17
	internal sealed class AutoIncrementInt64 : AutoIncrementValue
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000059C5 File Offset: 0x00003BC5
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000059D2 File Offset: 0x00003BD2
		internal override object Current
		{
			get
			{
				return this._current;
			}
			set
			{
				this._current = (long)value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000059E0 File Offset: 0x00003BE0
		internal override Type DataType
		{
			get
			{
				return typeof(long);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000059EC File Offset: 0x00003BEC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000059F4 File Offset: 0x00003BF4
		internal override long Seed
		{
			get
			{
				return this._seed;
			}
			set
			{
				if (this._current == this._seed || this.BoundaryCheck(value))
				{
					this._current = value;
				}
				this._seed = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005A20 File Offset: 0x00003C20
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00005A28 File Offset: 0x00003C28
		internal override long Step
		{
			get
			{
				return this._step;
			}
			set
			{
				if (value == 0L)
				{
					throw ExceptionBuilder.AutoIncrementSeed();
				}
				if (this._step != value)
				{
					if (this._current != this.Seed)
					{
						this._current = this._current - this._step + value;
					}
					this._step = value;
				}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005A66 File Offset: 0x00003C66
		internal override void MoveAfter()
		{
			this._current += this._step;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005A7B File Offset: 0x00003C7B
		internal override void SetCurrent(object value, IFormatProvider formatProvider)
		{
			this._current = Convert.ToInt64(value, formatProvider);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005A8C File Offset: 0x00003C8C
		internal override void SetCurrentAndIncrement(object value)
		{
			long num = (long)SqlConvert.ChangeType2(value, StorageType.Int64, typeof(long), CultureInfo.InvariantCulture);
			if (this.BoundaryCheck(num))
			{
				this._current = num + this._step;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005AD2 File Offset: 0x00003CD2
		private bool BoundaryCheck(BigInteger value)
		{
			return (this._step < 0L && value <= this._current) || (0L < this._step && this._current <= value);
		}

		// Token: 0x04000047 RID: 71
		private long _current;

		// Token: 0x04000048 RID: 72
		private long _seed;

		// Token: 0x04000049 RID: 73
		private long _step = 1L;
	}
}
