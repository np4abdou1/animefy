using System;
using System.Data.Common;
using System.Numerics;

namespace System.Data
{
	// Token: 0x02000012 RID: 18
	internal sealed class AutoIncrementBigInteger : AutoIncrementValue
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005B16 File Offset: 0x00003D16
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005B23 File Offset: 0x00003D23
		internal override object Current
		{
			get
			{
				return this._current;
			}
			set
			{
				this._current = (BigInteger)value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005B31 File Offset: 0x00003D31
		internal override Type DataType
		{
			get
			{
				return typeof(BigInteger);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005B3D File Offset: 0x00003D3D
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00005B45 File Offset: 0x00003D45
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00005B7B File Offset: 0x00003D7B
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00005B88 File Offset: 0x00003D88
		internal override long Step
		{
			get
			{
				return (long)this._step;
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

		// Token: 0x060000FC RID: 252 RVA: 0x00005BED File Offset: 0x00003DED
		internal override void MoveAfter()
		{
			this._current += this._step;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005C06 File Offset: 0x00003E06
		internal override void SetCurrent(object value, IFormatProvider formatProvider)
		{
			this._current = BigIntegerStorage.ConvertToBigInteger(value, formatProvider);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005C18 File Offset: 0x00003E18
		internal override void SetCurrentAndIncrement(object value)
		{
			BigInteger bigInteger = (BigInteger)value;
			if (this.BoundaryCheck(bigInteger))
			{
				this._current = bigInteger + this._step;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005C47 File Offset: 0x00003E47
		private bool BoundaryCheck(BigInteger value)
		{
			return (this._step < 0L && value <= this._current) || (0L < this._step && this._current <= value);
		}

		// Token: 0x0400004A RID: 74
		private BigInteger _current;

		// Token: 0x0400004B RID: 75
		private long _seed;

		// Token: 0x0400004C RID: 76
		private BigInteger _step = 1;
	}
}
