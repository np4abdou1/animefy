using System;
using System.Text;

namespace System.Collections.Specialized
{
	/// <summary>Provides a simple structure that stores Boolean values and small integers in 32 bits of memory.</summary>
	// Token: 0x020002BF RID: 703
	public struct BitVector32
	{
		/// <summary>Gets or sets the state of the bit flag indicated by the specified mask.</summary>
		/// <param name="bit">A mask that indicates the bit to get or set. </param>
		/// <returns>
		///     <see langword="true" /> if the specified bit flag is on (1); otherwise, <see langword="false" />.</returns>
		// Token: 0x170003B3 RID: 947
		public bool this[int bit]
		{
			get
			{
				return ((ulong)this._data & (ulong)((long)bit)) == (ulong)bit;
			}
			set
			{
				if (value)
				{
					this._data |= (uint)bit;
					return;
				}
				this._data &= (uint)(~(uint)bit);
			}
		}

		/// <summary>Creates the first mask in a series of masks that can be used to retrieve individual bits in a <see cref="T:System.Collections.Specialized.BitVector32" /> that is set up as bit flags.</summary>
		/// <returns>A mask that isolates the first bit flag in the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x060012AF RID: 4783 RVA: 0x0005968A File Offset: 0x0005788A
		public static int CreateMask()
		{
			return BitVector32.CreateMask(0);
		}

		/// <summary>Creates an additional mask following the specified mask in a series of masks that can be used to retrieve individual bits in a <see cref="T:System.Collections.Specialized.BitVector32" /> that is set up as bit flags.</summary>
		/// <param name="previous">The mask that indicates the previous bit flag. </param>
		/// <returns>A mask that isolates the bit flag following the one that <paramref name="previous" /> points to in <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="previous" /> indicates the last bit flag in the <see cref="T:System.Collections.Specialized.BitVector32" />. </exception>
		// Token: 0x060012B0 RID: 4784 RVA: 0x00059692 File Offset: 0x00057892
		public static int CreateMask(int previous)
		{
			if (previous == 0)
			{
				return 1;
			}
			if (previous == -2147483648)
			{
				throw new InvalidOperationException("Bit vector is full.");
			}
			return previous << 1;
		}

		/// <summary>Determines whether the specified object is equal to the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <param name="o">The object to compare with the current <see cref="T:System.Collections.Specialized.BitVector32" />. </param>
		/// <returns>
		///     <see langword="true" /> if the specified object is equal to the <see cref="T:System.Collections.Specialized.BitVector32" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060012B1 RID: 4785 RVA: 0x000596AF File Offset: 0x000578AF
		public override bool Equals(object o)
		{
			return o is BitVector32 && this._data == ((BitVector32)o)._data;
		}

		/// <summary>Serves as a hash function for the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A hash code for the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x060012B2 RID: 4786 RVA: 0x000596CE File Offset: 0x000578CE
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Returns a string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <param name="value">The <see cref="T:System.Collections.Specialized.BitVector32" /> to represent. </param>
		/// <returns>A string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x060012B3 RID: 4787 RVA: 0x000596E0 File Offset: 0x000578E0
		public static string ToString(BitVector32 value)
		{
			StringBuilder stringBuilder = new StringBuilder(45);
			stringBuilder.Append("BitVector32{");
			int num = (int)value._data;
			for (int i = 0; i < 32; i++)
			{
				if (((long)num & (long)((ulong)-2147483648)) != 0L)
				{
					stringBuilder.Append('1');
				}
				else
				{
					stringBuilder.Append('0');
				}
				num <<= 1;
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x060012B4 RID: 4788 RVA: 0x00059747 File Offset: 0x00057947
		public override string ToString()
		{
			return BitVector32.ToString(this);
		}

		// Token: 0x04000D13 RID: 3347
		private uint _data;
	}
}
