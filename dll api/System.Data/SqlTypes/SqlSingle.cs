using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a floating point number within the range of -3.40E +38 through 3.40E +38 to be stored in or retrieved from a database.</summary>
	// Token: 0x020000BE RID: 190
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlSingle : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000D37 RID: 3383 RVA: 0x00045087 File Offset: 0x00043287
		private SqlSingle(bool fNull)
		{
			this._fNotNull = false;
			this._value = 0f;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
		/// <param name="value">A floating point number which will be used as the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		// Token: 0x06000D38 RID: 3384 RVA: 0x0004509B File Offset: 0x0004329B
		public SqlSingle(float value)
		{
			if (!float.IsFinite(value))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this._fNotNull = true;
			this._value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure using the supplied double parameter.</summary>
		/// <param name="value">A double value which will be used as the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		// Token: 0x06000D39 RID: 3385 RVA: 0x000450BE File Offset: 0x000432BE
		public SqlSingle(double value)
		{
			this = new SqlSingle((float)value);
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000450C8 File Offset: 0x000432C8
		public bool IsNull
		{
			get
			{
				return !this._fNotNull;
			}
		}

		/// <summary>Gets the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. This property is read-only.</summary>
		/// <returns>A floating point value in the range -3.40E+38 through 3.40E+38.</returns>
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000450D3 File Offset: 0x000432D3
		public float Value
		{
			get
			{
				if (this._fNotNull)
				{
					return this._value;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Converts the specified floating point value to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The float value to be converted to <see cref="T:System.Data.SqlTypes.SqlSingle" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the value of the specified float.</returns>
		// Token: 0x06000D3C RID: 3388 RVA: 0x000450E9 File Offset: 0x000432E9
		public static implicit operator SqlSingle(float x)
		{
			return new SqlSingle(x);
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to float.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlSingle" /> value to be converted to float. </param>
		/// <returns>A float that contains the value of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</returns>
		// Token: 0x06000D3D RID: 3389 RVA: 0x000450F1 File Offset: 0x000432F1
		public static explicit operator float(SqlSingle x)
		{
			return x.Value;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.String" />.</summary>
		/// <returns>A <see langword="String" /> object representing the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D3E RID: 3390 RVA: 0x000450FA File Offset: 0x000432FA
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this._value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the specified <see cref="T:System.String" /> to a <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
		/// <param name="s">The <see cref="T:System.String" /> to be parsed. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> equivalent to the value that is contained in the specified <see cref="T:System.String" />.</returns>
		// Token: 0x06000D3F RID: 3391 RVA: 0x00045116 File Offset: 0x00043316
		public static SqlSingle Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlSingle.Null;
			}
			return new SqlSingle(float.Parse(s, CultureInfo.InvariantCulture));
		}

		/// <summary>Negates the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the negated value.</returns>
		// Token: 0x06000D40 RID: 3392 RVA: 0x0004513B File Offset: 0x0004333B
		public static SqlSingle operator -(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(-x._value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</returns>
		// Token: 0x06000D41 RID: 3393 RVA: 0x00045158 File Offset: 0x00043358
		public static SqlSingle operator +(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			float num = x._value + y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the results of the subtraction.</returns>
		// Token: 0x06000D42 RID: 3394 RVA: 0x00045197 File Offset: 0x00043397
		public static SqlSingle operator -(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			float num = x._value - y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Computes the product of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the product of the multiplication.</returns>
		// Token: 0x06000D43 RID: 3395 RVA: 0x000451D6 File Offset: 0x000433D6
		public static SqlSingle operator *(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			float num = x._value * y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the results of the division.</returns>
		// Token: 0x06000D44 RID: 3396 RVA: 0x00045218 File Offset: 0x00043418
		public static SqlSingle operator /(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			if (y._value == 0f)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			float num = x._value / y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>This implicit operator converts the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000D45 RID: 3397 RVA: 0x0004527A File Offset: 0x0004347A
		public static explicit operator SqlSingle(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.ByteValue);
			}
			return SqlSingle.Null;
		}

		/// <summary>This implicit operator converts the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000D46 RID: 3398 RVA: 0x00045298 File Offset: 0x00043498
		public static implicit operator SqlSingle(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000D47 RID: 3399 RVA: 0x000452B6 File Offset: 0x000434B6
		public static implicit operator SqlSingle(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000D48 RID: 3400 RVA: 0x000452D4 File Offset: 0x000434D4
		public static implicit operator SqlSingle(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000D49 RID: 3401 RVA: 0x000452F2 File Offset: 0x000434F2
		public static implicit operator SqlSingle(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000D4A RID: 3402 RVA: 0x00045310 File Offset: 0x00043510
		public static implicit operator SqlSingle(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(x.ToDouble());
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000D4B RID: 3403 RVA: 0x0004532D File Offset: 0x0004352D
		public static implicit operator SqlSingle(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(x.ToDouble());
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000D4C RID: 3404 RVA: 0x0004534A File Offset: 0x0004354A
		public static explicit operator SqlSingle(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlString" /> object to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the value represented by the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter.</returns>
		// Token: 0x06000D4D RID: 3405 RVA: 0x00045367 File Offset: 0x00043567
		public static explicit operator SqlSingle(SqlString x)
		{
			if (x.IsNull)
			{
				return SqlSingle.Null;
			}
			return SqlSingle.Parse(x.Value);
		}

		/// <summary>Performs a logical comparison of the two SqlSingle parameters to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D4E RID: 3406 RVA: 0x00045384 File Offset: 0x00043584
		public static SqlBoolean operator ==(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value == y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D4F RID: 3407 RVA: 0x000453B1 File Offset: 0x000435B1
		public static SqlBoolean operator !=(SqlSingle x, SqlSingle y)
		{
			return !(x == y);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D50 RID: 3408 RVA: 0x000453BF File Offset: 0x000435BF
		public static SqlBoolean operator <(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value < y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> operands to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D51 RID: 3409 RVA: 0x000453EC File Offset: 0x000435EC
		public static SqlBoolean operator >(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value > y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D52 RID: 3410 RVA: 0x00045419 File Offset: 0x00043619
		public static SqlBoolean operator <=(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value <= y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures to determine whether the first is greater than or equl to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D53 RID: 3411 RVA: 0x00045449 File Offset: 0x00043649
		public static SqlBoolean operator >=(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value >= y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</returns>
		// Token: 0x06000D54 RID: 3412 RVA: 0x00045479 File Offset: 0x00043679
		public static SqlSingle Add(SqlSingle x, SqlSingle y)
		{
			return x + y;
		}

		/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure from the first.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the results of the subtraction.</returns>
		// Token: 0x06000D55 RID: 3413 RVA: 0x00045482 File Offset: 0x00043682
		public static SqlSingle Subtract(SqlSingle x, SqlSingle y)
		{
			return x - y;
		}

		/// <summary>Computes the product of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the product of the multiplication.</returns>
		// Token: 0x06000D56 RID: 3414 RVA: 0x0004548B File Offset: 0x0004368B
		public static SqlSingle Multiply(SqlSingle x, SqlSingle y)
		{
			return x * y;
		}

		/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure by the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see langword="SqlInt64" /> structure that contains the results of the division.</returns>
		// Token: 0x06000D57 RID: 3415 RVA: 0x00045494 File Offset: 0x00043694
		public static SqlSingle Divide(SqlSingle x, SqlSingle y)
		{
			return x / y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlSingle" /> will be null.</returns>
		// Token: 0x06000D58 RID: 3416 RVA: 0x0004549D File Offset: 0x0004369D
		public static SqlBoolean Equals(SqlSingle x, SqlSingle y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D59 RID: 3417 RVA: 0x000454A6 File Offset: 0x000436A6
		public static SqlBoolean NotEquals(SqlSingle x, SqlSingle y)
		{
			return x != y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D5A RID: 3418 RVA: 0x000454AF File Offset: 0x000436AF
		public static SqlBoolean LessThan(SqlSingle x, SqlSingle y)
		{
			return x < y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> operands to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D5B RID: 3419 RVA: 0x000454B8 File Offset: 0x000436B8
		public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y)
		{
			return x > y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D5C RID: 3420 RVA: 0x000454C1 File Offset: 0x000436C1
		public static SqlBoolean LessThanOrEqual(SqlSingle x, SqlSingle y)
		{
			return x <= y;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D5D RID: 3421 RVA: 0x000454CA File Offset: 0x000436CA
		public static SqlBoolean GreaterThanOrEqual(SqlSingle x, SqlSingle y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000D5E RID: 3422 RVA: 0x000454D3 File Offset: 0x000436D3
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see langword="Value" /> equals the <see langword="Value" /> of this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. If the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure's Value is <see langword="true" />, the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's <see langword="Value" /> will be 1. Otherwise, the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's <see langword="Value" /> will be 0.</returns>
		// Token: 0x06000D5F RID: 3423 RVA: 0x000454E0 File Offset: 0x000436E0
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A new <see langword="SqlDouble " />equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D60 RID: 3424 RVA: 0x000454ED File Offset: 0x000436ED
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A new <see langword="SqlInt16" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D61 RID: 3425 RVA: 0x000454FA File Offset: 0x000436FA
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D62 RID: 3426 RVA: 0x00045507 File Offset: 0x00043707
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D63 RID: 3427 RVA: 0x00045514 File Offset: 0x00043714
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlMoney" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D64 RID: 3428 RVA: 0x00045521 File Offset: 0x00043721
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see langword="SqlDecimal" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D65 RID: 3429 RVA: 0x0004552E File Offset: 0x0004372E
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> representing the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06000D66 RID: 3430 RVA: 0x0004553B File Offset: 0x0004373B
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlSingle" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000D67 RID: 3431 RVA: 0x00045548 File Offset: 0x00043748
		public int CompareTo(object value)
		{
			if (value is SqlSingle)
			{
				SqlSingle value2 = (SqlSingle)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlSingle));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlSingle" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlSingle" /> to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return Value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000D68 RID: 3432 RVA: 0x00045584 File Offset: 0x00043784
		public int CompareTo(SqlSingle value)
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

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if the object is an instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> and the two are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000D69 RID: 3433 RVA: 0x000455DC File Offset: 0x000437DC
		public override bool Equals(object value)
		{
			if (!(value is SqlSingle))
			{
				return false;
			}
			SqlSingle y = (SqlSingle)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Gets the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000D6A RID: 3434 RVA: 0x00045634 File Offset: 0x00043834
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
		// Token: 0x06000D6B RID: 3435 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000D6C RID: 3436 RVA: 0x0004565C File Offset: 0x0004385C
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._fNotNull = false;
				return;
			}
			this._value = XmlConvert.ToSingle(reader.ReadElementString());
			this._fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter" />
		///     </param>
		// Token: 0x06000D6D RID: 3437 RVA: 0x000456AC File Offset: 0x000438AC
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this._value));
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000D6E RID: 3438 RVA: 0x000456E2 File Offset: 0x000438E2
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("float", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000434 RID: 1076
		private bool _fNotNull;

		// Token: 0x04000435 RID: 1077
		private float _value;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
		// Token: 0x04000436 RID: 1078
		public static readonly SqlSingle Null = new SqlSingle(true);

		/// <summary>Represents the zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> class.</summary>
		// Token: 0x04000437 RID: 1079
		public static readonly SqlSingle Zero = new SqlSingle(0f);

		/// <summary>Represents the minimum value that can be assigned to <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> class.</summary>
		// Token: 0x04000438 RID: 1080
		public static readonly SqlSingle MinValue = new SqlSingle(float.MinValue);

		/// <summary>Represents the maximum value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> class.</summary>
		// Token: 0x04000439 RID: 1081
		public static readonly SqlSingle MaxValue = new SqlSingle(float.MaxValue);
	}
}
