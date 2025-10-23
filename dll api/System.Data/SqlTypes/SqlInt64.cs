using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a 64-bit signed integer to be stored in or retrieved from a database.</summary>
	// Token: 0x020000BC RID: 188
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlInt64 : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x00043D63 File Offset: 0x00041F63
		private SqlInt64(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0L;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure using the supplied long integer.</summary>
		/// <param name="value">A long integer. </param>
		// Token: 0x06000CB1 RID: 3249 RVA: 0x00043D74 File Offset: 0x00041F74
		public SqlInt64(long value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00043D84 File Offset: 0x00041F84
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Gets the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. This property is read-only.</summary>
		/// <returns>A long integer representing the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</returns>
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00043D8F File Offset: 0x00041F8F
		public long Value
		{
			get
			{
				if (this.m_fNotNull)
				{
					return this.m_value;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Converts the long parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">A long integer value. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> equals the value of the long parameter.</returns>
		// Token: 0x06000CB4 RID: 3252 RVA: 0x00043DA5 File Offset: 0x00041FA5
		public static implicit operator SqlInt64(long x)
		{
			return new SqlInt64(x);
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to long.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new long value equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CB5 RID: 3253 RVA: 0x00043DAD File Offset: 0x00041FAD
		public static explicit operator long(SqlInt64 x)
		{
			return x.Value;
		}

		/// <summary>Converts this instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> to <see cref="T:System.String" />.</summary>
		/// <returns>A <see cref="T:System.String" /> representing the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CB6 RID: 3254 RVA: 0x00043DB6 File Offset: 0x00041FB6
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its 64-bit signed integer equivalent.</summary>
		/// <param name="s">The <see cref="T:System.String" /> to be parsed. </param>
		/// <returns>A 64-bit signed integer equivalent to the value that is contained in the specified <see cref="T:System.String" />.</returns>
		// Token: 0x06000CB7 RID: 3255 RVA: 0x00043DD2 File Offset: 0x00041FD2
		public static SqlInt64 Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlInt64.Null;
			}
			return new SqlInt64(long.Parse(s, null));
		}

		/// <summary>The unary minus operator negates the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the negated <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000CB8 RID: 3256 RVA: 0x00043DF3 File Offset: 0x00041FF3
		public static SqlInt64 operator -(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(-x.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Performs a bitwise one's complement operation on its <see cref="T:System.Data.SqlTypes.SqlInt64" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the ones complement of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000CB9 RID: 3257 RVA: 0x00043E10 File Offset: 0x00042010
		public static SqlInt64 operator ~(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(~x.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</returns>
		// Token: 0x06000CBA RID: 3258 RVA: 0x00043E30 File Offset: 0x00042030
		public static SqlInt64 operator +(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			long num = x.m_value + y.m_value;
			if (SqlInt64.SameSignLong(x.m_value, y.m_value) && !SqlInt64.SameSignLong(x.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(num);
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the results of the subtraction operation.</returns>
		// Token: 0x06000CBB RID: 3259 RVA: 0x00043E98 File Offset: 0x00042098
		public static SqlInt64 operator -(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			long num = x.m_value - y.m_value;
			if (!SqlInt64.SameSignLong(x.m_value, y.m_value) && SqlInt64.SameSignLong(y.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(num);
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the product of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</returns>
		// Token: 0x06000CBC RID: 3260 RVA: 0x00043F00 File Offset: 0x00042100
		public static SqlInt64 operator *(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			bool flag = false;
			long num = x.m_value;
			long num2 = y.m_value;
			long num3 = 0L;
			if (num < 0L)
			{
				flag = true;
				num = -num;
			}
			if (num2 < 0L)
			{
				flag = !flag;
				num2 = -num2;
			}
			long num4 = num & SqlInt64.s_lLowIntMask;
			long num5 = num >> 32 & SqlInt64.s_lLowIntMask;
			long num6 = num2 & SqlInt64.s_lLowIntMask;
			long num7 = num2 >> 32 & SqlInt64.s_lLowIntMask;
			if (num5 != 0L && num7 != 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			long num8 = num4 * num6;
			if (num8 < 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (num5 != 0L)
			{
				num3 = num5 * num6;
				if (num3 < 0L || num3 > 9223372036854775807L)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
			}
			else if (num7 != 0L)
			{
				num3 = num4 * num7;
				if (num3 < 0L || num3 > 9223372036854775807L)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
			}
			num8 += num3 << 32;
			if (num8 < 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (flag)
			{
				num8 = -num8;
			}
			return new SqlInt64(num8);
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property contains the results of the division operation.</returns>
		// Token: 0x06000CBD RID: 3261 RVA: 0x0004401C File Offset: 0x0004221C
		public static SqlInt64 operator /(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			if (y.m_value == 0L)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -9223372036854775808L && y.m_value == -1L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(x.m_value / y.m_value);
		}

		/// <summary>Computes the remainder after dividing the first <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property contains the remainder.</returns>
		// Token: 0x06000CBE RID: 3262 RVA: 0x0004408C File Offset: 0x0004228C
		public static SqlInt64 operator %(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			if (y.m_value == 0L)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -9223372036854775808L && y.m_value == -1L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(x.m_value % y.m_value);
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlInt64" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure that contains the results of the bitwise AND operation.</returns>
		// Token: 0x06000CBF RID: 3263 RVA: 0x000440FC File Offset: 0x000422FC
		public static SqlInt64 operator &(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt64(x.m_value & y.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Computes the bitwise OR of its two <see cref="T:System.Data.SqlTypes.SqlInt64" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure that contains the results of the bitwise OR operation.</returns>
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00044128 File Offset: 0x00042328
		public static SqlInt64 operator |(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt64(x.m_value | y.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure that contains the results of the bitwise XOR operation.</returns>
		// Token: 0x06000CC1 RID: 3265 RVA: 0x00044154 File Offset: 0x00042354
		public static SqlInt64 operator ^(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt64(x.m_value ^ y.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00044180 File Offset: 0x00042380
		public static explicit operator SqlInt64(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)((ulong)x.ByteValue));
			}
			return SqlInt64.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000CC3 RID: 3267 RVA: 0x0004419E File Offset: 0x0004239E
		public static implicit operator SqlInt64(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)((ulong)x.Value));
			}
			return SqlInt64.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000CC4 RID: 3268 RVA: 0x000441BC File Offset: 0x000423BC
		public static implicit operator SqlInt64(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)x.Value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000CC5 RID: 3269 RVA: 0x000441DA File Offset: 0x000423DA
		public static implicit operator SqlInt64(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)x.Value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property contains the integer part of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000CC6 RID: 3270 RVA: 0x000441F8 File Offset: 0x000423F8
		public static explicit operator SqlInt64(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlInt64.Null;
			}
			float value = x.Value;
			if (value > 9.223372E+18f || value < -9.223372E+18f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64((long)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000CC7 RID: 3271 RVA: 0x00044240 File Offset: 0x00042440
		public static explicit operator SqlInt64(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlInt64.Null;
			}
			double value = x.Value;
			if (value > 9.223372036854776E+18 || value < -9.223372036854776E+18)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64((long)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000CC8 RID: 3272 RVA: 0x0004428E File Offset: 0x0004248E
		public static explicit operator SqlInt64(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(x.ToInt64());
			}
			return SqlInt64.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the integer part of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000CC9 RID: 3273 RVA: 0x000442AC File Offset: 0x000424AC
		public static explicit operator SqlInt64(SqlDecimal x)
		{
			if (x.IsNull)
			{
				return SqlInt64.Null;
			}
			SqlDecimal sqlDecimal = x;
			sqlDecimal.AdjustScale((int)(-(int)sqlDecimal._bScale), false);
			if (sqlDecimal._bLen > 2)
			{
				throw new OverflowException(SQLResource.ConversionOverflowMessage);
			}
			long num2;
			if (sqlDecimal._bLen == 2)
			{
				ulong num = SqlDecimal.DWL(sqlDecimal._data1, sqlDecimal._data2);
				if (num > SqlDecimal.s_llMax && (sqlDecimal.IsPositive || num != 1UL + SqlDecimal.s_llMax))
				{
					throw new OverflowException(SQLResource.ConversionOverflowMessage);
				}
				num2 = (long)num;
			}
			else
			{
				num2 = (long)((ulong)sqlDecimal._data1);
			}
			if (!sqlDecimal.IsPositive)
			{
				num2 = -num2;
			}
			return new SqlInt64(num2);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> parameter to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlString" /> object to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the value represented by the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter.</returns>
		// Token: 0x06000CCA RID: 3274 RVA: 0x0004434D File Offset: 0x0004254D
		public static explicit operator SqlInt64(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(long.Parse(x.Value, null));
			}
			return SqlInt64.Null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00044370 File Offset: 0x00042570
		private static bool SameSignLong(long x, long y)
		{
			return ((x ^ y) & long.MinValue) == 0L;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CCC RID: 3276 RVA: 0x00044383 File Offset: 0x00042583
		public static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison on the two SqlInt64 parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CCD RID: 3277 RVA: 0x000443B0 File Offset: 0x000425B0
		public static SqlBoolean operator !=(SqlInt64 x, SqlInt64 y)
		{
			return !(x == y);
		}

		/// <summary>Performs a logical comparison on the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CCE RID: 3278 RVA: 0x000443BE File Offset: 0x000425BE
		public static SqlBoolean operator <(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CCF RID: 3279 RVA: 0x000443EB File Offset: 0x000425EB
		public static SqlBoolean operator >(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison on the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CD0 RID: 3280 RVA: 0x00044418 File Offset: 0x00042618
		public static SqlBoolean operator <=(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CD1 RID: 3281 RVA: 0x00044448 File Offset: 0x00042648
		public static SqlBoolean operator >=(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a bitwise one's complement operation on its <see cref="T:System.Data.SqlTypes.SqlInt64" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the ones complement of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000CD2 RID: 3282 RVA: 0x00044478 File Offset: 0x00042678
		public static SqlInt64 OnesComplement(SqlInt64 x)
		{
			return ~x;
		}

		/// <summary>Computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</returns>
		// Token: 0x06000CD3 RID: 3283 RVA: 0x00044480 File Offset: 0x00042680
		public static SqlInt64 Add(SqlInt64 x, SqlInt64 y)
		{
			return x + y;
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property equals the results of the subtraction operation.</returns>
		// Token: 0x06000CD4 RID: 3284 RVA: 0x00044489 File Offset: 0x00042689
		public static SqlInt64 Subtract(SqlInt64 x, SqlInt64 y)
		{
			return x - y;
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is equal to the product of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters.</returns>
		// Token: 0x06000CD5 RID: 3285 RVA: 0x00044492 File Offset: 0x00042692
		public static SqlInt64 Multiply(SqlInt64 x, SqlInt64 y)
		{
			return x * y;
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property contains the results of the division operation.</returns>
		// Token: 0x06000CD6 RID: 3286 RVA: 0x0004449B File Offset: 0x0004269B
		public static SqlInt64 Divide(SqlInt64 x, SqlInt64 y)
		{
			return x / y;
		}

		/// <summary>Computes the remainder after dividing the first <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property contains the remainder.</returns>
		// Token: 0x06000CD7 RID: 3287 RVA: 0x000444A4 File Offset: 0x000426A4
		public static SqlInt64 Mod(SqlInt64 x, SqlInt64 y)
		{
			return x % y;
		}

		/// <summary>Divides two <see cref="T:System.Data.SqlTypes.SqlInt64" /> values and returns the remainder.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> value.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> value.</param>
		/// <returns>The remainder left after division is performed on <paramref name="x" /> and <paramref name="y" />.</returns>
		// Token: 0x06000CD8 RID: 3288 RVA: 0x000444A4 File Offset: 0x000426A4
		public static SqlInt64 Modulus(SqlInt64 x, SqlInt64 y)
		{
			return x % y;
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlInt64" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure that contains the results of the bitwise AND operation.</returns>
		// Token: 0x06000CD9 RID: 3289 RVA: 0x000444AD File Offset: 0x000426AD
		public static SqlInt64 BitwiseAnd(SqlInt64 x, SqlInt64 y)
		{
			return x & y;
		}

		/// <summary>Computes the bitwise OR of its two <see cref="T:System.Data.SqlTypes.SqlInt64" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure that contains the results of the bitwise OR operation.</returns>
		// Token: 0x06000CDA RID: 3290 RVA: 0x000444B6 File Offset: 0x000426B6
		public static SqlInt64 BitwiseOr(SqlInt64 x, SqlInt64 y)
		{
			return x | y;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure that contains the results of the bitwise XOR operation.</returns>
		// Token: 0x06000CDB RID: 3291 RVA: 0x000444BF File Offset: 0x000426BF
		public static SqlInt64 Xor(SqlInt64 x, SqlInt64 y)
		{
			return x ^ y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlInt64" /> will be null.</returns>
		// Token: 0x06000CDC RID: 3292 RVA: 0x000444C8 File Offset: 0x000426C8
		public static SqlBoolean Equals(SqlInt64 x, SqlInt64 y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison on the two SqlInt64 parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CDD RID: 3293 RVA: 0x000444D1 File Offset: 0x000426D1
		public static SqlBoolean NotEquals(SqlInt64 x, SqlInt64 y)
		{
			return x != y;
		}

		/// <summary>Performs a logical comparison on the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CDE RID: 3294 RVA: 0x000444DA File Offset: 0x000426DA
		public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y)
		{
			return x < y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CDF RID: 3295 RVA: 0x000444E3 File Offset: 0x000426E3
		public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y)
		{
			return x > y;
		}

		/// <summary>Performs a logical comparison on the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CE0 RID: 3296 RVA: 0x000444EC File Offset: 0x000426EC
		public static SqlBoolean LessThanOrEqual(SqlInt64 x, SqlInt64 y)
		{
			return x <= y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameters to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000CE1 RID: 3297 RVA: 0x000444F5 File Offset: 0x000426F5
		public static SqlBoolean GreaterThanOrEqual(SqlInt64 x, SqlInt64 y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000CE2 RID: 3298 RVA: 0x000444FE File Offset: 0x000426FE
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see langword="Value" /> equals the <see langword="Value" /> of this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </returns>
		// Token: 0x06000CE3 RID: 3299 RVA: 0x0004450B File Offset: 0x0004270B
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CE4 RID: 3300 RVA: 0x00044518 File Offset: 0x00042718
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CE5 RID: 3301 RVA: 0x00044525 File Offset: 0x00042725
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CE6 RID: 3302 RVA: 0x00044532 File Offset: 0x00042732
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CE7 RID: 3303 RVA: 0x0004453F File Offset: 0x0004273F
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CE8 RID: 3304 RVA: 0x0004454C File Offset: 0x0004274C
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CE9 RID: 3305 RVA: 0x00044559 File Offset: 0x00042759
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> representing the value of this <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06000CEA RID: 3306 RVA: 0x00044566 File Offset: 0x00042766
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlInt64" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing " />in Visual Basic). </returns>
		// Token: 0x06000CEB RID: 3307 RVA: 0x00044574 File Offset: 0x00042774
		public int CompareTo(object value)
		{
			if (value is SqlInt64)
			{
				SqlInt64 value2 = (SqlInt64)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlInt64));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlInt64" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic). </returns>
		// Token: 0x06000CEC RID: 3308 RVA: 0x000445B0 File Offset: 0x000427B0
		public int CompareTo(SqlInt64 value)
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

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlInt64" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000CED RID: 3309 RVA: 0x00044608 File Offset: 0x00042808
		public override bool Equals(object value)
		{
			if (!(value is SqlInt64))
			{
				return false;
			}
			SqlInt64 y = (SqlInt64)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000CEE RID: 3310 RVA: 0x00044660 File Offset: 0x00042860
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this.Value.GetHashCode();
			}
			return 0;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>An <see langword="XmlSchema" />.</returns>
		// Token: 0x06000CEF RID: 3311 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader" />
		///     </param>
		// Token: 0x06000CF0 RID: 3312 RVA: 0x00044688 File Offset: 0x00042888
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToInt64(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter" />
		///     </param>
		// Token: 0x06000CF1 RID: 3313 RVA: 0x000446D8 File Offset: 0x000428D8
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this.m_value));
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000CF2 RID: 3314 RVA: 0x0004470E File Offset: 0x0004290E
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("long", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000421 RID: 1057
		private bool m_fNotNull;

		// Token: 0x04000422 RID: 1058
		private long m_value;

		// Token: 0x04000423 RID: 1059
		private static readonly long s_lLowIntMask = (long)((ulong)-1);

		// Token: 0x04000424 RID: 1060
		private static readonly long s_lHighIntMask = -4294967296L;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</summary>
		// Token: 0x04000425 RID: 1061
		public static readonly SqlInt64 Null = new SqlInt64(true);

		/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</summary>
		// Token: 0x04000426 RID: 1062
		public static readonly SqlInt64 Zero = new SqlInt64(0L);

		/// <summary>A constant representing the smallest possible value for a <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</summary>
		// Token: 0x04000427 RID: 1063
		public static readonly SqlInt64 MinValue = new SqlInt64(long.MinValue);

		/// <summary>A constant representing the largest possible value for a <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</summary>
		// Token: 0x04000428 RID: 1064
		public static readonly SqlInt64 MaxValue = new SqlInt64(long.MaxValue);
	}
}
