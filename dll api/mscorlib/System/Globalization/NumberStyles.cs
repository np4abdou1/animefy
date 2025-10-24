﻿using System;

namespace System.Globalization
{
	/// <summary>Determines the styles permitted in numeric string arguments that are passed to the <see langword="Parse" /> and <see langword="TryParse" /> methods of the integral and floating-point numeric types.</summary>
	// Token: 0x0200058A RID: 1418
	[Flags]
	public enum NumberStyles
	{
		/// <summary>Indicates that no style elements, such as leading or trailing white space, thousands separators, or a decimal separator, can be present in the parsed string. The string to be parsed must consist of integral decimal digits only. </summary>
		// Token: 0x040016A5 RID: 5797
		None = 0,
		/// <summary>Indicates that leading white-space characters can be present in the parsed string. Valid white-space characters have the Unicode values U+0009, U+000A, U+000B, U+000C, U+000D, and U+0020. Note that this is a subset of the characters for which the <see cref="M:System.Char.IsWhiteSpace(System.Char)" /> method returns <see langword="true" />.</summary>
		// Token: 0x040016A6 RID: 5798
		AllowLeadingWhite = 1,
		/// <summary>Indicates that trailing white-space characters can be present in the parsed string. Valid white-space characters have the Unicode values U+0009, U+000A, U+000B, U+000C, U+000D, and U+0020. Note that this is a subset of the characters for which the <see cref="M:System.Char.IsWhiteSpace(System.Char)" /> method returns <see langword="true" />.</summary>
		// Token: 0x040016A7 RID: 5799
		AllowTrailingWhite = 2,
		/// <summary>Indicates that the numeric string can have a leading sign. Valid leading sign characters are determined by the <see cref="P:System.Globalization.NumberFormatInfo.PositiveSign" /> and <see cref="P:System.Globalization.NumberFormatInfo.NegativeSign" /> properties.</summary>
		// Token: 0x040016A8 RID: 5800
		AllowLeadingSign = 4,
		/// <summary>Indicates that the numeric string can have a trailing sign. Valid trailing sign characters are determined by the <see cref="P:System.Globalization.NumberFormatInfo.PositiveSign" /> and <see cref="P:System.Globalization.NumberFormatInfo.NegativeSign" /> properties.</summary>
		// Token: 0x040016A9 RID: 5801
		AllowTrailingSign = 8,
		/// <summary>Indicates that the numeric string can have one pair of parentheses enclosing the number. The parentheses indicate that the string to be parsed represents a negative number.</summary>
		// Token: 0x040016AA RID: 5802
		AllowParentheses = 16,
		/// <summary>Indicates that the numeric string can have a decimal point. If the <see cref="T:System.Globalization.NumberStyles" /> value includes the <see cref="F:System.Globalization.NumberStyles.AllowCurrencySymbol" /> flag and the parsed string includes a currency symbol, the decimal separator character is determined by the <see cref="P:System.Globalization.NumberFormatInfo.CurrencyDecimalSeparator" /> property. Otherwise, the decimal separator character is determined by the <see cref="P:System.Globalization.NumberFormatInfo.NumberDecimalSeparator" /> property.</summary>
		// Token: 0x040016AB RID: 5803
		AllowDecimalPoint = 32,
		/// <summary>Indicates that the numeric string can have group separators, such as symbols that separate hundreds from thousands. If the <see cref="T:System.Globalization.NumberStyles" /> value includes the <see cref="F:System.Globalization.NumberStyles.AllowCurrencySymbol" /> flag and the string to be parsed includes a currency symbol, the valid group separator character is determined by the <see cref="P:System.Globalization.NumberFormatInfo.CurrencyGroupSeparator" /> property,  and the number of digits in each group is determined by the <see cref="P:System.Globalization.NumberFormatInfo.CurrencyGroupSizes" /> property. Otherwise, the valid group separator character is determined by the <see cref="P:System.Globalization.NumberFormatInfo.NumberGroupSeparator" /> property, and the number of digits in each group is determined by the <see cref="P:System.Globalization.NumberFormatInfo.NumberGroupSizes" /> property.</summary>
		// Token: 0x040016AC RID: 5804
		AllowThousands = 64,
		/// <summary>Indicates that the numeric string can be in exponential notation. The <see cref="F:System.Globalization.NumberStyles.AllowExponent" /> flag allows the parsed string to contain an exponent that begins with the "E" or "e" character and that is followed by an optional positive or negative sign and an integer. In other words, it successfully parses strings in the form nnnExx, nnnE+xx, and nnnE-xx. It does not allow a decimal separator or sign in the significand or mantissa; to allow these elements in the string to be parsed, use the <see cref="F:System.Globalization.NumberStyles.AllowDecimalPoint" /> and <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" /> flags, or use a composite style that includes these individual flags.</summary>
		// Token: 0x040016AD RID: 5805
		AllowExponent = 128,
		/// <summary>Indicates that the numeric string can contain a currency symbol. Valid currency symbols are determined by the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> property.</summary>
		// Token: 0x040016AE RID: 5806
		AllowCurrencySymbol = 256,
		/// <summary>Indicates that the numeric string represents a hexadecimal value. Valid hexadecimal values include the numeric digits 0-9 and the hexadecimal digits A-F and a-f. Strings that are parsed using this style cannot be prefixed with "0x" or "&amp;h". A string that is parsed with the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> style will always be interpreted as a hexadecimal value. The only flags that can be combined with <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> are <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" /> and <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />. The <see cref="T:System.Globalization.NumberStyles" /> enumeration includes a composite style, <see cref="F:System.Globalization.NumberStyles.HexNumber" />, that consists of these three flags.</summary>
		// Token: 0x040016AF RID: 5807
		AllowHexSpecifier = 512,
		/// <summary>Indicates that the <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />, and <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" /> styles are used. This is a composite number style.</summary>
		// Token: 0x040016B0 RID: 5808
		Integer = 7,
		/// <summary>Indicates that the <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />, and <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> styles are used. This is a composite number style.</summary>
		// Token: 0x040016B1 RID: 5809
		HexNumber = 515,
		/// <summary>Indicates that the <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingSign" />, <see cref="F:System.Globalization.NumberStyles.AllowDecimalPoint" />, and <see cref="F:System.Globalization.NumberStyles.AllowThousands" /> styles are used. This is a composite number style.</summary>
		// Token: 0x040016B2 RID: 5810
		Number = 111,
		/// <summary>Indicates that the <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" />, <see cref="F:System.Globalization.NumberStyles.AllowDecimalPoint" />, and <see cref="F:System.Globalization.NumberStyles.AllowExponent" /> styles are used. This is a composite number style.</summary>
		// Token: 0x040016B3 RID: 5811
		Float = 167,
		/// <summary>Indicates that all styles except <see cref="F:System.Globalization.NumberStyles.AllowExponent" /> and <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> are used. This is a composite number style.</summary>
		// Token: 0x040016B4 RID: 5812
		Currency = 383,
		/// <summary>Indicates that all styles except <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> are used. This is a composite number style.</summary>
		// Token: 0x040016B5 RID: 5813
		Any = 511
	}
}
