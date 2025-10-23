using System;

namespace System.Globalization
{
	/// <summary>Defines the Unicode category of a character.</summary>
	// Token: 0x02000599 RID: 1433
	public enum UnicodeCategory
	{
		/// <summary>Uppercase letter. Signified by the Unicode designation "Lu" (letter, uppercase). The value is 0.</summary>
		// Token: 0x040016FA RID: 5882
		UppercaseLetter,
		/// <summary>Lowercase letter. Signified by the Unicode designation "Ll" (letter, lowercase). The value is 1.</summary>
		// Token: 0x040016FB RID: 5883
		LowercaseLetter,
		/// <summary>Titlecase letter. Signified by the Unicode designation "Lt" (letter, titlecase). The value is 2.</summary>
		// Token: 0x040016FC RID: 5884
		TitlecaseLetter,
		/// <summary>Modifier letter character, which is free-standing spacing character that indicates modifications of a preceding letter. Signified by the Unicode designation "Lm" (letter, modifier). The value is 3.</summary>
		// Token: 0x040016FD RID: 5885
		ModifierLetter,
		/// <summary>Letter that is not an uppercase letter, a lowercase letter, a titlecase letter, or a modifier letter. Signified by the Unicode designation "Lo" (letter, other). The value is 4.</summary>
		// Token: 0x040016FE RID: 5886
		OtherLetter,
		/// <summary>Nonspacing character that indicates modifications of a base character. Signified by the Unicode designation "Mn" (mark, nonspacing). The value is 5.</summary>
		// Token: 0x040016FF RID: 5887
		NonSpacingMark,
		/// <summary>Spacing character that indicates modifications of a base character and affects the width of the glyph for that base character. Signified by the Unicode designation "Mc" (mark, spacing combining). The value is 6.</summary>
		// Token: 0x04001700 RID: 5888
		SpacingCombiningMark,
		/// <summary>Enclosing mark character, which is a nonspacing combining character that surrounds all previous characters up to and including a base character. Signified by the Unicode designation "Me" (mark, enclosing). The value is 7.</summary>
		// Token: 0x04001701 RID: 5889
		EnclosingMark,
		/// <summary>Decimal digit character, that is, a character in the range 0 through 9. Signified by the Unicode designation "Nd" (number, decimal digit). The value is 8.</summary>
		// Token: 0x04001702 RID: 5890
		DecimalDigitNumber,
		/// <summary>Number represented by a letter, instead of a decimal digit, for example, the Roman numeral for five, which is "V". The indicator is signified by the Unicode designation "Nl" (number, letter). The value is 9.</summary>
		// Token: 0x04001703 RID: 5891
		LetterNumber,
		/// <summary>Number that is neither a decimal digit nor a letter number, for example, the fraction 1/2. The indicator is signified by the Unicode designation "No" (number, other). The value is 10.</summary>
		// Token: 0x04001704 RID: 5892
		OtherNumber,
		/// <summary>Space character, which has no glyph but is not a control or format character. Signified by the Unicode designation "Zs" (separator, space). The value is 11.</summary>
		// Token: 0x04001705 RID: 5893
		SpaceSeparator,
		/// <summary>Character that is used to separate lines of text. Signified by the Unicode designation "Zl" (separator, line). The value is 12.</summary>
		// Token: 0x04001706 RID: 5894
		LineSeparator,
		/// <summary>Character used to separate paragraphs. Signified by the Unicode designation "Zp" (separator, paragraph). The value is 13.</summary>
		// Token: 0x04001707 RID: 5895
		ParagraphSeparator,
		/// <summary>Control code character, with a Unicode value of U+007F or in the range U+0000 through U+001F or U+0080 through U+009F. Signified by the Unicode designation "Cc" (other, control). The value is 14.</summary>
		// Token: 0x04001708 RID: 5896
		Control,
		/// <summary>Format character that affects the layout of text or the operation of text processes, but is not normally rendered. Signified by the Unicode designation "Cf" (other, format). The value is 15.</summary>
		// Token: 0x04001709 RID: 5897
		Format,
		/// <summary>High surrogate or a low surrogate character. Surrogate code values are in the range U+D800 through U+DFFF. Signified by the Unicode designation "Cs" (other, surrogate). The value is 16.</summary>
		// Token: 0x0400170A RID: 5898
		Surrogate,
		/// <summary>Private-use character, with a Unicode value in the range U+E000 through U+F8FF. Signified by the Unicode designation "Co" (other, private use). The value is 17.</summary>
		// Token: 0x0400170B RID: 5899
		PrivateUse,
		/// <summary>Connector punctuation character that connects two characters. Signified by the Unicode designation "Pc" (punctuation, connector). The value is 18.</summary>
		// Token: 0x0400170C RID: 5900
		ConnectorPunctuation,
		/// <summary>Dash or hyphen character. Signified by the Unicode designation "Pd" (punctuation, dash). The value is 19.</summary>
		// Token: 0x0400170D RID: 5901
		DashPunctuation,
		/// <summary>Opening character of one of the paired punctuation marks, such as parentheses, square brackets, and braces. Signified by the Unicode designation "Ps" (punctuation, open). The value is 20.</summary>
		// Token: 0x0400170E RID: 5902
		OpenPunctuation,
		/// <summary>Closing character of one of the paired punctuation marks, such as parentheses, square brackets, and braces. Signified by the Unicode designation "Pe" (punctuation, close). The value is 21.</summary>
		// Token: 0x0400170F RID: 5903
		ClosePunctuation,
		/// <summary>Opening or initial quotation mark character. Signified by the Unicode designation "Pi" (punctuation, initial quote). The value is 22.</summary>
		// Token: 0x04001710 RID: 5904
		InitialQuotePunctuation,
		/// <summary>Closing or final quotation mark character. Signified by the Unicode designation "Pf" (punctuation, final quote). The value is 23.</summary>
		// Token: 0x04001711 RID: 5905
		FinalQuotePunctuation,
		/// <summary>Punctuation character that is not a connector, a dash, open punctuation, close punctuation, an initial quote, or a final quote. Signified by the Unicode designation "Po" (punctuation, other). The value is 24.</summary>
		// Token: 0x04001712 RID: 5906
		OtherPunctuation,
		/// <summary>Mathematical symbol character, such as "+" or "= ". Signified by the Unicode designation "Sm" (symbol, math). The value is 25.</summary>
		// Token: 0x04001713 RID: 5907
		MathSymbol,
		/// <summary>Currency symbol character. Signified by the Unicode designation "Sc" (symbol, currency). The value is 26.</summary>
		// Token: 0x04001714 RID: 5908
		CurrencySymbol,
		/// <summary>Modifier symbol character, which indicates modifications of surrounding characters. For example, the fraction slash indicates that the number to the left is the numerator and the number to the right is the denominator. The indicator is signified by the Unicode designation "Sk" (symbol, modifier). The value is 27.</summary>
		// Token: 0x04001715 RID: 5909
		ModifierSymbol,
		/// <summary>Symbol character that is not a mathematical symbol, a currency symbol or a modifier symbol. Signified by the Unicode designation "So" (symbol, other). The value is 28.</summary>
		// Token: 0x04001716 RID: 5910
		OtherSymbol,
		/// <summary>Character that is not assigned to any Unicode category. Signified by the Unicode designation "Cn" (other, not assigned). The value is 29.</summary>
		// Token: 0x04001717 RID: 5911
		OtherNotAssigned
	}
}
