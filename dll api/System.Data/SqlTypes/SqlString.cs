using System;
using System.Data.Common;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a variable-length stream of characters to be stored in or retrieved from the database. <see cref="T:System.Data.SqlTypes.SqlString" /> has a different underlying data structure from its corresponding .NET Framework <see cref="T:System.String" /> data type.</summary>
	// Token: 0x020000C0 RID: 192
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlString : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000D70 RID: 3440 RVA: 0x0004572D File Offset: 0x0004392D
		private SqlString(bool fNull)
		{
			this.m_value = null;
			this.m_cmpInfo = null;
			this.m_lcid = 0;
			this.m_flag = SqlCompareOptions.None;
			this.m_fNotNull = false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> class.</summary>
		/// <param name="lcid">Specifies the geographical locale and language for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="compareOptions">Specifies the compare options for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="data">The data array to store. </param>
		/// <param name="index">The starting index within the array. </param>
		/// <param name="count">The number of characters from index to copy. </param>
		/// <param name="fUnicode">
		///       <see langword="true" /> if Unicode encoded. Otherwise, <see langword="false" />. </param>
		// Token: 0x06000D71 RID: 3441 RVA: 0x00045754 File Offset: 0x00043954
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count, bool fUnicode)
		{
			this.m_lcid = lcid;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			this.m_flag = compareOptions;
			if (data == null)
			{
				this.m_fNotNull = false;
				this.m_value = null;
				this.m_cmpInfo = null;
				return;
			}
			this.m_fNotNull = true;
			this.m_cmpInfo = null;
			if (fUnicode)
			{
				this.m_value = SqlString.s_unicodeEncoding.GetString(data, index, count);
				return;
			}
			Encoding encoding = Encoding.GetEncoding(new CultureInfo(this.m_lcid).TextInfo.ANSICodePage);
			this.m_value = encoding.GetString(data, index, count);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> class.</summary>
		/// <param name="lcid">Specifies the geographical locale and language for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="compareOptions">Specifies the compare options for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="data">The data array to store. </param>
		/// <param name="fUnicode">
		///       <see langword="true" /> if Unicode encoded. Otherwise, <see langword="false" />. </param>
		// Token: 0x06000D72 RID: 3442 RVA: 0x000457E2 File Offset: 0x000439E2
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, bool fUnicode)
		{
			this = new SqlString(lcid, compareOptions, data, 0, data.Length, fUnicode);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> class.</summary>
		/// <param name="lcid">Specifies the geographical locale and language for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="compareOptions">Specifies the compare options for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="data">The data array to store. </param>
		/// <param name="index">The starting index within the array. </param>
		/// <param name="count">The number of characters from index to copy. </param>
		// Token: 0x06000D73 RID: 3443 RVA: 0x000457F3 File Offset: 0x000439F3
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count)
		{
			this = new SqlString(lcid, compareOptions, data, index, count, true);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> structure using the specified locale id, compare options, and data.</summary>
		/// <param name="lcid">Specifies the geographical locale and language for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="compareOptions">Specifies the compare options for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="data">The data array to store. </param>
		// Token: 0x06000D74 RID: 3444 RVA: 0x00045803 File Offset: 0x00043A03
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data)
		{
			this = new SqlString(lcid, compareOptions, data, 0, data.Length, true);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> structure using the specified string, locale id, and compare option values.</summary>
		/// <param name="data">The string to store. </param>
		/// <param name="lcid">Specifies the geographical locale and language for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <param name="compareOptions">Specifies the compare options for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		// Token: 0x06000D75 RID: 3445 RVA: 0x00045813 File Offset: 0x00043A13
		public SqlString(string data, int lcid, SqlCompareOptions compareOptions)
		{
			this.m_lcid = lcid;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			this.m_flag = compareOptions;
			this.m_cmpInfo = null;
			if (data == null)
			{
				this.m_fNotNull = false;
				this.m_value = null;
				return;
			}
			this.m_fNotNull = true;
			this.m_value = data;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> structure using the specified string and locale id values.</summary>
		/// <param name="data">The string to store. </param>
		/// <param name="lcid">Specifies the geographical locale and language for the new <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		// Token: 0x06000D76 RID: 3446 RVA: 0x00045850 File Offset: 0x00043A50
		public SqlString(string data, int lcid)
		{
			this = new SqlString(data, lcid, SqlString.s_iDefaultFlag);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> structure using the specified string.</summary>
		/// <param name="data">The string to store. </param>
		// Token: 0x06000D77 RID: 3447 RVA: 0x0004585F File Offset: 0x00043A5F
		public SqlString(string data)
		{
			this = new SqlString(data, CultureInfo.CurrentCulture.LCID, SqlString.s_iDefaultFlag);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00045878 File Offset: 0x00043A78
		private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo)
		{
			this.m_lcid = lcid;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			this.m_flag = compareOptions;
			if (data == null)
			{
				this.m_fNotNull = false;
				this.m_value = null;
				this.m_cmpInfo = null;
				return;
			}
			this.m_value = data;
			this.m_cmpInfo = cmpInfo;
			this.m_fNotNull = true;
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlString" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="P:System.Data.SqlTypes.SqlString.Value" /> is <see cref="F:System.Data.SqlTypes.SqlString.Null" />. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000458C8 File Offset: 0x00043AC8
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Gets the string that is stored in this <see cref="T:System.Data.SqlTypes.SqlString" /> structure. This property is read-only.</summary>
		/// <returns>The string that is stored.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The value of the string is <see cref="F:System.Data.SqlTypes.SqlString.Null" />. </exception>
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000458D3 File Offset: 0x00043AD3
		public string Value
		{
			get
			{
				if (!this.IsNull)
				{
					return this.m_value;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Specifies the geographical locale and language for the <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</summary>
		/// <returns>The locale id for the string stored in the <see cref="P:System.Data.SqlTypes.SqlString.Value" /> property.</returns>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000458E9 File Offset: 0x00043AE9
		public int LCID
		{
			get
			{
				if (!this.IsNull)
				{
					return this.m_lcid;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> structure that represents information about the culture of this <see cref="T:System.Data.SqlTypes.SqlString" /> object.</summary>
		/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> structure that describes information about the culture of this SqlString structure including the names of the culture, the writing system, and the calendar used, and also access to culture-specific objects that provide methods for common operations, such as formatting dates and sorting strings.</returns>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x000458FF File Offset: 0x00043AFF
		public CultureInfo CultureInfo
		{
			get
			{
				if (!this.IsNull)
				{
					return CultureInfo.GetCultureInfo(this.m_lcid);
				}
				throw new SqlNullValueException();
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0004591A File Offset: 0x00043B1A
		private void SetCompareInfo()
		{
			if (this.m_cmpInfo == null)
			{
				this.m_cmpInfo = CultureInfo.GetCultureInfo(this.m_lcid).CompareInfo;
			}
		}

		/// <summary>Gets the <see cref="T:System.Globalization.CompareInfo" /> object that defines how string comparisons should be performed for this <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</summary>
		/// <returns>A <see langword="CompareInfo" /> object that defines string comparison for this <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</returns>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0004593A File Offset: 0x00043B3A
		public CompareInfo CompareInfo
		{
			get
			{
				if (!this.IsNull)
				{
					this.SetCompareInfo();
					return this.m_cmpInfo;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>A combination of one or more of the <see cref="T:System.Data.SqlTypes.SqlCompareOptions" /> enumeration values that represent the way in which this <see cref="T:System.Data.SqlTypes.SqlString" /> should be compared to other <see cref="T:System.Data.SqlTypes.SqlString" /> structures.</summary>
		/// <returns>A value specifying how this <see cref="T:System.Data.SqlTypes.SqlString" /> should be compared to other <see cref="T:System.Data.SqlTypes.SqlString" /> structures.</returns>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00045956 File Offset: 0x00043B56
		public SqlCompareOptions SqlCompareOptions
		{
			get
			{
				if (!this.IsNull)
				{
					return this.m_flag;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Converts the <see cref="T:System.String" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.String" /> to be converted. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the value of the specified <see langword="String" />.</returns>
		// Token: 0x06000D80 RID: 3456 RVA: 0x0004596C File Offset: 0x00043B6C
		public static implicit operator SqlString(string x)
		{
			return new SqlString(x);
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlString" /> to a <see cref="T:System.String" /></summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlString" /> to be converted. </param>
		/// <returns>A <see langword="String" />, whose contents are the same as the <see cref="P:System.Data.SqlTypes.SqlString.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter.</returns>
		// Token: 0x06000D81 RID: 3457 RVA: 0x00045974 File Offset: 0x00043B74
		public static explicit operator string(SqlString x)
		{
			return x.Value;
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlString" /> object to a <see cref="T:System.String" />.</summary>
		/// <returns>A <see cref="T:System.String" /> with the same value as this <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</returns>
		// Token: 0x06000D82 RID: 3458 RVA: 0x0004597D File Offset: 0x00043B7D
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value;
			}
			return SQLResource.NullString;
		}

		/// <summary>Gets an array of bytes, that contains the contents of the <see cref="T:System.Data.SqlTypes.SqlString" /> in Unicode format.</summary>
		/// <returns>An byte array, that contains the contents of the <see cref="T:System.Data.SqlTypes.SqlString" /> in Unicode format.</returns>
		// Token: 0x06000D83 RID: 3459 RVA: 0x00045993 File Offset: 0x00043B93
		public byte[] GetUnicodeBytes()
		{
			if (this.IsNull)
			{
				return null;
			}
			return SqlString.s_unicodeEncoding.GetBytes(this.m_value);
		}

		/// <summary>Gets an array of bytes, that contains the contents of the <see cref="T:System.Data.SqlTypes.SqlString" /> in ANSI format.</summary>
		/// <returns>An byte array, that contains the contents of the <see cref="T:System.Data.SqlTypes.SqlString" /> in ANSI format.</returns>
		// Token: 0x06000D84 RID: 3460 RVA: 0x000459AF File Offset: 0x00043BAF
		public byte[] GetNonUnicodeBytes()
		{
			if (this.IsNull)
			{
				return null;
			}
			return Encoding.GetEncoding(new CultureInfo(this.m_lcid).TextInfo.ANSICodePage).GetBytes(this.m_value);
		}

		/// <summary>Concatenates the two specified <see cref="T:System.Data.SqlTypes.SqlString" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the newly concatenated value representing the contents of the two <see cref="T:System.Data.SqlTypes.SqlString" /> parameters.</returns>
		// Token: 0x06000D85 RID: 3461 RVA: 0x000459E0 File Offset: 0x00043BE0
		public static SqlString operator +(SqlString x, SqlString y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlString.Null;
			}
			if (x.m_lcid != y.m_lcid || x.m_flag != y.m_flag)
			{
				throw new SqlTypeException(SQLResource.ConcatDiffCollationMessage);
			}
			return new SqlString(x.m_lcid, x.m_flag, x.m_value + y.m_value, (x.m_cmpInfo == null) ? y.m_cmpInfo : x.m_cmpInfo);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00045A64 File Offset: 0x00043C64
		private static int StringCompare(SqlString x, SqlString y)
		{
			if (x.m_lcid != y.m_lcid || x.m_flag != y.m_flag)
			{
				throw new SqlTypeException(SQLResource.CompareDiffCollationMessage);
			}
			x.SetCompareInfo();
			y.SetCompareInfo();
			int result;
			if ((x.m_flag & SqlCompareOptions.BinarySort) != SqlCompareOptions.None)
			{
				result = SqlString.CompareBinary(x, y);
			}
			else if ((x.m_flag & SqlCompareOptions.BinarySort2) != SqlCompareOptions.None)
			{
				result = SqlString.CompareBinary2(x, y);
			}
			else
			{
				string value = x.m_value;
				string value2 = y.m_value;
				int i = value.Length;
				int num = value2.Length;
				while (i > 0)
				{
					if (value[i - 1] != ' ')
					{
						break;
					}
					i--;
				}
				while (num > 0 && value2[num - 1] == ' ')
				{
					num--;
				}
				CompareOptions options = SqlString.CompareOptionsFromSqlCompareOptions(x.m_flag);
				result = x.m_cmpInfo.Compare(x.m_value, 0, i, y.m_value, 0, num, options);
			}
			return result;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00045B58 File Offset: 0x00043D58
		private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			int num = SqlString.StringCompare(x, y);
			bool value;
			switch (ecExpectedResult)
			{
			case EComparison.LT:
				value = (num < 0);
				break;
			case EComparison.LE:
				value = (num <= 0);
				break;
			case EComparison.EQ:
				value = (num == 0);
				break;
			case EComparison.GE:
				value = (num >= 0);
				break;
			case EComparison.GT:
				value = (num > 0);
				break;
			default:
				return SqlBoolean.Null;
			}
			return new SqlBoolean(value);
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> parameter.</returns>
		// Token: 0x06000D88 RID: 3464 RVA: 0x00045BD8 File Offset: 0x00043DD8
		public static explicit operator SqlString(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> object that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
		// Token: 0x06000D89 RID: 3465 RVA: 0x00045C08 File Offset: 0x00043E08
		public static explicit operator SqlString(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> object that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
		// Token: 0x06000D8A RID: 3466 RVA: 0x00045C3C File Offset: 0x00043E3C
		public static explicit operator SqlString(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The SqlInt32 structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> object that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
		// Token: 0x06000D8B RID: 3467 RVA: 0x00045C70 File Offset: 0x00043E70
		public static explicit operator SqlString(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> object that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
		// Token: 0x06000D8C RID: 3468 RVA: 0x00045CA4 File Offset: 0x00043EA4
		public static explicit operator SqlString(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter.</returns>
		// Token: 0x06000D8D RID: 3469 RVA: 0x00045CD8 File Offset: 0x00043ED8
		public static explicit operator SqlString(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
		// Token: 0x06000D8E RID: 3470 RVA: 0x00045D0C File Offset: 0x00043F0C
		public static explicit operator SqlString(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see langword="SqlDecimal" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the string representation of the <see langword="SqlDecimal" /> parameter.</returns>
		// Token: 0x06000D8F RID: 3471 RVA: 0x00045D3D File Offset: 0x00043F3D
		public static explicit operator SqlString(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
		// Token: 0x06000D90 RID: 3472 RVA: 0x00045D60 File Offset: 0x00043F60
		public static explicit operator SqlString(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlDateTime" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to be converted. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> parameter.</returns>
		// Token: 0x06000D91 RID: 3473 RVA: 0x00045D83 File Offset: 0x00043F83
		public static explicit operator SqlString(SqlDateTime x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Converts the specified <see cref="T:System.Data.SqlTypes.SqlGuid" /> parameter to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to be converted. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> whose value is the string representation of the specified <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x06000D92 RID: 3474 RVA: 0x00045DA6 File Offset: 0x00043FA6
		public static explicit operator SqlString(SqlGuid x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Creates a copy of this <see cref="T:System.Data.SqlTypes.SqlString" /> object.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlString" /> object in which all property values are the same as the original.</returns>
		// Token: 0x06000D93 RID: 3475 RVA: 0x00045DC9 File Offset: 0x00043FC9
		public SqlString Clone()
		{
			if (this.IsNull)
			{
				return new SqlString(true);
			}
			return new SqlString(this.m_value, this.m_lcid, this.m_flag);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D94 RID: 3476 RVA: 0x00045DF1 File Offset: 0x00043FF1
		public static SqlBoolean operator ==(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.EQ);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D95 RID: 3477 RVA: 0x00045DFB File Offset: 0x00043FFB
		public static SqlBoolean operator !=(SqlString x, SqlString y)
		{
			return !(x == y);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D96 RID: 3478 RVA: 0x00045E09 File Offset: 0x00044009
		public static SqlBoolean operator <(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.LT);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D97 RID: 3479 RVA: 0x00045E13 File Offset: 0x00044013
		public static SqlBoolean operator >(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.GT);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D98 RID: 3480 RVA: 0x00045E1D File Offset: 0x0004401D
		public static SqlBoolean operator <=(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.LE);
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D99 RID: 3481 RVA: 0x00045E27 File Offset: 0x00044027
		public static SqlBoolean operator >=(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.GE);
		}

		/// <summary>Concatenates the two specified <see cref="T:System.Data.SqlTypes.SqlString" /> structures.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> that contains the newly concatenated value representing the contents of the two <see cref="T:System.Data.SqlTypes.SqlString" /> parameters.</returns>
		// Token: 0x06000D9A RID: 3482 RVA: 0x00045E31 File Offset: 0x00044031
		public static SqlString Concat(SqlString x, SqlString y)
		{
			return x + y;
		}

		/// <summary>Concatenates two specified <see cref="T:System.Data.SqlTypes.SqlString" /> values to create a new <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> that is the concatenated value of <paramref name="x" /> and <paramref name="y" />.</returns>
		// Token: 0x06000D9B RID: 3483 RVA: 0x00045E31 File Offset: 0x00044031
		public static SqlString Add(SqlString x, SqlString y)
		{
			return x + y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />. If either instance is null, then the <see langword="SqlString" /> will be null.</returns>
		// Token: 0x06000D9C RID: 3484 RVA: 0x00045E3A File Offset: 0x0004403A
		public static SqlBoolean Equals(SqlString x, SqlString y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D9D RID: 3485 RVA: 0x00045E43 File Offset: 0x00044043
		public static SqlBoolean NotEquals(SqlString x, SqlString y)
		{
			return x != y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D9E RID: 3486 RVA: 0x00045E4C File Offset: 0x0004404C
		public static SqlBoolean LessThan(SqlString x, SqlString y)
		{
			return x < y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000D9F RID: 3487 RVA: 0x00045E55 File Offset: 0x00044055
		public static SqlBoolean GreaterThan(SqlString x, SqlString y)
		{
			return x > y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000DA0 RID: 3488 RVA: 0x00045E5E File Offset: 0x0004405E
		public static SqlBoolean LessThanOrEqual(SqlString x, SqlString y)
		{
			return x <= y;
		}

		/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlString" /> operands to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlString" />. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000DA1 RID: 3489 RVA: 0x00045E67 File Offset: 0x00044067
		public static SqlBoolean GreaterThanOrEqual(SqlString x, SqlString y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlString.Value" /> is non-zero; <see langword="false" /> if zero; otherwise Null.</returns>
		// Token: 0x06000DA2 RID: 3490 RVA: 0x00045E70 File Offset: 0x00044070
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>A new <see langword="SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> equals the number represented by this <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</returns>
		// Token: 0x06000DA3 RID: 3491 RVA: 0x00045E7D File Offset: 0x0004407D
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <returns>A new <see langword="SqlDateTime" /> structure that contains the date value represented by this <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06000DA4 RID: 3492 RVA: 0x00045E8A File Offset: 0x0004408A
		public SqlDateTime ToSqlDateTime()
		{
			return (SqlDateTime)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> that is equal to the numeric value of this <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06000DA5 RID: 3493 RVA: 0x00045E97 File Offset: 0x00044097
		public SqlDouble ToSqlDouble()
		{
			return (SqlDouble)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt16" />. </summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt16" /> that is equal to the numeric value of this <see cref="T:System.Data.SqlTypes.SqlString" />. </returns>
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00045EA4 File Offset: 0x000440A4
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt32" /> that is equal to the numeric value of this <see cref="T:System.Data.SqlTypes.SqlString" />. </returns>
		// Token: 0x06000DA7 RID: 3495 RVA: 0x00045EB1 File Offset: 0x000440B1
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlInt64" /> that is equal to the numeric value of this <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06000DA8 RID: 3496 RVA: 0x00045EBE File Offset: 0x000440BE
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> that is equal to the numeric value of this <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06000DA9 RID: 3497 RVA: 0x00045ECB File Offset: 0x000440CB
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> that contains the value of this <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06000DAA RID: 3498 RVA: 0x00045ED8 File Offset: 0x000440D8
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> that is equal to the numeric value of this <see cref="T:System.Data.SqlTypes.SqlString" />..</returns>
		// Token: 0x06000DAB RID: 3499 RVA: 0x00045EE5 File Offset: 0x000440E5
		public SqlSingle ToSqlSingle()
		{
			return (SqlSingle)this;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlString" /> structure to <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure whose <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> is the <see langword="Guid" /> represented by this <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</returns>
		// Token: 0x06000DAC RID: 3500 RVA: 0x00045EF2 File Offset: 0x000440F2
		public SqlGuid ToSqlGuid()
		{
			return (SqlGuid)this;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00045EFF File Offset: 0x000440FF
		private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			if ((compareOptions & SqlString.s_iValidSqlCompareOptionMask) != compareOptions)
			{
				throw new ArgumentOutOfRangeException("compareOptions");
			}
		}

		/// <summary>Gets the <see cref="T:System.Globalization.CompareOptions" /> enumeration equilvalent of the specified <see cref="T:System.Data.SqlTypes.SqlCompareOptions" /> value.</summary>
		/// <param name="compareOptions">A <see cref="T:System.Data.SqlTypes.SqlCompareOptions" /> value that describes the comparison options for this <see cref="T:System.Data.SqlTypes.SqlString" /> structure. </param>
		/// <returns>A <see langword="CompareOptions" /> value that corresponds to the <see langword="SqlCompareOptions" /> for this <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</returns>
		// Token: 0x06000DAE RID: 3502 RVA: 0x00045F18 File Offset: 0x00044118
		public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			CompareOptions compareOptions2 = CompareOptions.None;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			if ((compareOptions & (SqlCompareOptions.BinarySort | SqlCompareOptions.BinarySort2)) != SqlCompareOptions.None)
			{
				throw ADP.ArgumentOutOfRange("compareOptions");
			}
			if ((compareOptions & SqlCompareOptions.IgnoreCase) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreCase;
			}
			if ((compareOptions & SqlCompareOptions.IgnoreNonSpace) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreNonSpace;
			}
			if ((compareOptions & SqlCompareOptions.IgnoreKanaType) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreKanaType;
			}
			if ((compareOptions & SqlCompareOptions.IgnoreWidth) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreWidth;
			}
			return compareOptions2;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00045F68 File Offset: 0x00044168
		private bool FBinarySort()
		{
			return !this.IsNull && (this.m_flag & (SqlCompareOptions.BinarySort | SqlCompareOptions.BinarySort2)) > SqlCompareOptions.None;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00045F84 File Offset: 0x00044184
		private static int CompareBinary(SqlString x, SqlString y)
		{
			byte[] bytes = SqlString.s_unicodeEncoding.GetBytes(x.m_value);
			byte[] bytes2 = SqlString.s_unicodeEncoding.GetBytes(y.m_value);
			int num = bytes.Length;
			int num2 = bytes2.Length;
			int num3 = (num < num2) ? num : num2;
			int i;
			for (i = 0; i < num3; i++)
			{
				if (bytes[i] < bytes2[i])
				{
					return -1;
				}
				if (bytes[i] > bytes2[i])
				{
					return 1;
				}
			}
			i = num3;
			int num4 = 32;
			if (num < num2)
			{
				while (i < num2)
				{
					int num5 = (int)bytes2[i + 1] << (int)(8 + bytes2[i]);
					if (num5 != num4)
					{
						if (num4 <= num5)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i += 2;
					}
				}
			}
			else
			{
				while (i < num)
				{
					int num5 = (int)bytes[i + 1] << (int)(8 + bytes[i]);
					if (num5 != num4)
					{
						if (num5 <= num4)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i += 2;
					}
				}
			}
			return 0;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0004605C File Offset: 0x0004425C
		private static int CompareBinary2(SqlString x, SqlString y)
		{
			string value = x.m_value;
			string value2 = y.m_value;
			int length = value.Length;
			int length2 = value2.Length;
			int num = (length < length2) ? length : length2;
			for (int i = 0; i < num; i++)
			{
				if (value[i] < value2[i])
				{
					return -1;
				}
				if (value[i] > value2[i])
				{
					return 1;
				}
			}
			char c = ' ';
			if (length < length2)
			{
				int i = num;
				while (i < length2)
				{
					if (value2[i] != c)
					{
						if (c <= value2[i])
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i++;
					}
				}
			}
			else
			{
				int i = num;
				while (i < length)
				{
					if (value[i] != c)
					{
						if (value[i] <= c)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i++;
					}
				}
			}
			return 0;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlString" /> object to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return Value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic) </returns>
		// Token: 0x06000DB2 RID: 3506 RVA: 0x00046130 File Offset: 0x00044330
		public int CompareTo(object value)
		{
			if (value is SqlString)
			{
				SqlString value2 = (SqlString)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlString));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlString" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlString" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlString" /> to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> in Visual Basic). </returns>
		// Token: 0x06000DB3 RID: 3507 RVA: 0x0004616C File Offset: 0x0004436C
		public int CompareTo(SqlString value)
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
				int num = SqlString.StringCompare(this, value);
				if (num < 0)
				{
					return -1;
				}
				if (num > 0)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlString.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlString" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>Equals will return <see langword="true" /> if the object is an instance of <see cref="T:System.Data.SqlTypes.SqlString" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000DB4 RID: 3508 RVA: 0x000461B4 File Offset: 0x000443B4
		public override bool Equals(object value)
		{
			if (!(value is SqlString))
			{
				return false;
			}
			SqlString y = (SqlString)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Gets the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000DB5 RID: 3509 RVA: 0x0004620C File Offset: 0x0004440C
		public override int GetHashCode()
		{
			if (this.IsNull)
			{
				return 0;
			}
			byte[] array;
			if (this.FBinarySort())
			{
				array = SqlString.s_unicodeEncoding.GetBytes(this.m_value.TrimEnd());
			}
			else
			{
				CompareInfo compareInfo;
				CompareOptions options;
				try
				{
					this.SetCompareInfo();
					compareInfo = this.m_cmpInfo;
					options = SqlString.CompareOptionsFromSqlCompareOptions(this.m_flag);
				}
				catch (ArgumentException)
				{
					compareInfo = CultureInfo.InvariantCulture.CompareInfo;
					options = CompareOptions.None;
				}
				array = compareInfo.GetSortKey(this.m_value.TrimEnd(), options).KeyData;
			}
			return SqlBinary.HashByteArray(array, array.Length);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>An <see langword="XmlSchema" />.</returns>
		// Token: 0x06000DB6 RID: 3510 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader" />
		///     </param>
		// Token: 0x06000DB7 RID: 3511 RVA: 0x000462A0 File Offset: 0x000444A0
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = reader.ReadElementString();
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter" />
		///     </param>
		// Token: 0x06000DB8 RID: 3512 RVA: 0x000462EB File Offset: 0x000444EB
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(this.m_value);
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003E45F File Offset: 0x0003C65F
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04000442 RID: 1090
		private string m_value;

		// Token: 0x04000443 RID: 1091
		private CompareInfo m_cmpInfo;

		// Token: 0x04000444 RID: 1092
		private int m_lcid;

		// Token: 0x04000445 RID: 1093
		private SqlCompareOptions m_flag;

		// Token: 0x04000446 RID: 1094
		private bool m_fNotNull;

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</summary>
		// Token: 0x04000447 RID: 1095
		public static readonly SqlString Null = new SqlString(true);

		// Token: 0x04000448 RID: 1096
		internal static readonly UnicodeEncoding s_unicodeEncoding = new UnicodeEncoding();

		/// <summary>Specifies that <see cref="T:System.Data.SqlTypes.SqlString" /> comparisons should ignore case.</summary>
		// Token: 0x04000449 RID: 1097
		public static readonly int IgnoreCase = 1;

		/// <summary>Specifies that the string comparison must ignore the character width. </summary>
		// Token: 0x0400044A RID: 1098
		public static readonly int IgnoreWidth = 16;

		/// <summary>Specifies that the string comparison must ignore non-space combining characters, such as diacritics. </summary>
		// Token: 0x0400044B RID: 1099
		public static readonly int IgnoreNonSpace = 2;

		/// <summary>Specifies that the string comparison must ignore the Kana type. </summary>
		// Token: 0x0400044C RID: 1100
		public static readonly int IgnoreKanaType = 8;

		/// <summary>Specifies that sorts should be based on a characters numeric value instead of its alphabetical value.</summary>
		// Token: 0x0400044D RID: 1101
		public static readonly int BinarySort = 32768;

		/// <summary>Specifies that sorts should be based on a character's numeric value instead of its alphabetical value.</summary>
		// Token: 0x0400044E RID: 1102
		public static readonly int BinarySort2 = 16384;

		// Token: 0x0400044F RID: 1103
		private static readonly SqlCompareOptions s_iDefaultFlag = SqlCompareOptions.IgnoreCase | SqlCompareOptions.IgnoreKanaType | SqlCompareOptions.IgnoreWidth;

		// Token: 0x04000450 RID: 1104
		private static readonly CompareOptions s_iValidCompareOptionMask = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth;

		// Token: 0x04000451 RID: 1105
		internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask = SqlCompareOptions.IgnoreCase | SqlCompareOptions.IgnoreNonSpace | SqlCompareOptions.IgnoreKanaType | SqlCompareOptions.IgnoreWidth | SqlCompareOptions.BinarySort | SqlCompareOptions.BinarySort2;

		// Token: 0x04000452 RID: 1106
		internal static readonly int s_lcidUSEnglish = 1033;

		// Token: 0x04000453 RID: 1107
		private static readonly int s_lcidBinary = 33280;
	}
}
