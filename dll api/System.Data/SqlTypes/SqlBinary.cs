using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a variable-length stream of binary data to be stored in or retrieved from a database. </summary>
	// Token: 0x020000AE RID: 174
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlBinary : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x0003BCBC File Offset: 0x00039EBC
		private SqlBinary(bool fNull)
		{
			this._value = null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure, setting the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property to the contents of the supplied byte array.</summary>
		/// <param name="value">The byte array to be stored or retrieved. </param>
		// Token: 0x06000A27 RID: 2599 RVA: 0x0003BCC5 File Offset: 0x00039EC5
		public SqlBinary(byte[] value)
		{
			if (value == null)
			{
				this._value = null;
				return;
			}
			this._value = new byte[value.Length];
			value.CopyTo(this._value, 0);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0003BCED File Offset: 0x00039EED
		internal SqlBinary(byte[] value, bool ignored)
		{
			this._value = value;
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure is null. This property is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if <see langword="null" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0003BCF6 File Offset: 0x00039EF6
		public bool IsNull
		{
			get
			{
				return this._value == null;
			}
		}

		/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. This property is read-only.</summary>
		/// <returns>The value of the <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property is read when the property contains <see cref="F:System.Data.SqlTypes.SqlBinary.Null" />. </exception>
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0003BD04 File Offset: 0x00039F04
		public byte[] Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				byte[] array = new byte[this._value.Length];
				this._value.CopyTo(array, 0);
				return array;
			}
		}

		/// <summary>Gets the single byte from the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property located at the position indicated by the integer parameter, <paramref name="index" />. If <paramref name="index" /> indicates a position beyond the end of the byte array, a <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> will be raised. This property is read-only.</summary>
		/// <param name="index">The position of the byte to be retrieved. </param>
		/// <returns>The byte located at the position indicated by the integer parameter.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The property is read when the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property contains <see cref="F:System.Data.SqlTypes.SqlBinary.Null" />- or - The <paramref name="index" /> parameter indicates a position byond the length of the byte array as indicated by the <see cref="P:System.Data.SqlTypes.SqlBinary.Length" /> property. </exception>
		// Token: 0x17000185 RID: 389
		public byte this[int index]
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this._value[index];
			}
		}

		/// <summary>Gets the length in bytes of the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property. This property is read-only.</summary>
		/// <returns>The length of the binary data in the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The <see cref="P:System.Data.SqlTypes.SqlBinary.Length" /> property is read when the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property contains <see cref="F:System.Data.SqlTypes.SqlBinary.Null" />. </exception>
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0003BD53 File Offset: 0x00039F53
		public int Length
		{
			get
			{
				if (!this.IsNull)
				{
					return this._value.Length;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Converts an array of bytes to a <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <param name="x">The array of bytes to be converted. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure that represents the converted array of bytes.</returns>
		// Token: 0x06000A2D RID: 2605 RVA: 0x0003BD6B File Offset: 0x00039F6B
		public static implicit operator SqlBinary(byte[] x)
		{
			return new SqlBinary(x);
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure to a <see cref="T:System.Byte" /> array.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure to be converted. </param>
		/// <returns>A <see cref="T:System.Byte" /> array.</returns>
		// Token: 0x06000A2E RID: 2606 RVA: 0x0003BD73 File Offset: 0x00039F73
		public static explicit operator byte[](SqlBinary x)
		{
			return x.Value;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBinary" /> object to a string.</summary>
		/// <returns>A string that contains the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBinary" />. If the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> is null the string will contain "null".</returns>
		// Token: 0x06000A2F RID: 2607 RVA: 0x0003BD7C File Offset: 0x00039F7C
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return "SqlBinary(" + this._value.Length.ToString(CultureInfo.InvariantCulture) + ")";
			}
			return SQLResource.NullString;
		}

		/// <summary>Concatenates the two <see cref="T:System.Data.SqlTypes.SqlBinary" /> parameters to create a new <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>The concatenated values of the <paramref name="x" /> and <paramref name="y" /> parameters.</returns>
		// Token: 0x06000A30 RID: 2608 RVA: 0x0003BDBC File Offset: 0x00039FBC
		public static SqlBinary operator +(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBinary.Null;
			}
			byte[] array = new byte[x.Value.Length + y.Value.Length];
			x.Value.CopyTo(array, 0);
			y.Value.CopyTo(array, x.Value.Length);
			return new SqlBinary(array);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0003BE24 File Offset: 0x0003A024
		private static EComparison PerformCompareByte(byte[] x, byte[] y)
		{
			int num = (x.Length < y.Length) ? x.Length : y.Length;
			int i = 0;
			while (i < num)
			{
				if (x[i] != y[i])
				{
					if (x[i] < y[i])
					{
						return EComparison.LT;
					}
					return EComparison.GT;
				}
				else
				{
					i++;
				}
			}
			if (x.Length == y.Length)
			{
				return EComparison.EQ;
			}
			byte b = 0;
			if (x.Length < y.Length)
			{
				for (i = num; i < y.Length; i++)
				{
					if (y[i] != b)
					{
						return EComparison.LT;
					}
				}
			}
			else
			{
				for (i = num; i < x.Length; i++)
				{
					if (x[i] != b)
					{
						return EComparison.GT;
					}
				}
			}
			return EComparison.EQ;
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to a <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to be converted. </param>
		/// <returns>The <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to be converted. </returns>
		// Token: 0x06000A32 RID: 2610 RVA: 0x0003BEA5 File Offset: 0x0003A0A5
		public static explicit operator SqlBinary(SqlGuid x)
		{
			if (!x.IsNull)
			{
				return new SqlBinary(x.ToByteArray());
			}
			return SqlBinary.Null;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A33 RID: 2611 RVA: 0x0003BEC2 File Offset: 0x0003A0C2
		public static SqlBoolean operator ==(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			return new SqlBoolean(SqlBinary.PerformCompareByte(x.Value, y.Value) == EComparison.EQ);
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A34 RID: 2612 RVA: 0x0003BEF7 File Offset: 0x0003A0F7
		public static SqlBoolean operator !=(SqlBinary x, SqlBinary y)
		{
			return !(x == y);
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A35 RID: 2613 RVA: 0x0003BF05 File Offset: 0x0003A105
		public static SqlBoolean operator <(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			return new SqlBoolean(SqlBinary.PerformCompareByte(x.Value, y.Value) == EComparison.LT);
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A36 RID: 2614 RVA: 0x0003BF3A File Offset: 0x0003A13A
		public static SqlBoolean operator >(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			return new SqlBoolean(SqlBinary.PerformCompareByte(x.Value, y.Value) == EComparison.GT);
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A37 RID: 2615 RVA: 0x0003BF70 File Offset: 0x0003A170
		public static SqlBoolean operator <=(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = SqlBinary.PerformCompareByte(x.Value, y.Value);
			return new SqlBoolean(ecomparison == EComparison.LT || ecomparison == EComparison.EQ);
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structues to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A38 RID: 2616 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
		public static SqlBoolean operator >=(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = SqlBinary.PerformCompareByte(x.Value, y.Value);
			return new SqlBoolean(ecomparison == EComparison.GT || ecomparison == EComparison.EQ);
		}

		/// <summary>Concatenates two specified <see cref="T:System.Data.SqlTypes.SqlBinary" /> values to create a new <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBinary" /> that is the concatenated value of x and y.</returns>
		// Token: 0x06000A39 RID: 2617 RVA: 0x0003C001 File Offset: 0x0003A201
		public static SqlBinary Add(SqlBinary x, SqlBinary y)
		{
			return x + y;
		}

		/// <summary>Concatenates two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to create a new <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>The concatenated values of the <paramref name="x" /> and <paramref name="y" /> parameters.</returns>
		// Token: 0x06000A3A RID: 2618 RVA: 0x0003C001 File Offset: 0x0003A201
		public static SqlBinary Concat(SqlBinary x, SqlBinary y)
		{
			return x + y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlBinary" /> will be null.</returns>
		// Token: 0x06000A3B RID: 2619 RVA: 0x0003C00A File Offset: 0x0003A20A
		public static SqlBoolean Equals(SqlBinary x, SqlBinary y)
		{
			return x == y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A3C RID: 2620 RVA: 0x0003C013 File Offset: 0x0003A213
		public static SqlBoolean NotEquals(SqlBinary x, SqlBinary y)
		{
			return x != y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A3D RID: 2621 RVA: 0x0003C01C File Offset: 0x0003A21C
		public static SqlBoolean LessThan(SqlBinary x, SqlBinary y)
		{
			return x < y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A3E RID: 2622 RVA: 0x0003C025 File Offset: 0x0003A225
		public static SqlBoolean GreaterThan(SqlBinary x, SqlBinary y)
		{
			return x > y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A3F RID: 2623 RVA: 0x0003C02E File Offset: 0x0003A22E
		public static SqlBoolean LessThanOrEqual(SqlBinary x, SqlBinary y)
		{
			return x <= y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBinary" /> structures to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A40 RID: 2624 RVA: 0x0003C037 File Offset: 0x0003A237
		public static SqlBoolean GreaterThanOrEqual(SqlBinary x, SqlBinary y)
		{
			return x >= y;
		}

		/// <summary>Converts this instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> to <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</returns>
		// Token: 0x06000A41 RID: 2625 RVA: 0x0003C040 File Offset: 0x0003A240
		public SqlGuid ToSqlGuid()
		{
			return (SqlGuid)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlBinary" /> object to the supplied object and returns an indication of their relative values.</summary>
		/// <param name="value">The object to be compared to this <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A signed number that indicates the relative values of this <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure and the object.Return value Condition Less than zero The value of this <see cref="T:System.Data.SqlTypes.SqlBinary" /> object is less than the object. Zero This <see cref="T:System.Data.SqlTypes.SqlBinary" /> object is the same as object. Greater than zero This <see cref="T:System.Data.SqlTypes.SqlBinary" /> object is greater than object.-or- The object is a null reference. </returns>
		// Token: 0x06000A42 RID: 2626 RVA: 0x0003C050 File Offset: 0x0003A250
		public int CompareTo(object value)
		{
			if (value is SqlBinary)
			{
				SqlBinary value2 = (SqlBinary)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlBinary));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlBinary" /> object to the supplied <see cref="T:System.Data.SqlTypes.SqlBinary" /> object and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlBinary" /> object to be compared to this <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure. </param>
		/// <returns>A signed number that indicates the relative values of this <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure and the object.Return value Condition Less than zero The value of this <see cref="T:System.Data.SqlTypes.SqlBinary" /> object is less than the object. Zero This <see cref="T:System.Data.SqlTypes.SqlBinary" /> object is the same as object. Greater than zero This <see cref="T:System.Data.SqlTypes.SqlBinary" /> object is greater than object.-or- The object is a null reference. </returns>
		// Token: 0x06000A43 RID: 2627 RVA: 0x0003C08C File Offset: 0x0003A28C
		public int CompareTo(SqlBinary value)
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

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlBinary" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlBinary" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000A44 RID: 2628 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		public override bool Equals(object value)
		{
			if (!(value is SqlBinary))
			{
				return false;
			}
			SqlBinary y = (SqlBinary)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0003C13C File Offset: 0x0003A33C
		internal static int HashByteArray(byte[] rgbValue, int length)
		{
			if (length <= 0)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				int num2 = num >> 28 & 255;
				num <<= 4;
				num = (num ^ (int)rgbValue[i] ^ num2);
			}
			return num;
		}

		/// <summary>Returns the hash code for this <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000A46 RID: 2630 RVA: 0x0003C178 File Offset: 0x0003A378
		public override int GetHashCode()
		{
			if (this.IsNull)
			{
				return 0;
			}
			int num = this._value.Length;
			while (num > 0 && this._value[num - 1] == 0)
			{
				num--;
			}
			return SqlBinary.HashByteArray(this._value, num);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XMLSchema" /> instance.</returns>
		// Token: 0x06000A47 RID: 2631 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
		/// <param name="reader">A <see cref="T:System.Xml.XmlReader" />.</param>
		// Token: 0x06000A48 RID: 2632 RVA: 0x0003C1BC File Offset: 0x0003A3BC
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._value = null;
				return;
			}
			string text = reader.ReadElementString();
			if (text == null)
			{
				this._value = Array.Empty<byte>();
				return;
			}
			text = text.Trim();
			if (text.Length == 0)
			{
				this._value = Array.Empty<byte>();
				return;
			}
			this._value = Convert.FromBase64String(text);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
		/// <param name="writer">A <see cref="T:System.Xml.XmlWriter" />.</param>
		// Token: 0x06000A49 RID: 2633 RVA: 0x0003C231 File Offset: 0x0003A431
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(Convert.ToBase64String(this._value));
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />. </summary>
		/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000A4A RID: 2634 RVA: 0x0003C267 File Offset: 0x0003A467
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("base64Binary", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000382 RID: 898
		private byte[] _value;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		// Token: 0x04000383 RID: 899
		public static readonly SqlBinary Null = new SqlBinary(true);
	}
}
