﻿using System;
using System.Data.Common;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a numeric value between - 10^38 +1 and 10^38 - 1, with fixed precision and scale. </summary>
	// Token: 0x020000B7 RID: 183
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlDecimal : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000B57 RID: 2903 RVA: 0x0003F218 File Offset: 0x0003D418
		private byte CalculatePrecision()
		{
			int num;
			uint[] array;
			uint num2;
			if (this._data4 != 0U)
			{
				num = 33;
				array = SqlDecimal.s_decimalHelpersHiHi;
				num2 = this._data4;
			}
			else if (this._data3 != 0U)
			{
				num = 24;
				array = SqlDecimal.s_decimalHelpersHi;
				num2 = this._data3;
			}
			else if (this._data2 != 0U)
			{
				num = 15;
				array = SqlDecimal.s_decimalHelpersMid;
				num2 = this._data2;
			}
			else
			{
				num = 5;
				array = SqlDecimal.s_decimalHelpersLo;
				num2 = this._data1;
			}
			if (num2 < array[num])
			{
				num -= 2;
				if (num2 < array[num])
				{
					num -= 2;
					if (num2 < array[num])
					{
						num--;
					}
					else
					{
						num++;
					}
				}
				else
				{
					num++;
				}
			}
			else
			{
				num += 2;
				if (num2 < array[num])
				{
					num--;
				}
				else
				{
					num++;
				}
			}
			if (num2 >= array[num])
			{
				num++;
				if (num == 37 && num2 >= array[num])
				{
					num++;
				}
			}
			byte b = (byte)(num + 1);
			if (b > 1 && this.VerifyPrecision(b - 1))
			{
				b -= 1;
			}
			return Math.Max(b, this._bScale);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0003F304 File Offset: 0x0003D504
		private bool VerifyPrecision(byte precision)
		{
			int num = (int)(checked(precision - 1));
			if (this._data4 < SqlDecimal.s_decimalHelpersHiHi[num])
			{
				return true;
			}
			if (this._data4 == SqlDecimal.s_decimalHelpersHiHi[num])
			{
				if (this._data3 < SqlDecimal.s_decimalHelpersHi[num])
				{
					return true;
				}
				if (this._data3 == SqlDecimal.s_decimalHelpersHi[num])
				{
					if (this._data2 < SqlDecimal.s_decimalHelpersMid[num])
					{
						return true;
					}
					if (this._data2 == SqlDecimal.s_decimalHelpersMid[num] && this._data1 < SqlDecimal.s_decimalHelpersLo[num])
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0003F388 File Offset: 0x0003D588
		private SqlDecimal(bool fNull)
		{
			this._bLen = (this._bPrec = (this._bScale = 0));
			this._bStatus = 0;
			this._data1 = (this._data2 = (this._data3 = (this._data4 = SqlDecimal.s_uiZero)));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied <see cref="T:System.Decimal" /> value.</summary>
		/// <param name="value">The <see cref="T:System.Decimal" /> value to be stored as a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		// Token: 0x06000B5A RID: 2906 RVA: 0x0003F3DC File Offset: 0x0003D5DC
		public SqlDecimal(decimal value)
		{
			this._bStatus = SqlDecimal.s_bNotNull;
			int[] bits = decimal.GetBits(value);
			uint num = (uint)bits[3];
			this._data1 = (uint)bits[0];
			this._data2 = (uint)bits[1];
			this._data3 = (uint)bits[2];
			this._data4 = SqlDecimal.s_uiZero;
			this._bStatus |= (((num & 2147483648U) == 2147483648U) ? SqlDecimal.s_bNegative : 0);
			if (this._data3 != 0U)
			{
				this._bLen = 3;
			}
			else if (this._data2 != 0U)
			{
				this._bLen = 2;
			}
			else
			{
				this._bLen = 1;
			}
			this._bScale = (byte)((int)(num & 16711680U) >> 16);
			this._bPrec = 0;
			this._bPrec = this.CalculatePrecision();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied integer value.</summary>
		/// <param name="value">The supplied integer value which will the used as the value of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		// Token: 0x06000B5B RID: 2907 RVA: 0x0003F498 File Offset: 0x0003D698
		public SqlDecimal(int value)
		{
			this._bStatus = SqlDecimal.s_bNotNull;
			uint data = (uint)value;
			if (value < 0)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
				if (value != -2147483648)
				{
					data = (uint)(-(uint)value);
				}
			}
			this._data1 = data;
			this._data2 = (this._data3 = (this._data4 = SqlDecimal.s_uiZero));
			this._bLen = 1;
			this._bPrec = SqlDecimal.BGetPrecUI4(this._data1);
			this._bScale = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied long integer value.</summary>
		/// <param name="value">The supplied long integer value which will the used as the value of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		// Token: 0x06000B5C RID: 2908 RVA: 0x0003F518 File Offset: 0x0003D718
		public SqlDecimal(long value)
		{
			this._bStatus = SqlDecimal.s_bNotNull;
			ulong num = (ulong)value;
			if (value < 0L)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
				if (value != -9223372036854775808L)
				{
					num = (ulong)(-(ulong)value);
				}
			}
			this._data1 = (uint)num;
			this._data2 = (uint)(num >> 32);
			this._data3 = (this._data4 = 0U);
			this._bLen = ((this._data2 == 0U) ? 1 : 2);
			this._bPrec = SqlDecimal.BGetPrecUI8(num);
			this._bScale = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied parameters.</summary>
		/// <param name="bPrecision">The maximum number of digits that can be used to represent the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="bScale">The number of decimal places to which the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property will be resolved for the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="fPositive">A Boolean value that indicates whether the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure represents a positive or negative number. </param>
		/// <param name="bits">The 128-bit unsigned integer that provides the value of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" />. </param>
		// Token: 0x06000B5D RID: 2909 RVA: 0x0003F5A4 File Offset: 0x0003D7A4
		public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int[] bits)
		{
			SqlDecimal.CheckValidPrecScale(bPrecision, bScale);
			if (bits == null)
			{
				throw new ArgumentNullException("bits");
			}
			if (bits.Length != 4)
			{
				throw new ArgumentException(SQLResource.InvalidArraySizeMessage, "bits");
			}
			this._bPrec = bPrecision;
			this._bScale = bScale;
			this._data1 = (uint)bits[0];
			this._data2 = (uint)bits[1];
			this._data3 = (uint)bits[2];
			this._data4 = (uint)bits[3];
			this._bLen = 1;
			for (int i = 3; i >= 0; i--)
			{
				if (bits[i] != 0)
				{
					this._bLen = (byte)(i + 1);
					break;
				}
			}
			this._bStatus = SqlDecimal.s_bNotNull;
			if (!fPositive)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
			if (bPrecision < this.CalculatePrecision())
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied parameters.</summary>
		/// <param name="bPrecision">The maximum number of digits that can be used to represent the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="bScale">The number of decimal places to which the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property will be resolved for the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="fPositive">A Boolean value that indicates whether the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure represents a positive or negative number. </param>
		/// <param name="data1">An 32-bit unsigned integer which will be combined with data2, data3, and data4 to make up the 128-bit unsigned integer that represents the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures value. </param>
		/// <param name="data2">An 32-bit unsigned integer which will be combined with data1, data3, and data4 to make up the 128-bit unsigned integer that represents the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures value. </param>
		/// <param name="data3">An 32-bit unsigned integer which will be combined with data1, data2, and data4 to make up the 128-bit unsigned integer that represents the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures value. </param>
		/// <param name="data4">An 32-bit unsigned integer which will be combined with data1, data2, and data3 to make up the 128-bit unsigned integer that represents the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures value. </param>
		// Token: 0x06000B5E RID: 2910 RVA: 0x0003F67C File Offset: 0x0003D87C
		public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int data1, int data2, int data3, int data4)
		{
			SqlDecimal.CheckValidPrecScale(bPrecision, bScale);
			this._bPrec = bPrecision;
			this._bScale = bScale;
			this._data1 = (uint)data1;
			this._data2 = (uint)data2;
			this._data3 = (uint)data3;
			this._data4 = (uint)data4;
			this._bLen = 1;
			if (data4 == 0)
			{
				if (data3 == 0)
				{
					if (data2 == 0)
					{
						this._bLen = 1;
					}
					else
					{
						this._bLen = 2;
					}
				}
				else
				{
					this._bLen = 3;
				}
			}
			else
			{
				this._bLen = 4;
			}
			this._bStatus = SqlDecimal.s_bNotNull;
			if (!fPositive)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
			if (bPrecision < this.CalculatePrecision())
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied double parameter.</summary>
		/// <param name="dVal">A double, representing the value for the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		// Token: 0x06000B5F RID: 2911 RVA: 0x0003F738 File Offset: 0x0003D938
		public SqlDecimal(double dVal)
		{
			this = new SqlDecimal(false);
			this._bStatus = SqlDecimal.s_bNotNull;
			if (dVal < 0.0)
			{
				dVal = -dVal;
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (dVal >= SqlDecimal.s_DMAX_NUME)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			double num = Math.Floor(dVal);
			double num2 = dVal - num;
			this._bPrec = SqlDecimal.s_NUMERIC_MAX_PRECISION;
			this._bLen = 1;
			if (num > 0.0)
			{
				dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
				this._data1 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
				num = dVal;
				if (num > 0.0)
				{
					dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
					this._data2 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
					num = dVal;
					this._bLen += 1;
					if (num > 0.0)
					{
						dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
						this._data3 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
						num = dVal;
						this._bLen += 1;
						if (num > 0.0)
						{
							dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
							this._data4 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
							this._bLen += 1;
						}
					}
				}
			}
			uint num3 = (uint)(this.FZero() ? 0 : this.CalculatePrecision());
			if (num3 > SqlDecimal.s_DBL_DIG)
			{
				uint num4 = num3 - SqlDecimal.s_DBL_DIG;
				uint num5;
				do
				{
					num5 = this.DivByULong(10U);
					num4 -= 1U;
				}
				while (num4 > 0U);
				num4 = num3 - SqlDecimal.s_DBL_DIG;
				if (num5 >= 5U)
				{
					this.AddULong(1U);
					num3 = (uint)this.CalculatePrecision() + num4;
				}
				do
				{
					this.MultByULong(10U);
					num4 -= 1U;
				}
				while (num4 > 0U);
			}
			this._bScale = (byte)((num3 < SqlDecimal.s_DBL_DIG) ? (SqlDecimal.s_DBL_DIG - num3) : 0U);
			this._bPrec = (byte)(num3 + (uint)this._bScale);
			if (this._bScale > 0)
			{
				num3 = (uint)this._bScale;
				do
				{
					uint num6 = (num3 >= 9U) ? 9U : num3;
					num2 *= SqlDecimal.s_rgulShiftBase[(int)(num6 - 1U)];
					num3 -= num6;
					this.MultByULong(SqlDecimal.s_rgulShiftBase[(int)(num6 - 1U)]);
					this.AddULong((uint)num2);
					num2 -= Math.Floor(num2);
				}
				while (num3 > 0U);
			}
			if (num2 >= 0.5)
			{
				this.AddULong(1U);
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0003F994 File Offset: 0x0003DB94
		private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
		{
			SqlDecimal.CheckValidPrecScale(bPrec, bScale);
			this._bLen = bLen;
			this._bPrec = bPrec;
			this._bScale = bScale;
			this._data1 = rglData[0];
			this._data2 = rglData[1];
			this._data3 = rglData[2];
			this._data4 = rglData[3];
			this._bStatus = SqlDecimal.s_bNotNull;
			if (!fPositive)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure is null. Otherwise, <see langword="false" />. </returns>
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0003FA13 File Offset: 0x0003DC13
		public bool IsNull
		{
			get
			{
				return (this._bStatus & SqlDecimal.s_bNullMask) == SqlDecimal.s_bIsNull;
			}
		}

		/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. This property is read-only.</summary>
		/// <returns>A number in the range -79,228,162,514,264,337,593,543,950,335 through 79,228,162,514,162,514,264,337,593,543,950,335.</returns>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0003FA28 File Offset: 0x0003DC28
		public decimal Value
		{
			get
			{
				return this.ToDecimal();
			}
		}

		/// <summary>Indicates whether the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure is greater than zero.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> is assigned to null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0003FA30 File Offset: 0x0003DC30
		public bool IsPositive
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return (this._bStatus & SqlDecimal.s_bSignMask) == SqlDecimal.s_bPositive;
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0003FA53 File Offset: 0x0003DC53
		private void SetPositive()
		{
			this._bStatus &= SqlDecimal.s_bReverseSignMask;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0003FA68 File Offset: 0x0003DC68
		private void SetSignBit(bool fPositive)
		{
			this._bStatus = (fPositive ? (this._bStatus & SqlDecimal.s_bReverseSignMask) : (this._bStatus | SqlDecimal.s_bNegative));
		}

		/// <summary>Gets the maximum number of digits used to represent the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property.</summary>
		/// <returns>The maximum number of digits used to represent the <see langword="Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0003FA8E File Offset: 0x0003DC8E
		public byte Precision
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this._bPrec;
			}
		}

		/// <summary>Gets the number of decimal places to which <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> is resolved.</summary>
		/// <returns>The number of decimal places to which the <see langword="Value" /> property is resolved.</returns>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0003FAA4 File Offset: 0x0003DCA4
		public byte Scale
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this._bScale;
			}
		}

		/// <summary>Gets the binary representation of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure as an array of integers.</summary>
		/// <returns>An array of integers that contains the binary representation of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0003FABA File Offset: 0x0003DCBA
		public int[] Data
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return new int[]
				{
					(int)this._data1,
					(int)this._data2,
					(int)this._data3,
					(int)this._data4
				};
			}
		}

		/// <summary>Get the binary representation of the value of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure as an array of bytes.</summary>
		/// <returns>An array of bytes that contains the binary representation of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's value.</returns>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
		public byte[] BinData
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				int num = (int)this._data1;
				int num2 = (int)this._data2;
				int num3 = (int)this._data3;
				int num4 = (int)this._data4;
				byte[] array = new byte[16];
				array[0] = (byte)(num & 255);
				num >>= 8;
				array[1] = (byte)(num & 255);
				num >>= 8;
				array[2] = (byte)(num & 255);
				num >>= 8;
				array[3] = (byte)(num & 255);
				array[4] = (byte)(num2 & 255);
				num2 >>= 8;
				array[5] = (byte)(num2 & 255);
				num2 >>= 8;
				array[6] = (byte)(num2 & 255);
				num2 >>= 8;
				array[7] = (byte)(num2 & 255);
				array[8] = (byte)(num3 & 255);
				num3 >>= 8;
				array[9] = (byte)(num3 & 255);
				num3 >>= 8;
				array[10] = (byte)(num3 & 255);
				num3 >>= 8;
				array[11] = (byte)(num3 & 255);
				array[12] = (byte)(num4 & 255);
				num4 >>= 8;
				array[13] = (byte)(num4 & 255);
				num4 >>= 8;
				array[14] = (byte)(num4 & 255);
				num4 >>= 8;
				array[15] = (byte)(num4 & 255);
				return array;
			}
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.String" />.</summary>
		/// <returns>A new <see cref="T:System.String" /> object that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property.</returns>
		// Token: 0x06000B6A RID: 2922 RVA: 0x0003FC1C File Offset: 0x0003DE1C
		public override string ToString()
		{
			if (this.IsNull)
			{
				return SQLResource.NullString;
			}
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			int bLen = (int)this._bLen;
			char[] array2 = new char[(int)(SqlDecimal.s_NUMERIC_MAX_PRECISION + 1)];
			int i = 0;
			while (bLen > 1 || array[0] != 0U)
			{
				uint uiDigit;
				SqlDecimal.MpDiv1(array, ref bLen, SqlDecimal.s_ulBase10, out uiDigit);
				array2[i++] = SqlDecimal.ChFromDigit(uiDigit);
			}
			while (i <= (int)this._bScale)
			{
				array2[i++] = SqlDecimal.ChFromDigit(0U);
			}
			int num = 0;
			int num2 = 0;
			if (this._bScale > 0)
			{
				num = 1;
			}
			char[] array3;
			if (this.IsPositive)
			{
				array3 = new char[num + i];
			}
			else
			{
				array3 = new char[num + i + 1];
				array3[num2++] = '-';
			}
			while (i > 0)
			{
				if (i-- == (int)this._bScale)
				{
					array3[num2++] = '.';
				}
				array3[num2++] = array2[i];
			}
			return new string(array3);
		}

		/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its <see cref="T:System.Data.SqlTypes.SqlDecimal" /> equivalent.</summary>
		/// <param name="s">The <see langword="String" /> to be parsed. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> equivalent to the value that is contained in the specified <see cref="T:System.String" />.</returns>
		// Token: 0x06000B6B RID: 2923 RVA: 0x0003FD2C File Offset: 0x0003DF2C
		public static SqlDecimal Parse(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s == SQLResource.NullString)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal @null = SqlDecimal.Null;
			char[] array = s.ToCharArray();
			int num = array.Length;
			int num2 = -1;
			int num3 = 0;
			@null._bPrec = 1;
			@null._bScale = 0;
			@null.SetToZero();
			while (num != 0 && array[num - 1] == ' ')
			{
				num--;
			}
			if (num == 0)
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			while (array[num3] == ' ')
			{
				num3++;
				num--;
			}
			if (array[num3] == '-')
			{
				@null.SetSignBit(false);
				num3++;
				num--;
			}
			else
			{
				@null.SetSignBit(true);
				if (array[num3] == '+')
				{
					num3++;
					num--;
				}
			}
			while (num > 2 && array[num3] == '0')
			{
				num3++;
				num--;
			}
			if (2 == num && '0' == array[num3] && '.' == array[num3 + 1])
			{
				array[num3] = '.';
				array[num3 + 1] = '0';
			}
			if (num == 0 || num > (int)(SqlDecimal.s_NUMERIC_MAX_PRECISION + 1))
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			while (num > 1 && array[num3] == '0')
			{
				num3++;
				num--;
			}
			int i;
			for (i = 0; i < num; i++)
			{
				char c = array[num3];
				num3++;
				if (c >= '0' && c <= '9')
				{
					c -= '0';
					@null.MultByULong(SqlDecimal.s_ulBase10);
					@null.AddULong((uint)c);
				}
				else
				{
					if (c != '.' || num2 >= 0)
					{
						throw new FormatException(SQLResource.FormatMessage);
					}
					num2 = i;
				}
			}
			if (num2 < 0)
			{
				@null._bPrec = (byte)i;
				@null._bScale = 0;
			}
			else
			{
				@null._bPrec = (byte)(i - 1);
				@null._bScale = (byte)((int)@null._bPrec - num2);
			}
			if (@null._bPrec > SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			if (@null._bPrec == 0)
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			if (@null.FZero())
			{
				@null.SetPositive();
			}
			return @null;
		}

		/// <summary>Returns the a double equal to the contents of the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of this instance.</summary>
		/// <returns>The decimal representation of the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property.</returns>
		// Token: 0x06000B6C RID: 2924 RVA: 0x0003FF28 File Offset: 0x0003E128
		public double ToDouble()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			double num = this._data4;
			num = num * (double)SqlDecimal.s_lInt32Base + this._data3;
			num = num * (double)SqlDecimal.s_lInt32Base + this._data2;
			num = num * (double)SqlDecimal.s_lInt32Base + this._data1;
			num /= Math.Pow(10.0, (double)this._bScale);
			if (!this.IsPositive)
			{
				return -num;
			}
			return num;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
		private decimal ToDecimal()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			if (this._data4 != 0U || this._bScale > 28)
			{
				throw new OverflowException(SQLResource.ConversionOverflowMessage);
			}
			return new decimal((int)this._data1, (int)this._data2, (int)this._data3, !this.IsPositive, this._bScale);
		}

		/// <summary>Converts the <see cref="T:System.Decimal" /> value to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Decimal" /> value to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the value of the <see langword="Decimal" /> parameter.</returns>
		// Token: 0x06000B6E RID: 2926 RVA: 0x0004000E File Offset: 0x0003E20E
		public static implicit operator SqlDecimal(decimal x)
		{
			return new SqlDecimal(x);
		}

		/// <summary>Converts the <see cref="T:System.Double" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Double" /> structure to be converted.</param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose value equals the value of the <see cref="T:System.Double" /> parameter.</returns>
		// Token: 0x06000B6F RID: 2927 RVA: 0x00040016 File Offset: 0x0003E216
		public static explicit operator SqlDecimal(double x)
		{
			return new SqlDecimal(x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Int64" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Int64" /> structure to be converted.</param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the value of the <see cref="T:System.Int64" /> parameter.</returns>
		// Token: 0x06000B70 RID: 2928 RVA: 0x0004001E File Offset: 0x0003E21E
		public static implicit operator SqlDecimal(long x)
		{
			return new SqlDecimal(new decimal(x));
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Decimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be converted. </param>
		/// <returns>A new <see langword="Decimal" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000B71 RID: 2929 RVA: 0x0004002B File Offset: 0x0003E22B
		public static explicit operator decimal(SqlDecimal x)
		{
			return x.Value;
		}

		/// <summary>The unary minus operator negates the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be negated. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose value contains the results of the negation.</returns>
		// Token: 0x06000B72 RID: 2930 RVA: 0x00040034 File Offset: 0x0003E234
		public static SqlDecimal operator -(SqlDecimal x)
		{
			if (x.IsNull)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal result = x;
			if (result.FZero())
			{
				result.SetPositive();
			}
			else
			{
				result.SetSignBit(!result.IsPositive);
			}
			return result;
		}

		/// <summary>Calculates the sum of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operators.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the sum.</returns>
		// Token: 0x06000B73 RID: 2931 RVA: 0x00040078 File Offset: 0x0003E278
		public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDecimal.Null;
			}
			bool flag = true;
			bool flag2 = x.IsPositive;
			bool flag3 = y.IsPositive;
			int bScale = (int)x._bScale;
			int bScale2 = (int)y._bScale;
			int num = Math.Max((int)x._bPrec - bScale, (int)y._bPrec - bScale2);
			int num2 = Math.Max(bScale, bScale2);
			int num3 = num + num2 + 1;
			num3 = Math.Min((int)SqlDecimal.MaxPrecision, num3);
			if (num3 - num < num2)
			{
				num2 = num3 - num;
			}
			if (bScale != num2)
			{
				x.AdjustScale(num2 - bScale, true);
			}
			if (bScale2 != num2)
			{
				y.AdjustScale(num2 - bScale2, true);
			}
			if (!flag2)
			{
				flag2 = !flag2;
				flag3 = !flag3;
				flag = !flag;
			}
			int num4 = (int)x._bLen;
			int bLen = (int)y._bLen;
			uint[] array = new uint[]
			{
				x._data1,
				x._data2,
				x._data3,
				x._data4
			};
			uint[] array2 = new uint[]
			{
				y._data1,
				y._data2,
				y._data3,
				y._data4
			};
			byte bLen2;
			if (flag3)
			{
				ulong num5 = 0UL;
				int num6 = 0;
				while (num6 < num4 || num6 < bLen)
				{
					if (num6 < num4)
					{
						num5 += (ulong)array[num6];
					}
					if (num6 < bLen)
					{
						num5 += (ulong)array2[num6];
					}
					array[num6] = (uint)num5;
					num5 >>= 32;
					num6++;
				}
				if (num5 != 0UL)
				{
					if (num6 == SqlDecimal.s_cNumeMax)
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					array[num6] = (uint)num5;
					num6++;
				}
				bLen2 = (byte)num6;
			}
			else
			{
				int num7 = 0;
				if (x.LAbsCmp(y) < 0)
				{
					flag = !flag;
					uint[] array3 = array2;
					array2 = array;
					array = array3;
					num4 = bLen;
					bLen = (int)x._bLen;
				}
				ulong num5 = SqlDecimal.s_ulInt32Base;
				int num6 = 0;
				while (num6 < num4 || num6 < bLen)
				{
					if (num6 < num4)
					{
						num5 += (ulong)array[num6];
					}
					if (num6 < bLen)
					{
						num5 -= (ulong)array2[num6];
					}
					array[num6] = (uint)num5;
					if (array[num6] != 0U)
					{
						num7 = num6;
					}
					num5 >>= 32;
					num5 += SqlDecimal.s_ulInt32BaseForMod;
					num6++;
				}
				bLen2 = (byte)(num7 + 1);
			}
			SqlDecimal result = new SqlDecimal(array, bLen2, (byte)num3, (byte)num2, flag);
			if (result.FGt10_38() || result.CalculatePrecision() > SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (result.FZero())
			{
				result.SetPositive();
			}
			return result;
		}

		/// <summary>Calculates the results of subtracting the second <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose Value property contains the results of the subtraction.</returns>
		// Token: 0x06000B74 RID: 2932 RVA: 0x000402ED File Offset: 0x0003E4ED
		public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y)
		{
			return x + -y;
		}

		/// <summary>The multiplication operator computes the product of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the product of the multiplication.</returns>
		// Token: 0x06000B75 RID: 2933 RVA: 0x000402FC File Offset: 0x0003E4FC
		public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDecimal.Null;
			}
			int bLen = (int)y._bLen;
			int num = (int)(x._bScale + y._bScale);
			int num2 = num;
			int num3 = (int)(x._bPrec - x._bScale + (y._bPrec - y._bScale) + 1);
			int num4 = num2 + num3;
			if (num4 > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				num4 = (int)SqlDecimal.s_NUMERIC_MAX_PRECISION;
			}
			if (num2 > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				num2 = (int)SqlDecimal.s_NUMERIC_MAX_PRECISION;
			}
			num2 = Math.Min(num4 - num3, num2);
			num2 = Math.Max(num2, Math.Min(num, (int)SqlDecimal.s_cNumeDivScaleMin));
			int num5 = num2 - num;
			bool fPositive = x.IsPositive == y.IsPositive;
			uint[] array = new uint[]
			{
				x._data1,
				x._data2,
				x._data3,
				x._data4
			};
			uint[] array2 = new uint[]
			{
				y._data1,
				y._data2,
				y._data3,
				y._data4
			};
			uint[] array3 = new uint[9];
			int i = 0;
			for (int j = 0; j < (int)x._bLen; j++)
			{
				uint num6 = array[j];
				ulong num7 = 0UL;
				i = j;
				for (int k = 0; k < bLen; k++)
				{
					ulong num8 = num7 + (ulong)array3[i];
					ulong num9 = (ulong)array2[k];
					num7 = (ulong)num6 * num9;
					num7 += num8;
					if (num7 < num8)
					{
						num8 = SqlDecimal.s_ulInt32Base;
					}
					else
					{
						num8 = 0UL;
					}
					array3[i++] = (uint)num7;
					num7 = (num7 >> 32) + num8;
				}
				if (num7 != 0UL)
				{
					array3[i++] = (uint)num7;
				}
			}
			while (array3[i] == 0U && i > 0)
			{
				i--;
			}
			int num10 = i + 1;
			if (num5 != 0)
			{
				if (num5 < 0)
				{
					uint num11;
					uint num12;
					do
					{
						if (num5 <= -9)
						{
							num11 = SqlDecimal.s_rgulShiftBase[8];
							num5 += 9;
						}
						else
						{
							num11 = SqlDecimal.s_rgulShiftBase[-num5 - 1];
							num5 = 0;
						}
						SqlDecimal.MpDiv1(array3, ref num10, num11, out num12);
					}
					while (num5 != 0);
					if (num10 > SqlDecimal.s_cNumeMax)
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					for (i = num10; i < SqlDecimal.s_cNumeMax; i++)
					{
						array3[i] = 0U;
					}
					SqlDecimal result = new SqlDecimal(array3, (byte)num10, (byte)num4, (byte)num2, fPositive);
					if (result.FGt10_38())
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					if (num12 >= num11 / 2U)
					{
						result.AddULong(1U);
					}
					if (result.FZero())
					{
						result.SetPositive();
					}
					return result;
				}
				else
				{
					if (num10 > SqlDecimal.s_cNumeMax)
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					for (i = num10; i < SqlDecimal.s_cNumeMax; i++)
					{
						array3[i] = 0U;
					}
					SqlDecimal result = new SqlDecimal(array3, (byte)num10, (byte)num4, (byte)num, fPositive);
					if (result.FZero())
					{
						result.SetPositive();
					}
					result.AdjustScale(num5, true);
					return result;
				}
			}
			else
			{
				if (num10 > SqlDecimal.s_cNumeMax)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
				for (i = num10; i < SqlDecimal.s_cNumeMax; i++)
				{
					array3[i] = 0U;
				}
				SqlDecimal result = new SqlDecimal(array3, (byte)num10, (byte)num4, (byte)num2, fPositive);
				if (result.FGt10_38())
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
				if (result.FZero())
				{
					result.SetPositive();
				}
				return result;
			}
		}

		/// <summary>The division operator calculates the results of dividing the first <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000B76 RID: 2934 RVA: 0x00040640 File Offset: 0x0003E840
		public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (y.FZero())
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			bool fPositive = x.IsPositive == y.IsPositive;
			int num = Math.Max((int)(x._bScale + y._bPrec + 1), (int)SqlDecimal.s_cNumeDivScaleMin);
			int num2 = (int)(x._bPrec - x._bScale + y._bScale);
			int num3 = num + (int)x._bPrec + (int)y._bPrec + 1;
			int val = Math.Min(num, (int)SqlDecimal.s_cNumeDivScaleMin);
			num2 = Math.Min(num2, (int)SqlDecimal.s_NUMERIC_MAX_PRECISION);
			num3 = num2 + num;
			if (num3 > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				num3 = (int)SqlDecimal.s_NUMERIC_MAX_PRECISION;
			}
			num = Math.Min(num3 - num2, num);
			num = Math.Max(num, val);
			int digits = num - (int)x._bScale + (int)y._bScale;
			x.AdjustScale(digits, true);
			uint[] rgulU = new uint[]
			{
				x._data1,
				x._data2,
				x._data3,
				x._data4
			};
			uint[] rgulD = new uint[]
			{
				y._data1,
				y._data2,
				y._data3,
				y._data4
			};
			uint[] rgulR = new uint[SqlDecimal.s_cNumeMax + 1];
			uint[] array = new uint[SqlDecimal.s_cNumeMax];
			int num4;
			int num5;
			SqlDecimal.MpDiv(rgulU, (int)x._bLen, rgulD, (int)y._bLen, array, out num4, rgulR, out num5);
			SqlDecimal.ZeroToMaxLen(array, num4);
			SqlDecimal result = new SqlDecimal(array, (byte)num4, (byte)num3, (byte)num, fPositive);
			if (result.FZero())
			{
				result.SetPositive();
			}
			return result;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000B77 RID: 2935 RVA: 0x000407DF File Offset: 0x0003E9DF
		public static explicit operator SqlDecimal(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((int)x.ByteValue);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000B78 RID: 2936 RVA: 0x000407FC File Offset: 0x0003E9FC
		public static implicit operator SqlDecimal(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((int)x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" /></summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000B79 RID: 2937 RVA: 0x00040819 File Offset: 0x0003EA19
		public static implicit operator SqlDecimal(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((int)x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000B7A RID: 2938 RVA: 0x00040836 File Offset: 0x0003EA36
		public static implicit operator SqlDecimal(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to SqlDecimal.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000B7B RID: 2939 RVA: 0x00040853 File Offset: 0x0003EA53
		public static implicit operator SqlDecimal(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlMoney" /> operand to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000B7C RID: 2940 RVA: 0x00040870 File Offset: 0x0003EA70
		public static implicit operator SqlDecimal(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.ToDecimal());
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000B7D RID: 2941 RVA: 0x0004088D File Offset: 0x0003EA8D
		public static explicit operator SqlDecimal(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((double)x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000B7E RID: 2942 RVA: 0x000408AB File Offset: 0x0003EAAB
		public static explicit operator SqlDecimal(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlString" /> object to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the value represented by the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter.</returns>
		// Token: 0x06000B7F RID: 2943 RVA: 0x000408C8 File Offset: 0x0003EAC8
		public static explicit operator SqlDecimal(SqlString x)
		{
			if (!x.IsNull)
			{
				return SqlDecimal.Parse(x.Value);
			}
			return SqlDecimal.Null;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000408E8 File Offset: 0x0003EAE8
		[Conditional("DEBUG")]
		private void AssertValid()
		{
			if (this.IsNull)
			{
				return;
			}
			object obj = (new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			})[(int)(this._bLen - 1)];
			for (int i = (int)this._bLen; i < SqlDecimal.s_cNumeMax; i++)
			{
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00040948 File Offset: 0x0003EB48
		private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur)
		{
			switch (cUI4sCur)
			{
			case 1:
				rgulData[1] = (rgulData[2] = (rgulData[3] = 0U));
				return;
			case 2:
				rgulData[2] = (rgulData[3] = 0U);
				return;
			case 3:
				rgulData[3] = 0U;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0004098A File Offset: 0x0003EB8A
		private static byte CLenFromPrec(byte bPrec)
		{
			return SqlDecimal.s_rgCLenFromPrec[(int)(bPrec - 1)];
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00040995 File Offset: 0x0003EB95
		private bool FZero()
		{
			return this._data1 == 0U && this._bLen <= 1;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000409B0 File Offset: 0x0003EBB0
		private bool FGt10_38()
		{
			return (ulong)this._data4 >= 1262177448UL && this._bLen == 4 && ((ulong)this._data4 > 1262177448UL || (ulong)this._data3 > 1518781562UL || ((ulong)this._data3 == 1518781562UL && (ulong)this._data2 >= 160047680UL));
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00040A1C File Offset: 0x0003EC1C
		private bool FGt10_38(uint[] rglData)
		{
			return (ulong)rglData[3] >= 1262177448UL && ((ulong)rglData[3] > 1262177448UL || (ulong)rglData[2] > 1518781562UL || ((ulong)rglData[2] == 1518781562UL && (ulong)rglData[1] >= 160047680UL));
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00040A70 File Offset: 0x0003EC70
		private static byte BGetPrecUI4(uint value)
		{
			int num;
			if (value < SqlDecimal.s_ulT4)
			{
				if (value < SqlDecimal.s_ulT2)
				{
					num = ((value >= SqlDecimal.s_ulT1) ? 2 : 1);
				}
				else
				{
					num = ((value >= SqlDecimal.s_ulT3) ? 4 : 3);
				}
			}
			else if (value < SqlDecimal.s_ulT8)
			{
				if (value < SqlDecimal.s_ulT6)
				{
					num = ((value >= SqlDecimal.s_ulT5) ? 6 : 5);
				}
				else
				{
					num = ((value >= SqlDecimal.s_ulT7) ? 8 : 7);
				}
			}
			else
			{
				num = ((value >= SqlDecimal.s_ulT9) ? 10 : 9);
			}
			return (byte)num;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00040AEA File Offset: 0x0003ECEA
		private static byte BGetPrecUI8(uint ulU0, uint ulU1)
		{
			return SqlDecimal.BGetPrecUI8((ulong)ulU0 + ((ulong)ulU1 << 32));
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00040AFC File Offset: 0x0003ECFC
		private static byte BGetPrecUI8(ulong dwlVal)
		{
			int num2;
			if (dwlVal < (ulong)SqlDecimal.s_ulT8)
			{
				uint num = (uint)dwlVal;
				if (num < SqlDecimal.s_ulT4)
				{
					if (num < SqlDecimal.s_ulT2)
					{
						num2 = ((num >= SqlDecimal.s_ulT1) ? 2 : 1);
					}
					else
					{
						num2 = ((num >= SqlDecimal.s_ulT3) ? 4 : 3);
					}
				}
				else if (num < SqlDecimal.s_ulT6)
				{
					num2 = ((num >= SqlDecimal.s_ulT5) ? 6 : 5);
				}
				else
				{
					num2 = ((num >= SqlDecimal.s_ulT7) ? 8 : 7);
				}
			}
			else if (dwlVal < SqlDecimal.s_dwlT16)
			{
				if (dwlVal < SqlDecimal.s_dwlT12)
				{
					if (dwlVal < SqlDecimal.s_dwlT10)
					{
						num2 = ((dwlVal >= (ulong)SqlDecimal.s_ulT9) ? 10 : 9);
					}
					else
					{
						num2 = ((dwlVal >= SqlDecimal.s_dwlT11) ? 12 : 11);
					}
				}
				else if (dwlVal < SqlDecimal.s_dwlT14)
				{
					num2 = ((dwlVal >= SqlDecimal.s_dwlT13) ? 14 : 13);
				}
				else
				{
					num2 = ((dwlVal >= SqlDecimal.s_dwlT15) ? 16 : 15);
				}
			}
			else if (dwlVal < SqlDecimal.s_dwlT18)
			{
				num2 = ((dwlVal >= SqlDecimal.s_dwlT17) ? 18 : 17);
			}
			else
			{
				num2 = ((dwlVal >= SqlDecimal.s_dwlT19) ? 20 : 19);
			}
			return (byte)num2;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00040C04 File Offset: 0x0003EE04
		private void AddULong(uint ulAdd)
		{
			ulong num = (ulong)ulAdd;
			int bLen = (int)this._bLen;
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			int num2 = 0;
			for (;;)
			{
				num += (ulong)array[num2];
				array[num2] = (uint)num;
				num >>= 32;
				if (num == 0UL)
				{
					break;
				}
				num2++;
				if (num2 >= bLen)
				{
					goto Block_2;
				}
			}
			this.StoreFromWorkingArray(array);
			return;
			Block_2:
			if (num2 == SqlDecimal.s_cNumeMax)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			array[num2] = (uint)num;
			this._bLen += 1;
			if (this.FGt10_38(array))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this.StoreFromWorkingArray(array);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00040CB0 File Offset: 0x0003EEB0
		private void MultByULong(uint uiMultiplier)
		{
			int bLen = (int)this._bLen;
			ulong num = 0UL;
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			for (int i = 0; i < bLen; i++)
			{
				ulong num2 = (ulong)array[i] * (ulong)uiMultiplier;
				num += num2;
				if (num < num2)
				{
					num2 = SqlDecimal.s_ulInt32Base;
				}
				else
				{
					num2 = 0UL;
				}
				array[i] = (uint)num;
				num = (num >> 32) + num2;
			}
			if (num != 0UL)
			{
				if (bLen == SqlDecimal.s_cNumeMax)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
				array[bLen] = (uint)num;
				this._bLen += 1;
			}
			if (this.FGt10_38(array))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this.StoreFromWorkingArray(array);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00040D74 File Offset: 0x0003EF74
		private uint DivByULong(uint iDivisor)
		{
			ulong num = (ulong)iDivisor;
			ulong num2 = 0UL;
			bool flag = true;
			if (num == 0UL)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			for (int i = (int)this._bLen; i > 0; i--)
			{
				num2 = (num2 << 32) + (ulong)array[i - 1];
				uint num3 = (uint)(num2 / num);
				array[i - 1] = num3;
				num2 %= num;
				if (flag && num3 == 0U)
				{
					this._bLen -= 1;
				}
				else
				{
					flag = false;
				}
			}
			this.StoreFromWorkingArray(array);
			if (flag)
			{
				this._bLen = 1;
			}
			return (uint)num2;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00040E28 File Offset: 0x0003F028
		internal void AdjustScale(int digits, bool fRound)
		{
			bool flag = false;
			int i = digits;
			if (i + (int)this._bScale < 0)
			{
				throw new SqlTruncateException();
			}
			if (i + (int)this._bScale > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			byte bScale = (byte)(i + (int)this._bScale);
			byte bPrec = (byte)Math.Min((int)SqlDecimal.s_NUMERIC_MAX_PRECISION, Math.Max(1, i + (int)this._bPrec));
			if (i > 0)
			{
				this._bScale = bScale;
				this._bPrec = bPrec;
				while (i > 0)
				{
					uint num;
					if (i >= 9)
					{
						num = SqlDecimal.s_rgulShiftBase[8];
						i -= 9;
					}
					else
					{
						num = SqlDecimal.s_rgulShiftBase[i - 1];
						i = 0;
					}
					this.MultByULong(num);
				}
			}
			else if (i < 0)
			{
				uint num;
				uint num2;
				do
				{
					if (i <= -9)
					{
						num = SqlDecimal.s_rgulShiftBase[8];
						i += 9;
					}
					else
					{
						num = SqlDecimal.s_rgulShiftBase[-i - 1];
						i = 0;
					}
					num2 = this.DivByULong(num);
				}
				while (i < 0);
				flag = (num2 >= num / 2U);
				this._bScale = bScale;
				this._bPrec = bPrec;
			}
			if (flag && fRound)
			{
				this.AddULong(1U);
				return;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
		}

		/// <summary>The scale of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand will be adjusted to the number of digits indicated by the digits parameter. Depending on the value of the fRound parameter, the value will either be rounded to the appropriate number of digits or truncated.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be adjusted. </param>
		/// <param name="digits">The number of digits in the adjusted structure. </param>
		/// <param name="fRound">If this parameter is <see langword="true" />, the new Value will be rounded, if <see langword="false" />, the value will be truncated. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the adjusted number.</returns>
		// Token: 0x06000B8D RID: 2957 RVA: 0x00040F44 File Offset: 0x0003F144
		public static SqlDecimal AdjustScale(SqlDecimal n, int digits, bool fRound)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal result = n;
			result.AdjustScale(digits, fRound);
			return result;
		}

		/// <summary>Adjusts the value of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand to the indicated precision and scale.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose value is to be adjusted. </param>
		/// <param name="precision">The precision for the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="scale">The scale for the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose Value has been adjusted to the precision and scale indicated in the parameters.</returns>
		// Token: 0x06000B8E RID: 2958 RVA: 0x00040F6C File Offset: 0x0003F16C
		public static SqlDecimal ConvertToPrecScale(SqlDecimal n, int precision, int scale)
		{
			SqlDecimal.CheckValidPrecScale(precision, scale);
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal sqlDecimal = n;
			int digits = scale - (int)sqlDecimal._bScale;
			sqlDecimal.AdjustScale(digits, true);
			byte b = SqlDecimal.CLenFromPrec((byte)precision);
			if (b < sqlDecimal._bLen)
			{
				throw new SqlTruncateException();
			}
			if (b == sqlDecimal._bLen && precision < (int)sqlDecimal.CalculatePrecision())
			{
				throw new SqlTruncateException();
			}
			sqlDecimal._bPrec = (byte)precision;
			return sqlDecimal;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		private int LAbsCmp(SqlDecimal snumOp)
		{
			int bLen = (int)snumOp._bLen;
			int bLen2 = (int)this._bLen;
			if (bLen != bLen2)
			{
				if (bLen2 <= bLen)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				uint[] array = new uint[]
				{
					this._data1,
					this._data2,
					this._data3,
					this._data4
				};
				uint[] array2 = new uint[]
				{
					snumOp._data1,
					snumOp._data2,
					snumOp._data3,
					snumOp._data4
				};
				int num = bLen - 1;
				while (array[num] == array2[num])
				{
					num--;
					if (num < 0)
					{
						return 0;
					}
				}
				if (array[num] <= array2[num])
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00041084 File Offset: 0x0003F284
		private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD)
		{
			ciulD = ciulS;
			for (int i = 0; i < ciulS; i++)
			{
				rgulD[i] = rgulS[i];
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000410A6 File Offset: 0x0003F2A6
		private static void MpSet(uint[] rgulD, out int ciulD, uint iulN)
		{
			ciulD = 1;
			rgulD[0] = iulN;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000410AF File Offset: 0x0003F2AF
		private static void MpNormalize(uint[] rgulU, ref int ciulU)
		{
			while (ciulU > 1 && rgulU[ciulU - 1] == 0U)
			{
				ciulU--;
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000410C8 File Offset: 0x0003F2C8
		private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX)
		{
			uint num = 0U;
			int i;
			for (i = 0; i < ciulD; i++)
			{
				ulong num2 = (ulong)piulD[i];
				ulong x = (ulong)num + num2 * (ulong)iulX;
				num = SqlDecimal.HI(x);
				piulD[i] = SqlDecimal.LO(x);
			}
			if (num != 0U)
			{
				piulD[i] = num;
				ciulD++;
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00041110 File Offset: 0x0003F310
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
			SqlDecimal.MpNormalize(rgulU, ref ciulU);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00041155 File Offset: 0x0003F355
		internal static ulong DWL(uint lo, uint hi)
		{
			return (ulong)lo + ((ulong)hi << 32);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0004115F File Offset: 0x0003F35F
		private static uint HI(ulong x)
		{
			return (uint)(x >> 32);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00041166 File Offset: 0x0003F366
		private static uint LO(ulong x)
		{
			return (uint)x;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0004116C File Offset: 0x0003F36C
		private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR)
		{
			if (ciulD == 1 && rgulD[0] == 0U)
			{
				ciulQ = (ciulR = 0);
				return;
			}
			if (ciulU == 1 && ciulD == 1)
			{
				SqlDecimal.MpSet(rgulQ, out ciulQ, rgulU[0] / rgulD[0]);
				SqlDecimal.MpSet(rgulR, out ciulR, rgulU[0] % rgulD[0]);
				return;
			}
			if (ciulD > ciulU)
			{
				SqlDecimal.MpMove(rgulU, ciulU, rgulR, out ciulR);
				SqlDecimal.MpSet(rgulQ, out ciulQ, 0U);
				return;
			}
			if (ciulU <= 2)
			{
				ulong num = SqlDecimal.DWL(rgulU[0], rgulU[1]);
				ulong num2 = (ulong)rgulD[0];
				if (ciulD > 1)
				{
					num2 += (ulong)rgulD[1] << 32;
				}
				ulong x = num / num2;
				rgulQ[0] = SqlDecimal.LO(x);
				rgulQ[1] = SqlDecimal.HI(x);
				ciulQ = ((SqlDecimal.HI(x) != 0U) ? 2 : 1);
				x = num % num2;
				rgulR[0] = SqlDecimal.LO(x);
				rgulR[1] = SqlDecimal.HI(x);
				ciulR = ((SqlDecimal.HI(x) != 0U) ? 2 : 1);
				return;
			}
			if (ciulD == 1)
			{
				SqlDecimal.MpMove(rgulU, ciulU, rgulQ, out ciulQ);
				uint num3;
				SqlDecimal.MpDiv1(rgulQ, ref ciulQ, rgulD[0], out num3);
				rgulR[0] = num3;
				ciulR = 1;
				return;
			}
			ciulQ = (ciulR = 0);
			if (rgulU != rgulR)
			{
				SqlDecimal.MpMove(rgulU, ciulU, rgulR, out ciulR);
			}
			ciulQ = ciulU - ciulD + 1;
			uint num4 = rgulD[ciulD - 1];
			rgulR[ciulU] = 0U;
			int num5 = ciulU;
			uint num6 = (uint)(SqlDecimal.s_ulInt32Base / ((ulong)num4 + 1UL));
			if (num6 > 1U)
			{
				SqlDecimal.MpMul1(rgulD, ref ciulD, num6);
				num4 = rgulD[ciulD - 1];
				SqlDecimal.MpMul1(rgulR, ref ciulR, num6);
			}
			uint num7 = rgulD[ciulD - 2];
			do
			{
				ulong num8 = SqlDecimal.DWL(rgulR[num5 - 1], rgulR[num5]);
				uint num9;
				if (num4 == rgulR[num5])
				{
					num9 = (uint)(SqlDecimal.s_ulInt32Base - 1UL);
				}
				else
				{
					num9 = (uint)(num8 / (ulong)num4);
				}
				ulong num10 = (ulong)num9;
				uint num11 = (uint)(num8 - num10 * (ulong)num4);
				while ((ulong)num7 * num10 > SqlDecimal.DWL(rgulR[num5 - 2], num11))
				{
					num9 -= 1U;
					if (num11 >= -num4)
					{
						break;
					}
					num11 += num4;
					num10 = (ulong)num9;
				}
				num8 = SqlDecimal.s_ulInt32Base;
				ulong num12 = 0UL;
				int i = 0;
				int num13 = num5 - ciulD;
				while (i < ciulD)
				{
					ulong num14 = (ulong)rgulD[i];
					num12 += (ulong)num9 * num14;
					num8 += (ulong)rgulR[num13] - (ulong)SqlDecimal.LO(num12);
					num12 = (ulong)SqlDecimal.HI(num12);
					rgulR[num13] = SqlDecimal.LO(num8);
					num8 = (ulong)SqlDecimal.HI(num8) + SqlDecimal.s_ulInt32Base - 1UL;
					i++;
					num13++;
				}
				num8 += (ulong)rgulR[num13] - num12;
				rgulR[num13] = SqlDecimal.LO(num8);
				rgulQ[num5 - ciulD] = num9;
				if (SqlDecimal.HI(num8) == 0U)
				{
					rgulQ[num5 - ciulD] = num9 - 1U;
					uint num15 = 0U;
					i = 0;
					num13 = num5 - ciulD;
					while (i < ciulD)
					{
						num8 = (ulong)rgulD[i] + (ulong)rgulR[num13] + (ulong)num15;
						num15 = SqlDecimal.HI(num8);
						rgulR[num13] = SqlDecimal.LO(num8);
						i++;
						num13++;
					}
					rgulR[num13] += num15;
				}
				num5--;
			}
			while (num5 >= ciulD);
			SqlDecimal.MpNormalize(rgulQ, ref ciulQ);
			ciulR = ciulD;
			SqlDecimal.MpNormalize(rgulR, ref ciulR);
			if (num6 > 1U)
			{
				uint num16;
				SqlDecimal.MpDiv1(rgulD, ref ciulD, num6, out num16);
				SqlDecimal.MpDiv1(rgulR, ref ciulR, num6, out num16);
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00041488 File Offset: 0x0003F688
		private EComparison CompareNm(SqlDecimal snumOp)
		{
			int num = this.IsPositive ? 1 : -1;
			int num2 = snumOp.IsPositive ? 1 : -1;
			if (num == num2)
			{
				SqlDecimal sqlDecimal = this;
				SqlDecimal snumOp2 = snumOp;
				int num3 = (int)(this._bScale - snumOp._bScale);
				if (num3 < 0)
				{
					try
					{
						sqlDecimal.AdjustScale(-num3, true);
						goto IL_78;
					}
					catch (OverflowException)
					{
						return (num > 0) ? EComparison.GT : EComparison.LT;
					}
				}
				if (num3 > 0)
				{
					try
					{
						snumOp2.AdjustScale(num3, true);
					}
					catch (OverflowException)
					{
						return (num > 0) ? EComparison.LT : EComparison.GT;
					}
				}
				IL_78:
				int num4 = sqlDecimal.LAbsCmp(snumOp2);
				if (num4 == 0)
				{
					return EComparison.EQ;
				}
				if (num * num4 < 0)
				{
					return EComparison.LT;
				}
				return EComparison.GT;
			}
			if (num != 1)
			{
				return EComparison.LT;
			}
			return EComparison.GT;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00041548 File Offset: 0x0003F748
		private static void CheckValidPrecScale(byte bPrec, byte bScale)
		{
			if (bPrec < 1 || bPrec > SqlDecimal.MaxPrecision || bScale < 0 || bScale > SqlDecimal.MaxScale || bScale > bPrec)
			{
				throw new SqlTypeException(SQLResource.InvalidPrecScaleMessage);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00041548 File Offset: 0x0003F748
		private static void CheckValidPrecScale(int iPrec, int iScale)
		{
			if (iPrec < 1 || iPrec > (int)SqlDecimal.MaxPrecision || iScale < 0 || iScale > (int)SqlDecimal.MaxScale || iScale > iPrec)
			{
				throw new SqlTypeException(SQLResource.InvalidPrecScaleMessage);
			}
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operands to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B9C RID: 2972 RVA: 0x00041571 File Offset: 0x0003F771
		public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.CompareNm(y) == EComparison.EQ);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B9D RID: 2973 RVA: 0x0004159B File Offset: 0x0003F79B
		public static SqlBoolean operator !=(SqlDecimal x, SqlDecimal y)
		{
			return !(x == y);
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B9E RID: 2974 RVA: 0x000415A9 File Offset: 0x0003F7A9
		public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.CompareNm(y) == EComparison.LT);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B9F RID: 2975 RVA: 0x000415D3 File Offset: 0x0003F7D3
		public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.CompareNm(y) == EComparison.GT);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BA0 RID: 2976 RVA: 0x00041600 File Offset: 0x0003F800
		public static SqlBoolean operator <=(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = x.CompareNm(y);
			return new SqlBoolean(ecomparison == EComparison.LT || ecomparison == EComparison.EQ);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BA1 RID: 2977 RVA: 0x00041640 File Offset: 0x0003F840
		public static SqlBoolean operator >=(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = x.CompareNm(y);
			return new SqlBoolean(ecomparison == EComparison.GT || ecomparison == EComparison.EQ);
		}

		/// <summary>Calculates the sum of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operators.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the sum.</returns>
		// Token: 0x06000BA2 RID: 2978 RVA: 0x0004167E File Offset: 0x0003F87E
		public static SqlDecimal Add(SqlDecimal x, SqlDecimal y)
		{
			return x + y;
		}

		/// <summary>Calculates the results of subtracting the second <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose Value property contains the results of the subtraction.</returns>
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00041687 File Offset: 0x0003F887
		public static SqlDecimal Subtract(SqlDecimal x, SqlDecimal y)
		{
			return x - y;
		}

		/// <summary>The multiplication operator computes the product of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the product of the multiplication.</returns>
		// Token: 0x06000BA4 RID: 2980 RVA: 0x00041690 File Offset: 0x0003F890
		public static SqlDecimal Multiply(SqlDecimal x, SqlDecimal y)
		{
			return x * y;
		}

		/// <summary>The division operator calculates the results of dividing the first <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000BA5 RID: 2981 RVA: 0x00041699 File Offset: 0x0003F899
		public static SqlDecimal Divide(SqlDecimal x, SqlDecimal y)
		{
			return x / y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operands to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, the value of the <see langword="SqlDecimal" /> will be null.</returns>
		// Token: 0x06000BA6 RID: 2982 RVA: 0x000416A2 File Offset: 0x0003F8A2
		public static SqlBoolean Equals(SqlDecimal x, SqlDecimal y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BA7 RID: 2983 RVA: 0x000416AB File Offset: 0x0003F8AB
		public static SqlBoolean NotEquals(SqlDecimal x, SqlDecimal y)
		{
			return x != y;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BA8 RID: 2984 RVA: 0x000416B4 File Offset: 0x0003F8B4
		public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y)
		{
			return x < y;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BA9 RID: 2985 RVA: 0x000416BD File Offset: 0x0003F8BD
		public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y)
		{
			return x > y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BAA RID: 2986 RVA: 0x000416C6 File Offset: 0x0003F8C6
		public static SqlBoolean LessThanOrEqual(SqlDecimal x, SqlDecimal y)
		{
			return x <= y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BAB RID: 2987 RVA: 0x000416CF File Offset: 0x0003F8CF
		public static SqlBoolean GreaterThanOrEqual(SqlDecimal x, SqlDecimal y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000BAC RID: 2988 RVA: 0x000416D8 File Offset: 0x0003F8D8
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see langword="Value" /> equals the <see langword="Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. If the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's Value is <see langword="true" />, the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's <see langword="Value" /> will be 1. Otherwise, the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's <see langword="Value" /> will be 0.</returns>
		// Token: 0x06000BAD RID: 2989 RVA: 0x000416E5 File Offset: 0x0003F8E5
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06000BAE RID: 2990 RVA: 0x000416F2 File Offset: 0x0003F8F2
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06000BAF RID: 2991 RVA: 0x000416FF File Offset: 0x0003F8FF
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06000BB0 RID: 2992 RVA: 0x0004170C File Offset: 0x0003F90C
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06000BB1 RID: 2993 RVA: 0x00041719 File Offset: 0x0003F919
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06000BB2 RID: 2994 RVA: 0x00041726 File Offset: 0x0003F926
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06000BB3 RID: 2995 RVA: 0x00041733 File Offset: 0x0003F933
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> structure whose value is a string representing the value contained in this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
		// Token: 0x06000BB4 RID: 2996 RVA: 0x00041740 File Offset: 0x0003F940
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0004174D File Offset: 0x0003F94D
		private static char ChFromDigit(uint uiDigit)
		{
			return (char)(uiDigit + 48U);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00041754 File Offset: 0x0003F954
		private void StoreFromWorkingArray(uint[] rguiData)
		{
			this._data1 = rguiData[0];
			this._data2 = rguiData[1];
			this._data3 = rguiData[2];
			this._data4 = rguiData[3];
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0004177C File Offset: 0x0003F97C
		private void SetToZero()
		{
			this._bLen = 1;
			this._data1 = (this._data2 = (this._data3 = (this._data4 = 0U)));
			this._bStatus = (SqlDecimal.s_bNotNull | SqlDecimal.s_bPositive);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000417C4 File Offset: 0x0003F9C4
		private void MakeInteger(out bool fFraction)
		{
			int i = (int)this._bScale;
			fFraction = false;
			while (i > 0)
			{
				uint num;
				if (i >= 9)
				{
					num = this.DivByULong(SqlDecimal.s_rgulShiftBase[8]);
					i -= 9;
				}
				else
				{
					num = this.DivByULong(SqlDecimal.s_rgulShiftBase[i - 1]);
					i = 0;
				}
				if (num != 0U)
				{
					fFraction = true;
				}
			}
			this._bScale = 0;
		}

		/// <summary>The Abs method gets the absolute value of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</summary>
		/// <param name="n">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the unsigned number representing the absolute value of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004181A File Offset: 0x0003FA1A
		public static SqlDecimal Abs(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			n.SetPositive();
			return n;
		}

		/// <summary>Returns the smallest whole number greater than or equal to the specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure for which the ceiling value is to be calculated. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> representing the smallest whole number greater than or equal to the specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
		// Token: 0x06000BBA RID: 3002 RVA: 0x00041834 File Offset: 0x0003FA34
		public static SqlDecimal Ceiling(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (n._bScale == 0)
			{
				return n;
			}
			bool flag;
			n.MakeInteger(out flag);
			if (flag && n.IsPositive)
			{
				n.AddULong(1U);
			}
			if (n.FZero())
			{
				n.SetPositive();
			}
			return n;
		}

		/// <summary>Rounds a specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> number to the next lower whole number.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure for which the floor value is to be calculated. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure that contains the whole number part of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
		// Token: 0x06000BBB RID: 3003 RVA: 0x00041888 File Offset: 0x0003FA88
		public static SqlDecimal Floor(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (n._bScale == 0)
			{
				return n;
			}
			bool flag;
			n.MakeInteger(out flag);
			if (flag && !n.IsPositive)
			{
				n.AddULong(1U);
			}
			if (n.FZero())
			{
				n.SetPositive();
			}
			return n;
		}

		/// <summary>Gets a value that indicates the sign of a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose sign is to be evaluated. </param>
		/// <returns>A number that indicates the sign of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
		// Token: 0x06000BBC RID: 3004 RVA: 0x000418DC File Offset: 0x0003FADC
		public static SqlInt32 Sign(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlInt32.Null;
			}
			if (n == new SqlDecimal(0))
			{
				return SqlInt32.Zero;
			}
			if (n.IsNull)
			{
				return SqlInt32.Null;
			}
			if (!n.IsPositive)
			{
				return new SqlInt32(-1);
			}
			return new SqlInt32(1);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00041938 File Offset: 0x0003FB38
		private static SqlDecimal Round(SqlDecimal n, int lPosition, bool fTruncate)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (lPosition >= 0)
			{
				lPosition = Math.Min((int)SqlDecimal.s_NUMERIC_MAX_PRECISION, lPosition);
				if (lPosition >= (int)n._bScale)
				{
					return n;
				}
			}
			else
			{
				lPosition = Math.Max((int)(-(int)SqlDecimal.s_NUMERIC_MAX_PRECISION), lPosition);
				if (lPosition < (int)(n._bScale - n._bPrec))
				{
					n.SetToZero();
					return n;
				}
			}
			uint num = 0U;
			int i = Math.Abs(lPosition - (int)n._bScale);
			uint num2 = 1U;
			while (i > 0)
			{
				if (i >= 9)
				{
					num = n.DivByULong(SqlDecimal.s_rgulShiftBase[8]);
					num2 = SqlDecimal.s_rgulShiftBase[8];
					i -= 9;
				}
				else
				{
					num = n.DivByULong(SqlDecimal.s_rgulShiftBase[i - 1]);
					num2 = SqlDecimal.s_rgulShiftBase[i - 1];
					i = 0;
				}
			}
			if (num2 > 1U)
			{
				num /= num2 / 10U;
			}
			if (n.FZero() && (fTruncate || num < 5U))
			{
				n.SetPositive();
				return n;
			}
			if (num >= 5U && !fTruncate)
			{
				n.AddULong(1U);
			}
			i = Math.Abs(lPosition - (int)n._bScale);
			while (i-- > 0)
			{
				n.MultByULong(SqlDecimal.s_ulBase10);
			}
			return n;
		}

		/// <summary>Gets the number nearest the specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's value with the specified precision.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be rounded. </param>
		/// <param name="position">The number of significant fractional digits (precision) in the return value. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure that contains the results of the rounding operation.</returns>
		// Token: 0x06000BBE RID: 3006 RVA: 0x00041A47 File Offset: 0x0003FC47
		public static SqlDecimal Round(SqlDecimal n, int position)
		{
			return SqlDecimal.Round(n, position, false);
		}

		/// <summary>Truncates the specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's value to the that you want position.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be truncated. </param>
		/// <param name="position">The decimal position to which the number will be truncated. </param>
		/// <returns>Supply a negative value for the <paramref name="position" /> parameter in order to truncate the value to the corresponding position to the left of the decimal point.</returns>
		// Token: 0x06000BBF RID: 3007 RVA: 0x00041A51 File Offset: 0x0003FC51
		public static SqlDecimal Truncate(SqlDecimal n, int position)
		{
			return SqlDecimal.Round(n, position, true);
		}

		/// <summary>Raises the value of the specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to the specified exponential power.</summary>
		/// <param name="n">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be raised to a power. </param>
		/// <param name="exp">A double value that indicates the power to which the number should be raised. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure that contains the results.</returns>
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00041A5C File Offset: 0x0003FC5C
		public static SqlDecimal Power(SqlDecimal n, double exp)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			byte precision = n.Precision;
			int scale = (int)n.Scale;
			double x = n.ToDouble();
			n = new SqlDecimal(Math.Pow(x, exp));
			n.AdjustScale(scale - (int)n.Scale, true);
			n._bPrec = SqlDecimal.MaxPrecision;
			return n;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return Value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000BC1 RID: 3009 RVA: 0x00041ABC File Offset: 0x0003FCBC
		public int CompareTo(object value)
		{
			if (value is SqlDecimal)
			{
				SqlDecimal value2 = (SqlDecimal)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlDecimal));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> object and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00041AF8 File Offset: 0x0003FCF8
		public int CompareTo(SqlDecimal value)
		{
			if (this.IsNull)
			{
				if (!value.IsNull)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (value.IsNull)
				{
					return 1;
				}
				if (this < value)
				{
					return -1;
				}
				if (this > value)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Compares the supplied <see cref="T:System.Object" /> parameter to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> instance.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> and the two are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000BC3 RID: 3011 RVA: 0x00041B50 File Offset: 0x0003FD50
		public override bool Equals(object value)
		{
			if (!(value is SqlDecimal))
			{
				return false;
			}
			SqlDecimal y = (SqlDecimal)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000BC4 RID: 3012 RVA: 0x00041BA8 File Offset: 0x0003FDA8
		public override int GetHashCode()
		{
			if (this.IsNull)
			{
				return 0;
			}
			SqlDecimal sqlDecimal = this;
			int num = (int)sqlDecimal.CalculatePrecision();
			sqlDecimal.AdjustScale((int)SqlDecimal.s_NUMERIC_MAX_PRECISION - num, true);
			int bLen = (int)sqlDecimal._bLen;
			int num2 = 0;
			int[] data = sqlDecimal.Data;
			for (int i = 0; i < bLen; i++)
			{
				int num3 = num2 >> 28 & 255;
				num2 <<= 4;
				num2 = (num2 ^ data[i] ^ num3);
			}
			return num2;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>An <see langword="XmlSchema" />.</returns>
		// Token: 0x06000BC5 RID: 3013 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000BC6 RID: 3014 RVA: 0x00041C1C File Offset: 0x0003FE1C
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._bStatus = (SqlDecimal.s_bReverseNullMask & this._bStatus);
				return;
			}
			SqlDecimal sqlDecimal = SqlDecimal.Parse(reader.ReadElementString());
			this._bStatus = sqlDecimal._bStatus;
			this._bLen = sqlDecimal._bLen;
			this._bPrec = sqlDecimal._bPrec;
			this._bScale = sqlDecimal._bScale;
			this._data1 = sqlDecimal._data1;
			this._data2 = sqlDecimal._data2;
			this._data3 = sqlDecimal._data3;
			this._data4 = sqlDecimal._data4;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter " />
		///     </param>
		// Token: 0x06000BC7 RID: 3015 RVA: 0x00041CCC File Offset: 0x0003FECC
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(this.ToString());
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000BC8 RID: 3016 RVA: 0x00041D03 File Offset: 0x0003FF03
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("decimal", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040003C8 RID: 968
		internal byte _bStatus;

		// Token: 0x040003C9 RID: 969
		internal byte _bLen;

		// Token: 0x040003CA RID: 970
		internal byte _bPrec;

		// Token: 0x040003CB RID: 971
		internal byte _bScale;

		// Token: 0x040003CC RID: 972
		internal uint _data1;

		// Token: 0x040003CD RID: 973
		internal uint _data2;

		// Token: 0x040003CE RID: 974
		internal uint _data3;

		// Token: 0x040003CF RID: 975
		internal uint _data4;

		// Token: 0x040003D0 RID: 976
		private static readonly byte s_NUMERIC_MAX_PRECISION = 38;

		/// <summary>A constant representing the largest possible value for the <see cref="P:System.Data.SqlTypes.SqlDecimal.Precision" /> property.</summary>
		// Token: 0x040003D1 RID: 977
		public static readonly byte MaxPrecision = SqlDecimal.s_NUMERIC_MAX_PRECISION;

		/// <summary>A constant representing the maximum value for the <see cref="P:System.Data.SqlTypes.SqlDecimal.Scale" /> property.</summary>
		// Token: 0x040003D2 RID: 978
		public static readonly byte MaxScale = SqlDecimal.s_NUMERIC_MAX_PRECISION;

		// Token: 0x040003D3 RID: 979
		private static readonly byte s_bNullMask = 1;

		// Token: 0x040003D4 RID: 980
		private static readonly byte s_bIsNull = 0;

		// Token: 0x040003D5 RID: 981
		private static readonly byte s_bNotNull = 1;

		// Token: 0x040003D6 RID: 982
		private static readonly byte s_bReverseNullMask = ~SqlDecimal.s_bNullMask;

		// Token: 0x040003D7 RID: 983
		private static readonly byte s_bSignMask = 2;

		// Token: 0x040003D8 RID: 984
		private static readonly byte s_bPositive = 0;

		// Token: 0x040003D9 RID: 985
		private static readonly byte s_bNegative = 2;

		// Token: 0x040003DA RID: 986
		private static readonly byte s_bReverseSignMask = ~SqlDecimal.s_bSignMask;

		// Token: 0x040003DB RID: 987
		private static readonly uint s_uiZero = 0U;

		// Token: 0x040003DC RID: 988
		private static readonly int s_cNumeMax = 4;

		// Token: 0x040003DD RID: 989
		private static readonly long s_lInt32Base = 4294967296L;

		// Token: 0x040003DE RID: 990
		private static readonly ulong s_ulInt32Base = 4294967296UL;

		// Token: 0x040003DF RID: 991
		private static readonly ulong s_ulInt32BaseForMod = SqlDecimal.s_ulInt32Base - 1UL;

		// Token: 0x040003E0 RID: 992
		internal static readonly ulong s_llMax = 9223372036854775807UL;

		// Token: 0x040003E1 RID: 993
		private static readonly uint s_ulBase10 = 10U;

		// Token: 0x040003E2 RID: 994
		private static readonly double s_DUINT_BASE = (double)SqlDecimal.s_lInt32Base;

		// Token: 0x040003E3 RID: 995
		private static readonly double s_DUINT_BASE2 = SqlDecimal.s_DUINT_BASE * SqlDecimal.s_DUINT_BASE;

		// Token: 0x040003E4 RID: 996
		private static readonly double s_DUINT_BASE3 = SqlDecimal.s_DUINT_BASE2 * SqlDecimal.s_DUINT_BASE;

		// Token: 0x040003E5 RID: 997
		private static readonly double s_DMAX_NUME = 1E+38;

		// Token: 0x040003E6 RID: 998
		private static readonly uint s_DBL_DIG = 17U;

		// Token: 0x040003E7 RID: 999
		private static readonly byte s_cNumeDivScaleMin = 6;

		// Token: 0x040003E8 RID: 1000
		private static readonly uint[] s_rgulShiftBase = new uint[]
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

		// Token: 0x040003E9 RID: 1001
		private static readonly uint[] s_decimalHelpersLo = new uint[]
		{
			10U,
			100U,
			1000U,
			10000U,
			100000U,
			1000000U,
			10000000U,
			100000000U,
			1000000000U,
			1410065408U,
			1215752192U,
			3567587328U,
			1316134912U,
			276447232U,
			2764472320U,
			1874919424U,
			1569325056U,
			2808348672U,
			2313682944U,
			1661992960U,
			3735027712U,
			2990538752U,
			4135583744U,
			2701131776U,
			1241513984U,
			3825205248U,
			3892314112U,
			268435456U,
			2684354560U,
			1073741824U,
			2147483648U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U
		};

		// Token: 0x040003EA RID: 1002
		private static readonly uint[] s_decimalHelpersMid = new uint[]
		{
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			2U,
			23U,
			232U,
			2328U,
			23283U,
			232830U,
			2328306U,
			23283064U,
			232830643U,
			2328306436U,
			1808227885U,
			902409669U,
			434162106U,
			46653770U,
			466537709U,
			370409800U,
			3704098002U,
			2681241660U,
			1042612833U,
			1836193738U,
			1182068202U,
			3230747430U,
			2242703233U,
			952195850U,
			932023908U,
			730304488U,
			3008077584U,
			16004768U,
			160047680U
		};

		// Token: 0x040003EB RID: 1003
		private static readonly uint[] s_decimalHelpersHi = new uint[]
		{
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			5U,
			54U,
			542U,
			5421U,
			54210U,
			542101U,
			5421010U,
			54210108U,
			542101086U,
			1126043566U,
			2670501072U,
			935206946U,
			762134875U,
			3326381459U,
			3199043520U,
			1925664130U,
			2076772117U,
			3587851993U,
			1518781562U
		};

		// Token: 0x040003EC RID: 1004
		private static readonly uint[] s_decimalHelpersHiHi = new uint[]
		{
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			1U,
			12U,
			126U,
			1262U,
			12621U,
			126217U,
			1262177U,
			12621774U,
			126217744U,
			1262177448U
		};

		// Token: 0x040003ED RID: 1005
		private const int HelperTableStartIndexLo = 5;

		// Token: 0x040003EE RID: 1006
		private const int HelperTableStartIndexMid = 15;

		// Token: 0x040003EF RID: 1007
		private const int HelperTableStartIndexHi = 24;

		// Token: 0x040003F0 RID: 1008
		private const int HelperTableStartIndexHiHi = 33;

		// Token: 0x040003F1 RID: 1009
		private static readonly byte[] s_rgCLenFromPrec = new byte[]
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

		// Token: 0x040003F2 RID: 1010
		private static readonly uint s_ulT1 = 10U;

		// Token: 0x040003F3 RID: 1011
		private static readonly uint s_ulT2 = 100U;

		// Token: 0x040003F4 RID: 1012
		private static readonly uint s_ulT3 = 1000U;

		// Token: 0x040003F5 RID: 1013
		private static readonly uint s_ulT4 = 10000U;

		// Token: 0x040003F6 RID: 1014
		private static readonly uint s_ulT5 = 100000U;

		// Token: 0x040003F7 RID: 1015
		private static readonly uint s_ulT6 = 1000000U;

		// Token: 0x040003F8 RID: 1016
		private static readonly uint s_ulT7 = 10000000U;

		// Token: 0x040003F9 RID: 1017
		private static readonly uint s_ulT8 = 100000000U;

		// Token: 0x040003FA RID: 1018
		private static readonly uint s_ulT9 = 1000000000U;

		// Token: 0x040003FB RID: 1019
		private static readonly ulong s_dwlT10 = 10000000000UL;

		// Token: 0x040003FC RID: 1020
		private static readonly ulong s_dwlT11 = 100000000000UL;

		// Token: 0x040003FD RID: 1021
		private static readonly ulong s_dwlT12 = 1000000000000UL;

		// Token: 0x040003FE RID: 1022
		private static readonly ulong s_dwlT13 = 10000000000000UL;

		// Token: 0x040003FF RID: 1023
		private static readonly ulong s_dwlT14 = 100000000000000UL;

		// Token: 0x04000400 RID: 1024
		private static readonly ulong s_dwlT15 = 1000000000000000UL;

		// Token: 0x04000401 RID: 1025
		private static readonly ulong s_dwlT16 = 10000000000000000UL;

		// Token: 0x04000402 RID: 1026
		private static readonly ulong s_dwlT17 = 100000000000000000UL;

		// Token: 0x04000403 RID: 1027
		private static readonly ulong s_dwlT18 = 1000000000000000000UL;

		// Token: 0x04000404 RID: 1028
		private static readonly ulong s_dwlT19 = 10000000000000000000UL;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" />class.</summary>
		// Token: 0x04000405 RID: 1029
		public static readonly SqlDecimal Null = new SqlDecimal(true);

		/// <summary>A constant representing the minimum value for a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</summary>
		// Token: 0x04000406 RID: 1030
		public static readonly SqlDecimal MinValue = SqlDecimal.Parse("-99999999999999999999999999999999999999");

		/// <summary>A constant representing the maximum value of a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</summary>
		// Token: 0x04000407 RID: 1031
		public static readonly SqlDecimal MaxValue = SqlDecimal.Parse("99999999999999999999999999999999999999");
	}
}
