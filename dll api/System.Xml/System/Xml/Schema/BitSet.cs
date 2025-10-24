using System;

namespace System.Xml.Schema
{
	// Token: 0x02000229 RID: 553
	internal sealed class BitSet
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x0000A20E File Offset: 0x0000840E
		private BitSet()
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00070C68 File Offset: 0x0006EE68
		public BitSet(int count)
		{
			this.count = count;
			this.bits = new uint[this.Subscript(count + 31)];
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00070C8C File Offset: 0x0006EE8C
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x170003C9 RID: 969
		public bool this[int index]
		{
			get
			{
				return this.Get(index);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00070CA0 File Offset: 0x0006EEA0
		public void Clear()
		{
			int num = this.bits.Length;
			while (num-- > 0)
			{
				this.bits[num] = 0U;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00070CCC File Offset: 0x0006EECC
		public void Set(int index)
		{
			int num = this.Subscript(index);
			this.EnsureLength(num + 1);
			this.bits[num] |= 1U << index;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00070D04 File Offset: 0x0006EF04
		public bool Get(int index)
		{
			bool result = false;
			if (index < this.count)
			{
				int num = this.Subscript(index);
				result = (((ulong)this.bits[num] & (ulong)(1L << (index & 31 & 31))) > 0UL);
			}
			return result;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00070D40 File Offset: 0x0006EF40
		public int NextSet(int startFrom)
		{
			int num = startFrom + 1;
			if (num == this.count)
			{
				return -1;
			}
			int num2 = this.Subscript(num);
			num &= 31;
			uint num3;
			for (num3 = this.bits[num2] >> num; num3 == 0U; num3 = this.bits[num2])
			{
				if (++num2 == this.bits.Length)
				{
					return -1;
				}
				num = 0;
			}
			while ((num3 & 1U) == 0U)
			{
				num3 >>= 1;
				num++;
			}
			return (num2 << 5) + num;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00070DAC File Offset: 0x0006EFAC
		public void And(BitSet other)
		{
			if (this == other)
			{
				return;
			}
			int num = this.bits.Length;
			int num2 = other.bits.Length;
			int i = (num > num2) ? num2 : num;
			int num3 = i;
			while (num3-- > 0)
			{
				this.bits[num3] &= other.bits[num3];
			}
			while (i < num)
			{
				this.bits[i] = 0U;
				i++;
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00070E10 File Offset: 0x0006F010
		public void Or(BitSet other)
		{
			if (this == other)
			{
				return;
			}
			int num = other.bits.Length;
			this.EnsureLength(num);
			int num2 = num;
			while (num2-- > 0)
			{
				this.bits[num2] |= other.bits[num2];
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00070E58 File Offset: 0x0006F058
		public override int GetHashCode()
		{
			int num = 1234;
			int num2 = this.bits.Length;
			while (--num2 >= 0)
			{
				num ^= (int)(this.bits[num2] * (uint)(num2 + 1));
			}
			return num ^ num;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00070E90 File Offset: 0x0006F090
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			BitSet bitSet = (BitSet)obj;
			int num = this.bits.Length;
			int num2 = bitSet.bits.Length;
			int num3 = (num > num2) ? num2 : num;
			int num4 = num3;
			while (num4-- > 0)
			{
				if (this.bits[num4] != bitSet.bits[num4])
				{
					return false;
				}
			}
			if (num > num3)
			{
				int num5 = num;
				while (num5-- > num3)
				{
					if (this.bits[num5] != 0U)
					{
						return false;
					}
				}
			}
			else
			{
				int num6 = num2;
				while (num6-- > num3)
				{
					if (bitSet.bits[num6] != 0U)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00070F31 File Offset: 0x0006F131
		public BitSet Clone()
		{
			return new BitSet
			{
				count = this.count,
				bits = (uint[])this.bits.Clone()
			};
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00070F5C File Offset: 0x0006F15C
		public bool IsEmpty
		{
			get
			{
				uint num = 0U;
				for (int i = 0; i < this.bits.Length; i++)
				{
					num |= this.bits[i];
				}
				return num == 0U;
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00070F90 File Offset: 0x0006F190
		public bool Intersects(BitSet other)
		{
			int num = Math.Min(this.bits.Length, other.bits.Length);
			while (--num >= 0)
			{
				if ((this.bits[num] & other.bits[num]) != 0U)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00070FD3 File Offset: 0x0006F1D3
		private int Subscript(int bitIndex)
		{
			return bitIndex >> 5;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00070FD8 File Offset: 0x0006F1D8
		private void EnsureLength(int nRequiredLength)
		{
			if (nRequiredLength > this.bits.Length)
			{
				int num = 2 * this.bits.Length;
				if (num < nRequiredLength)
				{
					num = nRequiredLength;
				}
				uint[] destinationArray = new uint[num];
				Array.Copy(this.bits, destinationArray, this.bits.Length);
				this.bits = destinationArray;
			}
		}

		// Token: 0x04000C63 RID: 3171
		private int count;

		// Token: 0x04000C64 RID: 3172
		private uint[] bits;
	}
}
