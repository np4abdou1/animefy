using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents an integer value that is either 1 or 0 to be stored in or retrieved from a database.</summary>
	// Token: 0x020000AF RID: 175
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlBoolean : INullable, IComparable, IXmlSerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure using the supplied Boolean value.</summary>
		/// <param name="value">The value for the new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure; either <see langword="true" /> or <see langword="false" />. </param>
		// Token: 0x06000A4C RID: 2636 RVA: 0x0003C285 File Offset: 0x0003A485
		public SqlBoolean(bool value)
		{
			this.m_value = (value ? 2 : 1);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure using the specified integer value.</summary>
		/// <param name="value">The integer whose value is to be used for the new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		// Token: 0x06000A4D RID: 2637 RVA: 0x0003C294 File Offset: 0x0003A494
		public SqlBoolean(int value)
		{
			this = new SqlBoolean(value, false);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0003C29E File Offset: 0x0003A49E
		private SqlBoolean(int value, bool fNull)
		{
			if (fNull)
			{
				this.m_value = 0;
				return;
			}
			this.m_value = ((value != 0) ? 2 : 1);
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure is null; otherwise <see langword="false" />.</returns>
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0003C2B8 File Offset: 0x0003A4B8
		public bool IsNull
		{
			get
			{
				return this.m_value == 0;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value. This property is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />; otherwise <see langword="false" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The property is set to null. </exception>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0003C2C4 File Offset: 0x0003A4C4
		public bool Value
		{
			get
			{
				byte value = this.m_value;
				if (value == 1)
				{
					return false;
				}
				if (value == 2)
				{
					return true;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Indicates whether the current <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />.</summary>
		/// <returns>
		///     <see langword="true" /> if <see langword="Value" /> is <see langword="True" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0003C2E9 File Offset: 0x0003A4E9
		public bool IsTrue
		{
			get
			{
				return this.m_value == 2;
			}
		}

		/// <summary>Indicates whether the current <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</summary>
		/// <returns>
		///     <see langword="true" /> if <see langword="Value" /> is <see langword="False" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		public bool IsFalse
		{
			get
			{
				return this.m_value == 1;
			}
		}

		/// <summary>Converts the supplied byte value to a <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">A byte value to be converted to <see cref="T:System.Data.SqlTypes.SqlBoolean" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> value that contains 0 or 1.</returns>
		// Token: 0x06000A53 RID: 2643 RVA: 0x0003C2FF File Offset: 0x0003A4FF
		public static implicit operator SqlBoolean(bool x)
		{
			return new SqlBoolean(x);
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to a Boolean.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to convert. </param>
		/// <returns>A Boolean set to the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06000A54 RID: 2644 RVA: 0x0003C307 File Offset: 0x0003A507
		public static explicit operator bool(SqlBoolean x)
		{
			return x.Value;
		}

		/// <summary>Performs a NOT operation on a <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> on which the NOT operation will be performed. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> with the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /><see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if argument was true, <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" /> if argument was null, and <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> otherwise.</returns>
		// Token: 0x06000A55 RID: 2645 RVA: 0x0003C310 File Offset: 0x0003A510
		public static SqlBoolean operator !(SqlBoolean x)
		{
			byte value = x.m_value;
			if (value == 1)
			{
				return SqlBoolean.True;
			}
			if (value == 2)
			{
				return SqlBoolean.False;
			}
			return SqlBoolean.Null;
		}

		/// <summary>The true operator can be used to test the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether it is true.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be tested. </param>
		/// <returns>Returns <see langword="true" /> if the supplied parameter is <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is true, <see langword="false" /> otherwise.</returns>
		// Token: 0x06000A56 RID: 2646 RVA: 0x0003C33D File Offset: 0x0003A53D
		public static bool operator true(SqlBoolean x)
		{
			return x.IsTrue;
		}

		/// <summary>The false operator can be used to test the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether it is false.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be tested. </param>
		/// <returns>Returns <see langword="true" /> if the supplied parameter is <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is false, <see langword="false" /> otherwise.</returns>
		// Token: 0x06000A57 RID: 2647 RVA: 0x0003C346 File Offset: 0x0003A546
		public static bool operator false(SqlBoolean x)
		{
			return x.IsFalse;
		}

		/// <summary>Computes the bitwise AND operation of two specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The result of the logical AND operation.</returns>
		// Token: 0x06000A58 RID: 2648 RVA: 0x0003C34F File Offset: 0x0003A54F
		public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y)
		{
			if (x.m_value == 1 || y.m_value == 1)
			{
				return SqlBoolean.False;
			}
			if (x.m_value == 2 && y.m_value == 2)
			{
				return SqlBoolean.True;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Computes the bitwise OR of its operands.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The results of the logical OR operation.</returns>
		// Token: 0x06000A59 RID: 2649 RVA: 0x0003C386 File Offset: 0x0003A586
		public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y)
		{
			if (x.m_value == 2 || y.m_value == 2)
			{
				return SqlBoolean.True;
			}
			if (x.m_value == 1 && y.m_value == 1)
			{
				return SqlBoolean.False;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure as a byte.</summary>
		/// <returns>A byte representing the value of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</returns>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0003C3BD File Offset: 0x0003A5BD
		public byte ByteValue
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				if (this.m_value != 2)
				{
					return 0;
				}
				return 1;
			}
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to a string.</summary>
		/// <returns>A string that contains the value of the <see cref="T:System.Data.SqlTypes.SqlBoolean" />. If the value is null, the string will contain "null".</returns>
		// Token: 0x06000A5B RID: 2651 RVA: 0x0003C3DC File Offset: 0x0003A5DC
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.Value.ToString();
			}
			return SQLResource.NullString;
		}

		/// <summary>Converts the specified <see cref="T:System.String" /> representation of a logical value to its <see cref="T:System.Data.SqlTypes.SqlBoolean" /> equivalent.</summary>
		/// <param name="s">The <see cref="T:System.String" /> to be converted. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure that contains the parsed value.</returns>
		// Token: 0x06000A5C RID: 2652 RVA: 0x0003C408 File Offset: 0x0003A608
		public static SqlBoolean Parse(string s)
		{
			if (s == null)
			{
				return new SqlBoolean(bool.Parse(s));
			}
			if (s == SQLResource.NullString)
			{
				return SqlBoolean.Null;
			}
			s = s.TrimStart();
			char c = s[0];
			if (char.IsNumber(c) || '-' == c || '+' == c)
			{
				return new SqlBoolean(int.Parse(s, null));
			}
			return new SqlBoolean(bool.Parse(s));
		}

		/// <summary>Performs a one's complement operation on the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The one's complement of the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06000A5D RID: 2653 RVA: 0x0003C471 File Offset: 0x0003A671
		public static SqlBoolean operator ~(SqlBoolean x)
		{
			return !x;
		}

		/// <summary>Performs a bitwise exclusive-OR (XOR) operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The result of the logical XOR operation.</returns>
		// Token: 0x06000A5E RID: 2654 RVA: 0x0003C479 File Offset: 0x0003A679
		public static SqlBoolean operator ^(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value != y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000A5F RID: 2655 RVA: 0x0003C4A9 File Offset: 0x0003A6A9
		public static explicit operator SqlBoolean(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value > 0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000A60 RID: 2656 RVA: 0x0003C4C9 File Offset: 0x0003A6C9
		public static explicit operator SqlBoolean(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000A61 RID: 2657 RVA: 0x0003C4E9 File Offset: 0x0003A6E9
		public static explicit operator SqlBoolean(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000A62 RID: 2658 RVA: 0x0003C509 File Offset: 0x0003A709
		public static explicit operator SqlBoolean(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0L);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000A63 RID: 2659 RVA: 0x0003C52A File Offset: 0x0003A72A
		public static explicit operator SqlBoolean(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0.0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000A64 RID: 2660 RVA: 0x0003C555 File Offset: 0x0003A755
		public static explicit operator SqlBoolean(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean((double)x.Value != 0.0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000A65 RID: 2661 RVA: 0x0003C581 File Offset: 0x0003A781
		public static explicit operator SqlBoolean(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return x != SqlMoney.Zero;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
		// Token: 0x06000A66 RID: 2662 RVA: 0x0003C59D File Offset: 0x0003A79D
		public static explicit operator SqlBoolean(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x._data1 != 0U || x._data2 != 0U || x._data3 != 0U || x._data4 > 0U);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" /> to be converted to a <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000A67 RID: 2663 RVA: 0x0003C5D7 File Offset: 0x0003A7D7
		public static explicit operator SqlBoolean(SqlString x)
		{
			if (!x.IsNull)
			{
				return SqlBoolean.Parse(x.Value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> for equality.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A68 RID: 2664 RVA: 0x0003C5F4 File Offset: 0x0003A7F4
		public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A69 RID: 2665 RVA: 0x0003C621 File Offset: 0x0003A821
		public static SqlBoolean operator !=(SqlBoolean x, SqlBoolean y)
		{
			return !(x == y);
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is less than the second instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A6A RID: 2666 RVA: 0x0003C62F File Offset: 0x0003A82F
		public static SqlBoolean operator <(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> object. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> object. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is greater than the second instance; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000A6B RID: 2667 RVA: 0x0003C65C File Offset: 0x0003A85C
		public static SqlBoolean operator >(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is less than or equal to the second instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A6C RID: 2668 RVA: 0x0003C689 File Offset: 0x0003A889
		public static SqlBoolean operator <=(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is greater than or equal to the second instance; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000A6D RID: 2669 RVA: 0x0003C6B9 File Offset: 0x0003A8B9
		public static SqlBoolean operator >=(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a one's complement operation on the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The one's complement of the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06000A6E RID: 2670 RVA: 0x0003C6E9 File Offset: 0x0003A8E9
		public static SqlBoolean OnesComplement(SqlBoolean x)
		{
			return ~x;
		}

		/// <summary>Computes the bitwise AND operation of two specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The result of the logical AND operation.</returns>
		// Token: 0x06000A6F RID: 2671 RVA: 0x0003C6F1 File Offset: 0x0003A8F1
		public static SqlBoolean And(SqlBoolean x, SqlBoolean y)
		{
			return x & y;
		}

		/// <summary>Performs a bitwise OR operation on the two specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose Value is the result of the bitwise OR operation.</returns>
		// Token: 0x06000A70 RID: 2672 RVA: 0x0003C6FA File Offset: 0x0003A8FA
		public static SqlBoolean Or(SqlBoolean x, SqlBoolean y)
		{
			return x | y;
		}

		/// <summary>Performs a bitwise exclusive-OR operation on the supplied parameters.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>The result of the logical XOR operation.</returns>
		// Token: 0x06000A71 RID: 2673 RVA: 0x0003C703 File Offset: 0x0003A903
		public static SqlBoolean Xor(SqlBoolean x, SqlBoolean y)
		{
			return x ^ y;
		}

		/// <summary>Compares two <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A72 RID: 2674 RVA: 0x0003C70C File Offset: 0x0003A90C
		public static SqlBoolean Equals(SqlBoolean x, SqlBoolean y)
		{
			return x == y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> for equality.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000A73 RID: 2675 RVA: 0x0003C715 File Offset: 0x0003A915
		public static SqlBoolean NotEquals(SqlBoolean x, SqlBoolean y)
		{
			return x != y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is greater than the second instance; otherwise <see langword="false" />. </returns>
		// Token: 0x06000A74 RID: 2676 RVA: 0x0003C71E File Offset: 0x0003A91E
		public static SqlBoolean GreaterThan(SqlBoolean x, SqlBoolean y)
		{
			return x > y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is less than the second instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A75 RID: 2677 RVA: 0x0003C727 File Offset: 0x0003A927
		public static SqlBoolean LessThan(SqlBoolean x, SqlBoolean y)
		{
			return x < y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is greater than or equal to the second instance; otherwise <see langword="false" />.</returns>
		// Token: 0x06000A76 RID: 2678 RVA: 0x0003C730 File Offset: 0x0003A930
		public static SqlBoolean GreaterThanOrEquals(SqlBoolean x, SqlBoolean y)
		{
			return x >= y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see langword="true" /> if the first instance is less than or equal to the second instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A77 RID: 2679 RVA: 0x0003C739 File Offset: 0x0003A939
		public static SqlBoolean LessThanOrEquals(SqlBoolean x, SqlBoolean y)
		{
			return x <= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" />, the new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's value is 1. Otherwise, the new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure's value is 0.</returns>
		// Token: 0x06000A78 RID: 2680 RVA: 0x0003C742 File Offset: 0x0003A942
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" /> then the new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's value is 1. Otherwise, the new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's value is 0.</returns>
		// Token: 0x06000A79 RID: 2681 RVA: 0x0003C74F File Offset: 0x0003A94F
		public SqlDouble ToSqlDouble()
		{
			return (SqlDouble)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>A new <see langword="SqlInt16" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" /> then the new <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure's value is 1. Otherwise, the new <see langword="SqlInt16" /> structure's value is 0.</returns>
		// Token: 0x06000A7A RID: 2682 RVA: 0x0003C75C File Offset: 0x0003A95C
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A new <see langword="SqlInt32" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" />, the new <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure's value is 1. Otherwise, the new <see langword="SqlInt32" /> structure's value is 0.</returns>
		// Token: 0x06000A7B RID: 2683 RVA: 0x0003C769 File Offset: 0x0003A969
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A new <see langword="SqlInt64" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" />, the new <see cref="T:System.Data.SqlTypes.SqlInt64" />  structure's value is 1. Otherwise, the new <see langword="SqlInt64" /> structure's value is 0.</returns>
		// Token: 0x06000A7C RID: 2684 RVA: 0x0003C776 File Offset: 0x0003A976
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" />, the new <see cref="T:System.Data.SqlTypes.SqlMoney" /> value is 1. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="false" />, the new <see cref="T:System.Data.SqlTypes.SqlMoney" /> value is 0. If <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value is neither 1 nor 0, the new <see cref="T:System.Data.SqlTypes.SqlMoney" /> value is <see cref="F:System.Data.SqlTypes.SqlMoney.Null" />.</returns>
		// Token: 0x06000A7D RID: 2685 RVA: 0x0003C783 File Offset: 0x0003A983
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" /> then the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's value is 1. Otherwise, the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's value is 0.</returns>
		// Token: 0x06000A7E RID: 2686 RVA: 0x0003C790 File Offset: 0x0003A990
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose value is 1 or 0.If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals true, the new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure's value is 1; otherwise the new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure's value is 0.</returns>
		// Token: 0x06000A7F RID: 2687 RVA: 0x0003C79D File Offset: 0x0003A99D
		public SqlSingle ToSqlSingle()
		{
			return (SqlSingle)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> structure whose value is 1 or 0. If the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value equals <see langword="true" /> then <see cref="T:System.Data.SqlTypes.SqlString" /> structure's value is 1. Otherwise, the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure's value is 0.</returns>
		// Token: 0x06000A80 RID: 2688 RVA: 0x0003C7AA File Offset: 0x0003A9AA
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to a specified object and returns an indication of their relative values.</summary>
		/// <param name="value">An object to compare, or a null reference (<see langword="Nothing" /> in Visual Basic). </param>
		/// <returns>A signed number that indicates the relative values of the instance and value.Value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />.-or- 
		///             <paramref name="value" /> is a null reference (<see langword="Nothing" /> in Visual Basic). </returns>
		// Token: 0x06000A81 RID: 2689 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		public int CompareTo(object value)
		{
			if (value is SqlBoolean)
			{
				SqlBoolean value2 = (SqlBoolean)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlBoolean));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> object to the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> object and returns an indication of their relative values.</summary>
		/// <param name="value">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /><see cref="T:System.Data.SqlTypes.SqlBoolean" /> object to compare, or a null reference (<see langword="Nothing" /> in Visual Basic).  </param>
		/// <returns>A signed number that indicates the relative values of the instance and value.Value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />.-or- 
		///             <paramref name="value" /> is a null reference (<see langword="Nothing" /> in Visual Basic). </returns>
		// Token: 0x06000A82 RID: 2690 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		public int CompareTo(SqlBoolean value)
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
				if (this.ByteValue < value.ByteValue)
				{
					return -1;
				}
				if (this.ByteValue > value.ByteValue)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Compares the supplied object parameter to the <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> and the two are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A83 RID: 2691 RVA: 0x0003C844 File Offset: 0x0003AA44
		public override bool Equals(object value)
		{
			if (!(value is SqlBoolean))
			{
				return false;
			}
			SqlBoolean y = (SqlBoolean)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000A84 RID: 2692 RVA: 0x0003C89C File Offset: 0x0003AA9C
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
		// Token: 0x06000A85 RID: 2693 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000A86 RID: 2694 RVA: 0x0003C8C4 File Offset: 0x0003AAC4
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_value = 0;
				return;
			}
			this.m_value = (XmlConvert.ToBoolean(reader.ReadElementString()) ? 2 : 1);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter " />
		///     </param>
		// Token: 0x06000A87 RID: 2695 RVA: 0x0003C913 File Offset: 0x0003AB13
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString((this.m_value == 2) ? "true" : "false");
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000A88 RID: 2696 RVA: 0x0003C953 File Offset: 0x0003AB53
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("boolean", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000384 RID: 900
		private byte m_value;

		// Token: 0x04000385 RID: 901
		private const byte x_Null = 0;

		// Token: 0x04000386 RID: 902
		private const byte x_False = 1;

		// Token: 0x04000387 RID: 903
		private const byte x_True = 2;

		/// <summary>Represents a true value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		// Token: 0x04000388 RID: 904
		public static readonly SqlBoolean True = new SqlBoolean(true);

		/// <summary>Represents a false value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		// Token: 0x04000389 RID: 905
		public static readonly SqlBoolean False = new SqlBoolean(false);

		/// <summary>Represents <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		// Token: 0x0400038A RID: 906
		public static readonly SqlBoolean Null = new SqlBoolean(0, true);

		/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		// Token: 0x0400038B RID: 907
		public static readonly SqlBoolean Zero = new SqlBoolean(0);

		/// <summary>Represents a one value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
		// Token: 0x0400038C RID: 908
		public static readonly SqlBoolean One = new SqlBoolean(1);
	}
}
