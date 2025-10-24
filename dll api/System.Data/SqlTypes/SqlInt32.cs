using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a 32-bit signed integer to be stored in or retrieved from a database.</summary>
	// Token: 0x020000BB RID: 187
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlInt32 : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000C6C RID: 3180 RVA: 0x00043427 File Offset: 0x00041627
		private SqlInt32(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure using the supplied integer value.</summary>
		/// <param name="value">The integer to be converted. </param>
		// Token: 0x06000C6D RID: 3181 RVA: 0x00043437 File Offset: 0x00041637
		public SqlInt32(int value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure is null.</summary>
		/// <returns>This property is <see langword="true" /> if <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> is null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00043447 File Offset: 0x00041647
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Gets the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. This property is read-only.</summary>
		/// <returns>An integer representing the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The property contains <see cref="F:System.Data.SqlTypes.SqlInt32.Null" />. </exception>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00043452 File Offset: 0x00041652
		public int Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this.m_value;
			}
		}

		/// <summary>Converts the supplied integer to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">An integer value. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose Value property is equal to the integer parameter.</returns>
		// Token: 0x06000C70 RID: 3184 RVA: 0x00043468 File Offset: 0x00041668
		public static implicit operator SqlInt32(int x)
		{
			return new SqlInt32(x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to an integer.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>The converted integer value.</returns>
		// Token: 0x06000C71 RID: 3185 RVA: 0x00043470 File Offset: 0x00041670
		public static explicit operator int(SqlInt32 x)
		{
			return x.Value;
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to a <see cref="T:System.String" />.</summary>
		/// <returns>A <see cref="T:System.String" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000C72 RID: 3186 RVA: 0x00043479 File Offset: 0x00041679
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its 32-bit signed integer equivalent.</summary>
		/// <param name="s">The <see cref="T:System.String" /> to be parsed. </param>
		/// <returns>A 32-bit signed integer equivalent to the value that is contained in the specified <see cref="T:System.String" />.</returns>
		// Token: 0x06000C73 RID: 3187 RVA: 0x00043495 File Offset: 0x00041695
		public static SqlInt32 Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlInt32.Null;
			}
			return new SqlInt32(int.Parse(s, null));
		}

		/// <summary>Negates the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the negated value.</returns>
		// Token: 0x06000C74 RID: 3188 RVA: 0x000434B6 File Offset: 0x000416B6
		public static SqlInt32 operator -(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(-x.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Performs a bitwise one's complement operation on the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the one's complement operation.</returns>
		// Token: 0x06000C75 RID: 3189 RVA: 0x000434D3 File Offset: 0x000416D3
		public static SqlInt32 operator ~(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(~x.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property contains the sum of the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</returns>
		// Token: 0x06000C76 RID: 3190 RVA: 0x000434F0 File Offset: 0x000416F0
		public static SqlInt32 operator +(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			int num = x.m_value + y.m_value;
			if (SqlInt32.SameSignInt(x.m_value, y.m_value) && !SqlInt32.SameSignInt(x.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(num);
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property contains the results of the subtraction.</returns>
		// Token: 0x06000C77 RID: 3191 RVA: 0x00043558 File Offset: 0x00041758
		public static SqlInt32 operator -(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			int num = x.m_value - y.m_value;
			if (!SqlInt32.SameSignInt(x.m_value, y.m_value) && SqlInt32.SameSignInt(y.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(num);
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> contains the product of the two parameters.</returns>
		// Token: 0x06000C78 RID: 3192 RVA: 0x000435C0 File Offset: 0x000417C0
		public static SqlInt32 operator *(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			long num = (long)x.m_value * (long)y.m_value;
			long num2 = num & SqlInt32.s_lBitNotIntMax;
			if (num2 != 0L && num2 != SqlInt32.s_lBitNotIntMax)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)num);
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter from the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000C79 RID: 3193 RVA: 0x0004361C File Offset: 0x0004181C
		public static SqlInt32 operator /(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if ((long)x.m_value == SqlInt32.s_iIntMin && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(x.m_value / y.m_value);
		}

		/// <summary>Computes the remainder after dividing the first <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> contains the remainder.</returns>
		// Token: 0x06000C7A RID: 3194 RVA: 0x00043688 File Offset: 0x00041888
		public static SqlInt32 operator %(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if ((long)x.m_value == SqlInt32.s_iIntMin && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(x.m_value % y.m_value);
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlInt32" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the bitwise AND operation.</returns>
		// Token: 0x06000C7B RID: 3195 RVA: 0x000436F4 File Offset: 0x000418F4
		public static SqlInt32 operator &(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt32(x.m_value & y.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Computes the bitwise OR of the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the bitwise OR operation.</returns>
		// Token: 0x06000C7C RID: 3196 RVA: 0x00043720 File Offset: 0x00041920
		public static SqlInt32 operator |(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt32(x.m_value | y.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the bitwise XOR operation.</returns>
		// Token: 0x06000C7D RID: 3197 RVA: 0x0004374C File Offset: 0x0004194C
		public static SqlInt32 operator ^(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt32(x.m_value ^ y.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000C7E RID: 3198 RVA: 0x00043778 File Offset: 0x00041978
		public static explicit operator SqlInt32(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32((int)x.ByteValue);
			}
			return SqlInt32.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> property to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000C7F RID: 3199 RVA: 0x00043795 File Offset: 0x00041995
		public static implicit operator SqlInt32(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32((int)x.Value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000C80 RID: 3200 RVA: 0x000437B2 File Offset: 0x000419B2
		public static implicit operator SqlInt32(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32((int)x.Value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property of the <see langword="SqlInt64" /> parameter.</returns>
		// Token: 0x06000C81 RID: 3201 RVA: 0x000437D0 File Offset: 0x000419D0
		public static explicit operator SqlInt32(SqlInt64 x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			long value = x.Value;
			if (value > 2147483647L || value < -2147483648L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000C82 RID: 3202 RVA: 0x00043818 File Offset: 0x00041A18
		public static explicit operator SqlInt32(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			float value = x.Value;
			if (value > 2.1474836E+09f || value < -2.1474836E+09f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000C83 RID: 3203 RVA: 0x00043860 File Offset: 0x00041A60
		public static explicit operator SqlInt32(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			double value = x.Value;
			if (value > 2147483647.0 || value < -2147483648.0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000C84 RID: 3204 RVA: 0x000438AE File Offset: 0x00041AAE
		public static explicit operator SqlInt32(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(x.ToInt32());
			}
			return SqlInt32.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000C85 RID: 3205 RVA: 0x000438CC File Offset: 0x00041ACC
		public static explicit operator SqlInt32(SqlDecimal x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			x.AdjustScale((int)(-(int)x.Scale), true);
			long num = (long)((ulong)x._data1);
			if (!x.IsPositive)
			{
				num = -num;
			}
			if (x._bLen > 1 || num > 2147483647L || num < -2147483648L)
			{
				throw new OverflowException(SQLResource.ConversionOverflowMessage);
			}
			return new SqlInt32((int)num);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> object to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" /> object. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property equals the value represented by the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter.</returns>
		// Token: 0x06000C86 RID: 3206 RVA: 0x00043939 File Offset: 0x00041B39
		public static explicit operator SqlInt32(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(int.Parse(x.Value, null));
			}
			return SqlInt32.Null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0004395C File Offset: 0x00041B5C
		private static bool SameSignInt(int x, int y)
		{
			return ((long)(x ^ y) & (long)((ulong)int.MinValue)) == 0L;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C88 RID: 3208 RVA: 0x0004396D File Offset: 0x00041B6D
		public static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performa a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C89 RID: 3209 RVA: 0x0004399A File Offset: 0x00041B9A
		public static SqlBoolean operator !=(SqlInt32 x, SqlInt32 y)
		{
			return !(x == y);
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C8A RID: 3210 RVA: 0x000439A8 File Offset: 0x00041BA8
		public static SqlBoolean operator <(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C8B RID: 3211 RVA: 0x000439D5 File Offset: 0x00041BD5
		public static SqlBoolean operator >(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C8C RID: 3212 RVA: 0x00043A02 File Offset: 0x00041C02
		public static SqlBoolean operator <=(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C8D RID: 3213 RVA: 0x00043A32 File Offset: 0x00041C32
		public static SqlBoolean operator >=(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a bitwise one's complement operation on the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the one's complement operation.</returns>
		// Token: 0x06000C8E RID: 3214 RVA: 0x00043A62 File Offset: 0x00041C62
		public static SqlInt32 OnesComplement(SqlInt32 x)
		{
			return ~x;
		}

		/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property contains the sum of the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</returns>
		// Token: 0x06000C8F RID: 3215 RVA: 0x00043A6A File Offset: 0x00041C6A
		public static SqlInt32 Add(SqlInt32 x, SqlInt32 y)
		{
			return x + y;
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property contains the results of the subtraction.</returns>
		// Token: 0x06000C90 RID: 3216 RVA: 0x00043A73 File Offset: 0x00041C73
		public static SqlInt32 Subtract(SqlInt32 x, SqlInt32 y)
		{
			return x - y;
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> contains the product of the two parameters.</returns>
		// Token: 0x06000C91 RID: 3217 RVA: 0x00043A7C File Offset: 0x00041C7C
		public static SqlInt32 Multiply(SqlInt32 x, SqlInt32 y)
		{
			return x * y;
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter from the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000C92 RID: 3218 RVA: 0x00043A85 File Offset: 0x00041C85
		public static SqlInt32 Divide(SqlInt32 x, SqlInt32 y)
		{
			return x / y;
		}

		/// <summary>Computes the remainder after dividing the first <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> contains the remainder.</returns>
		// Token: 0x06000C93 RID: 3219 RVA: 0x00043A8E File Offset: 0x00041C8E
		public static SqlInt32 Mod(SqlInt32 x, SqlInt32 y)
		{
			return x % y;
		}

		/// <summary>Divides two <see cref="T:System.Data.SqlTypes.SqlInt32" /> values and returns the remainder.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> value.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> value.</param>
		/// <returns>The remainder left after division is performed on <paramref name="x" /> and <paramref name="y" />.</returns>
		// Token: 0x06000C94 RID: 3220 RVA: 0x00043A8E File Offset: 0x00041C8E
		public static SqlInt32 Modulus(SqlInt32 x, SqlInt32 y)
		{
			return x % y;
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlInt32" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the bitwise AND operation.</returns>
		// Token: 0x06000C95 RID: 3221 RVA: 0x00043A97 File Offset: 0x00041C97
		public static SqlInt32 BitwiseAnd(SqlInt32 x, SqlInt32 y)
		{
			return x & y;
		}

		/// <summary>Computes the bitwise OR of the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the bitwise OR operation.</returns>
		// Token: 0x06000C96 RID: 3222 RVA: 0x00043AA0 File Offset: 0x00041CA0
		public static SqlInt32 BitwiseOr(SqlInt32 x, SqlInt32 y)
		{
			return x | y;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure that contains the results of the bitwise XOR operation.</returns>
		// Token: 0x06000C97 RID: 3223 RVA: 0x00043AA9 File Offset: 0x00041CA9
		public static SqlInt32 Xor(SqlInt32 x, SqlInt32 y)
		{
			return x ^ y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlInt32" /> will be null.</returns>
		// Token: 0x06000C98 RID: 3224 RVA: 0x00043AB2 File Offset: 0x00041CB2
		public static SqlBoolean Equals(SqlInt32 x, SqlInt32 y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C99 RID: 3225 RVA: 0x00043ABB File Offset: 0x00041CBB
		public static SqlBoolean NotEquals(SqlInt32 x, SqlInt32 y)
		{
			return x != y;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C9A RID: 3226 RVA: 0x00043AC4 File Offset: 0x00041CC4
		public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y)
		{
			return x < y;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C9B RID: 3227 RVA: 0x00043ACD File Offset: 0x00041CCD
		public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y)
		{
			return x > y;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C9C RID: 3228 RVA: 0x00043AD6 File Offset: 0x00041CD6
		public static SqlBoolean LessThanOrEqual(SqlInt32 x, SqlInt32 y)
		{
			return x <= y;
		}

		/// <summary>Compares the two <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameters to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C9D RID: 3229 RVA: 0x00043ADF File Offset: 0x00041CDF
		public static SqlBoolean GreaterThanOrEqual(SqlInt32 x, SqlInt32 y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000C9E RID: 3230 RVA: 0x00043AE8 File Offset: 0x00041CE8
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see langword="Value" /> equals the <see langword="Value" /> of this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. If the value of the <see langword="SqlInt32" /> is less than 0 or greater than 255, an <see cref="T:System.OverflowException" /> occurs.</returns>
		// Token: 0x06000C9F RID: 3231 RVA: 0x00043AF5 File Offset: 0x00041CF5
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA0 RID: 3232 RVA: 0x00043B02 File Offset: 0x00041D02
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA1 RID: 3233 RVA: 0x00043B0F File Offset: 0x00041D0F
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA2 RID: 3234 RVA: 0x00043B1C File Offset: 0x00041D1C
		public SqlInt64 ToSqlInt64()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA3 RID: 3235 RVA: 0x00043B29 File Offset: 0x00041D29
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00043B36 File Offset: 0x00041D36
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA5 RID: 3237 RVA: 0x00043B43 File Offset: 0x00041D43
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> structure equal to the value of this <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06000CA6 RID: 3238 RVA: 0x00043B50 File Offset: 0x00041D50
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlInt32" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic). </returns>
		// Token: 0x06000CA7 RID: 3239 RVA: 0x00043B60 File Offset: 0x00041D60
		public int CompareTo(object value)
		{
			if (value is SqlInt32)
			{
				SqlInt32 value2 = (SqlInt32)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlInt32));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlInt32" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000CA8 RID: 3240 RVA: 0x00043B9C File Offset: 0x00041D9C
		public int CompareTo(SqlInt32 value)
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

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlInt32" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00043BF4 File Offset: 0x00041DF4
		public override bool Equals(object value)
		{
			if (!(value is SqlInt32))
			{
				return false;
			}
			SqlInt32 y = (SqlInt32)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000CAA RID: 3242 RVA: 0x00043C4C File Offset: 0x00041E4C
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
		// Token: 0x06000CAB RID: 3243 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000CAC RID: 3244 RVA: 0x00043C74 File Offset: 0x00041E74
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToInt32(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter" />
		///     </param>
		// Token: 0x06000CAD RID: 3245 RVA: 0x00043CC4 File Offset: 0x00041EC4
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
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000CAE RID: 3246 RVA: 0x00043CFA File Offset: 0x00041EFA
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("int", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000419 RID: 1049
		private bool m_fNotNull;

		// Token: 0x0400041A RID: 1050
		private int m_value;

		// Token: 0x0400041B RID: 1051
		private static readonly long s_iIntMin = -2147483648L;

		// Token: 0x0400041C RID: 1052
		private static readonly long s_lBitNotIntMax = -2147483648L;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> class.</summary>
		// Token: 0x0400041D RID: 1053
		public static readonly SqlInt32 Null = new SqlInt32(true);

		/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure.</summary>
		// Token: 0x0400041E RID: 1054
		public static readonly SqlInt32 Zero = new SqlInt32(0);

		/// <summary>A constant representing the smallest possible value of a <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		// Token: 0x0400041F RID: 1055
		public static readonly SqlInt32 MinValue = new SqlInt32(int.MinValue);

		/// <summary>A constant representing the largest possible value of a <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		// Token: 0x04000420 RID: 1056
		public static readonly SqlInt32 MaxValue = new SqlInt32(int.MaxValue);
	}
}
