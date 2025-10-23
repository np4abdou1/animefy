using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a floating-point number within the range of -1.79E +308 through 1.79E +308 to be stored in or retrieved from a database.</summary>
	// Token: 0x020000B8 RID: 184
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlDouble : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000BCA RID: 3018 RVA: 0x00041F9B File Offset: 0x0004019B
		private SqlDouble(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0.0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure using the supplied double parameter to set the new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> property.</summary>
		/// <param name="value">A double whose value will be used for the new <see cref="T:System.Data.SqlTypes.SqlDouble" />. </param>
		// Token: 0x06000BCB RID: 3019 RVA: 0x00041FB3 File Offset: 0x000401B3
		public SqlDouble(double value)
		{
			if (!double.IsFinite(value))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Returns a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlDouble" /> instance is null.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00041FD6 File Offset: 0x000401D6
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. This property is read-only.</summary>
		/// <returns>The value of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</returns>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00041FE1 File Offset: 0x000401E1
		public double Value
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

		/// <summary>Converts the supplied double value to a <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">The double value to convert. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> with the same value as the specified double parameter.</returns>
		// Token: 0x06000BCE RID: 3022 RVA: 0x00041FF7 File Offset: 0x000401F7
		public static implicit operator SqlDouble(double x)
		{
			return new SqlDouble(x);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to double.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A double equivalent to the specified <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's value.</returns>
		// Token: 0x06000BCF RID: 3023 RVA: 0x00041FFF File Offset: 0x000401FF
		public static explicit operator double(SqlDouble x)
		{
			return x.Value;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to a string.</summary>
		/// <returns>A string representing the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06000BD0 RID: 3024 RVA: 0x00042008 File Offset: 0x00040208
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its double-precision floating point number equivalent.</summary>
		/// <param name="s">The <see langword="String" /> to be parsed. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> that contains the value represented by the <see langword="String" />.</returns>
		// Token: 0x06000BD1 RID: 3025 RVA: 0x00042024 File Offset: 0x00040224
		public static SqlDouble Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlDouble.Null;
			}
			return new SqlDouble(double.Parse(s, CultureInfo.InvariantCulture));
		}

		/// <summary>Returns the negated value of the specified <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure that contains the negated value.</returns>
		// Token: 0x06000BD2 RID: 3026 RVA: 0x00042049 File Offset: 0x00040249
		public static SqlDouble operator -(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble(-x.m_value);
			}
			return SqlDouble.Null;
		}

		/// <summary>The addition operator computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>The sum of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</returns>
		// Token: 0x06000BD3 RID: 3027 RVA: 0x00042066 File Offset: 0x00040266
		public static SqlDouble operator +(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			double num = x.m_value + y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>The subtraction operator the second <see cref="T:System.Data.SqlTypes.SqlDouble" /> operand from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>The results of the subtraction operation.</returns>
		// Token: 0x06000BD4 RID: 3028 RVA: 0x000420A5 File Offset: 0x000402A5
		public static SqlDouble operator -(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			double num = x.m_value - y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>The multiplication operator computes the product of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>The product of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</returns>
		// Token: 0x06000BD5 RID: 3029 RVA: 0x000420E4 File Offset: 0x000402E4
		public static SqlDouble operator *(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			double num = x.m_value * y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>The division operator divides the first <see cref="T:System.Data.SqlTypes.SqlDouble" /> operand by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure that contains the results of the division operation.</returns>
		// Token: 0x06000BD6 RID: 3030 RVA: 0x00042124 File Offset: 0x00040324
		public static SqlDouble operator /(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			if (y.m_value == 0.0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			double num = x.m_value / y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is either 0 or 1, depending on the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BD7 RID: 3031 RVA: 0x0004218A File Offset: 0x0004038A
		public static explicit operator SqlDouble(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.ByteValue);
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlByte" /> is <see cref="F:System.Data.SqlTypes.SqlByte.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BD8 RID: 3032 RVA: 0x000421A8 File Offset: 0x000403A8
		public static implicit operator SqlDouble(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlInt16" /> is <see cref="F:System.Data.SqlTypes.SqlInt16.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BD9 RID: 3033 RVA: 0x000421C6 File Offset: 0x000403C6
		public static implicit operator SqlDouble(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlInt32" /> is <see cref="F:System.Data.SqlTypes.SqlInt32.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BDA RID: 3034 RVA: 0x000421E4 File Offset: 0x000403E4
		public static implicit operator SqlDouble(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlInt64" /> is <see cref="F:System.Data.SqlTypes.SqlInt64.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BDB RID: 3035 RVA: 0x00042202 File Offset: 0x00040402
		public static implicit operator SqlDouble(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlSingle" /> is <see cref="F:System.Data.SqlTypes.SqlSingle.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BDC RID: 3036 RVA: 0x00042220 File Offset: 0x00040420
		public static implicit operator SqlDouble(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlMoney" /> is <see cref="F:System.Data.SqlTypes.SqlMoney.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BDD RID: 3037 RVA: 0x0004223E File Offset: 0x0004043E
		public static implicit operator SqlDouble(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble(x.ToDouble());
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is <see cref="F:System.Data.SqlTypes.SqlDecimal.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BDE RID: 3038 RVA: 0x0004225B File Offset: 0x0004045B
		public static implicit operator SqlDouble(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble(x.ToDouble());
			}
			return SqlDouble.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" /> object. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the value of the number represented by the <see cref="T:System.Data.SqlTypes.SqlString" />. If the <see cref="T:System.Data.SqlTypes.SqlString" /> is <see cref="F:System.Data.SqlTypes.SqlString.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BDF RID: 3039 RVA: 0x00042278 File Offset: 0x00040478
		public static explicit operator SqlDouble(SqlString x)
		{
			if (x.IsNull)
			{
				return SqlDouble.Null;
			}
			return SqlDouble.Parse(x.Value);
		}

		/// <summary>Performs a logical comparison on two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000BE0 RID: 3040 RVA: 0x00042295 File Offset: 0x00040495
		public static SqlBoolean operator ==(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BE1 RID: 3041 RVA: 0x000422C2 File Offset: 0x000404C2
		public static SqlBoolean operator !=(SqlDouble x, SqlDouble y)
		{
			return !(x == y);
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BE2 RID: 3042 RVA: 0x000422D0 File Offset: 0x000404D0
		public static SqlBoolean operator <(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BE3 RID: 3043 RVA: 0x000422FD File Offset: 0x000404FD
		public static SqlBoolean operator >(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BE4 RID: 3044 RVA: 0x0004232A File Offset: 0x0004052A
		public static SqlBoolean operator <=(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BE5 RID: 3045 RVA: 0x0004235A File Offset: 0x0004055A
		public static SqlBoolean operator >=(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>The addition operator computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>The sum of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</returns>
		// Token: 0x06000BE6 RID: 3046 RVA: 0x0004238A File Offset: 0x0004058A
		public static SqlDouble Add(SqlDouble x, SqlDouble y)
		{
			return x + y;
		}

		/// <summary>The subtraction operator the second <see cref="T:System.Data.SqlTypes.SqlDouble" /> operand from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>The results of the subtraction operation.</returns>
		// Token: 0x06000BE7 RID: 3047 RVA: 0x00042393 File Offset: 0x00040593
		public static SqlDouble Subtract(SqlDouble x, SqlDouble y)
		{
			return x - y;
		}

		/// <summary>The multiplication operator computes the product of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>The product of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</returns>
		// Token: 0x06000BE8 RID: 3048 RVA: 0x0004239C File Offset: 0x0004059C
		public static SqlDouble Multiply(SqlDouble x, SqlDouble y)
		{
			return x * y;
		}

		/// <summary>The division operator divides the first <see cref="T:System.Data.SqlTypes.SqlDouble" /> operand by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure that contains the results of the division operation.</returns>
		// Token: 0x06000BE9 RID: 3049 RVA: 0x000423A5 File Offset: 0x000405A5
		public static SqlDouble Divide(SqlDouble x, SqlDouble y)
		{
			return x / y;
		}

		/// <summary>Performs a logical comparison on two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000BEA RID: 3050 RVA: 0x000423AE File Offset: 0x000405AE
		public static SqlBoolean Equals(SqlDouble x, SqlDouble y)
		{
			return x == y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether they are notequal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BEB RID: 3051 RVA: 0x000423B7 File Offset: 0x000405B7
		public static SqlBoolean NotEquals(SqlDouble x, SqlDouble y)
		{
			return x != y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BEC RID: 3052 RVA: 0x000423C0 File Offset: 0x000405C0
		public static SqlBoolean LessThan(SqlDouble x, SqlDouble y)
		{
			return x < y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BED RID: 3053 RVA: 0x000423C9 File Offset: 0x000405C9
		public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y)
		{
			return x > y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BEE RID: 3054 RVA: 0x000423D2 File Offset: 0x000405D2
		public static SqlBoolean LessThanOrEqual(SqlDouble x, SqlDouble y)
		{
			return x <= y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000BEF RID: 3055 RVA: 0x000423DB File Offset: 0x000405DB
		public static SqlBoolean GreaterThanOrEqual(SqlDouble x, SqlDouble y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>A <see langword="SqlBoolean" /> structure whose <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is non-zero, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the <see cref="T:System.Data.SqlTypes.SqlDouble" /> is zero and <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" /> if the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure is <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x06000BF0 RID: 3056 RVA: 0x000423E4 File Offset: 0x000405E4
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A <see langword="SqlByte" /> structure whose <see langword="Value" /> equals the <see langword="Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</returns>
		// Token: 0x06000BF1 RID: 3057 RVA: 0x000423F1 File Offset: 0x000405F1
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure whose <see langword="Value" /> equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's value.</returns>
		// Token: 0x06000BF2 RID: 3058 RVA: 0x000423FE File Offset: 0x000405FE
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure whose <see langword="Value" /> equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's value.</returns>
		// Token: 0x06000BF3 RID: 3059 RVA: 0x0004240B File Offset: 0x0004060B
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure whose <see langword="Value" /> equals the integer part of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's value.</returns>
		// Token: 0x06000BF4 RID: 3060 RVA: 0x00042418 File Offset: 0x00040618
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A new <see langword="SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> is equal to the value of this <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06000BF5 RID: 3061 RVA: 0x00042425 File Offset: 0x00040625
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see langword="SqlDecimal" /> structure whose converted value equals the rounded value of this <see langword="SqlDouble" />.</returns>
		// Token: 0x06000BF6 RID: 3062 RVA: 0x00042432 File Offset: 0x00040632
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A new <see langword="SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06000BF7 RID: 3063 RVA: 0x0004243F File Offset: 0x0004063F
		public SqlSingle ToSqlSingle()
		{
			return (SqlSingle)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see langword="SqlString" /> representing the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06000BF8 RID: 3064 RVA: 0x0004244C File Offset: 0x0004064C
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDouble" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to compare. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing " />in Visual Basic). </returns>
		// Token: 0x06000BF9 RID: 3065 RVA: 0x0004245C File Offset: 0x0004065C
		public int CompareTo(object value)
		{
			if (value is SqlDouble)
			{
				SqlDouble value2 = (SqlDouble)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlDouble));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDouble" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000BFA RID: 3066 RVA: 0x00042498 File Offset: 0x00040698
		public int CompareTo(SqlDouble value)
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

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000BFB RID: 3067 RVA: 0x000424F0 File Offset: 0x000406F0
		public override bool Equals(object value)
		{
			if (!(value is SqlDouble))
			{
				return false;
			}
			SqlDouble y = (SqlDouble)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structre.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000BFC RID: 3068 RVA: 0x00042548 File Offset: 0x00040748
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
		// Token: 0x06000BFD RID: 3069 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">A <see cref="T:System.Xml.XmlReader" />.</param>
		// Token: 0x06000BFE RID: 3070 RVA: 0x00042570 File Offset: 0x00040770
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToDouble(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">A <see cref="T:System.Xml.XmlWriter" />.</param>
		// Token: 0x06000BFF RID: 3071 RVA: 0x000425C0 File Offset: 0x000407C0
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
		// Token: 0x06000C00 RID: 3072 RVA: 0x000425F6 File Offset: 0x000407F6
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("double", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000408 RID: 1032
		private bool m_fNotNull;

		// Token: 0x04000409 RID: 1033
		private double m_value;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
		// Token: 0x0400040A RID: 1034
		public static readonly SqlDouble Null = new SqlDouble(true);

		/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
		// Token: 0x0400040B RID: 1035
		public static readonly SqlDouble Zero = new SqlDouble(0.0);

		/// <summary>A constant representing the minimum possible value of <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		// Token: 0x0400040C RID: 1036
		public static readonly SqlDouble MinValue = new SqlDouble(double.MinValue);

		/// <summary>A constant representing the maximum value for a <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
		// Token: 0x0400040D RID: 1037
		public static readonly SqlDouble MaxValue = new SqlDouble(double.MaxValue);
	}
}
