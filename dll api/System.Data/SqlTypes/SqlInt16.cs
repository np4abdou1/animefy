using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a 16-bit signed integer to be stored in or retrieved from a database.</summary>
	// Token: 0x020000BA RID: 186
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlInt16 : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000C29 RID: 3113 RVA: 0x00042B6F File Offset: 0x00040D6F
		private SqlInt16(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure using the supplied short integer parameter.</summary>
		/// <param name="value">A short integer. </param>
		// Token: 0x06000C2A RID: 3114 RVA: 0x00042B7F File Offset: 0x00040D7F
		public SqlInt16(short value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if null. Otherwise, <see langword="false" />. For more information, see Handling Null Values.</returns>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00042B8F File Offset: 0x00040D8F
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Gets the value of this instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. This property is read-only.</summary>
		/// <returns>A short integer representing the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00042B9A File Offset: 0x00040D9A
		public short Value
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

		/// <summary>Converts the supplied short integer to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A short integer value. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure with the same value as the specified short integer.</returns>
		// Token: 0x06000C2D RID: 3117 RVA: 0x00042BB0 File Offset: 0x00040DB0
		public static implicit operator SqlInt16(short x)
		{
			return new SqlInt16(x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to a short integer.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A short integer whose value is the Value of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000C2E RID: 3118 RVA: 0x00042BB8 File Offset: 0x00040DB8
		public static explicit operator short(SqlInt16 x)
		{
			return x.Value;
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.String" />.</summary>
		/// <returns>A <see cref="T:System.String" /> object representing the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of this instance of <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06000C2F RID: 3119 RVA: 0x00042BC1 File Offset: 0x00040DC1
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its 16-bit signed integer equivalent.</summary>
		/// <param name="s">The <see langword="String" /> to be parsed. </param>
		/// <returns>A 16-bit signed integer equivalent to the value that is contained in the specified <see cref="T:System.String" />.</returns>
		// Token: 0x06000C30 RID: 3120 RVA: 0x00042BDD File Offset: 0x00040DDD
		public static SqlInt16 Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlInt16.Null;
			}
			return new SqlInt16(short.Parse(s, null));
		}

		/// <summary>The unary minus operator negates the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure that contains the negated value.</returns>
		// Token: 0x06000C31 RID: 3121 RVA: 0x00042BFE File Offset: 0x00040DFE
		public static SqlInt16 operator -(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(-x.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>The ~ operator performs a bitwise one's complement operation on its <see cref="T:System.Data.SqlTypes.SqlByte" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the complement of the specified <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C32 RID: 3122 RVA: 0x00042C1C File Offset: 0x00040E1C
		public static SqlInt16 operator ~(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(~x.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</returns>
		// Token: 0x06000C33 RID: 3123 RVA: 0x00042C3C File Offset: 0x00040E3C
		public static SqlInt16 operator +(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			int num = (int)(x.m_value + y.m_value);
			if (((num >> 15 ^ num >> 16) & 1) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)num);
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the subtraction.</returns>
		// Token: 0x06000C34 RID: 3124 RVA: 0x00042C90 File Offset: 0x00040E90
		public static SqlInt16 operator -(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			int num = (int)(x.m_value - y.m_value);
			if (((num >> 15 ^ num >> 16) & 1) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)num);
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> contains the product of the two parameters.</returns>
		// Token: 0x06000C35 RID: 3125 RVA: 0x00042CE4 File Offset: 0x00040EE4
		public static SqlInt16 operator *(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			int num = (int)(x.m_value * y.m_value);
			int num2 = num & SqlInt16.s_MASKI2;
			if (num2 != 0 && num2 != SqlInt16.s_MASKI2)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)num);
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlInt16" /> operand by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000C36 RID: 3126 RVA: 0x00042D3C File Offset: 0x00040F3C
		public static SqlInt16 operator /(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -32768 && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16(x.m_value / y.m_value);
		}

		/// <summary>Computes the remainder after dividing its first <see cref="T:System.Data.SqlTypes.SqlInt16" /> operand by its second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> contains the remainder.</returns>
		// Token: 0x06000C37 RID: 3127 RVA: 0x00042DA8 File Offset: 0x00040FA8
		public static SqlInt16 operator %(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -32768 && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16(x.m_value % y.m_value);
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the bitwise AND.</returns>
		// Token: 0x06000C38 RID: 3128 RVA: 0x00042E14 File Offset: 0x00041014
		public static SqlInt16 operator &(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt16(x.m_value & y.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Computes the bitwise OR of its two <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the bitwise OR.</returns>
		// Token: 0x06000C39 RID: 3129 RVA: 0x00042E41 File Offset: 0x00041041
		public static SqlInt16 operator |(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt16((short)((ushort)x.m_value | (ushort)y.m_value));
			}
			return SqlInt16.Null;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the bitwise XOR.</returns>
		// Token: 0x06000C3A RID: 3130 RVA: 0x00042E70 File Offset: 0x00041070
		public static SqlInt16 operator ^(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt16(x.m_value ^ y.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000C3B RID: 3131 RVA: 0x00042E9D File Offset: 0x0004109D
		public static explicit operator SqlInt16(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16((short)x.ByteValue);
			}
			return SqlInt16.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000C3C RID: 3132 RVA: 0x00042EBA File Offset: 0x000410BA
		public static implicit operator SqlInt16(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16((short)x.Value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000C3D RID: 3133 RVA: 0x00042ED8 File Offset: 0x000410D8
		public static explicit operator SqlInt16(SqlInt32 x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			int value = x.Value;
			if (value > 32767 || value < -32768)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000C3E RID: 3134 RVA: 0x00042F20 File Offset: 0x00041120
		public static explicit operator SqlInt16(SqlInt64 x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			long value = x.Value;
			if (value > 32767L || value < -32768L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the integer part of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000C3F RID: 3135 RVA: 0x00042F68 File Offset: 0x00041168
		public static explicit operator SqlInt16(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			float value = x.Value;
			if (value < -32768f || value > 32767f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the integer part of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000C40 RID: 3136 RVA: 0x00042FB0 File Offset: 0x000411B0
		public static explicit operator SqlInt16(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			double value = x.Value;
			if (value < -32768.0 || value > 32767.0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000C41 RID: 3137 RVA: 0x00042FFE File Offset: 0x000411FE
		public static explicit operator SqlInt16(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(checked((short)x.ToInt32()));
			}
			return SqlInt16.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000C42 RID: 3138 RVA: 0x0004301C File Offset: 0x0004121C
		public static explicit operator SqlInt16(SqlDecimal x)
		{
			return (SqlInt16)((SqlInt32)x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> object to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" /> object. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property is equal to the value represented by the <see cref="T:System.Data.SqlTypes.SqlString" /> object parameter.</returns>
		// Token: 0x06000C43 RID: 3139 RVA: 0x00043029 File Offset: 0x00041229
		public static explicit operator SqlInt16(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(short.Parse(x.Value, null));
			}
			return SqlInt16.Null;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C44 RID: 3140 RVA: 0x0004304C File Offset: 0x0004124C
		public static SqlBoolean operator ==(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C45 RID: 3141 RVA: 0x00043079 File Offset: 0x00041279
		public static SqlBoolean operator !=(SqlInt16 x, SqlInt16 y)
		{
			return !(x == y);
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlInt16" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C46 RID: 3142 RVA: 0x00043087 File Offset: 0x00041287
		public static SqlBoolean operator <(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlInt16" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C47 RID: 3143 RVA: 0x000430B4 File Offset: 0x000412B4
		public static SqlBoolean operator >(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C48 RID: 3144 RVA: 0x000430E1 File Offset: 0x000412E1
		public static SqlBoolean operator <=(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C49 RID: 3145 RVA: 0x00043111 File Offset: 0x00041311
		public static SqlBoolean operator >=(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>The ~ operator performs a bitwise one's complement operation on its <see cref="T:System.Data.SqlTypes.SqlByte" /> operand.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the complement of the specified <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C4A RID: 3146 RVA: 0x00043141 File Offset: 0x00041341
		public static SqlInt16 OnesComplement(SqlInt16 x)
		{
			return ~x;
		}

		/// <summary>Computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the sum of the two <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</returns>
		// Token: 0x06000C4B RID: 3147 RVA: 0x00043149 File Offset: 0x00041349
		public static SqlInt16 Add(SqlInt16 x, SqlInt16 y)
		{
			return x + y;
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the subtraction.</returns>
		// Token: 0x06000C4C RID: 3148 RVA: 0x00043152 File Offset: 0x00041352
		public static SqlInt16 Subtract(SqlInt16 x, SqlInt16 y)
		{
			return x - y;
		}

		/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> contains the product of the two parameters.</returns>
		// Token: 0x06000C4D RID: 3149 RVA: 0x0004315B File Offset: 0x0004135B
		public static SqlInt16 Multiply(SqlInt16 x, SqlInt16 y)
		{
			return x * y;
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlInt16" /> operand by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the division.</returns>
		// Token: 0x06000C4E RID: 3150 RVA: 0x00043164 File Offset: 0x00041364
		public static SqlInt16 Divide(SqlInt16 x, SqlInt16 y)
		{
			return x / y;
		}

		/// <summary>Computes the remainder after dividing its first <see cref="T:System.Data.SqlTypes.SqlInt16" /> operand by its second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> contains the remainder.</returns>
		// Token: 0x06000C4F RID: 3151 RVA: 0x0004316D File Offset: 0x0004136D
		public static SqlInt16 Mod(SqlInt16 x, SqlInt16 y)
		{
			return x % y;
		}

		/// <summary>Divides two <see cref="T:System.Data.SqlTypes.SqlInt16" /> values and returns the remainder.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> value.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> value.</param>
		/// <returns>The remainder left after division is performed on <paramref name="x" /> and <paramref name="y" />.</returns>
		// Token: 0x06000C50 RID: 3152 RVA: 0x0004316D File Offset: 0x0004136D
		public static SqlInt16 Modulus(SqlInt16 x, SqlInt16 y)
		{
			return x % y;
		}

		/// <summary>Computes the bitwise AND of its <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the bitwise AND.</returns>
		// Token: 0x06000C51 RID: 3153 RVA: 0x00043176 File Offset: 0x00041376
		public static SqlInt16 BitwiseAnd(SqlInt16 x, SqlInt16 y)
		{
			return x & y;
		}

		/// <summary>Computes the bitwise OR of its two <see cref="T:System.Data.SqlTypes.SqlInt16" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property contains the results of the bitwise OR.</returns>
		// Token: 0x06000C52 RID: 3154 RVA: 0x0004317F File Offset: 0x0004137F
		public static SqlInt16 BitwiseOr(SqlInt16 x, SqlInt16 y)
		{
			return x | y;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure that contains the results of the XOR operation.</returns>
		// Token: 0x06000C53 RID: 3155 RVA: 0x00043188 File Offset: 0x00041388
		public static SqlInt16 Xor(SqlInt16 x, SqlInt16 y)
		{
			return x ^ y;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlInt16" /> will be null.</returns>
		// Token: 0x06000C54 RID: 3156 RVA: 0x00043191 File Offset: 0x00041391
		public static SqlBoolean Equals(SqlInt16 x, SqlInt16 y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C55 RID: 3157 RVA: 0x0004319A File Offset: 0x0004139A
		public static SqlBoolean NotEquals(SqlInt16 x, SqlInt16 y)
		{
			return x != y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlInt16" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C56 RID: 3158 RVA: 0x000431A3 File Offset: 0x000413A3
		public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y)
		{
			return x < y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlInt16" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C57 RID: 3159 RVA: 0x000431AC File Offset: 0x000413AC
		public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y)
		{
			return x > y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C58 RID: 3160 RVA: 0x000431B5 File Offset: 0x000413B5
		public static SqlBoolean LessThanOrEqual(SqlInt16 x, SqlInt16 y)
		{
			return x <= y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlInt16" /> structures to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000C59 RID: 3161 RVA: 0x000431BE File Offset: 0x000413BE
		public static SqlBoolean GreaterThanOrEqual(SqlInt16 x, SqlInt16 y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000C5A RID: 3162 RVA: 0x000431C7 File Offset: 0x000413C7
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. If the value of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> is less than 0 or greater than 255, an <see cref="T:System.OverflowException" /> occurs.</returns>
		// Token: 0x06000C5B RID: 3163 RVA: 0x000431D4 File Offset: 0x000413D4
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see langword="Value" /> equals the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C5C RID: 3164 RVA: 0x000431E1 File Offset: 0x000413E1
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see langword="Value" /> equals the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C5D RID: 3165 RVA: 0x000431EE File Offset: 0x000413EE
		public SqlInt32 ToSqlInt32()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see langword="Value" /> equals the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C5E RID: 3166 RVA: 0x000431FB File Offset: 0x000413FB
		public SqlInt64 ToSqlInt64()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see langword="Value" /> equals the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C5F RID: 3167 RVA: 0x00043208 File Offset: 0x00041408
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see langword="Value" /> equals the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C60 RID: 3168 RVA: 0x00043215 File Offset: 0x00041415
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see langword="Value" /> equals the value of this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</returns>
		// Token: 0x06000C61 RID: 3169 RVA: 0x00043222 File Offset: 0x00041422
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> representing the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of this instance of <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06000C62 RID: 3170 RVA: 0x0004322F File Offset: 0x0004142F
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlInt16" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000C63 RID: 3171 RVA: 0x0004323C File Offset: 0x0004143C
		public int CompareTo(object value)
		{
			if (value is SqlInt16)
			{
				SqlInt16 value2 = (SqlInt16)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlInt16));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlInt16" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000C64 RID: 3172 RVA: 0x00043278 File Offset: 0x00041478
		public int CompareTo(SqlInt16 value)
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

		/// <summary>Compares the specified object to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlInt16" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000C65 RID: 3173 RVA: 0x000432D0 File Offset: 0x000414D0
		public override bool Equals(object value)
		{
			if (!(value is SqlInt16))
			{
				return false;
			}
			SqlInt16 y = (SqlInt16)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000C66 RID: 3174 RVA: 0x00043328 File Offset: 0x00041528
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this.Value.GetHashCode();
			}
			return 0;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>An XML schema consumed by .NET Framework.</returns>
		// Token: 0x06000C67 RID: 3175 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code. </summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000C68 RID: 3176 RVA: 0x00043350 File Offset: 0x00041550
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToInt16(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter " />
		///     </param>
		// Token: 0x06000C69 RID: 3177 RVA: 0x000433A0 File Offset: 0x000415A0
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
		/// <returns>A <see cref="T:System.String" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000C6A RID: 3178 RVA: 0x000433D6 File Offset: 0x000415D6
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("short", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000412 RID: 1042
		private bool m_fNotNull;

		// Token: 0x04000413 RID: 1043
		private short m_value;

		// Token: 0x04000414 RID: 1044
		private static readonly int s_MASKI2 = -32768;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</summary>
		// Token: 0x04000415 RID: 1045
		public static readonly SqlInt16 Null = new SqlInt16(true);

		/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</summary>
		// Token: 0x04000416 RID: 1046
		public static readonly SqlInt16 Zero = new SqlInt16(0);

		/// <summary>A constant representing the smallest possible value of a <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		// Token: 0x04000417 RID: 1047
		public static readonly SqlInt16 MinValue = new SqlInt16(short.MinValue);

		/// <summary>A constant representing the largest possible value of a <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		// Token: 0x04000418 RID: 1048
		public static readonly SqlInt16 MaxValue = new SqlInt16(short.MaxValue);
	}
}
