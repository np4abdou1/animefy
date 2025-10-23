using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents an 8-bit unsigned integer, in the range of 0 through 255, to be stored in or retrieved from a database. </summary>
	// Token: 0x020000B0 RID: 176
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlByte : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000A8A RID: 2698 RVA: 0x0003C99E File Offset: 0x0003AB9E
		private SqlByte(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure using the specified byte value.</summary>
		/// <param name="value">A byte value to be stored in the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		// Token: 0x06000A8B RID: 2699 RVA: 0x0003C9AE File Offset: 0x0003ABAE
		public SqlByte(byte value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0003C9BE File Offset: 0x0003ABBE
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. This property is read-only </summary>
		/// <returns>The value of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</returns>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0003C9C9 File Offset: 0x0003ABC9
		public byte Value
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

		/// <summary>Converts the supplied byte value to a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A byte value to be converted to <see cref="T:System.Data.SqlTypes.SqlByte" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the supplied parameter.</returns>
		// Token: 0x06000A8E RID: 2702 RVA: 0x0003C9DF File Offset: 0x0003ABDF
		public static implicit operator SqlByte(byte x)
		{
			return new SqlByte(x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to a byte.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to be converted to a byte. </param>
		/// <returns>A byte whose value equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000A8F RID: 2703 RVA: 0x0003C9E7 File Offset: 0x0003ABE7
		public static explicit operator byte(SqlByte x)
		{
			return x.Value;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to a <see cref="T:System.String" />.</summary>
		/// <returns>A string that contains the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" />. If the <see langword="Value" /> is null, the <see langword="String" /> will be a null string.</returns>
		// Token: 0x06000A90 RID: 2704 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its 8-bit unsigned integer equivalent.</summary>
		/// <param name="s">The <see langword="String" /> to be parsed. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure that contains the 8-bit number represented by the <see langword="String" /> parameter.</returns>
		// Token: 0x06000A91 RID: 2705 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		public static SqlByte Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlByte.Null;
			}
			return new SqlByte(byte.Parse(s, null));
		}

		/// <summary>The ones complement operator performs a bitwise one's complement operation on its <see cref="T:System.Data.SqlTypes.SqlByte" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the ones complement of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000A92 RID: 2706 RVA: 0x0003CA2D File Offset: 0x0003AC2D
		public static SqlByte operator ~(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(~x.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlByte" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the sum of the two operands.</returns>
		// Token: 0x06000A93 RID: 2707 RVA: 0x0003CA4C File Offset: 0x0003AC4C
		public static SqlByte operator +(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			int num = (int)(x.m_value + y.m_value);
			if ((num & SqlByte.s_iBitNotByteMax) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlByte((byte)num);
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlByte" /> operand from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of subtracting the second <see cref="T:System.Data.SqlTypes.SqlByte" /> operand from the first.</returns>
		// Token: 0x06000A94 RID: 2708 RVA: 0x0003CA9C File Offset: 0x0003AC9C
		public static SqlByte operator -(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			int num = (int)(x.m_value - y.m_value);
			if ((num & SqlByte.s_iBitNotByteMax) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlByte((byte)num);
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the product of the multiplication.</returns>
		// Token: 0x06000A95 RID: 2709 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		public static SqlByte operator *(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			int num = (int)(x.m_value * y.m_value);
			if ((num & SqlByte.s_iBitNotByteMax) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlByte((byte)num);
		}

		/// <summary>Divides its first <see cref="T:System.Data.SqlTypes.SqlByte" /> operand by its second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000A96 RID: 2710 RVA: 0x0003CB3A File Offset: 0x0003AD3A
		public static SqlByte operator /(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			if (y.m_value != 0)
			{
				return new SqlByte(x.m_value / y.m_value);
			}
			throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
		}

		/// <summary>Computes the remainder after dividing its first <see cref="T:System.Data.SqlTypes.SqlByte" /> operand by its second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> contains the remainder.</returns>
		// Token: 0x06000A97 RID: 2711 RVA: 0x0003CB7A File Offset: 0x0003AD7A
		public static SqlByte operator %(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			if (y.m_value != 0)
			{
				return new SqlByte(x.m_value % y.m_value);
			}
			throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of the bitwise AND operation.</returns>
		// Token: 0x06000A98 RID: 2712 RVA: 0x0003CBBA File Offset: 0x0003ADBA
		public static SqlByte operator &(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlByte(x.m_value & y.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Computes the bitwise OR of its two <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of the bitwise OR operation.</returns>
		// Token: 0x06000A99 RID: 2713 RVA: 0x0003CBE7 File Offset: 0x0003ADE7
		public static SqlByte operator |(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlByte(x.m_value | y.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of the bitwise XOR operation.</returns>
		// Token: 0x06000A9A RID: 2714 RVA: 0x0003CC14 File Offset: 0x0003AE14
		public static SqlByte operator ^(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlByte(x.m_value ^ y.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter to be converted to a <see cref="T:System.Data.SqlTypes.SqlByte" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> of the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000A9B RID: 2715 RVA: 0x0003CC41 File Offset: 0x0003AE41
		public static explicit operator SqlByte(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(x.ByteValue);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see langword="SqlMoney" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000A9C RID: 2716 RVA: 0x0003CC5E File Offset: 0x0003AE5E
		public static explicit operator SqlByte(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(checked((byte)x.ToInt32()));
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000A9D RID: 2717 RVA: 0x0003CC7C File Offset: 0x0003AE7C
		public static explicit operator SqlByte(SqlInt16 x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255 || x.Value < 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000A9E RID: 2718 RVA: 0x0003CCD8 File Offset: 0x0003AED8
		public static explicit operator SqlByte(SqlInt32 x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255 || x.Value < 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see langword="SqlInt64" /> parameter.</returns>
		// Token: 0x06000A9F RID: 2719 RVA: 0x0003CD34 File Offset: 0x0003AF34
		public static explicit operator SqlByte(SqlInt64 x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255L || x.Value < 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003CD94 File Offset: 0x0003AF94
		public static explicit operator SqlByte(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255f || x.Value < 0f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
		public static explicit operator SqlByte(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255.0 || x.Value < 0.0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003CE5B File Offset: 0x0003B05B
		public static explicit operator SqlByte(SqlDecimal x)
		{
			return (SqlByte)((SqlInt32)x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">An instance of the <see langword="SqlString" /> class. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the numeric value represented by the <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003CE68 File Offset: 0x0003B068
		public static explicit operator SqlByte(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(byte.Parse(x.Value, null));
			}
			return SqlByte.Null;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlByte" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003CE8B File Offset: 0x0003B08B
		public static SqlBoolean operator ==(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AA5 RID: 2725 RVA: 0x0003CEB8 File Offset: 0x0003B0B8
		public static SqlBoolean operator !=(SqlByte x, SqlByte y)
		{
			return !(x == y);
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AA6 RID: 2726 RVA: 0x0003CEC6 File Offset: 0x0003B0C6
		public static SqlBoolean operator <(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AA7 RID: 2727 RVA: 0x0003CEF3 File Offset: 0x0003B0F3
		public static SqlBoolean operator >(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003CF20 File Offset: 0x0003B120
		public static SqlBoolean operator <=(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see langword="SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003CF50 File Offset: 0x0003B150
		public static SqlBoolean operator >=(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>The ones complement operator performs a bitwise one's complement operation on its <see cref="T:System.Data.SqlTypes.SqlByte" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the ones complement of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000AAA RID: 2730 RVA: 0x0003CF80 File Offset: 0x0003B180
		public static SqlByte OnesComplement(SqlByte x)
		{
			return ~x;
		}

		/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlByte" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see langword="Value" /> property contains the results of the addition.</returns>
		// Token: 0x06000AAB RID: 2731 RVA: 0x0003CF88 File Offset: 0x0003B188
		public static SqlByte Add(SqlByte x, SqlByte y)
		{
			return x + y;
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlByte" /> operand from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of subtracting the second <see cref="T:System.Data.SqlTypes.SqlByte" /> operand from the first.</returns>
		// Token: 0x06000AAC RID: 2732 RVA: 0x0003CF91 File Offset: 0x0003B191
		public static SqlByte Subtract(SqlByte x, SqlByte y)
		{
			return x - y;
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the product of the multiplication.</returns>
		// Token: 0x06000AAD RID: 2733 RVA: 0x0003CF9A File Offset: 0x0003B19A
		public static SqlByte Multiply(SqlByte x, SqlByte y)
		{
			return x * y;
		}

		/// <summary>Divides its first <see cref="T:System.Data.SqlTypes.SqlByte" /> operand by its second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000AAE RID: 2734 RVA: 0x0003CFA3 File Offset: 0x0003B1A3
		public static SqlByte Divide(SqlByte x, SqlByte y)
		{
			return x / y;
		}

		/// <summary>Computes the remainder after dividing its first <see cref="T:System.Data.SqlTypes.SqlByte" /> operand by its second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> contains the remainder.</returns>
		// Token: 0x06000AAF RID: 2735 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		public static SqlByte Mod(SqlByte x, SqlByte y)
		{
			return x % y;
		}

		/// <summary>Divides two <see cref="T:System.Data.SqlTypes.SqlByte" /> values and returns the remainder.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>The remainder left after division is performed on <paramref name="x" /> and <paramref name="y" />.</returns>
		// Token: 0x06000AB0 RID: 2736 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		public static SqlByte Modulus(SqlByte x, SqlByte y)
		{
			return x % y;
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of the bitwise AND operation.</returns>
		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003CFB5 File Offset: 0x0003B1B5
		public static SqlByte BitwiseAnd(SqlByte x, SqlByte y)
		{
			return x & y;
		}

		/// <summary>Computes the bitwise OR of its two <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of the bitwise OR operation.</returns>
		// Token: 0x06000AB2 RID: 2738 RVA: 0x0003CFBE File Offset: 0x0003B1BE
		public static SqlByte BitwiseOr(SqlByte x, SqlByte y)
		{
			return x | y;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>The results of the XOR operation.</returns>
		// Token: 0x06000AB3 RID: 2739 RVA: 0x0003CFC7 File Offset: 0x0003B1C7
		public static SqlByte Xor(SqlByte x, SqlByte y)
		{
			return x ^ y;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlByte" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlByte" /> will be null.</returns>
		// Token: 0x06000AB4 RID: 2740 RVA: 0x0003CFD0 File Offset: 0x0003B1D0
		public static SqlBoolean Equals(SqlByte x, SqlByte y)
		{
			return x == y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003CFD9 File Offset: 0x0003B1D9
		public static SqlBoolean NotEquals(SqlByte x, SqlByte y)
		{
			return x != y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0003CFE2 File Offset: 0x0003B1E2
		public static SqlBoolean LessThan(SqlByte x, SqlByte y)
		{
			return x < y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x0003CFEB File Offset: 0x0003B1EB
		public static SqlBoolean GreaterThan(SqlByte x, SqlByte y)
		{
			return x > y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AB8 RID: 2744 RVA: 0x0003CFF4 File Offset: 0x0003B1F4
		public static SqlBoolean LessThanOrEqual(SqlByte x, SqlByte y)
		{
			return x <= y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlByte" /> structures to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000AB9 RID: 2745 RVA: 0x0003CFFD File Offset: 0x0003B1FD
		public static SqlBoolean GreaterThanOrEqual(SqlByte x, SqlByte y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000ABA RID: 2746 RVA: 0x0003D006 File Offset: 0x0003B206
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A <see langword="SqlDouble" /> structure with the same value as this <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x06000ABB RID: 2747 RVA: 0x0003D013 File Offset: 0x0003B213
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A <see langword="SqlInt16" /> structure with the same value as this <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x06000ABC RID: 2748 RVA: 0x0003D020 File Offset: 0x0003B220
		public SqlInt16 ToSqlInt16()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A <see langword="SqlInt32" /> structure with the same value as this <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x06000ABD RID: 2749 RVA: 0x0003D02D File Offset: 0x0003B22D
		public SqlInt32 ToSqlInt32()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A <see langword="SqlInt64" /> structure who <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x06000ABE RID: 2750 RVA: 0x0003D03A File Offset: 0x0003B23A
		public SqlInt64 ToSqlInt64()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A <see langword="SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</returns>
		// Token: 0x06000ABF RID: 2751 RVA: 0x0003D047 File Offset: 0x0003B247
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A <see langword="SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</returns>
		// Token: 0x06000AC0 RID: 2752 RVA: 0x0003D054 File Offset: 0x0003B254
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A <see langword="SqlSingle" /> structure that has the same <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> as this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</returns>
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0003D061 File Offset: 0x0003B261
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Converts this instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see langword="SqlString" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's <see cref="P:System.Data.SqlTypes.SqlByte.Value" />.</returns>
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0003D06E File Offset: 0x0003B26E
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return Value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000AC3 RID: 2755 RVA: 0x0003D07C File Offset: 0x0003B27C
		public int CompareTo(object value)
		{
			if (value is SqlByte)
			{
				SqlByte value2 = (SqlByte)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlByte));
		}

		/// <summary>Compares this instance to the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> object and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlByte" /> object to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return Value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003D0B8 File Offset: 0x0003B2B8
		public int CompareTo(SqlByte value)
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

		/// <summary>Compares the supplied <see cref="T:System.Object" /> parameter to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> object.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003D110 File Offset: 0x0003B310
		public override bool Equals(object value)
		{
			if (!(value is SqlByte))
			{
				return false;
			}
			SqlByte y = (SqlByte)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000AC6 RID: 2758 RVA: 0x0003D168 File Offset: 0x0003B368
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
		// Token: 0x06000AC7 RID: 2759 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000AC8 RID: 2760 RVA: 0x0003D190 File Offset: 0x0003B390
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToByte(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter " />
		///     </param>
		// Token: 0x06000AC9 RID: 2761 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
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
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000ACA RID: 2762 RVA: 0x0003D216 File Offset: 0x0003B416
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("unsignedByte", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x0400038D RID: 909
		private bool m_fNotNull;

		// Token: 0x0400038E RID: 910
		private byte m_value;

		// Token: 0x0400038F RID: 911
		private static readonly int s_iBitNotByteMax = -256;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</summary>
		// Token: 0x04000390 RID: 912
		public static readonly SqlByte Null = new SqlByte(true);

		/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</summary>
		// Token: 0x04000391 RID: 913
		public static readonly SqlByte Zero = new SqlByte(0);

		/// <summary>A constant representing the smallest possible value of a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		// Token: 0x04000392 RID: 914
		public static readonly SqlByte MinValue = new SqlByte(0);

		/// <summary>A constant representing the largest possible value of a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		// Token: 0x04000393 RID: 915
		public static readonly SqlByte MaxValue = new SqlByte(byte.MaxValue);
	}
}
