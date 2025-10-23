using System;

namespace System.Xml
{
	// Token: 0x02000011 RID: 17
	internal struct BinXmlSqlDecimal
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002EF2 File Offset: 0x000010F2
		public bool IsPositive
		{
			get
			{
				return this.m_bSign == 0;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F00 File Offset: 0x00001100
		public BinXmlSqlDecimal(byte[] data, int offset, bool trim)
		{
			byte b = data[offset];
			if (b <= 11)
			{
				if (b == 7)
				{
					this.m_bLen = 1;
					goto IL_50;
				}
				if (b == 11)
				{
					this.m_bLen = 2;
					goto IL_50;
				}
			}
			else
			{
				if (b == 15)
				{
					this.m_bLen = 3;
					goto IL_50;
				}
				if (b == 19)
				{
					this.m_bLen = 4;
					goto IL_50;
				}
			}
			throw new XmlException("Unable to parse data as SQL_DECIMAL.", null);
			IL_50:
			this.m_bPrec = data[offset + 1];
			this.m_bScale = data[offset + 2];
			this.m_bSign = ((data[offset + 3] == 0) ? 1 : 0);
			this.m_data1 = BinXmlSqlDecimal.UIntFromByteArray(data, offset + 4);
			this.m_data2 = ((this.m_bLen > 1) ? BinXmlSqlDecimal.UIntFromByteArray(data, offset + 8) : 0U);
			this.m_data3 = ((this.m_bLen > 2) ? BinXmlSqlDecimal.UIntFromByteArray(data, offset + 12) : 0U);
			this.m_data4 = ((this.m_bLen > 3) ? BinXmlSqlDecimal.UIntFromByteArray(data, offset + 16) : 0U);
			if (this.m_bLen == 4 && this.m_data4 == 0U)
			{
				this.m_bLen = 3;
			}
			if (this.m_bLen == 3 && this.m_data3 == 0U)
			{
				this.m_bLen = 2;
			}
			if (this.m_bLen == 2 && this.m_data2 == 0U)
			{
				this.m_bLen = 1;
			}
			if (trim)
			{
				this.TrimTrailingZeros();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003037 File Offset: 0x00001237
		private static uint UIntFromByteArray(byte[] data, int offset)
		{
			return (uint)((int)data[offset] | (int)data[offset + 1] << 8 | (int)data[offset + 2] << 16 | (int)data[offset + 3] << 24);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003058 File Offset: 0x00001258
		private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
		{
			uint num = 0U;
			ulong num2 = (ulong)iulD;
			int i = ciulU;
			while (i > 0)
			{
				i--;
				ulong num3 = ((ulong)num << 32) + (ulong)rgulU[i];
				rgulU[i] = (uint)(num3 / num2);
				num = (uint)(num3 - (ulong)rgulU[i] * num2);
			}
			iulR = num;
			BinXmlSqlDecimal.MpNormalize(rgulU, ref ciulU);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000309D File Offset: 0x0000129D
		private static void MpNormalize(uint[] rgulU, ref int ciulU)
		{
			while (ciulU > 1 && rgulU[ciulU - 1] == 0U)
			{
				ciulU--;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000030B4 File Offset: 0x000012B4
		private static char ChFromDigit(uint uiDigit)
		{
			return (char)(uiDigit + 48U);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000030BC File Offset: 0x000012BC
		public decimal ToDecimal()
		{
			if (this.m_data4 != 0U || this.m_bScale > 28)
			{
				throw new XmlException("Arithmetic Overflow.", null);
			}
			return new decimal((int)this.m_data1, (int)this.m_data2, (int)this.m_data3, !this.IsPositive, this.m_bScale);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003110 File Offset: 0x00001310
		private void TrimTrailingZeros()
		{
			uint[] array = new uint[]
			{
				this.m_data1,
				this.m_data2,
				this.m_data3,
				this.m_data4
			};
			int bLen = (int)this.m_bLen;
			if (bLen == 1 && array[0] == 0U)
			{
				this.m_bScale = 0;
				return;
			}
			while (this.m_bScale > 0 && (bLen > 1 || array[0] != 0U))
			{
				uint num;
				BinXmlSqlDecimal.MpDiv1(array, ref bLen, 10U, out num);
				if (num != 0U)
				{
					break;
				}
				this.m_data1 = array[0];
				this.m_data2 = array[1];
				this.m_data3 = array[2];
				this.m_data4 = array[3];
				this.m_bScale -= 1;
			}
			if (this.m_bLen == 4 && this.m_data4 == 0U)
			{
				this.m_bLen = 3;
			}
			if (this.m_bLen == 3 && this.m_data3 == 0U)
			{
				this.m_bLen = 2;
			}
			if (this.m_bLen == 2 && this.m_data2 == 0U)
			{
				this.m_bLen = 1;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000031FC File Offset: 0x000013FC
		public override string ToString()
		{
			uint[] array = new uint[]
			{
				this.m_data1,
				this.m_data2,
				this.m_data3,
				this.m_data4
			};
			int bLen = (int)this.m_bLen;
			char[] array2 = new char[(int)(BinXmlSqlDecimal.NUMERIC_MAX_PRECISION + 1)];
			int i = 0;
			while (bLen > 1 || array[0] != 0U)
			{
				uint uiDigit;
				BinXmlSqlDecimal.MpDiv1(array, ref bLen, 10U, out uiDigit);
				array2[i++] = BinXmlSqlDecimal.ChFromDigit(uiDigit);
			}
			while (i <= (int)this.m_bScale)
			{
				array2[i++] = BinXmlSqlDecimal.ChFromDigit(0U);
			}
			bool isPositive = this.IsPositive;
			int num = isPositive ? i : (i + 1);
			if (this.m_bScale > 0)
			{
				num++;
			}
			char[] array3 = new char[num];
			int num2 = 0;
			if (!isPositive)
			{
				array3[num2++] = '-';
			}
			while (i > 0)
			{
				if (i-- == (int)this.m_bScale)
				{
					array3[num2++] = '.';
				}
				array3[num2++] = array2[i];
			}
			return new string(array3);
		}

		// Token: 0x04000072 RID: 114
		internal byte m_bLen;

		// Token: 0x04000073 RID: 115
		internal byte m_bPrec;

		// Token: 0x04000074 RID: 116
		internal byte m_bScale;

		// Token: 0x04000075 RID: 117
		internal byte m_bSign;

		// Token: 0x04000076 RID: 118
		internal uint m_data1;

		// Token: 0x04000077 RID: 119
		internal uint m_data2;

		// Token: 0x04000078 RID: 120
		internal uint m_data3;

		// Token: 0x04000079 RID: 121
		internal uint m_data4;

		// Token: 0x0400007A RID: 122
		private static readonly byte NUMERIC_MAX_PRECISION = 38;

		// Token: 0x0400007B RID: 123
		private static readonly byte MaxPrecision = BinXmlSqlDecimal.NUMERIC_MAX_PRECISION;

		// Token: 0x0400007C RID: 124
		private static readonly byte MaxScale = BinXmlSqlDecimal.NUMERIC_MAX_PRECISION;

		// Token: 0x0400007D RID: 125
		private static readonly int x_cNumeMax = 4;

		// Token: 0x0400007E RID: 126
		private static readonly long x_lInt32Base = 4294967296L;

		// Token: 0x0400007F RID: 127
		private static readonly ulong x_ulInt32Base = 4294967296UL;

		// Token: 0x04000080 RID: 128
		private static readonly ulong x_ulInt32BaseForMod = BinXmlSqlDecimal.x_ulInt32Base - 1UL;

		// Token: 0x04000081 RID: 129
		internal static readonly ulong x_llMax = 9223372036854775807UL;

		// Token: 0x04000082 RID: 130
		private static readonly double DUINT_BASE = (double)BinXmlSqlDecimal.x_lInt32Base;

		// Token: 0x04000083 RID: 131
		private static readonly double DUINT_BASE2 = BinXmlSqlDecimal.DUINT_BASE * BinXmlSqlDecimal.DUINT_BASE;

		// Token: 0x04000084 RID: 132
		private static readonly double DUINT_BASE3 = BinXmlSqlDecimal.DUINT_BASE2 * BinXmlSqlDecimal.DUINT_BASE;

		// Token: 0x04000085 RID: 133
		private static readonly uint[] x_rgulShiftBase = new uint[]
		{
			10U,
			100U,
			1000U,
			10000U,
			100000U,
			1000000U,
			10000000U,
			100000000U,
			1000000000U
		};

		// Token: 0x04000086 RID: 134
		private static readonly byte[] rgCLenFromPrec = new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			3,
			3,
			3,
			3,
			3,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4
		};
	}
}
